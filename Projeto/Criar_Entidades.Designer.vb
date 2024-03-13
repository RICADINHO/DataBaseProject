<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Criar_Entidades
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtInstituiçãoR = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtInvestigadorR = New System.Windows.Forms.TextBox()
        Me.bCriar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(156, 16)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Instituição Responsável: "
        '
        'txtInstituiçãoR
        '
        Me.txtInstituiçãoR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtInstituiçãoR.Location = New System.Drawing.Point(204, 68)
        Me.txtInstituiçãoR.Name = "txtInstituiçãoR"
        Me.txtInstituiçãoR.Size = New System.Drawing.Size(248, 22)
        Me.txtInstituiçãoR.TabIndex = 17
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(171, 16)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Investigador Responsável: "
        '
        'txtInvestigadorR
        '
        Me.txtInvestigadorR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtInvestigadorR.Location = New System.Drawing.Point(204, 17)
        Me.txtInvestigadorR.Name = "txtInvestigadorR"
        Me.txtInvestigadorR.Size = New System.Drawing.Size(248, 22)
        Me.txtInvestigadorR.TabIndex = 13
        '
        'bCriar
        '
        Me.bCriar.Enabled = False
        Me.bCriar.Location = New System.Drawing.Point(151, 123)
        Me.bCriar.Name = "bCriar"
        Me.bCriar.Size = New System.Drawing.Size(147, 48)
        Me.bCriar.TabIndex = 12
        Me.bCriar.Text = "Criar"
        Me.bCriar.UseVisualStyleBackColor = True
        '
        'Criar_Entidades
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(464, 196)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtInstituiçãoR)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtInvestigadorR)
        Me.Controls.Add(Me.bCriar)
        Me.Name = "Criar_Entidades"
        Me.Text = "Criar_Entidades"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents txtInstituiçãoR As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtInvestigadorR As TextBox
    Friend WithEvents bCriar As Button
End Class
