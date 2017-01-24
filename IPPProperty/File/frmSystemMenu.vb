Public Class frmSystemMenu

    Public mandatoryText() As TextBox

    Private Sub frmSystemMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        setFormDesign(Me)
        settingButton(Me, "Main")
        Me.Text = "Master Menu"
        lblHead.Text = "Master Menu"
    End Sub


    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        settingButton(Me, "AddNew")
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        mandatoryText = {txtProjectID, txtParentID, txtMenuCode, txtMenuName}

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


End Class