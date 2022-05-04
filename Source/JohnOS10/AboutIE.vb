Public Class AboutIE

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Panel2_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel2.MouseDown
        If e.Button = MouseButtons.Left Then
            Me.Panel2.Capture = False
            Const WM_NCLBUTTONDOWN As Integer = &HA1S
            Const HTCAPTION As Integer = 2
            Dim msg As Message = _
            Message.Create(Me.Handle, WM_NCLBUTTONDOWN, _
                New IntPtr(HTCAPTION), IntPtr.Zero)
            Me.DefWndProc(msg)
        End If
    End Sub

    Private Sub AboutIE_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MaximumSize = Screen.PrimaryScreen.WorkingArea.Size
    End Sub

End Class