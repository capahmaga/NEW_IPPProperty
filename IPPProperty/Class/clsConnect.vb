Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports System.Data.OleDb

Public Class clsConnect


    'function untuk ambil data dari database parameternya nama Table, jumlah data yang diambil, where/kondisi dan order
    Public Shared Function getAllData(ByVal table As String, Optional ByVal fieldData As String = "*",
                                      Optional ByVal topData As Integer = 0, Optional ByVal WhereData As String = "",
                                      Optional ByVal orderData As String = "", Optional ByVal orderType As String = "") As DataSet

        Dim cmd As New SqlCommand
        Dim ds As New DataSet
        Dim conStr As String = ConfigurationManager.AppSettings("SQLConnecttion") 'connection string ada di app.config <Appsetting>
        Dim connection As New SqlConnection

        Try
            connection.ConnectionString = conStr
            connection.Open()

            cmd.Parameters.Clear()
            cmd.CommandType = CommandType.Text

            If topData = 0 Then
                If WhereData = "" Then
                    ' select seluruh data dari table (nama table sebagai parameter)
                    cmd.CommandText = "select " & fieldData & " from " & table
                Else
                    ' ambil Seluruh data dengan kondisi
                    cmd.CommandText = "select " & fieldData & " from " & table & " where " & WhereData
                End If
            Else
                If WhereData = "" Then
                    'ambil sebagian data parameter sejumlah topData 
                    cmd.CommandText = "select top " & topData & " " & fieldData & " from " & table
                Else
                    'ambil sebagian data parameter sejumlah topData dengan kondisi parameter whereData
                    cmd.CommandText = "select top " & topData & " " & fieldData & " from " & table & " where " & WhereData
                End If
            End If
            'Check jika ada pengurutan data
            If orderData <> "" Then
                If orderType <> "" Then
                    ' ambil data dengan tabahan order / pengurutan dijadikan parameter
                    cmd.CommandText = cmd.CommandText & " order by " & orderData & " " & orderType & ";"
                Else
                    ' ambil data dengan tabahan order / pengurutan standard
                    cmd.CommandText = cmd.CommandText & " order by " & orderData & ";"
                End If
            End If
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


    Public Shared Function getServerDate() As Date
        Dim cmd As New SqlCommand
        Dim ds As New DataSet
        Dim conStr As String = ConfigurationManager.AppSettings("SQLConnecttion") 'connection string ada di app.config <Appsetting>
        Dim connection As New SqlConnection

        Try
            connection.ConnectionString = conStr
            connection.Open()

            cmd.Parameters.Clear()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "select getdate() as Today "
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

        Return ds.Tables("Data").Rows(0).Item("Today")
    End Function


    Public Shared Function insertData(ByVal projectID As String, ByVal personalID As String, ByVal rolesID As String,
                                ByVal institutionID As String, ByVal levelApprovalID As String, ByVal username As String,
                                ByVal password As String, ByVal remarks As String, ByVal isActive As Integer,
                                ByVal lastUpdated As DateTime, ByVal lastUpdater As String) As String
        Dim cmd As New SqlCommand
        Dim result As String = ""
        Dim sqlQuery As String = ""
        Dim conStr As String = ConfigurationManager.AppSettings("SQLConnecttion") 'connection string ada di app.config <Appsetting>
        Dim connection As New SqlConnection

        Try
            connection.ConnectionString = conStr
            connection.Open()

            cmd.Parameters.Clear()
            cmd.CommandType = CommandType.Text

            sqlQuery = "INSERT INTO [dbo].[APP_User]
                                       ([projectID],[personalID],[rolesID],[institutionID],[levelApprovalID]
                                       ,[username],[password],[remarks],[isActive],[lastUpdated],[lastUpdater])
                                 VALUES
                                       (@projectID,@personalID,@rolesID,@institutionID,@levelApprovalID
                                       ,@username,@password,@remarks,@isActive,@lastUpdated,@lastUpdater);"

            cmd.Parameters.AddWithValue("@projectID", projectID)
            cmd.Parameters.AddWithValue("@personalID", personalID)
            cmd.Parameters.AddWithValue("@rolesID", rolesID)
            cmd.Parameters.AddWithValue("@institutionID", institutionID)
            cmd.Parameters.AddWithValue("@levelApprovalID", levelApprovalID)
            cmd.Parameters.AddWithValue("@username", username)
            cmd.Parameters.AddWithValue("@password", password)
            cmd.Parameters.AddWithValue("@remarks", remarks)
            cmd.Parameters.AddWithValue("@isActive", isActive)
            cmd.Parameters.AddWithValue("@lastUpdated", lastUpdated)
            cmd.Parameters.AddWithValue("@lastUpdater", lastUpdater)

            cmd.Connection = connection
            Try
                cmd.ExecuteNonQuery()
            Catch ex As Exception

            End Try

            cmd = Nothing
            connection.Close()
            connection.Dispose()
        Catch ex As Exception
            result = ex.Message
        End Try

        Return result

    End Function


    Public Shared Function updateData(ByVal userID As String, ByVal projectID As String, ByVal personalID As String,
                                ByVal rolesID As String, ByVal institutionID As String, ByVal levelApprovalID As String,
                                ByVal username As String, ByVal password As String, ByVal remarks As String,
                                ByVal isActive As Integer, ByVal lastUpdated As DateTime, ByVal lastUpdater As String) As String
        Dim cmd As New SqlCommand
        Dim result As String = ""
        Dim conStr As String = ConfigurationManager.AppSettings("SQLConnecttion") 'connection string ada di app.config <Appsetting>
        Dim connection As New SqlConnection

        Try
            connection.ConnectionString = conStr
            connection.Open()

            cmd.Parameters.Clear()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "UPDATE [dbo].[APP_User]
                               SET [projectID] = @projectID
                                  ,[personalID] = @personalID
                                  ,[rolesID] = @rolesID
                                  ,[institutionID] = @institutionID
                                  ,[levelApprovalID] = @levelApprovalID
                                  ,[username] = @username
                                  ,[password] = @password
                                  ,[remarks] = @remarks
                                  ,[isActive] = @isActive
                                  ,[lastUpdated] = @lastUpdated
                                  ,[lastUpdater] = @lastUpdater
                             WHERE userID=@userId ;"

            cmd.Parameters.AddWithValue("@userId", userID)
            cmd.Parameters.AddWithValue("@projectID", projectID)
            cmd.Parameters.AddWithValue("@personalID", personalID)
            cmd.Parameters.AddWithValue("@rolesID", rolesID)
            cmd.Parameters.AddWithValue("@institutionID", institutionID)
            cmd.Parameters.AddWithValue("@levelApprovalID", levelApprovalID)
            cmd.Parameters.AddWithValue("@username", username)
            cmd.Parameters.AddWithValue("@password", password)
            cmd.Parameters.AddWithValue("@remarks", remarks)
            cmd.Parameters.AddWithValue("@isActive", isActive)
            cmd.Parameters.AddWithValue("@lastUpdated", lastUpdated)
            cmd.Parameters.AddWithValue("@lastUpdater", lastUpdater)

            cmd.Connection = connection
            cmd.ExecuteNonQuery()

            cmd = Nothing
            connection.Close()
            connection.Dispose()
        Catch ex As Exception
            result = ex.Message
        End Try

        Return result

    End Function

    Public Shared Function deleteData(ByVal userID As String, ByVal isActive As Integer, ByVal lastUpdated As DateTime,
                               ByVal lastUpdater As String) As String
        Dim cmd As New SqlCommand
        Dim result As String = ""
        Dim conStr As String = ConfigurationManager.AppSettings("SQLConnecttion") 'connection string ada di app.config <Appsetting>
        Dim connection As New SqlConnection

        Try
            connection.ConnectionString = conStr
            connection.Open()

            cmd.Parameters.Clear()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "UPDATE [dbo].[APP_User]
                               SET [isActive] = @isActive
                                  ,[lastUpdated] = @lastUpdated
                                  ,[lastUpdater] = @lastUpdater
                             WHERE userID=@userId ;"

            cmd.Parameters.AddWithValue("@userId", userID)
            cmd.Parameters.AddWithValue("@isActive", isActive)
            cmd.Parameters.AddWithValue("@lastUpdated", lastUpdated)
            cmd.Parameters.AddWithValue("@lastUpdater", lastUpdater)

            cmd.Connection = connection
            cmd.ExecuteNonQuery()

            cmd = Nothing
            connection.Close()
            connection.Dispose()
        Catch ex As Exception
            result = ex.Message
        End Try

        Return result

    End Function

    Public Shared Function getAllDataExcel(ByVal link As String, ByVal file As String) As DataSet
        Dim con As New OleDbConnection
        Dim cmd As New OleDbCommand
        Dim ds As DataSet

        con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + link + ";Extended Properties=Excel 8.0;"
        con.Open()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select * from [Sheet1$]"

        cmd.Connection = con

        Dim odbcDA As New OleDbDataAdapter(cmd)
        ds = New DataSet
        odbcDA.Fill(ds, "Excel")

        odbcDA = Nothing
        cmd = Nothing
        con.Close()

        Return ds

    End Function



    Public Shared Function getAllDataCSV(ByVal link As String, ByVal file As String) As DataSet
        Dim con As New OleDbConnection
        Dim cmd As New OleDbCommand
        Dim ds As DataSet

        con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Extended Properties='Text;HDR=No;Schema=schema.ini;';Data Source=" + link
        con.Open()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select * from " & file

        cmd.Connection = con

        Dim odbcDA As New OleDbDataAdapter(cmd)
        ds = New DataSet
        odbcDA.Fill(ds, "CSV")

        odbcDA = Nothing
        cmd = Nothing
        con.Close()

        Return ds

    End Function



End Class
