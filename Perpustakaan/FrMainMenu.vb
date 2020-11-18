Public Class FrMainMenu

    Private Sub DataBukuToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles DataBukuToolStripMenuItem.Click
        FrBuku.Show()
    End Sub

    Private Sub DataAnggotaToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles DataAnggotaToolStripMenuItem.Click
        FrAnggota.Show()
    End Sub

    Private Sub PeminjamanBukuToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles PeminjamanBukuToolStripMenuItem.Click
        FrPinjam.Show()
    End Sub

    Private Sub AboutAppToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AboutAppToolStripMenuItem.Click
        FrAboutApp.Show()
    End Sub
End Class