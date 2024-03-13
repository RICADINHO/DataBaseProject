Imports System.Runtime.Remoting.Contexts
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Criar_Programa
    Private SQL As New SQLControl

    Private Sub CarregarProgramas(sender As Object, e As EventArgs) Handles MyBase.Load
        MdiParent = Form1
    End Sub

    Private Sub IntroduzirPrograma()
        'Adicionar Parâmetros e dar execute
        SQL.AdicionarParametros("@Nome", txtNome.Text)


        SQL.Execute("INSERT INTO Programas (IDFP, nome)" &
                        "VALUES ((SELECT ISNULL(MAX(IDFP)+1,1) FROM Programas), @Nome)")

        If SQL.VerExceções(True) Then Exit Sub

        If SQL.Tabelas.Rows.Count > 0 Then
            Dim i As DataRow = SQL.Tabelas.Rows(0)
            MsgBox(i("IDFP").ToString)
        End If

        MsgBox("Programa Criado com Sucesso;")

    End Sub

    Private Sub CamposdeTexto(sender As Object, e As EventArgs) Handles txtNome.TextChanged
        'Check de Validação
        If Not String.IsNullOrWhiteSpace(txtNome.Text) Then
            bCriar.Enabled = True
        Else
            bCriar.Enabled = False
        End If
    End Sub

    Private Sub bCriar_Click(sender As Object, e As EventArgs) Handles bCriar.Click
        IntroduzirPrograma()
        txtNome.Clear()
        bCriar.Enabled = False
    End Sub

End Class