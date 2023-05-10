Imports System.ComponentModel

Public Class ViewSupply
    Private Sub ViewSupply_Load(sender As Object, e As EventArgs) Handles Me.Load

        Try
            ConnectDatabase()

            With sqlcmd
                .Connection = DBConnection
                .CommandType = CommandType.StoredProcedure
                .CommandText = "Supply"
                .Parameters.AddWithValue("@QType", "Get")
                .Parameters.AddWithValue("@SuppID", Inventory.SupplyID)
                .Parameters.AddWithValue("@suppName", "")
                .Parameters.AddWithValue("@supplyDescription", "")
                .Parameters.AddWithValue("@suppUnit", "")

                myreader = .ExecuteReader

                If myreader.Read Then

                    txtboxSupplyNo.Text = myreader("SupplyID")
                    txtboxSupplyName.Text = myreader("SupplyName")
                    txtboxDescription.Text = myreader("Description")
                    txtboxDateCreated.Text = myreader("DateCreated")

                End If

            End With

            DatabaseDisconnect()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            DatabaseDisconnect()
        End Try

    End Sub

    Private Sub ViewSupply_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        HomeScreen.Enabled = True
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub ToolTip1_Popup(sender As Object, e As PopupEventArgs) Handles ToolTip1.Popup

    End Sub
End Class