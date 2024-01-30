<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditKasir
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
        Label1 = New Label()
        tbEditUsername = New TextBox()
        Label2 = New Label()
        tbEditName = New TextBox()
        Label3 = New Label()
        tbEditPassword = New TextBox()
        Label4 = New Label()
        btnEdit = New Button()
        Button1 = New Button()
        DataGridView1 = New DataGridView()
        Label5 = New Label()
        cbEditRole = New ComboBox()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(97, 12)
        Label1.Name = "Label1"
        Label1.Size = New Size(89, 15)
        Label1.TabIndex = 0
        Label1.Text = "Edit AKun KAsir"
        ' 
        ' tbEditUsername
        ' 
        tbEditUsername.Location = New Point(147, 64)
        tbEditUsername.Name = "tbEditUsername"
        tbEditUsername.Size = New Size(100, 23)
        tbEditUsername.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(53, 67)
        Label2.Name = "Label2"
        Label2.Size = New Size(60, 15)
        Label2.TabIndex = 2
        Label2.Text = "Username"
        ' 
        ' tbEditName
        ' 
        tbEditName.Location = New Point(147, 104)
        tbEditName.Name = "tbEditName"
        tbEditName.Size = New Size(100, 23)
        tbEditName.TabIndex = 1
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(53, 107)
        Label3.Name = "Label3"
        Label3.Size = New Size(41, 15)
        Label3.TabIndex = 2
        Label3.Text = "NAme"
        ' 
        ' tbEditPassword
        ' 
        tbEditPassword.Location = New Point(147, 145)
        tbEditPassword.Name = "tbEditPassword"
        tbEditPassword.Size = New Size(100, 23)
        tbEditPassword.TabIndex = 1
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(53, 148)
        Label4.Name = "Label4"
        Label4.Size = New Size(57, 15)
        Label4.TabIndex = 2
        Label4.Text = "Password"
        ' 
        ' btnEdit
        ' 
        btnEdit.Location = New Point(53, 247)
        btnEdit.Name = "btnEdit"
        btnEdit.Size = New Size(75, 23)
        btnEdit.TabIndex = 3
        btnEdit.Text = "Edit"
        btnEdit.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(172, 247)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 4
        Button1.Text = "Cancle"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(374, 24)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.RowTemplate.Height = 25
        DataGridView1.Size = New Size(436, 247)
        DataGridView1.TabIndex = 5
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(53, 189)
        Label5.Name = "Label5"
        Label5.Size = New Size(30, 15)
        Label5.TabIndex = 2
        Label5.Text = "Role"
        ' 
        ' cbEditRole
        ' 
        cbEditRole.FormattingEnabled = True
        cbEditRole.Items.AddRange(New Object() {"kasir", "admin"})
        cbEditRole.Location = New Point(147, 186)
        cbEditRole.Name = "cbEditRole"
        cbEditRole.Size = New Size(121, 23)
        cbEditRole.TabIndex = 6
        ' 
        ' EditKasir
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(853, 327)
        Controls.Add(cbEditRole)
        Controls.Add(DataGridView1)
        Controls.Add(Button1)
        Controls.Add(btnEdit)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(tbEditPassword)
        Controls.Add(tbEditName)
        Controls.Add(tbEditUsername)
        Controls.Add(Label1)
        Name = "EditKasir"
        Text = "\"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents tbEditUsername As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents tbEditName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents tbEditPassword As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnEdit As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label5 As Label
    Friend WithEvents cbEditRole As ComboBox
End Class
