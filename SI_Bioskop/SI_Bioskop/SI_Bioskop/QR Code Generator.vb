Imports MessagingToolkit.QRCode.Codec
Imports MessagingToolkit.Barcode
Imports WebCam_Capture
Public Class QR_Code_Generator
    Dim QR_Generator As New MessagingToolkit.QRCode.Codec.QRCodeEncoder
    Dim BR_Generator As New MessagingToolkit.Barcode.BarcodeEncoder

    Private Sub btnprosesqrcode_Click(sender As Object, e As EventArgs) Handles btnprosesqrcode.Click
        Try
            PictureBox1.Image = QR_Generator.Encode(txtqrcode.Text)
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub btnprosesbarcode_Click(sender As Object, e As EventArgs) Handles btnprosesbarcode.Click
        BR_Generator.IncludeLabel = True
        BR_Generator.CustomLabel = txtbarcode.Text
        Try
            PictureBox2.Image = BR_Generator.Encode(MessagingToolkit.Barcode.BarcodeFormat.Code128, txtbarcode.Text)
            'PictureBox2.Image = New Bitmap(BR_Generator.Encode(MessagingToolkit.Barcode.BarcodeFormat.ISBN, TextBox2.Text))
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnsaveqrcode_Click(sender As Object, e As EventArgs) Handles btnsaveqrcode.Click
        Dim SD As New SaveFileDialog
        SD.Filter = "Image File (*.jpeg;*jpg;*.png;*.bmp;)| *.jpeg;*jpg;*.png;*.bmp;"
        If SD.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Try
                PictureBox1.Image.Save(SD.FileName, Imaging.ImageFormat.Png)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub btnsavebarcode_Click(sender As Object, e As EventArgs) Handles btnsavebarcode.Click
        Dim SD As New SaveFileDialog
        SD.Filter = "Image File (*.jpeg;*jpg;*.png;*.bmp;)| *.jpeg;*jpg;*.png;*.bmp;"
        If SD.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Try
                PictureBox2.Image.Save(SD.FileName, Imaging.ImageFormat.Png)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub Btnexit_Click(sender As Object, e As EventArgs) Handles Btnexit.Click
        Me.Close()
    End Sub
End Class
