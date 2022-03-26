<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class QR_Code_Generator
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
        Me.btnsavebarcode = New System.Windows.Forms.Button()
        Me.btnsaveqrcode = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnprosesbarcode = New System.Windows.Forms.Button()
        Me.btnprosesqrcode = New System.Windows.Forms.Button()
        Me.txtbarcode = New System.Windows.Forms.TextBox()
        Me.txtqrcode = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Btnexit = New System.Windows.Forms.Button()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnsavebarcode
        '
        Me.btnsavebarcode.Location = New System.Drawing.Point(576, 352)
        Me.btnsavebarcode.Name = "btnsavebarcode"
        Me.btnsavebarcode.Size = New System.Drawing.Size(75, 31)
        Me.btnsavebarcode.TabIndex = 29
        Me.btnsavebarcode.Text = "Save"
        Me.btnsavebarcode.UseVisualStyleBackColor = True
        '
        'btnsaveqrcode
        '
        Me.btnsaveqrcode.Location = New System.Drawing.Point(244, 352)
        Me.btnsaveqrcode.Name = "btnsaveqrcode"
        Me.btnsaveqrcode.Size = New System.Drawing.Size(75, 31)
        Me.btnsaveqrcode.TabIndex = 28
        Me.btnsaveqrcode.Text = "Save"
        Me.btnsaveqrcode.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.Location = New System.Drawing.Point(410, 174)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(225, 156)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 27
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(84, 174)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(207, 156)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 26
        Me.PictureBox1.TabStop = False
        '
        'btnprosesbarcode
        '
        Me.btnprosesbarcode.Location = New System.Drawing.Point(192, 55)
        Me.btnprosesbarcode.Name = "btnprosesbarcode"
        Me.btnprosesbarcode.Size = New System.Drawing.Size(75, 23)
        Me.btnprosesbarcode.TabIndex = 25
        Me.btnprosesbarcode.Text = "Proses"
        Me.btnprosesbarcode.UseVisualStyleBackColor = True
        '
        'btnprosesqrcode
        '
        Me.btnprosesqrcode.Location = New System.Drawing.Point(196, 55)
        Me.btnprosesqrcode.Name = "btnprosesqrcode"
        Me.btnprosesqrcode.Size = New System.Drawing.Size(75, 23)
        Me.btnprosesqrcode.TabIndex = 24
        Me.btnprosesqrcode.Text = "Proses"
        Me.btnprosesqrcode.UseVisualStyleBackColor = True
        '
        'txtbarcode
        '
        Me.txtbarcode.Location = New System.Drawing.Point(6, 19)
        Me.txtbarcode.Name = "txtbarcode"
        Me.txtbarcode.Size = New System.Drawing.Size(267, 20)
        Me.txtbarcode.TabIndex = 23
        '
        'txtqrcode
        '
        Me.txtqrcode.Location = New System.Drawing.Point(6, 19)
        Me.txtqrcode.Name = "txtqrcode"
        Me.txtqrcode.Size = New System.Drawing.Size(259, 20)
        Me.txtqrcode.TabIndex = 22
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtqrcode)
        Me.GroupBox1.Controls.Add(Me.btnprosesqrcode)
        Me.GroupBox1.Location = New System.Drawing.Point(54, 52)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(277, 100)
        Me.GroupBox1.TabIndex = 30
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "QR Code"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtbarcode)
        Me.GroupBox2.Controls.Add(Me.btnprosesbarcode)
        Me.GroupBox2.Location = New System.Drawing.Point(384, 52)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(286, 100)
        Me.GroupBox2.TabIndex = 31
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Barcode"
        '
        'Btnexit
        '
        Me.Btnexit.Location = New System.Drawing.Point(576, 404)
        Me.Btnexit.Name = "Btnexit"
        Me.Btnexit.Size = New System.Drawing.Size(75, 30)
        Me.Btnexit.TabIndex = 32
        Me.Btnexit.Text = "Exit"
        Me.Btnexit.UseVisualStyleBackColor = True
        '
        'QR_Code_Generator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(717, 456)
        Me.Controls.Add(Me.Btnexit)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnsavebarcode)
        Me.Controls.Add(Me.btnsaveqrcode)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "QR_Code_Generator"
        Me.Text = "QR_Code_Generator"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnsavebarcode As Button
    Friend WithEvents btnsaveqrcode As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnprosesbarcode As Button
    Friend WithEvents btnprosesqrcode As Button
    Friend WithEvents txtbarcode As TextBox
    Friend WithEvents txtqrcode As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Btnexit As Button
End Class
