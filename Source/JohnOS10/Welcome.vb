Public Class Welcome
    Private Sub Panel2_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel2.MouseDown
        If e.Button = MouseButtons.Left Then
            Me.Panel2.Capture = False
            Const WM_NCLBUTTONDOWN As Integer = &HA1S
            Const HTCAPTION As Integer = 2
            Dim msg As Message =
            Message.Create(Me.Handle, WM_NCLBUTTONDOWN,
                New IntPtr(HTCAPTION), IntPtr.Zero)
            Me.DefWndProc(msg)
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles x.Click
        Me.Close()
    End Sub

    Private Sub startbutton_Click(sender As Object, e As EventArgs) Handles startbutton.Click
        StartMenu.Show()
        Me.Close()
    End Sub

    Public Sub Run()
        If My.Settings.FirstRun Then
            Me.Show()
            My.Settings.FirstRun = False
            My.Settings.Save()
        End If
    End Sub

    Private Sub Welcome_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class