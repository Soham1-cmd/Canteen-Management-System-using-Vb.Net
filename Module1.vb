Imports System.Data
Imports System.Data.SqlClient
Module Module1
    Public connectionstring As String = "Data source = DESKTOP-S098J7U\SQLEXPRESS;Initial catalog =Gui_Vb_soham;Integrated Security =True"
    Public connection1 As New SqlConnection(connectionstring)
    Public cmd As New SqlCommand
    Public dr As SqlDataReader
    Public username1 As String = ""
    Public utype As String = ""
    Public password As String = ""
    Public qry As String = ""
    Public i As Integer = 0
    Public i_d As String = ""
    Public ds As New DataSet
    Public da As New SqlDataAdapter
    Public Function SearchData(ByVal qry As String) As DataSet
        If connection1.State = 1 Then connection1.Close()
        connection1.Open()
        da = New SqlDataAdapter(qry, connection1)
        ds = New DataSet
        da.Fill(ds)
        Return ds
        connection1.Close()
    End Function
    Public Function InsertData(ByVal qry As String) As Integer
        If connection1.State - 1 Then connection1.Close()
        cmd = New SqlCommand(qry, connection1)
        i = cmd.ExecuteNonQuery()
        If connection1.State - 1 Then connection1.Close()
        Return i
    End Function
End Module
