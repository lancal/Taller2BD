<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class seleccion
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
        Me.pbAccess = New System.Windows.Forms.PictureBox()
        Me.pbMysql = New System.Windows.Forms.PictureBox()
        Me.pbPostgresql = New System.Windows.Forms.PictureBox()
        Me.pbSql = New System.Windows.Forms.PictureBox()
        CType(Me.pbAccess, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbMysql, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbPostgresql, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbSql, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pbAccess
        '
        Me.pbAccess.Location = New System.Drawing.Point(9, 143)
        Me.pbAccess.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.pbAccess.Name = "pbAccess"
        Me.pbAccess.Size = New System.Drawing.Size(119, 117)
        Me.pbAccess.TabIndex = 0
        Me.pbAccess.TabStop = False
        '
        'pbMysql
        '
        Me.pbMysql.Location = New System.Drawing.Point(145, 143)
        Me.pbMysql.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.pbMysql.Name = "pbMysql"
        Me.pbMysql.Size = New System.Drawing.Size(123, 117)
        Me.pbMysql.TabIndex = 1
        Me.pbMysql.TabStop = False
        '
        'pbPostgresql
        '
        Me.pbPostgresql.Location = New System.Drawing.Point(286, 143)
        Me.pbPostgresql.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.pbPostgresql.Name = "pbPostgresql"
        Me.pbPostgresql.Size = New System.Drawing.Size(122, 117)
        Me.pbPostgresql.TabIndex = 2
        Me.pbPostgresql.TabStop = False
        '
        'pbSql
        '
        Me.pbSql.Location = New System.Drawing.Point(427, 143)
        Me.pbSql.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.pbSql.Name = "pbSql"
        Me.pbSql.Size = New System.Drawing.Size(125, 117)
        Me.pbSql.TabIndex = 3
        Me.pbSql.TabStop = False
        '
        'seleccion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(569, 295)
        Me.Controls.Add(Me.pbSql)
        Me.Controls.Add(Me.pbPostgresql)
        Me.Controls.Add(Me.pbMysql)
        Me.Controls.Add(Me.pbAccess)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "seleccion"
        Me.Text = "seleccion"
        CType(Me.pbAccess, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbMysql, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbPostgresql, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbSql, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pbAccess As PictureBox
    Friend WithEvents pbMysql As PictureBox
    Friend WithEvents pbPostgresql As PictureBox
    Friend WithEvents pbSql As PictureBox
End Class
