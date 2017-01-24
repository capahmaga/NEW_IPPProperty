Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports System.Data
Imports System.Configuration
Imports System.IO

Public Class frmDocLeaseProposal
    Public dtData As New DataTable


    Private Sub frmDocLeaseProposal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dateShort As New Date
        Dim report As New docLeaseProposal

        Dim path As String = Application.StartupPath & "\docLeaseProposal.rpt"

        report.Load(path)

        Dim dt As New DataTable("dtLeaseAgreement")

        dt.Columns.Add("projectID")
        dt.Columns.Add("leaseNo")
        dt.Columns.Add("printedDate")
        dt.Columns.Add("picName")
        dt.Columns.Add("companyName")
        dt.Columns.Add("companyAddress")
        dt.Columns.Add("companyPhone")
        dt.Columns.Add("companyFax")
        dt.Columns.Add("companyEmail")
        dt.Columns.Add("occupiedBy")
        dt.Columns.Add("leaseTitle")
        dt.Columns.Add("towerName")
        dt.Columns.Add("unitNo")
        dt.Columns.Add("unitType")
        dt.Columns.Add("unitSize")
        dt.Columns.Add("condition")
        dt.Columns.Add("detailCondition")
        dt.Columns.Add("commencementDate")
        dt.Columns.Add("expiryDate")
        dt.Columns.Add("countMonth")
        dt.Columns.Add("countDay")
        dt.Columns.Add("renewMonthDay")
        dt.Columns.Add("paymentTerm")
        dt.Columns.Add("paymentType")
        dt.Columns.Add("publishRate")
        dt.Columns.Add("rentalBaseMonth")
        dt.Columns.Add("rentalBaseDaily")
        dt.Columns.Add("VAT")
        dt.Columns.Add("totalAmountRental")
        dt.Columns.Add("securityDeposit")
        dt.Columns.Add("basicPhoneDeposit")
        dt.Columns.Add("phoneLine")
        dt.Columns.Add("totalPhoneDeposit")
        dt.Columns.Add("totalAmountDeposit")
        dt.Columns.Add("heldDeposit")
        dt.Columns.Add("adjustmentDeposit")
        dt.Columns.Add("basicAddBreakfast")
        dt.Columns.Add("totalPax")
        dt.Columns.Add("totalAmountBreakfast")
        dt.Columns.Add("basicAddLaundry")
        dt.Columns.Add("totalPacket")
        dt.Columns.Add("totalAmountLaundry")
        dt.Columns.Add("grandTotalAmount")
        dt.Columns.Add("quotedValidDate")
        dt.Columns.Add("preparedSignature")
        dt.Columns.Add("preparedBy")
        dt.Columns.Add("preparedByTitle")
        dt.Columns.Add("acknowledgedSignature")
        dt.Columns.Add("acknowledgedBy")
        dt.Columns.Add("acknowledgedByTitle")


        Dim row As DataRow = dt.NewRow
        row("projectID") = dtData.Rows(0).Item("projectID")
        row("leaseNo") = dtData.Rows(0).Item("leaseno")
        dateShort = dtData.Rows(0).Item("printedDate")
        row("printedDate") = dateShort.ToString("MMMM dd, yyyy")
        row("picName") = dtData.Rows(0).Item("personalName")
        row("companyName") = dtData.Rows(0).Item("companyName")
        row("companyAddress") = dtData.Rows(0).Item("address")
        row("companyPhone") = dtData.Rows(0).Item("phone")
        row("companyFax") = dtData.Rows(0).Item("facsimile")
        row("companyEmail") = dtData.Rows(0).Item("email")
        row("occupiedBy") = dtData.Rows(0).Item("occupiedBy")
        row("leaseTitle") = dtData.Rows(0).Item("leaseType")

        Dim countMonth As New Integer
        Dim countday As New Integer

        row("countMonth") = dtData.Rows(0).Item("countMonth")

        countMonth = Val(row("countMonth"))
        If row("countMonth") = 0 Then
            report.ReportDefinition.ReportObjects("Text32").Height = 0
            report.ReportDefinition.ReportObjects("Text35").Height = 0
            report.ReportDefinition.ReportObjects("Text47").Height = 0
            report.ReportDefinition.ReportObjects("Text48").Height = 0
            report.ReportDefinition.ReportObjects("Text73").Height = 0
            report.ReportDefinition.ReportObjects("text72").Height = 0
        End If

        row("countDay") = dtData.Rows(0).Item("countDay")
        countday = Val(row("countDay"))
        If row("countDay") = 0 Then
            report.ReportDefinition.ReportObjects("Text34").Height = 0
            report.ReportDefinition.ReportObjects("Text33").Height = 0
            report.ReportDefinition.ReportObjects("Text49").Height = 0
            report.ReportDefinition.ReportObjects("Text50").Height = 0
            report.ReportDefinition.ReportObjects("Text75").Height = 0
            report.ReportDefinition.ReportObjects("Text74").Height = 0
        End If


        If row("countMonth") <> 0 Then
            row("renewMonthDay") = countMonth & " month(s)  and "
            If row("countDay") <> 0 Then
                row("renewMonthDay") = countday & " day(s)"
            End If
        Else
            If row("countDay") <> 0 Then
                row("renewMonthDay") = countday & " day(s)"
            End If
        End If

        If row("leaseTitle") = "New" Then
            row("leaseTitle") = "LEASE CALCULATION"

            report.ReportDefinition.ReportObjects("Text63").Height = 0
            report.ReportDefinition.ReportObjects("Text89").Height = 0
            report.ReportDefinition.ReportObjects("Text88").Height = 0
            report.ReportDefinition.ReportObjects("Text68").Width = 0
            report.ReportDefinition.ReportObjects("Text64").Height = 0
            report.ReportDefinition.ReportObjects("Text91").Height = 0
            report.ReportDefinition.ReportObjects("Text90").Height = 0

            report.ReportDefinition.ReportObjects("text67").Height = 0
            report.ReportDefinition.ReportObjects("text69").Height = 0

        Else
            row("leaseTitle") = "RENEWAL CALCULATION"

            report.ReportDefinition.ReportObjects("text16").Height = 0
            report.ReportDefinition.ReportObjects("text107").Height = 0
            report.ReportDefinition.ReportObjects("text106").Height = 0

        End If
        row("towerName") = dtData.Rows(0).Item("towerName")
        row("unitNo") = dtData.Rows(0).Item("unitNo")
        row("unitType") = "(" & dtData.Rows(0).Item("unitTypeName") & ")"
        row("unitSize") = dtData.Rows(0).Item("unitSize")
        row("condition") = dtData.Rows(0).Item("conditionType")

        If row("condition") = "SA" Then
            row("condition") = " SERVICED APARTMENTS"
        Else
            row("condition") = " NON SERVICED APARTMENTS"
        End If

        row("detailCondition") = dtData.Rows(0).Item("condition")
        dateShort = dtData.Rows(0).Item("commencementDate")
        row("commencementDate") = dateShort.ToString("dd-MMM-yyyy")
        dateShort = dtData.Rows(0).Item("expiredDate")
        row("expiryDate") = dateShort.ToString("dd-MMM-yyyy")



        row("paymentTerm") = dtData.Rows(0).Item("paymentTerm")
        row("paymentType") = dtData.Rows(0).Item("paymentType")
        row("publishRate") = FormatNumber((Val(Microsoft.VisualBasic.Str(dtData.Rows(0).Item("publishRentalBase")))), 0)
        row("rentalBaseMonth") = FormatNumber((Val(Microsoft.VisualBasic.Str(dtData.Rows(0).Item("rentalBaseMonth")))), 0)
        row("rentalBaseDaily") = FormatNumber((Val(Microsoft.VisualBasic.Str(dtData.Rows(0).Item("rentalBaseDay")))), 0)
        row("VAT") = FormatNumber((Val(Microsoft.VisualBasic.Str(dtData.Rows(0).Item("VAT")))), 0)
        row("totalAmountRental") = FormatNumber((Val(Microsoft.VisualBasic.Str(dtData.Rows(0).Item("totalAmountRental")))), 0)
        row("securityDeposit") = FormatNumber((Val(Microsoft.VisualBasic.Str(dtData.Rows(0).Item("securityDeposit")))), 0)
        row("basicPhoneDeposit") = FormatNumber((Val(Microsoft.VisualBasic.Str(dtData.Rows(0).Item("basicPhoneDeposit")))), 0)
        row("phoneLine") = dtData.Rows(0).Item("linePhone")
        row("totalPhoneDeposit") = FormatNumber((Val(Microsoft.VisualBasic.Str(dtData.Rows(0).Item("totalPhoneDeposit")))), 0)
        row("totalAmountDeposit") = FormatNumber((Val(Microsoft.VisualBasic.Str(dtData.Rows(0).Item("totalAmountDeposit")))), 0)
        row("heldDeposit") = FormatNumber((Val(Microsoft.VisualBasic.Str(dtData.Rows(0).Item("heldDeposit")))), 0)
        row("adjustmentDeposit") = FormatNumber((Val(Microsoft.VisualBasic.Str(dtData.Rows(0).Item("totalAdjustment")))), 0)

        Dim useLetter As New Boolean

        useLetter = dtData.Rows(0).Item("isGuaranteeLetter")

        If Not useLetter Then
            report.ReportDefinition.ReportObjects("text55").Height = 0
        End If

        row("basicAddBreakfast") = "@ Rp. " & FormatNumber((Val(Microsoft.VisualBasic.Str(dtData.Rows(0).Item("basicAddBreakfast")))), 0) & ",-/pax X " & dtData.Rows(0).Item("totalPax") & " pax"
        row("totalPax") = dtData.Rows(0).Item("totalPax")
        row("totalAmountBreakfast") = FormatNumber((Val(Microsoft.VisualBasic.Str(dtData.Rows(0).Item("totalAmountBreakfast")))), 0)

        If row("totalAmountBreakfast") = 0 Then
            report.ReportDefinition.ReportObjects("Text65").Height = 0
            report.ReportDefinition.ReportObjects("Text100").Height = 0
            report.ReportDefinition.ReportObjects("Text93").Height = 0
            report.ReportDefinition.ReportObjects("Text92").Height = 0

        End If

        row("basicAddLaundry") = "@ Rp. " & FormatNumber((Val(Microsoft.VisualBasic.Str(dtData.Rows(0).Item("basicAddLaundry")))), 0) & ",-/packet X " & dtData.Rows(0).Item("totalPacket") & " packet"
        row("totalPacket") = dtData.Rows(0).Item("totalPacket")
        row("totalAmountLaundry") = FormatNumber((Val(Microsoft.VisualBasic.Str(dtData.Rows(0).Item("totalAmountAddLaundry")))), 0)

        If row("totalAmountLaundry") = 0 Then
            report.ReportDefinition.ReportObjects("Text70").Height = 0
            report.ReportDefinition.ReportObjects("Text101").Height = 0
            report.ReportDefinition.ReportObjects("Text95").Height = 0
            report.ReportDefinition.ReportObjects("Text94").Height = 0

        End If

        row("grandTotalAmount") = FormatNumber((Val(Microsoft.VisualBasic.Str(dtData.Rows(0).Item("grandTotalAmount")))), 0)
        dateShort = dtData.Rows(0).Item("quotedValidDate")
        row("quotedValidDate") = dateShort.ToString("dd-MMM-yyyy")
        row("preparedBy") = dtData.Rows(0).Item("salesPreparedBy")
        row("preparedByTitle") = dtData.Rows(0).Item("preparedTitle")
        row("acknowledgedBy") = dtData.Rows(0).Item("salesName")
        row("acknowledgedByTitle") = dtData.Rows(0).Item("jobTitle")

        Dim signature As New Boolean

        signature = dtData.Rows(0).Item("isUseSalesSignature")

        If signature Then
            ' Dim data As Byte() = DirectCast(dtData.Rows(0).Item("salesSign"), Byte())

            row("preparedSignature") = dtData.Rows(0).Item("salesSign")

            Select Case dtData.Rows(0).Item("salesPreparedBy")
                Case "Fransiskus M Mbotu"
                    ' report.ReportDefinition.ReportObjects("picFransiscus").Height = 0
                    report.ReportDefinition.ReportObjects("picCici").Height = 0
                    report.ReportDefinition.ReportObjects("picPutu").Height = 0
                    report.ReportDefinition.ReportObjects("picNatalie").Height = 0
                    report.ReportDefinition.ReportObjects("picRobbi").Height = 0
                Case "Cici Diana"
                    report.ReportDefinition.ReportObjects("picFransiscus").Height = 0
                    'report.ReportDefinition.ReportObjects("picCici").Height = 0
                    report.ReportDefinition.ReportObjects("picPutu").Height = 0
                    report.ReportDefinition.ReportObjects("picNatalie").Height = 0
                    report.ReportDefinition.ReportObjects("picRobbi").Height = 0
                Case "Putu Eka Miwaltika"
                    report.ReportDefinition.ReportObjects("picFransiscus").Height = 0
                    report.ReportDefinition.ReportObjects("picCici").Height = 0
                    'report.ReportDefinition.ReportObjects("picPutu").Height = 0
                    report.ReportDefinition.ReportObjects("picNatalie").Height = 0
                    report.ReportDefinition.ReportObjects("picRobbi").Height = 0
                Case "Natalie Irene Beatrick"
                    report.ReportDefinition.ReportObjects("picFransiscus").Height = 0
                    report.ReportDefinition.ReportObjects("picCici").Height = 0
                    report.ReportDefinition.ReportObjects("picPutu").Height = 0
                    'report.ReportDefinition.ReportObjects("picNatalie").Height = 0
                    report.ReportDefinition.ReportObjects("picRobbi").Height = 0
                Case "Robbi Farhan"
                    report.ReportDefinition.ReportObjects("picFransiscus").Height = 0
                    report.ReportDefinition.ReportObjects("picCici").Height = 0
                    report.ReportDefinition.ReportObjects("picPutu").Height = 0
                    report.ReportDefinition.ReportObjects("picNatalie").Height = 0
                    'report.ReportDefinition.ReportObjects("picRobbi").Height = 0
            End Select

        Else
            report.ReportDefinition.ReportObjects("picFransiscus").Height = 0
            report.ReportDefinition.ReportObjects("picCici").Height = 0
            report.ReportDefinition.ReportObjects("picPutu").Height = 0
            report.ReportDefinition.ReportObjects("picNatalie").Height = 0
            report.ReportDefinition.ReportObjects("picRobbi").Height = 0

        End If

        signature = dtData.Rows(0).Item("isUseParentSignature")

        If signature Then
            'Dim imgData As New Byte()

            'row("acknowledgedSignature") = dtData.Rows(0).Item("signature")

            If dtData.Rows(0).Item("salesName") <> "Fransiskus M Mbotu" Then
                report.ReportDefinition.ReportObjects("picAcknowledged").Height = 0
            End If
        Else
            report.ReportDefinition.ReportObjects("picAcknowledged").Height = 0
        End If

        dt.Rows.Add(row)
        dt.AcceptChanges()


        report.Database.Tables("dtLeaseAgreement").SetDataSource(dt)
        CrystalReportViewer1.ReportSource = report
    End Sub
End Class