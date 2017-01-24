
Imports System.Globalization
Module appFunction



    'Public Function GetDateSpanText(ByVal fromDate As Date, Optional toDate As Date = Nothing) As String
    '    Dim years As Integer = 0, months As Integer = 0, days As Integer = 0, monthdays As Integer = 0
    '    If toDate = Nothing Then toDate = Date.Now

    '    'Do Until toDate.AddYears(-1) < fromDate
    '    '    years += 1
    '    '    toDate = toDate.AddYears(-1)
    '    'Loop

    '    'Do Until toDate.AddMonths(-1) < fromDate
    '    '    months += 1
    '    '    toDate = toDate.AddMonths(-1)
    '    'Loop

    '    'Do Until toDate.AddDays(-1) < fromDate
    '    '    days += 1
    '    '    toDate = toDate.AddDays(-1)
    '    'Loop

    '    Do Until fromDate.AddYears(1) > toDate
    '        years += 1
    '        fromDate = fromDate.AddYears(1)
    '    Loop

    '    Do Until fromDate.AddMonths(1).AddDays(-1) > toDate
    '        months += 1
    '        fromDate = fromDate.AddMonths(1)
    '    Loop

    '    If months > 0 Then
    '        fromDate = fromDate.AddDays(-1)
    '    End If

    '    monthdays = convertDays(fromDate.Month, toDate.Month, fromDate.Year)

    '    Do Until fromDate.AddDays(1) > toDate
    '        days += 1
    '        fromDate = fromDate.AddDays(1)
    '    Loop

    '    If days >= monthdays Then
    '        months += 1
    '        days = days - monthdays
    '    End If

    '    Return String.Format("{0}, {1}, {2}", years, months, days)
    '    'Return String.Format("{0} Year(s), {1} Month(s), {2} Day(s)", years, months, days)
    'End Function


    Public Function GetDateSpanText(ByVal fromDate As Date, Optional toDate As Date = Nothing) As String
        Dim years As Integer = 0, months As Integer = 0, days As Integer = 0, monthdays As Integer = 0
        If toDate = Nothing Then toDate = Date.Now

        Dim loopDate As Boolean = True
        Dim startDay As Integer = 0
        Dim endDay As Integer = 0
        Dim fixedEndDay As Integer = 0
        Dim lastDayOfNextMonth As New Date
        Dim firstDayOfNextMonth As New Date
        Dim intervalDay As Integer = 0
        Dim startDate As New Date
        Dim counter As Integer = 1


        endDay = fromDate.Day - 1
        startDate = fromDate
        fixedEndDay = endDay

        Do Until loopDate = False

            startDay = fromDate.Day

            firstDayOfNextMonth = New DateTime(startDate.AddMonths(counter).Year, startDate.AddMonths(counter).Month, 1)
            lastDayOfNextMonth = firstDayOfNextMonth.AddMonths(1).AddDays(-1)

            If endDay > lastDayOfNextMonth.Day Then
                fixedEndDay = 1
            Else
                fixedEndDay = endDay
            End If

            intervalDay = getIntervalDay(fromDate.Month, fixedEndDay, startDay, fromDate.Year)

            If fromDate.AddDays(intervalDay) <= toDate Then
                months += 1
                fromDate = fromDate.AddDays(intervalDay).AddDays(1)
                counter += 1
            Else
                loopDate = False
            End If
        Loop

        If months > 0 Then
            fromDate = fromDate.AddDays(-1)
        End If

        intervalDay = convertDays(fromDate.Month, toDate.Month, toDate.Year)
        Do Until fromDate.AddDays(1) > toDate
            days += 1
            fromDate = fromDate.AddDays(1)
        Loop

        If days >= intervalDay Then
            months += 1
            days = days - intervalDay
        End If

        Return String.Format("{0}, {1}, {2}", years, months, days)
        'Return String.Format("{0} Year(s), {1} Month(s), {2} Day(s)", years, months, days)
    End Function

    Private Function getLastDayOfMonth(aDate As Date) As Date
        Return New Date(aDate.Year,
                            aDate.Month,
                            Date.DaysInMonth(aDate.Year, aDate.Month))
    End Function

    Public Function validateDate(ByVal beginDate As DateTime, ByVal endDate As DateTime)
        Dim result As Boolean = True

        If beginDate >= endDate Then
            result = False
        End If

        Return result
    End Function




    Public Function getIntervalDay(ByVal startMonth As Integer, ByVal endDay As Integer,
                                   ByVal startDay As Integer, ByVal year As Integer)
        Dim iDay As Integer = 0

        Select Case startMonth
            Case 1
                If (year Mod 4 = 0) Or (year Mod 100 = 0) Or (year Mod 400 = 0) Then
                    If startDay = 30 And endDay = 1 Then
                        iDay = 31
                    Else
                        iDay = 30
                    End If
                Else
                    If startDay = 31 And endDay = 1 Then
                        iDay = 29
                    Else
                        iDay = 30
                    End If
                End If

            Case 2
                If (year Mod 4 = 0) Or (year Mod 100 = 0) Or (year Mod 400 = 0) Then
                    iDay = 28
                Else
                    iDay = 27
                End If
            Case 3
                If startDay = 1 And endDay = 28 Then
                    iDay = 27
                ElseIf startDay = 2 And endDay = 29 Then
                    iDay = 27
                ElseIf startDay = 2 And endDay = 30 Then
                    iDay = 28
                Else
                    iDay = 30
                End If
            Case 4
                iDay = 29
            Case = 5
                iDay = 30
            Case 6
                iDay = 29
            Case 7
                iDay = 30
            Case 8
                iDay = 30
            Case 9
                iDay = 29
            Case 10
                iDay = 30
            Case 11
                iDay = 29
            Case 12
                iDay = 30
            Case Else
                iDay = 0
        End Select
        Return iDay
    End Function

    Public Function convertDays(ByVal startMonth As Integer, ByVal endMonth As Integer, ByVal year As Integer)
        Dim iDay As Integer = 0

        Select Case startMonth
            Case 1
                iDay = 30
            Case 2
                If (year Mod 4 = 0) Or (year Mod 100 = 0) Or (year Mod 400 = 0) Then
                    iDay = 28
                Else
                    iDay = 27
                End If
            Case 3
                iDay = 30
            Case 4
                iDay = 29
            Case = 5
                iDay = 30
            Case 6
                iDay = 29
            Case 7
                iDay = 30
            Case 8
                iDay = 30
            Case 9
                iDay = 29
            Case 10
                iDay = 30
            Case 11
                iDay = 29
            Case 12
                iDay = 30
            Case Else
                iDay = 0
        End Select
        Return iDay
    End Function


    Public Function getRomanMonth(ByVal month As Integer)
        Dim romanMonth As String = ""

        Select Case month
            Case 1
                romanMonth = "I"
            Case 2
                romanMonth = "II"
            Case 3
                romanMonth = "III"
            Case 4
                romanMonth = "IV"
            Case 5
                romanMonth = "V"
            Case 6
                romanMonth = "VI"
            Case 7
                romanMonth = "VII"
            Case 8
                romanMonth = "VIII"
            Case 9
                romanMonth = "IX"
            Case 10
                romanMonth = "X"
            Case 11
                romanMonth = "XI"
            Case Else
                romanMonth = "XII"

        End Select

        Return romanMonth
    End Function

End Module
