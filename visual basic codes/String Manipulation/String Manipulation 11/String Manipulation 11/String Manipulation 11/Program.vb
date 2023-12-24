Imports System




'11.
'not_bad:
'Given a String, find the first appearance Of the
'substring 'not' and 'bad'. If the 'bad' follows
'the 'not', replace the whole 'not'...'bad' substring
'With 'good'.
'Return the resulting String.
'Input: 'This dinner is not that bad!' 
'Outputs: This dinner Is good!





Module Module1
    Sub Main()
        Console.WriteLine("Enter a string:")
        Dim userInput As String = Console.ReadLine()
        Dim result As String = ReplaceNotBad(userInput)
        Console.WriteLine("Output: " & result)
        Console.ReadLine()
    End Sub

    Function ReplaceNotBad(input As String) As String
        Dim notIndex As Integer = input.IndexOf("not")
        Dim badIndex As Integer = input.IndexOf("bad")

        If notIndex <> -1 AndAlso badIndex <> -1 AndAlso badIndex > notIndex Then
            Dim prefix As String = input.Substring(0, notIndex)
            Dim suffix As String = input.Substring(badIndex + 3)
            Return prefix & "good" & suffix
        End If
        Return input
    End Function

End Module

