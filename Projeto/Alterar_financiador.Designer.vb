<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Alterar_financiador
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TBIDF = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TBQuantidadeDoada = New System.Windows.Forms.TextBox()
        Me.TBNome = New System.Windows.Forms.TextBox()
        Me.bAlterar = New System.Windows.Forms.Button()
        Me.LBFinanciadores = New System.Windows.Forms.ListBox()
        Me.txtPesquisa = New System.Windows.Forms.TextBox()
        Me.cbxTipo = New System.Windows.Forms.ComboBox()
        Me.GBValoresFinanciadores.SuspendLayout()
        Me.SuspendLayout()
        '
        'GBValoresFinanciadores
        '
        Me.GBValoresFinanciadores.Controls.Add(Me.cbxTipo)
        Me.GBValoresFinanciadores.Controls.Add(Me.Label4)
        Me.GBValoresFinanciadores.Controls.Add(Me.Label3)
        Me.GBValoresFinanciadores.Controls.Add(Me.Label2)
        Me.GBValoresFinanciadores.Controls.Add(Me.TBIDF)
        Me.GBValoresFinanciadores.Controls.Add(Me.Label1)
        Me.GBValoresFinanciadores.Controls.Add(Me.TBQuantidadeDoada)
        Me.GBValoresFinanciadores.Controls.Add(Me.TBNome)
        Me.GBValoresFinanciadores.Controls.Add(Me.bAlterar)
        Me.GBValoresFinanciadores.Location = New System.Drawing.Point(277, 12)
        Me.GBValoresFinanciadores.Name = "GBValoresFinanciadores"
        Me.GBValoresFinanciadores.Size = New System.Drawing.Size(325, 355)
        Me.GBValoresFinanciadores.TabIndex = 29
        Me.GBValoresFinanciadores.TabStop = False
        Me.GBValoresFinanciadores.Text = "Valores"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(146, 218)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 16)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Tipo:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(115, 155)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(123, 16)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Quantidade doada:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(146, 92)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 16)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Nome:"
        '
        'TBIDF
        '
        Me.TBIDF.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TBIDF.Location = New System.Drawing.Point(138, 45)
        Me.TBIDF.Name = "TBIDF"
        Me.TBIDF.ReadOnly = True
        Me.TBIDF.Size = New System.Drawing.Size(71, 22)
        Me.TBIDF.TabIndex = 18
        Me.TBIDF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(98, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 16)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "IDF:"
        '
        'TBQuantidadeDoada
        '
        Me.TBQuantidadeDoada.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TBQuantidadeDoada.Location = New System.Drawing.Point(45, 174)
        Me.TBQuantidadeDoada.Name = "TBQuantidadeDoada"
        Me.TBQuantidadeDoada.Size = New System.Drawing.Size(248, 22)
        Me.TBQuantidadeDoada.TabIndex = 20
        '
        'TBNome
        '
        Me.TBNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TBNome.Location = New System.Drawing.Point(45, 111)
        Me.TBNome.Name = "TBNome"
        Me.TBNome.Size = New System.Drawing.Size(248, 22)
        Me.TBNome.TabIndex = 19
        '
        'bAlterar
        '
        Me.bAlterar.Enabled = False
        Me.bAlterar.Location = New System.Drawing.Point(91, 285)
        Me.bAlterar.Name = "bAlterar"
        Me.bAlterar.Size = New System.Drawing.Size(147, 48)
        Me.bAlterar.TabIndex = 16
        Me.bAlterar.Text = "Alterar"
        Me.bAlterar.UseVisualStyleBackColor = True
        '
        'LBFinanciadores
        '
        Me.LBFinanciadores.FormattingEnabled = True
        Me.LBFinanciadores.ItemHeight = 16
        Me.LBFinanciadores.Location = New System.Drawing.Point(10, 43)
        Me.LBFinanciadores.Name = "LBFinanciadores"
        Me.LBFinanciadores.Size = New System.Drawing.Size(248, 324)
        Me.LBFinanciadores.TabIndex = 28
        '
        'txtPesquisa
        '
        Me.txtPesquisa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPesquisa.Location = New System.Drawing.Point(10, 12)
        Me.txtPesquisa.Name = "txtPesquisa"
        Me.txtPesquisa.Size = New System.Drawing.Size(248, 22)
        Me.txtPesquisa.TabIndex = 27
        '
        'cbxTipo
        '
        Me.cbxTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxTipo.FormattingEnabled = True
        Me.cbxTipo.Location = New System.Drawing.Point(101, 237)
        Me.cbxTipo.Name = "cbxTipo"
        Me.cbxTipo.Size = New System.Drawing.Size(121, 24)
        Me.cbxTipo.TabIndex = 27
        Me.cbxTipo.TabStop = False
        '
        'Alterar_financiador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(623, 380)
        Me.Controls.Add(Me.GBValoresFinanciadores)
        Me.Controls.Add(Me.LBFinanciadores)
        Me.Controls.Add(Me.txtPesquisa)
        Me.Name = "Alterar_financiador"
        Me.Text = "Alterar_financiador"
        Me.GBValoresFinanciadores.ResumeLayout(False)
        Me.GBValoresFinanciadores.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GBValoresFinanciadores As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TBIDF As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TBQuantidadeDoada As TextBox
    Friend WithEvents TBNome As TextBox
    Friend WithEvents bAlterar As Button
    Friend WithEvents LBFinanciadores As ListBox
    Friend WithEvents txtPesquisa As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cbxTipo As ComboBox
End Class
