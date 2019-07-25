Imports MySql.Data.MySqlClient
Public Class registereduser_details
    Dim mysqlcon As MySqlConnection
    Dim command As MySqlCommand
    Dim reader1 As MySqlDataReader
    Dim dt1 As Date
    Dim dt2 As Date
    Dim ts As Integer
    Dim duration As Integer
    Public Sub rooms_available(ByVal startdate As Date, ByVal enddate As Date, ByRef single_rooms As Integer, ByRef double_rooms As Integer)
        mysqlcon = New MySqlConnection
        single_rooms = 0
        double_rooms = 0
        mysqlcon.ConnectionString = "server=localhost;userid=root;password=root;database=userinfo"

        mysqlcon.Open()
        Dim query As String
        Dim command2 As MySqlCommand
        query = "Update userinfo.singleroom_table set Allotted = '0' "
        command2 = New MySqlCommand(query, mysqlcon)
        command2.ExecuteNonQuery()
        query = "Update userinfo.doubleroom_table set Allotted = '0' "
        command2 = New MySqlCommand(query, mysqlcon)
        command2.ExecuteNonQuery()

        'most of the following code involves taking in the alotted rooms in the time between start and end dates
        'and putting them in a combo box

        query = "select * from userinfo.userinfo_table"
        command = New MySqlCommand(query, mysqlcon)
        reader1 = command.ExecuteReader

        Dim startdatetemp As Date
        Dim enddatetemp As Date
        Dim mysqlcon2 As MySqlConnection
        mysqlcon2 = New MySqlConnection
        mysqlcon2.ConnectionString = "server=localhost;userid=root;password=root;database=userinfo"
        mysqlcon2.Open()
        While reader1.Read
            startdatetemp = CDate(reader1.GetString("Arrival_Date")).Date
            enddatetemp = CDate(reader1.GetString("end_date")).Date

            If ((startdate <= enddatetemp And startdate >= startdatetemp) Or (enddate >= startdatetemp And enddate <= enddatetemp) Or (startdate <= startdatetemp And enddate >= enddatetemp) Or (startdate >= startdatetemp And enddate <= enddatetemp)) Then
                Dim room_no As String = reader1.GetString("Room_No")

                If reader1.GetString("Room_type") = "Single" Then

                    query = "Update userinfo.singleroom_table set Allotted = '1' where Room_No= '" & room_no & "' "
                    command2 = New MySqlCommand(query, mysqlcon2)
                    command2.ExecuteNonQuery()

                Else

                    query = "Update userinfo.doubleroom_table set Allotted = '1' where Room_No= '" & room_no & "' "
                    command2 = New MySqlCommand(query, mysqlcon2)
                    command2.ExecuteNonQuery()
                End If

            End If
        End While
        mysqlcon2.Close()
        reader1.Close()
        mysqlcon.Close()


        mysqlcon.Close()

        mysqlcon.Open()
        Dim query3 As String
        Dim command3 As MySqlCommand
        query3 = "select * from userinfo.singleroom_table where Allotted='" & 0 & "'"
        command3 = New MySqlCommand(query3, mysqlcon)
        Dim reader3 As MySqlDataReader

        reader3 = command3.ExecuteReader
        While (reader3.Read)
            single_rooms = single_rooms + 1
            Dim room As String = reader3.GetString("Room_No")
            ComboBox2.Items.Add(room)
        End While
        command3.Dispose()
        query3 = "select * from userinfo.doubleroom_table where Allotted='" & 0 & "'"
        command3 = New MySqlCommand(query3, mysqlcon)
        reader3 = command3.ExecuteReader
        While (reader3.Read)
            double_rooms = double_rooms + 1
            Dim room As String = reader3.GetString("Room_No")
            ComboBox2.Items.Add(room)
        End While
        reader3.Close()
        mysqlcon.Close()

        mysqlcon.Open()
        Dim query4 As String
        Dim command4 As MySqlCommand
        query4 = "select * from userinfo.singleroom_table where Allotted='" & 1 & "'"
        command4 = New MySqlCommand(query4, mysqlcon)
        Dim reader4 As MySqlDataReader

        reader4 = command4.ExecuteReader
        While (reader4.Read)

            Dim room As String = reader4.GetString("Room_No")
            ComboBox1.Items.Add(room)
        End While
        command4.Dispose()
        query4 = "select * from userinfo.doubleroom_table where Allotted='" & 1 & "'"
        command4 = New MySqlCommand(query4, mysqlcon)
        reader4 = command4.ExecuteReader
        While (reader4.Read)

            Dim room As String = reader4.GetString("Room_No")
            ComboBox1.Items.Add(room)
        End While
        reader4.Close()
        mysqlcon.Close()
    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged   'selecting one of the options from the combobox will open the details of that person
        mysqlcon = New MySqlConnection
        mysqlcon.ConnectionString = "server=localhost;userid=root;password=root;database=userinfo"
        Dim reader As MySqlDataReader
        Try
            mysqlcon.Open()
            Dim query As String
            query = "select * from userinfo.userinfo_table where Room_No='" & ComboBox1.Text & "'"
            command = New MySqlCommand(query, mysqlcon)
            reader = command.ExecuteReader
            While reader.Read
                booking_notxt.Text = reader.GetInt32("Booking_No")
                nametxt.Text = reader.GetString("Name")
                contacttxt.Text = reader.GetDouble("Contact_No")
                date_txt.Text = reader.GetString("Arrival_Date")
                date2_txt.Text = reader.GetString("end_date")
                laundarytxt.Text = reader.GetInt32("Laundary")
                cleaningtxt.Text = reader.GetInt32("Cleaning")
            End While
            mysqlcon.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            mysqlcon.Dispose()
        End Try
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click  'if you want to log out
        MsgBox("You are logging out")
        Me.Close()
        adminpage.Close()
        mainpage.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click   'room details button
        dt1 = datetxt.Text
        dt2 = date2txt.Text
        ts = dt2.Subtract(dt1).Days
        duration = ts + 1
        If duration <= 0 Then
            MsgBox("End date should be greater than start date")         'unless, of course, you've discovered timetravel
        Else

            Label15.Show()
            Label16.Show()
            singletxt.Show()
            doubletxt.Show()
            Label13.Show()
            ComboBox1.Show()
            ComboBox2.Show()
            Label11.Show()
            Label4.Show()
            Label5.Show()
            Label6.Show()
            Label2.Show()
            Label3.Show()
            Label8.Show()
            Label9.Show()
            Label10.Show()
            booking_notxt.Show()
            nametxt.Show()
            contacttxt.Show()
            date_txt.Show()
            date2_txt.Show()
            laundarytxt.Show()
            cleaningtxt.Show()
            ComboBox1.Items.Clear()
            ComboBox2.Items.Clear()
            Dim startdate As Date = datetxt.Text
            Dim enddate As Date = date2txt.Text
            Dim single_rooms, double_rooms As Integer
            rooms_available(startdate, enddate, single_rooms, double_rooms) 'calling dunction available_rooms
            singletxt.Text = single_rooms
            doubletxt.Text = double_rooms
        End If
    End Sub

    Private Sub registereduser_details_Load(sender As Object, e As EventArgs) Handles MyBase.Load     'loads the details into the respective boxes
        Me.MaximizeBox = False
        Me.StartPosition = FormStartPosition.CenterScreen
        Label15.Hide()
        Label16.Hide()
        singletxt.Hide()
        doubletxt.Hide()
        Label13.Hide()
        ComboBox1.Hide()
        ComboBox2.Hide()
        Label11.Hide()
        Label4.Hide()
        Label5.Hide()
        Label6.Hide()
        Label2.Hide()
        Label3.Hide()
        Label8.Hide()
        Label9.Hide()
        Label10.Hide()
        booking_notxt.Hide()
        nametxt.Hide()
        contacttxt.Hide()
        date_txt.Hide()
        date2_txt.Hide()
        laundarytxt.Hide()
        cleaningtxt.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click  'this opens the offline booking page
        offline_bookingpage.Show()
        Me.Close()
        Label15.Show()
        Label16.Show()
        singletxt.Show()
        doubletxt.Show()
        Label13.Hide()
        ComboBox1.Hide()
        ComboBox2.Hide()
        Label11.Hide()
        Label4.Hide()
        Label5.Hide()
        Label6.Hide()
        Label2.Hide()
        Label3.Hide()
        Label8.Hide()
        Label9.Hide()
        Label10.Hide()
        booking_notxt.Hide()
        nametxt.Hide()
        contacttxt.Hide()
        date_txt.Hide()
        date2_txt.Hide()
        laundarytxt.Hide()
        cleaningtxt.Hide()
    End Sub
End Class