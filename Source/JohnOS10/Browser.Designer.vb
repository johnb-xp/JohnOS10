<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Browser
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Browser))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.maxButton = New System.Windows.Forms.Button()
        Me.minButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.closeButton = New System.Windows.Forms.Button()
        Me.backButton = New System.Windows.Forms.Button()
        Me.urlBar = New System.Windows.Forms.TextBox()
        Me.goButton = New System.Windows.Forms.Button()
        Me.forwardButton = New System.Windows.Forms.Button()
        Me.refreshButton = New System.Windows.Forms.Button()
        Me.informationButton = New System.Windows.Forms.Button()
        Me.homeButton = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.searchButton = New System.Windows.Forms.Button()
        Me.WebView21 = New Microsoft.Web.WebView2.WinForms.WebView2()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.WebView21, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = Global.JohnOS10.My.MySettings.Default.titleBarColor
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.maxButton)
        Me.Panel1.Controls.Add(Me.minButton)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.closeButton)
        Me.Panel1.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.JohnOS10.My.MySettings.Default, "titleBarColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(800, 26)
        Me.Panel1.TabIndex = 0
        '
        'maxButton
        '
        Me.maxButton.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.maxButton.BackColor = Global.JohnOS10.My.MySettings.Default.minButtonColor
        Me.maxButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.maxButton.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.JohnOS10.My.MySettings.Default, "minButtonColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.maxButton.DataBindings.Add(New System.Windows.Forms.Binding("ForeColor", Global.JohnOS10.My.MySettings.Default, "startButtonTextColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.maxButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.maxButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.maxButton.ForeColor = Global.JohnOS10.My.MySettings.Default.startButtonTextColor
        Me.maxButton.Location = New System.Drawing.Point(750, 2)
        Me.maxButton.Name = "maxButton"
        Me.maxButton.Size = New System.Drawing.Size(21, 22)
        Me.maxButton.TabIndex = 9
        Me.maxButton.Text = "🗗"
        Me.maxButton.UseVisualStyleBackColor = False
        '
        'minButton
        '
        Me.minButton.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.minButton.BackColor = Global.JohnOS10.My.MySettings.Default.minButtonColor
        Me.minButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.minButton.DataBindings.Add(New System.Windows.Forms.Binding("ForeColor", Global.JohnOS10.My.MySettings.Default, "startButtonTextColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.minButton.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.JohnOS10.My.MySettings.Default, "minButtonColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.minButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.minButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.minButton.ForeColor = Global.JohnOS10.My.MySettings.Default.startButtonTextColor
        Me.minButton.Location = New System.Drawing.Point(725, 2)
        Me.minButton.Name = "minButton"
        Me.minButton.Size = New System.Drawing.Size(21, 22)
        Me.minButton.TabIndex = 8
        Me.minButton.Text = "-"
        Me.minButton.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(6, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(123, 20)
        Me.Label1.TabIndex = 100
        Me.Label1.Text = "JohnOS Browser"
        '
        'closeButton
        '
        Me.closeButton.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.closeButton.BackColor = Global.JohnOS10.My.MySettings.Default.xButtonColor
        Me.closeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.closeButton.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.JohnOS10.My.MySettings.Default, "xButtonColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.closeButton.DataBindings.Add(New System.Windows.Forms.Binding("ForeColor", Global.JohnOS10.My.MySettings.Default, "startButtonTextColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.closeButton.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.closeButton.ForeColor = Global.JohnOS10.My.MySettings.Default.startButtonTextColor
        Me.closeButton.Location = New System.Drawing.Point(776, 2)
        Me.closeButton.Name = "closeButton"
        Me.closeButton.Size = New System.Drawing.Size(20, 22)
        Me.closeButton.TabIndex = 10
        Me.closeButton.Text = "x"
        Me.closeButton.UseVisualStyleBackColor = False
        '
        'backButton
        '
        Me.backButton.BackColor = Global.JohnOS10.My.MySettings.Default.backColor
        Me.backButton.BackgroundImage = CType(resources.GetObject("backButton.BackgroundImage"), System.Drawing.Image)
        Me.backButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.backButton.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.JohnOS10.My.MySettings.Default, "backColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.backButton.DataBindings.Add(New System.Windows.Forms.Binding("ForeColor", Global.JohnOS10.My.MySettings.Default, "backColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.backButton.Font = New System.Drawing.Font("Webdings", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.backButton.ForeColor = Global.JohnOS10.My.MySettings.Default.backColor
        Me.backButton.Location = New System.Drawing.Point(3, 3)
        Me.backButton.Name = "backButton"
        Me.backButton.Size = New System.Drawing.Size(27, 27)
        Me.backButton.TabIndex = 1
        Me.backButton.UseVisualStyleBackColor = False
        '
        'urlBar
        '
        Me.urlBar.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.urlBar.Location = New System.Drawing.Point(172, 32)
        Me.urlBar.Name = "urlBar"
        Me.urlBar.Size = New System.Drawing.Size(555, 20)
        Me.urlBar.TabIndex = 0
        Me.urlBar.Text = "http://johnbilkey.com/johnos/"
        '
        'goButton
        '
        Me.goButton.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.goButton.BackColor = Global.JohnOS10.My.MySettings.Default.backColor
        Me.goButton.BackgroundImage = CType(resources.GetObject("goButton.BackgroundImage"), System.Drawing.Image)
        Me.goButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.goButton.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.JohnOS10.My.MySettings.Default, "backColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.goButton.DataBindings.Add(New System.Windows.Forms.Binding("ForeColor", Global.JohnOS10.My.MySettings.Default, "backColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.goButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.goButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.goButton.ForeColor = Global.JohnOS10.My.MySettings.Default.backColor
        Me.goButton.Location = New System.Drawing.Point(729, 2)
        Me.goButton.Name = "goButton"
        Me.goButton.Size = New System.Drawing.Size(27, 27)
        Me.goButton.TabIndex = 6
        Me.goButton.UseVisualStyleBackColor = False
        '
        'forwardButton
        '
        Me.forwardButton.BackColor = Global.JohnOS10.My.MySettings.Default.backColor
        Me.forwardButton.BackgroundImage = CType(resources.GetObject("forwardButton.BackgroundImage"), System.Drawing.Image)
        Me.forwardButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.forwardButton.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.JohnOS10.My.MySettings.Default, "backColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.forwardButton.DataBindings.Add(New System.Windows.Forms.Binding("ForeColor", Global.JohnOS10.My.MySettings.Default, "backColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.forwardButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.forwardButton.Font = New System.Drawing.Font("Webdings", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.forwardButton.ForeColor = Global.JohnOS10.My.MySettings.Default.backColor
        Me.forwardButton.Location = New System.Drawing.Point(36, 3)
        Me.forwardButton.Name = "forwardButton"
        Me.forwardButton.Size = New System.Drawing.Size(27, 27)
        Me.forwardButton.TabIndex = 2
        Me.forwardButton.UseVisualStyleBackColor = False
        '
        'refreshButton
        '
        Me.refreshButton.BackColor = Global.JohnOS10.My.MySettings.Default.backColor
        Me.refreshButton.BackgroundImage = CType(resources.GetObject("refreshButton.BackgroundImage"), System.Drawing.Image)
        Me.refreshButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.refreshButton.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.JohnOS10.My.MySettings.Default, "backColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.refreshButton.DataBindings.Add(New System.Windows.Forms.Binding("ForeColor", Global.JohnOS10.My.MySettings.Default, "backColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.refreshButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.refreshButton.Font = New System.Drawing.Font("Webdings", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.refreshButton.ForeColor = Global.JohnOS10.My.MySettings.Default.backColor
        Me.refreshButton.Location = New System.Drawing.Point(69, 3)
        Me.refreshButton.Name = "refreshButton"
        Me.refreshButton.Size = New System.Drawing.Size(27, 27)
        Me.refreshButton.TabIndex = 3
        Me.refreshButton.UseVisualStyleBackColor = False
        '
        'informationButton
        '
        Me.informationButton.BackColor = Global.JohnOS10.My.MySettings.Default.backColor
        Me.informationButton.BackgroundImage = CType(resources.GetObject("informationButton.BackgroundImage"), System.Drawing.Image)
        Me.informationButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.informationButton.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.JohnOS10.My.MySettings.Default, "backColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.informationButton.DataBindings.Add(New System.Windows.Forms.Binding("ForeColor", Global.JohnOS10.My.MySettings.Default, "backColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.informationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.informationButton.Font = New System.Drawing.Font("Webdings", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.informationButton.ForeColor = Global.JohnOS10.My.MySettings.Default.backColor
        Me.informationButton.Location = New System.Drawing.Point(138, 29)
        Me.informationButton.Name = "informationButton"
        Me.informationButton.Size = New System.Drawing.Size(27, 27)
        Me.informationButton.TabIndex = 5
        Me.informationButton.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.informationButton.UseVisualStyleBackColor = False
        '
        'homeButton
        '
        Me.homeButton.BackColor = Global.JohnOS10.My.MySettings.Default.backColor
        Me.homeButton.BackgroundImage = CType(resources.GetObject("homeButton.BackgroundImage"), System.Drawing.Image)
        Me.homeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.homeButton.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.JohnOS10.My.MySettings.Default, "backColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.homeButton.DataBindings.Add(New System.Windows.Forms.Binding("ForeColor", Global.JohnOS10.My.MySettings.Default, "backColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.homeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.homeButton.Font = New System.Drawing.Font("Webdings", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.homeButton.ForeColor = Global.JohnOS10.My.MySettings.Default.backColor
        Me.homeButton.Location = New System.Drawing.Point(105, 29)
        Me.homeButton.Name = "homeButton"
        Me.homeButton.Size = New System.Drawing.Size(27, 27)
        Me.homeButton.TabIndex = 4
        Me.homeButton.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = Global.JohnOS10.My.MySettings.Default.backColor
        Me.Panel2.Controls.Add(Me.searchButton)
        Me.Panel2.Controls.Add(Me.backButton)
        Me.Panel2.Controls.Add(Me.forwardButton)
        Me.Panel2.Controls.Add(Me.refreshButton)
        Me.Panel2.Controls.Add(Me.goButton)
        Me.Panel2.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.JohnOS10.My.MySettings.Default, "backColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Panel2.Location = New System.Drawing.Point(3, 26)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(793, 32)
        Me.Panel2.TabIndex = 14
        '
        'searchButton
        '
        Me.searchButton.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.searchButton.BackColor = Global.JohnOS10.My.MySettings.Default.backColor
        Me.searchButton.BackgroundImage = CType(resources.GetObject("searchButton.BackgroundImage"), System.Drawing.Image)
        Me.searchButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.searchButton.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.JohnOS10.My.MySettings.Default, "backColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.searchButton.DataBindings.Add(New System.Windows.Forms.Binding("ForeColor", Global.JohnOS10.My.MySettings.Default, "backColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.searchButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.searchButton.ForeColor = Global.JohnOS10.My.MySettings.Default.backColor
        Me.searchButton.Location = New System.Drawing.Point(764, 2)
        Me.searchButton.Name = "searchButton"
        Me.searchButton.Size = New System.Drawing.Size(27, 27)
        Me.searchButton.TabIndex = 7
        Me.searchButton.UseVisualStyleBackColor = False
        '
        'WebView21
        '
        Me.WebView21.AllowExternalDrop = True
        Me.WebView21.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.WebView21.BackColor = System.Drawing.Color.White
        Me.WebView21.CreationProperties = Nothing
        Me.WebView21.DefaultBackgroundColor = System.Drawing.Color.White
        Me.WebView21.Location = New System.Drawing.Point(3, 57)
        Me.WebView21.Name = "WebView21"
        Me.WebView21.Size = New System.Drawing.Size(793, 510)
        Me.WebView21.Source = New System.Uri("http://johnbilkey.com/johnos", System.UriKind.Absolute)
        Me.WebView21.TabIndex = 15
        Me.WebView21.ZoomFactor = 1.0R
        '
        'Browser
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = Global.JohnOS10.My.MySettings.Default.titleBarColor
        Me.ClientSize = New System.Drawing.Size(800, 570)
        Me.Controls.Add(Me.WebView21)
        Me.Controls.Add(Me.homeButton)
        Me.Controls.Add(Me.informationButton)
        Me.Controls.Add(Me.urlBar)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.JohnOS10.My.MySettings.Default, "titleBarColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.ForeColor = System.Drawing.Color.Transparent
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Browser"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Browser"
        Me.TopMost = True
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.WebView21, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents closeButton As System.Windows.Forms.Button
    Friend WithEvents backButton As System.Windows.Forms.Button
    Friend WithEvents urlBar As System.Windows.Forms.TextBox
    Friend WithEvents goButton As System.Windows.Forms.Button
    Friend WithEvents forwardButton As System.Windows.Forms.Button
    Friend WithEvents refreshButton As System.Windows.Forms.Button
    Friend WithEvents informationButton As System.Windows.Forms.Button
    Friend WithEvents homeButton As System.Windows.Forms.Button
    Friend WithEvents minButton As Button
    Friend WithEvents maxButton As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents searchButton As Button
    Friend WithEvents WebView21 As Microsoft.Web.WebView2.WinForms.WebView2
End Class
