﻿Public Class POS
    Dim ID As Nullable(Of Integer) = Nothing
    Dim Item_ID As Integer
    Dim TQuan As Integer
    Dim TPay As Integer
    Dim PayL As Integer
    Dim SQL As New SQLControl
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If SQL.HasConnection = True Then
            MsgBox("Connected")
            SQL.RunQuery("Select Emp_ID,First_Name,Last_Name From Employee")
            If SQL.SQLDataset.Tables.Count > 0 Then
                DGVData.DataSource = SQL.SQLDataset.Tables(0)
            End If
        End If
        ID_Text.Focus()
        AmountLabel.Visible = False
        ItemList.Visible = False
        CustLabel.Visible = False
        CustInput.Visible = False
        PinLabel.Visible = False
        PinText.Visible = False
        Check_Cust.Visible = False
        PayList.Visible = False
        Search_Item.Visible = False
        DGVData.Visible = True
        PayList.Items.Add("Cash")
        PayList.Items.Add("Dollar")
        PayList.Items.Add("MasterCard LBP")
        PayList.Items.Add("MasterCard USD")
        PayList.Items.Add("Visa LBP")
        PayList.Items.Add("Visa  USD")
        ItemLabel.Visible = False
        ItemText.Visible = False
        QuantityText.Visible = False
        QuantityLabel.Visible = False
        TotalQuantity.Visible = False
        TotalPrice.Visible = False
        Amount_Text.Visible = False
        ToPayment.Visible = False
        AmountPayLabel.Visible = False
        EnterItem.Visible = False
        Amount_Text.Visible = False
        Done.Visible = False
        Pay.Visible = False
        TQuan = 0
        TPay = 0
        PayL = 0
    End Sub

    Private Sub EnterID_Click(sender As Object, e As EventArgs) Handles EnterID.Click
        Try
            ID = ID_Text.Text
            SQL.RunQuery("Select Count(Emp_ID) As EmpCount From Employee Where Emp_ID ='" & ID_Text.Text & "' ")
            If SQL.SQLDataset.Tables(0).Rows(0).Item("EmpCount") = 1 Then
                If (ID > 0) Then
                    AmountLabel.Visible = True
                    EnterID.Visible = False
                    SQL.RunQuery("Select First_Name From Employee Where Emp_ID='" & ID_Text.Text & "' ")
                    Emp_Label.Text = "Salesman: " & SQL.SQLDataset.Tables(0).Rows(0).Item(0)
                    ID_Text.Visible = False
                    ItemList.Visible = True
                    Search_Item.Visible = True
                    ItemLabel.Visible = True
                    EnterItem.Visible = True
                    ItemText.Visible = True
                    CustLabel.Visible = True
                    Check_Cust.Visible = True
                    CustInput.Visible = True
                    QuantityText.Visible = True
                    QuantityLabel.Visible = True
                    TotalQuantity.Visible = True
                    TotalPrice.Visible = True
                    ToPayment.Visible = True
                    ItemText.Focus()
                Else
                    MsgBox("Wrond ID entered")
                End If
            End If
            If SQL.HasConnection = True Then
                SQL.RunQuery("Select * From Item")
                If SQL.SQLDataset.Tables.Count > 0 Then
                    DGVData.DataSource = SQL.SQLDataset.Tables(0)
                End If
            End If
        Catch ex As Exception
            MsgBox("Enter ID")
        End Try





    End Sub

    Private Sub EnterItem_Click(sender As Object, e As EventArgs) Handles EnterItem.Click
        Try
            Item_ID = ItemText.Text
            SQL.RunQuery("Select Count(Item_ID) As ItemCount From Item Where Item_ID ='" & ItemText.Text & "' ")
            If SQL.SQLDataset.Tables(0).Rows(0).Item("ItemCount") = 1 Then
                SQL.RunQuery("Select Item_Price From Item Where Item_ID='" & Item_ID & "' ")
                TPay = TPay + (SQL.SQLDataset.Tables(0).Rows(0).Item(0) * QuantityText.Text)
                ItemList.Items.Add("Item ID : " + Item_ID.ToString + "    Quantity : " + QuantityText.Text + "    Price : " + SQL.SQLDataset.Tables(0).Rows(0).Item(0).ToString + "    Employee : " + ID.ToString)
                SQL.RunQuery("INSERT INTO Tran_Foot (Item_ID,Salesman,Price)" & "VALUES ('" & Item_ID & "','" & ID & "','" & SQL.SQLDataset.Tables(0).Rows(0).Item(0) & "');")
                TQuan = TQuan + QuantityText.Text
                ItemText.Text = ""
                QuantityText.Text = ""
                TotalQuantity.Text = "Total Quantity : " + TQuan.ToString
                ItemText.Focus()
                TotalPrice.Text = "Total Price : " + TPay.ToString
            End If
        Catch ex As Exception
            MsgBox("Enter ID and Quantity")
        End Try

    End Sub

    Private Sub ToPayment_Click(sender As Object, e As EventArgs) Handles ToPayment.Click
        TotalQuantity.Location = New Point(AmountLabel.Left, 120)
        TotalPrice.Location = New Point(AmountLabel.Left, 155)
        ID_Text.Visible = False
        EnterID.Visible = False
        EnterItem.Visible = False
        AmountLabel.Visible = True
        DGVData.Visible = False
        Emp_Label.Visible = False
        AmountPayLabel.Visible = True
        Search_Item.Visible = False
        ItemLabel.Visible = False
        Amount_Text.Visible = True
        ItemText.Visible = False
        QuantityText.Visible = False
        QuantityLabel.Visible = False
        CustLabel.Visible = False
        CustInput.Visible = False
        Check_Cust.Visible = False
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
            ItemList.Items.Clear()
            ItemList.Visible = False
            ItemLabel.Visible = False
            AmountPayLabel.Visible = False
            Amount_Text.Visible = False
            DGVData.Visible = True
            ItemText.Visible = False
            Search_Item.Visible = False
            AmountLabel.Visible = False
            QuantityText.Visible = False
            QuantityLabel.Visible = False
            AmountLabel.Visible = False
            AmountLabel.Text = "Amount Left :"
            TotalQuantity.Visible = False
            PayList.Visible = False
            TotalPrice.Visible = False
            ToPayment.Visible = False
            EnterID.Visible = True
            ID_Text.Visible = True
            Emp_Label.Visible = True
            Done.Visible = False
            Pay.Visible = False
            Emp_Label.Text = "Salesman ID "
            ID_Text.Text = ""
            ID_Text.Focus()
            If SQL.HasConnection = True Then
                SQL.RunQuery("Select Emp_ID,First_Name,Last_Name From Employee")
                If SQL.SQLDataset.Tables.Count > 0 Then
                    DGVData.DataSource = SQL.SQLDataset.Tables(0)
                End If
            End If
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
    Private Sub CheckAll_Click(sender As Object, e As EventArgs) Handles Search_Item.Click
        If SQL.HasConnection = True Then
            SQL.RunQuery("Select * From Item")
            If SQL.SQLDataset.Tables.Count > 0 Then
                DGVData.DataSource = SQL.SQLDataset.Tables(0)
            End If
        End If
    End Sub
    Private Sub CheckCust_Click(sender As Object, e As EventArgs) Handles Check_Cust.Click
        If SQL.HasConnection = True Then
            SQL.RunQuery("Select Cust_ID,Cust_Name From Customer")
            If SQL.SQLDataset.Tables.Count > 0 Then
                DGVData.DataSource = SQL.SQLDataset.Tables(0)
            End If
        End If
    End Sub

    Private Sub PayList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles PayList.SelectedIndexChanged

    End Sub
End Class
