Public Class Find_ID_Card
    Private Sub cari_Click(sender As Object, e As EventArgs) Handles cari.Click
        ID_Card_Form.Report_ID_Card1.SetParameterValue("ID_Crew", (TextBox1.Text))
        ID_Card_Form.Show()
        Me.Close()
    End Sub
End Class