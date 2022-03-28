<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Receipt
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
        Me.components = New System.ComponentModel.Container()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.tgltayang = New System.Windows.Forms.DateTimePicker()
        Me.jamtayang = New System.Windows.Forms.DateTimePicker()
        Me.txtnamacustomer = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtidcustomer = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtGrandtotal = New System.Windows.Forms.TextBox()
        Me.txtcrew = New System.Windows.Forms.TextBox()
        Me.txtidcrew = New System.Windows.Forms.TextBox()
        Me.txtidreceipt = New System.Windows.Forms.TextBox()
        Me.Total = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtjumlah = New System.Windows.Forms.TextBox()
        Me.txtharga = New System.Windows.Forms.TextBox()
        Me.txtjudul = New System.Windows.Forms.TextBox()
        Me.txt_IdMovie = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtsubtotal = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnhitung = New System.Windows.Forms.Button()
        Me.Change = New System.Windows.Forms.Label()
        Me.txtchange = New System.Windows.Forms.TextBox()
        Me.txtbayar = New System.Windows.Forms.TextBox()
        Me.txtitems = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.btn_tutup = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.tgltayang)
        Me.GroupBox1.Controls.Add(Me.jamtayang)
        Me.GroupBox1.Controls.Add(Me.txtnamacustomer)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.txtidcustomer)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.txtGrandtotal)
        Me.GroupBox1.Controls.Add(Me.txtcrew)
        Me.GroupBox1.Controls.Add(Me.txtidcrew)
        Me.GroupBox1.Controls.Add(Me.txtidreceipt)
        Me.GroupBox1.Controls.Add(Me.Total)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(36, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(807, 192)
        Me.GroupBox1.TabIndex = 22
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Receipt"
        '
        'tgltayang
        '
        Me.tgltayang.Location = New System.Drawing.Point(633, 73)
        Me.tgltayang.Name = "tgltayang"
        Me.tgltayang.Size = New System.Drawing.Size(151, 20)
        Me.tgltayang.TabIndex = 26
        '
        'jamtayang
        '
        Me.jamtayang.CustomFormat = "hh:mm:ss"
        Me.jamtayang.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.jamtayang.Location = New System.Drawing.Point(633, 99)
        Me.jamtayang.Name = "jamtayang"
        Me.jamtayang.ShowUpDown = True
        Me.jamtayang.Size = New System.Drawing.Size(151, 20)
        Me.jamtayang.TabIndex = 25
        '
        'txtnamacustomer
        '
        Me.txtnamacustomer.Location = New System.Drawing.Point(119, 125)
        Me.txtnamacustomer.Name = "txtnamacustomer"
        Me.txtnamacustomer.Size = New System.Drawing.Size(151, 20)
        Me.txtnamacustomer.TabIndex = 21
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(8, 128)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(82, 13)
        Me.Label16.TabIndex = 20
        Me.Label16.Text = "Nama Customer"
        '
        'txtidcustomer
        '
        Me.txtidcustomer.Location = New System.Drawing.Point(119, 89)
        Me.txtidcustomer.Name = "txtidcustomer"
        Me.txtidcustomer.Size = New System.Drawing.Size(151, 20)
        Me.txtidcustomer.TabIndex = 19
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(8, 92)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(65, 13)
        Me.Label15.TabIndex = 18
        Me.Label15.Text = "ID Customer"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(8, 60)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(0, 13)
        Me.Label14.TabIndex = 17
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(332, 66)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(184, 79)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 16
        Me.PictureBox1.TabStop = False
        '
        'txtGrandtotal
        '
        Me.txtGrandtotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGrandtotal.Location = New System.Drawing.Point(529, 15)
        Me.txtGrandtotal.Name = "txtGrandtotal"
        Me.txtGrandtotal.Size = New System.Drawing.Size(255, 47)
        Me.txtGrandtotal.TabIndex = 15
        '
        'txtcrew
        '
        Me.txtcrew.Location = New System.Drawing.Point(633, 128)
        Me.txtcrew.Name = "txtcrew"
        Me.txtcrew.Size = New System.Drawing.Size(151, 20)
        Me.txtcrew.TabIndex = 14
        '
        'txtidcrew
        '
        Me.txtidcrew.Location = New System.Drawing.Point(119, 57)
        Me.txtidcrew.Name = "txtidcrew"
        Me.txtidcrew.Size = New System.Drawing.Size(151, 20)
        Me.txtidcrew.TabIndex = 10
        '
        'txtidreceipt
        '
        Me.txtidreceipt.Location = New System.Drawing.Point(119, 25)
        Me.txtidreceipt.Name = "txtidreceipt"
        Me.txtidreceipt.Size = New System.Drawing.Size(151, 20)
        Me.txtidreceipt.TabIndex = 8
        '
        'Total
        '
        Me.Total.AutoSize = True
        Me.Total.Font = New System.Drawing.Font("Century Schoolbook", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Total.Location = New System.Drawing.Point(347, 25)
        Me.Total.Name = "Total"
        Me.Total.Size = New System.Drawing.Size(169, 23)
        Me.Total.TabIndex = 7
        Me.Total.Text = "Total Harga Rp."
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(567, 131)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(31, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Crew"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(567, 105)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Waktu"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(563, 79)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Tanggal"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 60)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "ID Crew"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 13)
        Me.Label2.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID Receipt"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtjumlah)
        Me.GroupBox2.Controls.Add(Me.txtharga)
        Me.GroupBox2.Controls.Add(Me.txtjudul)
        Me.GroupBox2.Controls.Add(Me.txt_IdMovie)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Location = New System.Drawing.Point(36, 210)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(807, 60)
        Me.GroupBox2.TabIndex = 24
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Item Pembelian"
        '
        'txtjumlah
        '
        Me.txtjumlah.Location = New System.Drawing.Point(715, 27)
        Me.txtjumlah.Name = "txtjumlah"
        Me.txtjumlah.Size = New System.Drawing.Size(69, 20)
        Me.txtjumlah.TabIndex = 12
        '
        'txtharga
        '
        Me.txtharga.Location = New System.Drawing.Point(512, 24)
        Me.txtharga.Name = "txtharga"
        Me.txtharga.Size = New System.Drawing.Size(114, 20)
        Me.txtharga.TabIndex = 11
        '
        'txtjudul
        '
        Me.txtjudul.Location = New System.Drawing.Point(308, 24)
        Me.txtjudul.Name = "txtjudul"
        Me.txtjudul.Size = New System.Drawing.Size(128, 20)
        Me.txtjudul.TabIndex = 10
        '
        'txt_IdMovie
        '
        Me.txt_IdMovie.Location = New System.Drawing.Point(110, 22)
        Me.txt_IdMovie.Name = "txt_IdMovie"
        Me.txt_IdMovie.Size = New System.Drawing.Size(107, 20)
        Me.txt_IdMovie.TabIndex = 9
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(632, 28)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(77, 19)
        Me.Label12.TabIndex = 3
        Me.Label12.Text = "Jumlah "
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(442, 25)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(61, 19)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "Harga"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(239, 22)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(63, 19)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "Judul "
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(5, 22)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(85, 19)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "ID Movie"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.DataGridView1)
        Me.GroupBox3.Location = New System.Drawing.Point(36, 276)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(807, 113)
        Me.GroupBox3.TabIndex = 25
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Detail Pembelian"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column6})
        Me.DataGridView1.Location = New System.Drawing.Point(6, 19)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.Size = New System.Drawing.Size(772, 81)
        Me.DataGridView1.TabIndex = 16
        '
        'Column1
        '
        Me.Column1.HeaderText = "ID Movie"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 125
        '
        'Column2
        '
        Me.Column2.HeaderText = "Judul"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 125
        '
        'Column3
        '
        Me.Column3.HeaderText = "Harga"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 125
        '
        'Column4
        '
        Me.Column4.HeaderText = "Jumlah "
        Me.Column4.MinimumWidth = 6
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 125
        '
        'Column6
        '
        Me.Column6.HeaderText = "Sub Total"
        Me.Column6.MinimumWidth = 6
        Me.Column6.Name = "Column6"
        Me.Column6.Width = 125
        '
        'txtsubtotal
        '
        Me.txtsubtotal.Location = New System.Drawing.Point(429, 449)
        Me.txtsubtotal.Name = "txtsubtotal"
        Me.txtsubtotal.Size = New System.Drawing.Size(114, 20)
        Me.txtsubtotal.TabIndex = 51
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(332, 447)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(91, 19)
        Me.Label8.TabIndex = 50
        Me.Label8.Text = "Sub Total"
        '
        'btnhitung
        '
        Me.btnhitung.Location = New System.Drawing.Point(36, 407)
        Me.btnhitung.Name = "btnhitung"
        Me.btnhitung.Size = New System.Drawing.Size(75, 33)
        Me.btnhitung.TabIndex = 49
        Me.btnhitung.Text = "Hitung"
        Me.btnhitung.UseVisualStyleBackColor = True
        '
        'Change
        '
        Me.Change.AutoSize = True
        Me.Change.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Change.Location = New System.Drawing.Point(593, 449)
        Me.Change.Name = "Change"
        Me.Change.Size = New System.Drawing.Size(72, 19)
        Me.Change.TabIndex = 46
        Me.Change.Text = "Change"
        '
        'txtchange
        '
        Me.txtchange.Location = New System.Drawing.Point(700, 446)
        Me.txtchange.Name = "txtchange"
        Me.txtchange.Size = New System.Drawing.Size(137, 20)
        Me.txtchange.TabIndex = 44
        '
        'txtbayar
        '
        Me.txtbayar.Location = New System.Drawing.Point(699, 406)
        Me.txtbayar.Name = "txtbayar"
        Me.txtbayar.Size = New System.Drawing.Size(138, 20)
        Me.txtbayar.TabIndex = 41
        '
        'txtitems
        '
        Me.txtitems.Location = New System.Drawing.Point(429, 410)
        Me.txtitems.Name = "txtitems"
        Me.txtitems.Size = New System.Drawing.Size(114, 20)
        Me.txtitems.TabIndex = 40
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(334, 411)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(55, 19)
        Me.Label13.TabIndex = 39
        Me.Label13.Text = "Items"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(593, 410)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(59, 19)
        Me.Label17.TabIndex = 42
        Me.Label17.Text = "Bayar"
        '
        'btn_tutup
        '
        Me.btn_tutup.Location = New System.Drawing.Point(146, 451)
        Me.btn_tutup.Name = "btn_tutup"
        Me.btn_tutup.Size = New System.Drawing.Size(75, 33)
        Me.btn_tutup.TabIndex = 45
        Me.btn_tutup.Text = "Tutup"
        Me.btn_tutup.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(38, 451)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 33)
        Me.btnCancel.TabIndex = 43
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btn_save
        '
        Me.btn_save.Location = New System.Drawing.Point(146, 406)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(75, 33)
        Me.btn_save.TabIndex = 38
        Me.btn_save.Text = "Simpan"
        Me.btn_save.UseVisualStyleBackColor = True
        '
        'Receipt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(878, 494)
        Me.Controls.Add(Me.txtsubtotal)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btnhitung)
        Me.Controls.Add(Me.Change)
        Me.Controls.Add(Me.txtchange)
        Me.Controls.Add(Me.txtbayar)
        Me.Controls.Add(Me.txtitems)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.btn_tutup)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btn_save)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Receipt"
        Me.Text = "Receipt"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtnamacustomer As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents txtidcustomer As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtGrandtotal As TextBox
    Friend WithEvents txtcrew As TextBox
    Friend WithEvents txtidcrew As TextBox
    Friend WithEvents txtidreceipt As TextBox
    Friend WithEvents Total As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtjumlah As TextBox
    Friend WithEvents txtharga As TextBox
    Friend WithEvents txtjudul As TextBox
    Friend WithEvents txt_IdMovie As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents txtsubtotal As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents btnhitung As Button
    Friend WithEvents Change As Label
    Friend WithEvents txtchange As TextBox
    Friend WithEvents txtbayar As TextBox
    Friend WithEvents txtitems As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents btn_tutup As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents btn_save As Button
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Timer1 As Timer
    Friend WithEvents jamtayang As DateTimePicker
    Friend WithEvents tgltayang As DateTimePicker
End Class
