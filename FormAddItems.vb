Imports System.Data.SqlClient
Public Class FormAddItems
    Private Sub FormAddItems_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load
        BindCombo()
        LoadingDataGrid()
    End Sub

    Public Sub BindCombo()
        cbnItem.Items.Clear()
        ds.Clear()
        qry = "Select * from TableItemType with (nolock)"
        ds = SearchData(qry)
        If ds.Tables(0).Rows.Count > 0 Then
            For Each row As DataRow In ds.Tables(0).Rows
                cbnItem.Items.Add(row(1).ToString())
            Next
        Else
            MsgBox("No Record Found", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If TxtTitle.Text = "" OrElse TxtCost.Text = "" OrElse TxtDes.Text = "" OrElse cbnItem.Text = "" Then
            MessageBox.Show("Please fill in all fields.")
            Return
        End If

        Try
            Dim qry As String = "INSERT INTO TableItems (ItemTitle, ItemType, Cost, ItemDes) VALUES (@ItemTitle, @ItemType, @Cost, @ItemDes)"
            i = InsertData(qry)
            If i >= 1 Then
                MessageBox.Show("Data inserted successfully")
                LoadingDataGrid()
            Else
                MessageBox.Show("Failed to insert data")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Sub LoadingDataGrid()
        qry = "Select * from TableItems with (nolock)"
        ds = SearchData(qry)
        If ds.Tables(0).Rows.Count > 0 Then
            DataGridView1.DataSource = ds.Tables(0)
        Else
            MsgBox("No Record Found ", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If TxtTitle.Text = "" OrElse TxtCost.Text = "" OrElse TxtDes.Text = "" OrElse cbnItem.Text = "" Then
            MessageBox.Show("Please fill in all fields.")
            Return
        End If

        Try
            Dim qry As String = "UPDATE TableItems SET ItemType = @ItemType, Cost = @Cost, ItemDes = @ItemDes WHERE ItemTitle = @ItemTitle"
            i = UpdateData(qry)
            If i >= 1 Then
                MessageBox.Show("Data updated successfully")
                LoadingDataGrid()
            Else
                MessageBox.Show("Failed to update data")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        If TxtTitle.Text = "" Then
            MessageBox.Show("Please select an item to delete.")
            Return
        End If

        Try
            Dim qry As String = "DELETE FROM TableItems WHERE ItemTitle = @ItemTitle"
            i = DeleteData(qry)
            If i >= 1 Then
                MessageBox.Show("Data deleted successfully")
                LoadingDataGrid()
                ClearFields()
            Else
                MessageBox.Show("Failed to delete data")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearFields()
    End Sub

    Private Sub ClearFields()
        TxtTitle.Clear()
        TxtCost.Clear()
        TxtDes.Clear()
        cbnItem.SelectedIndex = -1
    End Sub

    Private Sub DataGridView1_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick

        If e.RowIndex >= 0 Then
            Try
                Dim row As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
                TxtTitle.Text = row.Cells(1).Value.ToString()
                cbnItem.Text = row.Cells(2).Value.ToString()
                TxtCost.Text = row.Cells(3).Value.ToString()
                TxtDes.Text = row.Cells(4).Value.ToString()
                DataGridView1.Columns(4).Width = 10000 'Set the width to 200 pixels (you can change this value as needed)

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub
    Private Function UpdateData(query As String) As Integer
        Dim rowsAffected As Integer = 0
        Try
            Using connection1 As New SqlConnection(connectionstring)
                Using cmd As New SqlCommand(query, connection1)
                    cmd.Parameters.AddWithValue("@ItemTitle", TxtTitle.Text)
                    cmd.Parameters.AddWithValue("@ItemType", cbnItem.Text)
                    cmd.Parameters.AddWithValue("@Cost", TxtCost.Text)
                    cmd.Parameters.AddWithValue("@ItemDes", TxtDes.Text)
                    connection1.Open()
                    rowsAffected = cmd.ExecuteNonQuery()
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error updating data: " & ex.Message)
        End Try
        Return rowsAffected
    End Function

    Private Function DeleteData(query As String) As Integer
        Dim rowsAffected As Integer = 0
        Try
            Using connection1 As New SqlConnection(connectionstring)
                Using cmd As New SqlCommand(query, connection1)
                    cmd.Parameters.AddWithValue("@ItemTitle", TxtTitle.Text)
                    connection1.Open()
                    rowsAffected = cmd.ExecuteNonQuery()
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error deleting data: " & ex.Message)
        End Try
        Return rowsAffected
    End Function
End Class
