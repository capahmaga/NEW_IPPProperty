
Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports System.Data.OleDb

Public Class clsUpload

    Public Shared Function getUploadType(ByVal projectID As String, ByVal uploadParameter As String) As DataSet
        Dim cmd As New SqlCommand
        Dim ds As New DataSet
        Dim conStr As String = ConfigurationManager.AppSettings("SQLConnecttion") 'connection string ada di app.config <Appsetting>
        Dim connection As New SqlConnection

        Try
            connection.ConnectionString = conStr
            connection.Open()

            cmd.Parameters.Clear()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "select uploadID,UploadName from MS_Upload " +
                               " where projectID=@projectID and UploadParameter=@uploadParameter ;"
            cmd.Parameters.AddWithValue("@projectID", projectID)
            cmd.Parameters.AddWithValue("@uploadParameter", uploadParameter)
            cmd.Connection = connection

            Dim sqlDA As New SqlDataAdapter(cmd)
            ' hasil query dimasukan ke dataset dengan nama Data
            sqlDA.Fill(ds, "Data")
            'dispose dataser dan command
            sqlDA = Nothing
            cmd = Nothing
            'close koneksi database
            connection.Close()
        Catch ex As Exception
            MessageBox.Show("Error", ex.Message)
        End Try

        Return ds
    End Function


    Public Shared Function insertDataUploadGuestArrival(ByVal projectId As String, ByVal dtData As DataTable,
                                                 ByVal lastUpdated As DateTime, ByVal lastUpdater As String) As String
        Dim cmd As New SqlCommand
        Dim result As String = ""
        Dim sqlQuery As String = ""
        Dim conStr As String = ConfigurationManager.AppSettings("SQLConnecttion") 'connection string ada di app.config <Appsetting>
        Dim connection As New SqlConnection
        Dim transaction As SqlTransaction
        Dim countData As Integer = 0
        Dim queryResult As New Object

        Try
            connection.ConnectionString = conStr
            connection.Open()
            transaction = connection.BeginTransaction("UploadData")

            cmd.Transaction = transaction


            cmd.CommandType = CommandType.Text

            For i As Integer = 0 To dtData.Rows.Count - 1
                cmd.Parameters.Clear()

                cmd.CommandText = "select count(reservationNo) from [TR_GuestArrival] " +
                                   " where projectID=@projectID and reservationNo=@reservationNo "
                cmd.Parameters.AddWithValue("@projectID", projectId)
                cmd.Parameters.AddWithValue("@reservationNo", dtData.Rows(i).Item(22))
                cmd.Connection = connection

                queryResult = cmd.ExecuteScalar()

                cmd.Parameters.Clear()

                If Val(queryResult.ToString) > 0 Then ' data reservation sudah ada di database, Lakukan Update

                    cmd.CommandText = "UPDATE [dbo].[TR_GuestArrival] SET " +
                    " [unitID] =(select unitID from MS_Unit where unitNo=@unitNo)," +
                    " [personalName] = @personalName,[arrival] = @arrival,[checkINTime] = @checkINTime, " +
                    " [departure] = @departure,[SOB] = @SOB,[longofStay] = @longofStay,[marketing] = @marketing, " +
                    " [nationality] = @nationality,[companyName] = @companyName,[paxGroup] = @paxGroup, " +
                    " [RMST] = @RMST,[payment] = @payment,[remarks] = @remarks,[rateCD] = @rateCD, " +
                    " [amount] = @amount,[isActive] = @isActive,[lastUpdated] = @lastUpdated,[lastUpdater] = @lastUpdater " +
                    " Where projectID=@projectID and reservationNo=@reservationNo ;"

                Else ' data reservation belum ada di database, laukukan Insert
                    cmd.CommandText = "INSERT INTO [dbo].[TR_GuestArrival] " +
                    " ([projectID],[reservationNo],[unitID],[personalName],[arrival]," +
                    " [checkINTime],[departure],[SOB],[longofStay],[marketing],[nationality],[companyName],[paxGroup],[RMST], " +
                    " [payment],[remarks],[rateCD],[amount],[spAttn],[isActive],[lastUpdated],[lastUpdater]) " +
                    " VALUES " +
                    " (@projectID,@reservationNo,(select unitID from MS_Unit where unitNo=@unitNo),@personalName,@arrival," +
                    " @checkINTime,@departure,@SOB, @longofStay, @marketing,@nationality,@companyName,@paxGroup,@RMST, " +
                    " @payment,@remarks,@rateCD,@amount,@spAttn,@isActive,@lastUpdated,@lastUpdater );"

                End If

                cmd.Parameters.AddWithValue("@projectID", projectId)
                cmd.Parameters.AddWithValue("@reservationNo", dtData.Rows(i).Item(22))
                cmd.Parameters.AddWithValue("@unitNo", dtData.Rows(i).Item(23))
                cmd.Parameters.AddWithValue("@personalName", dtData.Rows(i).Item(25))
                cmd.Parameters.AddWithValue("@arrival", dtData.Rows(i).Item(26))
                cmd.Parameters.AddWithValue("@checkINTime", dtData.Rows(i).Item(27))
                cmd.Parameters.AddWithValue("@departure", dtData.Rows(i).Item(28))
                cmd.Parameters.AddWithValue("@SOB", dtData.Rows(i).Item(29))
                cmd.Parameters.AddWithValue("@longofStay", dtData.Rows(i).Item(30))
                cmd.Parameters.AddWithValue("@marketing", dtData.Rows(i).Item(31))
                cmd.Parameters.AddWithValue("@nationality", dtData.Rows(i).Item(32))
                cmd.Parameters.AddWithValue("@companyName", dtData.Rows(i).Item(33))
                cmd.Parameters.AddWithValue("@paxGroup", dtData.Rows(i).Item(34))
                cmd.Parameters.AddWithValue("@RMST", dtData.Rows(i).Item(36))
                cmd.Parameters.AddWithValue("@payment", 0)
                cmd.Parameters.AddWithValue("@remarks", dtData.Rows(i).Item(35))
                cmd.Parameters.AddWithValue("@rateCD", dtData.Rows(i).Item(37))
                cmd.Parameters.AddWithValue("@amount", dtData.Rows(i).Item(38))
                cmd.Parameters.AddWithValue("@spAttn", dtData.Rows(i).Item(38))
                cmd.Parameters.AddWithValue("@isActive", 1)
                cmd.Parameters.AddWithValue("@lastUpdated", lastUpdated)
                cmd.Parameters.AddWithValue("@lastUpdater", lastUpdater)

                cmd.Connection = connection
                Try
                    result = cmd.ExecuteNonQuery()
                Catch ex As Exception
                    result = ex.Message
                    transaction.Rollback()
                End Try
            Next

            transaction.Commit()
            cmd = Nothing
            connection.Close()
            connection.Dispose()
        Catch ex As Exception
            result = ex.Message
        End Try

        Return result

    End Function


    Public Shared Function insertUploadReservation(ByVal projectId As String, ByVal dtData As DataTable,
                                                 ByVal lastUpdated As DateTime, ByVal lastUpdater As String) As String
        Dim cmd As New SqlCommand
        Dim result As String = ""
        Dim sqlQuery As String = ""
        Dim conStr As String = ConfigurationManager.AppSettings("SQLConnecttion") 'connection string ada di app.config <Appsetting>
        Dim connection As New SqlConnection
        Dim transaction As SqlTransaction
        Dim countData As Integer = 0
        Dim queryResult As New Object

        Try
            connection.ConnectionString = conStr
            connection.Open()
            transaction = connection.BeginTransaction("UploadData")

            cmd.Transaction = transaction


            cmd.CommandType = CommandType.Text

            For i As Integer = 0 To dtData.Rows.Count - 1
                cmd.Parameters.Clear()

                cmd.CommandText = "select count(bookNo) from [TR_OnlineBooking] " +
                                   " where projectID=@projectID and bookNo=@bookNo "
                cmd.Parameters.AddWithValue("@projectID", projectId)
                cmd.Parameters.AddWithValue("@bookNo", dtData.Rows(i).Item(0))
                cmd.Connection = connection

                queryResult = cmd.ExecuteScalar()

                cmd.Parameters.Clear()

                If Val(queryResult.ToString) > 0 Then ' data reservation sudah ada di database, Lakukan Update

                    cmd.CommandType = "UPDATE [dbo].[TR_OnlineBooking] SET " +
                    " [projectID] = @projectID,[bookNo] = @bookNo,[reservationBy] = @reservationBy, " +
                    "[occupiedBy] = @occupiedBy,[checkIN] = @checkIN,[checkOut] = @checkOut,[roomNight] = @roomNight, " +
                    "[commision] = @commision,[result] = @result,[beforeAmount] = @beforeAmount,[finalAmount] = @finalAmount, " +
                    "[isActive] = @isActive,[lastUpdated] = @lastUpdated,[lastUpdater] = @lastUpdater " +
                    " Where projectID=@projectID and bookNo=@bookNo ;"

                Else ' data reservation belum ada di database, laukukan Insert
                    cmd.CommandType = "INSERT INTO [dbo].[TR_OnlineBooking] " +
                    "([projectID],[bookNo],[reservationBy],[occupiedBy],[checkIN],[checkOut],[roomNight], " +
                    " [commision],[result],[beforeAmount],[finalAmount],[isActive],[lastUpdated],[lastUpdater]) " +
                    "VALUES " +
                    " (@projectID,@bookNo,@reservationBy,@occupiedBy,@checkIN,@checkOut,@roomNight, " +
                    "@commision,@result,@beforeAmount,@finalAmount,@isActive,@lastUpdated,@lastUpdater);"
                End If

                cmd.Parameters.AddWithValue("@projectID", projectId)
                cmd.Parameters.AddWithValue("@bookNo", dtData.Rows(i).Item(0))
                cmd.Parameters.AddWithValue("@reservationBy", dtData.Rows(i).Item(1))
                cmd.Parameters.AddWithValue("@occupiedBy", dtData.Rows(i).Item(2))
                cmd.Parameters.AddWithValue("@checkIN", dtData.Rows(i).Item(3))
                cmd.Parameters.AddWithValue("@checkOut", dtData.Rows(i).Item(4))
                cmd.Parameters.AddWithValue("@roomNight", dtData.Rows(i).Item(5))
                cmd.Parameters.AddWithValue("@commision", dtData.Rows(i).Item(6))
                cmd.Parameters.AddWithValue("@result", dtData.Rows(i).Item(7))
                cmd.Parameters.AddWithValue("@beforeAmount", dtData.Rows(i).Item(8))
                cmd.Parameters.AddWithValue("@finalAmount", dtData.Rows(i).Item(9))
                cmd.Parameters.AddWithValue("@isActive", 1)
                cmd.Parameters.AddWithValue("@lastUpdated", lastUpdated)
                cmd.Parameters.AddWithValue("@lastUpdater", lastUpdater)

                cmd.Connection = connection
                Try
                    result = cmd.ExecuteNonQuery()
                Catch ex As Exception
                    result = ex.Message
                    transaction.Rollback()
                End Try
            Next

            transaction.Commit()
            cmd = Nothing
            connection.Close()
            connection.Dispose()
        Catch ex As Exception
            result = ex.Message
        End Try

        Return result

    End Function


    Public Shared Function insertUploadBilling(ByVal projectId As String, ByVal dtData As DataTable,
                                                 ByVal lastUpdated As DateTime, ByVal lastUpdater As String) As String
        Dim cmd As New SqlCommand
        Dim result As String = ""
        Dim sqlQuery As String = ""
        Dim conStr As String = ConfigurationManager.AppSettings("SQLConnecttion") 'connection string ada di app.config <Appsetting>
        Dim connection As New SqlConnection
        Dim transaction As SqlTransaction
        Dim countData As Integer = 0
        Dim queryResult As New Object

        Try
            connection.ConnectionString = conStr
            connection.Open()
            transaction = connection.BeginTransaction("UploadData")

            cmd.Transaction = transaction


            cmd.CommandType = CommandType.Text

            For i As Integer = 0 To dtData.Rows.Count - 1
                cmd.Parameters.Clear()

                cmd.CommandText = "select count(billingCode) from [TR_OnlineBooking] " +
                                   " where projectID=@projectID and beginPeriode=@beginPeriode and endPeriode=@endPeriode and " +
                                   " unitID=(select unitID from MS_unit where unitNo=@unitNo)"
                cmd.Parameters.AddWithValue("@projectID", projectId)
                cmd.Parameters.AddWithValue("@beginPeriode", dtData.Rows(i).Item(10))
                cmd.Parameters.AddWithValue("@endPeriode", dtData.Rows(i).Item(11))
                cmd.Parameters.AddWithValue("@unitNo", dtData.Rows(i).Item(2))
                cmd.Connection = connection

                queryResult = cmd.ExecuteScalar()

                cmd.Parameters.Clear()

                If Val(queryResult.ToString) > 0 Then ' data reservation sudah ada di database, Lakukan Update

                    cmd.CommandType = "UPDATE [dbo].[TR_Billing] SET " +
                    " [projectID] = @projectID,[billingCode] = @billingCode, " +
                    " [unitID] = (Select UnitID from MS_Unit where unitNo=@unitNo),[billingType] = @billingType, " +
                    " [rateID] = @rateID,[beginMeter] = @beginMeter,[endMeter] = @endMeter,[consumtion] = @consumtion, " +
                    " [bestprice] = @bestprice,[vat] = @vat,[beginPeriode] = @beginPeriode,[endPeriode] = @endPeriode, " +
                    " [remarks] = @remarks,[isActive] = @isActive,[lastUpdated] = @lastUpdated,[lastupdater] = @lastupdater " +
                    " Where projectID=@projectID and beginPeriode=@beginPeriode and endPeriode=@endPeriode and " +
                    " unitID=(select unitID from MS_unit where unitNo=@unitNo)"

                Else ' data reservation belum ada di database, laukukan Insert
                    cmd.CommandType = "INSERT INTO [dbo].[TR_Billing] " +
                    "([projectID],[billingCode],[unitID],[billingType], " +
                    " [rateID],[beginMeter],[endMeter],[consumtion],[bestprice],[vat],[beginPeriode], " +
                    " [endPeriode],[remarks],[isActive],[lastUpdated],[lastupdater]) " +
                    "VALUES " +
                    " (@projectID,@billingCode,(select unitID from MS_Unit where unitNO=@unitNO),@billingType, " +
                    " @rateID,@beginMeter,@endMeter,@consumtion,@bestprice,@vat,@beginPeriode, " +
                    " @endPeriode,@remarks,@isActive,@lastUpdated,@lastupdater);"
                End If

                cmd.Parameters.AddWithValue("@projectID", projectId)
                cmd.Parameters.AddWithValue("@billingCode", dtData.Rows(i).Item(1))
                cmd.Parameters.AddWithValue("@unitNO", dtData.Rows(i).Item(2))
                cmd.Parameters.AddWithValue("@billingType", dtData.Rows(i).Item(3))
                cmd.Parameters.AddWithValue("@rateID", dtData.Rows(i).Item(4))
                cmd.Parameters.AddWithValue("@beginMeter", dtData.Rows(i).Item(5))
                cmd.Parameters.AddWithValue("@endMeter", dtData.Rows(i).Item(6))
                cmd.Parameters.AddWithValue("@consumtion", dtData.Rows(i).Item(7))
                cmd.Parameters.AddWithValue("@bestprice", dtData.Rows(i).Item(8))
                cmd.Parameters.AddWithValue("@vat", dtData.Rows(i).Item(9))
                cmd.Parameters.AddWithValue("@beginPeriode", dtData.Rows(i).Item(10))
                cmd.Parameters.AddWithValue("@endPeriode", dtData.Rows(i).Item(11))
                cmd.Parameters.AddWithValue("@remarks", dtData.Rows(i).Item(12))
                cmd.Parameters.AddWithValue("@isActive", 1)
                cmd.Parameters.AddWithValue("@lastUpdated", lastUpdated)
                cmd.Parameters.AddWithValue("@lastUpdater", lastUpdater)

                cmd.Connection = connection
                Try
                    result = cmd.ExecuteNonQuery()
                Catch ex As Exception
                    result = ex.Message
                    transaction.Rollback()
                End Try
            Next

            transaction.Commit()
            cmd = Nothing
            connection.Close()
            connection.Dispose()
        Catch ex As Exception
            result = ex.Message
        End Try

        Return result

    End Function




End Class
