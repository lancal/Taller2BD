Public Class MenuAtencionAlCliente

    Dim motor As String
    Dim consulta As New Consultas
    'Dim opcionAgregar As Boolean
    Dim formInicial As Form

    Public Sub New(ByVal motor As String, ByRef formulario As Form)
        InitializeComponent()
        Me.formInicial = formulario
        Me.motor = motor

    End Sub

    Private Sub MenuAtencionAlCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class