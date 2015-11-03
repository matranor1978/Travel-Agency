Imports System.Security.Cryptography
Imports System.Text

Public Class HomePageFrm
    Private _utilisateur As Utilisateur

    Property utilisateurActuel()
        Get
            Return _utilisateur
        End Get
        Set(ByVal value)
            _utilisateur = value
        End Set
    End Property

    Private Sub bQuitter_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        End
    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If cbType.SelectedIndex = 0 Then
            CommisFrm.Show()
        ElseIf cbType.SelectedIndex = 1 Then
            GerantFrm.Show()
        Else
            AdminFrm.Show()
        End If
        Me.Visible = False
    End Sub

    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        Try
            Dim md5Hasher As MD5 = MD5.Create
            Dim donnees As Byte() = md5Hasher.ComputeHash(Encoding.Default.GetBytes(tPassword.Text))
            Dim chaineAconstruire As New StringBuilder()
            For i As Integer = 0 To donnees.Length - 1
                chaineAconstruire.Append(donnees(i).ToString("x2"))
            Next i
            Dim comparer As StringComparer = StringComparer.OrdinalIgnoreCase
            Dim ud As New UtilisateurDao
            _utilisateur = New Utilisateur(tLogin.Text.Trim, chaineAconstruire.ToString.Trim, cbType.SelectedItem.ToString)
            If ud.checkLoginUtilisateur(_utilisateur) Then
                If cbType.SelectedIndex = 0 Then
                    CommisFrm.Text = _utilisateur.username & "- " & _utilisateur.type
                    CommisFrm.Show()

                ElseIf cbType.SelectedIndex = 1 Then
                    GerantFrm.Text = _utilisateur.username & "- " & _utilisateur.type
                    GerantFrm.Show()
                Else
                    AdminFrm.Text = _utilisateur.username & "- " & _utilisateur.type
                    AdminFrm.Show()
                End If
                cbType.SelectedIndex = -1
                tLogin.Text = ""
                tPassword.Text = ""
                lerreur.Visible = False
                Me.Visible = False
            Else
                lerreur.Visible = True
            End If
        Catch ex As Exception

        End Try

    End Sub


    Private Sub bQuitter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bQuitter.Click
        End
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Timer1_Tick_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        lDate.Text = Date.Now.ToLongDateString
        lTime.Text = Date.Now.ToLongTimeString
    End Sub

    Private Sub HomePageFrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
