Public Class CommisFrm

    Private Sub CommisFrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: cette ligne de code charge les données dans la table 'Voyages2010DataSet.tblReservations'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.TblReservationsTableAdapter.Fill(Me.Voyages2010DataSet.tblReservations)
        'TODO: cette ligne de code charge les données dans la table 'Voyages2010DataSet.tblClients'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.TblClientsTableAdapter.Fill(Me.Voyages2010DataSet.tblClients)
    End Sub



    Private Sub MoveClient(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bFirstClient.Click, bPreviousClient.Click, bNextClient.Click, bLastClient.Click
        If sender Is bFirstClient Then
            Me.TblClientsBindingSource.MoveFirst()

        ElseIf sender Is bPreviousClient Then
            Me.TblClientsBindingSource.MovePrevious()
        ElseIf sender Is bNextClient Then
            Me.TblClientsBindingSource.MoveNext()
        Else
            Me.TblClientsBindingSource.MoveLast()
        End If
    End Sub

    Private Sub bQuitter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bQuitter.Click
        HomePageFrm.Show()
        Panel1.Visible = False
        Me.Hide()
    End Sub

    Private Sub bAjouterReservation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bAjouterReservation.Click
        Try
            'Terminer les modifications en cours
            Me.TblClientsBindingSource.EndEdit()
            'créer un nouvel enrg
            Me.TableAdapterManager.UpdateAll(Me.Voyages2010DataSet)
            MsgBox("Réservation ajoutée avec succès", MsgBoxStyle.Information, "Ajout Réservation")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub bSupprimerReservation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bSupprimerReservation.Click
        If MsgBox("Voulez-vous vraiement supprimer cette réservation ?", vbYesNo, "Confirmation de suppression") = vbYes Then
            Try
                Me.TblClientsReservationsBindingSource.RemoveCurrent()
                MsgBox("La Réservation a été Bien Supprimée", MsgBoxStyle.Information, "Suppression Réservation")
                Me.TableAdapterManager.UpdateAll(Me.Voyages2010DataSet)
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub GérerRéservationsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GérerRéservationsToolStripMenuItem.Click
        Panel1.Visible = True
    End Sub

    Private Sub ModifierMotDePasseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModifierMotDePasseToolStripMenuItem.Click
        Panel1.Visible = False
        SetPasswordCommis.Show()
    End Sub


End Class