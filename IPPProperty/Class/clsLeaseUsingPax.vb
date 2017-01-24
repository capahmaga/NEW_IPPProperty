Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports System.IO

Public Class clsLeaseUsingPax

    Public Shared Function insertDataLeaseUsingPax(ByVal projectId As String, ByVal leaseID As String,
                                                   ByVal leasetype As String, ByVal leaseNo As String,
                                                   ByVal chairmanName As String, ByVal companyName As String,
                                                   ByVal address As String, ByVal phone As String,
                                                   ByVal handphone As String, ByVal email As String,
                                                   ByVal filename As String, ByVal amount As Decimal,
                                                   ByVal paramSave As Boolean, ByVal isActive As Boolean,
                                                   ByVal lastUpdated As DateTime, ByVal lastUpdater As String)
        Dim result As String = ""

        Dim conStr As String = ConfigurationManager.AppSettings("SQLConnecttion")
        Dim connection As New SqlConnection
        Dim transaction As SqlTransaction
        Dim cmd As New SqlCommand
        'Dim docFileSql As New SqlParameter
        'docFileSql.SqlDbType = SqlDbType.Binary
        ''docFileSql.ParameterName = "docFile"
        'docFileSql.Value = docBytes
        Try
            connection.ConnectionString = conStr
            connection.Open()
            transaction = connection.BeginTransaction("UploadData")

            cmd.Transaction = transaction

            cmd.CommandType = CommandType.Text

            cmd.Parameters.Clear()

            If Not paramSave Then
                cmd.CommandText = "INSERT INTO [dbo].[TR_LeasePaxDoc]([projectID],[leaseType],[leaseNo],[chairmanName], " +
                          "[companyName],[address],[phone],[handphone],[email],[amount],[isActive]," +
                          " [lastUpdated],[lastupdater]) " +
                            " VALUES " +
                            " (@projectID,@leaseType,@leaseNo,@chairmanName,@companyName,@address,@phone,@handphone,@email," +
                            " @amount,@isActive,@lastUpdated,@lastupdater); " +
                            "  SELECT CAST(scope_identity() AS int);"

            Else
                cmd.CommandText = "Update [dbo].[TR_LeasePaxDoc] set [leaseType] = @leaseType, [leaseNo] = @leaseNo, [chairmanName] = @chairmanName, " +
                                " [companyName] = @companyName, [address] = @address,[phone] = @phone, [handphone] = @handphone, " +
                                " [email] = @email, [amount] = @amount,[isActive] = @isActive,[lastUpdated] = @lastUpdated,[lastupdater] = @lastupdater " +
                                " where projectID=@projectID and leaseID=@leaseID "

                cmd.Parameters.AddWithValue("@leaseID", leaseID)
            End If


            cmd.Parameters.AddWithValue("@projectID", projectId)
            cmd.Parameters.AddWithValue("@leaseNo", leaseNo)
            cmd.Parameters.AddWithValue("@leaseType", leasetype)
            cmd.Parameters.AddWithValue("@chairmanName", chairmanName)
            cmd.Parameters.AddWithValue("@companyName", companyName)
            cmd.Parameters.AddWithValue("@address", address)
            cmd.Parameters.AddWithValue("@phone", phone)
            cmd.Parameters.AddWithValue("@handPhone", handphone)
            cmd.Parameters.AddWithValue("@email", email)
            cmd.Parameters.AddWithValue("@amount", amount)
            cmd.Parameters.AddWithValue("@isActive", isActive)
            cmd.Parameters.AddWithValue("@lastUpdated", lastUpdated)
            cmd.Parameters.AddWithValue("@lastUpdater", lastUpdater)



            cmd.Connection = connection
            Try
                result = cmd.ExecuteScalar()
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


    Public Shared Function deleteDataLeaseUsingPax(ByVal projectID As String, ByVal leaseID As String, ByVal leaseNo As String, ByVal isActive As Boolean,
                                                   ByVal lastupdated As DateTime, ByVal lastUpdater As String) As String
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

            sqlQuery = "UPDATE [dbo].[TR_LeasePaxDoc]
                       SET [isActive] =@isActive
                          ,[lastUpdated] = @lastUpdated
                          ,[lastUpdater] = @lastUpdater 
                     WHERE projectID=@projectID and leaseID=@leaseID and leaseNO=@leaseNo;"

            cmd.Parameters.AddWithValue("@projectID", projectID)
            cmd.Parameters.AddWithValue("@leaseID", leaseID)
            cmd.Parameters.AddWithValue("@leaseNO", leaseNo)
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
