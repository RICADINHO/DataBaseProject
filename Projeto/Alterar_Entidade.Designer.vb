<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Alterar_Entidade
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
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.bAlterar = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtDesignação = New System.Windows.Forms.TextBox()
        Me.txtURL = New System.Windows.Forms.TextBox()
        Me.txtMorada = New System.Windows.Forms.TextBox()
        Me.txtPais = New System.Windows.Forms.TextBox()
        Me.txtSigla = New System.Windows.Forms.TextBox()
        Me.txtTelefone = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtDescrição = New System.Windows.Forms.TextBox()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TBIDFE = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LBEntidade = New System.Windows.Forms.ListBox()
        Me.txtPesquisa = New System.Windows.Forms.TextBox()
        Me.GBValoresFinanciadores.SuspendLayout()
        Me.SuspendLayout()
        '
        'GBValoresFinanciadores
        '
        Me.GBValoresFinanciadores.Controls.Add(Me.Label9)
        Me.GBValoresFinanciadores.Controls.Add(Me.Label8)
        Me.GBValoresFinanciadores.Controls.Add(Me.Label7)
        Me.GBValoresFinanciadores.Controls.Add(Me.bAlterar)
        Me.GBValoresFinanciadores.Controls.Add(Me.Label6)
        Me.GBValoresFinanciadores.Controls.Add(Me.Label5)
        Me.GBValoresFinanciadores.Controls.Add(Me.Label4)
        Me.GBValoresFinanciadores.Controls.Add(Me.Label3)
        Me.GBValoresFinanciadores.Controls.Add(Me.Label2)
        Me.GBValoresFinanciadores.Controls.Add(Me.txtDesignação)
        Me.GBValoresFinanciadores.Controls.Add(Me.txtURL)
        Me.GBValoresFinanciadores.Controls.Add(Me.txtMorada)
        Me.GBValoresFinanciadores.Controls.Add(Me.txtPais)
        Me.GBValoresFinanciadores.Controls.Add(Me.txtSigla)
        Me.GBValoresFinanciadores.Controls.Add(Me.txtTelefone)
        Me.GBValoresFinanciadores.Controls.Add(Me.txtEmail)
        Me.GBValoresFinanciadores.Controls.Add(Me.txtDescrição)
        Me.GBValoresFinanciadores.Controls.Add(Me.txtNome)
        Me.GBValoresFinanciadores.Controls.Add(Me.Label10)
        Me.GBValoresFinanciadores.Controls.Add(Me.TBIDFE)
        Me.GBValoresFinanciadores.Controls.Add(Me.Label1)
        Me.GBValoresFinanciadores.Location = New System.Drawing.Point(276, 12)
        Me.GBValoresFinanciadores.Name = "GBValoresFinanciadores"
        Me.GBValoresFinanciadores.Size = New System.Drawing.Size(399, 483)
        Me.GBValoresFinanciadores.TabIndex = 32
        Me.GBValoresFinanciadores.TabStop = False
        Me.GBValoresFinanciadores.Text = "Valores"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(14, 375)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(37, 16)
        Me.Label9.TabIndex = 43
        Me.Label9.Text = "Pais:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(14, 338)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(37, 16)
        Me.Label8.TabIndex = 42
        Me.Label8.Text = "URL:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(14, 301)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(57, 16)
        Me.Label7.TabIndex = 41
        Me.Label7.Text = "Morada:"
        '
        'bAlterar
        '
        Me.bAlterar.Enabled = False
        Me.bAlterar.Location = New System.Drawing.Point(177, 415)
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
        Me.Label6.Size = New System.Drawing.Size(41, 16)
        Me.Label6.TabIndex = 40
        Me.Label6.Text = "Sigla:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(14, 228)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 16)
        Me.Label5.TabIndex = 39
        Me.Label5.Text = "Designação:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(14, 188)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 16)
        Me.Label4.TabIndex = 38
        Me.Label4.Text = "Telefone:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 146)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 16)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "E-mail:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 108)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 16)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = "Descrição:"
        '
        'txtDesignação
        '
        Me.txtDesignação.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDesignação.Location = New System.Drawing.Point(128, 228)
        Me.txtDesignação.Name = "txtDesignação"
        Me.txtDesignação.Size = New System.Drawing.Size(248, 22)
        Me.txtDesignação.TabIndex = 35
        '
        'txtURL
        '
        Me.txtURL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtURL.Location = New System.Drawing.Point(128, 338)
        Me.txtURL.Name = "txtURL"
        Me.txtURL.Size = New System.Drawing.Size(248, 22)
        Me.txtURL.TabIndex = 34
        '
        'txtMorada
        '
        Me.txtMorada.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMorada.Location = New System.Drawing.Point(128, 301)
        Me.txtMorada.Name = "txtMorada"
        Me.txtMorada.Size = New System.Drawing.Size(248, 22)
        Me.txtMorada.TabIndex = 33
        '
        'txtPais
        '
        Me.txtPais.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPais.Location = New System.Drawing.Point(128, 375)
        Me.txtPais.Name = "txtPais"
        Me.txtPais.Size = New System.Drawing.Size(248, 22)
        Me.txtPais.TabIndex = 32
        '
        'txtSigla
        '
        Me.txtSigla.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSigla.Location = New System.Drawing.Point(128, 264)
        Me.txtSigla.Name = "txtSigla"
        Me.txtSigla.Size = New System.Drawing.Size(248, 22)
        Me.txtSigla.TabIndex = 31
        '
        'txtTelefone
        '
        Me.txtTelefone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTelefone.Location = New System.Drawing.Point(128, 188)
        Me.txtTelefone.Name = "txtTelefone"
        Me.txtTelefone.Size = New System.Drawing.Size(248, 22)
        Me.txtTelefone.TabIndex = 30
        '
        'txtEmail
        '
        Me.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEmail.Location = New System.Drawing.Point(128, 146)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(248, 22)
        Me.txtEmail.TabIndex = 29
        '
        'txtDescrição
        '
        Me.txtDescrição.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDescrição.Location = New System.Drawing.Point(128, 108)
        Me.txtDescrição.Name = "txtDescrição"
        Me.txtDescrição.Size = New System.Drawing.Size(248, 22)
        Me.txtDescrição.TabIndex = 28
        '
        'txtNome
        '
        Me.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNome.Location = New System.Drawing.Point(128, 70)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(248, 22)
        Me.txtNome.TabIndex = 27
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
        'TBIDFE
        '
        Me.TBIDFE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TBIDFE.Location = New System.Drawing.Point(228, 31)
        Me.TBIDFE.Name = "TBIDFE"
        Me.TBIDFE.ReadOnly = True
        Me.TBIDFE.Size = New System.Drawing.Size(71, 22)
        Me.TBIDFE.TabIndex = 18
        Me.TBIDFE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(182, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 16)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "IDFE:"
        '
        'LBEntidade
        '
        Me.LBEntidade.FormattingEnabled = True
        Me.LBEntidade.ItemHeight = 16
        Me.LBEntidade.Location = New System.Drawing.Point(9, 43)
        Me.LBEntidade.Name = "LBEntidade"
        Me.LBEntidade.Size = New System.Drawing.Size(248, 452)
        Me.LBEntidade.TabIndex = 31
        '
        'txtPesquisa
        '
        Me.txtPesquisa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPesquisa.Location = New System.Drawing.Point(9, 12)
        Me.txtPesquisa.Name = "txtPesquisa"
        Me.txtPesquisa.Size = New System.Drawing.Size(248, 22)
        Me.txtPesquisa.TabIndex = 30
        '
        'Alterar_Entidade
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(688, 507)
        Me.Controls.Add(Me.GBValoresFinanciadores)
        Me.Controls.Add(Me.LBEntidade)
        Me.Controls.Add(Me.txtPesquisa)
        Me.Name = "Alterar_Entidade"
        Me.Text = "Alterar_Entidade"
        Me.GBValoresFinanciadores.ResumeLayout(False)
        Me.GBValoresFinanciadores.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GBValoresFinanciadores As GroupBox
    Friend WithEvents TBIDFE As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents bAlterar As Button
    Friend WithEvents LBEntidade As ListBox
    Friend WithEvents txtPesquisa As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtDesignação As TextBox
    Friend WithEvents txtURL As TextBox
    Friend WithEvents txtMorada As TextBox
    Friend WithEvents txtPais As TextBox
    Friend WithEvents txtSigla As TextBox
    Friend WithEvents txtTelefone As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtDescrição As TextBox
    Friend WithEvents txtNome As TextBox
    Friend WithEvents Label10 As Label
End Class
