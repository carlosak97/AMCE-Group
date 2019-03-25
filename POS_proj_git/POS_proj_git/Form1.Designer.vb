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
        Me.CheckAll = New System.Windows.Forms.Button()
        CType(Me.DGVData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Emp_Label
        '
        Me.Emp_Label.AutoSize = True
        Me.Emp_Label.Location = New System.Drawing.Point(38, 45)
        Me.Emp_Label.Name = "Emp_Label"
        Me.Emp_Label.Size = New System.Drawing.Size(67, 13)
        Me.Emp_Label.TabIndex = 0
        Me.Emp_Label.Text = "Salesman ID"
        '
        'ID_Text
        '
        Me.ID_Text.Location = New System.Drawing.Point(130, 42)
        Me.ID_Text.Name = "ID_Text"
        Me.ID_Text.Size = New System.Drawing.Size(100, 20)
        Me.ID_Text.TabIndex = 1
        '
        'EnterID
        '
        Me.EnterID.Location = New System.Drawing.Point(311, 45)
        Me.EnterID.Name = "EnterID"
        Me.EnterID.Size = New System.Drawing.Size(75, 23)
        Me.EnterID.TabIndex = 2
        Me.EnterID.Text = "Enter"
        Me.EnterID.UseVisualStyleBackColor = True
        '
        'ItemList
        '
        Me.ItemList.FormattingEnabled = True
        Me.ItemList.Location = New System.Drawing.Point(25, 61)
        Me.ItemList.Name = "ItemList"
        Me.ItemList.Size = New System.Drawing.Size(280, 225)
        Me.ItemList.TabIndex = 3
        '
        'AmountLabel
        '
        Me.AmountLabel.AutoSize = True
        Me.AmountLabel.Location = New System.Drawing.Point(311, 187)
        Me.AmountLabel.Name = "AmountLabel"
        Me.AmountLabel.Size = New System.Drawing.Size(64, 13)
        Me.AmountLabel.TabIndex = 5
        Me.AmountLabel.Text = "Amount Left"
        '
        'PayList
        '
        Me.PayList.FormattingEnabled = True
        Me.PayList.Location = New System.Drawing.Point(695, 36)
        Me.PayList.Name = "PayList"
        Me.PayList.Size = New System.Drawing.Size(156, 212)
        Me.PayList.TabIndex = 6
        '
        'ItemLabel
        '
        Me.ItemLabel.AutoSize = True
        Me.ItemLabel.Location = New System.Drawing.Point(455, 45)
        Me.ItemLabel.Name = "ItemLabel"
        Me.ItemLabel.Size = New System.Drawing.Size(41, 13)
        Me.ItemLabel.TabIndex = 7
        Me.ItemLabel.Text = "Item ID"
        '
        'QuantityLabel
        '
        Me.QuantityLabel.AutoSize = True
        Me.QuantityLabel.Location = New System.Drawing.Point(458, 71)
        Me.QuantityLabel.Name = "QuantityLabel"
        Me.QuantityLabel.Size = New System.Drawing.Size(46, 13)
        Me.QuantityLabel.TabIndex = 8
        Me.QuantityLabel.Text = "Quantity"
        '
        'ItemText
        '
        Me.ItemText.Location = New System.Drawing.Point(511, 45)
        Me.ItemText.Name = "ItemText"
        Me.ItemText.Size = New System.Drawing.Size(100, 20)
        Me.ItemText.TabIndex = 9
        '
        'QuantityText
        '
        Me.QuantityText.Location = New System.Drawing.Point(511, 71)
        Me.QuantityText.Name = "QuantityText"
        Me.QuantityText.Size = New System.Drawing.Size(100, 20)
        Me.QuantityText.TabIndex = 10
        '
        'TotalQuantity
        '
        Me.TotalQuantity.AutoSize = True
        Me.TotalQuantity.Location = New System.Drawing.Point(311, 141)
        Me.TotalQuantity.Name = "TotalQuantity"
        Me.TotalQuantity.Size = New System.Drawing.Size(82, 13)
        Me.TotalQuantity.TabIndex = 11
        Me.TotalQuantity.Text = "Total Quantity : "
        '
        'TotalPrice
        '
        Me.TotalPrice.AutoSize = True
        Me.TotalPrice.Location = New System.Drawing.Point(311, 164)
        Me.TotalPrice.Name = "TotalPrice"
        Me.TotalPrice.Size = New System.Drawing.Size(67, 13)
        Me.TotalPrice.TabIndex = 12
        Me.TotalPrice.Text = "Total Price : "
        '
        'ToPayment
        '
        Me.ToPayment.Location = New System.Drawing.Point(309, 263)
        Me.ToPayment.Name = "ToPayment"
        Me.ToPayment.Size = New System.Drawing.Size(75, 23)
        Me.ToPayment.TabIndex = 13
        Me.ToPayment.Text = "Payment"
        Me.ToPayment.UseVisualStyleBackColor = True
        '
        'EnterItem
        '
        Me.EnterItem.Location = New System.Drawing.Point(511, 107)
        Me.EnterItem.Name = "EnterItem"
        Me.EnterItem.Size = New System.Drawing.Size(75, 23)
        Me.EnterItem.TabIndex = 14
        Me.EnterItem.Text = "Enter Item"
        Me.EnterItem.UseVisualStyleBackColor = True
        '
        'Pay
        '
        Me.Pay.Location = New System.Drawing.Point(695, 293)
        Me.Pay.Name = "Pay"
        Me.Pay.Size = New System.Drawing.Size(75, 23)
        Me.Pay.TabIndex = 15
        Me.Pay.Text = "Pay"
        Me.Pay.UseVisualStyleBackColor = True
        '
        'Amount_Text
        '
        Me.Amount_Text.Location = New System.Drawing.Point(695, 263)
        Me.Amount_Text.Name = "Amount_Text"
        Me.Amount_Text.Size = New System.Drawing.Size(100, 20)
        Me.Amount_Text.TabIndex = 16
        '
        'AmountPayLabel
        '
        Me.AmountPayLabel.AutoSize = True
        Me.AmountPayLabel.Location = New System.Drawing.Point(640, 268)
        Me.AmountPayLabel.Name = "AmountPayLabel"
        Me.AmountPayLabel.Size = New System.Drawing.Size(43, 13)
        Me.AmountPayLabel.TabIndex = 17
        Me.AmountPayLabel.Text = "Amount"
        '
        'Done
        '
        Me.Done.Location = New System.Drawing.Point(511, 341)
        Me.Done.Name = "Done"
        Me.Done.Size = New System.Drawing.Size(75, 23)
        Me.Done.TabIndex = 18
        Me.Done.Text = "Done"
        Me.Done.UseVisualStyleBackColor = True
        '
        'DGVData
        '
        Me.DGVData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVData.Location = New System.Drawing.Point(213, 51)
        Me.DGVData.Name = "DGVData"
        Me.DGVData.Size = New System.Drawing.Size(448, 232)
        Me.DGVData.TabIndex = 19
        '
        'CheckAll
        '
        Me.CheckAll.Location = New System.Drawing.Point(408, 341)
        Me.CheckAll.Name = "CheckAll"
        Me.CheckAll.Size = New System.Drawing.Size(75, 23)
        Me.CheckAll.TabIndex = 20
        Me.CheckAll.Text = "Search"
        Me.CheckAll.UseVisualStyleBackColor = True
        '
        'POS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(863, 378)
        Me.Controls.Add(Me.CheckAll)
        Me.Controls.Add(Me.DGVData)
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
        Me.Controls.Add(Me.ItemList)
        Me.Controls.Add(Me.EnterID)
        Me.Controls.Add(Me.ID_Text)
        Me.Controls.Add(Me.Emp_Label)
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
    Friend WithEvents CheckAll As System.Windows.Forms.Button

End Class
