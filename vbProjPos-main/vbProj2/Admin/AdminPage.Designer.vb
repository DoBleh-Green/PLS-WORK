<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminPage
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
        btnKasir = New Button()
        btnBarang = New Button()
        btnHistory = New Button()
        btnLogout = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(89, 15)
        Label1.TabIndex = 0
        Label1.Text = "Selamat datang"
        ' 
        ' btnKasir
        ' 
        btnKasir.Location = New Point(87, 95)
        btnKasir.Name = "btnKasir"
        btnKasir.Size = New Size(75, 61)
        btnKasir.TabIndex = 1
        btnKasir.Text = "Crud Kasir"
        btnKasir.UseVisualStyleBackColor = True
        ' 
        ' btnBarang
        ' 
        btnBarang.Location = New Point(199, 95)
        btnBarang.Name = "btnBarang"
        btnBarang.Size = New Size(99, 61)
        btnBarang.TabIndex = 1
        btnBarang.Text = "Crud Barang"
        btnBarang.UseVisualStyleBackColor = True
        ' 
        ' btnHistory
        ' 
        btnHistory.Location = New Point(339, 95)
        btnHistory.Name = "btnHistory"
        btnHistory.Size = New Size(75, 61)
        btnHistory.TabIndex = 1
        btnHistory.Text = "History"
        btnHistory.UseVisualStyleBackColor = True
        ' 
        ' btnLogout
        ' 
        btnLogout.Location = New Point(12, 260)
        btnLogout.Name = "btnLogout"
        btnLogout.Size = New Size(75, 23)
        btnLogout.TabIndex = 2
        btnLogout.Text = "Logout"
        btnLogout.UseVisualStyleBackColor = True
        ' 
        ' AdminPage
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(502, 295)
        Controls.Add(btnLogout)
        Controls.Add(btnHistory)
        Controls.Add(btnBarang)
        Controls.Add(btnKasir)
        Controls.Add(Label1)
        Name = "AdminPage"
        Text = "AdminPage"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents btnKasir As Button
    Friend WithEvents btnBarang As Button
    Friend WithEvents btnHistory As Button
    Friend WithEvents btnLogout As Button
End Class
