Imports System.ComponentModel

Public Class EditBilling

    Public PaymentId As String
    Public Balance As Integer = 0

    Private DiscountPt As Double = 0
    Private totalAmountInvoice As Integer = 0
    Private timenow As String
    Private newTransactionID As String

    Private decimalvalue As Decimal
    Private decimalvalue2 As Decimal

    Private totalGross As String
    Private totalBalance As String
    Private totalAmountPaid As String
    Private totalNewBalance As String

    Private AppID As String

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
                    Dim discount As String = "" '"Less " & DiscountPt & "%"

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
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

    End Sub

    Private Sub EditBilling_Load(sender As Object, e As EventArgs) Handles Me.Load

        ConnectDatabase()

        With sqlcmd

            Try
                .Connection = DBConnection
                .CommandType = CommandType.StoredProcedure
                .CommandText = "PatAppointments"
                .Parameters.AddWithValue("@QType", "Check")
                .Parameters.AddWithValue("@AppFilterStatus", "No Filter")
                .Parameters.AddWithValue("@PatID", PatientRecordScreen.MyPatientID)
                .Parameters.AddWithValue("@AppID", "")

                myreader = sqlcmd.ExecuteReader

                If myreader.Read() And Not IsDBNull(myreader("AppointmentID")) Then


                    Dim AppDate As DateTime = myreader("AppDate").ToString

                    AppID = myreader("AppointmentID")

                End If

            Catch ex As Exception
                DatabaseDisconnect()
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            End Try

        End With
        DatabaseDisconnect()


        timenow = Now().ToString("yyyyMMddHHmmssff")
        newTransactionID = "TRA" + timenow

        lblPatientName.Text = PatientRecordScreen.PatientName
        lblPhoneNumber.Text = PatientRecordScreen.txtboxContactNo.Text
        lblDentistName.Text = "Dr. " & PatientAppointmentHistory.nameDentist
        lblBillingDate.Text = DateTime.Today.ToString("MM/dd/yyyy")
        lblInvoiceNo.Text = newTransactionID
        lblDueDate.Text = DateTime.Today.ToString("MM/dd/yyyy")

        ConnectDatabase()

        With sqlcmd

            Try
                .Connection = DBConnection
                .CommandType = CommandType.StoredProcedure
                .CommandText = "getPatPayment"
                .Parameters.AddWithValue("@PatID", PatientRecordScreen.MyPatientID)
                'MsgBox("Successful", MsgBoxStyle.Information, "Information")

                myreader = sqlcmd.ExecuteReader

                If myreader.Read() Then

                    PaymentId = myreader("PaymentID")
                    'MsgBox(PaymentId)

                    Dim DateLastPaid As DateTime = myreader("DateLastPaid")

                    PatientAppointmentHistory.AppointmentID = myreader("AppointmentID")

                    txtboxLastDateAmountPaid.Text = myreader("AmountPaid").ToString + " : " + DateLastPaid.ToString("MMMM dd, yyyy")
                    lblLastDatePaid.Text = DateLastPaid.ToString("MMMM dd, yyyy")

                    decimalvalue = Convert.ToDecimal(myreader("AmountPaid").ToString)
                    lblLastAmountPaid.Text = "₱" & decimalvalue.ToString("N0")

                    decimalvalue = Convert.ToDecimal((myreader("TotalAmount") - myreader("TotalAmountPaid").ToString))
                    lblNewTotal.Text = "₱" & decimalvalue.ToString("N0")

                    decimalvalue = Convert.ToDecimal((myreader("TotalAmountPaid").ToString))
                    lblTotalPaidAmount.Text = "₱" & decimalvalue.ToString("N0")

                    totalGross = myreader("TotalAmount").ToString
                    txtboxGross.Text = "₱" & totalGross

                    Balance = myreader("TotalAmount").ToString

                    totalBalance = myreader("Balance").ToString
                    txtboxBalance.Text = "₱" & totalBalance
                Else
                    MsgBox("Billing Status is already Completed", MsgBoxStyle.Information, "Information")
                    Me.Close()
                End If

            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            End Try

        End With
        txtboxNewBalance.Text = txtboxBalance.Text


        DatabaseDisconnect()

        'PROCEDURES ON UPDATING PAYMENT
        ConnectDatabase()

        With sqlcmd

            Try
                .Connection = DBConnection
                .CommandType = CommandType.StoredProcedure
                .CommandText = "getPaymentProcedurePrices"
                .Parameters.AddWithValue("@AppID", PatientAppointmentHistory.AppointmentID)

                myreader = sqlcmd.ExecuteReader

                While myreader.Read
                    listboxProcedures.Items.Add(myreader("ProcedurePrices"))
                End While


            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            End Try

        End With

        DatabaseDisconnect()

        refreshDtGridInvoice()

    End Sub

    Private Sub txtboxAmountPaid_TextChanged(sender As Object, e As EventArgs) Handles txtboxAmountPaid.TextChanged

        If Not IsNumeric(txtboxAmountPaid.Text) Then
            txtboxNewBalance.Text = txtboxBalance.Text
            lblNewTotal.Text = txtboxNewBalance.Text
            lblTenderedAmount.Text = 0
            Exit Sub
        End If

        If txtboxAmountPaid.Text = "" Then
            txtboxNewBalance.Text = txtboxBalance.Text
            lblNewTotal.Text = txtboxNewBalance.Text
            lblTenderedAmount.Text = 0
            Exit Sub
        Else
            txtboxNewBalance.Text = totalBalance - txtboxAmountPaid.Text

            If txtboxNewBalance.Text < 0 Then
                txtboxNewBalance.Text = 0
            End If

            totalNewBalance = txtboxNewBalance.Text

            decimalvalue = Convert.ToDecimal(txtboxNewBalance.Text)
            txtboxNewBalance.Text = decimalvalue.ToString("N0")

            lblNewTotal.Text = "₱" & txtboxNewBalance.Text

            lblTenderedAmount.Text = txtboxAmountPaid.Text

            decimalvalue = Convert.ToDecimal(lblTenderedAmount.Text)
            lblTenderedAmount.Text = "₱" & decimalvalue.ToString("N0")

            txtboxChange.Text = txtboxAmountPaid.Text - totalBalance
            decimalvalue = Convert.ToDecimal(txtboxChange.Text)
            txtboxChange.Text = decimalvalue.ToString("N0")

            If txtboxChange.Text < 0 Then
                txtboxChange.Text = 0
            End If

            lblChange.Text = "₱" & txtboxChange.Text

        End If

        If txtboxChange.Text > 0 Then
            totalAmountPaid = totalBalance
        Else
            totalAmountPaid = txtboxAmountPaid.Text
        End If


    End Sub

    Private Sub txtboxNewBalance_TextChanged(sender As Object, e As EventArgs) Handles txtboxNewBalance.TextChanged

        If txtboxNewBalance.Text = "0" Then
            lblBillingStatus.Text = "Complete"
        Else
            lblBillingStatus.Text = "Incomplete"
        End If


    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        'MsgBox("Total Gross: " & totalGross)
        'MsgBox("Total Balance: " & totalBalance)
        'MsgBox("Total Amount Paid: " & totalAmountPaid)
        'MsgBox("Total New Balance: " & totalNewBalance)
        'Exit Sub


        If txtboxAmountPaid.Text = "" Then
            MessageBox.Show("Tendered Amount cannot be empty", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        If AppID = "" Then

            Try
                ConnectDatabase()
                With sqlcmd
                    .Connection = DBConnection
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "checkPatBilling"
                    .Parameters.AddWithValue("@PatID", PatientRecordScreen.MyPatientID)
                    'MsgBox("Successful", MsgBoxStyle.Information, "Information")

                    myreader = sqlcmd.ExecuteReader
                    If myreader.Read() Then

                        AppID = myreader("AppointmentID")

                    End If
                End With
                DatabaseDisconnect()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
                DatabaseDisconnect()
            End Try

            ConnectDatabase()

            With sqlcmd
                Try
                    .Connection = DBConnection
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "updatePayment"
                    .Parameters.AddWithValue("@newTransactionID", newTransactionID)
                    .Parameters.AddWithValue("@PayID", PaymentId)
                    .Parameters.AddWithValue("@AppID", AppID)
                    .Parameters.AddWithValue("@Gross", totalGross)
                    .Parameters.AddWithValue("@Balance", totalBalance)
                    .Parameters.AddWithValue("@AmountPaid", totalAmountPaid)
                    .Parameters.AddWithValue("@NewBalance", totalNewBalance)
                    .Parameters.AddWithValue("@StatusBill", lblBillingStatus.Text)
                    .ExecuteNonQuery()
                    'MsgBox("Payment Updated", MsgBoxStyle.Information, "Information")

                    DatabaseDisconnect()

                    Me.Close()

                    ClearPatientPanel()

                    With Billing
                        .WindowState = FormWindowState.Maximized
                        .Dock = DockStyle.Fill And DockStyle.Bottom
                        .AutoSize = True
                        .TopLevel = False
                        PatientRecordScreen.PatientProfilePanel.Controls.Add(Billing)
                        .BringToFront()
                        .Show()
                    End With
                    Exit Sub

                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.Critical)
                    DatabaseDisconnect()
                    Exit Sub
                End Try
            End With
        Else
            ConnectDatabase()

            With sqlcmd
                Try
                    .Connection = DBConnection
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "updatePayment"
                    .Parameters.AddWithValue("@newTransactionID", newTransactionID)
                    .Parameters.AddWithValue("@PayID", PaymentId)
                    .Parameters.AddWithValue("@AppID", AppID)
                    .Parameters.AddWithValue("@Gross", totalGross)
                    .Parameters.AddWithValue("@Balance", totalBalance)
                    .Parameters.AddWithValue("@AmountPaid", totalAmountPaid)
                    .Parameters.AddWithValue("@NewBalance", totalNewBalance)
                    .Parameters.AddWithValue("@StatusBill", lblBillingStatus.Text)
                    .ExecuteNonQuery()
                    'MsgBox("Payment Updated", MsgBoxStyle.Information, "Information")

                    DatabaseDisconnect()
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.Critical)
                    DatabaseDisconnect()
                    Exit Sub
                End Try
            End With
        End If


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

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub EditBilling_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        HomeScreen.Enabled = True
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click


        If PrintDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            printUInvoice.PrinterSettings = PrintDialog1.PrinterSettings
        End If

        PrintPreviewDialog1.Document = printUInvoice
        PrintPreviewDialog1.StartPosition = FormStartPosition.CenterScreen

        PrintPreviewDialog1.ShowDialog()

    End Sub

    Private Sub printUInvoice_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles printUInvoice.PrintPage

        Dim invoice As New Bitmap(Me.pnlInvoice.Width, Me.pnlInvoice.Height)
        pnlInvoice.DrawToBitmap(invoice, New Rectangle(0, 0, Me.pnlInvoice.Width, Me.pnlInvoice.Height))
        e.Graphics.DrawImage(invoice, 0, 0)

        Dim psD As New PageSetupDialog
        psD.Document = printUInvoice

    End Sub

    Private Sub txtboxAmountPaid_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtboxAmountPaid.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = ".") Then
                e.Handled = True
            End If
        End If
    End Sub
End Class