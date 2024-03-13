Public Class Criar_Entidades
    Private SQL As New SQLControl

    Private Sub CarregarEntidades(sender As Object, e As EventArgs) Handles MyBase.Load
        MdiParent = Form1
    End Sub

    Private Sub IntroduzirMembro()
        'Adicionar Parâmetros e dar execute
        SQL.AdicionarParametros("@InvestigadorResponsável", txtInvestigadorR.Text)
        SQL.AdicionarParametros("@InstituiçãoResponsável", txtInstituiçãoR.Text)

        SQL.Execute("INSERT INTO entidades (IDE, Investigador_responsavel, instituicao_responsavel)" &
                        "VALUES ((SELECT ISNULL(MAX(IDE)+1,1) FROM entidades), @InvestigadorResponsável, @InstituiçãoResponsável)")

        If SQL.VerExceções(True) Then Exit Sub

        If SQL.Tabelas.Rows.Count > 0 Then
            Dim i As DataRow = SQL.Tabelas.Rows(0)
            MsgBox(i("IDE").ToString)
        End If

        MsgBox("Entidade Criada com Sucesso;")

    End Sub

    Private Sub CamposdeTexto(sender As Object, e As EventArgs) Handles txtInvestigadorR.TextChanged, txtInstituiçãoR.TextChanged
        'Check de Validação
        If Not String.IsNullOrWhiteSpace(txtInvestigadorR.Text) AndAlso Not String.IsNullOrWhiteSpace(txtInstituiçãoR.Text) Then
            bCriar.Enabled = True
        Else
            bCriar.Enabled = False
        End If
    End Sub

    Private Sub bCriar_Click(sender As Object, e As EventArgs) Handles bCriar.Click
        IntroduzirMembro()
        txtInvestigadorR.Clear()
        txtInstituiçãoR.Clear()
        bCriar.Enabled = False
    End Sub


End Class