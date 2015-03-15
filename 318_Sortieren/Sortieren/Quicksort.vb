Imports System.Threading.Tasks

Public Class Quicksort
    Inherits Sort
    Dim mbolSortUmlauts As Boolean

    ''' <summary>
    ''' Quicksorts an array
    ''' </summary>
    ''' <param name="arr">Unsorted array</param>
    ''' <returns>Sorted string</returns>
    Async Function Sort(ByVal arr As Array, ByVal bolSortUmlauts As Boolean) As Task(Of String)
        Dim QuickSortTask As Task(Of String) = Task.Factory.StartNew(Function()
                                                                         mbolSortUmlauts = bolSortUmlauts
                                                                         QuickPartition(arr, 0, arr.Length - 1)
                                                                         Return arrayToString(arr)
                                                                     End Function)
        Dim result As String = Await QuickSortTask
        Return result
    End Function

    ''' <summary>
    ''' Partitions and swaps an array recursively
    ''' </summary>
    ''' <param name="arr">Unsorted array</param>
    ''' <param name="loIdx">Lowest index to sort</param>
    ''' <param name="hiIdx">Highest index to sort</param>
    Sub QuickPartition(ByRef arr As Array, ByVal loIdx As Integer, ByVal hiIdx As Integer)
        Dim lo As Integer = loIdx
        Dim hi As Integer = hiIdx

        Dim pivot As Object = arr((lo + hi) \ 2) ' get center value
        Do Until lo > hi
            Do While isGreater(pivot, arr(lo), mbolSortUmlauts) ' check from left to right until char is >= pivot
                lo += 1
            Loop
            Do While isGreater(arr(hi), pivot, mbolSortUmlauts) ' check from right to left until char is <= pivot
                hi -= 1
            Loop
            If lo <= hi Then ' if lo is still smaller than hi it means something was on the wrong side
                Swap(arr, lo, hi)
                lo += 1
                hi -= 1
            End If
        Loop
        If (lo < hiIdx) Then QuickPartition(arr, lo, hiIdx)
        If (hi > loIdx) Then QuickPartition(arr, loIdx, hi)
    End Sub

End Class
