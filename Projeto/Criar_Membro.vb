Imports System.Runtime.Remoting.Contexts
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Criar_Membro

    Private SQL As New SQLControl

    Private Sub CarregarMembros(sender As Object, e As EventArgs) Handles MyBase.Load
        MdiParent = Form1
        CarregarBox()
    End Sub

    Private Sub IntroduzirMembro()
        'Adicionar Parâmetros e dar execute
        SQL.AdicionarParametros("@TempoDedicado", txtTempoDedicado.Text)
        SQL.AdicionarParametros("@AfetaçãoProjeto", txtAfetaçãoProjeto.Text)
        SQL.AdicionarParametros("@TempoTotal", txtTempoTotal.Text)
        SQL.AdicionarParametros("@MembroDI", cbDI.Checked)
        SQL.AdicionarParametros("@funcao", cbxMembro_DI_funcao.Text)

        If cbDI.Checked = True Then
            SQL.Execute("INSERT INTO membros (IDM, per_tempo_dedicado, per_afetacao_projeto, tempo_total)" &
                        "VALUES ((SELECT ISNULL(MAX(IDM)+1,1) FROM membros), @TempoDedicado, @AfetaçãoProjeto, @TempoTotal)")
            SQL.Execute("INSERT INTO membros_DI (IDM, numero_funcionario, ORCID)" &
                        "VALUES ((SELECT ISNULL(MAX(IDM),1) FROM membros), (SELECT ISNULL(MAX(numero_funcionario)+100,1) FROM membros_DI), (SELECT ISNULL(MAX(ORCID)+1,1) FROM membros_DI))")
            SQL.AdicionarParametros("@funcao", cbxMembro_DI_funcao.Text)
            SQL.Execute("INSERT INTO membros_DI_funcao (IDM, funcao) " &
                        "VALUES ((SELECT ISNULL(MAX(IDM),1) FROM membros), @funcao)")
        ElseIf cbDI.Checked = False Then
            SQL.Execute("INSERT INTO membros (IDM, per_tempo_dedicado, per_afetacao_projeto, tempo_total)" &
                        "VALUES ((SELECT ISNULL(MAX(IDM)+1,1) FROM membros), @TempoDedicado, @AfetaçãoProjeto, @TempoTotal)")
        End If

        If SQL.VerExceções(True) Then Exit Sub

        If SQL.Tabelas.Rows.Count > 0 Then
            Dim i As DataRow = SQL.Tabelas.Rows(0)
            MsgBox(i("IDM").ToString)
        End If

        MsgBox("Membro Criado com Sucesso;")

    End Sub

    Private Sub CarregarBox()
        cbxMembro_DI_funcao.Items.Clear()
        SQL.Execute("SELECT DISTINCT funcao FROM Membros_DI_funcao;")
        'Verificar se ocorrem erros antes de carregar
        If SQL.VerExceções(True) Then Exit Sub

        For Each i As DataRow In SQL.Tabelas.Rows
            cbxMembro_DI_funcao.Items.Add(i("funcao").ToString)
        Next
    End Sub

    Private Sub CamposdeTexto(sender As Object, e As EventArgs) Handles txtTempoDedicado.TextChanged, txtAfetaçãoProjeto.TextChanged, txtTempoTotal.TextChanged, cbDI.CheckedChanged, cbxMembro_DI_funcao.TextChanged
        'Check de Validação
        If Not String.IsNullOrWhiteSpace(txtTempoDedicado.Text) AndAlso Not String.IsNullOrWhiteSpace(txtAfetaçãoProjeto.Text) AndAlso Not String.IsNullOrWhiteSpace(txtTempoTotal.Text) AndAlso Not txtTempoTotal.Text = "hh:mm:ss" Then

            If cbDI.Checked Then
                cbxMembro_DI_funcao.Enabled = True

                If Not String.IsNullOrWhiteSpace(cbxMembro_DI_funcao.Text) Then
                    bCriar.Enabled = True
                Else
                    bCriar.Enabled = False
                End If
            End If

            If Not cbDI.Checked Then
                cbxMembro_DI_funcao.Enabled = False
                bCriar.Enabled = True
            End If

        Else
            bCriar.Enabled = False
        End If
    End Sub

    Private Sub bCriar_Click(sender As Object, e As EventArgs) Handles bCriar.Click
        IntroduzirMembro()
        txtAfetaçãoProjeto.Clear()
        txtTempoDedicado.Clear()
        txtTempoTotal.Clear()
        cbDI.Checked = False
        bCriar.Enabled = False
        cbxMembro_DI_funcao.SelectedIndex = -1
    End Sub
End Class