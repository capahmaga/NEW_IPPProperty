Imports System

Public Class frmMSSite

    'Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
    '    Me.Close()
    'End Sub

    Private Sub frmMSSite_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        setFormDesign(Me)
    End Sub

    Private Sub btnLookup_Click(sender As Object, e As EventArgs) Handles btnLookup.Click

        paramForm = Me
        frmLookupSite.Show()

    End Sub
End Class