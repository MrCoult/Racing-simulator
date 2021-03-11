Public Class Form1
    Dim varSTART As Boolean
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Not varSTART Then
            ProgressBar1.Value = 0
            ProgressBar2.Value = 0
            Timer1.Start()
            Button1.Text = "Stop"
            varSTART = False
        Else
            Timer1.Stop()
            Button1.Text = "Start"
            varSTART = True
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim varPAS1 As Integer
        Dim varPAS2 As Integer
        varPAS1 = Rnd() * 10000
        ProgressBar1.Increment(varPAS1)
        varPAS2 = Rnd() * 10000
        ProgressBar2.Increment(varPAS2)
        If ProgressBar1.Value >= ProgressBar1.Maximum And ProgressBar1.Value >= ProgressBar1.Maximum Then
            Timer1.Stop()
            varSTART = False
            Button1.Text = "Start"
            MsgBox("Draw")
        ElseIf ProgressBar1.Value >= ProgressBar1.Maximum Then
            Timer1.Stop()
            varSTART = False
            Button1.Text = "Start"
            MsgBox("Player 1 Wins")
        ElseIf ProgressBar2.Value >= ProgressBar2.Maximum Then
            Timer1.Stop()
            varSTART = False
            Button1.Text = "Start"
            MsgBox("Player 2 Wins")
        End If
    End Sub
End Class
