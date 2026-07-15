<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormMENU
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.TABELBUKUToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Report1rdlcToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TABELPEMINJAMToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Report2rdlcToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TABELBUKUToolStripMenuItem, Me.Report1rdlcToolStripMenuItem, Me.TABELPEMINJAMToolStripMenuItem, Me.Report2rdlcToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'TABELBUKUToolStripMenuItem
        '
        Me.TABELBUKUToolStripMenuItem.Name = "TABELBUKUToolStripMenuItem"
        Me.TABELBUKUToolStripMenuItem.Size = New System.Drawing.Size(106, 24)
        Me.TABELBUKUToolStripMenuItem.Text = "TABEL BUKU"
        '
        'Report1rdlcToolStripMenuItem
        '
        Me.Report1rdlcToolStripMenuItem.Name = "Report1rdlcToolStripMenuItem"
        Me.Report1rdlcToolStripMenuItem.Size = New System.Drawing.Size(104, 24)
        Me.Report1rdlcToolStripMenuItem.Text = "Report1.rdlc"
        '
        'TABELPEMINJAMToolStripMenuItem
        '
        Me.TABELPEMINJAMToolStripMenuItem.Name = "TABELPEMINJAMToolStripMenuItem"
        Me.TABELPEMINJAMToolStripMenuItem.Size = New System.Drawing.Size(140, 24)
        Me.TABELPEMINJAMToolStripMenuItem.Text = "TABEL PEMINJAM"
        '
        'Report2rdlcToolStripMenuItem
        '
        Me.Report2rdlcToolStripMenuItem.Name = "Report2rdlcToolStripMenuItem"
        Me.Report2rdlcToolStripMenuItem.Size = New System.Drawing.Size(104, 24)
        Me.Report2rdlcToolStripMenuItem.Text = "Report2.rdlc"
        '
        'FormMENU
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FormMENU"
        Me.Text = "FormMENU"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents TABELBUKUToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Report1rdlcToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TABELPEMINJAMToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Report2rdlcToolStripMenuItem As ToolStripMenuItem
End Class
