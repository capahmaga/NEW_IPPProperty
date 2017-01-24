<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmHouseKeeping
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
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtTotalAmount = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtTaxAmount = New System.Windows.Forms.TextBox()
        Me.txtTaxPercetage = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.btnLKUnitNo = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtUnitNo = New System.Windows.Forms.TextBox()
        Me.btnLKProject = New System.Windows.Forms.Button()
        Me.txtProjectName = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtRemarks = New System.Windows.Forms.TextBox()
        Me.txtBestPrice = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtItemPrice = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtItem = New System.Windows.Forms.TextBox()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.dtpEndDate = New System.Windows.Forms.DateTimePicker()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.dtpStartDate = New System.Windows.Forms.DateTimePicker()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.chkTax = New System.Windows.Forms.CheckBox()
        Me.btnLKItem = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lkBillingCode = New System.Windows.Forms.Button()
        Me.txtBillingCode = New System.Windows.Forms.TextBox()
        Me.pnlHead = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.pnNavigation = New System.Windows.Forms.Panel()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.pnlHead.SuspendLayout()
        Me.pnNavigation.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label16
        '
        Me.Label16.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(12, 264)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(58, 16)
        Me.Label16.TabIndex = 74
        Me.Label16.Text = "Remarks"
        '
        'Label15
        '
        Me.Label15.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(12, 238)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(37, 16)
        Me.Label15.TabIndex = 73
        Me.Label15.Text = "Total"
        '
        'txtTotalAmount
        '
        Me.txtTotalAmount.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalAmount.Location = New System.Drawing.Point(103, 235)
        Me.txtTotalAmount.Name = "txtTotalAmount"
        Me.txtTotalAmount.Size = New System.Drawing.Size(154, 23)
        Me.txtTotalAmount.TabIndex = 72
        Me.txtTotalAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label14
        '
        Me.Label14.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(151, 212)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(20, 16)
        Me.Label14.TabIndex = 71
        Me.Label14.Text = "%"
        '
        'txtTaxAmount
        '
        Me.txtTaxAmount.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTaxAmount.Location = New System.Drawing.Point(176, 209)
        Me.txtTaxAmount.Name = "txtTaxAmount"
        Me.txtTaxAmount.Size = New System.Drawing.Size(146, 23)
        Me.txtTaxAmount.TabIndex = 70
        Me.txtTaxAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTaxPercetage
        '
        Me.txtTaxPercetage.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTaxPercetage.Location = New System.Drawing.Point(103, 209)
        Me.txtTaxPercetage.Name = "txtTaxPercetage"
        Me.txtTaxPercetage.Size = New System.Drawing.Size(42, 23)
        Me.txtTaxPercetage.TabIndex = 69
        Me.txtTaxPercetage.Text = "10"
        Me.txtTaxPercetage.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label13
        '
        Me.Label13.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(12, 212)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(29, 16)
        Me.Label13.TabIndex = 68
        Me.Label13.Text = "Tax"
        '
        'Label12
        '
        Me.Label12.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(12, 186)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(64, 16)
        Me.Label12.TabIndex = 66
        Me.Label12.Text = "Best Price"
        '
        'btnLKUnitNo
        '
        Me.btnLKUnitNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLKUnitNo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLKUnitNo.Location = New System.Drawing.Point(263, 59)
        Me.btnLKUnitNo.Name = "btnLKUnitNo"
        Me.btnLKUnitNo.Size = New System.Drawing.Size(28, 23)
        Me.btnLKUnitNo.TabIndex = 63
        Me.btnLKUnitNo.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(12, 62)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(49, 16)
        Me.Label11.TabIndex = 62
        Me.Label11.Text = "Unit No"
        '
        'txtUnitNo
        '
        Me.txtUnitNo.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUnitNo.Location = New System.Drawing.Point(103, 59)
        Me.txtUnitNo.Name = "txtUnitNo"
        Me.txtUnitNo.Size = New System.Drawing.Size(154, 23)
        Me.txtUnitNo.TabIndex = 61
        '
        'btnLKProject
        '
        Me.btnLKProject.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLKProject.Location = New System.Drawing.Point(350, 6)
        Me.btnLKProject.Name = "btnLKProject"
        Me.btnLKProject.Size = New System.Drawing.Size(24, 23)
        Me.btnLKProject.TabIndex = 59
        Me.btnLKProject.UseVisualStyleBackColor = True
        '
        'txtProjectName
        '
        Me.txtProjectName.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProjectName.Location = New System.Drawing.Point(103, 6)
        Me.txtProjectName.Name = "txtProjectName"
        Me.txtProjectName.Size = New System.Drawing.Size(241, 23)
        Me.txtProjectName.TabIndex = 58
        '
        'Label10
        '
        Me.Label10.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(12, 9)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(48, 16)
        Me.Label10.TabIndex = 60
        Me.Label10.Text = "Project"
        '
        'txtRemarks
        '
        Me.txtRemarks.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRemarks.Location = New System.Drawing.Point(103, 261)
        Me.txtRemarks.Multiline = True
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.Size = New System.Drawing.Size(271, 60)
        Me.txtRemarks.TabIndex = 57
        '
        'txtBestPrice
        '
        Me.txtBestPrice.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBestPrice.Location = New System.Drawing.Point(103, 183)
        Me.txtBestPrice.Name = "txtBestPrice"
        Me.txtBestPrice.Size = New System.Drawing.Size(154, 23)
        Me.txtBestPrice.TabIndex = 55
        Me.txtBestPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(12, 161)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(66, 16)
        Me.Label8.TabIndex = 49
        Me.Label8.Text = "Item Price"
        '
        'txtItemPrice
        '
        Me.txtItemPrice.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtItemPrice.Location = New System.Drawing.Point(103, 158)
        Me.txtItemPrice.Name = "txtItemPrice"
        Me.txtItemPrice.Size = New System.Drawing.Size(154, 23)
        Me.txtItemPrice.TabIndex = 48
        '
        'Label2
        '
        Me.Label2.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 135)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 16)
        Me.Label2.TabIndex = 43
        Me.Label2.Text = "Item"
        '
        'txtItem
        '
        Me.txtItem.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtItem.Location = New System.Drawing.Point(103, 132)
        Me.txtItem.Name = "txtItem"
        Me.txtItem.Size = New System.Drawing.Size(237, 23)
        Me.txtItem.TabIndex = 42
        '
        'btnClose
        '
        Me.btnClose.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Image = Global.IPPProperty.My.Resources.Resources.icon_cancel
        Me.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClose.Location = New System.Drawing.Point(327, 7)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(3, 3, 0, 3)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Padding = New System.Windows.Forms.Padding(2, 0, 0, 1)
        Me.btnClose.Size = New System.Drawing.Size(73, 27)
        Me.btnClose.TabIndex = 19
        Me.btnClose.Text = "Close"
        Me.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'dtpEndDate
        '
        Me.dtpEndDate.CustomFormat = "dd-MM-yyyy"
        Me.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpEndDate.Location = New System.Drawing.Point(103, 108)
        Me.dtpEndDate.Name = "dtpEndDate"
        Me.dtpEndDate.Size = New System.Drawing.Size(94, 20)
        Me.dtpEndDate.TabIndex = 41
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
        Me.btnSave.Size = New System.Drawing.Size(64, 26)
        Me.btnSave.TabIndex = 15
        Me.btnSave.Text = "Save"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'dtpStartDate
        '
        Me.dtpStartDate.CustomFormat = "dd-MM-yyyy"
        Me.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpStartDate.Location = New System.Drawing.Point(103, 85)
        Me.dtpStartDate.Name = "dtpStartDate"
        Me.dtpStartDate.Size = New System.Drawing.Size(93, 20)
        Me.dtpStartDate.TabIndex = 41
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.chkTax)
        Me.Panel1.Controls.Add(Me.Label16)
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Controls.Add(Me.txtTotalAmount)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.txtTaxAmount)
        Me.Panel1.Controls.Add(Me.txtTaxPercetage)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.btnLKUnitNo)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.txtUnitNo)
        Me.Panel1.Controls.Add(Me.btnLKProject)
        Me.Panel1.Controls.Add(Me.txtProjectName)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.txtRemarks)
        Me.Panel1.Controls.Add(Me.txtBestPrice)
        Me.Panel1.Controls.Add(Me.btnLKItem)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.txtItemPrice)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txtItem)
        Me.Panel1.Controls.Add(Me.dtpEndDate)
        Me.Panel1.Controls.Add(Me.dtpStartDate)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.lkBillingCode)
        Me.Panel1.Controls.Add(Me.txtBillingCode)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 38)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(416, 329)
        Me.Panel1.TabIndex = 16
        '
        'chkTax
        '
        Me.chkTax.Location = New System.Drawing.Point(327, 212)
        Me.chkTax.Name = "chkTax"
        Me.chkTax.Size = New System.Drawing.Size(74, 18)
        Me.chkTax.TabIndex = 75
        Me.chkTax.Text = "Non Tax"
        Me.chkTax.UseVisualStyleBackColor = True
        '
        'btnLKItem
        '
        Me.btnLKItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLKItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLKItem.Location = New System.Drawing.Point(346, 133)
        Me.btnLKItem.Name = "btnLKItem"
        Me.btnLKItem.Size = New System.Drawing.Size(28, 23)
        Me.btnLKItem.TabIndex = 52
        Me.btnLKItem.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 109)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 16)
        Me.Label4.TabIndex = 39
        Me.Label4.Text = "End Period"
        '
        'Label3
        '
        Me.Label3.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 85)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 16)
        Me.Label3.TabIndex = 39
        Me.Label3.Text = "Begin Period"
        '
        'Label5
        '
        Me.Label5.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 35)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 16)
        Me.Label5.TabIndex = 39
        Me.Label5.Text = "Billing Code"
        '
        'lkBillingCode
        '
        Me.lkBillingCode.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lkBillingCode.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lkBillingCode.Location = New System.Drawing.Point(263, 32)
        Me.lkBillingCode.Name = "lkBillingCode"
        Me.lkBillingCode.Size = New System.Drawing.Size(28, 23)
        Me.lkBillingCode.TabIndex = 19
        Me.lkBillingCode.UseVisualStyleBackColor = True
        '
        'txtBillingCode
        '
        Me.txtBillingCode.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBillingCode.Location = New System.Drawing.Point(103, 32)
        Me.txtBillingCode.Name = "txtBillingCode"
        Me.txtBillingCode.Size = New System.Drawing.Size(154, 23)
        Me.txtBillingCode.TabIndex = 18
        '
        'pnlHead
        '
        Me.pnlHead.Controls.Add(Me.Label1)
        Me.pnlHead.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHead.Location = New System.Drawing.Point(0, 0)
        Me.pnlHead.Name = "pnlHead"
        Me.pnlHead.Size = New System.Drawing.Size(416, 38)
        Me.pnlHead.TabIndex = 14
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(416, 35)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Billing Other"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.btnNew.Size = New System.Drawing.Size(62, 26)
        Me.btnNew.TabIndex = 14
        Me.btnNew.Text = "New"
        Me.btnNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'pnNavigation
        '
        Me.pnNavigation.Controls.Add(Me.btnPrint)
        Me.pnNavigation.Controls.Add(Me.btnClose)
        Me.pnNavigation.Controls.Add(Me.btnNew)
        Me.pnNavigation.Controls.Add(Me.btnSave)
        Me.pnNavigation.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnNavigation.Location = New System.Drawing.Point(0, 367)
        Me.pnNavigation.Name = "pnNavigation"
        Me.pnNavigation.Size = New System.Drawing.Size(416, 40)
        Me.pnNavigation.TabIndex = 15
        '
        'btnPrint
        '
        Me.btnPrint.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPrint.Location = New System.Drawing.Point(257, 7)
        Me.btnPrint.Margin = New System.Windows.Forms.Padding(3, 3, 0, 3)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Padding = New System.Windows.Forms.Padding(2, 0, 0, 1)
        Me.btnPrint.Size = New System.Drawing.Size(67, 27)
        Me.btnPrint.TabIndex = 20
        Me.btnPrint.Text = "Print"
        Me.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'frmHouseKeeping
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(416, 407)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.pnlHead)
        Me.Controls.Add(Me.pnNavigation)
        Me.Name = "frmHouseKeeping"
        Me.Text = "frmHouseKeeping"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.pnlHead.ResumeLayout(False)
        Me.pnNavigation.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents txtTotalAmount As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents txtTaxAmount As TextBox
    Friend WithEvents txtTaxPercetage As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents btnLKUnitNo As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents txtUnitNo As TextBox
    Friend WithEvents btnLKProject As Button
    Friend WithEvents txtProjectName As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtRemarks As TextBox
    Friend WithEvents txtBestPrice As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtItemPrice As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtItem As TextBox
    Friend WithEvents btnClose As Button
    Friend WithEvents dtpEndDate As DateTimePicker
    Friend WithEvents btnSave As Button
    Friend WithEvents dtpStartDate As DateTimePicker
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lkBillingCode As Button
    Friend WithEvents txtBillingCode As TextBox
    Friend WithEvents pnlHead As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents btnNew As Button
    Friend WithEvents pnNavigation As Panel
    Friend WithEvents btnLKItem As Button
    Friend WithEvents chkTax As CheckBox
    Friend WithEvents btnPrint As Button
End Class
