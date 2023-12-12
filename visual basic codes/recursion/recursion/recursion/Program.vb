Imports System

Module MainModule
    Sub Main()
        Dim number As Integer = 5
        Dim result As Integer = Factorial(number)

        Console.WriteLine($"Factorial of {number} is {result}")
        Console.ReadLine()
    End Sub

    Function Factorial(ByVal n As Integer) As Integer
        ' Base case: factorial of 0 is 1
        If n = 0 Then
            Return 1
        End If

        ' Recursive case: n! = n * (n-1)!
        Return n * Factorial(n - 1)
    End Function
End Module

