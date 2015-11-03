Imports System.Data.OleDb
Imports System.ComponentModel
Imports System.Security.Cryptography
Imports System.Text

Public Class UtilisateurDao
    Public cnn As New Connexion
    Sub New()
        Dim con As New OleDbConnection
        con.ConnectionString = "provider=microsoft.ace.oledb.12.0; data source =" & Application.StartupPath & "\Voyages2010.mdb"
        con.Open()
        Dim ds As New DataSet
        Dim dt As New DataTable

        ds.Tables.Add(dt)
        Dim da As New OleDbDataAdapter("select id, nom, password, type, affichage from tbUtilisateurs", con)
        da.Fill(dt)
        For Each row As DataRow In dt.Rows
            getAllUtilisateurs.Add(New Utilisateur(row.Item(1).ToString, row.Item(2).ToString, row.Item(3).ToString, row.Item(4).ToString))
        Next
        con.Close()
    End Sub

    Public Function checkLoginUtilisateur(ByVal u As Utilisateur) As Boolean
        If getAllUtilisateurs.Contains(u) Then
            Return True
        End If
        Return False
    End Function

    Sub addUtilisateur(ByRef user As Utilisateur)
        Dim listeUtilisateurs As BindingList(Of Utilisateur) = Me.getAllUtilisateurs
        listeUtilisateurs.Add(user)
        cnn.Myreq = "select * from tbUtilisateurs  WHERE id =( SELECT max(id) FROM tbUtilisateurs )"
        cnn.Connecting()
        Do While cnn.rdr.Read
            user.ID = cnn.rdr(0) + 1
        Loop
        cnn.Disconnecting()
        Dim md5Hasher As MD5 = MD5.Create
        Dim donnees As Byte() = md5Hasher.ComputeHash(Encoding.Default.GetBytes(user.password))
        Dim chaineAconstruire As New StringBuilder()
        For i As Integer = 0 To donnees.Length - 1
            chaineAconstruire.Append(donnees(i).ToString("x2"))
        Next i
        cnn.Myreq = "insert into tbUtilisateurs values (" & user.ID & " ,'" & user.username & "' ,'" & chaineAconstruire.ToString & "','" & user.type & "','" & user.preference & "')"
        cnn.Connecting()
        cnn.Disconnecting()
        MsgBox("Enregistrement Reussi")
    End Sub
    Sub deleteUtilisateur(ByVal _id As Integer)
        Dim listeUtilisateurs As BindingList(Of Utilisateur) = Me.getAllUtilisateurs
        Dim u As New Utilisateur(_id)
        cnn.Myreq = "delete from tbUtilisateurs where id = " & u.ID & ""
        cnn.Connecting()
        cnn.Disconnecting()
        MsgBox("Suppression Reussie")
    End Sub
    Sub updatePassword(ByVal nom As String, ByVal newPassword As String)
        Dim md5Hasher As MD5 = MD5.Create
        Dim donnees As Byte() = md5Hasher.ComputeHash(Encoding.Default.GetBytes(newPassword))
        Dim chaineAconstruire As New StringBuilder()
        For i As Integer = 0 To donnees.Length - 1
            chaineAconstruire.Append(donnees(i).ToString("x2"))
        Next i
        cnn.Myreq = "update [tbUtilisateurs] set [password] = '" & chaineAconstruire.ToString & "' where [nom] = '" & nom & "'"
        cnn.Connecting()
        cnn.Disconnecting()
        MsgBox("Modification Réussie")

    End Sub

    Function getAllUtilisateurs() As BindingList(Of Utilisateur)
        Dim listeUtilisateurs As New BindingList(Of Utilisateur)
        cnn.Myreq = "Select * from tbUtilisateurs"
        cnn.Connecting()

        Do While cnn.rdr.Read

            Dim user As New Utilisateur
            user.ID = cnn.rdr(0)
            user.username = cnn.rdr(1)
            user.password = cnn.rdr(2)
            user.type = cnn.rdr(3)
            listeUtilisateurs.Add(user)
        Loop
        cnn.Disconnecting()
        Return listeUtilisateurs
    End Function

    Function getAllUtilisateurs(ByVal nom As String, ByVal password As String) As Utilisateur
        Dim user As New Utilisateur
        cnn.Myreq = "Select * from tbUtilisateurs where nom = '" & nom & "' and password = '" & password & "'"
        cnn.Connecting()

        Do While cnn.rdr.Read

            user.ID = cnn.rdr(0)
            user.username = cnn.rdr(1)
            user.password = cnn.rdr(2)
            user.type = cnn.rdr(3)
            user.preference = cnn.rdr(4)

        Loop
        cnn.Disconnecting()
        Return user
    End Function


End Class
