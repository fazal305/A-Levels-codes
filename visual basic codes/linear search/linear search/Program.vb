Imports System

Module Module1
    Sub Main()
        ' Sample array to search
        Dim arr() As Integer = {4, 2, 7, 1, 9, 5, 8, 3, 6}

        ' Element to search for
        Dim searchElement As Integer = 5

        ' Perform linear search
        Dim index As Integer = LinearSearch(arr, searchElement)

        ' Display the result
        If index <> -1 Then
            Console.WriteLine($"Element {searchElement} found at index {index}.")
        Else
            Console.WriteLine($"Element {searchElement} not found in the array.")
        End If

        Console.ReadLine()
    End Sub

    Function LinearSearch(ByVal array() As Integer, ByVal target As Integer) As Integer
        For i As Integer = 0 To array.Length - 1
            If array(i) = target Then
                ' Element found, return its index
                Return i
            End If
        Next

        ' Element not found
        Return -1
    End Function
End Module
