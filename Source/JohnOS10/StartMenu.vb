Public Class StartMenu

    Private Sub closeMenuButton_Click(sender As Object, e As EventArgs) Handles closeMenuButton.Click
        Me.Hide()
        allPrograms.Hide()
    End Sub

    Private Sub closeMenuIcon_Click(sender As Object, e As EventArgs) Handles closeMenuIcon.Click
        Me.Hide()
        allPrograms.Hide()

    End Sub

    Private Sub browserIcon_Click(sender As Object, e As EventArgs) Handles browserIcon.Click
        If Not My.Settings.browserPatched Then
            BrowserPatcher.Show()
        Else
            Browser.Show()
        End If
        Me.Hide()
        allPrograms.Hide()

    End Sub

    Private Sub browserButton_Click(sender As Object, e As EventArgs) Handles browserButton.Click
        Desktop.launchBrowser()
        Me.Hide()
        allPrograms.Hide()

    End Sub

    Private Sub notepadIcon_Click(sender As Object, e As EventArgs) Handles notepadIcon.Click
        Run.Show()
        Me.Hide()
        allPrograms.Hide()

    End Sub

    Private Sub notepadButton_Click(sender As Object, e As EventArgs) Handles notepadButton.Click
        Run.Show()
        Me.Hide()
        allPrograms.Hide()

    End Sub

    Private Sub settingsIcon_Click(sender As Object, e As EventArgs) Handles settingsIcon.Click
        Settings.Show()
        Me.Hide()
        allPrograms.Hide()

    End Sub


    Private Sub settingsButton_Click(sender As Object, e As EventArgs) Handles settingsButton.Click
        Settings.Show()
        Me.Hide()
        allPrograms.Hide()

    End Sub

    Private Sub launcherButton_Click(sender As Object, e As EventArgs) Handles launcherButton.Click
        Launcher.Show()
        Me.Hide()
        allPrograms.Hide()


    End Sub

    Private Sub launcherIcon_Click(sender As Object, e As EventArgs) Handles launcherIcon.Click
        Launcher.Show()
        Me.Hide()
        allPrograms.Hide()


    End Sub

    Private Sub allProgramsButton_Click(sender As Object, e As EventArgs) Handles allProgramsButton.Click
        If allPrograms.Visible Then
            allPrograms.Hide()
        Else
            allPrograms.Show()
        End If

    End Sub

    Private Sub allProgramsIcon_Click(sender As Object, e As EventArgs) Handles allProgramsIcon.Click
        If allPrograms.Visible Then
            allPrograms.Hide()
        Else
            allPrograms.Show()
        End If

    End Sub

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
        Application.Exit()
        End
    End Sub

    Private Sub shutdownButton_Click(sender As Object, e As EventArgs) Handles shutdownButton.Click
        Shutdown.Show()
        Me.Hide()
        allPrograms.Hide()


    End Sub

    Private Sub StartMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Location = New Point(0, Screen.PrimaryScreen.Bounds.Height - 30 - Me.Height)
        Me.MaximumSize = Screen.PrimaryScreen.WorkingArea.Size

    End Sub
End Class