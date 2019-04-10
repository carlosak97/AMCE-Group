<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Me.PercLabel = New System.Windows.Forms.Label()
        Me.PinText = New System.Windows.Forms.TextBox()
        Me.PinLabel = New System.Windows.Forms.Label()
        Me.CustInput = New System.Windows.Forms.TextBox()
        Me.ItemList = New System.Windows.Forms.ListBox()
        Me.CustLabel = New System.Windows.Forms.Label()
        Me.Done = New System.Windows.Forms.Button()
        Me.AmountPayLabel = New System.Windows.Forms.Label()
        Me.Amount_Text = New System.Windows.Forms.TextBox()
        Me.Pay = New System.Windows.Forms.Button()
        Me.EnterItem = New System.Windows.Forms.Button()
        Me.ToPayment = New System.Windows.Forms.Button()
        Me.TotalPrice = New System.Windows.Forms.Label()
        Me.TotalQuantity = New System.Windows.Forms.Label()
        Me.QuantityText = New System.Windows.Forms.TextBox()
        Me.ItemText = New System.Windows.Forms.TextBox()
        Me.QuantityLabel = New System.Windows.Forms.Label()
        Me.ItemLabel = New System.Windows.Forms.Label()
        Me.PayList = New System.Windows.Forms.ListBox()
        Me.AmountLabel = New System.Windows.Forms.Label()
        Me.EnterID = New System.Windows.Forms.Button()
        Me.ID_Text = New System.Windows.Forms.TextBox()
        Me.Emp_Label = New System.Windows.Forms.Label()
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.LookUpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalesName = New System.Windows.Forms.Label()
        Me.SignOutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'PercLabel
        '
        Me.PercLabel.AutoSize = True
        Me.PercLabel.Location = New System.Drawing.Point(304, 304)
        Me.PercLabel.Name = "PercLabel"
        Me.PercLabel.Size = New System.Drawing.Size(58, 13)
        Me.PercLabel.TabIndex = 55
        Me.PercLabel.Text = "Discount : "
        '
        'PinText
        '
        Me.PinText.Location = New System.Drawing.Point(761, 325)
        Me.PinText.Margin = New System.Windows.Forms.Padding(1)
        Me.PinText.Name = "PinText"
        Me.PinText.Size = New System.Drawing.Size(100, 20)
        Me.PinText.TabIndex = 53
        '
        'PinLabel
        '
        Me.PinLabel.AutoSize = True
        Me.PinLabel.Location = New System.Drawing.Point(733, 328)
        Me.PinLabel.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.PinLabel.Name = "PinLabel"
        Me.PinLabel.Size = New System.Drawing.Size(22, 13)
        Me.PinLabel.TabIndex = 52
        Me.PinLabel.Text = "Pin"
        '
        'CustInput
        '
        Me.CustInput.Location = New System.Drawing.Point(511, 98)
        Me.CustInput.Name = "CustInput"
        Me.CustInput.Size = New System.Drawing.Size(100, 20)
        Me.CustInput.TabIndex = 50
        '
        'ItemList
        '
        Me.ItemList.FormattingEnabled = True
        Me.ItemList.Location = New System.Drawing.Point(12, 98)
        Me.ItemList.Name = "ItemList"
        Me.ItemList.Size = New System.Drawing.Size(280, 355)
        Me.ItemList.TabIndex = 32
        '
        'CustLabel
        '
        Me.CustLabel.AutoSize = True
        Me.CustLabel.Location = New System.Drawing.Point(445, 101)
        Me.CustLabel.Name = "CustLabel"
        Me.CustLabel.Size = New System.Drawing.Size(51, 13)
        Me.CustLabel.TabIndex = 49
        Me.CustLabel.Text = "Customer"
        '
        'Done
        '
        Me.Done.Location = New System.Drawing.Point(422, 430)
        Me.Done.Name = "Done"
        Me.Done.Size = New System.Drawing.Size(75, 23)
        Me.Done.TabIndex = 46
        Me.Done.Text = "Done"
        Me.Done.UseVisualStyleBackColor = True
        '
        'AmountPayLabel
        '
        Me.AmountPayLabel.AutoSize = True
        Me.AmountPayLabel.Location = New System.Drawing.Point(712, 304)
        Me.AmountPayLabel.Name = "AmountPayLabel"
        Me.AmountPayLabel.Size = New System.Drawing.Size(43, 13)
        Me.AmountPayLabel.TabIndex = 45
        Me.AmountPayLabel.Text = "Amount"
        '
        'Amount_Text
        '
        Me.Amount_Text.Location = New System.Drawing.Point(761, 301)
        Me.Amount_Text.Name = "Amount_Text"
        Me.Amount_Text.Size = New System.Drawing.Size(100, 20)
        Me.Amount_Text.TabIndex = 44
        '
        'Pay
        '
        Me.Pay.Location = New System.Drawing.Point(774, 325)
        Me.Pay.Name = "Pay"
        Me.Pay.Size = New System.Drawing.Size(75, 23)
        Me.Pay.TabIndex = 43
        Me.Pay.Text = "Pay"
        Me.Pay.UseVisualStyleBackColor = True
        '
        'EnterItem
        '
        Me.EnterItem.Location = New System.Drawing.Point(511, 176)
        Me.EnterItem.Name = "EnterItem"
        Me.EnterItem.Size = New System.Drawing.Size(75, 23)
        Me.EnterItem.TabIndex = 42
        Me.EnterItem.Text = "Enter"
        Me.EnterItem.UseVisualStyleBackColor = True
        '
        'ToPayment
        '
        Me.ToPayment.Location = New System.Drawing.Point(307, 361)
        Me.ToPayment.Name = "ToPayment"
        Me.ToPayment.Size = New System.Drawing.Size(75, 23)
        Me.ToPayment.TabIndex = 41
        Me.ToPayment.Text = "Payment"
        Me.ToPayment.UseVisualStyleBackColor = True
        '
        'TotalPrice
        '
        Me.TotalPrice.AutoSize = True
        Me.TotalPrice.Location = New System.Drawing.Point(304, 254)
        Me.TotalPrice.Name = "TotalPrice"
        Me.TotalPrice.Size = New System.Drawing.Size(67, 13)
        Me.TotalPrice.TabIndex = 40
        Me.TotalPrice.Text = "Total Price : "
        '
        'TotalQuantity
        '
        Me.TotalQuantity.AutoSize = True
        Me.TotalQuantity.Location = New System.Drawing.Point(304, 226)
        Me.TotalQuantity.Name = "TotalQuantity"
        Me.TotalQuantity.Size = New System.Drawing.Size(82, 13)
        Me.TotalQuantity.TabIndex = 39
        Me.TotalQuantity.Text = "Total Quantity : "
        '
        'QuantityText
        '
        Me.QuantityText.Location = New System.Drawing.Point(511, 150)
        Me.QuantityText.Name = "QuantityText"
        Me.QuantityText.Size = New System.Drawing.Size(100, 20)
        Me.QuantityText.TabIndex = 38
        '
        'ItemText
        '
        Me.ItemText.Location = New System.Drawing.Point(511, 124)
        Me.ItemText.Name = "ItemText"
        Me.ItemText.Size = New System.Drawing.Size(100, 20)
        Me.ItemText.TabIndex = 37
        '
        'QuantityLabel
        '
        Me.QuantityLabel.AutoSize = True
        Me.QuantityLabel.Location = New System.Drawing.Point(445, 150)
        Me.QuantityLabel.Name = "QuantityLabel"
        Me.QuantityLabel.Size = New System.Drawing.Size(46, 13)
        Me.QuantityLabel.TabIndex = 36
        Me.QuantityLabel.Text = "Quantity"
        '
        'ItemLabel
        '
        Me.ItemLabel.AutoSize = True
        Me.ItemLabel.Location = New System.Drawing.Point(445, 123)
        Me.ItemLabel.Name = "ItemLabel"
        Me.ItemLabel.Size = New System.Drawing.Size(41, 13)
        Me.ItemLabel.TabIndex = 35
        Me.ItemLabel.Text = "Item ID"
        '
        'PayList
        '
        Me.PayList.FormattingEnabled = True
        Me.PayList.Location = New System.Drawing.Point(715, 83)
        Me.PayList.Name = "PayList"
        Me.PayList.Size = New System.Drawing.Size(156, 212)
        Me.PayList.TabIndex = 34
        '
        'AmountLabel
        '
        Me.AmountLabel.AutoSize = True
        Me.AmountLabel.Location = New System.Drawing.Point(304, 279)
        Me.AmountLabel.Name = "AmountLabel"
        Me.AmountLabel.Size = New System.Drawing.Size(70, 13)
        Me.AmountLabel.TabIndex = 33
        Me.AmountLabel.Text = "Amount Left :"
        '
        'EnterID
        '
        Me.EnterID.Location = New System.Drawing.Point(254, 63)
        Me.EnterID.Name = "EnterID"
        Me.EnterID.Size = New System.Drawing.Size(75, 23)
        Me.EnterID.TabIndex = 31
        Me.EnterID.Text = "Enter"
        Me.EnterID.UseVisualStyleBackColor = True
        '
        'ID_Text
        '
        Me.ID_Text.Location = New System.Drawing.Point(148, 66)
        Me.ID_Text.Name = "ID_Text"
        Me.ID_Text.Size = New System.Drawing.Size(100, 20)
        Me.ID_Text.TabIndex = 30
        '
        'Emp_Label
        '
        Me.Emp_Label.AutoSize = True
        Me.Emp_Label.Location = New System.Drawing.Point(21, 69)
        Me.Emp_Label.Name = "Emp_Label"
        Me.Emp_Label.Size = New System.Drawing.Size(67, 13)
        Me.Emp_Label.TabIndex = 29
        Me.Emp_Label.Text = "Salesman ID"
        '
        'MenuStrip
        '
        Me.MenuStrip.BackColor = System.Drawing.SystemColors.Info
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LookUpToolStripMenuItem, Me.SignOutToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(944, 24)
        Me.MenuStrip.TabIndex = 56
        Me.MenuStrip.Text = "Menu"
        '
        'LookUpToolStripMenuItem
        '
        Me.LookUpToolStripMenuItem.Name = "LookUpToolStripMenuItem"
        Me.LookUpToolStripMenuItem.Size = New System.Drawing.Size(63, 20)
        Me.LookUpToolStripMenuItem.Text = "Look Up"
        '
        'SalesName
        '
        Me.SalesName.AutoSize = True
        Me.SalesName.Location = New System.Drawing.Point(125, 195)
        Me.SalesName.Name = "SalesName"
        Me.SalesName.Size = New System.Drawing.Size(33, 13)
        Me.SalesName.TabIndex = 57
        Me.SalesName.Text = "None"
        '
        'SignOutToolStripMenuItem
        '
        Me.SignOutToolStripMenuItem.Name = "SignOutToolStripMenuItem"
        Me.SignOutToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.SignOutToolStripMenuItem.Text = "Sign Out"
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(944, 474)
        Me.Controls.Add(Me.ItemList)
        Me.Controls.Add(Me.PercLabel)
        Me.Controls.Add(Me.PinText)
        Me.Controls.Add(Me.PinLabel)
        Me.Controls.Add(Me.CustInput)
        Me.Controls.Add(Me.CustLabel)
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
        Me.Controls.Add(Me.MenuStrip)
        Me.Controls.Add(Me.SalesName)
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "Main"
        Me.Text = "Point Of Sales"
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PercLabel As System.Windows.Forms.Label
    Friend WithEvents PinText As System.Windows.Forms.TextBox
    Friend WithEvents PinLabel As System.Windows.Forms.Label
    Friend WithEvents CustInput As System.Windows.Forms.TextBox
    Friend WithEvents ItemList As System.Windows.Forms.ListBox
    Friend WithEvents CustLabel As System.Windows.Forms.Label
    Friend WithEvents Done As System.Windows.Forms.Button
    Friend WithEvents AmountPayLabel As System.Windows.Forms.Label
    Friend WithEvents Amount_Text As System.Windows.Forms.TextBox
    Friend WithEvents Pay As System.Windows.Forms.Button
    Friend WithEvents EnterItem As System.Windows.Forms.Button
    Friend WithEvents ToPayment As System.Windows.Forms.Button
    Friend WithEvents TotalPrice As System.Windows.Forms.Label
    Friend WithEvents TotalQuantity As System.Windows.Forms.Label
    Friend WithEvents QuantityText As System.Windows.Forms.TextBox
    Friend WithEvents ItemText As System.Windows.Forms.TextBox
    Friend WithEvents QuantityLabel As System.Windows.Forms.Label
    Friend WithEvents ItemLabel As System.Windows.Forms.Label
    Friend WithEvents PayList As System.Windows.Forms.ListBox
    Friend WithEvents AmountLabel As System.Windows.Forms.Label
    Friend WithEvents EnterID As System.Windows.Forms.Button
    Friend WithEvents ID_Text As System.Windows.Forms.TextBox
    Friend WithEvents Emp_Label As System.Windows.Forms.Label
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents LookUpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalesName As System.Windows.Forms.Label
    Friend WithEvents SignOutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
