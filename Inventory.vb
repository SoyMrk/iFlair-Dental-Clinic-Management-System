Public Class Inventory

    Public Shared SupplyID As String

    Public Sub refreshSupplyDataGrid()

        dataViewSupply.RowTemplate.Height = 40
        Me.dataViewSupply.Rows.Clear()

        Try
            ConnectDatabase()
            With sqlcmd

                .Connection = DBConnection
                .CommandType = CommandType.StoredProcedure
                .CommandText = "viewInventoryList"
                .Parameters.AddWithValue("@QType", "All")
                'MsgBox("Successful", MsgBoxStyle.Information, "Information")

                myreader = sqlcmd.ExecuteReader

                While myreader.Read()

                    Me.dataViewSupply.Rows.Add(New Object() {myreader.Item("SupplyID"), myreader.Item("SupplyName"), myreader.Item("Description"), myreader.Item("RemainingStock"), myreader.Item("Unit")})

                End While

                DatabaseDisconnect()

            End With
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            DatabaseDisconnect()
        End Try


    End Sub



    Private Sub Inventory_Load(sender As Object, e As EventArgs) Handles Me.Load

        refreshSupplyDataGrid()

    End Sub


    Private Sub dataViewSupply_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles dataViewSupply.RowsAdded

        txtboxSupplyFound.Text = dataViewSupply.Rows.Count.ToString + " supply found"

    End Sub



    Private Sub dataViewSupply_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataViewSupply.CellContentClick
        If e.RowIndex < 0 Then
            Exit Sub
        End If
        SupplyID = dataViewSupply.CurrentRow.Cells(0).Value.ToString


        Dim senderGrid = DirectCast(sender, DataGridView)
        If TypeOf senderGrid.Columns(e.ColumnIndex) Is DataGridViewImageColumn AndAlso
        e.RowIndex >= 0 Then
            If e.ColumnIndex = 5 Then

                HomeScreen.Enabled = False

                EditSupply.Show()
                'MsgBox("edit")

                Exit Sub

            ElseIf e.ColumnIndex = 6 Then

                If MessageBox.Show(" Are you sure you want to delete?", "Are you sure?", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                    'MsgBox("Yes")
                    Try
                        ConnectDatabase()

                        With sqlcmd
                            .Connection = DBConnection
                            .CommandType = CommandType.StoredProcedure
                            .CommandText = "Supply"
                            .Parameters.AddWithValue("@QType", "Delete")
                            .Parameters.AddWithValue("@SuppID", SupplyID)
                            .Parameters.AddWithValue("@suppName", "")
                            .Parameters.AddWithValue("@supplyDescription", "")
                            .Parameters.AddWithValue("@suppUnit", "")

                            .ExecuteNonQuery()
                            'MessageBox.Show("Supply Successfully Deleted", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End With

                        DatabaseDisconnect()
                        refreshSupplyDataGrid()

                    Catch ex As Exception
                        MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
                        DatabaseDisconnect()

                    End Try
                End If

                Exit Sub

            End If
        End If

        HomeScreen.Enabled = False
        ViewSupply.Show()

    End Sub

    Private Sub btnAddSupply_Click(sender As Object, e As EventArgs) Handles btnAddSupply.Click

        HomeScreen.Enabled = False

        AddNewSupply.Show()


    End Sub

    Private Sub txtboxSearch_TextChanged(sender As Object, e As EventArgs) Handles txtboxSearch.TextChanged

        Me.dataViewSupply.Rows.Clear()

        ConnectDatabase()

        With sqlcmd
            .Connection = DBConnection
            .CommandType = CommandType.StoredProcedure
            .CommandText = "searchSupply"
            .Parameters.AddWithValue("@txtSearch", txtboxSearch.Text)
        End With

        myreader = sqlcmd.ExecuteReader
        While myreader.Read()
            Me.dataViewSupply.Rows.Add(New Object() {myreader.Item("SupplyID"), myreader.Item("SupplyName"), myreader.Item("Description")})
        End While
        DatabaseDisconnect()

    End Sub

    Private Sub txtboxSearch_Click(sender As Object, e As EventArgs) Handles txtboxSearch.Click

        txtboxSearch.Text = ""

    End Sub

    Private Sub dataViewSupply_CellMouseMove(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dataViewSupply.CellMouseMove

        dataViewSupply.ClearSelection()
        If e.RowIndex > -1 Then
            dataViewSupply.Rows(e.RowIndex).Selected = True
        End If


    End Sub

End Class