Public Class MenuTrabajadorEdicion
    Dim agregarOpcion As Boolean
    Dim consulta As New Consultas
    Dim formInicial As Form
    Dim motor As String
    Dim datosBuscados As Boolean = False
    Dim datosBuscadosEliminar As Boolean = False

    Public Sub New(ByVal motor As String, ByRef formulario As Form)
        InitializeComponent()
        Me.formInicial = formulario
        Me.motor = motor

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BbuscarAvion.Click
        Dim buscarCodigoAvion As DataTable

        Try

            buscarCodigoAvion = consulta.getAvionPorCodigo(Me.motor, TbCodAvion.Text, "avion")
            If (buscarCodigoAvion.Rows.Count = 0) Then
                MsgBox("Lo siento, no existe el Avion.")
                Return
            End If

        Catch ex As Exception
            MsgBox("No se pudo encontrar el Avion. " & ex.Message)
            Return
        End Try

        tbModelo.Enabled = Enabled
        tbPiloto.Enabled = Enabled
        Dim datosAvion As DataTable = consulta.getDatosAvionPorCodigo(Me.motor, TbCodAvion.Text, "avion")
        tbCodigoAvion.Text = datosAvion.Rows(0).Item("codAvion")
        tbModelo.Text = datosAvion.Rows(0).Item("modelo")
        tbPiloto.Text = datosAvion.Rows(0).Item("nombrePiloto")

        Dim fs As System.IO.FileStream
        fs = New System.IO.FileStream(CurDir() + datosAvion.Rows(0).Item("imagenAvion"), IO.FileMode.Open, IO.FileAccess.Read)
        pbFotoAvion.Image = System.Drawing.Image.FromStream(fs)
        fs.Close()

        MsgBox("Todo Bien. ")

    End Sub

    Private Sub MenuTrabajadorEdicion_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles BbuscarVuelo.Click
        Dim buscarCodigoVuelo As DataTable

        Try

            buscarCodigoVuelo = consulta.getVueloPorCodigo(Me.motor, TbCodVuelo.Text, "vuelo")
            If (buscarCodigoVuelo.Rows.Count = 0) Then
                MsgBox("Lo siento, no existe el Vuelo.")
                Return
            End If

        Catch ex As Exception
            MsgBox("No se pudo encontrar el Vuelo. " & ex.Message)
            Return
        End Try

        dtpFechaVuelo.Enabled = Enabled
        Dim datosVuelo As DataTable = consulta.getDatosVueloPorCodigo(Me.motor, TbCodVuelo.Text, "vuelo")
        tbCodigoVuelo.Text = datosVuelo.Rows(0).Item("codVuelo")
        dtpFechaVuelo.Text = datosVuelo.Rows(0).Item("fechaVuelo")

        MsgBox("Vuelo Encontrado. ")

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim datosVueloMod As DataTable
        Try
            datosVueloMod = consulta.getVueloPorCodigo(Me.motor, tbCodigoVuelo.Text, "vuelo")
            If (datosVueloMod.Rows.Count > 0) Then
                consulta.setFechaVuelo(Me.motor, tbCodigoVuelo.Text, dtpFechaVuelo.Text)
            Else
                MsgBox("el codigo ingresado no se encuentra en el sistema, por favor verifique e intente nuevamente")
                Return
            End If
        Catch ex As Exception
            MsgBox("No se pudo realizar la modificacion. Más detalles: " & ex.Message)
            Return
        End Try
        MsgBox("Vuelo Modificado Exitosamente. ")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim datosAvionMod As DataTable
        Try
            datosAvionMod = consulta.getAvionPorCodigo(Me.motor, tbCodigoAvion.Text, "avion")
            If (datosAvionMod.Rows.Count > 0) Then
                consulta.setModeloAvion(Me.motor, tbCodigoAvion.Text, tbModelo.Text)
                consulta.setPilotoAvion(Me.motor, tbCodigoAvion.Text, tbPiloto.Text)

                'Se elimina para luego agregar la nueva, problemas al sobrescribir
                Dim dirImagen As String = CurDir() + "/imagenesAvion/" + tbCodigoAvion.Text + ".png"
                pbFotoAvion.Image.Save(dirImagen)


            Else
                MsgBox("el codigo ingresado no se encuentra en el sistema, por favor verifique e intente nuevamente")
                Return
            End If
        Catch ex As Exception
            MsgBox("No se pudo realizar la modificacion. Más detalles: " & ex.Message)
            Return
        End Try
        MsgBox("Avion Modificado Exitosamente. ")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
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
                    pbFotoAvion.Image = System.Drawing.Image.FromStream(fs)
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

    Private Sub Button1_Click_2(sender As Object, e As EventArgs) Handles Button1.Click
        Dim volverLogin As New Trabajador("access", Me)
        volverLogin.Show()
        Me.Dispose()
    End Sub
End Class