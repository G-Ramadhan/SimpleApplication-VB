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
        Me.components = New System.ComponentModel.Container()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.LblPesan = New System.Windows.Forms.Label()
        Me.LblInfo = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.LblInfo2 = New System.Windows.Forms.Label()
        Me.LblPesan2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(100, 153)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(82, 37)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Stop"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(188, 153)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(82, 37)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Run"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'LblPesan
        '
        Me.LblPesan.AutoSize = True
        Me.LblPesan.Location = New System.Drawing.Point(10, 37)
        Me.LblPesan.Name = "LblPesan"
        Me.LblPesan.Size = New System.Drawing.Size(357, 28)
        Me.LblPesan.TabIndex = 2
        Me.LblPesan.Text = "Selamat Datang di Pemrograman Visual"
        '
        'LblInfo
        '
        Me.LblInfo.AutoSize = True
        Me.LblInfo.Location = New System.Drawing.Point(101, 9)
        Me.LblInfo.Name = "LblInfo"
        Me.LblInfo.Size = New System.Drawing.Size(158, 28)
        Me.LblInfo.TabIndex = 3
        Me.LblInfo.Text = "Posisi ke Kanan : "
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1
        '
        'LblInfo2
        '
        Me.LblInfo2.AutoSize = True
        Me.LblInfo2.Location = New System.Drawing.Point(109, 65)
        Me.LblInfo2.Name = "LblInfo2"
        Me.LblInfo2.Size = New System.Drawing.Size(133, 28)
        Me.LblInfo2.TabIndex = 4
        Me.LblInfo2.Text = "Posisi ke Kiri : "
        '
        'LblPesan2
        '
        Me.LblPesan2.AutoSize = True
        Me.LblPesan2.Location = New System.Drawing.Point(10, 93)
        Me.LblPesan2.Name = "LblPesan2"
        Me.LblPesan2.Size = New System.Drawing.Size(357, 28)
        Me.LblPesan2.TabIndex = 5
        Me.LblPesan2.Text = "Selamat Datang di Pemrograman Visual"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 28.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(379, 218)
        Me.Controls.Add(Me.LblPesan2)
        Me.Controls.Add(Me.LblInfo2)
        Me.Controls.Add(Me.LblInfo)
        Me.Controls.Add(Me.LblPesan)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents LblPesan As System.Windows.Forms.Label
    Friend WithEvents LblInfo As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents LblInfo2 As System.Windows.Forms.Label
    Friend WithEvents LblPesan2 As System.Windows.Forms.Label

End Class
