Public Class Eliminar_Programa
    Private SQL As New SQLControl
    Private Sub CarregarDelete(sender As Object, e As EventArgs) Handles MyBase.Load
        MdiParent = Form1
        DenunciarProgramas()
    End Sub

    Private Sub DenunciarProgramas()
        'Dá refresh e limpa a lista de programas
        CLBProgramas.Items.Clear()

        'Adicionar Parâmetros e dá Execute
        SQL.AdicionarParametros("@IDFP", "%" & txtPesquisa.Text & "%")
        SQL.Execute("SELECT IDFP " &
                    "FROM Programas " &
                    "WHERE IDFP LIKE @IDFP " &
                    "ORDER BY IDFP ASC;")

        'Verifica se tem erros e dá report, caso tenha cancela a operação
        If SQL.VerExceções(True) Then Exit Sub

        'Return da Lista de programas
        For Each i As DataRow In SQL.Tabelas.Rows
            CLBProgramas.Items.Add(i("IDFP"))
        Next
    End Sub

    Private Sub Eliminar()
        If MsgBox("Esta ação não terá retorno, tem a certeza que quer continuar?", MsgBoxStyle.YesNo, "Confirmação de Operação") = MsgBoxResult.Yes Then
            Dim c As Integer
            Dim Elim As String = ""

            For Each i As String In CLBProgramas.CheckedItems
                SQL.AdicionarParametros("@IDFP" & c, i)
                Elim += "DELETE FROM Programas WHERE IDFP=@IDFP" & c & ";"
                c += 1
            Next

            SQL.Execute(Elim)

            If SQL.VerExceções(True) Then Exit Sub

            MsgBox("Os programas selecionados foram eliminados com sucesso")

            DenunciarProgramas()
        End If
    End Sub

    Private Sub txtPesquisa_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPesquisa.KeyDown
        If e.KeyCode = Keys.Enter Then
            DenunciarProgramas()
            e.Handled = True
            e.SuppressKeyPress = True
        End If

    End Sub

    Private Sub bEliminar_Click(sender As Object, e As EventArgs) Handles bEliminar.Click
        If CLBProgramas.CheckedItems.Count > 0 Then Eliminar()
    End Sub
End Class