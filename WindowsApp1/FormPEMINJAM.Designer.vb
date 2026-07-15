<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPEMINJAM
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_tanggalkembali = New System.Windows.Forms.TextBox()
        Me.txt_tanggalpinjam = New System.Windows.Forms.TextBox()
        Me.txt_jumlahbuku = New System.Windows.Forms.TextBox()
        Me.txt_judulbuku = New System.Windows.Forms.TextBox()
        Me.txt_kodebuku = New System.Windows.Forms.TextBox()
        Me.txt_kodepinjam = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DB_UASDataSet2 = New WindowsApp1.DB_UASDataSet2()
        Me.TblPinjamBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_PinjamTableAdapter = New WindowsApp1.DB_UASDataSet2TableAdapters.Tbl_PinjamTableAdapter()
        Me.KodepinjamDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KodebukuDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JudulbukuDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JumlahbukuDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TanggalpinjamDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TanggalkembaliDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btn_exit = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DB_UASDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblPinjamBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(35, 220)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(141, 17)
        Me.Label2.TabIndex = 89
        Me.Label2.Text = "TANGGAL_KEMBALI"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(35, 180)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(132, 17)
        Me.Label3.TabIndex = 88
        Me.Label3.Text = "TANGGAL_PINJAM"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(35, 139)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(109, 17)
        Me.Label8.TabIndex = 87
        Me.Label8.Text = "JUMLAH_BUKU"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(35, 100)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(99, 17)
        Me.Label7.TabIndex = 86
        Me.Label7.Text = "JUDUL_BUKU"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(35, 60)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(93, 17)
        Me.Label6.TabIndex = 85
        Me.Label6.Text = "KODE_BUKU"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(35, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(104, 17)
        Me.Label5.TabIndex = 84
        Me.Label5.Text = "KODE_PINJAM"
        '
        'txt_tanggalkembali
        '
        Me.txt_tanggalkembali.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblPinjamBindingSource, "Tanggal_kembali", True))
        Me.txt_tanggalkembali.Location = New System.Drawing.Point(242, 212)
        Me.txt_tanggalkembali.Name = "txt_tanggalkembali"
        Me.txt_tanggalkembali.Size = New System.Drawing.Size(100, 22)
        Me.txt_tanggalkembali.TabIndex = 96
        '
        'txt_tanggalpinjam
        '
        Me.txt_tanggalpinjam.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblPinjamBindingSource, "Tanggal_pinjam", True))
        Me.txt_tanggalpinjam.Location = New System.Drawing.Point(242, 172)
        Me.txt_tanggalpinjam.Name = "txt_tanggalpinjam"
        Me.txt_tanggalpinjam.Size = New System.Drawing.Size(100, 22)
        Me.txt_tanggalpinjam.TabIndex = 95
        '
        'txt_jumlahbuku
        '
        Me.txt_jumlahbuku.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblPinjamBindingSource, "Jumlah_buku", True))
        Me.txt_jumlahbuku.Location = New System.Drawing.Point(242, 134)
        Me.txt_jumlahbuku.Name = "txt_jumlahbuku"
        Me.txt_jumlahbuku.Size = New System.Drawing.Size(100, 22)
        Me.txt_jumlahbuku.TabIndex = 94
        '
        'txt_judulbuku
        '
        Me.txt_judulbuku.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblPinjamBindingSource, "Judul_buku", True))
        Me.txt_judulbuku.Location = New System.Drawing.Point(242, 95)
        Me.txt_judulbuku.Name = "txt_judulbuku"
        Me.txt_judulbuku.Size = New System.Drawing.Size(100, 22)
        Me.txt_judulbuku.TabIndex = 93
        '
        'txt_kodebuku
        '
        Me.txt_kodebuku.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblPinjamBindingSource, "Kode_buku", True))
        Me.txt_kodebuku.Location = New System.Drawing.Point(242, 55)
        Me.txt_kodebuku.Name = "txt_kodebuku"
        Me.txt_kodebuku.Size = New System.Drawing.Size(100, 22)
        Me.txt_kodebuku.TabIndex = 92
        '
        'txt_kodepinjam
        '
        Me.txt_kodepinjam.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblPinjamBindingSource, "Kode_pinjam", True))
        Me.txt_kodepinjam.Location = New System.Drawing.Point(242, 17)
        Me.txt_kodepinjam.Name = "txt_kodepinjam"
        Me.txt_kodepinjam.Size = New System.Drawing.Size(100, 22)
        Me.txt_kodepinjam.TabIndex = 91
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.KodepinjamDataGridViewTextBoxColumn, Me.KodebukuDataGridViewTextBoxColumn, Me.JudulbukuDataGridViewTextBoxColumn, Me.JumlahbukuDataGridViewTextBoxColumn, Me.TanggalpinjamDataGridViewTextBoxColumn, Me.TanggalkembaliDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.TblPinjamBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(208, 352)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(804, 165)
        Me.DataGridView1.TabIndex = 97
        '
        'DB_UASDataSet2
        '
        Me.DB_UASDataSet2.DataSetName = "DB_UASDataSet2"
        Me.DB_UASDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblPinjamBindingSource
        '
        Me.TblPinjamBindingSource.DataMember = "Tbl_Pinjam"
        Me.TblPinjamBindingSource.DataSource = Me.DB_UASDataSet2
        '
        'Tbl_PinjamTableAdapter
        '
        Me.Tbl_PinjamTableAdapter.ClearBeforeFill = True
        '
        'KodepinjamDataGridViewTextBoxColumn
        '
        Me.KodepinjamDataGridViewTextBoxColumn.DataPropertyName = "Kode_pinjam"
        Me.KodepinjamDataGridViewTextBoxColumn.HeaderText = "Kode_pinjam"
        Me.KodepinjamDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.KodepinjamDataGridViewTextBoxColumn.Name = "KodepinjamDataGridViewTextBoxColumn"
        Me.KodepinjamDataGridViewTextBoxColumn.Width = 125
        '
        'KodebukuDataGridViewTextBoxColumn
        '
        Me.KodebukuDataGridViewTextBoxColumn.DataPropertyName = "Kode_buku"
        Me.KodebukuDataGridViewTextBoxColumn.HeaderText = "Kode_buku"
        Me.KodebukuDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.KodebukuDataGridViewTextBoxColumn.Name = "KodebukuDataGridViewTextBoxColumn"
        Me.KodebukuDataGridViewTextBoxColumn.Width = 125
        '
        'JudulbukuDataGridViewTextBoxColumn
        '
        Me.JudulbukuDataGridViewTextBoxColumn.DataPropertyName = "Judul_buku"
        Me.JudulbukuDataGridViewTextBoxColumn.HeaderText = "Judul_buku"
        Me.JudulbukuDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.JudulbukuDataGridViewTextBoxColumn.Name = "JudulbukuDataGridViewTextBoxColumn"
        Me.JudulbukuDataGridViewTextBoxColumn.Width = 125
        '
        'JumlahbukuDataGridViewTextBoxColumn
        '
        Me.JumlahbukuDataGridViewTextBoxColumn.DataPropertyName = "Jumlah_buku"
        Me.JumlahbukuDataGridViewTextBoxColumn.HeaderText = "Jumlah_buku"
        Me.JumlahbukuDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.JumlahbukuDataGridViewTextBoxColumn.Name = "JumlahbukuDataGridViewTextBoxColumn"
        Me.JumlahbukuDataGridViewTextBoxColumn.Width = 125
        '
        'TanggalpinjamDataGridViewTextBoxColumn
        '
        Me.TanggalpinjamDataGridViewTextBoxColumn.DataPropertyName = "Tanggal_pinjam"
        Me.TanggalpinjamDataGridViewTextBoxColumn.HeaderText = "Tanggal_pinjam"
        Me.TanggalpinjamDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.TanggalpinjamDataGridViewTextBoxColumn.Name = "TanggalpinjamDataGridViewTextBoxColumn"
        Me.TanggalpinjamDataGridViewTextBoxColumn.Width = 125
        '
        'TanggalkembaliDataGridViewTextBoxColumn
        '
        Me.TanggalkembaliDataGridViewTextBoxColumn.DataPropertyName = "Tanggal_kembali"
        Me.TanggalkembaliDataGridViewTextBoxColumn.HeaderText = "Tanggal_kembali"
        Me.TanggalkembaliDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.TanggalkembaliDataGridViewTextBoxColumn.Name = "TanggalkembaliDataGridViewTextBoxColumn"
        Me.TanggalkembaliDataGridViewTextBoxColumn.Width = 125
        '
        'btn_exit
        '
        Me.btn_exit.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_exit.Location = New System.Drawing.Point(1267, 255)
        Me.btn_exit.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_exit.Name = "btn_exit"
        Me.btn_exit.Size = New System.Drawing.Size(134, 47)
        Me.btn_exit.TabIndex = 116
        Me.btn_exit.Text = "EXIT"
        Me.btn_exit.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.Location = New System.Drawing.Point(1071, 258)
        Me.Button7.Margin = New System.Windows.Forms.Padding(4)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(157, 47)
        Me.Button7.TabIndex = 115
        Me.Button7.Text = "LAST"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(797, 256)
        Me.Button6.Margin = New System.Windows.Forms.Padding(4)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(209, 50)
        Me.Button6.TabIndex = 114
        Me.Button6.Text = "PREVIOUS"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(590, 255)
        Me.Button5.Margin = New System.Windows.Forms.Padding(4)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(152, 50)
        Me.Button5.TabIndex = 113
        Me.Button5.Text = "NEXT"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(407, 255)
        Me.Button4.Margin = New System.Windows.Forms.Padding(4)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(125, 46)
        Me.Button4.TabIndex = 112
        Me.Button4.Text = "FIRST"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(981, 180)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(165, 39)
        Me.Button3.TabIndex = 111
        Me.Button3.Text = "DELETE"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.Location = New System.Drawing.Point(751, 180)
        Me.Button8.Margin = New System.Windows.Forms.Padding(4)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(139, 39)
        Me.Button8.TabIndex = 110
        Me.Button8.Text = "SAVE"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button10
        '
        Me.Button10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button10.Location = New System.Drawing.Point(527, 180)
        Me.Button10.Margin = New System.Windows.Forms.Padding(4)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(147, 39)
        Me.Button10.TabIndex = 109
        Me.Button10.Text = "NEW"
        Me.Button10.UseVisualStyleBackColor = True
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'FormPEMINJAM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1447, 571)
        Me.Controls.Add(Me.btn_exit)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button10)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.txt_tanggalkembali)
        Me.Controls.Add(Me.txt_tanggalpinjam)
        Me.Controls.Add(Me.txt_jumlahbuku)
        Me.Controls.Add(Me.txt_judulbuku)
        Me.Controls.Add(Me.txt_kodebuku)
        Me.Controls.Add(Me.txt_kodepinjam)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Name = "FormPEMINJAM"
        Me.Text = "FormPEMINJAM"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DB_UASDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblPinjamBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_tanggalkembali As TextBox
    Friend WithEvents txt_tanggalpinjam As TextBox
    Friend WithEvents txt_jumlahbuku As TextBox
    Friend WithEvents txt_judulbuku As TextBox
    Friend WithEvents txt_kodebuku As TextBox
    Friend WithEvents txt_kodepinjam As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DB_UASDataSet2 As DB_UASDataSet2
    Friend WithEvents TblPinjamBindingSource As BindingSource
    Friend WithEvents Tbl_PinjamTableAdapter As DB_UASDataSet2TableAdapters.Tbl_PinjamTableAdapter
    Friend WithEvents KodepinjamDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents KodebukuDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents JudulbukuDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents JumlahbukuDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TanggalpinjamDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TanggalkembaliDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
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
