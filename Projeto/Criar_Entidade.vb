Public Class Criar_Entidade
    Private SQL As New SQLControl

    Private Sub CarregarProgramas(sender As Object, e As EventArgs) Handles MyBase.Load
        MdiParent = Form1
    End Sub

    Private Sub IntroduzirEntidade()
        'Adicionar Parâmetros e dar execute
        SQL.AdicionarParametros("@Nome", txtNome.Text)
        SQL.AdicionarParametros("@Descricao", txtDescrição.Text)
        SQL.AdicionarParametros("@Email", txtEmail.Text)
        SQL.AdicionarParametros("@Telefone", txtTelefone.Text)
        SQL.AdicionarParametros("@Designacao", txtDesignação.Text)
        SQL.AdicionarParametros("@Sigla", txtSigla.Text)
        SQL.AdicionarParametros("@Morada", txtMorada.Text)
        SQL.AdicionarParametros("@URL", txtURL.Text)
        SQL.AdicionarParametros("@Pais", txtPais.Text)


        SQL.Execute("INSERT INTO Entidade (IDFE, nome, descricao, email, telefone, designacao, sigla, morada, URL, pais)" &
                        "VALUES ((SELECT ISNULL(MAX(IDFE)+1,1) FROM Entidade), @Nome, @Descricao, @Email, @Telefone, @Designacao, @Sigla, @Morada, @URL, @Pais)")

        If SQL.VerExceções(True) Then Exit Sub

        If SQL.Tabelas.Rows.Count > 0 Then
            Dim i As DataRow = SQL.Tabelas.Rows(0)
            MsgBox(i("IDFE").ToString)
        End If

        MsgBox("Entidade Criada com Sucesso;")

    End Sub

    Private Sub CamposdeTexto(sender As Object, e As EventArgs) Handles txtNome.TextChanged, txtDescrição.TextChanged, txtEmail.TextChanged, txtTelefone.TextChanged, txtDesignação.TextChanged, txtSigla.TextChanged, txtMorada.TextChanged, txtURL.TextChanged, txtPais.TextChanged

        'Check de Validação
        If Not String.IsNullOrWhiteSpace(txtNome.Text) AndAlso Not String.IsNullOrWhiteSpace(txtDescrição.Text) AndAlso Not String.IsNullOrWhiteSpace(txtEmail.Text) AndAlso Not String.IsNullOrWhiteSpace(txtTelefone.Text) AndAlso Not String.IsNullOrWhiteSpace(txtDesignação.Text) AndAlso Not String.IsNullOrWhiteSpace(txtSigla.Text) AndAlso Not String.IsNullOrWhiteSpace(txtMorada.Text) AndAlso Not String.IsNullOrWhiteSpace(txtURL.Text) AndAlso Not String.IsNullOrWhiteSpace(txtPais.Text) Then
            bCriar.Enabled = True
        Else
            bCriar.Enabled = False
        End If
    End Sub

    Private Sub bCriar_Click(sender As Object, e As EventArgs) Handles bCriar.Click
        IntroduzirEntidade()
        txtNome.Clear()
        txtDescrição.Clear()
        txtDesignação.Clear()
        txtEmail.Clear()
        txtMorada.Clear()
        txtPais.Clear()
        txtSigla.Clear()
        txtTelefone.Clear()
        txtURL.Clear()
        bCriar.Enabled = False
    End Sub
End Class