<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class JIM
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
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.WebBrowser1.Location = New System.Drawing.Point(2, 26)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.ScriptErrorsSuppressed = True
        Me.WebBrowser1.ScrollBarsEnabled = False
        Me.WebBrowser1.Size = New System.Drawing.Size(414, 307)
        Me.WebBrowser1.TabIndex = 3
        Me.WebBrowser1.TabStop = False
        Me.WebBrowser1.Url = New System.Uri("http://johnbilkey.com/johnos/jim.html", System.UriKind.Absolute)
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
        Me.Button1.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.Button1.ForeColor = Global.JohnOS10.My.MySettings.Default.startButtonTextColor
        Me.Button1.Location = New System.Drawing.Point(395, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(20, 22)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "x"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = Global.JohnOS10.My.MySettings.Default.titleBarColor
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.JohnOS10.My.MySettings.Default, "titleBarColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(418, 26)
        Me.Panel1.TabIndex = 4
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
        Me.Button3.Location = New System.Drawing.Point(370, 2)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(21, 22)
        Me.Button3.TabIndex = 1
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
        Me.Label1.Location = New System.Drawing.Point(4, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(194, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "JohnOS Instant Messenger"
        '
        'JIM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = Global.JohnOS10.My.MySettings.Default.titleBarColor
        Me.ClientSize = New System.Drawing.Size(418, 335)
        Me.Controls.Add(Me.WebBrowser1)
        Me.Controls.Add(Me.Panel1)
        Me.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.JohnOS10.My.MySettings.Default, "titleBarColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "JIM"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "JIM"
        Me.TopMost = True
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents WebBrowser1 As System.Windows.Forms.WebBrowser
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button3 As Button
End Class
