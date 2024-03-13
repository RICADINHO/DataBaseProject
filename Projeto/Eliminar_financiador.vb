Public Class Eliminar_financiador
    Private SQL As New SQLControl
    Private Sub CarregarDelete(sender As Object, e As EventArgs) Handles MyBase.Load
        MdiParent = Form1
        DenunciarFinanciadores()
    End Sub

    Private Sub DenunciarFinanciadores()
        'Dá refresh e limpa a lista de financiadores
        CLBFinanciadores.Items.Clear()

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
            CLBFinanciadores.Items.Add(i("IDF"))
        Next
    End Sub

    Private Sub Eliminar()
        If MsgBox("Esta ação não terá retorno, tem a certeza que quer continuar?", MsgBoxStyle.YesNo, "Confirmação de Operação") = MsgBoxResult.Yes Then
            Dim c As Integer
            Dim Elim As String = ""

            For Each i As String In CLBFinanciadores.CheckedItems
                SQL.AdicionarParametros("@IDF" & c, i)
                Elim += "DELETE FROM Financiador_tipo WHERE IDF = @IDF" & c & ";"
                Elim += "DELETE FROM Financiador WHERE IDF=@IDF" & c & ";"
                c += 1
            Next

            SQL.Execute(Elim)

            If SQL.VerExceções(True) Then Exit Sub

            MsgBox("Os financiadores selecionados foram eliminados com sucesso")

            DenunciarFinanciadores()
        End If
    End Sub

    Private Sub txtPesquisa_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPesquisa.KeyDown
        If e.KeyCode = Keys.Enter Then
            DenunciarFinanciadores()
            e.Handled = True
            e.SuppressKeyPress = True
        End If

    End Sub

    Private Sub bEliminar_Click(sender As Object, e As EventArgs) Handles bEliminar.Click
        If CLBFinanciadores.CheckedItems.Count > 0 Then Eliminar()
    End Sub
End Class