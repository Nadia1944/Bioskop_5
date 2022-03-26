Imports MessagingToolkit.Barcode.BarcodeDecoder
Imports MessagingToolkit.QRCode.Codec
Public Class ScanReader
    Dim QR_Generator1 As New MessagingToolkit.QRCode.Codec.QRCodeEncoder
    Dim BR_Generator1 As New MessagingToolkit.Barcode.BarcodeEncoder

    Private Sub btnload_Click(sender As Object, e As EventArgs) Handles btnload.Click
        Dim OPD As New OpenFileDialog
        OPD.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        If OPD.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Try
                PictureBox2.Load(OPD.FileName)
            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Sub btnscan_Click(sender As Object, e As EventArgs) Handles btnscan2.Click
        Dim Scanner As New MessagingToolkit.Barcode.BarcodeDecoder
        Dim result As MessagingToolkit.Barcode.Result
        Try
            result = Scanner.Decode(New Bitmap(PictureBox2.Image))
            MsgBox(result.Text)
            TextBox2.Text = result.Text
        Catch ex As Exception
        End Try
    End Sub
End Class

