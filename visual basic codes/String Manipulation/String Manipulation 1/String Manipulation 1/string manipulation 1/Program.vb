Imports System.Linq


'1. Find if the input string has all the alphabets (case neutral).


Module Module1
    Sub Main()

        Console.WriteLine("Enter a string:")
        Dim inputString As String = Console.ReadLine()
        Dim result As Boolean = CheckAlphabets(inputString)

        If result Then
            Console.WriteLine("The input string contains all alphabets.")
        Else
            Console.WriteLine("The input string does not contain all alphabets.")
        End If
        Console.ReadLine()
    End Sub

    Function CheckAlphabets(inputString As String) As Boolean

        Dim allAlphabets As String = "abcdefghijklmnopqrstuvwxyz"
        inputString = inputString.ToLower()
        allAlphabets = allAlphabets.ToLower()

        For Each letter As Char In allAlphabets
            If Not inputString.Contains(letter) Then
                Return False
            End If
        Next

        Return True
    End Function

End Module


