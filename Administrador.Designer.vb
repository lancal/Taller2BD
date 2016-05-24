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
        Me.btEditarTrabajadorOruta = New System.Windows.Forms.Button()
        Me.btIngresarOruta = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btDesplegarTrabajadores
        '
        Me.btDesplegarTrabajadores.Location = New System.Drawing.Point(43, 177)
        Me.btDesplegarTrabajadores.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btDesplegarTrabajadores.Name = "btDesplegarTrabajadores"
        Me.btDesplegarTrabajadores.Size = New System.Drawing.Size(427, 23)
        Me.btDesplegarTrabajadores.TabIndex = 7
        Me.btDesplegarTrabajadores.Text = "Desplegar trabajadores"
        Me.btDesplegarTrabajadores.UseVisualStyleBackColor = True
        '
        'btEliminarRuta
        '
        Me.btEliminarRuta.ForeColor = System.Drawing.Color.Red
        Me.btEliminarRuta.Location = New System.Drawing.Point(43, 238)
        Me.btEliminarRuta.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btEliminarRuta.Name = "btEliminarRuta"
        Me.btEliminarRuta.Size = New System.Drawing.Size(427, 22)
        Me.btEliminarRuta.TabIndex = 8
        Me.btEliminarRuta.Text = "Eliminar rutas"
        Me.btEliminarRuta.UseVisualStyleBackColor = True
        '
        'btVolver
        '
        Me.btVolver.Location = New System.Drawing.Point(43, 316)
        Me.btVolver.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btVolver.Name = "btVolver"
        Me.btVolver.Size = New System.Drawing.Size(133, 24)
        Me.btVolver.TabIndex = 9
        Me.btVolver.Text = "Volver"
        Me.btVolver.UseVisualStyleBackColor = True
        '
        'btEditarTrabajadorOruta
        '
        Me.btEditarTrabajadorOruta.Location = New System.Drawing.Point(43, 109)
        Me.btEditarTrabajadorOruta.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btEditarTrabajadorOruta.Name = "btEditarTrabajadorOruta"
        Me.btEditarTrabajadorOruta.Size = New System.Drawing.Size(427, 23)
        Me.btEditarTrabajadorOruta.TabIndex = 13
        Me.btEditarTrabajadorOruta.Text = "Editar Trabajador o Ruta"
        Me.btEditarTrabajadorOruta.UseVisualStyleBackColor = True
        '
        'btIngresarOruta
        '
        Me.btIngresarOruta.Location = New System.Drawing.Point(43, 46)
        Me.btIngresarOruta.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btIngresarOruta.Name = "btIngresarOruta"
        Me.btIngresarOruta.Size = New System.Drawing.Size(427, 23)
        Me.btIngresarOruta.TabIndex = 14
        Me.btIngresarOruta.Text = "Ingresar Trabajador o Ruta"
        Me.btIngresarOruta.UseVisualStyleBackColor = True
        '
        'Administrador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(567, 402)
        Me.Controls.Add(Me.btIngresarOruta)
        Me.Controls.Add(Me.btEditarTrabajadorOruta)
        Me.Controls.Add(Me.btVolver)
        Me.Controls.Add(Me.btEliminarRuta)
        Me.Controls.Add(Me.btDesplegarTrabajadores)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "Administrador"
        Me.Text = "Menu del Administrador"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btDesplegarTrabajadores As Button
    Friend WithEvents btEliminarRuta As Button
    Friend WithEvents btVolver As Button
    Friend WithEvents btEditarTrabajadorOruta As Button
    Friend WithEvents btIngresarOruta As Button
End Class
