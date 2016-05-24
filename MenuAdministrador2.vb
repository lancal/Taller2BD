Public Class MenuAdministrador2

    Dim consultas As New Consultas
    Dim formInicial As Form
    Dim motor As String

    Public Sub New(ByVal motor As String, ByRef formulario As Form)
        InitializeComponent()
        Me.formInicial = formulario
        Me.motor = motor

    End Sub

    Private Sub MenuAdministrador2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Bbuscartrab_Click(sender As Object, e As EventArgs) Handles Bbuscartrab.Click
        Dim buscarRutPersona As DataTable

        Try

            buscarRutPersona = consultas.getUsuarioPorRut(Me.motor, tbRutbus.Text, "persona")
            If (buscarRutPersona.Rows.Count = 0) Then
                MsgBox("Lo siento, el usuario con ese Rut no existe.")
                Return
            End If

        Catch ex As Exception
            MsgBox("No se pudo encontrar el Usuario. " & ex.Message)
            Return
        End Try

        tbNombre.Enabled = Enabled
        tbPaterno.Enabled = Enabled
        tbMaterno.Enabled = Enabled
        tbEdad.Enabled = Enabled
        tbCorreo.Enabled = Enabled
        tbClave.Enabled = Enabled
        tbTipo.Enabled = Enabled
        tbTelefonos.Enabled = Enabled
        lbtelefonos.Enabled = Enabled

        Dim datosUsuario As DataTable = consultas.getDatosUsuarioPorRut(Me.motor, tbRutbus.Text, "persona")
        Dim datosTrabajador As DataTable = consultas.getDatosUsuarioPorRut(Me.motor, tbRutbus.Text, "trabajador")
        tbRut.Text = datosUsuario.Rows(0).Item("rut")
        tbNombre.Text = datosUsuario.Rows(0).Item("nombre")
        tbPaterno.Text = datosUsuario.Rows(0).Item("appPaterno")
        tbMaterno.Text = datosUsuario.Rows(0).Item("appMaterno")
        tbEdad.Text = datosUsuario.Rows(0).Item("edad")
        tbClave.Text = datosUsuario.Rows(0).Item("clave")
        tbCorreo.Text = datosUsuario.Rows(0).Item("correo")
        tbTipo.Text = datosTrabajador.Rows(0).Item("tipoTrabajador")

        Dim datosTelefonos As DataTable
        datosTelefonos = consultas.getTablas(Me.motor, "personatelefono")
        Dim filasTelefono() As DataRow = datosTelefonos.Select("rut = '" & tbRut.Text & "'")

        For i = 0 To filasTelefono.Count - 1
            lbtelefonos.Items.Add(filasTelefono(i).Item("telefono"))
        Next

        MsgBox("Usuario Encontrado. ")
    End Sub

    Private Sub Form_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dim response As MsgBoxResult
        response = MsgBox("Desea cerrar la ventana?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmar")
        If response = MsgBoxResult.Yes Then
            Me.Dispose()
            Me.Close()
            End
        ElseIf response = MsgBoxResult.No Then
            e.Cancel = True
            Exit Sub
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If (tbTelefonos.Text = "") Then
            MsgBox("Debe ingresar un numero antes de agregarlo")
        Else
            lbtelefonos.Items.Add(tbTelefonos.Text)
            tbTelefonos.Text = ""
        End If
    End Sub

    Public Function verificarCamposBlancos()
        Dim vacios As Boolean
        vacios = tbNombre.Text = "" Or tbPaterno.Text = "" Or tbMaterno.Text = ""
        vacios = vacios Or tbEdad.Text = "" Or tbClave.Text = "" Or lbtelefonos.Items.Count = 0
        vacios = vacios Or tbTipo.Text = ""
        If (vacios) Then
            Return True
        End If
        Return False

    End Function

    Public Function verificarCamposBlancos2()
        Dim vacios As Boolean
        vacios = TBcodigo.Text = "" Or TBciuOri.Text = "" Or TBciuDes.Text = ""
        vacios = vacios Or TBvalor.Text = ""
        If (vacios) Then
            Return True
        End If
        Return False

    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If (verificarCamposBlancos()) Then
            MsgBox("Debe rellenar todos los campos antes de continuar")
            Return
        End If
        Dim datosUsuarioMod As DataTable

        Try
            datosUsuarioMod = consultas.getUsuarioPorRut(Me.motor, tbRut.Text, "persona")
            If (datosUsuarioMod.Rows.Count > 0) Then
                consultas.setNombreUsuario(Me.motor, tbRut.Text, tbNombre.Text)
                consultas.setAppPaternoUsuario(Me.motor, tbRut.Text, tbPaterno.Text)
                consultas.setAppMaternoUsuario(Me.motor, tbRut.Text, tbMaterno.Text)
                consultas.setEdadUsuario(Me.motor, tbRut.Text, tbEdad.Text)
                consultas.setClaveUsuario(Me.motor, tbRut.Text, tbClave.Text)
                consultas.setCorreoUsuario(Me.motor, tbRut.Text, tbCorreo.Text)
                consultas.setTipoTrabajador(Me.motor, tbRut.Text, tbTipo.Text)

                Try
                    consultas.eliminarFilasPorUsuario(Me.motor, tbRut.Text, "personatelefono")
                Catch ex As Exception
                    MsgBox("Hubo un problema al intetnar actualizar los numeros del trabajador " + ex.Message)
                    Return
                End Try

                Dim i As Integer
                Dim str As String = ""

                For i = 0 To lbtelefonos.Items.Count - 1
                    str = lbtelefonos.Items(i).ToString
                    Try
                        consultas.agregarTelefonos(Me.motor, tbRut.Text, str)
                    Catch ex As Exception
                        MsgBox("hubo un error al agregar el telefono:" & ex.Message)
                        Return
                    End Try
                Next

            Else
                MsgBox("el codigo ingresado no se encuentra en el sistema, por favor verifique e intente nuevamente")
                Return
            End If
        Catch ex As Exception
            MsgBox("No se pudo realizar la modificacion. Más detalles: " & ex.Message)
            Return
        End Try
        MsgBox("Trabajador Modificado Exitosamente. ")
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim volverLogin As New Administrador("access", Me)
        volverLogin.Show()
        Me.Dispose()
    End Sub

    Private Sub BbuscarRuta_Click(sender As Object, e As EventArgs) Handles BbuscarRuta.Click
        Dim buscarRuta As DataTable

        Try


            buscarRuta = consultas.getRuta(Me.motor, TBbusCodigo.Text, "ruta")
            If (buscarRuta.Rows.Count = 0) Then
                MsgBox("Lo siento, no existe esta ruta")
                Return
            End If

        Catch ex As Exception
            MsgBox("No se pudo agregar la ruta. " & ex.Message)
            Return
        End Try


        TBciuOri.Enabled = Enabled
        TBciuDes.Enabled = Enabled
        TBvalor.Enabled = Enabled


        Dim datosRuta As DataTable = consultas.getDatosRuta(Me.motor, TBbusCodigo.Text, "ruta")

        TBcodigo.Text = datosRuta.Rows(0).Item("codRuta")
        TBciuOri.Text = datosRuta.Rows(0).Item("ciudadOrigen")
        TBciuDes.Text = datosRuta.Rows(0).Item("ciudadDestino")
        TBvalor.Text = datosRuta.Rows(0).Item("valor")



        MsgBox("Ruta Encontrada. ")
    End Sub

    Private Sub Bmodificar_Click(sender As Object, e As EventArgs) Handles Bmodificar.Click
        If (verificarCamposBlancos2()) Then
            MsgBox("Debe rellenar todos los campos antes de continuar")
            Return
        End If
        Dim datosRuta As DataTable

        Try
            datosRuta = consultas.getDatosRuta(Me.motor, TBbusCodigo.Text, "ruta")

            If (datosRuta.Rows.Count > 0) Then
                consultas.setRuta(Me.motor, TBcodigo.Text, TBciuOri.Text, TBciuDes.Text, TBvalor.Text)

            Else
                MsgBox("el codigo ingresado no se encuentra en el sistema, por favor verifique e intente nuevamente")
                Return
            End If
        Catch ex As Exception
            MsgBox("No se pudo realizar la modificacion. Más detalles: " & ex.Message)
            Return
        End Try
        MsgBox("Ruta Modificada Exitosamente. ")
    End Sub
End Class