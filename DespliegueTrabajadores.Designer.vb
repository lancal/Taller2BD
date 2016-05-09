<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DespliegueTrabajadores
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
        Me.dgDespliegueTrabajadores = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btVolver = New System.Windows.Forms.Button()
        CType(Me.dgDespliegueTrabajadores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgDespliegueTrabajadores
        '
        Me.dgDespliegueTrabajadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgDespliegueTrabajadores.Location = New System.Drawing.Point(64, 90)
        Me.dgDespliegueTrabajadores.Name = "dgDespliegueTrabajadores"
        Me.dgDespliegueTrabajadores.RowTemplate.Height = 28
        Me.dgDespliegueTrabajadores.Size = New System.Drawing.Size(945, 432)
        Me.dgDespliegueTrabajadores.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(408, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(208, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Despliegue de Trabajadores"
        '
        'btVolver
        '
        Me.btVolver.Location = New System.Drawing.Point(64, 587)
        Me.btVolver.Name = "btVolver"
        Me.btVolver.Size = New System.Drawing.Size(118, 44)
        Me.btVolver.TabIndex = 2
        Me.btVolver.Text = "Volver"
        Me.btVolver.UseVisualStyleBackColor = True
        '
        'DespliegueTrabajadores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1052, 732)
        Me.Controls.Add(Me.btVolver)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgDespliegueTrabajadores)
        Me.Name = "DespliegueTrabajadores"
        Me.Text = "DespliegueTrabajadores"
        CType(Me.dgDespliegueTrabajadores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgDespliegueTrabajadores As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents btVolver As Button
End Class
