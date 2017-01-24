
Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration

Public Class clsUnit

    Public Shared Function getDetailUnitByID(ByVal projectID As String, ByVal unitID As String) As DataSet
        Dim cmd As New SqlCommand
        Dim ds As New DataSet
        Dim conStr As String = ConfigurationManager.AppSettings("SQLConnecttion") 'connection string ada di app.config <Appsetting>
        Dim connection As New SqlConnection

        Try
            connection.ConnectionString = conStr
            connection.Open()

            cmd.Parameters.Clear()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "select * from MS_Unit mu " &
                               " left join MS_UnitType mt on mu.unitTypeID=mt.unitTypeID " &
                               " left join MS_UnitFacing mf on mu.facingID=mf.facingID " &
                               " left join MS_UnitView mv on mu.viewID=mv.viewID " &
                               " where mu.isActive=1 and mu.projectID=@projectID and mu.unitID=@unitID"
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

End Class
