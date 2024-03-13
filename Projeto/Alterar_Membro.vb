Public Class Alterar_Membro
    Private SQL As New SQLControl

    Private Sub DenunciarMembros()
        'Dá refresh e limpa a lista de membros
        LBMembros.Items.Clear()

        'Adicionar Parâmetros e dá Execute
        SQL.AdicionarParametros("@IDM", "%" & txtPesquisa.Text & "%")
        SQL.Execute("SELECT IDM " &
                    "FROM Membros " &
                    "WHERE IDM LIKE @IDM " &
                    "ORDER BY IDM ASC;")

        'Verifica se tem erros e dá report, caso tenha cancela a operação
        If SQL.VerExceções(True) Then Exit Sub

        'Return da Lista de Membros
        For Each i As DataRow In SQL.Tabelas.Rows
            LBMembros.Items.Add(i("IDM"))
        Next
    End Sub

    Private Sub ValoresMembros(IDM As String)
        SQL.AdicionarParametros("@item", IDM)
        SQL.Execute("SELECT TOP 1 * " &
                    "FROM Membros " &
                    "WHERE IDM LIKE @item;")

        If SQL.Contador < 1 Then Exit Sub

        For Each i As DataRow In SQL.Tabelas.Rows
            TBIDM.Text = i("IDM")
        Next
    End Sub

    Private Sub Alterar()
        SQL.AdicionarParametros("@per_tempo_dedicado", TBTempoDedicado.Text)
        SQL.AdicionarParametros("@per_afetacao_projeto", TBAfetaçãoProjeto.Text)
        SQL.AdicionarParametros("@tempo_total", TBTempoTotal.Text)
        SQL.AdicionarParametros("@IDM", TBIDM.Text)

        SQL.Execute("UPDATE membros " &
                    "SET per_afetacao_projeto=@per_afetacao_projeto, per_tempo_dedicado=@per_tempo_dedicado, tempo_total=@tempo_total " &
                    "WHERE IDM=@IDM")
        If SQL.VerExceções(True) Then Exit Sub
        MsgBox("Membro Alterado com Sucesso;")

    End Sub

    Private Sub CarregarAlteração(sender As Object, e As EventArgs) Handles MyBase.Load
        MdiParent = Form1
        DenunciarMembros()
    End Sub

    Private Sub txtPesquisa_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPesquisa.KeyDown
        If e.KeyCode = Keys.Enter Then
            DenunciarMembros()
            e.Handled = True
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub LBMembros_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LBMembros.SelectedIndexChanged
        ValoresMembros(LBMembros.Text)
    End Sub

    Private Sub bAlterar_Click(sender As Object, e As EventArgs) Handles bAlterar.Click
        Alterar()
    End Sub
    Private Sub CamposdeTexto(sender As Object, e As EventArgs) Handles TBTempoDedicado.TextChanged, TBAfetaçãoProjeto.TextChanged, TBTempoTotal.TextChanged, TBIDM.TextChanged
        'Check de Validação
        If Not String.IsNullOrWhiteSpace(TBTempoDedicado.Text) AndAlso Not String.IsNullOrWhiteSpace(TBAfetaçãoProjeto.Text) AndAlso Not String.IsNullOrWhiteSpace(TBTempoTotal.Text) AndAlso Not String.IsNullOrWhiteSpace(TBIDM.Text) AndAlso Not TBTempoTotal.Text = "hh:mm:ss" Then
            bAlterar.Enabled = True
        Else
            bAlterar.Enabled = False
        End If
    End Sub
End Class