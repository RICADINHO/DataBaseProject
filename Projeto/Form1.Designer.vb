<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.msMain = New System.Windows.Forms.MenuStrip()
        Me.bProjetos = New System.Windows.Forms.ToolStripMenuItem()
        Me.CirarProjetoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AlterarProjetoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarProjetoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListaDeProjetosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.bMembros = New System.Windows.Forms.ToolStripMenuItem()
        Me.bCriarMembro = New System.Windows.Forms.ToolStripMenuItem()
        Me.bAlterarMembros = New System.Windows.Forms.ToolStripMenuItem()
        Me.bEliminarMembros = New System.Windows.Forms.ToolStripMenuItem()
        Me.bVLM = New System.Windows.Forms.ToolStripMenuItem()
        Me.EntidadesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CriarEntidadesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AlterarEntidadeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarEntidadeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerListaDeEntidadesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FinanciadoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdicionarFinanciador = New System.Windows.Forms.ToolStripMenuItem()
        Me.AlterarFinanciador = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarFinanciador = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerListaDeFinanciadores = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProjetosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CriarPrograma = New System.Windows.Forms.ToolStripMenuItem()
        Me.AlterarPrograma = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarPrograma = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListaDeProgramas = New System.Windows.Forms.ToolStripMenuItem()
        Me.Entidade = New System.Windows.Forms.ToolStripMenuItem()
        Me.CriarEntidade = New System.Windows.Forms.ToolStripMenuItem()
        Me.AlterarEntidade = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarEntidade = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListaEntidades = New System.Windows.Forms.ToolStripMenuItem()
        Me.msMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'msMain
        '
        Me.msMain.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.msMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.bProjetos, Me.bMembros, Me.EntidadesToolStripMenuItem, Me.FinanciadoresToolStripMenuItem, Me.ProjetosToolStripMenuItem, Me.Entidade})
        Me.msMain.Location = New System.Drawing.Point(0, 0)
        Me.msMain.Name = "msMain"
        Me.msMain.Size = New System.Drawing.Size(1582, 28)
        Me.msMain.TabIndex = 1
        Me.msMain.Text = "MenuStrip1"
        '
        'bProjetos
        '
        Me.bProjetos.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CirarProjetoToolStripMenuItem, Me.AlterarProjetoToolStripMenuItem, Me.EliminarProjetoToolStripMenuItem, Me.ListaDeProjetosToolStripMenuItem})
        Me.bProjetos.Name = "bProjetos"
        Me.bProjetos.Size = New System.Drawing.Size(77, 24)
        Me.bProjetos.Text = "Projetos"
        '
        'CirarProjetoToolStripMenuItem
        '
        Me.CirarProjetoToolStripMenuItem.Name = "CirarProjetoToolStripMenuItem"
        Me.CirarProjetoToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.CirarProjetoToolStripMenuItem.Text = "Criar Projeto"
        '
        'AlterarProjetoToolStripMenuItem
        '
        Me.AlterarProjetoToolStripMenuItem.Name = "AlterarProjetoToolStripMenuItem"
        Me.AlterarProjetoToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.AlterarProjetoToolStripMenuItem.Text = "Alterar Projeto"
        '
        'EliminarProjetoToolStripMenuItem
        '
        Me.EliminarProjetoToolStripMenuItem.Name = "EliminarProjetoToolStripMenuItem"
        Me.EliminarProjetoToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.EliminarProjetoToolStripMenuItem.Text = "Eliminar Projeto"
        '
        'ListaDeProjetosToolStripMenuItem
        '
        Me.ListaDeProjetosToolStripMenuItem.Name = "ListaDeProjetosToolStripMenuItem"
        Me.ListaDeProjetosToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.ListaDeProjetosToolStripMenuItem.Text = "Lista de Projetos"
        '
        'bMembros
        '
        Me.bMembros.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.bCriarMembro, Me.bAlterarMembros, Me.bEliminarMembros, Me.bVLM})
        Me.bMembros.Name = "bMembros"
        Me.bMembros.Size = New System.Drawing.Size(86, 24)
        Me.bMembros.Text = "Membros"
        '
        'bCriarMembro
        '
        Me.bCriarMembro.Name = "bCriarMembro"
        Me.bCriarMembro.Size = New System.Drawing.Size(210, 26)
        Me.bCriarMembro.Text = "Criar Membro"
        '
        'bAlterarMembros
        '
        Me.bAlterarMembros.Name = "bAlterarMembros"
        Me.bAlterarMembros.Size = New System.Drawing.Size(210, 26)
        Me.bAlterarMembros.Text = "Alterar Membro"
        '
        'bEliminarMembros
        '
        Me.bEliminarMembros.Name = "bEliminarMembros"
        Me.bEliminarMembros.Size = New System.Drawing.Size(210, 26)
        Me.bEliminarMembros.Text = "Eliminar Membro"
        '
        'bVLM
        '
        Me.bVLM.Name = "bVLM"
        Me.bVLM.Size = New System.Drawing.Size(210, 26)
        Me.bVLM.Text = "Lista de Membros"
        '
        'EntidadesToolStripMenuItem
        '
        Me.EntidadesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CriarEntidadesToolStripMenuItem, Me.AlterarEntidadeToolStripMenuItem, Me.EliminarEntidadeToolStripMenuItem, Me.VerListaDeEntidadesToolStripMenuItem})
        Me.EntidadesToolStripMenuItem.Name = "EntidadesToolStripMenuItem"
        Me.EntidadesToolStripMenuItem.Size = New System.Drawing.Size(88, 24)
        Me.EntidadesToolStripMenuItem.Text = "Entidades"
        '
        'CriarEntidadesToolStripMenuItem
        '
        Me.CriarEntidadesToolStripMenuItem.Name = "CriarEntidadesToolStripMenuItem"
        Me.CriarEntidadesToolStripMenuItem.Size = New System.Drawing.Size(212, 26)
        Me.CriarEntidadesToolStripMenuItem.Text = "Criar Entidade"
        '
        'AlterarEntidadeToolStripMenuItem
        '
        Me.AlterarEntidadeToolStripMenuItem.Name = "AlterarEntidadeToolStripMenuItem"
        Me.AlterarEntidadeToolStripMenuItem.Size = New System.Drawing.Size(212, 26)
        Me.AlterarEntidadeToolStripMenuItem.Text = "Alterar Entidade"
        '
        'EliminarEntidadeToolStripMenuItem
        '
        Me.EliminarEntidadeToolStripMenuItem.Name = "EliminarEntidadeToolStripMenuItem"
        Me.EliminarEntidadeToolStripMenuItem.Size = New System.Drawing.Size(212, 26)
        Me.EliminarEntidadeToolStripMenuItem.Text = "Eliminar Entidade"
        '
        'VerListaDeEntidadesToolStripMenuItem
        '
        Me.VerListaDeEntidadesToolStripMenuItem.Name = "VerListaDeEntidadesToolStripMenuItem"
        Me.VerListaDeEntidadesToolStripMenuItem.Size = New System.Drawing.Size(212, 26)
        Me.VerListaDeEntidadesToolStripMenuItem.Text = "Lista de Entidades"
        '
        'FinanciadoresToolStripMenuItem
        '
        Me.FinanciadoresToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AdicionarFinanciador, Me.AlterarFinanciador, Me.EliminarFinanciador, Me.VerListaDeFinanciadores})
        Me.FinanciadoresToolStripMenuItem.Name = "FinanciadoresToolStripMenuItem"
        Me.FinanciadoresToolStripMenuItem.Size = New System.Drawing.Size(114, 24)
        Me.FinanciadoresToolStripMenuItem.Text = "Financiadores"
        '
        'AdicionarFinanciador
        '
        Me.AdicionarFinanciador.Name = "AdicionarFinanciador"
        Me.AdicionarFinanciador.Size = New System.Drawing.Size(238, 26)
        Me.AdicionarFinanciador.Text = "Criar Financiador"
        '
        'AlterarFinanciador
        '
        Me.AlterarFinanciador.Name = "AlterarFinanciador"
        Me.AlterarFinanciador.Size = New System.Drawing.Size(238, 26)
        Me.AlterarFinanciador.Text = "Alterar Financiador"
        '
        'EliminarFinanciador
        '
        Me.EliminarFinanciador.Name = "EliminarFinanciador"
        Me.EliminarFinanciador.Size = New System.Drawing.Size(238, 26)
        Me.EliminarFinanciador.Text = "Eliminar Financiador"
        '
        'VerListaDeFinanciadores
        '
        Me.VerListaDeFinanciadores.Name = "VerListaDeFinanciadores"
        Me.VerListaDeFinanciadores.Size = New System.Drawing.Size(238, 26)
        Me.VerListaDeFinanciadores.Text = "Lista de Financiadores"
        '
        'ProjetosToolStripMenuItem
        '
        Me.ProjetosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CriarPrograma, Me.AlterarPrograma, Me.EliminarPrograma, Me.ListaDeProgramas})
        Me.ProjetosToolStripMenuItem.Name = "ProjetosToolStripMenuItem"
        Me.ProjetosToolStripMenuItem.Size = New System.Drawing.Size(94, 24)
        Me.ProjetosToolStripMenuItem.Text = "Programas"
        '
        'CriarPrograma
        '
        Me.CriarPrograma.Name = "CriarPrograma"
        Me.CriarPrograma.Size = New System.Drawing.Size(218, 26)
        Me.CriarPrograma.Text = "Criar Programa"
        '
        'AlterarPrograma
        '
        Me.AlterarPrograma.Name = "AlterarPrograma"
        Me.AlterarPrograma.Size = New System.Drawing.Size(218, 26)
        Me.AlterarPrograma.Text = "Alterar Programa"
        '
        'EliminarPrograma
        '
        Me.EliminarPrograma.Name = "EliminarPrograma"
        Me.EliminarPrograma.Size = New System.Drawing.Size(218, 26)
        Me.EliminarPrograma.Text = "Eliminar Programa"
        '
        'ListaDeProgramas
        '
        Me.ListaDeProgramas.Name = "ListaDeProgramas"
        Me.ListaDeProgramas.Size = New System.Drawing.Size(218, 26)
        Me.ListaDeProgramas.Text = "Lista de Programas"
        '
        'Entidade
        '
        Me.Entidade.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CriarEntidade, Me.AlterarEntidade, Me.EliminarEntidade, Me.ListaEntidades})
        Me.Entidade.Name = "Entidade"
        Me.Entidade.Size = New System.Drawing.Size(82, 24)
        Me.Entidade.Text = "Entidade"
        '
        'CriarEntidade
        '
        Me.CriarEntidade.Name = "CriarEntidade"
        Me.CriarEntidade.Size = New System.Drawing.Size(212, 26)
        Me.CriarEntidade.Text = "Criar Entidade"
        '
        'AlterarEntidade
        '
        Me.AlterarEntidade.Name = "AlterarEntidade"
        Me.AlterarEntidade.Size = New System.Drawing.Size(212, 26)
        Me.AlterarEntidade.Text = "Alterar Entidade"
        '
        'EliminarEntidade
        '
        Me.EliminarEntidade.Name = "EliminarEntidade"
        Me.EliminarEntidade.Size = New System.Drawing.Size(212, 26)
        Me.EliminarEntidade.Text = "Eliminar Entidade"
        '
        'ListaEntidades
        '
        Me.ListaEntidades.Name = "ListaEntidades"
        Me.ListaEntidades.Size = New System.Drawing.Size(212, 26)
        Me.ListaEntidades.Text = "Lista de Entidades"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1582, 953)
        Me.Controls.Add(Me.msMain)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.msMain
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.msMain.ResumeLayout(False)
        Me.msMain.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents msMain As MenuStrip
    Friend WithEvents bProjetos As ToolStripMenuItem
    Friend WithEvents bMembros As ToolStripMenuItem
    Friend WithEvents bEliminarMembros As ToolStripMenuItem
    Friend WithEvents bAlterarMembros As ToolStripMenuItem
    Friend WithEvents bCriarMembro As ToolStripMenuItem
    Friend WithEvents bVLM As ToolStripMenuItem
    Friend WithEvents EntidadesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CriarEntidadesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AlterarEntidadeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EliminarEntidadeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VerListaDeEntidadesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FinanciadoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AdicionarFinanciador As ToolStripMenuItem
    Friend WithEvents AlterarFinanciador As ToolStripMenuItem
    Friend WithEvents EliminarFinanciador As ToolStripMenuItem
    Friend WithEvents VerListaDeFinanciadores As ToolStripMenuItem
    Friend WithEvents ProjetosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CriarPrograma As ToolStripMenuItem
    Friend WithEvents AlterarPrograma As ToolStripMenuItem
    Friend WithEvents EliminarPrograma As ToolStripMenuItem
    Friend WithEvents ListaDeProgramas As ToolStripMenuItem
    Friend WithEvents Entidade As ToolStripMenuItem
    Friend WithEvents CriarEntidade As ToolStripMenuItem
    Friend WithEvents EliminarEntidade As ToolStripMenuItem
    Friend WithEvents AlterarEntidade As ToolStripMenuItem
    Friend WithEvents ListaEntidades As ToolStripMenuItem
    Friend WithEvents CirarProjetoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListaDeProjetosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AlterarProjetoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EliminarProjetoToolStripMenuItem As ToolStripMenuItem
End Class
