<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddEmp4
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
        Me.search_txt = New System.Windows.Forms.TextBox()
        Me.des_cbx = New System.Windows.Forms.ComboBox()
        Me.srh_btn = New System.Windows.Forms.Button()
        Me.clr_btn = New System.Windows.Forms.Button()
        Me.upt_btn = New System.Windows.Forms.Button()
        Me.delete_btn = New System.Windows.Forms.Button()
        Me.save_btn = New System.Windows.Forms.Button()
        Me.coun_txt = New System.Windows.Forms.TextBox()
        Me.state_txt = New System.Windows.Forms.TextBox()
        Me.dob_txt = New System.Windows.Forms.TextBox()
        Me.mbl_txt = New System.Windows.Forms.TextBox()
        Me.pin_txt = New System.Windows.Forms.TextBox()
        Me.city_txt = New System.Windows.Forms.TextBox()
        Me.add_txt = New System.Windows.Forms.TextBox()
        Me.mail_txt = New System.Windows.Forms.TextBox()
        Me.sal_txt = New System.Windows.Forms.TextBox()
        Me.emp_txt = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.EmpId = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'search_txt
        '
        Me.search_txt.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.search_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.search_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.search_txt.Location = New System.Drawing.Point(142, 299)
        Me.search_txt.Name = "search_txt"
        Me.search_txt.Size = New System.Drawing.Size(686, 35)
        Me.search_txt.TabIndex = 58
        '
        'des_cbx
        '
        Me.des_cbx.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.des_cbx.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.des_cbx.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.des_cbx.FormattingEnabled = True
        Me.des_cbx.Location = New System.Drawing.Point(646, 50)
        Me.des_cbx.Name = "des_cbx"
        Me.des_cbx.Size = New System.Drawing.Size(182, 37)
        Me.des_cbx.TabIndex = 57
        '
        'srh_btn
        '
        Me.srh_btn.BackgroundImage = Global.GUI_microproject.My.Resources.Resources.search_btn
        Me.srh_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.srh_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.srh_btn.Location = New System.Drawing.Point(878, 287)
        Me.srh_btn.Name = "srh_btn"
        Me.srh_btn.Size = New System.Drawing.Size(139, 43)
        Me.srh_btn.TabIndex = 56
        Me.srh_btn.UseVisualStyleBackColor = True
        '
        'clr_btn
        '
        Me.clr_btn.BackgroundImage = Global.GUI_microproject.My.Resources.Resources.reset_btn
        Me.clr_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.clr_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.clr_btn.Location = New System.Drawing.Point(878, 218)
        Me.clr_btn.Name = "clr_btn"
        Me.clr_btn.Size = New System.Drawing.Size(139, 49)
        Me.clr_btn.TabIndex = 55
        Me.clr_btn.UseVisualStyleBackColor = True
        '
        'upt_btn
        '
        Me.upt_btn.BackgroundImage = Global.GUI_microproject.My.Resources.Resources.upd_btn
        Me.upt_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.upt_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.upt_btn.Location = New System.Drawing.Point(874, 154)
        Me.upt_btn.Name = "upt_btn"
        Me.upt_btn.Size = New System.Drawing.Size(143, 42)
        Me.upt_btn.TabIndex = 54
        Me.upt_btn.UseVisualStyleBackColor = True
        '
        'delete_btn
        '
        Me.delete_btn.BackgroundImage = Global.GUI_microproject.My.Resources.Resources.del_btn
        Me.delete_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.delete_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.delete_btn.Location = New System.Drawing.Point(878, 88)
        Me.delete_btn.Name = "delete_btn"
        Me.delete_btn.Size = New System.Drawing.Size(139, 44)
        Me.delete_btn.TabIndex = 53
        Me.delete_btn.UseVisualStyleBackColor = True
        '
        'save_btn
        '
        Me.save_btn.BackgroundImage = Global.GUI_microproject.My.Resources.Resources.btn1
        Me.save_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.save_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.save_btn.Location = New System.Drawing.Point(878, 26)
        Me.save_btn.Name = "save_btn"
        Me.save_btn.Size = New System.Drawing.Size(139, 44)
        Me.save_btn.TabIndex = 52
        Me.save_btn.UseVisualStyleBackColor = True
        '
        'coun_txt
        '
        Me.coun_txt.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.coun_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.coun_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.coun_txt.Location = New System.Drawing.Point(646, 258)
        Me.coun_txt.Name = "coun_txt"
        Me.coun_txt.Size = New System.Drawing.Size(182, 35)
        Me.coun_txt.TabIndex = 51
        '
        'state_txt
        '
        Me.state_txt.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.state_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.state_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.state_txt.Location = New System.Drawing.Point(646, 217)
        Me.state_txt.Name = "state_txt"
        Me.state_txt.Size = New System.Drawing.Size(182, 35)
        Me.state_txt.TabIndex = 50
        '
        'dob_txt
        '
        Me.dob_txt.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dob_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dob_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dob_txt.Location = New System.Drawing.Point(646, 135)
        Me.dob_txt.Name = "dob_txt"
        Me.dob_txt.Size = New System.Drawing.Size(182, 35)
        Me.dob_txt.TabIndex = 49
        '
        'mbl_txt
        '
        Me.mbl_txt.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.mbl_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.mbl_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mbl_txt.Location = New System.Drawing.Point(646, 94)
        Me.mbl_txt.Name = "mbl_txt"
        Me.mbl_txt.Size = New System.Drawing.Size(182, 35)
        Me.mbl_txt.TabIndex = 48
        '
        'pin_txt
        '
        Me.pin_txt.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.pin_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pin_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pin_txt.Location = New System.Drawing.Point(254, 263)
        Me.pin_txt.Name = "pin_txt"
        Me.pin_txt.Size = New System.Drawing.Size(169, 35)
        Me.pin_txt.TabIndex = 47
        '
        'city_txt
        '
        Me.city_txt.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.city_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.city_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.city_txt.Location = New System.Drawing.Point(254, 222)
        Me.city_txt.Name = "city_txt"
        Me.city_txt.Size = New System.Drawing.Size(169, 35)
        Me.city_txt.TabIndex = 46
        '
        'add_txt
        '
        Me.add_txt.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.add_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.add_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.add_txt.Location = New System.Drawing.Point(254, 139)
        Me.add_txt.Name = "add_txt"
        Me.add_txt.Size = New System.Drawing.Size(169, 35)
        Me.add_txt.TabIndex = 45
        '
        'mail_txt
        '
        Me.mail_txt.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.mail_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.mail_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mail_txt.Location = New System.Drawing.Point(254, 181)
        Me.mail_txt.Name = "mail_txt"
        Me.mail_txt.Size = New System.Drawing.Size(574, 35)
        Me.mail_txt.TabIndex = 44
        '
        'sal_txt
        '
        Me.sal_txt.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.sal_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.sal_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sal_txt.Location = New System.Drawing.Point(254, 97)
        Me.sal_txt.Name = "sal_txt"
        Me.sal_txt.Size = New System.Drawing.Size(169, 35)
        Me.sal_txt.TabIndex = 43
        '
        'emp_txt
        '
        Me.emp_txt.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.emp_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.emp_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.emp_txt.Location = New System.Drawing.Point(254, 52)
        Me.emp_txt.Name = "emp_txt"
        Me.emp_txt.Size = New System.Drawing.Size(169, 35)
        Me.emp_txt.TabIndex = 42
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(457, 262)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(117, 31)
        Me.Label13.TabIndex = 41
        Me.Label13.Text = "Country"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(457, 217)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(83, 31)
        Me.Label11.TabIndex = 40
        Me.Label11.Text = "State"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(457, 139)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(76, 31)
        Me.Label10.TabIndex = 39
        Me.Label10.Text = "DOB"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(445, 97)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(145, 31)
        Me.Label9.TabIndex = 38
        Me.Label9.Text = "Mobile.No"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(445, 52)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(169, 31)
        Me.Label8.TabIndex = 37
        Me.Label8.Text = "Designation"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(22, 263)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(123, 31)
        Me.Label7.TabIndex = 36
        Me.Label7.Text = "PIN NO."
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(22, 224)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 31)
        Me.Label6.TabIndex = 35
        Me.Label6.Text = "City "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(22, 139)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(192, 31)
        Me.Label5.TabIndex = 34
        Me.Label5.Text = "Address Line "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(22, 184)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 31)
        Me.Label4.TabIndex = 33
        Me.Label4.Text = "Email"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(22, 98)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 31)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "Salary"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(22, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(226, 31)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "Employee Name"
        '
        'EmpId
        '
        Me.EmpId.AutoSize = True
        Me.EmpId.BackColor = System.Drawing.Color.Transparent
        Me.EmpId.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmpId.Location = New System.Drawing.Point(22, 18)
        Me.EmpId.Name = "EmpId"
        Me.EmpId.Size = New System.Drawing.Size(180, 31)
        Me.EmpId.TabIndex = 30
        Me.EmpId.Text = "Employee ID"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.GridColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DataGridView1.Location = New System.Drawing.Point(62, 354)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(955, 151)
        Me.DataGridView1.TabIndex = 59
        '
        'AddEmp4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.GUI_microproject.My.Resources.Resources.can_back_f1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1089, 513)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.search_txt)
        Me.Controls.Add(Me.des_cbx)
        Me.Controls.Add(Me.srh_btn)
        Me.Controls.Add(Me.clr_btn)
        Me.Controls.Add(Me.upt_btn)
        Me.Controls.Add(Me.delete_btn)
        Me.Controls.Add(Me.save_btn)
        Me.Controls.Add(Me.coun_txt)
        Me.Controls.Add(Me.state_txt)
        Me.Controls.Add(Me.dob_txt)
        Me.Controls.Add(Me.mbl_txt)
        Me.Controls.Add(Me.pin_txt)
        Me.Controls.Add(Me.city_txt)
        Me.Controls.Add(Me.add_txt)
        Me.Controls.Add(Me.mail_txt)
        Me.Controls.Add(Me.sal_txt)
        Me.Controls.Add(Me.emp_txt)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.EmpId)
        Me.Name = "AddEmp4"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AddEmp4"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents search_txt As TextBox
    Friend WithEvents des_cbx As ComboBox
    Friend WithEvents srh_btn As Button
    Friend WithEvents clr_btn As Button
    Friend WithEvents upt_btn As Button
    Friend WithEvents delete_btn As Button
    Friend WithEvents save_btn As Button
    Friend WithEvents coun_txt As TextBox
    Friend WithEvents state_txt As TextBox
    Friend WithEvents dob_txt As TextBox
    Friend WithEvents mbl_txt As TextBox
    Friend WithEvents pin_txt As TextBox
    Friend WithEvents city_txt As TextBox
    Friend WithEvents add_txt As TextBox
    Friend WithEvents mail_txt As TextBox
    Friend WithEvents sal_txt As TextBox
    Friend WithEvents emp_txt As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents EmpId As Label
    Friend WithEvents DataGridView1 As DataGridView
End Class
