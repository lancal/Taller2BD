Public Class Trabajador

    Dim consultas As New Consultas
    Dim formInicial As Form
    Dim motor As String

    Public Sub New(ByVal motor As String, ByRef formulario As Form)

        InitializeComponent()
        Me.formInicial = formulario
        Me.motor = motor

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btVolver_Click(sender As Object, e As EventArgs) Handles btVolver.Click
        Dim volverLogin As New login("access", Me)
        volverLogin.Show()
        Me.Dispose()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        MsgBox("Bienvenido al Menu del Trabajador Para Ingresar Aviones o Vuelo")
        Dim menutrabajador As New MenuTrabajadorIngresos(Me.motor, Me)
        menutrabajador.Show()
        Me.Dispose()
    End Sub

    Private Sub Trabajador_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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