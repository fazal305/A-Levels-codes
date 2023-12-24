Imports System


'2. Replace selected character with another in entered string.


Module Module1
    Sub Main()

        Console.Write("Enter a string: ")
        Dim userInput As String = Console.ReadLine()

        Console.Write("Enter the character to replace: ")
        Dim charToReplace As Char = Console.ReadLine()(0)

        Console.Write("Enter the replacement character: ")
        Dim replacementChar As Char = Console.ReadLine()(0)
        Dim resultString As String = ReplaceCharacter(userInput, charToReplace, replacementChar)

        Console.WriteLine("Result: " & resultString)
        Console.ReadLine()

    End Sub

    Function ReplaceCharacter(originalString As String, charToReplace As Char, replacementChar As Char) As String
        Dim resultString As String = originalString.Replace(charToReplace, replacementChar)
        Return resultString
    End Function

End Module


