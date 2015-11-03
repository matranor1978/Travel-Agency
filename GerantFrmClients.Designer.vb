<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GerantFrmClients
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GerantFrmClients))
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TblClientsBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.TblClientsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Voyages2010DataSet = New VB_TP2.Voyages2010DataSet()
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
        Me.TblClientsBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.tabControlClient = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TblClientsDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.NumClientTextBox = New System.Windows.Forms.TextBox()
        Me.TitreAbregeTextBox = New System.Windows.Forms.TextBox()
        Me.NomClientTextBox = New System.Windows.Forms.TextBox()
        Me.PrenomTextBox = New System.Windows.Forms.TextBox()
        Me.AdresseTextBox = New System.Windows.Forms.TextBox()
        Me.TelephoneTextBox = New System.Windows.Forms.TextBox()
        Me.CodePostalTextBox = New System.Windows.Forms.TextBox()
        Me.VilleTextBox = New System.Windows.Forms.TextBox()
        Me.TblClientsTableAdapter = New VB_TP2.Voyages2010DataSetTableAdapters.tblClientsTableAdapter()
        Me.TableAdapterManager = New VB_TP2.Voyages2010DataSetTableAdapters.TableAdapterManager()
        Me.bSauvegarderAffichage = New System.Windows.Forms.Button()
        Me.bQuitter = New System.Windows.Forms.Button()
        Me.bChangerPreference = New System.Windows.Forms.Button()
        NumClientLabel = New System.Windows.Forms.Label()
        TitreAbregeLabel = New System.Windows.Forms.Label()
        NomClientLabel = New System.Windows.Forms.Label()
        PrenomLabel = New System.Windows.Forms.Label()
        AdresseLabel = New System.Windows.Forms.Label()
        TelephoneLabel = New System.Windows.Forms.Label()
        CodePostalLabel = New System.Windows.Forms.Label()
        VilleLabel = New System.Windows.Forms.Label()
        CType(Me.TblClientsBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TblClientsBindingNavigator.SuspendLayout()
        CType(Me.TblClientsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Voyages2010DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabControlClient.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.TblClientsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'NumClientLabel
        '
        NumClientLabel.AutoSize = True
        NumClientLabel.Location = New System.Drawing.Point(16, 30)
        NumClientLabel.Name = "NumClientLabel"
        NumClientLabel.Size = New System.Drawing.Size(61, 13)
        NumClientLabel.TabIndex = 0
        NumClientLabel.Text = "Num Client:"
        '
        'TitreAbregeLabel
        '
        TitreAbregeLabel.AutoSize = True
        TitreAbregeLabel.Location = New System.Drawing.Point(16, 56)
        TitreAbregeLabel.Name = "TitreAbregeLabel"
        TitreAbregeLabel.Size = New System.Drawing.Size(68, 13)
        TitreAbregeLabel.TabIndex = 2
        TitreAbregeLabel.Text = "Titre Abrege:"
        '
        'NomClientLabel
        '
        NomClientLabel.AutoSize = True
        NomClientLabel.Location = New System.Drawing.Point(16, 82)
        NomClientLabel.Name = "NomClientLabel"
        NomClientLabel.Size = New System.Drawing.Size(61, 13)
        NomClientLabel.TabIndex = 4
        NomClientLabel.Text = "Nom Client:"
        '
        'PrenomLabel
        '
        PrenomLabel.AutoSize = True
        PrenomLabel.Location = New System.Drawing.Point(16, 108)
        PrenomLabel.Name = "PrenomLabel"
        PrenomLabel.Size = New System.Drawing.Size(46, 13)
        PrenomLabel.TabIndex = 6
        PrenomLabel.Text = "Prenom:"
        '
        'AdresseLabel
        '
        AdresseLabel.AutoSize = True
        AdresseLabel.Location = New System.Drawing.Point(16, 134)
        AdresseLabel.Name = "AdresseLabel"
        AdresseLabel.Size = New System.Drawing.Size(48, 13)
        AdresseLabel.TabIndex = 8
        AdresseLabel.Text = "Adresse:"
        '
        'TelephoneLabel
        '
        TelephoneLabel.AutoSize = True
        TelephoneLabel.Location = New System.Drawing.Point(16, 160)
        TelephoneLabel.Name = "TelephoneLabel"
        TelephoneLabel.Size = New System.Drawing.Size(61, 13)
        TelephoneLabel.TabIndex = 10
        TelephoneLabel.Text = "Telephone:"
        '
        'CodePostalLabel
        '
        CodePostalLabel.AutoSize = True
        CodePostalLabel.Location = New System.Drawing.Point(16, 186)
        CodePostalLabel.Name = "CodePostalLabel"
        CodePostalLabel.Size = New System.Drawing.Size(67, 13)
        CodePostalLabel.TabIndex = 12
        CodePostalLabel.Text = "Code Postal:"
        '
        'VilleLabel
        '
        VilleLabel.AutoSize = True
        VilleLabel.Location = New System.Drawing.Point(16, 212)
        VilleLabel.Name = "VilleLabel"
        VilleLabel.Size = New System.Drawing.Size(29, 13)
        VilleLabel.TabIndex = 14
        VilleLabel.Text = "Ville:"
        '
        'TblClientsBindingNavigator
        '
        Me.TblClientsBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.TblClientsBindingNavigator.BindingSource = Me.TblClientsBindingSource
        Me.TblClientsBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.TblClientsBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.TblClientsBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.TblClientsBindingNavigatorSaveItem, Me.BindingNavigatorDeleteItem})
        Me.TblClientsBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.TblClientsBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.TblClientsBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.TblClientsBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.TblClientsBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.TblClientsBindingNavigator.Name = "TblClientsBindingNavigator"
        Me.TblClientsBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.TblClientsBindingNavigator.Size = New System.Drawing.Size(1012, 25)
        Me.TblClientsBindingNavigator.TabIndex = 1
        Me.TblClientsBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Ajouter nouveau"
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
        'TblClientsBindingNavigatorSaveItem
        '
        Me.TblClientsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TblClientsBindingNavigatorSaveItem.Image = CType(resources.GetObject("TblClientsBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.TblClientsBindingNavigatorSaveItem.Name = "TblClientsBindingNavigatorSaveItem"
        Me.TblClientsBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.TblClientsBindingNavigatorSaveItem.Text = "Enregistrer les données"
        '
        'tabControlClient
        '
        Me.tabControlClient.Controls.Add(Me.TabPage1)
        Me.tabControlClient.Controls.Add(Me.TabPage2)
        Me.tabControlClient.Location = New System.Drawing.Point(55, 56)
        Me.tabControlClient.Name = "tabControlClient"
        Me.tabControlClient.SelectedIndex = 0
        Me.tabControlClient.Size = New System.Drawing.Size(886, 437)
        Me.tabControlClient.TabIndex = 3
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TabPage1.Controls.Add(Me.TblClientsDataGridView)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(878, 411)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "DataGridView"
        '
        'TblClientsDataGridView
        '
        Me.TblClientsDataGridView.AllowUserToDeleteRows = False
        Me.TblClientsDataGridView.AutoGenerateColumns = False
        Me.TblClientsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TblClientsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8})
        Me.TblClientsDataGridView.DataSource = Me.TblClientsBindingSource
        Me.TblClientsDataGridView.Location = New System.Drawing.Point(20, 25)
        Me.TblClientsDataGridView.Name = "TblClientsDataGridView"
        Me.TblClientsDataGridView.Size = New System.Drawing.Size(839, 349)
        Me.TblClientsDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "NumClient"
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewTextBoxColumn1.HeaderText = "NumClient"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "TitreAbrege"
        Me.DataGridViewTextBoxColumn2.HeaderText = "TitreAbrege"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "NomClient"
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DataGridViewTextBoxColumn3.DefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridViewTextBoxColumn3.HeaderText = "NomClient"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Prenom"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Prenom"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Adresse"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Adresse"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Telephone"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Telephone"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "CodePostal"
        Me.DataGridViewTextBoxColumn7.HeaderText = "CodePostal"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Ville"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Ville"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'TabPage2
        '
        Me.TabPage2.AutoScroll = True
        Me.TabPage2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TabPage2.Controls.Add(NumClientLabel)
        Me.TabPage2.Controls.Add(Me.NumClientTextBox)
        Me.TabPage2.Controls.Add(TitreAbregeLabel)
        Me.TabPage2.Controls.Add(Me.TitreAbregeTextBox)
        Me.TabPage2.Controls.Add(NomClientLabel)
        Me.TabPage2.Controls.Add(Me.NomClientTextBox)
        Me.TabPage2.Controls.Add(PrenomLabel)
        Me.TabPage2.Controls.Add(Me.PrenomTextBox)
        Me.TabPage2.Controls.Add(AdresseLabel)
        Me.TabPage2.Controls.Add(Me.AdresseTextBox)
        Me.TabPage2.Controls.Add(TelephoneLabel)
        Me.TabPage2.Controls.Add(Me.TelephoneTextBox)
        Me.TabPage2.Controls.Add(CodePostalLabel)
        Me.TabPage2.Controls.Add(Me.CodePostalTextBox)
        Me.TabPage2.Controls.Add(VilleLabel)
        Me.TabPage2.Controls.Add(Me.VilleTextBox)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(878, 411)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "TextBox/ComboBox"
        '
        'NumClientTextBox
        '
        Me.NumClientTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblClientsBindingSource, "NumClient", True))
        Me.NumClientTextBox.Enabled = False
        Me.NumClientTextBox.Location = New System.Drawing.Point(90, 27)
        Me.NumClientTextBox.Name = "NumClientTextBox"
        Me.NumClientTextBox.Size = New System.Drawing.Size(155, 20)
        Me.NumClientTextBox.TabIndex = 1
        '
        'TitreAbregeTextBox
        '
        Me.TitreAbregeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblClientsBindingSource, "TitreAbrege", True))
        Me.TitreAbregeTextBox.Location = New System.Drawing.Point(90, 53)
        Me.TitreAbregeTextBox.Name = "TitreAbregeTextBox"
        Me.TitreAbregeTextBox.Size = New System.Drawing.Size(58, 20)
        Me.TitreAbregeTextBox.TabIndex = 3
        '
        'NomClientTextBox
        '
        Me.NomClientTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblClientsBindingSource, "NomClient", True))
        Me.NomClientTextBox.Enabled = False
        Me.NomClientTextBox.Location = New System.Drawing.Point(90, 79)
        Me.NomClientTextBox.Name = "NomClientTextBox"
        Me.NomClientTextBox.Size = New System.Drawing.Size(155, 20)
        Me.NomClientTextBox.TabIndex = 5
        '
        'PrenomTextBox
        '
        Me.PrenomTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblClientsBindingSource, "Prenom", True))
        Me.PrenomTextBox.Location = New System.Drawing.Point(90, 105)
        Me.PrenomTextBox.Name = "PrenomTextBox"
        Me.PrenomTextBox.Size = New System.Drawing.Size(155, 20)
        Me.PrenomTextBox.TabIndex = 7
        '
        'AdresseTextBox
        '
        Me.AdresseTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblClientsBindingSource, "Adresse", True))
        Me.AdresseTextBox.Location = New System.Drawing.Point(90, 131)
        Me.AdresseTextBox.Name = "AdresseTextBox"
        Me.AdresseTextBox.Size = New System.Drawing.Size(155, 20)
        Me.AdresseTextBox.TabIndex = 9
        '
        'TelephoneTextBox
        '
        Me.TelephoneTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblClientsBindingSource, "Telephone", True))
        Me.TelephoneTextBox.Location = New System.Drawing.Point(90, 157)
        Me.TelephoneTextBox.Name = "TelephoneTextBox"
        Me.TelephoneTextBox.Size = New System.Drawing.Size(155, 20)
        Me.TelephoneTextBox.TabIndex = 11
        '
        'CodePostalTextBox
        '
        Me.CodePostalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblClientsBindingSource, "CodePostal", True))
        Me.CodePostalTextBox.Location = New System.Drawing.Point(90, 183)
        Me.CodePostalTextBox.Name = "CodePostalTextBox"
        Me.CodePostalTextBox.Size = New System.Drawing.Size(58, 20)
        Me.CodePostalTextBox.TabIndex = 13
        '
        'VilleTextBox
        '
        Me.VilleTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblClientsBindingSource, "Ville", True))
        Me.VilleTextBox.Location = New System.Drawing.Point(90, 209)
        Me.VilleTextBox.Name = "VilleTextBox"
        Me.VilleTextBox.Size = New System.Drawing.Size(155, 20)
        Me.VilleTextBox.TabIndex = 15
        '
        'TblClientsTableAdapter
        '
        Me.TblClientsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tblClientsTableAdapter = Me.TblClientsTableAdapter
        Me.TableAdapterManager.tblReservationsTableAdapter = Nothing
        Me.TableAdapterManager.tblTitresTableAdapter = Nothing
        Me.TableAdapterManager.tblVoyagesTableAdapter = Nothing
        Me.TableAdapterManager.tbUtilisateursTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = VB_TP2.Voyages2010DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'bSauvegarderAffichage
        '
        Me.bSauvegarderAffichage.Location = New System.Drawing.Point(754, 499)
        Me.bSauvegarderAffichage.Name = "bSauvegarderAffichage"
        Me.bSauvegarderAffichage.Size = New System.Drawing.Size(183, 23)
        Me.bSauvegarderAffichage.TabIndex = 6
        Me.bSauvegarderAffichage.Text = "Sauvegarder Choix Affichage"
        Me.bSauvegarderAffichage.UseVisualStyleBackColor = True
        '
        'bQuitter
        '
        Me.bQuitter.BackColor = System.Drawing.Color.Black
        Me.bQuitter.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bQuitter.ForeColor = System.Drawing.Color.White
        Me.bQuitter.Location = New System.Drawing.Point(850, 533)
        Me.bQuitter.Name = "bQuitter"
        Me.bQuitter.Size = New System.Drawing.Size(150, 29)
        Me.bQuitter.TabIndex = 28
        Me.bQuitter.Text = "Quitter"
        Me.bQuitter.UseVisualStyleBackColor = False
        '
        'bChangerPreference
        '
        Me.bChangerPreference.Location = New System.Drawing.Point(525, 499)
        Me.bChangerPreference.Name = "bChangerPreference"
        Me.bChangerPreference.Size = New System.Drawing.Size(181, 23)
        Me.bChangerPreference.TabIndex = 29
        Me.bChangerPreference.Text = "Changer affichage"
        Me.bChangerPreference.UseVisualStyleBackColor = True
        '
        'GerantFrmClients
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1012, 574)
        Me.Controls.Add(Me.bChangerPreference)
        Me.Controls.Add(Me.bQuitter)
        Me.Controls.Add(Me.bSauvegarderAffichage)
        Me.Controls.Add(Me.tabControlClient)
        Me.Controls.Add(Me.TblClientsBindingNavigator)
        Me.Name = "GerantFrmClients"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GerantFrmClients"
        CType(Me.TblClientsBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TblClientsBindingNavigator.ResumeLayout(False)
        Me.TblClientsBindingNavigator.PerformLayout()
        CType(Me.TblClientsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Voyages2010DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabControlClient.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.TblClientsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TblClientsBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents TblClientsBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents tabControlClient As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents Voyages2010DataSet As VB_TP2.Voyages2010DataSet
    Friend WithEvents TblClientsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblClientsTableAdapter As VB_TP2.Voyages2010DataSetTableAdapters.tblClientsTableAdapter
    Friend WithEvents TableAdapterManager As VB_TP2.Voyages2010DataSetTableAdapters.TableAdapterManager
    Friend WithEvents TblClientsDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents NumClientTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TitreAbregeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NomClientTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PrenomTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AdresseTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TelephoneTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CodePostalTextBox As System.Windows.Forms.TextBox
    Friend WithEvents VilleTextBox As System.Windows.Forms.TextBox
    Friend WithEvents bSauvegarderAffichage As System.Windows.Forms.Button
    Friend WithEvents bQuitter As System.Windows.Forms.Button
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents bChangerPreference As System.Windows.Forms.Button
End Class
