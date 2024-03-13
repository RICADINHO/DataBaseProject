Public Class Alterar_Programa
    Private SQL As New SQLControl

    Private Sub DenunciarPrograma()
        'Dá refresh e limpa a lista de Programas
        LBProgramas.Items.Clear()

        'Adicionar Parâmetros e dá Execute
        SQL.AdicionarParametros("@IDFP", "%" & txtPesquisa.Text & "%")
        SQL.Execute("SELECT IDFP " &
                    "FROM Programas " &
                    "WHERE IDFP LIKE @IDFP " &
                    "ORDER BY IDFP ASC;")

        'Verifica se tem erros e dá report, caso tenha cancela a operação
        If SQL.VerExceções(True) Then Exit Sub

        'Return da Lista de Programas
        For Each i As DataRow In SQL.Tabelas.Rows
            LBProgramas.Items.Add(i("IDFP"))
        Next
    End Sub

    Private Sub ValoresProgramas(IDM As String)
        SQL.AdicionarParametros("@item", IDM)
        SQL.Execute("SELECT TOP 1 * " &
                    "FROM Programas " &
                    "WHERE IDFP LIKE @item;")

        If SQL.Contador < 1 Then Exit Sub

        For Each i As DataRow In SQL.Tabelas.Rows
            TBIDFP.Text = i("IDFP")
        Next
    End Sub

    Private Sub Alterar()
        SQL.AdicionarParametros("@Nome", TBNome.Text)
        SQL.AdicionarParametros("@IDFP", TBIDFP.Text)

        SQL.Execute("UPDATE Programas " &
                    "SET nome=@Nome " &
                    "WHERE IDFP=@IDFP")
        If SQL.VerExceções(True) Then Exit Sub
        MsgBox("Programa Alterado com Sucesso;")

    End Sub

    Private Sub CarregarAlteração(sender As Object, e As EventArgs) Handles MyBase.Load
        MdiParent = Form1
        DenunciarPrograma()
    End Sub

    Private Sub txtPesquisa_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPesquisa.KeyDown
        If e.KeyCode = Keys.Enter Then
            DenunciarPrograma()
            e.Handled = True
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub LBProgramas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LBProgramas.SelectedIndexChanged
        ValoresProgramas(LBProgramas.Text)
    End Sub

    Private Sub bAlterar_Click(sender As Object, e As EventArgs) Handles bAlterar.Click
        Alterar()
    End Sub
    Private Sub CamposdeTexto(sender As Object, e As EventArgs) Handles TBNome.TextChanged, TBIDFP.TextChanged
        'Check de Validação
        If Not String.IsNullOrWhiteSpace(TBNome.Text) AndAlso Not String.IsNullOrWhiteSpace(TBIDFP.Text) Then
            bAlterar.Enabled = True
        Else
            bAlterar.Enabled = False
        End If
    End Sub
End Class