Public Class Eliminar_Membro
    Private SQL As New SQLControl
    Private Sub CarregarDelete(sender As Object, e As EventArgs) Handles MyBase.Load
        MdiParent = Form1
        DenunciarMembros()
    End Sub

    Private Sub DenunciarMembros()
        'Dá refresh e limpa a lista de membros
        CLBMembros.Items.Clear()

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
            CLBMembros.Items.Add(i("IDM"))
        Next
    End Sub

    Private Sub Eliminar()
        If MsgBox("Esta ação não terá retorno, tem a certeza que quer continuar?", MsgBoxStyle.YesNo, "Confirmação de Operação") = MsgBoxResult.Yes Then
            Dim c As Integer
            Dim Elim As String = ""


            For Each i As String In CLBMembros.CheckedItems
                SQL.Execute("SELECT IDM
                                    FROM membros
                                    WHERE IDM not in (
                                    SELECT membros.IDM
                                    FROM Membros_DI, membros
                                    WHERE membros.IDM = MEMBROS_DI.IDM)")

                SQL.AdicionarParametros("@IDM", i)

                For Each r As DataRow In SQL.Tabelas.Rows


                    If r("idm") = CInt(i) Then

                        'SQL.AdicionarParametros("@IDM" & c, i)
                        Elim += "DELETE FROM tem WHERE tem.IDM=@IDM;"
                        Elim += "DELETE FROM Membros WHERE Membros.IDM=@IDM;"
                        'Elim += "DELETE FROM Membros_DI WHERE Membros_DI.IDM=@IDM" & c & ";"
                        'Elim += "DELETE FROM Membros_DI_funcao WHERE Membros_DI_funcao.IDM=@IDM" & c & ";"
                        'c += 1

                    Else

                        Elim += "DELETE FROM tem WHERE tem.IDM=@IDM;"
                        Elim += "DELETE FROM Membros_DI_funcao WHERE Membros_DI_funcao.IDM=@IDM;" & vbNewLine
                        Elim += "DELETE FROM Membros_DI WHERE Membros_DI.IDM=@IDM;" & vbNewLine
                        Elim += "DELETE FROM Membros WHERE Membros.IDM=@IDM;"
                        'c += 1

                    End If

                Next

            Next

            SQL.Execute(Elim)

            If SQL.VerExceções(True) Then Exit Sub

            MsgBox("Os membros selecionados foram eliminados com sucesso")

            DenunciarMembros()
        End If
    End Sub

    Private Sub txtPesquisa_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPesquisa.KeyDown
        If e.KeyCode = Keys.Enter Then
            DenunciarMembros()
            e.Handled = True
            e.SuppressKeyPress = True
        End If

    End Sub

    Private Sub bEliminar_Click(sender As Object, e As EventArgs) Handles bEliminar.Click
        If CLBMembros.CheckedItems.Count > 0 Then Eliminar()
    End Sub
End Class