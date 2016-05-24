<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuTrabajadorEdicion
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TbCodAvion = New System.Windows.Forms.TextBox()
        Me.BbuscarAvion = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbCodigoAvion = New System.Windows.Forms.TextBox()
        Me.tbModelo = New System.Windows.Forms.TextBox()
        Me.tbPiloto = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.pbFotoAvion = New System.Windows.Forms.PictureBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.BbuscarVuelo = New System.Windows.Forms.Button()
        Me.TbCodVuelo = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.tbCodigoVuelo = New System.Windows.Forms.TextBox()
        Me.dtpFechaVuelo = New System.Windows.Forms.DateTimePicker()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.pbFotoAvion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(66, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Ingrese Codigo Avion:"
        '
        'TbCodAvion
        '
        Me.TbCodAvion.Location = New System.Drawing.Point(69, 58)
        Me.TbCodAvion.Name = "TbCodAvion"
        Me.TbCodAvion.Size = New System.Drawing.Size(100, 20)
        Me.TbCodAvion.TabIndex = 1
        '
        'BbuscarAvion
        '
        Me.BbuscarAvion.Location = New System.Drawing.Point(78, 84)
        Me.BbuscarAvion.Name = "BbuscarAvion"
        Me.BbuscarAvion.Size = New System.Drawing.Size(79, 23)
        Me.BbuscarAvion.TabIndex = 2
        Me.BbuscarAvion.Text = "Buscar Avion"
        Me.BbuscarAvion.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 138)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Codigo:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 174)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Modelo:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 207)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(93, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Nombre del Piloto:"
        '
        'tbCodigoAvion
        '
        Me.tbCodigoAvion.Enabled = False
        Me.tbCodigoAvion.Location = New System.Drawing.Point(111, 135)
        Me.tbCodigoAvion.Name = "tbCodigoAvion"
        Me.tbCodigoAvion.Size = New System.Drawing.Size(100, 20)
        Me.tbCodigoAvion.TabIndex = 6
        '
        'tbModelo
        '
        Me.tbModelo.Enabled = False
        Me.tbModelo.Location = New System.Drawing.Point(111, 171)
        Me.tbModelo.Name = "tbModelo"
        Me.tbModelo.Size = New System.Drawing.Size(100, 20)
        Me.tbModelo.TabIndex = 7
        '
        'tbPiloto
        '
        Me.tbPiloto.Enabled = False
        Me.tbPiloto.Location = New System.Drawing.Point(111, 204)
        Me.tbPiloto.Name = "tbPiloto"
        Me.tbPiloto.Size = New System.Drawing.Size(100, 20)
        Me.tbPiloto.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 248)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Foto:"
        '
        'pbFotoAvion
        '
        Me.pbFotoAvion.Location = New System.Drawing.Point(15, 264)
        Me.pbFotoAvion.Name = "pbFotoAvion"
        Me.pbFotoAvion.Size = New System.Drawing.Size(153, 99)
        Me.pbFotoAvion.TabIndex = 10
        Me.pbFotoAvion.TabStop = False
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(174, 278)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 66)
        Me.Button2.TabIndex = 11
        Me.Button2.Text = "Subir otra Imagen"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(84, 383)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(93, 23)
        Me.Button3.TabIndex = 12
        Me.Button3.Text = "Modificar Avion"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(116, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Edicion de Aviones"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(368, 35)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(111, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Ingrese Codigo Vuelo:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(324, 9)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(109, 13)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Edicion de Vuelos"
        '
        'BbuscarVuelo
        '
        Me.BbuscarVuelo.Location = New System.Drawing.Point(380, 84)
        Me.BbuscarVuelo.Name = "BbuscarVuelo"
        Me.BbuscarVuelo.Size = New System.Drawing.Size(81, 23)
        Me.BbuscarVuelo.TabIndex = 16
        Me.BbuscarVuelo.Text = "Buscar Vuelo"
        Me.BbuscarVuelo.UseVisualStyleBackColor = True
        '
        'TbCodVuelo
        '
        Me.TbCodVuelo.Location = New System.Drawing.Point(371, 58)
        Me.TbCodVuelo.Name = "TbCodVuelo"
        Me.TbCodVuelo.Size = New System.Drawing.Size(100, 20)
        Me.TbCodVuelo.TabIndex = 17
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(281, 137)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(43, 13)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Codigo:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(281, 173)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(70, 13)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "Fecha Vuelo:"
        '
        'tbCodigoVuelo
        '
        Me.tbCodigoVuelo.Enabled = False
        Me.tbCodigoVuelo.Location = New System.Drawing.Point(358, 130)
        Me.tbCodigoVuelo.Name = "tbCodigoVuelo"
        Me.tbCodigoVuelo.Size = New System.Drawing.Size(133, 20)
        Me.tbCodigoVuelo.TabIndex = 20
        '
        'dtpFechaVuelo
        '
        Me.dtpFechaVuelo.Enabled = False
        Me.dtpFechaVuelo.Location = New System.Drawing.Point(358, 167)
        Me.dtpFechaVuelo.Name = "dtpFechaVuelo"
        Me.dtpFechaVuelo.Size = New System.Drawing.Size(133, 20)
        Me.dtpFechaVuelo.TabIndex = 21
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(371, 207)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(93, 23)
        Me.Button4.TabIndex = 22
        Me.Button4.Text = "Modifcar Vuelo"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Button1.Location = New System.Drawing.Point(373, 383)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(91, 23)
        Me.Button1.TabIndex = 23
        Me.Button1.Text = "Volver"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'MenuTrabajadorEdicion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(538, 418)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.dtpFechaVuelo)
        Me.Controls.Add(Me.tbCodigoVuelo)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TbCodVuelo)
        Me.Controls.Add(Me.BbuscarVuelo)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.pbFotoAvion)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.tbPiloto)
        Me.Controls.Add(Me.tbModelo)
        Me.Controls.Add(Me.tbCodigoAvion)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BbuscarAvion)
        Me.Controls.Add(Me.TbCodAvion)
        Me.Controls.Add(Me.Label1)
        Me.Name = "MenuTrabajadorEdicion"
        Me.Text = "Edicion de Aviones y Vuelos"
        CType(Me.pbFotoAvion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TbCodAvion As TextBox
    Friend WithEvents BbuscarAvion As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents tbCodigoAvion As TextBox
    Friend WithEvents tbModelo As TextBox
    Friend WithEvents tbPiloto As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents pbFotoAvion As PictureBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents BbuscarVuelo As Button
    Friend WithEvents TbCodVuelo As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents tbCodigoVuelo As TextBox
    Friend WithEvents dtpFechaVuelo As DateTimePicker
    Friend WithEvents Button4 As Button
    Friend WithEvents Button1 As Button
End Class
