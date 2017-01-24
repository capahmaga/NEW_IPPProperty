<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class msgBoxOK
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
        Me.lblMain = New System.Windows.Forms.Label()
        Me.lblFooter = New System.Windows.Forms.Label()
        Me.pnlHead = New System.Windows.Forms.Panel()
        Me.lblHead = New System.Windows.Forms.Label()
        Me.pnlNavWarning = New System.Windows.Forms.Panel()
        Me.btnNo = New System.Windows.Forms.Button()
        Me.btnYes = New System.Windows.Forms.Button()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.picLogo = New System.Windows.Forms.PictureBox()
        Me.pnlHead.SuspendLayout()
        Me.pnlNavWarning.SuspendLayout()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblMain
        '
        Me.lblMain.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblMain.Location = New System.Drawing.Point(92, 47)
        Me.lblMain.Name = "lblMain"
        Me.lblMain.Size = New System.Drawing.Size(286, 41)
        Me.lblMain.TabIndex = 10
        Me.lblMain.Text = "Label1"
        '
        'lblFooter
        '
        Me.lblFooter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblFooter.Location = New System.Drawing.Point(92, 88)
        Me.lblFooter.Name = "lblFooter"
        Me.lblFooter.Size = New System.Drawing.Size(286, 25)
        Me.lblFooter.TabIndex = 11
        Me.lblFooter.Text = "Label2"
        '
        'pnlHead
        '
        Me.pnlHead.Controls.Add(Me.lblHead)
        Me.pnlHead.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHead.Location = New System.Drawing.Point(0, 0)
        Me.pnlHead.Name = "pnlHead"
        Me.pnlHead.Size = New System.Drawing.Size(390, 32)
        Me.pnlHead.TabIndex = 12
        '
        'lblHead
        '
        Me.lblHead.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblHead.Location = New System.Drawing.Point(6, 5)
        Me.lblHead.Name = "lblHead"
        Me.lblHead.Size = New System.Drawing.Size(381, 23)
        Me.lblHead.TabIndex = 1
        Me.lblHead.Text = "Label3"
        Me.lblHead.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pnlNavWarning
        '
        Me.pnlNavWarning.Controls.Add(Me.btnNo)
        Me.pnlNavWarning.Controls.Add(Me.btnYes)
        Me.pnlNavWarning.Controls.Add(Me.btnOK)
        Me.pnlNavWarning.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlNavWarning.Location = New System.Drawing.Point(0, 127)
        Me.pnlNavWarning.Name = "pnlNavWarning"
        Me.pnlNavWarning.Size = New System.Drawing.Size(390, 44)
        Me.pnlNavWarning.TabIndex = 13
        '
        'btnNo
        '
        Me.btnNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNo.Location = New System.Drawing.Point(201, 8)
        Me.btnNo.Name = "btnNo"
        Me.btnNo.Size = New System.Drawing.Size(120, 29)
        Me.btnNo.TabIndex = 11
        Me.btnNo.Text = "No"
        Me.btnNo.UseVisualStyleBackColor = True
        '
        'btnYes
        '
        Me.btnYes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnYes.Location = New System.Drawing.Point(74, 8)
        Me.btnYes.Name = "btnYes"
        Me.btnYes.Size = New System.Drawing.Size(120, 29)
        Me.btnYes.TabIndex = 10
        Me.btnYes.Text = "Yes"
        Me.btnYes.UseVisualStyleBackColor = True
        '
        'btnOK
        '
        Me.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOK.Location = New System.Drawing.Point(123, 8)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(149, 29)
        Me.btnOK.TabIndex = 9
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'picLogo
        '
        Me.picLogo.Location = New System.Drawing.Point(11, 47)
        Me.picLogo.Name = "picLogo"
        Me.picLogo.Size = New System.Drawing.Size(65, 65)
        Me.picLogo.TabIndex = 9
        Me.picLogo.TabStop = False
        '
        'msgBoxOK
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(390, 171)
        Me.ControlBox = False
        Me.Controls.Add(Me.pnlNavWarning)
        Me.Controls.Add(Me.pnlHead)
        Me.Controls.Add(Me.lblFooter)
        Me.Controls.Add(Me.lblMain)
        Me.Controls.Add(Me.picLogo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "msgBoxOK"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Attention"
        Me.pnlHead.ResumeLayout(False)
        Me.pnlNavWarning.ResumeLayout(False)
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents picLogo As PictureBox
    Friend WithEvents lblMain As Label
    Friend WithEvents lblFooter As Label
    Friend WithEvents pnlHead As Panel
    Friend WithEvents lblHead As Label
    Friend WithEvents pnlNavWarning As Panel
    Friend WithEvents btnOK As Button
    Friend WithEvents btnNo As Button
    Friend WithEvents btnYes As Button
End Class
