Public Class Interval_Data_Crew
    Private Sub btn_tampil_Click(sender As Object, e As EventArgs) Handles btn_tampil.Click
        Form_Report_Data_Crew.Report_Data_Crew1.SetParameterValue("Tanggal Awal", DateTimePicker1.Value)
        Form_Report_Data_Crew.Report_Data_Crew1.SetParameterValue("Tanggal Akhir", DateTimePicker2.Value)
        Form_Report_Data_Crew.Show()
        Me.Close()
    End Sub
End Class