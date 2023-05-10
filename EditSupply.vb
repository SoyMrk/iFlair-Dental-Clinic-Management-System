Imports System.ComponentModel
Imports MySql.Data.MySqlClient

Public Class EditSupply
    Private Sub EditSupply_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'sqlstr = "SELECT * FROM supply WHERE SupplyID = '" & Inventory.SupplyID & "'"

        ConnectDatabase()

        With sqlcmd

            Try
                .Connection = DBConnection
                .CommandType = CommandType.StoredProcedure
                .CommandText = "Supply"
                .Parameters.AddWithValue("@QType", "Get")
                .Parameters.AddWithValue("@SuppID", Inventory.SupplyID)
                .Parameters.AddWithValue("@suppName", "")
                .Parameters.AddWithValue("@supplyDescription", "")
                .Parameters.AddWithValue("@suppUnit", "")
                'MsgBox("Successful", MsgBoxStyle.Information, "Information")

                myreader = sqlcmd.ExecuteReader

                While myreader.Read()

                    txtboxSupplyNo.Text = myreader("SupplyID")
                    txtboxSupplyName.Text = myreader("SupplyName")
                    txtboxDescription.Text = myreader("Description")
                    txtboxUnit.Text = myreader("Unit")

                End While

            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            End Try

        End With

        DatabaseDisconnect()




    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click

        HomeScreen.Enabled = True

        Me.Close()


    End Sub

    Private Sub EditSupply_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing

        HomeScreen.Enabled = True

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        ConnectDatabase()

        With sqlcmd

            Try
                .Connection = DBConnection
                .CommandType = CommandType.StoredProcedure
                .CommandText = "Supply"
                .Parameters.AddWithValue("@QType", "Edit")
                .Parameters.AddWithValue("@SuppID", Inventory.SupplyID)
                .Parameters.AddWithValue("@suppName", txtboxSupplyName.Text)
                .Parameters.AddWithValue("@supplyDescription", txtboxDescription.Text)
                .Parameters.AddWithValue("@suppUnit", txtboxUnit.Text)
                .ExecuteNonQuery()
                'MsgBox("Supply Updated", MsgBoxStyle.Information, "Information")

            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            End Try

            DatabaseDisconnect()

        End With

        Me.Close()

        HomeScreen.Enabled = True

        Inventory.refreshSupplyDataGrid()

    End Sub

End Class