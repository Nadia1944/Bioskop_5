<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Crew
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
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.DGV2 = New System.Windows.Forms.DataGridView()
        Me.btn_simpan = New System.Windows.Forms.Button()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn_caridata = New System.Windows.Forms.Button()
        Me.btn_edit = New System.Windows.Forms.Button()
        Me.btn_input = New System.Windows.Forms.Button()
        Me.umur_crew = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.status = New System.Windows.Forms.ComboBox()
        Me.alamat = New System.Windows.Forms.RichTextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.agama = New System.Windows.Forms.ComboBox()
        Me.jenis_kelamin = New System.Windows.Forms.ComboBox()
        Me.tempat_lahir = New System.Windows.Forms.TextBox()
        Me.no_hp = New System.Windows.Forms.TextBox()
        Me.nama_crew = New System.Windows.Forms.TextBox()
        Me.id_crew = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.foto_diri = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btn_browse = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.OpenFile1 = New System.Windows.Forms.OpenFileDialog()
        Me.lblselamat = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cari = New System.Windows.Forms.TextBox()
        Me.btn_cari = New System.Windows.Forms.Button()
        CType(Me.DGV2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(635, 559)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(73, 25)
        Me.btnExit.TabIndex = 53
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(542, 361)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(73, 31)
        Me.btnCancel.TabIndex = 52
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'DGV2
        '
        Me.DGV2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV2.Location = New System.Drawing.Point(50, 444)
        Me.DGV2.Name = "DGV2"
        Me.DGV2.RowHeadersWidth = 51
        Me.DGV2.Size = New System.Drawing.Size(658, 98)
        Me.DGV2.TabIndex = 51
        '
        'btn_simpan
        '
        Me.btn_simpan.Location = New System.Drawing.Point(442, 361)
        Me.btn_simpan.Name = "btn_simpan"
        Me.btn_simpan.Size = New System.Drawing.Size(73, 31)
        Me.btn_simpan.TabIndex = 50
        Me.btn_simpan.Text = "Simpan"
        Me.btn_simpan.UseVisualStyleBackColor = True
        '
        'btn_delete
        '
        Me.btn_delete.Location = New System.Drawing.Point(630, 361)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(73, 31)
        Me.btn_delete.TabIndex = 49
        Me.btn_delete.Text = "Delete"
        Me.btn_delete.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btn_caridata)
        Me.GroupBox1.Controls.Add(Me.btn_edit)
        Me.GroupBox1.Controls.Add(Me.btn_input)
        Me.GroupBox1.Controls.Add(Me.umur_crew)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.status)
        Me.GroupBox1.Controls.Add(Me.alamat)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.agama)
        Me.GroupBox1.Controls.Add(Me.jenis_kelamin)
        Me.GroupBox1.Controls.Add(Me.tempat_lahir)
        Me.GroupBox1.Controls.Add(Me.no_hp)
        Me.GroupBox1.Controls.Add(Me.nama_crew)
        Me.GroupBox1.Controls.Add(Me.id_crew)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(51, 48)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(369, 384)
        Me.GroupBox1.TabIndex = 48
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Data Crew Ticketing"
        '
        'btn_caridata
        '
        Me.btn_caridata.Location = New System.Drawing.Point(265, 27)
        Me.btn_caridata.Name = "btn_caridata"
        Me.btn_caridata.Size = New System.Drawing.Size(75, 23)
        Me.btn_caridata.TabIndex = 61
        Me.btn_caridata.Text = "Cari Data "
        Me.btn_caridata.UseVisualStyleBackColor = True
        '
        'btn_edit
        '
        Me.btn_edit.Location = New System.Drawing.Point(265, 109)
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.Size = New System.Drawing.Size(75, 28)
        Me.btn_edit.TabIndex = 34
        Me.btn_edit.Text = "Edit"
        Me.btn_edit.UseVisualStyleBackColor = True
        '
        'btn_input
        '
        Me.btn_input.Location = New System.Drawing.Point(265, 68)
        Me.btn_input.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_input.Name = "btn_input"
        Me.btn_input.Size = New System.Drawing.Size(75, 24)
        Me.btn_input.TabIndex = 35
        Me.btn_input.Text = "Input"
        Me.btn_input.UseVisualStyleBackColor = True
        '
        'umur_crew
        '
        Me.umur_crew.Location = New System.Drawing.Point(103, 135)
        Me.umur_crew.Name = "umur_crew"
        Me.umur_crew.Size = New System.Drawing.Size(141, 20)
        Me.umur_crew.TabIndex = 30
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(11, 138)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(79, 13)
        Me.Label12.TabIndex = 29
        Me.Label12.Text = "Usia                :"
        '
        'status
        '
        Me.status.FormattingEnabled = True
        Me.status.Items.AddRange(New Object() {"Karyawan Tetap", "Karyawan Kontrak"})
        Me.status.Location = New System.Drawing.Point(104, 350)
        Me.status.Name = "status"
        Me.status.Size = New System.Drawing.Size(141, 21)
        Me.status.TabIndex = 17
        '
        'alamat
        '
        Me.alamat.Location = New System.Drawing.Point(104, 250)
        Me.alamat.Name = "alamat"
        Me.alamat.Size = New System.Drawing.Size(184, 94)
        Me.alamat.TabIndex = 16
        Me.alamat.Text = ""
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(103, 109)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(141, 20)
        Me.DateTimePicker1.TabIndex = 15
        '
        'agama
        '
        Me.agama.FormattingEnabled = True
        Me.agama.Items.AddRange(New Object() {"Islam", "Budha", "Hindhu", "Kristen"})
        Me.agama.Location = New System.Drawing.Point(103, 190)
        Me.agama.Name = "agama"
        Me.agama.Size = New System.Drawing.Size(141, 21)
        Me.agama.TabIndex = 14
        '
        'jenis_kelamin
        '
        Me.jenis_kelamin.FormattingEnabled = True
        Me.jenis_kelamin.Items.AddRange(New Object() {"Perempuan", "Laki-Laki"})
        Me.jenis_kelamin.Location = New System.Drawing.Point(103, 163)
        Me.jenis_kelamin.Name = "jenis_kelamin"
        Me.jenis_kelamin.Size = New System.Drawing.Size(141, 21)
        Me.jenis_kelamin.TabIndex = 13
        '
        'tempat_lahir
        '
        Me.tempat_lahir.Location = New System.Drawing.Point(103, 83)
        Me.tempat_lahir.Name = "tempat_lahir"
        Me.tempat_lahir.Size = New System.Drawing.Size(141, 20)
        Me.tempat_lahir.TabIndex = 12
        '
        'no_hp
        '
        Me.no_hp.Location = New System.Drawing.Point(104, 217)
        Me.no_hp.Name = "no_hp"
        Me.no_hp.Size = New System.Drawing.Size(141, 20)
        Me.no_hp.TabIndex = 11
        '
        'nama_crew
        '
        Me.nama_crew.Location = New System.Drawing.Point(103, 56)
        Me.nama_crew.Name = "nama_crew"
        Me.nama_crew.Size = New System.Drawing.Size(141, 20)
        Me.nama_crew.TabIndex = 10
        '
        'id_crew
        '
        Me.id_crew.Location = New System.Drawing.Point(103, 29)
        Me.id_crew.Name = "id_crew"
        Me.id_crew.Size = New System.Drawing.Size(141, 20)
        Me.id_crew.TabIndex = 9
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(13, 353)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(76, 13)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = "Status            :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(10, 250)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(78, 13)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "Alamat            :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(10, 220)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(78, 13)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "No HP            :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(10, 193)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(79, 13)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Agama            :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(9, 166)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 13)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Jenis Kelamin  :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(10, 115)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Tanggal Lahir  :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(10, 86)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Tempat Lahir   :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 59)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Nama Crew     :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "ID Crew           :"
        '
        'foto_diri
        '
        Me.foto_diri.Location = New System.Drawing.Point(542, 335)
        Me.foto_diri.Name = "foto_diri"
        Me.foto_diri.Size = New System.Drawing.Size(161, 20)
        Me.foto_diri.TabIndex = 57
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(439, 338)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(52, 13)
        Me.Label11.TabIndex = 56
        Me.Label11.Text = "Foto Diri :"
        '
        'btn_browse
        '
        Me.btn_browse.Location = New System.Drawing.Point(627, 298)
        Me.btn_browse.Name = "btn_browse"
        Me.btn_browse.Size = New System.Drawing.Size(76, 31)
        Me.btn_browse.TabIndex = 55
        Me.btn_browse.Text = "Browse"
        Me.btn_browse.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(442, 48)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(254, 237)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 54
        Me.PictureBox1.TabStop = False
        '
        'OpenFile1
        '
        Me.OpenFile1.FileName = "OpenFileDialog1"
        '
        'lblselamat
        '
        Me.lblselamat.AutoSize = True
        Me.lblselamat.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblselamat.Location = New System.Drawing.Point(194, 9)
        Me.lblselamat.Name = "lblselamat"
        Me.lblselamat.Size = New System.Drawing.Size(0, 33)
        Me.lblselamat.TabIndex = 59
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Modern No. 20", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(166, 9)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(114, 29)
        Me.Label13.TabIndex = 60
        Me.Label13.Text = "Welcome"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(46, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 29)
        Me.Label1.TabIndex = 61
        Me.Label1.Text = "Welcome"
        '
        'cari
        '
        Me.cari.Location = New System.Drawing.Point(440, 407)
        Me.cari.Name = "cari"
        Me.cari.Size = New System.Drawing.Size(175, 20)
        Me.cari.TabIndex = 62
        '
        'btn_cari
        '
        Me.btn_cari.Location = New System.Drawing.Point(630, 401)
        Me.btn_cari.Name = "btn_cari"
        Me.btn_cari.Size = New System.Drawing.Size(75, 31)
        Me.btn_cari.TabIndex = 63
        Me.btn_cari.Text = "Cari"
        Me.btn_cari.UseVisualStyleBackColor = True
        '
        'Crew
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(757, 587)
        Me.Controls.Add(Me.btn_cari)
        Me.Controls.Add(Me.cari)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.lblselamat)
        Me.Controls.Add(Me.foto_diri)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.btn_browse)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.DGV2)
        Me.Controls.Add(Me.btn_simpan)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Crew"
        Me.Text = "Crew"
        CType(Me.DGV2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnExit As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents DGV2 As DataGridView
    Friend WithEvents btn_simpan As Button
    Friend WithEvents btn_delete As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btn_edit As Button
    Friend WithEvents btn_input As Button
    Friend WithEvents umur_crew As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents status As ComboBox
    Friend WithEvents alamat As RichTextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents agama As ComboBox
    Friend WithEvents jenis_kelamin As ComboBox
    Friend WithEvents tempat_lahir As TextBox
    Friend WithEvents no_hp As TextBox
    Friend WithEvents nama_crew As TextBox
    Friend WithEvents id_crew As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents foto_diri As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents btn_browse As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents OpenFile1 As OpenFileDialog
    Friend WithEvents lblselamat As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents btn_caridata As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents cari As TextBox
    Friend WithEvents btn_cari As Button
End Class
