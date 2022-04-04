<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ticket
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
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btn_exit = New System.Windows.Forms.Button()
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.btn_edit = New System.Windows.Forms.Button()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.btn_input = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DGV = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.jamtayang = New System.Windows.Forms.DateTimePicker()
        Me.txtharga = New System.Windows.Forms.TextBox()
        Me.txtidkursi = New System.Windows.Forms.TextBox()
        Me.tgltayang = New System.Windows.Forms.DateTimePicker()
        Me.txtstudiomovie = New System.Windows.Forms.TextBox()
        Me.txtrate = New System.Windows.Forms.TextBox()
        Me.txtjudul = New System.Windows.Forms.TextBox()
        Me.txtidmovie = New System.Windows.Forms.TextBox()
        Me.txtnamacrew = New System.Windows.Forms.TextBox()
        Me.txtidcrew = New System.Windows.Forms.TextBox()
        Me.txtidreceipt = New System.Windows.Forms.TextBox()
        Me.txtidticket = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btn_exit)
        Me.GroupBox3.Controls.Add(Me.btn_cancel)
        Me.GroupBox3.Controls.Add(Me.btn_delete)
        Me.GroupBox3.Controls.Add(Me.btn_edit)
        Me.GroupBox3.Controls.Add(Me.btn_save)
        Me.GroupBox3.Controls.Add(Me.btn_input)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 371)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(233, 76)
        Me.GroupBox3.TabIndex = 8
        Me.GroupBox3.TabStop = False
        '
        'btn_exit
        '
        Me.btn_exit.Location = New System.Drawing.Point(156, 44)
        Me.btn_exit.Name = "btn_exit"
        Me.btn_exit.Size = New System.Drawing.Size(61, 23)
        Me.btn_exit.TabIndex = 5
        Me.btn_exit.Text = "EXIT"
        Me.btn_exit.UseVisualStyleBackColor = True
        '
        'btn_cancel
        '
        Me.btn_cancel.Location = New System.Drawing.Point(82, 44)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(61, 23)
        Me.btn_cancel.TabIndex = 4
        Me.btn_cancel.Text = "CANCEL"
        Me.btn_cancel.UseVisualStyleBackColor = True
        '
        'btn_delete
        '
        Me.btn_delete.Location = New System.Drawing.Point(9, 44)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(61, 23)
        Me.btn_delete.TabIndex = 3
        Me.btn_delete.Text = "DELETE"
        Me.btn_delete.UseVisualStyleBackColor = True
        '
        'btn_edit
        '
        Me.btn_edit.Location = New System.Drawing.Point(156, 15)
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.Size = New System.Drawing.Size(61, 23)
        Me.btn_edit.TabIndex = 2
        Me.btn_edit.Text = "EDIT"
        Me.btn_edit.UseVisualStyleBackColor = True
        '
        'btn_save
        '
        Me.btn_save.Location = New System.Drawing.Point(82, 15)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(61, 23)
        Me.btn_save.TabIndex = 1
        Me.btn_save.Text = "SAVE"
        Me.btn_save.UseVisualStyleBackColor = True
        '
        'btn_input
        '
        Me.btn_input.Location = New System.Drawing.Point(9, 15)
        Me.btn_input.Name = "btn_input"
        Me.btn_input.Size = New System.Drawing.Size(61, 23)
        Me.btn_input.TabIndex = 0
        Me.btn_input.Text = "INPUT"
        Me.btn_input.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DGV)
        Me.GroupBox2.Location = New System.Drawing.Point(264, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(365, 435)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Detail Ticket"
        '
        'DGV
        '
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV.Location = New System.Drawing.Point(15, 22)
        Me.DGV.Name = "DGV"
        Me.DGV.Size = New System.Drawing.Size(333, 404)
        Me.DGV.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.jamtayang)
        Me.GroupBox1.Controls.Add(Me.txtharga)
        Me.GroupBox1.Controls.Add(Me.txtidkursi)
        Me.GroupBox1.Controls.Add(Me.tgltayang)
        Me.GroupBox1.Controls.Add(Me.txtstudiomovie)
        Me.GroupBox1.Controls.Add(Me.txtrate)
        Me.GroupBox1.Controls.Add(Me.txtjudul)
        Me.GroupBox1.Controls.Add(Me.txtidmovie)
        Me.GroupBox1.Controls.Add(Me.txtnamacrew)
        Me.GroupBox1.Controls.Add(Me.txtidcrew)
        Me.GroupBox1.Controls.Add(Me.txtidreceipt)
        Me.GroupBox1.Controls.Add(Me.txtidticket)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(234, 353)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ticket Data"
        '
        'jamtayang
        '
        Me.jamtayang.CustomFormat = "hh:mm:ss"
        Me.jamtayang.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.jamtayang.Location = New System.Drawing.Point(109, 259)
        Me.jamtayang.Name = "jamtayang"
        Me.jamtayang.ShowUpDown = True
        Me.jamtayang.Size = New System.Drawing.Size(109, 20)
        Me.jamtayang.TabIndex = 24
        '
        'txtharga
        '
        Me.txtharga.Location = New System.Drawing.Point(109, 311)
        Me.txtharga.Name = "txtharga"
        Me.txtharga.Size = New System.Drawing.Size(109, 20)
        Me.txtharga.TabIndex = 23
        '
        'txtidkursi
        '
        Me.txtidkursi.Location = New System.Drawing.Point(109, 285)
        Me.txtidkursi.Name = "txtidkursi"
        Me.txtidkursi.Size = New System.Drawing.Size(109, 20)
        Me.txtidkursi.TabIndex = 22
        '
        'tgltayang
        '
        Me.tgltayang.Location = New System.Drawing.Point(109, 233)
        Me.tgltayang.Name = "tgltayang"
        Me.tgltayang.Size = New System.Drawing.Size(109, 20)
        Me.tgltayang.TabIndex = 21
        '
        'txtstudiomovie
        '
        Me.txtstudiomovie.Location = New System.Drawing.Point(109, 207)
        Me.txtstudiomovie.Name = "txtstudiomovie"
        Me.txtstudiomovie.Size = New System.Drawing.Size(109, 20)
        Me.txtstudiomovie.TabIndex = 19
        '
        'txtrate
        '
        Me.txtrate.Location = New System.Drawing.Point(109, 181)
        Me.txtrate.Name = "txtrate"
        Me.txtrate.Size = New System.Drawing.Size(109, 20)
        Me.txtrate.TabIndex = 18
        '
        'txtjudul
        '
        Me.txtjudul.Location = New System.Drawing.Point(109, 155)
        Me.txtjudul.Name = "txtjudul"
        Me.txtjudul.Size = New System.Drawing.Size(109, 20)
        Me.txtjudul.TabIndex = 17
        '
        'txtidmovie
        '
        Me.txtidmovie.Location = New System.Drawing.Point(109, 129)
        Me.txtidmovie.Name = "txtidmovie"
        Me.txtidmovie.Size = New System.Drawing.Size(109, 20)
        Me.txtidmovie.TabIndex = 16
        '
        'txtnamacrew
        '
        Me.txtnamacrew.Location = New System.Drawing.Point(109, 103)
        Me.txtnamacrew.Name = "txtnamacrew"
        Me.txtnamacrew.Size = New System.Drawing.Size(109, 20)
        Me.txtnamacrew.TabIndex = 15
        '
        'txtidcrew
        '
        Me.txtidcrew.Location = New System.Drawing.Point(109, 77)
        Me.txtidcrew.Name = "txtidcrew"
        Me.txtidcrew.Size = New System.Drawing.Size(109, 20)
        Me.txtidcrew.TabIndex = 14
        '
        'txtidreceipt
        '
        Me.txtidreceipt.Location = New System.Drawing.Point(109, 51)
        Me.txtidreceipt.Name = "txtidreceipt"
        Me.txtidreceipt.Size = New System.Drawing.Size(109, 20)
        Me.txtidreceipt.TabIndex = 13
        '
        'txtidticket
        '
        Me.txtidticket.Location = New System.Drawing.Point(109, 25)
        Me.txtidticket.Name = "txtidticket"
        Me.txtidticket.Size = New System.Drawing.Size(109, 20)
        Me.txtidticket.TabIndex = 12
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(6, 314)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(90, 13)
        Me.Label12.TabIndex = 11
        Me.Label12.Text = "Harga                 :"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 288)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(92, 13)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "ID Kursi               :"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 262)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(92, 13)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Jam Tayang        :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 239)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(91, 13)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Tanggal Tayang :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 210)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(91, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Studio                 :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 184)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(90, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Rate                   :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 158)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(89, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Judul                  :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 132)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(89, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "ID Movie            :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 106)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Nama Crew        :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "ID Crew              :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "ID Receipt          :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID Ticket            :"
        '
        'Ticket
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(641, 458)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Ticket"
        Me.Text = "Ticket"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btn_exit As Button
    Friend WithEvents btn_cancel As Button
    Friend WithEvents btn_delete As Button
    Friend WithEvents btn_edit As Button
    Friend WithEvents btn_save As Button
    Friend WithEvents btn_input As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents DGV As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtharga As TextBox
    Friend WithEvents txtidkursi As TextBox
    Friend WithEvents tgltayang As DateTimePicker
    Friend WithEvents txtstudiomovie As TextBox
    Friend WithEvents txtrate As TextBox
    Friend WithEvents txtjudul As TextBox
    Friend WithEvents txtidmovie As TextBox
    Friend WithEvents txtnamacrew As TextBox
    Friend WithEvents txtidcrew As TextBox
    Friend WithEvents txtidreceipt As TextBox
    Friend WithEvents txtidticket As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents jamtayang As DateTimePicker
End Class
