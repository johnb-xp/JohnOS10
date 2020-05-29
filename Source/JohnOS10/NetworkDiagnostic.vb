Imports System.IO
Imports System.Net

Public Class NetworkDiagnostic

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Me.Close()
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


    Private Sub Label1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label1.MouseDown
        If e.Button = MouseButtons.Left Then
            Me.Label1.Capture = False
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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        infobox.Text = "Testing Connection"
        Dim tClient As WebClient = New WebClient

        '' Ping MSOE server to see if connected to the Internet
        Try
            My.Computer.Network.Ping("msoe.edu", 800)
            IntIndicator.BackgroundImage = My.Resources.internetconnected
            infobox.Text = "Connected to the Internet"
        Catch
            IntIndicator.BackgroundImage = My.Resources.nointernet
            infobox.Text = "Could not connect to the Internet"
        End Try

        '' Get an empty text file from my server to detect if the server is up
        '' and serving files
        Try
            Dim client As WebClient = New WebClient()
            Dim reader As StreamReader = New StreamReader(client.OpenRead("http://johnbilkey.cf/johnos/latest.txt"))
            JOSIndicator.BackgroundImage = My.Resources.josconnect
            infobox.Text = "Connected to JohnOS Internet Service"
        Catch
            JOSIndicator.BackgroundImage = My.Resources.nointernet
            infobox.Text = "Could not connect to the JohnOS Internet Service"
        End Try

    End Sub

    Private Sub NetworkDiagnostic_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MaximumSize = Screen.PrimaryScreen.WorkingArea.Size
        Me.BringToFront()
        IntIndicator.BackgroundImage = My.Resources.test
        JOSIndicator.BackgroundImage = My.Resources.test

    End Sub

End Class