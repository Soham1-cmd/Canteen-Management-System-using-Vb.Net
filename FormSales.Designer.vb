<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSales
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
        Me.txt_mob = New System.Windows.Forms.TextBox()
        Me.txt_name = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_date = New System.Windows.Forms.TextBox()
        Me.btnAddCart = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnminus = New System.Windows.Forms.Button()
        Me.btnSaveOrder = New System.Windows.Forms.Button()
        Me.btnPlus = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.cbxitems = New System.Windows.Forms.ComboBox()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.txtDueAmt = New System.Windows.Forms.TextBox()
        Me.txtCAmt = New System.Windows.Forms.TextBox()
        Me.txtRecAmt = New System.Windows.Forms.TextBox()
        Me.txtcost = New System.Windows.Forms.TextBox()
        Me.txtqty = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_mob
        '
        Me.txt_mob.Location = New System.Drawing.Point(245, 88)
        Me.txt_mob.Name = "txt_mob"
        Me.txt_mob.Size = New System.Drawing.Size(122, 20)
        Me.txt_mob.TabIndex = 0
        '
        'txt_name
        '
        Me.txt_name.Location = New System.Drawing.Point(87, 88)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(100, 20)
        Me.txt_name.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(105, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(278, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Mobile "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(453, 51)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 20)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Date"
        '
        'txt_date
        '
        Me.txt_date.Location = New System.Drawing.Point(419, 88)
        Me.txt_date.Name = "txt_date"
        Me.txt_date.Size = New System.Drawing.Size(122, 20)
        Me.txt_date.TabIndex = 6
        '
        'btnAddCart
        '
        Me.btnAddCart.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddCart.Location = New System.Drawing.Point(680, 51)
        Me.btnAddCart.Name = "btnAddCart"
        Me.btnAddCart.Size = New System.Drawing.Size(108, 57)
        Me.btnAddCart.TabIndex = 7
        Me.btnAddCart.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnminus)
        Me.Panel1.Controls.Add(Me.btnSaveOrder)
        Me.Panel1.Controls.Add(Me.btnPlus)
        Me.Panel1.Controls.Add(Me.DataGridView1)
        Me.Panel1.Controls.Add(Me.cbxitems)
        Me.Panel1.Controls.Add(Me.txtTotal)
        Me.Panel1.Controls.Add(Me.txtDueAmt)
        Me.Panel1.Controls.Add(Me.txtCAmt)
        Me.Panel1.Controls.Add(Me.txtRecAmt)
        Me.Panel1.Controls.Add(Me.txtcost)
        Me.Panel1.Controls.Add(Me.txtqty)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Location = New System.Drawing.Point(38, 135)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(905, 347)
        Me.Panel1.TabIndex = 8
        '
        'btnminus
        '
        Me.btnminus.Location = New System.Drawing.Point(532, 26)
        Me.btnminus.Name = "btnminus"
        Me.btnminus.Size = New System.Drawing.Size(60, 50)
        Me.btnminus.TabIndex = 18
        Me.btnminus.Text = "--"
        Me.btnminus.UseVisualStyleBackColor = True
        '
        'btnSaveOrder
        '
        Me.btnSaveOrder.Location = New System.Drawing.Point(620, 289)
        Me.btnSaveOrder.Name = "btnSaveOrder"
        Me.btnSaveOrder.Size = New System.Drawing.Size(93, 43)
        Me.btnSaveOrder.TabIndex = 17
        Me.btnSaveOrder.Text = "SAVE ORDER"
        Me.btnSaveOrder.UseVisualStyleBackColor = True
        '
        'btnPlus
        '
        Me.btnPlus.Location = New System.Drawing.Point(450, 26)
        Me.btnPlus.Name = "btnPlus"
        Me.btnPlus.Size = New System.Drawing.Size(53, 50)
        Me.btnPlus.TabIndex = 15
        Me.btnPlus.Text = "+"
        Me.btnPlus.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(34, 96)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(716, 178)
        Me.DataGridView1.TabIndex = 14
        '
        'cbxitems
        '
        Me.cbxitems.FormattingEnabled = True
        Me.cbxitems.Location = New System.Drawing.Point(14, 56)
        Me.cbxitems.Name = "cbxitems"
        Me.cbxitems.Size = New System.Drawing.Size(121, 21)
        Me.cbxitems.TabIndex = 13
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(463, 312)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(100, 20)
        Me.txtTotal.TabIndex = 12
        '
        'txtDueAmt
        '
        Me.txtDueAmt.Location = New System.Drawing.Point(185, 312)
        Me.txtDueAmt.Name = "txtDueAmt"
        Me.txtDueAmt.Size = New System.Drawing.Size(100, 20)
        Me.txtDueAmt.TabIndex = 11
        '
        'txtCAmt
        '
        Me.txtCAmt.Location = New System.Drawing.Point(327, 312)
        Me.txtCAmt.Name = "txtCAmt"
        Me.txtCAmt.Size = New System.Drawing.Size(100, 20)
        Me.txtCAmt.TabIndex = 10
        '
        'txtRecAmt
        '
        Me.txtRecAmt.Location = New System.Drawing.Point(46, 312)
        Me.txtRecAmt.Name = "txtRecAmt"
        Me.txtRecAmt.Size = New System.Drawing.Size(100, 20)
        Me.txtRecAmt.TabIndex = 9
        '
        'txtcost
        '
        Me.txtcost.Location = New System.Drawing.Point(314, 56)
        Me.txtcost.Name = "txtcost"
        Me.txtcost.Size = New System.Drawing.Size(100, 20)
        Me.txtcost.TabIndex = 8
        '
        'txtqty
        '
        Me.txtqty.Location = New System.Drawing.Point(174, 59)
        Me.txtqty.Name = "txtqty"
        Me.txtqty.Size = New System.Drawing.Size(100, 20)
        Me.txtqty.TabIndex = 7
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(486, 286)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(42, 13)
        Me.Label10.TabIndex = 6
        Me.Label10.Text = "TOTAL"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(324, 286)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(105, 13)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "CHANGE AMOUNT "
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(192, 286)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(80, 13)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "DUE AMOUNT"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(43, 286)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(106, 13)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "RECEIVE AMOUNT "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(345, 17)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(36, 13)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "COST"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(192, 17)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "QUANTITY"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(46, 17)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "ITEMS"
        '
        'FormSales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1005, 510)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnAddCart)
        Me.Controls.Add(Me.txt_date)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_name)
        Me.Controls.Add(Me.txt_mob)
        Me.Name = "FormSales"
        Me.Text = "FormSales"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_mob As TextBox
    Friend WithEvents txt_name As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_date As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnSaveOrder As Button
    Friend WithEvents btnAddCart As Button
    Friend WithEvents btnPlus As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents cbxitems As ComboBox
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents txtDueAmt As TextBox
    Friend WithEvents txtCAmt As TextBox
    Friend WithEvents txtRecAmt As TextBox
    Friend WithEvents txtcost As TextBox
    Friend WithEvents txtqty As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnminus As Button
End Class
