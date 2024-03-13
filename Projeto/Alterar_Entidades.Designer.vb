<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Alterar_Entidades
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TBInstituiçãoR = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TBIDE = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TBInvestigadorR = New System.Windows.Forms.TextBox()
        Me.bAlterar = New System.Windows.Forms.Button()
        Me.LBEntidades = New System.Windows.Forms.ListBox()
        Me.txtPesquisa = New System.Windows.Forms.TextBox()
        Me.GBValoresMembros.SuspendLayout()
        Me.SuspendLayout()
        '
        'GBValoresMembros
        '
        Me.GBValoresMembros.Controls.Add(Me.Label4)
        Me.GBValoresMembros.Controls.Add(Me.TBInstituiçãoR)
        Me.GBValoresMembros.Controls.Add(Me.Label2)
        Me.GBValoresMembros.Controls.Add(Me.TBIDE)
        Me.GBValoresMembros.Controls.Add(Me.Label1)
        Me.GBValoresMembros.Controls.Add(Me.TBInvestigadorR)
        Me.GBValoresMembros.Controls.Add(Me.bAlterar)
        Me.GBValoresMembros.Location = New System.Drawing.Point(280, 12)
        Me.GBValoresMembros.Name = "GBValoresMembros"
        Me.GBValoresMembros.Size = New System.Drawing.Size(325, 355)
        Me.GBValoresMembros.TabIndex = 29
        Me.GBValoresMembros.TabStop = False
        Me.GBValoresMembros.Text = "Valores"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(88, 189)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(156, 16)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "Instituição Responsável: "
        '
        'TBInstituiçãoR
        '
        Me.TBInstituiçãoR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TBInstituiçãoR.Location = New System.Drawing.Point(45, 208)
        Me.TBInstituiçãoR.Name = "TBInstituiçãoR"
        Me.TBInstituiçãoR.Size = New System.Drawing.Size(248, 22)
        Me.TBInstituiçãoR.TabIndex = 25
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(79, 103)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(171, 16)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Investigador Responsável: "
        '
        'TBIDE
        '
        Me.TBIDE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TBIDE.Location = New System.Drawing.Point(138, 45)
        Me.TBIDE.Name = "TBIDE"
        Me.TBIDE.ReadOnly = True
        Me.TBIDE.Size = New System.Drawing.Size(71, 22)
        Me.TBIDE.TabIndex = 18
        Me.TBIDE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(98, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 16)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "IDE:"
        '
        'TBInvestigadorR
        '
        Me.TBInvestigadorR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TBInvestigadorR.Location = New System.Drawing.Point(45, 122)
        Me.TBInvestigadorR.Name = "TBInvestigadorR"
        Me.TBInvestigadorR.Size = New System.Drawing.Size(248, 22)
        Me.TBInvestigadorR.TabIndex = 19
        '
        'bAlterar
        '
        Me.bAlterar.Enabled = False
        Me.bAlterar.Location = New System.Drawing.Point(91, 270)
        Me.bAlterar.Name = "bAlterar"
        Me.bAlterar.Size = New System.Drawing.Size(147, 48)
        Me.bAlterar.TabIndex = 16
        Me.bAlterar.Text = "Alterar"
        Me.bAlterar.UseVisualStyleBackColor = True
        '
        'LBEntidades
        '
        Me.LBEntidades.FormattingEnabled = True
        Me.LBEntidades.ItemHeight = 16
        Me.LBEntidades.Location = New System.Drawing.Point(12, 40)
        Me.LBEntidades.Name = "LBEntidades"
        Me.LBEntidades.Size = New System.Drawing.Size(248, 324)
        Me.LBEntidades.TabIndex = 28
        '
        'txtPesquisa
        '
        Me.txtPesquisa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPesquisa.Location = New System.Drawing.Point(12, 12)
        Me.txtPesquisa.Name = "txtPesquisa"
        Me.txtPesquisa.Size = New System.Drawing.Size(248, 22)
        Me.txtPesquisa.TabIndex = 27
        '
        'Alterar_Entidades
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(616, 368)
        Me.Controls.Add(Me.GBValoresMembros)
        Me.Controls.Add(Me.LBEntidades)
        Me.Controls.Add(Me.txtPesquisa)
        Me.Name = "Alterar_Entidades"
        Me.Text = "Alterar_Entidades"
        Me.GBValoresMembros.ResumeLayout(False)
        Me.GBValoresMembros.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GBValoresMembros As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TBInstituiçãoR As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TBIDE As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TBInvestigadorR As TextBox
    Friend WithEvents bAlterar As Button
    Friend WithEvents LBEntidades As ListBox
    Friend WithEvents txtPesquisa As TextBox
End Class
