<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Formreport
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
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.Tbl_BukuBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DB_UASDataSet1 = New WindowsApp1.DB_UASDataSet1()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.FileSystemWatcher1 = New System.IO.FileSystemWatcher()
        Me.Tbl_BukuTableAdapter = New WindowsApp1.DB_UASDataSet1TableAdapters.Tbl_BukuTableAdapter()
        CType(Me.Tbl_BukuBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DB_UASDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Tbl_BukuBindingSource
        '
        Me.Tbl_BukuBindingSource.DataMember = "Tbl_Buku"
        Me.Tbl_BukuBindingSource.DataSource = Me.DB_UASDataSet1
        '
        'DB_UASDataSet1
        '
        Me.DB_UASDataSet1.DataSetName = "DB_UASDataSet1"
        Me.DB_UASDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.Tbl_BukuBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "WindowsApp1.Report1.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(83, 29)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(1594, 706)
        Me.ReportViewer1.TabIndex = 0
        '
        'FileSystemWatcher1
        '
        Me.FileSystemWatcher1.EnableRaisingEvents = True
        Me.FileSystemWatcher1.SynchronizingObject = Me
        '
        'Tbl_BukuTableAdapter
        '
        Me.Tbl_BukuTableAdapter.ClearBeforeFill = True
        '
        'Formreport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1689, 690)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "Formreport"
        Me.Text = "Formreport"
        CType(Me.Tbl_BukuBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DB_UASDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents FileSystemWatcher1 As IO.FileSystemWatcher
    Friend WithEvents Tbl_BukuBindingSource As BindingSource
    Friend WithEvents DB_UASDataSet1 As DB_UASDataSet1
    Friend WithEvents Tbl_BukuTableAdapter As DB_UASDataSet1TableAdapters.Tbl_BukuTableAdapter
End Class
