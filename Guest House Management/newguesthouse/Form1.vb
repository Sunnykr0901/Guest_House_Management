Imports MySql.Data.MySqlClient                       'this is necessary for connections with mysql database

Public Class mainpage
    Dim mysqlcon As MySqlConnection                  'for a connection with mysql
    Dim command As MySqlCommand                      'a command that will help us complete our query
    Dim check As Boolean
    Dim count As Integer
    Dim ss As Integer = 500              'cost of a single room of a student
    Dim ds As Integer = 700              'cost of a double room of a student
    Dim sp As Integer = 400             'cost of a single room of a proffessor or staff
    Dim dp As Integer = 500             'cost of a double room of a proffessor or staff
    Dim cleaning As Integer = 50        'cost of cleaning your room
    Dim laundary As Integer = 20        'cost of doing laundry
    Dim category As String
    Private Sub mainpage_Load(sender As Object, e As EventArgs) Handles MyBase.Load     'mainpage is the first form
        Timer1.Start()
        Me.MaximizeBox = False
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.AcceptButton = login_btn                                                     'by default, the login_btn is selected
        Panel1.Hide()                          'Panel1 contains the info regarding the GuestHouse
        Panel2.Show()                          'Panel2 contains the login boxes
        Label7.Hide()
        Form9.Label3.Hide()
        Form9.Label4.Hide()
        Form9.Label5.Hide()
        Form9.Label2.Hide()
        Form9.Label6.Hide()
        DateTimePicker2.Hide()                 'this has the date of arrival
        DateTimePicker1.Hide()                 'this has today's date
        DateTimePicker3.Hide()                 'this has date of departure
        room.Hide()
        Label6.Show()
        Label1.Hide()                           'username
        Label2.Hide()                           'password
        usernametxt.Hide()                      'textbox to enter your username
        passwordtxt.Hide()                      'textbox to enter your password
        CheckBox1.Hide()                        'to show password
        login_btn.Hide()                        'to log in
        user_btn.Show()                         'this is the button for user login
        admin_login_btn.Show()                  'button for admin login
        info_btn.Show()                         'button to show info
        usernametxt.Select()
        Panel3.Hide()
    End Sub
    Private Sub info_btn_Click(sender As Object, e As EventArgs)
        Panel1.Show()                       'in this case, the info panel is shown
        Panel2.Hide()                       'and the first one is hidden
    End Sub
    Private Sub InfoBackButton_Click(sender As Object, e As EventArgs) Handles InfoBackButton.Click  'back button, sends you back to the first page
        Panel1.Hide()           'by hiding the panel1 if open
        Panel2.Show()           'and showing the panel2 
        user_btn.BackColor = Color.Green               'the selected button will turn red
        info_btn.BackColor = Color.Green             'while the greens
        admin_login_btn.BackColor = Color.Green      'are in fact, not
    End Sub
    Private Sub info_btn_Click_1(sender As Object, e As EventArgs) Handles info_btn.Click
        Panel1.Show()
        Panel2.Hide()
    End Sub

    Private Sub user_btn_Click(sender As Object, e As EventArgs) Handles user_btn.Click  'on clicking the user login
        If user_btn.BackColor = Color.Green Then     'if the box isn't selected
            Label7.Show()                   'this will read 'password'
            usernametxt.Select()            'this will select the username textbox
            user_btn.BackColor = Color.Red
            info_btn.BackColor = Color.Green
            admin_login_btn.BackColor = Color.Green          'showing true colours
            Label1.Show()                    'showing and hiding the appropriate things
            Label2.Show()
            usernametxt.Show()
            passwordtxt.Show()
            usernametxt.Select()
            CheckBox1.Show()
            login_btn.Show()
            Me.BackColor = Color.Black
            Label3.Show()
        Else                       'if the button is, in fact, selected, we should hide what's shown
            Label7.Hide()
            user_btn.BackColor = Color.Green
            info_btn.BackColor = Color.Green
            admin_login_btn.BackColor = Color.Green      'and they all turn green
            Label1.Hide()
            Label2.Hide()
            usernametxt.Hide()
            passwordtxt.Hide()
            usernametxt.Select()
            CheckBox1.Hide()
            login_btn.Hide()

        End If
    End Sub

    Private Sub login_btn_Click(sender As Object, e As EventArgs) Handles login_btn.Click    'on clicking the login button
        Form8.TextBox1.Text = usernametxt.Text
        mysqlcon = New MySqlConnection
        mysqlcon.ConnectionString = "server=localhost;userid=root;password=root;database=userinfo"   'connect to the database
        Dim reader As MySqlDataReader
        Try
            mysqlcon.Open()
            Dim query As String
            query = "select * from userinfo.userid_table where username='" & usernametxt.Text & "'"
            command = New MySqlCommand(query, mysqlcon)
            reader = command.ExecuteReader
            While reader.Read
                user_details.category.Text = reader.GetString("Category")
            End While
            mysqlcon.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            mysqlcon.Dispose()
        End Try
        'looking through the database userinfo_table and if the user exists, set check to true, otherwise false
        Try
            mysqlcon.Open()
            Dim query As String
            query = "select * from userinfo.userinfo_table where Webmail='" & usernametxt.Text & "'"
            command = New MySqlCommand(query, mysqlcon)
            reader = command.ExecuteReader
            Dim count As Integer
            count = 0
            While reader.Read
                count = count + 1
            End While
            If count >= 1 Then
                check = True
            Else
                check = False
            End If
            mysqlcon.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            mysqlcon.Dispose()
        End Try
        ' if user hasn't booked any room,then go to booking page for new room booking otherwise it goes to panel 3
        If check = False Then
            Try
                mysqlcon.Open()
                Dim query As String
                query = "select * from userinfo.userid_table where username='" & usernametxt.Text & "'and password='" & passwordtxt.Text & "'"
                command = New MySqlCommand(query, mysqlcon)
                reader = command.ExecuteReader
                Dim count As Integer
                count = 0
                While reader.Read
                    count = count + 1
                End While
                If count = 1 Then                  'check the user if they're in the database
                    user_details.usernametextbox.Text = usernametxt.Text
                    user_details.Show()
                    Me.Hide()
                ElseIf count > 1 Then
                    MessageBox.Show("Username and password duplicate")           'in case there are multiple instances of the same user
                Else
                    MessageBox.Show("Enter correct username and password")       'there are no instances of the same user
                End If
                mysqlcon.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                mysqlcon.Dispose()
            End Try
        Else
            Try
                mysqlcon.Open()
                Dim query As String
                query = "select * from userinfo.userid_table where username='" & usernametxt.Text & "'and password='" & passwordtxt.Text & "'"
                command = New MySqlCommand(query, mysqlcon)
                reader = command.ExecuteReader
                Dim count As Integer
                count = 0
                While reader.Read
                    count = count + 1
                End While
                If count = 1 Then                  'check the user if they're in the database
                    Panel3.Show()                      'panel3 will contain the user details if the user has booked a room
                    Panel2.Hide()
                ElseIf count > 1 Then
                    MessageBox.Show("Username and password duplicate")           'in case there are multiple instances of the same user
                Else
                    MessageBox.Show("Enter correct username and password")       'there are no instances of the same user
                End If
                mysqlcon.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                mysqlcon.Dispose()
            End Try
            'clearing all below textboxes
            booking_notxt.Text = ""
            room_notxt.Text = ""
            contacttxt.Text = ""
            datetxt.Text = ""
            date2txt.Text = ""
            roomtype.Text = ""
            laundarytxt.Text = ""
            cleaningtxt.Text = ""
        End If
    End Sub

    Private Sub admin_login_btn_Click_1(sender As Object, e As EventArgs) Handles admin_login_btn.Click   'click on admin login
        adminpage.Show()                     'it's form 4, and contains all about admins
        Me.Hide()                            'hide me
        user_btn.BackColor = Color.Green
        info_btn.BackColor = Color.Green
        admin_login_btn.BackColor = Color.Red      'admin's button turns red
    End Sub

    Private Sub CheckBox1_CheckedChanged_1(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged 'the show password checkbox
        If passwordtxt.UseSystemPasswordChar = True Then
            passwordtxt.UseSystemPasswordChar = False
        Else
            passwordtxt.UseSystemPasswordChar = True
        End If
    End Sub
    Private Sub panel3backButton_Click(sender As Object, e As EventArgs) Handles panel3backButton.Click        'the back button in panel3
        Panel3.Hide()
        Panel2.Show()
    End Sub

    Private Sub details_btn_Click_1(sender As Object, e As EventArgs) Handles details_btn.Click       'when user clicks to find their details
        mysqlcon = New MySqlConnection
        mysqlcon.ConnectionString = "server=localhost;userid=root;password=root;database=userinfo"
        Dim reader As MySqlDataReader
        count = 0
        'checking, user has any booked room or not
        Try
            mysqlcon.Open()
            Dim query As String
            query = "select * from userinfo.userinfo_table where Webmail='" & usernametxt.Text & "'"
            command = New MySqlCommand(query, mysqlcon)
            reader = command.ExecuteReader
            While reader.Read
                count = count + 1
            End While
            mysqlcon.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            mysqlcon.Dispose()
        End Try
        'show details of user 
        If count <> 0 Then
            Try
                mysqlcon.Open()
                Dim query As String
                query = "select * from userinfo.userinfo_table where Webmail='" & usernametxt.Text & "'"
                command = New MySqlCommand(query, mysqlcon)
                reader = command.ExecuteReader
                While reader.Read
                    'taking information from userinfo_table of users
                    booking_notxt.Text = reader.GetInt32("Booking_No")
                    room_notxt.Text = reader.GetString("Room_No")
                    datetxt.Text = reader.GetString("Arrival_Date")
                    date2txt.Text = reader.GetString("end_date")
                    contacttxt.Text = reader.GetDouble("Contact_No")
                    roomtype.Text = reader.GetString("Room_type")
                    laundarytxt.Text = reader.GetString("Laundary")
                    cleaningtxt.Text = reader.GetString("Cleaning")
                End While
                mysqlcon.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                mysqlcon.Dispose()
            End Try
        Else
            'if user has not booked any room then by clicking show my details button ,then go to booking page direct
            MsgBox("You are going to booking page")
            user_details.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub checkout_btn_Click(sender As Object, e As EventArgs) Handles checkout_btn.Click      'when they click on checkout button
        mysqlcon = New MySqlConnection
        mysqlcon.ConnectionString = "server=localhost;userid=root;password=root;database=userinfo"
        Dim reader As MySqlDataReader
        Dim count As Integer, count2 As Integer
        count = 0
        count2 = 0
        'checking, user has any booked room or not
        Try
            mysqlcon.Open()
            Dim query As String
            query = "select * from userinfo.userinfo_table where Webmail='" & usernametxt.Text & "'"
            command = New MySqlCommand(query, mysqlcon)
            reader = command.ExecuteReader
            While reader.Read
                count = count + 1
                DateTimePicker2.Text = reader.GetString("end_date")         'getting departure date from database
                DateTimePicker3.Text = reader.GetString("Arrival_Date")      'getting Arrival date from database
            End While
            mysqlcon.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            mysqlcon.Dispose()
        End Try
        If count = 1 Then
            Dim dt1 As Date = DateTimePicker1.Text
            Dim dt2 As Date = DateTimePicker2.Text
            Dim ts As Integer = dt2.Subtract(dt1).Days
            Dim duration As Integer = ts + 1

            Dim dt3 As Date = DateTimePicker3.Text
            ts = dt3.Subtract(dt1).Days
            'delete the information from userinfo_table of user
            If ts > 0 Then
                MsgBox("You haven't checked in")
            Else
                If duration < 0 Then
                    MsgBox("You are already checkedout")
                Else
                    Try
                        mysqlcon.Open()
                        Dim query As String
                        query = "update userinfo.userinfo_table set end_date='" & dt1.Date & "' where Webmail='" & usernametxt.Text & "'"
                        command = New MySqlCommand(query, mysqlcon)
                        reader = command.ExecuteReader
                        mysqlcon.Close()
                    Catch ex As Exception
                        MessageBox.Show(ex.Message)
                    Finally
                        mysqlcon.Dispose()
                    End Try
                    MsgBox("You are checked out")
                End If

            End If
        Else
            MsgBox("You are already checked out")
        End If
    End Sub

    Private Sub booking_cancel_btn_Click(sender As Object, e As EventArgs) Handles booking_cancel_btn.Click   'if the user decides to cancel their booking
        mysqlcon = New MySqlConnection
        mysqlcon.ConnectionString = "server=localhost;userid=root;password=root;database=userinfo"
        Dim reader As MySqlDataReader
        Dim count As Integer, a As Integer, b As Integer
        count = 0
        'checking, user has any booked room or not
        Try
            mysqlcon.Open()
            Dim query As String
            query = "select * from userinfo.userinfo_table where Webmail='" & usernametxt.Text & "'"
            command = New MySqlCommand(query, mysqlcon)
            reader = command.ExecuteReader

            While reader.Read
                count = count + 1
            End While
            mysqlcon.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            mysqlcon.Dispose()
        End Try
        Try
            mysqlcon.Open()
            Dim query As String
            query = "select * from userinfo.userid_table where username='" & usernametxt.Text & "'"
            command = New MySqlCommand(query, mysqlcon)
            reader = command.ExecuteReader

            While reader.Read
                category = reader.GetString("Category")
            End While
            mysqlcon.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            mysqlcon.Dispose()
        End Try
        If count <> 0 Then
            Try
                mysqlcon.Open()
                Dim query As String
                query = "select * from userinfo.userinfo_table where Webmail='" & usernametxt.Text & "'"
                command = New MySqlCommand(query, mysqlcon)
                reader = command.ExecuteReader

                While reader.Read
                    DateTimePicker2.Text = reader.GetString("Arrival_Date")
                    DateTimePicker3.Text = reader.GetString("end_date")
                    a = reader.GetInt32("Laundary")
                    b = reader.GetInt32("Cleaning")
                    room.Text = reader.GetString("Room_type")                     'gets the info of the user
                End While
                mysqlcon.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                mysqlcon.Dispose()
            End Try
            'calculate the duration (in days)
            Dim dt1 As Date = DateTimePicker1.Text
            Dim dt2 As Date = DateTimePicker2.Text
            Dim ts As Integer = dt2.Subtract(dt1).Days
            Dim duration As Integer = ts + 1
            'calculate the money to be retured to the user
            dt1 = DateTimePicker2.Text
            dt2 = DateTimePicker3.Text
            ts = dt2.Subtract(dt1).Days
            Dim days As Integer = ts + 1
            Dim total As Integer
            If roomtype.Text = "Single" And category = "student" Then
                total = ss * (duration) + cleaning * Val(cleaningtxt.Text) + laundary * Val(laundarytxt.Text)
            End If
            If roomtype.Text = "Single" And (category = "proffessor" Or category = "staff") Then
                total = sp * (duration) + cleaning * Val(cleaningtxt.Text) + laundary * Val(laundarytxt.Text)
            End If
            If roomtype.Text = "Double" And category = "student" Then
                total = ds * (duration) + cleaning * Val(cleaningtxt.Text) + laundary * Val(laundarytxt.Text)
            End If
            If roomtype.Text = "Double" And (category = "proffessor" Or category = "staff") Then
                total = dp * (duration) + cleaning * Val(cleaningtxt.Text) + laundary * Val(laundarytxt.Text)
            End If

            If duration > 4 Then
                Try
                    mysqlcon.Open()
                    Dim query As String
                    query = "delete from userinfo.userinfo_table where Webmail='" & usernametxt.Text & "'"
                    command = New MySqlCommand(query, mysqlcon)
                    reader = command.ExecuteReader
                    mysqlcon.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                Finally
                    mysqlcon.Dispose()
                End Try
                Form9.Label1.Text = "Booking Canceled"                        'if duration is more than 5 days, you can cancel and get a payback
                Form9.Label2.Text = "Your Payment booking"
                Form9.Label7.Text = total
                Form9.Label4.Text = "will return back in 2 days."
                Form9.Label5.Text = "Thank You"
                Form9.Label7.Show()
                Form9.Label4.Show()
                Form9.Label5.Show()
                Form9.Label6.Show()
                Form9.Label2.Show()
                Form9.Label1.Show()
                Form9.Show()
            End If
            If duration <= 4 Then
                Form9.Label2.Hide()
                Form9.Label3.Hide()
                Form9.Label7.Hide()
                Form9.Label4.Hide()
                Form9.Label5.Hide()
                Form9.Label6.Hide()
                MsgBox("You can't cancel now")           'if it's less than 5 days, you can't cancel
            End If
        End If
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Label3.ForeColor = Color.Blue Then
            Label3.ForeColor = Color.Red
        Else
            Label3.ForeColor = Color.Blue
        End If
    End Sub

    Private Sub change_password_btn_Click(sender As Object, e As EventArgs) Handles change_password_btn.Click
        Form8.Show()
        Me.Hide()
    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint
        'clearing all textboxes
        booking_notxt.Text = ""
        room_notxt.Text = ""
        contacttxt.Text = ""
        datetxt.Text = ""
        date2txt.Text = ""
        roomtype.Text = ""
        laundarytxt.Text = ""
        cleaningtxt.Text = ""
    End Sub
End Class

