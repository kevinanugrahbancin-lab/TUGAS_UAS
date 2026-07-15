Public Class FormTABELBUKU
    Private Sub FormTABELBUKU_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DB_UASDataSet.Tbl_Buku' table. You can move, or remove it, as needed.
        Me.Tbl_BukuTableAdapter.Fill(Me.DB_UASDataSet.Tbl_Buku)

    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Dim row = DirectCast(TblBukuBindingSource.AddNew(), DataRowView)
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If (String.IsNullOrEmpty(txt_penerbit.Text)) Then
            ErrorProvider1.SetError(txt_penerbit, "code is required")
        Else
            ErrorProvider1.SetError(txt_penerbit, String.Empty)
            For i As Integer = 0 To DataGridView1.Rows.Count = 1
                If txt_penerbit.Text = DataGridView1.Rows(i).Cells(1).Value.ToString And txt_idbuku.Text <> DataGridView1.Rows(i).Cells(0).Value.ToString Then
                    MessageBox.Show("kode exists befo   re")
                    Return
                Else
                    TblBukuBindingSource.EndEdit()
                    Tbl_BukuTableAdapter.Update(DB_UASDataSet.Tbl_Buku)
                End If
            Next
            MessageBox.Show("data saved succesfully")
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TblBukuBindingSource.MoveFirst()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TblBukuBindingSource.MoveNext()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        TblBukuBindingSource.MovePrevious()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        TblBukuBindingSource.MoveLast()
    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        End
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

    End Sub
End Class