<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Alterar_Membro
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
        Me.txtPesquisa = New System.Windows.Forms.TextBox()
        Me.bAlterar = New System.Windows.Forms.Button()
        Me.TBIDM = New System.Windows.Forms.TextBox()
        Me.TBTempoDedicado = New System.Windows.Forms.TextBox()
        Me.TBAfetaçãoProjeto = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LBMembros = New System.Windows.Forms.ListBox()
        Me.GBValoresMembros = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TBTempoTotal = New System.Windows.Forms.TextBox()
        Me.GBValoresMembros.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtPesquisa
        '
        Me.txtPesquisa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPesquisa.Location = New System.Drawing.Point(12, 7)
        Me.txtPesquisa.Name = "txtPesquisa"
        Me.txtPesquisa.Size = New System.Drawing.Size(248, 22)
        Me.txtPesquisa.TabIndex = 17
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
        'TBIDM
        '
        Me.TBIDM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TBIDM.Location = New System.Drawing.Point(138, 45)
        Me.TBIDM.Name = "TBIDM"
        Me.TBIDM.ReadOnly = True
        Me.TBIDM.Size = New System.Drawing.Size(71, 22)
        Me.TBIDM.TabIndex = 18
        Me.TBIDM.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TBTempoDedicado
        '
        Me.TBTempoDedicado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TBTempoDedicado.Location = New System.Drawing.Point(45, 111)
        Me.TBTempoDedicado.Name = "TBTempoDedicado"
        Me.TBTempoDedicado.Size = New System.Drawing.Size(248, 22)
        Me.TBTempoDedicado.TabIndex = 19
        '
        'TBAfetaçãoProjeto
        '
        Me.TBAfetaçãoProjeto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TBAfetaçãoProjeto.Location = New System.Drawing.Point(45, 174)
        Me.TBAfetaçãoProjeto.Name = "TBAfetaçãoProjeto"
        Me.TBAfetaçãoProjeto.Size = New System.Drawing.Size(248, 22)
        Me.TBAfetaçãoProjeto.TabIndex = 20
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(98, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 16)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "IDM:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(98, 92)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(140, 16)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Tempo Dedicado (%):"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(88, 155)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(151, 16)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Afetação no Projeto (%):"
        '
        'LBMembros
        '
        Me.LBMembros.FormattingEnabled = True
        Me.LBMembros.ItemHeight = 16
        Me.LBMembros.Location = New System.Drawing.Point(12, 38)
        Me.LBMembros.Name = "LBMembros"
        Me.LBMembros.Size = New System.Drawing.Size(248, 324)
        Me.LBMembros.TabIndex = 25
        '
        'GBValoresMembros
        '
        Me.GBValoresMembros.Controls.Add(Me.Label4)
        Me.GBValoresMembros.Controls.Add(Me.TBTempoTotal)
        Me.GBValoresMembros.Controls.Add(Me.Label3)
        Me.GBValoresMembros.Controls.Add(Me.Label2)
        Me.GBValoresMembros.Controls.Add(Me.TBIDM)
        Me.GBValoresMembros.Controls.Add(Me.Label1)
        Me.GBValoresMembros.Controls.Add(Me.TBAfetaçãoProjeto)
        Me.GBValoresMembros.Controls.Add(Me.TBTempoDedicado)
        Me.GBValoresMembros.Controls.Add(Me.bAlterar)
        Me.GBValoresMembros.Location = New System.Drawing.Point(279, 7)
        Me.GBValoresMembros.Name = "GBValoresMembros"
        Me.GBValoresMembros.Size = New System.Drawing.Size(325, 355)
        Me.GBValoresMembros.TabIndex = 26
        Me.GBValoresMembros.TabStop = False
        Me.GBValoresMembros.Text = "Valores"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(121, 214)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 16)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "Tempo Total:"
        '
        'TBTempoTotal
        '
        Me.TBTempoTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TBTempoTotal.Location = New System.Drawing.Point(45, 233)
        Me.TBTempoTotal.Name = "TBTempoTotal"
        Me.TBTempoTotal.Size = New System.Drawing.Size(248, 22)
        Me.TBTempoTotal.TabIndex = 25
        Me.TBTempoTotal.Text = "hh:mm:ss"
        '
        'Alterar_Membro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(616, 368)
        Me.Controls.Add(Me.GBValoresMembros)
        Me.Controls.Add(Me.LBMembros)
        Me.Controls.Add(Me.txtPesquisa)
        Me.Name = "Alterar_Membro"
        Me.Text = "Alterar_Membro"
        Me.GBValoresMembros.ResumeLayout(False)
        Me.GBValoresMembros.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtPesquisa As TextBox
    Friend WithEvents bAlterar As Button
    Friend WithEvents TBIDM As TextBox
    Friend WithEvents TBTempoDedicado As TextBox
    Friend WithEvents TBAfetaçãoProjeto As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents LBMembros As ListBox
    Friend WithEvents GBValoresMembros As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TBTempoTotal As TextBox
End Class
