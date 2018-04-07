Imports System.Data.SqlClient
Public Class Form1

    Private Sub TestdbDataSetBindingSource_CurrentChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TestdbDataSet.res_user' table. You can move, or remove it, as needed.
        Me.Res_userTableAdapter.Fill(Me.TestdbDataSet.res_user)
        'TODO: This line of code loads data into the 'TestdbDataSet.res_user' table. You can move, or remove it, as needed.
        Me.Res_userTableAdapter.Fill(Me.TestdbDataSet.res_user)

    End Sub
End Class
