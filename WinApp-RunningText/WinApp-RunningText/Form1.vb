Public Class Form1

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        LblPesan.Left = LblPesan.Left + 2
        If LblPesan.Left > 368 Then LblPesan.Left = -300
        LblInfo.Text = "Posisi ke Kanan : " & LblPesan.Left

        LblPesan2.Left = LblPesan2.Left - 2
        If LblPesan2.Left < -300 Then LblPesan2.Left = 368
        LblInfo2.Text = "Posisi ke Kiri : " & LblPesan2.Left

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Timer1.Enabled = False

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Timer1.Enabled = True

    End Sub
End Class
