Imports System.ComponentModel
Imports MySql.Data.MySqlClient

Public Class ViewTemplate

    Public Sub LoadComboBox()

        Try
            ConnectDatabase()
            Dim smsTemplateTemplate As New DataTable
            With sqlcmd
                .Connection = DBConnection
                .CommandType = CommandType.StoredProcedure
                .CommandText = "SMSTemplate"
                .Parameters.AddWithValue("@QType", "View")
                .Parameters.AddWithValue("@TempName", "")
                .Parameters.AddWithValue("@TempText", "")
                myAdapter.SelectCommand = sqlcmd
                myAdapter.Fill(smsTemplateTemplate)
            End With
            If smsTemplateTemplate.Rows.Count <> 0 Then

                cmbboxTempName.DataSource = smsTemplateTemplate
                cmbboxTempName.ValueMember = "TemplateName"
                cmbboxTempName.DisplayMember = "TemplateName"

            End If
            DatabaseDisconnect()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            DatabaseDisconnect()
        End Try

    End Sub
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub ViewTemplate_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        HomeScreen.Enabled = True
    End Sub

    Private Sub ViewTemplate_Load(sender As Object, e As EventArgs) Handles Me.Load

        LoadComboBox()

    End Sub

    Private Sub cmbboxTempName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbboxTempName.SelectedIndexChanged
        'If cmbboxTempName.Text = "" Then
        '    MessageBox.Show("SMS Templates is Empty, Please Add One")
        'End If
    End Sub

    Private Sub cmbboxTempName_DropDownClosed(sender As Object, e As EventArgs) Handles cmbboxTempName.DropDownClosed
        btnDelete.Visible = True
        btnEdit.Visible = True
        Try
            ConnectDatabase()

            With sqlcmd
                .Connection = DBConnection
                .CommandType = CommandType.StoredProcedure
                .CommandText = "SMSTemplate"
                .Parameters.AddWithValue("@QType", "Get")
                .Parameters.AddWithValue("@TempName", cmbboxTempName.SelectedValue.ToString)
                .Parameters.AddWithValue("@TempText", "")
                myreader = .ExecuteReader

                If myreader.Read() Then
                    richtxtMessage.Text = myreader("TemplateText")
                End If

            End With

            DatabaseDisconnect()

        Catch ex As Exception
            DatabaseDisconnect()
            MessageBox.Show(ex.Message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If richtxtMessage.Text = "" Then
            MessageBox.Show("Text Box Empty, Please Pick a Template", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        btnEdit.Visible = False
        btnDelete.Visible = False

        richtxtMessage.ReadOnly = False
        btnCancel.BringToFront()
        btnSave.BringToFront()

        richtxtMessage.Focus()
        richtxtMessage.SelectionStart = richtxtMessage.Text.Length
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        btnDelete.Visible = True
        btnEdit.Visible = True
        richtxtMessage.ReadOnly = True
        btnClose.BringToFront()
        btnAddTemplate.BringToFront()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        Try
            ConnectDatabase()

            With sqlcmd
                .Connection = DBConnection
                .CommandType = CommandType.StoredProcedure
                .CommandText = "SMSTemplate"
                .Parameters.AddWithValue("@QType", "Edit")
                .Parameters.AddWithValue("@TempText", richtxtMessage.Text)
                .Parameters.AddWithValue("@TempName", cmbboxTempName.SelectedValue.ToString)
                .ExecuteNonQuery()
                'MessageBox.Show("Template Message Updated Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End With

            DatabaseDisconnect()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            DatabaseDisconnect()

        End Try

        btnEdit.Visible = True
        richtxtMessage.ReadOnly = True
        btnClose.BringToFront()
        btnAddTemplate.BringToFront()
    End Sub

    Private Sub btnAddTemplate_Click(sender As Object, e As EventArgs) Handles btnAddTemplate.Click
        Me.Close()
        AddNewTemplate.Show()
        HomeScreen.Enabled = False
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If richtxtMessage.Text = "" Then
            MessageBox.Show("Select a Template First", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If


        Try
            ConnectDatabase()

            With sqlcmd

                If MessageBox.Show("Are you sure you want to delete this Template: '" & cmbboxTempName.SelectedValue.ToString & "'", "Are you sure?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation) = DialogResult.Yes Then

                    .Connection = DBConnection
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "SMSTemplate"
                    .Parameters.AddWithValue("@QType", "Delete")
                    .Parameters.AddWithValue("@TempName", cmbboxTempName.SelectedValue.ToString)
                    .Parameters.AddWithValue("@TempText", "")
                    .ExecuteNonQuery()

                    richtxtMessage.Text = ""
                    btnDelete.Visible = False
                    LoadComboBox()
                    'MsgBox("Template Successfully Deleted", MsgBoxStyle.Information, "Information")
                Else

                    Exit Sub

                End If

            End With

            DatabaseDisconnect()
        Catch ex As Exception
            DatabaseDisconnect()
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub cmbboxTempName_Click(sender As Object, e As EventArgs) Handles cmbboxTempName.Click
        If cmbboxTempName.Text = "" Then
            MessageBox.Show("SMS Templates is Empty, Please Add One")
        End If
    End Sub

End Class