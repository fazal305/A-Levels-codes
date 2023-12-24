Imports System


'3. Count And output the NUMBER of an entered character in a string.
'Also output separate counts for alphabets (cap & small together; case neutral),
'digits And other characters in same entered string. 



Module Module1
    Sub Main()

        Console.Write("Enter a string: ")
        Dim userInput As String = Console.ReadLine()
        Dim result As String = CountCharacters(userInput)
        Console.WriteLine(result)
        Console.ReadLine()

    End Sub

    Function CountCharacters(input As String) As String

        Dim alphabetCount As Integer = 0
        Dim digitCount As Integer = 0
        Dim otherCount As Integer = 0

        For Each ch As Char In input
            If Char.IsLetter(ch) Then
                alphabetCount += 1
            ElseIf Char.IsDigit(ch) Then
                digitCount += 1
            Else
                otherCount += 1
            End If
        Next

        Dim result As String = $"Alphabets: {alphabetCount} | Digits: {digitCount} | Other Characters: {otherCount}"
        Return result
    End Function

End Module

