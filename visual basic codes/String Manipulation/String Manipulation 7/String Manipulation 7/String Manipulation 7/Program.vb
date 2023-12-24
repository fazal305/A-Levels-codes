Imports System



'7.
'both_ends:
'Input a String s, output a String made Of the first 2
'And the last 2 chars of the original string,
'so 'spring' yields 'spng'. However, if the string length
'Is less than 2, return string s instead the empty string.





Module Module1
    Sub Main()

        Console.Write("Enter a string: ")
        Dim inputString As String = Console.ReadLine()
        Dim result As String = both_ends(inputString)
        Console.WriteLine("Result: " & result)
        Console.ReadLine()

    End Sub

    Function both_ends(s As String) As String

        If Len(s) < 2 Then
            Return s
        Else
            Return Microsoft.VisualBasic.Left(s, 2) & Microsoft.VisualBasic.Right(s, 2)
        End If

    End Function

End Module



