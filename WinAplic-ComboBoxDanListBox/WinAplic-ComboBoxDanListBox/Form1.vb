Imports System.IO
Public Class FormCBnLB
    Private Sub FormCBnLB_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cmb_Drive.Items.AddRange(IO.DriveInfo.GetDrives)
    End Sub

    Private Sub Cmb_Drive_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cmb_Drive.SelectedIndexChanged
        LstInfo.Items.Clear()
        LstInfo.Items.Add("Nama Drive :" & Dir("" & _
        Cmb_Drive.Text & "", FileAttribute.Volume) & "")
        LstInfo.Items.Add("System :" & Dir("" & _
        Cmb_Drive.Text & "", FileAttribute.System) & "")
        Dim dvr As New DriveInfo(Cmb_Drive.Text)
        Dim kapasitas = CStr(dvr.TotalSize / 1000000) & " MB"
        Dim sisa = CStr(dvr.TotalFreeSpace / 1000000) & " MB"
        Dim Terpakai = CStr(Val(kapasitas) - Val(sisa)) & " MB"
        LstInfo.Items.Add("Kapasitas : " & kapasitas)
        LstInfo.Items.Add("Terpakai : " & Terpakai)
        LstInfo.Items.Add("Sisa : " & sisa)
    End Sub
End Class
