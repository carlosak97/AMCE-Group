Public Class Main
    Dim ID As Nullable(Of Integer) = Nothing
    Dim Item_ID As Integer
    Dim TQuan As Integer
    Dim TPay As Integer
    Dim PayL As Integer
    Dim Discount As Integer
    Dim Is_USD As Boolean
    Dim SQL As New SQLControl
    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ItemList.Items.Add("Item ID           Quantity           Price           Employee")
        PayList.Visible = False
        SalesName.Visible = False
        PinLabel.Visible = False
        PinText.Visible = False
        PercLabel.Visible = False
        AmountPayLabel.Visible = False
        Amount_Text.Visible = False
        Done.Visible = False
        Pay.Visible = False
        ToPayment.Visible = False
        Done.Visible = False
        Is_USD = False
        TQuan = 0
        TPay = 0
        PayL = 0
        ID_Text.Focus()
        PayList.Items.Add("Cash")
        PayList.Items.Add("Dollar")
        PayList.Items.Add("MasterCard LBP")
        PayList.Items.Add("MasterCard USD")
        PayList.Items.Add("Visa LBP")
        PayList.Items.Add("Visa  USD")
    End Sub

    Private Sub EnterID_Click(sender As Object, e As EventArgs) Handles EnterID.Click
        Try
            ID = ID_Text.Text
            SQL.RunQuery("Select Count(Emp_ID) As EmpCount From Employee Where Emp_ID ='" & ID_Text.Text & "' ")
            If SQL.SQLDataset.Tables(0).Rows(0).Item("EmpCount") = 1 Then
                If (ID > 0) Then
                    SQL.RunQuery("Select First_Name From Employee Where Emp_ID='" & ID_Text.Text & "' ")
                    Emp_Label.Text = "Salesman: " & SQL.SQLDataset.Tables(0).Rows(0).Item(0)
                    SalesName.Text = SQL.SQLDataset.Tables(0).Rows(0).Item(0)
                    ItemText.Focus()
                    ID_Text.Text = ""
                Else
                    MsgBox("Wrond ID entered")
                End If
            End If
        Catch ex As Exception
            MsgBox("Enter ID")
        End Try





    End Sub

    Private Sub EnterItem_Click(sender As Object, e As EventArgs) Handles EnterItem.Click
        Try
            If ItemText.Text = "" Then
            Else
                Item_ID = ItemText.Text
                SQL.RunQuery("Select Count(Item_ID) As ItemCount From Item Where Item_ID ='" & ItemText.Text & "' ")
                If SQL.SQLDataset.Tables(0).Rows(0).Item("ItemCount") = 1 Then
                    SQL.RunQuery("Select Item_Price From Item Where Item_ID='" & Item_ID & "' ")
                    If Is_USD = False Then
                        TPay = TPay + ((SQL.SQLDataset.Tables(0).Rows(0).Item(0) - (SQL.SQLDataset.Tables(0).Rows(0).Item(0) * Discount / 100)) * QuantityText.Text)
                    Else
                        TPay = TPay + (((SQL.SQLDataset.Tables(0).Rows(0).Item(0) - (SQL.SQLDataset.Tables(0).Rows(0).Item(0) * 1500)) * Discount / 100) * QuantityText.Text)
                    End If
                    ItemList.Items.Add("   " + Item_ID.ToString + "                      " + QuantityText.Text + "                 " + SQL.SQLDataset.Tables(0).Rows(0).Item(0).ToString + "            " + SalesName.Text)
                        SQL.RunQuery("INSERT INTO Tran_Foot (Item_ID,Salesman,Price)" & "VALUES ('" & Item_ID & "','" & ID & "','" & SQL.SQLDataset.Tables(0).Rows(0).Item(0) & "');")
                        TQuan = TQuan + QuantityText.Text

                    TotalQuantity.Text = "Total Quantity : " + TQuan.ToString
                        ItemText.Focus()
                        TotalPrice.Text = "Total Price : " + TPay.ToString
                    ToPayment.Visible = True
                    SQL.RunQuery("Select ItemQuantity From Item Where Item_ID = '" & Item_ID & "' ")
                    Dim MinusQuan As Integer
                    MinusQuan = SQL.SQLDataset.Tables(0).Rows(0).Item(0) - QuantityText.Text
                    SQL.RunQuery("UPDATE Item SET ItemQuantity = '" & MinusQuan & "' Where Item_ID ='" & Item_ID & "'")
                    ItemText.Text = ""
                    QuantityText.Text = ""
                End If
                End If
        Catch ex As Exception
            MsgBox("Wrong or No ID/Quantity Entered")
        End Try
        Try
            If CustInput.Text = "" Then
            Else
                If SQL.HasConnection = True Then
                    SQL.RunQuery("Select Cust_Disc From Customer Where Cust_ID = '" & CustInput.Text & "' ")
                    If SQL.SQLDataset.Tables.Count > 0 Then
                        Discount = SQL.SQLDataset.Tables(0).Rows(0).Item(0)
                        PercLabel.Text = "Discount : " + Discount.ToString + "%"
                        PercLabel.Visible = True
                        TPay = TPay - (TPay * Discount / 100)
                        TotalPrice.Text = "Total Price : " + TPay.ToString
                        CustInput.Text = ""
                    End If
                End If
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub ToPayment_Click(sender As Object, e As EventArgs) Handles ToPayment.Click
        ID_Text.Visible = False
        EnterID.Visible = False
        EnterItem.Visible = False
        AmountLabel.Visible = True
        Emp_Label.Visible = False
        AmountPayLabel.Visible = True

        ItemLabel.Visible = False
        Amount_Text.Visible = True
        ItemText.Visible = False
        QuantityText.Visible = False
        QuantityLabel.Visible = False
        CustLabel.Visible = False
        CustInput.Visible = False

        PayList.Visible = True
        ToPayment.Visible = False
        AmountLabel.Visible = False
        Pay.Visible = True
        AmountLabel.Visible = True
        AmountLabel.Text = "Amount Left : " + TPay.ToString
        Done.Visible = True
        PayL = TPay
    End Sub

    Private Sub Done_Click(sender As Object, e As EventArgs) Handles Done.Click
        If PayL = 0 Or PayL < 0 Then
            TPay = 0
            TQuan = 0
            PayL = 0
            ID_Text.Focus()
            TotalQuantity.Text = "Total Quantity : " + TQuan.ToString
            TotalPrice.Text = "Total Price : " + TPay.ToString
            AmountLabel.Text = "Amount Left : " + TPay.ToString
            ItemList.Items.Clear()
            ItemList.Items.Add("Item ID           Quantity           Price           Employee")
            PayList.Visible = False
            SalesName.Visible = False
            PinLabel.Visible = False
            EnterItem.Visible = True
            Is_USD = False
            PinText.Visible = False
            Emp_Label.Visible = True
            PercLabel.Visible = False
            AmountPayLabel.Visible = False
            Amount_Text.Visible = False
            Done.Visible = False
            Pay.Visible = False
            ToPayment.Visible = False
            ID_Text.Visible = True
            EnterID.Visible = True
            Done.Visible = False
            ItemLabel.Visible = True
            Amount_Text.Visible = True
            ItemText.Visible = True
            QuantityText.Visible = True
            QuantityLabel.Visible = True
            CustLabel.Visible = True
            CustInput.Visible = True
            Amount_Text.Visible = False
        Else
            MsgBox("Still need payment from customer")
        End If

    End Sub

    Private Sub Pay_Click(sender As Object, e As EventArgs) Handles Pay.Click
        Try
            PayL = PayL - Amount_Text.Text
            AmountLabel.Text = "Amount Left : " + PayL.ToString
            Amount_Text.Text = ""
        Catch ex As Exception
            MsgBox("Enter Payment Amount")
        End Try

    End Sub
    Private Sub PayList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles PayList.SelectedIndexChanged
        Try
            Select Case PayList.SelectedIndex
                Case 0
                    Pay.Location = New Point(774, 325)
                    PinLabel.Visible = False
                    PinText.Visible = False
                    Is_USD = False
                Case 1
                    Pay.Location = New Point(774, 325)
                    PinLabel.Visible = False
                    PinText.Visible = False
                    Is_USD = True
                Case 2
                    Pay.Location = New Point(774, 350)
                    PinLabel.Visible = True
                    PinText.Visible = True
                    Is_USD = False
                Case 3
                    Pay.Location = New Point(774, 350)
                    PinLabel.Visible = True
                    PinText.Visible = True
                    Is_USD = True
                Case 4
                    Pay.Location = New Point(774, 350)
                    PinLabel.Visible = True
                    PinText.Visible = True
                    Is_USD = False
                Case 5
                    Pay.Location = New Point(774, 350)
                    PinLabel.Visible = True
                    PinText.Visible = True
                    Is_USD = True
            End Select
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub LookUpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LookUpToolStripMenuItem.Click
        Lookup.Show()
    End Sub

    Private Sub SignOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SignOutToolStripMenuItem.Click
        Me.Close()
    End Sub
End Class