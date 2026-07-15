Public Class FormReport1
    Private Sub FormReport1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DB_UASDataSet3.Tbl_Pinjam' table. You can move, or remove it, as needed.
        Me.Tbl_PinjamTableAdapter.Fill(Me.DB_UASDataSet3.Tbl_Pinjam)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class