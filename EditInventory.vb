Imports System.ComponentModel
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class EditInventory
    Private Sub btnInventoryHistory_Click(sender As Object, e As EventArgs) Handles btnInventoryHistory.Click

        Me.Enabled = False

        InventoryHistory.Show()


    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click

        Me.Close()

    End Sub

    Private Sub EditInventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If InventoryList.fromAppointment Then
            rdRecount.Visible = False
            rdAddCount.Visible = False
            rdMinusCount.Checked = True
            txtboxNewBalance.Select()
        End If

        txtboxSupplyNo.Text = InventoryList.InventorySupplyID

        ConnectDatabase()
        With sqlcmd

            Try
                .Connection = DBConnection
                .CommandType = CommandType.StoredProcedure
                .CommandText = "getInventorySupply"
                .Parameters.AddWithValue("@SuppID", txtboxSupplyNo.Text)
                'MsgBox("Successful", MsgBoxStyle.Information, "Information")

                myreader = sqlcmd.ExecuteReader

                While myreader.Read()

                    txtboxSupplyName.Text = myreader("SupplyName")
                    txtboxCurrentCount.Text = myreader("RemainingStock")
                    txtboxUnit.Text = myreader("Unit")

                End While

            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            End Try

        End With

        DatabaseDisconnect()


    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        'current count is initial stock
        'remaining stock is final balance

        If txtboxNewBalance.Text = "" Then
            MsgBox("Inventory New Balance cannot be empty", MsgBoxStyle.Exclamation, "Information")
            txtboxNewBalance.Select()
            Exit Sub
        End If

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

        'Declare variables needed for storing in database
        Dim remarks As String = ""
        Dim remainingStock As Integer

        'rd stands for radiobox
        'remarks and how computation will work varies on what radiobox is checked
        If rdRecount.Checked = True Then

            remainingStock = txtboxNewBalance.Text
            remarks = "Recounted Stock to " + remainingStock.ToString

        ElseIf rdAddCount.Checked = True Then

            remainingStock = Val(txtboxCurrentCount.Text) + Val(txtboxNewBalance.Text)
            remarks = "Added " & txtboxNewBalance.Text

        ElseIf rdMinusCount.Checked = True Then

            If InventoryList.fromAppointment Then
                remainingStock = Val(txtboxCurrentCount.Text) - Val(txtboxNewBalance.Text)
                remarks = "Removed " & txtboxNewBalance.Text & " from appointment in " & DateTime.Now.ToString("MM/dd/yyyy")
            Else
                remainingStock = Val(txtboxCurrentCount.Text) - Val(txtboxNewBalance.Text)
                remarks = "Removed " & txtboxNewBalance.Text
            End If

        End If

        'checks if the resulting stock will be unavailable, availabe, or low stock
        Dim invStatus As String
        If remainingStock = 0 Then
            invStatus = "Unavailable"
        ElseIf remainingStock > 10 Then
            invStatus = "Available"
        Else
            invStatus = "Low Stock"
        End If

        'STORING TO DATABASE
        ConnectDatabase()

        With sqlcmd

            Try

                .Connection = DBConnection
                .CommandType = CommandType.StoredProcedure
                .CommandText = "InsertNewSupplyInventory"
                .Parameters.AddWithValue("@InvId", newInvID)
                .Parameters.AddWithValue("@SuppId", txtboxSupplyNo.Text)
                If InventoryList.fromAppointment Then
                    .Parameters.AddWithValue("@InvAppID", PatientAppointmentHistory.AppointmentID)
                Else
                    .Parameters.AddWithValue("@InvAppID", "")
                End If
                .Parameters.AddWithValue("@IntStock", txtboxCurrentCount.Text)
                .Parameters.AddWithValue("@RmngStock", remainingStock)
                .Parameters.AddWithValue("@InvRemarks", remarks)
                .Parameters.AddWithValue("@StockUnit", txtboxUnit.Text)
                .Parameters.AddWithValue("@InvStatus", invStatus)

                .ExecuteNonQuery()
                'MsgBox("Inventory Updated", MsgBoxStyle.Information, "Information")

            Catch ex As Exception

                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")

            End Try

            DatabaseDisconnect()

        End With

        Me.Close()

        HomeScreen.Enabled = True

        InventoryList.refreshDataGridInvList()
        Dashboard.refreshDtGridInvWarn()

        AppointmentInventory.loadAppointmentInventoryList()
        AppointmentInventory.loadInventoryList()
    End Sub

    Private Sub EditInventory_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If Not InventoryList.fromAppointment Then
            HomeScreen.Enabled = True
        End If
    End Sub

    Private Sub txtboxNewBalance_Validating(sender As Object, e As CancelEventArgs) Handles txtboxNewBalance.Validating, txtboxNewBalance.Validating
        If (txtboxNewBalance.Text.Length) > 0 Then
            ErrorProvider1.SetError(txtboxNewBalance, String.Empty)
        Else
            ErrorProvider1.SetError(txtboxNewBalance, "This field is required!")
            txtboxNewBalance.Select()
        End If
    End Sub

    Private Sub btnRecount_Click(sender As Object, e As EventArgs)

        lblNewBalance.Text = "Recounted Inventory Stock"

    End Sub

    Private Sub btnAddCount_Click(sender As Object, e As EventArgs)

        lblNewBalance.Text = "Add Stock to Inventory"

    End Sub

    Private Sub btnMinusCount_Click(sender As Object, e As EventArgs)

        lblNewBalance.Text = "Remove Stock to Inventory"

    End Sub




    Private Sub rdRecount_CheckedChanged(sender As Object, e As EventArgs) Handles rdRecount.CheckedChanged

        lblNewBalance.Text = "Recounted Inventory Stock"
        lblNewBalance.Visible = True
        txtboxNewBalance.Visible = True

    End Sub

    Private Sub rdAddCount_CheckedChanged(sender As Object, e As EventArgs) Handles rdAddCount.CheckedChanged

        lblNewBalance.Text = "Add Stock to Inventory"
        lblNewBalance.Visible = True
        txtboxNewBalance.Visible = True

    End Sub

    Private Sub rdMinusCount_CheckedChanged(sender As Object, e As EventArgs) Handles rdMinusCount.CheckedChanged

        lblNewBalance.Text = "Remove Stock to Inventory"
        lblNewBalance.Visible = True
        txtboxNewBalance.Visible = True

    End Sub

End Class