Public Class frmReservation

    Public projectID As String
    Public unitID As String
    Public tcID As String
    Public leaseID As String
    Public dtForm As New DataTable
    Public mandatoryText() As TextBox
    Public moneyTextBox() As TextBox
    Public dataTextBox() As TextBox
    Public dtpStartFlag As Boolean = False
    Public dtpEndFlag As Boolean = False
    Public maxPax As Integer
    Public TCDate As DateTime
    ' Public clear As Boolean


    Private Sub frmReservation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim setText As String = "Tenant Confirmation"
        Me.CenterToScreen()
        setFormDesign(Me)
        'settingButton(Me, "Main")
        bindBookingPartner(GlobalProjectID, "Booking Online")
        Me.Text = setText
        lblHead.Text = setText
        cmbBookingType.SelectedItem = "Room"
        cmbSource.SelectedItem = "Billboard"
    End Sub

    Private Sub btnLKProject_Click(sender As Object, e As EventArgs) Handles btnLKProject.Click
        frmLookupSite.tableName = "ProjectID"
        If frmLookupSite.ShowDialog = DialogResult.OK Then
            txtProjectName.Text = lookUpRow.Item("projectName")
            projectID = lookUpRow.Item("projectID")
            GlobalProjectID = projectID
        End If
    End Sub

    Private Sub btnLKUnit_Click(sender As Object, e As EventArgs) Handles btnLKUnit.Click
        If txtProjectName.Text = "" Then
            callMessage(3, "Select Project First")
            If msgBoxOK.ShowDialog = DialogResult.OK Then
                Exit Sub
            End If
        End If

        frmLookupSite.tableName = "MS_Unit"
        If frmLookupSite.ShowDialog = DialogResult.OK Then
            unitID = lookUpRow.Item("unitID")
            txtUnitNo.Text = lookUpRow.Item("unitNo")
            txtMaxPax.Text = lookUpRow.Item("qtyPax")
        End If
    End Sub

    Private Sub cmbVendor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbVendor.SelectedIndexChanged
        If cmbVendor.SelectedValue = "7" Then
            txtBookNo.Enabled = False
        Else
            txtBookNo.Enabled = True
        End If
    End Sub

    Public Sub bindBookingPartner(ByVal projectID As String, ByVal vendorType As String)
        Dim dtData As New DataTable

        dtData = clsReservation.getDataReservationPartner(projectID, vendorType).Tables("Data")

        Try
            If dtData.Rows.Count > 0 Then
                cmbVendor.DisplayMember = "vendorName"
                cmbVendor.ValueMember = "vendorID"
                cmbVendor.DataSource = dtData
            Else
                callMessage(3, "Data Booking Partner not Found")
                If msgBoxOK.ShowDialog = DialogResult.OK Then
                    Exit Sub
                End If
            End If
        Catch ex As Exception
            callMessage(3, "Database Connection Failed")
            If msgBoxOK.ShowDialog = DialogResult.OK Then
                Exit Sub
            End If
        End Try


    End Sub


    Private Sub btnCalculateDate_Click(sender As Object, e As EventArgs) Handles btnCalculateDate.Click

        If dtpStartFlag = False Then
            callMessage(3, "Select Start Periode Date")
            If msgBoxOK.ShowDialog = DialogResult.OK Then
                Exit Sub
            End If
        End If

        If dtpEndFlag = False Then
            callMessage(3, "Select End Periode Date")
            If msgBoxOK.ShowDialog = DialogResult.OK Then
                Exit Sub
            End If
        End If


        If validateDate(dtpStartDate.Value, dtpEndDate.Value) = True Then
            Dim stayDate() As String
            Dim month As Integer

            stayDate = Split(GetDateSpanText(dtpStartDate.Value, dtpEndDate.Value), ",")

            If Val(stayDate(0)) > 0 Then
                month = Val(stayDate(0)) * 12
            End If

            txtMonth.Text = month + Val(stayDate(1))
            txtDay.Text = stayDate(2)
        Else
            callMessage(3, "End Date Must Grater Than Start Date")
            If msgBoxOK.ShowDialog = DialogResult.OK Then
                Exit Sub
            End If

        End If
    End Sub

    Private Sub comboBoxNonEditable(sender As Object, e As KeyEventArgs) Handles cmbBookingType.KeyDown, cmbAcknowledged.KeyDown,
            cmbCondition.KeyDown, cmbCharged.KeyDown, cmbSource.KeyDown, cmbStatus.KeyDown
        e.SuppressKeyPress = True
    End Sub

    Private Sub txtNumberControl(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtRental.KeyPress,
        txtSecurityDeposit.KeyPress, txtPaxRate.KeyPress, txtPax.KeyPress, txtDepositHeld.KeyPress, txtAdjustmentDeposit.KeyPress
        If Not IsNumeric(e.KeyChar) And Not e.KeyChar = ChrW(Keys.Back) Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click

        clearForm(Me)

        'settingButton(Me, "AddNew")
    End Sub

    Private Sub txtRental_TextChanged(sender As Object, e As EventArgs) Handles txtRental.TextChanged
        txtRental.SelectionStart = Microsoft.VisualBasic.Len(txtRental.Text)
        If txtRental.Text IsNot "" Then
            txtRental.Text = FormatNumber(txtRental.Text, 0)
            txtTax.Text = FormatNumber((Val(Microsoft.VisualBasic.Str(txtRental.Text)) * 0.1), 0)
            'txtTotal.Text = FormatNumber((Val(Microsoft.VisualBasic.Str(txtRental.Text)) +
            '                             Val(Microsoft.VisualBasic.Str(txtTax.Text))), 0)
        Else
            txtTax.Text = 0
            txtTotal.Text = 0
        End If

    End Sub

    Private Sub txtTelephoneDeposit_TextChanged(sender As Object, e As EventArgs) Handles txtTelephoneDeposit.TextChanged
        txtTelephoneDeposit.SelectionStart = Microsoft.VisualBasic.Len(txtTelephoneDeposit.Text)

        If txtTelephoneDeposit.Text IsNot "" Then
            txtTelephoneDeposit.Text = FormatNumber(txtTelephoneDeposit.Text, 0)

            If txtSecurityDeposit.Text = "" Then
                txtTotalDeposit.Text = FormatNumber(txtTelephoneDeposit.Text, 0)
            Else
                txtTotalDeposit.Text = FormatNumber((Val(Microsoft.VisualBasic.Str(txtSecurityDeposit.Text)) +
                                    Val(Microsoft.VisualBasic.Str(txtTelephoneDeposit.Text))), 0)
            End If
        Else

            If txtSecurityDeposit.Text = "" Then
                txtTotalDeposit.Text = 0
            Else
                txtTotalDeposit.Text = FormatNumber(Val(Microsoft.VisualBasic.Str(txtSecurityDeposit.Text)), 0)
            End If

        End If


    End Sub

    Private Sub txtSecurityDepost_TextChanged(sender As Object, e As EventArgs) Handles txtSecurityDeposit.TextChanged
        txtSecurityDeposit.SelectionStart = Microsoft.VisualBasic.Len(txtSecurityDeposit.Text)

        If txtSecurityDeposit.Text IsNot "" Then
            txtSecurityDeposit.Text = FormatNumber(txtSecurityDeposit.Text, 0)

            If txtTelephoneDeposit.Text = "" Then
                txtTotalDeposit.Text = FormatNumber(txtSecurityDeposit.Text, 0)
            Else
                txtTotalDeposit.Text = FormatNumber((Val(Microsoft.VisualBasic.Str(txtSecurityDeposit.Text)) +
                                    Val(Microsoft.VisualBasic.Str(txtTelephoneDeposit.Text))), 0)
            End If
        Else

            If txtTelephoneDeposit.Text = "" Then
                txtTotalDeposit.Text = 0
            Else
                txtTotalDeposit.Text = FormatNumber(Val(Microsoft.VisualBasic.Str(txtTelephoneDeposit.Text)), 0)
            End If

        End If

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        If (btnClose.Text).Contains("Cancel") Then
            settingButton(Me, "Cancel")
            If dtForm.Rows.Count > 0 Then
                bindDataFormByTC(dtForm)
            End If
        Else
            settingButton(Me, "Close")
            Me.Close()
        End If
    End Sub


    Public Sub bindDataFormByTC(ByVal dtData As DataTable)

        If dtData.Rows.Count > 0 And dtData IsNot Nothing Then
            projectID = dtData.Rows(0).Item("projectID")
            TCDate = dtData.Rows(0).Item("tcDate")
            tcID = dtData.Rows(0).Item("tcID")
            txtTCNo.Text = dtData.Rows(0).Item("tcNo")
            unitID = dtData.Rows(0).Item("unitID")
            cmbBookingType.SelectedItem = dtData.Rows(0).Item("bookingType")
            txtUnitNo.Text = dtData.Rows(0).Item("unitNo")
            txtReservationNo.Text = dtData.Rows(0).Item("reservationNo")
            txtLeaseNo.Text = dtData.Rows(0).Item("leaseNo")
            chkDaily.Checked = dtData.Rows(0).Item("isDaily")
            cmbVendor.SelectedValue = dtData.Rows(0).Item("vendorID")
            txtBookNo.Text = dtData.Rows(0).Item("vendorBookNo")
            txtPersonalName.Text = dtData.Rows(0).Item("tenantName")
            txtCompany.Text = dtData.Rows(0).Item("companyName")
            txtAddress.Text = dtData.Rows(0).Item("tenantAddress")
            txtPhone.Text = dtData.Rows(0).Item("tenantPhone")
            txtFacsimile.Text = dtData.Rows(0).Item("tenantFacsimile")
            txtHandphone.Text = dtData.Rows(0).Item("tenantHandphone")
            cmbSource.SelectedItem = dtData.Rows(0).Item("sourceInformation")
            cmbStatus.SelectedItem = dtData.Rows(0).Item("leaseStatus")
            dtpStartDate.Value = dtData.Rows(0).Item("beginPeriode")
            dtpEndDate.Value = dtData.Rows(0).Item("endPeriode")
            txtDay.Text = dtData.Rows(0).Item("countDay")
            txtMonth.Text = dtData.Rows(0).Item("countMonth")
            cmbCharged.SelectedItem = dtData.Rows(0).Item("chargedTarget")
            txtContactPerson.Text = dtData.Rows(0).Item("contactPerson")
            txtCPAddress.Text = dtData.Rows(0).Item("cpAddress")
            txtCPPhone.Text = dtData.Rows(0).Item("cpPhone")
            txtCPFacsimile.Text = dtData.Rows(0).Item("cpFacsimile")
            txtCPHandphone.Text = dtData.Rows(0).Item("cpHandphone")
            cmbCondition.SelectedItem = dtData.Rows(0).Item("condition")
            txtNote.Text = dtData.Rows(0).Item("Note")
            txtPaxRate.Text = FormatNumber((Val(Microsoft.VisualBasic.Str(dtData.Rows(0).Item("paxRate")))), 0)
            txtPax.Text = FormatNumber((Val(Microsoft.VisualBasic.Str(dtData.Rows(0).Item("totalPax")))), 0)
            txtRental.Text = FormatNumber((Val(Microsoft.VisualBasic.Str(dtData.Rows(0).Item("bestPrice")))), 0)
            txtTax.Text = FormatNumber((Val(Microsoft.VisualBasic.Str(dtData.Rows(0).Item("tax")))), 0)
            txtTotal.Text = FormatNumber((Val(Microsoft.VisualBasic.Str(dtData.Rows(0).Item("total")))), 0)
            chkElectricity.Checked = dtData.Rows(0).Item("chargedElectricity")
            chkWater.Checked = dtData.Rows(0).Item("chargedWater")
            txtSecurityDeposit.Text = FormatNumber((Val(Microsoft.VisualBasic.Str(dtData.Rows(0).Item("securityDeposit")))), 0)
            txtTelephoneDeposit.Text = FormatNumber((Val(Microsoft.VisualBasic.Str(dtData.Rows(0).Item("telephoneDeposit")))), 0)
            txtPhoneLine.Text = dtData.Rows(0).Item("telephoneLine")
            txtDepositHeld.Text = FormatNumber((Val(Microsoft.VisualBasic.Str(dtData.Rows(0).Item("heldDeposit")))), 0)
            txtAdjustmentDeposit.Text = FormatNumber((Val(Microsoft.VisualBasic.Str(dtData.Rows(0).Item("adjustmentDeposit")))), 0)
            cmbAcknowledged.SelectedItem = dtData.Rows(0).Item("acknowledgedBY")
            chkActive.Checked = dtData.Rows(0).Item("isActive")
            txtLastUpdated.Text = dtData.Rows(0).Item("lastUpdated")
            txtLastUpdater.Text = dtData.Rows(0).Item("lastUpdater")
        Else
            callMessage(3, "Data not Found")
            If msgBoxOK.ShowDialog = DialogResult.OK Then
                Exit Sub
            End If
        End If

    End Sub

    Public Sub bindDataFormLeaseRoom(ByVal dtData As DataTable)

        If dtData.Rows.Count > 0 And dtData IsNot Nothing Then
            txtPersonalName.Text = dtData.Rows(0).Item("personalName")
            txtCompany.Text = dtData.Rows(0).Item("companyName")
            txtAddress.Text = dtData.Rows(0).Item("address")
            txtPhone.Text = dtData.Rows(0).Item("phone")
            txtFacsimile.Text = dtData.Rows(0).Item("facsimile")
            txtHandphone.Text = ""
            cmbStatus.SelectedItem = dtData.Rows(0).Item("leaseType")
            dtpStartDate.Value = dtData.Rows(0).Item("commencementDate")
            dtpEndDate.Value = dtData.Rows(0).Item("expiredDate")
            cmbCharged.SelectedItem = dtData.Rows(0).Item("paymentType")
            txtDay.Text = dtData.Rows(0).Item("countDay")
            txtMonth.Text = dtData.Rows(0).Item("countMonth")

        Else
            callMessage(3, "Data not Found")
            If msgBoxOK.ShowDialog = DialogResult.OK Then
                Exit Sub
            End If
        End If

    End Sub


    Public Sub bindDataFormLeasePax(ByVal dtData As DataTable)

        If dtData.Rows.Count > 0 And dtData IsNot Nothing Then
            txtPersonalName.Text = dtData.Rows(0).Item("chairmanName")
            txtCompany.Text = dtData.Rows(0).Item("companyName")
            txtAddress.Text = dtData.Rows(0).Item("address")
            txtPhone.Text = dtData.Rows(0).Item("phone")
            txtHandphone.Text = dtData.Rows(0).Item("handphone")
            cmbStatus.SelectedItem = dtData.Rows(0).Item("leaseType")
        Else
            callMessage(3, "Data not Found")
            If msgBoxOK.ShowDialog = DialogResult.OK Then
                Exit Sub
            End If
        End If

    End Sub

    Private Sub btnLKLeaseNo_Click(sender As Object, e As EventArgs) Handles btnLKLeaseNo.Click

        If txtProjectName.Text = "" Then
            callMessage(3, "Select Project First")
            If msgBoxOK.ShowDialog = DialogResult.OK Then
                Exit Sub
            End If
        End If

        If cmbBookingType.SelectedItem = "Room" Or cmbBookingType.SelectedItem = "Pax" Then
            frmLookupSite.tableName = "TR_LeaseAgreement"
        Else
            frmLookupSite.tableName = "TR_LeaseAgreementPax"
        End If


        If frmLookupSite.ShowDialog = DialogResult.OK Then
            txtLeaseNo.Text = lookUpRow.Item("leaseNo")
            leaseID = lookUpRow.Item("leaseID")

            If cmbBookingType.SelectedItem = "Room" Then
                dtForm = clsLeaseProposal.getDataLeaseAgreement(projectID, leaseID, txtLeaseNo.Text).Tables("Data")
            Else
                dtForm = clsLeaseProposal.getDataLeaseAgreementPax(projectID, leaseID).Tables("Data")
            End If


            Try
                If dtForm.Rows.Count > 0 Then
                    If cmbBookingType.SelectedItem = "Room" Then
                        bindDataFormLeaseRoom(dtForm)
                    Else
                        bindDataFormLeasePax(dtForm)
                    End If
                Else
                        callMessage(3, "Data Not Found!")
                    If msgBoxOK.ShowDialog = DialogResult.OK Then
                        Exit Sub
                    End If
                End If
            Catch ex As Exception
                callMessage(3, "Data Not Found!")
                If msgBoxOK.ShowDialog = DialogResult.OK Then
                    Exit Sub
                End If
            End Try

        End If

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim errMSG As String = ""
        Dim dtReservation As New DataTable
        Dim tcno As String = ""

        mandatoryText = {txtProjectName, txtUnitNo, txtLeaseNo, txtPersonalName}

        If validateMandatory(mandatoryText) = False Then
            callMessage(3, "Mandatory data cannot empty!")
            If msgBoxOK.ShowDialog = DialogResult.OK Then
                Exit Sub
            End If
        End If

        moneyTextBox = {txtRental, txtSecurityDeposit, txtTelephoneDeposit, txtPhoneLine,
            txtDepositHeld, txtAdjustmentDeposit, txtPaxRate, txtPax}

        validateEmptyMoney(moneyTextBox)



        'dtReservation = clsReservation.getDataReservationByTCNo(projectID, txtTCNo.Text).Tables("Data")

        If txtTCNo.Text IsNot "" Then
            callMessage(2, "Data Founded in Database. Update data?")
            If msgBoxOK.ShowDialog = DialogResult.Yes Then
                ''== Update data di database ==''

                errMSG = clsReservation.updateDataReservation(projectID, tcID, txtTCNo.Text, getServerDate(), unitID, cmbBookingType.SelectedItem,
                                                              txtReservationNo.Text, txtLeaseNo.Text, chkDaily.Checked, cmbVendor.SelectedValue, txtBookNo.Text,
                                                              txtPersonalName.Text, txtCompany.Text, txtAddress.Text, txtPhone.Text, txtFacsimile.Text,
                                                              txtHandphone.Text, cmbSource.SelectedItem, cmbStatus.SelectedItem, dtpStartDate.Value,
                                                              dtpEndDate.Value, txtMonth.Text, txtDay.Text, cmbCharged.SelectedItem, txtContactPerson.Text, txtCPAddress.Text,
                                                              txtCPPhone.Text, txtCPFacsimile.Text, txtCPHandphone.Text, cmbCondition.SelectedItem,
                                                              txtNote.Text, txtPaxRate.Text, txtPax.Text, txtRental.Text, txtTax.Text, txtTotal.Text,
                                                              chkElectricity.Checked, chkWater.Checked, txtSecurityDeposit.Text, txtPhoneLine.Text,
                                                              txtTelephoneDeposit.Text, txtTotalDeposit.Text, txtDepositHeld.Text, txtAdjustmentDeposit.Text, Username,
                                                              cmbAcknowledged.SelectedItem, chkActive.Checked, getServerDate(), Username)
            End If
        Else
            callMessage(2, "Save data?")
            If msgBoxOK.ShowDialog = DialogResult.Yes Then
                ''== Save data di database ==''

                tcno = Year(getServerDate()) & Month(getServerDate())

                tcno = clsReservation.getTCNo(projectID, tcno)

                If tcno IsNot Nothing Or Not IsDBNull(tcno) Then
                    tcno = Microsoft.VisualBasic.Right(("000" & (Val(Microsoft.VisualBasic.Right(tcno, 3)) + 1)), 3)
                Else
                    tcno = "001"
                End If

                tcno = Year(getServerDate()) & Month(getServerDate()) & tcno

                txtTCNo.Text=tcno

                errMSG = clsReservation.insertDataReservation(projectID, tcno, getServerDate(), txtUnitNo.Text, cmbBookingType.SelectedItem,
                                                              txtReservationNo.Text, txtLeaseNo.Text, chkDaily.Checked, cmbVendor.SelectedValue, txtBookNo.Text,
                                                              txtPersonalName.Text, txtCompany.Text, txtAddress.Text, txtPhone.Text, txtFacsimile.Text,
                                                              txtHandphone.Text, cmbSource.SelectedItem, cmbStatus.SelectedItem, dtpStartDate.Value,
                                                              dtpEndDate.Value, txtMonth.Text, txtDay.Text, cmbCharged.SelectedItem, txtContactPerson.Text, txtCPAddress.Text,
                                                              txtCPPhone.Text, txtCPFacsimile.Text, txtCPHandphone.Text, cmbCondition.SelectedItem,
                                                              txtNote.Text, txtPaxRate.Text, txtPax.Text, txtRental.Text, txtTax.Text, txtTotal.Text,
                                                              chkElectricity.Checked, chkWater.Checked, txtSecurityDeposit.Text, txtPhoneLine.Text,
                                                              txtTelephoneDeposit.Text, txtTotalDeposit.Text, txtDepositHeld.Text, txtAdjustmentDeposit.Text, Username,
                                                              cmbAcknowledged.SelectedItem, chkActive.Checked, getServerDate(), Username)

            End If
        End If



        If errMSG = "" Or errMSG = 1 Then
            callMessage(1, "Data has been saved")
            If msgBoxOK.ShowDialog = DialogResult.OK Then
                Exit Sub
            End If
        Else
            callMessage(3, "Data Can't Save")
            If msgBoxOK.ShowDialog = DialogResult.OK Then
                Exit Sub
            End If
        End If
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        'settingButton(Me, "Edit")
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim errMsg As String = ""

        callMessage(2, "Delete data?")
        If msgBoxOK.ShowDialog = DialogResult.Yes Then

            errMsg = clsReservation.deleteDataReservation(projectID, tcID, Now, unitID, txtLeaseNo.Text, txtPersonalName.Text,
                                                          chkActive.Checked, Now, Username)
        End If

        If errMsg <> "" Then
            callMessage(3, "Data Can't Delete")
            If msgBoxOK.ShowDialog = DialogResult.OK Then
                Exit Sub
            End If
        Else
            callMessage(1, "Data deleted successfully")
            If msgBoxOK.ShowDialog = DialogResult.OK Then
                Exit Sub
            End If
        End If

    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Dim dtData As New DataTable

        dtData = clsReservation.getDataReservationByTCNo(projectID, txtTCNo.Text).Tables("Data")

        Try
            If dtData.Rows.Count > 0 Then
                frmRptTenantConfirmation.dtData = dtData
                frmRptTenantConfirmation.Show()
            Else
                callMessage(3, "Data not Found")
                If msgBoxOK.ShowDialog = DialogResult.OK Then
                    Exit Sub
                End If
            End If
        Catch ex As Exception
            callMessage(3, "Data not Found")
            If msgBoxOK.ShowDialog = DialogResult.OK Then
                Exit Sub
            End If
        End Try



    End Sub

    Private Sub dtpStartDate_ValueChanged(sender As Object, e As EventArgs) Handles dtpStartDate.ValueChanged
        dtpStartFlag = True
    End Sub

    Private Sub dtpEndDate_ValueChanged(sender As Object, e As EventArgs) Handles dtpEndDate.ValueChanged
        dtpEndFlag = True
    End Sub

    Private Sub btnLKReservation_Click(sender As Object, e As EventArgs) Handles btnLKReservation.Click
        If txtProjectName.Text = "" Then
            callMessage(3, "Select Project First")
            If msgBoxOK.ShowDialog = DialogResult.OK Then
                Exit Sub
            End If
        End If
        frmLookupSite.tableName = "TR_ReservationNo"
        If frmLookupSite.ShowDialog = DialogResult.OK Then
            txtReservationNo.Text = lookUpRow.Item("reservationNo")
            txtUnitNo.Text = lookUpRow.Item("UnitNo")
            txtPersonalName.Text = lookUpRow.Item("personalName")
            txtMaxPax.Text = clsLookUp.getUnitbySearch(projectID, txtUnitNo.Text).Tables("Data").Rows(0).Item("qtyPax")
        End If
    End Sub

    Private Sub txtPaxRate_TextChanged(sender As Object, e As EventArgs) Handles txtPaxRate.TextChanged
        If cmbBookingType.SelectedItem = "Pax" Then
            txtPaxRate.SelectionStart = Microsoft.VisualBasic.Len(txtPaxRate.Text)
            If txtPaxRate.Text IsNot "" Then
                txtPaxRate.Text = FormatNumber(txtPaxRate.Text, 0)
                If txtPaxRate.Text = "" Or txtPax.Text = "" Then
                    txtRental.Text = 0
                End If
                If txtPaxRate.Text <> "" And txtPax.Text <> "" Then
                    'txtTotal.Text = FormatNumber((Val(Microsoft.VisualBasic.Str(txtPaxRate.Text)) * (Val(Microsoft.VisualBasic.Str(txtPax.Text)))), 0)
                    txtRental.Text = FormatNumber(((Val(Microsoft.VisualBasic.Str(txtTotal.Text)) / 110) * 100), 0)
                    txtTax.Text = FormatNumber(((Val(Microsoft.VisualBasic.Str(txtTotal.Text)) / 110) * 10), 0)
                End If
            Else
                txtTotal.Text = 0
                txtRental.Text = 0
            End If

        End If

    End Sub

    Private Sub txtPax_TextChanged(sender As Object, e As EventArgs) Handles txtPax.TextChanged
        If cmbBookingType.SelectedItem = "Pax" Then
            txtPax.SelectionStart = Microsoft.VisualBasic.Len(txtPax.Text)
            If txtPax.Text IsNot "" Then
                txtPax.Text = FormatNumber(txtPax.Text, 0)
                If txtPaxRate.Text = "" Or txtPax.Text = "" Then
                    txtRental.Text = 0
                End If
                If txtPax.Text <> "" And txtTotal.Text IsNot "" Then

                    'txtTotal.Text = FormatNumber((Val(Microsoft.VisualBasic.Str(txtPaxRate.Text)) * (Val(Microsoft.VisualBasic.Str(txtPax.Text)))), 0)
                    txtRental.Text = FormatNumber(((Val(Microsoft.VisualBasic.Str(txtTotal.Text)) / 110) * 100), 0)
                    txtTax.Text = FormatNumber(((Val(Microsoft.VisualBasic.Str(txtTotal.Text)) / 110) * 10), 0)
                    txtPaxRate.Text = FormatNumber(((((Val(Microsoft.VisualBasic.Str(txtTotal.Text)) / 110) * 100)) / Val(txtPax.Text)), 0)

                End If
            Else
                'txtTotal.Text = 0
                txtRental.Text = 0
                txtPaxRate.Text = 0
            End If

        End If

    End Sub


    Private Sub btnLKTCNo_Click(sender As Object, e As EventArgs) Handles btnLKTCNo.Click
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

    Private Sub chkIsSDA_CheckedChanged(sender As Object, e As EventArgs) Handles chkIsSDA.CheckedChanged
        dataTextBox = {txtContactPerson, txtCPAddress, txtCPPhone, txtCPFacsimile, txtCPHandphone}

        If chkIsSDA.Checked = True Then
            For Each textbox As TextBox In dataTextBox
                textbox.Text = "SDA"
            Next
        Else
            For Each textbox As TextBox In dataTextBox
                textbox.Text = ""
            Next
        End If
    End Sub

    Private Sub cmbBookingType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbBookingType.SelectedIndexChanged
        If cmbBookingType.SelectedItem = "Pax" Then
            txtPax.Enabled = True
            'txtPaxRate.Enabled = True
        Else
            txtPax.Enabled = False
            'txtPaxRate.Enabled = False
            txtPax.Text = ""
            txtPaxRate.Text = ""
        End If
    End Sub

    Private Sub txtDepositHeld_TextChanged(sender As Object, e As EventArgs) Handles txtDepositHeld.TextChanged
        txtDepositHeld.SelectionStart = Microsoft.VisualBasic.Len(txtDepositHeld.Text)
        If txtDepositHeld.Text IsNot "" Then
            txtDepositHeld.Text = FormatNumber(txtDepositHeld.Text, 0)
        End If
    End Sub

    Private Sub txtAdjustmentDeposit_TextChanged(sender As Object, e As EventArgs) Handles txtAdjustmentDeposit.TextChanged
        txtAdjustmentDeposit.SelectionStart = Microsoft.VisualBasic.Len(txtAdjustmentDeposit.Text)
        If txtAdjustmentDeposit.Text IsNot "" Then
            txtAdjustmentDeposit.Text = FormatNumber(txtAdjustmentDeposit.Text, 0)
        End If
    End Sub

    Private Sub chkIncoming_CheckedChanged(sender As Object, e As EventArgs) Handles chkIncoming.CheckedChanged
        If chkIncoming.Checked Then
            txtReservationNo.Text = Year(getServerDate()) & Microsoft.VisualBasic.Right("00" & Month(getServerDate()), 2) &
               Microsoft.VisualBasic.Right("00" & Microsoft.VisualBasic.DateAndTime.Day(getServerDate()), 2) &
                Microsoft.VisualBasic.Right("00" & Hour(getServerDate()), 2) &
                Microsoft.VisualBasic.Right("00" & Minute(getServerDate()), 2) &
                 Microsoft.VisualBasic.Right("00" & Second(getServerDate()), 2)
        Else
            txtReservationNo.Text = ""
        End If
    End Sub

    Private Sub chkDaily_CheckedChanged(sender As Object, e As EventArgs) Handles chkDaily.CheckedChanged
        Dim strLeaseCode As String = System.Configuration.ConfigurationManager.AppSettings("formatLeasedaily")

        If chkDaily.Checked Then
            txtLeaseNo.Text = strLeaseCode & Year(getServerDate()) & Microsoft.VisualBasic.Right("00" & Month(getServerDate()), 2) &
               Microsoft.VisualBasic.Right("00" & Microsoft.VisualBasic.DateAndTime.Day(getServerDate()), 2) &
                Microsoft.VisualBasic.Right("00" & Hour(getServerDate()), 2) &
                Microsoft.VisualBasic.Right("00" & Minute(getServerDate()), 2) &
                 Microsoft.VisualBasic.Right("00" & Second(getServerDate()), 2)
        Else
            txtLeaseNo.Text = ""
        End If
    End Sub

    Private Sub txtTotal_TextChanged(sender As Object, e As EventArgs) Handles txtTotal.TextChanged
        txtTotal.SelectionStart = Microsoft.VisualBasic.Len(txtTotal.Text)
        If txtTotal.Text IsNot "" Then
            txtTotal.Text = FormatNumber(txtTotal.Text, 0)
            If cmbBookingType.SelectedItem = "Room" Then
                txtRental.Text = FormatNumber((Val(Microsoft.VisualBasic.Str((txtTotal.Text))) / 1.1))
            Else
                If txtPax.Text IsNot "" Then
                    txtPaxRate.Text = FormatNumber(((Val(Microsoft.VisualBasic.Str((txtTotal.Text))) / 1.1) / Val(txtPax.Text)))
                End If
            End If
        Else
            If cmbBookingType.SelectedItem = "Room" Then
                txtRental.Text = ""
            Else
                txtPaxRate.Text = ""
            End If
        End If
    End Sub

End Class