Public Class Alterar_Entidades
    Private SQL As New SQLControl

    Private Sub DenunciarEntidades()
        'Dá refresh e limpa a lista de Entidades
        LBEntidades.Items.Clear()

        'Adicionar Parâmetros e dá Execute
        SQL.AdicionarParametros("@IDE", "%" & txtPesquisa.Text & "%")
        SQL.Execute("SELECT IDE " &
                    "FROM Entidades " &
                    "WHERE IDE LIKE @IDE " &
                    "ORDER BY IDE ASC;")

        'Verifica se tem erros e dá report, caso tenha cancela a operação
        If SQL.VerExceções(True) Then Exit Sub

        'Return da Lista de Entidades
        For Each i As DataRow In SQL.Tabelas.Rows
            LBEntidades.Items.Add(i("IDE"))
        Next
    End Sub

    Private Sub ValoresEntidades(IDE As String)
        SQL.AdicionarParametros("@item", IDE)
        SQL.Execute("SELECT TOP 1 * " &
                    "FROM Entidades " &
                    "WHERE IDE LIKE @item;")

        If SQL.Contador < 1 Then Exit Sub

        For Each i As DataRow In SQL.Tabelas.Rows
            TBIDE.Text = i("IDE")
        Next
    End Sub

    Private Sub Alterar()
        SQL.AdicionarParametros("@InvestigadorResponsável", TBInvestigadorR.Text)
        SQL.AdicionarParametros("@InstituiçãoResponsável", TBInstituiçãoR.Text)
        SQL.AdicionarParametros("@IDE", TBIDE.Text)

        SQL.Execute("UPDATE Entidades " &
                    "SET Investigador_responsavel=@InvestigadorResponsável, instituicao_responsavel=@InstituiçãoResponsável " &
                    "WHERE IDE=@IDE")
        If SQL.VerExceções(True) Then Exit Sub
        MsgBox("Entidade Alterada com Sucesso;")

    End Sub

    Private Sub CarregarAlteração(sender As Object, e As EventArgs) Handles MyBase.Load
        MdiParent = Form1
        DenunciarEntidades()
    End Sub

    Private Sub txtPesquisa_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPesquisa.KeyDown
        If e.KeyCode = Keys.Enter Then
            DenunciarEntidades()
            e.Handled = True
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub LBMembros_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LBEntidades.SelectedIndexChanged
        ValoresEntidades(LBEntidades.Text)
    End Sub

    Private Sub bAlterar_Click(sender As Object, e As EventArgs) Handles bAlterar.Click
        Alterar()
        TBInvestigadorR.Clear()
        TBInstituiçãoR.Clear()
        TBIDE.Clear()
    End Sub
    Private Sub CamposdeTexto(sender As Object, e As EventArgs) Handles TBInvestigadorR.TextChanged, TBInstituiçãoR.TextChanged
        'Check de Validação
        If Not String.IsNullOrWhiteSpace(TBInvestigadorR.Text) AndAlso Not String.IsNullOrWhiteSpace(TBInstituiçãoR.Text) AndAlso Not String.IsNullOrWhiteSpace(TBIDE.Text) Then
            bAlterar.Enabled = True
        Else
            bAlterar.Enabled = False
        End If
    End Sub
End Class