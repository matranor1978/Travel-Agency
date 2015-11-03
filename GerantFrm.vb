Public Class GerantFrm
    Private _utilisateur As Utilisateur
    Property utilisateurActuel()
        Get
            Return _utilisateur
        End Get
        Set(ByVal value)
            _utilisateur = value
        End Set
    End Property

    Private Sub GerantFrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: cette ligne de code charge les données dans la table 'Voyages2010DataSet.tblVoyages'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.TblVoyagesTableAdapter.Fill(Me.Voyages2010DataSet.tblVoyages)
        'TODO: cette ligne de code charge les données dans la table 'Voyages2010DataSet.tblClients'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.TblClientsTableAdapter.Fill(Me.Voyages2010DataSet.tblClients)

        _utilisateur = HomePageFrm.utilisateurActuel()

    End Sub

    Private Sub bQuitter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bQuitter.Click
        HomePageFrm.Show()
        Me.Hide()
    End Sub

    Private Sub GererClientsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GererClientsToolStripMenuItem.Click
        GerantFrmClients.Show()
        Me.Hide()
    End Sub

    Private Sub GererVoyagesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GererVoyagesToolStripMenuItem.Click
        GerantFrmVoyages.Show()
        Me.Hide()
    End Sub

    Private Sub ModifierMotDePasseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModifierMotDePasseToolStripMenuItem.Click
        setPasswordGerant.Show()
    End Sub
End Class