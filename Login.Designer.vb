<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class login
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
        Me.tbuser = New System.Windows.Forms.TextBox()
        Me.tbpass = New System.Windows.Forms.TextBox()
        Me.btIngresar = New System.Windows.Forms.Button()
        Me.btVolverSeleccion = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Rut:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 152)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Password:"
        '
        'tbuser
        '
        Me.tbuser.Location = New System.Drawing.Point(209, 49)
        Me.tbuser.Name = "tbuser"
        Me.tbuser.Size = New System.Drawing.Size(100, 26)
        Me.tbuser.TabIndex = 2
        '
        'tbpass
        '
        Me.tbpass.Location = New System.Drawing.Point(209, 146)
        Me.tbpass.Name = "tbpass"
        Me.tbpass.Size = New System.Drawing.Size(100, 26)
        Me.tbpass.TabIndex = 3
        '
        'btIngresar
        '
        Me.btIngresar.Location = New System.Drawing.Point(209, 251)
        Me.btIngresar.Name = "btIngresar"
        Me.btIngresar.Size = New System.Drawing.Size(100, 31)
        Me.btIngresar.TabIndex = 4
        Me.btIngresar.Text = "Aceptar"
        Me.btIngresar.UseVisualStyleBackColor = True
        '
        'btVolverSeleccion
        '
        Me.btVolverSeleccion.Location = New System.Drawing.Point(29, 251)
        Me.btVolverSeleccion.Name = "btVolverSeleccion"
        Me.btVolverSeleccion.Size = New System.Drawing.Size(100, 31)
        Me.btVolverSeleccion.TabIndex = 5
        Me.btVolverSeleccion.Text = "Volver"
        Me.btVolverSeleccion.UseVisualStyleBackColor = True
        '
        'login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(875, 547)
        Me.Controls.Add(Me.btVolverSeleccion)
        Me.Controls.Add(Me.btIngresar)
        Me.Controls.Add(Me.tbpass)
        Me.Controls.Add(Me.tbuser)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "login"
        Me.Text = "login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents tbuser As TextBox
    Friend WithEvents tbpass As TextBox
    Friend WithEvents btIngresar As Button
    Friend WithEvents btVolverSeleccion As Button
End Class
