<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class POS
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Emp_Label = New System.Windows.Forms.Label()
        Me.ID_Text = New System.Windows.Forms.TextBox()
        Me.EnterID = New System.Windows.Forms.Button()
        Me.ItemList = New System.Windows.Forms.ListBox()
        Me.AmountLabel = New System.Windows.Forms.Label()
        Me.PayList = New System.Windows.Forms.ListBox()
        Me.ItemLabel = New System.Windows.Forms.Label()
        Me.QuantityLabel = New System.Windows.Forms.Label()
        Me.ItemText = New System.Windows.Forms.TextBox()
        Me.QuantityText = New System.Windows.Forms.TextBox()
        Me.TotalQuantity = New System.Windows.Forms.Label()
        Me.TotalPrice = New System.Windows.Forms.Label()
        Me.ToPayment = New System.Windows.Forms.Button()
        Me.EnterItem = New System.Windows.Forms.Button()
        Me.Pay = New System.Windows.Forms.Button()
        Me.Amount_Text = New System.Windows.Forms.TextBox()
        Me.AmountPayLabel = New System.Windows.Forms.Label()
        Me.Done = New System.Windows.Forms.Button()
        Me.DGVData = New System.Windows.Forms.DataGridView()
        Me.Search_Item = New System.Windows.Forms.Button()
        Me.CustLabel = New System.Windows.Forms.Label()
        Me.CustInput = New System.Windows.Forms.TextBox()
        Me.Check_Cust = New System.Windows.Forms.Button()
        Me.PinLabel = New System.Windows.Forms.Label()
        Me.PinText = New System.Windows.Forms.TextBox()
        CType(Me.DGVData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Emp_Label
        '
        Me.Emp_Label.AutoSize = True
        Me.Emp_Label.Location = New System.Drawing.Point(163, 100)
        Me.Emp_Label.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Emp_Label.Name = "Emp_Label"
        Me.Emp_Label.Size = New System.Drawing.Size(176, 32)
        Me.Emp_Label.TabIndex = 0
        Me.Emp_Label.Text = "Salesman ID"
        '
        'ID_Text
        '
        Me.ID_Text.Location = New System.Drawing.Point(357, 93)
        Me.ID_Text.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.ID_Text.Name = "ID_Text"
        Me.ID_Text.Size = New System.Drawing.Size(260, 38)
        Me.ID_Text.TabIndex = 1
        '
        'EnterID
        '
        Me.EnterID.Location = New System.Drawing.Point(667, 93)
        Me.EnterID.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.EnterID.Name = "EnterID"
        Me.EnterID.Size = New System.Drawing.Size(200, 55)
        Me.EnterID.TabIndex = 2
        Me.EnterID.Text = "Enter"
        Me.EnterID.UseVisualStyleBackColor = True
        '
        'ItemList
        '
        Me.ItemList.FormattingEnabled = True
        Me.ItemList.ItemHeight = 31
        Me.ItemList.Location = New System.Drawing.Point(67, 145)
        Me.ItemList.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.ItemList.Name = "ItemList"
        Me.ItemList.Size = New System.Drawing.Size(740, 531)
        Me.ItemList.TabIndex = 3
        '
        'AmountLabel
        '
        Me.AmountLabel.AutoSize = True
        Me.AmountLabel.Location = New System.Drawing.Point(829, 446)
        Me.AmountLabel.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.AmountLabel.Name = "AmountLabel"
        Me.AmountLabel.Size = New System.Drawing.Size(183, 32)
        Me.AmountLabel.TabIndex = 5
        Me.AmountLabel.Text = "Amount Left :"
        '
        'PayList
        '
        Me.PayList.FormattingEnabled = True
        Me.PayList.ItemHeight = 31
        Me.PayList.Location = New System.Drawing.Point(1853, 86)
        Me.PayList.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.PayList.Name = "PayList"
        Me.PayList.Size = New System.Drawing.Size(409, 500)
        Me.PayList.TabIndex = 6
        '
        'ItemLabel
        '
        Me.ItemLabel.AutoSize = True
        Me.ItemLabel.Location = New System.Drawing.Point(1187, 105)
        Me.ItemLabel.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.ItemLabel.Name = "ItemLabel"
        Me.ItemLabel.Size = New System.Drawing.Size(103, 32)
        Me.ItemLabel.TabIndex = 7
        Me.ItemLabel.Text = "Item ID"
        '
        'QuantityLabel
        '
        Me.QuantityLabel.AutoSize = True
        Me.QuantityLabel.Location = New System.Drawing.Point(1187, 169)
        Me.QuantityLabel.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.QuantityLabel.Name = "QuantityLabel"
        Me.QuantityLabel.Size = New System.Drawing.Size(122, 32)
        Me.QuantityLabel.TabIndex = 8
        Me.QuantityLabel.Text = "Quantity"
        '
        'ItemText
        '
        Me.ItemText.Location = New System.Drawing.Point(1363, 107)
        Me.ItemText.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.ItemText.Name = "ItemText"
        Me.ItemText.Size = New System.Drawing.Size(260, 38)
        Me.ItemText.TabIndex = 9
        '
        'QuantityText
        '
        Me.QuantityText.Location = New System.Drawing.Point(1363, 169)
        Me.QuantityText.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.QuantityText.Name = "QuantityText"
        Me.QuantityText.Size = New System.Drawing.Size(260, 38)
        Me.QuantityText.TabIndex = 10
        '
        'TotalQuantity
        '
        Me.TotalQuantity.AutoSize = True
        Me.TotalQuantity.Location = New System.Drawing.Point(829, 336)
        Me.TotalQuantity.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.TotalQuantity.Name = "TotalQuantity"
        Me.TotalQuantity.Size = New System.Drawing.Size(215, 32)
        Me.TotalQuantity.TabIndex = 11
        Me.TotalQuantity.Text = "Total Quantity : "
        '
        'TotalPrice
        '
        Me.TotalPrice.AutoSize = True
        Me.TotalPrice.Location = New System.Drawing.Point(829, 391)
        Me.TotalPrice.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.TotalPrice.Name = "TotalPrice"
        Me.TotalPrice.Size = New System.Drawing.Size(173, 32)
        Me.TotalPrice.TabIndex = 12
        Me.TotalPrice.Text = "Total Price : "
        '
        'ToPayment
        '
        Me.ToPayment.Location = New System.Drawing.Point(824, 627)
        Me.ToPayment.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.ToPayment.Name = "ToPayment"
        Me.ToPayment.Size = New System.Drawing.Size(200, 55)
        Me.ToPayment.TabIndex = 13
        Me.ToPayment.Text = "Payment"
        Me.ToPayment.UseVisualStyleBackColor = True
        '
        'EnterItem
        '
        Me.EnterItem.Location = New System.Drawing.Point(1363, 255)
        Me.EnterItem.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.EnterItem.Name = "EnterItem"
        Me.EnterItem.Size = New System.Drawing.Size(200, 55)
        Me.EnterItem.TabIndex = 14
        Me.EnterItem.Text = "Enter Item"
        Me.EnterItem.UseVisualStyleBackColor = True
        '
        'Pay
        '
        Me.Pay.Location = New System.Drawing.Point(1853, 699)
        Me.Pay.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.Pay.Name = "Pay"
        Me.Pay.Size = New System.Drawing.Size(200, 55)
        Me.Pay.TabIndex = 15
        Me.Pay.Text = "Pay"
        Me.Pay.UseVisualStyleBackColor = True
        '
        'Amount_Text
        '
        Me.Amount_Text.Location = New System.Drawing.Point(1853, 627)
        Me.Amount_Text.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.Amount_Text.Name = "Amount_Text"
        Me.Amount_Text.Size = New System.Drawing.Size(260, 38)
        Me.Amount_Text.TabIndex = 16
        '
        'AmountPayLabel
        '
        Me.AmountPayLabel.AutoSize = True
        Me.AmountPayLabel.Location = New System.Drawing.Point(1707, 639)
        Me.AmountPayLabel.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.AmountPayLabel.Name = "AmountPayLabel"
        Me.AmountPayLabel.Size = New System.Drawing.Size(113, 32)
        Me.AmountPayLabel.TabIndex = 17
        Me.AmountPayLabel.Text = "Amount"
        '
        'Done
        '
        Me.Done.Location = New System.Drawing.Point(1363, 813)
        Me.Done.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.Done.Name = "Done"
        Me.Done.Size = New System.Drawing.Size(200, 55)
        Me.Done.TabIndex = 18
        Me.Done.Text = "Done"
        Me.Done.UseVisualStyleBackColor = True
        '
        'DGVData
        '
        Me.DGVData.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGVData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVData.Location = New System.Drawing.Point(1245, 391)
        Me.DGVData.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.DGVData.Name = "DGVData"
        Me.DGVData.Size = New System.Drawing.Size(1109, 610)
        Me.DGVData.TabIndex = 19
        '
        'Search_Item
        '
        Me.Search_Item.Location = New System.Drawing.Point(1645, 107)
        Me.Search_Item.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.Search_Item.Name = "Search_Item"
        Me.Search_Item.Size = New System.Drawing.Size(200, 55)
        Me.Search_Item.TabIndex = 20
        Me.Search_Item.Text = "Search"
        Me.Search_Item.UseVisualStyleBackColor = True
        '
        'CustLabel
        '
        Me.CustLabel.AutoSize = True
        Me.CustLabel.Location = New System.Drawing.Point(1187, 52)
        Me.CustLabel.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.CustLabel.Name = "CustLabel"
        Me.CustLabel.Size = New System.Drawing.Size(137, 32)
        Me.CustLabel.TabIndex = 22
        Me.CustLabel.Text = "Customer"
        '
        'CustInput
        '
        Me.CustInput.Location = New System.Drawing.Point(1363, 45)
        Me.CustInput.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.CustInput.Name = "CustInput"
        Me.CustInput.Size = New System.Drawing.Size(260, 38)
        Me.CustInput.TabIndex = 23
        '
        'Check_Cust
        '
        Me.Check_Cust.Location = New System.Drawing.Point(1645, 45)
        Me.Check_Cust.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.Check_Cust.Name = "Check_Cust"
        Me.Check_Cust.Size = New System.Drawing.Size(200, 55)
        Me.Check_Cust.TabIndex = 24
        Me.Check_Cust.Text = "Search"
        Me.Check_Cust.UseVisualStyleBackColor = True
        '
        'PinLabel
        '
        Me.PinLabel.AutoSize = True
        Me.PinLabel.Location = New System.Drawing.Point(1707, 686)
        Me.PinLabel.Name = "PinLabel"
        Me.PinLabel.Size = New System.Drawing.Size(57, 32)
        Me.PinLabel.TabIndex = 25
        Me.PinLabel.Text = "Pin"
        '
        'PinText
        '
        Me.PinText.Location = New System.Drawing.Point(1853, 686)
        Me.PinText.Name = "PinText"
        Me.PinText.Size = New System.Drawing.Size(260, 38)
        Me.PinText.TabIndex = 26
        '
        'POS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(2352, 987)
        Me.Controls.Add(Me.PinText)
        Me.Controls.Add(Me.PinLabel)
        Me.Controls.Add(Me.Check_Cust)
        Me.Controls.Add(Me.CustInput)
        Me.Controls.Add(Me.ItemList)
        Me.Controls.Add(Me.CustLabel)
        Me.Controls.Add(Me.Search_Item)
        Me.Controls.Add(Me.Done)
        Me.Controls.Add(Me.AmountPayLabel)
        Me.Controls.Add(Me.Amount_Text)
        Me.Controls.Add(Me.Pay)
        Me.Controls.Add(Me.EnterItem)
        Me.Controls.Add(Me.ToPayment)
        Me.Controls.Add(Me.TotalPrice)
        Me.Controls.Add(Me.TotalQuantity)
        Me.Controls.Add(Me.QuantityText)
        Me.Controls.Add(Me.ItemText)
        Me.Controls.Add(Me.QuantityLabel)
        Me.Controls.Add(Me.ItemLabel)
        Me.Controls.Add(Me.PayList)
        Me.Controls.Add(Me.AmountLabel)
        Me.Controls.Add(Me.EnterID)
        Me.Controls.Add(Me.ID_Text)
        Me.Controls.Add(Me.Emp_Label)
        Me.Controls.Add(Me.DGVData)
        Me.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.Name = "POS"
        Me.Text = "Point of Sales"
        CType(Me.DGVData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Emp_Label As System.Windows.Forms.Label
    Friend WithEvents ID_Text As System.Windows.Forms.TextBox
    Friend WithEvents EnterID As System.Windows.Forms.Button
    Friend WithEvents ItemList As System.Windows.Forms.ListBox
    Friend WithEvents AmountLabel As System.Windows.Forms.Label
    Friend WithEvents PayList As System.Windows.Forms.ListBox
    Friend WithEvents ItemLabel As System.Windows.Forms.Label
    Friend WithEvents QuantityLabel As System.Windows.Forms.Label
    Friend WithEvents ItemText As System.Windows.Forms.TextBox
    Friend WithEvents QuantityText As System.Windows.Forms.TextBox
    Friend WithEvents TotalQuantity As System.Windows.Forms.Label
    Friend WithEvents TotalPrice As System.Windows.Forms.Label
    Friend WithEvents ToPayment As System.Windows.Forms.Button
    Friend WithEvents EnterItem As System.Windows.Forms.Button
    Friend WithEvents Pay As System.Windows.Forms.Button
    Friend WithEvents Amount_Text As System.Windows.Forms.TextBox
    Friend WithEvents AmountPayLabel As System.Windows.Forms.Label
    Friend WithEvents Done As System.Windows.Forms.Button
    Friend WithEvents DGVData As System.Windows.Forms.DataGridView
    Friend WithEvents Search_Item As System.Windows.Forms.Button
    Friend WithEvents CustLabel As System.Windows.Forms.Label
    Friend WithEvents CustInput As System.Windows.Forms.TextBox
    Friend WithEvents Check_Cust As System.Windows.Forms.Button
    Friend WithEvents PinLabel As Label
    Friend WithEvents PinText As TextBox
End Class
