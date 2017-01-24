Public Class frmAddress

    Public mandatoryText() As TextBox
    Public countryID As String
    Public personalType As String

    Private Sub frmAddress_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        setFormDesign(Me)
        bindAddressType()
    End Sub

    Public Sub bindAddressType()
        Dim dtAddress As New DataTable

        dtAddress = clsConnect.getAllData("MS_AddressType", " addressTypeId, AddressTypeName ").Tables("Data")
        If dtAddress.Rows.Count > 0 Then
            cmbAddressType.DataSource = dtAddress
            cmbAddressType.DisplayMember = "AddressTypeName"
            cmbAddressType.ValueMember = "addressTypeId"

        Else
            callMessage(3, "Data Address Type Not Found")
            If msgBoxOK.ShowDialog = DialogResult.OK Then
                Exit Sub
            End If
        End If
    End Sub

    Private Sub btnLKCountry_Click(sender As Object, e As EventArgs) Handles btnLKCountry.Click
        frmLookupSite.tableName = "MS_Country"

        If frmLookupSite.ShowDialog = DialogResult.OK Then
            txtCountry.Text = lookUpRow.Item("countryName")
            countryID = lookUpRow.Item("countryID")
        End If
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        settingButton(Me, "AddNew")
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        mandatoryText = {txtAddress}

        If cmbAddressType.SelectedValue.ToString = "" Then
            callMessage(3, "Choose Address Type First")
            If msgBoxOK.ShowDialog = DialogResult.OK Then
                Exit Sub
            End If
        End If

        If validateMandatory(mandatoryText) = False Then
            MessageBox.Show("Mandatory data cannot empty!", "Warning")
            Exit Sub
        End If

        If personalType = "PersonalIdentity" Then
            If frmMSPersonalIdentity.dgvAddress.RowCount > 0 Then
                For i As Integer = 0 To frmMSPersonalIdentity.dgvAddress.RowCount - 1
                    If frmMSPersonalIdentity.dgvAddress.Rows(i).Cells(0).Value = cmbAddressType.SelectedValue Then
                        callMessage(2, "Update data?")
                        If msgBoxOK.ShowDialog = DialogResult.Yes Then
                            frmMSPersonalIdentity.dgvAddress.Rows(i).Cells(0).Value = cmbAddressType.SelectedValue
                            frmMSPersonalIdentity.dgvAddress.Rows(i).Cells(1).Value = txtAddress.Text
                            frmMSPersonalIdentity.dgvAddress.Rows(i).Cells(2).Value = txtCity.Text
                            frmMSPersonalIdentity.dgvAddress.Rows(i).Cells(3).Value = txtProvince.Text
                            frmMSPersonalIdentity.dgvAddress.Rows(i).Cells(4).Value = txtCountry.Text
                            frmMSPersonalIdentity.dgvAddress.Rows(i).Cells(5).Value = txtZipCode.Text
                        End If
                    End If
                Next

            Else
                frmMSPersonalIdentity.dgvAddress.ColumnCount = 6
                frmMSPersonalIdentity.dgvAddress.Columns(0).Name = "Address Type"
                frmMSPersonalIdentity.dgvAddress.Columns(1).Name = "Address"
                frmMSPersonalIdentity.dgvAddress.Columns(2).Name = "City"
                frmMSPersonalIdentity.dgvAddress.Columns(3).Name = "Province"
                frmMSPersonalIdentity.dgvAddress.Columns(4).Name = "Country"
                frmMSPersonalIdentity.dgvAddress.Columns(5).Name = "Zipcode"

                Dim row As String() = New String() {cmbAddressType.SelectedValue, txtAddress.Text,
                                                    txtCity.Text, txtProvince.Text, txtCountry.Text, txtZipCode.Text}
                frmMSPersonalIdentity.dgvAddress.Rows.Add(row)
            End If
        End If

        '==========================================================================
        '' Beginning for form Institution
        '==========================================================================

        If personalType = "PersonalInstitution" Then
            If frmMSPersonalInstitution.dgvAddress.RowCount > 0 Then
                For i As Integer = 0 To frmMSPersonalInstitution.dgvAddress.RowCount - 1
                    If frmMSPersonalInstitution.dgvAddress.Rows(i).Cells(0).Value = cmbAddressType.SelectedValue Then
                        callMessage(2, "Update data?")
                        If msgBoxOK.ShowDialog = DialogResult.Yes Then
                            frmMSPersonalInstitution.dgvAddress.Rows(i).Cells(0).Value = cmbAddressType.SelectedValue
                            frmMSPersonalInstitution.dgvAddress.Rows(i).Cells(1).Value = txtAddress.Text
                            frmMSPersonalInstitution.dgvAddress.Rows(i).Cells(2).Value = txtCity.Text
                            frmMSPersonalInstitution.dgvAddress.Rows(i).Cells(3).Value = txtProvince.Text
                            frmMSPersonalInstitution.dgvAddress.Rows(i).Cells(4).Value = txtCountry.Text
                            frmMSPersonalInstitution.dgvAddress.Rows(i).Cells(5).Value = txtZipCode.Text
                        End If
                    End If
                Next

            Else
                frmMSPersonalInstitution.dgvAddress.ColumnCount = 6
                frmMSPersonalInstitution.dgvAddress.Columns(0).Name = "Address Type"
                frmMSPersonalInstitution.dgvAddress.Columns(1).Name = "Address"
                frmMSPersonalInstitution.dgvAddress.Columns(2).Name = "City"
                frmMSPersonalInstitution.dgvAddress.Columns(3).Name = "Province"
                frmMSPersonalInstitution.dgvAddress.Columns(4).Name = "Country"
                frmMSPersonalInstitution.dgvAddress.Columns(5).Name = "Zipcode"

                Dim row As String() = New String() {cmbAddressType.SelectedValue, txtAddress.Text,
                                                    txtCity.Text, txtProvince.Text, txtCountry.Text, txtZipCode.Text}
                frmMSPersonalInstitution.dgvAddress.Rows.Add(row)
            End If
        End If

        Me.DialogResult = DialogResult.OK
        Me.Close()

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class