Public Class Factura

    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Label3.Text = TimeOfDay.TimeOfDay.ToString
    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label7.Click

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        TBIngreso.Text = Label3.Text
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        TBHsalida.Text = Label3.Text


    End Sub

    Private Sub TBIngreso_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TBIngreso.TextChanged
        Dim Horainicial As New DateTime(Label3.Text)
        TBIngreso.Text = Label3.Text
        Horainicial = TBIngreso.Text
        Horasalida = TBHsalida.Text
        Minutos = Horasalida - Horainicial

        Dim minutos As Int32 = ts.Minutes

    End Sub

    Private Sub Factura_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class