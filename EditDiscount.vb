Imports System.ComponentModel

Public Class EditDiscount
    Public DiscName As String
    Public DiscLessPercentage As String

    Private Sub EditDiscount_Load(sender As Object, e As EventArgs) Handles Me.Load
        txtboxNewDiscountName.Text = DiscName
        txtboxDiscountName.Text = DiscName
        txtboxPercent.Text = DiscLessPercentage
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub EditDiscount_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Discount.Show()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        If txtboxNewDiscountName.Text = "" Or txtboxPercent.Text = "" Then
            MessageBox.Show("Please fill all required fields", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        Try
            ConnectDatabase()
            Dim Discounts As New DataTable
            With sqlcmd
                .Connection = DBConnection
                .CommandType = CommandType.StoredProcedure
                .CommandText = "Discounts"
                .Parameters.AddWithValue("@QType", "Edit")
                .Parameters.AddWithValue("@NewDiscName", txtboxNewDiscountName.Text)
                .Parameters.AddWithValue("@DiscPercentage", txtboxPercent.Text)
                .Parameters.AddWithValue("@DiscName", txtboxDiscountName.Text)

                .ExecuteNonQuery()
            End With

            'MessageBox.Show("Discount Updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

            DatabaseDisconnect()
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            DatabaseDisconnect()
        End Try
    End Sub

    Private Sub txtboxPercent_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtboxPercent.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
            'MsgBox("Numeric Input Only")
        End If
    End Sub

End Class