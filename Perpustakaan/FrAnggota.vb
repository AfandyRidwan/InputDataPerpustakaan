Public Class FrAnggota

    Sub clear()
        TxtID.Text = ""
        TxtNama.Text = ""
        TxtAlamat.Text = ""
        TxtTgl.Text = ""
        TxtTlp.Text = ""

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Close()
    End Sub


    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Call clear()
    End Sub
End Class