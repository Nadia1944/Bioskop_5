<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Kursi
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Kursi))
        Me.btn_Exit = New System.Windows.Forms.Button()
        Me.btn_Cancel = New System.Windows.Forms.Button()
        Me.btn_Delete = New System.Windows.Forms.Button()
        Me.btn_Edit = New System.Windows.Forms.Button()
        Me.btn_Save = New System.Windows.Forms.Button()
        Me.btn_input = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DGV = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Stok = New System.Windows.Forms.TextBox()
        Me.Studio = New System.Windows.Forms.TextBox()
        Me.Id_kursi = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_Exit
        '
        Me.btn_Exit.Location = New System.Drawing.Point(180, 211)
        Me.btn_Exit.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_Exit.Name = "btn_Exit"
        Me.btn_Exit.Size = New System.Drawing.Size(57, 23)
        Me.btn_Exit.TabIndex = 5
        Me.btn_Exit.Text = "EXIT"
        Me.btn_Exit.UseVisualStyleBackColor = True
        '
        'btn_Cancel
        '
        Me.btn_Cancel.Location = New System.Drawing.Point(28, 213)
        Me.btn_Cancel.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_Cancel.Name = "btn_Cancel"
        Me.btn_Cancel.Size = New System.Drawing.Size(57, 19)
        Me.btn_Cancel.TabIndex = 4
        Me.btn_Cancel.Text = "CANCEL"
        Me.btn_Cancel.UseVisualStyleBackColor = True
        '
        'btn_Delete
        '
        Me.btn_Delete.Location = New System.Drawing.Point(105, 213)
        Me.btn_Delete.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_Delete.Name = "btn_Delete"
        Me.btn_Delete.Size = New System.Drawing.Size(57, 19)
        Me.btn_Delete.TabIndex = 3
        Me.btn_Delete.Text = "DELETE"
        Me.btn_Delete.UseVisualStyleBackColor = True
        '
        'btn_Edit
        '
        Me.btn_Edit.Location = New System.Drawing.Point(180, 168)
        Me.btn_Edit.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_Edit.Name = "btn_Edit"
        Me.btn_Edit.Size = New System.Drawing.Size(57, 19)
        Me.btn_Edit.TabIndex = 2
        Me.btn_Edit.Text = "EDIT"
        Me.btn_Edit.UseVisualStyleBackColor = True
        '
        'btn_Save
        '
        Me.btn_Save.Location = New System.Drawing.Point(105, 168)
        Me.btn_Save.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_Save.Name = "btn_Save"
        Me.btn_Save.Size = New System.Drawing.Size(57, 19)
        Me.btn_Save.TabIndex = 1
        Me.btn_Save.Text = "SAVE"
        Me.btn_Save.UseVisualStyleBackColor = True
        '
        'btn_input
        '
        Me.btn_input.Location = New System.Drawing.Point(28, 168)
        Me.btn_input.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_input.Name = "btn_input"
        Me.btn_input.Size = New System.Drawing.Size(57, 19)
        Me.btn_input.TabIndex = 0
        Me.btn_input.Text = "INPUT"
        Me.btn_input.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DGV)
        Me.GroupBox2.Location = New System.Drawing.Point(28, 247)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Size = New System.Drawing.Size(311, 114)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Detail Data Kursi"
        '
        'DGV
        '
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV.Location = New System.Drawing.Point(16, 17)
        Me.DGV.Margin = New System.Windows.Forms.Padding(2)
        Me.DGV.Name = "DGV"
        Me.DGV.RowTemplate.Height = 28
        Me.DGV.Size = New System.Drawing.Size(281, 87)
        Me.DGV.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Stok)
        Me.GroupBox1.Controls.Add(Me.Studio)
        Me.GroupBox1.Controls.Add(Me.Id_kursi)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(28, 29)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(209, 114)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Input Data Kursi"
        '
        'Stok
        '
        Me.Stok.Location = New System.Drawing.Point(87, 53)
        Me.Stok.Margin = New System.Windows.Forms.Padding(2)
        Me.Stok.Name = "Stok"
        Me.Stok.Size = New System.Drawing.Size(98, 20)
        Me.Stok.TabIndex = 5
        '
        'Studio
        '
        Me.Studio.Location = New System.Drawing.Point(87, 83)
        Me.Studio.Margin = New System.Windows.Forms.Padding(2)
        Me.Studio.Name = "Studio"
        Me.Studio.Size = New System.Drawing.Size(98, 20)
        Me.Studio.TabIndex = 4
        '
        'Id_kursi
        '
        Me.Id_kursi.Location = New System.Drawing.Point(87, 27)
        Me.Id_kursi.Margin = New System.Windows.Forms.Padding(2)
        Me.Id_kursi.Name = "Id_kursi"
        Me.Id_kursi.Size = New System.Drawing.Size(98, 20)
        Me.Id_kursi.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 85)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Studio"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 55)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Stok"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 29)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID Kursi :"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(363, 29)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(411, 311)
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'Kursi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(794, 374)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btn_Exit)
        Me.Controls.Add(Me.btn_Cancel)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btn_Delete)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btn_Edit)
        Me.Controls.Add(Me.btn_input)
        Me.Controls.Add(Me.btn_Save)
        Me.Name = "Kursi"
        Me.Text = "Kursi"
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn_Exit As Button
    Friend WithEvents btn_Cancel As Button
    Friend WithEvents btn_Delete As Button
    Friend WithEvents btn_Edit As Button
    Friend WithEvents btn_Save As Button
    Friend WithEvents btn_input As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents DGV As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Stok As TextBox
    Friend WithEvents Studio As TextBox
    Friend WithEvents Id_kursi As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
