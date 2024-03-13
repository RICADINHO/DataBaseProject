Imports System.Data.SqlClient

Public Class Criar_Projeto
    Private SQL As New SQLControl

    Private Sub CarregarProgramas(sender As Object, e As EventArgs) Handles MyBase.Load
        MdiParent = Form1
        ValoresLBFinanciadores()
        ValoresLBEntidades_F()
        ValoresLBProgramas_F()
        ValoresLBMembros()
        ValoresLBInstituicao()
        CarregarBox()
    End Sub

    Private Sub IntroduzirProjeto()

        'parametros projeto base
        SQL.AdicionarParametros("@nome", TBNome.Text)
        SQL.AdicionarParametros("@titulo", TBTitulo.Text)
        SQL.AdicionarParametros("@data_inicio", TBData_inicio.Text)
        SQL.AdicionarParametros("@data_fim", TBData_fim.Text)
        SQL.AdicionarParametros("@DOI", TBDOI.Text)
        SQL.AdicionarParametros("@URL", TBURL.Text)
        SQL.AdicionarParametros("@custo", TBCusto.Text)
        SQL.AdicionarParametros("@descricao", TBDescricao.Text)
        'parametros associacoes do projeto
        SQL.AdicionarParametros("@estado_projeto", TBEstado_projeto.Text)
        SQL.AdicionarParametros("@publicacoes", cbxPublicacoes_projeto.Text)
        SQL.AdicionarParametros("@palavras", TBPalavras_chave.Text)
        SQL.AdicionarParametros("@areas", TBAreas_C.Text)
        SQL.AdicionarParametros("@dominio", cbxDominio.Text)
        'parametros financiadores/entidades
        'SQL.AdicionarParametros("@financiadores", LBFinanciadores.Text)
        'SQL.AdicionarParametros("@entidades", LBEntidades_F.Text)
        'SQL.AdicionarParametros("@programas", LBProgramas_F.Text)
        'parametros membros
        'SQL.AdicionarParametros("@membros", LBMembros.Text)
        'SQL.AdicionarParametros()


        Dim ola As String = ""
        'inserir projeto

        If cbxDominio.Text = "Ciências Tecnológicas" Then
            ola += "INSERT INTO Projetos (IDP, IDDC, nome_curto, titulo, data_inicio, data_fim, DOI, URL, custo_total_elegivel, descricao)" &
                        "VALUES ((SELECT ISNULL(MAX(IDP)+1,1) FROM Projetos), 1, @nome, @titulo, @data_inicio, @data_fim, @DOI, @URL, @custo, @descricao);"
        ElseIf cbxDominio.Text = "Ciências da Saúde" Then
            ola += "INSERT INTO Projetos (IDP, IDDC, nome_curto, titulo, data_inicio, data_fim, DOI, URL, custo_total_elegivel, descricao)" &
                        "VALUES ((SELECT ISNULL(MAX(IDP)+1,1) FROM Projetos), 2, @nome, @titulo, @data_inicio, @data_fim, @DOI, @URL, @custo, @descricao);"
        ElseIf cbxDominio.Text = "Ciências Jurídicas" Then
            ola += "INSERT INTO Projetos (IDP, IDDC, nome_curto, titulo, data_inicio, data_fim, DOI, URL, custo_total_elegivel, descricao)" &
                        "VALUES ((SELECT ISNULL(MAX(IDP)+1,1) FROM Projetos), 3, @nome, @titulo, @data_inicio, @data_fim, @DOI, @URL, @custo, @descricao);"
        End If

        'inserir associacoes
        ola += "INSERT INTO Projetos_estado(IDP, estado) " &
                    "VALUES((SELECT ISNULL(MAX(IDP),1) FROM Projetos), @estado_projeto);"

        If cbxPublicacoes_projeto.Text = "Sucesso" Then
            ola += "INSERT INTO Associacao_PPP(IDP, IDPP, URL, DOI) " &
                    "VALUES((SELECT ISNULL(MAX(IDP),1) FROM Projetos), 1, 'URL1', 'DOI1');"
        Else
            ola += "INSERT INTO Associacao_PPP(IDP, IDPP, URL, DOI) " &
                    "VALUES((SELECT ISNULL(MAX(IDP),1) FROM Projetos), 2, 'URL2', 'DOI2');"

        End If

        ola += "INSERT INTO palavra_chave(IDPC, palavras) " &
                    "VALUES((SELECT ISNULL(MAX(IDPC)+1,1) FROM palavra_chave), @palavras);"
        ola += "INSERT INTO AssociacaoPPC(IDP, IDPC) " &
                    "VALUES((SELECT ISNULL(MAX(IDP),1) FROM Projetos), (SELECT ISNULL(MAX(IDPC),1) FROM palavra_chave));"

        ola += "INSERT INTO area_cientifica(IDAC, areas) " &
                    "VALUES((SELECT ISNULL(MAX(IDAC)+1,1) FROM area_cientifica), @areas);"
        ola += "INSERT INTO Associacao_PAC(IDP, IDAC) " &
                    "VALUES((SELECT ISNULL(MAX(IDP),1) FROM Projetos), (SELECT ISNULL(MAX(IDAC),1) FROM area_cientifica));"


        'inserir financiadores/entidades

        SQL.Execute(ola)
        SQL.VerExceções(True)

        For Each ia As String In LBFinanciadores.CheckedItems
            SQL.AdicionarParametros("@IDF", ia)
            SQL.Execute("INSERT INTO Financiado(IDP, IDF) " &
                            "VALUES((SELECT ISNULL(MAX(IDP),1) FROM Projetos), @IDF) ")
            SQL.VerExceções(True)

            For Each j As String In LBEntidades_F.CheckedItems
                SQL.AdicionarParametros("@IDF", ia)
                SQL.AdicionarParametros("@IDFE", j)
                SQL.Execute("INSERT INTO FinanciaFE(IDF, IDFE) " &
                                "VALUES(@IDF, @IDFE)")
                SQL.VerExceções(True)
            Next

            For Each q As String In LBProgramas_F.CheckedItems
                SQL.AdicionarParametros("@IDF", ia)
                SQL.AdicionarParametros("@IDFP", q)
                SQL.Execute("INSERT INTO FinanciaFP(IDF, IDFP) " &
                            "VALUES(@IDF, @IDFP)")
                SQL.VerExceções(True)
            Next

        Next


        'inseir membros/instituiçoes
        For Each i As String In LBInstituicao.CheckedItems
            SQL.AdicionarParametros("@IDE", i)
            SQL.Execute("INSERT INTO Participa(IDP, IDE) " &
                        "VALUES((SELECT ISNULL(MAX(IDP),1) FROM Projetos), @IDE)")
            SQL.VerExceções(True)
            SQL.AdicionarParametros("@IDE", i)
            SQL.Execute("INSERT INTO Resposabiliza(IDP, IDE) " &
                        "VALUES((SELECT ISNULL(MAX(IDP),1) FROM Projetos), @IDE)")
            SQL.VerExceções(True)

            For Each jk As String In LBMembros.CheckedItems
                SQL.AdicionarParametros("@IDE", i)
                SQL.AdicionarParametros("@IDM", jk)
                SQL.Execute("INSERT INTO tem(IDE, IDM) " &
                            "VALUES(@IDE, @IDM)")
                SQL.VerExceções(True)
            Next

        Next





        If SQL.VerExceções(True) Then Exit Sub

        If SQL.Tabelas.Rows.Count > 0 Then
            Dim i As DataRow = SQL.Tabelas.Rows(0)
            MsgBox(i("IDP").ToString)
        End If

        MsgBox("Projeto Criado com Sucesso;")

    End Sub
    '--------------------funçoes--------

    Private Sub CarregarBox()
        cbxDominio.Items.Clear()
        SQL.Execute("SELECT DISTINCT dominio FROM dominio_cientifico;")
        'Verificar se ocorrem erros antes de carregar
        If SQL.VerExceções(True) Then Exit Sub

        For Each i As DataRow In SQL.Tabelas.Rows
            cbxDominio.Items.Add(i("dominio").ToString)
        Next

        cbxPublicacoes_projeto.Items.Clear()
        SQL.Execute("SELECT DISTINCT indicador_sucesso_projeto FROM publicacoes_do_projeto;")
        'Verificar se ocorrem erros antes de carregar
        If SQL.VerExceções(True) Then Exit Sub

        For Each i As DataRow In SQL.Tabelas.Rows
            cbxPublicacoes_projeto.Items.Add(i("indicador_sucesso_projeto").ToString)
        Next
    End Sub
    Private Sub ValoresLBFinanciadores()
        LBFinanciadores.Items.Clear()

        SQL.Execute("SELECT IDF " &
                    "FROM Financiador ")

        If SQL.VerExceções(True) Then Exit Sub

        For Each i As DataRow In SQL.Tabelas.Rows
            LBFinanciadores.Items.Add(i("IDF"))
        Next
    End Sub

    Private Sub ValoresLBEntidades_F()
        LBEntidades_F.Items.Clear()


        SQL.Execute("SELECT IDFE " &
                    "FROM Entidade ")

        If SQL.VerExceções(True) Then Exit Sub

        For Each i As DataRow In SQL.Tabelas.Rows
            LBEntidades_F.Items.Add(i("IDFE"))
        Next
    End Sub

    Private Sub ValoresLBProgramas_F()
        LBProgramas_F.Items.Clear()

        SQL.Execute("SELECT IDFP " &
                    "FROM Programas ")

        If SQL.VerExceções(True) Then Exit Sub

        For Each i As DataRow In SQL.Tabelas.Rows
            LBProgramas_F.Items.Add(i("IDFP"))
        Next
    End Sub

    Private Sub ValoresLBMembros()
        LBMembros.Items.Clear()

        SQL.Execute("SELECT IDM " &
                    "FROM membros ")

        If SQL.VerExceções(True) Then Exit Sub

        For Each i As DataRow In SQL.Tabelas.Rows
            LBMembros.Items.Add(i("IDM"))
        Next
    End Sub

    Private Sub ValoresLBInstituicao()
        LBInstituicao.Items.Clear()


        SQL.Execute("SELECT IDE " &
                    "FROM Entidades ")

        If SQL.VerExceções(True) Then Exit Sub

        For Each i As DataRow In SQL.Tabelas.Rows
            LBInstituicao.Items.Add(i("IDE"))
        Next
    End Sub

    '------------------checks finais------------------
    Private Sub LBProgramas_SelectedIndexChanged(sender As Object, e As EventArgs)
        ValoresLBFinanciadores()
        ValoresLBEntidades_F()
        ValoresLBProgramas_F()
        ValoresLBMembros()
        ValoresLBInstituicao()
    End Sub

    Private Sub CamposdeTexto(sender As Object, e As EventArgs) Handles TBAreas_C.TextChanged, TBCusto.TextChanged, TBData_fim.TextChanged, TBData_inicio.TextChanged, TBDescricao.TextChanged, TBDOI.TextChanged, TBEstado_projeto.TextChanged, TBNome.TextChanged, TBPalavras_chave.TextChanged, TBTitulo.TextChanged, TBURL.TextChanged, cbxDominio.TextChanged, cbxPublicacoes_projeto.TextChanged, LBMembros.ItemCheck, LBEntidades_F.ItemCheck, LBFinanciadores.ItemCheck, LBInstituicao.ItemCheck, LBProgramas_F.ItemCheck
        'Check de Validação
        If Not String.IsNullOrWhiteSpace(TBAreas_C.Text) AndAlso Not String.IsNullOrWhiteSpace(TBCusto.Text) AndAlso Not String.IsNullOrWhiteSpace(TBData_fim.Text) AndAlso Not String.IsNullOrWhiteSpace(TBData_inicio.Text) AndAlso Not String.IsNullOrWhiteSpace(TBDescricao.Text) AndAlso Not String.IsNullOrWhiteSpace(TBDOI.Text) AndAlso Not String.IsNullOrWhiteSpace(cbxDominio.Text) AndAlso Not String.IsNullOrWhiteSpace(TBEstado_projeto.Text) AndAlso Not String.IsNullOrWhiteSpace(TBNome.Text) AndAlso Not String.IsNullOrWhiteSpace(TBPalavras_chave.Text) AndAlso Not String.IsNullOrWhiteSpace(cbxPublicacoes_projeto.Text) AndAlso Not String.IsNullOrWhiteSpace(TBTitulo.Text) AndAlso Not String.IsNullOrWhiteSpace(TBURL.Text) AndAlso LBEntidades_F.CheckedItems.Count > 0 AndAlso LBFinanciadores.CheckedItems.Count > 0 AndAlso LBInstituicao.CheckedItems.Count > 0 AndAlso LBMembros.CheckedItems.Count > 0 AndAlso LBProgramas_F.CheckedItems.Count > 0 AndAlso Not TBData_inicio.Text = "YYYY-MM-DD" AndAlso Not TBData_fim.Text = "YYYY-MM-DD" Then
            bCriar.Enabled = True
        Else
            bCriar.Enabled = False
        End If
    End Sub

    Private Sub bCriar_Click(sender As Object, e As EventArgs) Handles bCriar.Click

        IntroduzirProjeto()
        If LBFinanciadores.CheckedItems.Count > 0 Then ValoresLBFinanciadores()
        TBNome.Clear()
        TBTitulo.Clear()
        TBData_inicio.Clear()
        TBData_fim.Clear()
        TBDOI.Clear()
        TBURL.Clear()
        TBCusto.Clear()
        TBDescricao.Clear()
        TBEstado_projeto.Clear()
        cbxPublicacoes_projeto.Items.Clear()
        cbxDominio.Items.Clear()
        TBPalavras_chave.Clear()
        LBFinanciadores.Items.Clear()
        LBEntidades_F.Items.Clear()
        LBProgramas_F.Items.Clear()
        LBMembros.Items.Clear()
        LBInstituicao.Items.Clear()
        TBAreas_C.Clear()
        bCriar.Enabled = False

    End Sub

End Class