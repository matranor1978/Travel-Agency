<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GerantFrmVoyages
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
        Dim CodeVoyageLabel As System.Windows.Forms.Label
        Dim DestinationLabel As System.Windows.Forms.Label
        Dim DureeLabel As System.Windows.Forms.Label
        Dim NumCategorieLabel As System.Windows.Forms.Label
        Dim DescriptionLabel As System.Windows.Forms.Label
        Dim PrixLabel As System.Windows.Forms.Label
        Dim PromotionLabel As System.Windows.Forms.Label
        Dim PhotoLabel As System.Windows.Forms.Label
        Dim VignetteLabel As System.Windows.Forms.Label
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GerantFrmVoyages))
        Me.TblVoyagesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Voyages2010DataSet = New VB_TP2.Voyages2010DataSet()
        Me.TblClientsDataGridView = New System.Windows.Forms.DataGridView()
        Me.CodeVoyageDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DestinationDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DureeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumCategorieDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescriptionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrixDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PromotionDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.PhotoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VignetteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TblClientsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblClientsTableAdapter = New VB_TP2.Voyages2010DataSetTableAdapters.tblClientsTableAdapter()
        Me.TblVoyagesTableAdapter = New VB_TP2.Voyages2010DataSetTableAdapters.tblVoyagesTableAdapter()
        Me.bSauvegarderAffichage = New System.Windows.Forms.Button()
        Me.TabControlVoyage = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.CodeVoyageTextBox = New System.Windows.Forms.TextBox()
        Me.DestinationTextBox = New System.Windows.Forms.TextBox()
        Me.DureeTextBox = New System.Windows.Forms.TextBox()
        Me.NumCategorieTextBox = New System.Windows.Forms.TextBox()
        Me.DescriptionTextBox = New System.Windows.Forms.TextBox()
        Me.PrixTextBox = New System.Windows.Forms.TextBox()
        Me.PromotionCheckBox = New System.Windows.Forms.CheckBox()
        Me.PhotoTextBox = New System.Windows.Forms.TextBox()
        Me.VignetteTextBox = New System.Windows.Forms.TextBox()
        Me.bQuitter = New System.Windows.Forms.Button()
        Me.bChangerPreference = New System.Windows.Forms.Button()
        Me.TblVoyagesBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.TblVoyagesBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.TableAdapterManager1 = New VB_TP2.Voyages2010DataSetTableAdapters.TableAdapterManager()
        CodeVoyageLabel = New System.Windows.Forms.Label()
        DestinationLabel = New System.Windows.Forms.Label()
        DureeLabel = New System.Windows.Forms.Label()
        NumCategorieLabel = New System.Windows.Forms.Label()
        DescriptionLabel = New System.Windows.Forms.Label()
        PrixLabel = New System.Windows.Forms.Label()
        PromotionLabel = New System.Windows.Forms.Label()
        PhotoLabel = New System.Windows.Forms.Label()
        VignetteLabel = New System.Windows.Forms.Label()
        CType(Me.TblVoyagesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Voyages2010DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblClientsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblClientsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControlVoyage.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.TblVoyagesBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TblVoyagesBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'CodeVoyageLabel
        '
        CodeVoyageLabel.AutoSize = True
        CodeVoyageLabel.Location = New System.Drawing.Point(10, 29)
        CodeVoyageLabel.Name = "CodeVoyageLabel"
        CodeVoyageLabel.Size = New System.Drawing.Size(88, 13)
        CodeVoyageLabel.TabIndex = 18
        CodeVoyageLabel.Text = "Code du voyage:"
        '
        'DestinationLabel
        '
        DestinationLabel.AutoSize = True
        DestinationLabel.Location = New System.Drawing.Point(10, 55)
        DestinationLabel.Name = "DestinationLabel"
        DestinationLabel.Size = New System.Drawing.Size(63, 13)
        DestinationLabel.TabIndex = 20
        DestinationLabel.Text = "Déstination:"
        '
        'DureeLabel
        '
        DureeLabel.AutoSize = True
        DureeLabel.Location = New System.Drawing.Point(10, 81)
        DureeLabel.Name = "DureeLabel"
        DureeLabel.Size = New System.Drawing.Size(39, 13)
        DureeLabel.TabIndex = 22
        DureeLabel.Text = "Durée:"
        '
        'NumCategorieLabel
        '
        NumCategorieLabel.AutoSize = True
        NumCategorieLabel.Location = New System.Drawing.Point(10, 107)
        NumCategorieLabel.Name = "NumCategorieLabel"
        NumCategorieLabel.Size = New System.Drawing.Size(82, 13)
        NumCategorieLabel.TabIndex = 24
        NumCategorieLabel.Text = "Num. catégorie:"
        '
        'DescriptionLabel
        '
        DescriptionLabel.AutoSize = True
        DescriptionLabel.Location = New System.Drawing.Point(10, 133)
        DescriptionLabel.Name = "DescriptionLabel"
        DescriptionLabel.Size = New System.Drawing.Size(63, 13)
        DescriptionLabel.TabIndex = 26
        DescriptionLabel.Text = "Description:"
        '
        'PrixLabel
        '
        PrixLabel.AutoSize = True
        PrixLabel.Location = New System.Drawing.Point(10, 159)
        PrixLabel.Name = "PrixLabel"
        PrixLabel.Size = New System.Drawing.Size(27, 13)
        PrixLabel.TabIndex = 28
        PrixLabel.Text = "Prix:"
        '
        'PromotionLabel
        '
        PromotionLabel.AutoSize = True
        PromotionLabel.Location = New System.Drawing.Point(10, 187)
        PromotionLabel.Name = "PromotionLabel"
        PromotionLabel.Size = New System.Drawing.Size(57, 13)
        PromotionLabel.TabIndex = 30
        PromotionLabel.Text = "Promotion:"
        '
        'PhotoLabel
        '
        PhotoLabel.AutoSize = True
        PhotoLabel.Location = New System.Drawing.Point(10, 215)
        PhotoLabel.Name = "PhotoLabel"
        PhotoLabel.Size = New System.Drawing.Size(38, 13)
        PhotoLabel.TabIndex = 32
        PhotoLabel.Text = "Photo:"
        '
        'VignetteLabel
        '
        VignetteLabel.AutoSize = True
        VignetteLabel.Location = New System.Drawing.Point(10, 241)
        VignetteLabel.Name = "VignetteLabel"
        VignetteLabel.Size = New System.Drawing.Size(49, 13)
        VignetteLabel.TabIndex = 34
        VignetteLabel.Text = "Vignette:"
        '
        'TblVoyagesBindingSource
        '
        Me.TblVoyagesBindingSource.DataMember = "tblVoyages"
        Me.TblVoyagesBindingSource.DataSource = Me.Voyages2010DataSet
        '
        'Voyages2010DataSet
        '
        Me.Voyages2010DataSet.DataSetName = "Voyages2010DataSet"
        Me.Voyages2010DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblClientsDataGridView
        '
        Me.TblClientsDataGridView.AllowUserToAddRows = False
        Me.TblClientsDataGridView.AllowUserToDeleteRows = False
        Me.TblClientsDataGridView.AutoGenerateColumns = False
        Me.TblClientsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TblClientsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CodeVoyageDataGridViewTextBoxColumn, Me.DestinationDataGridViewTextBoxColumn, Me.DureeDataGridViewTextBoxColumn, Me.NumCategorieDataGridViewTextBoxColumn, Me.DescriptionDataGridViewTextBoxColumn, Me.PrixDataGridViewTextBoxColumn, Me.PromotionDataGridViewCheckBoxColumn, Me.PhotoDataGridViewTextBoxColumn, Me.VignetteDataGridViewTextBoxColumn})
        Me.TblClientsDataGridView.DataSource = Me.TblVoyagesBindingSource
        Me.TblClientsDataGridView.Location = New System.Drawing.Point(6, 19)
        Me.TblClientsDataGridView.Name = "TblClientsDataGridView"
        Me.TblClientsDataGridView.Size = New System.Drawing.Size(845, 265)
        Me.TblClientsDataGridView.TabIndex = 2
        '
        'CodeVoyageDataGridViewTextBoxColumn
        '
        Me.CodeVoyageDataGridViewTextBoxColumn.DataPropertyName = "CodeVoyage"
        Me.CodeVoyageDataGridViewTextBoxColumn.HeaderText = "CodeVoyage"
        Me.CodeVoyageDataGridViewTextBoxColumn.Name = "CodeVoyageDataGridViewTextBoxColumn"
        Me.CodeVoyageDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DestinationDataGridViewTextBoxColumn
        '
        Me.DestinationDataGridViewTextBoxColumn.DataPropertyName = "Destination"
        Me.DestinationDataGridViewTextBoxColumn.HeaderText = "Destination"
        Me.DestinationDataGridViewTextBoxColumn.Name = "DestinationDataGridViewTextBoxColumn"
        Me.DestinationDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DureeDataGridViewTextBoxColumn
        '
        Me.DureeDataGridViewTextBoxColumn.DataPropertyName = "Duree"
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DureeDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle5
        Me.DureeDataGridViewTextBoxColumn.HeaderText = "Duree"
        Me.DureeDataGridViewTextBoxColumn.Name = "DureeDataGridViewTextBoxColumn"
        '
        'NumCategorieDataGridViewTextBoxColumn
        '
        Me.NumCategorieDataGridViewTextBoxColumn.DataPropertyName = "NumCategorie"
        Me.NumCategorieDataGridViewTextBoxColumn.HeaderText = "NumCategorie"
        Me.NumCategorieDataGridViewTextBoxColumn.Name = "NumCategorieDataGridViewTextBoxColumn"
        Me.NumCategorieDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DescriptionDataGridViewTextBoxColumn
        '
        Me.DescriptionDataGridViewTextBoxColumn.DataPropertyName = "Description"
        Me.DescriptionDataGridViewTextBoxColumn.HeaderText = "Description"
        Me.DescriptionDataGridViewTextBoxColumn.Name = "DescriptionDataGridViewTextBoxColumn"
        Me.DescriptionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PrixDataGridViewTextBoxColumn
        '
        Me.PrixDataGridViewTextBoxColumn.DataPropertyName = "Prix"
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PrixDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle6
        Me.PrixDataGridViewTextBoxColumn.HeaderText = "Prix"
        Me.PrixDataGridViewTextBoxColumn.Name = "PrixDataGridViewTextBoxColumn"
        '
        'PromotionDataGridViewCheckBoxColumn
        '
        Me.PromotionDataGridViewCheckBoxColumn.DataPropertyName = "Promotion"
        Me.PromotionDataGridViewCheckBoxColumn.HeaderText = "Promotion"
        Me.PromotionDataGridViewCheckBoxColumn.Name = "PromotionDataGridViewCheckBoxColumn"
        Me.PromotionDataGridViewCheckBoxColumn.ReadOnly = True
        '
        'PhotoDataGridViewTextBoxColumn
        '
        Me.PhotoDataGridViewTextBoxColumn.DataPropertyName = "Photo"
        Me.PhotoDataGridViewTextBoxColumn.HeaderText = "Photo"
        Me.PhotoDataGridViewTextBoxColumn.Name = "PhotoDataGridViewTextBoxColumn"
        Me.PhotoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'VignetteDataGridViewTextBoxColumn
        '
        Me.VignetteDataGridViewTextBoxColumn.DataPropertyName = "Vignette"
        Me.VignetteDataGridViewTextBoxColumn.HeaderText = "Vignette"
        Me.VignetteDataGridViewTextBoxColumn.Name = "VignetteDataGridViewTextBoxColumn"
        Me.VignetteDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TblClientsBindingSource
        '
        Me.TblClientsBindingSource.DataMember = "tblClients"
        Me.TblClientsBindingSource.DataSource = Me.Voyages2010DataSet
        '
        'TblClientsTableAdapter
        '
        Me.TblClientsTableAdapter.ClearBeforeFill = True
        '
        'TblVoyagesTableAdapter
        '
        Me.TblVoyagesTableAdapter.ClearBeforeFill = True
        '
        'bSauvegarderAffichage
        '
        Me.bSauvegarderAffichage.Location = New System.Drawing.Point(726, 360)
        Me.bSauvegarderAffichage.Name = "bSauvegarderAffichage"
        Me.bSauvegarderAffichage.Size = New System.Drawing.Size(183, 23)
        Me.bSauvegarderAffichage.TabIndex = 5
        Me.bSauvegarderAffichage.Text = "Sauvegarder Choix Affichage"
        Me.bSauvegarderAffichage.UseVisualStyleBackColor = True
        '
        'TabControlVoyage
        '
        Me.TabControlVoyage.Controls.Add(Me.TabPage1)
        Me.TabControlVoyage.Controls.Add(Me.TabPage2)
        Me.TabControlVoyage.Location = New System.Drawing.Point(27, 44)
        Me.TabControlVoyage.Name = "TabControlVoyage"
        Me.TabControlVoyage.SelectedIndex = 0
        Me.TabControlVoyage.Size = New System.Drawing.Size(886, 310)
        Me.TabControlVoyage.TabIndex = 6
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.TblClientsDataGridView)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(878, 284)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "DataGridView"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(CodeVoyageLabel)
        Me.TabPage2.Controls.Add(Me.CodeVoyageTextBox)
        Me.TabPage2.Controls.Add(DestinationLabel)
        Me.TabPage2.Controls.Add(Me.DestinationTextBox)
        Me.TabPage2.Controls.Add(DureeLabel)
        Me.TabPage2.Controls.Add(Me.DureeTextBox)
        Me.TabPage2.Controls.Add(NumCategorieLabel)
        Me.TabPage2.Controls.Add(Me.NumCategorieTextBox)
        Me.TabPage2.Controls.Add(DescriptionLabel)
        Me.TabPage2.Controls.Add(Me.DescriptionTextBox)
        Me.TabPage2.Controls.Add(PrixLabel)
        Me.TabPage2.Controls.Add(Me.PrixTextBox)
        Me.TabPage2.Controls.Add(PromotionLabel)
        Me.TabPage2.Controls.Add(Me.PromotionCheckBox)
        Me.TabPage2.Controls.Add(PhotoLabel)
        Me.TabPage2.Controls.Add(Me.PhotoTextBox)
        Me.TabPage2.Controls.Add(VignetteLabel)
        Me.TabPage2.Controls.Add(Me.VignetteTextBox)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(878, 284)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "TextBox/ComboBox"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'CodeVoyageTextBox
        '
        Me.CodeVoyageTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblVoyagesBindingSource, "CodeVoyage", True))
        Me.CodeVoyageTextBox.Enabled = False
        Me.CodeVoyageTextBox.Location = New System.Drawing.Point(103, 26)
        Me.CodeVoyageTextBox.Name = "CodeVoyageTextBox"
        Me.CodeVoyageTextBox.Size = New System.Drawing.Size(104, 20)
        Me.CodeVoyageTextBox.TabIndex = 19
        '
        'DestinationTextBox
        '
        Me.DestinationTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblVoyagesBindingSource, "Destination", True))
        Me.DestinationTextBox.Enabled = False
        Me.DestinationTextBox.Location = New System.Drawing.Point(103, 52)
        Me.DestinationTextBox.Name = "DestinationTextBox"
        Me.DestinationTextBox.Size = New System.Drawing.Size(104, 20)
        Me.DestinationTextBox.TabIndex = 21
        '
        'DureeTextBox
        '
        Me.DureeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblVoyagesBindingSource, "Duree", True))
        Me.DureeTextBox.Location = New System.Drawing.Point(103, 78)
        Me.DureeTextBox.Name = "DureeTextBox"
        Me.DureeTextBox.Size = New System.Drawing.Size(104, 20)
        Me.DureeTextBox.TabIndex = 23
        '
        'NumCategorieTextBox
        '
        Me.NumCategorieTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblVoyagesBindingSource, "NumCategorie", True))
        Me.NumCategorieTextBox.Enabled = False
        Me.NumCategorieTextBox.Location = New System.Drawing.Point(103, 104)
        Me.NumCategorieTextBox.Name = "NumCategorieTextBox"
        Me.NumCategorieTextBox.Size = New System.Drawing.Size(104, 20)
        Me.NumCategorieTextBox.TabIndex = 25
        '
        'DescriptionTextBox
        '
        Me.DescriptionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblVoyagesBindingSource, "Description", True))
        Me.DescriptionTextBox.Enabled = False
        Me.DescriptionTextBox.Location = New System.Drawing.Point(103, 130)
        Me.DescriptionTextBox.Name = "DescriptionTextBox"
        Me.DescriptionTextBox.Size = New System.Drawing.Size(766, 20)
        Me.DescriptionTextBox.TabIndex = 27
        '
        'PrixTextBox
        '
        Me.PrixTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblVoyagesBindingSource, "Prix", True))
        Me.PrixTextBox.Location = New System.Drawing.Point(103, 156)
        Me.PrixTextBox.Name = "PrixTextBox"
        Me.PrixTextBox.Size = New System.Drawing.Size(104, 20)
        Me.PrixTextBox.TabIndex = 29
        '
        'PromotionCheckBox
        '
        Me.PromotionCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.TblVoyagesBindingSource, "Promotion", True))
        Me.PromotionCheckBox.Enabled = False
        Me.PromotionCheckBox.Location = New System.Drawing.Point(103, 182)
        Me.PromotionCheckBox.Name = "PromotionCheckBox"
        Me.PromotionCheckBox.Size = New System.Drawing.Size(104, 24)
        Me.PromotionCheckBox.TabIndex = 31
        Me.PromotionCheckBox.UseVisualStyleBackColor = True
        '
        'PhotoTextBox
        '
        Me.PhotoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblVoyagesBindingSource, "Photo", True))
        Me.PhotoTextBox.Enabled = False
        Me.PhotoTextBox.Location = New System.Drawing.Point(103, 212)
        Me.PhotoTextBox.Name = "PhotoTextBox"
        Me.PhotoTextBox.Size = New System.Drawing.Size(104, 20)
        Me.PhotoTextBox.TabIndex = 33
        '
        'VignetteTextBox
        '
        Me.VignetteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblVoyagesBindingSource, "Vignette", True))
        Me.VignetteTextBox.Enabled = False
        Me.VignetteTextBox.Location = New System.Drawing.Point(103, 238)
        Me.VignetteTextBox.Name = "VignetteTextBox"
        Me.VignetteTextBox.Size = New System.Drawing.Size(104, 20)
        Me.VignetteTextBox.TabIndex = 35
        '
        'bQuitter
        '
        Me.bQuitter.BackColor = System.Drawing.Color.Black
        Me.bQuitter.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bQuitter.ForeColor = System.Drawing.Color.White
        Me.bQuitter.Location = New System.Drawing.Point(892, 399)
        Me.bQuitter.Name = "bQuitter"
        Me.bQuitter.Size = New System.Drawing.Size(150, 29)
        Me.bQuitter.TabIndex = 29
        Me.bQuitter.Text = "Quitter"
        Me.bQuitter.UseVisualStyleBackColor = False
        '
        'bChangerPreference
        '
        Me.bChangerPreference.Location = New System.Drawing.Point(497, 360)
        Me.bChangerPreference.Name = "bChangerPreference"
        Me.bChangerPreference.Size = New System.Drawing.Size(181, 23)
        Me.bChangerPreference.TabIndex = 30
        Me.bChangerPreference.Text = "Changer affichage"
        Me.bChangerPreference.UseVisualStyleBackColor = True
        '
        'TblVoyagesBindingNavigator
        '
        Me.TblVoyagesBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.TblVoyagesBindingNavigator.BindingSource = Me.TblVoyagesBindingSource
        Me.TblVoyagesBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.TblVoyagesBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.TblVoyagesBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.TblVoyagesBindingNavigatorSaveItem})
        Me.TblVoyagesBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.TblVoyagesBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.TblVoyagesBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.TblVoyagesBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.TblVoyagesBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.TblVoyagesBindingNavigator.Name = "TblVoyagesBindingNavigator"
        Me.TblVoyagesBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.TblVoyagesBindingNavigator.Size = New System.Drawing.Size(1054, 25)
        Me.TblVoyagesBindingNavigator.TabIndex = 31
        Me.TblVoyagesBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Ajouter nouveau"
        Me.BindingNavigatorAddNewItem.Visible = False
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(37, 22)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Nombre total d'éléments"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Supprimer"
        Me.BindingNavigatorDeleteItem.Visible = False
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Placer en premier"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Déplacer vers le haut"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Position actuelle"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Déplacer vers le bas"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Placer en dernier"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'TblVoyagesBindingNavigatorSaveItem
        '
        Me.TblVoyagesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TblVoyagesBindingNavigatorSaveItem.Image = CType(resources.GetObject("TblVoyagesBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.TblVoyagesBindingNavigatorSaveItem.Name = "TblVoyagesBindingNavigatorSaveItem"
        Me.TblVoyagesBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.TblVoyagesBindingNavigatorSaveItem.Text = "Enregistrer les données"
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.tblClientsTableAdapter = Me.TblClientsTableAdapter
        Me.TableAdapterManager1.tblReservationsTableAdapter = Nothing
        Me.TableAdapterManager1.tblTitresTableAdapter = Nothing
        Me.TableAdapterManager1.tblVoyagesTableAdapter = Me.TblVoyagesTableAdapter
        Me.TableAdapterManager1.tbUtilisateursTableAdapter = Nothing
        Me.TableAdapterManager1.UpdateOrder = VB_TP2.Voyages2010DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'GerantFrmVoyages
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1054, 440)
        Me.Controls.Add(Me.TblVoyagesBindingNavigator)
        Me.Controls.Add(Me.bChangerPreference)
        Me.Controls.Add(Me.bQuitter)
        Me.Controls.Add(Me.TabControlVoyage)
        Me.Controls.Add(Me.bSauvegarderAffichage)
        Me.Name = "GerantFrmVoyages"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GerantFrmVoyages"
        CType(Me.TblVoyagesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Voyages2010DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblClientsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblClientsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControlVoyage.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.TblVoyagesBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TblVoyagesBindingNavigator.ResumeLayout(False)
        Me.TblVoyagesBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TblClientsDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents Voyages2010DataSet As VB_TP2.Voyages2010DataSet
    Friend WithEvents TblClientsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblClientsTableAdapter As VB_TP2.Voyages2010DataSetTableAdapters.tblClientsTableAdapter
    Friend WithEvents TblVoyagesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblVoyagesTableAdapter As VB_TP2.Voyages2010DataSetTableAdapters.tblVoyagesTableAdapter
    Friend WithEvents bSauvegarderAffichage As System.Windows.Forms.Button
    Friend WithEvents TabControlVoyage As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents CodeVoyageTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DestinationTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DureeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NumCategorieTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DescriptionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PrixTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PromotionCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents PhotoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents VignetteTextBox As System.Windows.Forms.TextBox
    Friend WithEvents bQuitter As System.Windows.Forms.Button
    Friend WithEvents CodeVoyageDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DestinationDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DureeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NumCategorieDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescriptionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PrixDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PromotionDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents PhotoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VignetteDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents bChangerPreference As System.Windows.Forms.Button
    Friend WithEvents TblVoyagesBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents TblVoyagesBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents TableAdapterManager1 As VB_TP2.Voyages2010DataSetTableAdapters.TableAdapterManager
End Class
