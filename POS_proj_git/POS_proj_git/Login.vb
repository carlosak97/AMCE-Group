Public Class POS
    Dim SQL As New SQLControl
    Private Sub POS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UserText.Focus()
    End Sub

    Private Sub Login_Button_Click(sender As Object, e As EventArgs) Handles LoginB.Click
        Try
            If SQL.HasConnection = True Then
                SQL.RunQuery("Select Emp_Pass From Employee Where First_Name ='" & UserText.Text & "'")
                If SQL.SQLDataset.Tables.Count > 0 Then
                    If SQL.SQLDataset.Tables(0).Rows(0).Item(0) = PassText.Text Then
                        Main.Show()
                        UserText.Text = ""
                        PassText.Text = ""
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox("Wrong Username or Password Enetered")
        End Try



    End Sub
End Class
