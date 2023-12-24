Imports System



'9.
'MixUp:
'Given strings a And b, Return a Single String With a And b separated
'by a space '<a> <b>', except swap the first 2 chars of each string.
'e.g.
'mix', pod' -> 'pox mid'
'dog', 'dinner' -> 'dig donner'
' Assume a And b are length 2 Or more.






Module Module1
    Sub Main()

        Console.WriteLine("Enter the first string:")
        Dim a As String = Console.ReadLine()

        Console.WriteLine("Enter the second string:")
        Dim b As String = Console.ReadLine()

        Dim result As String = MixUp(a, b)
        Console.WriteLine("Result: " & result)
        Console.ReadLine()
    End Sub

    Function MixUp(a As String, b As String) As String

        If a.Length >= 2 And b.Length >= 2 Then
            Dim mixedString As String = b.Substring(0, 2) & a.Substring(2) & " " & a.Substring(0, 2) & b.Substring(2)
            Return mixedString
        Else
            Return "Strings should be at least 2 characters long."
        End If
    End Function

End Module

