Public Class Billing

    Public Sub refreshDataGridBilling()

        Me.datagridBillingTrans.Rows.Clear()

        Try

            ConnectDatabase()

            With sqlcmd
                .Connection = DBConnection
                .CommandType = CommandType.StoredProcedure
                .CommandText = "viewPatBills"
                .Parameters.AddWithValue("@BillStatus", "Incomplete")
                .Parameters.AddWithValue("@PatientID", PatientRecordScreen.MyPatientID)
                .Parameters.AddWithValue("@AppDateFilter", "")
                .Parameters.AddWithValue("@txtSearch", "")

                myreader = sqlcmd.ExecuteReader

                While myreader.Read()

                    If myreader("AppDate").ToString = "" Then
                        Exit Sub
                    Else

                        Dim AppDate As DateTime = myreader("AppDate").ToString

                        Me.datagridBillingTrans.Rows.Add(New Object() {myreader("PaymentID"), AppDate.ToString("MMMM dd, yyyy"), myreader.Item("Procedures"), myreader.Item("TotalAmount"), myreader.Item("Discount"), myreader.Item("TotalAmountPaid"), myreader.Item("AmountPaid"), myreader.Item("Balance"), myreader.Item("BillStatus"), myreader.Item("DateLastPaid")})
                    End If

                End While

                DatabaseDisconnect()

            End With
        Catch ex As Exception
            DatabaseDisconnect()
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try



    End Sub
    Private Sub Billing_Load(sender As Object, e As EventArgs) Handles Me.Load
        'cmbboxFilter.Text = "All"
        datagridBillingTrans.RowTemplate.Height = 40
        refreshDataGridBilling()
    End Sub

    Private Sub datagridBilling_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles S.CellContentClick, datagridBillingTrans.CellContentClick


        Dim senderGrid = DirectCast(sender, DataGridView)
        If TypeOf senderGrid.Columns(e.ColumnIndex) Is DataGridViewImageColumn AndAlso
        e.RowIndex >= 0 Then
            If e.ColumnIndex = 10 Then

                'MsgBox(datagridBillingTrans.CurrentRow.Cells(7).Value.ToString)

                If datagridBillingTrans.CurrentRow.Cells(8).Value.ToString = "Incomplete" Then

                    EditBilling.Show()
                    HomeScreen.Enabled = False
                Else
                    MsgBox("Billing Status is already Completed", MsgBoxStyle.Information, "Information")

                End If
                Exit Sub
                'MsgBox("edit")
            End If
        End If

        BillingHistory.lblTreatmentDate.Text = datagridBillingTrans.CurrentRow.Cells(1).Value.ToString
        BillingHistory.lblProcedures.Text = datagridBillingTrans.CurrentRow.Cells(2).Value.ToString
        BillingHistory.PaymentID = datagridBillingTrans.CurrentRow.Cells(0).Value.ToString

        HomeScreen.Enabled = False
        BillingHistory.Show()

        'MsgBox(BillingHistory.PaymentID)

    End Sub


    Private Sub datagridBilling_CellMouseMove(sender As Object, e As DataGridViewCellMouseEventArgs) Handles S.CellMouseMove, datagridBillingTrans.CellMouseMove
        datagridBillingTrans.ClearSelection()
        If e.RowIndex > -1 Then
            datagridBillingTrans.Rows(e.RowIndex).Selected = True
        End If
    End Sub

End Class