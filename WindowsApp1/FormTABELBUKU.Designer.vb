<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormTABELBUKU
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
        Me.components = New System.ComponentModel.Container()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_idbuku = New System.Windows.Forms.TextBox()
        Me.TblBukuBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DB_UASDataSet = New WindowsApp1.DB_UASDataSet()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.txt_pengarang = New System.Windows.Forms.TextBox()
        Me.txt_penerbit = New System.Windows.Forms.TextBox()
        Me.txt_tahunterbit = New System.Windows.Forms.TextBox()
        Me.txt_hargabuku = New System.Windows.Forms.TextBox()
        Me.txt_jumlahbuku = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IdbukuDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JudulbukuDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PengarangDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PenerbitDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TahunTerbitDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HargabukuDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JumlahBukuDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tbl_BukuTableAdapter = New WindowsApp1.DB_UASDataSetTableAdapters.Tbl_BukuTableAdapter()
        Me.btn_exit = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.TblBukuBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DB_UASDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(37, 135)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(76, 17)
        Me.Label8.TabIndex = 81
        Me.Label8.Text = "PENERBIT"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(37, 96)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(96, 17)
        Me.Label7.TabIndex = 80
        Me.Label7.Text = "PENGARANG"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(37, 56)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(99, 17)
        Me.Label6.TabIndex = 79
        Me.Label6.Text = "JUDUL_BUKU"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(37, 18)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 17)
        Me.Label5.TabIndex = 78
        Me.Label5.Text = "ID_BUKU"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(37, 252)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 17)
        Me.Label1.TabIndex = 84
        Me.Label1.Text = "JUMLAH_BUKU"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(37, 216)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 17)
        Me.Label2.TabIndex = 83
        Me.Label2.Text = "HARGA_BUKU"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(37, 176)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(113, 17)
        Me.Label3.TabIndex = 82
        Me.Label3.Text = "TAHUN_TERBIT"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txt_idbuku
        '
        Me.txt_idbuku.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblBukuBindingSource, "Id_buku", True))
        Me.txt_idbuku.Location = New System.Drawing.Point(246, 18)
        Me.txt_idbuku.Name = "txt_idbuku"
        Me.txt_idbuku.Size = New System.Drawing.Size(100, 22)
        Me.txt_idbuku.TabIndex = 85
        '
        'TblBukuBindingSource
        '
        Me.TblBukuBindingSource.DataMember = "Tbl_Buku"
        Me.TblBukuBindingSource.DataSource = Me.DB_UASDataSet
        '
        'DB_UASDataSet
        '
        Me.DB_UASDataSet.DataSetName = "DB_UASDataSet"
        Me.DB_UASDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TextBox2
        '
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblBukuBindingSource, "Judul_buku", True))
        Me.TextBox2.Location = New System.Drawing.Point(246, 56)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 22)
        Me.TextBox2.TabIndex = 86
        '
        'txt_pengarang
        '
        Me.txt_pengarang.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblBukuBindingSource, "Pengarang", True))
        Me.txt_pengarang.Location = New System.Drawing.Point(246, 96)
        Me.txt_pengarang.Name = "txt_pengarang"
        Me.txt_pengarang.Size = New System.Drawing.Size(100, 22)
        Me.txt_pengarang.TabIndex = 87
        '
        'txt_penerbit
        '
        Me.txt_penerbit.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblBukuBindingSource, "Penerbit", True))
        Me.txt_penerbit.Location = New System.Drawing.Point(246, 135)
        Me.txt_penerbit.Name = "txt_penerbit"
        Me.txt_penerbit.Size = New System.Drawing.Size(100, 22)
        Me.txt_penerbit.TabIndex = 88
        '
        'txt_tahunterbit
        '
        Me.txt_tahunterbit.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblBukuBindingSource, "Tahun_Terbit", True))
        Me.txt_tahunterbit.Location = New System.Drawing.Point(246, 173)
        Me.txt_tahunterbit.Name = "txt_tahunterbit"
        Me.txt_tahunterbit.Size = New System.Drawing.Size(100, 22)
        Me.txt_tahunterbit.TabIndex = 89
        '
        'txt_hargabuku
        '
        Me.txt_hargabuku.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblBukuBindingSource, "Harga_buku", True))
        Me.txt_hargabuku.Location = New System.Drawing.Point(246, 213)
        Me.txt_hargabuku.Name = "txt_hargabuku"
        Me.txt_hargabuku.Size = New System.Drawing.Size(100, 22)
        Me.txt_hargabuku.TabIndex = 90
        '
        'txt_jumlahbuku
        '
        Me.txt_jumlahbuku.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblBukuBindingSource, "Jumlah_Buku", True))
        Me.txt_jumlahbuku.Location = New System.Drawing.Point(246, 252)
        Me.txt_jumlahbuku.Name = "txt_jumlahbuku"
        Me.txt_jumlahbuku.Size = New System.Drawing.Size(100, 22)
        Me.txt_jumlahbuku.TabIndex = 91
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdbukuDataGridViewTextBoxColumn, Me.JudulbukuDataGridViewTextBoxColumn, Me.PengarangDataGridViewTextBoxColumn, Me.PenerbitDataGridViewTextBoxColumn, Me.TahunTerbitDataGridViewTextBoxColumn, Me.HargabukuDataGridViewTextBoxColumn, Me.JumlahBukuDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.TblBukuBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(220, 324)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(1128, 163)
        Me.DataGridView1.TabIndex = 92
        '
        'IdbukuDataGridViewTextBoxColumn
        '
        Me.IdbukuDataGridViewTextBoxColumn.DataPropertyName = "Id_buku"
        Me.IdbukuDataGridViewTextBoxColumn.HeaderText = "Id_buku"
        Me.IdbukuDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.IdbukuDataGridViewTextBoxColumn.Name = "IdbukuDataGridViewTextBoxColumn"
        Me.IdbukuDataGridViewTextBoxColumn.Width = 125
        '
        'JudulbukuDataGridViewTextBoxColumn
        '
        Me.JudulbukuDataGridViewTextBoxColumn.DataPropertyName = "Judul_buku"
        Me.JudulbukuDataGridViewTextBoxColumn.HeaderText = "Judul_buku"
        Me.JudulbukuDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.JudulbukuDataGridViewTextBoxColumn.Name = "JudulbukuDataGridViewTextBoxColumn"
        Me.JudulbukuDataGridViewTextBoxColumn.Width = 125
        '
        'PengarangDataGridViewTextBoxColumn
        '
        Me.PengarangDataGridViewTextBoxColumn.DataPropertyName = "Pengarang"
        Me.PengarangDataGridViewTextBoxColumn.HeaderText = "Pengarang"
        Me.PengarangDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.PengarangDataGridViewTextBoxColumn.Name = "PengarangDataGridViewTextBoxColumn"
        Me.PengarangDataGridViewTextBoxColumn.Width = 125
        '
        'PenerbitDataGridViewTextBoxColumn
        '
        Me.PenerbitDataGridViewTextBoxColumn.DataPropertyName = "Penerbit"
        Me.PenerbitDataGridViewTextBoxColumn.HeaderText = "Penerbit"
        Me.PenerbitDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.PenerbitDataGridViewTextBoxColumn.Name = "PenerbitDataGridViewTextBoxColumn"
        Me.PenerbitDataGridViewTextBoxColumn.Width = 125
        '
        'TahunTerbitDataGridViewTextBoxColumn
        '
        Me.TahunTerbitDataGridViewTextBoxColumn.DataPropertyName = "Tahun_Terbit"
        Me.TahunTerbitDataGridViewTextBoxColumn.HeaderText = "Tahun_Terbit"
        Me.TahunTerbitDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.TahunTerbitDataGridViewTextBoxColumn.Name = "TahunTerbitDataGridViewTextBoxColumn"
        Me.TahunTerbitDataGridViewTextBoxColumn.Width = 125
        '
        'HargabukuDataGridViewTextBoxColumn
        '
        Me.HargabukuDataGridViewTextBoxColumn.DataPropertyName = "Harga_buku"
        Me.HargabukuDataGridViewTextBoxColumn.HeaderText = "Harga_buku"
        Me.HargabukuDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.HargabukuDataGridViewTextBoxColumn.Name = "HargabukuDataGridViewTextBoxColumn"
        Me.HargabukuDataGridViewTextBoxColumn.Width = 125
        '
        'JumlahBukuDataGridViewTextBoxColumn
        '
        Me.JumlahBukuDataGridViewTextBoxColumn.DataPropertyName = "Jumlah_Buku"
        Me.JumlahBukuDataGridViewTextBoxColumn.HeaderText = "Jumlah_Buku"
        Me.JumlahBukuDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.JumlahBukuDataGridViewTextBoxColumn.Name = "JumlahBukuDataGridViewTextBoxColumn"
        Me.JumlahBukuDataGridViewTextBoxColumn.Width = 125
        '
        'Tbl_BukuTableAdapter
        '
        Me.Tbl_BukuTableAdapter.ClearBeforeFill = True
        '
        'btn_exit
        '
        Me.btn_exit.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_exit.Location = New System.Drawing.Point(1302, 210)
        Me.btn_exit.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_exit.Name = "btn_exit"
        Me.btn_exit.Size = New System.Drawing.Size(134, 47)
        Me.btn_exit.TabIndex = 108
        Me.btn_exit.Text = "EXIT"
        Me.btn_exit.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.Location = New System.Drawing.Point(1106, 213)
        Me.Button7.Margin = New System.Windows.Forms.Padding(4)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(157, 47)
        Me.Button7.TabIndex = 107
        Me.Button7.Text = "LAST"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(832, 211)
        Me.Button6.Margin = New System.Windows.Forms.Padding(4)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(209, 50)
        Me.Button6.TabIndex = 106
        Me.Button6.Text = "PREVIOUS"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(625, 210)
        Me.Button5.Margin = New System.Windows.Forms.Padding(4)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(152, 50)
        Me.Button5.TabIndex = 105
        Me.Button5.Text = "NEXT"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(442, 210)
        Me.Button4.Margin = New System.Windows.Forms.Padding(4)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(125, 46)
        Me.Button4.TabIndex = 104
        Me.Button4.Text = "FIRST"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(1016, 135)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(165, 39)
        Me.Button3.TabIndex = 103
        Me.Button3.Text = "DELETE"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.Location = New System.Drawing.Point(786, 135)
        Me.Button8.Margin = New System.Windows.Forms.Padding(4)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(139, 39)
        Me.Button8.TabIndex = 102
        Me.Button8.Text = "SAVE"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button10
        '
        Me.Button10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button10.Location = New System.Drawing.Point(562, 135)
        Me.Button10.Margin = New System.Windows.Forms.Padding(4)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(147, 39)
        Me.Button10.TabIndex = 101
        Me.Button10.Text = "NEW"
        Me.Button10.UseVisualStyleBackColor = True
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'FormTABELBUKU
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1537, 606)
        Me.Controls.Add(Me.btn_exit)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button10)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.txt_jumlahbuku)
        Me.Controls.Add(Me.txt_hargabuku)
        Me.Controls.Add(Me.txt_tahunterbit)
        Me.Controls.Add(Me.txt_penerbit)
        Me.Controls.Add(Me.txt_pengarang)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.txt_idbuku)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Name = "FormTABELBUKU"
        Me.Text = "FormTABELBUKU"
        CType(Me.TblBukuBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DB_UASDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_idbuku As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents txt_pengarang As TextBox
    Friend WithEvents txt_penerbit As TextBox
    Friend WithEvents txt_tahunterbit As TextBox
    Friend WithEvents txt_hargabuku As TextBox
    Friend WithEvents txt_jumlahbuku As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DB_UASDataSet As DB_UASDataSet
    Friend WithEvents TblBukuBindingSource As BindingSource
    Friend WithEvents Tbl_BukuTableAdapter As DB_UASDataSetTableAdapters.Tbl_BukuTableAdapter
    Friend WithEvents IdbukuDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents JudulbukuDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PengarangDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PenerbitDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TahunTerbitDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HargabukuDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents JumlahBukuDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents btn_exit As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button10 As Button
    Friend WithEvents ErrorProvider1 As ErrorProvider
End Class
