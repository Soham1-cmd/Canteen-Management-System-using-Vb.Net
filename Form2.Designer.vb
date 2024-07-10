<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChangePass
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BTN_CLOSE = New System.Windows.Forms.Button()
        Me.BTN_CHANGE = New System.Windows.Forms.Button()
        Me.txt_ConfirmPass = New System.Windows.Forms.TextBox()
        Me.txt_NewPass = New System.Windows.Forms.TextBox()
        Me.txt_oldPass = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.BTN_CLOSE)
        Me.Panel1.Controls.Add(Me.BTN_CHANGE)
        Me.Panel1.Controls.Add(Me.txt_ConfirmPass)
        Me.Panel1.Controls.Add(Me.txt_NewPass)
        Me.Panel1.Controls.Add(Me.txt_oldPass)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(169, 48)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(542, 408)
        Me.Panel1.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Millimeter, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Navy
        Me.Label4.Location = New System.Drawing.Point(125, 68)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(308, 44)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Reset Password"
        '
        'BTN_CLOSE
        '
        Me.BTN_CLOSE.BackColor = System.Drawing.Color.White
        Me.BTN_CLOSE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_CLOSE.ForeColor = System.Drawing.Color.Blue
        Me.BTN_CLOSE.Location = New System.Drawing.Point(301, 337)
        Me.BTN_CLOSE.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BTN_CLOSE.Name = "BTN_CLOSE"
        Me.BTN_CLOSE.Size = New System.Drawing.Size(112, 35)
        Me.BTN_CLOSE.TabIndex = 15
        Me.BTN_CLOSE.Text = "CANCEL"
        Me.BTN_CLOSE.UseVisualStyleBackColor = False
        '
        'BTN_CHANGE
        '
        Me.BTN_CHANGE.BackColor = System.Drawing.Color.Blue
        Me.BTN_CHANGE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_CHANGE.ForeColor = System.Drawing.Color.White
        Me.BTN_CHANGE.Location = New System.Drawing.Point(94, 337)
        Me.BTN_CHANGE.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BTN_CHANGE.Name = "BTN_CHANGE"
        Me.BTN_CHANGE.Size = New System.Drawing.Size(155, 35)
        Me.BTN_CHANGE.TabIndex = 14
        Me.BTN_CHANGE.Text = "CONTINUE"
        Me.BTN_CHANGE.UseVisualStyleBackColor = False
        '
        'txt_ConfirmPass
        '
        Me.txt_ConfirmPass.Location = New System.Drawing.Point(199, 297)
        Me.txt_ConfirmPass.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_ConfirmPass.Name = "txt_ConfirmPass"
        Me.txt_ConfirmPass.Size = New System.Drawing.Size(148, 26)
        Me.txt_ConfirmPass.TabIndex = 13
        '
        'txt_NewPass
        '
        Me.txt_NewPass.Location = New System.Drawing.Point(199, 222)
        Me.txt_NewPass.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_NewPass.Name = "txt_NewPass"
        Me.txt_NewPass.Size = New System.Drawing.Size(148, 26)
        Me.txt_NewPass.TabIndex = 12
        '
        'txt_oldPass
        '
        Me.txt_oldPass.Location = New System.Drawing.Point(201, 154)
        Me.txt_oldPass.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_oldPass.Name = "txt_oldPass"
        Me.txt_oldPass.Size = New System.Drawing.Size(148, 26)
        Me.txt_oldPass.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Blue
        Me.Label3.Location = New System.Drawing.Point(161, 263)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(242, 20)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "CONFIRM NEW PASSWORD"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(171, 188)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(220, 20)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "ENTER NEW PASSWORD"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(171, 118)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(216, 20)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "ENTER OLD PASSWORD"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.GUI_microproject.My.Resources.Resources.pass1
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(385, -1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(131, 114)
        Me.PictureBox1.TabIndex = 18
        Me.PictureBox1.TabStop = False
        '
        'ChangePass
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(873, 478)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.Name = "ChangePass"
        Me.Text = "FormChangePass"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents BTN_CLOSE As Button
    Friend WithEvents BTN_CHANGE As Button
    Friend WithEvents txt_ConfirmPass As TextBox
    Friend WithEvents txt_NewPass As TextBox
    Friend WithEvents txt_oldPass As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
