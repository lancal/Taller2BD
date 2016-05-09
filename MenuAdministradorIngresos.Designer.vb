<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class controlVuelos
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
        Me.TabPageCVuelo = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TabControlVuelos.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControlVuelos
        '
        Me.TabControlVuelos.Controls.Add(Me.TabPageCVuelo)
        Me.TabControlVuelos.Controls.Add(Me.TabPage2)
        Me.TabControlVuelos.Location = New System.Drawing.Point(0, 12)
        Me.TabControlVuelos.Name = "TabControlVuelos"
        Me.TabControlVuelos.SelectedIndex = 0
        Me.TabControlVuelos.Size = New System.Drawing.Size(580, 307)
        Me.TabControlVuelos.TabIndex = 0
        '
        'TabPageCVuelo
        '
        Me.TabPageCVuelo.Location = New System.Drawing.Point(4, 22)
        Me.TabPageCVuelo.Name = "TabPageCVuelo"
        Me.TabPageCVuelo.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageCVuelo.Size = New System.Drawing.Size(572, 281)
        Me.TabPageCVuelo.TabIndex = 0
        Me.TabPageCVuelo.Text = "Ingreso de Aviones"
        Me.TabPageCVuelo.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(572, 281)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Edicion de Aviones"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'controlVuelos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(596, 331)
        Me.Controls.Add(Me.TabControlVuelos)
        Me.Name = "controlVuelos"
        Me.Text = "Control de Vuelos"
        Me.TabControlVuelos.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControlVuelos As TabControl
    Friend WithEvents TabPageCVuelo As TabPage
    Friend WithEvents TabPage2 As TabPage
End Class
