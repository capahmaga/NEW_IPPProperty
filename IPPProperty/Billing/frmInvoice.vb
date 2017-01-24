Public Class frmInvoice
    Public projectID As String
    Public unitID As String
    Public invoiceID As String

    Private Sub btnLKProject_Click(sender As Object, e As EventArgs) Handles btnLKProject.Click
        frmLookupSite.tableName = "ProjectID"
        If frmLookupSite.ShowDialog = DialogResult.OK Then
            txtProjectName.Text = lookUpRow.Row("projectName")
            projectID = lookUpRow.Row("projectID")
        End If
    End Sub

    Private Sub btnLKLeaseNo_Click(sender As Object, e As EventArgs) Handles btnLKLeaseNo.Click
        frmLookupSite.tableName = "TR_TenantConfirmationUnit"
        If frmLookupSite.ShowDialog = DialogResult.OK Then
            txtLeaseNo.Text = lookUpRow.Row("proposalNo")
        End If
    End Sub

    Private Sub btnLKUnit_Click(sender As Object, e As EventArgs) Handles btnLKUnit.Click
        frmLookupSite.tableName = "MS_Unit"
        If frmLookupSite.ShowDialog = DialogResult.OK Then
            txtUnitNo.Text = lookUpRow.Row("unitNo")
            unitID = lookUpRow.Row("unitID")
            GlobalUnitID = unitID
        End If
    End Sub

    Private Sub btnLKInvoice_Click(sender As Object, e As EventArgs) Handles btnLKInvoice.Click
        frmLookupSite.tableName = "TR_Invoice"
        If frmLookupSite.ShowDialog = DialogResult.OK Then
            txtUnitNo.Text = lookUpRow.Row("unitNo")
            invoiceID = lookUpRow.Row("invoiceID")
        End If
    End Sub


    Private Sub bindDataInvoice(ByVal projectID As String, ByVal invoiceID As String)


    End Sub

    Private Sub btnLKTrans_Click(sender As Object, e As EventArgs) Handles btnLKTrans.Click
        frmLookupSite.tableName = "TR_Transaction"
        If frmLookupSite.ShowDialog = DialogResult.OK Then
            txtUnitNo.Text = lookUpRow.Row("unitNo")
            unitID = lookUpRow.Row("unitID")
            GlobalUnitID = unitID
        End If
    End Sub

    Private Sub btnAddAddTrans_Click(sender As Object, e As EventArgs) Handles btnAddAddTrans.Click

    End Sub

    Private Sub frmInvoice_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class