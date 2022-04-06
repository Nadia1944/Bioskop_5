Imports MessagingToolkit.QRCode.Codec
Imports WebCam_Capture
Imports MessagingToolkit.Barcode
Public Class QR_Code_reader_Webcam
    WithEvents Mywebcam As WebCamCapture
    Dim Reader As QRCodeDecoder
    Dim Scanner As New BarcodeDecoder
    Dim result As MessagingToolkit.Barcode.Result
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
    Private Sub StopWebcam()
        Try
            Mywebcam.Stop()
            Mywebcam.Dispose()
        Catch ex As Exception
        End Try
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        StartWebCam()
        TextBox1.Clear()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        StopWebcam()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim Scanner = New BarcodeDecoder
        Dim result As Result
        Try
            'Stop disini berfungsi untuk berhenti sementara (pause) dari webcam
            Mywebcam.Stop()
            'result adalah hasil scan
            'decode untuk mengubah hasil barcode ke hasil scan non string
            result = Scanner.Decode(New Bitmap(PictureBox1.Image))
            If result IsNot Nothing Then
                'decoded untuk konversi hasil scan ke string. Trim untuk menghapus spasi di awal dan akhir string (bukan diantara)
                Dim decoded As String
                decoded = result.ToString().Trim
                MsgBox(decoded)
                'REPORT TRANSAKSI --> FORM REPORT RECEIPT
                If Application.OpenForms().OfType(Of Report_Receipt).Any Then
                    Form_Report_Receipt.ComboBox1.Text = decoded
                End If
                TextBox1.Text = decoded
            ElseIf result Is Nothing Then
                MsgBox("Silahkan coba kembali")
                'start untuk memulai kembali webcam (unpause)
                StartWebCam()
            End If
        Catch ex As Exception
            MsgBox("Silahkan coba kembali")
            'start untuk memulai kembali webcam (unpause)
            StartWebCam()
        End Try
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        'Dim Scanner As New MessagingToolkit.Barcode.BarcodeDecoder
        'Dim result As MessagingToolkit.Barcode.Result
        'Try
        '    result = Scanner.Decode(New Bitmap(PictureBox1.Image))
        '    MsgBox(result.Text)
        '    TextBox1.Text = result.Text
        'Catch ex As Exception
        'End Try

        Dim SD As New SaveFileDialog
        SD.Filter = "PNG|*.png"
        If SD.ShowDialog() = DialogResult.OK Then
            PictureBox1.Image.Save(SD.FileName, Imaging.ImageFormat.Png)
        End If
    End Sub

    Private Sub Mywebcam_ImageCaptured(source As Object, e As WebcamEventArgs) Handles Mywebcam.ImageCaptured
        PictureBox1.Image = e.WebCamImage
    End Sub
End Class