<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Criar_Membro
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.bCriar = New System.Windows.Forms.Button()
        Me.txtTempoDedicado = New System.Windows.Forms.TextBox()
        Me.cbDI = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbxMembro_DI_funcao = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtTempoTotal = New System.Windows.Forms.TextBox()
        Me.txtAfetaçãoProjeto = New System.Windows.Forms.TextBox()
        Me.funcao = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'bCriar
        '
        Me.bCriar.Enabled = False
        Me.bCriar.Location = New System.Drawing.Point(263, 165)
        Me.bCriar.Name = "bCriar"
        Me.bCriar.Size = New System.Drawing.Size(147, 48)
        Me.bCriar.TabIndex = 0
        Me.bCriar.Text = "Criar"
        Me.bCriar.UseVisualStyleBackColor = True
        '
        'txtTempoDedicado
        '
        Me.txtTempoDedicado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTempoDedicado.Location = New System.Drawing.Point(178, 24)
        Me.txtTempoDedicado.Name = "txtTempoDedicado"
        Me.txtTempoDedicado.Size = New System.Drawing.Size(248, 22)
        Me.txtTempoDedicado.TabIndex = 1
        '
        'cbDI
        '
        Me.cbDI.AutoSize = True
        Me.cbDI.Location = New System.Drawing.Point(482, 48)
        Me.cbDI.Name = "cbDI"
        Me.cbDI.Size = New System.Drawing.Size(99, 20)
        Me.cbDI.TabIndex = 3
        Me.cbDI.Text = "Membro_DI"
        Me.cbDI.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(146, 16)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Tempo Dedicado (%) : "
        '
        'cbxMembro_DI_funcao
        '
        Me.cbxMembro_DI_funcao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxMembro_DI_funcao.Enabled = False
        Me.cbxMembro_DI_funcao.FormattingEnabled = True
        Me.cbxMembro_DI_funcao.Location = New System.Drawing.Point(471, 74)
        Me.cbxMembro_DI_funcao.Name = "cbxMembro_DI_funcao"
        Me.cbxMembro_DI_funcao.Size = New System.Drawing.Size(121, 24)
        Me.cbxMembro_DI_funcao.TabIndex = 7
        Me.cbxMembro_DI_funcao.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(23, 127)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 16)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Tempo Total :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 77)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(154, 16)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Afetação no Projeto (%): "
        '
        'txtTempoTotal
        '
        Me.txtTempoTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTempoTotal.Location = New System.Drawing.Point(178, 125)
        Me.txtTempoTotal.Name = "txtTempoTotal"
        Me.txtTempoTotal.Size = New System.Drawing.Size(248, 22)
        Me.txtTempoTotal.TabIndex = 9
        Me.txtTempoTotal.Text = "hh:mm:ss"
        '
        'txtAfetaçãoProjeto
        '
        Me.txtAfetaçãoProjeto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAfetaçãoProjeto.Location = New System.Drawing.Point(178, 74)
        Me.txtAfetaçãoProjeto.Name = "txtAfetaçãoProjeto"
        Me.txtAfetaçãoProjeto.Size = New System.Drawing.Size(248, 22)
        Me.txtAfetaçãoProjeto.TabIndex = 8
        '
        'funcao
        '
        Me.funcao.AutoSize = True
        Me.funcao.Location = New System.Drawing.Point(509, 101)
        Me.funcao.Name = "funcao"
        Me.funcao.Size = New System.Drawing.Size(48, 16)
        Me.funcao.TabIndex = 12
        Me.funcao.Text = "Label2"
        Me.funcao.Visible = False
        '
        'Criar_Membro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(616, 231)
        Me.Controls.Add(Me.funcao)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtTempoTotal)
        Me.Controls.Add(Me.txtAfetaçãoProjeto)
        Me.Controls.Add(Me.cbxMembro_DI_funcao)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbDI)
        Me.Controls.Add(Me.txtTempoDedicado)
        Me.Controls.Add(Me.bCriar)
        Me.Name = "Criar_Membro"
        Me.Text = "Criar_Membro"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents bCriar As Button
    Friend WithEvents txtTempoDedicado As TextBox
    Friend WithEvents cbDI As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cbxMembro_DI_funcao As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtTempoTotal As TextBox
    Friend WithEvents txtAfetaçãoProjeto As TextBox
    Friend WithEvents funcao As Label
End Class
