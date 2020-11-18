<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrMainMenu
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.DataBukuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataAnggotaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PeminjamanBukuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutAppToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DataBukuToolStripMenuItem, Me.DataAnggotaToolStripMenuItem, Me.PeminjamanBukuToolStripMenuItem, Me.AboutAppToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(367, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'DataBukuToolStripMenuItem
        '
        Me.DataBukuToolStripMenuItem.Name = "DataBukuToolStripMenuItem"
        Me.DataBukuToolStripMenuItem.Size = New System.Drawing.Size(73, 20)
        Me.DataBukuToolStripMenuItem.Text = "Data Buku"
        '
        'DataAnggotaToolStripMenuItem
        '
        Me.DataAnggotaToolStripMenuItem.Name = "DataAnggotaToolStripMenuItem"
        Me.DataAnggotaToolStripMenuItem.Size = New System.Drawing.Size(92, 20)
        Me.DataAnggotaToolStripMenuItem.Text = "Data Anggota"
        '
        'PeminjamanBukuToolStripMenuItem
        '
        Me.PeminjamanBukuToolStripMenuItem.Name = "PeminjamanBukuToolStripMenuItem"
        Me.PeminjamanBukuToolStripMenuItem.Size = New System.Drawing.Size(116, 20)
        Me.PeminjamanBukuToolStripMenuItem.Text = "Peminjaman Buku"
        '
        'AboutAppToolStripMenuItem
        '
        Me.AboutAppToolStripMenuItem.Name = "AboutAppToolStripMenuItem"
        Me.AboutAppToolStripMenuItem.Size = New System.Drawing.Size(77, 20)
        Me.AboutAppToolStripMenuItem.Text = "About App"
        '
        'FrMainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(367, 80)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FrMainMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Main Menu"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents DataBukuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataAnggotaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PeminjamanBukuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutAppToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
