<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormReport1
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.DB_UASDataSet3 = New WindowsApp1.DB_UASDataSet3()
        Me.Tbl_PinjamBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_PinjamTableAdapter = New WindowsApp1.DB_UASDataSet3TableAdapters.Tbl_PinjamTableAdapter()
        Me.FileSystemWatcher1 = New System.IO.FileSystemWatcher()
        CType(Me.DB_UASDataSet3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_PinjamBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.Tbl_PinjamBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "WindowsApp1.Report2.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(12, 24)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(1491, 472)
        Me.ReportViewer1.TabIndex = 0
        '
        'DB_UASDataSet3
        '
        Me.DB_UASDataSet3.DataSetName = "DB_UASDataSet3"
        Me.DB_UASDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Tbl_PinjamBindingSource
        '
        Me.Tbl_PinjamBindingSource.DataMember = "Tbl_Pinjam"
        Me.Tbl_PinjamBindingSource.DataSource = Me.DB_UASDataSet3
        '
        'Tbl_PinjamTableAdapter
        '
        Me.Tbl_PinjamTableAdapter.ClearBeforeFill = True
        '
        'FileSystemWatcher1
        '
        Me.FileSystemWatcher1.EnableRaisingEvents = True
        Me.FileSystemWatcher1.SynchronizingObject = Me
        '
        'FormReport1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1515, 577)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "FormReport1"
        Me.Text = "FormReport1"
        CType(Me.DB_UASDataSet3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_PinjamBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Tbl_PinjamBindingSource As BindingSource
    Friend WithEvents DB_UASDataSet3 As DB_UASDataSet3
    Friend WithEvents Tbl_PinjamTableAdapter As DB_UASDataSet3TableAdapters.Tbl_PinjamTableAdapter
    Friend WithEvents FileSystemWatcher1 As IO.FileSystemWatcher
End Class
