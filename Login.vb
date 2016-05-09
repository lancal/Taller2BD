﻿Public Class login

    Dim motor As String
    Dim consulta As New Consultas
    Dim formInicial As Form
    'Dim tbuserTXT As String

    Public Sub New(ByVal motor As String, ByRef formulario As Form)
        InitializeComponent()
        Me.formInicial = formulario
        Me.motor = motor



    End Sub

    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'evitar que se redimensione la ventana 
        Dim tamanio As Size
        tamanio.Width = Me.Width
        tamanio.Height = Me.Height
        Me.MaximumSize = tamanio
        Me.MinimumSize = tamanio

    End Sub

    Private Sub btIngresar_Click(sender As Object, e As EventArgs) Handles btIngresar.Click

        If (tbpass.Text = "" Or tbuser.Text = "") Then
            MsgBox("Por favor ingrese todos los datos antes de continuar",, "Faltan datos")
        Else

            If (consulta.getLogin(Me.motor, tbuser.Text, tbpass.Text, "persona").Rows.Count > 0) Then



                'verificar a que tipo de usuario corresponde en el sistema
                If (consulta.getUsuarioPorRut(Me.motor, tbuser.Text, "administrador").Rows.Count > 0) Then
                    Dim admin As New Administrador(Me.motor, Me)
                    MsgBox("Bienvenido Administrador")
                    admin.Show()
                    Me.Dispose()


                ElseIf (consulta.getUsuarioPorRut(Me.motor, tbuser.Text, "trabajador").Rows.Count > 0) Then
                    Dim trabajador As New Trabajador(Me.motor, Me)
                    MsgBox("Bienvenido Trabajador")
                    trabajador.Show()
                    Me.Dispose()


                End If


            Else



                MsgBox("Usuario no se encuentra en el sistema")

            End If



        End If



    End Sub

    Private Sub tbuser_TextChanged(sender As Object, e As EventArgs) Handles tbuser.TextChanged

    End Sub

    Private Sub tbpass_TextChanged(sender As Object, e As EventArgs) Handles tbpass.TextChanged

    End Sub

    Private Sub btVolverSeleccion_Click(sender As Object, e As EventArgs) Handles btVolverSeleccion.Click

        Dim volverSeleccion As New seleccion()
        volverSeleccion.Show()
        Me.Dispose()


    End Sub
End Class