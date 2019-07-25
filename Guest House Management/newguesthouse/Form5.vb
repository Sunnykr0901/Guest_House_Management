Imports MySql.Data.MySqlClient
Public Class paymentform
    Dim mysqlcon As MySqlConnection
    Dim command As MySqlCommand
    Dim verify_button As Boolean
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox("CVV is the last 3 digit number behind your debit card")
    End Sub
    Private Sub verify_btn_Click(sender As Object, e As EventArgs) Handles verify_btn.Click
        mysqlcon = New MySqlConnection
        mysqlcon.ConnectionString = "server=localhost;userid=root;password=root;database=userinfo"
        Dim reader As MySqlDataReader
        Try

            'the following is just a dummy program for verification
            'however the idea is that the software would send a mail to the person who has to verify it


            mysqlcon.Open()
            Dim query As String
            query = "select * from userinfo.userinfo_table where Name='" & nametxt.Text & "'and Contact_no='" & contacttxt.Text & "'and Room_type='" & roomtype.Text & "'and Arrival_Date='" & datetxt.Text & "'and Webmail='" & webmailtxt.Text & "'"
            command = New MySqlCommand(query, mysqlcon)
            reader = command.ExecuteReader
            MsgBox("Verified.Proceed Further!")
            verify_button = True
            mysqlcon.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            mysqlcon.Dispose()
        End Try
    End Sub

    'similarly the following is a dummy program but the idea is that it'd be
    'a highly encrypted and secure transmission
    'to transfer money

    Private Sub confirm_btn_Click(sender As Object, e As EventArgs) Handles confirm_btn.Click
        mysqlcon = New MySqlConnection
        mysqlcon.ConnectionString = "server=localhost;userid=root;password=root;database=userinfo"
        Dim reader As MySqlDataReader
        If verify_button Then
            If bankcombobox.Text = "" Or ddcombobox.Text = "" Or mmcombobox.Text = "" Or debittxt.Text = "" Or CVVtxt.Text = "" Then
                MsgBox("Enter your bank details.")
            Else
                If IsNum(debittxt.Text) = False Then
                    MsgBox("Enter correct debit card number")
                Else
                    If IsNum2(CVVtxt.Text) = False Then
                        MsgBox("Enter correct CVV")
                    Else
                        Try
                            mysqlcon.Open()
                            Dim query As String
                            query = "select * from userinfo.userinfo_table where Webmail='" & webmailtxt.Text & "'"
                            command = New MySqlCommand(query, mysqlcon)
                            reader = command.ExecuteReader
                            While reader.Read
                                receiptform.room_notxt.Text = roomtxt.Text
                                receiptform.booking_notxt.Text = reader.GetInt32("Booking_No")     'now you will receive the basic info of your stay
                                receiptform.roomtype.Text = reader.GetString("Room_type")

                                receiptform.TextBox2.Text = reader.GetString("Name")
                            End While
                            mysqlcon.Close()
                        Catch ex As Exception
                            MessageBox.Show(ex.Message)
                        Finally
                            mysqlcon.Dispose()
                        End Try
                        receiptform.TextBox1.Text = amounttxt.Text
                        receiptform.Show()
                        Me.Close()
                    End If
                End If
            End If
        Else
            MsgBox("Please first verify")
        End If
    End Sub

    Private Sub cancel_btn_Click(sender As Object, e As EventArgs) Handles cancel_btn.Click
        mysqlcon = New MySqlConnection
        mysqlcon.ConnectionString = "server=localhost;userid=root;password=root;database=userinfo"
        Dim reader As MySqlDataReader
        If verify_button Then
            Dim response = MsgBox("Do you want to pay?", vbYesNo)
            If response = vbNo Then

                Try
                    mysqlcon.Open()
                    Dim query As String
                    query = "delete from userinfo.userinfo_table where webmail='" & webmailtxt.Text & "'"  'all data will be deleted if you decide not to pay
                    command = New MySqlCommand(query, mysqlcon)
                    reader = command.ExecuteReader
                    mysqlcon.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                Finally
                    mysqlcon.Dispose()
                End Try
                MsgBox("You are now going to main page")
                Me.Close()
                mainpage.Show()
            End If
        Else
            Dim response = MsgBox("If you really want to pay,then verify first", vbOKCancel)
            If response = vbCancel Then
                Try
                    mysqlcon.Open()
                    Dim query As String
                    query = "delete from userinfo.userinfo_table where webmail='" & webmailtxt.Text & "'"
                    command = New MySqlCommand(query, mysqlcon)
                    reader = command.ExecuteReader
                    mysqlcon.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                Finally
                    mysqlcon.Dispose()
                End Try
            End If
        End If
        Me.Close()
        mainpage.Show()
    End Sub

   

    Private Sub paymentform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MaximizeBox = False
        Me.StartPosition = FormStartPosition.CenterScreen
        room_typetxt.Hide()
        roomtxt.Hide()
        Me.AcceptButton = confirm_btn
        bankcombobox.Select()
    End Sub
    Public Function IsNum(ByVal strInputText As String) As Boolean '16 digit debit card number
        Dim IsAlpha As Boolean = False
        If System.Text.RegularExpressions.Regex.IsMatch(strInputText, "^[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]$") Then
            IsAlpha = True
        Else
            IsAlpha = False
        End If
        Return IsAlpha
    End Function
    Public Function IsNum2(ByVal strInputText As String) As Boolean '3 digit cvv
        Dim IsAlpha As Boolean = False
        If System.Text.RegularExpressions.Regex.IsMatch(strInputText, "^[0-9][0-9][0-9]$") Then
            IsAlpha = True
        Else
            IsAlpha = False
        End If
        Return IsAlpha
    End Function
End Class