Public Class frmMSPersonalInstitution

    Public institutionID As String
    Public projectID As String
    Public contactPersonID As String

    Private Sub frmPersonalInstitution_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim setText As String = "Personal Institution"
        Me.CenterToScreen()
        setFormDesign(Me)
        settingButton(Me, "Main")
        Me.Text = setText
        lblHead.Text = setText
    End Sub

    Private Sub btnAddAddress_Click(sender As Object, e As EventArgs) Handles btnAddAddress.Click
        frmAddress.personalType = "PersonalIdentity"
        frmAddress.ShowDialog()
    End Sub

    Private Sub btnAddPhone_Click(sender As Object, e As EventArgs) Handles btnEditPhone.Click
        frmAddress.personalType = "PersonalIdentity"
        If dgvAddress.RowCount > 0 Then
            frmPhone.cmbPhoneType.SelectedValue = dgvPhone.Rows(Me.dgvPhone.CurrentRow.Index).Cells(0).Value()
            frmPhone.txtPhoneCode.Text = dgvPhone.Rows(Me.dgvPhone.CurrentRow.Index).Cells(1).Value()
            frmPhone.txtPhoneNumber.Text = dgvPhone.Rows(Me.dgvPhone.CurrentRow.Index).Cells(2).Value()
            frmPhone.txtRemarks.Text = dgvPhone.Rows(Me.dgvPhone.CurrentRow.Index).Cells(3).Value()
        Else
            callMessage(3, "Data not Found")
            If msgBoxOK.ShowDialog = DialogResult.OK Then
                Exit Sub
            End If
        End If
        frmPhone.ShowDialog()
    End Sub

    Private Sub btnEditAddress_Click(sender As Object, e As EventArgs) Handles btnEditAddress.Click
        frmAddress.personalType = "PersonalIdentity"
        If dgvAddress.RowCount > 0 Then
            frmAddress.cmbAddressType.SelectedValue = dgvAddress.Rows(Me.dgvAddress.CurrentRow.Index).Cells(0).Value()
            frmAddress.txtAddress.Text = dgvAddress.Rows(Me.dgvAddress.CurrentRow.Index).Cells(1).Value()
            frmAddress.txtCity.Text = dgvAddress.Rows(Me.dgvAddress.CurrentRow.Index).Cells(2).Value()
            frmAddress.txtProvince.Text = dgvAddress.Rows(Me.dgvAddress.CurrentRow.Index).Cells(3).Value()
            frmAddress.txtCountry.Text = dgvAddress.Rows(Me.dgvAddress.CurrentRow.Index).Cells(4).Value()
            frmAddress.txtZipCode.Text = dgvAddress.Rows(Me.dgvAddress.CurrentRow.Index).Cells(2).Value()
        Else
            callMessage(3, "Data not Found")
            If msgBoxOK.ShowDialog = DialogResult.OK Then
                Exit Sub
            End If
        End If
        frmAddress.ShowDialog()
    End Sub

    Private Sub btnDeleteAddress_Click(sender As Object, e As EventArgs) Handles btnDeleteAddress.Click

        If dgvAddress.RowCount > 0 Then
            callMessage(2, "Delete data " + dgvAddress.Rows(Me.dgvAddress.CurrentRow.Index).Cells(0).Value() + "?")
            If msgBoxOK.ShowDialog = DialogResult.Yes Then
                dgvAddress.Rows.Remove(dgvAddress.Rows(Me.dgvAddress.CurrentRow.Index))
                dgvAddress.Refresh()
            End If
        Else
            callMessage(3, "Data Not Found")
            If msgBoxOK.ShowDialog = DialogResult.Yes Then
                Exit Sub
            End If
        End If


    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnLKID_Click(sender As Object, e As EventArgs) Handles btnLKID.Click
        frmLookupSite.tableName = "ProjectID"
        If frmLookupSite.ShowDialog = DialogResult.OK Then
            txtProjectName.Text = lookUpRow.Item("projectName")
        End If
    End Sub

    Private Sub btnLKRoles_Click(sender As Object, e As EventArgs) Handles btnLKRoles.Click
        frmLookupSite.tableName = "PersonalID"
        If frmLookupSite.ShowDialog = DialogResult.OK Then
            projectID = lookUpRow.Item("projectID")
            institutionID = lookUpRow.Item("personalID")
            bindDataInstitution(projectID, institutionID)
        End If
    End Sub

    Public Sub bindDataInstitution(ByVal projectId As String, ByVal personalID As String)
        Dim dtInstitution As New DataTable

        dtInstitution = clsPersonal.getInstitutionByID(projectId, personalID).Tables("Data")

        If dtInstitution.Rows.Count > 0 Or dtInstitution IsNot Nothing Then
            txtCompanyCode.Text = dtInstitution.Rows(0).Item("personalCode").ToString
            txtProjectName.Text = dtInstitution.Rows(0).Item("projectName").ToString
            projectId = dtInstitution.Rows(0).Item("projectID").ToString
            txtCompanyName.Text = dtInstitution.Rows(0).Item("personalName").ToString
            txtBranchName.Text = dtInstitution.Rows(0).Item("branchName").ToString
            dtpBirthdate.Value = dtInstitution.Rows(0).Item("establishmentDate")
            txtEstablishmentPlace.Text = dtInstitution.Rows(0).Item("establishmentPlace").ToString
            txtCountry.Text = dtInstitution.Rows(0).Item("country").ToString
            txtContactPerson.Text = dtInstitution.Rows(0).Item("ContactPerson").ToString
            contactPersonID = dtInstitution.Rows(0).Item("contactPersonID").ToString
            txtSPPKP.Text = dtInstitution.Rows(0).Item("SPPKP").ToString
            txtSKDP.Text = dtInstitution.Rows(0).Item("SKDP").ToString
            txtSIUP.Text = dtInstitution.Rows(0).Item("SIUP").ToString
            txtSK.Text = dtInstitution.Rows(0).Item("SKKemenhumkam").ToString
            chkActive.Checked = dtInstitution.Rows(0).Item("isActive")
            txtLastUpdated.Text = dtInstitution.Rows(0).Item("lastUpdated").ToString
            txtLastUpdater.Text = dtInstitution.Rows(0).Item("lastUpdater").ToString

            bindAddress(projectId, personalID)
            bindPhone(projectId, personalID)
            bindEmail(projectId, personalID)
            bindBankAccount(projectId, personalID)
            bindDocument(projectId, personalID)
        Else
            callMessage(3, "Data not Found")
            If msgBoxOK.ShowDialog = DialogResult.OK Then
                Exit Sub
            End If
        End If


    End Sub

    Public Sub bindAddress(ByVal projectID As String, ByVal persoanlID As String)
        Dim dtAddress As New DataTable

        dgvAddress.DataSource = Nothing

        dtAddress = clsPersonal.getAddressByPersonalID(projectID, persoanlID).Tables("Data")

        If dtAddress.Rows.Count > 0 And (dtAddress IsNot Nothing) Then
            dgvAddress.DataSource = dtAddress
        Else
            dgvAddress.DataSource = Nothing
        End If

    End Sub

    Public Sub bindPhone(ByVal projectId As String, ByVal personalId As String)
        Dim dtPhone As New DataTable

        dtPhone = clsPersonal.getPhoneByPersonalID(projectId, personalId).Tables("data")

        If dtPhone.Rows.Count > 0 And dtPhone IsNot Nothing Then
            dgvPhone.DataSource = dtPhone

        Else
            dgvPhone.DataSource = Nothing
        End If

    End Sub

    Public Sub bindEmail(ByVal projectID As String, ByVal personalId As String)
        Dim dtEmail As New DataTable

        dtEmail = clsPersonal.getEmailByPersonalID(projectID, personalId).Tables("Data")

        If dtEmail.Rows.Count > 0 And dtEmail IsNot Nothing Then
            dgvEmail.DataSource = dtEmail

        Else
            dgvEmail.DataSource = Nothing
        End If
    End Sub

    Public Sub bindBankAccount(ByVal projectID As String, ByVal personalID As String)
        Dim dtBankAccount As New DataTable

        dtBankAccount = clsPersonal.getBankAccountByPersonalID(projectID, personalID).Tables("Data")

        If dtBankAccount.Rows.Count > 0 And dtBankAccount IsNot Nothing Then
            dgvBankAccount.DataSource = dtBankAccount

        Else
            dgvBankAccount.DataSource = Nothing
        End If

    End Sub

    Public Sub bindDocument(ByVal projectID As String, ByVal personalID As String)
        Dim dtDocument As New DataTable

        dtDocument = clsPersonal.getBankAccountByPersonalID(projectID, personalID).Tables("Data")

        If dtDocument.Rows.Count > 0 And dtDocument IsNot Nothing Then
            dgvDocument.DataSource = dtDocument

        Else
            dgvDocument.DataSource = Nothing
        End If

    End Sub


    Private Sub btnAddPhone_Click_1(sender As Object, e As EventArgs) Handles btnAddPhone.Click
        frmPhone.personalType = "PersonalIdentity"
        frmPhone.ShowDialog()
    End Sub

    Private Sub btnDeletePhone_Click(sender As Object, e As EventArgs) Handles btnDeletePhone.Click
        callMessage(2, "Delete data " + dgvPhone.Rows(Me.dgvPhone.CurrentRow.Index).Cells(0).Value() + "?")
        If msgBoxOK.ShowDialog = DialogResult.Yes Then
            dgvPhone.Rows.Remove(dgvPhone.Rows(Me.dgvPhone.CurrentRow.Index))
            dgvPhone.Refresh()
        End If
    End Sub

    Private Sub btnAddEmail_Click_1(sender As Object, e As EventArgs) Handles btnAddEmail.Click
        frmMSEmail.personalType = "PersonalIdentity"
        frmMSEmail.ShowDialog()
    End Sub

    Private Sub btnEditEmail_Click(sender As Object, e As EventArgs) Handles btnEditEmail.Click
        frmMSEmail.personalType = "PersonalIdentity"
        If dgvEmail.RowCount > 0 Then
            frmMSEmail.cmbEmailType.SelectedValue = dgvEmail.Rows(Me.dgvEmail.CurrentRow.Index).Cells(0).Value()
            frmMSEmail.txtEmailAddress.Text = dgvEmail.Rows(Me.dgvEmail.CurrentRow.Index).Cells(1).Value()
            frmMSEmail.txtEmailRemarks.Text = dgvEmail.Rows(Me.dgvEmail.CurrentRow.Index).Cells(2).Value()
        Else
            callMessage(3, "Data not Found")
            If msgBoxOK.ShowDialog = DialogResult.OK Then
                Exit Sub
            End If
        End If
        frmMSEmail.ShowDialog()
    End Sub

    Private Sub btnDeleteEmail_Click(sender As Object, e As EventArgs) Handles btnDeleteEmail.Click
        If dgvEmail.RowCount > 0 Then
            callMessage(2, "Delete data " + dgvEmail.Rows(Me.dgvEmail.CurrentRow.Index).Cells(0).Value() + "?")
            If msgBoxOK.ShowDialog = DialogResult.Yes Then
                dgvEmail.Rows.Remove(dgvEmail.Rows(Me.dgvEmail.CurrentRow.Index))
                dgvEmail.Refresh()
            End If
        Else
            callMessage(3, "Data not Found")
            If msgBoxOK.ShowDialog = DialogResult.OK Then
                Exit Sub
            End If
        End If
    End Sub

    Private Sub btnAddBank_Click_1(sender As Object, e As EventArgs) Handles btnAddBank.Click
        frmMSBankAccount.personalType = "PersonalIdentity"
        frmMSBankAccount.ShowDialog()
    End Sub

    Private Sub btnEditBank_Click(sender As Object, e As EventArgs) Handles btnEditBank.Click
        frmMSBankAccount.personalType = "PersonalIdentity"
        If dgvBankAccount.RowCount > 0 Then
            frmMSBankAccount.cmbAccountType.SelectedValue = dgvBankAccount.Rows(Me.dgvBankAccount.CurrentRow.Index).Cells(0).Value()
            frmMSBankAccount.txtBranchName.Text = dgvBankAccount.Rows(Me.dgvBankAccount.CurrentRow.Index).Cells(1).Value()
            frmMSBankAccount.txtAccountRemarks.Text = dgvBankAccount.Rows(Me.dgvBankAccount.CurrentRow.Index).Cells(2).Value()
        Else
            callMessage(3, "Data not Found")
            If msgBoxOK.ShowDialog = DialogResult.OK Then
                Exit Sub
            End If
        End If
        frmMSBankAccount.ShowDialog()
    End Sub

    Private Sub btnDeleteBank_Click(sender As Object, e As EventArgs) Handles btnDeleteBank.Click
        If dgvBankAccount.RowCount > 0 Then
            callMessage(2, "Delete data " + dgvBankAccount.Rows(Me.dgvBankAccount.CurrentRow.Index).Cells(0).Value() + "?")
            If msgBoxOK.ShowDialog = DialogResult.Yes Then
                dgvBankAccount.Rows.Remove(dgvBankAccount.Rows(Me.dgvBankAccount.CurrentRow.Index))
                dgvBankAccount.Refresh()
            End If
        Else
            callMessage(3, "Data not Found")
            If msgBoxOK.ShowDialog = DialogResult.OK Then
                Exit Sub
            End If
        End If

    End Sub

    Private Sub btnAddDocument_Click_1(sender As Object, e As EventArgs) Handles btnAddDocument.Click
        frmMSDocument.personalType = "PersonalIdentity"
        frmMSDocument.ShowDialog()
    End Sub

    Private Sub btnEditDocument_Click(sender As Object, e As EventArgs) Handles btnEditDocument.Click
        frmMSDocument.personalType = "PersonalIdentity"
        If dgvDocument.RowCount > 0 Then
            frmMSDocument.cmbDocumentType.SelectedValue = dgvDocument.Rows(Me.dgvDocument.CurrentRow.Index).Cells(0).Value()
            frmMSDocument.txtDocumentName.Text = dgvDocument.Rows(Me.dgvDocument.CurrentRow.Index).Cells(1).Value()
            frmMSDocument.txtDocumentRemarks.Text = dgvDocument.Rows(Me.dgvDocument.CurrentRow.Index).Cells(2).Value()
        Else
            callMessage(3, "Data not Found")
            If msgBoxOK.ShowDialog = DialogResult.OK Then
                Exit Sub
            End If
        End If
        frmMSDocument.ShowDialog()
    End Sub

    Private Sub btnDeleteDocument_Click(sender As Object, e As EventArgs) Handles btnDeleteDocument.Click
        If dgvDocument.RowCount > 0 Then
            callMessage(2, "Delete data " + dgvDocument.Rows(Me.dgvDocument.CurrentRow.Index).Cells(0).Value() + "?")
            If msgBoxOK.ShowDialog = DialogResult.Yes Then
                dgvDocument.Rows.Remove(dgvDocument.Rows(Me.dgvDocument.CurrentRow.Index))
                dgvDocument.Refresh()
            End If
        Else
            callMessage(3, "Data not Found")
            If msgBoxOK.ShowDialog = DialogResult.OK Then
                Exit Sub
            End If
        End If

    End Sub

    Private Sub btnLKCitizen_Click(sender As Object, e As EventArgs) Handles btnLKCitizen.Click
        frmLookupSite.tableName = "MS_Citizen"
        If frmLookupSite.ShowDialog = DialogResult.OK Then
            txtCountry.Text = lookUpRow.Item("countryName")
        End If
    End Sub

    Private Sub btnLKContactPerson_Click(sender As Object, e As EventArgs) Handles btnLKContactPerson.Click
        frmLookupSite.tableName = "PersonalID"
        If frmLookupSite.ShowDialog = DialogResult.OK Then
            txtCountry.Text = lookUpRow.Item("countryName")
            institutionID = lookUpRow.Item("personalID")
        End If
    End Sub
End Class