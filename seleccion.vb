Public Class seleccion

    Private Sub seleccion_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.BackgroundImage = Image.FromFile(CurDir() + "/Imagenes/fondo.png")
        pbAccess.Image = Image.FromFile(CurDir() + "/imagenes/access.png")
        pbMysql.Image = Image.FromFile(CurDir() + "/imagenes/mysql.png")
        pbPostgresql.Image = Image.FromFile(CurDir() + "/imagenes/postgresql.png")
        pbSql.Image = Image.FromFile(CurDir() + "/imagenes/sqlserver.png")

    End Sub

    Private Sub pbAccess_Click(sender As Object, e As EventArgs) Handles pbAccess.Click
        Dim login As New login("access", Me)
        login.Show()
        Me.Hide()
    End Sub

    Private Sub pbMysql_Click(sender As Object, e As EventArgs) Handles pbMysql.Click
        Dim login As New login("mysql", Me)
        login.Show()
        Me.Hide()
    End Sub

    Private Sub pbPostgresql_Click(sender As Object, e As EventArgs) Handles pbPostgresql.Click
        Dim login As New login("postgresql", Me)
        login.Show()
        Me.Hide()
    End Sub

    Private Sub pbSqlserver_Click(sender As Object, e As EventArgs) Handles pbSql.Click
        Dim login As New login("sqlserver", Me)
        login.Show()
        Me.Hide()
    End Sub


End Class