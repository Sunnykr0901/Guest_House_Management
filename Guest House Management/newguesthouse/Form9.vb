Public Class Form9

    'this shows up when you cancel the booking and assures you your money

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        mainpage.Panel2.Show()        'also takes you back home
        mainpage.Panel1.Hide()
        mainpage.Panel3.Hide()
    End Sub

    Private Sub Form9_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'hiding maximize
        Me.MaximizeBox = False
        Me.StartPosition = FormStartPosition.CenterScreen
    End Sub
End Class