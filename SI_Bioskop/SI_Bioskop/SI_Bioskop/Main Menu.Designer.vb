<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main_Menu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main_Menu))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.InputDataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataMovieToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataCustomerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataCrewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataKursiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransaksiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReceiptBioskopToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QRCodeToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.QRCodeGeneratorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QRReaderPictureToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QRCodeWebcamToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FindIDCardToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PeriodikDataCrewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportCustomerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportMovieToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportKursiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportCrewTicketingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportReceiptToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_exit = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InputDataToolStripMenuItem, Me.TransaksiToolStripMenuItem, Me.QRCodeToolStripMenuItem1, Me.ReportToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(414, 27)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'InputDataToolStripMenuItem
        '
        Me.InputDataToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DataMovieToolStripMenuItem, Me.DataCustomerToolStripMenuItem, Me.DataCrewToolStripMenuItem, Me.DataKursiToolStripMenuItem})
        Me.InputDataToolStripMenuItem.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputDataToolStripMenuItem.Name = "InputDataToolStripMenuItem"
        Me.InputDataToolStripMenuItem.Size = New System.Drawing.Size(118, 23)
        Me.InputDataToolStripMenuItem.Text = "Input Data "
        '
        'DataMovieToolStripMenuItem
        '
        Me.DataMovieToolStripMenuItem.Name = "DataMovieToolStripMenuItem"
        Me.DataMovieToolStripMenuItem.Size = New System.Drawing.Size(203, 24)
        Me.DataMovieToolStripMenuItem.Text = "Data Movie "
        '
        'DataCustomerToolStripMenuItem
        '
        Me.DataCustomerToolStripMenuItem.Name = "DataCustomerToolStripMenuItem"
        Me.DataCustomerToolStripMenuItem.Size = New System.Drawing.Size(203, 24)
        Me.DataCustomerToolStripMenuItem.Text = "Data Customer"
        '
        'DataCrewToolStripMenuItem
        '
        Me.DataCrewToolStripMenuItem.Name = "DataCrewToolStripMenuItem"
        Me.DataCrewToolStripMenuItem.Size = New System.Drawing.Size(203, 24)
        Me.DataCrewToolStripMenuItem.Text = "Data Crew"
        '
        'DataKursiToolStripMenuItem
        '
        Me.DataKursiToolStripMenuItem.Name = "DataKursiToolStripMenuItem"
        Me.DataKursiToolStripMenuItem.Size = New System.Drawing.Size(203, 24)
        Me.DataKursiToolStripMenuItem.Text = "Data Kursi"
        '
        'TransaksiToolStripMenuItem
        '
        Me.TransaksiToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ReceiptBioskopToolStripMenuItem})
        Me.TransaksiToolStripMenuItem.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TransaksiToolStripMenuItem.Name = "TransaksiToolStripMenuItem"
        Me.TransaksiToolStripMenuItem.Size = New System.Drawing.Size(105, 23)
        Me.TransaksiToolStripMenuItem.Text = "Transaksi"
        '
        'ReceiptBioskopToolStripMenuItem
        '
        Me.ReceiptBioskopToolStripMenuItem.Name = "ReceiptBioskopToolStripMenuItem"
        Me.ReceiptBioskopToolStripMenuItem.Size = New System.Drawing.Size(215, 24)
        Me.ReceiptBioskopToolStripMenuItem.Text = "Receipt Bioskop"
        '
        'QRCodeToolStripMenuItem1
        '
        Me.QRCodeToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.QRCodeGeneratorToolStripMenuItem, Me.QRReaderPictureToolStripMenuItem, Me.QRCodeWebcamToolStripMenuItem})
        Me.QRCodeToolStripMenuItem1.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QRCodeToolStripMenuItem1.Name = "QRCodeToolStripMenuItem1"
        Me.QRCodeToolStripMenuItem1.Size = New System.Drawing.Size(94, 23)
        Me.QRCodeToolStripMenuItem1.Text = "QR Code"
        '
        'QRCodeGeneratorToolStripMenuItem
        '
        Me.QRCodeGeneratorToolStripMenuItem.Name = "QRCodeGeneratorToolStripMenuItem"
        Me.QRCodeGeneratorToolStripMenuItem.Size = New System.Drawing.Size(241, 24)
        Me.QRCodeGeneratorToolStripMenuItem.Text = "QR Code Generator"
        '
        'QRReaderPictureToolStripMenuItem
        '
        Me.QRReaderPictureToolStripMenuItem.Name = "QRReaderPictureToolStripMenuItem"
        Me.QRReaderPictureToolStripMenuItem.Size = New System.Drawing.Size(241, 24)
        Me.QRReaderPictureToolStripMenuItem.Text = "Scan Reader"
        '
        'QRCodeWebcamToolStripMenuItem
        '
        Me.QRCodeWebcamToolStripMenuItem.Name = "QRCodeWebcamToolStripMenuItem"
        Me.QRCodeWebcamToolStripMenuItem.Size = New System.Drawing.Size(241, 24)
        Me.QRCodeWebcamToolStripMenuItem.Text = "BCQR Reader"
        '
        'ReportToolStripMenuItem
        '
        Me.ReportToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FindIDCardToolStripMenuItem, Me.PeriodikDataCrewToolStripMenuItem, Me.ReportCustomerToolStripMenuItem, Me.ReportMovieToolStripMenuItem, Me.ReportKursiToolStripMenuItem, Me.ReportCrewTicketingToolStripMenuItem, Me.ReportReceiptToolStripMenuItem})
        Me.ReportToolStripMenuItem.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReportToolStripMenuItem.Name = "ReportToolStripMenuItem"
        Me.ReportToolStripMenuItem.Size = New System.Drawing.Size(79, 23)
        Me.ReportToolStripMenuItem.Text = "Report"
        '
        'FindIDCardToolStripMenuItem
        '
        Me.FindIDCardToolStripMenuItem.Name = "FindIDCardToolStripMenuItem"
        Me.FindIDCardToolStripMenuItem.Size = New System.Drawing.Size(270, 24)
        Me.FindIDCardToolStripMenuItem.Text = "Find ID Card"
        '
        'PeriodikDataCrewToolStripMenuItem
        '
        Me.PeriodikDataCrewToolStripMenuItem.Name = "PeriodikDataCrewToolStripMenuItem"
        Me.PeriodikDataCrewToolStripMenuItem.Size = New System.Drawing.Size(270, 24)
        Me.PeriodikDataCrewToolStripMenuItem.Text = "Periodik Data Crew"
        '
        'ReportCustomerToolStripMenuItem
        '
        Me.ReportCustomerToolStripMenuItem.Name = "ReportCustomerToolStripMenuItem"
        Me.ReportCustomerToolStripMenuItem.Size = New System.Drawing.Size(270, 24)
        Me.ReportCustomerToolStripMenuItem.Text = "Report Customer"
        '
        'ReportMovieToolStripMenuItem
        '
        Me.ReportMovieToolStripMenuItem.Name = "ReportMovieToolStripMenuItem"
        Me.ReportMovieToolStripMenuItem.Size = New System.Drawing.Size(270, 24)
        Me.ReportMovieToolStripMenuItem.Text = "Report Movie"
        '
        'ReportKursiToolStripMenuItem
        '
        Me.ReportKursiToolStripMenuItem.Name = "ReportKursiToolStripMenuItem"
        Me.ReportKursiToolStripMenuItem.Size = New System.Drawing.Size(270, 24)
        Me.ReportKursiToolStripMenuItem.Text = "Report Kursi"
        '
        'ReportCrewTicketingToolStripMenuItem
        '
        Me.ReportCrewTicketingToolStripMenuItem.Name = "ReportCrewTicketingToolStripMenuItem"
        Me.ReportCrewTicketingToolStripMenuItem.Size = New System.Drawing.Size(270, 24)
        Me.ReportCrewTicketingToolStripMenuItem.Text = "Report Crew Ticketing"
        '
        'ReportReceiptToolStripMenuItem
        '
        Me.ReportReceiptToolStripMenuItem.Name = "ReportReceiptToolStripMenuItem"
        Me.ReportReceiptToolStripMenuItem.Size = New System.Drawing.Size(270, 24)
        Me.ReportReceiptToolStripMenuItem.Text = "Report Receipt"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Schoolbook", 32.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(39, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(335, 50)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "ANN CINEMA"
        '
        'btn_exit
        '
        Me.btn_exit.Location = New System.Drawing.Point(318, 296)
        Me.btn_exit.Name = "btn_exit"
        Me.btn_exit.Size = New System.Drawing.Size(79, 32)
        Me.btn_exit.TabIndex = 2
        Me.btn_exit.Text = "Exit"
        Me.btn_exit.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(10, 89)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(1, 3, 3, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(387, 201)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'Main_Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(414, 336)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btn_exit)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Main_Menu"
        Me.Text = "Main Menu"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents InputDataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataMovieToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataCustomerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataCrewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TransaksiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_exit As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents DataKursiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents QRCodeToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents QRCodeGeneratorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents QRReaderPictureToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents QRCodeWebcamToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FindIDCardToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PeriodikDataCrewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportCustomerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportMovieToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReceiptBioskopToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportKursiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportCrewTicketingToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportReceiptToolStripMenuItem As ToolStripMenuItem
End Class
