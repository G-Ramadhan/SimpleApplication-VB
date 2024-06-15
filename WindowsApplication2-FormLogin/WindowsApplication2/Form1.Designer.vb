<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLogin
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtPassword = New System.Windows.Forms.TextBox()
        Me.TxtUserName = New System.Windows.Forms.TextBox()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.BtnLogin = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Nirmala UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(240, 102)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 25)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "User Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Nirmala UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(240, 181)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 25)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Password"
        '
        'TxtPassword
        '
        Me.TxtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtPassword.Location = New System.Drawing.Point(358, 182)
        Me.TxtPassword.Name = "TxtPassword"
        Me.TxtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtPassword.Size = New System.Drawing.Size(223, 22)
        Me.TxtPassword.TabIndex = 5
        '
        'TxtUserName
        '
        Me.TxtUserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtUserName.Location = New System.Drawing.Point(358, 105)
        Me.TxtUserName.Name = "TxtUserName"
        Me.TxtUserName.Size = New System.Drawing.Size(223, 22)
        Me.TxtUserName.TabIndex = 4
        '
        'BtnCancel
        '
        Me.BtnCancel.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.BtnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCancel.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight
        Me.BtnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight
        Me.BtnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCancel.Image = Global.WindowsApplication2.My.Resources.Resources.stop1
        Me.BtnCancel.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnCancel.Location = New System.Drawing.Point(487, 250)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(79, 47)
        Me.BtnCancel.TabIndex = 7
        Me.BtnCancel.Text = "Cancel"
        Me.BtnCancel.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnCancel.UseVisualStyleBackColor = False
        '
        'BtnLogin
        '
        Me.BtnLogin.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.BtnLogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnLogin.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight
        Me.BtnLogin.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight
        Me.BtnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BtnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLogin.Image = Global.WindowsApplication2.My.Resources.Resources.unlock
        Me.BtnLogin.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnLogin.Location = New System.Drawing.Point(373, 250)
        Me.BtnLogin.Name = "BtnLogin"
        Me.BtnLogin.Size = New System.Drawing.Size(79, 47)
        Me.BtnLogin.TabIndex = 6
        Me.BtnLogin.Text = "Login"
        Me.BtnLogin.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnLogin.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = Global.WindowsApplication2.My.Resources.Resources.lock
        Me.PictureBox2.Location = New System.Drawing.Point(131, 191)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(76, 50)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.WindowsApplication2.My.Resources.Resources.group
        Me.PictureBox1.Location = New System.Drawing.Point(52, 96)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(128, 128)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'FormLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(634, 351)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.BtnLogin)
        Me.Controls.Add(Me.TxtPassword)
        Me.Controls.Add(Me.TxtUserName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "FormLogin"
        Me.Text = "Form Login Aplikasi"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtPassword As System.Windows.Forms.TextBox
    Friend WithEvents TxtUserName As System.Windows.Forms.TextBox
    Friend WithEvents BtnLogin As System.Windows.Forms.Button
    Friend WithEvents BtnCancel As System.Windows.Forms.Button

End Class
