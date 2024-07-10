Imports System.Data.SqlClient
Public Class Form1
    Private Sub login_btn_Click(sender As Object, e As EventArgs) Handles login_btn.Click
        If Len(Trim(username_tbx.Text)) = 0 Then
            MessageBox.Show("Please Enter Username", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            username_tbx.Clear()
            username_tbx.Focus()
        ElseIf Len(Trim(pass_tbx.Text)) = 0 Then
            MessageBox.Show("Please Enter Password", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            username_tbx.Clear()
            pass_tbx.Clear()
            pass_tbx.Focus()
        End If

        Try
            If connection1.State = 1 Then connection1.Close()
            cmd = New SqlCommand("Select Username, Password, UserRole from frmLogin with (nolock) where 
                                 Username=@U and Password = @P and UserRole = @UR ", connection1)
            cmd.Parameters.AddWithValue("@U", username_tbx.Text)
            cmd.Parameters.AddWithValue("@P", pass_tbx.Text)
            cmd.Parameters.AddWithValue("@UR", url_cbx.Text)
            cmd.Connection = connection1
            cmd.Connection.Open()
            dr = cmd.ExecuteReader()

            If dr.HasRows Then
                username1 = username_tbx.Text
                password = pass_tbx.Text
                utype = url_cbx.Text
                connection1.Close()
                If (utype = "Admin") OrElse (utype = "User") Then
                    Me.Hide()
                    Form3.Show()
                End If
            Else
                MessageBox.Show("Username & password is invalid ", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If

            If connection1.State = 1 Then connection1.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub exit_btn_Click(sender As Object, e As EventArgs) Handles exit_btn.Click
        Dim result As Integer
        result = MsgBox("Do you want to exit?", MsgBoxStyle.YesNo)
        If result = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub
End Class
