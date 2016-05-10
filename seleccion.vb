Public Class seleccion

    Private Sub seleccion_Load(sender As Object, e As EventArgs) Handles MyBase.Load




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

    Private Sub Form_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dim response As MsgBoxResult
        response = MsgBox("Desea cerrar la ventana?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmar")
        If response = MsgBoxResult.Yes Then
            Me.Dispose()
            Me.Close()
            End
        ElseIf response = MsgBoxResult.No Then
            e.Cancel = True
            Exit Sub
        End If
    End Sub


End Class