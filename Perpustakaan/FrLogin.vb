Public Class FrLogin

    Private Sub BtnLogin_Click(sender As System.Object, e As System.EventArgs) Handles BtnLogin.Click
        Dim Usernamae As String
        Dim Password As String

        Usernamae = TxtUser.Text
        Password = TxtPass.Text


        If (Usernamae = "Asep Ridwan Afandy") And (Password = "201902015") Then
            FrMainMenu.Show()
        Else
            MsgBox("Username atau Password salah!")
        End If
    End Sub
End Class
