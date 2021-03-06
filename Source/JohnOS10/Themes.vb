Public Class Themes
    Public Sub SaveTheme(sender As Object, e As EventArgs) Handles saveButton.Click
        My.Settings.titleBarColor = sampleTitleBar.BackColor()
        My.Settings.xButtonColor = sampleXButton.BackColor()
        My.Settings.notifBarColor = sampleNotifBar.BackColor()
        My.Settings.backColor = samplePanel.BackColor()
        My.Settings.startButtonColor = sampleStartButton.BackColor()
        My.Settings.minButtonColor = sampleMinButton.BackColor()
        My.Settings.startButtonTextColor = sampleStartButton.ForeColor()
        My.Settings.titleBarTextColor = sampleTitleBarText.ForeColor()
        My.Settings.taskbarColor = sampleTaskbar.BackColor()
        My.Settings.Save()
    End Sub

    Public Sub Reset()
        My.Settings.titleBarColor = DirectCast(New ColorConverter().ConvertFromString("0, 102, 204"), Color)
        My.Settings.xButtonColor = DirectCast(New ColorConverter().ConvertFromString("IndianRed"), Color)
        My.Settings.notifBarColor = DirectCast(New ColorConverter().ConvertFromString("15, 143, 234"), Color)
        My.Settings.backColor = DirectCast(New ColorConverter().ConvertFromString("236, 233, 216"), Color)
        My.Settings.startButtonColor = DirectCast(New ColorConverter().ConvertFromString("Green"), Color)
        My.Settings.minButtonColor = DirectCast(New ColorConverter().ConvertFromString("DodgerBlue"), Color)
        My.Settings.startButtonTextColor = DirectCast(New ColorConverter().ConvertFromString("White"), Color)
        My.Settings.titleBarTextColor = DirectCast(New ColorConverter().ConvertFromString("White"), Color)
        My.Settings.taskbarColor = DirectCast(New ColorConverter().ConvertFromString("0, 102, 204"), Color)
        My.Settings.Save()
    End Sub

    Public Sub ChangeTheme(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.Text = "Luna" Then
            sampleTitleBar.BackColor = DirectCast(New ColorConverter().ConvertFromString("0, 102, 204"), Color)
            sampleXButton.BackColor = DirectCast(New ColorConverter().ConvertFromString("IndianRed"), Color)
            sampleMinButton.BackColor = DirectCast(New ColorConverter().ConvertFromString("DodgerBlue"), Color)
            sampleStartButton.BackColor = DirectCast(New ColorConverter().ConvertFromString("Green"), Color)
            sampleTaskbar.BackColor = DirectCast(New ColorConverter().ConvertFromString("0, 102, 204"), Color)
            sampleNotifBar.BackColor = DirectCast(New ColorConverter().ConvertFromString("15, 143, 234"), Color)
            samplePanel.BackColor = DirectCast(New ColorConverter().ConvertFromString("236, 233, 216"), Color)
            sampleTitleBar.ForeColor = DirectCast(New ColorConverter().ConvertFromString("White"), Color)
            sampleStartButton.ForeColor = DirectCast(New ColorConverter().ConvertFromString("White"), Color)
            sampleXButton.ForeColor = DirectCast(New ColorConverter().ConvertFromString("white"), Color)
            Panel3.BackColor = sampleTitleBar.BackColor
            startButtonIcon.BackColor = sampleStartButton.BackColor()
            sampleXButton.ForeColor = sampleStartButton.ForeColor()
            sampleMinButton.ForeColor = sampleXButton.ForeColor()

        ElseIf ComboBox1.Text = "Classic" Then
            sampleTitleBar.BackColor = DirectCast(New ColorConverter().ConvertFromString("1, 0, 129"), Color)
            sampleXButton.BackColor = DirectCast(New ColorConverter().ConvertFromString("192, 192, 192"), Color)
            sampleMinButton.BackColor = DirectCast(New ColorConverter().ConvertFromString("192, 192, 192"), Color)
            sampleStartButton.BackColor = DirectCast(New ColorConverter().ConvertFromString("192, 192, 192"), Color)
            sampleTaskbar.BackColor = DirectCast(New ColorConverter().ConvertFromString("192, 192, 192"), Color)
            sampleNotifBar.BackColor = DirectCast(New ColorConverter().ConvertFromString("192, 192, 192"), Color)
            samplePanel.BackColor = DirectCast(New ColorConverter().ConvertFromString("192, 192, 192"), Color)
            sampleTitleBar.ForeColor = DirectCast(New ColorConverter().ConvertFromString("White"), Color)
            sampleStartButton.ForeColor = DirectCast(New ColorConverter().ConvertFromString("Black"), Color)
            Panel3.BackColor = sampleTitleBar.BackColor
            startButtonIcon.BackColor = sampleStartButton.BackColor()
            sampleXButton.ForeColor = sampleStartButton.ForeColor()
            sampleMinButton.ForeColor = sampleXButton.ForeColor()

        ElseIf ComboBox1.Text = "Olive Green" Then
            sampleTitleBar.BackColor = DirectCast(New ColorConverter().ConvertFromString("174, 192, 134"), Color)
            sampleXButton.BackColor = DirectCast(New ColorConverter().ConvertFromString("IndianRed"), Color)
            sampleMinButton.BackColor = DirectCast(New ColorConverter().ConvertFromString("132, 146, 85"), Color)
            sampleStartButton.BackColor = DirectCast(New ColorConverter().ConvertFromString("142, 163, 109"), Color)
            sampleTaskbar.BackColor = DirectCast(New ColorConverter().ConvertFromString("173, 189, 133"), Color)
            sampleNotifBar.BackColor = DirectCast(New ColorConverter().ConvertFromString("220, 206, 124"), Color)
            samplePanel.BackColor = DirectCast(New ColorConverter().ConvertFromString("236, 233, 216"), Color)
            sampleTitleBar.ForeColor = DirectCast(New ColorConverter().ConvertFromString("White"), Color)
            sampleStartButton.ForeColor = DirectCast(New ColorConverter().ConvertFromString("White"), Color)
            sampleXButton.ForeColor = DirectCast(New ColorConverter().ConvertFromString("white"), Color)
            Panel3.BackColor = sampleTitleBar.BackColor
            startButtonIcon.BackColor = sampleStartButton.BackColor()
            sampleXButton.ForeColor = sampleStartButton.ForeColor()
            sampleMinButton.ForeColor = sampleXButton.ForeColor()

        ElseIf ComboBox1.Text = "Royale Noir" Then
            sampleTitleBar.BackColor = DirectCast(New ColorConverter().ConvertFromString("Black"), Color)
            sampleXButton.BackColor = DirectCast(New ColorConverter().ConvertFromString("219, 101, 89"), Color)
            sampleMinButton.BackColor = DirectCast(New ColorConverter().ConvertFromString("Black"), Color)
            sampleStartButton.BackColor = DirectCast(New ColorConverter().ConvertFromString("51, 90, 52"), Color)
            sampleTaskbar.BackColor = DirectCast(New ColorConverter().ConvertFromString("51, 65, 81"), Color)
            sampleNotifBar.BackColor = DirectCast(New ColorConverter().ConvertFromString("28, 43, 65"), Color)
            samplePanel.BackColor = DirectCast(New ColorConverter().ConvertFromString("233, 232, 235"), Color)
            sampleTitleBar.ForeColor = DirectCast(New ColorConverter().ConvertFromString("White"), Color)
            sampleStartButton.ForeColor = DirectCast(New ColorConverter().ConvertFromString("White"), Color)
            sampleXButton.ForeColor = DirectCast(New ColorConverter().ConvertFromString("white"), Color)
            Panel3.BackColor = sampleTitleBar.BackColor
            startButtonIcon.BackColor = sampleStartButton.BackColor()
            sampleXButton.ForeColor = sampleStartButton.ForeColor()
            sampleMinButton.ForeColor = sampleXButton.ForeColor()

        ElseIf ComboBox1.Text = "Royale" Then
            sampleTitleBar.BackColor = DirectCast(New ColorConverter().ConvertFromString("90, 142, 202"), Color)
            sampleXButton.BackColor = DirectCast(New ColorConverter().ConvertFromString("219, 101, 89"), Color)
            sampleMinButton.BackColor = DirectCast(New ColorConverter().ConvertFromString("59, 127, 202"), Color)
            sampleStartButton.BackColor = DirectCast(New ColorConverter().ConvertFromString("56, 170, 74"), Color)
            sampleTaskbar.BackColor = DirectCast(New ColorConverter().ConvertFromString("61, 124, 204"), Color)
            sampleNotifBar.BackColor = DirectCast(New ColorConverter().ConvertFromString("95, 141, 200"), Color)
            samplePanel.BackColor = DirectCast(New ColorConverter().ConvertFromString("233, 232, 235"), Color)
            sampleTitleBar.ForeColor = DirectCast(New ColorConverter().ConvertFromString("White"), Color)
            sampleStartButton.ForeColor = DirectCast(New ColorConverter().ConvertFromString("White"), Color)
            sampleXButton.ForeColor = DirectCast(New ColorConverter().ConvertFromString("white"), Color)
            Panel3.BackColor = sampleTitleBar.BackColor
            startButtonIcon.BackColor = sampleStartButton.BackColor()
            sampleXButton.ForeColor = sampleStartButton.ForeColor()
            sampleMinButton.ForeColor = sampleXButton.ForeColor()

        ElseIf ComboBox1.Text = "Zune" Then
            sampleTitleBar.BackColor = DirectCast(New ColorConverter().ConvertFromString("Black"), Color)
            sampleXButton.BackColor = DirectCast(New ColorConverter().ConvertFromString("219, 101, 89"), Color)
            sampleMinButton.BackColor = DirectCast(New ColorConverter().ConvertFromString("Black"), Color)
            sampleStartButton.BackColor = DirectCast(New ColorConverter().ConvertFromString("222, 113, 41"), Color)
            sampleTaskbar.BackColor = DirectCast(New ColorConverter().ConvertFromString("51, 65, 81"), Color)
            sampleNotifBar.BackColor = DirectCast(New ColorConverter().ConvertFromString("28, 43, 65"), Color)
            samplePanel.BackColor = DirectCast(New ColorConverter().ConvertFromString("233, 232, 235"), Color)
            sampleTitleBar.ForeColor = DirectCast(New ColorConverter().ConvertFromString("White"), Color)
            sampleStartButton.ForeColor = DirectCast(New ColorConverter().ConvertFromString("White"), Color)
            sampleXButton.ForeColor = DirectCast(New ColorConverter().ConvertFromString("white"), Color)
            Panel3.BackColor = sampleTitleBar.BackColor
            startButtonIcon.BackColor = sampleStartButton.BackColor()
            sampleXButton.ForeColor = sampleStartButton.ForeColor()
            sampleMinButton.ForeColor = sampleXButton.ForeColor()

        ElseIf ComboBox1.Text = "Embedded" Then
            sampleTitleBar.BackColor = DirectCast(New ColorConverter().ConvertFromString("38, 109, 165"), Color)
            sampleXButton.BackColor = DirectCast(New ColorConverter().ConvertFromString("219, 57, 24"), Color)
            sampleMinButton.BackColor = DirectCast(New ColorConverter().ConvertFromString("20, 91, 147"), Color)
            sampleStartButton.BackColor = DirectCast(New ColorConverter().ConvertFromString("36, 83, 126"), Color)
            sampleTaskbar.BackColor = DirectCast(New ColorConverter().ConvertFromString("35, 106, 162"), Color)
            sampleNotifBar.BackColor = DirectCast(New ColorConverter().ConvertFromString("2, 68, 122"), Color)
            samplePanel.BackColor = DirectCast(New ColorConverter().ConvertFromString("233, 232, 235"), Color)
            sampleTitleBar.ForeColor = DirectCast(New ColorConverter().ConvertFromString("White"), Color)
            sampleStartButton.ForeColor = DirectCast(New ColorConverter().ConvertFromString("White"), Color)
            sampleXButton.ForeColor = DirectCast(New ColorConverter().ConvertFromString("white"), Color)
            Panel3.BackColor = sampleTitleBar.BackColor
            startButtonIcon.BackColor = sampleStartButton.BackColor()
            sampleXButton.ForeColor = sampleStartButton.ForeColor()
            sampleMinButton.ForeColor = sampleXButton.ForeColor()

        ElseIf ComboBox1.Text = "MSOE Raiders" Then
            sampleTitleBar.BackColor = DirectCast(New ColorConverter().ConvertFromString("78, 78, 78"), Color)
            sampleXButton.BackColor = DirectCast(New ColorConverter().ConvertFromString("IndianRed"), Color)
            sampleMinButton.BackColor = DirectCast(New ColorConverter().ConvertFromString("137, 137, 137"), Color)
            sampleStartButton.BackColor = DirectCast(New ColorConverter().ConvertFromString("153, 39, 6"), Color)
            sampleTaskbar.BackColor = DirectCast(New ColorConverter().ConvertFromString("51, 51, 51"), Color)
            sampleNotifBar.BackColor = DirectCast(New ColorConverter().ConvertFromString("153, 39, 6"), Color)
            samplePanel.BackColor = DirectCast(New ColorConverter().ConvertFromString("233, 232, 235"), Color)
            sampleTitleBar.ForeColor = DirectCast(New ColorConverter().ConvertFromString("White"), Color)
            sampleStartButton.ForeColor = DirectCast(New ColorConverter().ConvertFromString("White"), Color)
            sampleXButton.ForeColor = DirectCast(New ColorConverter().ConvertFromString("white"), Color)
            Panel3.BackColor = sampleTitleBar.BackColor
            startButtonIcon.BackColor = sampleStartButton.BackColor()
            sampleXButton.ForeColor = sampleStartButton.ForeColor()
            sampleMinButton.ForeColor = sampleXButton.ForeColor()

        ElseIf ComboBox1.Text = "Tropical" Then
            sampleTitleBar.BackColor = DirectCast(New ColorConverter().ConvertFromString("1, 194, 217"), Color)
            sampleXButton.BackColor = DirectCast(New ColorConverter().ConvertFromString("232, 109, 50"), Color)
            sampleMinButton.BackColor = DirectCast(New ColorConverter().ConvertFromString("215, 223, 131"), Color)
            sampleStartButton.BackColor = DirectCast(New ColorConverter().ConvertFromString("255, 106, 38"), Color)
            sampleTaskbar.BackColor = DirectCast(New ColorConverter().ConvertFromString("1, 194, 217"), Color)
            sampleNotifBar.BackColor = DirectCast(New ColorConverter().ConvertFromString("194, 205, 67"), Color)
            samplePanel.BackColor = DirectCast(New ColorConverter().ConvertFromString("243, 243, 243"), Color)
            sampleTitleBar.ForeColor = DirectCast(New ColorConverter().ConvertFromString("103, 103, 103"), Color)
            sampleStartButton.ForeColor = DirectCast(New ColorConverter().ConvertFromString("103, 103, 103"), Color)
            sampleXButton.ForeColor = DirectCast(New ColorConverter().ConvertFromString("103, 103, 103"), Color)
            Panel3.BackColor = sampleTitleBar.BackColor
            startButtonIcon.BackColor = sampleStartButton.BackColor()
            sampleXButton.ForeColor = sampleStartButton.ForeColor()
            sampleMinButton.ForeColor = sampleXButton.ForeColor()
        End If
    End Sub

    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles closeButton.Click
        Me.Close()
    End Sub

    Private Sub MinButton_Click(sender As Object, e As EventArgs) Handles minButton.Click
        Me.Hide()
    End Sub

    Private Sub Panel2_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles titleBar.MouseDown
        If e.Button = MouseButtons.Left Then
            Me.titleBar.Capture = False
            Const WM_NCLBUTTONDOWN As Integer = &HA1S
            Const HTCAPTION As Integer = 2
            Dim msg As Message =
            Message.Create(Me.Handle, WM_NCLBUTTONDOWN,
                New IntPtr(HTCAPTION), IntPtr.Zero)
            Me.DefWndProc(msg)
        End If
    End Sub

    Private Sub Themes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MaximumSize = Screen.PrimaryScreen.WorkingArea.Size
    End Sub

End Class