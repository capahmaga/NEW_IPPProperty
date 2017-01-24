Public Class frmPhone

    Public mandatoryText() As TextBox
    Public personalType As String

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        settingButton(Me, "AddNew")
    End Sub

    Private Sub frmPhone_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        setFormDesign(Me)
        bindPhoneType()
    End Sub

    Public Sub bindPhoneType()
        Dim dtAddress As New DataTable

        dtAddress = clsConnect.getAllData("MS_PhoneType", " phoneTypeID, phoneTypeName ").Tables("Data")
        If dtAddress.Rows.Count > 0 Then
            cmbPhoneType.DataSource = dtAddress
            cmbPhoneType.DisplayMember = "phoneTypeName"
            cmbPhoneType.ValueMember = "phoneTypeID"
        Else
            callMessage(3, "Data Address Type Not Found")
            If msgBoxOK.ShowDialog = DialogResult.OK Then
                Exit Sub
            End If
        End If

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        mandatoryText = {txtPhoneCode, txtPhoneNumber}

        If cmbPhoneType.SelectedValue.ToString = "" Then
            callMessage(3, "Choose Phone Type First")
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
                    If frmMSPersonalIdentity.dgvPhone.Rows(i).Cells(0).Value = cmbPhoneType.SelectedValue Then
                        callMessage(2, "Update data?")
                        If msgBoxOK.ShowDialog = DialogResult.Yes Then
                            frmMSPersonalIdentity.dgvPhone.Rows(i).Cells(0).Value = cmbPhoneType.SelectedValue
                            frmMSPersonalIdentity.dgvPhone.Rows(i).Cells(1).Value = txtPhoneCode.Text
                            frmMSPersonalIdentity.dgvPhone.Rows(i).Cells(2).Value = txtPhoneNumber.Text
                            frmMSPersonalIdentity.dgvPhone.Rows(i).Cells(3).Value = txtRemarks.Text
                        End If
                    End If
                Next
            Else
                frmMSPersonalIdentity.dgvPhone.ColumnCount = 4
                frmMSPersonalIdentity.dgvPhone.Columns(0).Name = "Phone Type"
                frmMSPersonalIdentity.dgvPhone.Columns(1).Name = "Phone Code"
                frmMSPersonalIdentity.dgvPhone.Columns(2).Name = "Phone Number"
                frmMSPersonalIdentity.dgvPhone.Columns(3).Name = "Remarks"

                Dim row As String() = New String() {cmbPhoneType.SelectedValue, txtPhoneCode.Text,
                                                    txtPhoneNumber.Text, txtRemarks.Text}
                frmMSPersonalIdentity.dgvAddress.Rows.Add(row)
            End If
        End If

        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub
End Class