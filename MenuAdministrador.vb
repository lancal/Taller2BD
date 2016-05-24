Public Class MenuAdministrador

    Dim motor As String
    Dim consulta As New Consultas
    Dim opcionAgregar As Boolean
    Dim formInicial As Form

    Public Sub New(ByVal motor As String, ByRef formulario As Form)
        InitializeComponent()
        Me.formInicial = formulario
        Me.motor = motor

    End Sub



    Private Sub Label11_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click

    End Sub

    Private Sub IngresoTrabajador_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub btVolverAdmin_Click(sender As Object, e As EventArgs) Handles btVolverAdmin.Click

        Dim volverAdmin As New Administrador(Me.motor, Me)
        volverAdmin.Show()
        Me.Dispose()
    End Sub

    Private Sub btIngresar_Click(sender As Object, e As EventArgs) Handles btIngresar.Click
        If (verificarCamposBlancos()) Then
            MsgBox("Debe rellenar todos los campos antes de continuar")
            Return
        End If


        Dim buscarRut As DataTable

            Try


            buscarRut = consulta.getUsuarioPorRut(Me.motor, tbRut.Text, "Persona")
            If (buscarRut.Rows.Count > 0) Then
                    MsgBox("Lo siento, ya existe una persona con ese rut en el sistema. No se puede realizar la accion")
                    Return
                End If

            Catch ex As Exception
                MsgBox("No se pudo agregar al usuario. " & ex.Message)
                Return
            End Try


        'buscarRut = consulta.getUsuarioPorRut(Me.motor, tbRut.Text, "Persona")
        'If (buscarRut.Rows.Count > 0) Then
        'MsgBox("Lo siento, ya existe una persona con ese rut en el sistema. No se puede realizar la accion")
        'Return

        'End If
        ' se agrega la persona como un trabajador con sus respectivos telefonos si es que los tiene
        consulta.agregarPersona(Me.motor, tbRut.Text, tbNombre.Text, tbapPat.Text, tbapMat.Text, tbEdad.Text, tbclave.Text, tbCorreo.Text)
        consulta.agregarTrabajador(Me.motor, tbRut.Text, tbTipoTrabajador.Text)
        consulta.agregarTelefono(Me.motor, tbRut.Text, tbTelefonos.Text)
        'agregar los telefonos del usuario
        Dim i As Integer
        Dim str As String = ""

        For i = 0 To lbtelefonos.Items.Count - 1
            str = lbtelefonos.Items(i).ToString
            Try
                consulta.agregarTelefono(Me.motor, tbRut.Text, str)
            Catch ex As Exception
                MsgBox("hubo un error al agregar el telefono:" & ex.Message)
                Exit For
            End Try
        Next

        MsgBox("El Trabajador fue ingresado exitosamente")



    End Sub

    Private Sub lbtelefonos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbtelefonos.SelectedIndexChanged

    End Sub

    Private Sub tbTelefonos_TextChanged(sender As Object, e As EventArgs) Handles tbTelefonos.TextChanged

    End Sub

    Private Sub btAgregarTelefono_Click(sender As Object, e As EventArgs) Handles btAgregarTelefono.Click

        If (tbTelefonos.Text = "") Then
            MsgBox("Debe ingresar un numero antes de agregarlo")
        Else
            lbtelefonos.Items.Add(tbTelefonos.Text)
            tbTelefonos.Text = ""
        End If



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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub

    Private Sub BingresarRuta_Click(sender As Object, e As EventArgs) Handles BingresarRuta.Click
        If (verificarCamposBlancos2()) Then
            MsgBox("Debe rellenar todos los campos antes de continuar")
            Return
        End If
        Dim buscarRuta As DataTable

        Try


            buscarRuta = consulta.getRuta(Me.motor, TBcodRuta.Text, "ruta")
            If (buscarRuta.Rows.Count > 0) Then
                MsgBox("Lo siento, ya existe esta ruta")
                Return
            End If

        Catch ex As Exception
            MsgBox("No se pudo agregar la ruta. " & ex.Message)
            Return
        End Try

        Try
            consulta.agregarRuta(Me.motor, TBcodRuta.Text, TBciuOri.Text, TBciuDes.Text, TBvalor.Text)
        Catch ex As Exception
            MsgBox("No se pudo agregar la ruta. " & ex.Message)
            Return
        End Try

        MsgBox("La ruta fue ingresada exitosamente")
    End Sub

    Public Function verificarCamposBlancos()
        Dim vacios As Boolean
        vacios = tbNombre.Text = "" Or tbapPat.Text = "" Or tbapMat.Text = ""
        vacios = vacios Or tbRut.Text = "" Or tbEdad.Text = "" Or lbtelefonos.Items.Count = 0
        vacios = vacios Or tbCorreo.Text = "" Or tbclave.Text = "" Or tbTipoTrabajador.Text = ""
        If (vacios) Then
            Return True
        End If
        Return False

    End Function

    Public Function verificarCamposBlancos2()
        Dim vacios As Boolean
        vacios = TBcodRuta.Text = "" Or TBciuOri.Text = "" Or TBciuDes.Text = ""
        vacios = vacios Or TBvalor.Text = ""
        If (vacios) Then
            Return True
        End If
        Return False

    End Function

End Class