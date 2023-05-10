Imports System.Security.Cryptography.X509Certificates

Public Class PatientMainScreen

    Public PatGridIndex As Integer

    Private Sub btnAddNewPatient_Click(sender As Object, e As EventArgs) Handles btnAddNewPatient.Click
        HomeScreen.Enabled = False
        AddNewPatient.Show()
    End Sub

    Public Sub RefreshPatientdataGrid()

        Me.datagridPatient.Rows.Clear()
        datagridPatient.RowTemplate.Height = 40

        ConnectDatabase()

        With sqlcmd

            Try
                .Connection = DBConnection
                .CommandType = CommandType.StoredProcedure
                .CommandText = "viewAllPatient"
                'MsgBox("Successful", MsgBoxStyle.Information, "Information")

                myreader = sqlcmd.ExecuteReader

                While myreader.Read()

                    Me.datagridPatient.Rows.Add(New Object() {myreader.Item("PatientID"), myreader.Item("LastName"), myreader.Item("FirstName"), myreader.Item("MiddleName"), myreader.Item("Barangay") + ", " + myreader.Item("Municipality") + ", " + myreader.Item("Province"), myreader.GetDateTime("DateofBirth").ToString("MM/dd/yyyy"), myreader.Item("Age"), myreader.Item("Gender")})

                End While

                DatabaseDisconnect()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
                DatabaseDisconnect()
            End Try

        End With


    End Sub

    Private Sub PatientMainScreen_Load(sender As Object, e As EventArgs) Handles Me.Load

        RefreshPatientdataGrid()

    End Sub


    'DISABLING DATAGRID SELECTION
    'Private Sub datagridPatient_SelectionChanged(sender As Object, e As EventArgs) Handles datagridPatient.SelectionChanged

    '    datagridPatient.ClearSelection()

    'End Sub

    Private Sub datagridPatient_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles datagridPatient.CellContentClick
        If e.RowIndex < 0 Then
            Exit Sub
        End If
        PatientRecordScreen.MyPatientID = datagridPatient.CurrentRow.Cells(0).Value.ToString

        'Dim senderGrid = DirectCast(sender, DataGridView)
        'If TypeOf senderGrid.Columns(e.ColumnIndex) Is DataGridViewImageColumn AndAlso e.RowIndex >= 0 Then
        '    If e.ColumnIndex = 9 Then
        '        MsgBox("clicked",)
        '    End If
        '    Exit Sub
        'End If

        ClearHomeMainPanel()

        With PatientRecordScreen
            .WindowState = FormWindowState.Maximized
            .Dock = DockStyle.Fill And DockStyle.Bottom
            .AutoSize = True
            .TopLevel = False
            HomeScreen.pnlHomeScreen.Controls.Add(PatientRecordScreen)
            .BringToFront()
            .Show()
        End With

    End Sub

    Private Sub txtboxSearchPatient_TextChanged(sender As Object, e As EventArgs) Handles txtboxSearchPatient.TextChanged

        Me.datagridPatient.Rows.Clear()


        Try
            ConnectDatabase()
            With sqlcmd
                .Connection = DBConnection
                .CommandType = CommandType.StoredProcedure
                .CommandText = "searchPatient"
                .Parameters.AddWithValue("@txtSearch", txtboxSearchPatient.Text)
            End With

            myreader = sqlcmd.ExecuteReader
            While myreader.Read()
                Me.datagridPatient.Rows.Add(New Object() {myreader.Item("PatientID"), myreader.Item("LastName"), myreader.Item("FirstName"), myreader.Item("MiddleName"), myreader.Item("Barangay") + ", " + myreader.Item("Municipality") + ", " + myreader.Item("Province"), myreader.GetDateTime("DateofBirth").ToString("MM/dd/yyyy"), myreader.Item("Age"), myreader.Item("Gender")})
            End While
            DatabaseDisconnect()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            DatabaseDisconnect()
        End Try

    End Sub



    Private Sub datagridPatient_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles datagridPatient.RowsAdded
        txtboxPatientFound.Text = Me.datagridPatient.Rows.Count.ToString + " patient/s found"
    End Sub

    Private Sub txtboxSearchPatient_Click(sender As Object, e As EventArgs) Handles txtboxSearchPatient.Click
        txtboxSearchPatient.Text = ""
    End Sub

    Private Sub PatientMainScreen_EnabledChanged(sender As Object, e As EventArgs) Handles Me.EnabledChanged
        'btnRefresh_Click(sender, e)
    End Sub

    Private Sub datagridPatient_CellMouseMove(sender As Object, e As DataGridViewCellMouseEventArgs) Handles datagridPatient.CellMouseMove
        datagridPatient.ClearSelection()
        If e.RowIndex > -1 Then
            datagridPatient.Rows(e.RowIndex).Selected = True
        End If
    End Sub

End Class