<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Receipt_Bioskop
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
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btntutup = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btncancel = New System.Windows.Forms.Button()
        Me.btnsimpan = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.jamtayang = New System.Windows.Forms.DateTimePicker()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtstudio = New System.Windows.Forms.TextBox()
        Me.txtrate = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtjumlah = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtharga = New System.Windows.Forms.TextBox()
        Me.txtidkursi = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtjudul = New System.Windows.Forms.TextBox()
        Me.txtidmovie = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtidcrew = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtchange = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtbayar = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtitems = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtgrandtotal = New System.Windows.Forms.RichTextBox()
        Me.jamtransaksi = New System.Windows.Forms.DateTimePicker()
        Me.tgltransaksi = New System.Windows.Forms.DateTimePicker()
        Me.txtnamacrew = New System.Windows.Forms.TextBox()
        Me.txtnamacust = New System.Windows.Forms.TextBox()
        Me.txtidcust = New System.Windows.Forms.TextBox()
        Me.txtidreceipt = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox3.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btntutup)
        Me.GroupBox3.Controls.Add(Me.DataGridView1)
        Me.GroupBox3.Controls.Add(Me.btncancel)
        Me.GroupBox3.Controls.Add(Me.btnsimpan)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 245)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(658, 153)
        Me.GroupBox3.TabIndex = 8
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Detail Receipt"
        '
        'btntutup
        '
        Me.btntutup.Location = New System.Drawing.Point(576, 110)
        Me.btntutup.Name = "btntutup"
        Me.btntutup.Size = New System.Drawing.Size(62, 33)
        Me.btntutup.TabIndex = 5
        Me.btntutup.Text = "TUTUP"
        Me.btntutup.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8})
        Me.DataGridView1.Location = New System.Drawing.Point(13, 19)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(544, 123)
        Me.DataGridView1.TabIndex = 0
        '
        'Column1
        '
        Me.Column1.HeaderText = "ID Movie"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "Judul"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "Rate"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.HeaderText = "Studio"
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        Me.Column5.HeaderText = "Jam Tayang"
        Me.Column5.Name = "Column5"
        '
        'Column6
        '
        Me.Column6.HeaderText = "ID Kursi"
        Me.Column6.Name = "Column6"
        '
        'Column7
        '
        Me.Column7.HeaderText = "Harga"
        Me.Column7.Name = "Column7"
        '
        'Column8
        '
        Me.Column8.HeaderText = "Jumlah"
        Me.Column8.Name = "Column8"
        '
        'btncancel
        '
        Me.btncancel.Location = New System.Drawing.Point(576, 64)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(62, 33)
        Me.btncancel.TabIndex = 4
        Me.btncancel.Text = "CANCEL"
        Me.btncancel.UseVisualStyleBackColor = True
        '
        'btnsimpan
        '
        Me.btnsimpan.Location = New System.Drawing.Point(576, 20)
        Me.btnsimpan.Name = "btnsimpan"
        Me.btnsimpan.Size = New System.Drawing.Size(62, 33)
        Me.btnsimpan.TabIndex = 3
        Me.btnsimpan.Text = "SIMPAN"
        Me.btnsimpan.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Controls.Add(Me.jamtayang)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.txtstudio)
        Me.GroupBox2.Controls.Add(Me.txtrate)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.txtjumlah)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.txtharga)
        Me.GroupBox2.Controls.Add(Me.txtidkursi)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.txtjudul)
        Me.GroupBox2.Controls.Add(Me.txtidmovie)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 165)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(658, 74)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Item"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(342, 19)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(71, 13)
        Me.Label18.TabIndex = 22
        Me.Label18.Text = "Jam Tayang :"
        '
        'jamtayang
        '
        Me.jamtayang.CustomFormat = "hh:mm:ss"
        Me.jamtayang.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.jamtayang.Location = New System.Drawing.Point(419, 16)
        Me.jamtayang.Name = "jamtayang"
        Me.jamtayang.ShowUpDown = True
        Me.jamtayang.Size = New System.Drawing.Size(73, 20)
        Me.jamtayang.TabIndex = 21
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(173, 46)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(58, 13)
        Me.Label16.TabIndex = 20
        Me.Label16.Text = "Studio      :"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(173, 20)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(57, 13)
        Me.Label17.TabIndex = 19
        Me.Label17.Text = "Rate        :"
        '
        'txtstudio
        '
        Me.txtstudio.Location = New System.Drawing.Point(231, 43)
        Me.txtstudio.Name = "txtstudio"
        Me.txtstudio.Size = New System.Drawing.Size(108, 20)
        Me.txtstudio.TabIndex = 18
        '
        'txtrate
        '
        Me.txtrate.Location = New System.Drawing.Point(231, 17)
        Me.txtrate.Name = "txtrate"
        Me.txtrate.Size = New System.Drawing.Size(108, 20)
        Me.txtrate.TabIndex = 17
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(498, 46)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(73, 13)
        Me.Label12.TabIndex = 16
        Me.Label12.Text = "Jumlah          :"
        '
        'txtjumlah
        '
        Me.txtjumlah.Location = New System.Drawing.Point(575, 40)
        Me.txtjumlah.Name = "txtjumlah"
        Me.txtjumlah.Size = New System.Drawing.Size(73, 20)
        Me.txtjumlah.TabIndex = 15
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(498, 20)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(72, 13)
        Me.Label10.TabIndex = 14
        Me.Label10.Text = "Harga           :"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(342, 45)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(71, 13)
        Me.Label11.TabIndex = 13
        Me.Label11.Text = "ID Kursi        :"
        '
        'txtharga
        '
        Me.txtharga.Location = New System.Drawing.Point(575, 15)
        Me.txtharga.Name = "txtharga"
        Me.txtharga.Size = New System.Drawing.Size(73, 20)
        Me.txtharga.TabIndex = 12
        '
        'txtidkursi
        '
        Me.txtidkursi.Location = New System.Drawing.Point(419, 42)
        Me.txtidkursi.Name = "txtidkursi"
        Me.txtidkursi.Size = New System.Drawing.Size(73, 20)
        Me.txtidkursi.TabIndex = 11
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 48)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(56, 13)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "Judul       :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 22)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 13)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "ID Movie :"
        '
        'txtjudul
        '
        Me.txtjudul.Location = New System.Drawing.Point(64, 45)
        Me.txtjudul.Name = "txtjudul"
        Me.txtjudul.Size = New System.Drawing.Size(108, 20)
        Me.txtjudul.TabIndex = 8
        '
        'txtidmovie
        '
        Me.txtidmovie.Location = New System.Drawing.Point(64, 19)
        Me.txtidmovie.Name = "txtidmovie"
        Me.txtidmovie.Size = New System.Drawing.Size(108, 20)
        Me.txtidmovie.TabIndex = 7
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtidcrew)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.txtchange)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.txtbayar)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.txtitems)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtgrandtotal)
        Me.GroupBox1.Controls.Add(Me.jamtransaksi)
        Me.GroupBox1.Controls.Add(Me.tgltransaksi)
        Me.GroupBox1.Controls.Add(Me.txtnamacrew)
        Me.GroupBox1.Controls.Add(Me.txtnamacust)
        Me.GroupBox1.Controls.Add(Me.txtidcust)
        Me.GroupBox1.Controls.Add(Me.txtidreceipt)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(658, 147)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Receipt"
        '
        'txtidcrew
        '
        Me.txtidcrew.Location = New System.Drawing.Point(100, 67)
        Me.txtidcrew.Name = "txtidcrew"
        Me.txtidcrew.Size = New System.Drawing.Size(108, 20)
        Me.txtidcrew.TabIndex = 22
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(6, 70)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(87, 13)
        Me.Label19.TabIndex = 21
        Me.Label19.Text = "ID Crew             :"
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(472, 19)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(171, 46)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 20
        Me.PictureBox1.TabStop = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(236, 111)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(89, 13)
        Me.Label15.TabIndex = 19
        Me.Label15.Text = "Change              :"
        '
        'txtchange
        '
        Me.txtchange.Location = New System.Drawing.Point(325, 108)
        Me.txtchange.Name = "txtchange"
        Me.txtchange.Size = New System.Drawing.Size(108, 20)
        Me.txtchange.TabIndex = 18
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(236, 88)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(88, 13)
        Me.Label14.TabIndex = 17
        Me.Label14.Text = "Bayar                 :"
        '
        'txtbayar
        '
        Me.txtbayar.Location = New System.Drawing.Point(325, 85)
        Me.txtbayar.Name = "txtbayar"
        Me.txtbayar.Size = New System.Drawing.Size(108, 20)
        Me.txtbayar.TabIndex = 16
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(236, 66)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(89, 13)
        Me.Label13.TabIndex = 15
        Me.Label13.Text = "Items                  :"
        '
        'txtitems
        '
        Me.txtitems.Location = New System.Drawing.Point(325, 63)
        Me.txtitems.Name = "txtitems"
        Me.txtitems.Size = New System.Drawing.Size(108, 20)
        Me.txtitems.TabIndex = 14
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(231, 23)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(88, 24)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Total Rp"
        '
        'txtgrandtotal
        '
        Me.txtgrandtotal.Location = New System.Drawing.Point(325, 19)
        Me.txtgrandtotal.Name = "txtgrandtotal"
        Me.txtgrandtotal.Size = New System.Drawing.Size(108, 39)
        Me.txtgrandtotal.TabIndex = 12
        Me.txtgrandtotal.Text = ""
        '
        'jamtransaksi
        '
        Me.jamtransaksi.CustomFormat = "hh:mm:ss"
        Me.jamtransaksi.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.jamtransaksi.Location = New System.Drawing.Point(534, 104)
        Me.jamtransaksi.Name = "jamtransaksi"
        Me.jamtransaksi.ShowUpDown = True
        Me.jamtransaksi.Size = New System.Drawing.Size(109, 20)
        Me.jamtransaksi.TabIndex = 11
        '
        'tgltransaksi
        '
        Me.tgltransaksi.Location = New System.Drawing.Point(534, 81)
        Me.tgltransaksi.Name = "tgltransaksi"
        Me.tgltransaksi.Size = New System.Drawing.Size(109, 20)
        Me.tgltransaksi.TabIndex = 10
        '
        'txtnamacrew
        '
        Me.txtnamacrew.Location = New System.Drawing.Point(100, 113)
        Me.txtnamacrew.Name = "txtnamacrew"
        Me.txtnamacrew.Size = New System.Drawing.Size(108, 20)
        Me.txtnamacrew.TabIndex = 9
        '
        'txtnamacust
        '
        Me.txtnamacust.Location = New System.Drawing.Point(100, 90)
        Me.txtnamacust.Name = "txtnamacust"
        Me.txtnamacust.Size = New System.Drawing.Size(108, 20)
        Me.txtnamacust.TabIndex = 8
        '
        'txtidcust
        '
        Me.txtidcust.Location = New System.Drawing.Point(100, 45)
        Me.txtidcust.Name = "txtidcust"
        Me.txtidcust.Size = New System.Drawing.Size(108, 20)
        Me.txtidcust.TabIndex = 7
        '
        'txtidreceipt
        '
        Me.txtidreceipt.Location = New System.Drawing.Point(100, 23)
        Me.txtidreceipt.Name = "txtidreceipt"
        Me.txtidreceipt.Size = New System.Drawing.Size(108, 20)
        Me.txtidreceipt.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(469, 110)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Waktu       :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(469, 85)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Tanggal    :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 116)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Nama Crew        :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 93)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nama Customer :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "ID Customer       :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID Receipt         :"
        '
        'Timer1
        '
        '
        'Receipt_Bioskop
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(686, 414)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Receipt_Bioskop"
        Me.Text = "Receipt Bioskop"
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btntutup As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents btncancel As Button
    Friend WithEvents btnsimpan As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label18 As Label
    Friend WithEvents jamtayang As DateTimePicker
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents txtstudio As TextBox
    Friend WithEvents txtrate As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtjumlah As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txtharga As TextBox
    Friend WithEvents txtidkursi As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtjudul As TextBox
    Friend WithEvents txtidmovie As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label15 As Label
    Friend WithEvents txtchange As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents txtbayar As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txtitems As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtgrandtotal As RichTextBox
    Friend WithEvents jamtransaksi As DateTimePicker
    Friend WithEvents tgltransaksi As DateTimePicker
    Friend WithEvents txtnamacrew As TextBox
    Friend WithEvents txtnamacust As TextBox
    Friend WithEvents txtidcust As TextBox
    Friend WithEvents txtidreceipt As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents txtidcrew As TextBox
    Friend WithEvents Label19 As Label
End Class
