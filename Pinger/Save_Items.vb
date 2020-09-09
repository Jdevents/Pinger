Public Class Save_Items

    Dim _ip As String
    Dim _id As Integer
    Dim _DispalyName As String
    Dim _Settingslblname As String
    Dim _AlwaysNoTop As Boolean
    Dim _pingfq As Integer
    Dim _MSworn As Integer

    Public Property Ip As String
        Get
            Return _ip
        End Get
        Set(value As String)
            _ip = value
        End Set
    End Property

    Public Property Id As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            _id = value
        End Set
    End Property

    Public Property DispalyName As String
        Get
            Return _DispalyName
        End Get
        Set(value As String)
            _DispalyName = value
        End Set
    End Property

    Public Property Settingslblname As String
        Get
            Return _Settingslblname
        End Get
        Set(value As String)
            _Settingslblname = value
        End Set
    End Property

    Public Property AlwaysNoTop As Boolean
        Get
            Return _AlwaysNoTop
        End Get
        Set(value As Boolean)
            _AlwaysNoTop = value
        End Set
    End Property

    Public Property Pingfq1 As Integer
        Get
            Return _pingfq
        End Get
        Set(value As Integer)
            _pingfq = value
        End Set
    End Property

    Public Property MSworn As Integer
        Get
            Return _MSworn
        End Get
        Set(value As Integer)
            _MSworn = value
        End Set
    End Property
End Class
