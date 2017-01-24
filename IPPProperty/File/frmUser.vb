
Public Class frmUser

    Public mandatoryText() As TextBox

    Private Sub frmUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        setFormDesign(Me)
        settingButton(Me, "Main")
        Me.Text = "Master User"
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        settingButton(Me, "AddNew")
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        mandatoryText = {txtInstitutionID, txtRolesID, txtUsername, txtPassword, txtRePassword, txtLevelApproval}

        If validateMandatory(mandatoryText) = False Then
            callMessage(3, "Mandatory data cannot empty!")
            If msgBoxOK.ShowDialog = DialogResult.OK Then
                Exit Sub
            End If
            Exit Sub
        End If

        If txtPassword.Text <> txtRePassword.Text Then
            callMessage(3, "Password and Retype Password does not match")
            If msgBoxOK.ShowDialog = DialogResult.OK Then
                Exit Sub
            End If
        End If
        Dim isActive As Integer = 0
        Dim password As String = ""
        Dim errorMsg As String = ""

        password = HiddenData.Encrypt(txtPassword.Text)
        If chkActive.Checked = True Then
            isActive = 1
        End If

        Dim dtData As New DataTable

        Dim todayDate As DateTime = getServerDate()

        dtData = clsConnect.getAllData("APP_User",,, " userID=" + secureString(txtUserID.Text)).Tables("Data")

        If dtData.Rows.Count > 0 Or dtData IsNot Nothing Then
            callMessage(2, "Update data?")
            If msgBoxOK.ShowDialog = DialogResult.Yes Then
                errorMsg = clsConnect.updateData(txtUserID.Text, txtProjectID.Text, txtID.Text, txtRolesID.Text, txtInstitutionID.Text, txtLevelApproval.Text,
                                         txtUsername.Text, password, txtRemarks.Text, isActive, todayDate, Username)
            End If
        Else
            errorMsg = clsConnect.insertData(txtProjectID.Text, txtID.Text, txtRolesID.Text, txtInstitutionID.Text, txtLevelApproval.Text,
                                         txtUsername.Text, password, txtRemarks.Text, isActive, todayDate, Username)
        End If

        If errorMsg = "" Then
            settingButton(Me, "Save")
            callMessage(1, "Save Succeed")
            If msgBoxOK.ShowDialog = DialogResult.OK Then
                Exit Sub
            End If
        Else
            callMessage(3, "Save Failed")
            If msgBoxOK.ShowDialog = DialogResult.OK Then
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

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        settingButton(Me, "Edit")
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

    End Sub

    Private Sub btnLKID_Click(sender As Object, e As EventArgs) Handles btnLKID.Click
        frmLookupSite.tableName = "PersonalID"
        If frmLookupSite.ShowDialog = DialogResult.OK Then
            txtID.Text = lookUpRow.Item("personalID")
        End If
    End Sub

    Private Sub btnLKUserID_Click(sender As Object, e As EventArgs) Handles btnLKUserID.Click
        frmLookupSite.tableName = "UserID"
        If frmLookupSite.ShowDialog = DialogResult.OK Then
            settingButton(Me, "Lookup")
            Dim dtData As New DataTable
            dtData = clsConnect.getAllData("APP_User",,, "userID=" + txtID.Text).Tables("Data")
            If dtData.Rows.Count > 0 And (dtData IsNot Nothing) Then
                With dtData
                    txtUserID.Text = .Rows(0).Item("UserID")
                    txtID.Text = .Rows(0).Item("personalID")
                    txtProjectID.Text = .Rows(0).Item("projectID")
                    txtRolesID.Text = .Rows(0).Item("rolesID")
                    txtInstitutionID.Text = .Rows(0).Item("institutionID")
                    txtLevelApproval.Text = .Rows(0).Item("levelApprovalID")
                    txtUsername.Text = .Rows(0).Item("username")
                    txtPassword.Text = .Rows(0).Item("password")
                    If IsDBNull(.Rows(0).Item("remarks")) Then
                        txtRemarks.Text = ""
                    Else
                        txtRemarks.Text = .Rows(0).Item("remarks")
                    End If

                    chkActive.Checked = .Rows(0).Item("isactive")
                    txtLastUpdated.Text = .Rows(0).Item("lastUpdated")
                    txtLastUpdater.Text = .Rows(0).Item("lastupdater")
                End With
            End If
        End If
    End Sub

    Private Sub btnLKProject_Click(sender As Object, e As EventArgs) Handles btnLKProject.Click
        frmLookupSite.tableName = "ProjectID"
        If frmLookupSite.ShowDialog = DialogResult.OK Then
            txtProjectID.Text = lookUpRow.Item("projectID")
        End If
    End Sub

    Private Sub btnLKRoles_Click(sender As Object, e As EventArgs) Handles btnLKRoles.Click
        frmLookupSite.tableName = "RolesID"
        If frmLookupSite.ShowDialog = DialogResult.OK Then
            txtRolesID.Text = lookUpRow.Item("rolesID")
        End If
    End Sub

    Private Sub btnLKInstitution_Click(sender As Object, e As EventArgs) Handles btnLKInstitution.Click
        frmLookupSite.tableName = "InstitutionID"
        If frmLookupSite.ShowDialog = DialogResult.OK Then
            txtInstitutionID.Text = lookUpRow.Item("personalID")
        End If
    End Sub

    Private Sub btnLKApproval_Click(sender As Object, e As EventArgs) Handles btnLKApproval.Click
        frmLookupSite.tableName = "ApprovalID"
        If frmLookupSite.ShowDialog = DialogResult.OK Then
            txtLevelApproval.Text = lookUpRow.Item("levelApprovalID")
        End If
    End Sub
End Class