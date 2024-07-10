Imports System.Data.SqlClient

Public Class AddDes
    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        Try
            Using connection1 As New SqlConnection("Data Source=DESKTOP-S098J7U\SQLEXPRESS;Initial Catalog=Gui_Vb_soham;Integrated Security=True")
                connection1.Open()

                If txtDes.Text = "" Then
                    MessageBox.Show("Please enter a designation.")
                    txtDes.Focus()
                    Return
                End If

                Dim qry As String = "INSERT INTO TableDesignation (Desgination) VALUES (@Desgination)"
                Using cmd As New SqlCommand(qry, connection1)
                    cmd.Parameters.AddWithValue("@Desgination", txtDes.Text)
                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                    If rowsAffected > 0 Then
                        MessageBox.Show("Data Inserted Successfully")
                        LoadingDataGrid()
                        txtDes.Clear()
                        txtDes.Focus()
                    Else
                        MessageBox.Show("Failed to insert data.")
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        Try
            Using connection1 As New SqlConnection("Data Source=DESKTOP-S098J7U\SQLEXPRESS;Initial Catalog=Gui_Vb_soham;Integrated Security=True")
                connection1.Open()

                If txtDes.Text = "" Then
                    MessageBox.Show("Please enter a designation.")
                    txtDes.Focus()
                    Return
                End If

                Dim qry As String = "UPDATE TableDesignation SET Desgination = @Desgination WHERE ID = @ID"
                Using cmd As New SqlCommand(qry, connection1)
                    cmd.Parameters.AddWithValue("@Desgination", txtDes.Text)
                    cmd.Parameters.AddWithValue("@ID", i_d)
                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                    If rowsAffected > 0 Then
                        MessageBox.Show("Data Updated Successfully")
                        LoadingDataGrid()
                        txtDes.Clear()
                        txtDes.Focus()
                    Else
                        MessageBox.Show("Failed to update data.")
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        Try
            If i_d = "" Then
                MessageBox.Show("Select any item to delete.")
                Return
            End If

            Using connection1 As New SqlConnection("Data Source=DESKTOP-S098J7U\SQLEXPRESS;Initial Catalog=Gui_Vb_soham;Integrated Security=True")
                connection1.Open()

                Dim qry As String = "DELETE FROM TableDesignation WHERE ID = @ID"
                Using cmd As New SqlCommand(qry, connection1)
                    cmd.Parameters.AddWithValue("@ID", i_d)
                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                    If rowsAffected > 0 Then
                        MessageBox.Show("Data Deleted Successfully")
                        LoadingDataGrid()
                        txtDes.Clear()
                        txtDes.Focus()
                    Else
                        MessageBox.Show("Failed to delete data.")
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Public Sub LoadingDataGrid()
        Try
            Using connection1 As New SqlConnection("Data Source=DESKTOP-S098J7U\SQLEXPRESS;Initial Catalog=Gui_Vb_soham;Integrated Security=True")
                connection1.Open()

                Dim qry As String = "SELECT * FROM TableDesignation"
                Dim adapter As New SqlDataAdapter(qry, connection1)
                Dim ds As New DataSet()
                adapter.Fill(ds)

                If ds.Tables(0).Rows.Count > 0 Then
                    DataGridView1.DataSource = ds.Tables(0)
                Else
                    MsgBox("No Records Found", MsgBoxStyle.Exclamation)
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub DataGridView1_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick
        If e.RowIndex >= 0 Then
            Try
                i_d = DataGridView1.CurrentRow.Cells(0).Value.ToString()
                txtDes.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString()
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End If
    End Sub

    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Me.Dispose()

    End Sub
End Class
