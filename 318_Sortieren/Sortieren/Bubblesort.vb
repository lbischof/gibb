Imports System.Threading.Tasks

Public Class Bubblesort
    Inherits Sort

    ''' <summary>
    ''' Bubblesorts an array
    ''' </summary>
    ''' <param name="arr">Unsorted array</param>
    ''' <returns>Sorted string</returns>
    Async Function Sort(ByVal arr As Array, ByVal bolSortUmlauts As Boolean) As Task(Of String)
        Dim BubbleSortTask As Task(Of String) = Task.Factory.StartNew(Function()
                                                                          Dim hi As Integer = arr.Length - 2 ' Subtract two because of zero based index and because we always check the following char. 
                                                                          For j = 0 To arr.Length - 1
                                                                              For i = 0 To hi
                                                                                  If isGreater(arr(i), arr(i + 1), bolSortUmlauts) Then
                                                                                      Swap(arr, i, i + 1)
                                                                                  End If
                                                                              Next
                                                                              hi -= 1
                                                                          Next
                                                                          Return arrayToString(arr)
                                                                      End Function)
        Dim result As String = Await BubbleSortTask
        Return result
    End Function
End Class
