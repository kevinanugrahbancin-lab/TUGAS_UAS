Public Class Formreport
    Private Sub Formreport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DB_UASDataSet1.Tbl_Buku' table. You can move, or remove it, as needed.
        Me.Tbl_BukuTableAdapter.Fill(Me.DB_UASDataSet1.Tbl_Buku)

        Me.ReportViewer1.RefreshReport()

    End Sub
End Class