Imports System

Module Module1
    Sub Main()
        ' Sample sorted array to search
        Dim arr() As Integer = {1, 2, 3, 4, 5, 6, 7, 8, 9}

        ' Element to search for
        Dim searchElement As Integer = 5

        ' Perform binary search
        Dim index As Integer = BinarySearch(arr, searchElement)

        ' Display the result
        If index <> -1 Then
            Console.WriteLine($"Element {searchElement} found at index {index}.")
        Else
            Console.WriteLine($"Element {searchElement} not found in the array.")
        End If

        Console.ReadLine()
    End Sub

    Function BinarySearch(ByVal array() As Integer, ByVal target As Integer) As Integer
        Dim low As Integer = 0
        Dim high As Integer = array.Length - 1

        While low <= high
            Dim mid As Integer = (low + high) \ 2

            If array(mid) = target Then
                ' Element found, return its index
                Return mid
            ElseIf array(mid) < target Then
                ' If the target is greater, ignore the left half
                low = mid + 1
            Else
                ' If the target is smaller, ignore the right half
                high = mid - 1
            End If
        End While

        ' Element not found
        Return -1
    End Function
End Module

