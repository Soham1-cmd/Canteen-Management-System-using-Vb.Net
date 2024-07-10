<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formStockEntry
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
        Me.txtDesc = New System.Windows.Forms.TextBox()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.btn_up = New System.Windows.Forms.Button()
        Me.btn_del = New System.Windows.Forms.Button()
        Me.btn_clr = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.txtQty = New System.Windows.Forms.TextBox()
        Me.cbxitems = New System.Windows.Forms.ComboBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(48, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(176, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Select Items"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(48, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(124, 31)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Quantity"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(48, 143)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(162, 31)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Description"
        '
        'txtDesc
        '
        Me.txtDesc.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtDesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDesc.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDesc.Location = New System.Drawing.Point(240, 144)
        Me.txtDesc.Name = "txtDesc"
        Me.txtDesc.Size = New System.Drawing.Size(178, 35)
        Me.txtDesc.TabIndex = 5
        '
        'btn_save
        '
        Me.btn_save.BackgroundImage = Global.GUI_microproject.My.Resources.Resources.btn1
        Me.btn_save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_save.Location = New System.Drawing.Point(461, 50)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(126, 47)
        Me.btn_save.TabIndex = 6
        Me.btn_save.UseVisualStyleBackColor = True
        '
        'btn_up
        '
        Me.btn_up.BackgroundImage = Global.GUI_microproject.My.Resources.Resources.upd_btn
        Me.btn_up.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_up.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_up.Location = New System.Drawing.Point(610, 48)
        Me.btn_up.Name = "btn_up"
        Me.btn_up.Size = New System.Drawing.Size(122, 49)
        Me.btn_up.TabIndex = 7
        Me.btn_up.UseVisualStyleBackColor = True
        '
        'btn_del
        '
        Me.btn_del.BackgroundImage = Global.GUI_microproject.My.Resources.Resources.del_btn
        Me.btn_del.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_del.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_del.Location = New System.Drawing.Point(461, 125)
        Me.btn_del.Name = "btn_del"
        Me.btn_del.Size = New System.Drawing.Size(126, 53)
        Me.btn_del.TabIndex = 8
        Me.btn_del.UseVisualStyleBackColor = True
        '
        'btn_clr
        '
        Me.btn_clr.BackgroundImage = Global.GUI_microproject.My.Resources.Resources.reset_btn
        Me.btn_clr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_clr.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_clr.Location = New System.Drawing.Point(610, 125)
        Me.btn_clr.Name = "btn_clr"
        Me.btn_clr.Size = New System.Drawing.Size(122, 49)
        Me.btn_clr.TabIndex = 9
        Me.btn_clr.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.GridColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DataGridView1.Location = New System.Drawing.Point(52, 194)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(5)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(680, 215)
        Me.DataGridView1.TabIndex = 10
        '
        'txtQty
        '
        Me.txtQty.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtQty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtQty.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQty.Location = New System.Drawing.Point(240, 97)
        Me.txtQty.Name = "txtQty"
        Me.txtQty.Size = New System.Drawing.Size(178, 35)
        Me.txtQty.TabIndex = 12
        '
        'cbxitems
        '
        Me.cbxitems.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cbxitems.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbxitems.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxitems.FormattingEnabled = True
        Me.cbxitems.Location = New System.Drawing.Point(240, 46)
        Me.cbxitems.Name = "cbxitems"
        Me.cbxitems.Size = New System.Drawing.Size(178, 37)
        Me.cbxitems.TabIndex = 13
        '
        'formStockEntry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.GUI_microproject.My.Resources.Resources.can_back_f1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.cbxitems)
        Me.Controls.Add(Me.txtQty)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btn_clr)
        Me.Controls.Add(Me.btn_del)
        Me.Controls.Add(Me.btn_up)
        Me.Controls.Add(Me.btn_save)
        Me.Controls.Add(Me.txtDesc)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "formStockEntry"
        Me.Text = "formStockEntry"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtDesc As TextBox
    Friend WithEvents btn_save As Button
    Friend WithEvents btn_up As Button
    Friend WithEvents btn_del As Button
    Friend WithEvents btn_clr As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents txtQty As TextBox
    Friend WithEvents cbxitems As ComboBox
End Class
