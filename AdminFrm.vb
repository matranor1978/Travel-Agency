Imports System.ComponentModel
Imports System.Data.OleDb

Public Class AdminFrm
    Dim ud As New UtilisateurDao
    Dim listeUtilisateurs As BindingList(Of Utilisateur) = ud.getAllUtilisateurs()
    Shared type As String
    Shared pref As String
    Dim con As New OleDbConnection

    Private Sub AdminFrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: cette ligne de code charge les données dans la table 'Voyages2010DataSet.tbUtilisateurs'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.TbUtilisateursTableAdapter.Fill(Me.Voyages2010DataSet.tbUtilisateurs)
        con.ConnectionString = "provider=microsoft.ace.oledb.12.0; data source =" & Application.StartupPath & "\Voyages2010.mdb"
        con.Open()
        lbUtilisateurs.DataSource = listeUtilisateurs
        lbUtilisateurs.Update()
    End Sub
    Private Sub btnQuitter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
        HomePageFrm.Show()
    End Sub

    Private Sub bAjouter_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bAjouter.Click
        Panel2.Enabled = True
        Dim listeUtilisateurs As BindingList(Of Utilisateur) = ud.getAllUtilisateurs()
        Dim u As Utilisateur


        If rbCommis.Checked = True Then
            type = "Commis"
        ElseIf rbGerant.Checked = True Then

            type = "Gérant"
            GroupBox1.Enabled = True


            If rbDataGrid.Checked = True Then
                pref = "DataGrid"
            Else
                pref = "TextBox"
            End If
        End If

        u = New Utilisateur(tNom.Text, tPassword.Text, type, pref)

        If tNom.Text <> "" And tPassword.Text <> "" And (rbCommis.Checked Or rbGerant.Checked) Then

            ud.addUtilisateur(u)
            lbUtilisateurs.DataSource = ud.getAllUtilisateurs()
            lbUtilisateurs.Update()
            tNom.Text = ""
            tPassword.Text = ""
            rbCommis.Checked = False
            rbGerant.Checked = False
        Else
            'MsgBox("Tous les champs sont obligatoires!!")
        End If

    End Sub

    Private Sub bSupprimer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bSupprimer.Click
        Dim user As New Utilisateur(tNom.Text, tPassword.Text, type, pref)
        Dim reponse As DialogResult
        If lbUtilisateurs.SelectedIndex = -1 Then
            Return
        End If
        Dim u As Utilisateur = CType(lbUtilisateurs.SelectedItem, Utilisateur)
        If u.type = "Administrateur" Then
            MsgBox("Vous ne pouvez pas supprimer un administrateur")
        Else
            reponse = MessageBox.Show("Désirez-vous supprimer l'utilisateur [" + u.toString + "] ?", "Confirmation de suppression", MessageBoxButtons.YesNo)
            If reponse <> Windows.Forms.DialogResult.Yes Then
                Return
            End If
            If reponse = Windows.Forms.DialogResult.Yes Then

                ud.deleteUtilisateur(u.ID)
                If lbUtilisateurs.SelectedIndex <> -1 Then
                    lbUtilisateurs.Update()
                    lbUtilisateurs.DataSource = ud.getAllUtilisateurs()
                    lbUtilisateurs.Update()
                End If
            End If
        End If
    End Sub

    Private Sub bQuitter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bQuitter.Click
        Me.Close()
        HomePageFrm.Show()
    End Sub

    Private Sub bNextUser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bNextUser.Click
        Dim i As Integer = lbUtilisateurs.SelectedIndex
        Dim t As Integer = lbUtilisateurs.Items.Count
        If i < t - 1 Then
            lbUtilisateurs.SetSelected(i + 1, True)
        End If
    End Sub

    Private Sub bPreviousUser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bPreviousUser.Click
        Dim i As Integer = lbUtilisateurs.SelectedIndex
        If i > 0 Then
            lbUtilisateurs.SetSelected(i - 1, True)
        End If
    End Sub

    Private Sub bLastUser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bLastUser.Click
        Dim i As Integer = lbUtilisateurs.SelectedIndex
        Dim t As Integer = lbUtilisateurs.Items.Count
        If i < t - 1 Then
            lbUtilisateurs.SetSelected(t - 1, True)
        End If
    End Sub

    Private Sub bFirstUser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bFirstUser.Click
        Dim i As Integer = lbUtilisateurs.SelectedIndex
        Dim t As Integer = lbUtilisateurs.Items.Count
        If t > 0 Then
            lbUtilisateurs.SetSelected(0, True)
        End If
    End Sub

    Private Sub rbGerant_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbGerant.CheckedChanged
        If rbGerant.Checked = True Then
            GroupBox1.Enabled = True
        Else
            GroupBox1.Enabled = False
        End If
    End Sub

End Class