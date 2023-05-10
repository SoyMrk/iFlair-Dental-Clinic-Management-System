Public Class UserInformation

    Public Sub refreshDataGridUserInfo()

        Me.dataviewUserInformation.Rows.Clear()
        dataviewUserInformation.RowTemplate.Height = 40

        ConnectDatabase()

        With sqlcmd

            Try
                .Connection = DBConnection
                .CommandType = CommandType.StoredProcedure
                .CommandText = "viewUserInformation"
                'MsgBox("Successful", MsgBoxStyle.Information, "Information")

                myreader = sqlcmd.ExecuteReader

                While myreader.Read()

                    Me.dataviewUserInformation.Rows.Add(New Object() {myreader.Item("EmpFirstName") + " " + myreader.Item("EmpLastName"), myreader.Item("UserName"), myreader.Item("UserType")})

                End While

            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
                DatabaseDisconnect()
            End Try

        End With

        DatabaseDisconnect()

    End Sub

    Private Sub btnAddNewUser_Click(sender As Object, e As EventArgs) Handles btnAddNewUser.Click

        HomeScreen.Enabled = False

        AddNewUserAccount.Show()

    End Sub

    Private Sub UserInformation_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        refreshDataGridUserInfo()

    End Sub

    Private Sub txtboxSearch_TextChanged(sender As Object, e As EventArgs) Handles txtboxSearch.TextChanged

        Me.dataviewUserInformation.Rows.Clear()

        ConnectDatabase()

        With sqlcmd
            .Connection = DBConnection
            .CommandType = CommandType.StoredProcedure
            .CommandText = "searchUserInformation"
            .Parameters.AddWithValue("@txtSearch", txtboxSearch.Text)
        End With

        myreader = sqlcmd.ExecuteReader
        While myreader.Read()
            Me.dataviewUserInformation.Rows.Add(New Object() {myreader.Item("EmpFirstName") + " " + myreader.Item("EmpLastName"), myreader.Item("UserName"), myreader.Item("UserType")})
        End While
        DatabaseDisconnect()

    End Sub

    Private Sub txtboxSearch_Click(sender As Object, e As EventArgs) Handles txtboxSearch.Click

        txtboxSearch.Text = ""

    End Sub

    Private Sub dataviewUserInformation_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles dataviewUserInformation.RowsAdded

        txtboxFoundUser.Text = Me.dataviewUserInformation.Rows.Count.ToString + " user/s found"

    End Sub

    Private Sub dataviewUserInformation_CellMouseMove(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dataviewUserInformation.CellMouseMove

        dataviewUserInformation.ClearSelection()
        If e.RowIndex > -1 Then
            dataviewUserInformation.Rows(e.RowIndex).Selected = True
        End If

    End Sub

    Private Sub dataviewUserInformation_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataviewUserInformation.CellContentClick

        If e.RowIndex < 0 Then
            Exit Sub
        End If
        ViewUserInformation.UName = dataviewUserInformation.CurrentRow.Cells(1).Value.ToString


        HomeScreen.Enabled = False
        ViewUserInformation.Show()

    End Sub

End Class