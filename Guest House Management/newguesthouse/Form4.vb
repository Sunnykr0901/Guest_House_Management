Imports MySql.Data.MySqlClient
Public Class adminpage
    Dim mysqlcon As MySqlConnection
    Dim command As MySqlCommand
    Private Sub LOGIN_btn_Click(sender As Object, e As EventArgs) Handles LOGIN_btn.Click
        mysqlcon = New MySqlConnection
        mysqlcon.ConnectionString = "server=localhost;userid=root;password=root;database=userinfo"
        Dim reader As MySqlDataReader


        'most of this is the same as getting the info from the userid table, just this time from the adminid table


        Try
            mysqlcon.Open()
            Dim query As String
            query = "select * from userinfo.adminid_table where username='" & usernametxt.Text & "'and password='" & passwordtxt.Text & "'"
            command = New MySqlCommand(query, mysqlcon)
            reader = command.ExecuteReader
            Dim count As Integer
            count = 0
            While reader.Read
                count = count + 1
            End While
            If count = 1 Then
                registereduser_details.Show()
                Me.Hide()
            ElseIf count > 1 Then
                MessageBox.Show("Username and password duplicate")
            Else
                MessageBox.Show("Enter correct username and password")

            End If
            mysqlcon.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            mysqlcon.Dispose()
        End Try
    End Sub

    Private Sub back_btn_Click(sender As Object, e As EventArgs) Handles back_btn.Click   'the changing colours of the buttons
        mainpage.Show()
        Me.Hide()
        mainpage.user_btn.BackColor = Color.Red
        mainpage.info_btn.BackColor = Color.Green
        mainpage.admin_login_btn.BackColor = Color.Green
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged  'check box to show/hide password
        If passwordtxt.UseSystemPasswordChar = True Then
            passwordtxt.UseSystemPasswordChar = False
        Else
            passwordtxt.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub adminpage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MaximizeBox = False
        Me.StartPosition = FormStartPosition.CenterScreen
        usernametxt.Select()
        Me.AcceptButton = LOGIN_btn
    End Sub
End Class