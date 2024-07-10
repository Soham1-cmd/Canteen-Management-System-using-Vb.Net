Imports System.Data.SqlClient
Imports System.Security.Cryptography

Public Class SalesEntry1
    Dim cost As Decimal = 0
    Dim MAXID As String = ""
    Dim qty As Integer = 0
    Dim final_qty As Integer = 0
    Dim totalPrice As Decimal = 0

    Private Sub SalesEntryvb_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtDate.Text = Date.Today
    End Sub

    Private Sub btnAddtoCart_Click(sender As Object, e As EventArgs) Handles btnAddtoCart.Click
        If txtName.Text = "" Then
            MessageBox.Show("Please enter customer name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtName.Focus()
            Exit Sub
        End If

        If txtMob.Text.Trim = "" Then
            MessageBox.Show("Please enter customer mobile number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtMob.Focus()
            Exit Sub
        End If

        Dim customerName As String = txtName.Text
        Dim mobile As String = txtMob.Text

        Dim queryString As String = "INSERT INTO TableSalesMaster(Customer, Mobile, Date) VALUES (@Customer, @Mobile, @Date)"

        Try
            Using connection As New SqlConnection("Data Source=DESKTOP-S098J7U\SQLEXPRESS;Initial Catalog=Gui_Vb_soham;Integrated Security=True")
                connection.Open()
                Using command As New SqlCommand(queryString, connection)
                    command.Parameters.AddWithValue("@Customer", customerName)
                    command.Parameters.AddWithValue("@Mobile", mobile)
                    command.Parameters.AddWithValue("@Date", Date.Today)
                    Dim rowsAffected As Integer = command.ExecuteNonQuery()
                    If rowsAffected >= 1 Then
                        MessageBox.Show("Add items into cart ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Panel1.Visible = True
                        BindCombo()
                        getMaxID()
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BindCombo()
        Dim qry As String = "Select * from TableItems with (nolock)"
        Try
            Using connection1 As New SqlConnection("Data Source=DESKTOP-S098J7U\SQLEXPRESS;Initial Catalog=Gui_Vb_soham;Integrated Security=True")
                connection1.Open()
                Using cmd As New SqlCommand(qry, connection1)
                    Dim sda As New SqlDataAdapter(cmd)
                    Dim ds1 As New DataSet()
                    sda.Fill(ds1, "TableItems")
                    cbxItems.Items.Clear()

                    For i As Integer = 0 To ds1.Tables("TableItems").Rows.Count - 1
                        cbxItems.Items.Add(ds1.Tables("TableItems").Rows(i)(1).ToString())
                    Next
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cbxItems_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxItems.SelectedIndexChanged
        If cbxItems.SelectedItem IsNot Nothing Then
            Dim selectedItem As String = cbxItems.SelectedItem.ToString()
            Dim qry As String = "SELECT * FROM TableItems WHERE ItemTitle = @ItemTitle"
            Try
                Using connection1 As New SqlConnection("Data Source=DESKTOP-S098J7U\SQLEXPRESS;Initial Catalog=Gui_Vb_soham;Integrated Security=True")
                    connection1.Open()
                    Using cmd As New SqlCommand(qry, connection1)
                        cmd.Parameters.AddWithValue("@ItemTitle", selectedItem)
                        Dim dr1 As SqlDataReader = cmd.ExecuteReader()
                        If dr1.Read() Then
                            txtCost.Text = dr1("Cost").ToString()
                            cost = Convert.ToDecimal(dr1("Cost"))
                            txtQty.Focus()
                        Else
                            MessageBox.Show("Price not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub txtQty_TextChanged(sender As Object, e As EventArgs) Handles txtQty.TextChanged
        If Not String.IsNullOrEmpty(txtQty.Text) AndAlso IsNumeric(txtQty.Text) Then
            txtCost.Text = (Convert.ToInt32(txtQty.Text) * cost).ToString()
            txtCost.ReadOnly = True
        Else
            txtCost.Clear()
        End If
    End Sub

    Private Sub btnPlus_Click(sender As Object, e As EventArgs) Handles btnPlus.Click
        If String.IsNullOrEmpty(txtQty.Text) OrElse Not IsNumeric(txtQty.Text) Then
            MessageBox.Show("Please enter a valid quantity", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtQty.Focus()
            Exit Sub
        End If

        btnMinus.Enabled = False
        checkStock()

        If qty >= Convert.ToInt32(txtQty.Text) Then
            Dim itemTitle As String = cbxItems.SelectedItem.ToString()
            Dim quantity As Integer = Convert.ToInt32(txtQty.Text)
            Dim totalCost As Decimal = quantity * cost

            Dim qry As String = "INSERT INTO TableGridSales (ID, ItemName, Quantity, TotalCost) VALUES (@ID, @ItemName, @Quantity, @TotalCost)"
            Try
                Using connection1 As New SqlConnection("Data Source=DESKTOP-S098J7U\SQLEXPRESS;Initial Catalog=Gui_Vb_soham;Integrated Security=True")
                    connection1.Open()
                    Using cmd As New SqlCommand(qry, connection1)
                        cmd.Parameters.AddWithValue("@ID", MAXID)
                        cmd.Parameters.AddWithValue("@ItemName", itemTitle)
                        cmd.Parameters.AddWithValue("@Quantity", quantity)
                        cmd.Parameters.AddWithValue("@TotalCost", totalCost)

                        Dim i As Integer = cmd.ExecuteNonQuery()

                        If i >= 1 Then
                            MessageBox.Show("1 item added to cart", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            UpdateQty()
                            ShowItemGrid()
                        Else
                            MessageBox.Show("Failure", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            MessageBox.Show("Insufficient quantity in stock", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub checkStock()
        If cbxItems.SelectedItem IsNot Nothing Then
            Dim itemTitle As String = cbxItems.SelectedItem.ToString()
            Dim qry As String = "SELECT * FROM TableStock WHERE ItemTitle = @ItemTitle"
            Try
                Using connection1 As New SqlConnection("Data Source=DESKTOP-S098J7U\SQLEXPRESS;Initial Catalog=Gui_Vb_soham;Integrated Security=True")
                    connection1.Open()
                    Using cmd As New SqlCommand(qry, connection1)
                        cmd.Parameters.AddWithValue("@ItemTitle", itemTitle)
                        Dim dr1 As SqlDataReader = cmd.ExecuteReader()
                        If dr1.Read() Then
                            qty = Convert.ToInt32(dr1("Quantity"))
                        Else
                            MessageBox.Show("Item Not Available", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub UpdateQty()
        If qty >= Convert.ToInt32(txtQty.Text) Then
            Dim qty2 As Integer = qty - Convert.ToInt32(txtQty.Text)
            Dim itemTitle As String = cbxItems.SelectedItem.ToString()
            Dim qry As String = "UPDATE TableStock SET Quantity = @Quantity WHERE ItemTitle = @ItemTitle"
            Try
                Using connection1 As New SqlConnection("Data Source=DESKTOP-S098J7U\SQLEXPRESS;Initial Catalog=Gui_Vb_soham;Integrated Security=True")
                    connection1.Open()
                    Using cmd As New SqlCommand(qry, connection1)
                        cmd.Parameters.AddWithValue("@Quantity", qty2)
                        cmd.Parameters.AddWithValue("@ItemTitle", itemTitle)

                        Dim i As Integer = cmd.ExecuteNonQuery()

                        If i >= 1 Then
                            MessageBox.Show("Item Quantity Updated", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            MessageBox.Show("Failed to update item quantity", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            MessageBox.Show("Insufficient quantity", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Public Sub ShowItemGrid()
        Try
            Dim qry As String = "SELECT * FROM TableGridSales WHERE ID = @MAXID"
            Using connection1 As New SqlConnection("Data Source=DESKTOP-S098J7U\SQLEXPRESS;Initial Catalog=Gui_Vb_soham;Integrated Security=True")
                connection1.Open()
                Using da As New SqlDataAdapter(qry, connection1)
                    da.SelectCommand.Parameters.AddWithValue("@MAXID", MAXID)
                    Dim ds As New DataSet
                    da.Fill(ds)
                    If ds.Tables(0).Rows.Count > 0 Then
                        DataGridView1.DataSource = ds.Tables(0)
                        CalculateTotal()
                    Else
                        MessageBox.Show("Data not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub CalculateTotal()
        Dim totalAmount As Decimal = 0
        Try
            For Each row As DataGridViewRow In DataGridView1.Rows
                If row.Cells.Count > 4 AndAlso row.Cells(4).Value IsNot Nothing AndAlso Not IsDBNull(row.Cells(4).Value) Then
                    totalAmount += Convert.ToDecimal(row.Cells(4).Value)
                End If
            Next
            txtTotal.Text = totalAmount.ToString()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Public Sub getMaxID()
        Try
            Dim qry As String = "SELECT MAX(ID) AS maxID FROM TableSalesMaster"
            Using connection1 As New SqlConnection("Data Source=DESKTOP-S098J7U\SQLEXPRESS;Initial Catalog=Gui_Vb_soham;Integrated Security=True")
                connection1.Open()
                Using cmd As New SqlCommand(qry, connection1)
                    Dim dr1 As SqlDataReader = cmd.ExecuteReader()
                    If dr1.Read() Then
                        MAXID = dr1("maxID").ToString()
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnSaveOrder_Click(sender As Object, e As EventArgs) Handles btnSaveOrder.Click
        Try
            Dim TotalSale As Decimal = 0 ' Replace with the actual value

            Dim qry As String = "UPDATE TableSalesMaster SET TotalSale = @TotalSale WHERE ID = @MAXID"
            Using connection1 As New SqlConnection("Data Source=DESKTOP-S098J7U\SQLEXPRESS;Initial Catalog=Gui_Vb_soham;Integrated Security=True")
                connection1.Open()
                Using cmd As New SqlCommand(qry, connection1)
                    cmd.Parameters.AddWithValue("@TotalSale", TotalSale)
                    cmd.Parameters.AddWithValue("@MAXID", MAXID)

                    Dim i As Integer = cmd.ExecuteNonQuery()

                    If i >= 1 Then
                        MessageBox.Show("Order Successfully Saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        ' Clear form fields and reset DataGridView
                        txtName.Clear()
                        txtMob.Clear()
                        cbxItems.Text = ""
                        txtCost.Text = "0"
                        txtRecAmt.Text = "0"
                        txtQty.Clear()
                        txtDueAmt.Text = "0"
                        txtChAmt.Text = "0"
                        Panel1.Visible = False
                        txtName.Focus()
                        DataGridView1.DataSource = Nothing
                    Else
                        MessageBox.Show("Failed to save order", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtRecAmt_TextChanged(sender As Object, e As EventArgs) Handles txtRecAmt.TextChanged
        Try
            If Not String.IsNullOrEmpty(txtRecAmt.Text) AndAlso IsNumeric(txtRecAmt.Text) Then
                If Convert.ToDecimal(txtRecAmt.Text) > Convert.ToDecimal(txtTotal.Text) Then
                    txtChAmt.Text = (Convert.ToDecimal(txtRecAmt.Text) - Convert.ToDecimal(txtTotal.Text)).ToString()
                    txtDueAmt.Text = "0"
                ElseIf Convert.ToDecimal(txtRecAmt.Text) < Convert.ToDecimal(txtTotal.Text) Then
                    txtDueAmt.Text = (Convert.ToDecimal(txtTotal.Text) - Convert.ToDecimal(txtRecAmt.Text)).ToString()
                    txtChAmt.Text = "0"
                End If
            Else
                txtDueAmt.Text = "0"
                txtChAmt.Text = "0"
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub DataGridView1_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick
        If e.RowIndex >= 0 Then
            Try
                Dim i As Integer = DataGridView1.CurrentRow.Index
                i_d = DataGridView1.Item(0, i).Value.ToString() ' Assuming the ID is in the first column
                cbxItems.Text = DataGridView1.Item(2, i).Value.ToString() ' Assuming the item name is in the third column
                txtQty.Text = DataGridView1.Item(3, i).Value.ToString() ' Assuming the quantity is in the fourth column
                txtCost.Text = DataGridView1.Item(4, i).Value.ToString() ' Assuming the cost is in the fifth column
                btnMinus.Enabled = True
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub btnMinus_Click(sender As Object, e As EventArgs) Handles btnMinus.Click
        If String.IsNullOrEmpty(i_d) Then
            MessageBox.Show("Please select an item to delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Try
                Dim qry As String = "DELETE FROM TableGridSales WHERE SalesID = @ID"
                Using connection1 As New SqlConnection("Data Source=DESKTOP-S098J7U\SQLEXPRESS;Initial Catalog=Gui_Vb_soham;Integrated Security=True")
                    connection1.Open()
                    Using cmd As New SqlCommand(qry, connection1)
                        cmd.Parameters.AddWithValue("@ID", i_d)
                        Dim i As Integer = cmd.ExecuteNonQuery()

                        If i > 0 Then
                            qry = "SELECT * FROM TableGridSales WHERE ID = @MAXID"
                            Using da As New SqlDataAdapter(qry, connection1)
                                da.SelectCommand.Parameters.AddWithValue("@MAXID", MAXID)
                                Dim ds As New DataSet
                                da.Fill(ds)
                                If ds.Tables(0).Rows.Count > 0 Then
                                    DataGridView1.DataSource = ds.Tables(0)
                                    CalculateTotal()
                                    MessageBox.Show("Item deleted from the cart", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                End If
                            End Using
                        Else
                            MessageBox.Show("Failed to delete item", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
        btnMinus.Enabled = False
    End Sub

End Class
