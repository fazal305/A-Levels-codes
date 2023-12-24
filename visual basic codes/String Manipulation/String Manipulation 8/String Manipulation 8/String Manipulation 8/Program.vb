Imports System



'8.
'fix_start:
'Given a String s, Return a String
'where all occurences Of its first Char have
'been changed To '*', except do not change
'the first Char itself.
'e.g., 'babble' yields 'ba*le' or 'alpha' outputs 'alph'
'Assume that the String Is length 1 Or more




Module Module1

    Sub Main()

        Console.Write("Enter a string: ")
        Dim inputString As String = Console.ReadLine()
        Dim result As String = FixStart(inputString)
        Console.WriteLine("Result: " & result)
        Console.ReadLine()
    End Sub

    Function FixStart(input As String) As String

        If String.IsNullOrEmpty(input) Then
            Return "Input string is empty."
        End If

        Dim firstChar As Char = input(0)
        Dim modifiedString As String = firstChar & input.Substring(1).Replace(firstChar, "*")
        Return modifiedString

    End Function

End Module


