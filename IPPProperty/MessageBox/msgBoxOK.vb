Imports System
Imports System.Reflection

Public Class msgBoxOK


    Private Sub msgBoxOK_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Select Case paramType
            Case 1
                ' Message Success
                showBox(paramType, messageBoxMessage)
            Case 2
                'Message Confirmation
                showBox(paramType, messageBoxMessage)
            Case Else
                'Message Error Aplication
                showBox(paramType, messageBoxMessage, "Contact your Administration.")
        End Select

    End Sub

    Public Sub hiddenButton(ByVal type As String)
        If type = 2 Then
            btnOK.Visible = False
            btnNo.Visible = True
            btnYes.Visible = True
        Else
            btnOK.Visible = True
            btnNo.Visible = False
            btnYes.Visible = False
        End If
    End Sub


    Public Sub showBox(ByVal type As String, ByVal mainInfo As String, Optional ByVal footer As String = "")
        Dim msgBoxFontChild As New Font("Tahoma", 8, FontStyle.Regular)
        Dim msgBoxFont As New Font("Tahoma", 9.5, FontStyle.Bold)

        lblMain.Text = mainInfo
        lblFooter.Text = footer

        lblMain.Font = msgBoxFont
        lblFooter.Font = msgBoxFontChild
        lblHead.Font = msgBoxFont

        lblHead.ForeColor = Color.White

        pnlNavWarning.BackColor = Color.FromArgb(45, 118, 183)

        hiddenButton(type)


        If type = 1 Then

            Dim imgSuccess As New Bitmap((New Bitmap(My.Resources.success_icon)), 65, 65)
            picLogo.Image = imgSuccess

            lblHead.Text = "SUCCESS"
            Me.BackColor = Color.White

            pnlHead.BackColor = Color.FromArgb(93, 164, 35)

            lblMain.ForeColor = Color.Black
            lblFooter.ForeColor = Color.Black

            btnOK.FlatStyle = FlatStyle.Flat
            btnOK.BackColor = Color.FromArgb(22, 122, 168)
            btnOK.FlatAppearance.BorderColor = Color.FromArgb(10, 166, 248)
            btnOK.Font = msgBoxFont
            btnOK.ForeColor = Color.White

        End If

        If type = 2 Then

            Dim imgAttention As New Bitmap((New Bitmap(My.Resources.sign_warning_icon)), 65, 65)

            picLogo.Image = imgAttention

            lblHead.Text = "ATTENTION"

            Me.BackColor = Color.White
            pnlHead.BackColor = Color.FromArgb(227, 176, 0)

            lblMain.ForeColor = Color.Black
            lblFooter.ForeColor = Color.Black

            btnYes.FlatStyle = FlatStyle.Flat
            btnYes.BackColor = Color.FromArgb(22, 122, 168)
            btnYes.FlatAppearance.BorderColor = Color.FromArgb(10, 166, 248)
            btnYes.Font = msgBoxFont
            btnYes.ForeColor = Color.White

            btnNo.FlatStyle = FlatStyle.Flat
            btnNo.BackColor = Color.FromArgb(22, 122, 168)
            btnNo.FlatAppearance.BorderColor = Color.FromArgb(10, 166, 248)
            btnNo.Font = msgBoxFont
            btnNo.ForeColor = Color.White
        End If

        If type = 3 Then

            Dim imgWarning As New Bitmap((New Bitmap(My.Resources.Actions_stop_icon)), 65, 65)
            picLogo.Image = imgWarning

            lblHead.Text = "WARNING"
            Me.BackColor = Color.FromArgb(82, 158, 204)

            lblMain.ForeColor = Color.White
            lblFooter.ForeColor = Color.White

            pnlHead.BackColor = Color.FromArgb(198, 15, 19)

            btnOK.FlatStyle = FlatStyle.Flat
            btnOK.BackColor = Color.FromArgb(22, 122, 168)
            btnOK.FlatAppearance.BorderColor = Color.FromArgb(10, 166, 248)
            btnOK.Font = msgBoxFont
            btnOK.ForeColor = Color.White

        End If

    End Sub

    Private Sub btnYes_Click(sender As Object, e As EventArgs) Handles btnYes.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Yes
    End Sub

    Private Sub btnNo_Click(sender As Object, e As EventArgs) Handles btnNo.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.No
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.No
    End Sub
End Class