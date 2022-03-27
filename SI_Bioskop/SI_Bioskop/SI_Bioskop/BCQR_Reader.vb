Imports MessagingToolkit.QRCode.Codec
Imports WebCam_Capture
Public Class QR_Code_reader_Webcam
    WithEvents Mywebcam As WebCamCapture
    Dim Reader As QRCodeDecoder
    Private Sub StartWebCam()
        Try
            'StopWebcam()
            Mywebcam = New WebCamCapture
            Mywebcam.Start(0)
            Mywebcam.Start(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        StartWebCam()
        TextBox1.Clear()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'StopWebcam()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            'StopWebcam()
            Reader = New QRCodeDecoder
            TextBox1.Text = Reader.decode(New Data.QRCodeBitmapImage(PictureBox1.Image))
            MsgBox("Data Terbaca")
        Catch ex As Exception
            StartWebCam()
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim Scanner As New MessagingToolkit.Barcode.BarcodeDecoder
        Dim result As MessagingToolkit.Barcode.Result
        Try
            result = Scanner.Decode(New Bitmap(PictureBox1.Image))
            MsgBox(result.Text)
            TextBox1.Text = result.Text
        Catch ex As Exception
        End Try
    End Sub
End Class