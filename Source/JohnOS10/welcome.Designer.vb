<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Welcome
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Welcome))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.startButtonIcon = New System.Windows.Forms.PictureBox()
        Me.startbutton = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.JohnOSDesktoplogo = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.x = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.startButtonIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.JohnOSDesktoplogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Location = New System.Drawing.Point(3, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(535, 270)
        Me.Panel1.TabIndex = 19
        '
        'Panel4
        '
        Me.Panel4.BackColor = Global.JohnOS10.My.MySettings.Default.backColor
        Me.Panel4.Controls.Add(Me.Label4)
        Me.Panel4.Controls.Add(Me.startButtonIcon)
        Me.Panel4.Controls.Add(Me.startbutton)
        Me.Panel4.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.JohnOS10.My.MySettings.Default, "backColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 217)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(535, 53)
        Me.Panel4.TabIndex = 19
        '
        'Label4
        '
        Me.Label4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(179, 11)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(147, 31)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "To begin, click"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'startButtonIcon
        '
        Me.startButtonIcon.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.startButtonIcon.BackColor = Global.JohnOS10.My.MySettings.Default.startButtonColor
        Me.startButtonIcon.BackgroundImage = CType(resources.GetObject("startButtonIcon.BackgroundImage"), System.Drawing.Image)
        Me.startButtonIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.startButtonIcon.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.JohnOS10.My.MySettings.Default, "startButtonColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.startButtonIcon.Location = New System.Drawing.Point(332, 17)
        Me.startButtonIcon.Name = "startButtonIcon"
        Me.startButtonIcon.Size = New System.Drawing.Size(18, 21)
        Me.startButtonIcon.TabIndex = 13
        Me.startButtonIcon.TabStop = False
        '
        'startbutton
        '
        Me.startbutton.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.startbutton.BackColor = Global.JohnOS10.My.MySettings.Default.startButtonColor
        Me.startbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.startbutton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.startbutton.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.JohnOS10.My.MySettings.Default, "startButtonColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.startbutton.DataBindings.Add(New System.Windows.Forms.Binding("ForeColor", Global.JohnOS10.My.MySettings.Default, "startButtonTextColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.startbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.startbutton.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.startbutton.ForeColor = Global.JohnOS10.My.MySettings.Default.startButtonTextColor
        Me.startbutton.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.startbutton.Location = New System.Drawing.Point(329, 12)
        Me.startbutton.Margin = New System.Windows.Forms.Padding(1)
        Me.startbutton.MinimumSize = New System.Drawing.Size(78, 30)
        Me.startbutton.Name = "startbutton"
        Me.startbutton.Size = New System.Drawing.Size(78, 30)
        Me.startbutton.TabIndex = 0
        Me.startbutton.Text = "start"
        Me.startbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.startbutton.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.JohnOSDesktoplogo)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 27)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(535, 243)
        Me.Panel3.TabIndex = 18
        '
        'Label3
        '
        Me.Label3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.Font = New System.Drawing.Font("Trebuchet MS", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(206, 97)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(326, 62)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "to JohnOS 10"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'JohnOSDesktoplogo
        '
        Me.JohnOSDesktoplogo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.JohnOSDesktoplogo.BackColor = System.Drawing.Color.Transparent
        Me.JohnOSDesktoplogo.BackgroundImage = CType(resources.GetObject("JohnOSDesktoplogo.BackgroundImage"), System.Drawing.Image)
        Me.JohnOSDesktoplogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.JohnOSDesktoplogo.Location = New System.Drawing.Point(13, 10)
        Me.JohnOSDesktoplogo.Name = "JohnOSDesktoplogo"
        Me.JohnOSDesktoplogo.Size = New System.Drawing.Size(187, 174)
        Me.JohnOSDesktoplogo.TabIndex = 17
        Me.JohnOSDesktoplogo.TabStop = False
        '
        'Label2
        '
        Me.Label2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.Font = New System.Drawing.Font("Trebuchet MS", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(206, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(326, 79)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Welcome"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel2
        '
        Me.Panel2.BackColor = Global.JohnOS10.My.MySettings.Default.titleBarColor
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.x)
        Me.Panel2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Panel2.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.JohnOS10.My.MySettings.Default, "titleBarColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(535, 27)
        Me.Panel2.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.DataBindings.Add(New System.Windows.Forms.Binding("ForeColor", Global.JohnOS10.My.MySettings.Default, "titleBarTextColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = Global.JohnOS10.My.MySettings.Default.titleBarTextColor
        Me.Label1.Location = New System.Drawing.Point(5, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(159, 20)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Welcome to JohnOS"
        '
        'x
        '
        Me.x.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.x.BackColor = Global.JohnOS10.My.MySettings.Default.xButtonColor
        Me.x.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.x.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.JohnOS10.My.MySettings.Default, "xButtonColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.x.DataBindings.Add(New System.Windows.Forms.Binding("ForeColor", Global.JohnOS10.My.MySettings.Default, "startButtonTextColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.x.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.x.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.x.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.x.ForeColor = Global.JohnOS10.My.MySettings.Default.startButtonTextColor
        Me.x.Location = New System.Drawing.Point(513, 3)
        Me.x.Name = "x"
        Me.x.Size = New System.Drawing.Size(21, 22)
        Me.x.TabIndex = 1
        Me.x.Text = "x"
        Me.x.UseVisualStyleBackColor = False
        '
        'Welcome
        '
        Me.AcceptButton = Me.startbutton
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.AutoSize = True
        Me.BackColor = Global.JohnOS10.My.MySettings.Default.titleBarColor
        Me.CancelButton = Me.x
        Me.ClientSize = New System.Drawing.Size(541, 273)
        Me.Controls.Add(Me.Panel1)
        Me.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.JohnOS10.My.MySettings.Default, "titleBarColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Welcome"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Welcome"
        Me.TopMost = True
        Me.Panel1.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        CType(Me.startButtonIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        CType(Me.JohnOSDesktoplogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents x As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents JohnOSDesktoplogo As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents startButtonIcon As PictureBox
    Friend WithEvents startbutton As Button
End Class
