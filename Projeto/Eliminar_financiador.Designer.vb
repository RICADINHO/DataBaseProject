<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Eliminar_financiador
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
        Me.CLBFinanciadores = New System.Windows.Forms.CheckedListBox()
        Me.txtPesquisa = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'bEliminar
        '
        Me.bEliminar.Location = New System.Drawing.Point(12, 361)
        Me.bEliminar.Name = "bEliminar"
        Me.bEliminar.Size = New System.Drawing.Size(256, 23)
        Me.bEliminar.TabIndex = 23
        Me.bEliminar.Text = "Eliminar"
        Me.bEliminar.UseVisualStyleBackColor = True
        '
        'CLBFinanciadores
        '
        Me.CLBFinanciadores.FormattingEnabled = True
        Me.CLBFinanciadores.Location = New System.Drawing.Point(12, 36)
        Me.CLBFinanciadores.Name = "CLBFinanciadores"
        Me.CLBFinanciadores.Size = New System.Drawing.Size(256, 310)
        Me.CLBFinanciadores.TabIndex = 22
        '
        'txtPesquisa
        '
        Me.txtPesquisa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPesquisa.Location = New System.Drawing.Point(12, 8)
        Me.txtPesquisa.Name = "txtPesquisa"
        Me.txtPesquisa.Size = New System.Drawing.Size(256, 22)
        Me.txtPesquisa.TabIndex = 21
        '
        'Eliminar_financiador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(278, 389)
        Me.Controls.Add(Me.bEliminar)
        Me.Controls.Add(Me.CLBFinanciadores)
        Me.Controls.Add(Me.txtPesquisa)
        Me.Name = "Eliminar_financiador"
        Me.Text = "Eliminar_financiador"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents bEliminar As Button
    Friend WithEvents CLBFinanciadores As CheckedListBox
    Friend WithEvents txtPesquisa As TextBox
End Class
