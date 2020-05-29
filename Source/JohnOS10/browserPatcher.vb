Imports Microsoft.Win32
Imports System.Reflection

Public Class BrowserPatcher
    ' This program will attempt to update the Windows registry so the latest version of Internet Explorer is installed.

    Private Shared wbfAssemblyName As String
    Public ieVer As Integer = 0

    ''' Get current version of Internet Explorer on user's machine
    ''' Returns IE version # (throws exception if IE is not present or pre-version 7)
    Public Function GetCurrentBrowserVersion() As Integer
        Dim browserVersion As Integer = 0
        '   get version ID
        Using ieKey As RegistryKey =
                Registry.LocalMachine.OpenSubKey("SOFTWARE\Microsoft\Internet Explorer",
                    RegistryKeyPermissionCheck.ReadSubTree,
                    System.Security.AccessControl.RegistryRights.QueryValues)
            Dim version As Object = ieKey.GetValue("svcVersion")
            If version Is Nothing Then
                version = ieKey.GetValue("Version")
                '   no Internet Explorer
                If version Is Nothing Then _
                consoleLogBox.Text = consoleLogBox.Text & vbNewLine & "Internet Explorer not detected on your system"
            End If
            Integer.TryParse(version.ToString().Split("."c)(0), browserVersion)
        End Using
        '   make sure version is 7 or higher
        If browserVersion < 7 Then
            consoleLogBox.Text = consoleLogBox.Text & vbNewLine & "Your version of Internet Explorer is too old to work with the JohnOS browser"
        End If
        consoleLogBox.Text = consoleLogBox.Text & vbNewLine & "Detected IE " + browserVersion.ToString

        Return browserVersion
    End Function

    Public Sub SetBrowserEmulationVersion(ByVal AssemblyName As String)
        Dim browserVersion As Integer = Me.GetCurrentBrowserVersion()

        '   get name of current assembly
        If String.IsNullOrEmpty(AssemblyName) Then
            '   not given
            consoleLogBox.Text = consoleLogBox.Text & vbNewLine & "Error configuring registry settings"

        Else
            '   save for future calls
            wbfAssemblyName = AssemblyName
        End If

        '' Force standards mode
        Select Case browserVersion
            Case "7"
                browserVersion = 7000
            Case "8"
                browserVersion = 8888
            Case "9"
                browserVersion = 9999
            Case "10"
                browserVersion = 10001
            Case Else
                If browserVersion >= 11 Then
                    browserVersion = 11001
                Else
                    Throw New Exception("IE Version not supported")
                End If
        End Select

        '   set emulation keys for 32-bit/64-bit release/debug versions
        Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Microsoft\Internet Explorer" _
            & "\MAIN\FeatureControl\FEATURE_BROWSER_EMULATION",
                wbfAssemblyName & ".exe", browserVersion)
        Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Microsoft\Internet Explorer" _
            & "\MAIN\FeatureControl\FEATURE_BROWSER_EMULATION",
                wbfAssemblyName & ".vshost.exe", browserVersion)
        Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Wow6432Node\" _
            & "Microsoft\Internet Explorer\MAIN\FeatureControl\FEATURE_BROWSER_EMULATION",
                wbfAssemblyName & ".exe", browserVersion)
        Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Wow6432Node\" _
            & "Microsoft\Internet Explorer\MAIN\FeatureControl\FEATURE_BROWSER_EMULATION",
                wbfAssemblyName & ".vshost.exe", browserVersion)
        consoleLogBox.Text = consoleLogBox.Text & vbNewLine & "Successfully patched registry. JohnOS Browser updated."

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
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

    Private Sub Patch(sender As Object, e As EventArgs) Handles MyBase.Load
        '' Runs Code
        SetBrowserEmulationVersion(System.Reflection.Assembly.GetExecutingAssembly.GetName.Name())
        My.Settings.browserPatched = True
        My.Settings.Save()
    End Sub

    Private Sub ContinueButton_Click(sender As Object, e As EventArgs) Handles continueButton.Click
        Browser.Show()
        Me.Close()
    End Sub
End Class