﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class setPasswordGerant
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
        Me.txtNomUser = New System.Windows.Forms.TextBox()
        Me.lblUser = New System.Windows.Forms.Label()
        Me.LbPasswordIncorrect = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.textPasswordConfirm = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.textNewPassword = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtNomUser
        '
        Me.txtNomUser.Enabled = False
        Me.txtNomUser.Location = New System.Drawing.Point(19, 40)
        Me.txtNomUser.Name = "txtNomUser"
        Me.txtNomUser.Size = New System.Drawing.Size(196, 20)
        Me.txtNomUser.TabIndex = 111
        Me.txtNomUser.TabStop = False
        '
        'lblUser
        '
        Me.lblUser.AutoSize = True
        Me.lblUser.Location = New System.Drawing.Point(16, 24)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(84, 13)
        Me.lblUser.TabIndex = 110
        Me.lblUser.Text = "Nom d'utilisateur"
        '
        'LbPasswordIncorrect
        '
        Me.LbPasswordIncorrect.AutoSize = True
        Me.LbPasswordIncorrect.ForeColor = System.Drawing.Color.Red
        Me.LbPasswordIncorrect.Location = New System.Drawing.Point(16, 114)
        Me.LbPasswordIncorrect.Name = "LbPasswordIncorrect"
        Me.LbPasswordIncorrect.Size = New System.Drawing.Size(0, 13)
        Me.LbPasswordIncorrect.TabIndex = 109
        Me.LbPasswordIncorrect.Visible = False
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(155, 188)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 108
        Me.Button2.Text = "Annuler"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(19, 188)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 107
        Me.Button1.Text = "Confirmer"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'textPasswordConfirm
        '
        Me.textPasswordConfirm.Location = New System.Drawing.Point(19, 146)
        Me.textPasswordConfirm.Name = "textPasswordConfirm"
        Me.textPasswordConfirm.Size = New System.Drawing.Size(177, 20)
        Me.textPasswordConfirm.TabIndex = 106
        Me.textPasswordConfirm.UseSystemPasswordChar = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 130)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(146, 13)
        Me.Label2.TabIndex = 105
        Me.Label2.Text = "Confirmez votre mot de passe"
        '
        'textNewPassword
        '
        Me.textNewPassword.Location = New System.Drawing.Point(19, 91)
        Me.textNewPassword.Name = "textNewPassword"
        Me.textNewPassword.Size = New System.Drawing.Size(180, 20)
        Me.textNewPassword.TabIndex = 104
        Me.textNewPassword.UseSystemPasswordChar = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 75)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(176, 13)
        Me.Label1.TabIndex = 103
        Me.Label1.Text = "Entrer votre nouveau mot de passe "
        '
        'setPassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(370, 230)
        Me.Controls.Add(Me.txtNomUser)
        Me.Controls.Add(Me.lblUser)
        Me.Controls.Add(Me.LbPasswordIncorrect)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.textPasswordConfirm)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.textNewPassword)
        Me.Controls.Add(Me.Label1)
        Me.Name = "setPassword"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Modifier mot de passe"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtNomUser As System.Windows.Forms.TextBox
    Friend WithEvents lblUser As System.Windows.Forms.Label
    Friend WithEvents LbPasswordIncorrect As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents textPasswordConfirm As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents textNewPassword As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
