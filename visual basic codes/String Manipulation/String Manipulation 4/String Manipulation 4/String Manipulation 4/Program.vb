Imports System


'4. Find the character that appears most number of times in an entered string And output it.


Module Module1
    Sub Main()

        Console.Write("Enter a string: ")
        Dim userInput As String = Console.ReadLine()
        Dim mostFrequentChar As Char = FindMostFrequentCharacter(userInput)

        Console.WriteLine($"The most frequent character is: {mostFrequentChar}")

        Console.ReadLine()

    End Sub

    Function FindMostFrequentCharacter(inputString As String) As Char

        Dim charFrequency As New Dictionary(Of Char, Integer)

        For Each c As Char In inputString
            If charFrequency.ContainsKey(c) Then
                charFrequency(c) += 1
            Else
                charFrequency(c) = 1
            End If
        Next

        Dim maxChar As Char = Char.MinValue
        Dim maxFrequency As Integer = 0

        For Each kvp As KeyValuePair(Of Char, Integer) In charFrequency
            If kvp.Value > maxFrequency Then
                maxChar = kvp.Key
                maxFrequency = kvp.Value
            End If
        Next

        Return maxChar
    End Function

End Module


