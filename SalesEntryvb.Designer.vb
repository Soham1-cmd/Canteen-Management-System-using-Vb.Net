<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SalesEntry1
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtQty = New System.Windows.Forms.TextBox()
        Me.txtCost = New System.Windows.Forms.TextBox()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.txtChAmt = New System.Windows.Forms.TextBox()
        Me.txtDueAmt = New System.Windows.Forms.TextBox()
        Me.txtRecAmt = New System.Windows.Forms.TextBox()
        Me.btnAddtoCart = New System.Windows.Forms.Button()
        Me.btnPlus = New System.Windows.Forms.Button()
        Me.btnMinus = New System.Windows.Forms.Button()
        Me.btnSaveOrder = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cbxItems = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtMob = New System.Windows.Forms.TextBox()
        Me.txtDate = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(54, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "NAME"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(49, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 31)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "ITEMS"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(265, 12)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 31)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "QTY"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(434, 13)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(94, 31)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "COST"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(19, 316)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(162, 31)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "RECEIVED"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(218, 317)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 31)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "DUE"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(344, 317)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(137, 31)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "CHANGE"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(514, 317)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(107, 31)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "TOTAL"
        '
        'txtQty
        '
        Me.txtQty.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtQty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtQty.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQty.Location = New System.Drawing.Point(245, 54)
        Me.txtQty.Name = "txtQty"
        Me.txtQty.Size = New System.Drawing.Size(125, 35)
        Me.txtQty.TabIndex = 8
        '
        'txtCost
        '
        Me.txtCost.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCost.Location = New System.Drawing.Point(419, 55)
        Me.txtCost.Name = "txtCost"
        Me.txtCost.Size = New System.Drawing.Size(133, 35)
        Me.txtCost.TabIndex = 9
        '
        'txtTotal
        '
        Me.txtTotal.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.Location = New System.Drawing.Point(496, 351)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(147, 35)
        Me.txtTotal.TabIndex = 10
        '
        'txtChAmt
        '
        Me.txtChAmt.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtChAmt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtChAmt.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtChAmt.Location = New System.Drawing.Point(341, 351)
        Me.txtChAmt.Name = "txtChAmt"
        Me.txtChAmt.Size = New System.Drawing.Size(140, 35)
        Me.txtChAmt.TabIndex = 11
        '
        'txtDueAmt
        '
        Me.txtDueAmt.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtDueAmt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDueAmt.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDueAmt.Location = New System.Drawing.Point(196, 350)
        Me.txtDueAmt.Name = "txtDueAmt"
        Me.txtDueAmt.Size = New System.Drawing.Size(129, 35)
        Me.txtDueAmt.TabIndex = 12
        '
        'txtRecAmt
        '
        Me.txtRecAmt.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtRecAmt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRecAmt.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRecAmt.Location = New System.Drawing.Point(26, 350)
        Me.txtRecAmt.Name = "txtRecAmt"
        Me.txtRecAmt.Size = New System.Drawing.Size(147, 35)
        Me.txtRecAmt.TabIndex = 13
        '
        'btnAddtoCart
        '
        Me.btnAddtoCart.BackgroundImage = Global.GUI_microproject.My.Resources.Resources._2
        Me.btnAddtoCart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAddtoCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddtoCart.Location = New System.Drawing.Point(632, 23)
        Me.btnAddtoCart.Name = "btnAddtoCart"
        Me.btnAddtoCart.Size = New System.Drawing.Size(150, 67)
        Me.btnAddtoCart.TabIndex = 15
        Me.btnAddtoCart.UseVisualStyleBackColor = True
        '
        'btnPlus
        '
        Me.btnPlus.BackgroundImage = Global.GUI_microproject.My.Resources.Resources.add
        Me.btnPlus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPlus.Location = New System.Drawing.Point(594, 11)
        Me.btnPlus.Name = "btnPlus"
        Me.btnPlus.Size = New System.Drawing.Size(83, 78)
        Me.btnPlus.TabIndex = 16
        Me.btnPlus.UseVisualStyleBackColor = True
        '
        'btnMinus
        '
        Me.btnMinus.BackgroundImage = Global.GUI_microproject.My.Resources.Resources.m1
        Me.btnMinus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMinus.Location = New System.Drawing.Point(714, 11)
        Me.btnMinus.Name = "btnMinus"
        Me.btnMinus.Size = New System.Drawing.Size(84, 78)
        Me.btnMinus.TabIndex = 17
        Me.btnMinus.UseVisualStyleBackColor = True
        '
        'btnSaveOrder
        '
        Me.btnSaveOrder.BackgroundImage = Global.GUI_microproject.My.Resources.Resources.btn1
        Me.btnSaveOrder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSaveOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSaveOrder.Location = New System.Drawing.Point(656, 335)
        Me.btnSaveOrder.Name = "btnSaveOrder"
        Me.btnSaveOrder.Size = New System.Drawing.Size(133, 50)
        Me.btnSaveOrder.TabIndex = 18
        Me.btnSaveOrder.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(76, 97)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(722, 210)
        Me.DataGridView1.TabIndex = 19
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.cbxItems)
        Me.Panel1.Controls.Add(Me.DataGridView1)
        Me.Panel1.Controls.Add(Me.btnMinus)
        Me.Panel1.Controls.Add(Me.btnSaveOrder)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.btnPlus)
        Me.Panel1.Controls.Add(Me.txtRecAmt)
        Me.Panel1.Controls.Add(Me.txtDueAmt)
        Me.Panel1.Controls.Add(Me.txtChAmt)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.txtQty)
        Me.Panel1.Controls.Add(Me.txtCost)
        Me.Panel1.Controls.Add(Me.txtTotal)
        Me.Panel1.Location = New System.Drawing.Point(23, 107)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(817, 430)
        Me.Panel1.TabIndex = 20
        Me.Panel1.Visible = False
        '
        'cbxItems
        '
        Me.cbxItems.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cbxItems.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.cbxItems.FormattingEnabled = True
        Me.cbxItems.Location = New System.Drawing.Point(14, 54)
        Me.cbxItems.Name = "cbxItems"
        Me.cbxItems.Size = New System.Drawing.Size(180, 33)
        Me.cbxItems.TabIndex = 26
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(218, 18)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(122, 31)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "MOBILE"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(389, 20)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(91, 31)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "DATE"
        '
        'txtName
        '
        Me.txtName.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(23, 55)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(147, 35)
        Me.txtName.TabIndex = 23
        '
        'txtMob
        '
        Me.txtMob.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtMob.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMob.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMob.Location = New System.Drawing.Point(202, 55)
        Me.txtMob.Name = "txtMob"
        Me.txtMob.Size = New System.Drawing.Size(147, 35)
        Me.txtMob.TabIndex = 24
        '
        'txtDate
        '
        Me.txtDate.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDate.Location = New System.Drawing.Point(365, 55)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Size = New System.Drawing.Size(147, 35)
        Me.txtDate.TabIndex = 25
        '
        'SalesEntry1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.GUI_microproject.My.Resources.Resources.can_back_f1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(871, 513)
        Me.Controls.Add(Me.txtDate)
        Me.Controls.Add(Me.txtMob)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnAddtoCart)
        Me.Controls.Add(Me.Label1)
        Me.Name = "SalesEntry1"
        Me.Text = "SalesEntryvb"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtQty As TextBox
    Friend WithEvents txtCost As TextBox
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents txtChAmt As TextBox
    Friend WithEvents txtDueAmt As TextBox
    Friend WithEvents txtRecAmt As TextBox
    Friend WithEvents btnAddtoCart As Button
    Friend WithEvents btnPlus As Button
    Friend WithEvents btnMinus As Button
    Friend WithEvents btnSaveOrder As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents cbxItems As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtMob As TextBox
    Friend WithEvents txtDate As TextBox
End Class
