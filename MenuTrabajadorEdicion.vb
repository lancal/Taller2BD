Public Class MenuTrabajadorEdicion
    Dim agregarOpcion As Boolean
    Dim consulta As New Consultas
    Dim formInicial As Form
    Dim motor As String
    Dim datosBuscados As Boolean = False
    Dim datosBuscadosEliminar As Boolean = False
    Dim agregarOpcionHotel As Boolean
    Dim tipoPersonaBuscado As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Bbuscar.Click
        If (TBbuscarcodigo.Text = "") Then
            MsgBox("Debe ingresar un rut para buscar")
            Return
        End If

        Dim datosVuelo As DataTable

        'verificar que la persona exista en la base de datos
        Try
            datosVuelo = consulta.getDatosAvionPorCodigo(Me.motor, TBbuscarcodigo.Text, "avion")
        Catch ex As Exception
            MsgBox("Hubo un error al intentar buscar al usuario. más información: " + ex.Message)
            Return
        End Try
    End Sub
End Class