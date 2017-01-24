Public Class frmMSEmail

    Public mandatoryText() As TextBox
    Public personalType As String

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        settingButton(Me, "AddNew")
    End Sub

    Private Sub frmMSEmail_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        setFormDesign(Me)
        bindEmailType()
    End Sub

    Public Sub bindEmailType()
        Dim dtEmail As New DataTable

        dtEmail = clsConnect.getAllData("MS_EmailType", " emailTypeID, emailTypeName ").Tables("Data")
        If dtEmail.Rows.Count > 0 Then
            cmbEmailType.DataSource = dtEmail
            cmbEmailType.DisplayMember = "emailTypeName"
            cmbEmailType.ValueMember = "emailTypeID"
        Else
            callMessage(3, "Data Address Type Not Found")
            If msgBoxOK.ShowDialog = DialogResult.OK Then
                Exit Sub
            End If
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        mandatoryText = {txtEmailAddress}

        If cmbEmailType.SelectedValue.ToString = "" Then
            callMessage(3, "Choose Email Type First")
            If msgBoxOK.ShowDialog = DialogResult.OK Then
                Exit Sub
            End If
        End If

        If validateMandatory(mandatoryText) = False Then
            MessageBox.Show("Mandatory data cannot empty!", "Warning")
            Exit Sub
        End If

        If personalType = "PersonalIdentity" Then
            If frmMSPersonalIdentity.dgvEmail.RowCount > 0 Then
                For i As Integer = 0 To frmMSPersonalIdentity.dgvEmail.RowCount - 1
                    callMessage(2, "Update data?")
                    If msgBoxOK.ShowDialog = DialogResult.Yes Then
                        If frmMSPersonalIdentity.dgvEmail.Rows(i).Cells(0).Value = cmbEmailType.SelectedValue Then
                            frmMSPersonalIdentity.dgvEmail.Rows(i).Cells(0).Value = cmbEmailType.SelectedValue
                            frmMSPersonalIdentity.dgvEmail.Rows(i).Cells(1).Value = txtEmailAddress.Text
                            frmMSPersonalIdentity.dgvEmail.Rows(i).Cells(2).Value = txtEmailRemarks.Text
                        End If
                    End If
                Next
            Else
                frmMSPersonalIdentity.dgvEmail.ColumnCount = 4
                frmMSPersonalIdentity.dgvEmail.Columns(0).Name = "Email Type"
                frmMSPersonalIdentity.dgvEmail.Columns(1).Name = "Email Address"
                frmMSPersonalIdentity.dgvEmail.Columns(2).Name = "Remarks"

                Dim row As String() = New String() {cmbEmailType.SelectedValue, txtEmailAddress.Text,
                                                txtEmailRemarks.Text}
                frmMSPersonalIdentity.dgvAddress.Rows.Add(row)
            End If
        End If

        If personalType = "PersonalInstitution" Then
            If frmMSPersonalInstitution.dgvEmail.RowCount > 0 Then
                For i As Integer = 0 To frmMSPersonalInstitution.dgvEmail.RowCount - 1
                    callMessage(2, "Update data?")
                    If msgBoxOK.ShowDialog = DialogResult.Yes Then
                        If frmMSPersonalInstitution.dgvEmail.Rows(i).Cells(0).Value = cmbEmailType.SelectedValue Then
                            frmMSPersonalInstitution.dgvEmail.Rows(i).Cells(0).Value = cmbEmailType.SelectedValue
                            frmMSPersonalInstitution.dgvEmail.Rows(i).Cells(1).Value = txtEmailAddress.Text
                            frmMSPersonalInstitution.dgvEmail.Rows(i).Cells(2).Value = txtEmailRemarks.Text
                        End If
                    End If
                Next
            Else
                frmMSPersonalInstitution.dgvEmail.ColumnCount = 4
                frmMSPersonalInstitution.dgvEmail.Columns(0).Name = "Email Type"
                frmMSPersonalInstitution.dgvEmail.Columns(1).Name = "Email Address"
                frmMSPersonalInstitution.dgvEmail.Columns(2).Name = "Remarks"

                Dim row As String() = New String() {cmbEmailType.SelectedValue, txtEmailAddress.Text,
                                                txtEmailRemarks.Text}
                frmMSPersonalInstitution.dgvAddress.Rows.Add(row)
            End If
        End If

        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

End Class