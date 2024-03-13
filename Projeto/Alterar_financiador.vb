Public Class Alterar_financiador
    Private SQL As New SQLControl

    Private Sub CarregarBox()
        cbxTipo.Items.Clear()
        SQL.Execute("SELECT DISTINCT tipo FROM Financiador_tipo;")
        'Verificar se ocorrem erros antes de carregar
        If SQL.VerExceções(True) Then Exit Sub

        For Each i As DataRow In SQL.Tabelas.Rows
            cbxTipo.Items.Add(i("tipo").ToString)
        Next
    End Sub

    Private Sub DenunciarFinanciadores()
        'Dá refresh e limpa a lista de Financiadores
        LBFinanciadores.Items.Clear()

        'Adicionar Parâmetros e dá Execute
        SQL.AdicionarParametros("@IDF", "%" & txtPesquisa.Text & "%")
        SQL.Execute("SELECT IDF " &
                    "FROM Financiador " &
                    "WHERE IDF LIKE @IDF " &
                    "ORDER BY IDF ASC;")

        'Verifica se tem erros e dá report, caso tenha cancela a operação
        If SQL.VerExceções(True) Then Exit Sub

        'Return da Lista de financiadores
        For Each i As DataRow In SQL.Tabelas.Rows
            LBFinanciadores.Items.Add(i("IDF"))
        Next
    End Sub

    Private Sub ValoresFinanciadores(IDF As String)
        SQL.AdicionarParametros("@item", IDF)
        SQL.Execute("SELECT TOP 1 * " &
                    "FROM Financiador " &
                    "WHERE IDF LIKE @item;")

        If SQL.Contador < 1 Then Exit Sub

        For Each i As DataRow In SQL.Tabelas.Rows
            TBIDF.Text = i("IDF")
        Next
    End Sub

    Private Sub Alterar()
        SQL.AdicionarParametros("@Nome", TBNome.Text)
        SQL.AdicionarParametros("@QuantidadeDoada", TBQuantidadeDoada.Text)
        SQL.AdicionarParametros("@IDF", TBIDF.Text)

        SQL.Execute("UPDATE Financiador " &
                    "SET nome=@Nome, quantidade_doada=@QuantidadeDoada " &
                    "WHERE IDF=@IDF")
        SQL.AdicionarParametros("@Tipo", cbxTipo.Text)
        SQL.AdicionarParametros("@IDF", TBIDF.Text)
        SQL.Execute("UPDATE Financiador_tipo " &
                    "SET tipo=@Tipo " &
                    "WHERE IDF=@IDF")

        If SQL.VerExceções(True) Then Exit Sub

        MsgBox("Financiador Alterado com Sucesso;")

    End Sub

    Private Sub CarregarAlteração(sender As Object, e As EventArgs) Handles MyBase.Load
        MdiParent = Form1
        DenunciarFinanciadores()
        CarregarBox()
    End Sub

    Private Sub txtPesquisa_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPesquisa.KeyDown
        If e.KeyCode = Keys.Enter Then
            DenunciarFinanciadores()
            e.Handled = True
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub LBMembros_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LBFinanciadores.SelectedIndexChanged
        ValoresFinanciadores(LBFinanciadores.Text)
    End Sub

    Private Sub bAlterar_Click(sender As Object, e As EventArgs) Handles bAlterar.Click
        Alterar()
    End Sub
    Private Sub CamposdeTexto(sender As Object, e As EventArgs) Handles TBNome.TextChanged, TBQuantidadeDoada.TextChanged, TBIDF.TextChanged, cbxTipo.TextChanged
        'Check de Validação
        If Not String.IsNullOrWhiteSpace(TBNome.Text) AndAlso Not String.IsNullOrWhiteSpace(TBQuantidadeDoada.Text) AndAlso Not String.IsNullOrWhiteSpace(TBIDF.Text) AndAlso Not String.IsNullOrWhiteSpace(cbxTipo.Text) Then
            bAlterar.Enabled = True
        Else
            bAlterar.Enabled = False
        End If
    End Sub

End Class