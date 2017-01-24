Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration

Public Class clsPersonal

    Public Shared Function getPersonalByID(ByVal projectID As String, ByVal personallID As String) As DataSet

        Dim cmd As New SqlCommand
        Dim ds As New DataSet
        Dim conStr As String = ConfigurationManager.AppSettings("SQLConnecttion") 'connection string ada di app.config <Appsetting>
        Dim connection As New SqlConnection

        Try
            connection.ConnectionString = conStr
            connection.Open()

            cmd.Parameters.Clear()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "select mp.ProjectID,mpj.projectName,mp.personalID,mp.personalName,mp.personalCode,
                                mp.personalTypeID,mp.NPWP,mpi.institutionID,mpi.IDNO,mpc.personalName as CompanyName,
                                mpi.birthDate,mpi.birthPlace,mpi.gender,mms.MaritalStatusID, mms.maritalStatusName,
                                mbt.bloodTypeID,mbt.bloodTypeName,mr.religionID,mr.religionName,mo.occupationID,
                                mo.occupationName,mc.citizenID,mc.citizenName,
                                mp.isActive,mp.lastUpdated,mp.lastUpdater from MS_Personal mp
                                left join MS_Project mpj on mp.projectID=mpj.projectID
                                left join MS_PersonalIdentity mpi on mp.personalID=mpi.identityID
                                left join MS_Personal mpc on mpi.institutionID=mpc.personalID
                                left join ms_maritalStatus mms on mpi.maritalStatusID=mms.maritalStatusID
                                left join MS_BloodType mbt on mpi.bloodTypeID=mbt.bloodTypeID
                                left join MS_Religion mr on mpi.religionID=mr.religionID
                                left join MS_Occupation mo on mpi.occupationID=mo.occupationID
                                left join MS_Citizen mc on mpi.citizenID=mc.citizenID  
                               where mp.isActive=1 and mp.projectID=@projectID and mp.personalID=@personalID"
            cmd.Parameters.AddWithValue("@projectID", projectID)
            cmd.Parameters.AddWithValue("@personalID", personallID)
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


    Public Shared Function getInstitutionByID(ByVal projectID As String, ByVal personallID As String) As DataSet

        Dim cmd As New SqlCommand
        Dim ds As New DataSet
        Dim conStr As String = ConfigurationManager.AppSettings("SQLConnecttion") 'connection string ada di app.config <Appsetting>
        Dim connection As New SqlConnection

        Try
            connection.ConnectionString = conStr
            connection.Open()

            cmd.Parameters.Clear()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "select mp.ProjectID,mpj.projectName,mp.personalID,mp.personalCode,mp.personalName,mp.personalTypeID,
                                mp.NPWP,mpi.institutionID,mpi.branchName,mpi.contactPersonID,
                                mpc.personalName as ContactPerson,mpi.country,mc.citizenName as countryName,
                                mpi.establishmentDate,mpi.establishmentPlace,mpi.SPPKP,mpi.SKDP,mpi.SIUP,
                                mpi.SKKemenhumkam,mp.isActive,mp.lastUpdated,mp.lastUpdater from MS_Personal mp
                                left join MS_Project mpj on mp.projectID=mpj.projectID
                                left join MS_PersonalInstitution mpi on mp.personalID=mpi.institutionID
                                left join MS_Personal mpc on mpi.contactPersonID=mpc.personalID
                                left join MS_Citizen mc on mpi.country=mc.citizenID    
                               where mp.isActive=1 and mp.projectID=@projectID and mp.personalID=@personalID"
            cmd.Parameters.AddWithValue("@projectID", projectID)
            cmd.Parameters.AddWithValue("@personalID", personallID)
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


    Public Shared Function getAddressByPersonalID(ByVal projectID As String, ByVal personallID As String) As DataSet

        Dim cmd As New SqlCommand
        Dim ds As New DataSet
        Dim conStr As String = ConfigurationManager.AppSettings("SQLConnecttion") 'connection string ada di app.config <Appsetting>
        Dim connection As New SqlConnection

        Try
            connection.ConnectionString = conStr
            connection.Open()

            cmd.Parameters.Clear()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "select * from MS_Address ms
                                left join MS_AddressType mat on ms.projectID=mat.projectID and ms.addressTypeID=mat.addressTypeID
                               where ms.isActive=1 and ms.projectID=@projectID and ms.personalID=@personalID"
            cmd.Parameters.AddWithValue("@projectID", projectID)
            cmd.Parameters.AddWithValue("@personalID", personallID)
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

    Public Shared Function getPhoneByPersonalID(ByVal projectID As String, ByVal personallID As String) As DataSet

        Dim cmd As New SqlCommand
        Dim ds As New DataSet
        Dim conStr As String = ConfigurationManager.AppSettings("SQLConnecttion") 'connection string ada di app.config <Appsetting>
        Dim connection As New SqlConnection

        Try
            connection.ConnectionString = conStr
            connection.Open()

            cmd.Parameters.Clear()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "select * from MS_Phone mp
                                left join MS_PhoneType mpt on mp.projectID=mpt.projectID and mp.phoneTypeID=mpt.phoneTypeID
                               where mp.isActive=1 and mp.projectID=@projectID and mp.personalID=@personalID"
            cmd.Parameters.AddWithValue("@projectID", projectID)
            cmd.Parameters.AddWithValue("@personalID", personallID)
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

    Public Shared Function getEmailByPersonalID(ByVal projectID As String, ByVal personallID As String) As DataSet

        Dim cmd As New SqlCommand
        Dim ds As New DataSet
        Dim conStr As String = ConfigurationManager.AppSettings("SQLConnecttion") 'connection string ada di app.config <Appsetting>
        Dim connection As New SqlConnection

        Try
            connection.ConnectionString = conStr
            connection.Open()

            cmd.Parameters.Clear()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "select * from MS_Email me
                                left join MS_EmailType met on me.projectID=met.projectID and me.emailTypeID=met.emailTypeID
                               where me.isActive=1 and me.projectID=@projectID and me.personalID=@personalID"
            cmd.Parameters.AddWithValue("@projectID", projectID)
            cmd.Parameters.AddWithValue("@personalID", personallID)
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

    Public Shared Function getBankAccountByPersonalID(ByVal projectID As String, ByVal personallID As String) As DataSet

        Dim cmd As New SqlCommand
        Dim ds As New DataSet
        Dim conStr As String = ConfigurationManager.AppSettings("SQLConnecttion") 'connection string ada di app.config <Appsetting>
        Dim connection As New SqlConnection

        Try
            connection.ConnectionString = conStr
            connection.Open()

            cmd.Parameters.Clear()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "select * from MS_BankAccount mba 
                                left join MS_Bank mb on mba.bankID=mb.bankID
                               where mba.isActive=1 and mb.projectID=@projectID and mba.personalID=@personalID"
            cmd.Parameters.AddWithValue("@projectID", projectID)
            cmd.Parameters.AddWithValue("@personalID", personallID)
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


    Public Shared Function getDocumentByPersonalID(ByVal projectID As String, ByVal personallID As String) As DataSet

        Dim cmd As New SqlCommand
        Dim ds As New DataSet
        Dim conStr As String = ConfigurationManager.AppSettings("SQLConnecttion") 'connection string ada di app.config <Appsetting>
        Dim connection As New SqlConnection

        Try
            connection.ConnectionString = conStr
            connection.Open()

            cmd.Parameters.Clear()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "select * from MS_Document md
                                left join MS_DocumentType mdt on md.projectID=mdt.projectID and md.documentTypeID=mdt.documentTypeID
                               where md.isActive=1 and md.projectID=@projectID and md.documentKey=@personalID"
            cmd.Parameters.AddWithValue("@projectID", projectID)
            cmd.Parameters.AddWithValue("@personalID", personallID)
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


    Public Shared Function getMaritalStatusByProjectID(ByVal projectID As String) As DataSet

        Dim cmd As New SqlCommand
        Dim ds As New DataSet
        Dim conStr As String = ConfigurationManager.AppSettings("SQLConnecttion") 'connection string ada di app.config <Appsetting>
        Dim connection As New SqlConnection

        Try
            connection.ConnectionString = conStr
            connection.Open()

            cmd.Parameters.Clear()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "select * from MS_MaritalStatus
                               where isActive=1 and projectID=@projectID "
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

    Public Shared Function getPhoneByProjectID(ByVal projectID As String) As DataSet

        Dim cmd As New SqlCommand
        Dim ds As New DataSet
        Dim conStr As String = ConfigurationManager.AppSettings("SQLConnecttion") 'connection string ada di app.config <Appsetting>
        Dim connection As New SqlConnection

        Try
            connection.ConnectionString = conStr
            connection.Open()

            cmd.Parameters.Clear()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "select * from ms_phone 
                               where isActive=1 and projectID=@projectID "
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

    Public Shared Function getEmailByProjectID(ByVal projectID As String) As DataSet

        Dim cmd As New SqlCommand
        Dim ds As New DataSet
        Dim conStr As String = ConfigurationManager.AppSettings("SQLConnecttion") 'connection string ada di app.config <Appsetting>
        Dim connection As New SqlConnection

        Try
            connection.ConnectionString = conStr
            connection.Open()

            cmd.Parameters.Clear()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "select * from MS_Email  
                               where isActive=1 and projectID=@projectID "
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

    Public Shared Function getBankAccountByProjectID(ByVal projectID As String) As DataSet

        Dim cmd As New SqlCommand
        Dim ds As New DataSet
        Dim conStr As String = ConfigurationManager.AppSettings("SQLConnecttion") 'connection string ada di app.config <Appsetting>
        Dim connection As New SqlConnection

        Try
            connection.ConnectionString = conStr
            connection.Open()

            cmd.Parameters.Clear()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "select * from MS_BankAccount   
                               where isActive=1 and projectID=@projectID "
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


    Public Shared Function getDocumentByProjectID(ByVal projectID As String) As DataSet

        Dim cmd As New SqlCommand
        Dim ds As New DataSet
        Dim conStr As String = ConfigurationManager.AppSettings("SQLConnecttion") 'connection string ada di app.config <Appsetting>
        Dim connection As New SqlConnection

        Try
            connection.ConnectionString = conStr
            connection.Open()

            cmd.Parameters.Clear()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "select * from MS_Document   
                               where isActive=1 and projectID=@projectID "
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


    Public Shared Function insertDataIdentity(ByVal projectID As String, ByVal personalTypeID As String, ByVal personalCode As String,
                                ByVal personalName As String, ByVal IDNO As String, ByVal NPWP As String, ByVal personalStatusID As String,
                                ByVal institutionID As String, ByVal gender As String, ByVal birthDate As Date,
                                ByVal birthPlace As String, ByVal maritalStatusID As String, ByVal bloodTypeID As String,
                                ByVal religionID As String, ByVal occupationID As String, ByVal citizenID As String,
                                ByVal remarks As String, ByVal dtAddress As DataTable, ByVal dtPhone As DataTable,
                                ByVal dtEmail As DataTable, ByVal dtBankAccount As DataTable, ByVal dtDocument As DataTable,
                                ByVal isActive As Integer, ByVal lastUpdated As DateTime, ByVal lastUpdater As String) As String
        Dim cmd As New SqlCommand
        Dim result As String = ""
        Dim sqlQuery As String = ""
        Dim conStr As String = ConfigurationManager.AppSettings("SQLConnecttion") 'connection string ada di app.config <Appsetting>
        Dim connection As New SqlConnection
        Dim transaction As SqlTransaction
        Dim personalID As String = ""

        Try
            connection.ConnectionString = conStr
            connection.Open()
            transaction = connection.BeginTransaction("InputPersonal")

            cmd.Transaction = transaction
            cmd.Parameters.Clear()
            cmd.CommandType = CommandType.Text

            ''===== Insert data into MS_Personal =======''

            cmd.CommandText = "INSERT INTO [dbo].[MS_Personal]
                          ([projectID],[personalCode],[personalName],[personalTypeID],[NPWP],[remarks],
                          [isActive],[lastUpdated],[lastUpdater]) 
                        VALUES 
                          (@projectID,@personalCode,@personalName,@personalTypeID,@NPWP,@remarks,
                           @isActive,@lastUpdated,@lastUpdater); " _
                & " SELECT CAST(scope_identity() AS int);"


            cmd.Parameters.AddWithValue("@projectID", projectID)
            cmd.Parameters.AddWithValue("@personalCode", personalCode)
            cmd.Parameters.AddWithValue("@personalName", personalName)
            cmd.Parameters.AddWithValue("@personalTypeID", personalTypeID)
            cmd.Parameters.AddWithValue("@NPWP", NPWP)
            cmd.Parameters.AddWithValue("@remarks", remarks)
            cmd.Parameters.AddWithValue("@isActive", isActive)
            cmd.Parameters.AddWithValue("@lastUpdated", lastUpdated)
            cmd.Parameters.AddWithValue("@lastUpdater", lastUpdater)

            cmd.Connection = connection
            Try
                personalID = cmd.ExecuteScalar()
            Catch ex As Exception
                result = ex.Message
                transaction.Rollback()
            End Try


            ''====== Insert data into MS_PersonalIdentity =====''

            cmd.Parameters.Clear()

            cmd.CommandText = "INSERT INTO [dbo].[MS_PersonalIdentity]
                        ([identityID],[institutionID],[personalStatusID],[IDNO][gender],[birthDate],[birthPlace],
                         [maritalStatusID],[bloodTypeID],[religionID],[occupationID],[citizenID],[isActive],
                         [lastUpdated],[lastUpdates])     
                        VALUES 
                          (@identityID,@institutionID,@personalStatusID,@IDNO,@gender,@birthDate,@birthPlace,
                            @maritalStatusID,@bloodTypeID,@religionID,@occupationID,@citizenID,@isActive,
                            @lastUpdated,@lastUpdates);"

            cmd.Parameters.AddWithValue("@identityID", personalID)
            cmd.Parameters.AddWithValue("@institutionID", institutionID)
            cmd.Parameters.AddWithValue("@personalStatusID", personalStatusID)
            cmd.Parameters.AddWithValue("@IDNO", IDNO)
            cmd.Parameters.AddWithValue("@gender", gender)
            cmd.Parameters.AddWithValue("@birthDate", birthDate)
            cmd.Parameters.AddWithValue("@birthPlace", birthPlace)
            cmd.Parameters.AddWithValue("@maritalStatusID", maritalStatusID)
            cmd.Parameters.AddWithValue("@bloodTypeID", bloodTypeID)
            cmd.Parameters.AddWithValue("@religionID", religionID)
            cmd.Parameters.AddWithValue("@occupationID", occupationID)
            cmd.Parameters.AddWithValue("@citizenID", citizenID)
            cmd.Parameters.AddWithValue("@isActive", isActive)
            cmd.Parameters.AddWithValue("@lastUpdated", lastUpdated)
            cmd.Parameters.AddWithValue("@lastUpdater", lastUpdater)


            cmd.Connection = connection
            Try
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                result = ex.Message
                transaction.Rollback()
            End Try

            ''=========== Insert data Address ===========''
            If dtAddress.Rows.Count > 0 And dtAddress IsNot Nothing Then

                For i As Integer = 0 To dtAddress.Rows.Count - 1
                    cmd.Parameters.Clear()
                    cmd.CommandText = "INSERT INTO [dbo].[MS_Address]
                            ([projectID],[addressTypeID],[personalID],[addressName],[city],[province],[ZIPCode],
                            [isActive],[lastUpdated],[lastUpdater])     
                            VALUES 
                          (@projectID,@addressTypeID,@personalID,@addressName,@city,
                            @province,@ZIPCode,@isActive,@lastUpdated,@lastUpdater);"

                    cmd.Parameters.AddWithValue("@projectID", dtAddress.Rows(i).Item("projectID"))
                    cmd.Parameters.AddWithValue("@addressTypeID", dtAddress.Rows(i).Item("addressTypeID"))
                    cmd.Parameters.AddWithValue("@personalID", personalID)
                    cmd.Parameters.AddWithValue("@addressName", dtAddress.Rows(i).Item("addressName"))
                    cmd.Parameters.AddWithValue("@city", dtAddress.Rows(i).Item("city"))
                    cmd.Parameters.AddWithValue("@province", dtAddress.Rows(i).Item("province"))
                    cmd.Parameters.AddWithValue("@ZIPCode", dtAddress.Rows(i).Item("ZIPCode"))
                    cmd.Parameters.AddWithValue("@isActive", isActive)
                    cmd.Parameters.AddWithValue("@lastUpdated", lastUpdated)
                    cmd.Parameters.AddWithValue("@lastUpdater", lastUpdater)

                    cmd.Connection = connection
                    Try
                        cmd.ExecuteNonQuery()
                    Catch ex As Exception
                        result = ex.Message
                        transaction.Rollback()
                    End Try
                Next
            End If


            ''=========== Insert data Phone ===========''
            If dtPhone.Rows.Count > 0 And dtPhone IsNot Nothing Then
                For i As Integer = 0 To dtPhone.Rows.Count - 1
                    cmd.Parameters.Clear()
                    cmd.CommandText = "INSERT INTO [dbo].[MS_Phone]
                                    ([projectID],[personalID],[phoneTypeID],[phoneCode],[phoneNumber],
                                    [remarks],[isActive],[lastUpdated],[lastUpdater])
                                         VALUES
                                   (@projectID,@personalID,@phoneTypeID,@phoneCode,@phoneNumber,
                                    @remarks,@isActive,@lastUpdated,@lastUpdater);"

                    cmd.Parameters.AddWithValue("@projectID", dtPhone.Rows(i).Item("projectID"))
                    cmd.Parameters.AddWithValue("@phoneTypeID", dtPhone.Rows(i).Item("phoneTypeID"))
                    cmd.Parameters.AddWithValue("@personalID", personalID)
                    cmd.Parameters.AddWithValue("@phoneCode", dtPhone.Rows(i).Item("phoneCode"))
                    cmd.Parameters.AddWithValue("@phoneNumber", dtPhone.Rows(i).Item("phoneNumber"))
                    cmd.Parameters.AddWithValue("@remarks", dtPhone.Rows(i).Item("remarks"))
                    cmd.Parameters.AddWithValue("@isActive", isActive)
                    cmd.Parameters.AddWithValue("@lastUpdated", lastUpdated)
                    cmd.Parameters.AddWithValue("@lastUpdater", lastUpdater)

                    cmd.Connection = connection
                    Try
                        cmd.ExecuteNonQuery()
                    Catch ex As Exception
                        result = ex.Message
                        transaction.Rollback()
                    End Try
                Next
            End If


            ''=========== Insert data Email ===========''
            If dtEmail.Rows.Count > 0 And dtEmail IsNot Nothing Then
                For i As Integer = 0 To dtEmail.Rows.Count - 1
                    cmd.Parameters.Clear()
                    cmd.CommandText = "INSERT INTO [dbo].[MS_Email]
                                    ([projectID],[personalID],[emailTypeID],[emailCode],[emailName],
                                    [remarks],[isActive],[lastUpdated],[lastUpdater])
                                         VALUES
                                   (@projectID,@personalID,@emailTypeID,@emailCode,@emailName,@remarks,
                                    @isActive,@lastUpdated,@lastUpdater);"

                    cmd.Parameters.AddWithValue("@projectID", dtEmail.Rows(i).Item("projectID"))
                    cmd.Parameters.AddWithValue("@emailTypeID", dtEmail.Rows(i).Item("emailTypeID"))
                    cmd.Parameters.AddWithValue("@personalID", personalID)
                    cmd.Parameters.AddWithValue("@emailCode", dtEmail.Rows(i).Item("emailCode"))
                    cmd.Parameters.AddWithValue("@emailName", dtEmail.Rows(i).Item("emailName"))
                    cmd.Parameters.AddWithValue("@remarks", dtEmail.Rows(i).Item("remarks"))
                    cmd.Parameters.AddWithValue("@isActive", isActive)
                    cmd.Parameters.AddWithValue("@lastUpdated", lastUpdated)
                    cmd.Parameters.AddWithValue("@lastUpdater", lastUpdater)

                    cmd.Connection = connection
                    Try
                        cmd.ExecuteNonQuery()
                    Catch ex As Exception
                        result = ex.Message
                        transaction.Rollback()
                    End Try
                Next
            End If


            ''=========== Insert data Bank Account ===========''
            If dtBankAccount.Rows.Count > 0 And dtBankAccount IsNot Nothing Then
                For i As Integer = 0 To dtBankAccount.Rows.Count - 1
                    cmd.Parameters.Clear()
                    cmd.CommandText = "INSERT INTO [dbo].[MS_BankAccount]
                                    ([projectID],[bankID],[bankAccountCode],[personalID],[accountNo],[accountTypeID],
                                    [currencyID],[branchName],[remarks],[isActive],[lastUpdated],[lastUpdater])
                                         VALUES
                                   (@projectID,@bankID,@bankAccountCode,@personalID,@accountNo,@accountTypeID,
                                    @currencyID,@branchName,@remarks,@isActive,@lastUpdated,@lastUpdater);"

                    cmd.Parameters.AddWithValue("@projectID", dtBankAccount.Rows(i).Item("projectID"))
                    cmd.Parameters.AddWithValue("@bankID", dtBankAccount.Rows(i).Item("bankID"))
                    cmd.Parameters.AddWithValue("@personalID", personalID)
                    cmd.Parameters.AddWithValue("@bankAccountCode", dtBankAccount.Rows(i).Item("bankAccountCode"))
                    cmd.Parameters.AddWithValue("@accountNo", dtBankAccount.Rows(i).Item("accountNo"))
                    cmd.Parameters.AddWithValue("@accountTypeID", dtBankAccount.Rows(i).Item("accountTypeID"))
                    cmd.Parameters.AddWithValue("@currencyID", dtBankAccount.Rows(i).Item("currencyID"))
                    cmd.Parameters.AddWithValue("@branchName", dtBankAccount.Rows(i).Item("branchName"))
                    cmd.Parameters.AddWithValue("@remarks", dtBankAccount.Rows(i).Item("remarks"))
                    cmd.Parameters.AddWithValue("@isActive", isActive)
                    cmd.Parameters.AddWithValue("@lastUpdated", lastUpdated)
                    cmd.Parameters.AddWithValue("@lastUpdater", lastUpdater)

                    cmd.Connection = connection
                    Try
                        cmd.ExecuteNonQuery()
                    Catch ex As Exception
                        result = ex.Message
                        transaction.Rollback()
                    End Try
                Next
            End If


            ''=========== Insert data Document ===========''
            If dtDocument.Rows.Count > 0 And dtDocument IsNot Nothing Then
                For i As Integer = 0 To dtDocument.Rows.Count - 1
                    cmd.Parameters.Clear()
                    cmd.CommandText = "INSERT INTO [dbo].[MS_Document]
                                    ([projectID][documentKey],[documentTypeID],[documentName],[documentFile],
                                    [remarks],[isActive],[lastupdated],[lastUpdater])
                                         VALUES
                                  (@projectID@documentKey,@documentTypeID,@documentName,@documentFile,
                                    @remarks,@isActive,@lastupdated,@lastUpdater) ;"

                    cmd.Parameters.AddWithValue("@projectID", dtBankAccount.Rows(i).Item("projectID"))
                    cmd.Parameters.AddWithValue("@documentKey", personalID)
                    cmd.Parameters.AddWithValue("@documentTypeID", dtBankAccount.Rows(i).Item("documentTypeID"))
                    cmd.Parameters.AddWithValue("@documentName", dtBankAccount.Rows(i).Item("documentName"))
                    cmd.Parameters.AddWithValue("@documentFile", dtBankAccount.Rows(i).Item("documentFile"))
                    cmd.Parameters.AddWithValue("@remarks", dtBankAccount.Rows(i).Item("remarks"))
                    cmd.Parameters.AddWithValue("@isActive", isActive)
                    cmd.Parameters.AddWithValue("@lastUpdated", lastUpdated)
                    cmd.Parameters.AddWithValue("@lastUpdater", lastUpdater)

                    cmd.Connection = connection
                    Try
                        cmd.ExecuteNonQuery()
                    Catch ex As Exception
                        result = ex.Message
                        transaction.Rollback()
                    End Try
                Next
            End If




            cmd = Nothing
            connection.Close()
            connection.Dispose()
        Catch ex As Exception
            result = ex.Message
        End Try

        Return result

    End Function


    Public Shared Function updateDataIdentity(ByVal projectID As String, ByVal personalTypeID As String, ByVal personalCode As String,
                               ByVal personalName As String, ByVal IDNO As String, ByVal NPWP As String, ByVal personalStatusID As String,
                               ByVal institutionID As String, ByVal gender As String, ByVal birthDate As Date,
                               ByVal birthPlace As String, ByVal maritalStatusID As String, ByVal bloodTypeID As String,
                               ByVal religionID As String, ByVal occupationID As String, ByVal citizenID As String,
                               ByVal remarks As String, ByVal dtAddress As DataTable, ByVal dtPhone As DataTable,
                               ByVal dtEmail As DataTable, ByVal dtBankAccount As DataTable, ByVal dtDocument As DataTable,
                               ByVal isActive As Integer, ByVal lastUpdated As DateTime, ByVal lastUpdater As String) As String
        Dim cmd As New SqlCommand
        Dim result As String = ""
        Dim sqlQuery As String = ""
        Dim conStr As String = ConfigurationManager.AppSettings("SQLConnecttion") 'connection string ada di app.config <Appsetting>
        Dim connection As New SqlConnection
        Dim transaction As SqlTransaction
        Dim personalID As String = ""

        Try
            connection.ConnectionString = conStr
            connection.Open()
            transaction = connection.BeginTransaction("InputPersonal")

            cmd.Transaction = transaction
            cmd.Parameters.Clear()
            cmd.CommandType = CommandType.Text

            ''===== Update data into MS_Personal =======''

            cmd.CommandText = "UPDATE [dbo].[MS_Personal]
                           SET [projectID] = @projectID, 
                              ,[personalCode] = @personalCode,
                              ,[personalName] = @personalName,
                              ,[personalTypeID] = @personalTypeID,
                              ,[NPWP] = @NPWP,
                              ,[remarks] = @remarks,
                              ,[isActive] = @isActive,
                              ,[lastUpdated] = @lastUpdated,
                              ,[lastUpdater] = @lastUpdater 
                         WHERE projectID=@projectID and personalID=@personalID ;"

            cmd.Parameters.AddWithValue("@projectID", projectID)
            cmd.Parameters.AddWithValue("@personalCode", personalCode)
            cmd.Parameters.AddWithValue("@personalName", personalName)
            cmd.Parameters.AddWithValue("@personalTypeID", personalTypeID)
            cmd.Parameters.AddWithValue("@NPWP", NPWP)
            cmd.Parameters.AddWithValue("@remarks", remarks)
            cmd.Parameters.AddWithValue("@isActive", isActive)
            cmd.Parameters.AddWithValue("@lastUpdated", lastUpdated)
            cmd.Parameters.AddWithValue("@lastUpdater", lastUpdater)

            cmd.Connection = connection
            Try
                personalID = cmd.ExecuteNonQuery()
            Catch ex As Exception
                result = ex.Message
                transaction.Rollback()
            End Try


            ''====== Update data into MS_PersonalIdentity =====''

            cmd.Parameters.Clear()

            cmd.CommandText = "UPDATE [dbo].[MS_PersonalIdentity]
                               SET [identityID] = @identityID,
                                  ,[institutionID] = @institutionID,
                                  ,[personalStatusID] = @personalStatusID,
                                  ,[IDNO] = @IDNO,
                                  ,[gender] = @gender,
                                  ,[birthDate] = @birthDate,
                                  ,[birthPlace] = @birthPlace,
                                  ,[maritalStatusID] = @maritalStatusID,
                                  ,[bloodTypeID] = @bloodTypeID,
                                  ,[religionID] = @religionID,
                                  ,[occupationID] = @occupationID,
                                  ,[citizenID] = @citizenID,
                                  ,[isActive] = @isActive,
                                  ,[lastUpdated] = @lastUpdated,
                                  ,[lastUpdates] = @lastUpdates 
                             WHERE  projectID=@projectId and identityID=@personalID;"

            cmd.Parameters.AddWithValue("@identityID", personalID)
            cmd.Parameters.AddWithValue("@institutionID", institutionID)
            cmd.Parameters.AddWithValue("@personalStatusID", personalStatusID)
            cmd.Parameters.AddWithValue("@IDNO", IDNO)
            cmd.Parameters.AddWithValue("@gender", gender)
            cmd.Parameters.AddWithValue("@birthDate", birthDate)
            cmd.Parameters.AddWithValue("@birthPlace", birthPlace)
            cmd.Parameters.AddWithValue("@maritalStatusID", maritalStatusID)
            cmd.Parameters.AddWithValue("@bloodTypeID", bloodTypeID)
            cmd.Parameters.AddWithValue("@religionID", religionID)
            cmd.Parameters.AddWithValue("@occupationID", occupationID)
            cmd.Parameters.AddWithValue("@citizenID", citizenID)
            cmd.Parameters.AddWithValue("@isActive", isActive)
            cmd.Parameters.AddWithValue("@lastUpdated", lastUpdated)
            cmd.Parameters.AddWithValue("@lastUpdater", lastUpdater)


            cmd.Connection = connection
            Try
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                result = ex.Message
                transaction.Rollback()
            End Try

            ''=========== Update data Address ===========''

            For i As Integer = 0 To dtAddress.Rows.Count - 1
                cmd.Parameters.Clear()
                cmd.CommandText = "INSERT INTO [dbo].[MS_Address]
                            ([projectID],[addressTypeID],[personalID],[addressName],[city],[province],[ZIPCode],
                            [isActive],[lastUpdated],[lastUpdater])     
                            VALUES 
                          (@projectID,@addressTypeID,@personalID,@addressName,@city,
                            @province,@ZIPCode,@isActive,@lastUpdated,@lastUpdater);"

                cmd.Parameters.AddWithValue("@projectID", dtAddress.Rows(i).Item("projectID"))
                cmd.Parameters.AddWithValue("@addressTypeID", dtAddress.Rows(i).Item("addressTypeID"))
                cmd.Parameters.AddWithValue("@personalID", personalID)
                cmd.Parameters.AddWithValue("@addressName", dtAddress.Rows(i).Item("addressName"))
                cmd.Parameters.AddWithValue("@city", dtAddress.Rows(i).Item("city"))
                cmd.Parameters.AddWithValue("@province", dtAddress.Rows(i).Item("province"))
                cmd.Parameters.AddWithValue("@ZIPCode", dtAddress.Rows(i).Item("ZIPCode"))
                cmd.Parameters.AddWithValue("@isActive", isActive)
                cmd.Parameters.AddWithValue("@lastUpdated", lastUpdated)
                cmd.Parameters.AddWithValue("@lastUpdater", lastUpdater)

                cmd.Connection = connection
                Try
                    cmd.ExecuteNonQuery()
                Catch ex As Exception
                    result = ex.Message
                    transaction.Rollback()
                End Try
            Next

            ''=========== Insert data Phone ===========''

            For i As Integer = 0 To dtPhone.Rows.Count - 1
                cmd.Parameters.Clear()
                cmd.CommandText = "INSERT INTO [dbo].[MS_Phone]
                                    ([projectID],[personalID],[phoneTypeID],[phoneCode],[phoneNumber],
                                    [remarks],[isActive],[lastUpdated],[lastUpdater])
                                         VALUES
                                   (@projectID,@personalID,@phoneTypeID,@phoneCode,@phoneNumber,
                                    @remarks,@isActive,@lastUpdated,@lastUpdater);"

                cmd.Parameters.AddWithValue("@projectID", dtPhone.Rows(i).Item("projectID"))
                cmd.Parameters.AddWithValue("@phoneTypeID", dtPhone.Rows(i).Item("phoneTypeID"))
                cmd.Parameters.AddWithValue("@personalID", personalID)
                cmd.Parameters.AddWithValue("@phoneCode", dtPhone.Rows(i).Item("phoneCode"))
                cmd.Parameters.AddWithValue("@phoneNumber", dtPhone.Rows(i).Item("phoneNumber"))
                cmd.Parameters.AddWithValue("@remarks", dtPhone.Rows(i).Item("remarks"))
                cmd.Parameters.AddWithValue("@isActive", isActive)
                cmd.Parameters.AddWithValue("@lastUpdated", lastUpdated)
                cmd.Parameters.AddWithValue("@lastUpdater", lastUpdater)

                cmd.Connection = connection
                Try
                    cmd.ExecuteNonQuery()
                Catch ex As Exception
                    result = ex.Message
                    transaction.Rollback()
                End Try
            Next

            ''=========== Insert data Email ===========''

            For i As Integer = 0 To dtEmail.Rows.Count - 1
                cmd.Parameters.Clear()
                cmd.CommandText = "INSERT INTO [dbo].[MS_Email]
                                    ([projectID],[personalID],[emailTypeID],[emailCode],[emailName],
                                    [remarks],[isActive],[lastUpdated],[lastUpdater])
                                         VALUES
                                   (@projectID,@personalID,@emailTypeID,@emailCode,@emailName,@remarks,
                                    @isActive,@lastUpdated,@lastUpdater);"

                cmd.Parameters.AddWithValue("@projectID", dtEmail.Rows(i).Item("projectID"))
                cmd.Parameters.AddWithValue("@emailTypeID", dtEmail.Rows(i).Item("emailTypeID"))
                cmd.Parameters.AddWithValue("@personalID", personalID)
                cmd.Parameters.AddWithValue("@emailCode", dtEmail.Rows(i).Item("emailCode"))
                cmd.Parameters.AddWithValue("@emailName", dtEmail.Rows(i).Item("emailName"))
                cmd.Parameters.AddWithValue("@remarks", dtEmail.Rows(i).Item("remarks"))
                cmd.Parameters.AddWithValue("@isActive", isActive)
                cmd.Parameters.AddWithValue("@lastUpdated", lastUpdated)
                cmd.Parameters.AddWithValue("@lastUpdater", lastUpdater)

                cmd.Connection = connection
                Try
                    cmd.ExecuteNonQuery()
                Catch ex As Exception
                    result = ex.Message
                    transaction.Rollback()
                End Try
            Next


            ''=========== Insert data Bank Account ===========''

            For i As Integer = 0 To dtBankAccount.Rows.Count - 1
                cmd.Parameters.Clear()
                cmd.CommandText = "INSERT INTO [dbo].[MS_BankAccount]
                                    ([projectID],[bankID],[bankAccountCode],[personalID],[accountNo],[accountTypeID],
                                    [currencyID],[branchName],[remarks],[isActive],[lastUpdated],[lastUpdater])
                                         VALUES
                                   (@projectID,@bankID,@bankAccountCode,@personalID,@accountNo,@accountTypeID,
                                    @currencyID,@branchName,@remarks,@isActive,@lastUpdated,@lastUpdater);"

                cmd.Parameters.AddWithValue("@projectID", dtBankAccount.Rows(i).Item("projectID"))
                cmd.Parameters.AddWithValue("@bankID", dtBankAccount.Rows(i).Item("bankID"))
                cmd.Parameters.AddWithValue("@personalID", personalID)
                cmd.Parameters.AddWithValue("@bankAccountCode", dtBankAccount.Rows(i).Item("bankAccountCode"))
                cmd.Parameters.AddWithValue("@accountNo", dtBankAccount.Rows(i).Item("accountNo"))
                cmd.Parameters.AddWithValue("@accountTypeID", dtBankAccount.Rows(i).Item("accountTypeID"))
                cmd.Parameters.AddWithValue("@currencyID", dtBankAccount.Rows(i).Item("currencyID"))
                cmd.Parameters.AddWithValue("@branchName", dtBankAccount.Rows(i).Item("branchName"))
                cmd.Parameters.AddWithValue("@remarks", dtBankAccount.Rows(i).Item("remarks"))
                cmd.Parameters.AddWithValue("@isActive", isActive)
                cmd.Parameters.AddWithValue("@lastUpdated", lastUpdated)
                cmd.Parameters.AddWithValue("@lastUpdater", lastUpdater)

                cmd.Connection = connection
                Try
                    cmd.ExecuteNonQuery()
                Catch ex As Exception
                    result = ex.Message
                    transaction.Rollback()
                End Try
            Next


            ''=========== Insert data Document ===========''

            For i As Integer = 0 To dtDocument.Rows.Count - 1
                cmd.Parameters.Clear()
                cmd.CommandText = "INSERT INTO [dbo].[MS_Document]
                                    ([projectID][documentKey],[documentTypeID],[documentName],[documentFile],
                                    [remarks],[isActive],[lastupdated],[lastUpdater])
                                         VALUES
                                  (@projectID@documentKey,@documentTypeID,@documentName,@documentFile,
                                    @remarks,@isActive,@lastupdated,@lastUpdater) ;"

                cmd.Parameters.AddWithValue("@projectID", dtBankAccount.Rows(i).Item("projectID"))
                cmd.Parameters.AddWithValue("@documentKey", personalID)
                cmd.Parameters.AddWithValue("@documentTypeID", dtBankAccount.Rows(i).Item("documentTypeID"))
                cmd.Parameters.AddWithValue("@documentName", dtBankAccount.Rows(i).Item("documentName"))
                cmd.Parameters.AddWithValue("@documentFile", dtBankAccount.Rows(i).Item("documentFile"))
                cmd.Parameters.AddWithValue("@remarks", dtBankAccount.Rows(i).Item("remarks"))
                cmd.Parameters.AddWithValue("@isActive", isActive)
                cmd.Parameters.AddWithValue("@lastUpdated", lastUpdated)
                cmd.Parameters.AddWithValue("@lastUpdater", lastUpdater)

                cmd.Connection = connection
                Try
                    cmd.ExecuteNonQuery()
                Catch ex As Exception
                    result = ex.Message
                    transaction.Rollback()
                End Try
            Next


            cmd = Nothing
            connection.Close()
            connection.Dispose()
        Catch ex As Exception
            result = ex.Message
        End Try

        Return result

    End Function


End Class
