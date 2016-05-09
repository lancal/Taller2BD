Public Class Conexiones

    Dim motor As String = ""
    Dim bdAccess As New access
    Dim bdpostgres As New PostgresSql
    Dim bdsqlserver As New SqlServer
    Dim bdmysql As New Mysql
    Public Sub New(ByVal motor As String)
        Me.motor = motor
    End Sub

    Public Function QueryConRetorno(ByVal query As String) As DataTable

        Select Case motor
            Case "access"
                Return bdAccess.EjecutarQuery(query)
            Case "postgresql"
                Return bdpostgres.EjecutarQuery(query)
            Case "sqlserver"
                Return bdsqlserver.EjecutarQuery(query)
            Case "mysql"
                Return bdmysql.EjecutarQuery(query)
            Case Else
                Return Nothing
        End Select

    End Function

    Public Sub QuerySinRetorno(ByVal query As String)
        Select Case motor
            Case "access"
                bdAccess.EjecutarQuerySinRetorno(query)
            Case "postgresql"
                bdpostgres.EjecutarQuerySinRetorno(query)
            Case "sqlserver"
                bdsqlserver.EjecutarQuerySinRetorno(query)
            Case "mysql"
                bdmysql.EjecutarQuerySinRetorno(query)
            Case Else
                Return
        End Select
    End Sub

End Class
