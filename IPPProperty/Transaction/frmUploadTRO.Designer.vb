<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmUploadTRO
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
        Me.pnlHead = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.pnNavigation = New System.Windows.Forms.Panel()
        Me.txtUploaded = New System.Windows.Forms.TextBox()
        Me.txtUpload = New System.Windows.Forms.TextBox()
        Me.lblUploaded = New System.Windows.Forms.Label()
        Me.lblUpload = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.ofdData = New System.Windows.Forms.OpenFileDialog()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtPath = New System.Windows.Forms.TextBox()
        Me.btnLKFile = New System.Windows.Forms.Button()
        Me.dgvData = New System.Windows.Forms.DataGridView()
        Me.btnUpload = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbUploadType = New System.Windows.Forms.ComboBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pnlHead.SuspendLayout()
        Me.pnNavigation.SuspendLayout()
        CType(Me.dgvData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlHead
        '
        Me.pnlHead.Controls.Add(Me.Label1)
        Me.pnlHead.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHead.Location = New System.Drawing.Point(0, 0)
        Me.pnlHead.Name = "pnlHead"
        Me.pnlHead.Size = New System.Drawing.Size(907, 38)
        Me.pnlHead.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(907, 35)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Upload Transaction"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnPrint
        '
        Me.btnPrint.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPrint.Location = New System.Drawing.Point(526, 7)
        Me.btnPrint.Margin = New System.Windows.Forms.Padding(3, 3, 0, 3)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Padding = New System.Windows.Forms.Padding(2, 0, 0, 1)
        Me.btnPrint.Size = New System.Drawing.Size(67, 27)
        Me.btnPrint.TabIndex = 18
        Me.btnPrint.Text = "Print"
        Me.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'pnNavigation
        '
        Me.pnNavigation.Controls.Add(Me.txtUploaded)
        Me.pnNavigation.Controls.Add(Me.txtUpload)
        Me.pnNavigation.Controls.Add(Me.lblUploaded)
        Me.pnNavigation.Controls.Add(Me.lblUpload)
        Me.pnNavigation.Controls.Add(Me.btnPrint)
        Me.pnNavigation.Controls.Add(Me.btnClose)
        Me.pnNavigation.Controls.Add(Me.btnNew)
        Me.pnNavigation.Controls.Add(Me.btnSave)
        Me.pnNavigation.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnNavigation.Location = New System.Drawing.Point(0, 461)
        Me.pnNavigation.Name = "pnNavigation"
        Me.pnNavigation.Size = New System.Drawing.Size(907, 40)
        Me.pnNavigation.TabIndex = 9
        '
        'txtUploaded
        '
        Me.txtUploaded.Location = New System.Drawing.Point(410, 11)
        Me.txtUploaded.Name = "txtUploaded"
        Me.txtUploaded.Size = New System.Drawing.Size(100, 20)
        Me.txtUploaded.TabIndex = 23
        '
        'txtUpload
        '
        Me.txtUpload.Location = New System.Drawing.Point(222, 11)
        Me.txtUpload.Name = "txtUpload"
        Me.txtUpload.Size = New System.Drawing.Size(100, 20)
        Me.txtUpload.TabIndex = 23
        '
        'lblUploaded
        '
        Me.lblUploaded.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.lblUploaded.AutoSize = True
        Me.lblUploaded.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUploaded.Location = New System.Drawing.Point(348, 12)
        Me.lblUploaded.Name = "lblUploaded"
        Me.lblUploaded.Size = New System.Drawing.Size(61, 16)
        Me.lblUploaded.TabIndex = 22
        Me.lblUploaded.Text = "Uploaded"
        '
        'lblUpload
        '
        Me.lblUpload.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.lblUpload.AutoSize = True
        Me.lblUpload.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUpload.Location = New System.Drawing.Point(173, 12)
        Me.lblUpload.Name = "lblUpload"
        Me.lblUpload.Size = New System.Drawing.Size(47, 16)
        Me.lblUpload.TabIndex = 21
        Me.lblUpload.Text = "Upload"
        '
        'btnClose
        '
        Me.btnClose.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Image = Global.IPPProperty.My.Resources.Resources.icon_cancel
        Me.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClose.Location = New System.Drawing.Point(598, 7)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(3, 3, 0, 3)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Padding = New System.Windows.Forms.Padding(2, 0, 0, 1)
        Me.btnClose.Size = New System.Drawing.Size(73, 27)
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
        Me.btnNew.Size = New System.Drawing.Size(62, 26)
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
        Me.btnSave.Size = New System.Drawing.Size(64, 26)
        Me.btnSave.TabIndex = 15
        Me.btnSave.Text = "Save"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(11, 36)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(71, 16)
        Me.Label13.TabIndex = 20
        Me.Label13.Text = "Upload File"
        '
        'txtPath
        '
        Me.txtPath.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPath.Location = New System.Drawing.Point(88, 33)
        Me.txtPath.Name = "txtPath"
        Me.txtPath.Size = New System.Drawing.Size(498, 23)
        Me.txtPath.TabIndex = 18
        '
        'btnLKFile
        '
        Me.btnLKFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLKFile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLKFile.Location = New System.Drawing.Point(592, 33)
        Me.btnLKFile.Name = "btnLKFile"
        Me.btnLKFile.Size = New System.Drawing.Size(28, 23)
        Me.btnLKFile.TabIndex = 19
        Me.btnLKFile.UseVisualStyleBackColor = True
        '
        'dgvData
        '
        Me.dgvData.AllowUserToAddRows = False
        Me.dgvData.AllowUserToDeleteRows = False
        Me.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvData.Location = New System.Drawing.Point(4, 71)
        Me.dgvData.Name = "dgvData"
        Me.dgvData.ReadOnly = True
        Me.dgvData.Size = New System.Drawing.Size(900, 344)
        Me.dgvData.TabIndex = 21
        '
        'btnUpload
        '
        Me.btnUpload.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpload.Image = Global.IPPProperty.My.Resources.Resources.Folders_Uploads_Folder_icon
        Me.btnUpload.Location = New System.Drawing.Point(626, 32)
        Me.btnUpload.Name = "btnUpload"
        Me.btnUpload.Size = New System.Drawing.Size(81, 25)
        Me.btnUpload.TabIndex = 22
        Me.btnUpload.Text = "Upload"
        Me.btnUpload.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 16)
        Me.Label2.TabIndex = 43
        Me.Label2.Text = "Upload Type"
        '
        'cmbUploadType
        '
        Me.cmbUploadType.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbUploadType.FormattingEnabled = True
        Me.cmbUploadType.Items.AddRange(New Object() {"Arrival List", "Billing"})
        Me.cmbUploadType.Location = New System.Drawing.Point(88, 8)
        Me.cmbUploadType.Name = "cmbUploadType"
        Me.cmbUploadType.Size = New System.Drawing.Size(154, 21)
        Me.cmbUploadType.TabIndex = 44
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.cmbUploadType)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.btnUpload)
        Me.Panel1.Controls.Add(Me.dgvData)
        Me.Panel1.Controls.Add(Me.btnLKFile)
        Me.Panel1.Controls.Add(Me.txtPath)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 38)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(907, 423)
        Me.Panel1.TabIndex = 10
        '
        'frmUploadTRO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(907, 501)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.pnlHead)
        Me.Controls.Add(Me.pnNavigation)
        Me.Name = "frmUploadTRO"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Upload Transaction"
        Me.pnlHead.ResumeLayout(False)
        Me.pnNavigation.ResumeLayout(False)
        Me.pnNavigation.PerformLayout()
        CType(Me.dgvData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlHead As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents btnPrint As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents btnNew As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents pnNavigation As Panel
    Friend WithEvents ofdData As OpenFileDialog
    Friend WithEvents lblUploaded As Label
    Friend WithEvents lblUpload As Label
    Friend WithEvents txtUploaded As TextBox
    Friend WithEvents txtUpload As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txtPath As TextBox
    Friend WithEvents btnLKFile As Button
    Friend WithEvents dgvData As DataGridView
    Friend WithEvents btnUpload As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbUploadType As ComboBox
    Friend WithEvents Panel1 As Panel
End Class
