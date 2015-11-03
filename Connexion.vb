Imports System.Data.OleDb
Imports System.Windows.Forms

Public Class Connexion
    Private mycon As OleDbConnection
    Private strcon As String
    Public rdr As OleDbDataReader
    Public Myreq As String
    Private cmd As OleDbCommand
    Public Sub Connecting()
        strcon = "provider=microsoft.ace.oledb.12.0; data source =" & Application.StartupPath & "\Voyages2010.mdb"
        mycon = New OleDbConnection(strcon)
        mycon.Open()
        cmd = New OleDbCommand(Myreq, mycon)
        rdr = cmd.ExecuteReader
    End Sub
    Public Sub Disconnecting()
        rdr.Close()
        mycon.Close()
    End Sub
End Class
