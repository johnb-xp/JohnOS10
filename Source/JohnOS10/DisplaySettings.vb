Public Class DisplaySettings
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
        Me.BringToFront()
        PictureBox.BackgroundImage = Desktop.BackgroundImage
        PictureBox.BackgroundImageLayout = Desktop.BackgroundImageLayout
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.Text = "Mountain" Then
            PictureBox.BackgroundImage = My.Resources.default_wall
        ElseIf ComboBox1.Text = "None" Then
            PictureBox.BackgroundImage = Nothing
        ElseIf ComboBox1.Text = "Cloud Leap" Then
            PictureBox.BackgroundImage = My.Resources.win2k
        ElseIf ComboBox1.Text = "Clouds" Then
            PictureBox.BackgroundImage = My.Resources.clouds
        ElseIf ComboBox1.Text = "MSOE" Then
            PictureBox.BackgroundImage = My.Resources.msoe_logo
        ElseIf ComboBox1.Text = "River Sumida" Then
            PictureBox.BackgroundImage = My.Resources.river_sumida
        ElseIf ComboBox1.Text = "Gone Fishing" Then
            PictureBox.BackgroundImage = My.Resources.gone_fishing
        ElseIf ComboBox1.Text = "NT Server" Then
            PictureBox.BackgroundImage = My.Resources.nt_server
        End If
    End Sub

    Private Sub ComboBox1_Egg(sender As Object, e As EventArgs) Handles ComboBox1.Click
        Dim r As String = ComboBox1.Text.ToLower()
        If r = "john" Then
            PictureBox.BackgroundImage = My.Resources.nicole
        ElseIf r = "nicole" Then
            PictureBox.BackgroundImage = My.Resources.nicole
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ofd.ShowDialog()
    End Sub

    Private Sub ofd_FileOk(sender As System.Object, e As System.ComponentModel.CancelEventArgs) Handles ofd.FileOk
        PictureBox.BackgroundImage = Image.FromFile(ofd.FileName)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Desktop.BackgroundImage = PictureBox.BackgroundImage
        Desktop.BackgroundImageLayout = PictureBox.BackgroundImageLayout
        Desktop.BackColor = PictureBox.BackColor
        My.Settings.BackgroundImage = GetStringFromImage(PictureBox.BackgroundImage)
        My.Settings.BackgroundImageLayout = PictureBox.BackgroundImageLayout
        My.Settings.BackgroundColor = PictureBox.BackColor()
        My.Settings.Save()
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        If ComboBox2.Text = "Tile" Then
            PictureBox.BackgroundImageLayout = 1
        ElseIf ComboBox2.Text = "Center" Then
            PictureBox.BackgroundImageLayout = 2
        ElseIf ComboBox2.Text = "Stretch" Then
            PictureBox.BackgroundImageLayout = 3
        ElseIf ComboBox2.Text = "Zoom" Then
            PictureBox.BackgroundImageLayout = 4
        End If
    End Sub

    Public Shared Function GetStringFromImage(image As Image) As String
        If image IsNot Nothing Then
            Dim ic As New ImageConverter()
            Dim buffer As Byte() = DirectCast(ic.ConvertTo(image, GetType(Byte())), Byte())
            Return Convert.ToBase64String(buffer, Base64FormattingOptions.InsertLineBreaks)
        Else
            Return Nothing
        End If
    End Function

    Public Shared Function GetImageFromString(base64String As String) As Image
        If String.IsNullOrWhiteSpace(base64String) Then Return Nothing
        Dim buffer As Byte() = Convert.FromBase64String(base64String)
        If buffer IsNot Nothing Then
            Dim ic As New ImageConverter()
            Return TryCast(ic.ConvertFrom(buffer), Image)
        Else
            Return Nothing
        End If
    End Function

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Try
            Dim dlg As ColorDialog = New ColorDialog
            dlg.Color = PictureBox.BackColor
            If dlg.ShowDialog = System.Windows.Forms.DialogResult.OK Then
                PictureBox.BackColor = dlg.Color
            End If
        Catch ex As Exception : End Try
    End Sub
End Class