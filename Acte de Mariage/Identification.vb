Public Class Identification

    Private Sub Verification()
        If TextBox1.Text.Equals("Amen") Then
            Main.Show()
            Me.Close()
        Else
            MsgBox("Mot de passe incorect", MsgBoxStyle.Critical, "Erreur")
            TextBox1.Clear()
            TextBox1.FindForm()
        End If
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Verification()
    End Sub
End Class