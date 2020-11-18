Public Class FrPinjam
    Sub clear()
        TxtID.Text = ""
        TxtNama.Text = ""
        TxtKode.Text = ""
        TxtJudul.Text = ""
    End Sub
    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles BtnExit.Click
        Close()
    End Sub

    Private Sub BtnClear_Click(sender As System.Object, e As System.EventArgs) Handles BtnClear.Click
        Call clear()
    End Sub
End Class