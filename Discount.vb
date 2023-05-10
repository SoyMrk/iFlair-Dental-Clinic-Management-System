Imports System.ComponentModel

Public Class Discount
    Private Sub Discount_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            ConnectDatabase()
            Dim Discounts As New DataTable
            With sqlcmd
                .Connection = DBConnection
                .CommandType = CommandType.StoredProcedure
                .CommandText = "Discounts"
                .Parameters.AddWithValue("@QType", "View")
                .Parameters.AddWithValue("@DiscName", "")
                .Parameters.AddWithValue("@DiscPercentage", DBNull.Value)
                .Parameters.AddWithValue("@NewDiscName", "")
            End With

            myAdapter.SelectCommand = sqlcmd
            myAdapter.Fill(Discounts)

            If Discounts.Rows.Count <> 0 Then

                cmbboxDiscount.DataSource = Discounts
                cmbboxDiscount.ValueMember = "DiscountName"
                cmbboxDiscount.DisplayMember = "DiscountName"

            End If

            DatabaseDisconnect()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            DatabaseDisconnect()
        End Try

        LoadCmbBox()

    End Sub

    Private Sub Discount_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        HomeScreen.Enabled = True
    End Sub

    Private Sub cmbboxDiscount_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmbboxDiscount.SelectionChangeCommitted

        LoadCmbBox()

    End Sub

    Public Sub LoadCmbBox()

        Try
            ConnectDatabase()
            Dim Discounts As New DataTable
            With sqlcmd
                .Connection = DBConnection
                .CommandType = CommandType.StoredProcedure
                .CommandText = "Discounts"
                .Parameters.AddWithValue("@QType", "Get")
                .Parameters.AddWithValue("@DiscName", cmbboxDiscount.Text)
                .Parameters.AddWithValue("@DiscPercentage", DBNull.Value)
                .Parameters.AddWithValue("@NewDiscName", "")
            End With

            myreader = sqlcmd.ExecuteReader

            If myreader.Read Then
                txtboxPercent.Text = myreader("DiscountLessPercentage")
            End If

            DatabaseDisconnect()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            DatabaseDisconnect()
        End Try

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnEditDiscount_Click(sender As Object, e As EventArgs) Handles btnEditDiscount.Click
        EditDiscount.DiscName = cmbboxDiscount.Text
        EditDiscount.DiscLessPercentage = txtboxPercent.Text
        Me.Close()
        HomeScreen.Enabled = False
        EditDiscount.Show()
    End Sub

    Private Sub btnAddDiscount_Click(sender As Object, e As EventArgs) Handles btnAddDiscount.Click
        Me.Close()
        HomeScreen.Enabled = False
        AddDiscount.Show()
    End Sub

End Class