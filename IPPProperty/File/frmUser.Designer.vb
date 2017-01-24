<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUser
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnLKID = New System.Windows.Forms.Button()
        Me.chkActive = New System.Windows.Forms.CheckBox()
        Me.txtInstitutionID = New System.Windows.Forms.TextBox()
        Me.txtLastUpdater = New System.Windows.Forms.TextBox()
        Me.txtLastUpdated = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.pnNavigation = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gbMain = New System.Windows.Forms.GroupBox()
        Me.btnLKProject = New System.Windows.Forms.Button()
        Me.txtProjectID = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.btnLKUserID = New System.Windows.Forms.Button()
        Me.txtUserID = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.btnLKApproval = New System.Windows.Forms.Button()
        Me.txtLevelApproval = New System.Windows.Forms.TextBox()
        Me.btnLKInstitution = New System.Windows.Forms.Button()
        Me.btnLKRoles = New System.Windows.Forms.Button()
        Me.txtRemarks = New System.Windows.Forms.TextBox()
        Me.txtRePassword = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.txtRolesID = New System.Windows.Forms.TextBox()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.pnlHead = New System.Windows.Forms.Panel()
        Me.pnNavigation.SuspendLayout()
        Me.gbMain.SuspendLayout()
        Me.pnlHead.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnLKID
        '
        Me.btnLKID.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLKID.Location = New System.Drawing.Point(255, 47)
        Me.btnLKID.Name = "btnLKID"
        Me.btnLKID.Size = New System.Drawing.Size(24, 23)
        Me.btnLKID.TabIndex = 2
        Me.btnLKID.UseVisualStyleBackColor = True
        '
        'chkActive
        '
        Me.chkActive.AutoSize = True
        Me.chkActive.Location = New System.Drawing.Point(116, 345)
        Me.chkActive.Name = "chkActive"
        Me.chkActive.Size = New System.Drawing.Size(56, 17)
        Me.chkActive.TabIndex = 13
        Me.chkActive.Text = "Active"
        Me.chkActive.UseVisualStyleBackColor = True
        '
        'txtInstitutionID
        '
        Me.txtInstitutionID.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInstitutionID.Location = New System.Drawing.Point(116, 136)
        Me.txtInstitutionID.Name = "txtInstitutionID"
        Me.txtInstitutionID.Size = New System.Drawing.Size(270, 23)
        Me.txtInstitutionID.TabIndex = 5
        '
        'txtLastUpdater
        '
        Me.txtLastUpdater.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLastUpdater.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLastUpdater.Location = New System.Drawing.Point(114, 398)
        Me.txtLastUpdater.Name = "txtLastUpdater"
        Me.txtLastUpdater.ReadOnly = True
        Me.txtLastUpdater.Size = New System.Drawing.Size(216, 23)
        Me.txtLastUpdater.TabIndex = 13
        '
        'txtLastUpdated
        '
        Me.txtLastUpdated.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLastUpdated.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLastUpdated.Location = New System.Drawing.Point(114, 371)
        Me.txtLastUpdated.Name = "txtLastUpdated"
        Me.txtLastUpdated.ReadOnly = True
        Me.txtLastUpdated.Size = New System.Drawing.Size(135, 23)
        Me.txtLastUpdated.TabIndex = 14
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(13, 398)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(80, 16)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "Last Updater"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(13, 371)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(82, 16)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Last Updated"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(13, 345)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(42, 16)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Active"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(13, 170)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(91, 16)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Level Approval"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 141)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 16)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Institution"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(13, 112)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 16)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Roles"
        '
        'Label2
        '
        Me.Label2.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 16)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Personal ID"
        '
        'btnPrint
        '
        Me.btnPrint.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPrint.Location = New System.Drawing.Point(317, 7)
        Me.btnPrint.Margin = New System.Windows.Forms.Padding(3, 3, 0, 3)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Padding = New System.Windows.Forms.Padding(2, 0, 0, 1)
        Me.btnPrint.Size = New System.Drawing.Size(67, 27)
        Me.btnPrint.TabIndex = 18
        Me.btnPrint.Text = "Print"
        Me.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Image = Global.IPPProperty.My.Resources.Resources.icon_cancel
        Me.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClose.Location = New System.Drawing.Point(389, 7)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(3, 3, 0, 3)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Padding = New System.Windows.Forms.Padding(2, 0, 0, 1)
        Me.btnClose.Size = New System.Drawing.Size(73, 27)
        Me.btnClose.TabIndex = 19
        Me.btnClose.Text = "Close"
        Me.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Image = Global.IPPProperty.My.Resources.Resources.icon_delete
        Me.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDelete.Location = New System.Drawing.Point(196, 7)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(3, 3, 0, 3)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Padding = New System.Windows.Forms.Padding(2, 0, 0, 0)
        Me.btnDelete.Size = New System.Drawing.Size(70, 26)
        Me.btnDelete.TabIndex = 17
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnNew
        '
        Me.btnNew.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNew.Image = Global.IPPProperty.My.Resources.Resources.icon_new
        Me.btnNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNew.Location = New System.Drawing.Point(6, 7)
        Me.btnNew.Margin = New System.Windows.Forms.Padding(3, 3, 0, 3)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Padding = New System.Windows.Forms.Padding(2, 0, 1, 0)
        Me.btnNew.Size = New System.Drawing.Size(60, 26)
        Me.btnNew.TabIndex = 14
        Me.btnNew.Text = "New"
        Me.btnNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.Image = Global.IPPProperty.My.Resources.Resources.icon_edit
        Me.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEdit.Location = New System.Drawing.Point(135, 7)
        Me.btnEdit.Margin = New System.Windows.Forms.Padding(3, 3, 0, 3)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Padding = New System.Windows.Forms.Padding(2, 0, 1, 0)
        Me.btnEdit.Size = New System.Drawing.Size(58, 26)
        Me.btnEdit.TabIndex = 16
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Image = Global.IPPProperty.My.Resources.Resources.icon_save
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSave.Location = New System.Drawing.Point(70, 7)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(3, 3, 0, 3)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Padding = New System.Windows.Forms.Padding(2, 0, 0, 0)
        Me.btnSave.Size = New System.Drawing.Size(62, 26)
        Me.btnSave.TabIndex = 15
        Me.btnSave.Text = "Save"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'pnNavigation
        '
        Me.pnNavigation.Controls.Add(Me.btnPrint)
        Me.pnNavigation.Controls.Add(Me.btnClose)
        Me.pnNavigation.Controls.Add(Me.btnDelete)
        Me.pnNavigation.Controls.Add(Me.btnNew)
        Me.pnNavigation.Controls.Add(Me.btnEdit)
        Me.pnNavigation.Controls.Add(Me.btnSave)
        Me.pnNavigation.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnNavigation.Location = New System.Drawing.Point(0, 474)
        Me.pnNavigation.Name = "pnNavigation"
        Me.pnNavigation.Size = New System.Drawing.Size(472, 40)
        Me.pnNavigation.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(472, 41)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Master User"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'gbMain
        '
        Me.gbMain.Controls.Add(Me.btnLKProject)
        Me.gbMain.Controls.Add(Me.txtProjectID)
        Me.gbMain.Controls.Add(Me.Label14)
        Me.gbMain.Controls.Add(Me.btnLKUserID)
        Me.gbMain.Controls.Add(Me.txtUserID)
        Me.gbMain.Controls.Add(Me.Label13)
        Me.gbMain.Controls.Add(Me.btnLKApproval)
        Me.gbMain.Controls.Add(Me.txtLevelApproval)
        Me.gbMain.Controls.Add(Me.btnLKInstitution)
        Me.gbMain.Controls.Add(Me.btnLKRoles)
        Me.gbMain.Controls.Add(Me.btnLKID)
        Me.gbMain.Controls.Add(Me.chkActive)
        Me.gbMain.Controls.Add(Me.txtRemarks)
        Me.gbMain.Controls.Add(Me.txtRePassword)
        Me.gbMain.Controls.Add(Me.txtPassword)
        Me.gbMain.Controls.Add(Me.txtInstitutionID)
        Me.gbMain.Controls.Add(Me.txtUsername)
        Me.gbMain.Controls.Add(Me.txtRolesID)
        Me.gbMain.Controls.Add(Me.txtLastUpdater)
        Me.gbMain.Controls.Add(Me.txtLastUpdated)
        Me.gbMain.Controls.Add(Me.txtID)
        Me.gbMain.Controls.Add(Me.Label8)
        Me.gbMain.Controls.Add(Me.Label7)
        Me.gbMain.Controls.Add(Me.Label6)
        Me.gbMain.Controls.Add(Me.Label11)
        Me.gbMain.Controls.Add(Me.Label5)
        Me.gbMain.Controls.Add(Me.Label12)
        Me.gbMain.Controls.Add(Me.Label10)
        Me.gbMain.Controls.Add(Me.Label9)
        Me.gbMain.Controls.Add(Me.Label4)
        Me.gbMain.Controls.Add(Me.Label3)
        Me.gbMain.Controls.Add(Me.Label2)
        Me.gbMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gbMain.Location = New System.Drawing.Point(0, 38)
        Me.gbMain.Name = "gbMain"
        Me.gbMain.Size = New System.Drawing.Size(472, 476)
        Me.gbMain.TabIndex = 7
        Me.gbMain.TabStop = False
        '
        'btnLKProject
        '
        Me.btnLKProject.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLKProject.Location = New System.Drawing.Point(255, 78)
        Me.btnLKProject.Name = "btnLKProject"
        Me.btnLKProject.Size = New System.Drawing.Size(24, 23)
        Me.btnLKProject.TabIndex = 19
        Me.btnLKProject.UseVisualStyleBackColor = True
        '
        'txtProjectID
        '
        Me.txtProjectID.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProjectID.Location = New System.Drawing.Point(116, 78)
        Me.txtProjectID.Name = "txtProjectID"
        Me.txtProjectID.Size = New System.Drawing.Size(133, 23)
        Me.txtProjectID.TabIndex = 18
        '
        'Label14
        '
        Me.Label14.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(13, 80)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(64, 16)
        Me.Label14.TabIndex = 20
        Me.Label14.Text = "Project ID"
        '
        'btnLKUserID
        '
        Me.btnLKUserID.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLKUserID.Location = New System.Drawing.Point(255, 17)
        Me.btnLKUserID.Name = "btnLKUserID"
        Me.btnLKUserID.Size = New System.Drawing.Size(24, 23)
        Me.btnLKUserID.TabIndex = 16
        Me.btnLKUserID.UseVisualStyleBackColor = True
        '
        'txtUserID
        '
        Me.txtUserID.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUserID.Location = New System.Drawing.Point(116, 17)
        Me.txtUserID.Name = "txtUserID"
        Me.txtUserID.Size = New System.Drawing.Size(133, 23)
        Me.txtUserID.TabIndex = 15
        '
        'Label13
        '
        Me.Label13.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(13, 19)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(50, 16)
        Me.Label13.TabIndex = 17
        Me.Label13.Text = "User ID"
        '
        'btnLKApproval
        '
        Me.btnLKApproval.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLKApproval.Location = New System.Drawing.Point(255, 167)
        Me.btnLKApproval.Name = "btnLKApproval"
        Me.btnLKApproval.Size = New System.Drawing.Size(24, 23)
        Me.btnLKApproval.TabIndex = 8
        Me.btnLKApproval.UseVisualStyleBackColor = True
        '
        'txtLevelApproval
        '
        Me.txtLevelApproval.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLevelApproval.Location = New System.Drawing.Point(116, 167)
        Me.txtLevelApproval.Name = "txtLevelApproval"
        Me.txtLevelApproval.Size = New System.Drawing.Size(133, 23)
        Me.txtLevelApproval.TabIndex = 7
        '
        'btnLKInstitution
        '
        Me.btnLKInstitution.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLKInstitution.Location = New System.Drawing.Point(392, 135)
        Me.btnLKInstitution.Name = "btnLKInstitution"
        Me.btnLKInstitution.Size = New System.Drawing.Size(24, 23)
        Me.btnLKInstitution.TabIndex = 6
        Me.btnLKInstitution.UseVisualStyleBackColor = True
        '
        'btnLKRoles
        '
        Me.btnLKRoles.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLKRoles.Location = New System.Drawing.Point(392, 107)
        Me.btnLKRoles.Name = "btnLKRoles"
        Me.btnLKRoles.Size = New System.Drawing.Size(24, 23)
        Me.btnLKRoles.TabIndex = 4
        Me.btnLKRoles.UseVisualStyleBackColor = True
        '
        'txtRemarks
        '
        Me.txtRemarks.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRemarks.Location = New System.Drawing.Point(116, 287)
        Me.txtRemarks.Multiline = True
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.Size = New System.Drawing.Size(300, 50)
        Me.txtRemarks.TabIndex = 12
        '
        'txtRePassword
        '
        Me.txtRePassword.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRePassword.Location = New System.Drawing.Point(116, 255)
        Me.txtRePassword.Name = "txtRePassword"
        Me.txtRePassword.Size = New System.Drawing.Size(163, 23)
        Me.txtRePassword.TabIndex = 11
        Me.txtRePassword.UseSystemPasswordChar = True
        '
        'txtPassword
        '
        Me.txtPassword.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(116, 225)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(163, 23)
        Me.txtPassword.TabIndex = 10
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'txtUsername
        '
        Me.txtUsername.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.Location = New System.Drawing.Point(116, 196)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(270, 23)
        Me.txtUsername.TabIndex = 9
        '
        'txtRolesID
        '
        Me.txtRolesID.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRolesID.Location = New System.Drawing.Point(116, 107)
        Me.txtRolesID.Name = "txtRolesID"
        Me.txtRolesID.Size = New System.Drawing.Size(270, 23)
        Me.txtRolesID.TabIndex = 3
        '
        'txtID
        '
        Me.txtID.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtID.Location = New System.Drawing.Point(116, 47)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(133, 23)
        Me.txtID.TabIndex = 1
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(14, 290)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(58, 16)
        Me.Label11.TabIndex = 6
        Me.Label11.Text = "Remarks"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(13, 258)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(56, 16)
        Me.Label12.TabIndex = 7
        Me.Label12.Text = "Re-Type"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(13, 227)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(63, 16)
        Me.Label10.TabIndex = 7
        Me.Label10.Text = "Password"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(14, 198)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(66, 16)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Username"
        '
        'pnlHead
        '
        Me.pnlHead.Controls.Add(Me.Label1)
        Me.pnlHead.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHead.Location = New System.Drawing.Point(0, 0)
        Me.pnlHead.Name = "pnlHead"
        Me.pnlHead.Size = New System.Drawing.Size(472, 38)
        Me.pnlHead.TabIndex = 5
        '
        'frmUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(472, 514)
        Me.Controls.Add(Me.pnNavigation)
        Me.Controls.Add(Me.gbMain)
        Me.Controls.Add(Me.pnlHead)
        Me.Name = "frmUser"
        Me.Text = "Master User"
        Me.pnNavigation.ResumeLayout(False)
        Me.gbMain.ResumeLayout(False)
        Me.gbMain.PerformLayout()
        Me.pnlHead.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnLKID As Button
    Friend WithEvents chkActive As CheckBox
    Friend WithEvents txtInstitutionID As TextBox
    Friend WithEvents txtLastUpdater As TextBox
    Friend WithEvents txtLastUpdated As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnPrint As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnNew As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents pnNavigation As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents gbMain As GroupBox
    Friend WithEvents btnLKApproval As Button
    Friend WithEvents txtLevelApproval As TextBox
    Friend WithEvents btnLKInstitution As Button
    Friend WithEvents btnLKRoles As Button
    Friend WithEvents txtRemarks As TextBox
    Friend WithEvents txtRePassword As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtRolesID As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents pnlHead As Panel
    Friend WithEvents txtID As TextBox
    Friend WithEvents btnLKUserID As Button
    Friend WithEvents txtUserID As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents btnLKProject As Button
    Friend WithEvents txtProjectID As TextBox
    Friend WithEvents Label14 As Label
End Class
