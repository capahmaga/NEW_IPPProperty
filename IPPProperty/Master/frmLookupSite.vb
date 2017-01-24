Imports IPPProperty.clsConnect

Public Class frmLookupSite

    Public tableName As String
    Public paramName As String
    Public paramSatu As String

    Private Sub frmLookupSite_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        changeColor(Me)
        setFormDesign(Me)
        dgvLookUp.DataSource = Nothing
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        'paramForm.Show()
        Me.Close()
    End Sub

    Private Sub btnSearch_Click_1(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim dtData As New DataTable
        Select Case tableName
            Case "UserID"
                dtData = clsLookUp.getAPPUserByName(secureString(txtSearch.Text)).Tables("Data")
            Case "PersonalID"
                dtData = clsLookUp.getPersonalByName(GlobalProjectID, secureString(txtSearch.Text)).Tables("Data")
            Case "ProjectID"
                dtData = clsLookUp.getProjectByName(secureString(txtSearch.Text)).Tables("Data")
            Case "RolesID"
                dtData = clsLookUp.getRolesByName(GlobalProjectID, secureString(txtSearch.Text)).Tables("Data")
            Case "InstitutionID"
                dtData = clsLookUp.getInstitutionByName(GlobalProjectID, secureString(txtSearch.Text)).Tables("Data")
            Case "ApprovalID"
                dtData = clsLookUp.getInstitutionByName(GlobalProjectID, (txtSearch.Text)).Tables("Data")
            Case "MenuID"
                dtData = clsLookUp.getMenuByName(GlobalProjectID, (txtSearch.Text)).Tables("Data")
            Case "AddressType"
                dtData = clsLookUp.getAddressType(GlobalProjectID, (txtSearch.Text)).Tables("Data")
            Case "MS_Country"
                dtData = clsLookUp.getCountryByName(GlobalProjectID, (txtSearch.Text)).Tables("Data")
            Case "MS_Citizen"
                dtData = clsLookUp.getCitizenByName(GlobalProjectID, (txtSearch.Text)).Tables("Data")
            Case "MS_Bank"
                dtData = clsLookUp.getBankbySearch(GlobalProjectID, (txtSearch.Text)).Tables("Data")
            Case "MS_Unit"
                dtData = clsLookUp.getUnitbySearch(GlobalProjectID, (txtSearch.Text)).Tables("Data")
            Case "TR_TenantConfirmation"
                dtData = clsLookUp.getTenantConfirmationbySearch(GlobalProjectID, (txtSearch.Text)).Tables("Data")
            Case "TR_LeaseAgreementPax"
                dtData = clsLookUp.getTenantConfirmationPaxbySearch(GlobalProjectID, paramSatu, (txtSearch.Text)).Tables("Data")
            Case "TR_TenantConfirmationUnit"
                dtData = clsLookUp.getTenantConfirmationbyUnitSearch(GlobalProjectID, GlobalUnitID, (txtSearch.Text)).Tables("Data")
            Case "TR_LeaseAgreement"
                dtData = clsLookUp.getLeaseAgreementBySearch(GlobalProjectID, (txtSearch.Text)).Tables("Data")
            Case "TR_ReservationNo"
                dtData = clsLookUp.getReservationNoBySearch(GlobalProjectID, (txtSearch.Text)).Tables("Data")
            Case "TR_Invoice"
                dtData = clsLookUp.getInvoiceBySearch(GlobalProjectID, GlobalUnitID, (txtSearch.Text)).Tables("Data")
            Case "TR_Transaction"
                dtData = clsLookUp.getTransactionBySearch(GlobalProjectID, GlobalUnitID, (txtSearch.Text)).Tables("Data")
            Case Else
        End Select

        dgvLookUp.DataSource = Nothing
        If dtData.Rows.Count > 0 And (dtData IsNot Nothing) Then
            dgvLookUp.DataSource = dtData
        Else
            callMessage(3, "Data not Found")
            If msgBoxOK.ShowDialog = DialogResult.OK Then
                Exit Sub
            End If
        End If
    End Sub


    Private Sub btnChoose_Click(sender As Object, e As EventArgs) Handles btnChoose.Click




        If (dgvLookUp.RowCount > 0) Or (dgvLookUp.DataSource IsNot Nothing) Then
            'lookUpID = dgvLookUp.Rows(Me.dgvLookUp.CurrentRow.Index).Cells(0).Value()
            'For Each column As DataGridViewColumn In dgvLookUp.Columns
            '    If (column.HeaderText).Contains("Name") Then
            '        lookUpName = dgvLookUp.Rows(Me.dgvLookUp.CurrentRow.Index).Cells(column.HeaderText).Value()
            '    End If
            '    If (column.HeaderText).Contains("projectID") Then
            '        lookUpProjectID = dgvLookUp.Rows(Me.dgvLookUp.CurrentRow.Index).Cells(column.HeaderText).Value()
            '    End If
            '    If (column.HeaderText).Contains("unitNo") Then
            '        lookUpUnitNo = dgvLookUp.Rows(Me.dgvLookUp.CurrentRow.Index).Cells(column.HeaderText).Value()
            '    End If
            '    If (column.HeaderText).Contains("Personal") Then
            '        lookUpPersonalName = dgvLookUp.Rows(Me.dgvLookUp.CurrentRow.Index).Cells(column.HeaderText).Value()
            '    End If
            'Next
            lookUpRow = DirectCast(dgvLookUp.CurrentRow.DataBoundItem, DataRowView)

            Me.DialogResult = DialogResult.OK
            Me.Close()
        Else
            callMessage(3, "Choose data First")
            If msgBoxOK.ShowDialog = DialogResult.OK Then
                Exit Sub
            End If
        End If
    End Sub
End Class