﻿Imports System.Data.SqlClient
Public Class Form3
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        ProgressBar1.Visible = False
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(3)
        If ProgressBar1.Value = ProgressBar1.Maximum Then
            Me.Hide()
            MDIParent1.Show()
            Timer1.Stop()
        End If
    End Sub
End Class