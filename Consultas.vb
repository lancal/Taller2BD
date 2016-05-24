Public Class Consultas

    Public Function getLogin(ByVal motor As String, ByVal rut As String, ByVal pass As String, ByVal tabla As String) As DataTable

        Dim query As String

        query = "Select rut,clave FROM " & tabla & " WHERE rut = '" & rut & "' AND clave = '" & pass & "';"

        Dim conexion As New Conexiones(motor)
        Return conexion.QueryConRetorno(query)


    End Function

    Public Function getUsuarioPorRut(ByVal motor As String, ByVal rut As String, ByVal tabla As String) As DataTable
        Dim query As String

        query = "SELECT rut FROM " & tabla & " WHERE rut = '" & rut & "';"

        Dim conexion As New Conexiones(motor)
        Return conexion.QueryConRetorno(query)
    End Function

    Public Function getTipoTrabajador(ByVal motor As String, ByVal rut As String, ByVal tabla As String) As DataTable
        Dim query As String

        query = "SELECT tipoTrabajador FROM " & tabla & " WHERE rut = '" & rut & "';"

        Dim conexion As New Conexiones(motor)
        Return conexion.QueryConRetorno(query)
    End Function

    Public Function getAvionPorCodigo(ByVal motor As String, ByVal codigo As String, ByVal tabla As String) As DataTable
        Dim query As String

        query = "SELECT codAvion FROM " & tabla & " WHERE codAvion = '" & codigo & "';"

        Dim conexion As New Conexiones(motor)
        Return conexion.QueryConRetorno(query)
    End Function

    Public Function getRuta(ByVal motor As String, ByVal codigo As String, ByVal tabla As String) As DataTable
        Dim query As String

        query = "SELECT codRuta FROM " & tabla & " WHERE codRuta = '" & codigo & "';"

        Dim conexion As New Conexiones(motor)
        Return conexion.QueryConRetorno(query)
    End Function

    Public Function getVueloPorCodigo(ByVal motor As String, ByVal codVuelo As String, ByVal tabla As String) As DataTable
        Dim query As String

        query = "SELECT codVuelo FROM " & tabla & " WHERE codVuelo = '" & codVuelo & "';"


        Dim conexion As New Conexiones(motor)
        Return conexion.QueryConRetorno(query)
    End Function

    Public Function getDatosUsuarioPorRut(ByVal motor As String, ByVal rut As String, ByVal tabla As String) As DataTable
        Dim query As String

        query = "SELECT * FROM " & tabla & " WHERE rut = '" & rut & "';"


        Dim conexion As New Conexiones(motor)
        Return conexion.QueryConRetorno(query)
    End Function

    Public Function getDatosAvionPorCodigo(ByVal motor As String, ByVal codAvion As String, ByVal tabla As String) As DataTable
        Dim query As String

        query = "SELECT * FROM " & tabla & " WHERE codAvion = '" & codAvion & "';"


        Dim conexion As New Conexiones(motor)
        Return conexion.QueryConRetorno(query)
    End Function

    Public Function getDatosRuta(ByVal motor As String, ByVal codRuta As String, ByVal tabla As String) As DataTable
        Dim query As String

        query = "SELECT * FROM " & tabla & " WHERE codRuta = '" & codRuta & "';"


        Dim conexion As New Conexiones(motor)
        Return conexion.QueryConRetorno(query)
    End Function

    Public Function getDatosVueloPorCodigo(ByVal motor As String, ByVal codVuelo As String, ByVal tabla As String) As DataTable
        Dim query As String

        query = "SELECT * FROM " & tabla & " WHERE codVuelo = '" & codVuelo & "';"


        Dim conexion As New Conexiones(motor)
        Return conexion.QueryConRetorno(query)
    End Function



    Public Sub agregarPersona(ByVal motor As String, ByVal rut As String, ByVal nombre As String, ByVal appPaterno As String, ByVal appMaterno As String, ByVal edad As Integer, ByVal clave As String, ByVal correo As String)
        Dim query As String

        query = "INSERT INTO persona VALUES ('" & rut & "','" & nombre & "','" & appPaterno & "', '" & appMaterno & "', '" & edad & "', '" & clave & "', '" & correo & "')"


        Dim conexion As New Conexiones(motor)
        conexion.QuerySinRetorno(query)
    End Sub

    Public Sub agregarCliente(ByVal motor As String, ByVal rut As String, ByVal direccion As String)
        Dim query As String

        query = "INSERT INTO cliente VALUES ('" & rut & "','" & direccion & "')"


        Dim conexion As New Conexiones(motor)
        conexion.QuerySinRetorno(query)
    End Sub

    Public Sub agregarRuta(ByVal motor As String, ByVal codigoRuta As String, ByVal ciudadOrigen As String, ByVal ciudadDestino As String, ByVal valor As Integer)
        Dim query As String

        query = "INSERT INTO ruta VALUES ('" & codigoRuta & "','" & ciudadOrigen & "','" & ciudadDestino & "','" & valor & "')"


        Dim conexion As New Conexiones(motor)
        conexion.QuerySinRetorno(query)
    End Sub

    Public Sub agregarTrabajador(ByVal motor As String, ByVal rut As String, ByVal tipoTrabajador As String)
        Dim query As String

        query = "INSERT INTO trabajador VALUES ('" & rut & "','" & tipoTrabajador & "')"


        Dim conexion As New Conexiones(motor)
        conexion.QuerySinRetorno(query)
    End Sub


    Public Sub agregarTelefono(ByVal motor As String, ByVal rut As String, ByVal telefono As String)
        Dim query As String

        query = "INSERT INTO personatelefono VALUES ('" & rut & "','" & telefono & "');"


        Dim conexion As New Conexiones(motor)
        conexion.QuerySinRetorno(query)
    End Sub

    Public Sub agregarAvion(ByVal motor As String, ByVal codAvion As String, ByVal modelo As String, ByVal nombrePiloto As String, ByVal imagenAvion As String)
        Dim query As String

        query = "INSERT INTO avion(codAvion,modelo,nombrePiloto,imagenAvion) VALUES ('" & codAvion & "','" & modelo & "','" & nombrePiloto & "','" & imagenAvion & "')"


        Dim conexion As New Conexiones(motor)
        conexion.QuerySinRetorno(query)
    End Sub

    Public Sub agregarVuelo(ByVal motor As String, ByVal codVuelo As String, ByVal fechaVuelo As Date)
        Dim query As String

        query = "INSERT INTO vuelo(codVuelo,fechaVuelo) VALUES ('" & codVuelo & "','" & fechaVuelo & "')"


        Dim conexion As New Conexiones(motor)
        conexion.QuerySinRetorno(query)
    End Sub


    Public Function getTablas(ByVal motor As String, ByVal tabla As String) As DataTable
        Dim query As String

        query = "Select * FROM " & tabla & " ;"


        Dim conexion As New Conexiones(motor)
        Return conexion.QueryConRetorno(query)
    End Function

    Public Sub setFechaVuelo(ByVal motor As String, ByVal codVuelo As String, ByVal fechaVuelo As Date)
        Dim query As String

        query = "UPDATE vuelo SET fechaVuelo = '" & fechaVuelo & "' WHERE codVuelo = '" & codVuelo & "'"


        Dim conexion As New Conexiones(motor)
        conexion.QuerySinRetorno(query)
    End Sub

    Public Sub setModeloAvion(ByVal motor As String, ByVal codAvion As String, ByVal modelo As String)
        Dim query As String

        query = "UPDATE avion SET modelo = '" & modelo & "' WHERE codAvion = '" & codAvion & "'"


        Dim conexion As New Conexiones(motor)
        conexion.QuerySinRetorno(query)
    End Sub

    Public Sub setPilotoAvion(ByVal motor As String, ByVal codAvion As String, ByVal nombrePiloto As String)
        Dim query As String

        query = "UPDATE avion SET nombrePiloto = '" & nombrePiloto & "' WHERE codAvion = '" & codAvion & "'"


        Dim conexion As New Conexiones(motor)
        conexion.QuerySinRetorno(query)
    End Sub

    Public Sub setNombreUsuario(ByVal motor As String, ByVal rut As String, ByVal nombre As String)
        Dim query As String

        query = "UPDATE persona SET nombre = '" & nombre & "' WHERE rut = '" & rut & "'"


        Dim conexion As New Conexiones(motor)
        conexion.QuerySinRetorno(query)
    End Sub

    Public Sub setAppPaternoUsuario(ByVal motor As String, ByVal rut As String, ByVal appPaterno As String)
        Dim query As String

        query = "UPDATE persona SET appPaterno = '" & appPaterno & "' WHERE rut = '" & rut & "'"


        Dim conexion As New Conexiones(motor)
        conexion.QuerySinRetorno(query)
    End Sub

    Public Sub setAppMaternoUsuario(ByVal motor As String, ByVal rut As String, ByVal appMaterno As String)
        Dim query As String

        query = "UPDATE persona SET appMaterno = '" & appMaterno & "' WHERE rut = '" & rut & "'"


        Dim conexion As New Conexiones(motor)
        conexion.QuerySinRetorno(query)
    End Sub

    Public Sub setEdadUsuario(ByVal motor As String, ByVal rut As String, ByVal edad As String)
        Dim query As String

        query = "UPDATE persona SET edad = '" & edad & "' WHERE rut = '" & rut & "'"


        Dim conexion As New Conexiones(motor)
        conexion.QuerySinRetorno(query)
    End Sub

    Public Sub setClaveUsuario(ByVal motor As String, ByVal rut As String, ByVal clave As String)
        Dim query As String

        query = "UPDATE persona SET clave = '" & clave & "' WHERE rut = '" & rut & "'"


        Dim conexion As New Conexiones(motor)
        conexion.QuerySinRetorno(query)
    End Sub

    Public Sub setCorreoUsuario(ByVal motor As String, ByVal rut As String, ByVal correo As String)
        Dim query As String

        query = "UPDATE persona SET correo = '" & correo & "' WHERE rut = '" & rut & "'"


        Dim conexion As New Conexiones(motor)
        conexion.QuerySinRetorno(query)
    End Sub

    Public Sub setTipoTrabajador(ByVal motor As String, ByVal rut As String, ByVal tipoTrabajador As String)
        Dim query As String

        query = "UPDATE trabajador SET tipoTrabajador = '" & tipoTrabajador & "' WHERE rut = '" & rut & "'"


        Dim conexion As New Conexiones(motor)
        conexion.QuerySinRetorno(query)
    End Sub

    Public Sub setRuta(ByVal motor As String, ByVal codRuta As String, ByVal ciudadOrigen As String, ByVal ciudadDestino As String, ByVal valor As Integer)
        Dim query As String

        query = "UPDATE ruta SET codRuta = '" & codRuta & "' , ciudadOrigen = '" & ciudadOrigen & "' , ciudadDestino = '" & ciudadDestino & "', valor = '" & valor & "'  WHERE codRuta = '" & codRuta & "'"


        Dim conexion As New Conexiones(motor)
        conexion.QuerySinRetorno(query)
    End Sub

    Public Sub agregarTelefonos(ByVal motor As String, ByVal rut As String, ByVal telefono As String)
        Dim query As String

        query = "INSERT INTO personatelefono(rut,telefono) VALUES ('" & rut & "','" & telefono & "')"

        Dim conexion As New Conexiones(motor)
        conexion.QuerySinRetorno(query)


    End Sub

    Public Sub eliminarFilasPorUsuario(ByVal motor As String, ByVal rut As String, ByVal tabla As String)
        Dim query As String

        query = "DELETE FROM " & tabla & " WHERE rut ='" & rut & "'"


        Dim conexion As New Conexiones(motor)
        conexion.QuerySinRetorno(query)
    End Sub

    Public Sub eliminarRuta(ByVal motor As String, ByVal codigo As String, ByVal tabla As String)
        Dim query As String

        query = "DELETE FROM " & tabla & " WHERE codRuta ='" & codigo & "'"


        Dim conexion As New Conexiones(motor)
        conexion.QuerySinRetorno(query)
    End Sub

End Class
