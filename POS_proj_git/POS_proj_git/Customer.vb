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
        If Cust_Prog.Checked = True Then
            Dim X As Integer
            SQL.RunQuery("Select Count(Cust_ID) From Customer")
            X = SQL.SQLDataset.Tables(0).Rows(0).Item(0) + 1
            SQL.RunQuery("INSERT INTO Customer (Cust_ID,Cust_Name,Cust_Age,Cust_Disc,Cust_Telephone,Nationality,Region,Cust_DOB)" & "VALUES ('" & X & "','" & Name_Text.Text & "','" & Age_Text.Text & "','" & 0 & "','" & Tel_text.Text & "','" & Nationality.SelectedItem.ToString & "','" & MyBase.Region.SelectedItem.ToString & "','" & Date_Text.Text & "');")
            Name_Text.Text = ""
            Age_Text.Text = ""
            Date_Text.Text = "DD/MM/YY"
            Tel_text.Text = ""
            Region.ResetText()
            Nationality.ResetText()
            Cust_Prog.ResetText()
        ElseIf Loyal_Prog.Checked = True Then
            Dim X As Integer
            SQL.RunQuery("Select Count(Cust_ID) From Customer")
            X = SQL.SQLDataset.Tables(0).Rows(0).Item(0) + 1
            SQL.RunQuery("INSERT INTO Customer (Cust_ID,Cust_Name,Cust_Age,Cust_Disc,Cust_Telephone,Nationality,Region,Cust_DOB)" & "VALUES ('" & X & "','" & Name_Text.Text & "','" & Age_Text.Text & "','" & 10 & "','" & Tel_text.Text & "','" & Nationality.SelectedItem.ToString & "','" & MyBase.Region.SelectedItem.ToString & "','" & Date_Text.Text & "');")
            Name_Text.Text = ""
            Age_Text.Text = ""
            Date_Text.Text = "DD/MM/YY"
            Tel_text.Text = ""
            Region.ResetText()
            Nationality.ResetText()
            Loyal_Prog.ResetText()
        Else
            MsgBox("Choose a Program")
        End If

    End Sub
End Class