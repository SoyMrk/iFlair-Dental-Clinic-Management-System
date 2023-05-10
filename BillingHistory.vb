Imports System.ComponentModel

Public Class BillingHistory

    Public Shared PaymentID As String
    Private Sub BillingHistory_Load(sender As Object, e As EventArgs) Handles Me.Load

        'MsgBox(PaymentID)

        Try
            ConnectDatabase()
            Try

                With sqlcmd
                    .Connection = DBConnection
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "viewPatBillHist"
                    .Parameters.AddWithValue("@PayID", PaymentID)

                    myreader = .ExecuteReader

                    While myreader.Read
                        Me.datagridBillingHistory.Rows.Add(New Object() {myreader.Item("DatePaid"), myreader.Item("Gross"), myreader.Item("Balance"), myreader.Item("AmountPaid"), myreader.Item("NewBalance")})
                    End While
                End With

            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                DatabaseDisconnect()
            End Try

            DatabaseDisconnect()

        Catch ex As Exception

            DatabaseDisconnect()

        End Try

    End Sub

    Private Sub BillingHistory_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        HomeScreen.Enabled = True
    End Sub

    Private Sub datagridBillingHistory_CellMouseMove(sender As Object, e As DataGridViewCellMouseEventArgs) Handles datagridBillingHistory.CellMouseMove
        datagridBillingHistory.ClearSelection()
        If e.RowIndex > -1 Then
            datagridBillingHistory.Rows(e.RowIndex).Selected = True
        End If
    End Sub
End Class