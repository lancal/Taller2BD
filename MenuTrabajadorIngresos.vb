Public Class MenuTrabajadorIngresos
    Dim motor As String
    Dim consulta As New Consultas
    Dim opcionAgregar As Boolean
    Dim formInicial As Form

    Public Sub New(ByVal motor As String, ByRef formulario As Form)
        InitializeComponent()
        Me.formInicial = formulario
        Me.motor = motor

    End Sub

    Private Sub MenuTrabajadorIngresos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim buscarCodigo As DataTable

        Try


            buscarCodigo = consulta.getAvionPorCodigo(Me.motor, TbCodigoAvion.Text, "avion")
            If (buscarCodigo.Rows.Count > 0) Then
                MsgBox("Lo siento, ya existe el Avion")
                Return
            End If

        Catch ex As Exception
            MsgBox("No se pudo agregar el Avion. " & ex.Message)
            Return
        End Try

        consulta.agregarAvion(Me.motor, TbCodigoAvion.Text, TbModeloAvion.Text, TbNombrePiloto.Text)
        MsgBox("El Trabajador fue ingresado exitosamente")
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub
End Class