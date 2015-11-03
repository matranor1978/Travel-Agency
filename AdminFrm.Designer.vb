<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminFrm
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
        Me.TbUtilisateursBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Voyages2010DataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Voyages2010DataSet = New VB_TP2.Voyages2010DataSet()
        Me.TblClientsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblClientsTableAdapter = New VB_TP2.Voyages2010DataSetTableAdapters.tblClientsTableAdapter()
        Me.TbUtilisateursTableAdapter = New VB_TP2.Voyages2010DataSetTableAdapters.tbUtilisateursTableAdapter()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbDataGrid = New System.Windows.Forms.RadioButton()
        Me.rbTextBox = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rbCommis = New System.Windows.Forms.RadioButton()
        Me.rbGerant = New System.Windows.Forms.RadioButton()
        Me.tPassword = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tNom = New System.Windows.Forms.TextBox()
        Me.bAjouter = New System.Windows.Forms.Button()
        Me.bSupprimer = New System.Windows.Forms.Button()
        Me.bFirstUser = New System.Windows.Forms.Button()
        Me.bPreviousUser = New System.Windows.Forms.Button()
        Me.bNextUser = New System.Windows.Forms.Button()
        Me.bLastUser = New System.Windows.Forms.Button()
        Me.lbUtilisateurs = New System.Windows.Forms.ListBox()
        Me.bQuitter = New System.Windows.Forms.Button()
        CType(Me.TbUtilisateursBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Voyages2010DataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Voyages2010DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblClientsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TbUtilisateursBindingSource
        '
        Me.TbUtilisateursBindingSource.DataMember = "tbUtilisateurs"
        Me.TbUtilisateursBindingSource.DataSource = Me.Voyages2010DataSetBindingSource
        '
        'Voyages2010DataSetBindingSource
        '
        Me.Voyages2010DataSetBindingSource.DataSource = Me.Voyages2010DataSet
        Me.Voyages2010DataSetBindingSource.Position = 0
        '
        'Voyages2010DataSet
        '
        Me.Voyages2010DataSet.DataSetName = "Voyages2010DataSet"
        Me.Voyages2010DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblClientsBindingSource
        '
        Me.TblClientsBindingSource.DataMember = "tblClients"
        Me.TblClientsBindingSource.DataSource = Me.Voyages2010DataSetBindingSource
        '
        'TblClientsTableAdapter
        '
        Me.TblClientsTableAdapter.ClearBeforeFill = True
        '
        'TbUtilisateursTableAdapter
        '
        Me.TbUtilisateursTableAdapter.ClearBeforeFill = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.GroupBox1)
        Me.Panel2.Controls.Add(Me.GroupBox2)
        Me.Panel2.Controls.Add(Me.tPassword)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.tNom)
        Me.Panel2.Enabled = False
        Me.Panel2.Location = New System.Drawing.Point(21, 36)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(429, 209)
        Me.Panel2.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbDataGrid)
        Me.GroupBox1.Controls.Add(Me.rbTextBox)
        Me.GroupBox1.Enabled = False
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(32, 140)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(316, 49)
        Me.GroupBox1.TabIndex = 22
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Préférence d'affichage"
        '
        'rbDataGrid
        '
        Me.rbDataGrid.AutoSize = True
        Me.rbDataGrid.Location = New System.Drawing.Point(104, 26)
        Me.rbDataGrid.Name = "rbDataGrid"
        Me.rbDataGrid.Size = New System.Drawing.Size(75, 17)
        Me.rbDataGrid.TabIndex = 20
        Me.rbDataGrid.TabStop = True
        Me.rbDataGrid.Text = "DataGrid"
        Me.rbDataGrid.UseVisualStyleBackColor = True
        '
        'rbTextBox
        '
        Me.rbTextBox.AutoSize = True
        Me.rbTextBox.Location = New System.Drawing.Point(220, 26)
        Me.rbTextBox.Name = "rbTextBox"
        Me.rbTextBox.Size = New System.Drawing.Size(71, 17)
        Me.rbTextBox.TabIndex = 21
        Me.rbTextBox.TabStop = True
        Me.rbTextBox.Text = "TextBox"
        Me.rbTextBox.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rbCommis)
        Me.GroupBox2.Controls.Add(Me.rbGerant)
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GroupBox2.Location = New System.Drawing.Point(31, 72)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(349, 62)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Type utilisateur"
        '
        'rbCommis
        '
        Me.rbCommis.AutoSize = True
        Me.rbCommis.Location = New System.Drawing.Point(105, 30)
        Me.rbCommis.Name = "rbCommis"
        Me.rbCommis.Size = New System.Drawing.Size(67, 17)
        Me.rbCommis.TabIndex = 18
        Me.rbCommis.TabStop = True
        Me.rbCommis.Text = "Commis"
        Me.rbCommis.UseVisualStyleBackColor = True
        '
        'rbGerant
        '
        Me.rbGerant.AutoSize = True
        Me.rbGerant.Location = New System.Drawing.Point(221, 30)
        Me.rbGerant.Name = "rbGerant"
        Me.rbGerant.Size = New System.Drawing.Size(60, 17)
        Me.rbGerant.TabIndex = 19
        Me.rbGerant.TabStop = True
        Me.rbGerant.Text = "Gérant"
        Me.rbGerant.UseVisualStyleBackColor = True
        '
        'tPassword
        '
        Me.tPassword.Location = New System.Drawing.Point(136, 34)
        Me.tPassword.Name = "tPassword"
        Me.tPassword.Size = New System.Drawing.Size(260, 20)
        Me.tPassword.TabIndex = 6
        Me.tPassword.UseSystemPasswordChar = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(39, 37)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(77, 13)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Mot de passe"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(39, 10)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(88, 13)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "Nom utilisateur"
        '
        'tNom
        '
        Me.tNom.Location = New System.Drawing.Point(136, 3)
        Me.tNom.Name = "tNom"
        Me.tNom.Size = New System.Drawing.Size(260, 20)
        Me.tNom.TabIndex = 1
        '
        'bAjouter
        '
        Me.bAjouter.BackColor = System.Drawing.Color.LightSteelBlue
        Me.bAjouter.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bAjouter.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bAjouter.Location = New System.Drawing.Point(53, 267)
        Me.bAjouter.Name = "bAjouter"
        Me.bAjouter.Size = New System.Drawing.Size(95, 24)
        Me.bAjouter.TabIndex = 0
        Me.bAjouter.Text = "Ajouter"
        Me.bAjouter.UseVisualStyleBackColor = False
        '
        'bSupprimer
        '
        Me.bSupprimer.BackColor = System.Drawing.Color.LightSteelBlue
        Me.bSupprimer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bSupprimer.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bSupprimer.Location = New System.Drawing.Point(496, 267)
        Me.bSupprimer.Name = "bSupprimer"
        Me.bSupprimer.Size = New System.Drawing.Size(95, 24)
        Me.bSupprimer.TabIndex = 4
        Me.bSupprimer.Text = "&Supprimer"
        Me.bSupprimer.UseVisualStyleBackColor = False
        '
        'bFirstUser
        '
        Me.bFirstUser.BackColor = System.Drawing.Color.LightSteelBlue
        Me.bFirstUser.Location = New System.Drawing.Point(496, 20)
        Me.bFirstUser.Name = "bFirstUser"
        Me.bFirstUser.Size = New System.Drawing.Size(50, 23)
        Me.bFirstUser.TabIndex = 3
        Me.bFirstUser.Text = "|<"
        Me.bFirstUser.UseVisualStyleBackColor = False
        '
        'bPreviousUser
        '
        Me.bPreviousUser.BackColor = System.Drawing.Color.LightSteelBlue
        Me.bPreviousUser.Location = New System.Drawing.Point(552, 20)
        Me.bPreviousUser.Name = "bPreviousUser"
        Me.bPreviousUser.Size = New System.Drawing.Size(47, 23)
        Me.bPreviousUser.TabIndex = 4
        Me.bPreviousUser.Text = "<"
        Me.bPreviousUser.UseVisualStyleBackColor = False
        '
        'bNextUser
        '
        Me.bNextUser.BackColor = System.Drawing.Color.LightSteelBlue
        Me.bNextUser.Location = New System.Drawing.Point(637, 20)
        Me.bNextUser.Name = "bNextUser"
        Me.bNextUser.Size = New System.Drawing.Size(45, 23)
        Me.bNextUser.TabIndex = 5
        Me.bNextUser.Text = ">"
        Me.bNextUser.UseVisualStyleBackColor = False
        '
        'bLastUser
        '
        Me.bLastUser.BackColor = System.Drawing.Color.LightSteelBlue
        Me.bLastUser.Location = New System.Drawing.Point(688, 20)
        Me.bLastUser.Name = "bLastUser"
        Me.bLastUser.Size = New System.Drawing.Size(48, 23)
        Me.bLastUser.TabIndex = 6
        Me.bLastUser.Text = ">|"
        Me.bLastUser.UseVisualStyleBackColor = False
        '
        'lbUtilisateurs
        '
        Me.lbUtilisateurs.FormattingEnabled = True
        Me.lbUtilisateurs.Location = New System.Drawing.Point(496, 66)
        Me.lbUtilisateurs.Name = "lbUtilisateurs"
        Me.lbUtilisateurs.Size = New System.Drawing.Size(232, 186)
        Me.lbUtilisateurs.TabIndex = 7
        '
        'bQuitter
        '
        Me.bQuitter.BackColor = System.Drawing.Color.Black
        Me.bQuitter.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bQuitter.ForeColor = System.Drawing.Color.White
        Me.bQuitter.Location = New System.Drawing.Point(591, 329)
        Me.bQuitter.Name = "bQuitter"
        Me.bQuitter.Size = New System.Drawing.Size(150, 29)
        Me.bQuitter.TabIndex = 19
        Me.bQuitter.Text = "Quitter"
        Me.bQuitter.UseVisualStyleBackColor = False
        '
        'AdminFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(753, 370)
        Me.Controls.Add(Me.bQuitter)
        Me.Controls.Add(Me.bSupprimer)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.bAjouter)
        Me.Controls.Add(Me.lbUtilisateurs)
        Me.Controls.Add(Me.bFirstUser)
        Me.Controls.Add(Me.bLastUser)
        Me.Controls.Add(Me.bPreviousUser)
        Me.Controls.Add(Me.bNextUser)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "AdminFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Administrateur"
        CType(Me.TbUtilisateursBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Voyages2010DataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Voyages2010DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblClientsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Voyages2010DataSetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Voyages2010DataSet As VB_TP2.Voyages2010DataSet
    Friend WithEvents TblClientsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblClientsTableAdapter As VB_TP2.Voyages2010DataSetTableAdapters.tblClientsTableAdapter
    Friend WithEvents TbUtilisateursBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TbUtilisateursTableAdapter As VB_TP2.Voyages2010DataSetTableAdapters.tbUtilisateursTableAdapter
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents tPassword As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents tNom As System.Windows.Forms.TextBox
    Friend WithEvents bAjouter As System.Windows.Forms.Button
    Friend WithEvents bSupprimer As System.Windows.Forms.Button
    Friend WithEvents bFirstUser As System.Windows.Forms.Button
    Friend WithEvents bPreviousUser As System.Windows.Forms.Button
    Friend WithEvents bNextUser As System.Windows.Forms.Button
    Friend WithEvents bLastUser As System.Windows.Forms.Button
    Friend WithEvents lbUtilisateurs As System.Windows.Forms.ListBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents rbCommis As System.Windows.Forms.RadioButton
    Friend WithEvents rbGerant As System.Windows.Forms.RadioButton
    Friend WithEvents bQuitter As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rbDataGrid As System.Windows.Forms.RadioButton
    Friend WithEvents rbTextBox As System.Windows.Forms.RadioButton
End Class
