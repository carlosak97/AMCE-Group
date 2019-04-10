Public Class POS
    
    Private Sub POS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UserText.Focus()
    End Sub

    Private Sub Login_Button_Click(sender As Object, e As EventArgs) Handles LoginB.Click
        Main.Show()
    End Sub
End Class
