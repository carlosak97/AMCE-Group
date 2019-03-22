Public Class POS
    Dim ID As Nullable(Of Integer) = Nothing
    Dim Item_ID As Integer
    Dim TQuan As Integer
    Dim TPay As Integer
    Dim PayL As Integer
    Dim OP As Boolean
    Dim SQL As New SQLControl
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If SQL.HasConnection = True Then
            MsgBox("Connected")
        End If
        ID_Text.Focus()
        OP = False
        AmountLabel.Visible = False
        ItemList.Visible = False
        PayList.Visible = False
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
            If (ID > 0) Then
                AmountLabel.Visible = True
                EnterID.Visible = False
                ID_Text.Visible = False
                Label1.Visible = False
                ItemList.Visible = True
                ItemLabel.Visible = True
                EnterItem.Visible = True
                ItemText.Visible = True
                QuantityText.Visible = True
                QuantityLabel.Visible = True
                TotalQuantity.Visible = True
                TotalPrice.Visible = True
                ToPayment.Visible = True
                ItemText.Focus()
            Else
                MsgBox("Wrond ID entered")
            End If
        Catch ex As Exception
            MsgBox("Enter ID")
        End Try





    End Sub

    Private Sub EnterItem_Click(sender As Object, e As EventArgs) Handles EnterItem.Click
        Try
            Item_ID = ItemText.Text
            TQuan = TQuan + QuantityText.Text
            ItemText.Text = ""
            QuantityText.Text = ""
            TotalQuantity.Text = "Total Quantity : " + TQuan.ToString
            ItemText.Focus()
            PayL = PayL + 20
            TPay = TPay + 20
            TotalPrice.Text = "Total Price : " + TPay.ToString
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
        Label1.Visible = False
        ItemLabel.Visible = False
        Amount_Text.Visible = True
        ItemText.Visible = False
        QuantityText.Visible = False
        QuantityLabel.Visible = False
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
            Amount_Text.Visible = False
            ItemText.Visible = False
            AmountLabel.Visible = False
            QuantityText.Visible = False
            QuantityLabel.Visible = False
            AmountLabel.Visible = False
            TotalQuantity.Visible = False
            PayList.Visible = False
            TotalPrice.Visible = False
            ToPayment.Visible = False
            EnterID.Visible = True
            ID_Text.Visible = True
            Label1.Visible = True
            Done.Visible = False
            Pay.Visible = False

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

End Class
