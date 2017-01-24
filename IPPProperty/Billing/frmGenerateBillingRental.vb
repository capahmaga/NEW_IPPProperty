Public Class frmGenerateBillingRental
    Public projectID As String
    Public unitID As String
    Public TCID As String
    Public mandatoryText() As TextBox
    Public moneyTextBox() As TextBox
    Public dtpStartFlag As Boolean = False
    Public dtpEndFlag As Boolean = False
    Public dtForm As New DataTable
    Public unitTypeCode As String
    Public unitTower As String

    Private Sub btnLKProject_Click(sender As Object, e As EventArgs) Handles btnLKProject.Click
        frmLookupSite.tableName = "ProjectID"
        If frmLookupSite.ShowDialog = DialogResult.OK Then
            txtProjectName.Text = lookUpRow.Item("projectName")
            projectID = lookUpRow.Item("projectID")
        End If
    End Sub

    Private Sub btnLKTC_Click(sender As Object, e As EventArgs) Handles btnLKTC.Click
        If txtProjectName.Text = "" Then
            callMessage(3, "Select Project First")
            If msgBoxOK.ShowDialog = DialogResult.OK Then
                Exit Sub
            End If
        End If

        frmLookupSite.tableName = "TR_TenantConfirmation"
        If frmLookupSite.ShowDialog = DialogResult.OK Then
            txtTCNo.Text = lookUpRow.Item("tcNo")
            tcID = lookUpRow.Item("tcID")
            Dim dtData As New DataTable

            dtData = clsReservation.getDataReservationByTCNo(projectID, txtTCNo.Text).Tables("Data")

            Try
                If dtData.Rows.Count > 0 Then
                    bindDataFormByTC(dtData)
                Else
                    callMessage(3, "Data Not Found")
                    If msgBoxOK.ShowDialog = DialogResult.OK Then
                        Exit Sub
                    End If
                End If
            Catch ex As Exception
                callMessage(3, "Data Not Found")
                If msgBoxOK.ShowDialog = DialogResult.OK Then
                    Exit Sub
                End If
            End Try

        End If
    End Sub


    Public Sub bindDataFormByTC(ByVal dtData As DataTable)

        If dtData.Rows.Count > 0 And dtData IsNot Nothing Then
            projectID = dtData.Rows(0).Item("projectID")
            TCID = dtData.Rows(0).Item("tcID")
            txtTCNO.Text = dtData.Rows(0).Item("tcNo")
            txtTCDate.Text = dtData.Rows(0).Item("tcDate")
            unitID = dtData.Rows(0).Item("unitID")
            txtUnitNo.Text = dtData.Rows(0).Item("unitNo")
            txtLeaseNo.Text = dtData.Rows(0).Item("leaseNo")
            txtLeaseDate.Text = dtData.Rows(0).Item("leaseDate")
            txtPersonalName.Text = dtData.Rows(0).Item("tenantName")
            txtCompany.Text = dtData.Rows(0).Item("companyName")
            txtAddress.Text = dtData.Rows(0).Item("tenantAddress")
            dtpStart.Value = dtData.Rows(0).Item("countMonth")
            dtpEnd.Value = dtData.Rows(0).Item("companyName")
            txtMonth.Text = dtData.Rows(0).Item("countMonth")
            txtDay.Text = dtData.Rows(0).Item("countDay")
        Else
            callMessage(3, "Data not Found")
            If msgBoxOK.ShowDialog = DialogResult.OK Then
                Exit Sub
            End If
        End If

    End Sub

    Private Sub btnLKInvoice_Click(sender As Object, e As EventArgs) Handles btnLKInvoice.Click

    End Sub

End Class