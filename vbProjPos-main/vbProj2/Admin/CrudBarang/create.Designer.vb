<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class create
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
        hargaC = New TextBox()
        stokC = New TextBox()
        usernameC = New TextBox()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(412, 334)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 24
        Button1.Text = "Cancle"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' btnEdit
        ' 
        btnEdit.Location = New Point(293, 334)
        btnEdit.Name = "btnEdit"
        btnEdit.Size = New Size(75, 23)
        btnEdit.TabIndex = 23
        btnEdit.Text = "create"
        btnEdit.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(293, 256)
        Label4.Name = "Label4"
        Label4.Size = New Size(77, 15)
        Label4.TabIndex = 20
        Label4.Text = "harga barang"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(293, 215)
        Label3.Name = "Label3"
        Label3.Size = New Size(29, 15)
        Label3.TabIndex = 21
        Label3.Text = "stok"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(293, 175)
        Label2.Name = "Label2"
        Label2.Size = New Size(77, 15)
        Label2.TabIndex = 22
        Label2.Text = "nama barang"
        ' 
        ' hargaC
        ' 
        hargaC.Location = New Point(387, 253)
        hargaC.Name = "hargaC"
        hargaC.Size = New Size(100, 23)
        hargaC.TabIndex = 17
        ' 
        ' stokC
        ' 
        stokC.Location = New Point(387, 212)
        stokC.Name = "stokC"
        stokC.Size = New Size(100, 23)
        stokC.TabIndex = 18
        ' 
        ' usernameC
        ' 
        usernameC.Location = New Point(387, 172)
        usernameC.Name = "usernameC"
        usernameC.Size = New Size(100, 23)
        usernameC.TabIndex = 19
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(337, 120)
        Label1.Name = "Label1"
        Label1.Size = New Size(98, 15)
        Label1.TabIndex = 16
        Label1.Text = "create Akun Kasir"
        ' 
        ' create
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Button1)
        Controls.Add(btnEdit)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(hargaC)
        Controls.Add(stokC)
        Controls.Add(usernameC)
        Controls.Add(Label1)
        Name = "create"
        Text = "create"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents hargaC As TextBox
    Friend WithEvents stokC As TextBox
    Friend WithEvents usernameC As TextBox
    Friend WithEvents Label1 As Label
End Class
