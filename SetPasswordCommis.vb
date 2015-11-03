Imports System.Security.Cryptography
Imports System.Text
Imports System.Data.OleDb
Imports System.IO
Public Class SetPasswordCommis

    Private Sub setPassword_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim nom As String() = CommisFrm.Text.Split(New Char() {"-"c})

        txtNomUserC.Text = nom(0)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Hide()
        CommisFrm.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim ud As New UtilisateurDao
        If textNewPassword.Text = textPasswordConfirm.Text AndAlso textNewPassword.Text <> "" AndAlso textPasswordConfirm.Text <> "" Then
            Dim nom As String() = CommisFrm.Text.Split(New Char() {"-"c})
            ud.updatePassword(nom(0), textNewPassword.Text)
            Button1.Enabled = False
            LbPasswordIncorrect.Show()
            Exit Sub
        Else
            LbPasswordIncorrect.Text = "* Mot de passe non confirmé"
            LbPasswordIncorrect.Visible = True
        End If
    End Sub
End Class

   