Imports System.Data.SqlClient
Public Class Form1
    Dim connection As New SqlConnection("Server = WESARUTKHM; Database = testdb; Integrated Security = true")
    Private Sub TestdbDataSetBindingSource_CurrentChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TestdbDataSet.res_user' table. You can move, or remove it, as needed.
        Me.Res_userTableAdapter.Fill(Me.TestdbDataSet.res_user)
        'TODO: This line of code loads data into the 'TestdbDataSet.res_user' table. You can move, or remove it, as needed.
        Me.Res_userTableAdapter.Fill(Me.TestdbDataSet.res_user)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnRegister.Click

        Dim insertExecute As String = "INSERT INTO dbo.res_user (name, lastname, age, birthdate, created_date, updated_date) VALUES ('" & txtName.Text & "', '" & txtLastname.Text & "', " & txtAge.Text & ", '" & txtBirth.Value & "', GETUTCDATE(), GETUTCDATE())"
        ExecuteQuery(insertExecute)


    End Sub

    Public Sub ExecuteQuery(query As String)
        Dim command As New SqlCommand(query, connection)
        connection.Open()
        command.ExecuteNonQuery()
        connection.Close()
    End Sub
End Class
