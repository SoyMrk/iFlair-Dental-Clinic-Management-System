Public Class Treatment

    Public Sub refreshDataViewTreatment()

        Me.dataviewTreatment.Rows.Clear()

        ConnectDatabase()
        With sqlcmd
            Try
                .Connection = DBConnection
                .CommandType = CommandType.StoredProcedure
                .CommandText = "viewTransactions"
                .Parameters.AddWithValue("@filterType", cmbboxFilterTransactions.Text)
                .Parameters.AddWithValue("@txtSearch", "")
                .Parameters.AddWithValue("@AppDateFilter", "")


                myreader = sqlcmd.ExecuteReader


                While myreader.Read()


                    If myreader("AppDate").ToString = "" Then
                        Exit Sub
                    Else


                        Dim AppDate As DateTime = myreader("AppDate").ToString

                        Me.dataviewTreatment.Rows.Add(New Object() {AppDate.ToString("MMMM dd, yyyy"), myreader.Item("FirstName") + " " + myreader.Item("LastName"), myreader.Item("Procedures"), myreader.Item("TotalAmount"), myreader.Item("TotalAmountPaid"), myreader.Item("Balance"), myreader.Item("DateLastPaid")})


                    End If

                End While

            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
                DatabaseDisconnect()
            End Try
        End With

        DatabaseDisconnect()

        txtboxAppsFound.Text = Me.dataviewTreatment.Rows.Count.ToString + " treatment/s found"
    End Sub

    Private Sub Treatment_Load(sender As Object, e As EventArgs) Handles Me.Load
        cmbboxFilterTransactions.Text = "All"
        dataviewTreatment.RowTemplate.Height = 40
        refreshDataViewTreatment()
        dataviewTreatment.ClearSelection()
    End Sub

    Private Sub dataviewTreatment_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles dataviewTreatment.RowsAdded
        txtboxAppsFound.Text = Me.dataviewTreatment.Rows.Count.ToString + " treatment/s found"
    End Sub

    Private Sub txtboxSearch_TextChanged(sender As Object, e As EventArgs) Handles txtboxSearch.TextChanged

        If cmbboxFilterTransactions.Text = "All" Or cmbboxFilterTransactions.Text = "Today" Or cmbboxFilterTransactions.Text = "Week" Or cmbboxFilterTransactions.Text = "Month" Then

            If txtboxSearch.Text = "" Or txtboxSearch.Text = "Search Transactions" Then

                Me.dataviewTreatment.Rows.Clear()

                ConnectDatabase()
                With sqlcmd
                    Try
                        .Connection = DBConnection
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "viewTransactions"
                        .Parameters.AddWithValue("@filterType", cmbboxFilterTransactions.Text)
                        .Parameters.AddWithValue("@txtSearch", txtboxSearch.Text)
                        .Parameters.AddWithValue("@AppDateFilter", "")
                        'MsgBox("Successful", MsgBoxStyle.Information, "Information")

                        myreader = sqlcmd.ExecuteReader


                        While myreader.Read()


                            If myreader("AppDate").ToString = "" Then
                                Exit Sub
                            Else

                                Dim AppDate As DateTime = myreader("AppDate").ToString

                                Me.dataviewTreatment.Rows.Add(New Object() {AppDate.ToString("MMMM dd, yyyy"), myreader.Item("FirstName") + " " + myreader.Item("LastName"), myreader.Item("Procedures"), myreader.Item("TotalAmount"), myreader.Item("TotalAmountPaid"), myreader.Item("Balance")})


                            End If

                        End While

                    Catch ex As Exception
                        MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
                        DatabaseDisconnect()
                    End Try
                End With
                DatabaseDisconnect()

            End If

            Me.dataviewTreatment.Rows.Clear()

            ConnectDatabase()
            With sqlcmd
                Try
                    .Connection = DBConnection
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "viewTransactions"
                    .Parameters.AddWithValue("@filterType", cmbboxFilterTransactions.Text)
                    .Parameters.AddWithValue("@txtSearch", txtboxSearch.Text)
                    .Parameters.AddWithValue("@AppDateFilter", "")
                    'MsgBox("Successful", MsgBoxStyle.Information, "Information")

                    myreader = sqlcmd.ExecuteReader


                    While myreader.Read()


                        If myreader("AppDate").ToString = "" Then
                            Exit Sub
                        Else

                            Dim AppDate As DateTime = myreader("AppDate").ToString

                            Me.dataviewTreatment.Rows.Add(New Object() {AppDate.ToString("MMMM dd, yyyy"), myreader.Item("FirstName") + " " + myreader.Item("LastName"), myreader.Item("Procedures"), myreader.Item("TotalAmount"), myreader.Item("TotalAmountPaid"), myreader.Item("Balance")})


                        End If

                    End While

                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
                    DatabaseDisconnect()
                End Try
            End With
            DatabaseDisconnect()

        End If




    End Sub

    Private Sub dataviewTreatment_CellMouseMove(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dataviewTreatment.CellMouseMove
        dataviewTreatment.ClearSelection()
        'If e.RowIndex > -1 Then
        '    dataviewTreatment.Rows(e.RowIndex).Selected = True
        'End If
    End Sub

    Private Sub txtboxSearch_Click(sender As Object, e As EventArgs) Handles txtboxSearch.Click
        txtboxSearch.Text = ""
    End Sub

    Private Sub cmbboxFilterTransactions_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmbboxFilterTransactions.SelectionChangeCommitted

        refreshDataViewTreatment()

    End Sub

    Private Sub dtpickerFilter_ValueChanged(sender As Object, e As EventArgs) Handles dtpickerFilter.ValueChanged

        Me.dataviewTreatment.Rows.Clear()

        ConnectDatabase()
        With sqlcmd
            Try
                .Connection = DBConnection
                .CommandType = CommandType.StoredProcedure
                .CommandText = "viewTransactions"
                .Parameters.AddWithValue("@filterType", "Date")
                .Parameters.AddWithValue("@txtSearch", "")
                .Parameters.AddWithValue("@AppDateFilter", dtpickerFilter.Value.ToString("yyyy-MM-dd"))


                myreader = sqlcmd.ExecuteReader


                While myreader.Read()


                    If myreader("AppDate").ToString = "" Then
                        Exit Sub
                    Else


                        Dim AppDate As DateTime = myreader("AppDate").ToString

                        Me.dataviewTreatment.Rows.Add(New Object() {AppDate.ToString("MMMM dd, yyyy"), myreader.Item("FirstName") + " " + myreader.Item("LastName"), myreader.Item("Procedures"), myreader.Item("TotalAmount"), myreader.Item("TotalAmountPaid"), myreader.Item("Balance"), myreader.Item("DateLastPaid")})


                    End If

                End While

            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
                DatabaseDisconnect()
            End Try
        End With

        DatabaseDisconnect()

        txtboxAppsFound.Text = Me.dataviewTreatment.Rows.Count.ToString + " treatment/s found"

    End Sub

    Private Sub btnResetFilter_Click(sender As Object, e As EventArgs) Handles btnResetFilter.Click
        dtpickerFilter.Value = DateTime.Now
        refreshDataViewTreatment()
    End Sub

    'Private Sub btnDiscount_Click(sender As Object, e As EventArgs) Handles btnDiscount.Click
    '    HomeScreen.Enabled = False
    '    Discount.Show()
    'End Sub

End Class