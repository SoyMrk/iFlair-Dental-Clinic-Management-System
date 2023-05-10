Imports Microsoft.Office.Interop
Imports System.IO

Public Class InventoryList

    Public Shared InventorySupplyID As String
    Public Shared fromAppointment As Boolean

    Public Sub refreshDataGridInvList()

        Me.dataviewInventoryList.Rows.Clear()
        dataviewInventoryList.RowTemplate.Height = 40

        ConnectDatabase()
        With sqlcmd
            Try
                .Connection = DBConnection
                .CommandType = CommandType.StoredProcedure
                .CommandText = "viewInventoryList"
                .Parameters.AddWithValue("@QType", "All")
                'MsgBox("Successful", MsgBoxStyle.Information, "Information")

                myreader = sqlcmd.ExecuteReader

                While myreader.Read()
                    Me.dataviewInventoryList.Rows.Add(New Object() {myreader.Item("SupplyID"), myreader.Item("SupplyName"), myreader.Item("RemainingStock"), myreader.Item("Unit"), myreader.Item("Status"), myreader.Item("DateLastUpdated")})
                End While

            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            End Try
        End With
        DatabaseDisconnect()

    End Sub



    Private Sub InventoryList_Load(sender As Object, e As EventArgs) Handles Me.Load

        refreshDataGridInvList()
        cmbboxFilterStatus.Text = "All"

    End Sub



    Private Sub dataviewInventoryList_CellMouseMove(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dataviewInventoryList.CellMouseMove

        dataviewInventoryList.ClearSelection()
        If e.RowIndex > -1 Then
            dataviewInventoryList.Rows(e.RowIndex).Selected = True
        End If

    End Sub

    Private Sub dataviewInventoryList_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataviewInventoryList.CellContentClick

        If e.RowIndex < 0 Then
            Exit Sub
        End If

        InventorySupplyID = dataviewInventoryList.CurrentRow.Cells(0).Value.ToString

        HomeScreen.Enabled = False

        EditInventory.Show()

    End Sub

    Private Sub txtboxSearch_Click(sender As Object, e As EventArgs) Handles txtboxSearch.Click

        txtboxSearch.Text = ""

    End Sub

    Private Sub txtboxSearch_TextChanged(sender As Object, e As EventArgs) Handles txtboxSearch.TextChanged

        If txtboxSearch.Text = "Search Inventory" Then
            Exit Sub
        End If

        Me.dataviewInventoryList.Rows.Clear()
        ConnectDatabase()
        With sqlcmd
            Try
                .Connection = DBConnection
                .CommandType = CommandType.StoredProcedure
                .CommandText = "searchInventory"
                .Parameters.AddWithValue("@txtSearch", txtboxSearch.Text)
                'MsgBox("Successful", MsgBoxStyle.Information, "Information")

                myreader = sqlcmd.ExecuteReader

                While myreader.Read()
                    Me.dataviewInventoryList.Rows.Add(New Object() {myreader.Item("SupplyID"), myreader.Item("SupplyName"), myreader.Item("RemainingStock"), myreader.Item("Unit"), myreader.Item("Status"), myreader.Item("DateLastUpdated")})
                End While

            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            End Try
        End With
        DatabaseDisconnect()

    End Sub

    Private Sub txtboxSearch_Leave(sender As Object, e As EventArgs) Handles txtboxSearch.Leave

        txtboxSearch.Text = "Search Inventory"

    End Sub

    Private Sub cmbboxFilterStatus_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmbboxFilterStatus.SelectionChangeCommitted

        Me.dataviewInventoryList.Rows.Clear()
        dataviewInventoryList.RowTemplate.Height = 40

        ConnectDatabase()
        With sqlcmd
            Try
                .Connection = DBConnection
                .CommandType = CommandType.StoredProcedure
                .CommandText = "viewInventoryList"
                .Parameters.AddWithValue("@QType", cmbboxFilterStatus.Text)
                'MsgBox("Successful", MsgBoxStyle.Information, "Information")

                myreader = sqlcmd.ExecuteReader

                While myreader.Read()
                    Me.dataviewInventoryList.Rows.Add(New Object() {myreader.Item("SupplyID"), myreader.Item("SupplyName"), myreader.Item("RemainingStock"), myreader.Item("Unit"), myreader.Item("Status"), myreader.Item("DateLastUpdated")})
                End While

            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            End Try
        End With
        DatabaseDisconnect()

    End Sub

    Private Sub btnExcel_Click(sender As Object, e As EventArgs) Handles btnExcel.Click

        Dim StartUpPath As String = Application.StartupPath


        Dim xlsFiles As String = desktopPath + "\Dental Clinic Management System\Reports\InventoryRecords\"
        Dim xlsTemplates As String

        If StartUpPath.Contains("bin") Then
            xlsTemplates = StartUpPath.Replace("\bin\Debug\net6.0-windows\", "\Templates\")
        Else
            xlsTemplates = StartUpPath + "\Templates\"
        End If

        'MsgBox(xlsTemplates)
        'MsgBox(xlsFiles)

        Dim xlsApp As Excel.Application
        Dim xlsWB As Excel.Workbook
        Dim xlsSheet As Excel.Worksheet

        xlsApp = New Excel.Application

        xlsApp.Visible = False
        xlsWB = xlsApp.Workbooks.Open(xlsTemplates & "InventoryRecord.xlsx")

        xlsSheet = xlsWB.Worksheets(1)
        xlsSheet.Unprotect("flair")

        Dim x As Integer
        Dim currentRow As Integer = 9
        For x = 0 To dataviewInventoryList.RowCount - 1

            xlsSheet.Cells(currentRow, 1) = dataviewInventoryList.Rows(x).Cells("colSuppName").Value
            xlsSheet.Cells(currentRow, 2) = dataviewInventoryList.Rows(x).Cells("colRemainingStock").Value
            xlsSheet.Cells(currentRow, 3) = dataviewInventoryList.Rows(x).Cells("colStockUnit").Value
            xlsSheet.Cells(currentRow, 4) = dataviewInventoryList.Rows(x).Cells("colSuppStatus").Value
            xlsSheet.Cells(currentRow, 5) = dataviewInventoryList.Rows(x).Cells("colDateLastUpdated").Value.ToString

            currentRow += 1

        Next

        xlsSheet.Cells(5, 5) = dataviewInventoryList.Rows.Count.ToString

        With xlsSheet.Range("A9", "D" & currentRow - 1)
            .Borders(Excel.XlBordersIndex.xlInsideHorizontal).LineStyle = Excel.XlLineStyle.xlContinuous
            .Borders(Excel.XlBordersIndex.xlInsideHorizontal).Weight = Excel.XlBorderWeight.xlHairline
        End With


        xlsSheet.PageSetup.Orientation = Excel.XlPageOrientation.xlLandscape
        xlsApp.ActiveWindow.View = Excel.XlWindowView.xlPageLayoutView
        xlsApp.ActiveWindow.DisplayGridlines = False

        xlsSheet.PageSetup.LeftFooter = "Date Created: " & DateTime.Now & Chr(10) & "Generated by: " & LoginAccount.empName

        Dim myfilename As String = "InventoryRecord-" & DateTime.Now.ToString("MMddyy-HHmmss") & ".xlsx"
        xlsSheet.Protect("flair")

        xlsWB.SaveAs(xlsFiles & myfilename)
        xlsApp.Quit()

        releaseObject(xlsApp)
        releaseObject(xlsWB)
        releaseObject(xlsSheet)

        If File.Exists("C:\Program Files (x86)\Microsoft Office\root\Office16\EXCEL.EXE") Then

            Process.Start("C:\Program Files (x86)\Microsoft Office\root\Office16\EXCEL.EXE", """" & xlsFiles & myfilename & """")

        ElseIf File.Exists("C:\Program Files\Microsoft Office\root\Office16\EXCEL.EXE") Then

            Process.Start("C:\Program Files\Microsoft Office\root\Office16\EXCEL.EXE", """" & xlsFiles & myfilename & """")

        Else

            MessageBox.Show("Excel is not installed in this device", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        End If

    End Sub


End Class