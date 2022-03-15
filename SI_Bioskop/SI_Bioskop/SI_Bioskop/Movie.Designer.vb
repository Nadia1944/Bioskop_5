<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Movie
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.jam_tayang = New System.Windows.Forms.TextBox()
        Me.studio = New System.Windows.Forms.TextBox()
        Me.Rate = New System.Windows.Forms.TextBox()
        Me.judul = New System.Windows.Forms.TextBox()
        Me.id_movie = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DGV1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btn_exit = New System.Windows.Forms.Button()
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.btn_edit = New System.Windows.Forms.Button()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.btn_input = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DGV1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.jam_tayang)
        Me.GroupBox1.Controls.Add(Me.studio)
        Me.GroupBox1.Controls.Add(Me.Rate)
        Me.GroupBox1.Controls.Add(Me.judul)
        Me.GroupBox1.Controls.Add(Me.id_movie)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 28)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(242, 246)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Movie"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(113, 164)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(123, 20)
        Me.DateTimePicker1.TabIndex = 11
        '
        'jam_tayang
        '
        Me.jam_tayang.Location = New System.Drawing.Point(113, 200)
        Me.jam_tayang.Name = "jam_tayang"
        Me.jam_tayang.Size = New System.Drawing.Size(122, 20)
        Me.jam_tayang.TabIndex = 10
        '
        'studio
        '
        Me.studio.Location = New System.Drawing.Point(114, 136)
        Me.studio.Name = "studio"
        Me.studio.Size = New System.Drawing.Size(122, 20)
        Me.studio.TabIndex = 9
        '
        'Rate
        '
        Me.Rate.Location = New System.Drawing.Point(115, 100)
        Me.Rate.Name = "Rate"
        Me.Rate.Size = New System.Drawing.Size(122, 20)
        Me.Rate.TabIndex = 8
        '
        'judul
        '
        Me.judul.Location = New System.Drawing.Point(114, 64)
        Me.judul.Name = "judul"
        Me.judul.Size = New System.Drawing.Size(122, 20)
        Me.judul.TabIndex = 7
        '
        'id_movie
        '
        Me.id_movie.Location = New System.Drawing.Point(114, 32)
        Me.id_movie.Name = "id_movie"
        Me.id_movie.Size = New System.Drawing.Size(122, 20)
        Me.id_movie.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(16, 170)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(94, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Tanggal Tayang  :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(16, 203)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(95, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Jam Tayang         :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 139)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(94, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Studio                  :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 103)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Rate                    :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Judul                   :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID Movie             :"
        '
        'DGV1
        '
        Me.DGV1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV1.Location = New System.Drawing.Point(17, 26)
        Me.DGV1.Name = "DGV1"
        Me.DGV1.Size = New System.Drawing.Size(325, 284)
        Me.DGV1.TabIndex = 1
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btn_exit)
        Me.GroupBox3.Controls.Add(Me.btn_cancel)
        Me.GroupBox3.Controls.Add(Me.btn_delete)
        Me.GroupBox3.Controls.Add(Me.btn_edit)
        Me.GroupBox3.Controls.Add(Me.btn_save)
        Me.GroupBox3.Controls.Add(Me.btn_input)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 280)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(233, 76)
        Me.GroupBox3.TabIndex = 9
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
        Me.btn_input.Location = New System.Drawing.Point(9, 19)
        Me.btn_input.Name = "btn_input"
        Me.btn_input.Size = New System.Drawing.Size(61, 23)
        Me.btn_input.TabIndex = 0
        Me.btn_input.Text = "INPUT"
        Me.btn_input.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DGV1)
        Me.GroupBox2.Location = New System.Drawing.Point(260, 28)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(355, 328)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Detail Movie"
        '
        'Movie
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(627, 374)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Movie"
        Me.Text = "Movie"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DGV1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DGV1 As DataGridView
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents jam_tayang As TextBox
    Friend WithEvents studio As TextBox
    Friend WithEvents Rate As TextBox
    Friend WithEvents judul As TextBox
    Friend WithEvents id_movie As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btn_exit As Button
    Friend WithEvents btn_cancel As Button
    Friend WithEvents btn_delete As Button
    Friend WithEvents btn_edit As Button
    Friend WithEvents btn_save As Button
    Friend WithEvents btn_input As Button
    Friend WithEvents GroupBox2 As GroupBox
End Class
