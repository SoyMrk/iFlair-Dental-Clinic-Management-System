Public Class Employee


    Public Shared EmpID As String
    Public Sub refreshDataGridEmp()

        Me.datagridEmployee.Rows.Clear()
        datagridEmployee.RowTemplate.Height = 40

        ConnectDatabase()
        With sqlcmd
            Try
                .Connection = DBConnection
                .CommandType = CommandType.StoredProcedure
                .CommandText = "viewAllEmployee"
                'MsgBox("Successful", MsgBoxStyle.Information, "Information")

                myreader = sqlcmd.ExecuteReader

                While myreader.Read()
                    Dim DateofBirth As DateTime = myreader("DateOfBirth").ToString
                    Me.datagridEmployee.Rows.Add(New Object() {myreader.Item("EmployeeID"), myreader.Item("EmpLastName"), myreader.Item("EmpFirstName"), myreader.Item("EmpMiddleName"), myreader.Item("JobPosition"), myreader.Item("EmpMunicipality") + ", " + myreader.Item("EmpProvince"), DateofBirth.ToString("MMMM dd, yyyy"), myreader.Item("EmpEmail"), myreader.Item("EmpContactNo")})
                End While

            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            End Try
        End With



        DatabaseDisconnect()

    End Sub



    Private Sub Employee_Load(sender As Object, e As EventArgs) Handles Me.Load

        refreshDataGridEmp()

    End Sub

    Private Sub btnAddNewEmployee_Click(sender As Object, e As EventArgs) Handles btnAddNewEmployee.Click
        HomeScreen.Enabled = False
        AddNewEmployee.Show()
    End Sub

    Private Sub datagridEmployee_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles datagridEmployee.RowsAdded

        txtboxFoundEmp.Text = Me.datagridEmployee.Rows.Count.ToString + " employee/s found"


    End Sub

    Private Sub txtboxSearchEmployee_TextChanged(sender As Object, e As EventArgs) Handles txtboxSearchEmployee.TextChanged

        Me.datagridEmployee.Rows.Clear()

        'MsgBox(sqlstr)
        ConnectDatabase()

        With sqlcmd
            .Connection = DBConnection
            .CommandType = CommandType.StoredProcedure
            .CommandText = "searchEmployee"
            .Parameters.AddWithValue("@txtSearch", txtboxSearchEmployee.Text)
        End With

        myreader = sqlcmd.ExecuteReader
        While myreader.Read()
            Dim DateofBirth As DateTime = myreader("DateOfBirth").ToString
            Me.datagridEmployee.Rows.Add(New Object() {myreader.Item("EmployeeID"), myreader.Item("EmpLastName"), myreader.Item("EmpFirstName"), myreader.Item("EmpMiddleName"), myreader.Item("JobPosition"), myreader.Item("EmpMunicipality") + ", " + myreader.Item("EmpProvince"), DateofBirth.ToString("MMMM dd, yyyy"), myreader.Item("EmpEmail"), myreader.Item("EmpContactNo")})
        End While
        DatabaseDisconnect()

    End Sub

    Private Sub txtboxSearchEmployee_Click(sender As Object, e As EventArgs) Handles txtboxSearchEmployee.Click
        txtboxSearchEmployee.Text = ""
    End Sub

    Private Sub datagridEmployee_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles datagridEmployee.CellContentClick
        If e.RowIndex < 0 Then
            Exit Sub
        End If
        EmpID = datagridEmployee.CurrentRow.Cells(0).Value.ToString

        Dim senderGrid = DirectCast(sender, DataGridView)
        If TypeOf senderGrid.Columns(e.ColumnIndex) Is DataGridViewImageColumn AndAlso e.RowIndex >= 0 Then
            If e.ColumnIndex = 9 Then

                HomeScreen.Enabled = False
                EditEmployeeDetails.Show()

                Exit Sub

            ElseIf e.ColumnIndex = 10 Then
                If datagridEmployee.CurrentRow.Cells(4).Value.ToString.Contains("Dentist") Then
                    MessageBox.Show("Cannot Delete Employees with Job Dentist", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End If
                If MessageBox.Show("Delete Employee?" + vbCrLf + "This will also delete the UserAccount and its Userlogs", "Are you sure?", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) = DialogResult.OK Then
                    'MsgBox("Yes")

                    'sqlstr = "DELETE from employee WHERE EmployeeID = '" & EmpID & "'"

                    Try
                        ConnectDatabase()

                        With sqlcmd
                            .Connection = DBConnection
                            .CommandType = CommandType.StoredProcedure
                            .CommandText = "deleteEmployee"
                            .Parameters.AddWithValue("@EmpID", EmpID)
                            .ExecuteNonQuery()
                            'MessageBox.Show("Employee Data Deleted", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End With

                        DatabaseDisconnect()
                    Catch ex As Exception
                        DatabaseDisconnect()
                    End Try

                    refreshDataGridEmp()

                End If

            End If
            Exit Sub
        End If

        HomeScreen.Enabled = False
        ViewEmployeeDetails.Show()

    End Sub

    Private Sub datagridEmployee_CellMouseMove(sender As Object, e As DataGridViewCellMouseEventArgs) Handles datagridEmployee.CellMouseMove

        datagridEmployee.ClearSelection()
        If e.RowIndex > -1 Then
            datagridEmployee.Rows(e.RowIndex).Selected = True
        End If

    End Sub

End Class