<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Administrador
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
        Me.btDesplegarTrabajadores = New System.Windows.Forms.Button()
        Me.btEliminarRuta = New System.Windows.Forms.Button()
        Me.btVolver = New System.Windows.Forms.Button()
        Me.btSalir = New System.Windows.Forms.Button()
        Me.btEditarTrabajadorOruta = New System.Windows.Forms.Button()
        Me.btIngresarOruta = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btDesplegarTrabajadores
        '
        Me.btDesplegarTrabajadores.Location = New System.Drawing.Point(65, 272)
        Me.btDesplegarTrabajadores.Name = "btDesplegarTrabajadores"
        Me.btDesplegarTrabajadores.Size = New System.Drawing.Size(640, 35)
        Me.btDesplegarTrabajadores.TabIndex = 7
        Me.btDesplegarTrabajadores.Text = "Desplegar trabajadores"
        Me.btDesplegarTrabajadores.UseVisualStyleBackColor = True
        '
        'btEliminarRuta
        '
        Me.btEliminarRuta.Location = New System.Drawing.Point(65, 366)
        Me.btEliminarRuta.Name = "btEliminarRuta"
        Me.btEliminarRuta.Size = New System.Drawing.Size(640, 34)
        Me.btEliminarRuta.TabIndex = 8
        Me.btEliminarRuta.Text = "Eliminar rutas"
        Me.btEliminarRuta.UseVisualStyleBackColor = True
        '
        'btVolver
        '
        Me.btVolver.Location = New System.Drawing.Point(65, 486)
        Me.btVolver.Name = "btVolver"
        Me.btVolver.Size = New System.Drawing.Size(199, 37)
        Me.btVolver.TabIndex = 9
        Me.btVolver.Text = "Volver"
        Me.btVolver.UseVisualStyleBackColor = True
        '
        'btSalir
        '
        Me.btSalir.Location = New System.Drawing.Point(503, 486)
        Me.btSalir.Name = "btSalir"
        Me.btSalir.Size = New System.Drawing.Size(202, 37)
        Me.btSalir.TabIndex = 12
        Me.btSalir.Text = "Salir"
        Me.btSalir.UseVisualStyleBackColor = True
        '
        'btEditarTrabajadorOruta
        '
        Me.btEditarTrabajadorOruta.Location = New System.Drawing.Point(65, 167)
        Me.btEditarTrabajadorOruta.Name = "btEditarTrabajadorOruta"
        Me.btEditarTrabajadorOruta.Size = New System.Drawing.Size(640, 35)
        Me.btEditarTrabajadorOruta.TabIndex = 13
        Me.btEditarTrabajadorOruta.Text = "Editar Trabajador o Ruta"
        Me.btEditarTrabajadorOruta.UseVisualStyleBackColor = True
        '
        'btIngresarOruta
        '
        Me.btIngresarOruta.Location = New System.Drawing.Point(65, 71)
        Me.btIngresarOruta.Name = "btIngresarOruta"
        Me.btIngresarOruta.Size = New System.Drawing.Size(640, 35)
        Me.btIngresarOruta.TabIndex = 14
        Me.btIngresarOruta.Text = "Ingresar Trabajador o Ruta"
        Me.btIngresarOruta.UseVisualStyleBackColor = True
        '
        'Administrador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(851, 618)
        Me.Controls.Add(Me.btIngresarOruta)
        Me.Controls.Add(Me.btEditarTrabajadorOruta)
        Me.Controls.Add(Me.btSalir)
        Me.Controls.Add(Me.btVolver)
        Me.Controls.Add(Me.btEliminarRuta)
        Me.Controls.Add(Me.btDesplegarTrabajadores)
        Me.Name = "Administrador"
        Me.Text = "Menu del Administrador"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btDesplegarTrabajadores As Button
    Friend WithEvents btEliminarRuta As Button
    Friend WithEvents btVolver As Button
    Friend WithEvents btSalir As Button
    Friend WithEvents btEditarTrabajadorOruta As Button
    Friend WithEvents btIngresarOruta As Button
End Class
