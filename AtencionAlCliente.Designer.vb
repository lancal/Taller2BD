<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AtencionAlCliente
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btIngresarOeditar = New System.Windows.Forms.Button()
        Me.btDesplegarXclientes = New System.Windows.Forms.Button()
        Me.btVolver = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btIngresarOeditar
        '
        Me.btIngresarOeditar.Location = New System.Drawing.Point(66, 42)
        Me.btIngresarOeditar.Name = "btIngresarOeditar"
        Me.btIngresarOeditar.Size = New System.Drawing.Size(578, 37)
        Me.btIngresarOeditar.TabIndex = 1
        Me.btIngresarOeditar.Text = "Ingresar o Editar Reserva"
        Me.btIngresarOeditar.UseVisualStyleBackColor = True
        '
        'btDesplegarXclientes
        '
        Me.btDesplegarXclientes.Location = New System.Drawing.Point(66, 147)
        Me.btDesplegarXclientes.Name = "btDesplegarXclientes"
        Me.btDesplegarXclientes.Size = New System.Drawing.Size(578, 46)
        Me.btDesplegarXclientes.TabIndex = 3
        Me.btDesplegarXclientes.Text = "Despliegue por clientes"
        Me.btDesplegarXclientes.UseVisualStyleBackColor = True
        '
        'btVolver
        '
        Me.btVolver.Location = New System.Drawing.Point(66, 309)
        Me.btVolver.Name = "btVolver"
        Me.btVolver.Size = New System.Drawing.Size(199, 37)
        Me.btVolver.TabIndex = 11
        Me.btVolver.Text = "Volver"
        Me.btVolver.UseVisualStyleBackColor = True
        '
        'AtencionAlCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(994, 626)
        Me.Controls.Add(Me.btVolver)
        Me.Controls.Add(Me.btDesplegarXclientes)
        Me.Controls.Add(Me.btIngresarOeditar)
        Me.Name = "AtencionAlCliente"
        Me.Text = "Atencion Al Cliente"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btIngresarOeditar As Button
    Friend WithEvents btDesplegarXclientes As Button
    Friend WithEvents btVolver As Button
End Class
