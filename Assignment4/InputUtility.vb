Option Explicit On
Option Strict On



''' <summary>
''' This is a helper class that
''' checks if the input is of the desired type
''' 
''' </summary>
''' <remarks></remarks>
Public Class InputUtility
    ''' <summary>
    ''' GetInteger
    ''' Converts a text representing an integer to an Integer value.
    ''' </summary>
    ''' <param name="stringToConvert">The string to be converted.</param>
    ''' <param name="intOutValue">The converted Integer value. If the conversion is successful
    ''' this variable will have a valid value, otherwise it is initiated to zero.</param>
    ''' <returns>True if the conversion is successful and False otherwise.</returns>
    ''' <remarks></remarks>
    Public Shared Function GetInteger(ByVal stringToConvert As String, ByRef intOutValue As Integer) As Boolean

        Dim goodNumber As Boolean = Integer.TryParse(stringToConvert, intOutValue)
        Return goodNumber

    End Function

    ''' <summary>
    ''' GetInteger
    ''' Converts a text representing an integer to an Integer value, and validates
    ''' the converted value to be within the range minLimit and maxLimit
    ''' </summary>
    ''' <param name="stringToConvert">The string to be converted.</param>
    ''' <param name="intOutValue">The converted Integer value. If the conversion is successful
    ''' this variable will have a valid value, otherwise it is initiated to zero.</param>
    ''' <returns>True if the conversion is successful and converted value is within the range
    ''' minLimit and maxLimit, False otherwise.</returns>
    ''' <remarks></remarks>
    Public Shared Function GetInteger(ByVal stringToConvert As String, ByRef intOutValue As Integer, _
                                       ByVal minLimit As Integer, ByVal maxLimit As Integer) As Boolean

        Dim goodNumber As Boolean = Integer.TryParse(stringToConvert, intOutValue)

        If (goodNumber) Then
            goodNumber = intOutValue >= minLimit And intOutValue <= maxLimit
        End If

        Return goodNumber

    End Function

    ''' <summary>
    ''' GetDouble
    ''' Converts a text representing a double to an Double value.
    ''' </summary>
    ''' <param name="stringToConvert">The string to be converted.</param>
    ''' <param name="dblOutValue">The converted Double value. If the conversion is successful
    ''' this variable will have a valid value, otherwise it is initiated to zero.</param>
    ''' <returns>True if the conversion is successful and False otherwise.</returns>
    ''' <remarks></remarks>
    Public Shared Function GetDouble(ByVal stringToConvert As String, ByRef dblOutValue As Double) As Boolean

        Dim goodNumber As Boolean = Double.TryParse(stringToConvert, dblOutValue)
        Return goodNumber

    End Function
    ''' <summary>
    ''' GetDouble
    ''' Converts a text representing an double to an Double value, and validates
    ''' the converted value to be within the range minLimit and maxLimit
    ''' </summary>
    ''' <param name="stringToConvert">The string to be converted.</param>
    ''' <param name="dblOutValue">The converted Double value. If the conversion is successful
    ''' this variable will have a valid value, otherwise it is initiated to zero.</param>
    ''' <returns>True if the conversion is successful and converted value is within the range
    ''' >= minLimit, False otherwise.</returns>
    ''' <remarks></remarks>
    Public Shared Function GetDouble(ByVal stringToConvert As String, ByRef dblOutValue As Double, _
                                       ByVal minLimit As Double) As Boolean

        Dim goodNumber As Boolean = GetDouble(stringToConvert, dblOutValue, minLimit, Integer.MaxValue)

        Return goodNumber

    End Function

    ''' <summary>
    ''' GetDouble
    ''' Converts a text representing an double to an Double value, and validates
    ''' the converted value to be within the range minLimit and maxLimit
    ''' </summary>
    ''' <param name="stringToConvert">The string to be converted.</param>
    ''' <param name="dblOutValue">The converted Double value. If the conversion is successful
    ''' this variable will have a valid value, otherwise it is initiated to zero.</param>
    ''' <returns>True if the conversion is successful and converted value is within the range
    ''' minLimit and maxLimit, False otherwise.</returns>
    ''' <remarks></remarks>
    Public Shared Function GetDouble(ByVal stringToConvert As String, ByRef dblOutValue As Double, _
                                       ByVal minLimit As Double, ByVal maxLimit As Double) As Boolean

        Dim goodNumber As Boolean = Double.TryParse(stringToConvert, dblOutValue)

        If (goodNumber) Then
            goodNumber = dblOutValue >= minLimit And dblOutValue <= maxLimit
        End If

        Return goodNumber

    End Function

    ''' <summary>
    ''' GetPositiveInteger
    ''' Converts a string represented Integer value to an Integer type, and validates
    ''' the converted value to be >= 0
    ''' </summary>
    ''' <param name="stringToConvert">String representing the Integer value.</param>
    ''' <param name="intOutValue">The converted Integer value. If the conversion is successful
    ''' this variable will have a valid value, otherwise it is initiated to zero.</param>
    ''' <returns>True if the conversion is successful and the converted value >=0, False otherwise.</returns>
    ''' <remarks></remarks>
    Public Shared Function GetPositiveInteger(ByVal stringToConvert As String, ByRef intOutValue As Integer) As Boolean

        Dim goodNumber As Boolean = Integer.TryParse(stringToConvert, intOutValue)
        If (goodNumber) Then
            goodNumber = intOutValue >= 0
        End If

        Return goodNumber

    End Function

    ''' <summary>
    ''' GetPositiveDouble
    ''' Converts a string represented Double value to an Double type, and validates
    ''' the converted value to be >= 0
    ''' </summary>
    ''' <param name="stringToConvert">String representing the Double value.</param>
    ''' <param name="doubleOutValue">The converted Double value. If the conversion is successful
    ''' this variable will have a valid value, otherwise it is initiated to zero.</param>
    ''' <returns>True if the conversion is successful and the converted value >=0, False otherwise.</returns>
    ''' <remarks></remarks>
    Public Shared Function GetPositiveDouble(ByVal stringToConvert As String, ByRef doubleOutValue As Double) As Boolean

        Dim goodNumber As Boolean = Double.TryParse(stringToConvert, doubleOutValue)
        If (goodNumber) Then
            goodNumber = doubleOutValue >= 0
        End If

        Return goodNumber

    End Function

    ''' <summary>
    ''' ValidateString
    ''' Validates a string for not being null or empty.
    ''' </summary>
    ''' <param name="stringIn">The string to be validated.</param>
    ''' <returns>True if the validation is successful and False otherwise.</returns>
    ''' <remarks></remarks>
    Public Shared Function ValidateString(stringIn As String) As Boolean

        Dim strIn = stringIn.Trim() 'delete leading and trailing spaces
        Return Not String.IsNullOrEmpty(strIn)

    End Function

End Class
