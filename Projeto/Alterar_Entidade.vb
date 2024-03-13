Public Class Alterar_Entidade
    Private SQL As New SQLControl

    Private Sub DenunciarEntidade()
        'Dá refresh e limpa a lista de Entidades
        LBEntidade.Items.Clear()

        'Adicionar Parâmetros e dá Execute
        SQL.AdicionarParametros("@IDFE", "%" & txtPesquisa.Text & "%")
        SQL.Execute("SELECT IDFE " &
                    "FROM Entidade " &
                    "WHERE IDFE LIKE @IDFE " &
                    "ORDER BY IDFE ASC;")

        'Verifica se tem erros e dá report, caso tenha cancela a operação
        If SQL.VerExceções(True) Then Exit Sub

        'Return da Lista de Entidades
        For Each i As DataRow In SQL.Tabelas.Rows
            LBEntidade.Items.Add(i("IDFE"))
        Next
    End Sub

    Private Sub ValoresEntidade(IDFE As String)
        SQL.AdicionarParametros("@item", IDFE)
        SQL.Execute("SELECT TOP 1 * " &
                    "FROM Entidade " &
                    "WHERE IDFE LIKE @item;")

        If SQL.Contador < 1 Then Exit Sub

        For Each i As DataRow In SQL.Tabelas.Rows
            TBIDFE.Text = i("IDFE")
        Next
    End Sub

    Private Sub Alterar()
        SQL.AdicionarParametros("@Nome", txtNome.Text)
        SQL.AdicionarParametros("@Descricao", txtDescrição.Text)
        SQL.AdicionarParametros("@Email", txtEmail.Text)
        SQL.AdicionarParametros("@Telefone", txtTelefone.Text)
        SQL.AdicionarParametros("@Designacao", txtDesignação.Text)
        SQL.AdicionarParametros("@Sigla", txtSigla.Text)
        SQL.AdicionarParametros("@Morada", txtMorada.Text)
        SQL.AdicionarParametros("@URL", txtURL.Text)
        SQL.AdicionarParametros("@Pais", txtPais.Text)
        SQL.AdicionarParametros("@IDFE", TBIDFE.Text)

        SQL.Execute("UPDATE Entidade " &
                    "SET nome=@Nome, descricao=@Descricao, email=@Email, telefone=@Telefone, designacao=@Designacao, sigla=@Sigla, morada=@Morada, URL=@URL, pais=@Pais " &
                    "WHERE IDFE=@IDFE")
        If SQL.VerExceções(True) Then Exit Sub
        MsgBox("Entidade Alterada com Sucesso;")

    End Sub

    Private Sub CarregarAlteração(sender As Object, e As EventArgs) Handles MyBase.Load
        MdiParent = Form1
        DenunciarEntidade()
    End Sub

    Private Sub txtPesquisa_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPesquisa.KeyDown
        If e.KeyCode = Keys.Enter Then
            DenunciarEntidade()
            e.Handled = True
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub LBProgramas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LBEntidade.SelectedIndexChanged
        ValoresEntidade(LBEntidade.Text)
    End Sub

    Private Sub bAlterar_Click(sender As Object, e As EventArgs) Handles bAlterar.Click
        Alterar()
        txtNome.Clear()
        txtDescrição.Clear()
        txtEmail.Clear()
        txtTelefone.Clear()
        txtDesignação.Clear()
        txtSigla.Clear()
        txtMorada.Clear()
        txtURL.Clear()
        txtPais.Clear()
        TBIDFE.Clear()
    End Sub

    Private Sub CamposdeTexto(sender As Object, e As EventArgs) Handles txtNome.TextChanged, txtDescrição.TextChanged, txtEmail.TextChanged, txtTelefone.TextChanged, txtDesignação.TextChanged, txtSigla.TextChanged, txtMorada.TextChanged, txtURL.TextChanged, txtPais.TextChanged, TBIDFE.TextChanged
        'Check de Validação
        If Not String.IsNullOrWhiteSpace(txtNome.Text) AndAlso Not String.IsNullOrWhiteSpace(txtDescrição.Text) AndAlso Not String.IsNullOrWhiteSpace(txtEmail.Text) AndAlso Not String.IsNullOrWhiteSpace(txtTelefone.Text) AndAlso Not String.IsNullOrWhiteSpace(txtDesignação.Text) AndAlso Not String.IsNullOrWhiteSpace(txtSigla.Text) AndAlso Not String.IsNullOrWhiteSpace(txtMorada.Text) AndAlso Not String.IsNullOrWhiteSpace(txtURL.Text) AndAlso Not String.IsNullOrWhiteSpace(txtPais.Text) AndAlso Not String.IsNullOrWhiteSpace(TBIDFE.Text) Then
            bAlterar.Enabled = True
        Else
            bAlterar.Enabled = False
        End If
    End Sub
End Class