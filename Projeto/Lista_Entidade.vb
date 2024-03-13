Imports System.Security.Policy

Public Class Lista_Entidade
    Public SQL As New SQLControl
    Public Sub CarregarValores(Optional Query As String = "")
        'Se não for passado nenhum parâmetro, segue com a amostragem das Entidades
        If Query = "" Then
            SQL.Execute("SELECT * FROM Entidade ")
        Else
            SQL.Execute(Query)
        End If

        If SQL.VerExceções(True) Then Exit Sub
        dgvData.DataSource = SQL.Tabelas

    End Sub

    Private Sub EncontrarSearch()
        SQL.AdicionarParametros("@item", "%" & txtProcura.Text & "%")
        CarregarValores("SELECT *" &
                        "FROM Entidade " &
                        "WHERE IDFE LIKE @item OR nome LIKE @item OR descricao LIKE @item OR email LIKE @item OR telefone LIKE @item OR designacao LIKE @item OR sigla LIKE @item OR morada LIKE @item OR URL LIKE @item OR  pais LIKE @item ")
    End Sub

    Private Sub CarregarEntidade(sender As Object, e As EventArgs) Handles MyBase.Load
        MdiParent = Form1
        CarregarValores()
    End Sub

    Private Sub cmdSearch_Click(sender As Object, e As EventArgs) Handles cmdProcura.Click
        EncontrarSearch()
    End Sub
End Class