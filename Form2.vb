Imports System.Data.SqlClient
Public Class ChangePass
    Private Sub BTN_CLOSE_Click(sender As Object, e As EventArgs)
        Me.Dispose()
    End Sub
    Private Sub BTN_CHANGE_Click(sender As Object, e As EventArgs)
        Try
            If connection1.State = ConnectionState.Closed Then
                connection1.Open()
            End If
            If txt_oldPass.Text = "" Then
                MessageBox.Show("Please enter the old password.")
                txt_oldPass.Focus()
                Exit Sub
            End If
            If txt_NewPass.Text = "" Then
                MessageBox.Show("Please enter the new password.")
                txt_NewPass.Focus()
                Exit Sub
            End If
            If txt_ConfirmPass.Text = "" Then
                MessageBox.Show("Please confirm the new password.")
                txt_ConfirmPass.Focus()
                Exit Sub
            End If
            If txt_oldPass.Text <> Module1.password Then
                MessageBox.Show("Old password does not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txt_oldPass.Focus()
                Exit Sub
            End If
            If txt_NewPass.Text <> txt_ConfirmPass.Text Then
                MessageBox.Show("New password and confirm password do not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txt_NewPass.Focus()
                Exit Sub
            End If
            Dim qry As String = "UPDATE frmLogin SET Password = @Password WHERE Username = @Username"
            Using cmd As New SqlCommand(qry, connection1)
                cmd.Parameters.AddWithValue("@Password", txt_NewPass.Text)
                cmd.Parameters.AddWithValue("@Username", Module1.username1)
                Dim i As Integer = cmd.ExecuteNonQuery()
                If i >= 1 Then
                    MessageBox.Show("Password changed successfully.")
                    txt_oldPass.Clear()
                    txt_NewPass.Clear()
                    txt_ConfirmPass.Clear()
                    Me.Close()
                    MDIParent1.Hide()
                Else
                    MessageBox.Show("Failed to change password.")
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            connection1.Close()
        End Try
    End Sub
End Class

