<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTimeDate
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
        Me.Lbl12jam = New System.Windows.Forms.Label()
        Me.Lbl24jam = New System.Windows.Forms.Label()
        Me.DTtanggal = New System.Windows.Forms.DateTimePicker()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'Lbl12jam
        '
        Me.Lbl12jam.AutoSize = True
        Me.Lbl12jam.Location = New System.Drawing.Point(26, 46)
        Me.Lbl12jam.Name = "Lbl12jam"
        Me.Lbl12jam.Size = New System.Drawing.Size(67, 25)
        Me.Lbl12jam.TabIndex = 0
        Me.Lbl12jam.Text = "Label1"
        '
        'Lbl24jam
        '
        Me.Lbl24jam.AutoSize = True
        Me.Lbl24jam.Location = New System.Drawing.Point(26, 71)
        Me.Lbl24jam.Name = "Lbl24jam"
        Me.Lbl24jam.Size = New System.Drawing.Size(67, 25)
        Me.Lbl24jam.TabIndex = 1
        Me.Lbl24jam.Text = "Label1"
        '
        'DTtanggal
        '
        Me.DTtanggal.Location = New System.Drawing.Point(31, 99)
        Me.DTtanggal.Name = "DTtanggal"
        Me.DTtanggal.Size = New System.Drawing.Size(298, 31)
        Me.DTtanggal.TabIndex = 2
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'FrmTimeDate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(352, 162)
        Me.Controls.Add(Me.DTtanggal)
        Me.Controls.Add(Me.Lbl24jam)
        Me.Controls.Add(Me.Lbl12jam)
        Me.Font = New System.Drawing.Font("Nirmala UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "FrmTimeDate"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Time and Date Picker"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Lbl12jam As System.Windows.Forms.Label
    Friend WithEvents Lbl24jam As System.Windows.Forms.Label
    Friend WithEvents DTtanggal As System.Windows.Forms.DateTimePicker
    Friend WithEvents Timer1 As System.Windows.Forms.Timer

End Class
