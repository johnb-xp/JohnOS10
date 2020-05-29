Public Class allPrograms
    Private Sub updateButton_Click(sender As Object, e As EventArgs) Handles updateButton.Click
        UpdateJOS.Show()
        Me.Hide()
        StartMenu.Hide()

    End Sub

    Private Sub browserButton_Click(sender As Object, e As EventArgs) Handles browserButton.Click
        If Not My.Settings.browserPatched Then
            BrowserPatcher.Show()
        Else
            Browser.Show()
        End If
        Me.Hide()
        StartMenu.Hide()


    End Sub

    Private Sub calendarButton_Click(sender As Object, e As EventArgs) Handles calendarButton.Click
        Calendar.Show()
        Me.Hide()
        StartMenu.Hide()


    End Sub

    Private Sub minesweeperButton_Click(sender As Object, e As EventArgs) Handles minesweeperButton.Click
        Minesweeper.Show()
        Me.Hide()
        StartMenu.Hide()


    End Sub

    Private Sub calculatorButton_Click(sender As Object, e As EventArgs) Handles calculatorButton.Click
        Calc.Show()
        Me.Hide()
        StartMenu.Hide()


    End Sub

    Private Sub notepadButton_Click(sender As Object, e As EventArgs) Handles notepadButton.Click
        Notepad.Show()
        Me.Hide()
        StartMenu.Hide()


    End Sub

    Private Sub jimButton_Click(sender As Object, e As EventArgs) Handles jimButton.Click
        JIM.Show()
        Me.Hide()
        StartMenu.Hide()


    End Sub

    Private Sub moonButton_Click(sender As Object, e As EventArgs) Handles moonButton.Click
        MoonPhase.Show()
        Me.Hide()
        StartMenu.Hide()


    End Sub

    Private Sub mediaButton_Click(sender As Object, e As EventArgs) Handles mediaButton.Click
        MediaPlayer.Show()
        Me.Hide()
        StartMenu.Hide()


    End Sub

    Private Sub radioButton_Click(sender As Object, e As EventArgs) Handles radioButton.Click
        RadioMarg.Show()
        Me.Hide()
        StartMenu.Hide()


    End Sub

    Private Sub bitcoinButton_Click(sender As Object, e As EventArgs) Handles bitcoinButton.Click
        BitcoinPrice.Show()
        Me.Hide()
        StartMenu.Hide()


    End Sub

    Private Sub yortzeeButton_Click(sender As Object, e As EventArgs) Handles yortzeeButton.Click
        Yortzee.Show()
        Me.Hide()
        StartMenu.Hide()


    End Sub

    Private Sub clockButton_Click(sender As Object, e As EventArgs) Handles clockButton.Click
        Clock.Show()
        Me.Hide()
        StartMenu.Hide()


    End Sub

    Private Sub mapsButton_Click(sender As Object, e As EventArgs) Handles mapsButton.Click
        Maps.Show()
        Me.Hide()
        StartMenu.Hide()


    End Sub

    Private Sub settingsButton_Click(sender As Object, e As EventArgs) Handles settingsButton.Click
        Settings.Show()
        Me.Hide()
        StartMenu.Hide()


    End Sub

    Private Sub closeButton_Click(sender As Object, e As EventArgs) Handles closeButton.Click
        Me.Hide()
    End Sub
    Private Sub allPrograms_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Location = New Point(StartMenu.Width, Screen.PrimaryScreen.Bounds.Height - 30 - Me.Height)
        Me.MaximumSize = Screen.PrimaryScreen.WorkingArea.Size
    End Sub
End Class