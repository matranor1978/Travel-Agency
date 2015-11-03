Public Class Utilisateur
    Private _userName, _password, _type, _preference As String
    Private _id As Integer

    Public Sub New(ByVal u As String, ByVal p As String, ByVal t As String, ByVal pref As String)
        _userName = u
        _password = p
        _type = t
        _preference = pref
    End Sub

    Public Sub New(ByVal u As String, ByVal p As String, ByVal t As String)
        _userName = u
        _password = p
        _type = t

    End Sub

    Public Overrides Function Equals(ByVal obj As Object) As Boolean
        Try
            Dim u As Utilisateur = CType(obj, Utilisateur)
            If (u._userName = Me._userName And u._password = Me._password And u._type = Me._type And u._preference = Me._preference) Then
                Return True
            End If
        Catch ex As Exception

        End Try
        
        Return False
    End Function

    Public Sub New()
        _userName = ""
        _password = ""
        _type = ""
        _preference = ""
    End Sub

    Public Sub New(ByVal id As Integer)
        _id = id
    End Sub

    Public Property username
        Get
            Return _userName
        End Get
        Set(ByVal value)
            _userName = value
        End Set
    End Property
    Public Property password
        Get
            Return _password
        End Get
        Set(ByVal value)
            _password = value
        End Set
    End Property
    Public Property type
        Get
            Return _type
        End Get
        Set(ByVal value)
            _type = value
        End Set
    End Property

    Public Property preference
        Get
            Return _preference
        End Get
        Set(ByVal value)
            _preference = value
        End Set
    End Property

    Public Property ID() As Integer
        Get
            Return _id
        End Get
        Set(ByVal value As Integer)
            _id = value
            'NotifyPropertyChanged("ID")
        End Set
    End Property

    Public Overrides Function toString() As String
        Return _userName & " , " & _type
    End Function

End Class

