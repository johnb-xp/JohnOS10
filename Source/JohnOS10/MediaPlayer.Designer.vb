<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MediaPlayer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MediaPlayer))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TrackBar1 = New System.Windows.Forms.TrackBar()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.AxWindowsMediaPlayer1 = New AxWMPLib.AxWindowsMediaPlayer()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(725, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(35, 35)
        Me.PictureBox1.TabIndex = 21
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.DataBindings.Add(New System.Windows.Forms.Binding("ForeColor", Global.JohnOS10.My.MySettings.Default, "titleBarTextColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = Global.JohnOS10.My.MySettings.Default.titleBarTextColor
        Me.Label1.Location = New System.Drawing.Point(6, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(158, 20)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "JohnOS Media Player"
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = Global.JohnOS10.My.MySettings.Default.xButtonColor
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.JohnOS10.My.MySettings.Default, "xButtonColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Button1.DataBindings.Add(New System.Windows.Forms.Binding("ForeColor", Global.JohnOS10.My.MySettings.Default, "startButtonTextColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.Button1.ForeColor = Global.JohnOS10.My.MySettings.Default.startButtonTextColor
        Me.Button1.Location = New System.Drawing.Point(739, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(22, 22)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "x"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = Global.JohnOS10.My.MySettings.Default.titleBarColor
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.Button9)
        Me.Panel1.Controls.Add(Me.Button8)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.JohnOS10.My.MySettings.Default, "titleBarColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(762, 26)
        Me.Panel1.TabIndex = 9
        '
        'Button9
        '
        Me.Button9.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button9.BackColor = Global.JohnOS10.My.MySettings.Default.minButtonColor
        Me.Button9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button9.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.JohnOS10.My.MySettings.Default, "minButtonColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Button9.DataBindings.Add(New System.Windows.Forms.Binding("ForeColor", Global.JohnOS10.My.MySettings.Default, "startButtonTextColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button9.ForeColor = Global.JohnOS10.My.MySettings.Default.startButtonTextColor
        Me.Button9.Location = New System.Drawing.Point(713, 2)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(21, 22)
        Me.Button9.TabIndex = 7
        Me.Button9.Text = "🗗"
        Me.Button9.UseVisualStyleBackColor = False
        '
        'Button8
        '
        Me.Button8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button8.BackColor = Global.JohnOS10.My.MySettings.Default.minButtonColor
        Me.Button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button8.DataBindings.Add(New System.Windows.Forms.Binding("ForeColor", Global.JohnOS10.My.MySettings.Default, "startButtonTextColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Button8.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.JohnOS10.My.MySettings.Default, "minButtonColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.ForeColor = Global.JohnOS10.My.MySettings.Default.startButtonTextColor
        Me.Button8.Location = New System.Drawing.Point(687, 2)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(21, 22)
        Me.Button8.TabIndex = 8
        Me.Button8.Text = "-"
        Me.Button8.UseVisualStyleBackColor = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.Filter = "All files (*.*)|*.*"
        Me.OpenFileDialog1.InitialDirectory = "C:/"
        Me.OpenFileDialog1.Title = "Choose a media file to open"
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button2.BackColor = Global.JohnOS10.My.MySettings.Default.titleBarColor
        Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.DataBindings.Add(New System.Windows.Forms.Binding("ForeColor", Global.JohnOS10.My.MySettings.Default, "titleBarColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Button2.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.JohnOS10.My.MySettings.Default, "titleBarColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.ForeColor = Global.JohnOS10.My.MySettings.Default.titleBarColor
        Me.Button2.Location = New System.Drawing.Point(3, 3)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(32, 32)
        Me.Button2.TabIndex = 1
        Me.Button2.UseVisualStyleBackColor = False
        '
        'TrackBar1
        '
        Me.TrackBar1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TrackBar1.BackColor = Global.JohnOS10.My.MySettings.Default.titleBarColor
        Me.TrackBar1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TrackBar1.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.JohnOS10.My.MySettings.Default, "titleBarColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.TrackBar1.Location = New System.Drawing.Point(503, 11)
        Me.TrackBar1.Maximum = 100
        Me.TrackBar1.Name = "TrackBar1"
        Me.TrackBar1.Size = New System.Drawing.Size(208, 45)
        Me.TrackBar1.TabIndex = 5
        Me.TrackBar1.TickStyle = System.Windows.Forms.TickStyle.None
        Me.TrackBar1.Value = 100
        '
        'Button3
        '
        Me.Button3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button3.BackColor = Global.JohnOS10.My.MySettings.Default.titleBarColor
        Me.Button3.BackgroundImage = CType(resources.GetObject("Button3.BackgroundImage"), System.Drawing.Image)
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.DataBindings.Add(New System.Windows.Forms.Binding("ForeColor", Global.JohnOS10.My.MySettings.Default, "titleBarColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Button3.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.JohnOS10.My.MySettings.Default, "titleBarColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.ForeColor = Global.JohnOS10.My.MySettings.Default.titleBarColor
        Me.Button3.Location = New System.Drawing.Point(39, 3)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(32, 32)
        Me.Button3.TabIndex = 2
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button4.BackColor = Global.JohnOS10.My.MySettings.Default.titleBarColor
        Me.Button4.BackgroundImage = CType(resources.GetObject("Button4.BackgroundImage"), System.Drawing.Image)
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button4.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.JohnOS10.My.MySettings.Default, "titleBarColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Button4.DataBindings.Add(New System.Windows.Forms.Binding("ForeColor", Global.JohnOS10.My.MySettings.Default, "titleBarColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.ForeColor = Global.JohnOS10.My.MySettings.Default.titleBarColor
        Me.Button4.Location = New System.Drawing.Point(76, 3)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(32, 32)
        Me.Button4.TabIndex = 3
        Me.Button4.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(471, 3)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox2.TabIndex = 33
        Me.PictureBox2.TabStop = False
        '
        'Button5
        '
        Me.Button5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button5.BackColor = Global.JohnOS10.My.MySettings.Default.titleBarColor
        Me.Button5.BackgroundImage = CType(resources.GetObject("Button5.BackgroundImage"), System.Drawing.Image)
        Me.Button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button5.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.JohnOS10.My.MySettings.Default, "titleBarColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Button5.DataBindings.Add(New System.Windows.Forms.Binding("ForeColor", Global.JohnOS10.My.MySettings.Default, "titleBarColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.ForeColor = Global.JohnOS10.My.MySettings.Default.titleBarColor
        Me.Button5.Location = New System.Drawing.Point(111, 3)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(32, 32)
        Me.Button5.TabIndex = 4
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = Global.JohnOS10.My.MySettings.Default.titleBarColor
        Me.Panel2.Controls.Add(Me.Button2)
        Me.Panel2.Controls.Add(Me.PictureBox2)
        Me.Panel2.Controls.Add(Me.Button5)
        Me.Panel2.Controls.Add(Me.TrackBar1)
        Me.Panel2.Controls.Add(Me.Button3)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.Button4)
        Me.Panel2.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.JohnOS10.My.MySettings.Default, "titleBarColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 489)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(762, 38)
        Me.Panel2.TabIndex = 34
        '
        'AxWindowsMediaPlayer1
        '
        Me.AxWindowsMediaPlayer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AxWindowsMediaPlayer1.Enabled = True
        Me.AxWindowsMediaPlayer1.Location = New System.Drawing.Point(0, 26)
        Me.AxWindowsMediaPlayer1.Name = "AxWindowsMediaPlayer1"
        Me.AxWindowsMediaPlayer1.OcxState = CType(resources.GetObject("AxWindowsMediaPlayer1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxWindowsMediaPlayer1.Size = New System.Drawing.Size(762, 463)
        Me.AxWindowsMediaPlayer1.TabIndex = 34
        Me.AxWindowsMediaPlayer1.TabStop = False
        '
        'MediaPlayer
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(762, 527)
        Me.Controls.Add(Me.AxWindowsMediaPlayer1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.ForeColor = System.Drawing.Color.Transparent
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MediaPlayer"
        Me.Text = "JohnOS Media Player"
        Me.TopMost = True
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents TrackBar1 As System.Windows.Forms.TrackBar
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents AxWindowsMediaPlayer1 As AxWindowsMediaPlayer
End Class
