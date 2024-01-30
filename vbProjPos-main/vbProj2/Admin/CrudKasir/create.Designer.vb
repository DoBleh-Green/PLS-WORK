<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreateBarang
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
        Button1 = New Button()
        btnEdit = New Button()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        tbEditPassword = New TextBox()
        tbEditName = New TextBox()
        tbEditUsername = New TextBox()
        Label1 = New Label()
        cbEditRole = New ComboBox()
        Label5 = New Label()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(234, 197)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 13
        Button1.Text = "Cancle"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' btnEdit
        ' 
        btnEdit.Location = New Point(115, 197)
        btnEdit.Name = "btnEdit"
        btnEdit.Size = New Size(75, 23)
        btnEdit.TabIndex = 12
        btnEdit.Text = "create"
        btnEdit.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(115, 145)
        Label4.Name = "Label4"
        Label4.Size = New Size(57, 15)
        Label4.TabIndex = 9
        Label4.Text = "Password"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(115, 104)
        Label3.Name = "Label3"
        Label3.Size = New Size(41, 15)
        Label3.TabIndex = 10
        Label3.Text = "NAme"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(115, 64)
        Label2.Name = "Label2"
        Label2.Size = New Size(60, 15)
        Label2.TabIndex = 11
        Label2.Text = "Username"
        ' 
        ' tbEditPassword
        ' 
        tbEditPassword.Location = New Point(209, 142)
        tbEditPassword.Name = "tbEditPassword"
        tbEditPassword.Size = New Size(100, 23)
        tbEditPassword.TabIndex = 6
        ' 
        ' tbEditName
        ' 
        tbEditName.Location = New Point(209, 101)
        tbEditName.Name = "tbEditName"
        tbEditName.Size = New Size(100, 23)
        tbEditName.TabIndex = 7
        ' 
        ' tbEditUsername
        ' 
        tbEditUsername.Location = New Point(209, 61)
        tbEditUsername.Name = "tbEditUsername"
        tbEditUsername.Size = New Size(100, 23)
        tbEditUsername.TabIndex = 8
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(159, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(98, 15)
        Label1.TabIndex = 5
        Label1.Text = "create Akun Kasir"
        ' 
        ' cbEditRole
        ' 
        cbEditRole.FormattingEnabled = True
        cbEditRole.Items.AddRange(New Object() {"kasir", "admin"})
        cbEditRole.Location = New Point(209, 171)
        cbEditRole.Name = "cbEditRole"
        cbEditRole.Size = New Size(121, 23)
        cbEditRole.TabIndex = 14
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(118, 174)
        Label5.Name = "Label5"
        Label5.Size = New Size(35, 15)
        Label5.TabIndex = 15
        Label5.Text = "ROLE"
        ' 
        ' CreateKasir
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(437, 450)
        Controls.Add(Label5)
        Controls.Add(cbEditRole)
        Controls.Add(Button1)
        Controls.Add(btnEdit)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(tbEditPassword)
        Controls.Add(tbEditName)
        Controls.Add(tbEditUsername)
        Controls.Add(Label1)
        Name = "CreateKasir"
        Text = "CreateKasir"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents tbEditPassword As TextBox
    Friend WithEvents tbEditName As TextBox
    Friend WithEvents tbEditUsername As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cbEditRole As ComboBox
    Friend WithEvents Label5 As Label
End Class
