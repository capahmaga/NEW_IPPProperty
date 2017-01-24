Public Class frmMSBankAccount

    Public bankID As Integer
    Public mandatoryText() As TextBox
    Public personalType As String

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        settingButton(Me, "AddNew")
    End Sub

    Private Sub frmMSBankAccount_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        setFormDesign(Me)
        bindAccountType()
        bindCurrency()
    End Sub

    Public Sub bindAccountType()
        Dim dtAccountType As New DataTable

        dtAccountType = clsConnect.getAllData("MS_AccountType", "accountTypeID, accountTypeName").Tables("Data")
        If dtAccountType.Rows.Count > 0 Then
            cmbAccountType.DataSource = dtAccountType
            cmbAccountType.DisplayMember = "accountTypeName"
            cmbAccountType.ValueMember = "accountTypeID"

        Else
            callMessage(3, "Data Account Type not Found")
            If msgBoxOK.ShowDialog = DialogResult.OK Then
                Exit Sub
            End If
        End If

    End Sub

    Public Sub bindCurrency()
        Dim dtCurrency As New DataTable

        dtCurrency = clsConnect.getAllData("MS_Currency", "currencyID, currencyName").Tables("Data")

        If dtCurrency.Rows.Count > 0 Then
            cmbCurrency.DataSource = dtCurrency
            cmbCurrency.DisplayMember = ""
            cmbCurrency.ValueMember = ""
        End If

    End Sub

    Private Sub btnLKID_Click(sender As Object, e As EventArgs) Handles btnLKID.Click
        frmLookupSite.tableName = "MS_Bank"

        If frmLookupSite.ShowDialog = DialogResult.OK Then
            bankID = lookUpRow.Item("bankID")
            txtBank.Text = lookUpRow.Item("bankName")
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        mandatoryText = {txtBank, txtBankCode, txtBranchName, txtAccountNo}

        If cmbAccountType.SelectedValue.ToString = "" Then
            callMessage(3, "Choose Account First")
            If msgBoxOK.ShowDialog = DialogResult.OK Then
                Exit Sub
            End If
        End If

        If cmbCurrency.SelectedValue.ToString = "" Then
            callMessage(3, "Choose Currency First")
            If msgBoxOK.ShowDialog = DialogResult.OK Then
                Exit Sub
            End If
        End If

        If validateMandatory(mandatoryText) = False Then
            MessageBox.Show("Mandatory data cannot empty!", "Warning")
            Exit Sub
        End If

        If personalType = "PersonalIdentity" Then
            If frmMSPersonalIdentity.dgvBankAccount.RowCount > 0 Then

                For i As Integer = 0 To frmMSPersonalIdentity.dgvBankAccount.RowCount - 1
                    If frmMSPersonalIdentity.dgvBankAccount.Rows(i).Cells(0).Value = cmbAccountType.SelectedValue Then
                        callMessage(2, "Update data?")
                        If msgBoxOK.ShowDialog = DialogResult.Yes Then
                            frmMSPersonalIdentity.dgvBankAccount.Rows(i).Cells(0).Value = bankID
                            frmMSPersonalIdentity.dgvBankAccount.Rows(i).Cells(1).Value = txtBank.Text
                            frmMSPersonalIdentity.dgvBankAccount.Rows(i).Cells(2).Value = cmbAccountType.SelectedValue
                            frmMSPersonalIdentity.dgvBankAccount.Rows(i).Cells(3).Value = cmbAccountType.Text
                            frmMSPersonalIdentity.dgvBankAccount.Rows(i).Cells(4).Value = cmbCurrency.SelectedValue
                            frmMSPersonalIdentity.dgvBankAccount.Rows(i).Cells(5).Value = cmbCurrency.Text
                            frmMSPersonalIdentity.dgvBankAccount.Rows(i).Cells(6).Value = txtAccountNo.Text
                            frmMSPersonalIdentity.dgvBankAccount.Rows(i).Cells(7).Value = txtBranchName.Text
                            frmMSPersonalIdentity.dgvBankAccount.Rows(i).Cells(8).Value = txtAccountRemarks.Text
                            If chkActive.Checked = True Then
                                frmMSPersonalIdentity.dgvBankAccount.Rows(i).Cells(9).Value = True
                            Else
                                frmMSPersonalIdentity.dgvBankAccount.Rows(i).Cells(9).Value = False
                            End If

                            frmMSPersonalIdentity.dgvBankAccount.Rows(i).Cells(10).Value = txtLastUpdated.Text
                            frmMSPersonalIdentity.dgvBankAccount.Rows(i).Cells(11).Value = txtLastUpdater.Text

                        End If
                    End If
                Next
            Else
                frmMSPersonalIdentity.dgvBankAccount.ColumnCount = 12
                frmMSPersonalIdentity.dgvBankAccount.Columns(0).Name = "Bank ID"
                frmMSPersonalIdentity.dgvBankAccount.Columns(1).Name = "Bank"
                frmMSPersonalIdentity.dgvBankAccount.Columns(2).Name = "Account Type ID"
                frmMSPersonalIdentity.dgvBankAccount.Columns(3).Name = "Account Type"
                frmMSPersonalIdentity.dgvBankAccount.Columns(4).Name = "Currency ID"
                frmMSPersonalIdentity.dgvBankAccount.Columns(5).Name = "Currency"
                frmMSPersonalIdentity.dgvBankAccount.Columns(6).Name = "Account No"
                frmMSPersonalIdentity.dgvBankAccount.Columns(7).Name = "Branch Name"
                frmMSPersonalIdentity.dgvBankAccount.Columns(8).Name = "Remarks"
                frmMSPersonalIdentity.dgvBankAccount.Columns(9).Name = "Active"
                frmMSPersonalIdentity.dgvBankAccount.Columns(10).Name = "Last Updated"
                frmMSPersonalIdentity.dgvBankAccount.Columns(11).Name = "Last Updater"

                Dim row As String() = New String() {bankID, txtBank.Text, cmbAccountType.SelectedValue, cmbAccountType.Text,
                                               cmbCurrency.SelectedValue, cmbCurrency.Text, txtAccountNo.Text,
                                               txtBranchName.Text, txtAccountRemarks.Text, chkActive.Checked,
                                               txtLastUpdated.Text, txtLastUpdater.Text}
                frmMSPersonalIdentity.dgvAddress.Rows.Add(row)
            End If
        End If

        If personalType = "PersonalInstitution" Then
            If frmMSPersonalInstitution.dgvBankAccount.RowCount > 0 Then

                For i As Integer = 0 To frmMSPersonalInstitution.dgvBankAccount.RowCount - 1
                    If frmMSPersonalInstitution.dgvBankAccount.Rows(i).Cells(0).Value = cmbAccountType.SelectedValue Then
                        callMessage(2, "Update data?")
                        If msgBoxOK.ShowDialog = DialogResult.Yes Then
                            frmMSPersonalInstitution.dgvBankAccount.Rows(i).Cells(0).Value = bankID
                            frmMSPersonalInstitution.dgvBankAccount.Rows(i).Cells(1).Value = txtBank.Text
                            frmMSPersonalInstitution.dgvBankAccount.Rows(i).Cells(2).Value = cmbAccountType.SelectedValue
                            frmMSPersonalInstitution.dgvBankAccount.Rows(i).Cells(3).Value = cmbAccountType.Text
                            frmMSPersonalInstitution.dgvBankAccount.Rows(i).Cells(4).Value = cmbCurrency.SelectedValue
                            frmMSPersonalInstitution.dgvBankAccount.Rows(i).Cells(5).Value = cmbCurrency.Text
                            frmMSPersonalInstitution.dgvBankAccount.Rows(i).Cells(6).Value = txtAccountNo.Text
                            frmMSPersonalInstitution.dgvBankAccount.Rows(i).Cells(7).Value = txtBranchName.Text
                            frmMSPersonalInstitution.dgvBankAccount.Rows(i).Cells(8).Value = txtAccountRemarks.Text
                            If chkActive.Checked = True Then
                                frmMSPersonalInstitution.dgvBankAccount.Rows(i).Cells(9).Value = True
                            Else
                                frmMSPersonalInstitution.dgvBankAccount.Rows(i).Cells(9).Value = False
                            End If

                            frmMSPersonalInstitution.dgvBankAccount.Rows(i).Cells(10).Value = txtLastUpdated.Text
                            frmMSPersonalInstitution.dgvBankAccount.Rows(i).Cells(11).Value = txtLastUpdater.Text

                        End If
                    End If
                Next
            Else
                frmMSPersonalInstitution.dgvBankAccount.ColumnCount = 12
                frmMSPersonalInstitution.dgvBankAccount.Columns(0).Name = "Bank ID"
                frmMSPersonalInstitution.dgvBankAccount.Columns(1).Name = "Bank"
                frmMSPersonalInstitution.dgvBankAccount.Columns(2).Name = "Account Type ID"
                frmMSPersonalInstitution.dgvBankAccount.Columns(3).Name = "Account Type"
                frmMSPersonalInstitution.dgvBankAccount.Columns(4).Name = "Currency ID"
                frmMSPersonalInstitution.dgvBankAccount.Columns(5).Name = "Currency"
                frmMSPersonalInstitution.dgvBankAccount.Columns(6).Name = "Account No"
                frmMSPersonalInstitution.dgvBankAccount.Columns(7).Name = "Branch Name"
                frmMSPersonalInstitution.dgvBankAccount.Columns(8).Name = "Remarks"
                frmMSPersonalInstitution.dgvBankAccount.Columns(9).Name = "Active"
                frmMSPersonalInstitution.dgvBankAccount.Columns(10).Name = "Last Updated"
                frmMSPersonalInstitution.dgvBankAccount.Columns(11).Name = "Last Updater"

                Dim row As String() = New String() {bankID, txtBank.Text, cmbAccountType.SelectedValue, cmbAccountType.Text,
                                               cmbCurrency.SelectedValue, cmbCurrency.Text, txtAccountNo.Text,
                                               txtBranchName.Text, txtAccountRemarks.Text, chkActive.Checked,
                                               txtLastUpdated.Text, txtLastUpdater.Text}
                frmMSPersonalInstitution.dgvAddress.Rows.Add(row)
            End If
        End If

        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub
End Class