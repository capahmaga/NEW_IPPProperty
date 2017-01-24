Imports System.Configuration
Imports System.Globalization
Imports System.Threading

Public Class frmLeaseProposal

    Public projectID As String
    Public unitID As String
    Public leaseId As String
    Public mandatoryText() As TextBox
    Public moneyTextBox() As TextBox
    Public dtpStartFlag As Boolean = False
    Public dtpEndFlag As Boolean = False
    Public dtForm As New DataTable
    Public unitTypeCode As String
    Public unitTower As String
    Public tempName As String
    Public clear As Boolean = True



    Private Sub frmLeaseProposal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim setText As String = "Lease Proposal"
        Me.CenterToScreen()
        setFormDesign(Me)
        'settingButton(Me, "Main")
        Me.Text = setText
        lblHead.Text = setText
        bindPreparedData()
        leaseId = ""
        'generateLeaseNO(1)

        Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("en-US")
        Thread.CurrentThread.CurrentUICulture = CultureInfo.CreateSpecificCulture("en-US")

    End Sub

    Private Sub btnLKProject_Click(sender As Object, e As EventArgs) Handles btnLKProject.Click
        frmLookupSite.tableName = "ProjectID"
        If frmLookupSite.ShowDialog = DialogResult.OK Then
            txtProjectName.Text = lookUpRow.Item("projectName")
            projectID = lookUpRow.Item("projectID")
        End If
    End Sub

    Private Sub btnLKUnitNo_Click(sender As Object, e As EventArgs)
        frmLookupSite.tableName = "MS_Unit"
        If frmLookupSite.ShowDialog = DialogResult.OK Then
            txtUnitNo.Text = lookUpRow.Item("countryName")
            unitID = lookUpRow.Item("unitID")
        End If
    End Sub

    Public Sub bindPaymentTerm(ByVal projectID As String)
        Dim dtData As DataTable

        dtData = clsConnect.getAllData("MS_Rate",,, " projectID=" & projectID & " and rateCategoryID=" & projectID).Tables("Data")

        If dtData.Rows.Count > 0 Or dtData IsNot Nothing Then
            cmbPaymentTerms.DisplayMember = "bloodTypeName"
            cmbPaymentTerms.ValueMember = "bloodTypeID"
            cmbPaymentTerms.DataSource = dtData
        Else
            callMessage(3, "Data not Found")
            If msgBoxOK.ShowDialog = DialogResult.OK Then
                Exit Sub
            End If
        End If

    End Sub

    Private Sub txtNumberControl(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtpublishRentalBase.KeyPress,
            txttotalPhoneDeposit.KeyPress, txtSecurityDeposit.KeyPress, txtHeldDeposit.KeyPress,
            txtbasicPhoneDeposit.KeyPress, txtlinePhone.KeyPress, txtbasicAddLaundry.KeyPress, txttotalPax.KeyPress,
            txtbasicAddBreakfast.KeyPress, txttotalPacket.KeyPress, txttotalAdjustment.KeyPress

        If Not IsNumeric(e.KeyChar) And Not e.KeyChar = ChrW(Keys.Back) Then
            e.Handled = True
        End If
    End Sub

    Public Sub bindPreparedData()
        Dim dtData As New DataTable

        dtData = clsConnect.getAllData("MS_Sales", " SalesID,SalesName ",, " isActive=1 and parentID is not null ").Tables("Data")

        If dtData.Rows.Count > 0 And dtData IsNot Nothing Then
            cmbpreparedBy.DisplayMember = "SalesName"
            cmbpreparedBy.ValueMember = "SalesID"
            cmbpreparedBy.DataSource = dtData
        Else
            callMessage(3, "Data not Found")
            If msgBoxOK.ShowDialog = DialogResult.OK Then
                Exit Sub
            End If
        End If

    End Sub


    Public Sub bindAcknowledgedData(ByVal salesID As String)
        Dim dtData As New DataTable

        dtData = clsConnect.getAllData("MS_Sales", " SalesID,SalesName ",, " isActive=1 and parentID is null or salesid in (select parentID from ms_sales where salesid=" & salesID & ")").Tables("Data")

        If dtData.Rows.Count > 0 And dtData IsNot Nothing Then
            cmbacknowledgedBy.DisplayMember = "SalesName"
            cmbacknowledgedBy.ValueMember = "SalesID"
            cmbacknowledgedBy.DataSource = dtData
        Else
            callMessage(3, "Data not Found")
            If msgBoxOK.ShowDialog = DialogResult.OK Then
                Exit Sub
            End If
        End If

    End Sub

    Public Sub bindDataForm(ByVal dtData As DataTable)

        If dtData.Rows.Count > 0 And dtData IsNot Nothing Then
            projectID = dtData.Rows(0).Item("projectID")
            leaseId = dtData.Rows(0).Item("leaseID")
            txtLeaseNo.Text = dtData.Rows(0).Item("leaseNo")
            txtPersonalName.Text = dtData.Rows(0).Item("personalName")
            chkPrivate.Checked = dtData.Rows(0).Item("isPrivate")
            txtcompanyName.Text = dtData.Rows(0).Item("companyName")
            txtAddress.Text = dtData.Rows(0).Item("address")
            txtPhone.Text = dtData.Rows(0).Item("phone")
            txtFax.Text = dtData.Rows(0).Item("facsimile")
            txtEmail.Text = dtData.Rows(0).Item("email")
            txtoccupiedBy.Text = dtData.Rows(0).Item("occupiedBy")
            cmbLeaseType.Text = dtData.Rows(0).Item("leaseType")
            unitID = dtData.Rows(0).Item("unitID")
            txtUnitNo.Text = dtData.Rows(0).Item("unitNo")
            txtUnitSize.Text = dtData.Rows(0).Item("unitSize")
            txtUnitType.Text = dtData.Rows(0).Item("unitTypeName")
            unitTypeCode = dtData.Rows(0).Item("unitTypeCode")
            If dtData.Rows(0).Item("isUpgrade") Then
                chkUpgradeUnit.Checked = True
            Else
                chkUpgradeUnit.Checked = False
            End If
            cmbCondition.Text = dtData.Rows(0).Item("conditionType")
            txtcondition.Text = dtData.Rows(0).Item("condition")
            dtpcommencementDate.Value = dtData.Rows(0).Item("commencementDate")
            dtpexpiredDate.Value = dtData.Rows(0).Item("expiredDate")
            dtpPrinted.Value = dtData.Rows(0).Item("printedDate")
            txtcountMonth.Text = dtData.Rows(0).Item("countMonth")
            txtcountDay.Text = dtData.Rows(0).Item("countDay")
            cmbPaymentTerms.Text = dtData.Rows(0).Item("paymentTerm")
            cmbPaymentType.Text = dtData.Rows(0).Item("paymentType")
            txtpublishRentalBase.Text = FormatNumber((Val(Microsoft.VisualBasic.Str(dtData.Rows(0).Item("publishRentalBase")))), 0)
            txtrentalBaseMonth.Text = FormatNumber((Val(Microsoft.VisualBasic.Str(dtData.Rows(0).Item("rentalBaseMonth")))), 0)
            txtrentalBaseDay.Text = FormatNumber((Val(Microsoft.VisualBasic.Str(dtData.Rows(0).Item("rentalBaseDay")))), 0)
            txtVAT.Text = FormatNumber((Val(Microsoft.VisualBasic.Str(dtData.Rows(0).Item("VAT")))), 0)
            txttotalAmountRental.Text = FormatNumber((Val(Microsoft.VisualBasic.Str(dtData.Rows(0).Item("totalAmountRental")))), 0)
            If dtData.Rows(0).Item("isGuaranteeLetter") Then
                chkGuaranteeLetter.Checked = True
            Else
                chkGuaranteeLetter.Checked = False
            End If
            txtSecurityDeposit.Text = FormatNumber((Val(Microsoft.VisualBasic.Str(dtData.Rows(0).Item("securityDeposit")))), 0)
            txtbasicPhoneDeposit.Text = FormatNumber((Val(Microsoft.VisualBasic.Str(dtData.Rows(0).Item("basicPhoneDeposit")))), 0)
            txtlinePhone.Text = dtData.Rows(0).Item("linePhone")
            txttotalPhoneDeposit.Text = FormatNumber((Val(Microsoft.VisualBasic.Str(dtData.Rows(0).Item("totalPhoneDeposit")))), 0)
            txttotalAdjustment.Text = FormatNumber((Val(Microsoft.VisualBasic.Str(dtData.Rows(0).Item("totalAmountDeposit")))), 0)
            txtbasicAddBreakfast.Text = FormatNumber((Val(Microsoft.VisualBasic.Str(dtData.Rows(0).Item("basicAddBreakfast")))), 0)
            txttotalPax.Text = dtData.Rows(0).Item("totalPax")
            txttotalAmountBreakfast.Text = FormatNumber((Val(Microsoft.VisualBasic.Str(dtData.Rows(0).Item("totalAmountBreakfast")))), 0)
            txtbasicAddLaundry.Text = FormatNumber((Val(Microsoft.VisualBasic.Str(dtData.Rows(0).Item("basicAddLaundry")))), 0)
            txttotalPacket.Text = dtData.Rows(0).Item("totalPacket")
            txttotalAmountAddLaundry.Text = FormatNumber((Val(Microsoft.VisualBasic.Str(dtData.Rows(0).Item("totalAmountAddLaundry")))), 0)
            txtgrandTotalAmount.Text = FormatNumber((Val(Microsoft.VisualBasic.Str(dtData.Rows(0).Item("grandTotalAmount")))), 0)
            dtpquotedValidDate.Value = dtData.Rows(0).Item("quotedValidDate")
            cmbpreparedBy.SelectedValue = dtData.Rows(0).Item("preparedBy")
            If dtData.Rows(0).Item("isUseSalesSignature") Then
                chkSignature.Checked = True

            Else
                chkSignature.Checked = False
            End If
            cmbacknowledgedBy.SelectedValue = dtData.Rows(0).Item("acknowledgedBy")
            If dtData.Rows(0).Item("isUseParentSignature") Then
                chkacknowledgedBy.Checked = True
            Else
                chkacknowledgedBy.Checked = False
            End If
            If dtData.Rows(0).Item("isActive") Then
                chkActive.Checked = True
            Else
                chkActive.Checked = False
            End If
            txtLastUpdated.Text = dtData.Rows(0).Item("lastUpdated")
            txtLastUpdater.Text = dtData.Rows(0).Item("lastUpdater")

        Else
            callMessage(3, "Data not Found")
            If msgBoxOK.ShowDialog = DialogResult.OK Then
                Exit Sub
            End If
        End If
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


        If validateDate(dtpcommencementDate.Value, dtpexpiredDate.Value) = True Then
            Dim stayDate() As String
            Dim month As Integer

            stayDate = Split(GetDateSpanText(dtpcommencementDate.Value, dtpexpiredDate.Value), ",")

            If Val(stayDate(0)) > 0 Then
                month = Val(stayDate(0)) * 12
            End If

            txtcountMonth.Text = month + Val(stayDate(1))
            txtcountDay.Text = stayDate(2)
            setTotalRental()

            dtpquotedValidDate.Value = dtpcommencementDate.Value.AddDays(-7)
        Else
            callMessage(3, "End Date Must Grater Than Start Date")
            If msgBoxOK.ShowDialog = DialogResult.OK Then
                Exit Sub
            End If

        End If
    End Sub

    Private Sub txtRental_TextChanged(sender As Object, e As EventArgs) Handles txtpublishRentalBase.TextChanged
        If clear = True Then

            If txtpublishRentalBase.Text IsNot "" Then
                txtpublishRentalBase.SelectionStart = Microsoft.VisualBasic.Len(txtpublishRentalBase.Text)
                setTotalRental()

                'If txtcountMonth.Text = "" Or txtcountDay.Text = "" Then
                '    callMessage(3, "Generate Lease Date First!")
                '    If msgBoxOK.ShowDialog = DialogResult.OK Then
                '        Exit Sub
                '    End If
                'End If
            End If
        End If
    End Sub

    Public Sub setTotalRental()
        If clear = True Then
            If txtcountMonth.Text <> "" Or txtcountDay.Text <> "" Then
                If txtpublishRentalBase.Text <> "" Then
                    txtpublishRentalBase.Text = FormatNumber(Val(Microsoft.VisualBasic.Str((txtpublishRentalBase.Text))), 0)

                    txtrentalBaseMonth.Text = FormatNumber(Val(Microsoft.VisualBasic.Str(txtcountMonth.Text)) * Val(Microsoft.VisualBasic.Str(txtpublishRentalBase.Text)), 0)
                    txtrentalBaseDay.Text = FormatNumber((Val(Microsoft.VisualBasic.Str(txtcountDay.Text)) / 30) * Val(Microsoft.VisualBasic.Str(txtpublishRentalBase.Text)), 0)
                    txtVAT.Text = FormatNumber(((Val(Microsoft.VisualBasic.Str(txtrentalBaseMonth.Text)) + Val(Microsoft.VisualBasic.Str(txtrentalBaseDay.Text))) * 0.1), 0)

                    'txttotalAmountRental.Text = FormatNumber((Val(Microsoft.VisualBasic.Str(txtrentalBaseMonth.Text)) +
                    '                                   Val(Microsoft.VisualBasic.Str(txtrentalBaseDay.Text) +
                    '                                   Val(Microsoft.VisualBasic.Str(txtVAT.Text)))), 0)
                End If

                setGrandTotal()
            End If
        End If
    End Sub

    Public Sub setGrandTotal()
        Dim total As New Decimal
        total = 0
        If txttotalAmountRental.Text <> "" Then
            total = total + Val(Microsoft.VisualBasic.Str(txttotalAmountRental.Text))
        End If
        If txttotalAdjustment.Text <> "" Then
            total = total + Val(Microsoft.VisualBasic.Str(txttotalAdjustment.Text))
        End If
        If txttotalAmountBreakfast.Text <> "" Then
            total = total + Val(Microsoft.VisualBasic.Str(txttotalAmountBreakfast.Text))
        End If
        If txttotalAmountAddLaundry.Text <> "" Then
            total = total + Val(Microsoft.VisualBasic.Str(txttotalAmountAddLaundry.Text))
        End If

        txtgrandTotalAmount.Text = FormatNumber(total, 0)

    End Sub

    Public Sub setTotalDeposit()
        Dim total As New Decimal
        total = 0
        If txtSecurityDeposit.Text <> "" Then
            total = total + Val(Microsoft.VisualBasic.Str(txtSecurityDeposit.Text))
        End If
        If txttotalPhoneDeposit.Text <> "" Then
            total = total + Val(Microsoft.VisualBasic.Str(txttotalPhoneDeposit.Text))
        End If

        txttotalAmountDeposit.Text = FormatNumber(total, 0)

        If txtHeldDeposit.Text <> "" Then
            total = total - Val(Microsoft.VisualBasic.Str(txtHeldDeposit.Text))
        End If
        txttotalAdjustment.Text = FormatNumber(total, 0)

        setGrandTotal()
    End Sub


    Private Sub txtSecurityDeposit_TextChanged(sender As Object, e As EventArgs) Handles txtSecurityDeposit.TextChanged
        If clear = True Then
            If txtSecurityDeposit.Text IsNot "" Then
                txtSecurityDeposit.SelectionStart = Microsoft.VisualBasic.Len(txtSecurityDeposit.Text)
                txtSecurityDeposit.Text = FormatNumber(Val(Microsoft.VisualBasic.Str((txtSecurityDeposit.Text))), 0)
                setTotalDeposit()
            End If
        End If
    End Sub

    Private Sub txtAmountPerLine_TextChanged(sender As Object, e As EventArgs) Handles txtbasicPhoneDeposit.TextChanged
        If clear = True Then

            If txtbasicPhoneDeposit.Text IsNot "" Then
                txtbasicPhoneDeposit.SelectionStart = Microsoft.VisualBasic.Len(txtbasicPhoneDeposit.Text)
                txtbasicPhoneDeposit.Text = FormatNumber(Val(Microsoft.VisualBasic.Str((txtbasicPhoneDeposit.Text))), 0)

                If txtbasicPhoneDeposit.Text = "" Or txtlinePhone.Text = "" Then
                    txttotalPhoneDeposit.Text = ""
                Else
                    txttotalPhoneDeposit.Text = FormatNumber(Val(Microsoft.VisualBasic.Str((txtbasicPhoneDeposit.Text))) *
                                                                Val(Microsoft.VisualBasic.Str((txtlinePhone.Text))), 0)
                    setTotalDeposit()

                End If
            End If
        End If
    End Sub

    Private Sub dtpStartDate_ValueChanged(sender As Object, e As EventArgs) Handles dtpcommencementDate.ValueChanged
        dtpStartFlag = True
    End Sub

    Private Sub dtpEndDate_ValueChanged(sender As Object, e As EventArgs) Handles dtpexpiredDate.ValueChanged
        dtpEndFlag = True
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        clear = False
        clearForm(Me)
        'settingButton(Me, "AddNew")
        clear = True
        leaseId = ""
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        If (btnClose.Text).Contains("Cancel") Then
            settingButton(Me, "Cancel")
            If dtForm.Rows.Count > 0 Then
                bindDataForm(dtForm)
            End If
        Else
            settingButton(Me, "Close")
            Me.Close()
        End If
    End Sub

    Private Sub btnLKLeaseNo_Click_1(sender As Object, e As EventArgs) Handles btnLKLeaseNo.Click
        frmLookupSite.tableName = "TR_LeaseAgreement"
        If frmLookupSite.ShowDialog = DialogResult.OK Then
            txtLeaseNo.Text = lookUpRow.Item("leaseNo")
            leaseId = lookUpRow.Item("leaseID")
            dtForm = clsLeaseProposal.getDataLeaseAgreement(projectID, leaseId, txtLeaseNo.Text).Tables("Data")
            Try
                If dtForm.Rows.Count > 0 Then
                    bindDataForm(dtForm)
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

    Private Sub btnLKUnitNo_Click_1(sender As Object, e As EventArgs) Handles btnLKUnitNo.Click
        frmLookupSite.tableName = "MS_Unit"
        If frmLookupSite.ShowDialog = DialogResult.OK Then

            unitID = lookUpRow.Item("unitID")
            GlobalUnitID = unitID
            txtUnitNo.Text = lookUpRow.Item("unitNo")
            txtUnitType.Text = lookUpRow.Item("unitTypeName")
            txtUnitSize.Text = lookUpRow.Item("unitSize")
            unitTypeCode = lookUpRow.Item("unitTypeCode")
            unitTower = lookUpRow.Item("towerName")

            If cmbLeaseType.SelectedItem = "New" Then
                txtLeaseNo.Text = generateLeaseNO(GlobalProjectID) & "/" & unitTypeCode
            ElseIf cmbLeaseType.SelectedItem = "Renewal" Then
                txtLeaseNo.Text = generateLeaseNO(GlobalProjectID) & "/" & txtUnitNo.Text
            Else
                If txtLeaseNo.Text = "" Then
                    callMessage(3, "Select Lease Number First")
                    If msgBoxOK.ShowDialog = DialogResult.OK Then
                        Exit Sub
                    End If
                End If
            End If

        End If
    End Sub

    Private Sub txtAdjusmentDeposit_TextChanged(sender As Object, e As EventArgs) Handles txtHeldDeposit.TextChanged

        If txtHeldDeposit.Text IsNot "" Then
            txtHeldDeposit.SelectionStart = Microsoft.VisualBasic.Len(txtHeldDeposit.Text)
            txtHeldDeposit.Text = FormatNumber(Val(Microsoft.VisualBasic.Str((txtHeldDeposit.Text))), 0)
            setTotalDeposit()
        End If
    End Sub

    Private Sub txtPhoneLine_TextChanged(sender As Object, e As EventArgs) Handles txtlinePhone.TextChanged
        If clear = True Then
            If txtlinePhone.Text IsNot "" Then
                txtlinePhone.SelectionStart = Microsoft.VisualBasic.Len(txtlinePhone.Text)
                txtlinePhone.Text = FormatNumber(Val(Microsoft.VisualBasic.Str((txtlinePhone.Text))), 0)

                If txtbasicPhoneDeposit.Text = "" Or txtlinePhone.Text = "" Then
                    txttotalPhoneDeposit.Text = ""
                Else
                    txttotalPhoneDeposit.Text = FormatNumber(Val(Microsoft.VisualBasic.Str((txtbasicPhoneDeposit.Text))) *
                                                                Val(Microsoft.VisualBasic.Str((txtlinePhone.Text))), 0)
                    setTotalDeposit()

                End If
            End If
        End If
    End Sub

    Private Sub cmbLeaseType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbLeaseType.SelectedIndexChanged
        If cmbLeaseType.SelectedItem = "New" Then
            txtHeldDeposit.Enabled = False
            txtHeldDeposit.Text = ""
        Else
            txtHeldDeposit.Enabled = True
        End If
        setTotalDeposit()
    End Sub

    Private Sub cmbCondition_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCondition.SelectedIndexChanged
        If cmbCondition.SelectedItem = "NSA" Then
            txtcondition.Text = "Price excludes electricity, water and gas charge, unit daily cleaning, towel and bedsheets change, water dispenser and internet connection"
        Else
            txtcondition.Text = "Price includes electricity, water and gas charge, unit daily cleaning,towel and bedsheets change, water dispenser and internet connection"
        End If
    End Sub

    Private Sub chkPrivate_CheckedChanged(sender As Object, e As EventArgs) Handles chkPrivate.CheckedChanged

        If txtcompanyName.Text <> "PRIVATE" Then
            tempName = txtcompanyName.Text
        End If
        If chkPrivate.Checked Then
            txtcompanyName.Text = "PRIVATE"
        Else
            txtcompanyName.Text = tempName
        End If
    End Sub

    Private Sub dtpQuotedExpired_ValueChanged(sender As Object, e As EventArgs) Handles dtpquotedValidDate.ValueChanged
        If clear Then
            If dtpcommencementDate.Value < dtpquotedValidDate.Value Then
                callMessage(3, "Quoted Date must be earlier or same as Commencement Date!")
                If msgBoxOK.ShowDialog = DialogResult.OK Then
                    Exit Sub
                End If
            End If
        End If
    End Sub

    Private Sub txtAddBreakfast_TextChanged(sender As Object, e As EventArgs) Handles txtbasicAddBreakfast.TextChanged
        If clear = True Then
            If txtbasicAddBreakfast.Text IsNot "" Then
                txtbasicAddBreakfast.SelectionStart = Microsoft.VisualBasic.Len(txtbasicAddBreakfast.Text)
                txtbasicAddBreakfast.Text = FormatNumber(Val(Microsoft.VisualBasic.Str((txtbasicAddBreakfast.Text))), 0)

                If txttotalPax.Text = "" Or txtbasicAddBreakfast.Text = "" Then
                    txttotalAmountBreakfast.Text = ""
                Else
                    txttotalAmountBreakfast.Text = FormatNumber(Val(Microsoft.VisualBasic.Str((txttotalPax.Text))) *
                                                                Val(Microsoft.VisualBasic.Str((txtbasicAddBreakfast.Text))), 0)
                    setGrandTotal()

                End If
            End If
        End If
    End Sub

    Private Sub txtAddLaundry_TextChanged(sender As Object, e As EventArgs) Handles txtbasicAddLaundry.TextChanged
        If clear = True Then
            If txtbasicAddLaundry.Text IsNot "" Then
                txtbasicAddLaundry.SelectionStart = Microsoft.VisualBasic.Len(txtbasicAddLaundry.Text)
                txtbasicAddLaundry.Text = FormatNumber(Val(Microsoft.VisualBasic.Str((txtbasicAddLaundry.Text))), 0)

                If txttotalPacket.Text = "" Or txtbasicAddLaundry.Text = "" Then
                    txttotalAmountAddLaundry.Text = ""
                Else
                    txttotalAmountAddLaundry.Text = FormatNumber(Val(Microsoft.VisualBasic.Str((txttotalPacket.Text))) *
                                                                Val(Microsoft.VisualBasic.Str((txtbasicAddLaundry.Text))), 0)
                    setGrandTotal()

                End If
            End If
        End If
    End Sub

    Private Sub txtPax_TextChanged(sender As Object, e As EventArgs) Handles txttotalPax.TextChanged
        If clear = True Then
            If txttotalPax.Text IsNot "" Then
                txttotalPax.SelectionStart = Microsoft.VisualBasic.Len(txttotalPax.Text)
                txttotalPax.Text = FormatNumber(Val(Microsoft.VisualBasic.Str((txttotalPax.Text))), 0)

                If txtbasicAddBreakfast.Text = "" Or txttotalPax.Text = "" Then
                    txttotalAmountBreakfast.Text = ""
                Else
                    txttotalAmountBreakfast.Text = FormatNumber(Val(Microsoft.VisualBasic.Str((txtbasicAddBreakfast.Text))) *
                                                                Val(Microsoft.VisualBasic.Str((txttotalPax.Text))), 0)
                    setGrandTotal()

                End If
            End If
        End If
    End Sub

    Private Sub txtPacket_TextChanged(sender As Object, e As EventArgs) Handles txttotalPacket.TextChanged
        If clear = True Then
            If txttotalPacket.Text IsNot "" Then
                txttotalPacket.SelectionStart = Microsoft.VisualBasic.Len(txttotalPacket.Text)
                txttotalPacket.Text = FormatNumber(Val(Microsoft.VisualBasic.Str((txttotalPacket.Text))), 0)

                If txtbasicAddLaundry.Text = "" Or txttotalPacket.Text = "" Then
                    txttotalAmountAddLaundry.Text = ""
                Else
                    txttotalAmountAddLaundry.Text = FormatNumber(Val(Microsoft.VisualBasic.Str((txtbasicAddLaundry.Text))) *
                                                                Val(Microsoft.VisualBasic.Str((txttotalPacket.Text))), 0)
                    setGrandTotal()

                End If
            End If
        End If

    End Sub

    Private Sub cmbPrepared_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbpreparedBy.SelectedIndexChanged
        bindAcknowledgedData(cmbpreparedBy.SelectedValue)
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles chkGuaranteeLetter.CheckedChanged

        If chkGuaranteeLetter.Checked = True Then
            txtSecurityDeposit.Enabled = False
            txtSecurityDeposit.Text = ""
        Else
            txtSecurityDeposit.Enabled = True
        End If
        setTotalDeposit()
    End Sub



    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim dtData As New DataTable
        Dim errMsg As String = ""

        mandatoryText = {txtProjectName, txtLeaseNo, txtUnitNo, txtgrandTotalAmount}

        If validateMandatory(mandatoryText) = False Then
            callMessage(3, "Mandatory data cannot empty!")
            If msgBoxOK.ShowDialog = DialogResult.OK Then
                Exit Sub
            End If
            Exit Sub
        End If

        moneyTextBox = {txtpublishRentalBase, txtrentalBaseMonth, txtrentalBaseDay, txtVAT, txttotalAmountRental,
            txtSecurityDeposit, txtbasicPhoneDeposit, txtlinePhone, txttotalPhoneDeposit, txttotalAdjustment,
            txtbasicAddBreakfast, txttotalPax, txtbasicAddLaundry, txttotalPacket, txttotalAmountAddLaundry,
            txtHeldDeposit, txttotalAmountDeposit, txtgrandTotalAmount}

        validateEmptyMoney(moneyTextBox)

        dtData = clsConnect.getAllData("TR_LeaseAgreement", " leaseNo ",, " projectID=" & GlobalProjectID & " and leaseno='" & txtLeaseNo.Text & "'").Tables("Data")
        todayDate = clsConnect.getServerDate

        Try
            If dtData.Rows.Count > 0 Then
                callMessage(2, "Update data?")
                If msgBoxOK.ShowDialog = DialogResult.Yes Then
                    errMsg = saveData("Update")
                End If
            Else
                callMessage(2, "Save data?")
                If msgBoxOK.ShowDialog = DialogResult.Yes Then
                    errMsg = saveData("Insert")
                End If
            End If
        Catch ex As Exception
            callMessage(3, "Failed to Connect Database")
            If msgBoxOK.ShowDialog = DialogResult.OK Then
                Exit Sub
            End If
        End Try

        If errMsg <> "1" Then
            callMessage(3, "Failed to Connect Database")
            If msgBoxOK.ShowDialog = DialogResult.OK Then
                Exit Sub
            End If
        Else
            callMessage(1, "Data Saved")
            If msgBoxOK.ShowDialog = DialogResult.OK Then
                Exit Sub
            End If
        End If



    End Sub

    Public Function saveData(ByVal saveAction As String)
        Dim errMsg As String = ""

        If saveAction = "Insert" Then
            errMsg = clsLeaseProposal.insertLeaseProposal(projectID, txtLeaseNo.Text,
                                                            txtPersonalName.Text,
                                                            chkPrivate.Checked,
                                                            txtcompanyName.Text,
                                                            txtAddress.Text,
                                                            txtPhone.Text,
                                                            txtFax.Text,
                                                            txtEmail.Text,
                                                            txtoccupiedBy.Text,
                                                            cmbLeaseType.SelectedItem,
                                                            unitID,
                                                            chkUpgradeUnit.Checked,
                                                            cmbCondition.SelectedItem,
                                                            txtcondition.Text,
                                                            dtpcommencementDate.Value.Date,
                                                            dtpexpiredDate.Value.Date,
                                                            dtpPrinted.Value.Date,
                                                            txtcountMonth.Text,
                                                            txtcountDay.Text,
                                                            cmbPaymentTerms.Text,
                                                            cmbPaymentType.Text,
                                                            txtpublishRentalBase.Text,
                                                            txtrentalBaseMonth.Text,
                                                            txtrentalBaseDay.Text,
                                                            txtVAT.Text,
                                                            txttotalAmountRental.Text,
                                                            chkGuaranteeLetter.Checked,
                                                            txtSecurityDeposit.Text,
                                                            txtbasicPhoneDeposit.Text,
                                                            txtlinePhone.Text,
                                                            txttotalPhoneDeposit.Text,
                                                           txttotalAmountDeposit.Text,
                                                           txtHeldDeposit.Text,
                                                            txttotalAdjustment.Text,
                                                            txtbasicAddBreakfast.Text,
                                                            txttotalPax.Text,
                                                            txttotalAmountBreakfast.Text,
                                                            txtbasicAddLaundry.Text,
                                                            txttotalPacket.Text,
                                                            txttotalAmountAddLaundry.Text,
                                                            txtgrandTotalAmount.Text,
                                                            dtpquotedValidDate.Value.Date,
                                                            cmbpreparedBy.SelectedValue,
                                                            chkSignature.Checked,
                                                            cmbacknowledgedBy.SelectedValue,
                                                            chkacknowledgedBy.Checked,
                                                            chkActive.Checked,
                                                            todayDate,
                                                            Username)
        Else
            errMsg = clsLeaseProposal.updateLeaseProposal(projectID, leaseId,
                                                           txtLeaseNo.Text,
                                                           txtPersonalName.Text,
                                                           chkPrivate.Checked,
                                                           txtcompanyName.Text,
                                                           txtAddress.Text,
                                                           txtPhone.Text,
                                                           txtFax.Text,
                                                           txtEmail.Text,
                                                           txtoccupiedBy.Text,
                                                           cmbLeaseType.SelectedItem,
                                                           unitID,
                                                           chkUpgradeUnit.Checked,
                                                          cmbCondition.SelectedItem,
                                                           txtcondition.Text,
                                                           dtpcommencementDate.Value,
                                                           dtpexpiredDate.Value,
                                                          dtpPrinted.Value.Date,
                                                           txtcountMonth.Text,
                                                           txtcountDay.Text,
                                                           cmbPaymentTerms.Text,
                                                           cmbPaymentType.Text,
                                                           txtpublishRentalBase.Text,
                                                           txtrentalBaseMonth.Text,
                                                           txtrentalBaseDay.Text,
                                                           txtVAT.Text,
                                                           txttotalAmountRental.Text,
                                                           chkGuaranteeLetter.Checked,
                                                           txtSecurityDeposit.Text,
                                                           txtbasicPhoneDeposit.Text,
                                                           txtlinePhone.Text,
                                                           txttotalPhoneDeposit.Text,
                                                           txttotalAmountDeposit.Text,
                                                           txtHeldDeposit.Text,
                                                           txttotalAdjustment.Text,
                                                           txtbasicAddBreakfast.Text,
                                                           txttotalPax.Text,
                                                           txttotalAmountBreakfast.Text,
                                                           txtbasicAddLaundry.Text,
                                                           txttotalPacket.Text,
                                                           txttotalAmountAddLaundry.Text,
                                                           txtgrandTotalAmount.Text,
                                                           dtpquotedValidDate.Value,
                                                           cmbpreparedBy.SelectedValue,
                                                           chkSignature.Checked,
                                                           cmbacknowledgedBy.SelectedValue,
                                                           chkacknowledgedBy.Checked,
                                                           chkActive.Checked,
                                                            todayDate,
                                                            Username)
        End If

        Return errMsg
    End Function

    Public Function generateLeaseNO(ByVal projectID As String)
        Dim leaseNo As String = ""

        'Dim test As String = "AI/PC/MGT/001-V-2016/3 Bdr"

        Dim strLeaseCode As String = ConfigurationManager.AppSettings("formatLease")
        Dim tahun As String = Now.Year
        Dim bulan As String = Now.Month
        Dim nomer As String = ""

        Dim strCode() As String

        bulan = getRomanMonth(Val(bulan))

        Dim dtData As New DataTable

        dtData = clsConnect.getAllData("TR_LeaseAgreement", "leaseNo", 1,
                                       "projectID=" & projectID & "AND SUBSTRING(leaseNo,(select charindex('-',leaseNo)+1)," & bulan.Length & ") ='" & bulan &
                                       "' AND SUBSTRING(leaseNo,(select charindex('-',leaseNo)+2+" & bulan.Length & ")," & tahun.Length & ") =" & tahun, "leaseNo", "desc").Tables("Data")


        Try
            If dtData IsNot Nothing And dtData.Rows.Count > 0 Then
                strCode = Split(dtData.Rows(0).Item("leaseNo"), "-")

                nomer = strCode(0).Substring((strLeaseCode.Length), (strCode(0).Length - strLeaseCode.Length))

                nomer = Microsoft.VisualBasic.Right("00000" & nomer + 1, nomer.Length)
            Else
                nomer = Microsoft.VisualBasic.Right("00000" & (Val(nomer) + 1), 3)
            End If
        Catch ex As Exception
            nomer = Microsoft.VisualBasic.Right("00000" & (Val(nomer) + 1), 3)
        End Try

        leaseNo = strLeaseCode & nomer & "-" & bulan & "-" & tahun
        Return leaseNo
    End Function

    'Private Sub comboBoxNonEditable(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles cmbLeaseType.KeyPress, cmbAcknowledged.KeyPress,
    '        cmbCondition.KeyPress, cmbPaymentTerms.KeyPress, cmbPaymentType.KeyPress, cmbPrepared.KeyPress
    '    e.Handled = True
    'End Sub

    Private Sub comboBoxNonEditable(sender As Object, e As KeyEventArgs) Handles cmbLeaseType.KeyDown, cmbacknowledgedBy.KeyDown,
            cmbCondition.KeyDown, cmbPaymentTerms.KeyDown, cmbPaymentType.KeyDown, cmbpreparedBy.KeyDown
        e.SuppressKeyPress = True
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Dim dtData As New DataTable

        dtData = clsLeaseProposal.getDataLeaseAgreementDoc(projectID, txtLeaseNo.Text).Tables("Data")

        Try
            If dtData.Rows.Count > 0 Then
                frmDocLeaseProposal.dtData = dtData
                frmDocLeaseProposal.Show()
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

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim errMsg As String = ""

        mandatoryText = {txtProjectName, txtLeaseNo}

        If validateMandatory(mandatoryText) = False Then
            callMessage(3, "Mandatory data cannot empty!")
            If msgBoxOK.ShowDialog = DialogResult.OK Then
                Exit Sub
            End If
            Exit Sub
        End If

        callMessage(2, "Delete data?")
        If msgBoxOK.ShowDialog = DialogResult.Yes Then
            errMsg = clsLeaseProposal.deleteLeaseProposal(projectID, leaseId, txtLeaseNo.Text, False, getServerDate(), Username)

            If errMsg <> "" Then
                callMessage(3, "Failed to Delete Data. Database Connection Failed")
                If msgBoxOK.ShowDialog = DialogResult.OK Then
                    Exit Sub
                End If
            Else
                callMessage(1, "Data Deleted")
                If msgBoxOK.ShowDialog = DialogResult.OK Then
                    Exit Sub
                End If
            End If
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnGenerateLease.Click
        If cmbLeaseType.SelectedItem = "New" Then
            If txtUnitNo.Text <> "" Then
                txtLeaseNo.Text = generateLeaseNO(GlobalProjectID) & "/" & unitTypeCode
            End If
        Else
            If txtUnitNo.Text <> "" And cmbLeaseType.SelectedItem = "Renewal" Then
                txtLeaseNo.Text = generateLeaseNO(GlobalProjectID) & "/" & txtUnitNo.Text
            End If
            If cmbLeaseType.SelectedItem = "Revision" And txtLeaseNo.Text = "" And leaseId = "" Then
                callMessage(3, "Select Lease Number First")
                If msgBoxOK.ShowDialog = DialogResult.OK Then
                    cmbLeaseType.SelectedItem = ""
                    Exit Sub
                End If
            End If
        End If
    End Sub

    Private Sub txttotalAmountRental_TextChanged(sender As Object, e As EventArgs) Handles txttotalAmountRental.TextChanged
        mandatoryText = {txtcountMonth, txtcountDay}
        If clear = True Then
            If validateMandatory(mandatoryText) = False Then
                callMessage(3, "Mandatory data cannot empty!")
                If msgBoxOK.ShowDialog = DialogResult.OK Then
                    Exit Sub
                End If
                Exit Sub
            End If
            If txttotalAmountRental.Text <> "" Then
                txttotalAmountRental.SelectionStart = Microsoft.VisualBasic.Len(txttotalAmountRental.Text)
                txtpublishRentalBase.Text = FormatNumber(Val(Microsoft.VisualBasic.Str((txttotalAmountRental.Text))) / ((Val(txtcountMonth.Text) * 1.1) + (Val(txtcountDay.Text) / 30 * 1.1)), 0)
                txttotalAmountRental.Text = FormatNumber(Val(Microsoft.VisualBasic.Str((txttotalAmountRental.Text))), 0)
            Else
                txtpublishRentalBase.Text = ""
            End If
        End If
    End Sub
End Class