Public Class Shutdown
    Private Sub DoShutdown(sender As Object, e As EventArgs) Handles PictureBox3.Click
        System.Diagnostics.Process.Start("shutdown", "-s -t 00")
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        System.Diagnostics.Process.Start("shutdown", "-s -t 00")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Desktop.Close()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Desktop.Close()
    End Sub

    Private Sub DoReboot(sender As Object, e As EventArgs) Handles PictureBox1.Click
        System.Diagnostics.Process.Start("shutdown", "-r -t 00")
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        System.Diagnostics.Process.Start("shutdown", "-r -t 00")
    End Sub

    Private Sub Shutdown_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MaximumSize = Screen.PrimaryScreen.WorkingArea.Size
    End Sub
End Class