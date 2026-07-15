Imports System.Data
Public Class FormMENU
    Private Sub TABELBUKUToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TABELBUKUToolStripMenuItem.Click
        FormTABELBUKU.Show()
    End Sub

    Private Sub Report1rdlcToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Report1rdlcToolStripMenuItem.Click
        Dim frm As New Formreport
        frm.Show()
    End Sub

    Private Sub TABELPEMINJAMToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TABELPEMINJAMToolStripMenuItem.Click
        FormPEMINJAM.Show()
    End Sub

    Private Sub Report2rdlcToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Report2rdlcToolStripMenuItem.Click
        Dim frm As New FormReport1
        frm.Show()
    End Sub
End Class