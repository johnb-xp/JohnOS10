Public Class Settings
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
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

    Private Sub Settings_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MaximumSize = Screen.PrimaryScreen.WorkingArea.Size
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        If Me.WindowState = FormWindowState.Normal Then
            Me.WindowState = FormWindowState.Maximized
        Else
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.Click
        If ListView1.SelectedIndices.Contains(0) Then
            AboutJohnOS.Show()
        ElseIf ListView1.SelectedIndices.Contains(1) Then
            Clock.Show()
        ElseIf ListView1.SelectedIndices.Contains(2) Then
            DisplaySettings.Show()
        ElseIf ListView1.SelectedIndices.Contains(3) Then
            UpdateJOS.Show()
        ElseIf ListView1.SelectedIndices.Contains(4) Then
            NetworkDiagnostic.Show()
        ElseIf ListView1.SelectedIndices.Contains(5) Then
            My.Settings.FirstRun = True
            My.Settings.Save()
        ElseIf ListView1.SelectedIndices.Contains(6) Then
            ResourceMonitor.Show()
        ElseIf ListView1.SelectedIndices.Contains(7) Then
            Themes.Show()
        End If
    End Sub


    Private Sub ListView1_Enter(sender As Object, e As KeyEventArgs) Handles ListView1.KeyDown
        If e.KeyCode = Keys.Enter Then
            If ListView1.SelectedIndices.Contains(0) Then
                AboutJohnOS.Show()
            ElseIf ListView1.SelectedIndices.Contains(1) Then
                Clock.Show()
            ElseIf ListView1.SelectedIndices.Contains(2) Then
                DisplaySettings.Show()
            ElseIf ListView1.SelectedIndices.Contains(3) Then
                UpdateJOS.Show()
            ElseIf ListView1.SelectedIndices.Contains(4) Then
                NetworkDiagnostic.Show()
            ElseIf ListView1.SelectedIndices.Contains(5) Then
                My.Settings.FirstRun = True
                My.Settings.Save()
            ElseIf ListView1.SelectedIndices.Contains(6) Then
                ResourceMonitor.Show()
            ElseIf ListView1.SelectedIndices.Contains(7) Then
                Themes.Show()
            End If
            e.Handled = True
            e.SuppressKeyPress = True
        End If
    End Sub
End Class