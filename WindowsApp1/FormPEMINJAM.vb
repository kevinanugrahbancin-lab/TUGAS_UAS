Public Class FormPEMINJAM
    Private Sub FormPEMINJAM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DB_UASDataSet2.Tbl_Pinjam' table. You can move, or remove it, as needed.
        Me.Tbl_PinjamTableAdapter.Fill(Me.DB_UASDataSet2.Tbl_Pinjam)

    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Dim row = DirectCast(TblPinjamBindingSource.AddNew(), DataRowView)
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If (String.IsNullOrEmpty(txt_kodepinjam.Text)) Then
            ErrorProvider1.SetError(txt_kodepinjam, "code is required")
        Else
            ErrorProvider1.SetError(txt_kodepinjam, String.Empty)
            For i As Integer = 0 To DataGridView1.Rows.Count = 1
                If txt_kodepinjam.Text = DataGridView1.Rows(i).Cells(1).Value.ToString And txt_judulbuku.Text <> DataGridView1.Rows(i).Cells(0).Value.ToString Then
                    MessageBox.Show("kode exists befo   re")
                    Return
                Else
                    TblPinjamBindingSource.EndEdit()
                    Tbl_PinjamTableAdapter.Update(DB_UASDataSet2.Tbl_Pinjam)
                End If
            Next
            MessageBox.Show("data saved succesfully")
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TblPinjamBindingSource.RemoveCurrent()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TblPinjamBindingSource.MoveFirst()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TblPinjamBindingSource.MoveNext()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        TblPinjamBindingSource.MovePrevious()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        TblPinjamBindingSource.MoveLast()
    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        End
    End Sub
End Class