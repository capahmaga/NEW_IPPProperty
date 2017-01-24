
Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration

Public Class clsReservation


    Public Shared Function getDataReservationPartner(ByVal projectID As String, ByVal paramVendor As String) As DataSet
        Dim cmd As New SqlCommand
        Dim ds As New DataSet
        Dim conStr As String = ConfigurationManager.AppSettings("SQLConnecttion") 'connection string ada di app.config <Appsetting>
        Dim connection As New SqlConnection

        Try
            connection.ConnectionString = conStr
            connection.Open()

            cmd.Parameters.Clear()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "select mv.vendorID,mv.vendorName from MS_Vendor mv " +
                            " left join MS_VendorType mvt on mv.vendorType=mvt.vendorTypeID " +
                            " where mv.projectID=@projectID and mvt.vendorTypeName=@paramVendor "
            cmd.Parameters.AddWithValue("@projectID", projectID)
            cmd.Parameters.AddWithValue("@paramVendor", paramVendor)
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

    Public Shared Function getDataReservationByLeaseNo(ByVal projectID As String, ByVal leaseNo As String) As DataSet
        Dim cmd As New SqlCommand
        Dim ds As New DataSet
        Dim conStr As String = ConfigurationManager.AppSettings("SQLConnecttion") 'connection string ada di app.config <Appsetting>
        Dim connection As New SqlConnection

        Try
            connection.ConnectionString = conStr
            connection.Open()

            cmd.Parameters.Clear()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "select * from TR_TenantConfirmation ttc " +
                              " left join MS_unit MU on ttc.unitID=mu.unitID " +
                              " where ttc.isActive=1 And ttc.projectId=@projectID And ttc.leaseNo Like '%" & leaseNo & "%'"
            cmd.Parameters.AddWithValue("@projectID", projectID)
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

    Public Shared Function getDataReservationByTCNo(ByVal projectID As String, ByVal tcNo As String) As DataSet
        Dim cmd As New SqlCommand
        Dim ds As New DataSet
        Dim conStr As String = ConfigurationManager.AppSettings("SQLConnecttion") 'connection string ada di app.config <Appsetting>
        Dim connection As New SqlConnection

        Try
            connection.ConnectionString = conStr
            connection.Open()

            cmd.Parameters.Clear()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "select * from TR_TenantConfirmation ttc " +
                              " left join MS_unit MU on ttc.unitID=mu.unitID " +
                              " where ttc.isActive=1 And ttc.projectId=@projectID And ttc.TCno Like '%" & tcNo & "%'"
            cmd.Parameters.AddWithValue("@projectID", projectID)
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

    Public Shared Function getBindDataReservation(ByVal projectID As String, ByVal leaseNo As String) As DataSet
        Dim cmd As New SqlCommand
        Dim ds As New DataSet
        Dim conStr As String = ConfigurationManager.AppSettings("SQLConnecttion") 'connection string ada di app.config <Appsetting>
        Dim connection As New SqlConnection

        Try
            connection.ConnectionString = conStr
            connection.Open()

            cmd.Parameters.Clear()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "select tcID, proposalNo from MS_Unit
                                where isActive=1 and projectId=@projectID and proposalNo like '%" & leaseNo & "%'"
            cmd.Parameters.AddWithValue("@projectID", projectID)
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

    Public Shared Function getTCNo(ByVal projectID As String, ByVal paramDate As String) As String
        Dim cmd As New SqlCommand
        Dim queryResult As String = ""
        Dim conStr As String = ConfigurationManager.AppSettings("SQLConnecttion") 'connection string ada di app.config <Appsetting>
        Dim connection As New SqlConnection

        Try
            connection.ConnectionString = conStr
            connection.Open()

            cmd.Parameters.Clear()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "select top 1 tcno from TR_TenantConfirmation " +
                            " where LEFT(tcNo,6)=@paramDate and isActive=1 and projectId=@projectID " +
                            " order by tcNo desc"
            cmd.Parameters.AddWithValue("@projectID", projectID)
            cmd.Parameters.AddWithValue("@paramDate", paramDate)
            cmd.Connection = connection

            queryResult = cmd.ExecuteScalar()
            cmd = Nothing
            'close koneksi database
            connection.Close()
        Catch ex As Exception
            MessageBox.Show("Error", ex.Message)
        End Try

        Return queryResult
    End Function


    Public Shared Function insertDataReservation(ByVal projectID As String, ByVal tcNo As String, ByVal tcDate As Date,
                                                ByVal unitNo As String, ByVal bookingType As String, ByVal reservationNo As String,
                                                ByVal leaseNo As String, ByVal isDaily As Boolean, ByVal vendorID As String, ByVal vendorBookNo As String,
                                                ByVal tenantName As String, ByVal companyName As String, ByVal tenantAddress As String,
                                                ByVal tenantPhone As String, ByVal tenantFacsimile As String, ByVal tenantHandphone As String,
                                                ByVal sourceInformation As String, ByVal leaseStatus As String, ByVal beginPeriode As DateTime,
                                                ByVal endPeriode As DateTime, ByVal countMonth As Integer, ByVal countDay As Integer,
                                                ByVal chargedTarget As String, ByVal contactPerson As String,
                                                ByVal cpAddress As String, ByVal cpPhone As String, ByVal cpFacsimile As String,
                                                ByVal cpHandphone As String, ByVal condition As String, ByVal Note As String,
                                                ByVal paxRate As Decimal, ByVal totalPax As Integer, ByVal bestPrice As Decimal,
                                                ByVal tax As Decimal, ByVal total As Decimal, ByVal chargedElectricity As Boolean,
                                                ByVal chargedWater As Boolean, ByVal securityDeposit As Decimal,
                                                ByVal telephoneLine As Integer, ByVal telephoneDeposit As Decimal, ByVal totalDeposit As Decimal,
                                                ByVal heldDeposit As Decimal, ByVal adjustmentDeposit As Decimal, ByVal preparedBy As String,
                                                ByVal acknowledgedBY As String, ByVal isActive As String, ByVal lastUpdated As Date,
                                                 ByVal lastUpdater As String) As String
        Dim cmd As New SqlCommand
        Dim result As String = ""
        Dim sqlQuery As String = ""
        Dim conStr As String = ConfigurationManager.AppSettings("SQLConnecttion") 'connection string ada di app.config <Appsetting>
        Dim connection As New SqlConnection
        Dim transaction As SqlTransaction

        Try
            connection.ConnectionString = conStr
            connection.Open()
            transaction = connection.BeginTransaction("UploadData")

            cmd.Transaction = transaction

            cmd.CommandType = CommandType.Text

            cmd.Parameters.Clear()

            cmd.CommandText = "INSERT INTO [dbo].[TR_TenantConfirmation]
                            ([projectID],[tcNo],[tcDate],[unitID],[bookingType],[reservationNo],[leaseNo],[isDaily],[vendorID],[vendorBookNo],[tenantName]
                            ,[companyName],[tenantAddress],[tenantPhone],[tenantFacsimile],[tenantHandphone],[sourceInformation],[leaseStatus],[beginPeriode]
                            ,[endPeriode],[countMonth],[countDay],[chargedTarget],[contactPerson],[cpAddress],[cpPhone],[cpFacsimile],[cpHandphone], 
                            [condition],[Note],[paxRate],[totalPax],[bestPrice],[tax],[total],[chargedElectricity],[chargedWater],
                            [securityDeposit],[telephoneDeposit],[telephoneLine],[totalDeposit]
                            ,[heldDeposit],[adjustmentDeposit],[preparedBy],[acknowledgedBY],[isActive],[lastUpdated],[lastUpdater])
                        VALUES
                            (@projectID,@tcNo,@tcDate,(select unitID from MS_unit where unitNo=@unitNo),@bookingType,@reservationNo,@leaseNo,@isDaily,@vendorID,@vendorBookNo,@tenantName,
                            @companyName,@tenantAddress,@tenantPhone,@tenantFacsimile,@tenantHandphone,@sourceInformation,@leaseStatus,@beginPeriode,
                            @endPeriode,@countMonth,@countDay,@chargedTarget,@contactPerson,@cpAddress,@cpPhone,@cpFacsimile,@cpHandphone,@condition,@Note,@paxRate,
                            @totalPax,@bestPrice,@tax,@total,@chargedElectricity,@chargedWater,@securityDeposit,@telephoneDeposit,@telephoneLine,@totalDeposit,
                            @heldDeposit,@adjustmentDeposit,@preparedBy,@acknowledgedBY,@isActive,@lastUpdated,@lastUpdater);"

            cmd.Parameters.AddWithValue("@projectID", projectID)
            cmd.Parameters.AddWithValue("@tcNo", tcNo)
            cmd.Parameters.AddWithValue("@tcDate", tcDate)
            cmd.Parameters.AddWithValue("@unitNo", unitNo)
            cmd.Parameters.AddWithValue("@bookingType", bookingType)
            cmd.Parameters.AddWithValue("@reservationNo", reservationNo)
            cmd.Parameters.AddWithValue("@leaseNo", leaseNo)
            cmd.Parameters.AddWithValue("@isDaily", isDaily)
            cmd.Parameters.AddWithValue("@vendorID", vendorID)
            cmd.Parameters.AddWithValue("@vendorBookNo", vendorBookNo)
            cmd.Parameters.AddWithValue("@tenantName", tenantName)
            cmd.Parameters.AddWithValue("@companyName", companyName)
            cmd.Parameters.AddWithValue("@tenantAddress", tenantAddress)
            cmd.Parameters.AddWithValue("@tenantPhone", tenantPhone)
            cmd.Parameters.AddWithValue("@tenantFacsimile", tenantFacsimile)
            cmd.Parameters.AddWithValue("@tenantHandphone", tenantHandphone)
            cmd.Parameters.AddWithValue("@sourceInformation", sourceInformation)
            cmd.Parameters.AddWithValue("@leaseStatus", leaseStatus)
            cmd.Parameters.AddWithValue("@beginPeriode", beginPeriode)
            cmd.Parameters.AddWithValue("@endPeriode", endPeriode)
            cmd.Parameters.AddWithValue("@countMonth", countMonth)
            cmd.Parameters.AddWithValue("@countDay", countDay)
            cmd.Parameters.AddWithValue("@chargedTarget", chargedTarget)
            cmd.Parameters.AddWithValue("@contactPerson", contactPerson)
            cmd.Parameters.AddWithValue("@cpAddress", cpAddress)
            cmd.Parameters.AddWithValue("@cpPhone", cpPhone)
            cmd.Parameters.AddWithValue("@cpFacsimile", cpFacsimile)
            cmd.Parameters.AddWithValue("@cpHandphone", cpHandphone)
            cmd.Parameters.AddWithValue("@condition", condition)
            cmd.Parameters.AddWithValue("@Note", Note)
            cmd.Parameters.AddWithValue("@paxRate", paxRate)
            cmd.Parameters.AddWithValue("@totalPax", totalPax)
            cmd.Parameters.AddWithValue("@bestPrice", bestPrice)
            cmd.Parameters.AddWithValue("@tax", tax)
            cmd.Parameters.AddWithValue("@total", total)
            cmd.Parameters.AddWithValue("@chargedElectricity", chargedElectricity)
            cmd.Parameters.AddWithValue("@chargedWater", chargedWater)
            cmd.Parameters.AddWithValue("@securityDeposit", securityDeposit)
            cmd.Parameters.AddWithValue("@telephoneDeposit", telephoneDeposit)
            cmd.Parameters.AddWithValue("@telephoneLine", telephoneLine)
            cmd.Parameters.AddWithValue("@totalDeposit", totalDeposit)
            cmd.Parameters.AddWithValue("@heldDeposit", heldDeposit)
            cmd.Parameters.AddWithValue("@adjustmentDeposit", adjustmentDeposit)
            cmd.Parameters.AddWithValue("@preparedBy", preparedBy)
            cmd.Parameters.AddWithValue("@acknowledgedBY", acknowledgedBY)
            cmd.Parameters.AddWithValue("@isActive", isActive)
            cmd.Parameters.AddWithValue("@lastUpdated", lastUpdated)
            cmd.Parameters.AddWithValue("@lastUpdater", lastUpdater)

            cmd.Connection = connection
            Try
                result = cmd.ExecuteNonQuery()
            Catch ex As Exception
                result = ex.Message
                transaction.Rollback()
            End Try

            transaction.Commit()
            cmd = Nothing
            connection.Close()
            connection.Dispose()
        Catch ex As Exception
            result = ex.Message
        End Try

        Return result


    End Function


    Public Shared Function updateDataReservation(ByVal projectID As String, ByVal TCID As String, ByVal tcNo As String, ByVal tcDate As Date,
                                                ByVal unitID As String, ByVal bookingType As String, ByVal reservationNo As String,
                                                ByVal leaseNo As String, ByVal isDaily As Boolean, ByVal vendorID As String, ByVal vendorBookNo As String,
                                                ByVal tenantName As String, ByVal companyName As String, ByVal tenantAddress As String,
                                                ByVal tenantPhone As String, ByVal tenantFacsimile As String, ByVal tenantHandphone As String,
                                                ByVal sourceInformation As String, ByVal leaseStatus As String, ByVal beginPeriode As DateTime,
                                                ByVal endPeriode As DateTime, ByVal countMonth As Integer, ByVal countDay As Integer,
                                                ByVal chargedTarget As String, ByVal contactPerson As String,
                                                ByVal cpAddress As String, ByVal cpPhone As String, ByVal cpFacsimile As String,
                                                ByVal cpHandphone As String, ByVal condition As String, ByVal Note As String,
                                                ByVal paxRate As Decimal, ByVal totalPax As Integer, ByVal bestPrice As Decimal,
                                                ByVal tax As Decimal, ByVal total As Decimal, ByVal chargedElectricity As Boolean,
                                                ByVal chargedWater As Boolean, ByVal securityDeposit As Decimal,
                                                ByVal telephoneLine As Integer, ByVal telephoneDeposit As Decimal,
                                                ByVal totalDeposit As Decimal, ByVal heldDeposit As Decimal,
                                                ByVal adjustmentDeposit As Decimal, ByVal preparedBy As String, ByVal acknowledgedBY As String,
                                                ByVal isActive As String, ByVal lastUpdated As Date, ByVal lastUpdater As String) As String

        Dim cmd As New SqlCommand
        Dim result As String = ""
        Dim sqlQuery As String = ""
        Dim conStr As String = ConfigurationManager.AppSettings("SQLConnecttion") 'connection string ada di app.config <Appsetting>
        Dim connection As New SqlConnection
        Dim transaction As SqlTransaction

        Try
            connection.ConnectionString = conStr
            connection.Open()
            transaction = connection.BeginTransaction("UploadData")

            cmd.Transaction = transaction

            cmd.CommandType = CommandType.Text

            cmd.Parameters.Clear()

            cmd.CommandText = "UPDATE [dbo].[TR_TenantConfirmation]
                       SET [projectID] = @projectID,
                            [tcNo] = @tcNo,
                            [tcDate] = @tcDate,
                            [unitID] = @unitID,
                            [bookingType] = @bookingType,
                            [reservationNo] = @reservationNo,
                            [leaseNo] = @leaseNo,
                            [isDaily]=@isDaily,
                            [vendorID] = @vendorID,
                            [vendorBookNo] = @vendorBookNo,
                            [tenantName] = @tenantName,
                            [companyName] = @companyName,
                            [tenantAddress] = @tenantAddress,
                            [tenantPhone] = @tenantPhone,
                            [tenantFacsimile] = @tenantFacsimile,
                            [tenantHandphone] = @tenantHandphone,
                            [sourceInformation] = @sourceInformation,
                            [leaseStatus] = @leaseStatus,
                            [beginPeriode] = @beginPeriode,
                            [endPeriode] = @endPeriode,
                            [countMonth]=@countMonth,
                            [countDay]=@countDay,
                            [chargedTarget] = @chargedTarget,
                            [contactPerson] = @contactPerson,
                            [cpAddress] = @cpAddress,
                            [cpPhone] = @cpPhone,
                            [cpFacsimile] = @cpFacsimile,
                            [cpHandphone] = @cpHandphone,
                            [condition] = @condition,
                            [Note] = @Note,
                            [paxRate] = @paxRate,
                            [totalPax] = @totalPax,
                            [bestPrice] = @bestPrice,
                            [tax] = @tax,
                            [total] = @total,
                            [chargedElectricity] = @chargedElectricity,
                            [chargedWater] = @chargedWater,
                            [securityDeposit] = @securityDeposit,
                            [telephoneDeposit] = @telephoneDeposit,
                            [telephoneLine] = @telephoneLine,
                            [totalDeposit]= @totalDeposit,
                            [heldDeposit] = @heldDeposit,
                            [adjustmentDeposit] = @adjustmentDeposit,
                            [preparedBy] = @preparedBy,
                            [acknowledgedBY] = @acknowledgedBY,
                            [isActive] = @isActive,
                            [lastUpdated] = @lastUpdated,
                            [lastUpdater] = @lastUpdater  
                     WHERE projectID=@projectID and tcId=@tcID ;"

            cmd.Parameters.AddWithValue("@projectID", projectID)
            cmd.Parameters.AddWithValue("@tcID", TCID)
            cmd.Parameters.AddWithValue("@tcNo", tcNo)
            cmd.Parameters.AddWithValue("@tcDate", tcDate)
            cmd.Parameters.AddWithValue("@unitID", unitID)
            cmd.Parameters.AddWithValue("@bookingType", bookingType)
            cmd.Parameters.AddWithValue("@reservationNo", reservationNo)
            cmd.Parameters.AddWithValue("@leaseNo", leaseNo)
            cmd.Parameters.AddWithValue("@isDaily", isDaily)
            cmd.Parameters.AddWithValue("@vendorID", vendorID)
            cmd.Parameters.AddWithValue("@vendorBookNo", vendorBookNo)
            cmd.Parameters.AddWithValue("@tenantName", tenantName)
            cmd.Parameters.AddWithValue("@companyName", companyName)
            cmd.Parameters.AddWithValue("@tenantAddress", tenantAddress)
            cmd.Parameters.AddWithValue("@tenantPhone", tenantPhone)
            cmd.Parameters.AddWithValue("@tenantFacsimile", tenantFacsimile)
            cmd.Parameters.AddWithValue("@tenantHandphone", tenantHandphone)
            cmd.Parameters.AddWithValue("@sourceInformation", sourceInformation)
            cmd.Parameters.AddWithValue("@leaseStatus", leaseStatus)
            cmd.Parameters.AddWithValue("@beginPeriode", beginPeriode)
            cmd.Parameters.AddWithValue("@endPeriode", endPeriode)
            cmd.Parameters.AddWithValue("@countMonth", countMonth)
            cmd.Parameters.AddWithValue("@countDay", countDay)
            cmd.Parameters.AddWithValue("@chargedTarget", chargedTarget)
            cmd.Parameters.AddWithValue("@contactPerson", contactPerson)
            cmd.Parameters.AddWithValue("@cpAddress", cpAddress)
            cmd.Parameters.AddWithValue("@cpPhone", cpPhone)
            cmd.Parameters.AddWithValue("@cpFacsimile", cpFacsimile)
            cmd.Parameters.AddWithValue("@cpHandphone", cpHandphone)
            cmd.Parameters.AddWithValue("@condition", condition)
            cmd.Parameters.AddWithValue("@Note", Note)
            cmd.Parameters.AddWithValue("@paxRate", paxRate)
            cmd.Parameters.AddWithValue("@totalPax", totalPax)
            cmd.Parameters.AddWithValue("@bestPrice", bestPrice)
            cmd.Parameters.AddWithValue("@tax", tax)
            cmd.Parameters.AddWithValue("@total", total)
            cmd.Parameters.AddWithValue("@chargedElectricity", chargedElectricity)
            cmd.Parameters.AddWithValue("@chargedWater", chargedWater)
            cmd.Parameters.AddWithValue("@securityDeposit", securityDeposit)
            cmd.Parameters.AddWithValue("@telephoneDeposit", telephoneDeposit)
            cmd.Parameters.AddWithValue("@telephoneLine", telephoneLine)
            cmd.Parameters.AddWithValue("@totalDeposit", totalDeposit)
            cmd.Parameters.AddWithValue("@heldDeposit", heldDeposit)
            cmd.Parameters.AddWithValue("@adjustmentDeposit", adjustmentDeposit)
            cmd.Parameters.AddWithValue("@preparedBy", preparedBy)
            cmd.Parameters.AddWithValue("@acknowledgedBY", acknowledgedBY)
            cmd.Parameters.AddWithValue("@isActive", isActive)
            cmd.Parameters.AddWithValue("@lastUpdated", lastUpdated)
            cmd.Parameters.AddWithValue("@lastUpdater", lastUpdater)

            cmd.Connection = connection
            Try
                result = cmd.ExecuteNonQuery()
            Catch ex As Exception
                result = ex.Message
                transaction.Rollback()
            End Try

            transaction.Commit()
            cmd = Nothing
            connection.Close()
            connection.Dispose()
        Catch ex As Exception
            result = ex.Message
        End Try

        Return result

    End Function

    Public Shared Function deleteDataReservation(ByVal projectID As String, ByVal tcID As String, ByVal tcDate As Date,
                                                 ByVal unitID As String, ByVal proposalNo As String,
                                                 ByVal tenantName As String, ByVal isActive As String, ByVal lastupdated As DateTime,
                                                 ByVal lastUpdater As String) As String
        Dim cmd As New SqlCommand
        Dim result As String = ""
        Dim sqlQuery As String = ""
        Dim conStr As String = ConfigurationManager.AppSettings("SQLConnecttion") 'connection string ada di app.config <Appsetting>
        Dim connection As New SqlConnection
        Dim transaction As SqlTransaction

        Try
            connection.ConnectionString = conStr
            connection.Open()
            transaction = connection.BeginTransaction("UploadData")

            cmd.Transaction = transaction

            cmd.CommandType = CommandType.Text

            cmd.Parameters.Clear()

            cmd.CommandText = "UPDATE [dbo].[TR_TenantConfirmation]
                       SET [isActive] =@isActive
                          ,[lastUpdated] = @lastUpdated
                          ,[lastUpdater] = @lastUpdater 
                     WHERE projectID=@projectID and tcId=@tcID and tcDate=@tcDate and unitID=@unitId 
                            and proposalNo=@proposalNo and tenantName=@tenantName  ;"

            cmd.Parameters.AddWithValue("@projectID", projectID)
            cmd.Parameters.AddWithValue("@tcID", tcID)
            cmd.Parameters.AddWithValue("@tcDate", tcDate)
            cmd.Parameters.AddWithValue("@unitID", unitID)
            cmd.Parameters.AddWithValue("@proposalNo", proposalNo)
            cmd.Parameters.AddWithValue("@tenantName", tenantName)
            cmd.Parameters.AddWithValue("@isActive", isActive)
            cmd.Parameters.AddWithValue("@lastUpdated", lastupdated)
            cmd.Parameters.AddWithValue("@lastUpdater", lastUpdater)

            cmd.Connection = connection
            Try
                result = cmd.ExecuteNonQuery()
            Catch ex As Exception
                result = ex.Message
                transaction.Rollback()
            End Try

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
