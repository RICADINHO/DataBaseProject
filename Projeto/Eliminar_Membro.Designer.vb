<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Eliminar_Membro
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
        Me.txtPesquisa = New System.Windows.Forms.TextBox()
        Me.CLBMembros = New System.Windows.Forms.CheckedListBox()
        Me.bEliminar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtPesquisa
        '
        Me.txtPesquisa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPesquisa.Location = New System.Drawing.Point(12, 12)
        Me.txtPesquisa.Name = "txtPesquisa"
        Me.txtPesquisa.Size = New System.Drawing.Size(256, 22)
        Me.txtPesquisa.TabIndex = 18
        '
        'CLBMembros
        '
        Me.CLBMembros.FormattingEnabled = True
        Me.CLBMembros.Location = New System.Drawing.Point(12, 40)
        Me.CLBMembros.Name = "CLBMembros"
        Me.CLBMembros.Size = New System.Drawing.Size(256, 310)
        Me.CLBMembros.TabIndex = 19
        '
        'bEliminar
        '
        Me.bEliminar.Location = New System.Drawing.Point(12, 365)
        Me.bEliminar.Name = "bEliminar"
        Me.bEliminar.Size = New System.Drawing.Size(256, 23)
        Me.bEliminar.TabIndex = 20
        Me.bEliminar.Text = "Eliminar"
        Me.bEliminar.UseVisualStyleBackColor = True
        '
        'Eliminar_Membro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(280, 400)
        Me.Controls.Add(Me.bEliminar)
        Me.Controls.Add(Me.CLBMembros)
        Me.Controls.Add(Me.txtPesquisa)
        Me.Name = "Eliminar_Membro"
        Me.Text = "Eliminar_Membro"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtPesquisa As TextBox
    Friend WithEvents CLBMembros As CheckedListBox
    Friend WithEvents bEliminar As Button
End Class
