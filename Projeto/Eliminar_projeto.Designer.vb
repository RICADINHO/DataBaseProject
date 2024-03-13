<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Eliminar_projeto
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
        Me.bEliminar = New System.Windows.Forms.Button()
        Me.CLBProjeto = New System.Windows.Forms.CheckedListBox()
        Me.txtPesquisa = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'bEliminar
        '
        Me.bEliminar.Location = New System.Drawing.Point(12, 348)
        Me.bEliminar.Name = "bEliminar"
        Me.bEliminar.Size = New System.Drawing.Size(256, 23)
        Me.bEliminar.TabIndex = 29
        Me.bEliminar.Text = "Eliminar"
        Me.bEliminar.UseVisualStyleBackColor = True
        '
        'CLBProjeto
        '
        Me.CLBProjeto.FormattingEnabled = True
        Me.CLBProjeto.Location = New System.Drawing.Point(12, 32)
        Me.CLBProjeto.Name = "CLBProjeto"
        Me.CLBProjeto.Size = New System.Drawing.Size(256, 310)
        Me.CLBProjeto.TabIndex = 28
        '
        'txtPesquisa
        '
        Me.txtPesquisa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPesquisa.Location = New System.Drawing.Point(12, 4)
        Me.txtPesquisa.Name = "txtPesquisa"
        Me.txtPesquisa.Size = New System.Drawing.Size(256, 22)
        Me.txtPesquisa.TabIndex = 27
        '
        'Eliminar_projeto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(278, 379)
        Me.Controls.Add(Me.bEliminar)
        Me.Controls.Add(Me.CLBProjeto)
        Me.Controls.Add(Me.txtPesquisa)
        Me.Name = "Eliminar_projeto"
        Me.Text = "Eliminar_projeto"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents bEliminar As Button
    Friend WithEvents CLBProjeto As CheckedListBox
    Friend WithEvents txtPesquisa As TextBox
End Class
