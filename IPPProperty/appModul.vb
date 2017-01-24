Module appModul

    Public paramForm As Form
    Public navigationForm As Form
    Public formButtonAction As Boolean = True



    Public Sub changeColor(form As Form)

        Dim myFont As New Font("Tahoma", 9, FontStyle.Regular)

        For Each ctrl As Control In form.Controls
            If TypeOf ctrl Is Panel Or TypeOf ctrl Is GroupBox Then

                For Each child In ctrl.Controls
                    If TypeOf child Is Label Then
                        CType(child, Label).BackColor = Color.Transparent
                        'CType(child, Label).Font = myFont
                    End If
                    If TypeOf child Is CheckBox Then
                        CType(child, CheckBox).BackColor = Color.Transparent
                        CType(child, CheckBox).Font = myFont
                    End If
                    If TypeOf child Is Button Then
                        CType(child, Button).BackColor = Color.FromArgb(250, 250, 250)
                        CType(child, Button).FlatStyle = FlatStyle.Flat
                        CType(child, Button).FlatAppearance.BorderColor = Color.FromArgb(10, 166, 248)
                        CType(child, Button).FlatAppearance.MouseOverBackColor = Color.FromArgb(245, 228, 96)
                        CType(child, Button).ImageAlign = ContentAlignment.MiddleLeft
                        CType(child, Button).TextAlign = ContentAlignment.MiddleRight
                    End If
                Next
                If TypeOf ctrl Is TabPage Then
                    Dim fontTabPage As New Font("Tahoma", 8, FontStyle.Regular)
                    For Each child In ctrl.Controls
                        If TypeOf child Is Button Then
                            CType(child, Button).BackColor = Color.FromArgb(250, 250, 250)
                            CType(child, Button).FlatStyle = FlatStyle.Flat
                            CType(child, Button).FlatAppearance.BorderColor = Color.FromArgb(10, 166, 248)
                            CType(child, Button).FlatAppearance.MouseOverBackColor = Color.FromArgb(245, 228, 96)
                            'CType(child, Button).ImageAlign = ContentAlignment.MiddleLeft
                            CType(child, Button).TextAlign = ContentAlignment.MiddleCenter
                            CType(child, Button).Font = fontTabPage
                        End If
                    Next
                End If
                ctrl.BackColor = Color.Transparent
                ctrl.BackgroundImage = IPPProperty.My.Resources.bg_body_pasir
                If ctrl.Name = "pnlHead" Then
                    ctrl.BackColor = Color.FromArgb(82, 158, 204)
                End If
                If ctrl.Name = "pnNavigation" Then
                    ctrl.BackColor = Color.FromArgb(45, 118, 183)
                End If
                ctrl.Font = myFont
            End If
        Next

    End Sub

    Public Sub SetAllMenuItems(ByRef menuStrip As MenuStrip, ByVal Visible As Boolean)

        Dim c As ToolStripItem

        Dim t As ToolStripMenuItem

        For Each c In menuStrip.Items

            c.Visible = True

            If c.GetType Is GetType(ToolStripMenuItem) Then

                t = c

                SetAllMenuItems(t.DropDownItems, Visible)

            End If

        Next

    End Sub

    Private Sub SetAllMenuItems(ByRef menus As ToolStripItemCollection, ByVal Visible As Boolean)

        Dim c As ToolStripItem

        Dim t As ToolStripMenuItem

        For Each c In menus

            c.Visible = Visible

            If c.GetType Is GetType(ToolStripMenuItem) Then

                t = c

                SetAllMenuItems(t.DropDownItems, Visible)

            End If

        Next

    End Sub


    Public Sub setFormDesign(form As Form)

        changeColor(form)

        form.ControlBox = False
        form.StartPosition = FormStartPosition.CenterScreen
        form.FormBorderStyle = FormBorderStyle.FixedSingle

        Dim imgLookUp As New Bitmap((New Bitmap(My.Resources.icon_list)), 17, 17)
        Dim imgNew As New Bitmap((New Bitmap(My.Resources.icon_new)), 17, 17)
        Dim imgSave As New Bitmap((New Bitmap(My.Resources.icon_save)), 17, 17)
        Dim imgEdit As New Bitmap((New Bitmap(My.Resources.icon_edit)), 17, 17)
        Dim imgDelete As New Bitmap((New Bitmap(My.Resources.icon_delete)), 17, 17)
        Dim imgClose As New Bitmap((New Bitmap(My.Resources.icon_cancel)), 17, 17)
        Dim imgPrint As New Bitmap((New Bitmap(My.Resources.Apps_printer_icon)), 17, 17)
        Dim imgSearch As New Bitmap((New Bitmap(My.Resources.Search_icon)), 17, 17)
        Dim imgChoose As New Bitmap((New Bitmap(My.Resources.Sign_Select_icon)), 17, 17)
        Dim imgUpload As New Bitmap((New Bitmap(My.Resources.Folders_Uploads_Folder_icon)), 17, 17)

        For Each ctrl As Control In form.Controls
            If TypeOf ctrl Is Panel Or TypeOf ctrl Is GroupBox Then
                For Each child In ctrl.Controls
                    If TypeOf child Is Button Then
                        If (CType(child, Button).Name).Contains("btnLK") Then
                            CType(child, Button).Image = imgLookUp
                        End If
                        If (CType(child, Button).Name).Contains("New") Then
                            CType(child, Button).Image = imgNew
                        End If
                        If (CType(child, Button).Name).Contains("Save") Then
                            CType(child, Button).Image = imgSave
                        End If
                        If (CType(child, Button).Name).Contains("Edit") Then
                            CType(child, Button).Image = imgEdit
                        End If
                        If (CType(child, Button).Name).Contains("Delete") Then
                            CType(child, Button).Image = imgDelete
                        End If
                        If (CType(child, Button).Name).Contains("Close") Then
                            CType(child, Button).Image = imgClose
                        End If
                        If (CType(child, Button).Name).Contains("Print") Then
                            CType(child, Button).Image = imgPrint
                        End If
                        If (CType(child, Button).Name).Contains("Search") Then
                            CType(child, Button).Image = imgSearch
                        End If
                        If (CType(child, Button).Name).Contains("Choose") Then
                            CType(child, Button).Image = imgChoose
                        End If
                        If (CType(child, Button).Name).Contains("Upload") Then
                            CType(child, Button).Image = imgUpload
                        End If
                        If (CType(child, Button).Name).Contains("Add") Then
                            CType(child, Button).TextAlign = ContentAlignment.MiddleCenter
                            CType(child, Button).Image = Nothing
                            CType(child, Button).Font = New Font("Tahoma", 8, FontStyle.Regular)
                        End If
                        If (CType(child, Button).Name).Contains("Remove") Then
                            CType(child, Button).TextAlign = ContentAlignment.MiddleCenter
                            CType(child, Button).Image = Nothing
                            CType(child, Button).Font = New Font("Tahoma", 8, FontStyle.Regular)
                        End If

                    End If
                Next
            End If
        Next

    End Sub

    Public Function validateMandatory(ByVal dataTextBox() As TextBox) As Boolean
        Dim cekValid As Boolean = True
        For Each textbox As TextBox In dataTextBox
            If textbox.Text = "" Then
                textbox.BackColor = Color.FromArgb(247, 249, 104)
                cekValid = False
            End If
        Next
        If cekValid = True Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Sub validateEmptyMoney(ByVal dataTextBox() As TextBox)

        For Each tb As TextBox In dataTextBox
            If String.IsNullOrEmpty(tb.Text) Or tb.Text = "" Then
                tb.Text = 0
            End If
        Next
    End Sub


    Public Sub callMessage(ByVal type As Integer, ByVal message As String)
        Dim msgBox As msgBoxOK = New msgBoxOK
        paramType = type
        messageBoxMessage = message
    End Sub

    'Public Sub settingActionButton(form As Form)
    '    For Each ctrl As Control In form.Controls("pnNavigation").Controls
    '        If TypeOf ctrl Is Button Then
    '            AddHandler ctrl.Click, AddressOf CommonClickHandler
    '            navigationForm = form
    '        End If
    '    Next
    '    For Each ctrl As Control In form.Controls("gbMain").Controls
    '        If TypeOf ctrl Is Button Then
    '            AddHandler ctrl.Click, AddressOf CommonClickHandler
    '            navigationForm = form
    '        End If
    '    Next
    'End Sub

    'Private Sub CommonClickHandler(ByVal sender As System.Object, ByVal e As System.EventArgs)

    '    If (CType(sender, Button).Name).Contains("New") Then
    '        ' Function New
    '        settingButton(navigationForm, "AddNew")
    '    End If
    '    If (CType(sender, Button).Name).Contains("Save") Then
    '        'Function Save
    '        settingButton(navigationForm, "Save")
    '    End If
    '    If (CType(sender, Button).Name).Contains("Edit") Then
    '        'Function Edit
    '        settingButton(navigationForm, "Edit")
    '    End If
    '    If (CType(sender, Button).Name).Contains("Delete") Then
    '        'Function Delete
    '        settingButton(navigationForm, "Delete")
    '    End If
    '    If (CType(sender, Button).Name).Contains("Close") Then
    '        'Function Close
    '        If (CType(sender, Button).Text).Contains("Cancel") Then
    '            settingButton(navigationForm, "Cancel")
    '        Else
    '            closeForm()
    '        End If
    '    End If
    '    If (CType(sender, Button)).Name.Contains("Print") Then
    '        'Function Print
    '        MessageBox.Show("Function Print")
    '    End If
    '    If (CType(sender, Button).Name).Contains("Search") Then
    '        'Function Search
    '        MessageBox.Show("Function Search")
    '    End If
    '    If (CType(sender, Button).Name).Contains("Choose") Then
    '        'Function Choose
    '        MessageBox.Show("Function Choose")
    '    End If
    '    If (CType(sender, Button).Name).Contains("LK") Then
    '        'Function Choose
    '        MessageBox.Show("Function Lookup")
    '    End If

    'End Sub

    'Public Sub setNavigation(form As Form)
    '    For Each ctrl As Control In form.Controls
    '        If (ctrl.Name).Contains("Navigation") Then
    '            For Each child In ctrl.Controls
    '                If TypeOf child Is Button Then
    '                    If (CType(child, Button).Name).Contains("New") Then
    '                        ' Function New
    '                        settingButton(navigationForm, "AddNew")
    '                    End If
    '                    If (CType(child, Button).Name).Contains("Save") Then
    '                        'Function Save
    '                        settingButton(navigationForm, "Save")
    '                    End If
    '                    If (CType(child, Button).Name).Contains("Edit") Then
    '                        'Function Edit
    '                        settingButton(navigationForm, "Edit")
    '                    End If
    '                    If (CType(child, Button).Name).Contains("Delete") Then
    '                        'Function Delete
    '                        settingButton(navigationForm, "Delete")
    '                    End If
    '                    If (CType(child, Button).Name).Contains("Close") Then
    '                        'Function Close
    '                        If (CType(child, Button).Text).Contains("Cancel") Then
    '                            settingButton(navigationForm, "Cancel")
    '                        Else
    '                            closeForm()
    '                        End If
    '                    End If
    '                    If (CType(child, Button).Name).Contains("Print") Then
    '                        'Function Print
    '                    End If
    '                    If (CType(child, Button).Name).Contains("Search") Then
    '                        'Function Search
    '                    End If
    '                    If (CType(child, Button).Name).Contains("Choose") Then
    '                        'Function Choose
    '                    End If

    '                End If
    '            Next
    '        End If
    '    Next

    'End Sub


    Public Sub closeForm()
        navigationForm.Close()
    End Sub

    Public Sub clearForm(form As Form)

        For Each ctrl As Control In form.Controls
            If TypeOf ctrl Is Panel Or TypeOf ctrl Is GroupBox Then
                For Each child In ctrl.Controls
                    If TypeOf child Is TextBox Then
                        CType(child, TextBox).Text = ""
                    End If
                    If TypeOf child Is DateTimePicker Then
                        CType(child, DateTimePicker).Value = Now
                    End If
                Next
            End If
        Next
    End Sub

    Public Sub allTextReadOnly(form As Form, ByVal status As Boolean)

        For Each ctrl As Control In form.Controls
            If TypeOf ctrl Is Panel Or TypeOf ctrl Is GroupBox Then
                For Each child In ctrl.Controls
                    If TypeOf child Is TextBox Then
                        CType(child, TextBox).ReadOnly = status
                        If (CType(child, TextBox).Name).Contains("Last") Then
                            CType(child, TextBox).ReadOnly = True
                        End If
                        If (CType(child, TextBox).Name).Contains("ID") Then
                            CType(child, TextBox).ReadOnly = True
                        End If
                    End If
                Next
            End If
        Next
    End Sub

    Public Function secureString(ByVal word As String) As String
        Dim result As String = ""

        result = word.Replace("'", "").Replace(";", "")

        Return result

    End Function

    Public Sub settingButton(form As Form, Optional ByVal buttonClick As String = "")

        Dim ctrl As Control = form.Controls("pnNavigation")

        If buttonClick = "AddNew" Then
            Dim imgClose As New Bitmap((New Bitmap(My.Resources.icon_cancel)), 17, 17)

            ctrl.Controls("btnNew").Enabled = False
            ctrl.Controls("btnSave").Enabled = True
            ctrl.Controls("btnEdit").Enabled = False
            ctrl.Controls("btnDelete").Enabled = False
            ctrl.Controls("btnPrint").Enabled = False
            ctrl.Controls("btnClose").Text = "Cancel"
            ctrl.Controls("btnClose").Width = 72
            formButtonAction = False
            allTextReadOnly(form, False)
            clearForm(form)
        End If

        If buttonClick = "Save" Then
            ctrl.Controls("btnNew").Enabled = True
            ctrl.Controls("btnSave").Enabled = False
            ctrl.Controls("btnEdit").Enabled = True
            ctrl.Controls("btnDelete").Enabled = True
            ctrl.Controls("btnPrint").Enabled = True
            ctrl.Controls("btnClose").Text = "Close"
            formButtonAction = True
            allTextReadOnly(form, True)
        End If

        'If buttonClick = "View" Then
        '    ctrl.Controls("btnNew").Enabled = True
        '    ctrl.Controls("btnSave").Enabled = False
        '    ctrl.Controls("btnEdit").Enabled = True
        '    ctrl.Controls("btnDelete").Enabled = True
        '    ctrl.Controls("btnPrint").Enabled = True
        '    ctrl.Controls("btnClose").Text = "Close"
        '    formButtonAction = True
        '    allTextReadOnly(form, True)
        'End If

        If buttonClick = "Edit" Then
            ctrl.Controls("btnNew").Enabled = True
            ctrl.Controls("btnSave").Enabled = True
            ctrl.Controls("btnEdit").Enabled = False
            ctrl.Controls("btnDelete").Enabled = False
            ctrl.Controls("btnPrint").Enabled = False
            ctrl.Controls("btnClose").Text = "Cancel"
            formButtonAction = True
            allTextReadOnly(form, False)
        End If

        If buttonClick = "Delete" Then
            ctrl.Controls("btnNew").Enabled = True
            ctrl.Controls("btnSave").Enabled = False
            ctrl.Controls("btnEdit").Enabled = False
            ctrl.Controls("btnDelete").Enabled = False
            ctrl.Controls("btnPrint").Enabled = False
            ctrl.Controls("btnClose").Text = "Close"
            formButtonAction = True
            allTextReadOnly(form, True)
        End If

        If buttonClick = "Cancel" Or buttonClick = "Main" Then
            ctrl.Controls("btnNew").Enabled = True
            ctrl.Controls("btnSave").Enabled = False
            ctrl.Controls("btnEdit").Enabled = False
            ctrl.Controls("btnDelete").Enabled = False
            ctrl.Controls("btnPrint").Enabled = False
            ctrl.Controls("btnClose").Text = "Close"
            formButtonAction = True
            allTextReadOnly(form, True)
        End If

        If buttonClick = "Lookup" Then
            ctrl.Controls("btnNew").Enabled = True
            ctrl.Controls("btnSave").Enabled = False
            ctrl.Controls("btnEdit").Enabled = True
            ctrl.Controls("btnDelete").Enabled = True
            ctrl.Controls("btnPrint").Enabled = True
            ctrl.Controls("btnClose").Text = "Close"
            formButtonAction = True
            allTextReadOnly(form, True)
        End If

    End Sub

End Module
