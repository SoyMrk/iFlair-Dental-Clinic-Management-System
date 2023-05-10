Imports System.ComponentModel

Public Class EditProcedure

    Public Shared ProcedureNo As String


    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
        HomeScreen.Enabled = True
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        If txtboxPrcedureName.Text = "" Or txtboxDescription.Text = "" Or txtboxPrice.Text = "" Then
            MessageBox.Show("Please fill are required fields", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        If cmbboxCategory.Text = "" Then
            MessageBox.Show("Please choose a procedure category", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            cmbboxCategory.Select()
            Exit Sub
        End If

        ConnectDatabase()

        With sqlcmd

            Try
                .Connection = DBConnection
                .CommandType = CommandType.StoredProcedure
                .CommandText = "AppProcedures"
                .Parameters.AddWithValue("@QType", "Edit")
                .Parameters.AddWithValue("@ProdID", txtboxProcedureNumber.Text)
                .Parameters.AddWithValue("@ProdName", txtboxPrcedureName.Text)
                .Parameters.AddWithValue("@ProdDescription", txtboxDescription.Text)
                .Parameters.AddWithValue("@ProdPrice", txtboxPrice.Text)
                .Parameters.AddWithValue("@ProdCategory", cmbboxCategory.Text)

                .ExecuteNonQuery()
                'MsgBox("Procedure Updated", MsgBoxStyle.Information, "Information")

            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            End Try

            DatabaseDisconnect()

        End With

        Me.Close()

        HomeScreen.Enabled = True

    End Sub



    Private Sub EditProcedure_Load(sender As Object, e As EventArgs) Handles Me.Load

        'sqlstr = "SELECT * FROM `procedure` WHERE ProcedureID = '" & ProcedureNo & "'"

        'MsgBox(sqlstr)

        ConnectDatabase()
        With sqlcmd
            Try
                .Connection = DBConnection
                .CommandType = CommandType.StoredProcedure
                .CommandText = "AppProcedures"
                .Parameters.AddWithValue("@QType", "Get")
                .Parameters.AddWithValue("@ProdID", ProcedureNo)
                .Parameters.AddWithValue("@ProdName", "")
                .Parameters.AddWithValue("@ProdDescription", "")
                .Parameters.AddWithValue("@ProdPrice", DBNull.Value)
                .Parameters.AddWithValue("@ProdCategory", "")
                'MsgBox("Successful", MsgBoxStyle.Information, "Information")

                myreader = sqlcmd.ExecuteReader

                If myreader.Read() Then

                    txtboxProcedureNumber.Text = myreader("ProcedureID")
                    txtboxPrcedureName.Text = myreader("ProcedureName")
                    txtboxDescription.Text = myreader("Description")
                    txtboxPrice.Text = myreader("Price")
                    cmbboxCategory.Text = myreader("Category").ToString

                End If



            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            End Try
        End With

        DatabaseDisconnect()

    End Sub

    Private Sub EditProcedure_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
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

    Private Sub txtboxPrcedureName_Validating(sender As Object, e As CancelEventArgs) Handles txtboxPrice.Validating, txtboxPrcedureName.Validating, txtboxDescription.Validating
        Dim txtbox As TextBox = DirectCast(sender, TextBox)

        If (txtbox.Text.Length) > 0 Then
            ErrorProvider1.SetError(txtbox, String.Empty)
        Else
            ErrorProvider1.SetError(txtbox, "This field is required!")
            txtbox.Select()
        End If
    End Sub
End Class