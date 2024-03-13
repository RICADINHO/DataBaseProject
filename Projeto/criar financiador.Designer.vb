<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class criar_financiador
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.txtQuantidade_doada = New System.Windows.Forms.TextBox()
        Me.bCriar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbxTipo = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 16)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Nome:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(26, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(123, 16)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Quantidade doada:"
        '
        'txtNome
        '
        Me.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNome.Location = New System.Drawing.Point(177, 24)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(248, 22)
        Me.txtNome.TabIndex = 13
        '
        'txtQuantidade_doada
        '
        Me.txtQuantidade_doada.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtQuantidade_doada.Location = New System.Drawing.Point(177, 70)
        Me.txtQuantidade_doada.Name = "txtQuantidade_doada"
        Me.txtQuantidade_doada.Size = New System.Drawing.Size(248, 22)
        Me.txtQuantidade_doada.TabIndex = 14
        '
        'bCriar
        '
        Me.bCriar.Enabled = False
        Me.bCriar.Location = New System.Drawing.Point(232, 167)
        Me.bCriar.Name = "bCriar"
        Me.bCriar.Size = New System.Drawing.Size(147, 48)
        Me.bCriar.TabIndex = 16
        Me.bCriar.Text = "Criar"
        Me.bCriar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 124)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 16)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Tipo:"
        '
        'cbxTipo
        '
        Me.cbxTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxTipo.FormattingEnabled = True
        Me.cbxTipo.Location = New System.Drawing.Point(246, 124)
        Me.cbxTipo.Name = "cbxTipo"
        Me.cbxTipo.Size = New System.Drawing.Size(121, 24)
        Me.cbxTipo.TabIndex = 18
        Me.cbxTipo.TabStop = False
        '
        'criar_financiador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(447, 230)
        Me.Controls.Add(Me.cbxTipo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.bCriar)
        Me.Controls.Add(Me.txtQuantidade_doada)
        Me.Controls.Add(Me.txtNome)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Name = "criar_financiador"
        Me.Text = "criar_financiador"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtNome As TextBox
    Friend WithEvents txtQuantidade_doada As TextBox
    Friend WithEvents bCriar As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents cbxTipo As ComboBox
End Class
