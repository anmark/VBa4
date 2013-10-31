Option Explicit On
Option Strict On

'MainForm.vb
'Created: By Anmar Khazal 2013-10-31

Public Class MainForm
    'Test variables
    Private Const totalNumberOfSeats As Integer = 240
    Private numOfReservedSeats As Integer = 0
    Private Const m_numOfSeats As Integer = 2

    'Declare a reference variable of the SeatManager type
    Private m_seatManager As SeatManager

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        m_seatManager = New SeatManager(m_numOfSeats)
        InitializeGUI()

    End Sub

    ''' <summary>
    ''' Clears the input and output controls
    ''' and does some initializations.
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub InitializeGUI()
        Dim customerName As String = String.Empty
        Dim price As Double = 0.0
        rbtnReserve.Checked = True
        lstSeats.Items.Clear()

        'new way of initializing GUI
        UpdateGUI()

        'clear input controls
        txtName.Text = String.Empty
        txtPrice.Text = String.Empty

        'clear all output controls
        lblNumOfReservedSeats.Text = String.Empty
        lblNumOfVacantSeats.Text = String.Empty
        lblTotalNumberOfSeats.Text = m_seatManager.GetNumOfSeats.ToString

        ' Old way
        'For i As Integer = 0 To totalNumberOfSeats - 1
        ' Dim strOut As String = String.Format("{0, 5} {1, -8} {2, -18} {3, 10:f2}", i + 1, "Vacant", customerName, price)
        ' lstSeats.Items.Add(strOut)
        ' Next

        'continue with other init
    End Sub

    ''' <summary>
    ''' Updates the GUI depending on user input
    ''' Old item is removed in list and replaced with new item
    ''' with updated values
    ''' </summary>
    ''' <param name="customerName"></param>
    ''' <param name="price"></param>
    ''' <remarks></remarks>
    ''' Private Sub UpdateGUI(ByVal customerName As String, ByVal price As Double)
    Private Sub UpdateGUI()

        lstSeats.Items.Clear()

        'Update ListBox
        lstSeats.Items.AddRange(m_seatManager.GetSeatInfoStrings)

        'Updates all output controls
        lblNumOfReservedSeats.Text = m_seatManager.GetNumReserved().ToString
        lblNumOfVacantSeats.Text = m_seatManager.GetNumVacant().ToString
        lblTotalNumberOfSeats.Text = m_seatManager.GetNumOfSeats().ToString

        'Old way
        'Dim index As Integer = lstSeats.SelectedIndex
        'If (rbtnReserve.Checked) Then
        '    m_numOfSeats()
        '    Dim strout As String = String.Format("{0, 5} {1, -8} {2, -18} {3, 10:f2}", index + 1, "reserved", customername, price)
        '    numOfReservedSeats += 1
        '    lstSeats.Items.RemoveAt(index)
        '    lstSeats.Items.Insert(index, strout)
        'Else
        '    Dim strout As String = String.Format("{0, 5} {1, -8} {2, -18} {3, 10:f2}", index + 1, "vacant", "", 0.0)
        '    numOfReservedSeats -= 1
        '    lstSeats.Items.RemoveAt(index)
        '    lstSeats.Items.Insert(index, strout)
        'End If

        'lblNumOfReservedSeats.Text = numOfReservedSeats.ToString()
        'lblNumOfVacantSeats.Text = (totalNumberOfSeats - numOfReservedSeats).ToString()

    End Sub

    ''' <summary>
    ''' Event-handler method for the Click-event of the OK button.
    ''' When clicked, this method will be executed.
    ''' </summary>
    ''' <param name="sender">Reference to the object that has fired the Click event (the button)</param>
    ''' <param name="e">Contains current information about the event.</param>
    ''' <remarks></remarks>
    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        ReserveOrCancelSeat()
    End Sub

    ''' <summary>
    ''' Reserve or cancel a seat
    ''' 1. Check that the user has highlighted a row in the listbox
    '''    If no, give a friendly message to user and return.
    ''' 
    ''' 2. If the Reserve option button is checked,
    ''' 
    '''    2.a If the seat is already checked, 
    '''        confirm with the user to continue or return
    '''    2.b If continue, call ReadAndValidateInput to read the name
    '''        and price from the textboxes
    '''    2.c If reading is OK, call the m_seatMngr's Reserve method
    '''        to reserve the seat
    ''' 3. Else if the Cancel option button is checked,
    '''    Call the m_seatMngr's CancelReservation method.
    ''' 4. Call the UpdteGUI method to update the output controls.
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub ReserveOrCancelSeat()

        Dim customerName As String = String.Empty
        Dim seatPrice As Double = 0.0

        If (CheckSelectedIndex()) Then
            If (rbtnReserve.Checked) Then
                If (m_seatManager.GetSeatInfoAt(lstSeats.SelectedIndex).Contains("Reserved")) Then
                    Dim result = MessageBox.Show("The seat is already Reserved, Continue?", "Seat Already Reserved", MessageBoxButtons.OKCancel)
                    If result = DialogResult.OK Then
                        Dim inputOK As Boolean = ReadAndValidateInput(customerName, seatPrice)
                        If (inputOK) Then
                            m_seatManager.CancelSeat(lstSeats.SelectedIndex)
                            m_seatManager.ReserveSeat(customerName, seatPrice, lstSeats.SelectedIndex)
                            '2c
                        Else
                            MessageBox.Show("Error when reserving seat", "Error", MessageBoxButtons.OK)
                        End If
                        '2b
                    ElseIf result = DialogResult.Cancel Then
                        'Do nothing
                    End If
                    '2a
                Else
                    Dim inputOK As Boolean = ReadAndValidateInput(customerName, seatPrice)
                    If (inputOK) Then
                        m_seatManager.ReserveSeat(customerName, seatPrice, lstSeats.SelectedIndex)
                    Else
                        MessageBox.Show("Error when reserving seat", "Error", MessageBoxButtons.OK)
                    End If
                End If

            ElseIf (rbtnCancel.Checked) Then
                If (m_seatManager.GetSeatInfoAt(lstSeats.SelectedIndex).Contains("Reserved")) Then
                    Dim result = MessageBox.Show("Continue to cancel reservation?", "Cancel Reservation", MessageBoxButtons.OKCancel)
                    If result = DialogResult.OK Then
                        m_seatManager.CancelSeat(lstSeats.SelectedIndex)
                    Else
                        'Do nothing
                        'MessageBox.Show("The reservation was not canceled", "Error", MessageBoxButtons.OK)
                    End If
                End If
                '3

            End If
            '2
        End If
        '1
        UpdateGUI()
        '4

    End Sub

    ''' <summary>
    ''' The user must highlight an item in the ListBox before a 
    ''' reservation/cancelation can be performed. If an item in
    ''' the ListBox is not highlighted, give an error msg to the user.
    ''' </summary>
    ''' <returns>True if an item is highlighted, false otherwise.</returns>
    ''' <remarks></remarks>
    Private Function CheckSelectedIndex() As Boolean
        'check if item is selected
        If (lstSeats.SelectedIndex < 0) Then
            MessageBox.Show("No item selected!" & Environment.NewLine _
                            & " Please select a item in the list.", "Error!", _
                            MessageBoxButtons.OK, MessageBoxIcon.[Error])
            Return False
        End If

        Return True
        'Old way
        'Dim rowText As String = lstSeats.SelectedItem.ToString()
        'If (rbtnReserve.Checked) Then
        '    If (rowText.Contains("Reserved")) Then
        '        MessageBox.Show("Seat already reserved!" & Environment.NewLine _
        '                & " Please select a vacant one.", "Error!", _
        '                MessageBoxButtons.OK, MessageBoxIcon.[Error])
        '        Return False
        '    End If
        'Else
        '    If (rowText.Contains("Vacant")) Then
        '        MessageBox.Show("Seat already vacant!" & Environment.NewLine _
        '                & " Please select a reserved one.", "Error!", _
        '                MessageBoxButtons.OK, MessageBoxIcon.[Error])
        '        Return False
        '    End If
        'End If
        'Return True

    End Function

    ''' <summary>
    ''' Parse and validate user input.
    ''' The values are passed as parameters in method calls.
    ''' This method calls two other methods to read and validate name and price respectively.
    ''' </summary>
    ''' <returns>True if inpus is valid, False otherwise.</returns>
    ''' <remarks></remarks>
    Private Function ReadAndValidateInput(ByRef name As String, ByRef price As Double) As Boolean

        Dim goodName As Boolean = ReadAndValidateName(name)
        Dim goodPrice As Boolean = ReadAndValidatePrice(price)

        Return goodName And goodPrice

    End Function

    Private Function ReadAndValidateName(ByRef name As String) As Boolean

        name = txtName.Text.Trim()

        Dim goodName As Boolean = InputUtility.ValidateString(txtName.Text)

        'if the name is empty or null
        If (Not goodName) Then
            MessageBox.Show("Invalid input in name field! Name can't be empty, " & Environment.NewLine _
                            & "and must have at least one character (not blank)", "Error!", _
                            MessageBoxButtons.OK, MessageBoxIcon.[Error])
            txtName.Focus()
            txtName.Text = " "
            txtName.SelectAll()
            Return False
        Else
            'Name is not empty

            Return True
        End If

    End Function

    Private Function ReadAndValidatePrice(ByRef price As Double) As Boolean

        Dim goodPrice As Boolean = InputUtility.GetDouble(txtPrice.Text, price, 0)
        'if price is not negative digit
        If (Not goodPrice) Then
            MessageBox.Show("Invalid input in price field! Price can't be empty, " & Environment.NewLine _
                            & "or negative", "Error!", _
                            MessageBoxButtons.OK, MessageBoxIcon.[Error])
            txtPrice.Focus()
            txtPrice.Text = " "
            txtPrice.SelectAll()
            Return False
        Else
            'Price is correct
            Return True
        End If

    End Function

    Private Sub rbtnReserve_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnReserve.CheckedChanged
        txtName.Enabled = True
        txtPrice.Enabled = True
    End Sub


    Private Sub rbtnCancel_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnCancel.CheckedChanged
        txtName.Enabled = False
        txtPrice.Enabled = False
    End Sub

End Class
