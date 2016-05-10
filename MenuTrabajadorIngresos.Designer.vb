<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuTrabajadorIngresos
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TbCodigoAvion = New System.Windows.Forms.TextBox()
        Me.TbModeloAvion = New System.Windows.Forms.TextBox()
        Me.TbNombrePiloto = New System.Windows.Forms.TextBox()
        Me.TbCodigoVuelo = New System.Windows.Forms.TextBox()
        Me.TbFechaVuelo = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.PbAvion = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        CType(Me.PbAvion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(71, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Ingreso de Aviones"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Codigo:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 98)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Modelo:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(22, 176)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Foto:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(354, 20)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(92, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Ingreso de Vuelos"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(22, 134)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(93, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Nombre del Piloto:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(281, 63)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(43, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Codigo:"
        '
        'TbCodigoAvion
        '
        Me.TbCodigoAvion.Location = New System.Drawing.Point(121, 60)
        Me.TbCodigoAvion.Name = "TbCodigoAvion"
        Me.TbCodigoAvion.Size = New System.Drawing.Size(100, 20)
        Me.TbCodigoAvion.TabIndex = 7
        '
        'TbModeloAvion
        '
        Me.TbModeloAvion.Location = New System.Drawing.Point(121, 95)
        Me.TbModeloAvion.Name = "TbModeloAvion"
        Me.TbModeloAvion.Size = New System.Drawing.Size(100, 20)
        Me.TbModeloAvion.TabIndex = 8
        '
        'TbNombrePiloto
        '
        Me.TbNombrePiloto.Location = New System.Drawing.Point(121, 131)
        Me.TbNombrePiloto.Name = "TbNombrePiloto"
        Me.TbNombrePiloto.Size = New System.Drawing.Size(100, 20)
        Me.TbNombrePiloto.TabIndex = 9
        '
        'TbCodigoVuelo
        '
        Me.TbCodigoVuelo.Location = New System.Drawing.Point(357, 60)
        Me.TbCodigoVuelo.Name = "TbCodigoVuelo"
        Me.TbCodigoVuelo.Size = New System.Drawing.Size(100, 20)
        Me.TbCodigoVuelo.TabIndex = 10
        '
        'TbFechaVuelo
        '
        Me.TbFechaVuelo.Location = New System.Drawing.Point(357, 95)
        Me.TbFechaVuelo.Name = "TbFechaVuelo"
        Me.TbFechaVuelo.Size = New System.Drawing.Size(100, 20)
        Me.TbFechaVuelo.TabIndex = 11
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(281, 98)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(40, 13)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Fecha:"
        '
        'PbAvion
        '
        Me.PbAvion.Location = New System.Drawing.Point(121, 176)
        Me.PbAvion.Name = "PbAvion"
        Me.PbAvion.Size = New System.Drawing.Size(100, 87)
        Me.PbAvion.TabIndex = 13
        Me.PbAvion.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(54, 298)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 23)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "Ingresar Avion"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(346, 144)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(100, 23)
        Me.Button2.TabIndex = 15
        Me.Button2.Text = "Ingresar Vuelo"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(25, 206)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 38)
        Me.Button3.TabIndex = 16
        Me.Button3.Text = "Subir Imagen"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'MenuTrabajadorIngresos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(529, 358)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PbAvion)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TbFechaVuelo)
        Me.Controls.Add(Me.TbCodigoVuelo)
        Me.Controls.Add(Me.TbNombrePiloto)
        Me.Controls.Add(Me.TbModeloAvion)
        Me.Controls.Add(Me.TbCodigoAvion)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "MenuTrabajadorIngresos"
        Me.Text = "Menu del Trabajador"
        CType(Me.PbAvion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TbCodigoAvion As TextBox
    Friend WithEvents TbModeloAvion As TextBox
    Friend WithEvents TbNombrePiloto As TextBox
    Friend WithEvents TbCodigoVuelo As TextBox
    Friend WithEvents TbFechaVuelo As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents PbAvion As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
End Class
