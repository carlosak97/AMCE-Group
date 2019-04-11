Public Class POS
    Dim SQL As New SQLControl
    Private Sub POS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UserText.Focus()
    End Sub

    Private Sub Login_Button_Click(sender As Object, e As EventArgs) Handles LoginB.Click
        If Sql.HasConnection = True Then
            SQL.RunQuery("Select Emp_Pass From Employee Where First_Name ='" & UserText.Text & "'")
            If Sql.SQLDataset.Tables.Count > 0 Then
                If SQL.SQLDataset.Tables(0).Rows(0).Item(0) = PassText.Text Then
                    Main.Show()
                End If
            End If
        End If

    End Sub
End Class
