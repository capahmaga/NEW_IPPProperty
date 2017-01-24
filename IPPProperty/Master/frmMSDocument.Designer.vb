<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMSDocument
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
        Me.gbMain = New System.Windows.Forms.GroupBox()
        Me.btnLKDocumentFile = New System.Windows.Forms.Button()
        Me.btnLKDocument = New System.Windows.Forms.Button()
        Me.pcbDocument = New System.Windows.Forms.PictureBox()
        Me.cmbDocumentType = New System.Windows.Forms.ComboBox()
        Me.txtDocumentID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDocumentCode = New System.Windows.Forms.TextBox()
        Me.txtDocumentFile = New System.Windows.Forms.TextBox()
        Me.txtDocumentName = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtDocumentRemarks = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pnNavigation = New System.Windows.Forms.Panel()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.lblHead = New System.Windows.Forms.Label()
        Me.ofdFile = New System.Windows.Forms.OpenFileDialog()
        Me.chkActive = New System.Windows.Forms.CheckBox()
        Me.txtLastUpdater = New System.Windows.Forms.TextBox()
        Me.txtLastUpdated = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.gbMain.SuspendLayout()
        CType(Me.pcbDocument, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnNavigation.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbMain
        '
        Me.gbMain.Controls.Add(Me.chkActive)
        Me.gbMain.Controls.Add(Me.txtLastUpdater)
        Me.gbMain.Controls.Add(Me.txtLastUpdated)
        Me.gbMain.Controls.Add(Me.Label8)
        Me.gbMain.Controls.Add(Me.Label9)
        Me.gbMain.Controls.Add(Me.Label10)
        Me.gbMain.Controls.Add(Me.btnLKDocumentFile)
        Me.gbMain.Controls.Add(Me.btnLKDocument)
        Me.gbMain.Controls.Add(Me.pcbDocument)
        Me.gbMain.Controls.Add(Me.cmbDocumentType)
        Me.gbMain.Controls.Add(Me.txtDocumentID)
        Me.gbMain.Controls.Add(Me.Label1)
        Me.gbMain.Controls.Add(Me.txtDocumentCode)
        Me.gbMain.Controls.Add(Me.txtDocumentFile)
        Me.gbMain.Controls.Add(Me.txtDocumentName)
        Me.gbMain.Controls.Add(Me.Label6)
        Me.gbMain.Controls.Add(Me.Label4)
        Me.gbMain.Controls.Add(Me.Label3)
        Me.gbMain.Controls.Add(Me.Label5)
        Me.gbMain.Controls.Add(Me.txtDocumentRemarks)
        Me.gbMain.Controls.Add(Me.Label2)
        Me.gbMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gbMain.Location = New System.Drawing.Point(0, 41)
        Me.gbMain.Name = "gbMain"
        Me.gbMain.Size = New System.Drawing.Size(685, 319)
        Me.gbMain.TabIndex = 29
        Me.gbMain.TabStop = False
        '
        'btnLKDocumentFile
        '
        Me.btnLKDocumentFile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLKDocumentFile.Location = New System.Drawing.Point(389, 132)
        Me.btnLKDocumentFile.Name = "btnLKDocumentFile"
        Me.btnLKDocumentFile.Size = New System.Drawing.Size(24, 24)
        Me.btnLKDocumentFile.TabIndex = 41
        Me.btnLKDocumentFile.UseVisualStyleBackColor = True
        '
        'btnLKDocument
        '
        Me.btnLKDocument.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLKDocument.Location = New System.Drawing.Point(280, 51)
        Me.btnLKDocument.Name = "btnLKDocument"
        Me.btnLKDocument.Size = New System.Drawing.Size(26, 24)
        Me.btnLKDocument.TabIndex = 40
        Me.btnLKDocument.UseVisualStyleBackColor = True
        '
        'pcbDocument
        '
        Me.pcbDocument.Location = New System.Drawing.Point(421, 19)
        Me.pcbDocument.Name = "pcbDocument"
        Me.pcbDocument.Size = New System.Drawing.Size(256, 294)
        Me.pcbDocument.TabIndex = 39
        Me.pcbDocument.TabStop = False
        '
        'cmbDocumentType
        '
        Me.cmbDocumentType.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbDocumentType.FormattingEnabled = True
        Me.cmbDocumentType.Location = New System.Drawing.Point(120, 80)
        Me.cmbDocumentType.Name = "cmbDocumentType"
        Me.cmbDocumentType.Size = New System.Drawing.Size(154, 21)
        Me.cmbDocumentType.TabIndex = 38
        '
        'txtDocumentID
        '
        Me.txtDocumentID.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDocumentID.Location = New System.Drawing.Point(120, 23)
        Me.txtDocumentID.Name = "txtDocumentID"
        Me.txtDocumentID.Size = New System.Drawing.Size(154, 23)
        Me.txtDocumentID.TabIndex = 18
        '
        'Label1
        '
        Me.Label1.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(17, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 16)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Document ID"
        '
        'txtDocumentCode
        '
        Me.txtDocumentCode.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDocumentCode.Location = New System.Drawing.Point(120, 51)
        Me.txtDocumentCode.Name = "txtDocumentCode"
        Me.txtDocumentCode.Size = New System.Drawing.Size(154, 23)
        Me.txtDocumentCode.TabIndex = 18
        '
        'txtDocumentFile
        '
        Me.txtDocumentFile.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDocumentFile.Location = New System.Drawing.Point(120, 133)
        Me.txtDocumentFile.Name = "txtDocumentFile"
        Me.txtDocumentFile.Size = New System.Drawing.Size(264, 23)
        Me.txtDocumentFile.TabIndex = 18
        '
        'txtDocumentName
        '
        Me.txtDocumentName.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDocumentName.Location = New System.Drawing.Point(120, 105)
        Me.txtDocumentName.Name = "txtDocumentName"
        Me.txtDocumentName.Size = New System.Drawing.Size(194, 23)
        Me.txtDocumentName.TabIndex = 18
        '
        'Label6
        '
        Me.Label6.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(17, 135)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(89, 16)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Document File"
        '
        'Label4
        '
        Me.Label4.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(17, 53)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(98, 16)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Document Code"
        '
        'Label3
        '
        Me.Label3.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(17, 107)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(102, 16)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Document Name"
        '
        'Label5
        '
        Me.Label5.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(18, 162)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 16)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Remarks"
        '
        'txtDocumentRemarks
        '
        Me.txtDocumentRemarks.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDocumentRemarks.Location = New System.Drawing.Point(120, 161)
        Me.txtDocumentRemarks.Multiline = True
        Me.txtDocumentRemarks.Name = "txtDocumentRemarks"
        Me.txtDocumentRemarks.Size = New System.Drawing.Size(293, 71)
        Me.txtDocumentRemarks.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(17, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 16)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Document Type"
        '
        'pnNavigation
        '
        Me.pnNavigation.Controls.Add(Me.btnClose)
        Me.pnNavigation.Controls.Add(Me.btnNew)
        Me.pnNavigation.Controls.Add(Me.btnSave)
        Me.pnNavigation.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnNavigation.Location = New System.Drawing.Point(0, 360)
        Me.pnNavigation.Name = "pnNavigation"
        Me.pnNavigation.Size = New System.Drawing.Size(685, 40)
        Me.pnNavigation.TabIndex = 28
        '
        'btnClose
        '
        Me.btnClose.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Image = Global.IPPProperty.My.Resources.Resources.icon_cancel
        Me.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClose.Location = New System.Drawing.Point(606, 7)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(3, 3, 0, 3)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Padding = New System.Windows.Forms.Padding(2, 0, 0, 1)
        Me.btnClose.Size = New System.Drawing.Size(67, 27)
        Me.btnClose.TabIndex = 19
        Me.btnClose.Text = "Close"
        Me.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnClose.UseVisualStyleBackColor = True
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
        'lblHead
        '
        Me.lblHead.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblHead.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHead.Location = New System.Drawing.Point(0, 0)
        Me.lblHead.Name = "lblHead"
        Me.lblHead.Size = New System.Drawing.Size(685, 41)
        Me.lblHead.TabIndex = 27
        Me.lblHead.Text = "Master Document"
        Me.lblHead.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ofdFile
        '
        Me.ofdFile.FileName = "OpenFileDialog1"
        '
        'chkActive
        '
        Me.chkActive.AutoSize = True
        Me.chkActive.Location = New System.Drawing.Point(122, 237)
        Me.chkActive.Name = "chkActive"
        Me.chkActive.Size = New System.Drawing.Size(56, 17)
        Me.chkActive.TabIndex = 50
        Me.chkActive.Text = "Active"
        Me.chkActive.UseVisualStyleBackColor = True
        '
        'txtLastUpdater
        '
        Me.txtLastUpdater.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLastUpdater.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLastUpdater.Location = New System.Drawing.Point(120, 286)
        Me.txtLastUpdater.Name = "txtLastUpdater"
        Me.txtLastUpdater.ReadOnly = True
        Me.txtLastUpdater.Size = New System.Drawing.Size(216, 23)
        Me.txtLastUpdater.TabIndex = 51
        '
        'txtLastUpdated
        '
        Me.txtLastUpdated.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLastUpdated.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLastUpdated.Location = New System.Drawing.Point(120, 257)
        Me.txtLastUpdated.Name = "txtLastUpdated"
        Me.txtLastUpdated.ReadOnly = True
        Me.txtLastUpdated.Size = New System.Drawing.Size(135, 23)
        Me.txtLastUpdated.TabIndex = 52
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(14, 289)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(80, 16)
        Me.Label8.TabIndex = 47
        Me.Label8.Text = "Last Updater"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(14, 260)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(82, 16)
        Me.Label9.TabIndex = 48
        Me.Label9.Text = "Last Updated"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(14, 237)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(42, 16)
        Me.Label10.TabIndex = 49
        Me.Label10.Text = "Active"
        '
        'frmMSDocument
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(685, 400)
        Me.Controls.Add(Me.gbMain)
        Me.Controls.Add(Me.pnNavigation)
        Me.Controls.Add(Me.lblHead)
        Me.Name = "frmMSDocument"
        Me.Text = "Master Document"
        Me.gbMain.ResumeLayout(False)
        Me.gbMain.PerformLayout()
        CType(Me.pcbDocument, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnNavigation.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gbMain As GroupBox
    Friend WithEvents cmbDocumentType As ComboBox
    Friend WithEvents txtDocumentName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtDocumentRemarks As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents pnNavigation As Panel
    Friend WithEvents btnClose As Button
    Friend WithEvents btnNew As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents lblHead As Label
    Friend WithEvents pcbDocument As PictureBox
    Friend WithEvents txtDocumentID As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtDocumentCode As TextBox
    Friend WithEvents txtDocumentFile As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnLKDocumentFile As Button
    Friend WithEvents btnLKDocument As Button
    Friend WithEvents ofdFile As OpenFileDialog
    Friend WithEvents chkActive As CheckBox
    Friend WithEvents txtLastUpdater As TextBox
    Friend WithEvents txtLastUpdated As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
End Class
