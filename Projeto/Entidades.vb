Public Class Entidades
    Public SQL As New SQLControl
    Public Sub CarregarValores(Optional Query As String = "")
        'Se não for passado nenhum parâmetro, segue com a amostragem das Entidades
        If Query = "" Then
            SQL.Execute("SELECT * " &
                        "FROM Entidades;")
        Else
            SQL.Execute(Query)
        End If

        If SQL.VerExceções(True) Then Exit Sub
        dgvData.DataSource = SQL.Tabelas

    End Sub

    Private Sub EncontrarSearch()
        SQL.AdicionarParametros("@item", "%" & txtProcura.Text & "%")
        CarregarValores("SELECT *" &
                        "FROM Entidades " &
                        "WHERE Entidades.IDE LIKE @item OR Entidades.Investigador_responsavel LIKE @item OR Entidades.instituicao_responsavel LIKE @item;")
    End Sub

    Private Sub CarregarMembros(sender As Object, e As EventArgs) Handles MyBase.Load
        MdiParent = Form1
        CarregarValores()
    End Sub

    Private Sub cmdSearch_Click(sender As Object, e As EventArgs) Handles cmdProcura.Click
        EncontrarSearch()
    End Sub
End Class