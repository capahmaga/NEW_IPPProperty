Imports IPPProperty.clsConnect

Public Class frmMSProject

    Private Sub frmMSProject_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bindTable()
    End Sub

    Private Sub bindTable()
        Dim dsFloor As DataSet
        dsFloor = getAllData("sys.Tables", "name")
        ComboBox1.DataSource = dsFloor.Tables("data")
        ComboBox1.DisplayMember = "name"
        ComboBox1.ValueMember = "Name"
    End Sub

End Class