Imports System.ComponentModel
Imports System.Globalization
Imports MySql.Data.MySqlClient

Public Class AddBilling

    Public totalPrice As Integer = 0
    Private DiscountPt As Double = 0
    Private totalAmountInvoice As Integer = 0
    Private timenow As String
    Private newPaymentID As String
    Private newTransactionID As String

    Private totalAmountPaid As String
    Private totalGross As String
    Private totalBalance As String
    Private totalAmountPrice As String

    Private decimalvalue As Decimal
    Private decimalvalue2 As Decimal

    Public Sub refreshDtGridInvoice()

        dtgridInvoice.Rows.Clear()
        Try
            ConnectDatabase()

            With sqlcmd
                .Connection = DBConnection
                .CommandType = CommandType.StoredProcedure
                .CommandText = "getAppInvoice"
                .Parameters.AddWithValue("@AppID", PatientAppointmentHistory.AppointmentID)

                myreader = .ExecuteReader

                While myreader.Read
                    Dim discountedPrice As Double = (myreader("Price").ToString * DiscountPt)
                    'Dim discount As String = "Less " & DiscountPt & "%"
                    Dim discount As String = ""
                    If cmbboxDiscount.Text = "NO DISCOUNT" Then
                        discount = ""
                    Else
                        discount = cmbboxDiscount.Text & " (" & DiscountPt & "%)"
                    End If

                    Dim price As String = myreader.Item("Price")
                    decimalvalue = Convert.ToDecimal(price)

                    Dim totalAmount As String = price - discountedPrice
                    decimalvalue2 = Convert.ToDecimal(price)

                    dtgridInvoice.Rows.Add(New Object() {myreader.Item("ProcedureName"), "₱" & decimalvalue.ToString("N0"), discount, discountedPrice, "₱" & decimalvalue2.ToString("N0")})

                End While



            End With

            DatabaseDisconnect()
        Catch ex As Exception

            DatabaseDisconnect()

        End Try

    End Sub

    Private Sub AddBilling_Load(sender As Object, e As EventArgs) Handles Me.Load

        timenow = Now().ToString("yyyyMMddHHmmssff")
        newPaymentID = "PAY" + timenow
        newTransactionID = "TRA" + timenow

        lblPatientName.Text = PatientRecordScreen.PatientName
        lblPhoneNumber.Text = PatientRecordScreen.txtboxContactNo.Text
        lblDentistName.Text = "Dr. " & PatientAppointmentHistory.nameDentist
        lblBillingDate.Text = DateTime.Today.ToString("MM/dd/yyyy")
        lblInvoiceNo.Text = newTransactionID
        lblDueDate.Text = DateTime.Today.ToString("MM/dd/yyyy")


        'totalAmountInvoice = 0
        'For Each row As DataGridViewRow In dtgridInvoice.Rows
        '    totalAmountInvoice += row.Cells.Item(4).Value
        'Next

        lblTotal.Text = "₱" & txtboxTotal.Text

        ConnectDatabase()

        With sqlcmd

            Try
                .Connection = DBConnection
                .CommandType = CommandType.StoredProcedure
                .CommandText = "getPaymentProcedurePrices"
                .Parameters.AddWithValue("@AppID", PatientAppointmentHistory.AppointmentID)

                myreader = sqlcmd.ExecuteReader
                While myreader.Read()

                    totalPrice = totalPrice + myreader("Price")
                    listboxProcedures.Items.Add(myreader("ProcedurePrices"))
                    txtboxGross.Text = totalPrice
                    totalGross = totalPrice

                End While
                DatabaseDisconnect()

            Catch ex As Exception
                DatabaseDisconnect()
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End With
        txtboxTotal.Text = totalPrice
        totalAmountPrice = totalPrice

        Try
            ConnectDatabase()
            Dim DiscountTable As New DataTable
            With sqlcmd
                .Connection = DBConnection
                .CommandType = CommandType.StoredProcedure
                .CommandText = "getDiscounts"
            End With
            myAdapter.SelectCommand = sqlcmd
            myAdapter.Fill(DiscountTable)

            cmbboxDiscount.DataSource = DiscountTable
            cmbboxDiscount.ValueMember = "DiscountID"
            cmbboxDiscount.DisplayMember = "DiscountName"

            DatabaseDisconnect()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            DatabaseDisconnect()
        End Try

        txtboxBalance.Text = txtboxTotal.Text
        cmbboxDiscount.Text = "NO DISCOUNT"
        refreshDtGridInvoice()

    End Sub

    Private Sub AddBilling_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        HomeScreen.Enabled = True
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        HomeScreen.Enabled = True
        Me.Close()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        If txtboxAmountPaid.Text = "" Then
            MessageBox.Show("Tendered Amount cannot be empty", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If


        ConnectDatabase()

        With sqlcmd
            Try
                .Connection = DBConnection
                .CommandType = CommandType.StoredProcedure
                .CommandText = "AddPayment"
                .Parameters.AddWithValue("@newPaymentID", newPaymentID)
                .Parameters.AddWithValue("@AppID", PatientAppointmentHistory.AppointmentID)
                .Parameters.AddWithValue("@Discount", cmbboxDiscount.Text)
                .Parameters.AddWithValue("@Total", totalAmountPrice)
                .Parameters.AddWithValue("@TotalAmountPaid", totalAmountPaid)
                .Parameters.AddWithValue("@AmountPaid", totalAmountPaid)
                .Parameters.AddWithValue("@Balance", totalBalance)
                .Parameters.AddWithValue("@BillingStatus", lblBillingStatus.Text)
                .Parameters.AddWithValue("@newTransactionID", newTransactionID)
                .Parameters.AddWithValue("@Gross", totalGross)

                .ExecuteNonQuery()
                'MessageBox.Show("Payment Registered", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

                DatabaseDisconnect()
            Catch ex As Exception
                DatabaseDisconnect()
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try


        End With

        ClearPatientPanel()

        With PatientAppointmentHistory
            .WindowState = FormWindowState.Maximized
            .Dock = DockStyle.Fill And DockStyle.Bottom
            .AutoSize = True
            .TopLevel = False
            PatientRecordScreen.PatientProfilePanel.Controls.Add(PatientAppointmentHistory)
            .BringToFront()
            .Show()
        End With


        If MessageBox.Show("Set Up Next Appointment for this patient?", "Next Appoinment", MessageBoxButtons.YesNo) = DialogResult.Yes Then

            Me.Close()

            NextAppointment.Show()

        Else

            Me.Close()

        End If

    End Sub

    Private Sub cmbboxDiscount_TextChanged(sender As Object, e As EventArgs) Handles cmbboxDiscount.TextChanged

        Dim Discount As Double = 0
        txtboxAmountPaid.Text = ""
        txtboxBalance.Text = ""
        txtboxChange.Text = 0
        lblChange.Text = 0


        Try
            ConnectDatabase()

            With sqlcmd
                .Connection = DBConnection
                .CommandType = CommandType.StoredProcedure
                .CommandText = "getDiscount"
                .Parameters.AddWithValue("@DiscID", cmbboxDiscount.SelectedValue.ToString)

                myreader = .ExecuteReader

                If myreader.Read Then
                    DiscountPt = myreader("DiscountLessPercentage") / 100
                    Discount = totalGross * DiscountPt
                    Dim discountedPrice As Double = totalGross - Discount
                    lblDiscountAmount2.Text = Discount.ToString("N0")
                    txtboxTotal.Text = discountedPrice
                    totalPrice = discountedPrice

                End If
            End With

            DatabaseDisconnect()
        Catch ex As Exception

            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            DatabaseDisconnect()

        End Try

        refreshDtGridInvoice()

        totalAmountInvoice = 0
        For Each row As DataGridViewRow In dtgridInvoice.Rows
            totalAmountInvoice += row.Cells.Item(3).Value
        Next

        Dim decimalTotal As Decimal
        decimalTotal = Convert.ToDecimal(txtboxTotal.Text)
        lblTotal.Text = "₱" & decimalTotal.ToString("N0")

        txtboxAmountPaid.Select()
        txtboxBalance.Text = txtboxTotal.Text

    End Sub

    Private Sub txtboxAmountPaid_TextChanged(sender As Object, e As EventArgs) Handles txtboxAmountPaid.TextChanged

        totalAmountPaid = txtboxAmountPaid.Text

        If Not IsNumeric(txtboxAmountPaid.Text) Then
            txtboxBalance.Text = txtboxTotal.Text
            lblTenderedAmount.Text = 0
            Exit Sub
        End If


        If txtboxAmountPaid.Text = "" Then
            txtboxBalance.Text = txtboxTotal.Text
            txtboxChange.Text = 0
            lblTenderedAmount.Text = 0
            Exit Sub
        Else
            txtboxBalance.Text = txtboxTotal.Text - txtboxAmountPaid.Text

            If txtboxBalance.Text < 0 Then
                txtboxBalance.Text = 0
            End If

            totalBalance = txtboxBalance.Text

            decimalvalue = Convert.ToDecimal(txtboxBalance.Text)
            txtboxBalance.Text = decimalvalue.ToString("N0")

            decimalvalue = Convert.ToDecimal(txtboxAmountPaid.Text)
            lblTenderedAmount.Text = "₱" & decimalvalue.ToString("N0")

            txtboxChange.Text = txtboxAmountPaid.Text - txtboxTotal.Text
            decimalvalue = Convert.ToDecimal(txtboxChange.Text)

            If txtboxChange.Text < 0 Then
                txtboxChange.Text = 0
            End If

            If Not decimalvalue.ToString("N0") < 0 Then
                txtboxChange.Text = "₱" & decimalvalue.ToString("N0")
            End If

            lblChange.Text = "₱" & txtboxChange.Text

            If txtboxChange.Text > 0 Then
                totalAmountPaid = txtboxTotal.Text
            End If

        End If

    End Sub

    Private Sub txtboxBalance_TextChanged(sender As Object, e As EventArgs) Handles txtboxBalance.TextChanged

        If txtboxBalance.Text = "0" Then
            lblBillingStatus.Text = "Complete"
        Else
            lblBillingStatus.Text = "Incomplete"
        End If



    End Sub

    Private Sub txtboxAmountPaid_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtboxAmountPaid.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = ".") Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub PrintInvoice_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintInvoice.PrintPage

        Dim invoice As New Bitmap(Me.pnlInvoice.Width, Me.pnlInvoice.Height)
        pnlInvoice.DrawToBitmap(invoice, New Rectangle(0, 0, Me.pnlInvoice.Width, Me.pnlInvoice.Height))
        e.Graphics.DrawImage(invoice, 0, 0)

        Dim psD As New PageSetupDialog
        psD.Document = PrintInvoice

    End Sub


    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click


        If PrintDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            PrintInvoice.PrinterSettings = PrintDialog1.PrinterSettings
        End If

        PrintPreviewDialog1.Document = PrintInvoice
        PrintPreviewDialog1.StartPosition = FormStartPosition.CenterScreen

        PrintPreviewDialog1.ShowDialog()

    End Sub

    Private Sub lblAddDiscount_Click(sender As Object, e As EventArgs) Handles lblAddDiscount.Click
        lblAddDiscount.Visible = False

        lblDiscount.Visible = True
        cmbboxDiscount.Visible = True

        lblDiscountAmount.Visible = True
        lblDiscountAmount2.Visible = True
        lblDiscountUsed.Visible = True
        lblDiscountUsed2.Visible = True
    End Sub

    Private Sub cmbboxDiscount_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmbboxDiscount.SelectionChangeCommitted
        lblDiscountUsed2.Text = cmbboxDiscount.Text
        If cmbboxDiscount.Text = "NO DISCOUNT" Then
            lblAddDiscount.Visible = True

            lblDiscount.Visible = False
            cmbboxDiscount.Visible = False

            lblDiscountAmount.Visible = False
            lblDiscountAmount2.Visible = False
            lblDiscountUsed.Visible = False
            lblDiscountUsed2.Visible = False
        End If
    End Sub

    Private Sub txtboxTotal_TextChanged(sender As Object, e As EventArgs) Handles txtboxTotal.TextChanged

        decimalvalue = Convert.ToDecimal(txtboxTotal.Text)
        txtboxTotal.Text = decimalvalue.ToString("N0")
    End Sub

    Private Sub txtboxGross_TextChanged(sender As Object, e As EventArgs) Handles txtboxGross.TextChanged

        decimalvalue = Convert.ToDecimal(txtboxGross.Text)
        txtboxGross.Text = decimalvalue.ToString("N0")
    End Sub


End Class