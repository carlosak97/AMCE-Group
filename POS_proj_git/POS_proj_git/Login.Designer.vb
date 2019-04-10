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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.UserText = New System.Windows.Forms.TextBox()
        Me.PassText = New System.Windows.Forms.TextBox()
        Me.LoginB = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(33, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "UserName"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(37, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Password"
        '
        'UserText
        '
        Me.UserText.Location = New System.Drawing.Point(96, 43)
        Me.UserText.Name = "UserText"
        Me.UserText.Size = New System.Drawing.Size(100, 20)
        Me.UserText.TabIndex = 2
        '
        'PassText
        '
        Me.PassText.Location = New System.Drawing.Point(96, 78)
        Me.PassText.Name = "PassText"
        Me.PassText.Size = New System.Drawing.Size(100, 20)
        Me.PassText.TabIndex = 3
        '
        'LoginB
        '
        Me.LoginB.Location = New System.Drawing.Point(96, 125)
        Me.LoginB.Name = "LoginB"
        Me.LoginB.Size = New System.Drawing.Size(100, 40)
        Me.LoginB.TabIndex = 4
        Me.LoginB.Text = "Login"
        Me.LoginB.UseVisualStyleBackColor = True
        '
        'POS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ClientSize = New System.Drawing.Size(276, 197)
        Me.Controls.Add(Me.LoginB)
        Me.Controls.Add(Me.PassText)
        Me.Controls.Add(Me.UserText)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "POS"
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents UserText As System.Windows.Forms.TextBox
    Friend WithEvents PassText As System.Windows.Forms.TextBox
    Friend WithEvents LoginB As System.Windows.Forms.Button
End Class
