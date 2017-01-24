Public Class frmBilling

    Private Sub frmUploadBilling_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        setFormDesign(Me)
    End Sub

    Private Sub btnLKFile_Click(sender As Object, e As EventArgs) Handles   lkBillingCode.Click
        ofdData.FileName = ".XLS"
        ofdData.ShowDialog()
        'txtPath.Text = ofdData.FileName
    End Sub

    'Private Sub btnUpload_Click(sender As Object, e As EventArgs) 
    '    Dim dataFile As String = txtPath.Text
    '    Dim File As String = IO.Path.GetFileName(txtPath.Text)

    '    If dgvData.Rows.Count > 0 Then
    '        dgvData.Rows.Clear()
    '        dgvData.DataSource = Nothing
    '    End If

    '    If System.IO.File.Exists(dataFile) = True Then
    '        Dim dt As New DataTable
    '        dt = clsConnect.getAllDataExcel(dataFile, File).Tables("Excel")
    '        dgvData.DataSource = dt

    '        callMessage(1, "You will upload " & dgvData.Rows.Count & " data.")
    '        If msgBoxOK.ShowDialog = DialogResult.Yes Then
    '            Exit Sub
    '        End If
    '    Else
    '        MsgBox("File Does Not Exist")
    '        Exit Sub
    '    End If
    '    txtUpload.Text = dgvData.Rows.Count
    '    txtUploaded.Text = 0
    'End Sub

    'Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
    '    dgvData.DataSource = Nothing
    '    dtpStartDate.Value = Now
    '    dtpEndDate.Value = Now
    '    txtPath.Text = ""
    '    txtUpload.Text = ""
    '    txtUploaded.Text = ""
    'End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

    End Sub
End Class