Imports System.Data.SqlClient

Public Class SqlServer

    Private conexion As New SqlConnection
    Private comando As New SqlCommand
    Private lector As SqlDataReader
    Private transaccion As SqlTransaction
    Private adaptador As SqlDataAdapter
    Public Sub New()
        conexion.ConnectionString = "Data Source=coloso.disc.ucn.cl,587\SQLEXPRESS;Initial Catalog=bd12_2015;User ID=bd12_2015; password=h3r1g"
    End Sub

    Public Function adap(ByVal comando As SqlCommand) As SqlDataAdapter
        Dim adapa As SqlDataAdapter = New SqlDataAdapter(comando)
        Return adapa
    End Function
    '**********************************************************'
    '*Nombre método: EjecutarQuerySinRetorn
    '*@Param: La query (consulta) que se desea realizar
    '**********************************************************'
    Public Sub EjecutarQuerySinRetorno(ByVal Query As String)
        Try
            conexion.Open() 'se abre la conexión
            comando.CommandText = Query 'se le asocia la query al comando
            comando.Connection = conexion 'se le asigna la conexión al comando
            comando.ExecuteNonQuery() 'se ejecuta
            conexion.Close() 'se cierra la conexión
        Catch ex As Exception
            Throw New Exception("Ocurrió un error al ejecutar la query (insert/update/delete)." & ex.Message)
        End Try
    End Sub
    '**********************************************************'
    '*Nombre método: EjecutarQuery
    '*Retorna un DataTable con las tuplas que devuelva la query
    '*@Param: La query (consulta) que se desea realizar
    '**********************************************************'
    Public Function EjecutarQuery(ByVal Query As String) As DataTable
        Try
            Dim dt As DataTable = New DataTable() 'se crea un nuevo datatable
            conexion.Open() 'se abre la conexión
            comando.CommandText = Query 'se le asigna la query al comando
            comando.Connection = conexion 'se le asigna la conexión al comando
            'transaccion = conexion.BeginTransaction()
            adaptador = adap(comando) 'se le asocia el comando al adaptador
            adaptador.Fill(dt) 'el adaptador se encarga de poblar el datatable
            conexion.Close() 'se cierra la conexión
            Return dt 'se retorna el datatable con las tuplas ya cargadas
        Catch ex As Exception
            Throw New Exception("Ocurrió un error al obtener a los datos." & ex.Message)
        End Try
    End Function

End Class
