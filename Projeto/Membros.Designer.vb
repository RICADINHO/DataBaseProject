﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Membros
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
        Me.dgvData = New System.Windows.Forms.DataGridView()
        Me.txtProcura = New System.Windows.Forms.TextBox()
        Me.cmdProcura = New System.Windows.Forms.Button()
        CType(Me.dgvData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvData
        '
        Me.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvData.Location = New System.Drawing.Point(12, 47)
        Me.dgvData.Name = "dgvData"
        Me.dgvData.RowHeadersWidth = 51
        Me.dgvData.RowTemplate.Height = 24
        Me.dgvData.Size = New System.Drawing.Size(1358, 572)
        Me.dgvData.TabIndex = 0
        '
        'txtProcura
        '
        Me.txtProcura.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtProcura.Location = New System.Drawing.Point(12, 12)
        Me.txtProcura.Name = "txtProcura"
        Me.txtProcura.Size = New System.Drawing.Size(146, 22)
        Me.txtProcura.TabIndex = 1
        '
        'cmdProcura
        '
        Me.cmdProcura.Location = New System.Drawing.Point(164, 11)
        Me.cmdProcura.Name = "cmdProcura"
        Me.cmdProcura.Size = New System.Drawing.Size(100, 28)
        Me.cmdProcura.TabIndex = 2
        Me.cmdProcura.Text = "Procurar"
        Me.cmdProcura.UseVisualStyleBackColor = True
        '
        'Membros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1030, 612)
        Me.Controls.Add(Me.cmdProcura)
        Me.Controls.Add(Me.txtProcura)
        Me.Controls.Add(Me.dgvData)
        Me.Name = "Membros"
        Me.Text = "Membros"
        CType(Me.dgvData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvData As DataGridView
    Friend WithEvents txtProcura As TextBox
    Friend WithEvents cmdProcura As Button
End Class
