Public Class Main_Menu
    Private Sub DataCustomerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataCustomerToolStripMenuItem.Click
        Customer.Show()
    End Sub

    Private Sub DataCrewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataCrewToolStripMenuItem.Click
        Crew.Show()
    End Sub

    Private Sub DataKursiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataKursiToolStripMenuItem.Click
        Kursi.Show()
    End Sub

    Private Sub TicketToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TicketToolStripMenuItem.Click
        Ticket.Show()
    End Sub

    Private Sub ReceiptToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ReceiptToolStripMenuItem1.Click

    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        Me.Close()
    End Sub

    Private Sub DataMovieToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles DataMovieToolStripMenuItem.Click
        Movie.Show()
    End Sub
End Class