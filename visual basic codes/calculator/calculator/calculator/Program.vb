Imports System

Module Module1
    Sub Main()
        ' Display calculator menu
        Console.WriteLine("Simple Calculator")
        Console.WriteLine("1. Addition")
        Console.WriteLine("2. Subtraction")
        Console.WriteLine("3. Multiplication")
        Console.WriteLine("4. Division")
        Console.WriteLine("5. Exit")

        ' Get user choice
        Console.Write("Enter your choice (1-5): ")
        Dim choice As Integer = Integer.Parse(Console.ReadLine())

        ' Perform calculation based on user choice
        Select Case choice
            Case 1
                PerformAddition()
            Case 2
                PerformSubtraction()
            Case 3
                PerformMultiplication()
            Case 4
                PerformDivision()
            Case 5
                ' Exit the program
                Console.WriteLine("Exiting the calculator. Goodbye!")
            Case Else
                ' Invalid choice
                Console.WriteLine("Invalid choice. Please enter a number between 1 and 5.")
        End Select

        ' Wait for user input before closing the console window
        Console.ReadLine()
    End Sub

    ' Function to perform addition
    Sub PerformAddition()
        Console.Write("Enter the first number: ")
        Dim num1 As Double = Double.Parse(Console.ReadLine())
        Console.Write("Enter the second number: ")
        Dim num2 As Double = Double.Parse(Console.ReadLine())
        Dim result As Double = num1 + num2
        Console.WriteLine($"Result: {num1} + {num2} = {result}")
    End Sub

    ' Function to perform subtraction
    Sub PerformSubtraction()
        Console.Write("Enter the first number: ")
        Dim num1 As Double = Double.Parse(Console.ReadLine())
        Console.Write("Enter the second number: ")
        Dim num2 As Double = Double.Parse(Console.ReadLine())
        Dim result As Double = num1 - num2
        Console.WriteLine($"Result: {num1} - {num2} = {result}")
    End Sub

    ' Function to perform multiplication
    Sub PerformMultiplication()
        Console.Write("Enter the first number: ")
        Dim num1 As Double = Double.Parse(Console.ReadLine())
        Console.Write("Enter the second number: ")
        Dim num2 As Double = Double.Parse(Console.ReadLine())
        Dim result As Double = num1 * num2
        Console.WriteLine($"Result: {num1} * {num2} = {result}")
    End Sub

    ' Function to perform division
    Sub PerformDivision()
        Console.Write("Enter the numerator: ")
        Dim numerator As Double = Double.Parse(Console.ReadLine())
        Console.Write("Enter the denominator: ")
        Dim denominator As Double = Double.Parse(Console.ReadLine())

        If denominator <> 0 Then
            Dim result As Double = numerator / denominator
            Console.WriteLine($"Result: {numerator} / {denominator} = {result}")
        Else
            Console.WriteLine("Error: Division by zero is not allowed.")
        End If
    End Sub
End Module

