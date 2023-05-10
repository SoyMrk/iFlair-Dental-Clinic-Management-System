Public Class PrescriptionRecords

    Public Sub refreshDataGridPrescription()

        Me.dataviewPrescription.Rows.Clear()

        Try
            ConnectDatabase()
            With sqlcmd
                .Connection = DBConnection
                .CommandType = CommandType.StoredProcedure
                .CommandText = "viewPatPrescriptions"
                .Parameters.AddWithValue("@PatID", PatientRecordScreen.MyPatientID)
                'MsgBox("Successful", MsgBoxStyle.Information, "Information")

                myreader = sqlcmd.ExecuteReader

                While myreader.Read()

                    Dim DentistName As String = myreader("EmpFirstName") + " " + myreader("EmpMiddleName") + " " + myreader("EmpLastName")
                    Me.dataviewPrescription.Rows.Add(New Object() {DentistName, myreader.Item("PrescriptionName"), myreader.Item("DateCreated")})

                End While

            End With
            DatabaseDisconnect()
        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            DatabaseDisconnect()

        End Try

    End Sub

    Private Sub PrescriptionRecords_Load(sender As Object, e As EventArgs) Handles Me.Load
        dataviewPrescription.RowTemplate.Height = 40
        refreshDataGridPrescription()
    End Sub

End Class