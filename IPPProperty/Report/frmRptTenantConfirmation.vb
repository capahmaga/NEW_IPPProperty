Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports System.Data
Imports System.Configuration

Public Class frmRptTenantConfirmation

    Public dtData As New DataTable

    Private Sub frmRptTenantConfirmation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dateShort As New Date
        Dim report As New rptTenantConfirmation

        Dim path As String = Application.StartupPath & "\rptTenantConfirmation.rpt"

        report.Load(path)

        Dim dt As New DataTable("dtTenantReservation")

        dt.Columns.Add("projectID")
        dt.Columns.Add("tcDate")
        dt.Columns.Add("tcNo")
        dt.Columns.Add("unitNo")
        dt.Columns.Add("reservationNo")
        dt.Columns.Add("proposalNo")
        dt.Columns.Add("tenantName")
        dt.Columns.Add("companyName")
        dt.Columns.Add("tenantAddress")
        dt.Columns.Add("tenantPhone")
        dt.Columns.Add("tenantFacsimile")
        dt.Columns.Add("tenantHandphone")
        dt.Columns.Add("sourceInformation")
        dt.Columns.Add("leaseStatus")
        dt.Columns.Add("beginPeriod")
        dt.Columns.Add("endPeriod")
        dt.Columns.Add("month")
        dt.Columns.Add("day")
        dt.Columns.Add("chargedTarget")
        dt.Columns.Add("contactPerson")
        dt.Columns.Add("cpAddress")
        dt.Columns.Add("cpPhone")
        dt.Columns.Add("cpFacsimile")
        dt.Columns.Add("cpHandphone")
        dt.Columns.Add("condition")
        dt.Columns.Add("note")
        dt.Columns.Add("bestPrice")
        dt.Columns.Add("tax")
        dt.Columns.Add("total")
        dt.Columns.Add("securityDeposit")
        dt.Columns.Add("telephoneDeposit")
        dt.Columns.Add("phoneLine")
        dt.Columns.Add("totalDeposit")
        dt.Columns.Add("heldDeposit")
        dt.Columns.Add("adjusmentDeposit")
        dt.Columns.Add("preparedBy")
        dt.Columns.Add("acknowledgedBy")


        Dim row As DataRow = dt.NewRow

        row("projectID") = dtData.Rows(0).Item("projectID")
        dateShort = dtData.Rows(0).Item("tcDate")
        row("tcDate") = dateShort.ToString("dd-MM-yyyy")
        row("tcNo") = dtData.Rows(0).Item("tcNo")
        row("unitNo") = dtData.Rows(0).Item("unitNO")
        row("reservationNo") = dtData.Rows(0).Item("reservationNo")
        row("proposalNo") = dtData.Rows(0).Item("leaseNo")
        row("tenantName") = dtData.Rows(0).Item("tenantName")
        row("companyName") = dtData.Rows(0).Item("companyName")
        row("tenantAddress") = dtData.Rows(0).Item("tenantAddress")
        row("tenantPhone") = dtData.Rows(0).Item("tenantPhone")
        row("tenantFacsimile") = dtData.Rows(0).Item("tenantFacsimile")
        row("tenantHandphone") = dtData.Rows(0).Item("tenantHandphone")
        row("sourceInformation") = dtData.Rows(0).Item("sourceInformation")

        Select Case row("sourceInformation")
            Case "Billboard"
                report.ReportDefinition.ReportObjects("Text6").Height = 0
            Case "Newspaper"
                report.ReportDefinition.ReportObjects("Text7").Height = 0
            Case "Internet"
                report.ReportDefinition.ReportObjects("Text8").Height = 0
            Case "Old Tenant"
                report.ReportDefinition.ReportObjects("Text9").Height = 0
            Case "Frineds"
                report.ReportDefinition.ReportObjects("Text10").Height = 0
            Case "Group"
                report.ReportDefinition.ReportObjects("Text11").Height = 0
            Case "Agent"
                report.ReportDefinition.ReportObjects("Text12").Height = 0
            Case Else
                report.ReportDefinition.ReportObjects("Text13").Height = 0
        End Select

        row("leaseStatus") = dtData.Rows(0).Item("leaseStatus")
        If row("leaseStatus") = "New" Then
            report.ReportDefinition.ReportObjects("Text16").Height = 0
        Else
            report.ReportDefinition.ReportObjects("Text15").Height = 0
        End If
        dateShort = dtData.Rows(0).Item("beginPeriode")
        row("beginPeriod") = dateShort.ToString("dd-MM-yyyy")
        dateShort = dtData.Rows(0).Item("endPeriode")
        row("endPeriod") = dateShort.ToString("dd-MM-yyyy")
        row("month") = dtData.Rows(0).Item("countMonth")
        row("day") = dtData.Rows(0).Item("countDay")
        row("chargedTarget") = dtData.Rows(0).Item("chargedTarget")

        If row("chargedTarget") = "Personal Account" Then
            report.ReportDefinition.ReportObjects("Text18").Height = 0
        Else
            report.ReportDefinition.ReportObjects("Text17").Height = 0
        End If
        row("contactPerson") = dtData.Rows(0).Item("contactPerson")
        row("cpAddress") = dtData.Rows(0).Item("cpAddress")
        row("cpPhone") = dtData.Rows(0).Item("cpPhone")
        row("cpFacsimile") = dtData.Rows(0).Item("cpFacsimile")
        row("cpHandphone") = dtData.Rows(0).Item("cpHandphone")
        row("condition") = dtData.Rows(0).Item("condition")

        If row("condition") = "SA" Then
            report.ReportDefinition.ReportObjects("Text20").Height = 0
        Else
            report.ReportDefinition.ReportObjects("Text19").Height = 0
        End If

        row("note") = dtData.Rows(0).Item("note")
        row("bestPrice") = FormatNumber((Val(Microsoft.VisualBasic.Str(dtData.Rows(0).Item("bestprice")))), 0)
        row("tax") = FormatNumber((Val(Microsoft.VisualBasic.Str(dtData.Rows(0).Item("tax")))), 0)
        row("total") = FormatNumber((Val(Microsoft.VisualBasic.Str(dtData.Rows(0).Item("total")))), 0)
        row("securityDeposit") = FormatNumber((Val(Microsoft.VisualBasic.Str(dtData.Rows(0).Item("securityDeposit")))), 0)
        row("telephoneDeposit") = FormatNumber((Val(Microsoft.VisualBasic.Str(dtData.Rows(0).Item("telephoneDeposit")))), 0)
        row("phoneLine") = dtData.Rows(0).Item("telephoneLine")
        row("totalDeposit") = FormatNumber((Val(Microsoft.VisualBasic.Str(dtData.Rows(0).Item("totalDeposit")))), 0)
        row("heldDeposit") = FormatNumber((Val(Microsoft.VisualBasic.Str(dtData.Rows(0).Item("heldDeposit")))), 0)
        row("adjusmentDeposit") = FormatNumber((Val(Microsoft.VisualBasic.Str(dtData.Rows(0).Item("adjustmentDeposit")))), 0)
        row("preparedBy") = dtData.Rows(0).Item("preparedBy")
        row("acknowledgedBy") = dtData.Rows(0).Item("acknowledgedBy")

        dt.Rows.Add(row)


        report.Database.Tables("dtTenantReservation").SetDataSource(dt)
        'report.ReportDefinition.ReportObjects("Text53").Height = 0
        CrystalReportViewer1.ReportSource = report
    End Sub
End Class