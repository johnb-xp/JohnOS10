<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StartMenu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StartMenu))
        Me.launcherIcon = New System.Windows.Forms.PictureBox()
        Me.launcherButton = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.exitButton = New System.Windows.Forms.PictureBox()
        Me.shutdownButton = New System.Windows.Forms.PictureBox()
        Me.allProgramsIcon = New System.Windows.Forms.PictureBox()
        Me.settingsIcon = New System.Windows.Forms.PictureBox()
        Me.notepadIcon = New System.Windows.Forms.PictureBox()
        Me.browserIcon = New System.Windows.Forms.PictureBox()
        Me.closeMenuIcon = New System.Windows.Forms.PictureBox()
        Me.settingsButton = New System.Windows.Forms.Button()
        Me.allProgramsButton = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.notepadButton = New System.Windows.Forms.Button()
        Me.browserButton = New System.Windows.Forms.Button()
        Me.closeMenuButton = New System.Windows.Forms.Button()
        CType(Me.launcherIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.exitButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.shutdownButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.allProgramsIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.settingsIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.notepadIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.browserIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.closeMenuIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'launcherIcon
        '
        Me.launcherIcon.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.launcherIcon.BackColor = System.Drawing.Color.Transparent
        Me.launcherIcon.BackgroundImage = CType(resources.GetObject("launcherIcon.BackgroundImage"), System.Drawing.Image)
        Me.launcherIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.launcherIcon.Location = New System.Drawing.Point(163, 216)
        Me.launcherIcon.Name = "launcherIcon"
        Me.launcherIcon.Size = New System.Drawing.Size(32, 32)
        Me.launcherIcon.TabIndex = 24
        Me.launcherIcon.TabStop = False
        '
        'launcherButton
        '
        Me.launcherButton.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.launcherButton.BackColor = Global.JohnOS10.My.MySettings.Default.backColor
        Me.launcherButton.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.JohnOS10.My.MySettings.Default, "backColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.launcherButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.launcherButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.launcherButton.Location = New System.Drawing.Point(4, 212)
        Me.launcherButton.Name = "launcherButton"
        Me.launcherButton.Size = New System.Drawing.Size(195, 40)
        Me.launcherButton.TabIndex = 5
        Me.launcherButton.Text = "Launcher"
        Me.launcherButton.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = Global.JohnOS10.My.MySettings.Default.titleBarColor
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.JohnOS10.My.MySettings.Default, "titleBarColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(204, 42)
        Me.Panel3.TabIndex = 22
        '
        'Label1
        '
        Me.Label1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = Global.JohnOS10.My.MySettings.Default.titleBarColor
        Me.Label1.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.JohnOS10.My.MySettings.Default, "titleBarColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Label1.DataBindings.Add(New System.Windows.Forms.Binding("ForeColor", Global.JohnOS10.My.MySettings.Default, "titleBarTextColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = Global.JohnOS10.My.MySettings.Default.titleBarTextColor
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(196, 43)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "JohnOS 10"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'exitButton
        '
        Me.exitButton.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.exitButton.BackColor = System.Drawing.Color.White
        Me.exitButton.BackgroundImage = CType(resources.GetObject("exitButton.BackgroundImage"), System.Drawing.Image)
        Me.exitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.exitButton.Location = New System.Drawing.Point(130, 301)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(32, 31)
        Me.exitButton.TabIndex = 15
        Me.exitButton.TabStop = False
        '
        'shutdownButton
        '
        Me.shutdownButton.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.shutdownButton.BackColor = System.Drawing.Color.Red
        Me.shutdownButton.BackgroundImage = CType(resources.GetObject("shutdownButton.BackgroundImage"), System.Drawing.Image)
        Me.shutdownButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.shutdownButton.Location = New System.Drawing.Point(166, 301)
        Me.shutdownButton.Name = "shutdownButton"
        Me.shutdownButton.Size = New System.Drawing.Size(31, 31)
        Me.shutdownButton.TabIndex = 14
        Me.shutdownButton.TabStop = False
        '
        'allProgramsIcon
        '
        Me.allProgramsIcon.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.allProgramsIcon.BackColor = System.Drawing.Color.Transparent
        Me.allProgramsIcon.BackgroundImage = CType(resources.GetObject("allProgramsIcon.BackgroundImage"), System.Drawing.Image)
        Me.allProgramsIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.allProgramsIcon.Location = New System.Drawing.Point(163, 258)
        Me.allProgramsIcon.Name = "allProgramsIcon"
        Me.allProgramsIcon.Size = New System.Drawing.Size(32, 32)
        Me.allProgramsIcon.TabIndex = 13
        Me.allProgramsIcon.TabStop = False
        '
        'settingsIcon
        '
        Me.settingsIcon.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.settingsIcon.BackColor = System.Drawing.Color.Transparent
        Me.settingsIcon.BackgroundImage = CType(resources.GetObject("settingsIcon.BackgroundImage"), System.Drawing.Image)
        Me.settingsIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.settingsIcon.Location = New System.Drawing.Point(8, 174)
        Me.settingsIcon.Name = "settingsIcon"
        Me.settingsIcon.Size = New System.Drawing.Size(32, 32)
        Me.settingsIcon.TabIndex = 12
        Me.settingsIcon.TabStop = False
        '
        'notepadIcon
        '
        Me.notepadIcon.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.notepadIcon.BackColor = System.Drawing.Color.Transparent
        Me.notepadIcon.BackgroundImage = CType(resources.GetObject("notepadIcon.BackgroundImage"), System.Drawing.Image)
        Me.notepadIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.notepadIcon.Location = New System.Drawing.Point(8, 132)
        Me.notepadIcon.Name = "notepadIcon"
        Me.notepadIcon.Size = New System.Drawing.Size(32, 32)
        Me.notepadIcon.TabIndex = 11
        Me.notepadIcon.TabStop = False
        '
        'browserIcon
        '
        Me.browserIcon.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.browserIcon.BackColor = System.Drawing.Color.Transparent
        Me.browserIcon.BackgroundImage = CType(resources.GetObject("browserIcon.BackgroundImage"), System.Drawing.Image)
        Me.browserIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.browserIcon.Location = New System.Drawing.Point(8, 90)
        Me.browserIcon.Name = "browserIcon"
        Me.browserIcon.Size = New System.Drawing.Size(32, 32)
        Me.browserIcon.TabIndex = 10
        Me.browserIcon.TabStop = False
        '
        'closeMenuIcon
        '
        Me.closeMenuIcon.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.closeMenuIcon.BackColor = System.Drawing.Color.Transparent
        Me.closeMenuIcon.BackgroundImage = CType(resources.GetObject("closeMenuIcon.BackgroundImage"), System.Drawing.Image)
        Me.closeMenuIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.closeMenuIcon.Location = New System.Drawing.Point(8, 50)
        Me.closeMenuIcon.Name = "closeMenuIcon"
        Me.closeMenuIcon.Size = New System.Drawing.Size(32, 32)
        Me.closeMenuIcon.TabIndex = 9
        Me.closeMenuIcon.TabStop = False
        '
        'settingsButton
        '
        Me.settingsButton.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.settingsButton.BackColor = Global.JohnOS10.My.MySettings.Default.backColor
        Me.settingsButton.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.JohnOS10.My.MySettings.Default, "backColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.settingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.settingsButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.settingsButton.Location = New System.Drawing.Point(4, 170)
        Me.settingsButton.Name = "settingsButton"
        Me.settingsButton.Size = New System.Drawing.Size(195, 40)
        Me.settingsButton.TabIndex = 4
        Me.settingsButton.Text = "Control Panel"
        Me.settingsButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.settingsButton.UseVisualStyleBackColor = False
        '
        'allProgramsButton
        '
        Me.allProgramsButton.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.allProgramsButton.BackColor = Global.JohnOS10.My.MySettings.Default.backColor
        Me.allProgramsButton.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.JohnOS10.My.MySettings.Default, "backColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.allProgramsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.allProgramsButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.allProgramsButton.Location = New System.Drawing.Point(4, 254)
        Me.allProgramsButton.Name = "allProgramsButton"
        Me.allProgramsButton.Size = New System.Drawing.Size(195, 40)
        Me.allProgramsButton.TabIndex = 6
        Me.allProgramsButton.Text = "All Programs"
        Me.allProgramsButton.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = Global.JohnOS10.My.MySettings.Default.backColor
        Me.Panel1.Controls.Add(Me.notepadIcon)
        Me.Panel1.Controls.Add(Me.notepadButton)
        Me.Panel1.Controls.Add(Me.browserIcon)
        Me.Panel1.Controls.Add(Me.browserButton)
        Me.Panel1.Controls.Add(Me.closeMenuIcon)
        Me.Panel1.Controls.Add(Me.closeMenuButton)
        Me.Panel1.Controls.Add(Me.launcherIcon)
        Me.Panel1.Controls.Add(Me.launcherButton)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.exitButton)
        Me.Panel1.Controls.Add(Me.shutdownButton)
        Me.Panel1.Controls.Add(Me.allProgramsIcon)
        Me.Panel1.Controls.Add(Me.settingsIcon)
        Me.Panel1.Controls.Add(Me.settingsButton)
        Me.Panel1.Controls.Add(Me.allProgramsButton)
        Me.Panel1.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.JohnOS10.My.MySettings.Default, "backColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(204, 336)
        Me.Panel1.TabIndex = 21
        '
        'notepadButton
        '
        Me.notepadButton.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.notepadButton.BackColor = Global.JohnOS10.My.MySettings.Default.backColor
        Me.notepadButton.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.JohnOS10.My.MySettings.Default, "backColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.notepadButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.notepadButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.notepadButton.Location = New System.Drawing.Point(4, 128)
        Me.notepadButton.Name = "notepadButton"
        Me.notepadButton.Size = New System.Drawing.Size(195, 40)
        Me.notepadButton.TabIndex = 3
        Me.notepadButton.Text = "Run"
        Me.notepadButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.notepadButton.UseVisualStyleBackColor = False
        '
        'browserButton
        '
        Me.browserButton.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.browserButton.BackColor = Global.JohnOS10.My.MySettings.Default.backColor
        Me.browserButton.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.JohnOS10.My.MySettings.Default, "backColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.browserButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.browserButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.browserButton.Location = New System.Drawing.Point(4, 86)
        Me.browserButton.Name = "browserButton"
        Me.browserButton.Size = New System.Drawing.Size(195, 40)
        Me.browserButton.TabIndex = 2
        Me.browserButton.Text = "JohnOS Browser"
        Me.browserButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.browserButton.UseVisualStyleBackColor = False
        '
        'closeMenuButton
        '
        Me.closeMenuButton.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.closeMenuButton.BackColor = Global.JohnOS10.My.MySettings.Default.backColor
        Me.closeMenuButton.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.JohnOS10.My.MySettings.Default, "backColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.closeMenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.closeMenuButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.closeMenuButton.Location = New System.Drawing.Point(4, 45)
        Me.closeMenuButton.Name = "closeMenuButton"
        Me.closeMenuButton.Size = New System.Drawing.Size(195, 39)
        Me.closeMenuButton.TabIndex = 1
        Me.closeMenuButton.Text = "Close Start Menu"
        Me.closeMenuButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.closeMenuButton.UseVisualStyleBackColor = False
        '
        'StartMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(204, 336)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "StartMenu"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Start Menu"
        Me.TopMost = True
        CType(Me.launcherIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.exitButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.shutdownButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.allProgramsIcon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.settingsIcon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.notepadIcon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.browserIcon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.closeMenuIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents launcherIcon As PictureBox
    Friend WithEvents launcherButton As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents exitButton As PictureBox
    Friend WithEvents shutdownButton As PictureBox
    Friend WithEvents allProgramsIcon As PictureBox
    Friend WithEvents settingsIcon As PictureBox
    Friend WithEvents notepadIcon As PictureBox
    Friend WithEvents browserIcon As PictureBox
    Friend WithEvents closeMenuIcon As PictureBox
    Friend WithEvents settingsButton As Button
    Friend WithEvents allProgramsButton As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents notepadButton As Button
    Friend WithEvents browserButton As Button
    Friend WithEvents closeMenuButton As Button
End Class
