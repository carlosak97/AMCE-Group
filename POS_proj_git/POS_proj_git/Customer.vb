Public Class Customer

    Private Sub LookUpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LookUpToolStripMenuItem.Click
        Lookup.Show()
    End Sub

    Private Sub SignOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SignOutToolStripMenuItem.Click
        Me.Close()
    End Sub
End Class