Imports System.ComponentModel
Imports MySql.Data.MySqlClient

Public Class AddNewSupply
    Private Sub AddNewSupply_Load(sender As Object, e As EventArgs) Handles Me.Load

        Dim timenow As String = Now().ToString("yyyyMMddHHmmssff")
        Dim newSupplyNo As String = "SUP" + timenow

        txtboxSupplyNo.Text = newSupplyNo

        ConnectDatabase()
        With sqlcmd
            Try
                .Connection = DBConnection
                .CommandType = CommandType.StoredProcedure
                .CommandText = "getSupplyCount"
                'MsgBox("Successful", MsgBoxStyle.Information, "Information")

                myreader = sqlcmd.ExecuteReader

                If myreader.Read() Then

                    txtboxSupplyNo.Text = txtboxSupplyNo.Text + myreader("SupplyCount").ToString

                End If

            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            End Try
        End With

        DatabaseDisconnect()


        'ConnectDatabase()

        'Dim CategoryTable As New DataTable

        'Dim Category As New MySqlCommand("SELECT * FROM supply_category", DBConnection)
        'myAdapter = New MySqlDataAdapter(Category)

        'myAdapter.Fill(CategoryTable)
        'cmbboxCategory.DataSource = CategoryTable
        'cmbboxCategory.ValueMember = "Category"
        'cmbboxCategory.DisplayMember = "Category"

        'DatabaseDisconnect()



    End Sub

    Private Sub btnAddNew_Click(sender As Object, e As EventArgs) Handles btnAddNew.Click

        Dim allTxt As New List(Of Control)
        For Each txt As TextBox In FindControlRecursive(allTxt, Me, GetType(TextBox))
            If txt.Text = "" Then
                MsgBox(txt.AccessibleName & " cannot be empty.", MsgBoxStyle.Exclamation, "Information")
                txt.Select()
                Exit Sub
            End If
            'MsgBox(txt.Name)
        Next

        Dim timenow As String = Now().ToString("yyyyMMddHHmmssff")
        Dim newInvID As String = "INV" + timenow

        ConnectDatabase()
        With sqlcmd
            Try
                .Connection = DBConnection
                .CommandType = CommandType.StoredProcedure
                .CommandText = "getInventoryCount"
                'MsgBox("Successful", MsgBoxStyle.Information, "Information")

                myreader = sqlcmd.ExecuteReader

                If myreader.Read() Then

                    newInvID = newInvID + myreader("InventoryCount").ToString

                End If

            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            End Try
        End With

        DatabaseDisconnect()


        Dim InvStatus As String
        If txtboxInitialStock.Text = 0 Then
            InvStatus = "Unavailable"
        ElseIf txtboxInitialStock.Text > 10 Then
            InvStatus = "Available"
        Else
            InvStatus = "Low Stock"
        End If

        ConnectDatabase()

        With sqlcmd

            Try

                .Connection = DBConnection
                .CommandType = CommandType.StoredProcedure
                .CommandText = "InsertNewSupply"
                .Parameters.AddWithValue("@SuppID", txtboxSupplyNo.Text)
                .Parameters.AddWithValue("@SuppName", txtboxSupplyName.Text)
                .Parameters.AddWithValue("@SupplyDescription", txtboxDescription.Text)
                .Parameters.AddWithValue("@InvID", newInvID)
                .Parameters.AddWithValue("@IntStock", txtboxInitialStock.Text)
                .Parameters.AddWithValue("@StockUnit", txtboxUnit.Text)
                .Parameters.AddWithValue("@InvRemarks", "First Record")
                .Parameters.AddWithValue("@InvStatus", InvStatus)

                .ExecuteNonQuery()
                'MsgBox("Supply Registered", MsgBoxStyle.Information, "Information")

            Catch ex As Exception

                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")

            End Try

            DatabaseDisconnect()

        End With

        Me.Close()

        HomeScreen.Enabled = True

        Inventory.refreshSupplyDataGrid()

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click

        HomeScreen.Enabled = True

        Me.Close()


    End Sub

    Private Sub AddNewSupply_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing

        HomeScreen.Enabled = True

    End Sub

    Private Sub Input_Validating(sender As Object, e As CancelEventArgs) Handles txtboxSupplyName.Validating, txtboxInitialStock.Validating, txtboxDescription.Validating

        Dim txtbox As TextBox = DirectCast(sender, TextBox)

        If (txtbox.Text.Length) > 0 Then
            ErrorProvider1.SetError(txtbox, String.Empty)
        Else
            ErrorProvider1.SetError(txtbox, "This field is required!")
            txtbox.Select()
        End If

    End Sub

    Private Sub txtboxInitialStock_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtboxInitialStock.KeyPress

        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
            'MsgBox("Numeric Input Only")
        End If

    End Sub

End Class