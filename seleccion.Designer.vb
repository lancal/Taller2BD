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
        Me.pbAccess.Location = New System.Drawing.Point(61, 148)
        Me.pbAccess.Name = "pbAccess"
        Me.pbAccess.Size = New System.Drawing.Size(153, 180)
        Me.pbAccess.TabIndex = 0
        Me.pbAccess.TabStop = False
        '
        'pbMysql
        '
        Me.pbMysql.Location = New System.Drawing.Point(233, 148)
        Me.pbMysql.Name = "pbMysql"
        Me.pbMysql.Size = New System.Drawing.Size(153, 180)
        Me.pbMysql.TabIndex = 1
        Me.pbMysql.TabStop = False
        '
        'pbPostgresql
        '
        Me.pbPostgresql.Location = New System.Drawing.Point(405, 148)
        Me.pbPostgresql.Name = "pbPostgresql"
        Me.pbPostgresql.Size = New System.Drawing.Size(153, 180)
        Me.pbPostgresql.TabIndex = 2
        Me.pbPostgresql.TabStop = False
        '
        'pbSql
        '
        Me.pbSql.Location = New System.Drawing.Point(577, 148)
        Me.pbSql.Name = "pbSql"
        Me.pbSql.Size = New System.Drawing.Size(153, 180)
        Me.pbSql.TabIndex = 3
        Me.pbSql.TabStop = False
        '
        'seleccion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(758, 524)
        Me.Controls.Add(Me.pbSql)
        Me.Controls.Add(Me.pbPostgresql)
        Me.Controls.Add(Me.pbMysql)
        Me.Controls.Add(Me.pbAccess)
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
