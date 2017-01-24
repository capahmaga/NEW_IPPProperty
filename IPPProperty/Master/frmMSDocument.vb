Imports System.IO

Public Class frmMSDocument

    Public mandatoryText() As TextBox
    Public personalType As String

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        settingButton(Me, "AddNew")
    End Sub

    Private Sub frmMSDocument_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        setFormDesign(Me)
        bindDocumentType()
    End Sub

    Public Sub bindDocumentType()
        Dim dtDocument As New DataTable

        dtDocument = clsConnect.getAllData("MS_EmailType", " emailTypeID, emailTypeName ").Tables("Data")
        If dtDocument.Rows.Count > 0 Then
            cmbDocumentType.DataSource = dtDocument
            cmbDocumentType.DisplayMember = "emailTypeName"
            cmbDocumentType.ValueMember = "emailTypeID"
        Else
            callMessage(3, "Data Address Type Not Found")
            If msgBoxOK.ShowDialog = DialogResult.OK Then
                Exit Sub
            End If
        End If
    End Sub

    Private Sub btnLKDocumentFile_Click(sender As Object, e As EventArgs) Handles btnLKDocumentFile.Click
        If ofdFile.ShowDialog() = DialogResult.OK Then
            pcbDocument.BackgroundImage = Image.FromFile(ofdFile.FileName)
            txtDocumentFile.Text = ofdFile.FileName
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        mandatoryText = {txtDocumentID, txtDocumentCode, txtDocumentName}

        If cmbDocumentType.Text = "" Then
            callMessage(3, "Choose Document Type First")
            If msgBoxOK.ShowDialog = DialogResult.OK Then
                Exit Sub
            End If
        End If

        If personalType = "PersonalIdentity" Then
            If frmMSPersonalIdentity.dgvDocument.RowCount > 0 Then
                For i As Integer = 0 To frmMSPersonalIdentity.dgvDocument.RowCount - 1
                    If frmMSPersonalIdentity.dgvDocument.Rows(i).Cells(0).Value = cmbDocumentType.SelectedValue Then
                        callMessage(2, "Update data?")
                        If msgBoxOK.ShowDialog = DialogResult.Yes Then
                            frmMSPersonalIdentity.dgvDocument.Rows(i).Cells(0).Value = txtDocumentID.Text
                            frmMSPersonalIdentity.dgvDocument.Rows(i).Cells(1).Value = txtDocumentCode.Text
                            frmMSPersonalIdentity.dgvDocument.Rows(i).Cells(2).Value = cmbDocumentType.Text
                            frmMSPersonalIdentity.dgvDocument.Rows(i).Cells(3).Value = txtDocumentName.Text
                            frmMSPersonalIdentity.dgvDocument.Rows(i).Cells(4).Value = txtDocumentFile.Text
                            frmMSPersonalIdentity.dgvDocument.Rows(i).Cells(5).Value = txtDocumentRemarks.Text

                            If chkActive.Checked = True Then
                                frmMSPersonalIdentity.dgvDocument.Rows(i).Cells(9).Value = True
                            Else
                                frmMSPersonalIdentity.dgvDocument.Rows(i).Cells(9).Value = False
                            End If

                            frmMSPersonalIdentity.dgvDocument.Rows(i).Cells(10).Value = txtLastUpdated.Text
                            frmMSPersonalIdentity.dgvDocument.Rows(i).Cells(11).Value = txtLastUpdater.Text

                        End If
                    End If
                Next
            Else
                frmMSPersonalIdentity.dgvDocument.ColumnCount = 12
                frmMSPersonalIdentity.dgvDocument.Columns(0).Name = "Document ID"
                frmMSPersonalIdentity.dgvDocument.Columns(1).Name = "Document Code"
                frmMSPersonalIdentity.dgvDocument.Columns(2).Name = "Document Type"
                frmMSPersonalIdentity.dgvDocument.Columns(3).Name = "Document Name"
                frmMSPersonalIdentity.dgvDocument.Columns(4).Name = "Document File"
                frmMSPersonalIdentity.dgvDocument.Columns(5).Name = "Currency"
                frmMSPersonalIdentity.dgvDocument.Columns(6).Name = "Account No"
                frmMSPersonalIdentity.dgvDocument.Columns(7).Name = "Branch Name"
                frmMSPersonalIdentity.dgvDocument.Columns(8).Name = "Remarks"
                frmMSPersonalIdentity.dgvDocument.Columns(9).Name = "Active"
                frmMSPersonalIdentity.dgvDocument.Columns(10).Name = "Last Updated"
                frmMSPersonalIdentity.dgvDocument.Columns(11).Name = "Last Updater"

                Dim row As String() = New String() {txtDocumentID.Text, txtDocumentCode.Text, cmbDocumentType.Text,
                                                    txtDocumentName.Text, txtDocumentFile.Text,
                                                   txtDocumentRemarks.Text, chkActive.Checked,
                                                   txtLastUpdated.Text, txtLastUpdater.Text}
                frmMSPersonalIdentity.dgvAddress.Rows.Add(row)
            End If
        End If

        If personalType = "PersonalInstitution" Then
            If frmMSPersonalInstitution.dgvDocument.RowCount > 0 Then
                For i As Integer = 0 To frmMSPersonalInstitution.dgvDocument.RowCount - 1
                    If frmMSPersonalInstitution.dgvDocument.Rows(i).Cells(0).Value = cmbDocumentType.SelectedValue Then
                        callMessage(2, "Update data?")
                        If msgBoxOK.ShowDialog = DialogResult.Yes Then
                            frmMSPersonalInstitution.dgvDocument.Rows(i).Cells(0).Value = txtDocumentID.Text
                            frmMSPersonalInstitution.dgvDocument.Rows(i).Cells(1).Value = txtDocumentCode.Text
                            frmMSPersonalInstitution.dgvDocument.Rows(i).Cells(2).Value = cmbDocumentType.Text
                            frmMSPersonalInstitution.dgvDocument.Rows(i).Cells(3).Value = txtDocumentName.Text
                            frmMSPersonalInstitution.dgvDocument.Rows(i).Cells(4).Value = txtDocumentFile.Text
                            frmMSPersonalInstitution.dgvDocument.Rows(i).Cells(5).Value = txtDocumentRemarks.Text

                            If chkActive.Checked = True Then
                                frmMSPersonalInstitution.dgvDocument.Rows(i).Cells(9).Value = True
                            Else
                                frmMSPersonalInstitution.dgvDocument.Rows(i).Cells(9).Value = False
                            End If

                            frmMSPersonalInstitution.dgvDocument.Rows(i).Cells(10).Value = txtLastUpdated.Text
                            frmMSPersonalInstitution.dgvDocument.Rows(i).Cells(11).Value = txtLastUpdater.Text

                        End If
                    End If
                Next
            Else
                frmMSPersonalInstitution.dgvDocument.ColumnCount = 12
                frmMSPersonalInstitution.dgvDocument.Columns(0).Name = "Document ID"
                frmMSPersonalInstitution.dgvDocument.Columns(1).Name = "Document Code"
                frmMSPersonalInstitution.dgvDocument.Columns(2).Name = "Document Type"
                frmMSPersonalInstitution.dgvDocument.Columns(3).Name = "Document Name"
                frmMSPersonalInstitution.dgvDocument.Columns(4).Name = "Document File"
                frmMSPersonalInstitution.dgvDocument.Columns(5).Name = "Currency"
                frmMSPersonalInstitution.dgvDocument.Columns(6).Name = "Account No"
                frmMSPersonalInstitution.dgvDocument.Columns(7).Name = "Branch Name"
                frmMSPersonalInstitution.dgvDocument.Columns(8).Name = "Remarks"
                frmMSPersonalInstitution.dgvDocument.Columns(9).Name = "Active"
                frmMSPersonalInstitution.dgvDocument.Columns(10).Name = "Last Updated"
                frmMSPersonalInstitution.dgvDocument.Columns(11).Name = "Last Updater"

                Dim row As String() = New String() {txtDocumentID.Text, txtDocumentCode.Text, cmbDocumentType.Text,
                                                    txtDocumentName.Text, txtDocumentFile.Text,
                                                   txtDocumentRemarks.Text, chkActive.Checked,
                                                   txtLastUpdated.Text, txtLastUpdater.Text}
                frmMSPersonalInstitution.dgvAddress.Rows.Add(row)
            End If
        End If

        Me.DialogResult = DialogResult.OK
        Me.Close()

    End Sub
End Class