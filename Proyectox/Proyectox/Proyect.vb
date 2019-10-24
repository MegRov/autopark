Public Class Proyect

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If ProgressBar1.Value < 100 Then
            ProgressBar1.Value = ProgressBar1.Value + 5
        Else
            Timer1.Enabled = False
            Me.Hide()
            Form1.Show()


        End If

    End Sub
End Class