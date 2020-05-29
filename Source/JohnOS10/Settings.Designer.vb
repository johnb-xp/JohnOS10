<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Settings
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
        Dim ListViewItem1 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("About JohnOS", 1)
        Dim ListViewItem2 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Clock", 4)
        Dim ListViewItem3 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Display Settings", 5)
        Dim ListViewItem4 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("JohnOS Update", 0)
        Dim ListViewItem5 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Network Diagnostic", 2)
        Dim ListViewItem6 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Reset Settings", 7)
        Dim ListViewItem7 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Themes", 6)
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Settings))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pbRAM = New System.Windows.Forms.ProgressBar()
        Me.pbCPU = New System.Windows.Forms.ProgressBar()
        Me.lblRAM = New System.Windows.Forms.Label()
        Me.lblCPU = New System.Windows.Forms.Label()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.SettingsIcons = New System.Windows.Forms.ImageList(Me.components)
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pcCPU = New System.Diagnostics.PerformanceCounter()
        Me.pcRAM = New System.Diagnostics.PerformanceCounter()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.pcCPU, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcRAM, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = Global.JohnOS10.My.MySettings.Default.xButtonColor
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.JohnOS10.My.MySettings.Default, "xButtonColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Button1.DataBindings.Add(New System.Windows.Forms.Binding("ForeColor", Global.JohnOS10.My.MySettings.Default, "startButtonTextColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = Global.JohnOS10.My.MySettings.Default.startButtonTextColor
        Me.Button1.Location = New System.Drawing.Point(541, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(21, 22)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "x"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = Global.JohnOS10.My.MySettings.Default.backColor
        Me.Panel1.Controls.Add(Me.pbRAM)
        Me.Panel1.Controls.Add(Me.pbCPU)
        Me.Panel1.Controls.Add(Me.lblRAM)
        Me.Panel1.Controls.Add(Me.lblCPU)
        Me.Panel1.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.JohnOS10.My.MySettings.Default, "backColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Panel1.Location = New System.Drawing.Point(3, 246)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(560, 41)
        Me.Panel1.TabIndex = 13
        '
        'pbRAM
        '
        Me.pbRAM.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pbRAM.Location = New System.Drawing.Point(384, 9)
        Me.pbRAM.Name = "pbRAM"
        Me.pbRAM.Size = New System.Drawing.Size(169, 23)
        Me.pbRAM.TabIndex = 12
        '
        'pbCPU
        '
        Me.pbCPU.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.pbCPU.Location = New System.Drawing.Point(67, 9)
        Me.pbCPU.Name = "pbCPU"
        Me.pbCPU.Size = New System.Drawing.Size(169, 23)
        Me.pbCPU.TabIndex = 11
        '
        'lblRAM
        '
        Me.lblRAM.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblRAM.AutoSize = True
        Me.lblRAM.Location = New System.Drawing.Point(321, 12)
        Me.lblRAM.Name = "lblRAM"
        Me.lblRAM.Size = New System.Drawing.Size(31, 13)
        Me.lblRAM.TabIndex = 10
        Me.lblRAM.Text = "RAM"
        '
        'lblCPU
        '
        Me.lblCPU.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblCPU.AutoSize = True
        Me.lblCPU.Location = New System.Drawing.Point(7, 12)
        Me.lblCPU.Name = "lblCPU"
        Me.lblCPU.Size = New System.Drawing.Size(29, 13)
        Me.lblCPU.TabIndex = 9
        Me.lblCPU.Text = "CPU"
        '
        'ListView1
        '
        Me.ListView1.Alignment = System.Windows.Forms.ListViewAlignment.SnapToGrid
        Me.ListView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListView1.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.ListView1.HideSelection = False
        Me.ListView1.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem1, ListViewItem2, ListViewItem3, ListViewItem4, ListViewItem5, ListViewItem6, ListViewItem7})
        Me.ListView1.LargeImageList = Me.SettingsIcons
        Me.ListView1.Location = New System.Drawing.Point(2, 26)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(562, 223)
        Me.ListView1.SmallImageList = Me.SettingsIcons
        Me.ListView1.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.ListView1.TabIndex = 32
        Me.ListView1.TileSize = New System.Drawing.Size(48, 48)
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'SettingsIcons
        '
        Me.SettingsIcons.ImageStream = CType(resources.GetObject("SettingsIcons.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.SettingsIcons.TransparentColor = System.Drawing.Color.Transparent
        Me.SettingsIcons.Images.SetKeyName(0, "shield.png")
        Me.SettingsIcons.Images.SetKeyName(1, "sign-question.png")
        Me.SettingsIcons.Images.SetKeyName(2, "josconnect2.png")
        Me.SettingsIcons.Images.SetKeyName(3, "window-layout.png")
        Me.SettingsIcons.Images.SetKeyName(4, "clock.png")
        Me.SettingsIcons.Images.SetKeyName(5, "device-computer.png")
        Me.SettingsIcons.Images.SetKeyName(6, "layers.png")
        Me.SettingsIcons.Images.SetKeyName(7, "life-buoy.png")
        '
        'Panel2
        '
        Me.Panel2.BackColor = Global.JohnOS10.My.MySettings.Default.titleBarColor
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.Controls.Add(Me.Button9)
        Me.Panel2.Controls.Add(Me.Button3)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.JohnOS10.My.MySettings.Default, "titleBarColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(566, 26)
        Me.Panel2.TabIndex = 14
        '
        'Button9
        '
        Me.Button9.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Button9.BackColor = Global.JohnOS10.My.MySettings.Default.minButtonColor
        Me.Button9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button9.DataBindings.Add(New System.Windows.Forms.Binding("ForeColor", Global.JohnOS10.My.MySettings.Default, "startButtonTextColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Button9.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.JohnOS10.My.MySettings.Default, "minButtonColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button9.ForeColor = Global.JohnOS10.My.MySettings.Default.startButtonTextColor
        Me.Button9.Location = New System.Drawing.Point(515, 2)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(21, 22)
        Me.Button9.TabIndex = 1
        Me.Button9.Text = "🗗"
        Me.Button9.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button3.BackColor = Global.JohnOS10.My.MySettings.Default.minButtonColor
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.JohnOS10.My.MySettings.Default, "minButtonColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Button3.DataBindings.Add(New System.Windows.Forms.Binding("ForeColor", Global.JohnOS10.My.MySettings.Default, "startButtonTextColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = Global.JohnOS10.My.MySettings.Default.startButtonTextColor
        Me.Button3.Location = New System.Drawing.Point(489, 2)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(21, 22)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "-"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.DataBindings.Add(New System.Windows.Forms.Binding("ForeColor", Global.JohnOS10.My.MySettings.Default, "titleBarTextColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = Global.JohnOS10.My.MySettings.Default.titleBarTextColor
        Me.Label1.Location = New System.Drawing.Point(3, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Control Panel"
        '
        'pcCPU
        '
        Me.pcCPU.CategoryName = "Processor"
        Me.pcCPU.CounterName = "% Processor Time"
        Me.pcCPU.InstanceName = "_Total"
        '
        'pcRAM
        '
        Me.pcRAM.CategoryName = "Memory"
        Me.pcRAM.CounterName = "% Committed Bytes In Use"
        '
        'Timer1
        '
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.Filter = "Image Files (*.bmp;*.jpg;*.jpeg,*.png)|*.BMP;*.JPG;*.JPEG;*.PNG"
        Me.OpenFileDialog1.Title = "Choose an Image"
        '
        'Settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = Global.JohnOS10.My.MySettings.Default.titleBarColor
        Me.ClientSize = New System.Drawing.Size(566, 290)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.Panel2)
        Me.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.JohnOS10.My.MySettings.Default, "titleBarColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Settings"
        Me.Text = "Control Panel"
        Me.TopMost = True
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.pcCPU, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcRAM, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button3 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents pbRAM As ProgressBar
    Friend WithEvents pbCPU As ProgressBar
    Friend WithEvents lblRAM As Label
    Friend WithEvents lblCPU As Label
    Friend WithEvents pcCPU As PerformanceCounter
    Friend WithEvents pcRAM As PerformanceCounter
    Friend WithEvents Timer1 As Timer
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Button9 As Button
    Friend WithEvents ListView1 As ListView
    Friend WithEvents SettingsIcons As ImageList
End Class
