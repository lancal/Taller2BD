<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Trabajador
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
        Me.Button4 = New System.Windows.Forms.Button()
        Me.btVolver = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(68, 292)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(537, 42)
        Me.Button4.TabIndex = 8
        Me.Button4.Text = "Despliegue de Aviones en Estado de Vuelo"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'btVolver
        '
        Me.btVolver.Location = New System.Drawing.Point(68, 430)
        Me.btVolver.Name = "btVolver"
        Me.btVolver.Size = New System.Drawing.Size(199, 37)
        Me.btVolver.TabIndex = 10
        Me.btVolver.Text = "Volver"
        Me.btVolver.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(68, 75)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(537, 36)
        Me.Button3.TabIndex = 11
        Me.Button3.Text = "Ingresar Avion o Vuelo"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(68, 185)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(537, 36)
        Me.Button5.TabIndex = 12
        Me.Button5.Text = "Editar Avion o Vuelo"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(402, 430)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(203, 37)
        Me.Button7.TabIndex = 13
        Me.Button7.Text = "Salir"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Trabajador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1013, 728)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.btVolver)
        Me.Controls.Add(Me.Button4)
        Me.Name = "Trabajador"
        Me.Text = "Menu del Trabajador"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button4 As Button
    Friend WithEvents btVolver As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button7 As Button
End Class
