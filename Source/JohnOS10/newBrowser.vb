Public Class newBrowser
    '' Working on updating to browser based on WebView2 (Chromium Edge - Requires newer .NET Framework and Chromium engine in Windows)
    Private Sub Browser_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MaximumSize = Screen.PrimaryScreen.WorkingArea.Size
    End Sub

    Private Sub CloseButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles closeButton.Click
        Me.Close()
    End Sub

    Private Sub BackButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles backButton.Click
        WebView21.GoBack()
    End Sub

    Private Sub RefreshButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles refreshButton.Click
        WebView21.Refresh()
    End Sub

    Private Sub GoButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles goButton.Click
        Me.WebView21.CoreWebView2.Navigate(urlBar.Text)
    End Sub

    Private Sub ForwardButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles forwardButton.Click
        WebView21.GoForward()
    End Sub
    Private Sub Panel1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseDown
        If e.Button = MouseButtons.Left Then
            Me.Panel1.Capture = False
            Const WM_NCLBUTTONDOWN As Integer = &HA1S
            Const HTCAPTION As Integer = 2
            Dim msg As Message =
            Message.Create(Me.Handle, WM_NCLBUTTONDOWN,
                New IntPtr(HTCAPTION), IntPtr.Zero)
            Me.DefWndProc(msg)
        End If
    End Sub
    '' Handles draggin title bar

    Private Sub InfoButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles informationButton.Click
        AboutIE.Show()
    End Sub
    '' About Button

    Private Sub HomeButton_Click(sender As System.Object, e As System.EventArgs) Handles homeButton.Click
        Me.WebView21.CoreWebView2.Navigate("http://johnbilkey.cf/johnos")
    End Sub
    '' Home Button

    Private Sub MinButton_Click(sender As Object, e As EventArgs) Handles minButton.Click
        Me.Hide()
    End Sub
    '' Min Button

    Private Sub MaxButton_Click(sender As Object, e As EventArgs) Handles maxButton.Click
        If Me.WindowState = FormWindowState.Normal Then
            Me.WindowState = FormWindowState.Maximized
        Else
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub
    '' Max button

    Private Sub UrlBar_KeyDown(sender As Object, e As KeyEventArgs) Handles urlBar.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.WebView21.CoreWebView2.Navigate(urlBar.Text)
            e.Handled = True
            e.SuppressKeyPress = True
        End If
    End Sub
    '' Handles enter key

    Private Sub WebView2_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs)
        urlBar.Text = Me.WebView21.Source.ToString()
    End Sub
    ''Go Button

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles searchButton.Click
        Me.WebView21.CoreWebView2.Navigate("https://duckduckgo.com/?t=palemoon&q=" & urlBar.Text)
    End Sub

    '' Search Button

End Class