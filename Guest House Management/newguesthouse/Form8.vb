Imports MySql.Data.MySqlClient
Public Class Form8
    Dim mysqlcon As MySqlConnection                  'for a connection with mysql
    Dim command As MySqlCommand


    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        'showing password
        If TextBox2.UseSystemPasswordChar = True Then
            TextBox2.UseSystemPasswordChar = False
        Else
            TextBox2.UseSystemPasswordChar = True
        End If
        If TextBox3.UseSystemPasswordChar = True Then
            TextBox3.UseSystemPasswordChar = False
        Else
            TextBox3.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        mysqlcon = New MySqlConnection
        mysqlcon.ConnectionString = "server=localhost;userid=root;password=root;database=userinfo"
        Dim reader As MySqlDataReader
        If Len(TextBox2.Text) < 5 Then
            MsgBox("Password too short")
        Else
            If TextBox2.Text <> TextBox3.Text Then
                MsgBox("Password doen't match")
                'updating the password of the user
            Else
                Try
                    mysqlcon.Open()
                    Dim query As String
                    query = "update userinfo.userid_table set password='" & TextBox2.Text & "' where username='" & TextBox1.Text & "'"
                    command = New MySqlCommand(query, mysqlcon)
                    reader = command.ExecuteReader
                    mysqlcon.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                Finally
                    mysqlcon.Dispose()
                End Try
                MsgBox("Password successfully updated")
                mainpage.Show()
                Me.Close()
            End If
        End If
    End Sub

    Private Sub Form8_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'hiding
        TextBox1.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'going to mainpage
        mainpage.Show()
        Me.Close()
    End Sub
End Class