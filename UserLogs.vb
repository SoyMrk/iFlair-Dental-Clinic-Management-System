Public Class UserLogs

    Public Sub refreshDataGridUserLogs()

        Me.dataviewUserLogs.Rows.Clear()
        'dataviewUserLogs.RowTemplate.Height = 40

        ConnectDatabase()

        With sqlcmd

            Try
                .Connection = DBConnection
                .CommandType = CommandType.StoredProcedure
                .CommandText = "UserLogsFilter"
                .Parameters.AddWithValue("@dateFilter", "")
                .Parameters.AddWithValue("@txtSearch", "")
                'MsgBox("Successful", MsgBoxStyle.Information, "Information")

                myreader = sqlcmd.ExecuteReader

                While myreader.Read()

                    Me.dataviewUserLogs.Rows.Add(New Object() {myreader("UserLogID"), myreader("UserName"), myreader("UserType"), myreader("DateTimeIn"), myreader("DateTimeOut")})

                End While

            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
                DatabaseDisconnect()
            End Try

        End With

        DatabaseDisconnect()

    End Sub

    Private Sub UserLogs_Load(sender As Object, e As EventArgs) Handles Me.Load
        refreshDataGridUserLogs()

    End Sub

    Private Sub txtboxSearch_Click(sender As Object, e As EventArgs) Handles txtboxSearch.Click
        txtboxSearch.Text = ""
    End Sub

    Private Sub txtboxSearch_TextChanged(sender As Object, e As EventArgs) Handles txtboxSearch.TextChanged

        If txtboxSearch.Text = "  Search here" Or txtboxSearch.Text = "" Then
            Exit Sub
        End If

        Me.dataviewUserLogs.Rows.Clear()

        ConnectDatabase()

        With sqlcmd
            .Connection = DBConnection
            .CommandType = CommandType.StoredProcedure
            .CommandText = "UserLogsFilter"
            .Parameters.AddWithValue("@dateFilter", dtpickerFilter.Value.ToString("yyyy-MM-dd"))
            .Parameters.AddWithValue("@txtSearch", txtboxSearch.Text)
        End With

        myreader = sqlcmd.ExecuteReader
        While myreader.Read()
            Me.dataviewUserLogs.Rows.Add(New Object() {myreader("UserLogID"), myreader("UserName"), myreader("UserType"), myreader("DateTimeIn"), myreader("DateTimeOut")})
        End While
        DatabaseDisconnect()

    End Sub

    Private Sub dataviewUserLogs_CellMouseMove(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dataviewUserLogs.CellMouseMove

        dataviewUserLogs.ClearSelection()
        If e.RowIndex > -1 Then
            dataviewUserLogs.Rows(e.RowIndex).Selected = True
        End If

    End Sub

    Private Sub dtpickerFilter_ValueChanged(sender As Object, e As EventArgs) Handles dtpickerFilter.ValueChanged
        dataviewUserLogs.Rows.Clear()

        Try
            ConnectDatabase()

            With sqlcmd
                .Connection = DBConnection
                .CommandType = CommandType.StoredProcedure
                .CommandText = "UserLogsFilter"
                .Parameters.AddWithValue("@dateFilter", dtpickerFilter.Value.ToString("yyyy-MM-dd"))
                .Parameters.AddWithValue("@txtSearch", "")
            End With

            myreader = sqlcmd.ExecuteReader

            While myreader.Read()

                Me.dataviewUserLogs.Rows.Add(New Object() {myreader("UserLogID"), myreader("UserName"), myreader("UserType"), myreader("DateTimeIn"), myreader("DateTimeOut")})

            End While

            DatabaseDisconnect()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            DatabaseDisconnect()
        End Try
    End Sub

    Private Sub btnResetFilter_Click(sender As Object, e As EventArgs) Handles btnResetFilter.Click
        dtpickerFilter.Value = DateTime.Now
        refreshDataGridUserLogs()
    End Sub
End Class