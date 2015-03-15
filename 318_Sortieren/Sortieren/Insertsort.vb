Imports System.Threading.Tasks

Public Class Insertsort
    Inherits Sort

    ''' <summary>
    ''' Insertsorts an array
    ''' </summary>
    ''' <param name="arr">Unsorted array</param>
    ''' <returns>Sorted string</returns>
    Async Function Sort(ByVal arr As Array, ByVal bolSortUmlauts As Boolean) As Task(Of String)
        Dim InsertSortTask As Task(Of String) = Task.Factory.StartNew(Function()
                                                                          Dim lo As Integer = 0
                                                                          Dim hi As Integer = arr.Length - 1
                                                                          Dim t As Object
                                                                          Dim j As Integer = 0
                                                                          ' sort chars[lo..hi]
                                                                          For i = lo + 1 To hi
                                                                              t = arr(i)
                                                                              j = i - 1
                                                                              ' shift elements down until insertion point found
                                                                              While j >= lo AndAlso isGreater(arr(j), t, bolSortUmlauts)
                                                                                  arr(j + 1) = arr(j)
                                                                                  j -= 1
                                                                              End While

                                                                              ' insert
                                                                              arr(j + 1) = t
                                                                          Next

                                                                          Return arrayToString(arr)
                                                                      End Function)
        Dim result As String = Await InsertSortTask
        Return result
    End Function
End Class
