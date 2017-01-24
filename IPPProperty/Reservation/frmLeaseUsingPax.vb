
Imports System.IO

Public Class frmLeaseUsingPax
    Public leaseId As String = ""
    Public projectID As String
    Public dtForm As New DataTable
    Public contentType As String
    Public mandatoryText() As TextBox


    Private Sub frmLeaseUsingPax_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim setText As String = "Lease Proposal"
        Me.CenterToScreen()
        setFormDesign(Me)
        'settingButton(Me, "Main")
        Me.Text = setText
        lblHead.Text = setText
        leaseId = ""
    End Sub


    Private Sub btnLKProject_Click(sender As Object, e As EventArgs) Handles btnLKProject.Click
        frmLookupSite.tableName = "ProjectID"
        If frmLookupSite.ShowDialog = DialogResult.OK Then
            txtProjectName.Text = lookUpRow.Item("projectName")
            projectID = lookUpRow.Item("projectID")
        End If
    End Sub

    Private Sub btnLKLeaseNo_Click(sender As Object, e As EventArgs) Handles btnLKLeaseNo.Click
        frmLookupSite.paramSatu = cmbLeaseType.SelectedItem
        frmLookupSite.tableName = "TR_LeaseAgreementPax"
        If frmLookupSite.ShowDialog = DialogResult.OK Then
            txtLeaseNo.Text = lookUpRow.Item("leaseNo")
            leaseId = lookUpRow.Item("leaseID")
            dtForm = clsLeaseProposal.getDataLeaseAgreementPax(projectID, leaseId).Tables("Data")
            Try
                If dtForm.Rows.Count > 0 Then
                    binddataForm(dtForm)
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

    Public Sub binddataForm(ByVal dtData As DataTable)

        leaseId = dtData.Rows(0).Item("leaseID")
        txtLeaseNo.Text = dtData.Rows(0).Item("leaseNo")
        txtChairmanName.Text = dtData.Rows(0).Item("chairmanName")
        txtcompanyName.Text = dtData.Rows(0).Item("companyName")
        txtAddress.Text = dtData.Rows(0).Item("address")
        txtPhone.Text = dtData.Rows(0).Item("phone")
        txtHandphone.Text = dtData.Rows(0).Item("handphone")
        txtEmail.Text = dtData.Rows(0).Item("email")
        txtAmount.Text = dtData.Rows(0).Item("Amount")
        chkActive.Checked = dtData.Rows(0).Item("isActive")
        txtLastUpdated.Text = dtData.Rows(0).Item("LastUpdated")
        txtLastUpdater.Text = dtData.Rows(0).Item("LastUpdater")



    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        'Dim fs As FileStream

        mandatoryText = {txtProjectName, txtLeaseNo, txtChairmanName, txtAmount}

        If validateMandatory(mandatoryText) = False Then
            MessageBox.Show("Mandatory data cannot empty!", "Warning")
            Exit Sub
        End If

        'fs = New FileStream(txtAmount.Text, FileMode.Open, FileAccess.Read)
        'Dim docByte As Byte() = New Byte(fs.Length - 1) {}

        'fs.Read(docByte, 0, System.Convert.ToInt32(fs.Length))

        'fs.Close()

        Dim dtData As New DataTable
        Dim errMSG As String = ""
        Dim paramSave As Boolean = False

        callMessage(2, "Any duplicate data will update. Save data?")
        If msgBoxOK.ShowDialog = DialogResult.No Then
            Exit Sub
        End If

        dtData = clsConnect.getAllData("TR_LeasePaxDoc",,, "projectID=" & projectID & " and leaseID='" & leaseId & "'").Tables("Data")

        Try
            If dtData.Rows.Count > 0 Then
                'Update data
                paramSave = True
            Else
                'save data
                paramSave = False
            End If
        Catch ex As Exception
            paramSave = False
        End Try

        errMSG = clsLeaseUsingPax.insertDataLeaseUsingPax(projectID, leaseId, cmbLeaseType.SelectedItem, txtLeaseNo.Text, txtChairmanName.Text,
                                                        txtcompanyName.Text, txtAddress.Text, txtPhone.Text, txtHandphone.Text, txtEmail.Text,
                                                        IO.Path.GetFileName(txtAmount.Text), txtAmount.Text, paramSave, chkActive.Checked, getServerDate(), Username)

        If errMSG = "" Or errMSG = 1 Or Len(errMSG) < 10 Then
            callMessage(1, "Data Saved")
            If msgBoxOK.ShowDialog = DialogResult.OK Then
                If Not paramSave Then
                    leaseId = errMSG
                End If
                Exit Sub
            End If
        Else
            callMessage(3, "Failed to Connect Database")
            If msgBoxOK.ShowDialog = DialogResult.OK Then
                Exit Sub
            End If
        End If
    End Sub

    Private Sub txtAmount_TextChanged(sender As Object, e As EventArgs) Handles txtAmount.TextChanged
        txtAmount.SelectionStart = Microsoft.VisualBasic.Len(txtAmount.Text)
        If txtAmount.Text <> "" Then
            txtAmount.Text = FormatNumber(txtAmount.Text, 0)
        End If
    End Sub

    Private Sub txtNumberControl(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtAmount.KeyPress
        If Not IsNumeric(e.KeyChar) And Not e.KeyChar = ChrW(Keys.Back) Then
            e.Handled = True
        End If

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim errmsg As String = ""

        If leaseId = "" Then
            callMessage(3, "Select Data First")
            If msgBoxOK.ShowDialog = DialogResult.OK Then
                Exit Sub
            End If
        End If

        callMessage(2, "Delete data?")
        If msgBoxOK.ShowDialog = DialogResult.Yes Then
            errmsg = clsLeaseUsingPax.deleteDataLeaseUsingPax(projectID, leaseId, txtLeaseNo.Text, chkActive.Checked, getServerDate(), Username)
        Else
            Exit Sub
        End If


        If errmsg <> "" Then
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

    Private Sub btnEdit_Click(sender As Object, e As EventArgs)
        settingButton(Me, "Edit")
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        clearForm(Me)
        leaseId = ""
        'settingButton(Me, "AddNew")
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class