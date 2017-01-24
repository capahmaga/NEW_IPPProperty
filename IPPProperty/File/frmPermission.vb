Public Class frmPermission


    Public mandatoryText() As TextBox

    Private Sub frmUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim setText As String = "Master Permission"
        Me.CenterToScreen()
        setFormDesign(Me)
        settingButton(Me, "Main")
        Me.Text = setText
        lblHead.Text = setText
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        settingButton(Me, "AddNew")
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        mandatoryText = {txtProjectID, txtRolesID, txtMenuID, txtMenuName}

        If validateMandatory(mandatoryText) = False Then
            MessageBox.Show("Mandatory data cannot empty!", "Warning")
            Exit Sub
        End If
        settingButton(Me, "Save")
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
        frmLookupSite.tableName = "ProjectID"
        If frmLookupSite.ShowDialog = DialogResult.OK Then
            txtProjectID.Text = lookUpRow.Item("projectID")
        End If
    End Sub

    Private Sub btnLKRoles_Click(sender As Object, e As EventArgs) Handles btnLKRoles.Click
        frmLookupSite.tableName = "RolesID"
        GlobalProjectID = txtProjectID.Text
        dgvData.DataSource = Nothing

        If GlobalProjectID = "" Then
            callMessage(3, "Select Project First!")
            If msgBoxOK.ShowDialog = DialogResult.OK Then
                Exit Sub
            End If
        End If
        If frmLookupSite.ShowDialog = DialogResult.OK Then
            txtRolesID.Text = lookUpRow.Item("rolesID")
            Dim dt As New DataTable

            dgvData.DataSource = Nothing

            dt = clsConnect.getAllData("APP_MenuPermission", "menuID,menuName,isInsert,isUpdate,isRead,isDelete,isActive",,
                                       " isActive=1 and projectID=" + GlobalProjectID + " and rolesID=" + txtRolesID.Text).Tables("Data")

            If dt.Rows.Count > 0 Or dt IsNot Nothing Then
                dgvData.DataSource = dt
            End If
        End If
    End Sub

    Private Sub btnLKMenu_Click(sender As Object, e As EventArgs) Handles btnLKMenu.Click
        frmLookupSite.tableName = "MenuID"
        GlobalProjectID = txtProjectID.Text

        If GlobalProjectID = "" Then
            callMessage(3, "Select Project First!")
            If msgBoxOK.ShowDialog = DialogResult.OK Then
                Exit Sub
            End If
        End If

        If frmLookupSite.ShowDialog = DialogResult.OK Then
            txtMenuID.Text = lookUpRow.Item("menuID")
            txtMenuName.Text = lookUpRow.Item("menuName")
        End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        mandatoryText = {txtProjectID, txtRolesID, txtMenuID, txtMenuName}

        If validateMandatory(mandatoryText) = False Then
            MessageBox.Show("Mandatory data cannot empty!", "Warning")
            Exit Sub
        End If

        For i As Integer = 0 To dgvData.Rows.Count - 1
            If txtMenuID.Text = dgvData.Rows(i).Cells("menuID").ToString Then
                dgvData.Rows(i).Cells("menuID").Value = txtMenuID.Text
                dgvData.Rows(i).Cells("menuName").Value = txtMenuName.Text
                dgvData.Rows(i).Cells("isInsert").Value = chkIsinsert.Checked
                dgvData.Rows(i).Cells("isUpdate").Value = chkUpdate.Checked
                dgvData.Rows(i).Cells("isRead").Value = chkRead.Checked
                dgvData.Rows(i).Cells("isDelete").Value = chkDelete.Checked
                dgvData.Rows(i).Cells("isActive").Value = chkActive.Checked
            Else
                Dim row As String() = New String() {txtMenuID.Text, txtMenuName.Text,
                                                    chkIsinsert.Checked, chkUpdate.Checked,
                                                    chkRead.Checked, chkDelete.Checked, chkActive.Checked}
                dgvData.Rows.Add(row)
            End If
        Next

    End Sub

    Private Sub dgvData_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvData.CellContentDoubleClick
        txtMenuID.Text = dgvData.Rows(Me.dgvData.CurrentRow.Index).Cells("menuID").Value()
        txtMenuName.Text = dgvData.Rows(Me.dgvData.CurrentRow.Index).Cells("menuName").Value()
        chkIsinsert.Checked = dgvData.Rows(Me.dgvData.CurrentRow.Index).Cells("isInsert").Value()
        chkUpdate.Checked = dgvData.Rows(Me.dgvData.CurrentRow.Index).Cells("isUpdate").Value()
        chkRead.Checked = dgvData.Rows(Me.dgvData.CurrentRow.Index).Cells("isRead").Value()
        chkDelete.Checked = dgvData.Rows(Me.dgvData.CurrentRow.Index).Cells("isDelete").Value()
        chkActive.Checked = dgvData.Rows(Me.dgvData.CurrentRow.Index).Cells("isActive").Value()
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        For i As Integer = 0 To dgvData.RowCount - 1
            If txtMenuID.Text = dgvData.Rows(i).Cells("menuID").ToString Then
                dgvData.Rows.Remove(dgvData.Rows(i))
            Else
                callMessage(3, "Data Not Found")
                If msgBoxOK.ShowDialog = DialogResult.OK Then
                    Exit Sub
                End If
            End If
        Next

    End Sub
End Class