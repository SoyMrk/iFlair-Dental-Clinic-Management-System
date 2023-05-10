Imports MySql.Data.MySqlClient

Module dbConnect
    Public sqlcmd As New MySqlCommand
    Public sqlstr As String
    Public sqlstr2 As String
    Public sqlstr3 As String
    Public sqlstr4 As String
    Public myreader As MySqlDataReader
    Public myAdapter As New MySqlDataAdapter

    Public serverIp As String
    Public userId As String
    Public password As String
    Public dbName As String

    Public DBConnection As New MySqlConnection

    Public Sub ConnectDatabase()

        serverIp = My.Settings.serverIp
        userId = My.Settings.userId
        password = My.Settings.password
        dbName = My.Settings.dbName
        'MsgBox(serverIp)
        'MsgBox(userId)
        'MsgBox(password)
        'MsgBox(dbName)

        Dim ConnectionString As String = "server=" & serverIp & ";user id=" & userId & ";password=" & password & ";database=" & dbName & ""

        With DBConnection

            Try
                If .State = ConnectionState.Open Then .Close()
                .ConnectionString = ConnectionString
                sqlcmd.Parameters.Clear()
                .Open()
            Catch ex As Exception
                MessageBox.Show("Could not Connect to the Database", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Call DatabaseDisconnect()
            End Try

        End With

    End Sub


    Public Sub DatabaseDisconnect()
        With DBConnection
            sqlcmd.Parameters.Clear()
            .Close()
            .Dispose()
        End With
    End Sub



End Module
