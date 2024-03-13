<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class alterar_projeto
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GBValoresFinanciadores = New System.Windows.Forms.GroupBox()
        Me.TBEstado = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.cbxIndicador = New System.Windows.Forms.ComboBox()
        Me.cbxDominio = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TBPalavras = New System.Windows.Forms.TextBox()
        Me.TBAreas = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.bAlterar = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TBDOI = New System.Windows.Forms.TextBox()
        Me.TBDescricao = New System.Windows.Forms.TextBox()
        Me.TBCusto = New System.Windows.Forms.TextBox()
        Me.TBURL = New System.Windows.Forms.TextBox()
        Me.TBData_fim = New System.Windows.Forms.TextBox()
        Me.TBData_inicio = New System.Windows.Forms.TextBox()
        Me.TBTitulo = New System.Windows.Forms.TextBox()
        Me.TBNome = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TBIDP = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LBProjetos = New System.Windows.Forms.ListBox()
        Me.txtPesquisa = New System.Windows.Forms.TextBox()
        Me.GBValoresFinanciadores.SuspendLayout()
        Me.SuspendLayout()
        '
        'GBValoresFinanciadores
        '
        Me.GBValoresFinanciadores.Controls.Add(Me.TBEstado)
        Me.GBValoresFinanciadores.Controls.Add(Me.Label14)
        Me.GBValoresFinanciadores.Controls.Add(Me.cbxIndicador)
        Me.GBValoresFinanciadores.Controls.Add(Me.cbxDominio)
        Me.GBValoresFinanciadores.Controls.Add(Me.Label9)
        Me.GBValoresFinanciadores.Controls.Add(Me.Label11)
        Me.GBValoresFinanciadores.Controls.Add(Me.Label12)
        Me.GBValoresFinanciadores.Controls.Add(Me.Label13)
        Me.GBValoresFinanciadores.Controls.Add(Me.TBPalavras)
        Me.GBValoresFinanciadores.Controls.Add(Me.TBAreas)
        Me.GBValoresFinanciadores.Controls.Add(Me.Label8)
        Me.GBValoresFinanciadores.Controls.Add(Me.Label7)
        Me.GBValoresFinanciadores.Controls.Add(Me.bAlterar)
        Me.GBValoresFinanciadores.Controls.Add(Me.Label6)
        Me.GBValoresFinanciadores.Controls.Add(Me.Label5)
        Me.GBValoresFinanciadores.Controls.Add(Me.Label4)
        Me.GBValoresFinanciadores.Controls.Add(Me.Label3)
        Me.GBValoresFinanciadores.Controls.Add(Me.Label2)
        Me.GBValoresFinanciadores.Controls.Add(Me.TBDOI)
        Me.GBValoresFinanciadores.Controls.Add(Me.TBDescricao)
        Me.GBValoresFinanciadores.Controls.Add(Me.TBCusto)
        Me.GBValoresFinanciadores.Controls.Add(Me.TBURL)
        Me.GBValoresFinanciadores.Controls.Add(Me.TBData_fim)
        Me.GBValoresFinanciadores.Controls.Add(Me.TBData_inicio)
        Me.GBValoresFinanciadores.Controls.Add(Me.TBTitulo)
        Me.GBValoresFinanciadores.Controls.Add(Me.TBNome)
        Me.GBValoresFinanciadores.Controls.Add(Me.Label10)
        Me.GBValoresFinanciadores.Controls.Add(Me.TBIDP)
        Me.GBValoresFinanciadores.Controls.Add(Me.Label1)
        Me.GBValoresFinanciadores.Location = New System.Drawing.Point(257, 2)
        Me.GBValoresFinanciadores.Name = "GBValoresFinanciadores"
        Me.GBValoresFinanciadores.Size = New System.Drawing.Size(631, 512)
        Me.GBValoresFinanciadores.TabIndex = 33
        Me.GBValoresFinanciadores.TabStop = False
        Me.GBValoresFinanciadores.Text = "Valores"
        '
        'TBEstado
        '
        Me.TBEstado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TBEstado.Location = New System.Drawing.Point(128, 374)
        Me.TBEstado.Name = "TBEstado"
        Me.TBEstado.Size = New System.Drawing.Size(248, 22)
        Me.TBEstado.TabIndex = 48
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(12, 374)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(71, 32)
        Me.Label14.TabIndex = 47
        Me.Label14.Text = "Estado" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "do projeto:"
        '
        'cbxIndicador
        '
        Me.cbxIndicador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxIndicador.FormattingEnabled = True
        Me.cbxIndicador.Location = New System.Drawing.Point(185, 464)
        Me.cbxIndicador.Name = "cbxIndicador"
        Me.cbxIndicador.Size = New System.Drawing.Size(121, 24)
        Me.cbxIndicador.TabIndex = 36
        Me.cbxIndicador.TabStop = False
        '
        'cbxDominio
        '
        Me.cbxDominio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxDominio.FormattingEnabled = True
        Me.cbxDominio.Location = New System.Drawing.Point(185, 423)
        Me.cbxDominio.Name = "cbxDominio"
        Me.cbxDominio.Size = New System.Drawing.Size(121, 24)
        Me.cbxDominio.TabIndex = 37
        Me.cbxDominio.TabStop = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(463, 228)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(105, 16)
        Me.Label9.TabIndex = 43
        Me.Label9.Text = "Palavras-chave:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(463, 70)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(108, 16)
        Me.Label11.TabIndex = 44
        Me.Label11.Text = "Áreas científicas:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(14, 426)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(115, 16)
        Me.Label12.TabIndex = 45
        Me.Label12.Text = "Domínio científico:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(14, 464)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(139, 16)
        Me.Label13.TabIndex = 46
        Me.Label13.Text = "Indicador de sucesso:"
        '
        'TBPalavras
        '
        Me.TBPalavras.Location = New System.Drawing.Point(424, 258)
        Me.TBPalavras.Multiline = True
        Me.TBPalavras.Name = "TBPalavras"
        Me.TBPalavras.Size = New System.Drawing.Size(179, 102)
        Me.TBPalavras.TabIndex = 38
        '
        'TBAreas
        '
        Me.TBAreas.Location = New System.Drawing.Point(424, 105)
        Me.TBAreas.Multiline = True
        Me.TBAreas.Name = "TBAreas"
        Me.TBAreas.Size = New System.Drawing.Size(179, 105)
        Me.TBAreas.TabIndex = 39
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(14, 338)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(72, 16)
        Me.Label8.TabIndex = 42
        Me.Label8.Text = "Descrição:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(14, 301)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 16)
        Me.Label7.TabIndex = 41
        Me.Label7.Text = "Custo total:"
        '
        'bAlterar
        '
        Me.bAlterar.Enabled = False
        Me.bAlterar.Location = New System.Drawing.Point(434, 426)
        Me.bAlterar.Name = "bAlterar"
        Me.bAlterar.Size = New System.Drawing.Size(147, 48)
        Me.bAlterar.TabIndex = 16
        Me.bAlterar.Text = "Alterar"
        Me.bAlterar.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(14, 264)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 16)
        Me.Label6.TabIndex = 40
        Me.Label6.Text = "URL:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(14, 228)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(33, 16)
        Me.Label5.TabIndex = 39
        Me.Label5.Text = "DOI:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(14, 188)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 16)
        Me.Label4.TabIndex = 38
        Me.Label4.Text = "Data do fim:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 146)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 16)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "Data de inicio:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 108)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 16)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = "Título:"
        '
        'TBDOI
        '
        Me.TBDOI.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TBDOI.Location = New System.Drawing.Point(128, 228)
        Me.TBDOI.Name = "TBDOI"
        Me.TBDOI.Size = New System.Drawing.Size(248, 22)
        Me.TBDOI.TabIndex = 35
        '
        'TBDescricao
        '
        Me.TBDescricao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TBDescricao.Location = New System.Drawing.Point(128, 338)
        Me.TBDescricao.Name = "TBDescricao"
        Me.TBDescricao.Size = New System.Drawing.Size(248, 22)
        Me.TBDescricao.TabIndex = 34
        '
        'TBCusto
        '
        Me.TBCusto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TBCusto.Location = New System.Drawing.Point(128, 301)
        Me.TBCusto.Name = "TBCusto"
        Me.TBCusto.Size = New System.Drawing.Size(248, 22)
        Me.TBCusto.TabIndex = 33
        '
        'TBURL
        '
        Me.TBURL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TBURL.Location = New System.Drawing.Point(128, 264)
        Me.TBURL.Name = "TBURL"
        Me.TBURL.Size = New System.Drawing.Size(248, 22)
        Me.TBURL.TabIndex = 31
        '
        'TBData_fim
        '
        Me.TBData_fim.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TBData_fim.Location = New System.Drawing.Point(128, 188)
        Me.TBData_fim.Name = "TBData_fim"
        Me.TBData_fim.Size = New System.Drawing.Size(248, 22)
        Me.TBData_fim.TabIndex = 30
        Me.TBData_fim.Text = "YYYY-MM-DD"
        '
        'TBData_inicio
        '
        Me.TBData_inicio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TBData_inicio.Location = New System.Drawing.Point(128, 146)
        Me.TBData_inicio.Name = "TBData_inicio"
        Me.TBData_inicio.Size = New System.Drawing.Size(248, 22)
        Me.TBData_inicio.TabIndex = 29
        Me.TBData_inicio.Text = "YYYY-MM-DD"
        '
        'TBTitulo
        '
        Me.TBTitulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TBTitulo.Location = New System.Drawing.Point(128, 108)
        Me.TBTitulo.Name = "TBTitulo"
        Me.TBTitulo.Size = New System.Drawing.Size(248, 22)
        Me.TBTitulo.TabIndex = 28
        '
        'TBNome
        '
        Me.TBNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TBNome.Location = New System.Drawing.Point(128, 70)
        Me.TBNome.Name = "TBNome"
        Me.TBNome.Size = New System.Drawing.Size(248, 22)
        Me.TBNome.TabIndex = 27
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(14, 70)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(47, 16)
        Me.Label10.TabIndex = 26
        Me.Label10.Text = "Nome:"
        '
        'TBIDP
        '
        Me.TBIDP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TBIDP.Location = New System.Drawing.Point(220, 31)
        Me.TBIDP.Name = "TBIDP"
        Me.TBIDP.ReadOnly = True
        Me.TBIDP.Size = New System.Drawing.Size(71, 22)
        Me.TBIDP.TabIndex = 18
        Me.TBIDP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(182, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 16)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "IDP:"
        '
        'LBProjetos
        '
        Me.LBProjetos.FormattingEnabled = True
        Me.LBProjetos.ItemHeight = 16
        Me.LBProjetos.Location = New System.Drawing.Point(3, 30)
        Me.LBProjetos.Name = "LBProjetos"
        Me.LBProjetos.Size = New System.Drawing.Size(248, 484)
        Me.LBProjetos.TabIndex = 35
        '
        'txtPesquisa
        '
        Me.txtPesquisa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPesquisa.Location = New System.Drawing.Point(3, 2)
        Me.txtPesquisa.Name = "txtPesquisa"
        Me.txtPesquisa.Size = New System.Drawing.Size(248, 22)
        Me.txtPesquisa.TabIndex = 34
        '
        'alterar_projeto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(911, 528)
        Me.Controls.Add(Me.LBProjetos)
        Me.Controls.Add(Me.txtPesquisa)
        Me.Controls.Add(Me.GBValoresFinanciadores)
        Me.Name = "alterar_projeto"
        Me.Text = "alterar_projeto"
        Me.GBValoresFinanciadores.ResumeLayout(False)
        Me.GBValoresFinanciadores.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GBValoresFinanciadores As GroupBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents bAlterar As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TBDOI As TextBox
    Friend WithEvents TBDescricao As TextBox
    Friend WithEvents TBCusto As TextBox
    Friend WithEvents TBURL As TextBox
    Friend WithEvents TBData_fim As TextBox
    Friend WithEvents TBData_inicio As TextBox
    Friend WithEvents TBTitulo As TextBox
    Friend WithEvents TBNome As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents TBIDP As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents LBProjetos As ListBox
    Friend WithEvents txtPesquisa As TextBox
    Friend WithEvents cbxIndicador As ComboBox
    Friend WithEvents cbxDominio As ComboBox
    Friend WithEvents TBPalavras As TextBox
    Friend WithEvents TBAreas As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents TBEstado As TextBox
    Friend WithEvents Label14 As Label
End Class
