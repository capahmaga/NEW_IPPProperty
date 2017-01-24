Public Class frmLogin

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pnLogin.Location = New Point(ClientSize.Width / 2 - pnLogin.Size.Width / 2, ClientSize.Height / 2 - pnLogin.Size.Height / 2)
        pnLogin.Anchor = AnchorStyles.None
        Me.BackColor = Color.FromArgb(0, 63, 105)
        pnLogin.BackColor = Color.FromArgb(40, 141, 207)
        btnLogin.BackColor = Color.FromArgb(75, 77, 79)
        btnLogin.FlatStyle = FlatStyle.Flat
        btnLogin.FlatAppearance.BorderColor = Color.FromArgb(75, 77, 79)
        btnLogin.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 63, 105)
        Panel2.BackColor = Color.White
        Label1.ForeColor = Color.White
        Label2.ForeColor = Color.White
        Label3.ForeColor = Color.White
        lblPassword.ForeColor = Color.White
        btnLogin.ForeColor = Color.White
        Me.txtUsername.AutoSize = False
        Me.txtPassword.AutoSize = False
        Me.txtUsername.Height = 25
        Me.txtPassword.Height = 25

        Dim imgEye As New Bitmap((New Bitmap(My.Resources.eye_icon)), 18, 18)
        pcbEye.Image = imgEye

    End Sub
    Private Sub Panel1_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles pnLogin.Paint

        pnLogin.BorderStyle = BorderStyle.FixedSingle
        e.Graphics.DrawRectangle(New Pen(Color.White, 2), pnLogin.ClientRectangle)

    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim dtData As New DataTable

        dtData = clsConnect.getAllData("APP_User",,, " username='" + secureString(txtUsername.Text) + "'").Tables("data")

        If dtData.Rows.Count > 0 Or dtData IsNot Nothing Then
            If txtPassword.Text = HiddenData.Decrypt(dtData.Rows(0).Item("password")) Then
                callMessage(1, "Login Succeed")
                If msgBoxOK.ShowDialog = DialogResult.OK Then
                    Username = txtUsername.Text
                    frmAddMenu.Show()
                    Me.Hide()
                End If
            Else
                callMessage(3, "Incorrect Username or Password")
                If msgBoxOK.ShowDialog = DialogResult.OK Then
                    Exit Sub
                End If
            End If
        End If

    End Sub

    Private Sub pcbEye_MouseDown(sender As Object, e As EventArgs) Handles pcbEye.MouseDown
        txtPassword.UseSystemPasswordChar = False
    End Sub

    Private Sub pcbEye_MouseUp(sender As Object, e As EventArgs) Handles pcbEye.MouseUp
        txtPassword.UseSystemPasswordChar = True
    End Sub

End Class