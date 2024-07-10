Imports System.Data.SqlClient

Public Class formStockEntry
    Private connection1 As New SqlConnection("Data Source=DESKTOP-S098J7U\SQLEXPRESS;Initial Catalog=Gui_Vb_soham;Integrated Security=True")
    Private i_d As String

    Private Sub formStockEntry_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BindCombo()
        LoadingDataGrid()
    End Sub

    Public Sub BindCombo()
        Try
            cbxitems.Items.Clear()
            Dim qry As String = "SELECT DISTINCT ItemID,ItemTitle FROM TableItems"
            Dim ds As DataSet = GetData(qry)

            If ds.Tables(0).Rows.Count > 0 Then
                For Each row As DataRow In ds.Tables(0).Rows
                    cbxitems.Items.Add(row("ItemTitle").ToString())
                Next
            Else
                MsgBox("No Records Found", MsgBoxStyle.Exclamation)
            End If
        Catch ex As Exception
            HandleError(ex)
        End Try
    End Sub

    Public Sub LoadingDataGrid()
        Try
            Dim qry As String = "SELECT * FROM TableStock"
            Dim ds As DataSet = GetData(qry)

            If ds.Tables(0).Rows.Count > 0 Then
                DataGridView1.DataSource = ds.Tables(0)
            Else
                MsgBox("No Records Found", MsgBoxStyle.Exclamation)
            End If
        Catch ex As Exception
            HandleError(ex)
        End Try
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        If String.IsNullOrWhiteSpace(cbxitems.Text) OrElse String.IsNullOrWhiteSpace(txtQty.Text) OrElse String.IsNullOrWhiteSpace(txtDesc.Text) Then
            MessageBox.Show("Please fill in all fields.")
            Return
        End If

        Try
            Dim qry As String = "INSERT INTO TableStock (ItemTitle, Quantity, ItemDesc) VALUES (@ItemTitle, @Quantity, @ItemDesc)"

            Using connection As New SqlConnection("Data Source=DESKTOP-S098J7U\SQLEXPRESS;Initial Catalog=Gui_Vb_soham;Integrated Security=True")
                connection.Open()
                Using cmd As New SqlCommand(qry, connection)
                    cmd.Parameters.AddWithValue("@ItemTitle", cbxitems.Text)
                    cmd.Parameters.AddWithValue("@Quantity", txtQty.Text)
                    cmd.Parameters.AddWithValue("@ItemDesc", txtDesc.Text)

                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                    If rowsAffected >= 1 Then
                        MessageBox.Show("Data inserted successfully")
                        LoadingDataGrid()
                        clear()

                    Else
                        MessageBox.Show("Failed to insert data")
                    End If
                End Using
            End Using
        Catch ex As Exception
            HandleError(ex)
        End Try
    End Sub

    Private Sub btn_up_Click(sender As Object, e As EventArgs) Handles btn_up.Click
        If String.IsNullOrWhiteSpace(cbxitems.Text) OrElse String.IsNullOrWhiteSpace(txtQty.Text) OrElse String.IsNullOrWhiteSpace(txtDesc.Text) Then
            MessageBox.Show("Please fill in all fields.")
            Return
        End If

        Try
            Dim qry As String = "UPDATE TableStock SET ItemTitle = @ItemTitle, Quantity = @Quantity, ItemDesc = @ItemDesc WHERE StockID = @StockID"

            Using connection As New SqlConnection("Data Source=DESKTOP-S098J7U\SQLEXPRESS;Initial Catalog=Gui_Vb_soham;Integrated Security=True")
                connection.Open()
                Using cmd As New SqlCommand(qry, connection)
                    cmd.Parameters.AddWithValue("@ItemTitle", cbxitems.Text)
                    cmd.Parameters.AddWithValue("@Quantity", txtQty.Text)
                    cmd.Parameters.AddWithValue("@ItemDesc", txtDesc.Text)
                    cmd.Parameters.AddWithValue("@StockID", i_d)

                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                    If rowsAffected >= 1 Then
                        MessageBox.Show("Data updated successfully")
                        LoadingDataGrid()
                        clear()

                    Else
                        MessageBox.Show("Failed to update data")
                    End If
                End Using
            End Using
        Catch ex As Exception
            HandleError(ex)
        End Try
    End Sub

    Private Sub btn_del_Click(sender As Object, e As EventArgs) Handles btn_del.Click
        Dim result As Integer = MsgBox("Do you want to delete this item?", MsgBoxStyle.YesNo)
        If result = DialogResult.Yes Then
            If i_d = "" Then
                MsgBox("Select any row in the gridview.")
            Else
                Try
                    Dim qry As String = "DELETE FROM TableStock WHERE StockId = @StockID"

                    Using connection As New SqlConnection("Data Source=DESKTOP-S098J7U\SQLEXPRESS;Initial Catalog=Gui_Vb_soham;Integrated Security=True")
                        connection.Open()
                        Using cmd As New SqlCommand(qry, connection)
                            cmd.Parameters.AddWithValue("@StockID", i_d)

                            Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                            If rowsAffected >= 1 Then
                                MessageBox.Show("Record successfully deleted.")
                                LoadingDataGrid()
                                clear()
                            Else
                                MessageBox.Show("Failed to delete record.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            End If
                        End Using
                    End Using
                Catch ex As Exception
                    HandleError(ex)
                End Try
            End If
        End If
    End Sub

    Private Sub btn_clr_Click(sender As Object, e As EventArgs) Handles btn_clr.Click
        clear()
    End Sub

    Private Sub DataGridView1_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick
        If e.RowIndex >= 0 Then
            Try
                Dim i As Integer = DataGridView1.CurrentRow.Index
                i_d = DataGridView1.Item(0, i).Value.ToString()
                Me.cbxitems.Text = DataGridView1.Item(1, i).Value.ToString()
                Me.txtQty.Text = DataGridView1.Item(2, i).Value.ToString()
                Me.txtDesc.Text = DataGridView1.Item(3, i).Value.ToString()
            Catch ex As Exception
                HandleError(ex)
            End Try
        End If
    End Sub

    Private Sub HandleError(ex As Exception)
        MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    Private Function GetData(qry As String) As DataSet
        Using connection As New SqlConnection("Data Source=DESKTOP-S098J7U\SQLEXPRESS;Initial Catalog=Gui_Vb_soham;Integrated Security=True")
            Dim ds As New DataSet
            Try
                connection.Open()
                Using da As New SqlDataAdapter(qry, connection)
                    da.Fill(ds)
                End Using
            Catch ex As Exception
                HandleError(ex)
            End Try
            Return ds
        End Using
    End Function

    Public Sub clear()
        cbxitems.Items.Clear()
        txtQty.Clear()
        txtDesc.Clear()
        cbxitems.Text = ""
    End Sub

    Private Sub txtDesc_TextChanged(sender As Object, e As EventArgs) Handles txtDesc.TextChanged
        txtDesc.Text = txtQty.Text + " Items Available"
    End Sub
End Class
