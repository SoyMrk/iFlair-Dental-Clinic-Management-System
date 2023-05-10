Public Class PatientTransaction

    Public Sub refreshDataGridPatTransaction()

        Me.datagridPatTransaction.Rows.Clear()

        Try

            ConnectDatabase()

            With sqlcmd
                .Connection = DBConnection
                .CommandType = CommandType.StoredProcedure
                .CommandText = "viewPatBills"
                .Parameters.AddWithValue("@BillStatus", "Complete")
                .Parameters.AddWithValue("@PatientID", PatientRecordScreen.MyPatientID)
                .Parameters.AddWithValue("@AppDateFilter", "")
                .Parameters.AddWithValue("@txtSearch", "")

                myreader = sqlcmd.ExecuteReader
                    
                While myreader.Read()

                    If myreader("AppDate").ToString = "" Then
                        Exit Sub
                    Else

                        Dim AppDate As DateTime = myreader("AppDate").ToString

                        Me.datagridPatTransaction.Rows.Add(New Object() {myreader("PaymentID"), AppDate.ToString("MMMM dd, yyyy"), myreader.Item("Procedures"), myreader.Item("TotalAmount"), myreader.Item("Discount"), myreader.Item("TotalAmountPaid"), myreader.Item("AmountPaid"), myreader.Item("DateLastPaid")})
                    End If

                End While

                DatabaseDisconnect()

            End With
        Catch ex As Exception
            DatabaseDisconnect()
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try

    End Sub

    Private Sub PatientTransaction_Load(sender As Object, e As EventArgs) Handles Me.Load

        datagridPatTransaction.RowTemplate.Height = 40
        refreshDataGridPatTransaction()

    End Sub

    Private Sub txtboxSearch_Click(sender As Object, e As EventArgs) Handles txtboxSearch.Click

        If txtboxSearch.Text = "  Search here" Then
            txtboxSearch.Text = ""
        End If



    End Sub

    Private Sub datagridPatTransaction_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles datagridPatTransaction.CellContentClick


        BillingHistory.lblTreatmentDate.Text = datagridPatTransaction.CurrentRow.Cells(1).Value.ToString
        BillingHistory.lblProcedures.Text = datagridPatTransaction.CurrentRow.Cells(2).Value.ToString
        BillingHistory.PaymentID = datagridPatTransaction.CurrentRow.Cells(0).Value.ToString

        HomeScreen.Enabled = False
        BillingHistory.Show()

        'MsgBox(BillingHistory.PaymentID)

    End Sub

    Private Sub datagridPatTransaction_CellMouseMove(sender As Object, e As DataGridViewCellMouseEventArgs) Handles datagridPatTransaction.CellMouseMove

        datagridPatTransaction.ClearSelection()
        If e.RowIndex > -1 Then
            datagridPatTransaction.Rows(e.RowIndex).Selected = True
        End If

    End Sub

    Private Sub dtpickerFilter_ValueChanged(sender As Object, e As EventArgs) Handles dtpickerFilter.ValueChanged

        'MsgBox(dtpickerFilter.Value.ToString("yyyy-MM-dd"))

        Me.datagridPatTransaction.Rows.Clear()

        Try

            ConnectDatabase()

            With sqlcmd
                .Connection = DBConnection
                .CommandType = CommandType.StoredProcedure
                .CommandText = "viewPatBills"
                .Parameters.AddWithValue("@BillStatus", "Complete")
                .Parameters.AddWithValue("@PatientID", PatientRecordScreen.MyPatientID)
                .Parameters.AddWithValue("@AppDateFilter", dtpickerFilter.Value.ToString("yyyy-MM-dd"))
                .Parameters.AddWithValue("@txtSearch", "")

                myreader = sqlcmd.ExecuteReader

                While myreader.Read()

                    If myreader("AppDate").ToString = "" Then
                        Exit Sub
                    Else

                        Dim AppDate As DateTime = myreader("AppDate").ToString

                        Me.datagridPatTransaction.Rows.Add(New Object() {myreader("PaymentID"), AppDate.ToString("MMMM dd, yyyy"), myreader.Item("Procedures"), myreader.Item("TotalAmount"), myreader.Item("Discount"), myreader.Item("TotalAmountPaid"), myreader.Item("AmountPaid"), myreader.Item("DateLastPaid")})
                    End If

                End While

                DatabaseDisconnect()

            End With
        Catch ex As Exception
            DatabaseDisconnect()
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try

    End Sub

    Private Sub btnResetFilter_Click(sender As Object, e As EventArgs) Handles btnResetFilter.Click
        dtpickerFilter.Value = DateTime.Now
        txtboxSearch.Text = "  Search here"
        refreshDataGridPatTransaction()
    End Sub

    Private Sub txtboxSearch_TextChanged(sender As Object, e As EventArgs) Handles txtboxSearch.TextChanged

        Me.datagridPatTransaction.Rows.Clear()

        Try

            ConnectDatabase()

            With sqlcmd
                .Connection = DBConnection
                .CommandType = CommandType.StoredProcedure
                .CommandText = "viewPatBills"
                .Parameters.AddWithValue("@BillStatus", "Complete")
                .Parameters.AddWithValue("@PatientID", PatientRecordScreen.MyPatientID)
                .Parameters.AddWithValue("@AppDateFilter", "")
                .Parameters.AddWithValue("@txtSearch", txtboxSearch.Text)

                myreader = sqlcmd.ExecuteReader

                While myreader.Read()

                    If myreader("AppDate").ToString = "" Then
                        Exit Sub
                    Else

                        Dim AppDate As DateTime = myreader("AppDate").ToString

                        Me.datagridPatTransaction.Rows.Add(New Object() {myreader("PaymentID"), AppDate.ToString("MMMM dd, yyyy"), myreader.Item("Procedures"), myreader.Item("TotalAmount"), myreader.Item("Discount"), myreader.Item("TotalAmountPaid"), myreader.Item("AmountPaid"), myreader.Item("DateLastPaid")})
                    End If

                End While

                DatabaseDisconnect()

            End With
        Catch ex As Exception
            DatabaseDisconnect()
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try


    End Sub

End Class