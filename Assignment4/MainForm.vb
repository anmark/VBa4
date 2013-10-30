Public Class MainForm
    'Test variables
    Private Const totalNumberOfSeats As Integer = 240
    Private numOfReservedSeats As Integer = 0
    Private Const m_numOfSeats As Integer = 64


    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
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

        For i As Integer = 0 To totalNumberOfSeats - 1
            Dim strOut As String = String.Format("{0, 5} {1, -8} {2, -18} {3, 10:f2}", i + 1, "Vacant", customerName, price)
            lstSeats.Items.Add(strOut)
        Next

        'clear input controls
        txtName.Text = String.Empty
        txtPrice.Text = String.Empty

        'clear all output controls
        lblNumOfReservedSeats.Text = String.Empty
        lblNumOfVacantSeats.Text = String.Empty
        lblTotalNumberOfSeats.Text = totalNumberOfSeats.ToString()

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
    Private Sub UpdateGUI(ByVal customerName As String, ByVal price As Double)

        Dim index As Integer = lstSeats.SelectedIndex

        If (rbtnReserve.Checked) Then
            Dim strOut As String = String.Format("{0, 5} {1, -8} {2, -18} {3, 10:f2}", index + 1, "Reserved", customerName, price)
            numOfReservedSeats += 1
            lstSeats.Items.RemoveAt(index)
            lstSeats.Items.Insert(index, strOut)
        Else
            Dim strOut As String = String.Format("{0, 5} {1, -8} {2, -18} {3, 10:f2}", index + 1, "Vacant", "", 0.0)
            numOfReservedSeats -= 1
            lstSeats.Items.RemoveAt(index)
            lstSeats.Items.Insert(index, strOut)
        End If


        lblNumOfReservedSeats.Text = numOfReservedSeats.ToString()
        lblNumOfVacantSeats.Text = (totalNumberOfSeats - numOfReservedSeats).ToString()


    End Sub

    ''' <summary>
    ''' Event-handler method for the Click-event of the OK button.
    ''' When clicked, this method will be executed.
    ''' Calls the ReadAndValidateInput method, save its return value in a Boolean variable.
    ''' If return value is True, a call is made to the UpdateGUI method to display 
    ''' the updated results. 
    ''' </summary>
    ''' <param name="sender">Reference to the object that has fired the Click event (the button)</param>
    ''' <param name="e">Contains current information about the event.</param>
    ''' <remarks></remarks>
    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click

        Dim customerName As String = String.Empty
        Dim seatPrice As Double = 0.0

        'Dim inputOK As Boolean = ReadAndValidateInput()

        'if cancel reservation is selected, user input does not need to be validated
        If (rbtnCancel.Checked) Then
            If (itemIsSelected()) Then
                UpdateGUI(customerName, seatPrice)
            Else
                Return
            End If

        Else
            Dim inputOK As Boolean = ReadAndValidateInput(customerName, seatPrice)

            If (inputOK) Then
                If (itemIsSelected()) Then
                    UpdateGUI(customerName, seatPrice)
                Else
                    Return
                End If
            Else
                Return
            End If
        End If

    End Sub

    ''' <summary>
    ''' Checks wether a item is selected in the list.
    ''' Depending on what radiobutton is checked, the user is limited
    ''' to selecting either a vacant seat, or reserved seat
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function itemIsSelected() As Boolean
        'check if item is selected
        If (Not lstSeats.SelectedIndex >= 0) Then
            MessageBox.Show("No item selected!" & Environment.NewLine _
                            & " Please select a item in the list.", "Error!", _
                            MessageBoxButtons.OK, MessageBoxIcon.[Error])
            Return False
        Else
            Dim rowText As String = lstSeats.SelectedItem.ToString()
            If (rbtnReserve.Checked) Then
                If (rowText.Contains("Reserved")) Then
                    MessageBox.Show("Seat already reserved!" & Environment.NewLine _
                            & " Please select a vacant one.", "Error!", _
                            MessageBoxButtons.OK, MessageBoxIcon.[Error])
                    Return False
                End If
            Else
                If (rowText.Contains("Vacant")) Then
                    MessageBox.Show("Seat already vacant!" & Environment.NewLine _
                            & " Please select a reserved one.", "Error!", _
                            MessageBoxButtons.OK, MessageBoxIcon.[Error])
                    Return False
                End If
            End If
            Return True

        End If

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
