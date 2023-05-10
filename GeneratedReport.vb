Public Class GeneratedReport
    Private Sub GeneratedReport_Load(sender As Object, e As EventArgs) Handles Me.Load

        If SalesReport.grpboxDateRange.Visible = True Then

            If SalesReport.btnProcedureFilter.Visible = True Then 'With no Procedure

                Try
                    ConnectDatabase()
                    With sqlcmd

                        .Connection = DBConnection
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "GenerateReport"
                        .Parameters.AddWithValue("@ReportType", "PatientSalesBalanceReport")
                        .Parameters.AddWithValue("@DateRangeFrom", SalesReport.dtpickStart.Value.ToString("yyyy-MM-dd"))
                        .Parameters.AddWithValue("@DateRangeTo", SalesReport.dtpickEnd.Value.ToString("yyyy-MM-dd"))
                        .Parameters.AddWithValue("@ProcedureFilter", "")

                        myreader = .ExecuteReader

                        While myreader.Read

                            Dim multipleAppDates As String = ""
                            Dim AppDateToString As DateTime
                            Dim AppDate As String = ""

                            If myreader("AppDate").ToString.Contains(","c) Then
                                multipleAppDates = myreader("AppDate").ToString
                            Else
                                AppDateToString = myreader("AppDate").ToString
                                AppDate = AppDateToString.ToString("MMM-dd-yyyy")
                            End If

                            Dim DateLastPaidToString As DateTime = myreader("DateLastPaid").ToString
                            Dim DateLastPaid As String = DateLastPaidToString.ToString("MMM-dd-yyyy")

                            If myreader("AppDate").ToString.Contains(","c) Then
                                Me.dtgridSalesReport.Rows.Add(New Object() {myreader.Item("PatientName"), myreader.Item("Procedures"), multipleAppDates, myreader.Item("TotalAmountPaid"), myreader.Item("Balance"), DateLastPaid})
                            Else
                                Me.dtgridSalesReport.Rows.Add(New Object() {myreader.Item("PatientName"), myreader.Item("Procedures"), AppDate, myreader.Item("TotalAmountPaid"), myreader.Item("Balance"), DateLastPaid})
                            End If

                        End While
                    End With
                    DatabaseDisconnect()
                Catch ex As Exception

                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    DatabaseDisconnect()
                End Try

            Else 'With Procedure

                Try
                    ConnectDatabase()
                    With sqlcmd

                        .Connection = DBConnection
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "GenerateReport"
                        .Parameters.AddWithValue("@ReportType", "PatientSalesBalanceReport")
                        .Parameters.AddWithValue("@DateRangeFrom", SalesReport.dtpickStart.Value.ToString("yyyy-MM-dd"))
                        .Parameters.AddWithValue("@DateRangeTo", SalesReport.dtpickEnd.Value.ToString("yyyy-MM-dd"))
                        .Parameters.AddWithValue("@ProcedureFilter", SalesReport.cmbboxProcedure.Text)

                        myreader = .ExecuteReader

                        While myreader.Read

                            Dim multipleAppDates As String = ""
                            Dim AppDateToString As DateTime
                            Dim AppDate As String = ""

                            If myreader("AppDate").ToString.Contains(","c) Then
                                multipleAppDates = myreader("AppDate").ToString
                            Else
                                AppDateToString = myreader("AppDate").ToString
                                AppDate = AppDateToString.ToString("MMM-dd-yyyy")
                            End If

                            Dim DateLastPaidToString As DateTime = myreader("DateLastPaid").ToString
                            Dim DateLastPaid As String = DateLastPaidToString.ToString("MMM-dd-yyyy")

                            If myreader("AppDate").ToString.Contains(","c) Then
                                Me.dtgridSalesReport.Rows.Add(New Object() {myreader.Item("PatientName"), myreader.Item("Procedures"), multipleAppDates, myreader.Item("TotalAmountPaid"), myreader.Item("Balance"), DateLastPaid})
                            Else
                                Me.dtgridSalesReport.Rows.Add(New Object() {myreader.Item("PatientName"), myreader.Item("Procedures"), AppDate, myreader.Item("TotalAmountPaid"), myreader.Item("Balance"), DateLastPaid})
                            End If

                        End While
                    End With
                    DatabaseDisconnect()
                Catch ex As Exception

                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    DatabaseDisconnect()
                End Try

            End If



        Else

            If SalesReport.rbDaily.Checked = True Then

                If SalesReport.btnProcedureFilter.Visible = True Then 'WITHOUT PROCEDURE

                    Try
                        ConnectDatabase()
                        With sqlcmd

                            .Connection = DBConnection
                            .CommandType = CommandType.StoredProcedure
                            .CommandText = "GenerateReport"
                            .Parameters.AddWithValue("@ReportType", "DailyReport")
                            .Parameters.AddWithValue("@DateRangeFrom", DBNull.Value)
                            .Parameters.AddWithValue("@DateRangeTo", DBNull.Value)
                            .Parameters.AddWithValue("@ProcedureFilter", "")

                            myreader = .ExecuteReader

                            While myreader.Read

                                Dim multipleAppDates As String = ""
                                Dim AppDateToString As DateTime
                                Dim AppDate As String = ""

                                If myreader("AppDate").ToString.Contains(","c) Then
                                    multipleAppDates = myreader("AppDate").ToString
                                Else
                                    AppDateToString = myreader("AppDate").ToString
                                    AppDate = AppDateToString.ToString("MMM-dd-yyyy")
                                End If

                                Dim DateLastPaidToString As DateTime = myreader("DateLastPaid").ToString
                                Dim DateLastPaid As String = DateLastPaidToString.ToString("MMM-dd-yyyy")

                                If myreader("AppDate").ToString.Contains(","c) Then
                                    Me.dtgridSalesReport.Rows.Add(New Object() {myreader.Item("PatientName"), myreader.Item("Procedures"), multipleAppDates, myreader.Item("TotalAmountPaid"), myreader.Item("Balance"), DateLastPaid})
                                Else
                                    Me.dtgridSalesReport.Rows.Add(New Object() {myreader.Item("PatientName"), myreader.Item("Procedures"), AppDate, myreader.Item("TotalAmountPaid"), myreader.Item("Balance"), DateLastPaid})
                                End If

                            End While
                        End With
                        DatabaseDisconnect()
                    Catch ex As Exception

                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        DatabaseDisconnect()
                    End Try

                Else 'WITH PROCEDURE

                    Try
                        ConnectDatabase()
                        With sqlcmd

                            .Connection = DBConnection
                            .CommandType = CommandType.StoredProcedure
                            .CommandText = "GenerateReport"
                            .Parameters.AddWithValue("@ReportType", "DailyReport")
                            .Parameters.AddWithValue("@DateRangeFrom", DBNull.Value)
                            .Parameters.AddWithValue("@DateRangeTo", DBNull.Value)
                            .Parameters.AddWithValue("@ProcedureFilter", SalesReport.cmbboxProcedure.Text)

                            myreader = .ExecuteReader

                            While myreader.Read

                                Dim multipleAppDates As String = ""
                                Dim AppDateToString As DateTime
                                Dim AppDate As String = ""

                                If myreader("AppDate").ToString.Contains(","c) Then
                                    multipleAppDates = myreader("AppDate").ToString
                                Else
                                    AppDateToString = myreader("AppDate").ToString
                                    AppDate = AppDateToString.ToString("MMM-dd-yyyy")
                                End If

                                Dim DateLastPaidToString As DateTime = myreader("DateLastPaid").ToString
                                Dim DateLastPaid As String = DateLastPaidToString.ToString("MMM-dd-yyyy")

                                If myreader("AppDate").ToString.Contains(","c) Then
                                    Me.dtgridSalesReport.Rows.Add(New Object() {myreader.Item("PatientName"), myreader.Item("Procedures"), multipleAppDates, myreader.Item("TotalAmountPaid"), myreader.Item("Balance"), DateLastPaid})
                                Else
                                    Me.dtgridSalesReport.Rows.Add(New Object() {myreader.Item("PatientName"), myreader.Item("Procedures"), AppDate, myreader.Item("TotalAmountPaid"), myreader.Item("Balance"), DateLastPaid})
                                End If

                            End While

                        End With
                        DatabaseDisconnect()
                    Catch ex As Exception

                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        DatabaseDisconnect()
                    End Try

                End If

            ElseIf SalesReport.rbWeekly.Checked = True Then

                If SalesReport.btnProcedureFilter.Visible = True Then 'WITHOUT PROCEDURE

                    Try
                        ConnectDatabase()
                        With sqlcmd

                            .Connection = DBConnection
                            .CommandType = CommandType.StoredProcedure
                            .CommandText = "GenerateReport"
                            .Parameters.AddWithValue("@ReportType", "WeeklyReport")
                            .Parameters.AddWithValue("@DateRangeFrom", DBNull.Value)
                            .Parameters.AddWithValue("@DateRangeTo", DBNull.Value)
                            .Parameters.AddWithValue("@ProcedureFilter", "")

                            myreader = .ExecuteReader

                            While myreader.Read

                                Dim multipleAppDates As String = ""
                                Dim AppDateToString As DateTime
                                Dim AppDate As String = ""

                                If myreader("AppDate").ToString.Contains(","c) Then
                                    multipleAppDates = myreader("AppDate").ToString
                                Else
                                    AppDateToString = myreader("AppDate").ToString
                                    AppDate = AppDateToString.ToString("MMM-dd-yyyy")
                                End If

                                Dim DateLastPaidToString As DateTime = myreader("DateLastPaid").ToString
                                Dim DateLastPaid As String = DateLastPaidToString.ToString("MMM-dd-yyyy")

                                If myreader("AppDate").ToString.Contains(","c) Then
                                    Me.dtgridSalesReport.Rows.Add(New Object() {myreader.Item("PatientName"), myreader.Item("Procedures"), multipleAppDates, myreader.Item("TotalAmountPaid"), myreader.Item("Balance"), DateLastPaid})
                                Else
                                    Me.dtgridSalesReport.Rows.Add(New Object() {myreader.Item("PatientName"), myreader.Item("Procedures"), AppDate, myreader.Item("TotalAmountPaid"), myreader.Item("Balance"), DateLastPaid})
                                End If

                            End While
                        End With
                        DatabaseDisconnect()
                    Catch ex As Exception

                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        DatabaseDisconnect()
                    End Try


                Else 'WITH PROCEDURE

                    Try
                        ConnectDatabase()
                        With sqlcmd

                            .Connection = DBConnection
                            .CommandType = CommandType.StoredProcedure
                            .CommandText = "GenerateReport"
                            .Parameters.AddWithValue("@ReportType", "WeeklyReport")
                            .Parameters.AddWithValue("@DateRangeFrom", DBNull.Value)
                            .Parameters.AddWithValue("@DateRangeTo", DBNull.Value)
                            .Parameters.AddWithValue("@ProcedureFilter", SalesReport.cmbboxProcedure.Text)

                            myreader = .ExecuteReader

                            While myreader.Read

                                Dim multipleAppDates As String = ""
                                Dim AppDateToString As DateTime
                                Dim AppDate As String = ""

                                If myreader("AppDate").ToString.Contains(","c) Then
                                    multipleAppDates = myreader("AppDate").ToString
                                Else
                                    AppDateToString = myreader("AppDate").ToString
                                    AppDate = AppDateToString.ToString("MMM-dd-yyyy")
                                End If

                                Dim DateLastPaidToString As DateTime = myreader("DateLastPaid").ToString
                                Dim DateLastPaid As String = DateLastPaidToString.ToString("MMM-dd-yyyy")

                                If myreader("AppDate").ToString.Contains(","c) Then
                                    Me.dtgridSalesReport.Rows.Add(New Object() {myreader.Item("PatientName"), myreader.Item("Procedures"), multipleAppDates, myreader.Item("TotalAmountPaid"), myreader.Item("Balance"), DateLastPaid})
                                Else
                                    Me.dtgridSalesReport.Rows.Add(New Object() {myreader.Item("PatientName"), myreader.Item("Procedures"), AppDate, myreader.Item("TotalAmountPaid"), myreader.Item("Balance"), DateLastPaid})
                                End If

                            End While
                        End With
                        DatabaseDisconnect()
                    Catch ex As Exception

                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        DatabaseDisconnect()
                    End Try


                End If


            ElseIf SalesReport.rbMonthly.Checked = True Then

                If SalesReport.btnProcedureFilter.Visible = True Then 'WITHOUT PROCEDURE

                    Try
                        ConnectDatabase()
                        With sqlcmd

                            .Connection = DBConnection
                            .CommandType = CommandType.StoredProcedure
                            .CommandText = "GenerateReport"
                            .Parameters.AddWithValue("@ReportType", "MonthlyReport")
                            .Parameters.AddWithValue("@DateRangeFrom", DBNull.Value)
                            .Parameters.AddWithValue("@DateRangeTo", DBNull.Value)
                            .Parameters.AddWithValue("@ProcedureFilter", "")

                            myreader = .ExecuteReader

                            While myreader.Read

                                Dim multipleAppDates As String = ""
                                Dim AppDateToString As DateTime
                                Dim AppDate As String = ""

                                If myreader("AppDate").ToString.Contains(","c) Then
                                    multipleAppDates = myreader("AppDate").ToString
                                Else
                                    AppDateToString = myreader("AppDate").ToString
                                    AppDate = AppDateToString.ToString("MMM-dd-yyyy")
                                End If

                                Dim DateLastPaidToString As DateTime = myreader("DateLastPaid").ToString
                                Dim DateLastPaid As String = DateLastPaidToString.ToString("MMM-dd-yyyy")

                                If myreader("AppDate").ToString.Contains(","c) Then
                                    Me.dtgridSalesReport.Rows.Add(New Object() {myreader.Item("PatientName"), myreader.Item("Procedures"), multipleAppDates, myreader.Item("TotalAmountPaid"), myreader.Item("Balance"), DateLastPaid})
                                Else
                                    Me.dtgridSalesReport.Rows.Add(New Object() {myreader.Item("PatientName"), myreader.Item("Procedures"), AppDate, myreader.Item("TotalAmountPaid"), myreader.Item("Balance"), DateLastPaid})
                                End If

                            End While
                        End With
                        DatabaseDisconnect()
                    Catch ex As Exception

                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        DatabaseDisconnect()
                    End Try


                Else 'WITH PROCEDURE

                    Try
                        ConnectDatabase()
                        With sqlcmd

                            .Connection = DBConnection
                            .CommandType = CommandType.StoredProcedure
                            .CommandText = "GenerateReport"
                            .Parameters.AddWithValue("@ReportType", "MonthlyReport")
                            .Parameters.AddWithValue("@DateRangeFrom", DBNull.Value)
                            .Parameters.AddWithValue("@DateRangeTo", DBNull.Value)
                            .Parameters.AddWithValue("@ProcedureFilter", SalesReport.cmbboxProcedure.Text)

                            myreader = .ExecuteReader

                            While myreader.Read
                                'MsgBox(myreader("AppDate").ToString)

                                Dim multipleAppDates As String = ""
                                Dim AppDateToString As DateTime
                                Dim AppDate As String = ""

                                If myreader("AppDate").ToString.Contains(","c) Then
                                    multipleAppDates = myreader("AppDate").ToString
                                Else
                                    AppDateToString = myreader("AppDate").ToString
                                    AppDate = AppDateToString.ToString("MMM-dd-yyyy")
                                End If

                                Dim DateLastPaidToString As DateTime = myreader("DateLastPaid").ToString
                                Dim DateLastPaid As String = DateLastPaidToString.ToString("MMM-dd-yyyy")

                                If myreader("AppDate").ToString.Contains(","c) Then
                                    Me.dtgridSalesReport.Rows.Add(New Object() {myreader.Item("PatientName"), myreader.Item("Procedures"), multipleAppDates, myreader.Item("TotalAmountPaid"), myreader.Item("Balance"), DateLastPaid})
                                Else
                                    Me.dtgridSalesReport.Rows.Add(New Object() {myreader.Item("PatientName"), myreader.Item("Procedures"), AppDate, myreader.Item("TotalAmountPaid"), myreader.Item("Balance"), DateLastPaid})
                                End If

                            End While
                        End With
                        DatabaseDisconnect()
                    Catch ex As Exception
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        DatabaseDisconnect()
                    End Try


                End If


            End If

        End If

    End Sub

    Private Sub dtgridSalesReport_CellMouseMove(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dtgridSalesReport.CellMouseMove

        dtgridSalesReport.ClearSelection()
        If e.RowIndex > -1 Then
            dtgridSalesReport.Rows(e.RowIndex).Selected = True
        End If

    End Sub
End Class