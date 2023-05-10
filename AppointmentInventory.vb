Imports System.ComponentModel

Public Class AppointmentInventory
    Private Sub AppointmentInventory_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        InventoryList.fromAppointment = False
        HomeScreen.Enabled = True
    End Sub

    Private Sub btnDone_Click(sender As Object, e As EventArgs) Handles btnDone.Click
        InventoryList.fromAppointment = False
        Me.Close()
    End Sub

    Public Sub loadAppointmentInventoryList()

        Me.dtviewAppointmentInventoryList.Rows.Clear()
        dtviewAppointmentInventoryList.RowTemplate.Height = 40

        ConnectDatabase()
        With sqlcmd
            Try
                .Connection = DBConnection
                .CommandType = CommandType.StoredProcedure
                .CommandText = "viewAppointmentInventories"
                .Parameters.AddWithValue("@InvAppID", PatientAppointmentHistory.AppointmentID)
                'MsgBox("Successful", MsgBoxStyle.Information, "Information")

                myreader = sqlcmd.ExecuteReader

                While myreader.Read()
                    Me.dtviewAppointmentInventoryList.Rows.Add(New Object() {myreader.Item("SupplyName"), myreader.Item("Remarks")})
                End While

                DatabaseDisconnect()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
                DatabaseDisconnect()
            End Try
        End With
    End Sub

    Public Sub loadInventoryList()
        Me.dtgridViewInventoryList.Rows.Clear()
        dtgridViewInventoryList.RowTemplate.Height = 40

        ConnectDatabase()
        With sqlcmd
            Try
                .Connection = DBConnection
                .CommandType = CommandType.StoredProcedure
                .CommandText = "viewInventoryList"
                .Parameters.AddWithValue("@QType", "All")
                'MsgBox("Successful", MsgBoxStyle.Information, "Information")

                myreader = sqlcmd.ExecuteReader

                While myreader.Read()
                    Me.dtgridViewInventoryList.Rows.Add(New Object() {myreader.Item("SupplyID"), myreader.Item("SupplyName"), myreader.Item("RemainingStock"), myreader.Item("Unit")})
                End While

                DatabaseDisconnect()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
                DatabaseDisconnect()
            End Try
        End With
    End Sub

    Private Sub AppointmentInventory_Load(sender As Object, e As EventArgs) Handles Me.Load
        loadInventoryList()
        loadAppointmentInventoryList()
    End Sub

    Private Sub txtboxSearch_TextChanged(sender As Object, e As EventArgs) Handles txtboxSearch.TextChanged
        If txtboxSearch.Text = "Search Inventory" Then
            Exit Sub
        End If

        Me.dtgridViewInventoryList.Rows.Clear()
        ConnectDatabase()
        With sqlcmd
            Try
                .Connection = DBConnection
                .CommandType = CommandType.StoredProcedure
                .CommandText = "searchInventory"
                .Parameters.AddWithValue("@txtSearch", txtboxSearch.Text)
                'MsgBox("Successful", MsgBoxStyle.Information, "Information")

                myreader = sqlcmd.ExecuteReader

                While myreader.Read()
                    Me.dtgridViewInventoryList.Rows.Add(New Object() {myreader.Item("SupplyID"), myreader.Item("SupplyName"), myreader.Item("RemainingStock"), myreader.Item("Unit"), myreader.Item("Status"), myreader.Item("DateLastUpdated")})
                End While

            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            End Try
        End With
        DatabaseDisconnect()
    End Sub

    Private Sub txtboxSearch_Leave(sender As Object, e As EventArgs) Handles txtboxSearch.Leave
        txtboxSearch.Text = "Search Inventory"
    End Sub

    Private Sub txtboxSearch_Click(sender As Object, e As EventArgs) Handles txtboxSearch.Click
        txtboxSearch.Text = ""
    End Sub

    Private Sub dtgridViewInventoryList_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgridViewInventoryList.CellContentClick
        If e.RowIndex < 0 Then
            Exit Sub
        End If

        InventoryList.InventorySupplyID = dtgridViewInventoryList.CurrentRow.Cells(0).Value.ToString
        InventoryList.fromAppointment = True


        EditInventory.Show()
    End Sub

    Private Sub dtgridViewInventoryList_CellMouseMove(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dtgridViewInventoryList.CellMouseMove
        dtgridViewInventoryList.ClearSelection()
        If e.RowIndex > -1 Then
            dtgridViewInventoryList.Rows(e.RowIndex).Selected = True
        End If
    End Sub

    Private Sub dtviewAppointmentInventoryList_SelectionChanged(sender As Object, e As EventArgs) Handles dtviewAppointmentInventoryList.SelectionChanged
        dtviewAppointmentInventoryList.ClearSelection()
    End Sub

End Class