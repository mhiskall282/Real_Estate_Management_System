Public Class Form1
    Private TimerInterval As Integer = 10
    Private Counter As Integer = 0

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Interval = TimerInterval
        Timer1.Start()
        lblCount.Text = Counter.ToString()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Counter += 1
        lblCount.Text = Counter.ToString()
        If Counter >= 100 Then
            Timer1.Stop()
            Me.Hide()
            frmLogin.Show()
        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class
