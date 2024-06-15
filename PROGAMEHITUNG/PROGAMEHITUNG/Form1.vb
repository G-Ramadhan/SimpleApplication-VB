Public Class Form1

    Private Sub btnACAK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnACAK.Click
        Randomize()
        If btnACAK.Text = "Acak" Then
            Timer1.Enabled = True
            btnACAK.Text = "Stop"
        Else
            Timer1.Enabled = False
            btnACAK.Text = "Acak"
        End If
    End Sub

    Private Sub btnCEKHASIL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCEKHASIL.Click
        If lblOPR.Text = "+" Then
            If Val(txtAngka1.Text) + Val(txtAngka2.Text) = txtHasil.Text Then
                lblPESAN.Text = "SELAMAT JAWABAN ANDA BENAR"
            Else
                lblPESAN.Text = "MAAF JAWABAN ANDA SALAH, YANG BENAR = " & (Val(txtAngka1.Text) + Val(txtAngka2.Text))
            End If

        ElseIf lblOPR.Text = "-" Then
            If Val(txtAngka1.Text) - Val(txtAngka2.Text) = txtHasil.Text Then
                lblPESAN.Text = "SELAMAT JAWABAN ANDA BENAR"
            Else
                lblPESAN.Text = "MAAF JAWABAN ANDA SALAH, YANG BENAR = " & (Val(txtAngka1.Text) - Val(txtAngka2.Text))
            End If

        ElseIf lblOPR.Text = "X" Then
            If Val(txtAngka1.Text) * Val(txtAngka2.Text) = txtHasil.Text Then
                lblPESAN.Text = "SELAMAT JAWABAN ANDA BENAR"
            Else
                lblPESAN.Text = "MAAF JAWABAN ANDA SALAH, YANG BENAR = " & (Val(txtAngka1.Text) * Val(txtAngka2.Text))
            End If
        Else
            If Val(txtAngka1.Text) / Val(txtAngka2.Text) = txtHasil.Text Then
                lblPESAN.Text = "SELAMAT JAWABAN ANDA BENAR"
            Else
                lblPESAN.Text = "MAAF JAWABAN ANDA SALAH, YANG BENAR = " & (Val(txtAngka1.Text) / Val(txtAngka2.Text))
            End If
        End If
    End Sub

    Private Sub btnTAMBAH_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTAMBAH.Click
        lblOPR.Text = "+"
    End Sub

    Private Sub btnKURANG_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKURANG.Click
        lblOPR.Text = "-"
    End Sub

    Private Sub btnKALI_Click(sender As Object, e As EventArgs) Handles btnKALI.Click
        lblOPR.Text = "X"
    End Sub

    Private Sub btnBAGI_Click(sender As Object, e As EventArgs) Handles btnBAGI.Click
        lblOPR.Text = ":"
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        txtAngka1.Text = Int(Rnd() * txtACAK.Text)
        txtAngka2.Text = Int(Rnd() * txtACAK.Text)
    End Sub

End Class
