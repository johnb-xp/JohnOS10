Imports System.Net
Imports System.IO

Public Class Desktop
    Public updateReleased As Boolean = False
    '' True if an update is available
    Public latest As String
    '' Holds version # of latest version from JohnOS Server

    Private Sub ComputerIcon_Click(sender As Object, e As EventArgs) Handles ComputerIcon.Click
        FileManager.Show()
    End Sub

    Private Sub ComputerLabel_Click(sender As Object, e As EventArgs) Handles computerLabel.Click
        FileManager.Show()
    End Sub

    Private Sub BrowserLabel_Click(sender As Object, e As EventArgs) Handles browserLabel.Click
        If Not My.Settings.browserPatched Then
            BrowserPatcher.Show()
        Else
            Browser.Show()
        End If
        ' Launches the browser - if the browser is not set up it will launch its setup program.
    End Sub

    Private Sub IE_Icon_Click(sender As System.Object, e As System.EventArgs) Handles IE_Icon.Click
        If Not My.Settings.browserPatched Then
            BrowserPatcher.Show()
        Else
            Browser.Show()
        End If
    End Sub

    Private Sub Notepad_Icon_Click(sender As System.Object, e As System.EventArgs) Handles Notepad_Icon.Click
        Notepad.Show()
    End Sub

    Private Sub NotepadLabel_Click(sender As Object, e As EventArgs) Handles notepadLabel.Click
        Notepad.Show()
    End Sub

    Private Sub Startbutton_Click(sender As System.Object, e As System.EventArgs) Handles startbutton.Click
        If StartMenu.Visible Then
            StartMenu.Hide()
            allPrograms.Hide()
        Else
            StartMenu.Show()
        End If
    End Sub
    Private Sub TaskbarClock_Click(sender As Object, e As EventArgs) Handles taskbarClockLabel.Click
        Calendar.Show()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles taskbarClockTimer.Tick
        If My.Settings.clock = 12 Then
            taskbarClockLabel.Text = DateTime.Now.ToString("hh:mm tt")
        Else
            taskbarClockLabel.Text = DateTime.Now.ToString("HH:mm tt")
        End If
        ' My.Settings.Clock is edited in the Clock program, accessible through All Programs.
    End Sub

    Private Sub NetworkIcon_Click(sender As Object, e As EventArgs) Handles networkIcon.Click
        If updateReleased Then
            UpdateJOS.Show()
        Else
            NetworkDiagnostic.Show()
        End If
        ' Opens network diagnostic if no update available, would display connected icon
        ' Opens JohnOS Update if an update is available, would display update icon.

    End Sub

    Private Sub UpdateCheckTimer_Tick(sender As Object, e As EventArgs) Handles refreshJIS.Tick
        Me.UpdateCheck()
        ''Runs Update check And network test at interval set on refreshJIS
    End Sub

    Private Sub UpdateCheck()
        networkIcon.Hide()
        Try
            Dim client As WebClient = New WebClient()
            Dim reader As StreamReader = New StreamReader(client.OpenRead("http://johnbilkey.cf/johnos/latest.txt"))
            latest = reader.ReadLine()
            ''Checks for Updates based on the version stated in the "AboutJohnOS" program
            If latest.Equals(AboutJohnOS.GetVersion()) Then
                networkIcon.BackgroundImage = My.Resources.josconnect
                '' No updates
            Else
                networkIcon.BackgroundImage = My.Resources.update
                updateReleased = True
                '' Updates
            End If
        Catch
            networkIcon.BackgroundImage = My.Resources.nointernet
            ''Could not connect To server
        End Try
        networkIcon.Show()
    End Sub

    Private Sub StartButtonIcon_Click(sender As Object, e As EventArgs) Handles startButtonIcon.Click
        If StartMenu.Visible Then
            StartMenu.Hide()
            allPrograms.Hide()
        Else
            StartMenu.Show()
        End If
    End Sub

    Private Sub RadioMiniPlayer_Click(sender As Object, e As EventArgs) Handles radioMiniPlayer.Click
        RadioMarg.Show()
        radioMiniPlayer.Hide()

    End Sub

    Private Sub MiniPlayer_Click(sender As Object, e As EventArgs) Handles miniPlayer.Click
        MediaPlayer.Show()
        miniPlayer.Hide()
    End Sub

    Private Sub Desktop_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Loads desktop background settings from My.Settings - Configured in Display Settings in Control Panel
        If Not My.Settings.FirstRun Then
            Me.BackgroundImageLayout = My.Settings.BackgroundImageLayout
            Me.BackgroundImage = DisplaySettings.GetImageFromString(My.Settings.BackgroundImage)
            Me.BackColor = My.Settings.BackgroundColor
        Else
            ' This code excecutes on the first run of the program
            Me.BackgroundImage = My.Resources.default_wall
            Me.BackgroundImageLayout = 3
            My.Settings.BackgroundImage = DisplaySettings.GetStringFromImage(Me.BackgroundImage)
            My.Settings.BackgroundImageLayout = Me.BackgroundImageLayout
            My.Settings.Save()
            Themes.Reset()
            Welcome.Run()
        End If

        Me.UpdateCheck()
        ' Runs update check on launch
    End Sub

End Class