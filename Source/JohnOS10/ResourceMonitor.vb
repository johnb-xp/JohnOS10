Public Class ResourceMonitor
    Private Sub ResourceMonitor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MaximumSize = Screen.PrimaryScreen.WorkingArea.Size
        'INITIALIZE THE INTERVAL OF THE TIMER TO 500.
        Timer1.Interval = 500
        'START THE TIMER
        Timer1.Start()
    End Sub

    Private Sub Panel2_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel2.MouseDown
        If e.Button = MouseButtons.Left Then
            Me.Panel2.Capture = False
            Const WM_NCLBUTTONDOWN As Integer = &HA1S
            Const HTCAPTION As Integer = 2
            Dim msg As Message =
            Message.Create(Me.Handle, WM_NCLBUTTONDOWN,
                New IntPtr(HTCAPTION), IntPtr.Zero)
            Me.DefWndProc(msg)
        End If
    End Sub
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Timer1_Tick_1(sender As Object, e As EventArgs) Handles Timer1.Tick
        'SET PROGESSBAR TO THE PERFORMANCE VALUE.
        pbCPU.Value = pcCPU.NextValue
        pbRAM.Value = pcRAM.NextValue
        'SET THE PROGRESS BAR VALUE TO THE LABEL TO KNOW WHAT IS THE PERCENTAGE OF THE PROCESS.
        lblCPU.Text = "CPU: " & pbCPU.Value & "%"
        lblRAM.Text = "RAM: " & pbRAM.Value & "%"
    End Sub
End Class