Public Class NotePad

    Private Sub BukaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BukaToolStripMenuItem.Click
        Dim kotak_dialog As OpenFileDialog = New OpenFileDialog
        kotak_dialog.Filter = "File Text (*.txt) | *.txt"
        kotak_dialog.ShowDialog()
        Dim fileText As String = My.Computer.FileSystem.ReadAllText(kotak_dialog.FileName)
        RchTeks.Text = fileText
    End Sub

    Private Sub SimpanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SimpanToolStripMenuItem.Click
        Dim kotak_dialog As SaveFileDialog = New SaveFileDialog
        kotak_dialog.Filter = "File Text (*.txt) | *.txt"
        kotak_dialog.ShowDialog()
        My.Computer.FileSystem.WriteAllText("" & kotak_dialog.FileName & "", RchTeks.Text,False)
    End Sub

    Private Sub BaruToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BaruToolStripMenuItem.Click
        RchTeks.Text = ""
    End Sub

    Private Sub RegularToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegularToolStripMenuItem.Click
        RchTeks.SelectionFont = New Font(RchTeks.SelectionFont, FontStyle.Regular)
    End Sub

    Private Sub BoldToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BoldToolStripMenuItem.Click
        RchTeks.SelectionFont = New Font(RchTeks.SelectionFont, FontStyle.Bold)
    End Sub
End Class
