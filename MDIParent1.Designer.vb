<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MDIParent1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.MasterEntryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmployeeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddEmployeeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ItemManagementToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddItemsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StockManagementToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddStockToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalesManagementToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalesFormToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangePasswordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.BackColor = System.Drawing.Color.PaleGreen
        Me.MenuStrip.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MasterEntryToolStripMenuItem, Me.EmployeeToolStripMenuItem, Me.ItemManagementToolStripMenuItem, Me.StockManagementToolStripMenuItem, Me.SalesManagementToolStripMenuItem, Me.ChangePasswordToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(1350, 29)
        Me.MenuStrip.TabIndex = 5
        Me.MenuStrip.Text = "MenuStrip"
        '
        'MasterEntryToolStripMenuItem
        '
        Me.MasterEntryToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AAToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.MasterEntryToolStripMenuItem.Name = "MasterEntryToolStripMenuItem"
        Me.MasterEntryToolStripMenuItem.Size = New System.Drawing.Size(114, 25)
        Me.MasterEntryToolStripMenuItem.Text = "Master Entry "
        '
        'AAToolStripMenuItem
        '
        Me.AAToolStripMenuItem.Name = "AAToolStripMenuItem"
        Me.AAToolStripMenuItem.Size = New System.Drawing.Size(195, 26)
        Me.AAToolStripMenuItem.Text = "Add Designation"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(195, 26)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'EmployeeToolStripMenuItem
        '
        Me.EmployeeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddEmployeeToolStripMenuItem})
        Me.EmployeeToolStripMenuItem.Name = "EmployeeToolStripMenuItem"
        Me.EmployeeToolStripMenuItem.Size = New System.Drawing.Size(90, 25)
        Me.EmployeeToolStripMenuItem.Text = "Employee"
        '
        'AddEmployeeToolStripMenuItem
        '
        Me.AddEmployeeToolStripMenuItem.Name = "AddEmployeeToolStripMenuItem"
        Me.AddEmployeeToolStripMenuItem.Size = New System.Drawing.Size(180, 26)
        Me.AddEmployeeToolStripMenuItem.Text = "Add Employee"
        '
        'ItemManagementToolStripMenuItem
        '
        Me.ItemManagementToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddItemsToolStripMenuItem})
        Me.ItemManagementToolStripMenuItem.Name = "ItemManagementToolStripMenuItem"
        Me.ItemManagementToolStripMenuItem.Size = New System.Drawing.Size(153, 25)
        Me.ItemManagementToolStripMenuItem.Text = "Item Management "
        '
        'AddItemsToolStripMenuItem
        '
        Me.AddItemsToolStripMenuItem.Name = "AddItemsToolStripMenuItem"
        Me.AddItemsToolStripMenuItem.Size = New System.Drawing.Size(150, 26)
        Me.AddItemsToolStripMenuItem.Text = "Add items"
        '
        'StockManagementToolStripMenuItem
        '
        Me.StockManagementToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddStockToolStripMenuItem})
        Me.StockManagementToolStripMenuItem.Name = "StockManagementToolStripMenuItem"
        Me.StockManagementToolStripMenuItem.Size = New System.Drawing.Size(159, 25)
        Me.StockManagementToolStripMenuItem.Text = "Stock Management "
        '
        'AddStockToolStripMenuItem
        '
        Me.AddStockToolStripMenuItem.Name = "AddStockToolStripMenuItem"
        Me.AddStockToolStripMenuItem.Size = New System.Drawing.Size(149, 26)
        Me.AddStockToolStripMenuItem.Text = "Add Stock"
        '
        'SalesManagementToolStripMenuItem
        '
        Me.SalesManagementToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SalesFormToolStripMenuItem})
        Me.SalesManagementToolStripMenuItem.Name = "SalesManagementToolStripMenuItem"
        Me.SalesManagementToolStripMenuItem.Size = New System.Drawing.Size(158, 25)
        Me.SalesManagementToolStripMenuItem.Text = "Sales Management "
        '
        'SalesFormToolStripMenuItem
        '
        Me.SalesFormToolStripMenuItem.Name = "SalesFormToolStripMenuItem"
        Me.SalesFormToolStripMenuItem.Size = New System.Drawing.Size(161, 26)
        Me.SalesFormToolStripMenuItem.Text = "Sales Form "
        '
        'ChangePasswordToolStripMenuItem
        '
        Me.ChangePasswordToolStripMenuItem.Name = "ChangePasswordToolStripMenuItem"
        Me.ChangePasswordToolStripMenuItem.Size = New System.Drawing.Size(145, 25)
        Me.ChangePasswordToolStripMenuItem.Text = "Change Password"
        '
        'Panel1
        '
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Location = New System.Drawing.Point(0, 32)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1376, 717)
        Me.Panel1.TabIndex = 11
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Cyan
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1373, 696)
        Me.Panel2.TabIndex = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.GUI_microproject.My.Resources.Resources.wel_come
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(451, -77)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(420, 243)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!)
        Me.Label2.Location = New System.Drawing.Point(334, 282)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(649, 39)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "THE CANTEEN MANGEMENT SYSTEM "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Cyan
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!)
        Me.Label1.Location = New System.Drawing.Point(541, 227)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(258, 39)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "WELCOME TO "
        '
        'MDIParent1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1350, 691)
        Me.Controls.Add(Me.MenuStrip)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "MDIParent1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Main Menu"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents MasterEntryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EmployeeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddEmployeeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AAToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ItemManagementToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StockManagementToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalesManagementToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ChangePasswordToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddItemsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddStockToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalesFormToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
