<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class edit
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
        DataGridView1 = New DataGridView()
        Button1 = New Button()
        btnEdit = New Button()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        tbEditstok = New TextBox()
        tbEditharga = New TextBox()
        tbEditNamaBarang = New TextBox()
        Label1 = New Label()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(342, 35)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.RowTemplate.Height = 25
        DataGridView1.Size = New Size(436, 247)
        DataGridView1.TabIndex = 17
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(140, 258)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 16
        Button1.Text = "Cancle"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' btnEdit
        ' 
        btnEdit.Location = New Point(21, 258)
        btnEdit.Name = "btnEdit"
        btnEdit.Size = New Size(75, 23)
        btnEdit.TabIndex = 15
        btnEdit.Text = "Edit"
        btnEdit.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(21, 159)
        Label4.Name = "Label4"
        Label4.Size = New Size(29, 15)
        Label4.TabIndex = 12
        Label4.Text = "stok"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(21, 118)
        Label3.Name = "Label3"
        Label3.Size = New Size(37, 15)
        Label3.TabIndex = 13
        Label3.Text = "harga"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(21, 78)
        Label2.Name = "Label2"
        Label2.Size = New Size(77, 15)
        Label2.TabIndex = 14
        Label2.Text = "nama barang"
        ' 
        ' tbEditstok
        ' 
        tbEditstok.Location = New Point(115, 156)
        tbEditstok.Name = "tbEditstok"
        tbEditstok.Size = New Size(100, 23)
        tbEditstok.TabIndex = 8
        ' 
        ' tbEditharga
        ' 
        tbEditharga.Location = New Point(115, 115)
        tbEditharga.Name = "tbEditharga"
        tbEditharga.Size = New Size(100, 23)
        tbEditharga.TabIndex = 9
        ' 
        ' tbEditNamaBarang
        ' 
        tbEditNamaBarang.Location = New Point(115, 75)
        tbEditNamaBarang.Name = "tbEditNamaBarang"
        tbEditNamaBarang.Size = New Size(100, 23)
        tbEditNamaBarang.TabIndex = 10
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(65, 23)
        Label1.Name = "Label1"
        Label1.Size = New Size(67, 15)
        Label1.TabIndex = 7
        Label1.Text = "edit barang"
        ' 
        ' edit
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(797, 312)
        Controls.Add(DataGridView1)
        Controls.Add(Button1)
        Controls.Add(btnEdit)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(tbEditstok)
        Controls.Add(tbEditharga)
        Controls.Add(tbEditNamaBarang)
        Controls.Add(Label1)
        Name = "edit"
        Text = "edit"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents tbEditstok As TextBox
    Friend WithEvents tbEditharga As TextBox
    Friend WithEvents tbEditNamaBarang As TextBox
    Friend WithEvents Label1 As Label
End Class
