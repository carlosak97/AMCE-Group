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
        Me.Nationality = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Region = New System.Windows.Forms.ComboBox()
        Me.Date_Text = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.LookUpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SignOutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Tel_text = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.MenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(115, 110)
        Me.Label1.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Name"
        '
        'Name_Text
        '
        Me.Name_Text.Location = New System.Drawing.Point(224, 103)
        Me.Name_Text.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.Name_Text.Name = "Name_Text"
        Me.Name_Text.Size = New System.Drawing.Size(260, 38)
        Me.Name_Text.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(141, 241)
        Me.Label2.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 32)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Age"
        '
        'Age_Text
        '
        Me.Age_Text.Location = New System.Drawing.Point(227, 234)
        Me.Age_Text.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.Age_Text.Name = "Age_Text"
        Me.Age_Text.Size = New System.Drawing.Size(260, 38)
        Me.Age_Text.TabIndex = 3
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Cust_Prog)
        Me.GroupBox1.Controls.Add(Me.Loyal_Prog)
        Me.GroupBox1.Location = New System.Drawing.Point(1157, 86)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.GroupBox1.Size = New System.Drawing.Size(533, 229)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Program"
        '
        'Cust_Prog
        '
        Me.Cust_Prog.AutoSize = True
        Me.Cust_Prog.Location = New System.Drawing.Point(128, 165)
        Me.Cust_Prog.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.Cust_Prog.Name = "Cust_Prog"
        Me.Cust_Prog.Size = New System.Drawing.Size(289, 36)
        Me.Cust_Prog.TabIndex = 11
        Me.Cust_Prog.TabStop = True
        Me.Cust_Prog.Text = "Customer Program"
        Me.Cust_Prog.UseVisualStyleBackColor = True
        '
        'Loyal_Prog
        '
        Me.Loyal_Prog.AutoSize = True
        Me.Loyal_Prog.Location = New System.Drawing.Point(128, 45)
        Me.Loyal_Prog.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.Loyal_Prog.Name = "Loyal_Prog"
        Me.Loyal_Prog.Size = New System.Drawing.Size(258, 36)
        Me.Loyal_Prog.TabIndex = 10
        Me.Loyal_Prog.TabStop = True
        Me.Loyal_Prog.Text = "Loyalty Program"
        Me.Loyal_Prog.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(605, 110)
        Me.Label3.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(151, 32)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Telephone"
        '
        'Enter_Button
        '
        Me.Enter_Button.BackColor = System.Drawing.SystemColors.Control
        Me.Enter_Button.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Enter_Button.Location = New System.Drawing.Point(1157, 341)
        Me.Enter_Button.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.Enter_Button.Name = "Enter_Button"
        Me.Enter_Button.Size = New System.Drawing.Size(533, 143)
        Me.Enter_Button.TabIndex = 9
        Me.Enter_Button.Text = "Enter"
        Me.Enter_Button.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(605, 241)
        Me.Label4.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(150, 32)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Nationality"
        '
        'Nationality
        '
        Me.Nationality.FormattingEnabled = True
        Me.Nationality.Items.AddRange(New Object() {"American", "Armenian", "African", "British", "Chinese", "Hungarian", "Indian", "Japanese", "Korean", "Lebanese", "Russian"})
        Me.Nationality.Location = New System.Drawing.Point(773, 234)
        Me.Nationality.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.Nationality.Name = "Nationality"
        Me.Nationality.Size = New System.Drawing.Size(263, 39)
        Me.Nationality.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(101, 360)
        Me.Label5.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(106, 32)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Region"
        '
        'Region
        '
        Me.Region.FormattingEnabled = True
        Me.Region.Items.AddRange(New Object() {"Antelias", "Jal El Dib", "Naccash", "Zalka", "Dbayeh", "Achrafieh", "Verdun", "Hamra", "Beirut", "Tripoly"})
        Me.Region.Location = New System.Drawing.Point(227, 353)
        Me.Region.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.Region.Name = "Region"
        Me.Region.Size = New System.Drawing.Size(260, 39)
        Me.Region.TabIndex = 13
        '
        'Date_Text
        '
        Me.Date_Text.Location = New System.Drawing.Point(776, 353)
        Me.Date_Text.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.Date_Text.Name = "Date_Text"
        Me.Date_Text.Size = New System.Drawing.Size(260, 38)
        Me.Date_Text.TabIndex = 15
        Me.Date_Text.Text = "DD/MM/YY"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(579, 360)
        Me.Label6.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(172, 32)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Date of Birth"
        '
        'MenuStrip
        '
        Me.MenuStrip.BackColor = System.Drawing.SystemColors.Info
        Me.MenuStrip.ImageScalingSize = New System.Drawing.Size(40, 40)
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LookUpToolStripMenuItem, Me.SignOutToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Padding = New System.Windows.Forms.Padding(16, 5, 0, 5)
        Me.MenuStrip.Size = New System.Drawing.Size(1723, 55)
        Me.MenuStrip.TabIndex = 57
        Me.MenuStrip.Text = "Menu"
        '
        'LookUpToolStripMenuItem
        '
        Me.LookUpToolStripMenuItem.Name = "LookUpToolStripMenuItem"
        Me.LookUpToolStripMenuItem.Size = New System.Drawing.Size(142, 45)
        Me.LookUpToolStripMenuItem.Text = "Look Up"
        '
        'SignOutToolStripMenuItem
        '
        Me.SignOutToolStripMenuItem.Name = "SignOutToolStripMenuItem"
        Me.SignOutToolStripMenuItem.Size = New System.Drawing.Size(76, 45)
        Me.SignOutToolStripMenuItem.Text = "Exit"
        '
        'Tel_text
        '
        Me.Tel_text.Location = New System.Drawing.Point(773, 102)
        Me.Tel_text.Name = "Tel_text"
        Me.Tel_text.Size = New System.Drawing.Size(263, 38)
        Me.Tel_text.TabIndex = 58
        '
        'Customer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(1723, 513)
        Me.Controls.Add(Me.Tel_text)
        Me.Controls.Add(Me.MenuStrip)
        Me.Controls.Add(Me.Date_Text)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Region)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Nationality)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Enter_Button)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Age_Text)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Name_Text)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
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
    Friend WithEvents Nationality As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Region As System.Windows.Forms.ComboBox
    Friend WithEvents Date_Text As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents LookUpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SignOutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Tel_text As TextBox
End Class
