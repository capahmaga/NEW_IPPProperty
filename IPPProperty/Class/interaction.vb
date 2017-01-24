Imports IPPProperty

Public Class interaction

    Private _paramType As Integer
    Public Property paramType() As Integer
        Get
            Return _paramType
        End Get
        Set(ByVal paramType As Integer)
            _paramType = paramType
        End Set

    End Property


End Class
