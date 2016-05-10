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
        Dim dt As DataTable = consultas.getTablas(motor, "trabajador")
        dgDespliegueTrabajadores.DataSource = dt
        dgDespliegueTrabajadores.Columns(0).HeaderText = "rut"
        dgDespliegueTrabajadores.Columns(1).HeaderText = "tipoTrabajador"
    End Sub

    Private Sub btVolver_Click(sender As Object, e As EventArgs) Handles btVolver.Click

        Dim volverLogin As New Administrador("access", Me)
        volverLogin.Show()
        Me.Dispose()

    End Sub

    Private Sub dgDespliegueTrabajadores_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgDespliegueTrabajadores.CellContentClick

        'dgDespliegueTrabajadores.Show()
        'Dim datos As DataTable
        'datos = consultas.getTablas(Me.motor, "persona")
        'dgDespliegueTrabajadores.DataSource = datos

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
End Class