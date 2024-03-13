Public Class Membros
    Public SQL As New SQLControl
    Public Sub CarregarValores(Optional Query As String = "")
        'Se não for passado nenhum parâmetro, segue com a amostragem dos Membros
        If Query = "" Then
            SQL.Execute("SELECT Membros.IDM, Membros.per_tempo_dedicado, Membros.per_afetacao_projeto, Membros.tempo_total, Membros_DI.numero_funcionario, Membros_DI.ORCID, Membros_DI_funcao.funcao " &
                        "FROM Membros left join Membros_DI " &
                        "ON Membros.IDM = Membros_DI.IDM " &
                        "left JOIN membros_DI_funcao " &
                        "ON Membros_DI.IDM = membros_DI_funcao.IDM;")
        Else
            SQL.Execute(Query)
        End If

        If SQL.VerExceções(True) Then Exit Sub
        dgvData.DataSource = SQL.Tabelas

    End Sub

    Private Sub EncontrarSearch()
        SQL.AdicionarParametros("@item", "%" & txtProcura.Text & "%")
        CarregarValores("SELECT  Membros.IDM, Membros.per_tempo_dedicado, Membros.per_afetacao_projeto, Membros.tempo_total, Membros_DI.numero_funcionario, Membros_DI.ORCID, Membros_DI_funcao.funcao " &
                        "FROM Membros left join Membros_DI " &
                        "ON Membros.IDM = Membros_DI.IDM " &
                        "left JOIN membros_DI_funcao " &
                        "ON Membros_DI.IDM = membros_DI_funcao.IDM " &
                        "WHERE Membros.IDM LIKE @item; ")
    End Sub

    Private Sub CarregarMembros(sender As Object, e As EventArgs) Handles MyBase.Load
        MdiParent = Form1
        CarregarValores()
    End Sub

    Private Sub cmdSearch_Click(sender As Object, e As EventArgs) Handles cmdProcura.Click
        EncontrarSearch()
    End Sub
End Class