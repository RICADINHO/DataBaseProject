<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Alterar_Programa
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
        Me.GBValoresMembros = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TBIDFP = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TBNome = New System.Windows.Forms.TextBox()
        Me.bAlterar = New System.Windows.Forms.Button()
        Me.LBProgramas = New System.Windows.Forms.ListBox()
        Me.txtPesquisa = New System.Windows.Forms.TextBox()
        Me.GBValoresMembros.SuspendLayout()
        Me.SuspendLayout()
        '
        'GBValoresMembros
        '
        Me.GBValoresMembros.Controls.Add(Me.Label2)
        Me.GBValoresMembros.Controls.Add(Me.TBIDFP)
        Me.GBValoresMembros.Controls.Add(Me.Label1)
        Me.GBValoresMembros.Controls.Add(Me.TBNome)
        Me.GBValoresMembros.Controls.Add(Me.bAlterar)
        Me.GBValoresMembros.Location = New System.Drawing.Point(278, 12)
        Me.GBValoresMembros.Name = "GBValoresMembros"
        Me.GBValoresMembros.Size = New System.Drawing.Size(325, 355)
        Me.GBValoresMembros.TabIndex = 29
        Me.GBValoresMembros.TabStop = False
        Me.GBValoresMembros.Text = "Valores"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(148, 92)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 16)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Nome:"
        '
        'TBIDFP
        '
        Me.TBIDFP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TBIDFP.Location = New System.Drawing.Point(138, 45)
        Me.TBIDFP.Name = "TBIDFP"
        Me.TBIDFP.ReadOnly = True
        Me.TBIDFP.Size = New System.Drawing.Size(71, 22)
        Me.TBIDFP.TabIndex = 18
        Me.TBIDFP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(98, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 16)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "IDFP:"
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
        Me.bAlterar.Location = New System.Drawing.Point(101, 139)
        Me.bAlterar.Name = "bAlterar"
        Me.bAlterar.Size = New System.Drawing.Size(147, 48)
        Me.bAlterar.TabIndex = 16
        Me.bAlterar.Text = "Alterar"
        Me.bAlterar.UseVisualStyleBackColor = True
        '
        'LBProgramas
        '
        Me.LBProgramas.FormattingEnabled = True
        Me.LBProgramas.ItemHeight = 16
        Me.LBProgramas.Location = New System.Drawing.Point(11, 43)
        Me.LBProgramas.Name = "LBProgramas"
        Me.LBProgramas.Size = New System.Drawing.Size(248, 324)
        Me.LBProgramas.TabIndex = 28
        '
        'txtPesquisa
        '
        Me.txtPesquisa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPesquisa.Location = New System.Drawing.Point(11, 12)
        Me.txtPesquisa.Name = "txtPesquisa"
        Me.txtPesquisa.Size = New System.Drawing.Size(248, 22)
        Me.txtPesquisa.TabIndex = 27
        '
        'Alterar_Programa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(615, 374)
        Me.Controls.Add(Me.GBValoresMembros)
        Me.Controls.Add(Me.LBProgramas)
        Me.Controls.Add(Me.txtPesquisa)
        Me.Name = "Alterar_Programa"
        Me.Text = "Alterar_Programa"
        Me.GBValoresMembros.ResumeLayout(False)
        Me.GBValoresMembros.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GBValoresMembros As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TBIDFP As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TBNome As TextBox
    Friend WithEvents bAlterar As Button
    Friend WithEvents LBProgramas As ListBox
    Friend WithEvents txtPesquisa As TextBox
End Class
