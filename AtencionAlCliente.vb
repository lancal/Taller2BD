Public Class AtencionAlCliente

    Dim motor As String
    Dim consulta As New Consultas
    'Dim opcionAgregar As Boolean
    Dim formInicial As Form

    Public Sub New(ByVal motor As String, ByRef formulario As Form)
        InitializeComponent()
        Me.formInicial = formulario
        Me.motor = motor

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btIngresarOeditar_Click(sender As Object, e As EventArgs) Handles btIngresarOeditar.Click

        MsgBox("Bienvenido al Menu Atenciion al Cliente")
        Dim menuAtencion As New MenuAtencionAlCliente(Me.motor, Me)
        menuAtencion.Show()
        Me.Dispose()


    End Sub

    Private Sub btVolver_Click(sender As Object, e As EventArgs) Handles btVolver.Click

        Dim volverLogin As New login(Me.motor, Me)
        volverLogin.Show()
        Me.Dispose()

    End Sub

    Private Sub AtencionAlCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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