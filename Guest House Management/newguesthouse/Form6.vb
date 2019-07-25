Public Class receiptform               'clicking on logout will
    Private Sub logout_btn_Click(sender As Object, e As EventArgs) Handles logout_btn.Click
        mainpage.Show()           'take you to the main page
        Me.Close()                'and close
        user_details.Close()      'all the
        paymentform.Close()       'things
    End Sub

    Private Sub receiptform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'hideing maximize
        Me.MaximizeBox = False
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.AcceptButton = logout_btn
    End Sub
End Class