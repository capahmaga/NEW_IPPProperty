Imports System.IO

Public Class frmUploadTRO
    Private Sub frmUploadTRO_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        setFormDesign(Me)
        'settingButton(Me, "Main")
        txtUpload.Text = 0
        txtUploaded.Text = 0
        'bindTypeUpload(GlobalProjectID, paramFormUpload)

        bindTypeUpload(GlobalProjectID, "TRO")

    End Sub

    Public Sub bindTypeUpload(ByVal projectID As String, ByVal paramFormUpload As String)
        Dim dtData As New DataTable

        dtData = clsUpload.getUploadType(projectID, paramFormUpload).Tables("Data")

        Try
            If dtData.Rows.Count > 0 Then
                cmbUploadType.DisplayMember = "UploadName"
                cmbUploadType.ValueMember = "UploadID"
                cmbUploadType.DataSource = dtData
                'If dtData.Rows(0).Item("uploadParameter") = "Billing" Then
                '    lblBillingRate.Visible = True
                '    txtBillingRate.Visible = True
                '    btnLKBillingRate.Visible = True
                'End If
            Else
                callMessage(3, "Data Upload Type Not Found")
                If msgBoxOK.ShowDialog = DialogResult.Yes Then
                    Exit Sub
                End If
            End If
        Catch ex As Exception
            callMessage(3, "Data Upload Type Not Found")
            If msgBoxOK.ShowDialog = DialogResult.Yes Then
                Exit Sub
            End If
        End Try

    End Sub



    Private Sub btnLKFile_Click(sender As Object, e As EventArgs) Handles btnLKFile.Click

        'If paramFormUpload = "TRO" Then
        '    ofdData.FileName = ".CSV"
        'Else
        '    ofdData.FileName = ".XLS"
        'End If

        ofdData.ShowDialog()
        txtPath.Text = ofdData.FileName

    End Sub

    Private Sub btnUpload_Click(sender As Object, e As EventArgs) Handles btnUpload.Click
        Dim dataFile As String = txtPath.Text
        Dim File As String = IO.Path.GetFileName(txtPath.Text)
        Dim odf As New FileInfo(ofdData.FileName)

        If dgvData.Rows.Count > 0 Then
            dgvData.Rows.Clear()
            dgvData.DataSource = Nothing
        End If

        If System.IO.File.Exists(dataFile) = True Then
            Dim dt As New DataTable

            If cmbUploadType.SelectedValue = 1 Then

                dt = clsConnect.getAllDataCSV(odf.DirectoryName, File).Tables("CSV")

            Else
                dt = clsConnect.getAllDataExcel(dataFile, File).Tables("Excel")
            End If


            dgvData.DataSource = dt.DefaultView
            callMessage(1, "You will upload " & dgvData.Rows.Count & " data.")
            If msgBoxOK.ShowDialog = DialogResult.Yes Then
                Exit Sub
            End If
        Else
            callMessage(3, "File Does Not Exist")
            If msgBoxOK.ShowDialog = DialogResult.Yes Then
                Exit Sub
            End If
            Exit Sub
        End If
        txtUpload.Text = dgvData.Rows.Count
        txtUploaded.Text = 0
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        txtPath.Text = ""
        dgvData.DataSource = Nothing
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim errMsg As String = ""

        If dgvData.Rows.Count > 0 And dgvData IsNot Nothing Then
            Dim dtData As New DataTable
            dtData = CType(dgvData.DataSource, DataView).ToTable

            Select Case cmbUploadType.SelectedValue
                Case 1 ' Upload untuk data TRO
                    callMessage(2, "Any duplicate data will update. Save data?")
                    If msgBoxOK.ShowDialog = DialogResult.Yes Then
                        errMsg = clsUpload.insertDataUploadGuestArrival(GlobalProjectID, dtData, getServerDate(), Username)
                    End If

                Case 2 ' Upload untuk Billing 
                    callMessage(2, "Any duplicate data will update. Save data?")
                    If msgBoxOK.ShowDialog = DialogResult.Yes Then
                        errMsg = clsUpload.insertUploadBilling(GlobalProjectID, dtData, getServerDate(), Username)
                    End If

                Case Else ' Upload untuk Reservation
                    callMessage(2, "Any duplicate data will update. Save data?")
                    If msgBoxOK.ShowDialog = DialogResult.Yes Then
                        errMsg = clsUpload.insertUploadReservation(GlobalProjectID, dtData, getServerDate(), Username)
                    End If
            End Select
            If errMsg = "" Then
                callMessage(1, "Save Process Succeed!")
                If msgBoxOK.ShowDialog = DialogResult.Yes Then
                    Exit Sub
                End If
            Else
                callMessage(3, "Save Process Failed!")
                If msgBoxOK.ShowDialog = DialogResult.Yes Then
                    Exit Sub
                End If
            End If

        Else
            callMessage(3, "Upload Data First!")
            If msgBoxOK.ShowDialog = DialogResult.Yes Then
                Exit Sub
            End If
            Exit Sub
        End If

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnLKReservation_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label38_Click(sender As Object, e As EventArgs)

    End Sub
End Class