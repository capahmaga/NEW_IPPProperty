Public Class frmMSPersonalIdentity

    Public ProjectID As String
    Public PersonalID As String
    Public institutionID As String
    Public mandatoryText() As TextBox

    Public Sub bindMaritalStatus(ByVal projectid As String)
        Dim dtMaritalStatus As New DataTable
        dtMaritalStatus = clsPersonal.getMaritalStatusByProjectID(projectid).Tables("Data")

        If dtMaritalStatus.Rows.Count > 0 Or dtMaritalStatus IsNot Nothing Then
            cmbMaritalStatus.DataSource = dtMaritalStatus
            cmbMaritalStatus.DisplayMember = "MaritalStatusName"
            cmbMaritalStatus.ValueMember = "MaritalStatusID"
        Else
            callMessage(3, "Data not Found")
            If msgBoxOK.ShowDialog = DialogResult.OK Then
                Exit Sub
            End If
        End If
    End Sub

    Public Sub bindBloodType(ByVal projectId As String)
        Dim dtBlood As New DataTable
        dtBlood = clsConnect.getAllData("MS_BloodType").Tables("Data")

        If dtBlood.Rows.Count > 0 Or dtBlood IsNot Nothing Then
            cmbBloodType.DataSource = dtBlood
            cmbBloodType.DisplayMember = "bloodTypeName"
            cmbBloodType.ValueMember = "bloodTypeID"
        Else
            callMessage(3, "Data not Found")
            If msgBoxOK.ShowDialog = DialogResult.OK Then
                Exit Sub
            End If
        End If
    End Sub

    Public Sub bindReligion(ByVal projectId As String)
        Dim dtReligion As New DataTable

        dtReligion = clsConnect.getAllData("MS_Religion").Tables("Data")

        If dtReligion.Rows.Count > 0 Or dtReligion IsNot Nothing Then
            cmbReligion.DataSource = dtReligion
            cmbReligion.DisplayMember = "religionName"
            cmbReligion.ValueMember = "religionID"
        Else
            callMessage(3, "Data not Found")
            If msgBoxOK.ShowDialog = DialogResult.OK Then
                Exit Sub
            End If
        End If

    End Sub

    Public Sub bindOccupation(ByVal projectId As String)
        Dim dtOccupation As New DataTable

        dtOccupation = clsConnect.getAllData("MS_Occupation").Tables("Data")

        If dtOccupation.Rows.Count > 0 Or dtOccupation IsNot Nothing Then
            cmbOccupation.DataSource = dtOccupation
            cmbOccupation.DisplayMember = "occupationName"
            cmbOccupation.ValueMember = "occupationID"
        Else
            callMessage(3, "Data not Found")
            If msgBoxOK.ShowDialog = DialogResult.OK Then
                Exit Sub
            End If
        End If

    End Sub

    Private Sub frmMSPersonalIdentity_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim setText As String = "Master Personal"
        Me.CenterToScreen()
        setFormDesign(Me)
        settingButton(Me, "Main")
        Me.Text = setText
        lblHead.Text = setText
        bindBloodType(GlobalProjectID)
        bindMaritalStatus(GlobalProjectID)
        bindReligion(GlobalProjectID)
        bindOccupation(GlobalProjectID)
        MessageBox.Show("atas")
    End Sub

    Private Sub btnAddAddress_Click_1(sender As Object, e As EventArgs) Handles btnAddAddress.Click
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
        If (btnClose.Text).Contains("Cancel") Then
            settingButton(Me, "Cancel")
        Else
            settingButton(Me, "Close")
            Me.Close()
        End If
    End Sub

    Private Sub btnLKID_Click(sender As Object, e As EventArgs) Handles btnLKID.Click
        frmLookupSite.tableName = "ProjectID"
        If frmLookupSite.ShowDialog = DialogResult.OK Then
            txtProjectName.Text = lookUpRow.Item("projectName")
            ProjectID = lookUpRow.Item("projectID")
        End If
    End Sub

    Private Sub btnLKPersonal_Click(sender As Object, e As EventArgs) Handles btnLKPersonal.Click
        frmLookupSite.tableName = "PersonalID"
        If frmLookupSite.ShowDialog = DialogResult.OK Then
            ProjectID = lookUpRow.Item("projectID")
            PersonalID = lookUpRow.Item("personalID")
            bindDataPersonal(ProjectID, PersonalID)
            settingButton(Me, "Save")
        End If
    End Sub

    Public Sub bindDataPersonal(ByVal projectID As String, ByVal personalId As String)
        Dim dtPersonal As New DataTable

        dtPersonal = clsPersonal.getPersonalByID(projectID, personalId).Tables("Data")

        If dtPersonal.Rows.Count > 0 And (dtPersonal IsNot Nothing) Then
            txtPersonalID.Text = dtPersonal.Rows(0).Item("IDNO").ToString
            txtPersonalCode.Text = dtPersonal.Rows(0).Item("personalCode").ToString
            txtProjectName.Text = dtPersonal.Rows(0).Item("projectName").ToString
            projectID = dtPersonal.Rows(0).Item("projectID").ToString
            txtPersonalName.Text = dtPersonal.Rows(0).Item("personalName").ToString
            txtNPWP.Text = dtPersonal.Rows(0).Item("NPWP").ToString
            txtCompany.Text = dtPersonal.Rows(0).Item("companyName").ToString
            If dtPersonal.Rows(0).Item("gender").ToString = "M" Then
                rbMale.Checked = True
            Else
                rbFemale.Checked = True
            End If
            'dtpBirthdate.Text = dtPersonal.Rows(0).Item("birtDate")
            txtBirthPlace.Text = dtPersonal.Rows(0).Item("birthPlace").ToString
            cmbMaritalStatus.Text = dtPersonal.Rows(0).Item("maritalStatusName").ToString
            cmbBloodType.Text = dtPersonal.Rows(0).Item("bloodTypeName").ToString
            cmbReligion.Text = dtPersonal.Rows(0).Item("religionName").ToString
            cmbOccupation.Text = dtPersonal.Rows(0).Item("occupationName").ToString
            txtCitizen.Text = dtPersonal.Rows(0).Item("citizenName").ToString
            chkActive.Checked = dtPersonal.Rows(0).Item("isActive")
            txtLastUpdated.Text = dtPersonal.Rows(0).Item("lastUpdated").ToString
            txtLastUpdater.Text = dtPersonal.Rows(0).Item("lastUpdater").ToString

            bindAddress(projectID, personalId)
            bindPhone(projectID, personalId)
            bindEmail(projectID, personalId)
            bindBankAccount(projectID, personalId)
            bindDocument(projectID, personalId)
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

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles btnLKCompany.Click
        frmLookupSite.tableName = "PersonalID"
        If frmLookupSite.ShowDialog = DialogResult.OK Then
            txtCompany.Text = lookUpRow.Item("companyName")
        End If
    End Sub

    Private Sub btnLKCitizen_Click(sender As Object, e As EventArgs) Handles btnLKCitizen.Click
        frmLookupSite.tableName = "MS_Citizen"
        If frmLookupSite.ShowDialog = DialogResult.OK Then
            txtCitizen.Text = lookUpRow.Item("citizen")
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

    Private Sub rbMale_CheckedChanged(sender As Object, e As EventArgs) Handles rbMale.CheckedChanged
        If rbMale.Checked = True Then
            rbFemale.Checked = False
        End If
    End Sub

    Private Sub rbFemale_CheckedChanged(sender As Object, e As EventArgs) Handles rbFemale.CheckedChanged
        If rbFemale.Checked = True Then
            rbMale.Checked = False
        End If
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        clearForm(Me)
        settingButton(Me, "AddNew")
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        mandatoryText = {txtPersonalCode, txtProjectName, txtPersonalName, txtPersonalID}

        If validateMandatory(mandatoryText) = False Then
            MessageBox.Show("Mandatory data cannot empty!", "Warning")
            Exit Sub
        End If

        Dim dtSave As New DataTable

        dtSave = clsConnect.getAllData("MS_Personal",,, "personalID=" & PersonalID).Tables("Data")

        If dtSave.Rows.Count > 0 Or dtSave IsNot Nothing Then
            callMessage(2, "Data Founded in Database. Update data?")
            If msgBoxOK.ShowDialog = DialogResult.Yes Then
                ''== Update data di database ==''

            End If
        Else
            callMessage(2, "Save data?")
            If msgBoxOK.ShowDialog = DialogResult.Yes Then
                ''== Save data di database ==''

            End If
        End If


    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        settingButton(Me, "Edit")
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

    End Sub
End Class