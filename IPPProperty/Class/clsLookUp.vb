Imports System.Data.SqlClient
Imports System.Configuration

Public Class clsLookUp

    Public Shared Function getAPPUserByName(ByVal search As String) As DataSet

        Dim cmd As New SqlCommand
        Dim ds As New DataSet
        Dim conStr As String = ConfigurationManager.AppSettings("SQLConnecttion") 'connection string ada di app.config <Appsetting>
        Dim connection As New SqlConnection

        Try
            connection.ConnectionString = conStr
            connection.Open()

            cmd.Parameters.Clear()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "select au.userID, au.Username,au.personalID,au.InstitutionID,mp.personalName From App_user au
                                left join MS_Personal mp on au.personalID=mp.personalID
                                where au.isActive=1 and  mp.personalName like '%" & search & "%'"
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


    Public Shared Function getPersonalByName(ByVal projectID As String, ByVal search As String) As DataSet

        Dim cmd As New SqlCommand
        Dim ds As New DataSet
        Dim conStr As String = ConfigurationManager.AppSettings("SQLConnecttion") 'connection string ada di app.config <Appsetting>
        Dim connection As New SqlConnection

        Try
            connection.ConnectionString = conStr
            connection.Open()

            cmd.Parameters.Clear()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "select personalID,projectID,personalCode,personalName,personalTypeID from MS_Personal 
                               where isActive=1 and projectID=@projectID and personalName like '%" & search & "%'"
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


    Public Shared Function getProjectByName(ByVal search As String) As DataSet

        Dim cmd As New SqlCommand
        Dim ds As New DataSet
        Dim conStr As String = ConfigurationManager.AppSettings("SQLConnecttion") 'connection string ada di app.config <Appsetting>
        Dim connection As New SqlConnection

        Try
            connection.ConnectionString = conStr
            connection.Open()

            cmd.Parameters.Clear()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "Select projectId,siteID,projectCode,projectName from MS_Project
                                where isActive=1 and projectName like  '%" & search & "%'"
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


    Public Shared Function getRolesByName(ByVal projectID As String, ByVal search As String) As DataSet

        Dim cmd As New SqlCommand
        Dim ds As New DataSet
        Dim conStr As String = ConfigurationManager.AppSettings("SQLConnecttion") 'connection string ada di app.config <Appsetting>
        Dim connection As New SqlConnection

        Try
            connection.ConnectionString = conStr
            connection.Open()

            cmd.Parameters.Clear()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "select rolesId,projectID,rolesCode,rolesName from APP_Roles
                                where isActive=1 and projectID=@projectID and rolesName like '%" & search & "%'"
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

    Public Shared Function getInstitutionByName(ByVal projectID As String, ByVal search As String) As DataSet

        Dim cmd As New SqlCommand
        Dim ds As New DataSet
        Dim conStr As String = ConfigurationManager.AppSettings("SQLConnecttion") 'connection string ada di app.config <Appsetting>
        Dim connection As New SqlConnection

        Try
            connection.ConnectionString = conStr
            connection.Open()

            cmd.Parameters.Clear()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "select personalID,ProjectID,personalCode,personalName from MS_Personal
                                where isActive=1 and personalTypeID=2 and projectId=@projectID and personalname like '%" & search & "%'"
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


    Public Shared Function getMenuByName(ByVal projectID As String, ByVal search As String) As DataSet

        Dim cmd As New SqlCommand
        Dim ds As New DataSet
        Dim conStr As String = ConfigurationManager.AppSettings("SQLConnecttion") 'connection string ada di app.config <Appsetting>
        Dim connection As New SqlConnection

        Try
            connection.ConnectionString = conStr
            connection.Open()

            cmd.Parameters.Clear()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "select menuID,projectID,parentID,menuName from APP_Menu
                                where isActive=1 and projectId=@projectID and menuName like '%" & search & "%'"
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


    Public Shared Function getAddressType(ByVal projectID As String, ByVal search As String) As DataSet

        Dim cmd As New SqlCommand
        Dim ds As New DataSet
        Dim conStr As String = ConfigurationManager.AppSettings("SQLConnecttion") 'connection string ada di app.config <Appsetting>
        Dim connection As New SqlConnection

        Try
            connection.ConnectionString = conStr
            connection.Open()

            cmd.Parameters.Clear()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "select AddressTypeID,AddressTypeName from MS_AddressType
                                where isActive=1 and projectId=@projectID and addressname like '%" & search & "%'"
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

    Public Shared Function getCountryByName(ByVal projectID As String, ByVal search As String) As DataSet

        Dim cmd As New SqlCommand
        Dim ds As New DataSet
        Dim conStr As String = ConfigurationManager.AppSettings("SQLConnecttion") 'connection string ada di app.config <Appsetting>
        Dim connection As New SqlConnection

        Try
            connection.ConnectionString = conStr
            connection.Open()

            cmd.Parameters.Clear()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "select countryId,countryCode, countryName from MS_Country
                                where isActive=1 and projectId=@projectID and countryName like '%" & search & "%'"
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

    Public Shared Function getCitizenByName(ByVal projectID As String, ByVal search As String) As DataSet

        Dim cmd As New SqlCommand
        Dim ds As New DataSet
        Dim conStr As String = ConfigurationManager.AppSettings("SQLConnecttion") 'connection string ada di app.config <Appsetting>
        Dim connection As New SqlConnection

        Try
            connection.ConnectionString = conStr
            connection.Open()

            cmd.Parameters.Clear()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "select citizenID,citizenCode, citizenName from MS_Citizen
                                where isActive=1 and projectId=@projectID and citizenName like '%" & search & "%'"
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

    Public Shared Function getBankbySearch(ByVal projectID As String, ByVal search As String) As DataSet

        Dim cmd As New SqlCommand
        Dim ds As New DataSet
        Dim conStr As String = ConfigurationManager.AppSettings("SQLConnecttion") 'connection string ada di app.config <Appsetting>
        Dim connection As New SqlConnection

        Try
            connection.ConnectionString = conStr
            connection.Open()

            cmd.Parameters.Clear()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "select bankID, bankName from MS_Bank
                                where isActive=1 and projectId=@projectID and bankName like '%" & search & "%'"
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


    Public Shared Function getApprovalByName(ByVal projectID As String, ByVal search As String) As DataSet

        Dim cmd As New SqlCommand
        Dim ds As New DataSet
        Dim conStr As String = ConfigurationManager.AppSettings("SQLConnecttion") 'connection string ada di app.config <Appsetting>
        Dim connection As New SqlConnection

        Try
            connection.ConnectionString = conStr
            connection.Open()

            cmd.Parameters.Clear()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = " select levelApprovalID,projectID,levelApprovalCode,levelApprovalName from APP_LevelApproval
                                where isActive=1 and projectID=@projectID and levelApprovalName  like '%" & search & "%'"
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

    Public Shared Function getUnitbySearch(ByVal projectID As String, ByVal search As String) As DataSet

        Dim cmd As New SqlCommand
        Dim ds As New DataSet
        Dim conStr As String = ConfigurationManager.AppSettings("SQLConnecttion") 'connection string ada di app.config <Appsetting>
        Dim connection As New SqlConnection

        Try
            connection.ConnectionString = conStr
            connection.Open()

            cmd.Parameters.Clear()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "select mu.unitID, mu.unitNo, mu.UnitSize,mt.unitTypeCode,mt.UnitTypeName, " +
                               "mu.qtyPax, mu.towerName from MS_Unit mu " &
                               " left join MS_UnitType mt on mu.unitTypeID=mt.unitTypeID " &
                               " left join MS_UnitFacing mf on mu.facingID=mf.facingID " &
                               " left join MS_UnitView mv on mu.viewID=mv.viewID " &
                               " where mu.isActive = 1 And mu.projectId =@projectID And mu.unitNo Like '%" & search & "%'"
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

    Public Shared Function getTenantConfirmationbySearch(ByVal projectID As String, ByVal search As String) As DataSet

        Dim cmd As New SqlCommand
        Dim ds As New DataSet
        Dim conStr As String = ConfigurationManager.AppSettings("SQLConnecttion") 'connection string ada di app.config <Appsetting>
        Dim connection As New SqlConnection

        Try
            connection.ConnectionString = conStr
            connection.Open()

            cmd.Parameters.Clear()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "select tcID, tcNo, unitNo, reservationNo from TR_TenantConfirmation ttc " +
                               " left join MS_Unit mu on ttc.unitID=mu.unitID " +
                               "  where ttc.isActive=1 And ttc.projectId=@projectID And ( tcNo Like '%" & search & "%' or reservationNo like '%" & search & "%')"
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


    Public Shared Function getTenantConfirmationPaxbySearch(ByVal projectID As String, ByVal leaseType As String,
                                                            ByVal search As String) As DataSet

        Dim cmd As New SqlCommand
        Dim ds As New DataSet
        Dim conStr As String = ConfigurationManager.AppSettings("SQLConnecttion") 'connection string ada di app.config <Appsetting>
        Dim connection As New SqlConnection

        Try
            connection.ConnectionString = conStr
            connection.Open()

            cmd.Parameters.Clear()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "select leaseId, leaseType,leaseNo,chairmanName,companyName from TR_LeasePaxDoc  " +
                               "  where isActive=1 And projectId=@projectID and leaseType=@leaseType And leaseNo  Like '%" & search & "%' "
            cmd.Parameters.AddWithValue("@projectID", projectID)
            cmd.Parameters.AddWithValue("@leaseType", leaseType)
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

    Public Shared Function getTenantConfirmationbyUnitSearch(ByVal projectID As String, ByVal unitID As String, ByVal search As String) As DataSet

        Dim cmd As New SqlCommand
        Dim ds As New DataSet
        Dim conStr As String = ConfigurationManager.AppSettings("SQLConnecttion") 'connection string ada di app.config <Appsetting>
        Dim connection As New SqlConnection

        Try
            connection.ConnectionString = conStr
            connection.Open()

            cmd.Parameters.Clear()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "select tcID, proposalNo from TR_TenantConfirmation 
                                where isActive=1 and projectId=@projectID and unitID=@unitID and proposalNo like '%" & search & "%'"
            cmd.Parameters.AddWithValue("@projectID", projectID)
            cmd.Parameters.AddWithValue("@unitID", unitID)
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

    Public Shared Function getInvoiceBySearch(ByVal projectID As String, ByVal unitID As String, ByVal search As String) As DataSet

        Dim cmd As New SqlCommand
        Dim ds As New DataSet
        Dim conStr As String = ConfigurationManager.AppSettings("SQLConnecttion") 'connection string ada di app.config <Appsetting>
        Dim connection As New SqlConnection

        Try
            connection.ConnectionString = conStr
            connection.Open()

            cmd.Parameters.Clear()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "select invoiceID, invoiceNo from TR_TenantConfirmation 
                                where isActive=1 and projectId=@projectID and unitID=@unitID and invoiceNo like '%" & search & "%'"
            cmd.Parameters.AddWithValue("@projectID", projectID)
            cmd.Parameters.AddWithValue("@unitID", unitID)
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

    Public Shared Function getReservationNoBySearch(ByVal projectID As String, ByVal search As String) As DataSet

        Dim cmd As New SqlCommand
        Dim ds As New DataSet
        Dim conStr As String = ConfigurationManager.AppSettings("SQLConnecttion") 'connection string ada di app.config <Appsetting>
        Dim connection As New SqlConnection

        Try
            connection.ConnectionString = conStr
            connection.Open()

            cmd.Parameters.Clear()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "select tga.transID, tga.reservationNo, mu.unitNo,tga.personalName from  TR_GuestArrival tga " +
                              " left join MS_Unit mu on tga.unitID=mu.unitID " +
                               " where tga.isActive=1 And tga.projectId=@projectID and " +
                               " tga.reservationNo not in (select reservationNo from TR_TenantConfirmation) And " +
                               " tga.reservationNo Like '%" & search & "%'"
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


    Public Shared Function getTransactionBySearch(ByVal projectID As String, ByVal unitID As String, ByVal search As String) As DataSet

        Dim cmd As New SqlCommand
        Dim ds As New DataSet
        Dim conStr As String = ConfigurationManager.AppSettings("SQLConnecttion") 'connection string ada di app.config <Appsetting>
        Dim connection As New SqlConnection

        Try
            connection.ConnectionString = conStr
            connection.Open()

            cmd.Parameters.Clear()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "select tb.billingId as BillingID,mu.unitID as UnitID,mu.unitNo as UnitNo,
                                tb.billingType as BillingName, tb.beginPeriode as BeginPeriode, tb.endPeriode  as EndPeriode,
                                tb.bestprice as Amount From TR_Billing tb
                                left join MS_Unit mu on tb.unitID=mu.unitID
                                where isActive=1 and projectID=@projectID and UnitNo like '%" & search & "%'
                                union
                                select tcu.tcID as BillingID, tcu.UnitID as UnitID, mu.unitNo as UnitNo,
                                (select 'Rental' as BillingName), tcu.beginPeriode as BeginPeriode, tcu.endPeriode as EndPeriode,
                                tcu.bestPrice as Amount from TR_TenantConfirmation tcu
                                left join MS_Unit mu on tcu.unitID=mu.unitID 
                                 where tb.isActive=1 and tb.projectID=@projectID and mu.UnitNo like '%" & search & "%'"

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


    Public Shared Function getLeaseAgreementBySearch(ByVal projectID As String, ByVal search As String) As DataSet

        Dim cmd As New SqlCommand
        Dim ds As New DataSet
        Dim conStr As String = ConfigurationManager.AppSettings("SQLConnecttion") 'connection string ada di app.config <Appsetting>
        Dim connection As New SqlConnection

        Try
            connection.ConnectionString = conStr
            connection.Open()

            cmd.Parameters.Clear()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "select leaseID,LeaseNo ,personalName,mu.unitNo from TR_LeaseAgreement tla " +
                               " left join MS_Unit mu on tla.unitID=mu.unitID " +
                               " where tla.projectId=@projectID and  " +
                               " tla.leaseNo not in (select leaseNo from TR_TenantConfirmation where isActive=1) and tla.LeaseNo like '%" & search & "%' "
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

End Class
