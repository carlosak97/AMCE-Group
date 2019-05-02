<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Customer
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
        Dim Tel_Text As System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Name_Text = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Age_Text = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Cust_Prog = New System.Windows.Forms.RadioButton()
        Me.Loyal_Prog = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Enter_Button = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Date_Text = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.LookUpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SignOutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Tel_Text = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.MenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(43, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Name"
        '
        'Name_Text
        '
        Me.Name_Text.Location = New System.Drawing.Point(84, 43)
        Me.Name_Text.Name = "Name_Text"
        Me.Name_Text.Size = New System.Drawing.Size(100, 20)
        Me.Name_Text.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(53, 101)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(26, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Age"
        '
        'Age_Text
        '
        Me.Age_Text.Location = New System.Drawing.Point(85, 98)
        Me.Age_Text.Name = "Age_Text"
        Me.Age_Text.Size = New System.Drawing.Size(100, 20)
        Me.Age_Text.TabIndex = 3
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Cust_Prog)
        Me.GroupBox1.Controls.Add(Me.Loyal_Prog)
        Me.GroupBox1.Location = New System.Drawing.Point(434, 36)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 96)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Program"
        '
        'Cust_Prog
        '
        Me.Cust_Prog.AutoSize = True
        Me.Cust_Prog.Location = New System.Drawing.Point(48, 69)
        Me.Cust_Prog.Name = "Cust_Prog"
        Me.Cust_Prog.Size = New System.Drawing.Size(111, 17)
        Me.Cust_Prog.TabIndex = 11
        Me.Cust_Prog.TabStop = True
        Me.Cust_Prog.Text = "Customer Program"
        Me.Cust_Prog.UseVisualStyleBackColor = True
        '
        'Loyal_Prog
        '
        Me.Loyal_Prog.AutoSize = True
        Me.Loyal_Prog.Location = New System.Drawing.Point(48, 19)
        Me.Loyal_Prog.Name = "Loyal_Prog"
        Me.Loyal_Prog.Size = New System.Drawing.Size(100, 17)
        Me.Loyal_Prog.TabIndex = 10
        Me.Loyal_Prog.TabStop = True
        Me.Loyal_Prog.Text = "Loyalty Program"
        Me.Loyal_Prog.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(227, 46)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Telephone"
        '
        'Tel_Text
        '
        Tel_Text.Location = New System.Drawing.Point(291, 43)
        Tel_Text.Name = "Tel_Text"
        Tel_Text.Size = New System.Drawing.Size(100, 20)
        Tel_Text.TabIndex = 8
        '
        'Enter_Button
        '
        Me.Enter_Button.BackColor = System.Drawing.SystemColors.Control
        Me.Enter_Button.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Enter_Button.Location = New System.Drawing.Point(434, 143)
        Me.Enter_Button.Name = "Enter_Button"
        Me.Enter_Button.Size = New System.Drawing.Size(200, 60)
        Me.Enter_Button.TabIndex = 9
        Me.Enter_Button.Text = "Enter"
        Me.Enter_Button.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(227, 101)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Nationality"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"American", "Armenian", "African", "British", "Chinese", "Hungarian", "Indian", "Japanese", "Korean", "Lebanese", "Russian"})
        Me.ComboBox1.Location = New System.Drawing.Point(290, 98)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(101, 21)
        Me.ComboBox1.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(38, 151)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Region"
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"Antelias", "Jal El Dib", "Naccash", "Zalka", "Dbayeh", "Achrafieh", "Verdun", "Hamra", "Beirut", "Tripoly"})
        Me.ComboBox2.Location = New System.Drawing.Point(85, 148)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(100, 21)
        Me.ComboBox2.TabIndex = 13
        '
        'Date_Text
        '
        Me.Date_Text.Location = New System.Drawing.Point(291, 148)
        Me.Date_Text.Name = "Date_Text"
        Me.Date_Text.Size = New System.Drawing.Size(100, 20)
        Me.Date_Text.TabIndex = 15
        Me.Date_Text.Text = "DD/MM/YY"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(217, 151)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Date of Birth"
        '
        'MenuStrip
        '
        Me.MenuStrip.BackColor = System.Drawing.SystemColors.Info
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LookUpToolStripMenuItem, Me.SignOutToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(646, 24)
        Me.MenuStrip.TabIndex = 57
        Me.MenuStrip.Text = "Menu"
        '
        'LookUpToolStripMenuItem
        '
        Me.LookUpToolStripMenuItem.Name = "LookUpToolStripMenuItem"
        Me.LookUpToolStripMenuItem.Size = New System.Drawing.Size(63, 20)
        Me.LookUpToolStripMenuItem.Text = "Look Up"
        '
        'SignOutToolStripMenuItem
        '
        Me.SignOutToolStripMenuItem.Name = "SignOutToolStripMenuItem"
        Me.SignOutToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.SignOutToolStripMenuItem.Text = "Exit"
        '
        'Customer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(646, 215)
        Me.Controls.Add(Me.MenuStrip)
        Me.Controls.Add(Me.Date_Text)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Enter_Button)
        Me.Controls.Add(Tel_Text)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Age_Text)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Name_Text)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Customer"
        Me.Text = "Customer"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Name_Text As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Age_Text As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Enter_Button As System.Windows.Forms.Button
    Friend WithEvents Cust_Prog As System.Windows.Forms.RadioButton
    Friend WithEvents Loyal_Prog As System.Windows.Forms.RadioButton
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents Date_Text As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents LookUpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SignOutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
