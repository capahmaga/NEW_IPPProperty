Public Class clsMenuAction

    Public Sub menu001001(ByVal a As String)
        frmUser.Show()
    End Sub

    Public Sub menu001005(ByVal a As String)
        Application.Exit()
    End Sub

    Public Sub menu001002003(ByVal a As String)
        frmPermission.Show()
    End Sub

    Public Sub menu004002(ByVal a As String)
        frmMSPersonalIdentity.Show()
        frmMSPersonalIdentity.TopMost = True
    End Sub

    Public Sub menu004003(ByVal a As String)
        frmMSPersonalInstitution.Show()
        frmMSPersonalInstitution.TopMost = True
    End Sub
    Public Sub menu005002(ByVal a As String)
        frmBilling.Show()
        frmBilling.TopMost = True
    End Sub
    Public Sub menu005003(ByVal a As String)
        frmBilling.Show()
        frmBilling.TopMost = True
    End Sub
    Public Sub menu005004(ByVal a As String)
        frmBilling.Show()
        frmBilling.TopMost = True
    End Sub
    Public Sub menu003001(ByVal a As String)
        frmReservation.Show()
        frmReservation.TopMost = True
    End Sub

End Class
