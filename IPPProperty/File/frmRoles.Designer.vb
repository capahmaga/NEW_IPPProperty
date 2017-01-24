<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmRoles
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.btnLKID = New System.Windows.Forms.Button()
        Me.chkActive = New System.Windows.Forms.CheckBox()
        Me.txtRemarks = New System.Windows.Forms.TextBox()
        Me.txtRolesCode = New System.Windows.Forms.TextBox()
        Me.txtRolesName = New System.Windows.Forms.TextBox()
        Me.txtLastUpdater = New System.Windows.Forms.TextBox()
        Me.lblHead = New System.Windows.Forms.Label()
        Me.pnNavigation = New System.Windows.Forms.Panel()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.txtLastUpdated = New System.Windows.Forms.TextBox()
        Me.txtProjectID = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.pnlHead = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.gbMain = New System.Windows.Forms.GroupBox()
        Me.pnNavigation.SuspendLayout()
        Me.pnlHead.SuspendLayout()
        Me.gbMain.SuspendLayout()
        Me.SuspendLayout()
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
        'btnLKID
        '
        Me.btnLKID.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLKID.Location = New System.Drawing.Point(255, 51)
        Me.btnLKID.Name = "btnLKID"
        Me.btnLKID.Size = New System.Drawing.Size(24, 23)
        Me.btnLKID.TabIndex = 2
        Me.btnLKID.UseVisualStyleBackColor = True
        '
        'chkActive
        '
        Me.chkActive.AutoSize = True
        Me.chkActive.Location = New System.Drawing.Point(116, 209)
        Me.chkActive.Name = "chkActive"
        Me.chkActive.Size = New System.Drawing.Size(56, 17)
        Me.chkActive.TabIndex = 13
        Me.chkActive.Text = "Active"
        Me.chkActive.UseVisualStyleBackColor = True
        '
        'txtRemarks
        '
        Me.txtRemarks.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRemarks.Location = New System.Drawing.Point(116, 142)
        Me.txtRemarks.Multiline = True
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.Size = New System.Drawing.Size(300, 50)
        Me.txtRemarks.TabIndex = 12
        '
        'txtRolesCode
        '
        Me.txtRolesCode.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRolesCode.Location = New System.Drawing.Point(116, 81)
        Me.txtRolesCode.Name = "txtRolesCode"
        Me.txtRolesCode.Size = New System.Drawing.Size(270, 23)
        Me.txtRolesCode.TabIndex = 5
        '
        'txtRolesName
        '
        Me.txtRolesName.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRolesName.Location = New System.Drawing.Point(116, 111)
        Me.txtRolesName.Name = "txtRolesName"
        Me.txtRolesName.Size = New System.Drawing.Size(270, 23)
        Me.txtRolesName.TabIndex = 9
        '
        'txtLastUpdater
        '
        Me.txtLastUpdater.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLastUpdater.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLastUpdater.Location = New System.Drawing.Point(114, 262)
        Me.txtLastUpdater.Name = "txtLastUpdater"
        Me.txtLastUpdater.ReadOnly = True
        Me.txtLastUpdater.Size = New System.Drawing.Size(216, 23)
        Me.txtLastUpdater.TabIndex = 13
        '
        'lblHead
        '
        Me.lblHead.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblHead.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHead.Location = New System.Drawing.Point(0, 0)
        Me.lblHead.Name = "lblHead"
        Me.lblHead.Size = New System.Drawing.Size(474, 41)
        Me.lblHead.TabIndex = 0
        Me.lblHead.Text = "lblHead"
        Me.lblHead.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.pnNavigation.Location = New System.Drawing.Point(0, 295)
        Me.pnNavigation.Name = "pnNavigation"
        Me.pnNavigation.Size = New System.Drawing.Size(474, 40)
        Me.pnNavigation.TabIndex = 12
        '
        'btnClose
        '
        Me.btnClose.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Image = Global.IPPProperty.My.Resources.Resources.icon_cancel
        Me.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClose.Location = New System.Drawing.Point(398, 7)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(3, 3, 0, 3)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Padding = New System.Windows.Forms.Padding(2, 0, 0, 1)
        Me.btnClose.Size = New System.Drawing.Size(67, 27)
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
        'txtLastUpdated
        '
        Me.txtLastUpdated.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLastUpdated.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLastUpdated.Location = New System.Drawing.Point(114, 235)
        Me.txtLastUpdated.Name = "txtLastUpdated"
        Me.txtLastUpdated.ReadOnly = True
        Me.txtLastUpdated.Size = New System.Drawing.Size(135, 23)
        Me.txtLastUpdated.TabIndex = 14
        '
        'txtProjectID
        '
        Me.txtProjectID.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProjectID.Location = New System.Drawing.Point(116, 51)
        Me.txtProjectID.Name = "txtProjectID"
        Me.txtProjectID.Size = New System.Drawing.Size(133, 23)
        Me.txtProjectID.TabIndex = 1
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(13, 262)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(80, 16)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "Last Updater"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(13, 235)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(82, 16)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Last Updated"
        '
        'pnlHead
        '
        Me.pnlHead.Controls.Add(Me.lblHead)
        Me.pnlHead.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHead.Location = New System.Drawing.Point(0, 0)
        Me.pnlHead.Name = "pnlHead"
        Me.pnlHead.Size = New System.Drawing.Size(474, 38)
        Me.pnlHead.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(13, 209)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(42, 16)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Active"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(14, 145)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(58, 16)
        Me.Label11.TabIndex = 6
        Me.Label11.Text = "Remarks"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(14, 116)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(76, 16)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Roles Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 86)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 16)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Roles Code"
        '
        'Label2
        '
        Me.Label2.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 16)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Project ID"
        '
        'gbMain
        '
        Me.gbMain.Controls.Add(Me.btnLKID)
        Me.gbMain.Controls.Add(Me.chkActive)
        Me.gbMain.Controls.Add(Me.txtRemarks)
        Me.gbMain.Controls.Add(Me.txtRolesCode)
        Me.gbMain.Controls.Add(Me.txtRolesName)
        Me.gbMain.Controls.Add(Me.txtLastUpdater)
        Me.gbMain.Controls.Add(Me.txtLastUpdated)
        Me.gbMain.Controls.Add(Me.txtProjectID)
        Me.gbMain.Controls.Add(Me.Label8)
        Me.gbMain.Controls.Add(Me.Label7)
        Me.gbMain.Controls.Add(Me.Label6)
        Me.gbMain.Controls.Add(Me.Label11)
        Me.gbMain.Controls.Add(Me.Label9)
        Me.gbMain.Controls.Add(Me.Label4)
        Me.gbMain.Controls.Add(Me.Label2)
        Me.gbMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gbMain.Location = New System.Drawing.Point(0, 0)
        Me.gbMain.Name = "gbMain"
        Me.gbMain.Size = New System.Drawing.Size(474, 335)
        Me.gbMain.TabIndex = 13
        Me.gbMain.TabStop = False
        '
        'frmRoles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(474, 335)
        Me.Controls.Add(Me.pnNavigation)
        Me.Controls.Add(Me.pnlHead)
        Me.Controls.Add(Me.gbMain)
        Me.Name = "frmRoles"
        Me.Text = "frmRoles"
        Me.pnNavigation.ResumeLayout(False)
        Me.pnlHead.ResumeLayout(False)
        Me.gbMain.ResumeLayout(False)
        Me.gbMain.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnPrint As Button
    Friend WithEvents btnLKID As Button
    Friend WithEvents chkActive As CheckBox
    Friend WithEvents txtRemarks As TextBox
    Friend WithEvents txtRolesCode As TextBox
    Friend WithEvents txtRolesName As TextBox
    Friend WithEvents txtLastUpdater As TextBox
    Friend WithEvents lblHead As Label
    Friend WithEvents pnNavigation As Panel
    Friend WithEvents btnClose As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnNew As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents txtLastUpdated As TextBox
    Friend WithEvents txtProjectID As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents pnlHead As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents gbMain As GroupBox
End Class
