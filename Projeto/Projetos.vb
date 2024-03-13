Public Class Projetos
    Public SQL As New SQLControl

    Public Sub CarregarValores(Optional Query As String = "")
        'Se não for passado nenhum parâmetro, segue com a amostragem dos Projetos
        If Query = "" Then
            SQL.Execute("SELECT * FROM Projetos;")
        Else
            SQL.Execute(Query)
        End If

        If SQL.VerExceções(True) Then Exit Sub
        dgvData.DataSource = SQL.Tabelas

    End Sub

    Private Sub EncontrarSearch()
        SQL.AdicionarParametros("@item", "%" & txtSearch.Text & "%")
        CarregarValores("SELECT * FROM Projetos WHERE nome_curto LIKE @item;")
    End Sub

    Private Sub CarregarProjetos(sender As Object, e As EventArgs) Handles MyBase.Load
        MdiParent = Form1
        CarregarValores()
    End Sub

    Private Sub cmdSearch_Click(sender As Object, e As EventArgs) Handles cmdSearch.Click
        EncontrarSearch()
    End Sub
End Class