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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.username_tbx = New System.Windows.Forms.TextBox()
        Me.url_cbx = New System.Windows.Forms.ComboBox()
        Me.login_btn = New System.Windows.Forms.Button()
        Me.exit_btn = New System.Windows.Forms.Button()
        Me.pass_tbx = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(728, 100)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(41, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(639, 39)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "CANTEEEN MANAGEMENT SYSTEM"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(87, 103)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(220, 31)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Enter username"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(90, 158)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(217, 31)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Enter password"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(90, 215)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(144, 31)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "User Role"
        '
        'username_tbx
        '
        Me.username_tbx.BackColor = System.Drawing.Color.WhiteSmoke
        Me.username_tbx.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.username_tbx.Location = New System.Drawing.Point(376, 95)
        Me.username_tbx.Multiline = True
        Me.username_tbx.Name = "username_tbx"
        Me.username_tbx.Size = New System.Drawing.Size(221, 39)
        Me.username_tbx.TabIndex = 5
        '
        'url_cbx
        '
        Me.url_cbx.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.url_cbx.FormattingEnabled = True
        Me.url_cbx.Items.AddRange(New Object() {"Student", "Admin", "Canteen Manager"})
        Me.url_cbx.Location = New System.Drawing.Point(376, 215)
        Me.url_cbx.Margin = New System.Windows.Forms.Padding(3, 6, 3, 3)
        Me.url_cbx.Name = "url_cbx"
        Me.url_cbx.Size = New System.Drawing.Size(221, 37)
        Me.url_cbx.TabIndex = 7
        '
        'login_btn
        '
        Me.login_btn.BackColor = System.Drawing.Color.Transparent
        Me.login_btn.BackgroundImage = Global.GUI_microproject.My.Resources.Resources.backbu3
        Me.login_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.login_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.login_btn.Location = New System.Drawing.Point(191, 310)
        Me.login_btn.Name = "login_btn"
        Me.login_btn.Size = New System.Drawing.Size(116, 51)
        Me.login_btn.TabIndex = 8
        Me.login_btn.Text = "LOGIN"
        Me.login_btn.UseVisualStyleBackColor = False
        '
        'exit_btn
        '
        Me.exit_btn.BackColor = System.Drawing.Color.Transparent
        Me.exit_btn.BackgroundImage = Global.GUI_microproject.My.Resources.Resources.backbut1
        Me.exit_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.exit_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.exit_btn.Location = New System.Drawing.Point(376, 310)
        Me.exit_btn.Name = "exit_btn"
        Me.exit_btn.Size = New System.Drawing.Size(100, 51)
        Me.exit_btn.TabIndex = 9
        Me.exit_btn.Text = "EXIT"
        Me.exit_btn.UseVisualStyleBackColor = False
        '
        'pass_tbx
        '
        Me.pass_tbx.BackColor = System.Drawing.Color.WhiteSmoke
        Me.pass_tbx.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pass_tbx.Location = New System.Drawing.Point(376, 158)
        Me.pass_tbx.Multiline = True
        Me.pass_tbx.Name = "pass_tbx"
        Me.pass_tbx.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.pass_tbx.Size = New System.Drawing.Size(221, 40)
        Me.pass_tbx.TabIndex = 10
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.BackgroundImage = Global.GUI_microproject.My.Resources.Resources.back1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(728, 426)
        Me.Controls.Add(Me.pass_tbx)
        Me.Controls.Add(Me.exit_btn)
        Me.Controls.Add(Me.login_btn)
        Me.Controls.Add(Me.url_cbx)
        Me.Controls.Add(Me.username_tbx)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.DoubleBuffered = True
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login Form"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents username_tbx As TextBox
    Friend WithEvents url_cbx As ComboBox
    Friend WithEvents login_btn As Button
    Friend WithEvents exit_btn As Button
    Friend WithEvents pass_tbx As TextBox
End Class
