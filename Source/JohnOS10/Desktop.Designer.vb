<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Desktop
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Desktop))
        Me.JohnOSDesktoplogo = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.notepadLabel = New System.Windows.Forms.Label()
        Me.Notepad_Icon = New System.Windows.Forms.PictureBox()
        Me.IE_Icon = New System.Windows.Forms.PictureBox()
        Me.browserLabel = New System.Windows.Forms.Label()
        Me.ComputerIcon = New System.Windows.Forms.PictureBox()
        Me.computerLabel = New System.Windows.Forms.Label()
        Me.taskbarClockTimer = New System.Windows.Forms.Timer(Me.components)
        Me.refreshJIS = New System.Windows.Forms.Timer(Me.components)
        Me.taskbar = New System.Windows.Forms.Panel()
        Me.rightBar = New System.Windows.Forms.Panel()
        Me.networkIcon = New System.Windows.Forms.PictureBox()
        Me.taskbarClockLabel = New System.Windows.Forms.Label()
        Me.miniPlayer = New System.Windows.Forms.PictureBox()
        Me.radioMiniPlayer = New System.Windows.Forms.PictureBox()
        Me.startButtonIcon = New System.Windows.Forms.PictureBox()
        Me.startbutton = New System.Windows.Forms.Button()
        CType(Me.JohnOSDesktoplogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Notepad_Icon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IE_Icon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComputerIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.taskbar.SuspendLayout()
        Me.rightBar.SuspendLayout()
        CType(Me.networkIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.miniPlayer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.radioMiniPlayer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.startButtonIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'JohnOSDesktoplogo
        '
        Me.JohnOSDesktoplogo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.JohnOSDesktoplogo.BackColor = System.Drawing.Color.Transparent
        Me.JohnOSDesktoplogo.BackgroundImage = CType(resources.GetObject("JohnOSDesktoplogo.BackgroundImage"), System.Drawing.Image)
        Me.JohnOSDesktoplogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.JohnOSDesktoplogo.Location = New System.Drawing.Point(578, 6)
        Me.JohnOSDesktoplogo.Name = "JohnOSDesktoplogo"
        Me.JohnOSDesktoplogo.Size = New System.Drawing.Size(47, 41)
        Me.JohnOSDesktoplogo.TabIndex = 16
        Me.JohnOSDesktoplogo.TabStop = False
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Trebuchet MS", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(620, 10)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(177, 40)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "JohnOS 10"
        '
        'notepadLabel
        '
        Me.notepadLabel.AutoSize = True
        Me.notepadLabel.BackColor = System.Drawing.Color.Transparent
        Me.notepadLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.notepadLabel.Location = New System.Drawing.Point(8, 185)
        Me.notepadLabel.Name = "notepadLabel"
        Me.notepadLabel.Size = New System.Drawing.Size(61, 16)
        Me.notepadLabel.TabIndex = 3
        Me.notepadLabel.Text = "Notepad"
        '
        'Notepad_Icon
        '
        Me.Notepad_Icon.BackColor = System.Drawing.Color.Transparent
        Me.Notepad_Icon.BackgroundImage = CType(resources.GetObject("Notepad_Icon.BackgroundImage"), System.Drawing.Image)
        Me.Notepad_Icon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Notepad_Icon.Location = New System.Drawing.Point(11, 137)
        Me.Notepad_Icon.Name = "Notepad_Icon"
        Me.Notepad_Icon.Size = New System.Drawing.Size(48, 48)
        Me.Notepad_Icon.TabIndex = 14
        Me.Notepad_Icon.TabStop = False
        '
        'IE_Icon
        '
        Me.IE_Icon.BackColor = System.Drawing.Color.Transparent
        Me.IE_Icon.BackgroundImage = CType(resources.GetObject("IE_Icon.BackgroundImage"), System.Drawing.Image)
        Me.IE_Icon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.IE_Icon.InitialImage = Nothing
        Me.IE_Icon.Location = New System.Drawing.Point(12, 69)
        Me.IE_Icon.Name = "IE_Icon"
        Me.IE_Icon.Size = New System.Drawing.Size(48, 48)
        Me.IE_Icon.TabIndex = 12
        Me.IE_Icon.TabStop = False
        '
        'browserLabel
        '
        Me.browserLabel.AutoSize = True
        Me.browserLabel.BackColor = System.Drawing.Color.Transparent
        Me.browserLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.browserLabel.Location = New System.Drawing.Point(9, 118)
        Me.browserLabel.Name = "browserLabel"
        Me.browserLabel.Size = New System.Drawing.Size(57, 16)
        Me.browserLabel.TabIndex = 2
        Me.browserLabel.Text = "Browser"
        '
        'ComputerIcon
        '
        Me.ComputerIcon.BackColor = System.Drawing.Color.Transparent
        Me.ComputerIcon.BackgroundImage = CType(resources.GetObject("ComputerIcon.BackgroundImage"), System.Drawing.Image)
        Me.ComputerIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ComputerIcon.Location = New System.Drawing.Point(12, 2)
        Me.ComputerIcon.Name = "ComputerIcon"
        Me.ComputerIcon.Size = New System.Drawing.Size(48, 48)
        Me.ComputerIcon.TabIndex = 20
        Me.ComputerIcon.TabStop = False
        '
        'computerLabel
        '
        Me.computerLabel.AutoSize = True
        Me.computerLabel.BackColor = System.Drawing.Color.Transparent
        Me.computerLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.computerLabel.Location = New System.Drawing.Point(-1, 51)
        Me.computerLabel.Name = "computerLabel"
        Me.computerLabel.Size = New System.Drawing.Size(87, 16)
        Me.computerLabel.TabIndex = 1
        Me.computerLabel.Text = "My Computer"
        '
        'taskbarClockTimer
        '
        Me.taskbarClockTimer.Enabled = True
        Me.taskbarClockTimer.Interval = 500
        '
        'refreshJIS
        '
        Me.refreshJIS.Enabled = True
        Me.refreshJIS.Interval = 1800000
        '
        'taskbar
        '
        Me.taskbar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.taskbar.BackColor = Global.JohnOS10.My.MySettings.Default.taskbarColor
        Me.taskbar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.taskbar.Controls.Add(Me.rightBar)
        Me.taskbar.Controls.Add(Me.startButtonIcon)
        Me.taskbar.Controls.Add(Me.startbutton)
        Me.taskbar.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.JohnOS10.My.MySettings.Default, "taskbarColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.taskbar.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.taskbar.Location = New System.Drawing.Point(0, 570)
        Me.taskbar.MaximumSize = New System.Drawing.Size(0, 30)
        Me.taskbar.MinimumSize = New System.Drawing.Size(0, 30)
        Me.taskbar.Name = "taskbar"
        Me.taskbar.Size = New System.Drawing.Size(800, 30)
        Me.taskbar.TabIndex = 11
        '
        'rightBar
        '
        Me.rightBar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rightBar.AutoSize = True
        Me.rightBar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.rightBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.rightBar.Controls.Add(Me.networkIcon)
        Me.rightBar.Controls.Add(Me.taskbarClockLabel)
        Me.rightBar.Controls.Add(Me.miniPlayer)
        Me.rightBar.Controls.Add(Me.radioMiniPlayer)
        Me.rightBar.Location = New System.Drawing.Point(627, 0)
        Me.rightBar.MaximumSize = New System.Drawing.Size(173, 30)
        Me.rightBar.MinimumSize = New System.Drawing.Size(125, 30)
        Me.rightBar.Name = "rightBar"
        Me.rightBar.Size = New System.Drawing.Size(173, 30)
        Me.rightBar.TabIndex = 12
        '
        'networkIcon
        '
        Me.networkIcon.BackColor = Global.JohnOS10.My.MySettings.Default.notifBarColor
        Me.networkIcon.BackgroundImage = Global.JohnOS10.My.Resources.Resources.nointernet
        Me.networkIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.networkIcon.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.JohnOS10.My.MySettings.Default, "notifBarColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.networkIcon.Dock = System.Windows.Forms.DockStyle.Left
        Me.networkIcon.ErrorImage = Nothing
        Me.networkIcon.InitialImage = Nothing
        Me.networkIcon.Location = New System.Drawing.Point(48, 0)
        Me.networkIcon.Name = "networkIcon"
        Me.networkIcon.Size = New System.Drawing.Size(24, 30)
        Me.networkIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.networkIcon.TabIndex = 13
        Me.networkIcon.TabStop = False
        '
        'taskbarClockLabel
        '
        Me.taskbarClockLabel.BackColor = Global.JohnOS10.My.MySettings.Default.notifBarColor
        Me.taskbarClockLabel.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.JohnOS10.My.MySettings.Default, "notifBarColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.taskbarClockLabel.DataBindings.Add(New System.Windows.Forms.Binding("ForeColor", Global.JohnOS10.My.MySettings.Default, "startButtonTextColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.taskbarClockLabel.Dock = System.Windows.Forms.DockStyle.Right
        Me.taskbarClockLabel.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.taskbarClockLabel.ForeColor = Global.JohnOS10.My.MySettings.Default.startButtonTextColor
        Me.taskbarClockLabel.Location = New System.Drawing.Point(72, 0)
        Me.taskbarClockLabel.Margin = New System.Windows.Forms.Padding(0)
        Me.taskbarClockLabel.Name = "taskbarClockLabel"
        Me.taskbarClockLabel.Size = New System.Drawing.Size(101, 30)
        Me.taskbarClockLabel.TabIndex = 4
        Me.taskbarClockLabel.Text = "00:00 PM"
        Me.taskbarClockLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'miniPlayer
        '
        Me.miniPlayer.BackColor = Global.JohnOS10.My.MySettings.Default.notifBarColor
        Me.miniPlayer.BackgroundImage = CType(resources.GetObject("miniPlayer.BackgroundImage"), System.Drawing.Image)
        Me.miniPlayer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.miniPlayer.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.JohnOS10.My.MySettings.Default, "notifBarColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.miniPlayer.Dock = System.Windows.Forms.DockStyle.Left
        Me.miniPlayer.ErrorImage = Nothing
        Me.miniPlayer.InitialImage = Nothing
        Me.miniPlayer.Location = New System.Drawing.Point(24, 0)
        Me.miniPlayer.Name = "miniPlayer"
        Me.miniPlayer.Size = New System.Drawing.Size(24, 30)
        Me.miniPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.miniPlayer.TabIndex = 15
        Me.miniPlayer.TabStop = False
        Me.miniPlayer.Visible = False
        '
        'radioMiniPlayer
        '
        Me.radioMiniPlayer.BackColor = Global.JohnOS10.My.MySettings.Default.notifBarColor
        Me.radioMiniPlayer.BackgroundImage = CType(resources.GetObject("radioMiniPlayer.BackgroundImage"), System.Drawing.Image)
        Me.radioMiniPlayer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.radioMiniPlayer.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.JohnOS10.My.MySettings.Default, "notifBarColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.radioMiniPlayer.Dock = System.Windows.Forms.DockStyle.Left
        Me.radioMiniPlayer.ErrorImage = Nothing
        Me.radioMiniPlayer.InitialImage = Nothing
        Me.radioMiniPlayer.Location = New System.Drawing.Point(0, 0)
        Me.radioMiniPlayer.Name = "radioMiniPlayer"
        Me.radioMiniPlayer.Size = New System.Drawing.Size(24, 30)
        Me.radioMiniPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.radioMiniPlayer.TabIndex = 14
        Me.radioMiniPlayer.TabStop = False
        Me.radioMiniPlayer.Visible = False
        '
        'startButtonIcon
        '
        Me.startButtonIcon.BackColor = Global.JohnOS10.My.MySettings.Default.startButtonColor
        Me.startButtonIcon.BackgroundImage = CType(resources.GetObject("startButtonIcon.BackgroundImage"), System.Drawing.Image)
        Me.startButtonIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.startButtonIcon.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.JohnOS10.My.MySettings.Default, "startButtonColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.startButtonIcon.InitialImage = Nothing
        Me.startButtonIcon.Location = New System.Drawing.Point(4, 2)
        Me.startButtonIcon.Name = "startButtonIcon"
        Me.startButtonIcon.Size = New System.Drawing.Size(28, 26)
        Me.startButtonIcon.TabIndex = 11
        Me.startButtonIcon.TabStop = False
        '
        'startbutton
        '
        Me.startbutton.BackColor = Global.JohnOS10.My.MySettings.Default.startButtonColor
        Me.startbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.startbutton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.startbutton.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.JohnOS10.My.MySettings.Default, "startButtonColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.startbutton.DataBindings.Add(New System.Windows.Forms.Binding("ForeColor", Global.JohnOS10.My.MySettings.Default, "startButtonTextColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.startbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.startbutton.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.startbutton.ForeColor = Global.JohnOS10.My.MySettings.Default.startButtonTextColor
        Me.startbutton.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.startbutton.Location = New System.Drawing.Point(0, 0)
        Me.startbutton.Margin = New System.Windows.Forms.Padding(1)
        Me.startbutton.MinimumSize = New System.Drawing.Size(78, 30)
        Me.startbutton.Name = "startbutton"
        Me.startbutton.Size = New System.Drawing.Size(86, 30)
        Me.startbutton.TabIndex = 0
        Me.startbutton.Text = "start"
        Me.startbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.startbutton.UseVisualStyleBackColor = False
        '
        'Desktop
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.BackgroundImage = Global.JohnOS10.My.Resources.Resources.default_wall
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 600)
        Me.Controls.Add(Me.computerLabel)
        Me.Controls.Add(Me.ComputerIcon)
        Me.Controls.Add(Me.taskbar)
        Me.Controls.Add(Me.JohnOSDesktoplogo)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.notepadLabel)
        Me.Controls.Add(Me.Notepad_Icon)
        Me.Controls.Add(Me.IE_Icon)
        Me.Controls.Add(Me.browserLabel)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Desktop"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "JohnOS 10"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.JohnOSDesktoplogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Notepad_Icon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IE_Icon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComputerIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.taskbar.ResumeLayout(False)
        Me.taskbar.PerformLayout()
        Me.rightBar.ResumeLayout(False)
        CType(Me.networkIcon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.miniPlayer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.radioMiniPlayer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.startButtonIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents taskbar As System.Windows.Forms.Panel
    Friend WithEvents JohnOSDesktoplogo As System.Windows.Forms.PictureBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents notepadLabel As System.Windows.Forms.Label
    Friend WithEvents Notepad_Icon As System.Windows.Forms.PictureBox
    Friend WithEvents IE_Icon As System.Windows.Forms.PictureBox
    Friend WithEvents browserLabel As System.Windows.Forms.Label
    Friend WithEvents ComputerIcon As System.Windows.Forms.PictureBox
    Friend WithEvents computerLabel As System.Windows.Forms.Label
    Friend WithEvents startbutton As System.Windows.Forms.Button
    Friend WithEvents startButtonIcon As System.Windows.Forms.PictureBox
    Friend WithEvents taskbarClockLabel As Label
    Friend WithEvents taskbarClockTimer As Timer
    Friend WithEvents networkIcon As PictureBox
    Friend WithEvents refreshJIS As Timer
    Friend WithEvents rightBar As Panel
    Friend WithEvents miniPlayer As PictureBox
    Friend WithEvents radioMiniPlayer As PictureBox
End Class
