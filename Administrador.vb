Public Class Administrador

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

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub btEditarTrabajadorOruta_Click_1(sender As Object, e As EventArgs) Handles btEditarTrabajadorOruta.Click


    End Sub

    Private Sub btIngresarOruta_Click(sender As Object, e As EventArgs) Handles btIngresarOruta.Click

        MsgBox("Bienvenido al Menu del Administrador")
        Dim menuadmin As New MenuAdministrador(Me.motor, Me)
        menuadmin.Show()
        Me.Dispose()







    End Sub

    Private Sub btVolver_Click(sender As Object, e As EventArgs) Handles btVolver.Click
        Dim volverLogin As New login("access", Me)
        volverLogin.Show()
        Me.Dispose()
    End Sub

    Private Sub btDesplegarTrabajadores_Click(sender As Object, e As EventArgs) Handles btDesplegarTrabajadores.Click

        Dim desplegarTrabajadores As New DespliegueTrabajadores(Me.motor, Me)
        desplegarTrabajadores.Show()
        Me.Dispose()

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

    Private Sub Administrador_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class