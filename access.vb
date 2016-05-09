Imports System.Data.OleDb

Public Class access

    Private conexion As New OleDbConnection
    Private comando As New OleDbCommand
    Private lector As OleDbDataReader
    Private transaccion As OleDbTransaction
    Private adaptador As OleDbDataAdapter

    'Query con retorno
    Public Function EjecutarQuery(ByVal Query As String) As DataTable

        Dim tablaDatos As New DataTable 'se instancia una DataTable
        Dim ruta As String = CurDir() & "/Taller2BD.accdb" 'ruta de la base de datos access
        Dim cadenaConexion As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & ruta & " ;Persist Security Info=False"
        Dim adaptador As New OleDbDataAdapter(Query, cadenaConexion)

        Try
            adaptador.Fill(tablaDatos)
        Catch ex As Exception
            Throw New Exception("Ocurrió un error al ejecutar la query." & ex.Message)
        End Try

        Return tablaDatos 'se retorna la tabla con todos los datos de la query
    End Function

    'query sin retorno
    Public Sub EjecutarQuerySinRetorno(ByVal Query As String)

        Dim tablaDatos As New DataTable 'se instancia una DataTable
        Dim ruta As String = CurDir() & "/Taller2BD.accdb" 'ruta de la base de datos access
        Dim cadenaConexion As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & ruta & " ;Persist Security Info=False"

        Try
            Dim adaptador As New OleDbDataAdapter(Query, cadenaConexion)
            adaptador.Fill(tablaDatos)
        Catch ex As Exception
            Throw New Exception("Ocurrió un Error al ejecutar la query (insert/update/delete)." & ex.Message)
        End Try

    End Sub



End Class
