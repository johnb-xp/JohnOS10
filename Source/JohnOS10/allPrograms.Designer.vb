<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class allPrograms
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(allPrograms))
        Me.allprogs = New System.Windows.Forms.Panel()
        Me.closeButton = New System.Windows.Forms.Button()
        Me.yortzeeButton = New System.Windows.Forms.Button()
        Me.minesweeperButton = New System.Windows.Forms.Button()
        Me.bitcoinButton = New System.Windows.Forms.Button()
        Me.moonButton = New System.Windows.Forms.Button()
        Me.radioButton = New System.Windows.Forms.Button()
        Me.mediaButton = New System.Windows.Forms.Button()
        Me.mapsButton = New System.Windows.Forms.Button()
        Me.jimButton = New System.Windows.Forms.Button()
        Me.notepadButton = New System.Windows.Forms.Button()
        Me.calendarButton = New System.Windows.Forms.Button()
        Me.clockButton = New System.Windows.Forms.Button()
        Me.calculatorButton = New System.Windows.Forms.Button()
        Me.settingsButton = New System.Windows.Forms.Button()
        Me.updateButton = New System.Windows.Forms.Button()
        Me.browserButton = New System.Windows.Forms.Button()
        Me.allprogs.SuspendLayout()
        Me.SuspendLayout()
        '
        'allprogs
        '
        Me.allprogs.AutoSize = True
        Me.allprogs.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.allprogs.BackColor = Global.JohnOS10.My.MySettings.Default.backColor
        Me.allprogs.Controls.Add(Me.closeButton)
        Me.allprogs.Controls.Add(Me.yortzeeButton)
        Me.allprogs.Controls.Add(Me.minesweeperButton)
        Me.allprogs.Controls.Add(Me.bitcoinButton)
        Me.allprogs.Controls.Add(Me.moonButton)
        Me.allprogs.Controls.Add(Me.radioButton)
        Me.allprogs.Controls.Add(Me.mediaButton)
        Me.allprogs.Controls.Add(Me.mapsButton)
        Me.allprogs.Controls.Add(Me.jimButton)
        Me.allprogs.Controls.Add(Me.notepadButton)
        Me.allprogs.Controls.Add(Me.calendarButton)
        Me.allprogs.Controls.Add(Me.clockButton)
        Me.allprogs.Controls.Add(Me.calculatorButton)
        Me.allprogs.Controls.Add(Me.settingsButton)
        Me.allprogs.Controls.Add(Me.updateButton)
        Me.allprogs.Controls.Add(Me.browserButton)
        Me.allprogs.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.JohnOS10.My.MySettings.Default, "backColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.allprogs.Dock = System.Windows.Forms.DockStyle.Fill
        Me.allprogs.Location = New System.Drawing.Point(0, 0)
        Me.allprogs.MinimumSize = New System.Drawing.Size(160, 0)
        Me.allprogs.Name = "allprogs"
        Me.allprogs.Size = New System.Drawing.Size(180, 480)
        Me.allprogs.TabIndex = 16
        '
        'closeButton
        '
        Me.closeButton.AutoSize = True
        Me.closeButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.closeButton.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.closeButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.closeButton.Image = CType(resources.GetObject("closeButton.Image"), System.Drawing.Image)
        Me.closeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.closeButton.Location = New System.Drawing.Point(0, 450)
        Me.closeButton.Name = "closeButton"
        Me.closeButton.Size = New System.Drawing.Size(180, 30)
        Me.closeButton.TabIndex = 0
        Me.closeButton.Text = "Close"
        Me.closeButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.closeButton.UseVisualStyleBackColor = True
        '
        'yortzeeButton
        '
        Me.yortzeeButton.AutoSize = True
        Me.yortzeeButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.yortzeeButton.Dock = System.Windows.Forms.DockStyle.Top
        Me.yortzeeButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.yortzeeButton.Image = CType(resources.GetObject("yortzeeButton.Image"), System.Drawing.Image)
        Me.yortzeeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.yortzeeButton.Location = New System.Drawing.Point(0, 420)
        Me.yortzeeButton.Name = "yortzeeButton"
        Me.yortzeeButton.Size = New System.Drawing.Size(180, 30)
        Me.yortzeeButton.TabIndex = 1
        Me.yortzeeButton.Text = "Yortzee"
        Me.yortzeeButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.yortzeeButton.UseVisualStyleBackColor = True
        '
        'minesweeperButton
        '
        Me.minesweeperButton.AutoSize = True
        Me.minesweeperButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.minesweeperButton.Dock = System.Windows.Forms.DockStyle.Top
        Me.minesweeperButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.minesweeperButton.Image = CType(resources.GetObject("minesweeperButton.Image"), System.Drawing.Image)
        Me.minesweeperButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.minesweeperButton.Location = New System.Drawing.Point(0, 390)
        Me.minesweeperButton.Name = "minesweeperButton"
        Me.minesweeperButton.Size = New System.Drawing.Size(180, 30)
        Me.minesweeperButton.TabIndex = 2
        Me.minesweeperButton.Text = "Minesweeper"
        Me.minesweeperButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.minesweeperButton.UseVisualStyleBackColor = True
        '
        'bitcoinButton
        '
        Me.bitcoinButton.AutoSize = True
        Me.bitcoinButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.bitcoinButton.Dock = System.Windows.Forms.DockStyle.Top
        Me.bitcoinButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bitcoinButton.Image = CType(resources.GetObject("bitcoinButton.Image"), System.Drawing.Image)
        Me.bitcoinButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bitcoinButton.Location = New System.Drawing.Point(0, 360)
        Me.bitcoinButton.Name = "bitcoinButton"
        Me.bitcoinButton.Size = New System.Drawing.Size(180, 30)
        Me.bitcoinButton.TabIndex = 3
        Me.bitcoinButton.Text = "Bitcoin"
        Me.bitcoinButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bitcoinButton.UseVisualStyleBackColor = True
        '
        'moonButton
        '
        Me.moonButton.AutoSize = True
        Me.moonButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.moonButton.Dock = System.Windows.Forms.DockStyle.Top
        Me.moonButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.moonButton.Image = CType(resources.GetObject("moonButton.Image"), System.Drawing.Image)
        Me.moonButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.moonButton.Location = New System.Drawing.Point(0, 330)
        Me.moonButton.Name = "moonButton"
        Me.moonButton.Size = New System.Drawing.Size(180, 30)
        Me.moonButton.TabIndex = 4
        Me.moonButton.Text = "Moon Phase"
        Me.moonButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.moonButton.UseVisualStyleBackColor = True
        '
        'radioButton
        '
        Me.radioButton.AutoSize = True
        Me.radioButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.radioButton.Dock = System.Windows.Forms.DockStyle.Top
        Me.radioButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radioButton.Image = CType(resources.GetObject("radioButton.Image"), System.Drawing.Image)
        Me.radioButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.radioButton.Location = New System.Drawing.Point(0, 300)
        Me.radioButton.Name = "radioButton"
        Me.radioButton.Size = New System.Drawing.Size(180, 30)
        Me.radioButton.TabIndex = 5
        Me.radioButton.Text = "Radio"
        Me.radioButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.radioButton.UseVisualStyleBackColor = True
        '
        'mediaButton
        '
        Me.mediaButton.AutoSize = True
        Me.mediaButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.mediaButton.Dock = System.Windows.Forms.DockStyle.Top
        Me.mediaButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mediaButton.Image = CType(resources.GetObject("mediaButton.Image"), System.Drawing.Image)
        Me.mediaButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.mediaButton.Location = New System.Drawing.Point(0, 270)
        Me.mediaButton.Name = "mediaButton"
        Me.mediaButton.Size = New System.Drawing.Size(180, 30)
        Me.mediaButton.TabIndex = 6
        Me.mediaButton.Text = "Media Player"
        Me.mediaButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.mediaButton.UseVisualStyleBackColor = True
        '
        'mapsButton
        '
        Me.mapsButton.AutoSize = True
        Me.mapsButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.mapsButton.Dock = System.Windows.Forms.DockStyle.Top
        Me.mapsButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mapsButton.Image = CType(resources.GetObject("mapsButton.Image"), System.Drawing.Image)
        Me.mapsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.mapsButton.Location = New System.Drawing.Point(0, 240)
        Me.mapsButton.Name = "mapsButton"
        Me.mapsButton.Size = New System.Drawing.Size(180, 30)
        Me.mapsButton.TabIndex = 7
        Me.mapsButton.Text = "Maps"
        Me.mapsButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.mapsButton.UseVisualStyleBackColor = True
        '
        'jimButton
        '
        Me.jimButton.AutoSize = True
        Me.jimButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.jimButton.Dock = System.Windows.Forms.DockStyle.Top
        Me.jimButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.jimButton.Image = CType(resources.GetObject("jimButton.Image"), System.Drawing.Image)
        Me.jimButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.jimButton.Location = New System.Drawing.Point(0, 210)
        Me.jimButton.Name = "jimButton"
        Me.jimButton.Size = New System.Drawing.Size(180, 30)
        Me.jimButton.TabIndex = 8
        Me.jimButton.Text = "JIM"
        Me.jimButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.jimButton.UseVisualStyleBackColor = True
        '
        'notepadButton
        '
        Me.notepadButton.AutoSize = True
        Me.notepadButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.notepadButton.Dock = System.Windows.Forms.DockStyle.Top
        Me.notepadButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.notepadButton.Image = CType(resources.GetObject("notepadButton.Image"), System.Drawing.Image)
        Me.notepadButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.notepadButton.Location = New System.Drawing.Point(0, 180)
        Me.notepadButton.Name = "notepadButton"
        Me.notepadButton.Size = New System.Drawing.Size(180, 30)
        Me.notepadButton.TabIndex = 9
        Me.notepadButton.Text = "Notepad"
        Me.notepadButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.notepadButton.UseVisualStyleBackColor = True
        '
        'calendarButton
        '
        Me.calendarButton.AutoSize = True
        Me.calendarButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.calendarButton.Dock = System.Windows.Forms.DockStyle.Top
        Me.calendarButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.calendarButton.Image = CType(resources.GetObject("calendarButton.Image"), System.Drawing.Image)
        Me.calendarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.calendarButton.Location = New System.Drawing.Point(0, 150)
        Me.calendarButton.Name = "calendarButton"
        Me.calendarButton.Size = New System.Drawing.Size(180, 30)
        Me.calendarButton.TabIndex = 10
        Me.calendarButton.Text = "Calendar"
        Me.calendarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.calendarButton.UseVisualStyleBackColor = True
        '
        'clockButton
        '
        Me.clockButton.AutoSize = True
        Me.clockButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.clockButton.Dock = System.Windows.Forms.DockStyle.Top
        Me.clockButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clockButton.Image = CType(resources.GetObject("clockButton.Image"), System.Drawing.Image)
        Me.clockButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.clockButton.Location = New System.Drawing.Point(0, 120)
        Me.clockButton.Name = "clockButton"
        Me.clockButton.Size = New System.Drawing.Size(180, 30)
        Me.clockButton.TabIndex = 11
        Me.clockButton.Text = "Clock"
        Me.clockButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.clockButton.UseVisualStyleBackColor = True
        '
        'calculatorButton
        '
        Me.calculatorButton.AutoSize = True
        Me.calculatorButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.calculatorButton.Dock = System.Windows.Forms.DockStyle.Top
        Me.calculatorButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.calculatorButton.Image = CType(resources.GetObject("calculatorButton.Image"), System.Drawing.Image)
        Me.calculatorButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.calculatorButton.Location = New System.Drawing.Point(0, 90)
        Me.calculatorButton.Name = "calculatorButton"
        Me.calculatorButton.Size = New System.Drawing.Size(180, 30)
        Me.calculatorButton.TabIndex = 12
        Me.calculatorButton.Text = "Calculator"
        Me.calculatorButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.calculatorButton.UseVisualStyleBackColor = True
        '
        'settingsButton
        '
        Me.settingsButton.AutoSize = True
        Me.settingsButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.settingsButton.Dock = System.Windows.Forms.DockStyle.Top
        Me.settingsButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.settingsButton.Image = CType(resources.GetObject("settingsButton.Image"), System.Drawing.Image)
        Me.settingsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.settingsButton.Location = New System.Drawing.Point(0, 60)
        Me.settingsButton.Name = "settingsButton"
        Me.settingsButton.Size = New System.Drawing.Size(180, 30)
        Me.settingsButton.TabIndex = 13
        Me.settingsButton.Text = "Control Panel"
        Me.settingsButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.settingsButton.UseVisualStyleBackColor = True
        '
        'updateButton
        '
        Me.updateButton.AutoSize = True
        Me.updateButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.updateButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.updateButton.Dock = System.Windows.Forms.DockStyle.Top
        Me.updateButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.updateButton.Image = CType(resources.GetObject("updateButton.Image"), System.Drawing.Image)
        Me.updateButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.updateButton.Location = New System.Drawing.Point(0, 30)
        Me.updateButton.Name = "updateButton"
        Me.updateButton.Size = New System.Drawing.Size(180, 30)
        Me.updateButton.TabIndex = 14
        Me.updateButton.Text = "JohnOS Update"
        Me.updateButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.updateButton.UseVisualStyleBackColor = True
        '
        'browserButton
        '
        Me.browserButton.AutoSize = True
        Me.browserButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.browserButton.Dock = System.Windows.Forms.DockStyle.Top
        Me.browserButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.browserButton.Image = CType(resources.GetObject("browserButton.Image"), System.Drawing.Image)
        Me.browserButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.browserButton.Location = New System.Drawing.Point(0, 0)
        Me.browserButton.Name = "browserButton"
        Me.browserButton.Size = New System.Drawing.Size(180, 30)
        Me.browserButton.TabIndex = 15
        Me.browserButton.Text = "JohnOS Browser"
        Me.browserButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.browserButton.UseVisualStyleBackColor = True
        '
        'allPrograms
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = Global.JohnOS10.My.MySettings.Default.backColor
        Me.ClientSize = New System.Drawing.Size(180, 480)
        Me.Controls.Add(Me.allprogs)
        Me.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.JohnOS10.My.MySettings.Default, "backColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MinimumSize = New System.Drawing.Size(160, 0)
        Me.Name = "allPrograms"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "All Programs"
        Me.TopMost = True
        Me.allprogs.ResumeLayout(False)
        Me.allprogs.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents allprogs As Panel
    Friend WithEvents mapsButton As Button
    Friend WithEvents radioButton As Button
    Friend WithEvents closeButton As Button
    Friend WithEvents bitcoinButton As Button
    Friend WithEvents mediaButton As Button
    Friend WithEvents moonButton As Button
    Friend WithEvents jimButton As Button
    Friend WithEvents yortzeeButton As Button
    Friend WithEvents settingsButton As Button
    Friend WithEvents notepadButton As Button
    Friend WithEvents browserButton As Button
    Friend WithEvents updateButton As Button
    Friend WithEvents minesweeperButton As Button
    Friend WithEvents calendarButton As Button
    Friend WithEvents clockButton As Button
    Friend WithEvents calculatorButton As Button
End Class
