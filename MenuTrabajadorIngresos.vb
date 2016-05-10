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

        PbAvion.Image.Save(CurDir() + "/imagenesAvion/" + TbCodigoAvion.Text + ".png")
        Dim dirImage As String = "/imagenesAvion/" + TbCodigoAvion.Text + ".png"

        consulta.agregarAvion(Me.motor, TbCodigoAvion.Text, TbModeloAvion.Text, TbNombrePiloto.Text, dirImage)
        MsgBox("El Avion fue ingresado exitosamente")
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim buscarImagen As New OpenFileDialog()

        buscarImagen.InitialDirectory = "c:\"
        buscarImagen.Filter = "Png (*.png)|*.png"
        buscarImagen.FilterIndex = 2
        buscarImagen.RestoreDirectory = True


        If (buscarImagen.ShowDialog() = System.Windows.Forms.DialogResult.OK) Then
            Try

                If (IsValidImage(buscarImagen.FileName)) Then

                    Dim fs As System.IO.FileStream
                    fs = New System.IO.FileStream(buscarImagen.FileName, IO.FileMode.Open, IO.FileAccess.Read)
                    PbAvion.Image = System.Drawing.Image.FromStream(fs)
                    fs.Close()
                Else
                    MsgBox("Por favor elija una imagen")
                End If

            Catch ex As Exception

            End Try
        End If
    End Sub
    Function IsValidImage(filename As String) As Boolean
        Try
            Dim img As System.Drawing.Image = System.Drawing.Image.FromFile(filename)
        Catch generatedExceptionName As OutOfMemoryException
            ' Image.FromFile throws an OutOfMemoryException  
            ' if the file does not have a valid image format or 
            ' GDI+ does not support the pixel format of the file. 
            ' 
            Return False
        End Try
        Return True
    End Function

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