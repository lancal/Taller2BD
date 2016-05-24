Public Class Registro
    Dim motor As String
    Dim consulta As New Consultas
    Dim opcionAgregar As Boolean
    Dim formInicial As Form
    Public Sub New(ByVal motor As String, ByRef formulario As Form)
        InitializeComponent()
        Me.formInicial = formulario
        Me.motor = motor

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (verificarCamposBlancos()) Then
            MsgBox("Debe rellenar todos los campos antes de continuar")
            Return
        End If


        Dim buscarRut As DataTable

        Try


            buscarRut = consulta.getUsuarioPorRut(Me.motor, tbRut.Text, "persona")
            If (buscarRut.Rows.Count > 0) Then
                MsgBox("Lo siento, ya existe una persona con ese rut en el sistema. No se puede realizar la accion")
                Return
            End If

        Catch ex As Exception
            MsgBox("No se pudo agregar al usuario. " & ex.Message)
            Return
        End Try



        consulta.agregarPersona(Me.motor, tbRut.Text, tbNombre.Text, tbPaterno.Text, tbMaterno.Text, tbEdad.Text, tbClave.Text, tbCorreo.Text)
        consulta.agregarCliente(Me.motor, tbRut.Text, tbDireccion.Text)



        MsgBox("Ha sido registrado exitosamente")
    End Sub

    Public Function verificarCamposBlancos()
        Dim vacios As Boolean
        vacios = tbNombre.Text = "" Or tbPaterno.Text = "" Or tbMaterno.Text = ""
        vacios = vacios Or tbRut.Text = "" Or tbEdad.Text = ""
        vacios = vacios Or tbCorreo.Text = "" Or tbClave.Text = "" Or tbDireccion.Text = ""
        If (vacios) Then
            Return True
        End If
        Return False

    End Function

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

        Dim volverlogin As New login(Me.motor, Me)
        volverlogin.Show()
        Me.Dispose()
    End Sub
End Class