<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class offline_bookingpage
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.book_btn = New System.Windows.Forms.Button()
        Me.Back = New System.Windows.Forms.Button()
        Me.nametxt = New System.Windows.Forms.TextBox()
        Me.addresstxt = New System.Windows.Forms.TextBox()
        Me.contacttxt = New System.Windows.Forms.TextBox()
        Me.purposetxt = New System.Windows.Forms.TextBox()
        Me.roomtype = New System.Windows.Forms.ComboBox()
        Me.datetxt = New System.Windows.Forms.DateTimePicker()
        Me.date2txt = New System.Windows.Forms.DateTimePicker()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Laundarytxt = New System.Windows.Forms.ComboBox()
        Me.cleaningtxt = New System.Windows.Forms.ComboBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.webmailtxt = New System.Windows.Forms.ComboBox()
        Me.category = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Font = New System.Drawing.Font("Lucida Fax", 28.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(420, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(499, 57)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "IITG GUEST HOUSE"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Font = New System.Drawing.Font("Lucida Fax", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Gray
        Me.Label2.Location = New System.Drawing.Point(138, 124)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "* Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Font = New System.Drawing.Font("Lucida Fax", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Gray
        Me.Label3.Location = New System.Drawing.Point(135, 174)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = " * Address"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Font = New System.Drawing.Font("Lucida Fax", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Gray
        Me.Label4.Location = New System.Drawing.Point(138, 222)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(122, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "* Contact No"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label5.Font = New System.Drawing.Font("Lucida Fax", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Gray
        Me.Label5.Location = New System.Drawing.Point(138, 272)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(173, 20)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "* Purpose Of Visit"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label6.Font = New System.Drawing.Font("Lucida Fax", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Gray
        Me.Label6.Location = New System.Drawing.Point(138, 317)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(154, 20)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "* Date of arrival"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label7.Font = New System.Drawing.Font("Lucida Fax", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Gray
        Me.Label7.Location = New System.Drawing.Point(135, 366)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(186, 20)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "* Date of Departure"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label8.Font = New System.Drawing.Font("Lucida Fax", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Gray
        Me.Label8.Location = New System.Drawing.Point(138, 417)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(125, 20)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "* Room Type"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label10.Font = New System.Drawing.Font("Lucida Fax", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Gray
        Me.Label10.Location = New System.Drawing.Point(138, 470)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(99, 20)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "* Webmail"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label11.Font = New System.Drawing.Font("Lucida Fax", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Gray
        Me.Label11.Location = New System.Drawing.Point(821, 368)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(370, 20)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "No of days the following services taken"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label12.Font = New System.Drawing.Font("Lucida Fax", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Gray
        Me.Label12.Location = New System.Drawing.Point(856, 413)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(108, 20)
        Me.Label12.TabIndex = 11
        Me.Label12.Text = "* Laundary"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label13.Font = New System.Drawing.Font("Lucida Fax", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Gray
        Me.Label13.Location = New System.Drawing.Point(856, 462)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(102, 20)
        Me.Label13.TabIndex = 12
        Me.Label13.Text = "* Cleaning"
        '
        'book_btn
        '
        Me.book_btn.BackColor = System.Drawing.Color.Lime
        Me.book_btn.Font = New System.Drawing.Font("Lucida Fax", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.book_btn.Location = New System.Drawing.Point(548, 584)
        Me.book_btn.Name = "book_btn"
        Me.book_btn.Size = New System.Drawing.Size(113, 44)
        Me.book_btn.TabIndex = 11
        Me.book_btn.Text = "Book"
        Me.book_btn.UseVisualStyleBackColor = False
        '
        'Back
        '
        Me.Back.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Back.Font = New System.Drawing.Font("Lucida Fax", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Back.Location = New System.Drawing.Point(958, 590)
        Me.Back.Name = "Back"
        Me.Back.Size = New System.Drawing.Size(104, 32)
        Me.Back.TabIndex = 12
        Me.Back.Text = "Back"
        Me.Back.UseVisualStyleBackColor = False
        '
        'nametxt
        '
        Me.nametxt.Font = New System.Drawing.Font("Lucida Fax", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nametxt.Location = New System.Drawing.Point(331, 116)
        Me.nametxt.Name = "nametxt"
        Me.nametxt.Size = New System.Drawing.Size(329, 28)
        Me.nametxt.TabIndex = 1
        '
        'addresstxt
        '
        Me.addresstxt.Font = New System.Drawing.Font("Lucida Fax", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addresstxt.Location = New System.Drawing.Point(331, 166)
        Me.addresstxt.Name = "addresstxt"
        Me.addresstxt.Size = New System.Drawing.Size(588, 28)
        Me.addresstxt.TabIndex = 2
        '
        'contacttxt
        '
        Me.contacttxt.Font = New System.Drawing.Font("Lucida Fax", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.contacttxt.Location = New System.Drawing.Point(332, 213)
        Me.contacttxt.Name = "contacttxt"
        Me.contacttxt.Size = New System.Drawing.Size(329, 28)
        Me.contacttxt.TabIndex = 3
        '
        'purposetxt
        '
        Me.purposetxt.Font = New System.Drawing.Font("Lucida Fax", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.purposetxt.Location = New System.Drawing.Point(332, 263)
        Me.purposetxt.Name = "purposetxt"
        Me.purposetxt.Size = New System.Drawing.Size(419, 28)
        Me.purposetxt.TabIndex = 4
        '
        'roomtype
        '
        Me.roomtype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.roomtype.Font = New System.Drawing.Font("Lucida Fax", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.roomtype.FormattingEnabled = True
        Me.roomtype.Items.AddRange(New Object() {"Single", "Double"})
        Me.roomtype.Location = New System.Drawing.Point(331, 411)
        Me.roomtype.Name = "roomtype"
        Me.roomtype.Size = New System.Drawing.Size(121, 28)
        Me.roomtype.TabIndex = 7
        '
        'datetxt
        '
        Me.datetxt.Font = New System.Drawing.Font("Lucida Fax", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.datetxt.Location = New System.Drawing.Point(332, 311)
        Me.datetxt.Name = "datetxt"
        Me.datetxt.Size = New System.Drawing.Size(345, 28)
        Me.datetxt.TabIndex = 5
        '
        'date2txt
        '
        Me.date2txt.Font = New System.Drawing.Font("Lucida Fax", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.date2txt.Location = New System.Drawing.Point(332, 360)
        Me.date2txt.Name = "date2txt"
        Me.date2txt.Size = New System.Drawing.Size(345, 28)
        Me.date2txt.TabIndex = 6
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button1.Font = New System.Drawing.Font("Lucida Fax", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(893, 298)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(243, 43)
        Me.Button1.TabIndex = 26
        Me.Button1.Text = "Available rooms"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Laundarytxt
        '
        Me.Laundarytxt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Laundarytxt.Font = New System.Drawing.Font("Lucida Fax", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Laundarytxt.FormattingEnabled = True
        Me.Laundarytxt.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5"})
        Me.Laundarytxt.Location = New System.Drawing.Point(988, 413)
        Me.Laundarytxt.Name = "Laundarytxt"
        Me.Laundarytxt.Size = New System.Drawing.Size(74, 31)
        Me.Laundarytxt.TabIndex = 9
        '
        'cleaningtxt
        '
        Me.cleaningtxt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cleaningtxt.Font = New System.Drawing.Font("Lucida Fax", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cleaningtxt.FormattingEnabled = True
        Me.cleaningtxt.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5"})
        Me.cleaningtxt.Location = New System.Drawing.Point(988, 464)
        Me.cleaningtxt.Name = "cleaningtxt"
        Me.cleaningtxt.Size = New System.Drawing.Size(74, 31)
        Me.cleaningtxt.TabIndex = 10
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(991, 59)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 22)
        Me.DateTimePicker1.TabIndex = 29
        '
        'webmailtxt
        '
        Me.webmailtxt.Font = New System.Drawing.Font("Lucida Fax", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.webmailtxt.FormattingEnabled = True
        Me.webmailtxt.Items.AddRange(New Object() {"Outsider"})
        Me.webmailtxt.Location = New System.Drawing.Point(331, 464)
        Me.webmailtxt.Name = "webmailtxt"
        Me.webmailtxt.Size = New System.Drawing.Size(346, 31)
        Me.webmailtxt.TabIndex = 8
        '
        'category
        '
        Me.category.Font = New System.Drawing.Font("Lucida Fax", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.category.FormattingEnabled = True
        Me.category.Items.AddRange(New Object() {"student", "proffessor", "staff", "None"})
        Me.category.Location = New System.Drawing.Point(332, 524)
        Me.category.Name = "category"
        Me.category.Size = New System.Drawing.Size(121, 28)
        Me.category.TabIndex = 30
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Lucida Fax", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Gray
        Me.Label9.Location = New System.Drawing.Point(138, 524)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(103, 20)
        Me.Label9.TabIndex = 31
        Me.Label9.Text = "* Category"
        '
        'offline_bookingpage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(1269, 673)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.category)
        Me.Controls.Add(Me.webmailtxt)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.cleaningtxt)
        Me.Controls.Add(Me.Laundarytxt)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.date2txt)
        Me.Controls.Add(Me.datetxt)
        Me.Controls.Add(Me.roomtype)
        Me.Controls.Add(Me.purposetxt)
        Me.Controls.Add(Me.contacttxt)
        Me.Controls.Add(Me.addresstxt)
        Me.Controls.Add(Me.nametxt)
        Me.Controls.Add(Me.Back)
        Me.Controls.Add(Me.book_btn)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "offline_bookingpage"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents book_btn As System.Windows.Forms.Button
    Friend WithEvents Back As System.Windows.Forms.Button
    Friend WithEvents nametxt As System.Windows.Forms.TextBox
    Friend WithEvents addresstxt As System.Windows.Forms.TextBox
    Friend WithEvents contacttxt As System.Windows.Forms.TextBox
    Friend WithEvents purposetxt As System.Windows.Forms.TextBox
    Friend WithEvents roomtype As System.Windows.Forms.ComboBox
    Friend WithEvents datetxt As System.Windows.Forms.DateTimePicker
    Friend WithEvents date2txt As System.Windows.Forms.DateTimePicker
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Laundarytxt As System.Windows.Forms.ComboBox
    Friend WithEvents cleaningtxt As System.Windows.Forms.ComboBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents webmailtxt As System.Windows.Forms.ComboBox
    Friend WithEvents category As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
End Class
