<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UpdateJOS
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UpdateJOS))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = Global.JohnOS10.My.MySettings.Default.titleBarColor
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.WebBrowser1)
        Me.Panel1.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.JohnOS10.My.MySettings.Default, "titleBarColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(619, 469)
        Me.Panel1.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.BackColor = Global.JohnOS10.My.MySettings.Default.backColor
        Me.Panel3.Controls.Add(Me.Button4)
        Me.Panel3.Controls.Add(Me.Button3)
        Me.Panel3.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.JohnOS10.My.MySettings.Default, "backColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Panel3.Location = New System.Drawing.Point(3, 27)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(613, 30)
        Me.Panel3.TabIndex = 12
        '
        'Button4
        '
        Me.Button4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button4.BackColor = Global.JohnOS10.My.MySettings.Default.backColor
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button4.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.JohnOS10.My.MySettings.Default, "backColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.Black
        Me.Button4.Location = New System.Drawing.Point(381, 4)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(106, 23)
        Me.Button4.TabIndex = 4
        Me.Button4.Text = "About this Version"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button3.BackColor = Global.JohnOS10.My.MySettings.Default.backColor
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.JohnOS10.My.MySettings.Default, "backColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.Black
        Me.Button3.Location = New System.Drawing.Point(504, 4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(106, 23)
        Me.Button3.TabIndex = 5
        Me.Button3.Text = "Check for Updates"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = Global.JohnOS10.My.MySettings.Default.titleBarColor
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.Controls.Add(Me.Button2)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Panel2.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.JohnOS10.My.MySettings.Default, "titleBarColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(619, 27)
        Me.Panel2.TabIndex = 11
        '
        'Button2
        '
        Me.Button2.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Button2.BackColor = Global.JohnOS10.My.MySettings.Default.minButtonColor
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.JohnOS10.My.MySettings.Default, "minButtonColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Button2.DataBindings.Add(New System.Windows.Forms.Binding("ForeColor", Global.JohnOS10.My.MySettings.Default, "startButtonTextColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = Global.JohnOS10.My.MySettings.Default.startButtonTextColor
        Me.Button2.Location = New System.Drawing.Point(572, 2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(21, 22)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "-"
        Me.Button2.UseVisualStyleBackColor = False
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
        Me.Label1.Size = New System.Drawing.Size(118, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "JohnOS Update"
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Button1.BackColor = Global.JohnOS10.My.MySettings.Default.xButtonColor
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.DataBindings.Add(New System.Windows.Forms.Binding("ForeColor", Global.JohnOS10.My.MySettings.Default, "startButtonTextColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Button1.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.JohnOS10.My.MySettings.Default, "xButtonColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = Global.JohnOS10.My.MySettings.Default.startButtonTextColor
        Me.Button1.Location = New System.Drawing.Point(597, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(21, 22)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "x"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.WebBrowser1.Location = New System.Drawing.Point(3, 56)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.ScriptErrorsSuppressed = True
        Me.WebBrowser1.Size = New System.Drawing.Size(613, 410)
        Me.WebBrowser1.TabIndex = 6
        Me.WebBrowser1.Url = New System.Uri("http://johnbilkey.com/johnos/update", System.UriKind.Absolute)
        '
        'UpdateJOS
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = Global.JohnOS10.My.MySettings.Default.titleBarColor
        Me.ClientSize = New System.Drawing.Size(619, 469)
        Me.Controls.Add(Me.Panel1)
        Me.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.JohnOS10.My.MySettings.Default, "titleBarColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "UpdateJOS"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "JohnOS Update"
        Me.TopMost = True
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents WebBrowser1 As System.Windows.Forms.WebBrowser
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Panel3 As Panel
End Class
