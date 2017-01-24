Public Class frmChangePassword

    Public mandatoryText() As TextBox
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        mandatoryText = {txtUsername, txtNewPassword, txtOldPassword, txtRetype}

        If validateMandatory(mandatoryText) = False Then
            MessageBox.Show("Mandatory data cannot empty!", "Warning")
            Exit Sub
        End If

        If txtNewPassword.Text <> txtRetype.Text Then
            callMessage(3, "New Password and Retype Password didn't match")
            If msgBoxOK.ShowDialog = DialogResult.OK Then
                Exit Sub
            End If
        End If

    End Sub

    Private Sub frmChangePassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        setFormDesign(Me)
    End Sub
End Class