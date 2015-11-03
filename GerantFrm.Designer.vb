<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GerantFrm
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
        Me.TblClientsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Voyages2010DataSet = New VB_TP2.Voyages2010DataSet()
        Me.TblVoyagesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.GérerClientsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GererClientsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GererVoyagesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModifierMotDePasseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TblClientsTableAdapter = New VB_TP2.Voyages2010DataSetTableAdapters.tblClientsTableAdapter()
        Me.TblVoyagesTableAdapter = New VB_TP2.Voyages2010DataSetTableAdapters.tblVoyagesTableAdapter()
        Me.bQuitter = New System.Windows.Forms.Button()
        CType(Me.TblClientsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Voyages2010DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblVoyagesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
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
        'TblVoyagesBindingSource
        '
        Me.TblVoyagesBindingSource.DataMember = "tblVoyages"
        Me.TblVoyagesBindingSource.DataSource = Me.Voyages2010DataSet
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GérerClientsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(854, 24)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'GérerClientsToolStripMenuItem
        '
        Me.GérerClientsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GererClientsToolStripMenuItem, Me.GererVoyagesToolStripMenuItem, Me.ModifierMotDePasseToolStripMenuItem})
        Me.GérerClientsToolStripMenuItem.Name = "GérerClientsToolStripMenuItem"
        Me.GérerClientsToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.GérerClientsToolStripMenuItem.Text = "Menu"
        '
        'GererClientsToolStripMenuItem
        '
        Me.GererClientsToolStripMenuItem.Name = "GererClientsToolStripMenuItem"
        Me.GererClientsToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
        Me.GererClientsToolStripMenuItem.Text = "Gérer clients"
        '
        'GererVoyagesToolStripMenuItem
        '
        Me.GererVoyagesToolStripMenuItem.Name = "GererVoyagesToolStripMenuItem"
        Me.GererVoyagesToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
        Me.GererVoyagesToolStripMenuItem.Text = "Gérer voyages"
        '
        'ModifierMotDePasseToolStripMenuItem
        '
        Me.ModifierMotDePasseToolStripMenuItem.Name = "ModifierMotDePasseToolStripMenuItem"
        Me.ModifierMotDePasseToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
        Me.ModifierMotDePasseToolStripMenuItem.Text = "Modifier Mot de Passe"
        '
        'TblClientsTableAdapter
        '
        Me.TblClientsTableAdapter.ClearBeforeFill = True
        '
        'TblVoyagesTableAdapter
        '
        Me.TblVoyagesTableAdapter.ClearBeforeFill = True
        '
        'bQuitter
        '
        Me.bQuitter.BackColor = System.Drawing.Color.Black
        Me.bQuitter.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bQuitter.ForeColor = System.Drawing.Color.White
        Me.bQuitter.Location = New System.Drawing.Point(692, 407)
        Me.bQuitter.Name = "bQuitter"
        Me.bQuitter.Size = New System.Drawing.Size(150, 29)
        Me.bQuitter.TabIndex = 28
        Me.bQuitter.Text = "Quitter"
        Me.bQuitter.UseVisualStyleBackColor = False
        '
        'GerantFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(854, 448)
        Me.Controls.Add(Me.bQuitter)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "GerantFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gérant"
        CType(Me.TblClientsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Voyages2010DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblVoyagesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents GérerClientsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GererClientsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GererVoyagesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Voyages2010DataSet As VB_TP2.Voyages2010DataSet
    Friend WithEvents TblClientsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblClientsTableAdapter As VB_TP2.Voyages2010DataSetTableAdapters.tblClientsTableAdapter
    Friend WithEvents TblVoyagesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblVoyagesTableAdapter As VB_TP2.Voyages2010DataSetTableAdapters.tblVoyagesTableAdapter
    Friend WithEvents bQuitter As System.Windows.Forms.Button
    Friend WithEvents ModifierMotDePasseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
