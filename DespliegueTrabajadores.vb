Public Class DespliegueTrabajadores

    Dim consultas As New Consultas
    Dim formInicial As Form
    Dim motor As String

    Public Sub New(ByVal motor As String, ByRef formulario As Form)

        InitializeComponent()
        Me.formInicial = formulario
        Me.motor = motor

    End Sub


    Private Sub DespliegueTrabajadores_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btVolver_Click(sender As Object, e As EventArgs) Handles btVolver.Click

        Dim volverLogin As New Administrador("access", Me)
        volverLogin.Show()
        Me.Dispose()

    End Sub

    Private Sub dgDespliegueTrabajadores_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgDespliegueTrabajadores.CellContentClick

        dgDespliegueTrabajadores.Show()
        Dim datos As DataTable
        datos = consultas.getTablas(Me.motor, "persona")

    End Sub
End Class