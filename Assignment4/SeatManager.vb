Option Explicit On
Option Strict On

'SeatManager.vb
'Created: By Anmar Khazal 2013-10-31

Public Class SeatManager
    'Input variables
    'initialized in the constructor
    Private ReadOnly m_totNumOfSeats As Integer
    'array for storing customer names
    Private ReadOnly m_nameList() As String = Nothing
    'array for storing seat prices
    Private ReadOnly m_priceList() As Double = Nothing


    'Private ReadOnly m_totNumOfRows As Integer
    'Private ReadOnly m_totNumOfCols As Integer

    '2-dim array for storing customer seat names
    'Private m_nameMatrix As String(,)

    '2-dim array for storing seat prices
    'sPrivate m_priceMatrix As Integer(,)

    ''' <summary>
    ''' a constructor which initiates the size of the arrays
    ''' </summary>
    Public Sub New(ByVal maxNumberOfSeats As Integer)
        'Public Sub New(ByVal totNumOfRows As Integer, ByVal totNumOfCols As Integer)
        'only time m_totNumOfRows and m_totNumOfCols can be assigned values
        m_totNumOfSeats = maxNumberOfSeats
        m_nameList = New String(m_totNumOfSeats) {}
        m_priceList = New Double(m_totNumOfSeats) {}
        'm_totNumOfRows = New Integer(totNumOfRows) {}
        'm_totNumOfCols = New Integer(totNumOfCols) {}
        ' m_totNumOfRows = totNumOfRows
        ' m_totNumOfCols = totNumOfCols

        'create price and matrix with size based on constructor input
        'm_priceMatrix = New Integer(m_totNumOfRows - 1, m_totNumOfCols - 1) {}
        'm_nameMatrix = New String(m_totNumOfRows - 1, m_totNumOfCols - 1) {}

    End Sub

    ''' <summary>
    ''' Check so the value of an index is within the array range,
    ''' i.e. index >=0 and index is less than m_totNumOfSeats
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function CheckIndex(ByVal index As Integer) As Boolean
        If (index >= 0 And index < m_totNumOfSeats) Then
            Return True
        Else
            Return False
        End If
    End Function

    ''' <summary>
    ''' Calculate the number of seats reserved
    ''' </summary>
    ''' <returns>Number of reserved seats</returns>
    ''' <remarks></remarks>
    Public Function GetNumReserved() As Integer
        Dim numberOfReservedSeats As Integer = 0
        ' Loop over each element
        For Each name As String In m_nameList
            If (Not String.IsNullOrEmpty(name)) Then
                numberOfReservedSeats += 1
            End If
        Next
        Return numberOfReservedSeats
    End Function

    ''' <summary>
    ''' Calculate the number of seats not reserved
    ''' </summary>
    ''' <returns>Number of vacant seats</returns>
    ''' <remarks></remarks>
    Public Function GetNumVacant() As Integer
        Dim numberOfVacantSeats As Integer = -1
        ' Loop over each element
        For Each name As String In m_nameList
            If (String.IsNullOrEmpty(name)) Then
                numberOfVacantSeats += 1
            End If
        Next
        Return numberOfVacantSeats
    End Function

    ''' <summary>
    ''' Get total number of seats. 
    ''' </summary>
    ''' <returns>Total number of seats</returns>
    ''' <remarks></remarks>
    Public Function GetNumOfSeats() As Integer
        Return m_totNumOfSeats
    End Function

    ''' <summary>
    ''' Adds a reservation, Save name in the nameList and the price in the priceList
    ''' in the position that equals index
    ''' </summary>
    ''' <param name="name">Name of the customer</param>
    ''' <param name="price">Price of the seat</param>
    ''' <param name="index">Index of the array position</param>
    ''' <returns>True if seat is successfully reserved, False if it is already occupied </returns>
    ''' <remarks></remarks>
    Public Function ReserveSeat(ByVal name As String, ByVal price As Double, _
                          ByVal index As Integer) As Boolean
        If (CheckIndex(index)) Then
            If (String.IsNullOrEmpty(m_nameList(index))) Then
                m_nameList(index) = name
                m_priceList(index) = price
                Return True
            Else
                Return False
            End If

        End If
    End Function



    ''' <summary>
    ''' Cancel a reservation. Assign a value Nothing in the nameList, and 0.0 in
    ''' the priceList at the position that equals index
    ''' </summary>
    ''' <param name="index">Index for array position</param>
    ''' <returns>True if seat was successfully canceled, false if the seat is already vacant</returns>
    ''' <remarks></remarks>
    Public Function CancelSeat(ByVal index As Integer) As Boolean
        If (CheckIndex(index)) Then
            If (Not String.IsNullOrEmpty(m_nameList(index))) Then
                m_nameList(index) = Nothing
                m_priceList(index) = 0.0
                Return True
            Else
                Return False
            End If
        End If
    End Function

    ''' <summary>
    ''' Returns tha status for a seat in a position = index
    ''' </summary>
    ''' <param name="index">Index of the array position</param>
    ''' <returns>A formatted string containing information about the seat, customer name
    ''' price and whether the seat is reserved or vacant.</returns>
    ''' <remarks></remarks>
    Public Function GetSeatInfoAt(ByVal index As Integer) As String
        Dim status As String
        If (CheckIndex(index)) Then
            If (String.IsNullOrEmpty(m_nameList(index))) Then
                status = "Vacant"
            Else
                status = "Reserved"
            End If

            Dim customerName As String = m_nameList(index)
            Dim price As Double = m_priceList(index)
            Dim seatInfo As String = String.Format("{0, 5} {1, -8} {2, -18} {3, 10:f2}", index + 1, status, customerName, price)
            Return seatInfo
        End If

        Return "Index Error"
    End Function

    ''' <summary>
    ''' This method prepares an array of strings with information about all seats.
    ''' Each element is a string formatted using the GetSeatInfo function.
    ''' </summary>
    ''' <param name="choice"></param>
    ''' <returns>An array of strings</returns>
    ''' <remarks></remarks>
    ''' Public Function GetSeatInfoStrings(ByVal choice As DisplayOptions) As String()
    Public Function GetSeatInfoStrings() As String()
        'Dim count As Integer = GetNumOfSeats(choice)
        Dim count As Integer = GetNumOfSeats()

        If (count <= 0) Then
            Return Nothing
        End If

        Dim strSeatInfoStrings As String() = New String(count - 1) {}

        Dim i As Integer = 0 'needed for the strSeatInfo
        'its the element corresponding with the index empty
        For index As Integer = 0 To m_totNumOfSeats - 1
            strSeatInfoStrings(index) = GetSeatInfoAt(index)
        Next

        Return strSeatInfoStrings
    End Function

    ''' <summary>
    ''' Determines the index for an element at (row, col) that corresponding to a position 
    ''' in a one-dim representation of the matrix. Think of the matrix as being rolled out into a one
    ''' dimensional array. In a 3 x 3 matrix, the element in 
    ''' position (1,1) has index 4 in a one dimensional array.
    '''       20 11 22
    '''       33 41 55
    '''       60 7  99 consider value (1,1) = 41
    ''' The above matrix can now be represented as a one-dimensional arraay. This makes 
    ''' it easier to update the listbox in the GUI.
    '''       20 11 22 33 41 55 60 7 99    value(4) = 41
    ''' Index 0  1  2  3  4  5  6  7 8
    ''' 
    ''' Hence, index (1,1) in the matrix corresponds to row 4 in the listbox (one-dim array). 
    ''' </summary>
    ''' <param name="row">row number</param>
    ''' <param name="col">column number</param>
    ''' <returns>The new index as explained above.</returns>
    ''' <remarks></remarks>
    Public Function MatrixIndexToVectorIndex(ByVal row As Integer, ByVal col As Integer) As Integer
        ' Dim index As Integer = row * m_totNumOfCols + col
        'Return index
    End Function

    ''' <summary>
    ''' Determines the index in the matrix (row, col) that corresponds to a given 
    ''' index in a one-dim array (listbox). This method actually is a reverse process of
    ''' the method MatrixIndexToVectorIndex (see above). The paramater row contains
    ''' the inpu, i.e. index of the element in a one-dim array. The results (row and col)
    ''' are saved and sent back to the caller via the reference variables row, col.    ''' 
    ''' </summary>
    ''' <param name="row">Input and output parameter</param>
    ''' <param name="col">Output parameter</param>
    ''' <remarks></remarks>
    Public Sub VectorIndexToMatrixIndex(ByRef row As Integer, ByRef col As Integer)
        Dim vectorRow As Integer = row      'row in a vector
        'row = Math.Ceiling((vectorRow / m_totNumOfCols))    'row in a matrix
        'col = vectorRow Mod m_totNumOfCols
    End Sub


End Class
