<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CommisFrm
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim NumClientLabel As System.Windows.Forms.Label
        Dim TitreAbregeLabel As System.Windows.Forms.Label
        Dim NomClientLabel As System.Windows.Forms.Label
        Dim PrenomLabel As System.Windows.Forms.Label
        Dim AdresseLabel As System.Windows.Forms.Label
        Dim TelephoneLabel As System.Windows.Forms.Label
        Dim CodePostalLabel As System.Windows.Forms.Label
        Dim VilleLabel As System.Windows.Forms.Label
        Me.TblClientsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Voyages2010DataSet = New VB_TP2.Voyages2010DataSet()
        Me.TblClientsTableAdapter = New VB_TP2.Voyages2010DataSetTableAdapters.tblClientsTableAdapter()
        Me.TblReservationsTableAdapter = New VB_TP2.Voyages2010DataSetTableAdapters.tblReservationsTableAdapter()
        Me.TableAdapterManager = New VB_TP2.Voyages2010DataSetTableAdapters.TableAdapterManager()
        Me.NumClientTextBox = New System.Windows.Forms.TextBox()
        Me.TitreAbregeTextBox = New System.Windows.Forms.TextBox()
        Me.NomClientTextBox = New System.Windows.Forms.TextBox()
        Me.PrenomTextBox = New System.Windows.Forms.TextBox()
        Me.AdresseTextBox = New System.Windows.Forms.TextBox()
        Me.TelephoneTextBox = New System.Windows.Forms.TextBox()
        Me.CodePostalTextBox = New System.Windows.Forms.TextBox()
        Me.VilleTextBox = New System.Windows.Forms.TextBox()
        Me.TblReservationsDataGridView = New System.Windows.Forms.DataGridView()
        Me.bSupprimerReservation = New System.Windows.Forms.Button()
        Me.bAjouterReservation = New System.Windows.Forms.Button()
        Me.bFirstClient = New System.Windows.Forms.Button()
        Me.bLastClient = New System.Windows.Forms.Button()
        Me.bPreviousClient = New System.Windows.Forms.Button()
        Me.bNextClient = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GérerRéservationsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModifierMotDePasseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.bQuitter = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TblClientsReservationsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        NumClientLabel = New System.Windows.Forms.Label()
        TitreAbregeLabel = New System.Windows.Forms.Label()
        NomClientLabel = New System.Windows.Forms.Label()
        PrenomLabel = New System.Windows.Forms.Label()
        AdresseLabel = New System.Windows.Forms.Label()
        TelephoneLabel = New System.Windows.Forms.Label()
        CodePostalLabel = New System.Windows.Forms.Label()
        VilleLabel = New System.Windows.Forms.Label()
        CType(Me.TblClientsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Voyages2010DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblReservationsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.TblClientsReservationsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NumClientLabel
        '
        NumClientLabel.AutoSize = True
        NumClientLabel.Location = New System.Drawing.Point(9, 84)
        NumClientLabel.Name = "NumClientLabel"
        NumClientLabel.Size = New System.Drawing.Size(61, 13)
        NumClientLabel.TabIndex = 4
        NumClientLabel.Text = "Num Client:"
        '
        'TitreAbregeLabel
        '
        TitreAbregeLabel.AutoSize = True
        TitreAbregeLabel.Location = New System.Drawing.Point(9, 110)
        TitreAbregeLabel.Name = "TitreAbregeLabel"
        TitreAbregeLabel.Size = New System.Drawing.Size(68, 13)
        TitreAbregeLabel.TabIndex = 6
        TitreAbregeLabel.Text = "Titre Abrege:"
        '
        'NomClientLabel
        '
        NomClientLabel.AutoSize = True
        NomClientLabel.Location = New System.Drawing.Point(9, 136)
        NomClientLabel.Name = "NomClientLabel"
        NomClientLabel.Size = New System.Drawing.Size(61, 13)
        NomClientLabel.TabIndex = 8
        NomClientLabel.Text = "Nom Client:"
        '
        'PrenomLabel
        '
        PrenomLabel.AutoSize = True
        PrenomLabel.Location = New System.Drawing.Point(9, 162)
        PrenomLabel.Name = "PrenomLabel"
        PrenomLabel.Size = New System.Drawing.Size(46, 13)
        PrenomLabel.TabIndex = 10
        PrenomLabel.Text = "Prenom:"
        '
        'AdresseLabel
        '
        AdresseLabel.AutoSize = True
        AdresseLabel.Location = New System.Drawing.Point(9, 188)
        AdresseLabel.Name = "AdresseLabel"
        AdresseLabel.Size = New System.Drawing.Size(48, 13)
        AdresseLabel.TabIndex = 12
        AdresseLabel.Text = "Adresse:"
        '
        'TelephoneLabel
        '
        TelephoneLabel.AutoSize = True
        TelephoneLabel.Location = New System.Drawing.Point(9, 214)
        TelephoneLabel.Name = "TelephoneLabel"
        TelephoneLabel.Size = New System.Drawing.Size(61, 13)
        TelephoneLabel.TabIndex = 14
        TelephoneLabel.Text = "Telephone:"
        '
        'CodePostalLabel
        '
        CodePostalLabel.AutoSize = True
        CodePostalLabel.Location = New System.Drawing.Point(9, 240)
        CodePostalLabel.Name = "CodePostalLabel"
        CodePostalLabel.Size = New System.Drawing.Size(67, 13)
        CodePostalLabel.TabIndex = 16
        CodePostalLabel.Text = "Code Postal:"
        '
        'VilleLabel
        '
        VilleLabel.AutoSize = True
        VilleLabel.Location = New System.Drawing.Point(9, 266)
        VilleLabel.Name = "VilleLabel"
        VilleLabel.Size = New System.Drawing.Size(29, 13)
        VilleLabel.TabIndex = 18
        VilleLabel.Text = "Ville:"
        '
        'TblClientsBindingSource
        '
        Me.TblClientsBindingSource.DataMember = "tblClients"
        Me.TblClientsBindingSource.DataSource = Me.Voyages2010DataSet
        '
        'Voyages2010DataSet
        '
        Me.Voyages2010DataSet.DataSetName = "Voyages2010DataSet"
        Me.Voyages2010DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblClientsTableAdapter
        '
        Me.TblClientsTableAdapter.ClearBeforeFill = True
        '
        'TblReservationsTableAdapter
        '
        Me.TblReservationsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tblClientsTableAdapter = Me.TblClientsTableAdapter
        Me.TableAdapterManager.tblReservationsTableAdapter = Me.TblReservationsTableAdapter
        Me.TableAdapterManager.tblTitresTableAdapter = Nothing
        Me.TableAdapterManager.tblVoyagesTableAdapter = Nothing
        Me.TableAdapterManager.tbUtilisateursTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = VB_TP2.Voyages2010DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'NumClientTextBox
        '
        Me.NumClientTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblClientsBindingSource, "NumClient", True))
        Me.NumClientTextBox.Enabled = False
        Me.NumClientTextBox.Location = New System.Drawing.Point(83, 81)
        Me.NumClientTextBox.Name = "NumClientTextBox"
        Me.NumClientTextBox.Size = New System.Drawing.Size(151, 20)
        Me.NumClientTextBox.TabIndex = 5
        '
        'TitreAbregeTextBox
        '
        Me.TitreAbregeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblClientsBindingSource, "TitreAbrege", True))
        Me.TitreAbregeTextBox.Enabled = False
        Me.TitreAbregeTextBox.Location = New System.Drawing.Point(83, 107)
        Me.TitreAbregeTextBox.Name = "TitreAbregeTextBox"
        Me.TitreAbregeTextBox.Size = New System.Drawing.Size(151, 20)
        Me.TitreAbregeTextBox.TabIndex = 7
        '
        'NomClientTextBox
        '
        Me.NomClientTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblClientsBindingSource, "NomClient", True))
        Me.NomClientTextBox.Enabled = False
        Me.NomClientTextBox.Location = New System.Drawing.Point(83, 133)
        Me.NomClientTextBox.Name = "NomClientTextBox"
        Me.NomClientTextBox.Size = New System.Drawing.Size(151, 20)
        Me.NomClientTextBox.TabIndex = 9
        '
        'PrenomTextBox
        '
        Me.PrenomTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblClientsBindingSource, "Prenom", True))
        Me.PrenomTextBox.Enabled = False
        Me.PrenomTextBox.Location = New System.Drawing.Point(83, 159)
        Me.PrenomTextBox.Name = "PrenomTextBox"
        Me.PrenomTextBox.Size = New System.Drawing.Size(151, 20)
        Me.PrenomTextBox.TabIndex = 11
        '
        'AdresseTextBox
        '
        Me.AdresseTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblClientsBindingSource, "Adresse", True))
        Me.AdresseTextBox.Enabled = False
        Me.AdresseTextBox.Location = New System.Drawing.Point(83, 185)
        Me.AdresseTextBox.Name = "AdresseTextBox"
        Me.AdresseTextBox.Size = New System.Drawing.Size(151, 20)
        Me.AdresseTextBox.TabIndex = 13
        '
        'TelephoneTextBox
        '
        Me.TelephoneTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblClientsBindingSource, "Telephone", True))
        Me.TelephoneTextBox.Enabled = False
        Me.TelephoneTextBox.Location = New System.Drawing.Point(83, 211)
        Me.TelephoneTextBox.Name = "TelephoneTextBox"
        Me.TelephoneTextBox.Size = New System.Drawing.Size(151, 20)
        Me.TelephoneTextBox.TabIndex = 15
        '
        'CodePostalTextBox
        '
        Me.CodePostalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblClientsBindingSource, "CodePostal", True))
        Me.CodePostalTextBox.Enabled = False
        Me.CodePostalTextBox.Location = New System.Drawing.Point(83, 237)
        Me.CodePostalTextBox.Name = "CodePostalTextBox"
        Me.CodePostalTextBox.Size = New System.Drawing.Size(151, 20)
        Me.CodePostalTextBox.TabIndex = 17
        '
        'VilleTextBox
        '
        Me.VilleTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblClientsBindingSource, "Ville", True))
        Me.VilleTextBox.Enabled = False
        Me.VilleTextBox.Location = New System.Drawing.Point(83, 263)
        Me.VilleTextBox.Name = "VilleTextBox"
        Me.VilleTextBox.Size = New System.Drawing.Size(151, 20)
        Me.VilleTextBox.TabIndex = 19
        '
        'TblReservationsDataGridView
        '
        Me.TblReservationsDataGridView.AutoGenerateColumns = False
        Me.TblReservationsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TblReservationsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.TblReservationsDataGridView.DataSource = Me.TblClientsReservationsBindingSource
        Me.TblReservationsDataGridView.Location = New System.Drawing.Point(301, 78)
        Me.TblReservationsDataGridView.Name = "TblReservationsDataGridView"
        Me.TblReservationsDataGridView.Size = New System.Drawing.Size(447, 220)
        Me.TblReservationsDataGridView.TabIndex = 19
        '
        'bSupprimerReservation
        '
        Me.bSupprimerReservation.BackColor = System.Drawing.Color.LightSteelBlue
        Me.bSupprimerReservation.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bSupprimerReservation.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bSupprimerReservation.Location = New System.Drawing.Point(564, 319)
        Me.bSupprimerReservation.Name = "bSupprimerReservation"
        Me.bSupprimerReservation.Size = New System.Drawing.Size(95, 24)
        Me.bSupprimerReservation.TabIndex = 23
        Me.bSupprimerReservation.Text = "&Supprimer"
        Me.bSupprimerReservation.UseVisualStyleBackColor = False
        '
        'bAjouterReservation
        '
        Me.bAjouterReservation.BackColor = System.Drawing.Color.LightSteelBlue
        Me.bAjouterReservation.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bAjouterReservation.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bAjouterReservation.Location = New System.Drawing.Point(431, 319)
        Me.bAjouterReservation.Name = "bAjouterReservation"
        Me.bAjouterReservation.Size = New System.Drawing.Size(95, 24)
        Me.bAjouterReservation.TabIndex = 20
        Me.bAjouterReservation.Text = "&Ajouter"
        Me.bAjouterReservation.UseVisualStyleBackColor = False
        '
        'bFirstClient
        '
        Me.bFirstClient.BackColor = System.Drawing.Color.LightSteelBlue
        Me.bFirstClient.Location = New System.Drawing.Point(12, 43)
        Me.bFirstClient.Name = "bFirstClient"
        Me.bFirstClient.Size = New System.Drawing.Size(50, 23)
        Me.bFirstClient.TabIndex = 21
        Me.bFirstClient.Text = "|<"
        Me.bFirstClient.UseVisualStyleBackColor = False
        '
        'bLastClient
        '
        Me.bLastClient.BackColor = System.Drawing.Color.LightSteelBlue
        Me.bLastClient.Location = New System.Drawing.Point(204, 43)
        Me.bLastClient.Name = "bLastClient"
        Me.bLastClient.Size = New System.Drawing.Size(48, 23)
        Me.bLastClient.TabIndex = 25
        Me.bLastClient.Text = ">|"
        Me.bLastClient.UseVisualStyleBackColor = False
        '
        'bPreviousClient
        '
        Me.bPreviousClient.BackColor = System.Drawing.Color.LightSteelBlue
        Me.bPreviousClient.Location = New System.Drawing.Point(68, 43)
        Me.bPreviousClient.Name = "bPreviousClient"
        Me.bPreviousClient.Size = New System.Drawing.Size(47, 23)
        Me.bPreviousClient.TabIndex = 22
        Me.bPreviousClient.Text = "<"
        Me.bPreviousClient.UseVisualStyleBackColor = False
        '
        'bNextClient
        '
        Me.bNextClient.BackColor = System.Drawing.Color.LightSteelBlue
        Me.bNextClient.Location = New System.Drawing.Point(153, 43)
        Me.bNextClient.Name = "bNextClient"
        Me.bNextClient.Size = New System.Drawing.Size(45, 23)
        Me.bNextClient.TabIndex = 24
        Me.bNextClient.Text = ">"
        Me.bNextClient.UseVisualStyleBackColor = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(874, 24)
        Me.MenuStrip1.TabIndex = 26
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GérerRéservationsToolStripMenuItem, Me.ModifierMotDePasseToolStripMenuItem})
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.MenuToolStripMenuItem.Text = "Menu"
        '
        'GérerRéservationsToolStripMenuItem
        '
        Me.GérerRéservationsToolStripMenuItem.Name = "GérerRéservationsToolStripMenuItem"
        Me.GérerRéservationsToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
        Me.GérerRéservationsToolStripMenuItem.Text = "Gérer Réservations"
        '
        'ModifierMotDePasseToolStripMenuItem
        '
        Me.ModifierMotDePasseToolStripMenuItem.Name = "ModifierMotDePasseToolStripMenuItem"
        Me.ModifierMotDePasseToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
        Me.ModifierMotDePasseToolStripMenuItem.Text = "Modifier Mot de passe"
        '
        'bQuitter
        '
        Me.bQuitter.BackColor = System.Drawing.Color.Black
        Me.bQuitter.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bQuitter.ForeColor = System.Drawing.Color.White
        Me.bQuitter.Location = New System.Drawing.Point(703, 491)
        Me.bQuitter.Name = "bQuitter"
        Me.bQuitter.Size = New System.Drawing.Size(150, 29)
        Me.bQuitter.TabIndex = 27
        Me.bQuitter.Text = "Quitter"
        Me.bQuitter.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.TblReservationsDataGridView)
        Me.Panel1.Controls.Add(Me.bSupprimerReservation)
        Me.Panel1.Controls.Add(Me.bLastClient)
        Me.Panel1.Controls.Add(Me.bAjouterReservation)
        Me.Panel1.Controls.Add(Me.VilleTextBox)
        Me.Panel1.Controls.Add(Me.bFirstClient)
        Me.Panel1.Controls.Add(VilleLabel)
        Me.Panel1.Controls.Add(Me.CodePostalTextBox)
        Me.Panel1.Controls.Add(Me.bPreviousClient)
        Me.Panel1.Controls.Add(CodePostalLabel)
        Me.Panel1.Controls.Add(Me.bNextClient)
        Me.Panel1.Controls.Add(Me.TelephoneTextBox)
        Me.Panel1.Controls.Add(NumClientLabel)
        Me.Panel1.Controls.Add(TelephoneLabel)
        Me.Panel1.Controls.Add(Me.NumClientTextBox)
        Me.Panel1.Controls.Add(Me.AdresseTextBox)
        Me.Panel1.Controls.Add(TitreAbregeLabel)
        Me.Panel1.Controls.Add(AdresseLabel)
        Me.Panel1.Controls.Add(Me.TitreAbregeTextBox)
        Me.Panel1.Controls.Add(Me.PrenomTextBox)
        Me.Panel1.Controls.Add(NomClientLabel)
        Me.Panel1.Controls.Add(PrenomLabel)
        Me.Panel1.Controls.Add(Me.NomClientTextBox)
        Me.Panel1.Location = New System.Drawing.Point(13, 37)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(793, 438)
        Me.Panel1.TabIndex = 28
        Me.Panel1.Visible = False
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "NumClient"
        Me.DataGridViewTextBoxColumn1.HeaderText = "NumClient"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "CodeVoyage"
        Me.DataGridViewTextBoxColumn2.HeaderText = "CodeVoyage"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "NombrePersonnes"
        Me.DataGridViewTextBoxColumn3.HeaderText = "NombrePersonnes"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "DateReservation"
        Me.DataGridViewTextBoxColumn4.HeaderText = "DateReservation"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'TblClientsReservationsBindingSource
        '
        Me.TblClientsReservationsBindingSource.DataMember = "tblClientsReservations"
        Me.TblClientsReservationsBindingSource.DataSource = Me.TblClientsBindingSource
        '
        'CommisFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(874, 548)
        Me.Controls.Add(Me.bQuitter)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "CommisFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Commis"
        CType(Me.TblClientsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Voyages2010DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblReservationsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.TblClientsReservationsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Voyages2010DataSet As VB_TP2.Voyages2010DataSet
    Friend WithEvents TblClientsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblClientsTableAdapter As VB_TP2.Voyages2010DataSetTableAdapters.tblClientsTableAdapter
    Friend WithEvents TblReservationsTableAdapter As VB_TP2.Voyages2010DataSetTableAdapters.tblReservationsTableAdapter
    Friend WithEvents TableAdapterManager As VB_TP2.Voyages2010DataSetTableAdapters.TableAdapterManager
    Friend WithEvents NumClientTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TitreAbregeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NomClientTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PrenomTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AdresseTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TelephoneTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CodePostalTextBox As System.Windows.Forms.TextBox
    Friend WithEvents VilleTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TblReservationsDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents TblClientsReservationsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents bSupprimerReservation As System.Windows.Forms.Button
    Friend WithEvents bAjouterReservation As System.Windows.Forms.Button
    Friend WithEvents bFirstClient As System.Windows.Forms.Button
    Friend WithEvents bLastClient As System.Windows.Forms.Button
    Friend WithEvents bPreviousClient As System.Windows.Forms.Button
    Friend WithEvents bNextClient As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents MenuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GérerRéservationsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModifierMotDePasseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents bQuitter As System.Windows.Forms.Button
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
End Class
