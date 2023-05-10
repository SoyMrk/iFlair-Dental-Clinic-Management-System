Public Class TreatmentForm
    'BUTTON COMMENTED/DELETED
    Public Sub refreshdataGridTreatForm()


        Me.dataviewTreatment.Rows.Clear()
        Try
            ConnectDatabase()
            With sqlcmd
                .Connection = DBConnection
                .CommandType = CommandType.StoredProcedure
                .CommandText = "viewPatProdHist"
                .Parameters.AddWithValue("@AppDateFilter", cmbboxFilter.Text)
                .Parameters.AddWithValue("@PatientID", PatientRecordScreen.MyPatientID)
                .Parameters.AddWithValue("@SearchTxt", "")
                'MsgBox("Successful", MsgBoxStyle.Information, "Information")

                myreader = sqlcmd.ExecuteReader

                While myreader.Read()


                    If myreader("AppDate").ToString = "" Then
                        Exit Sub
                    Else


                        Dim AppDate As DateTime = myreader("AppDate").ToString

                        Me.dataviewTreatment.Rows.Add(New Object() {AppDate.ToString("MMMM dd, yyyy"), myreader.Item("Procedures"), myreader.Item("TotalAmount"), myreader.Item("TotalAmountPaid"), myreader.Item("Balance"), myreader.Item("DateLastPaid")})


                    End If

                End While
            End With
            DatabaseDisconnect()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            DatabaseDisconnect()
        End Try





    End Sub

    Private Sub txtboxSearch_TextChanged(sender As Object, e As EventArgs) Handles txtboxSearch.TextChanged

        Me.dataviewTreatment.Rows.Clear()

        ConnectDatabase()
        With sqlcmd
            Try
                .Connection = DBConnection
                .CommandType = CommandType.StoredProcedure
                .CommandText = "viewPatProdHist"
                .Parameters.AddWithValue("@AppDateFilter", cmbboxFilter.Text)
                .Parameters.AddWithValue("@PatientID", PatientRecordScreen.MyPatientID)
                .Parameters.AddWithValue("@SearchTxt", txtboxSearch.Text)
                'MsgBox("Successful", MsgBoxStyle.Information, "Information")

                myreader = sqlcmd.ExecuteReader


                While myreader.Read()


                    If myreader("AppDate").ToString = "" Then
                        Exit Sub
                    Else


                        Dim AppDate As DateTime = myreader("AppDate").ToString

                        Me.dataviewTreatment.Rows.Add(New Object() {AppDate.ToString("MMMM dd, yyyy"), myreader.Item("Procedures"), myreader.Item("TotalAmount"), myreader.Item("TotalAmountPaid"), myreader.Item("Balance"), myreader.Item("DateLastPaid")})


                    End If

                End While
                DatabaseDisconnect()

            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
                DatabaseDisconnect()
            End Try
        End With


    End Sub

    Private Sub TreatmentForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        dataviewTreatment.RowTemplate.Height = 40
        cmbboxFilter.Text = "All"
        refreshdataGridTreatForm()

    End Sub

    Private Sub txtboxSearch_Click(sender As Object, e As EventArgs) Handles txtboxSearch.Click
        txtboxSearch.Text = ""
    End Sub

    Private Sub dataviewTreatment_CellMouseMove(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dataviewTreatment.CellMouseMove
        dataviewTreatment.ClearSelection()
        If e.RowIndex > -1 Then
            dataviewTreatment.Rows(e.RowIndex).Selected = True
        End If
    End Sub

    Private Sub cmbboxFilter_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmbboxFilter.SelectionChangeCommitted

        Me.dataviewTreatment.Rows.Clear()
        Try
            ConnectDatabase()
            With sqlcmd
                .Connection = DBConnection
                .CommandType = CommandType.StoredProcedure
                .CommandText = "viewPatProdHist"
                .Parameters.AddWithValue("@AppDateFilter", cmbboxFilter.Text)
                .Parameters.AddWithValue("@PatientID", PatientRecordScreen.MyPatientID)
                .Parameters.AddWithValue("@SearchTxt", "")
                'MsgBox("Successful", MsgBoxStyle.Information, "Information")

                myreader = sqlcmd.ExecuteReader


                While myreader.Read()


                    If myreader("AppDate").ToString = "" Then
                        Exit Sub
                    Else


                        Dim AppDate As DateTime = myreader("AppDate").ToString

                        Me.dataviewTreatment.Rows.Add(New Object() {AppDate.ToString("MMMM dd, yyyy"), myreader.Item("Procedures"), myreader.Item("TotalAmount"), myreader.Item("TotalAmountPaid"), myreader.Item("Balance"), myreader.Item("DateLastPaid")})


                    End If

                End While
            End With
            DatabaseDisconnect()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            DatabaseDisconnect()
        End Try

    End Sub


End Class