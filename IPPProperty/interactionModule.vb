Module interactionModule

    Public Username As String = "Admin"
    Public GlobalProjectID As String = 1
    Public GlobalUnitID As String
    Public todayDate As DateTime
    Public paramFormUpload As String
    Private _paramType As Integer
    Private _messageBoxMessage As String




    Public Function getServerDate() As DateTime
        Dim todayDate As New DateTime

        todayDate = clsConnect.getAllData("APP_User", "getdate() as Today ").Tables("data").Rows(0).Item("Today")

        Return todayDate
    End Function


    Public Property paramType() As Integer
        Get
            Return _paramType
        End Get
        Set(ByVal paramType As Integer)
            _paramType = paramType
        End Set

    End Property

    Public Property messageBoxMessage() As String
        Get
            Return _messageBoxMessage
        End Get
        Set(ByVal messageBoxMessage As String)
            _messageBoxMessage = messageBoxMessage
        End Set

    End Property

End Module
