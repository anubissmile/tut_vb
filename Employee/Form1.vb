Imports System.Data.SqlClient
Public Class Form1
    Dim connection As New SqlConnection("Server = WESARUTKHM; Database = testdb; Integrated Security = true")
    Dim index As Integer
    Private Sub TestdbDataSetBindingSource_CurrentChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TestdbDataSet.res_user' table. You can move, or remove it, as needed.
        Me.Res_userTableAdapter.Fill(Me.TestdbDataSet.res_user)
        'TODO: This line of code loads data into the 'TestdbDataSet.res_user' table. You can move, or remove it, as needed.
        Me.Res_userTableAdapter.Fill(Me.TestdbDataSet.res_user)
        ExecuteQuery("")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnRegister.Click

        Dim insertExecute As String = "INSERT INTO dbo.res_user (name, lastname, age, birthdate, created_date, updated_date) VALUES ('" & txtName.Text & "', '" & txtLastname.Text & "', " & txtAge.Text & ", '" & txtBirth.Value & "', GETUTCDATE(), GETUTCDATE())"
        ExecuteNonQuery(insertExecute)
        ExecuteQuery("")
    End Sub

    Public Sub ExecuteNonQuery(query As String)
        Dim command As New SqlCommand(query, connection)
        connection.Open()
        command.ExecuteNonQuery()
        connection.Close()
    End Sub

    Private Sub btnShowAll_Click(sender As Object, e As EventArgs) Handles btnShowAll.Click
        ExecuteQuery("")
    End Sub

    Public Sub ExecuteQuery(query As String)
        Dim selectAll As String = "SELECT * FROM res_user"
        Dim command As New SqlCommand(selectAll, connection)
        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()
        adapter.Fill(table)
        userView.DataSource = table
    End Sub

    Private Sub userView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles userView.CellContentClick
        index = e.RowIndex
        MessageBox.Show(index)
        Dim selectedRow As DataGridViewRow
        selectedRow = userView.Rows(index)
        txtName.Text = selectedRow.Cells(0).Value.ToString()
        txtLastname.Text = selectedRow.Cells(1).Value.ToString()
        txtAge.Text = selectedRow.Cells(2).Value.ToString()
    End Sub
End Class
