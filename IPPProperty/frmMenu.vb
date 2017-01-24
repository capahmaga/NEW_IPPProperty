

Public Class frmAddMenu

    Private Sub frmMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        paramType = 1
        Me.Text = "PT Indonesia Prima Property Tbk"
        Me.BackColor = Color.FromArgb(0, 63, 105)
        paramForm = Me

        GlobalProjectID = 1

        If settingPermission() = False Then
            callMessage(3, "You don't currently have permission to access this Application.")
            If msgBoxOK.ShowDialog = DialogResult.OK Then
                End
            End If
        End If

    End Sub

    Private Sub menuAction_Click(sender As Object, e As EventArgs)
        Dim menuCode As String = sender.Name.ToString

        Dim methodName As String = "menu" & menuCode.Replace(".", "")
        Dim menuAction As New clsMenuAction
        Dim getTypeAction As System.Type = GetType(clsMenuAction)
        Dim actionMenu As System.Reflection.MethodInfo = getTypeAction.GetMethod(methodName)
        Dim param() As Object = {""}
        Try
            actionMenu.Invoke(menuAction, param)
        Catch ex As Exception
            MessageBox.Show("Please Generate Function for Method " + methodName, sender.text)
        End Try
    End Sub

    'This code is used to recursively add child menu items by filtering by ParentID
    Public Function AddChildMenuItems(ByVal menuData As DataTable, ByVal parentMenuItem As String,
                                      ByRef menuitem As ToolStripMenuItem) As ToolStripMenuItem

        Dim view As DataView = New DataView(menuData)
        view.RowFilter = ("ParentID=" + parentMenuItem)
        For Each row As DataRowView In view
            Dim newMenuItem As New ToolStripMenuItem(row.Item("menuName"), Nothing)
            If row.Item("menuAction") <> "" Then
                AddHandler newMenuItem.Click, AddressOf menuAction_Click
            End If
            newMenuItem.Name = row.Item("menuCode")
            If row.Item("menuName") = "Separator" Then
                menuitem.DropDownItems.Add(New ToolStripSeparator())
            Else
                menuitem.DropDownItems.Add(newMenuItem)
            End If

            AddChildMenuItems(menuData, row.Item("menuID"), newMenuItem)
        Next
        Return menuitem
    End Function


    Public Function settingPermission() As Boolean
        Dim menu As Boolean = True
        Dim dtMenu As New DataTable

        dtMenu = clsConnect.getAllData("APP_Menu",,,, "menuID asc").Tables("Data")

        If dtMenu.Rows.Count > 0 And (dtMenu IsNot Nothing) Then
            Dim view As DataView = New DataView(dtMenu)
            view.RowFilter = "ParentID is null"
            For Each row As DataRowView In view
                Dim newMenuItem As New ToolStripMenuItem(row.Item("menuName"), Nothing)
                newMenuItem.Name = row.Item("menuCode")
                msMainMenu.Items.Add(newMenuItem)
                AddChildMenuItems(dtMenu, row.Item("menuID"), newMenuItem)
            Next
        Else
            menu = False
        End If
        Return menu
    End Function

End Class

