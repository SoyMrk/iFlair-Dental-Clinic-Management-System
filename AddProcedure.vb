Imports System.ComponentModel

Public Class AddProcedure
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        ConnectDatabase()

        With sqlcmd

            Try
                .Connection = DBConnection
                .CommandType = CommandType.StoredProcedure
                .CommandText = "AppProcedures"
                .Parameters.AddWithValue("@QType", "Insert")
                .Parameters.AddWithValue("@ProdID", txtboxProcedureNumber.Text)
                .Parameters.AddWithValue("@ProdName", txtboxPrcedureName.Text)
                .Parameters.AddWithValue("@ProdDescription", txtboxDescription.Text)
                .Parameters.AddWithValue("@ProdPrice", txtboxPrice.Text)
                .Parameters.AddWithValue("@ProdCategory", cmbboxCategory.Text)

                .ExecuteNonQuery()
                'MsgBox("Procedure Registered", MsgBoxStyle.Information, "Information")

            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            End Try

            DatabaseDisconnect()

        End With

        Me.Close()

        HomeScreen.Enabled = True

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click

        Me.Close()

        HomeScreen.Enabled = True

    End Sub

    Private Sub AddProcedure_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ConnectDatabase()
        With sqlcmd
            Try
                .Connection = DBConnection
                .CommandType = CommandType.StoredProcedure
                .CommandText = "getProdCount"
                'MsgBox("Successful", MsgBoxStyle.Information, "Information")

                myreader = sqlcmd.ExecuteReader

                If myreader.Read() Then

                    txtboxProcedureNumber.Text = "PROD" & myreader("ProdCount") + 1

                End If

            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            End Try
        End With

        DatabaseDisconnect()

    End Sub

    Private Sub AddProcedure_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        HomeScreen.Enabled = True

        ClearHomeMainPanel()

        With Procedure
            .WindowState = FormWindowState.Maximized
            .Dock = DockStyle.Fill And DockStyle.Bottom
            .AutoSize = True
            .TopLevel = False
            HomeScreen.pnlHomeScreen.Controls.Add(Procedure)
            .BringToFront()
            .Show()
        End With

    End Sub

    Private Sub Input_Validating(sender As Object, e As CancelEventArgs) Handles txtboxPrice.Validating, txtboxPrcedureName.Validating, txtboxDescription.Validating

        Dim txtbox As TextBox = DirectCast(sender, TextBox)

        If (txtbox.Text.Length) > 0 Then
            ErrorProvider1.SetError(txtbox, String.Empty)
        Else
            ErrorProvider1.SetError(txtbox, "This field is required!")
            txtbox.Select()
        End If

    End Sub
End Class