Public Class Procedure
    Private Sub btnAddNewProcedure_Click(sender As Object, e As EventArgs) Handles btnAddNewProcedure.Click

        HomeScreen.Enabled = False

        AddProcedure.Show()

    End Sub

    Public Sub refreshProdDataGrid()

        Me.dataGridProcedure.Rows.Clear()

        ConnectDatabase()
        With sqlcmd
            Try
                .Connection = DBConnection
                .CommandType = CommandType.StoredProcedure
                .CommandText = "AppProcedures"
                .Parameters.AddWithValue("@QType", "View")
                .Parameters.AddWithValue("@ProdID", "")
                .Parameters.AddWithValue("@ProdName", "")
                .Parameters.AddWithValue("@ProdDescription", "")
                .Parameters.AddWithValue("@ProdPrice", DBNull.Value)
                .Parameters.AddWithValue("@ProdCategory", "")
                'MsgBox("Successful", MsgBoxStyle.Information, "Information")

                myreader = sqlcmd.ExecuteReader

                While myreader.Read()
                    Me.dataGridProcedure.Rows.Add(New Object() {myreader.Item("ProcedureID"), myreader.Item("ProcedureName"), myreader.Item("Price"), myreader.Item("Description"), myreader.Item("Category")})
                End While
                DatabaseDisconnect()

            Catch ex As Exception
                DatabaseDisconnect()
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            End Try
        End With




    End Sub


    Private Sub Procedure_Load(sender As Object, e As EventArgs) Handles Me.Load

        dataGridProcedure.RowTemplate.Height = 40
        refreshProdDataGrid()

    End Sub

    Private Sub dataGridProcedure_SelectionChanged(sender As Object, e As EventArgs) Handles dataGridProcedure.SelectionChanged
        dataGridProcedure.ClearSelection()
    End Sub

    Private Sub dataGridProcedure_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataGridProcedure.CellContentClick

        EditProcedure.ProcedureNo = dataGridProcedure.CurrentRow.Cells(0).Value.ToString


        Dim senderGrid = DirectCast(sender, DataGridView)
        If TypeOf senderGrid.Columns(e.ColumnIndex) Is DataGridViewImageColumn AndAlso
        e.RowIndex >= 0 Then
            If e.ColumnIndex = 5 Then

                EditProcedure.Show()
                HomeScreen.Enabled = False



            ElseIf e.ColumnIndex = 6 Then
                MsgBox("delete")


            End If
        End If
    End Sub

    Private Sub dataGridProcedure_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles dataGridProcedure.RowsAdded

        txtboxProcFound.Text = dataGridProcedure.Rows.Count.ToString + " Procedure/s found"

    End Sub

    Private Sub txtboxSearch_TextChanged(sender As Object, e As EventArgs) Handles txtboxSearch.TextChanged

        Me.dataGridProcedure.Rows.Clear()

        ConnectDatabase()
        With sqlcmd
            Try
                .Connection = DBConnection
                .CommandType = CommandType.StoredProcedure
                .CommandText = "searchAppProcedures"
                .Parameters.AddWithValue("@txtSearch", txtboxSearch.Text)
                'MsgBox("Successful", MsgBoxStyle.Information, "Information")

                myreader = sqlcmd.ExecuteReader

                While myreader.Read()
                    Me.dataGridProcedure.Rows.Add(New Object() {myreader.Item("ProcedureID"), myreader.Item("ProcedureName"), myreader.Item("Price"), myreader.Item("Description"), myreader.Item("Category")})
                End While

            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            End Try
        End With



        DatabaseDisconnect()

    End Sub

    Private Sub txtboxSearch_Click(sender As Object, e As EventArgs) Handles txtboxSearch.Click
        txtboxSearch.Text = ""
    End Sub

    Private Sub dataGridProcedure_CellMouseMove(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dataGridProcedure.CellMouseMove

        dataGridProcedure.ClearSelection()
        If e.RowIndex > -1 Then
            dataGridProcedure.Rows(e.RowIndex).Selected = True
        End If

    End Sub
End Class