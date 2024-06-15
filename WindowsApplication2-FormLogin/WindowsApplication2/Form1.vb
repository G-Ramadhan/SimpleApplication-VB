Public Class FormLogin

    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        If TxtUserName.Text = "admin" And TxtPassword.Text = "123" Then
            MsgBox("Selamat, Anda adalah Pengguna Yang Sah!")
        Else
            MsgBox("Maaf, Anda Bukan Pengguna Yang Sah!")
        End If
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        MsgBox("Sampai Jumpa Lagi!")
        End
    End Sub
End Class
