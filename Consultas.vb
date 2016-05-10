Public Class Consultas

    Public Function getLogin(ByVal motor As String, ByVal rut As String, ByVal pass As String, ByVal tabla As String) As DataTable


        Dim query As String
        If (motor = "postgresql") Then
            query = "SELECT rut,clave FROM """ + tabla + """  WHERE rut = '" & rut & "' AND clave = '" & pass & "';"
        Else
            query = "Select rut,clave FROM " & tabla & " WHERE rut = '" & rut & "' AND clave = '" & pass & "';"
        End If
        Dim conexion As New Conexiones(motor)
        Return conexion.QueryConRetorno(query)


    End Function

    Public Function getUsuarioPorRut(ByVal motor As String, ByVal rut As String, ByVal tabla As String) As DataTable
        Dim query As String
        If (motor = "postgresql") Then
            query = "SELECT rut FROM """ & tabla & """ WHERE rut = '" & rut & "';"
        Else
            query = "SELECT rut FROM " & tabla & " WHERE rut = '" & rut & "';"
        End If
        motor = "access"
        Dim conexion As New Conexiones(motor)
        Return conexion.QueryConRetorno(query)
    End Function

    Public Function getTipoTrabajador(ByVal motor As String, ByVal rut As String, ByVal tabla As String) As DataTable
        Dim query As String
        If (motor = "postgresql") Then
            query = "SELECT tipotrabajador FROM """ & tabla & """ WHERE rut = '" & rut & "';"
        Else
            query = "SELECT tipotrabajador FROM " & tabla & " WHERE rut = '" & rut & "';"
        End If
        motor = "access"
        Dim conexion As New Conexiones(motor)
        Return conexion.QueryConRetorno(query)
    End Function



    Public Function getAvionPorCodigo(ByVal motor As String, ByVal codigo As String, ByVal tabla As String) As DataTable
        Dim query As String
        If (motor = "postgresql") Then
            query = "SELECT codAvion FROM """ & tabla & """ WHERE codAvion = '" & codigo & "';"
        Else
            query = "SELECT codAvion FROM " & tabla & " WHERE codAvion = '" & codigo & "';"
        End If
        motor = "access"
        Dim conexion As New Conexiones(motor)
        Return conexion.QueryConRetorno(query)
    End Function

    Public Function getDatosUsuarioPorRut(ByVal motor As String, ByVal rut As String, ByVal tabla As String) As DataTable
        Dim query As String
        If (motor = "postgresql") Then
            query = "SELECT * FROM """ & tabla & """ WHERE rut = '" & rut & "';"
        Else
            query = "SELECT * FROM " & tabla & " WHERE rut = '" & rut & "';"
        End If

        Dim conexion As New Conexiones(motor)
        Return conexion.QueryConRetorno(query)
    End Function

    Public Function getDatosAvionPorCodigo(ByVal motor As String, ByVal codAvion As String, ByVal tabla As String) As DataTable
        Dim query As String
        If (motor = "postgresql") Then
            query = "SELECT * FROM """ & tabla & """ WHERE codAvion = '" & codAvion & "';"
        Else
            query = "SELECT * FROM " & tabla & " WHERE codAvion = '" & codAvion & "';"
        End If

        Dim conexion As New Conexiones(motor)
        Return conexion.QueryConRetorno(query)
    End Function



    Public Sub agregarPersona(ByVal motor As String, ByVal rut As String, ByVal nombre As String, ByVal appPaterno As String, ByVal appMaterno As String, ByVal edad As Integer, ByVal clave As String, ByVal correo As String)
        Dim query As String
        If (motor = "postgresql") Then
            query = "INSERT INTO ""Persona"" VALUES ('" & rut & "','" & nombre & "','" & appPaterno & "', '" & appMaterno & "', '" & edad & "', '" & clave & "', '" & correo & "')"
        Else
            query = "INSERT INTO persona VALUES ('" & rut & "','" & nombre & "','" & appPaterno & "', '" & appMaterno & "', '" & edad & "', '" & clave & "', '" & correo & "')"
        End If

        Dim conexion As New Conexiones(motor)
        conexion.QuerySinRetorno(query)
    End Sub

    Public Sub agregarTrabajador(ByVal motor As String, ByVal rut As String, ByVal tipoTrabajador As String)
        Dim query As String
        If (motor = "postgresql") Then
            query = "INSERT INTO ""Persona"" VALUES ('" & rut & "','" & tipoTrabajador & "')"
        Else
            query = "INSERT INTO trabajador VALUES ('" & rut & "','" & tipoTrabajador & "')"
        End If

        Dim conexion As New Conexiones(motor)
        conexion.QuerySinRetorno(query)
    End Sub


    Public Sub agregarTelefono(ByVal motor As String, ByVal rut As String, ByVal telefono As String)
        Dim query As String
        If (motor = "postgresql") Then
            query = "INSERT INTO ""PersonaTelefonos"" VALUES ('" & rut & "','" & telefono & "');"
        Else
            query = "INSERT INTO personatelefono VALUES ('" & rut & "','" & telefono & "');"
        End If

        Dim conexion As New Conexiones(motor)
        conexion.QuerySinRetorno(query)
    End Sub

    Public Sub agregarAvion(ByVal motor As String, ByVal codAvion As String, ByVal modelo As String, ByVal nombrePiloto As String, ByVal imagenAvion As String)
        Dim query As String
        If (motor = "postgresql") Then
            query = "INSERT INTO ""avion"" VALUES ('" & codAvion & "','" & modelo & "','" & nombrePiloto & "')"
        Else
            query = "INSERT INTO avion(codAvion,modelo,nombrePiloto,imagenAvion) VALUES ('" & codAvion & "','" & modelo & "','" & nombrePiloto & "','" & imagenAvion & "')"
        End If

        Dim conexion As New Conexiones(motor)
        conexion.QuerySinRetorno(query)
    End Sub


    Public Function getTablas(ByVal motor As String, ByVal tabla As String) As DataTable
        Dim query As String
        If (motor = "postgresql") Then
            query = "Select * FROM """ & tabla & """ ;"
        Else
            query = "Select * FROM " & tabla & " ;"
        End If

        Dim conexion As New Conexiones(motor)
        Return conexion.QueryConRetorno(query)
    End Function




End Class
