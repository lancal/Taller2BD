<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ControlVuelos
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
        Me.TabControlVuelos = New System.Windows.Forms.TabControl()
        Me.TabPageIngresoA = New System.Windows.Forms.TabPage()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBoxNPiloto = New System.Windows.Forms.TextBox()
        Me.FotoAvion = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBoxModelo = New System.Windows.Forms.TextBox()
        Me.TextBoxCodigo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPageEdicionV = New System.Windows.Forms.TabPage()
        Me.TabControlVuelos.SuspendLayout()
        Me.TabPageIngresoA.SuspendLayout()
        CType(Me.FotoAvion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControlVuelos
        '
        Me.TabControlVuelos.Controls.Add(Me.TabPageIngresoA)
        Me.TabControlVuelos.Controls.Add(Me.TabPageEdicionV)
        Me.TabControlVuelos.Location = New System.Drawing.Point(0, 12)
        Me.TabControlVuelos.Name = "TabControlVuelos"
        Me.TabControlVuelos.SelectedIndex = 0
        Me.TabControlVuelos.Size = New System.Drawing.Size(446, 279)
        Me.TabControlVuelos.TabIndex = 0
        '
        'TabPageIngresoA
        '
        Me.TabPageIngresoA.Controls.Add(Me.Button1)
        Me.TabPageIngresoA.Controls.Add(Me.TextBoxNPiloto)
        Me.TabPageIngresoA.Controls.Add(Me.FotoAvion)
        Me.TabPageIngresoA.Controls.Add(Me.Label4)
        Me.TabPageIngresoA.Controls.Add(Me.Label3)
        Me.TabPageIngresoA.Controls.Add(Me.TextBoxModelo)
        Me.TabPageIngresoA.Controls.Add(Me.TextBoxCodigo)
        Me.TabPageIngresoA.Controls.Add(Me.Label2)
        Me.TabPageIngresoA.Controls.Add(Me.Label1)
        Me.TabPageIngresoA.Location = New System.Drawing.Point(4, 22)
        Me.TabPageIngresoA.Name = "TabPageIngresoA"
        Me.TabPageIngresoA.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageIngresoA.Size = New System.Drawing.Size(438, 253)
        Me.TabPageIngresoA.TabIndex = 0
        Me.TabPageIngresoA.Text = "Ingreso de Aviones"
        Me.TabPageIngresoA.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(142, 190)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(105, 23)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Ingresar Avion"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBoxNPiloto
        '
        Me.TextBoxNPiloto.Location = New System.Drawing.Point(11, 135)
        Me.TextBoxNPiloto.Name = "TextBoxNPiloto"
        Me.TextBoxNPiloto.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxNPiloto.TabIndex = 7
        '
        'FotoAvion
        '
        Me.FotoAvion.Location = New System.Drawing.Point(241, 30)
        Me.FotoAvion.Name = "FotoAvion"
        Me.FotoAvion.Size = New System.Drawing.Size(180, 125)
        Me.FotoAvion.TabIndex = 6
        Me.FotoAvion.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 119)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Nombre Piloto:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(201, 14)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Foto:"
        '
        'TextBoxModelo
        '
        Me.TextBoxModelo.Location = New System.Drawing.Point(11, 83)
        Me.TextBoxModelo.Name = "TextBoxModelo"
        Me.TextBoxModelo.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxModelo.TabIndex = 3
        '
        'TextBoxCodigo
        '
        Me.TextBoxCodigo.Location = New System.Drawing.Point(11, 30)
        Me.TextBoxCodigo.Name = "TextBoxCodigo"
        Me.TextBoxCodigo.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxCodigo.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Modelo:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Codigo:"
        '
        'TabPageEdicionV
        '
        Me.TabPageEdicionV.Location = New System.Drawing.Point(4, 22)
        Me.TabPageEdicionV.Name = "TabPageEdicionV"
        Me.TabPageEdicionV.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageEdicionV.Size = New System.Drawing.Size(438, 253)
        Me.TabPageEdicionV.TabIndex = 1
        Me.TabPageEdicionV.Text = "Edicion de Aviones"
        Me.TabPageEdicionV.UseVisualStyleBackColor = True
        '
        'ControlVuelos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(446, 297)
        Me.Controls.Add(Me.TabControlVuelos)
        Me.Name = "ControlVuelos"
        Me.Text = "Control de Vuelos"
        Me.TabControlVuelos.ResumeLayout(False)
        Me.TabPageIngresoA.ResumeLayout(False)
        Me.TabPageIngresoA.PerformLayout()
        CType(Me.FotoAvion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControlVuelos As TabControl
    Friend WithEvents TabPageIngresoA As TabPage
    Friend WithEvents TabPageEdicionV As TabPage
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBoxNPiloto As TextBox
    Friend WithEvents FotoAvion As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBoxModelo As TextBox
    Friend WithEvents TextBoxCodigo As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
