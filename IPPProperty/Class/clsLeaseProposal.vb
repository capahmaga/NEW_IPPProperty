
Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration

Public Class clsLeaseProposal


    Public Shared Function insertLeaseProposal(ByVal projectID As String, ByVal leaseNo As String, ByVal personalName As String, ByVal isPrivate As Boolean,
                                               ByVal companyName As String, ByVal address As String, ByVal phone As String, ByVal facsimile As String,
                                               ByVal email As String, ByVal occupiedBy As String, ByVal leaseType As String,
                                               ByVal unitID As String, ByVal isUpgrade As Boolean, ByVal conditionType As String,
                                               ByVal condition As String, ByVal commencementDate As Date, ByVal expiredDate As Date, ByVal printedDate As Date,
                                               ByVal countMonth As Integer, ByVal countDay As Integer, ByVal paymentTerm As String,
                                               ByVal paymentType As String, ByVal publishRentalBase As Decimal, ByVal rentalBaseMonth As Decimal,
                                               ByVal rentalBaseDay As Decimal, ByVal VAT As Decimal, ByVal totalAmountRental As Decimal,
                                               ByVal isGuaranteeLetter As Boolean, ByVal securityDeposit As Decimal, ByVal basicPhoneDeposit As Decimal,
                                               ByVal linePhone As Integer, ByVal totalPhoneDeposit As Decimal, ByVal totalAmountDeposit As Decimal,
                                               ByVal heldDeposit As Decimal, ByVal totalAdjustment As Decimal,
                                               ByVal basicAddBreakfast As Decimal, ByVal totalPax As Integer, ByVal totalAmountBreakfast As Decimal,
                                               ByVal basicAddLaundry As Decimal, ByVal totalPacket As Integer, ByVal totalAmountAddLaundry As Decimal,
                                               ByVal grandTotalAmount As Decimal, ByVal quotedValidDate As Date, ByVal preparedBy As String,
                                               ByVal isUseSalesSignature As Boolean, ByVal acknowledgedBy As String, ByVal isUseParentSignature As Boolean,
                                               ByVal isActive As Boolean, ByVal lastUpdated As Date, ByVal lastUpdater As String)

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

            cmd.CommandText = "INSERT INTO [dbo].[TR_LeaseAgreement]([projectID],[leaseNo],[personalName],[isPrivate],[companyName],[address]," +
                " [phone],[facsimile],[email],[occupiedBy],[leaseType], [unitID],[isUpgrade],[conditionType],[condition], " +
                " [commencementDate],[expiredDate],[printedDate],[countMonth],[countDay],[paymentTerm]," +
                " [paymentType],[publishRentalBase],[rentalBaseMonth],[rentalBaseDay],[VAT],[totalAmountRental],[isGuaranteeLetter],[securityDeposit]," +
                " [basicPhoneDeposit],[linePhone],[totalPhoneDeposit],[totalAmountDeposit],[heldDeposit],[totalAdjustment], " +
                " [basicAddBreakfast],[totalPax],[totalAmountBreakfast],[basicAddLaundry],[totalPacket],[totalAmountAddLaundry], " +
                " [grandTotalAmount],[quotedValidDate],[preparedBy],[isUseSalesSignature]," +
                " [acknowledgedBy],[isUseParentSignature],[isActive],[lastUpdated],[lastUpdater]) " +
                " VALUES " +
                " (@projectID,@leaseNo,@personalName,@isPrivate,@companyName,@address, " +
                " @phone,@facsimile,@email,@occupiedBy,@leaseType,@unitID,@isUpgrade,@conditionType,@condition," +
                " @commencementDate,@expiredDate,@printedDate,@countMonth,@countDay,@paymentTerm, " +
                " @paymentType,@publishRentalBase,@rentalBaseMonth,@rentalBaseDay,@VAT, @totalAmountRental,@isGuaranteeLetter,@securityDeposit, " +
                " @basicPhoneDeposit,@linePhone,@totalPhoneDeposit,@totalAmountDeposit, @heldDeposit,@totalAdjustment, " +
                " @basicAddBreakfast, @totalPax,@totalAmountBreakfast,@basicAddLaundry,@totalPacket,@totalAmountAddLaundry, " +
                " @grandTotalAmount,@quotedValidDate,@preparedBy,@isUseSalesSignature, " +
                " @acknowledgedBy,@isUseParentSignature,@isActive,@lastUpdated,@lastUpdater); "

            cmd.Parameters.AddWithValue("@projectID", projectID)
            cmd.Parameters.AddWithValue("@leaseNo", leaseNo)
            cmd.Parameters.AddWithValue("@personalName", personalName)
            cmd.Parameters.AddWithValue("@isPrivate", isPrivate)
            cmd.Parameters.AddWithValue("@companyName", companyName)
            cmd.Parameters.AddWithValue("@address", address)
            cmd.Parameters.AddWithValue("@phone", phone)
            cmd.Parameters.AddWithValue("@facsimile", facsimile)
            cmd.Parameters.AddWithValue("@email", email)
            cmd.Parameters.AddWithValue("@occupiedBy", occupiedBy)
            cmd.Parameters.AddWithValue("@leaseType", leaseType)
            cmd.Parameters.AddWithValue("@unitID", unitID)
            cmd.Parameters.AddWithValue("@isUpgrade", isUpgrade)
            cmd.Parameters.AddWithValue("@conditionType", conditionType)
            cmd.Parameters.AddWithValue("@condition", condition)
            cmd.Parameters.AddWithValue("@commencementDate", commencementDate)
            cmd.Parameters.AddWithValue("@expiredDate", expiredDate)
            cmd.Parameters.AddWithValue("@printedDate", printedDate)
            cmd.Parameters.AddWithValue("@countMonth", countMonth)
            cmd.Parameters.AddWithValue("@countDay", countDay)
            cmd.Parameters.AddWithValue("@paymentTerm", paymentTerm)
            cmd.Parameters.AddWithValue("@paymentType", paymentType)
            cmd.Parameters.AddWithValue("@publishRentalBase", publishRentalBase)
            cmd.Parameters.AddWithValue("@rentalBaseMonth", rentalBaseMonth)
            cmd.Parameters.AddWithValue("@rentalBaseDay", rentalBaseDay)
            cmd.Parameters.AddWithValue("@VAT", VAT)
            cmd.Parameters.AddWithValue("@totalAmountRental", totalAmountRental)
            cmd.Parameters.AddWithValue("@isGuaranteeLetter", isGuaranteeLetter)
            cmd.Parameters.AddWithValue("@securityDeposit", securityDeposit)
            cmd.Parameters.AddWithValue("@basicPhoneDeposit", basicPhoneDeposit)
            cmd.Parameters.AddWithValue("@linePhone", linePhone)
            cmd.Parameters.AddWithValue("@totalPhoneDeposit", totalPhoneDeposit)
            cmd.Parameters.AddWithValue("@totalAmountDeposit", totalAmountDeposit)
            cmd.Parameters.AddWithValue("@heldDeposit", heldDeposit)
            cmd.Parameters.AddWithValue("@totalAdjustment", totalAdjustment)
            cmd.Parameters.AddWithValue("@basicAddBreakfast", basicAddBreakfast)
            cmd.Parameters.AddWithValue("@totalPax", totalPax)
            cmd.Parameters.AddWithValue("@totalAmountBreakfast", totalAmountBreakfast)
            cmd.Parameters.AddWithValue("@basicAddLaundry", basicAddLaundry)
            cmd.Parameters.AddWithValue("@totalPacket", totalPacket)
            cmd.Parameters.AddWithValue("@totalAmountAddLaundry", totalAmountAddLaundry)
            cmd.Parameters.AddWithValue("@grandTotalAmount", grandTotalAmount)
            cmd.Parameters.AddWithValue("@quotedValidDate", quotedValidDate)
            cmd.Parameters.AddWithValue("@preparedBy", preparedBy)
            cmd.Parameters.AddWithValue("@isUseSalesSignature", isUseSalesSignature)
            cmd.Parameters.AddWithValue("@acknowledgedBy", acknowledgedBy)
            cmd.Parameters.AddWithValue("@isUseParentSignature", isUseParentSignature)
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


    Public Shared Function updateLeaseProposal(ByVal projectID As String,
                                                ByVal leaseID As String,
                                                ByVal leaseNo As String,
                                                ByVal personalName As String,
                                                ByVal isPrivate As Boolean,
                                                ByVal companyName As String,
                                                ByVal address As String,
                                               ByVal phone As String,
                                               ByVal facsimile As String,
                                               ByVal email As String,
                                                ByVal occupiedBy As String,
                                                ByVal leaseType As String,
                                                ByVal unitID As String,
                                                ByVal isUpgrade As Boolean,
                                                ByVal conditionType As String,
                                                ByVal condition As String,
                                                ByVal commencementDate As Date,
                                                ByVal expiredDate As Date,
                                                ByVal printedDate As Date,
                                                ByVal countMonth As Integer,
                                                ByVal countDay As Integer,
                                                ByVal paymentTerm As String,
                                                ByVal paymentType As String,
                                                ByVal publishRentalBase As Decimal,
                                                ByVal rentalBaseMonth As Decimal,
                                                ByVal rentalBaseDay As Decimal,
                                                ByVal VAT As Decimal,
                                                ByVal totalAmountRental As Decimal,
                                                ByVal isGuaranteeLetter As Boolean,
                                                ByVal securityDeposit As Decimal,
                                                ByVal basicPhoneDeposit As Decimal,
                                                ByVal linePhone As Integer,
                                                ByVal totalPhoneDeposit As Decimal,
                                                ByVal totalAmountDeposit As Decimal,
                                                ByVal heldDeposit As Decimal,
                                                ByVal totalAdjustment As Decimal,
                                                ByVal basicAddBreakfast As Decimal,
                                                ByVal totalPax As Integer,
                                                ByVal totalAmountBreakfast As Decimal,
                                                ByVal basicAddLaundry As Decimal,
                                                ByVal totalPacket As Integer,
                                                ByVal totalAmountAddLaundry As Decimal,
                                                ByVal grandTotalAmount As Decimal,
                                                ByVal quotedValidDate As Date,
                                                ByVal preparedBy As String,
                                                ByVal isUseSalesSignature As Boolean,
                                                ByVal acknowledgedBy As String,
                                                ByVal isUseParentSignature As Boolean,
                                                ByVal isActive As Boolean,
                                                ByVal lastUpdated As Date,
                                                ByVal lastUpdater As String) _
                                                As String
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

            cmd.CommandText = "UPDATE [dbo].[TR_LeaseAgreement]
                           SET [projectID] = @projectID,
                                [leaseNo] = @leaseNo,
                                [personalName] = @personalName,
                                [isPrivate] = @isPrivate,
                                [companyName] = @companyName,
                                [address] = @address,
                                [phone]=@phone,
                                [facsimile]=@facsimile,
                                [email]=@email,
                                [occupiedBy] = @occupiedBy,
                                [leaseType] = @leaseType,
                                [unitID] = @unitID,
                                [isUpgrade] = @isUpgrade,
                                [conditionType]=@conditionType,
                                [condition] = @condition,
                                [commencementDate] = @commencementDate,
                                [expiredDate] = @expiredDate,
                                [printedDate]=@printedDate,
                                [countMonth] = @countMonth,
                                [countDay] = @countDay,
                                [paymentTerm] = @paymentTerm,
                                [paymentType] = @paymentType,
                                [publishRentalBase] = @publishRentalBase,
                                [rentalBaseMonth] = @rentalBaseMonth,
                                [rentalBaseDay] = @rentalBaseDay,
                                [VAT] = @VAT,
                                [totalAmountRental] = @totalAmountRental,
                                [isGuaranteeLetter] = @isGuaranteeLetter,
                                [securityDeposit] = @securityDeposit,
                                [basicPhoneDeposit] = @basicPhoneDeposit,
                                [linePhone] = @linePhone,
                                [totalPhoneDeposit] = @totalPhoneDeposit,
                                [totalAmountDeposit] = @totalAmountDeposit,
                                [heldDeposit]=@heldDeposit,
                                [totalAdjustment]=@totalAdjustment,
                                [basicAddBreakfast] = @basicAddBreakfast,
                                [totalPax] = @totalPax,
                                [totalAmountBreakfast] = @totalAmountBreakfast,
                                [basicAddLaundry] = @basicAddLaundry,
                                [totalPacket] = @totalPacket,
                                [totalAmountAddLaundry] = @totalAmountAddLaundry,
                                [grandTotalAmount] = @grandTotalAmount,
                                [quotedValidDate] = @quotedValidDate,
                                [preparedBy] = @preparedBy,
                                [isUseSalesSignature] = @isUseSalesSignature,
                                [acknowledgedBy] = @acknowledgedBy,
                                [isUseParentSignature] = @isUseParentSignature,
                                [isActive] = @isActive,
                                [lastUpdated] = @lastUpdated,
                                [lastUpdater] = @lastUpdater
                     WHERE projectID=@projectID and leaseID=@leaseID ;"

            cmd.Parameters.AddWithValue("@projectID", projectID)
            cmd.Parameters.AddWithValue("@leaseID", leaseID)
            cmd.Parameters.AddWithValue("@leaseNo", leaseNo)
            cmd.Parameters.AddWithValue("@personalName", personalName)
            cmd.Parameters.AddWithValue("@isPrivate", isPrivate)
            cmd.Parameters.AddWithValue("@companyName", companyName)
            cmd.Parameters.AddWithValue("@address", address)
            cmd.Parameters.AddWithValue("@phone", phone)
            cmd.Parameters.AddWithValue("@facsimile", facsimile)
            cmd.Parameters.AddWithValue("@email", email)
            cmd.Parameters.AddWithValue("@occupiedBy", occupiedBy)
            cmd.Parameters.AddWithValue("@leaseType", leaseType)
            cmd.Parameters.AddWithValue("@unitID", unitID)
            cmd.Parameters.AddWithValue("@isUpgrade", isUpgrade)
            cmd.Parameters.AddWithValue("@conditionType", conditionType)
            cmd.Parameters.AddWithValue("@condition", condition)
            cmd.Parameters.AddWithValue("@commencementDate", commencementDate)
            cmd.Parameters.AddWithValue("@expiredDate", expiredDate)
            cmd.Parameters.AddWithValue("@printedDate", printedDate)
            cmd.Parameters.AddWithValue("@countMonth", countMonth)
            cmd.Parameters.AddWithValue("@countDay", countDay)
            cmd.Parameters.AddWithValue("@paymentTerm", paymentTerm)
            cmd.Parameters.AddWithValue("@paymentType", paymentType)
            cmd.Parameters.AddWithValue("@publishRentalBase", publishRentalBase)
            cmd.Parameters.AddWithValue("@rentalBaseMonth", rentalBaseMonth)
            cmd.Parameters.AddWithValue("@rentalBaseDay", rentalBaseDay)
            cmd.Parameters.AddWithValue("@VAT", VAT)
            cmd.Parameters.AddWithValue("@totalAmountRental", totalAmountRental)
            cmd.Parameters.AddWithValue("@isGuaranteeLetter", isGuaranteeLetter)
            cmd.Parameters.AddWithValue("@securityDeposit", securityDeposit)
            cmd.Parameters.AddWithValue("@basicPhoneDeposit", basicPhoneDeposit)
            cmd.Parameters.AddWithValue("@linePhone", linePhone)
            cmd.Parameters.AddWithValue("@totalPhoneDeposit", totalPhoneDeposit)
            cmd.Parameters.AddWithValue("@totalAmountDeposit", totalAmountDeposit)
            cmd.Parameters.AddWithValue("@heldDeposit", heldDeposit)
            cmd.Parameters.AddWithValue("@totalAdjustment", totalAdjustment)
            cmd.Parameters.AddWithValue("@basicAddBreakfast", basicAddBreakfast)
            cmd.Parameters.AddWithValue("@totalPax", totalPax)
            cmd.Parameters.AddWithValue("@totalAmountBreakfast", totalAmountBreakfast)
            cmd.Parameters.AddWithValue("@basicAddLaundry", basicAddLaundry)
            cmd.Parameters.AddWithValue("@totalPacket", totalPacket)
            cmd.Parameters.AddWithValue("@totalAmountAddLaundry", totalAmountAddLaundry)
            cmd.Parameters.AddWithValue("@grandTotalAmount", grandTotalAmount)
            cmd.Parameters.AddWithValue("@quotedValidDate", quotedValidDate)
            cmd.Parameters.AddWithValue("@preparedBy", preparedBy)
            cmd.Parameters.AddWithValue("@isUseSalesSignature", isUseSalesSignature)
            cmd.Parameters.AddWithValue("@acknowledgedBy", acknowledgedBy)
            cmd.Parameters.AddWithValue("@isUseParentSignature", isUseParentSignature)
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

    Public Shared Function deleteLeaseProposal(ByVal projectID As String, ByVal leaseID As String, ByVal leaseNo As String,
                                               ByVal isActive As String, ByVal lastupdated As DateTime,
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
                     WHERE projectID=@projectID and leaseID=@leaseID and leaseNo=@leaseNo  ;"

            cmd.Parameters.AddWithValue("@projectID", projectID)
            cmd.Parameters.AddWithValue("@leaseID", leaseID)
            cmd.Parameters.AddWithValue("@leaseNo", leaseNo)
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


    Public Shared Function getDataLeaseAgreement(ByVal projectID As String, ByVal leaseId As String, ByVal leaseNo As String) As DataSet

        Dim cmd As New SqlCommand
        Dim ds As New DataSet
        Dim conStr As String = ConfigurationManager.AppSettings("SQLConnecttion") 'connection string ada di app.config <Appsetting>
        Dim connection As New SqlConnection

        Try
            connection.ConnectionString = conStr
            connection.Open()

            cmd.Parameters.Clear()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "select * from TR_LeaseAgreement tla " +
                                " Left join MS_Unit  mu on tla.unitID=mu.unitID " +
                                " left join MS_UnitType mt on mu.unitTypeID=mt.unitTypeID " +
                                " left join MS_Sales ms on tla.preparedBy=ms.salesID " +
                                " where tla.projectID=@projectID and leaseID=@leaseId and leaseNo=@leaseNo and tla.isActive=1 "
            cmd.Parameters.AddWithValue("@projectID", projectID)
            cmd.Parameters.AddWithValue("@leaseId", leaseId)
            cmd.Parameters.AddWithValue("@leaseNo", leaseNo)
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



    Public Shared Function getDataLeaseAgreementDoc(ByVal projectID As String, ByVal leaseNo As String) As DataSet

        Dim cmd As New SqlCommand
        Dim ds As New DataSet
        Dim conStr As String = ConfigurationManager.AppSettings("SQLConnecttion") 'connection string ada di app.config <Appsetting>
        Dim connection As New SqlConnection

        Try
            connection.ConnectionString = conStr
            connection.Open()

            cmd.Parameters.Clear()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "select  tla.*,mu.*,mt.*,ms.signature as salesSign,ms.salesName as salesPreparedBy,ms.jobTitle as preparedTitle,msa.* from TR_LeaseAgreement tla " +
                                " Left join MS_Unit  mu on tla.unitID=mu.unitID " +
                                " left join MS_UnitType mt on mu.unitTypeID=mt.unitTypeID " +
                                " left join MS_Sales ms on tla.preparedBy=ms.salesID " +
                                " left join MS_Sales msa on tla.acknowledgedBy=msa.salesID " +
                                " where tla.projectID=@projectID and leaseNo=@leaseNo "
            cmd.Parameters.AddWithValue("@projectID", projectID)
            cmd.Parameters.AddWithValue("@leaseNo", leaseNo)
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

    Public Shared Function getDataLeaseAgreementPax(ByVal projectID As String, ByVal leaseId As String) As DataSet

        Dim cmd As New SqlCommand
        Dim ds As New DataSet
        Dim conStr As String = ConfigurationManager.AppSettings("SQLConnecttion") 'connection string ada di app.config <Appsetting>
        Dim connection As New SqlConnection

        Try
            connection.ConnectionString = conStr
            connection.Open()

            cmd.Parameters.Clear()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "select * from TR_LeasePaxDoc  " +
                                " where projectID=@projectID and leaseID=@leaseId "
            cmd.Parameters.AddWithValue("@projectID", projectID)
            cmd.Parameters.AddWithValue("@leaseId", leaseId)
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



End Class
