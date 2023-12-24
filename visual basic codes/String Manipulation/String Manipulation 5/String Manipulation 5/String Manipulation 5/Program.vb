Imports System



'5. Find the count of vowels characters in an entered string separately. 



Module Module1
    Sub Main()

        Console.Write("Enter a string: ")
        Dim userInput As String = Console.ReadLine()

        userInput = userInput.ToUpper()

        Dim countA, countE, countI, countO, countU As Integer
        countA = countE = countI = countO = countU = 0

        For Each ch As Char In userInput
            Select Case ch
                Case "A"
                    countA += 1
                Case "E"
                    countE += 1
                Case "I"
                    countI += 1
                Case "O"
                    countO += 1
                Case "U"
                    countU += 1
            End Select
        Next

        Console.WriteLine("Count of 'A': " & countA)
        Console.WriteLine("Count of 'E': " & countE)
        Console.WriteLine("Count of 'I': " & countI)
        Console.WriteLine("Count of 'O': " & countO)
        Console.WriteLine("Count of 'U': " & countU)

        Console.ReadLine()
    End Sub
End Module



