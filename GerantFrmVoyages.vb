Public Class GerantFrmVoyages
    
    Private _utilisateur As Utilisateur
    Private drapeau As Boolean


    Private Sub GerantFrmVoyages_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: cette ligne de code charge les données dans la table 'Voyages2010DataSet.tblVoyages'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.TblVoyagesTableAdapter.Fill(Me.Voyages2010DataSet.tblVoyages)
        _utilisateur = HomePageFrm.utilisateurActuel()
        Dim ud As New UtilisateurDao
        Dim user As New Utilisateur
        user = ud.getAllUtilisateurs(_utilisateur.username, _utilisateur.password)
        If user.preference = "DataGrid" Then
            TabControlVoyage.TabPages.Remove(TabPage2)
        ElseIf user.preference = "TextBox" Then
            TabControlVoyage.TabPages.Remove(TabPage1)
        End If

    End Sub

    Private Sub bQuitter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bQuitter.Click
        End
    End Sub

   
    Private Sub TblClientsBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub bChangerPreference_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bChangerPreference.Click
        If TabControlVoyage.TabCount < 2 Then
            If drapeau = True Then
                TabControlVoyage.TabPages.Insert(1, TabPage2)
                TabControlVoyage.TabPages.Remove(TabPage1)
                drapeau = False
                _utilisateur.preference() = "TextBox"
            Else
                TabControlVoyage.TabPages.Insert(0, TabPage1)
                TabControlVoyage.TabPages.Remove(TabPage2)
                drapeau = True
                _utilisateur.preference = "DataGrid"
            End If
        End If
    End Sub

    Private Sub TblVoyagesBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TblVoyagesBindingNavigatorSaveItem.Click
        If MessageBox.Show("Voulez-vous sauvegarder les changements ?", "Confirmation de sauvegarde", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Try
                Me.Validate()
                Me.TblVoyagesBindingSource.EndEdit()
                Me.TableAdapterManager1.UpdateAll(Me.Voyages2010DataSet)
                MsgBox("Modification réussie!!")
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub
End Class