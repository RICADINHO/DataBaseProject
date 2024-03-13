Public Class Ver_lista_financiadores
    Public SQL As New SQLControl

    Public Sub CarregarValores(Optional Query As String = "")
        'Se não for passado nenhum parâmetro, segue com a amostragem dos Financiadores
        If Query = "" Then
            SQL.Execute("SELECT Financiador.*, Financiador_tipo.tipo " &
                        "From Financiador , Financiador_tipo " &
                        "WHERE Financiador.IDF = Financiador_tipo.IDF ")
        Else
            SQL.Execute(Query)
        End If

        If SQL.VerExceções(True) Then Exit Sub
        dgvData.DataSource = SQL.Tabelas

    End Sub

    Private Sub EncontrarSearch()
        SQL.AdicionarParametros("@item", "%" & txtProcura.Text & "%")
        'CarregarValores("SELECT Financiador.*, Financiador_tipo.tipo " &
        '"FROM Financiador, Financiador_tipo " &
        '"WHERE Financiador.IDF = Financiador_tipo.IDF AND Financiador.IDF LIKE @item OR Financiador.nome LIKE @item OR Financiador.quantidade_doada LIKE @item OR Financiador_tipo.tipo LIKE @item;")'
        CarregarValores("SELECT Financiador.*, Financiador_tipo.tipo 
                        FROM Financiador, Financiador_tipo  
                        WHERE Financiador.IDF = Financiador_tipo.IDF
                        INTERSECT
                        SELECT Financiador.*, Financiador_tipo.tipo
                        FROM Financiador, Financiador_tipo
                        WHERE Financiador.IDF LIKE @item OR Financiador.nome LIKE @item OR Financiador.quantidade_doada LIKE @item OR Financiador_tipo.tipo LIKE @item")
    End Sub

    Private Sub CarregarFinanciadores(sender As Object, e As EventArgs) Handles MyBase.Load
        MdiParent = Form1
        CarregarValores()
    End Sub

    Private Sub cmdSearch_Click(sender As Object, e As EventArgs) Handles cmdProcura.Click
        EncontrarSearch()
    End Sub
End Class