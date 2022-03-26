<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ScanReader
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
        Me.btnscan2 = New System.Windows.Forms.Button()
        Me.btnload = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btnscan1 = New System.Windows.Forms.Button()
        Me.btnqrcode = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnbarcode = New System.Windows.Forms.Button()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnscan2
        '
        Me.btnscan2.Location = New System.Drawing.Point(594, 239)
        Me.btnscan2.Name = "btnscan2"
        Me.btnscan2.Size = New System.Drawing.Size(79, 33)
        Me.btnscan2.TabIndex = 16
        Me.btnscan2.Text = "Scan"
        Me.btnscan2.UseVisualStyleBackColor = True
        '
        'btnload
        '
        Me.btnload.Location = New System.Drawing.Point(433, 239)
        Me.btnload.Name = "btnload"
        Me.btnload.Size = New System.Drawing.Size(79, 33)
        Me.btnload.TabIndex = 15
        Me.btnload.Text = "Load"
        Me.btnload.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(433, 201)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(240, 20)
        Me.TextBox2.TabIndex = 14
        '
        'PictureBox2
        '
        Me.PictureBox2.Location = New System.Drawing.Point(433, 28)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(240, 148)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 13
        Me.PictureBox2.TabStop = False
        '
        'btnscan1
        '
        Me.btnscan1.Location = New System.Drawing.Point(243, 239)
        Me.btnscan1.Name = "btnscan1"
        Me.btnscan1.Size = New System.Drawing.Size(92, 33)
        Me.btnscan1.TabIndex = 20
        Me.btnscan1.Text = "Scan"
        Me.btnscan1.UseVisualStyleBackColor = True
        '
        'btnqrcode
        '
        Me.btnqrcode.Location = New System.Drawing.Point(47, 239)
        Me.btnqrcode.Name = "btnqrcode"
        Me.btnqrcode.Size = New System.Drawing.Size(92, 33)
        Me.btnqrcode.TabIndex = 19
        Me.btnqrcode.Text = "QR Code"
        Me.btnqrcode.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(47, 201)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(288, 20)
        Me.TextBox1.TabIndex = 18
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(47, 28)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(288, 148)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 17
        Me.PictureBox1.TabStop = False
        '
        'btnbarcode
        '
        Me.btnbarcode.Location = New System.Drawing.Point(145, 239)
        Me.btnbarcode.Name = "btnbarcode"
        Me.btnbarcode.Size = New System.Drawing.Size(92, 33)
        Me.btnbarcode.TabIndex = 21
        Me.btnbarcode.Text = "Barcode"
        Me.btnbarcode.UseVisualStyleBackColor = True
        '
        'ScanReader
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(716, 330)
        Me.Controls.Add(Me.btnbarcode)
        Me.Controls.Add(Me.btnscan1)
        Me.Controls.Add(Me.btnqrcode)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnscan2)
        Me.Controls.Add(Me.btnload)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.PictureBox2)
        Me.Name = "ScanReader"
        Me.Text = "ScanReader"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnscan2 As Button
    Friend WithEvents btnload As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents btnscan1 As Button
    Friend WithEvents btnqrcode As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnbarcode As Button
End Class
