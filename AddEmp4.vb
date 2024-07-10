Imports System.Data.SqlClient
Imports System.Security.Cryptography.X509Certificates
Public Class AddEmp4
    Private Sub save_btn_Click(sender As Object, e As EventArgs) Handles save_btn.Click
        If emp_txt.Text = "" Then emp_txt.Focus() : Exit Sub
        If sal_txt.Text = "" Then sal_txt.Focus() : Exit Sub
        If mbl_txt.Text = "" Then mbl_txt.Focus() : Exit Sub
        If mail_txt.Text = "" Then mail_txt.Focus() : Exit Sub
        If dob_txt.Text = "" Then dob_txt.Focus() : Exit Sub
        If add_txt.Text = "" Then add_txt.Focus() : Exit Sub
        If city_txt.Text = "" Then city_txt.Focus() : Exit Sub
        If state_txt.Text = "" Then state_txt.Focus() : Exit Sub
        If pin_txt.Text = "" Then pin_txt.Focus() : Exit Sub
        If coun_txt.Text = "" Then coun_txt.Focus() : Exit Sub

        'database code

        Try
            Dim connectionString As String = "Data source=DESKTOP-S098J7U\SQLEXPRESS;Initial catalog=Gui_Vb_soham;Integrated Security=True"
            Dim qry As String = "INSERT INTO TableEmployeeMgt (EmpName, Designation, Salary, Mobile, Email, DOB, Address, City, State, PinNo, Country) " &
          "VALUES (@EmpName, @Designation, @Salary, @Mobile, @Email, @DOB, @Address, @City, @State, @PinNo, @Country)"

            Using connection1 As New SqlConnection(connectionString)
                Using cmd As New SqlCommand(qry, connection1)
                    cmd.Parameters.AddWithValue("@EmpName", emp_txt.Text) ' Use .Text to get the text value
                    cmd.Parameters.AddWithValue("@Designation", des_cbx.Text)
                    cmd.Parameters.AddWithValue("@Salary", sal_txt.Text)
                    cmd.Parameters.AddWithValue("@Mobile", mbl_txt.Text)
                    cmd.Parameters.AddWithValue("@Email", mail_txt.Text)
                    cmd.Parameters.AddWithValue("@DOB", dob_txt.Text)
                    cmd.Parameters.AddWithValue("@Address", add_txt.Text)
                    cmd.Parameters.AddWithValue("@City", city_txt.Text)
                    cmd.Parameters.AddWithValue("@State", state_txt.Text)
                    cmd.Parameters.AddWithValue("@PinNo", pin_txt.Text)
                    cmd.Parameters.AddWithValue("@Country", coun_txt.Text)

                    connection1.Open()
                    Dim i As Integer = cmd.ExecuteNonQuery()

                    If (i > 0) Then
                        MsgBox("Success ", MsgBoxStyle.Information)
                        LoadingDataGrid()
                        ClearParameters()
                    Else
                        MsgBox("Failure ", MsgBoxStyle.Critical)
                    End If
                End Using
            End Using
        Catch ex As Exception
            MsgBox("An error occurred: " & ex.Message, MsgBoxStyle.Critical)
        End Try

    End Sub


    Public Sub LoadingDataGrid()
        If connection1.State = 1 Then connection1.Close()
        qry = "Select * from TableEmployeeMgt with (nolock)"
        ds = SearchData(qry)
        If ds.Tables(0).Rows.Count > 0 Then
            DataGridView1.DataSource = ds.Tables(0)
        Else
            MsgBox("No Record Found ", MsgBoxStyle.Exclamation)



        End If
    End Sub

    Private Sub AddEmp4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        EmpId.Visible = False
        BindCombo()
        LoadingDataGrid()
    End Sub

    Private Sub DataGridView1_MouseClick(sender As Object, e As MouseEventArgs) Handles DataGridView1.MouseClick
        EmpId.Visible = True
        i = DataGridView1.CurrentRow.Index
        Me.EmpId.Text = DataGridView1.Item(0, i).Value
        Me.emp_txt.Text = DataGridView1.Item(1, i).Value
        Me.des_cbx.Text = DataGridView1.Item(2, i).Value
        Me.sal_txt.Text = DataGridView1.Item(3, i).Value
        Me.mbl_txt.Text = DataGridView1.Item(4, i).Value
        Me.mail_txt.Text = DataGridView1.Item(5, i).Value
        Me.dob_txt.Text = DataGridView1.Item(6, i).Value
        Me.add_txt.Text = DataGridView1.Item(7, i).Value
        Me.city_txt.Text = DataGridView1.Item(8, i).Value
        Me.state_txt.Text = DataGridView1.Item(9, i).Value
        Me.pin_txt.Text = DataGridView1.Item(10, i).Value
        Me.coun_txt.Text = DataGridView1.Item(11, i).Value


    End Sub



    ' Database code
    Public Sub upt_btn_Click(sender As Object, e As EventArgs) Handles upt_btn.Click
        If emp_txt.Text = "" Then emp_txt.Focus() : Exit Sub
        If sal_txt.Text = "" Then sal_txt.Focus() : Exit Sub
        If mbl_txt.Text = "" Then mbl_txt.Focus() : Exit Sub
        If mail_txt.Text = "" Then mail_txt.Focus() : Exit Sub
        If dob_txt.Text = "" Then dob_txt.Focus() : Exit Sub
        If add_txt.Text = "" Then add_txt.Focus() : Exit Sub
        If city_txt.Text = "" Then city_txt.Focus() : Exit Sub
        If state_txt.Text = "" Then state_txt.Focus() : Exit Sub
        If pin_txt.Text = "" Then pin_txt.Focus() : Exit Sub
        If coun_txt.Text = "" Then coun_txt.Focus() : Exit Sub

        ' Database code
        Try
            Dim connectionString As String = "Data source=DESKTOP-S098J7U\SQLEXPRESS;Initial catalog=Gui_Vb_soham;Integrated Security=True"
            Dim qry As String = "UPDATE TableEmployeeMgt SET EmpName = @EmpName, Designation = @Designation, Salary = @Salary, Mobile = @Mobile, Email = @Email, DOB = @DOB, Address = @Address, City = @City, State = @State, PinNo = @PinNo, Country = @Country WHERE EmpId = @EmpID"

            Using connection1 As New SqlConnection(connectionString)
                Using cmd As New SqlCommand(qry, connection1)
                    cmd.Parameters.AddWithValue("@EmpName", emp_txt.Text)
                    cmd.Parameters.AddWithValue("@Designation", des_cbx.Text)
                    cmd.Parameters.AddWithValue("@Salary", sal_txt.Text)
                    cmd.Parameters.AddWithValue("@Mobile", mbl_txt.Text)
                    cmd.Parameters.AddWithValue("@Email", mail_txt.Text)
                    cmd.Parameters.AddWithValue("@DOB", dob_txt.Text)
                    cmd.Parameters.AddWithValue("@Address", add_txt.Text)
                    cmd.Parameters.AddWithValue("@City", city_txt.Text)
                    cmd.Parameters.AddWithValue("@State", state_txt.Text)
                    cmd.Parameters.AddWithValue("@PinNo", pin_txt.Text)
                    cmd.Parameters.AddWithValue("@Country", coun_txt.Text)
                    ' Assuming EmployeeID is the primary key of the table
                    cmd.Parameters.AddWithValue("@EmpID", EmpId.Text)

                    connection1.Open()
                    Dim i As Integer = cmd.ExecuteNonQuery()

                    If (i > 0) Then
                        MsgBox("Data updated successfully.", MsgBoxStyle.Information)
                        LoadingDataGrid()
                        ClearParameters()
                    Else
                        MsgBox("Failed to update data.", MsgBoxStyle.Critical)
                    End If
                End Using
            End Using
        Catch ex As Exception
            MsgBox("An error occurred: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub delete_btn_Click(sender As Object, e As EventArgs) Handles delete_btn.Click
        Dim result As Integer = MsgBox("Do you want to delete Employee?", MsgBoxStyle.YesNo)
        If result = DialogResult.Yes Then
            If (EmpId.Text = "") Then
                MsgBox("Select data to delete", MsgBoxStyle.Critical)
            Else
                Try
                    Dim connectionString As String = "Data Source=DESKTOP-S098J7U\SQLEXPRESS;Initial Catalog=Gui_Vb_soham;Integrated Security=True"
                    Using connection1 As New SqlConnection(connectionString)
                        connection1.Open()
                        Dim qry As String = "DELETE FROM TableEmployeeMgt WHERE EmpId = @EmpId"
                        Using cmd As New SqlCommand(qry, connection1)
                            cmd.Parameters.AddWithValue("@EmpId", EmpId.Text)
                            Dim i As Integer = cmd.ExecuteNonQuery()

                            If (i > 0) Then
                                MsgBox("Data deleted successfully.", MsgBoxStyle.Information)
                                LoadingDataGrid()
                                ClearParameters()
                            Else
                                MsgBox("Failed to delete data.", MsgBoxStyle.Critical)
                            End If
                        End Using
                    End Using
                Catch ex As Exception
                    MsgBox("An error occurred: " & ex.Message, MsgBoxStyle.Critical)
                End Try
            End If
        End If
    End Sub

    Private Sub ClearParameters()
        ' Clear text boxes
        emp_txt.Text = ""
        sal_txt.Text = ""
        des_cbx.Text = ""
        mbl_txt.Text = ""
        mail_txt.Text = ""
        dob_txt.Text = ""
        add_txt.Text = ""
        city_txt.Text = ""
        state_txt.Text = ""
        pin_txt.Text = ""
        coun_txt.Text = ""
    End Sub

    Public Sub clr_btn_Click(sender As Object, e As EventArgs) Handles clr_btn.Click
        EmpId.Text = ""
        EmpId.Visible = False
        ClearParameters()


    End Sub

    Private Sub srh_btn_Click(sender As Object, e As EventArgs) Handles srh_btn.Click
        If search_txt.Text = "" Then
            MsgBox("Enter parameter to search", MsgBoxStyle.Critical)
            LoadingDataGrid() ' Call function to load data grid without any search criteria
            Exit Sub
        Else
            Dim searchParameter As String = search_txt.Text.Trim()
            Dim qry As String = "SELECT * FROM TableEmployeeMgt WITH (NOLOCK) WHERE "

            ' Dynamically construct the WHERE clause for each column
            qry &= "(EmpName LIKE '%' + @searchParameter + '%' OR "
            qry &= "Designation LIKE '%' + @searchParameter + '%' OR "
            qry &= "Salary LIKE '%' + @searchParameter + '%' OR "
            qry &= "Mobile LIKE '%' + @searchParameter + '%' OR "
            qry &= "Email LIKE '%' + @searchParameter + '%' OR "
            qry &= "DOB LIKE '%' + @searchParameter + '%' OR "
            qry &= "Address LIKE '%' + @searchParameter + '%' OR "
            qry &= "City LIKE '%' + @searchParameter + '%' OR "
            qry &= "State LIKE '%' + @searchParameter + '%' OR "
            qry &= "PinNo LIKE '%' + @searchParameter + '%' OR "
            qry &= "Country LIKE '%' + @searchParameter + '%')"

            Try
                Using connection1 As New SqlConnection("Data Source=DESKTOP-S098J7U\SQLEXPRESS;Initial Catalog=Gui_Vb_soham;Integrated Security=True"),
                      cmd As New SqlCommand(qry, connection1)

                    cmd.Parameters.AddWithValue("@searchParameter", searchParameter)

                    connection1.Open()

                    Using reader As SqlDataReader = cmd.ExecuteReader()
                        If reader.HasRows Then
                            ClearParameters()
                            Dim dt As New DataTable()
                            dt.Load(reader)
                            DataGridView1.DataSource = dt
                        Else
                            ClearParameters()
                            MsgBox("Record not found", MsgBoxStyle.Critical)
                        End If
                    End Using
                End Using
            Catch ex As Exception
                MsgBox("An error occurred: " & ex.Message, MsgBoxStyle.Critical)
            End Try
        End If
    End Sub
    Public Sub BindCombo()
        des_cbx.Items.Clear()
        ds.Clear()
        qry = "Select * from TableDesignation with (nolock)"
        ds = SearchData(qry)
        If ds.Tables(0).Rows.Count > 0 Then
            Dim a As Integer = ds.Tables(0).Rows.Count - 1
            Dim i As Integer = 0
            For i = 0 To a
                des_cbx.Items.Add(ds.Tables(0).Rows(i)(1).ToString())
            Next
        Else
            MsgBox("No Record Found", MsgBoxStyle.Exclamation)
        End If
    End Sub


End Class