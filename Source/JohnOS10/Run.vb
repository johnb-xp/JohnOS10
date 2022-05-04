Public Class Run
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles min.Click
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles x.Click
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

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles ok.Click
        Dim r As String = TextBox1.Text.ToLower()
        Select Case r
            Case "exit"
                Desktop.Close()
            Case "winver"
                AboutJohnOS.Show()
            Case "josver"
                AboutJohnOS.Show()
            Case "browser"
                Browser.Show()
            Case "iexplore"
                Browser.Show()
            Case "settings"
                Settings.Show()
            Case "control"
                Settings.Show()
            Case "shutdown"
                Shutdown.Show()
            Case "update"
                UpdateJOS.Show()
            Case "yortzee"
                Yortzee.Show()
            Case "welcome"
                Welcome.Show()
            Case "calc"
                Calc.Show()
            Case "calculator"
                Calc.Show()
            Case "explorer"
                FileManager.Show()
            Case "file"
                FileManager.Show()
            Case "moon"
                MoonPhase.Show()
            Case "notepad"
                Notepad.Show()
            Case "network"
                NetworkDiagnostic.Show()
            Case "NetworkDiagnostic"
                NetworkDiagnostic.Show()
            Case "netcheck"
                NetworkDiagnostic.Show()
            Case "radio"
                RadioMarg.Show()
            Case "margarita"
                RadioMarg.Show()
            Case "maps"
                Maps.Show()
            Case "winmine"
                Minesweeper.Show()
            Case "minesweeper"
                Minesweeper.Show()
            Case "mplayer"
                MediaPlayer.Show()
            Case "media"
                MediaPlayer.Show()
            Case "launcher"
                Launcher.Show()
            Case "jim"
                JIM.Show()
            Case "clock"
                Clock.Show()
            Case "calendar"
                Calendar.Show()
            Case "btc"
                BitcoinPrice.Show()
            Case "bitcoin"
                BitcoinPrice.Show()
            Case "start"
                StartMenu.Show()
            Case "allprogs"
                allPrograms.Show()
            Case "egg"
                Egg.Show()
            Case "john"
                Egg.EasterEgg()
            Case "welcome"
                Welcome.Show()
            Case "display"
                DisplaySettings.Show()
            Case "display setings"
                DisplaySettings.Show()
            Case "themes"
                Themes.Show()
            Case "browser -about"
                AboutIE.Show()
            Case "browser -patch"
                BrowserPatcher.Show()
            Case "browser -new"
                Browser.Show()
            Case "browser"
                Desktop.launchBrowser()
            Case "browser -old"
                oldBrowser.Show()
            Case "browser -classic"
                oldBrowser.Show()
            Case "oldbrowser"
                oldBrowser.Show()
            Case "reset"
                My.Settings.FirstRun = True
                My.Settings.Save()
            Case "all"
                Themes.Show()
                AboutIE.Show()
                AboutJohnOS.Show()
                allPrograms.Show()
                BitcoinPrice.Show()
                Calc.Show()
                Calendar.Show()
                Clock.Show()
                DisplaySettings.Show()
                Egg.Show()
                FileManager.Show()
                JIM.Show()
                Launcher.Show()
                Maps.Show()
                MediaPlayer.Show()
                Minesweeper.Show()
                MoonPhase.Show()
                NetworkDiagnostic.Show()
                Notepad.Show()
                RadioMarg.Show()
                RunError.Show()
                Settings.Show()
                StartMenu.Show()
                Themes.Show()
                UpdateJOS.Show()
                Welcome.Show()
                Yortzee.Show()

            Case Else
                Try
                    Dim OpenCMD
                    OpenCMD = CreateObject("wscript.shell")
                    OpenCMD.run(TextBox1.Text)
                Catch
                    RunError.Show()
                End Try
        End Select
        Me.Close()
    End Sub

    Private Sub Run_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MaximumSize = Screen.PrimaryScreen.WorkingArea.Size
        Me.Location = New Point((Screen.PrimaryScreen.Bounds.Width - Me.Width) / 2, Screen.PrimaryScreen.Bounds.Height - 30 - Me.Height)
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class