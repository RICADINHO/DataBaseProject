Public Class Eliminar_Entidade
    Private SQL As New SQLControl
    Private Sub CarregarDelete(sender As Object, e As EventArgs) Handles MyBase.Load
        MdiParent = Form1
        DenunciarEntidades()
    End Sub

    Private Sub DenunciarEntidades()
        'Dá refresh e limpa a lista de Entidades
        CLBEntidade.Items.Clear()

        'Adicionar Parâmetros e dá Execute
        SQL.AdicionarParametros("@IDFE", "%" & txtPesquisa.Text & "%")
        SQL.Execute("SELECT IDFE " &
                    "FROM Entidade " &
                    "WHERE IDFE LIKE @IDFE " &
                    "ORDER BY IDFE ASC;")

        'Verifica se tem erros e dá report, caso tenha cancela a operação
        If SQL.VerExceções(True) Then Exit Sub

        'Return da Lista de Entidades
        For Each i As DataRow In SQL.Tabelas.Rows
            CLBEntidade.Items.Add(i("IDFE"))
        Next
    End Sub

    Private Sub Eliminar()
        If MsgBox("Esta ação não terá retorno, tem a certeza que quer continuar?", MsgBoxStyle.YesNo, "Confirmação de Operação") = MsgBoxResult.Yes Then
            Dim c As Integer
            Dim Elim As String = ""

            For Each i As String In CLBEntidade.CheckedItems
                SQL.AdicionarParametros("@IDFE" & c, i)
                Elim += "DELETE FROM Entidade WHERE IDFE=@IDFE" & c & ";"
                c += 1
            Next

            SQL.Execute(Elim)

            If SQL.VerExceções(True) Then Exit Sub

            MsgBox("As entidades selecionadas foram eliminadas com sucesso")

            DenunciarEntidades()
        End If
    End Sub

    Private Sub txtPesquisa_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPesquisa.KeyDown
        If e.KeyCode = Keys.Enter Then
            DenunciarEntidades()
            e.Handled = True
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub bEliminar_Click(sender As Object, e As EventArgs) Handles bEliminar.Click
        If CLBEntidade.CheckedItems.Count > 0 Then Eliminar()
    End Sub

End Class