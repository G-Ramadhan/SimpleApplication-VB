<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtNomorSewa = New System.Windows.Forms.TextBox()
        Me.TxtNama = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.JnsMbl = New System.Windows.Forms.Label()
        Me.Txtperhari = New System.Windows.Forms.TextBox()
        Me.lama = New System.Windows.Forms.Label()
        Me.TxtLamaSewa = New System.Windows.Forms.TextBox()
        Me.asd = New System.Windows.Forms.Label()
        Me.txtjumlah = New System.Windows.Forms.TextBox()
        Me.CmbJenisMobil = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Nirmala UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(139, 105)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(108, 23)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nomor Sewa"
        '
        'TxtNomorSewa
        '
        Me.TxtNomorSewa.Location = New System.Drawing.Point(287, 105)
        Me.TxtNomorSewa.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxtNomorSewa.Name = "TxtNomorSewa"
        Me.TxtNomorSewa.Size = New System.Drawing.Size(264, 30)
        Me.TxtNomorSewa.TabIndex = 3
        '
        'TxtNama
        '
        Me.TxtNama.Location = New System.Drawing.Point(287, 145)
        Me.TxtNama.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxtNama.Name = "TxtNama"
        Me.TxtNama.Size = New System.Drawing.Size(264, 30)
        Me.TxtNama.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Nirmala UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(139, 145)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(127, 23)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Nama Penyewa"
        '
        'JnsMbl
        '
        Me.JnsMbl.AutoSize = True
        Me.JnsMbl.Font = New System.Drawing.Font("Nirmala UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.JnsMbl.Location = New System.Drawing.Point(139, 183)
        Me.JnsMbl.Name = "JnsMbl"
        Me.JnsMbl.Size = New System.Drawing.Size(94, 23)
        Me.JnsMbl.TabIndex = 5
        Me.JnsMbl.Text = "Jenis Mobil"
        '
        'Txtperhari
        '
        Me.Txtperhari.Location = New System.Drawing.Point(287, 221)
        Me.Txtperhari.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Txtperhari.Name = "Txtperhari"
        Me.Txtperhari.ReadOnly = True
        Me.Txtperhari.Size = New System.Drawing.Size(264, 30)
        Me.Txtperhari.TabIndex = 6
        '
        'lama
        '
        Me.lama.AutoSize = True
        Me.lama.Font = New System.Drawing.Font("Nirmala UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lama.Location = New System.Drawing.Point(139, 259)
        Me.lama.Name = "lama"
        Me.lama.Size = New System.Drawing.Size(95, 23)
        Me.lama.TabIndex = 5
        Me.lama.Text = "Lama Sewa"
        '
        'TxtLamaSewa
        '
        Me.TxtLamaSewa.Location = New System.Drawing.Point(287, 259)
        Me.TxtLamaSewa.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxtLamaSewa.Name = "TxtLamaSewa"
        Me.TxtLamaSewa.Size = New System.Drawing.Size(264, 30)
        Me.TxtLamaSewa.TabIndex = 6
        '
        'asd
        '
        Me.asd.AutoSize = True
        Me.asd.Font = New System.Drawing.Font("Nirmala UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.asd.Location = New System.Drawing.Point(139, 297)
        Me.asd.Name = "asd"
        Me.asd.Size = New System.Drawing.Size(111, 23)
        Me.asd.TabIndex = 5
        Me.asd.Text = "Jumlah Bayar"
        '
        'txtjumlah
        '
        Me.txtjumlah.Location = New System.Drawing.Point(287, 297)
        Me.txtjumlah.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtjumlah.Name = "txtjumlah"
        Me.txtjumlah.ReadOnly = True
        Me.txtjumlah.Size = New System.Drawing.Size(264, 30)
        Me.txtjumlah.TabIndex = 6
        '
        'CmbJenisMobil
        '
        Me.CmbJenisMobil.FormattingEnabled = True
        Me.CmbJenisMobil.Items.AddRange(New Object() {"BUS", "SEDAN", "KIJANG", "CARRY"})
        Me.CmbJenisMobil.Location = New System.Drawing.Point(287, 183)
        Me.CmbJenisMobil.Name = "CmbJenisMobil"
        Me.CmbJenisMobil.Size = New System.Drawing.Size(264, 31)
        Me.CmbJenisMobil.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Nirmala UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(140, 221)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 23)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Sewa Perhari"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Nirmala UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(14, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(672, 46)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "INPUT DATA RENTAL MOBIL"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(287, 358)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(114, 37)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "Blank Form"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(407, 358)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(114, 37)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Close"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(699, 505)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.CmbJenisMobil)
        Me.Controls.Add(Me.txtjumlah)
        Me.Controls.Add(Me.asd)
        Me.Controls.Add(Me.TxtLamaSewa)
        Me.Controls.Add(Me.lama)
        Me.Controls.Add(Me.Txtperhari)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.JnsMbl)
        Me.Controls.Add(Me.TxtNama)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TxtNomorSewa)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Nirmala UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtNomorSewa As System.Windows.Forms.TextBox
    Friend WithEvents TxtNama As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents JnsMbl As System.Windows.Forms.Label
    Friend WithEvents Txtperhari As System.Windows.Forms.TextBox
    Friend WithEvents lama As System.Windows.Forms.Label
    Friend WithEvents TxtLamaSewa As System.Windows.Forms.TextBox
    Friend WithEvents asd As System.Windows.Forms.Label
    Friend WithEvents txtjumlah As System.Windows.Forms.TextBox
    Friend WithEvents CmbJenisMobil As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button

End Class
