Imports System.Data.SqlClient
Public Class SQLControl
    'Executar a conecção com a DataBase do SQLServer
    Private Ligação As New SqlConnection("Server=DESKTOP-QEA81B5\SQLEXPRESS; Database=ttt;Trusted_Connection=True")
    Private Comando As SqlCommand

    'Criar Tabelas e Adaptador Vazios
    Public Adaptador As SqlDataAdapter
    Public Tabelas As DataTable
    'Criar uma Lista de Parâmetros Vazia
    Public Parâmetros As New List(Of SqlParameter)
    'Métodos Estatísticos da DataBase
    Public Contador As Integer
    Public Exceção As String

    'Default
    Public Sub New()
    End Sub
    'Permite ligar várias databases
    Public Sub New(ConnectionString As String)
        Ligação = New SqlConnection(ConnectionString)
    End Sub

    'Gestão de ações envolta da DataBase
    Public Sub Execute(Query As String)
        'Resetar Estatísticas das Querys
        Contador = 0
        Exceção = ""

        'Caso dê erro
        Try
            Ligação.Open()
            'Criar Comando
            Comando = New SqlCommand(Query, Ligação)
            'Carrega os parâmetros
            Parâmetros.ForEach(Sub(p) Comando.Parameters.Add(p))
            'Limpa a Lista de Parametros
            Parâmetros.Clear()
            'Executa os Comandos e preenche a DataBase
            Tabelas = New DataTable
            Adaptador = New SqlDataAdapter(Comando)
            Contador = Adaptador.Fill(Tabelas)

        Catch ex As Exception
            'Caso Detete Erro
            Exceção = "Erro de Execução de Query: " & vbNewLine & ex.Message
        Finally
            'Interrompe a Conecção
            If Ligação.State = ConnectionState.Open Then Ligação.Close()
        End Try
    End Sub

    'Adicionar Parâmetros
    Public Sub AdicionarParametros(Nome As String, Valor As Object)
        Dim NovoParâmetro As New SqlParameter(Nome, Valor)
        Parâmetros.Add(NovoParâmetro)
    End Sub

    'Verificar Erros
    Public Function VerExceções(Optional Report As Boolean = False) As Boolean
        If String.IsNullOrEmpty(Exceção) Then Return False
        If Report = True Then MsgBox(Exceção, MsgBoxStyle.Critical, "Exceção: ")
        Return True
    End Function
End Class