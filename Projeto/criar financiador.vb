Imports System.Runtime.Remoting.Contexts
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class criar_financiador

    Private SQL As New SQLControl

    Private Sub CarregarFinanciadores(sender As Object, e As EventArgs) Handles MyBase.Load
        MdiParent = Form1
        CarregarBox()
    End Sub
    Private Sub IntroduzirFinanciador()
        'Adicionar Parâmetros e dar execute
        SQL.AdicionarParametros("@Nome", txtNome.Text)
        SQL.AdicionarParametros("@QuantidadeDoada", txtQuantidade_doada.Text)

        SQL.Execute("INSERT INTO Financiador (IDF, nome, quantidade_doada)" &
                    "VALUES ((SELECT ISNULL(MAX(IDF)+1,1) FROM Financiador), @Nome, @QuantidadeDoada)")
        SQL.AdicionarParametros("@Tipo", cbxTipo.Text)
        SQL.Execute("INSERT INTO Financiador_tipo (IDF, tipo)" &
                        "VALUES ((SELECT ISNULL(MAX(IDF)+1,1) FROM Financiador_tipo), @Tipo)")

        If SQL.VerExceções(True) Then Exit Sub

        If SQL.Tabelas.Rows.Count > 0 Then
            Dim i As DataRow = SQL.Tabelas.Rows(0)
            MsgBox(i("IDF").ToString)
        End If

        MsgBox("Financiador Criado com Sucesso;")

    End Sub

    Private Sub CarregarBox()
        cbxTipo.Items.Clear()
        SQL.Execute("SELECT DISTINCT tipo FROM Financiador_tipo;")
        'Verificar se ocorrem erros antes de carregar
        If SQL.VerExceções(True) Then Exit Sub

        For Each i As DataRow In SQL.Tabelas.Rows
            cbxTipo.Items.Add(i("tipo").ToString)
        Next
    End Sub

    Private Sub CamposdeTexto(sender As Object, e As EventArgs) Handles txtNome.TextChanged, txtQuantidade_doada.TextChanged, cbxTipo.TextChanged
        'Check de Validação
        If Not String.IsNullOrWhiteSpace(txtNome.Text) AndAlso Not String.IsNullOrWhiteSpace(txtQuantidade_doada.Text) AndAlso Not String.IsNullOrWhiteSpace(cbxTipo.Text) Then
            bCriar.Enabled = True
        Else
            bCriar.Enabled = False
        End If
    End Sub

    Private Sub bCriar_Click(sender As Object, e As EventArgs) Handles bCriar.Click
        IntroduzirFinanciador()
        txtQuantidade_doada.Clear()
        txtNome.Clear()
        bCriar.Enabled = False
        cbxTipo.SelectedIndex = -1
    End Sub














End Class