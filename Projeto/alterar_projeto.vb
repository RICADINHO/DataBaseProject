Public Class alterar_projeto
    Private SQL As New SQLControl

    Private Sub DenunciarProjeto()
        'Dá refresh e limpa a lista de projetos
        LBProjetos.Items.Clear()

        'Adicionar Parâmetros e dá Execute
        SQL.AdicionarParametros("@IDP", "%" & txtPesquisa.Text & "%")
        SQL.Execute("SELECT IDP " &
                    "FROM Projetos " &
                    "WHERE IDP LIKE @IDP " &
                    "ORDER BY IDP ASC;")

        'Verifica se tem erros e dá report, caso tenha cancela a operação
        If SQL.VerExceções(True) Then Exit Sub

        'Return da Lista de projetos
        For Each i As DataRow In SQL.Tabelas.Rows
            LBProjetos.Items.Add(i("IDP"))
        Next
    End Sub

    Private Sub ValoresProjeto(IDP As String)
        SQL.AdicionarParametros("@item", IDP)
        SQL.Execute("SELECT TOP 1 * " &
                    "FROM Projetos " &
                    "WHERE IDP LIKE @item;")

        If SQL.Contador < 1 Then Exit Sub

        For Each i As DataRow In SQL.Tabelas.Rows
            TBIDP.Text = i("IDP")
        Next
    End Sub

    Private Sub Alterar()
        SQL.AdicionarParametros("@nome", TBNome.Text)
        SQL.AdicionarParametros("@titulo", TBTitulo.Text)
        SQL.AdicionarParametros("@data_inicio", TBData_inicio.Text)
        SQL.AdicionarParametros("@data_fim", TBData_fim.Text)
        SQL.AdicionarParametros("@DOI", TBDOI.Text)
        SQL.AdicionarParametros("@URL", TBURL.Text)
        SQL.AdicionarParametros("@custo", TBCusto.Text)
        SQL.AdicionarParametros("@descricao", TBDescricao.Text)
        SQL.AdicionarParametros("@IDP", TBIDP.Text)

        If cbxDominio.Text = "Ciências Tecnológicas" Then
            SQL.Execute("UPDATE Projetos " &
                    "SET IDDC=1, nome_curto=@nome, titulo=@titulo, data_inicio=@data_inicio, data_fim=@data_fim, DOI=@DOI, URL=@URL, custo_total_elegivel=@custo, descricao=@descricao " &
                    "WHERE IDP=@IDP")
        ElseIf cbxDominio.Text = "Ciências da Saúde" Then
            SQL.Execute("UPDATE Projetos " &
                    "SET IDDC=2, nome_curto=@nome, titulo=@titulo, data_inicio=@data_inicio, data_fim=@data_fim, DOI=@DOI, URL=@URL, custo_total_elegivel=@custo, descricao=@descricao " &
                    "WHERE IDP=@IDP")
        ElseIf cbxDominio.Text = "Ciências Jurídicas" Then
            SQL.Execute("UPDATE Projetos " &
                    "SET IDDC=3, nome_curto=@nome, titulo=@titulo, data_inicio=@data_inicio, data_fim=@data_fim, DOI=@DOI, URL=@URL, custo_total_elegivel=@custo, descricao=@descricao " &
                    "WHERE IDP=@IDP")
        End If


        If cbxIndicador.Text = "Sucesso" Then
            SQL.AdicionarParametros("@IDP", TBIDP.Text)
            SQL.Execute("DELETE FROM Associacao_PPP WHERE IDP=@IDP")
            SQL.AdicionarParametros("@IDP", TBIDP.Text)
            SQL.Execute("INSERT INTO Associacao_PPP(IDP, IDPP, URL, DOI) " &
                        "VALUES(@IDP, 1, 'URL1', 'DOI2');")
        Else
            SQL.AdicionarParametros("@IDP", TBIDP.Text)
            SQL.Execute("DELETE FROM Associacao_PPP WHERE IDP=@IDP")
            SQL.AdicionarParametros("@IDP", TBIDP.Text)
            SQL.Execute("INSERT INTO Associacao_PPP(IDP, IDPP, URL, DOI) " &
                    "VALUES(@IDP, 2, 'URL2', 'DOI2');")

        End If

        SQL.AdicionarParametros("@IDP", TBIDP.Text)
        SQL.Execute("DELETE FROM Projetos_estado WHERE IDP=@IDP")
        SQL.AdicionarParametros("@estado", TBEstado.Text)
        SQL.AdicionarParametros("@IDP", TBIDP.Text)
        SQL.Execute("INSERT INTO Projetos_estado(IDP, estado) " &
                    "VALUES(@IDP, @estado);")


        SQL.AdicionarParametros("@IDP", TBIDP.Text)
        SQL.Execute("DELETE FROM AssociacaoPPC WHERE IDP=@IDP")
        SQL.AdicionarParametros("@palavras", TBPalavras.Text)
        SQL.Execute("INSERT INTO palavra_chave(IDPC, palavras) " &
                    "VALUES((SELECT ISNULL(MAX(IDPC)+1,1) FROM palavra_chave), @palavras);")
        SQL.AdicionarParametros("@IDP", TBIDP.Text)
        SQL.Execute("INSERT INTO AssociacaoPPC(IDP, IDPC) " &
                    "VALUES(@IDP, (SELECT ISNULL(MAX(IDPC),1) FROM palavra_chave));")


        SQL.AdicionarParametros("@IDP", TBIDP.Text)
        SQL.Execute("DELETE FROM Associacao_PAC WHERE IDP=@IDP")
        SQL.AdicionarParametros("@areas", TBAreas.Text)
        SQL.Execute("INSERT INTO area_cientifica(IDAC, areas) " &
                    "VALUES((SELECT ISNULL(MAX(IDAC)+1,1) FROM area_cientifica), @areas);")
        SQL.AdicionarParametros("@IDP", TBIDP.Text)
        SQL.Execute("INSERT INTO Associacao_PAC(IDP, IDAC) " &
                    "VALUES(@IDP, (SELECT ISNULL(MAX(IDAC),1) FROM area_cientifica));")




        If SQL.VerExceções(True) Then Exit Sub

        MsgBox("Projeto Alterado com Sucesso;")

    End Sub

    Private Sub CarregarBox()
        cbxDominio.Items.Clear()
        SQL.Execute("SELECT DISTINCT dominio FROM dominio_cientifico;")
        'Verificar se ocorrem erros antes de carregar
        If SQL.VerExceções(True) Then Exit Sub

        For Each i As DataRow In SQL.Tabelas.Rows
            cbxDominio.Items.Add(i("dominio").ToString)
        Next

        cbxIndicador.Items.Clear()
        SQL.Execute("SELECT DISTINCT indicador_sucesso_projeto FROM publicacoes_do_projeto;")
        'Verificar se ocorrem erros antes de carregar
        If SQL.VerExceções(True) Then Exit Sub

        For Each i As DataRow In SQL.Tabelas.Rows
            cbxIndicador.Items.Add(i("indicador_sucesso_projeto").ToString)
        Next
    End Sub
    Private Sub CarregarAlteração(sender As Object, e As EventArgs) Handles MyBase.Load
        MdiParent = Form1
        DenunciarProjeto()
        CarregarBox()
    End Sub

    Private Sub txtPesquisa_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPesquisa.KeyDown
        If e.KeyCode = Keys.Enter Then
            DenunciarProjeto()
            e.Handled = True
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub LBProgramas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LBProjetos.SelectedIndexChanged
        ValoresProjeto(LBProjetos.Text)
    End Sub

    Private Sub bAlterar_Click(sender As Object, e As EventArgs) Handles bAlterar.Click
        Alterar()
        TBNome.Clear()
        TBTitulo.Clear()
        TBData_inicio.Clear()
        TBData_fim.Clear()
        TBDOI.Clear()
        TBURL.Clear()
        TBCusto.Clear()
        TBDescricao.Clear()
        TBIDP.Clear()
        TBEstado.Clear()
        TBAreas.Clear()
        TBPalavras.Clear()
        cbxDominio.Items.Clear()
        cbxIndicador.Items.Clear()

    End Sub

    Private Sub CamposdeTexto(sender As Object, e As EventArgs) Handles TBNome.TextChanged, TBTitulo.TextChanged, TBData_inicio.TextChanged, TBData_fim.TextChanged, TBDOI.TextChanged, TBURL.TextChanged, TBCusto.TextChanged, TBDescricao.TextChanged, TBIDP.TextChanged, TBEstado.TextChanged, TBAreas.TextChanged, TBPalavras.TextChanged, cbxDominio.TextChanged, cbxIndicador.TextChanged
        'Check de Validação
        If Not String.IsNullOrWhiteSpace(TBNome.Text) AndAlso Not String.IsNullOrWhiteSpace(TBTitulo.Text) AndAlso Not String.IsNullOrWhiteSpace(TBData_inicio.Text) AndAlso Not String.IsNullOrWhiteSpace(TBData_fim.Text) AndAlso Not String.IsNullOrWhiteSpace(TBDOI.Text) AndAlso Not String.IsNullOrWhiteSpace(TBURL.Text) AndAlso Not String.IsNullOrWhiteSpace(TBCusto.Text) AndAlso Not String.IsNullOrWhiteSpace(TBDescricao.Text) AndAlso Not String.IsNullOrWhiteSpace(TBIDP.Text) AndAlso Not String.IsNullOrWhiteSpace(TBEstado.Text) AndAlso Not String.IsNullOrWhiteSpace(TBAreas.Text) AndAlso Not String.IsNullOrWhiteSpace(TBPalavras.Text) AndAlso Not String.IsNullOrWhiteSpace(cbxIndicador.Text) AndAlso Not String.IsNullOrWhiteSpace(cbxDominio.Text) AndAlso Not TBData_inicio.Text = "YYYY-MM-DD" AndAlso Not TBData_fim.Text = "YYYY-MM-DD" Then
            bAlterar.Enabled = True
        Else
            bAlterar.Enabled = False
        End If
    End Sub

End Class