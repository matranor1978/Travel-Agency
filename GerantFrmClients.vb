Imports System.Text.RegularExpressions

Public Class GerantFrmClients
    Private _utilisateur As Utilisateur
    Private drapeau As Boolean

    Private Sub bQuitter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bQuitter.Click
        End
    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorAddNewItem.Click

        NomClientTextBox.Enabled = True
        TblClientsDataGridView.Rows(TblClientsDataGridView.Rows.Count - 1).Cells(2).ReadOnly = False
        
    End Sub

    Private Sub TblClientsBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TblClientsBindingNavigatorSaveItem.Click
        If MessageBox.Show("Voulez-vous sauvegarder les changements ?", "Confirmation de sauvegarde", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Try
                Me.Validate()
                Me.TblClientsBindingSource.EndEdit()
                Me.TableAdapterManager.UpdateAll(Me.Voyages2010DataSet)
                NomClientTextBox.ReadOnly = True
                MsgBox("Sauvegarde réussie!!")

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub


    Private Sub GerantFrmClients_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: cette ligne de code charge les données dans la table 'Voyages2010DataSet.tblClients'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.TblClientsTableAdapter.Fill(Me.Voyages2010DataSet.tblClients)
        
        _utilisateur = HomePageFrm.utilisateurActuel()
        Dim ud As New UtilisateurDao
        Dim user As New Utilisateur
        user = ud.getAllUtilisateurs(_utilisateur.username, _utilisateur.password)
        If user.preference = "DataGrid" Then
            tabControlClient.TabPages.Remove(TabPage2)
        ElseIf user.preference = "TextBox" Then
            tabControlClient.TabPages.Remove(TabPage1)
        End If
        TblClientsDataGridView.Columns.Item(0).ReadOnly = True
        TblClientsDataGridView.Columns.Item(2).ReadOnly = True
    End Sub

    Private Sub bChangerPreference_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bChangerPreference.Click
        If tabControlClient.TabCount < 2 Then
            If drapeau = True Then
                tabControlClient.TabPages.Insert(1, TabPage2)
                tabControlClient.TabPages.Remove(TabPage1)
                drapeau = False
                NomClientTextBox.ReadOnly = True
                _utilisateur.preference() = "TextBox"
            Else
                tabControlClient.TabPages.Insert(0, TabPage1)
                tabControlClient.TabPages.Remove(TabPage2)
                drapeau = True
                NomClientTextBox.ReadOnly = True
                _utilisateur.preference = "DataGrid"
            End If
        End If
    End Sub
End Class