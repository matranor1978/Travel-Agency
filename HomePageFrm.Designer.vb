<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HomePageFrm
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
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btnOk = New System.Windows.Forms.Button()
        Me.tPassword = New System.Windows.Forms.TextBox()
        Me.tLogin = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbType = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.bQuitter = New System.Windows.Forms.Button()
        Me.lerreur = New System.Windows.Forms.Label()
        Me.lDate = New System.Windows.Forms.Label()
        Me.lTime = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'btnOk
        '
        Me.btnOk.BackColor = System.Drawing.Color.Black
        Me.btnOk.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOk.ForeColor = System.Drawing.Color.White
        Me.btnOk.Location = New System.Drawing.Point(109, 229)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(150, 29)
        Me.btnOk.TabIndex = 25
        Me.btnOk.Text = "OK"
        Me.btnOk.UseVisualStyleBackColor = False
        '
        'tPassword
        '
        Me.tPassword.Location = New System.Drawing.Point(196, 169)
        Me.tPassword.Name = "tPassword"
        Me.tPassword.Size = New System.Drawing.Size(144, 20)
        Me.tPassword.TabIndex = 24
        Me.tPassword.UseSystemPasswordChar = True
        '
        'tLogin
        '
        Me.tLogin.Location = New System.Drawing.Point(196, 133)
        Me.tLogin.Name = "tLogin"
        Me.tLogin.Size = New System.Drawing.Size(144, 20)
        Me.tLogin.TabIndex = 23
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(31, 170)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(117, 20)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Mot de passe"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(31, 135)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 20)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Login"
        '
        'cbType
        '
        Me.cbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbType.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbType.ForeColor = System.Drawing.Color.Black
        Me.cbType.FormattingEnabled = True
        Me.cbType.Items.AddRange(New Object() {"Commis", "Gérant", "Administrateur"})
        Me.cbType.Location = New System.Drawing.Point(187, 30)
        Me.cbType.Name = "cbType"
        Me.cbType.Size = New System.Drawing.Size(219, 32)
        Me.cbType.TabIndex = 20
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(30, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 24)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Vous êtes : "
        '
        'bQuitter
        '
        Me.bQuitter.BackColor = System.Drawing.Color.Black
        Me.bQuitter.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bQuitter.ForeColor = System.Drawing.Color.White
        Me.bQuitter.Location = New System.Drawing.Point(321, 229)
        Me.bQuitter.Name = "bQuitter"
        Me.bQuitter.Size = New System.Drawing.Size(150, 29)
        Me.bQuitter.TabIndex = 18
        Me.bQuitter.Text = "Quitter"
        Me.bQuitter.UseVisualStyleBackColor = False
        '
        'lerreur
        '
        Me.lerreur.AutoSize = True
        Me.lerreur.ForeColor = System.Drawing.Color.Red
        Me.lerreur.Location = New System.Drawing.Point(193, 201)
        Me.lerreur.Name = "lerreur"
        Me.lerreur.Size = New System.Drawing.Size(165, 13)
        Me.lerreur.TabIndex = 26
        Me.lerreur.Text = "* Login ou mot de passe incorrect"
        Me.lerreur.Visible = False
        '
        'lDate
        '
        Me.lDate.AutoSize = True
        Me.lDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lDate.ForeColor = System.Drawing.Color.Black
        Me.lDate.Location = New System.Drawing.Point(32, 273)
        Me.lDate.Name = "lDate"
        Me.lDate.Size = New System.Drawing.Size(0, 13)
        Me.lDate.TabIndex = 28
        '
        'lTime
        '
        Me.lTime.AutoSize = True
        Me.lTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lTime.ForeColor = System.Drawing.Color.Black
        Me.lTime.Location = New System.Drawing.Point(151, 273)
        Me.lTime.Name = "lTime"
        Me.lTime.Size = New System.Drawing.Size(0, 13)
        Me.lTime.TabIndex = 27
        '
        'HomePageFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(554, 295)
        Me.Controls.Add(Me.lDate)
        Me.Controls.Add(Me.lTime)
        Me.Controls.Add(Me.lerreur)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.tPassword)
        Me.Controls.Add(Me.tLogin)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cbType)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.bQuitter)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "HomePageFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Accueil"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents btnOk As System.Windows.Forms.Button
    Friend WithEvents tPassword As System.Windows.Forms.TextBox
    Friend WithEvents tLogin As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cbType As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents bQuitter As System.Windows.Forms.Button
    Friend WithEvents lerreur As System.Windows.Forms.Label
    Friend WithEvents lDate As System.Windows.Forms.Label
    Friend WithEvents lTime As System.Windows.Forms.Label

End Class
