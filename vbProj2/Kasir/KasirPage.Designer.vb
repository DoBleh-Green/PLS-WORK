<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class KasirPage
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
        id_barang = New DataGridViewTextBoxColumn()
        nama_barang = New DataGridViewTextBoxColumn()
        jumlah_barang = New DataGridViewTextBoxColumn()
        total_harga = New DataGridViewTextBoxColumn()
        Label1 = New Label()
        ComboBox1 = New ComboBox()
        TBidbarang = New TextBox()
        Label2 = New Label()
        TBstok = New TextBox()
        Label3 = New Label()
        TBharga = New TextBox()
        Label4 = New Label()
        jumlah = New NumericUpDown()
        Label5 = New Label()
        Label6 = New Label()
        TBtotalharga = New TextBox()
        Label7 = New Label()
        TBsubtotal = New TextBox()
        submit = New Button()
        Label8 = New Label()
        TBtunai = New TextBox()
        total = New Label()
        TBtotal = New TextBox()
        Label9 = New Label()
        TBkembalian = New TextBox()
        ComboBox2 = New ComboBox()
        Label10 = New Label()
        Label11 = New Label()
        ComboBox3 = New ComboBox()
        TBnama = New TextBox()
        nama = New Label()
        DataGridView2 = New DataGridView()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        CType(jumlah, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridView2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {id_barang, nama_barang, jumlah_barang, total_harga})
        DataGridView1.Location = New Point(21, 27)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.RowTemplate.Height = 25
        DataGridView1.Size = New Size(444, 171)
        DataGridView1.TabIndex = 0
        ' 
        ' id_barang
        ' 
        id_barang.HeaderText = "id_barang"
        id_barang.Name = "id_barang"
        id_barang.ReadOnly = True
        ' 
        ' nama_barang
        ' 
        nama_barang.HeaderText = "nama_barang"
        nama_barang.Name = "nama_barang"
        nama_barang.ReadOnly = True
        ' 
        ' jumlah_barang
        ' 
        jumlah_barang.HeaderText = "jumlah_barang"
        jumlah_barang.Name = "jumlah_barang"
        jumlah_barang.ReadOnly = True
        ' 
        ' total_harga
        ' 
        total_harga.HeaderText = "total_harga"
        total_harga.Name = "total_harga"
        total_harga.ReadOnly = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(498, 67)
        Label1.Name = "Label1"
        Label1.Size = New Size(57, 15)
        Label1.TabIndex = 1
        Label1.Text = "id barang"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(581, 24)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(121, 23)
        ComboBox1.TabIndex = 2
        ' 
        ' TBidbarang
        ' 
        TBidbarang.Location = New Point(581, 67)
        TBidbarang.Name = "TBidbarang"
        TBidbarang.ReadOnly = True
        TBidbarang.Size = New Size(100, 23)
        TBidbarang.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(498, 24)
        Label2.Name = "Label2"
        Label2.Size = New Size(77, 15)
        Label2.TabIndex = 4
        Label2.Text = "nama barang"
        ' 
        ' TBstok
        ' 
        TBstok.Location = New Point(792, 24)
        TBstok.Name = "TBstok"
        TBstok.ReadOnly = True
        TBstok.Size = New Size(100, 23)
        TBstok.TabIndex = 6
        TBstok.Text = "0"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(734, 27)
        Label3.Name = "Label3"
        Label3.Size = New Size(29, 15)
        Label3.TabIndex = 5
        Label3.Text = "stok"
        ' 
        ' TBharga
        ' 
        TBharga.Location = New Point(792, 64)
        TBharga.Name = "TBharga"
        TBharga.ReadOnly = True
        TBharga.Size = New Size(100, 23)
        TBharga.TabIndex = 8
        TBharga.Text = "0"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(734, 67)
        Label4.Name = "Label4"
        Label4.Size = New Size(37, 15)
        Label4.TabIndex = 7
        Label4.Text = "harga"
        ' 
        ' jumlah
        ' 
        jumlah.Location = New Point(581, 115)
        jumlah.Name = "jumlah"
        jumlah.Size = New Size(53, 23)
        jumlah.TabIndex = 9
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(491, 117)
        Label5.Name = "Label5"
        Label5.Size = New Size(84, 15)
        Label5.TabIndex = 10
        Label5.Text = "jumlah barang"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(705, 114)
        Label6.Name = "Label6"
        Label6.Size = New Size(66, 15)
        Label6.TabIndex = 11
        Label6.Text = "total_harga"
        ' 
        ' TBtotalharga
        ' 
        TBtotalharga.Location = New Point(792, 114)
        TBtotalharga.Name = "TBtotalharga"
        TBtotalharga.ReadOnly = True
        TBtotalharga.Size = New Size(100, 23)
        TBtotalharga.TabIndex = 12
        TBtotalharga.Text = "0"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(491, 163)
        Label7.Name = "Label7"
        Label7.Size = New Size(50, 15)
        Label7.TabIndex = 13
        Label7.Text = "subtotal"
        ' 
        ' TBsubtotal
        ' 
        TBsubtotal.Location = New Point(581, 160)
        TBsubtotal.Name = "TBsubtotal"
        TBsubtotal.ReadOnly = True
        TBsubtotal.Size = New Size(100, 23)
        TBsubtotal.TabIndex = 14
        TBsubtotal.Text = "0"
        ' 
        ' submit
        ' 
        submit.Location = New Point(718, 163)
        submit.Name = "submit"
        submit.Size = New Size(75, 23)
        submit.TabIndex = 15
        submit.Text = "hitung"
        submit.UseVisualStyleBackColor = True
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(498, 208)
        Label8.Name = "Label8"
        Label8.Size = New Size(34, 15)
        Label8.TabIndex = 16
        Label8.Text = "tunai"
        ' 
        ' TBtunai
        ' 
        TBtunai.Location = New Point(581, 208)
        TBtunai.Name = "TBtunai"
        TBtunai.Size = New Size(100, 23)
        TBtunai.TabIndex = 17
        ' 
        ' total
        ' 
        total.AutoSize = True
        total.Location = New Point(718, 216)
        total.Name = "total"
        total.Size = New Size(31, 15)
        total.TabIndex = 18
        total.Text = "total"
        ' 
        ' TBtotal
        ' 
        TBtotal.Location = New Point(792, 213)
        TBtotal.Name = "TBtotal"
        TBtotal.ReadOnly = True
        TBtotal.Size = New Size(100, 23)
        TBtotal.TabIndex = 19
        TBtotal.Text = "0"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(498, 259)
        Label9.Name = "Label9"
        Label9.Size = New Size(62, 15)
        Label9.TabIndex = 20
        Label9.Text = "kembalian"
        ' 
        ' TBkembalian
        ' 
        TBkembalian.Location = New Point(581, 256)
        TBkembalian.Name = "TBkembalian"
        TBkembalian.ReadOnly = True
        TBkembalian.Size = New Size(100, 23)
        TBkembalian.TabIndex = 21
        TBkembalian.Text = "0"
        ' 
        ' ComboBox2
        ' 
        ComboBox2.FormattingEnabled = True
        ComboBox2.Items.AddRange(New Object() {"5", "10", "15", "20", "25", "30", "35", "40", "45", "50", "100"})
        ComboBox2.Location = New Point(581, 300)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(121, 23)
        ComboBox2.TabIndex = 22
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(499, 308)
        Label10.Name = "Label10"
        Label10.Size = New Size(42, 15)
        Label10.TabIndex = 23
        Label10.Text = "diskon"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(21, 273)
        Label11.Name = "Label11"
        Label11.Size = New Size(62, 15)
        Label11.TabIndex = 25
        Label11.Text = "nama user"
        ' 
        ' ComboBox3
        ' 
        ComboBox3.FormattingEnabled = True
        ComboBox3.Location = New Point(115, 270)
        ComboBox3.Name = "ComboBox3"
        ComboBox3.Size = New Size(121, 23)
        ComboBox3.TabIndex = 24
        ' 
        ' TBnama
        ' 
        TBnama.Location = New Point(115, 319)
        TBnama.Name = "TBnama"
        TBnama.ReadOnly = True
        TBnama.Size = New Size(100, 23)
        TBnama.TabIndex = 27
        TBnama.Text = "0"
        ' 
        ' nama
        ' 
        nama.AutoSize = True
        nama.Location = New Point(41, 322)
        nama.Name = "nama"
        nama.Size = New Size(45, 15)
        nama.TabIndex = 26
        nama.Text = "ID_user"
        ' 
        ' DataGridView2
        ' 
        DataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView2.Location = New Point(21, 366)
        DataGridView2.Name = "DataGridView2"
        DataGridView2.RowTemplate.Height = 25
        DataGridView2.Size = New Size(871, 150)
        DataGridView2.TabIndex = 28
        ' 
        ' KasirPage
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1055, 544)
        Controls.Add(DataGridView2)
        Controls.Add(TBnama)
        Controls.Add(nama)
        Controls.Add(Label11)
        Controls.Add(ComboBox3)
        Controls.Add(Label10)
        Controls.Add(ComboBox2)
        Controls.Add(TBkembalian)
        Controls.Add(Label9)
        Controls.Add(TBtotal)
        Controls.Add(total)
        Controls.Add(TBtunai)
        Controls.Add(Label8)
        Controls.Add(submit)
        Controls.Add(TBsubtotal)
        Controls.Add(Label7)
        Controls.Add(TBtotalharga)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(jumlah)
        Controls.Add(TBharga)
        Controls.Add(Label4)
        Controls.Add(TBstok)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(TBidbarang)
        Controls.Add(ComboBox1)
        Controls.Add(Label1)
        Controls.Add(DataGridView1)
        Name = "KasirPage"
        Text = "o"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        CType(jumlah, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridView2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents id_barang As DataGridViewTextBoxColumn
    Friend WithEvents nama_barang As DataGridViewTextBoxColumn
    Friend WithEvents jumlah_barang As DataGridViewTextBoxColumn
    Friend WithEvents total_harga As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents TBidbarang As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TBstok As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TBharga As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents jumlah As NumericUpDown
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TBtotalharga As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TBsubtotal As TextBox
    Friend WithEvents submit As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents TBtunai As TextBox
    Friend WithEvents total As Label
    Friend WithEvents TBtotal As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TBkembalian As TextBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents nama As Label
    Friend WithEvents TBnama As TextBox
    Friend WithEvents DataGridView2 As DataGridView
End Class
