Imports System


'10.
'verbing:
'Given a String, If its length Is at least 3,
'add 'ing' to its end.
'Unless it already ends In 'ing', in which case
'add 'ly' instead.
'If the String length Is less than 3, leave it unchanged.
'Return the resulting String.
'examples:
'input 'end' --> 'ending'
'input 'ending' --> 'endingly'
'input 'go' --> 'go'






Module MainModule
    Sub Main()
        Console.Write("Enter a string: ")
        Dim userInput As String = Console.ReadLine()
        Dim result As String = ModifyString(userInput)
        Console.WriteLine("Result: " & result)
        Console.ReadLine()
    End Sub

    Function ModifyString(input As String) As String

        If input.Length >= 3 Then
            If input.EndsWith("ing") Then
                Return input & "ly"
            Else
                Return input & "ing"
            End If
        Else
            Return input
        End If
    End Function

End Module

