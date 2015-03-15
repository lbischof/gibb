
Imports System.Text

Public Class Sort

    ''' <summary>
    ''' Swaps two objects at given positions in array
    ''' </summary>
    ''' <param name="input">Input array</param>
    ''' <param name="a">First index</param>
    ''' <param name="b">Second index</param>
    Sub Swap(ByRef input As Array, ByVal a As Integer, ByVal b As Integer)
        Dim charTmp As Object = input(a)
        input(a) = input(b)
        input(b) = charTmp
    End Sub

    ''' <summary>
    ''' Converts an array to a string
    ''' </summary>
    ''' <param name="arr">The Array</param>
    ''' <returns>All the array elements concatenated to a string</returns>
    Function arrayToString(ByVal arr As Array) As String
        If TypeOf arr Is String() Then
            Return String.Join(" ", DirectCast(arr, String()))
        Else
            Return New String(arr)
        End If
    End Function

    ''' <summary>
    ''' Checks if a is greater than b
    ''' </summary>
    ''' <param name="a">First element</param>
    ''' <param name="b">Second element</param>
    ''' <param name="bolSortUmlauts">Specify if umlauts should be handled as normal characters</param>
    ''' <returns>True or false depending if a is greater than b</returns>
    Function isGreater(ByVal a As Object, ByVal b As Object, ByVal bolSortUmlauts As Boolean) As Boolean
        If bolSortUmlauts Then
            Return String.Compare(a, b, Globalization.CultureInfo.CurrentCulture, Globalization.CompareOptions.IgnoreNonSpace) > 0
        Else
            Return String.Compare(a, b, Globalization.CultureInfo.CurrentCulture, Globalization.CompareOptions.Ordinal) > 0
        End If
    End Function
End Class
