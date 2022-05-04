Public Class Clock
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
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

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
    End Sub

    Private Sub Clock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MaximumSize = Screen.PrimaryScreen.WorkingArea.Size
        ComboBox1.Text = My.Settings.clock.ToString + " Hour"

        WebBrowser1.Navigate("about:blank")
        If WebBrowser1.Document IsNot Nothing Then
            WebBrowser1.Document.Write(String.Empty)
        End If
        WebBrowser1.DocumentText = My.Resources.clock
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.Text = "24 Hour" Then
            My.Settings.clock = 24
            My.Settings.Save()
        Else
            My.Settings.clock = 12
            My.Settings.Save()
        End If
    End Sub

    Private Sub WebBrowser1_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted

    End Sub
End Class