Imports System



'6.
'donuts:
'INPUT an INT count Of a number Of donuts, OUTPUT a String
'of the form 'Number of donuts: <count>', where <count> is the number
'input.However, If the count Is 10 Or more, then use the word 'many'
'instead of the actual count.
'So donuts(5) outputs 'Number of donuts: 5'
'And donuts(23) outputs 'Number of donuts: many'




Module Module1
    Sub Main()

        Console.WriteLine("Enter the number of donuts:")

        Dim userInput As String = Console.ReadLine()
        Dim donutCount As Integer

        If Integer.TryParse(userInput, donutCount) Then
            Console.WriteLine(Donuts(donutCount))
        Else
            Console.WriteLine("Invalid input. Please enter a valid number.")
        End If
        Console.ReadLine()

    End Sub

    Function Donuts(count As Integer) As String

        If count >= 10 Then
            Return "Number of donuts: many"
        Else
            Return "Number of donuts: " & count.ToString()
        End If

    End Function

End Module


