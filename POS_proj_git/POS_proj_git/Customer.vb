Public Class Customer

    Dim SQL As New SQLControl
    Private Sub LookUpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LookUpToolStripMenuItem.Click
        Lookup.Show()
    End Sub

    Private Sub SignOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SignOutToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub Customer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Name_Text.Focus()
    End Sub

    Private Sub Enter_Button_Click(sender As Object, e As EventArgs) Handles Enter_Button.Click

    End Sub
End Class