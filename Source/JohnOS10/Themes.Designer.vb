<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Themes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Themes))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.saveButton = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.samplePanel = New System.Windows.Forms.Panel()
        Me.startButtonIcon = New System.Windows.Forms.PictureBox()
        Me.sampleStartButton = New System.Windows.Forms.Button()
        Me.sampleNotifBar = New System.Windows.Forms.PictureBox()
        Me.sampleTaskbar = New System.Windows.Forms.Panel()
        Me.sampleTitleBar = New System.Windows.Forms.Panel()
        Me.sampleTitleBarText = New System.Windows.Forms.Label()
        Me.sampleMinButton = New System.Windows.Forms.Button()
        Me.sampleXButton = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.titleBar = New System.Windows.Forms.Panel()
        Me.minButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.closeButton = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.samplePanel.SuspendLayout()
        CType(Me.startButtonIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sampleNotifBar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.sampleTitleBar.SuspendLayout()
        Me.titleBar.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = Global.JohnOS10.My.MySettings.Default.backColor
        Me.Panel1.Controls.Add(Me.saveButton)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.ComboBox1)
        Me.Panel1.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.JohnOS10.My.MySettings.Default, "backColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Panel1.Location = New System.Drawing.Point(2, 25)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(360, 275)
        Me.Panel1.TabIndex = 38
        '
        'saveButton
        '
        Me.saveButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.saveButton.Location = New System.Drawing.Point(269, 5)
        Me.saveButton.Name = "saveButton"
        Me.saveButton.Size = New System.Drawing.Size(81, 25)
        Me.saveButton.TabIndex = 8
        Me.saveButton.Text = "Save"
        Me.saveButton.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Panel3.Controls.Add(Me.samplePanel)
        Me.Panel3.Controls.Add(Me.sampleTitleBar)
        Me.Panel3.Location = New System.Drawing.Point(9, 38)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(340, 226)
        Me.Panel3.TabIndex = 7
        '
        'samplePanel
        '
        Me.samplePanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.samplePanel.Controls.Add(Me.startButtonIcon)
        Me.samplePanel.Controls.Add(Me.sampleStartButton)
        Me.samplePanel.Controls.Add(Me.sampleNotifBar)
        Me.samplePanel.Controls.Add(Me.sampleTaskbar)
        Me.samplePanel.Location = New System.Drawing.Point(3, 28)
        Me.samplePanel.Name = "samplePanel"
        Me.samplePanel.Size = New System.Drawing.Size(334, 195)
        Me.samplePanel.TabIndex = 12
        '
        'startButtonIcon
        '
        Me.startButtonIcon.BackColor = System.Drawing.Color.Green
        Me.startButtonIcon.BackgroundImage = CType(resources.GetObject("startButtonIcon.BackgroundImage"), System.Drawing.Image)
        Me.startButtonIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.startButtonIcon.InitialImage = Nothing
        Me.startButtonIcon.Location = New System.Drawing.Point(4, 167)
        Me.startButtonIcon.Name = "startButtonIcon"
        Me.startButtonIcon.Size = New System.Drawing.Size(28, 26)
        Me.startButtonIcon.TabIndex = 43
        Me.startButtonIcon.TabStop = False
        '
        'sampleStartButton
        '
        Me.sampleStartButton.BackColor = System.Drawing.Color.Green
        Me.sampleStartButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.sampleStartButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.sampleStartButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.sampleStartButton.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sampleStartButton.ForeColor = System.Drawing.Color.White
        Me.sampleStartButton.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.sampleStartButton.Location = New System.Drawing.Point(0, 165)
        Me.sampleStartButton.Margin = New System.Windows.Forms.Padding(1)
        Me.sampleStartButton.MinimumSize = New System.Drawing.Size(78, 30)
        Me.sampleStartButton.Name = "sampleStartButton"
        Me.sampleStartButton.Size = New System.Drawing.Size(86, 30)
        Me.sampleStartButton.TabIndex = 42
        Me.sampleStartButton.Text = "start"
        Me.sampleStartButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.sampleStartButton.UseVisualStyleBackColor = False
        '
        'sampleNotifBar
        '
        Me.sampleNotifBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.sampleNotifBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.sampleNotifBar.InitialImage = Nothing
        Me.sampleNotifBar.Location = New System.Drawing.Point(264, 165)
        Me.sampleNotifBar.Name = "sampleNotifBar"
        Me.sampleNotifBar.Size = New System.Drawing.Size(70, 30)
        Me.sampleNotifBar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.sampleNotifBar.TabIndex = 41
        Me.sampleNotifBar.TabStop = False
        '
        'sampleTaskbar
        '
        Me.sampleTaskbar.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.sampleTaskbar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.sampleTaskbar.Location = New System.Drawing.Point(67, 165)
        Me.sampleTaskbar.Name = "sampleTaskbar"
        Me.sampleTaskbar.Size = New System.Drawing.Size(225, 30)
        Me.sampleTaskbar.TabIndex = 12
        '
        'sampleTitleBar
        '
        Me.sampleTitleBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.sampleTitleBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.sampleTitleBar.Controls.Add(Me.sampleTitleBarText)
        Me.sampleTitleBar.Controls.Add(Me.sampleMinButton)
        Me.sampleTitleBar.Controls.Add(Me.sampleXButton)
        Me.sampleTitleBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.sampleTitleBar.Location = New System.Drawing.Point(0, 0)
        Me.sampleTitleBar.Name = "sampleTitleBar"
        Me.sampleTitleBar.Size = New System.Drawing.Size(340, 29)
        Me.sampleTitleBar.TabIndex = 11
        '
        'sampleTitleBarText
        '
        Me.sampleTitleBarText.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.sampleTitleBarText.AutoSize = True
        Me.sampleTitleBarText.BackColor = System.Drawing.Color.Transparent
        Me.sampleTitleBarText.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold)
        Me.sampleTitleBarText.ForeColor = System.Drawing.Color.White
        Me.sampleTitleBarText.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.sampleTitleBarText.Location = New System.Drawing.Point(3, 3)
        Me.sampleTitleBarText.Name = "sampleTitleBarText"
        Me.sampleTitleBarText.Size = New System.Drawing.Size(60, 20)
        Me.sampleTitleBarText.TabIndex = 4
        Me.sampleTitleBarText.Text = "Sample"
        '
        'sampleMinButton
        '
        Me.sampleMinButton.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.sampleMinButton.BackColor = System.Drawing.Color.DodgerBlue
        Me.sampleMinButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.sampleMinButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.sampleMinButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.sampleMinButton.ForeColor = System.Drawing.Color.White
        Me.sampleMinButton.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.sampleMinButton.Location = New System.Drawing.Point(287, 3)
        Me.sampleMinButton.Name = "sampleMinButton"
        Me.sampleMinButton.Size = New System.Drawing.Size(22, 22)
        Me.sampleMinButton.TabIndex = 99
        Me.sampleMinButton.TabStop = False
        Me.sampleMinButton.Text = "-"
        Me.sampleMinButton.UseVisualStyleBackColor = False
        '
        'sampleXButton
        '
        Me.sampleXButton.BackColor = System.Drawing.Color.IndianRed
        Me.sampleXButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.sampleXButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.sampleXButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.sampleXButton.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sampleXButton.ForeColor = System.Drawing.Color.Transparent
        Me.sampleXButton.Location = New System.Drawing.Point(314, 3)
        Me.sampleXButton.Name = "sampleXButton"
        Me.sampleXButton.Size = New System.Drawing.Size(22, 22)
        Me.sampleXButton.TabIndex = 99
        Me.sampleXButton.TabStop = False
        Me.sampleXButton.Text = "x"
        Me.sampleXButton.UseVisualStyleBackColor = False
        '
        'ComboBox1
        '
        Me.ComboBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Luna", "Classic", "Olive Green", "Royale Noir", "Royale", "Zune", "Embedded", "Tropical", "MSOE Raiders"})
        Me.ComboBox1.Location = New System.Drawing.Point(9, 6)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(254, 23)
        Me.ComboBox1.TabIndex = 6
        Me.ComboBox1.Text = "Select a Theme"
        '
        'titleBar
        '
        Me.titleBar.BackColor = Global.JohnOS10.My.MySettings.Default.titleBarColor
        Me.titleBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.titleBar.Controls.Add(Me.minButton)
        Me.titleBar.Controls.Add(Me.Label1)
        Me.titleBar.Controls.Add(Me.closeButton)
        Me.titleBar.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.JohnOS10.My.MySettings.Default, "titleBarColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.titleBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.titleBar.Location = New System.Drawing.Point(0, 0)
        Me.titleBar.Name = "titleBar"
        Me.titleBar.Size = New System.Drawing.Size(364, 26)
        Me.titleBar.TabIndex = 36
        '
        'minButton
        '
        Me.minButton.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.minButton.BackColor = Global.JohnOS10.My.MySettings.Default.minButtonColor
        Me.minButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.minButton.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.JohnOS10.My.MySettings.Default, "minButtonColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.minButton.DataBindings.Add(New System.Windows.Forms.Binding("ForeColor", Global.JohnOS10.My.MySettings.Default, "startButtonTextColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.minButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.minButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.minButton.ForeColor = Global.JohnOS10.My.MySettings.Default.startButtonTextColor
        Me.minButton.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.minButton.Location = New System.Drawing.Point(313, 2)
        Me.minButton.Name = "minButton"
        Me.minButton.Size = New System.Drawing.Size(22, 22)
        Me.minButton.TabIndex = 2
        Me.minButton.Text = "-"
        Me.minButton.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(3, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Themes"
        '
        'closeButton
        '
        Me.closeButton.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.closeButton.BackColor = Global.JohnOS10.My.MySettings.Default.xButtonColor
        Me.closeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.closeButton.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.JohnOS10.My.MySettings.Default, "xButtonColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.closeButton.DataBindings.Add(New System.Windows.Forms.Binding("ForeColor", Global.JohnOS10.My.MySettings.Default, "startButtonTextColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.closeButton.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.closeButton.ForeColor = Global.JohnOS10.My.MySettings.Default.startButtonTextColor
        Me.closeButton.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.closeButton.Location = New System.Drawing.Point(339, 2)
        Me.closeButton.Name = "closeButton"
        Me.closeButton.Size = New System.Drawing.Size(22, 22)
        Me.closeButton.TabIndex = 0
        Me.closeButton.Text = "x"
        Me.closeButton.UseVisualStyleBackColor = False
        '
        'Themes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = Global.JohnOS10.My.MySettings.Default.titleBarColor
        Me.ClientSize = New System.Drawing.Size(364, 303)
        Me.Controls.Add(Me.titleBar)
        Me.Controls.Add(Me.Panel1)
        Me.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.JohnOS10.My.MySettings.Default, "titleBarColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Themes"
        Me.Text = "Themes"
        Me.TopMost = True
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.samplePanel.ResumeLayout(False)
        CType(Me.startButtonIcon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sampleNotifBar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.sampleTitleBar.ResumeLayout(False)
        Me.sampleTitleBar.PerformLayout()
        Me.titleBar.ResumeLayout(False)
        Me.titleBar.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents closeButton As Button
    Friend WithEvents titleBar As Panel
    Friend WithEvents minButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents saveButton As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents samplePanel As Panel
    Friend WithEvents sampleNotifBar As PictureBox
    Friend WithEvents sampleTaskbar As Panel
    Friend WithEvents sampleTitleBar As Panel
    Friend WithEvents sampleXButton As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents sampleMinButton As Button
    Friend WithEvents sampleTitleBarText As Label
    Friend WithEvents startButtonIcon As PictureBox
    Friend WithEvents sampleStartButton As Button
End Class
