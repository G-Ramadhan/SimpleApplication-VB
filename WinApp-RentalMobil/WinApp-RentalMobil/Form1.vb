Public Class Form1
    Sub KOSONG()
        TxtNomorSewa.Text = ""
        TxtNama.Text = ""
        CmbJenisMobil.Text = ""
        Txtperhari.Text = 0
        TxtLamaSewa.Text = 0
        txtjumlah.Text = 0
    End Sub


    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbJenisMobil.SelectedIndexChanged
        If CmbJenisMobil.Text = "Bus" Then
            Txtperhari.Text = 1000000
        ElseIf CmbJenisMobil.Text = "SEDAN" Then
            Txtperhari.Text = 800000
        ElseIf CmbJenisMobil.Text = "KIJANG" Then
            Txtperhari.Text = 400000
        Else
            Txtperhari.Text = 200000
        End If


    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call KOSONG()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Call KOSONG()
    End Sub

    Private Sub TxtLamaSewa_TextChanged(sender As Object, e As EventArgs) Handles TxtLamaSewa.TextChanged
        If TxtLamaSewa.Text = "" Then TxtLamaSewa.Text = "0"
        If Not IsNumeric(TxtLamaSewa.Text) Then
            MsgBox("MAAF DATA HARUS ANGKA")
            Exit Sub
        End If
        txtjumlah.Text = Txtperhari.Text * TxtLamaSewa.Text
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If MsgBox("keluar?", vbYesNo, "konfirm") = vbYes Then
            End
        End If
    End Sub
End Class
