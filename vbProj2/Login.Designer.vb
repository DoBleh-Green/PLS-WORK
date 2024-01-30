<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        lUsername = New Label()
        lPassword = New Label()
        tbUsername = New TextBox()
        tbPassword = New TextBox()
        btnLogin = New Button()
        SuspendLayout()
        ' 
        ' lUsername
        ' 
        lUsername.AutoSize = True
        lUsername.Location = New Point(38, 59)
        lUsername.Name = "lUsername"
        lUsername.Size = New Size(60, 15)
        lUsername.TabIndex = 0
        lUsername.Text = "Username"
        ' 
        ' lPassword
        ' 
        lPassword.AutoSize = True
        lPassword.Location = New Point(38, 106)
        lPassword.Name = "lPassword"
        lPassword.Size = New Size(57, 15)
        lPassword.TabIndex = 0
        lPassword.Text = "Password"
        ' 
        ' tbUsername
        ' 
        tbUsername.Location = New Point(135, 56)
        tbUsername.Name = "tbUsername"
        tbUsername.Size = New Size(100, 23)
        tbUsername.TabIndex = 1
        ' 
        ' tbPassword
        ' 
        tbPassword.Location = New Point(135, 103)
        tbPassword.Name = "tbPassword"
        tbPassword.Size = New Size(100, 23)
        tbPassword.TabIndex = 1
        ' 
        ' btnLogin
        ' 
        btnLogin.Location = New Point(98, 160)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(75, 23)
        btnLogin.TabIndex = 2
        btnLogin.Text = "Login"
        btnLogin.UseVisualStyleBackColor = True
        ' 
        ' Login
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(280, 195)
        Controls.Add(btnLogin)
        Controls.Add(tbPassword)
        Controls.Add(tbUsername)
        Controls.Add(lPassword)
        Controls.Add(lUsername)
        Name = "Login"
        Text = "Login"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lUsername As Label
    Friend WithEvents lPassword As Label
    Friend WithEvents tbUsername As TextBox
    Friend WithEvents tbPassword As TextBox
    Friend WithEvents btnLogin As Button
End Class
