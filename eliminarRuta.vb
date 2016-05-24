Public Class eliminarRuta
    Dim motor As String
    Dim consulta As New Consultas
    Dim opcionAgregar As Boolean
    Dim formInicial As Form
    Public Sub New(ByVal motor As String, ByRef formulario As Form)
        InitializeComponent()
        Me.formInicial = formulario
        Me.motor = motor

        'cargar las rutas
        Dim datosRutas As DataTable = Nothing

        Try
            datosRutas = consulta.getTablas(motor, "ruta")
        Catch ex As Exception
            MsgBox("La consulta no se pudo realizar debido a:" & ex.Message)
        End Try

        If (datosRutas Is Nothing) Then
            MsgBox("Motor de busqueda no encontrado")
            cbRutas.Enabled = False
        Else

            cbRutas.DataSource = datosRutas
            cbRutas.ValueMember = "codRuta"
            cbRutas.DisplayMember = "codRuta"

        End If



    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            consulta.eliminarRuta(Me.motor, cbRutas.SelectedValue.ToString, "ruta")
        Catch ex As Exception
            MsgBox("hubo un error al eliminar la ruta:" & ex.Message)
            Return
        End Try
        MsgBox("ruta eliminada exitosamente")
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
        Dim volverAdmin As New Administrador(Me.motor, Me)
        volverAdmin.Show()
        Me.Dispose()
    End Sub
End Class