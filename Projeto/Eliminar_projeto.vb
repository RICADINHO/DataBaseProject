Public Class Eliminar_projeto
    Private SQL As New SQLControl
    Private Sub CarregarDelete(sender As Object, e As EventArgs) Handles MyBase.Load
        MdiParent = Form1
        DenunciarEntidades()
    End Sub

    Private Sub DenunciarEntidades()
        'Dá refresh e limpa a lista de projetos
        CLBProjeto.Items.Clear()

        'Adicionar Parâmetros e dá Execute
        SQL.AdicionarParametros("@IDP", "%" & txtPesquisa.Text & "%")
        SQL.Execute("SELECT IDP " &
                    "FROM Projetos " &
                    "WHERE IDP LIKE @IDP " &
                    "ORDER BY IDP ASC;")

        'Verifica se tem erros e dá report, caso tenha cancela a operação
        If SQL.VerExceções(True) Then Exit Sub

        'Return da Lista de projetos
        For Each i As DataRow In SQL.Tabelas.Rows
            CLBProjeto.Items.Add(i("IDP"))
        Next
    End Sub

    Private Sub Eliminar()
        If MsgBox("Esta ação não terá retorno, tem a certeza que quer continuar?", MsgBoxStyle.YesNo, "Confirmação de Operação") = MsgBoxResult.Yes Then
            Dim c As Integer
            Dim Elim As String = ""

            For Each i As String In CLBProjeto.CheckedItems
                SQL.AdicionarParametros("@IDP", i)
                'elimiar associacoes do projeto
                Elim += "DELETE FROM Projetos_estado WHERE IDP=@IDP;"
                ' SQL.AdicionarParametros("@IDP", i)
                ' SQL.AdicionarParametros("@IDP", i)
                Elim += "DELETE FROM Associacao_PPP WHERE IDP=@IDP;"
                ' SQL.AdicionarParametros("@IDP", i)
                'Elim += "DELETE FROM palavra_chave WHERE IDPC=(SELECT IDPC FROM AssociacaoPPC WHERE IDP=@IDP);"
                '  SQL.AdicionarParametros("@IDP", i)
                Elim += "DELETE FROM AssociacaoPPC WHERE IDP=@IDP;"
                ' SQL.AdicionarParametros("@IDP", i)
                'SQL.AdicionarParametros("@IDP", i)
                Elim += "DELETE FROM Associacao_PAC WHERE IDP=@IDP;"
                'SQL.AdicionarParametros("@IDP", i)

                'eliminar financiadores/entidades
                Elim += "DELETE FROM FinanciaFP WHERE IDF=(SELECT IDF FROM Financiador WHERE IDF=(SELECT IDF FROM Financiado WHERE IDP=@IDP));"
                Elim += "DELETE FROM FinanciaFE WHERE IDF=(SELECT IDF FROM Financiador WHERE IDF=(SELECT IDF FROM Financiado WHERE IDP=@IDP));"
                ' SQL.AdicionarParametros("@IDP", i)
                ' Elim += "DELETE FROM FinanciaFP WHERE IDF=(SELECT IDF FROM Financiador WHERE IDF=(SELECT IDF FROM Financiado WHERE IDP=@IDP));"
                ' SQL.AdicionarParametros("@IDP", i)
                Elim += "DELETE FROM Financiado WHERE IDP=@IDP;"
                'SQL.AdicionarParametros("@IDP", i)
                'eliminar membros/instituicoes
                Elim += "DELETE FROM tem WHERE IDE=(SELECT IDE FROM Entidades WHERE IDE=(SELECT IDE FROM Participa WHERE IDP=@IDP));"
                'SQL.AdicionarParametros("@IDP", i)
                Elim += "DELETE FROM Participa WHERE IDP=@IDP;"
                'SQL.AdicionarParametros("@IDP", i)
                Elim += "DELETE FROM Resposabiliza WHERE IDP=@IDP;"
                'eliminar projeto
                'SQL.AdicionarParametros("@IDP", i)
                Elim += "DELETE FROM Projetos WHERE IDP=@IDP;"
                c += 1
            Next

                SQL.Execute(Elim)

            If SQL.VerExceções(True) Then Exit Sub

            MsgBox("Os projetos selecionadas foram eliminadas com sucesso")

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
        If CLBProjeto.CheckedItems.Count > 0 Then Eliminar()
    End Sub

End Class