Imports System

Module Program
    Sub Main()

    End Sub
    Function CalcPoints(CardNum As String, Total As Double) As Integer
        ' Declare variables
        Dim OldPoints As Integer
        Dim NewPoints As Integer

        ' Call the GetPoints function to get the number of points already collected
        OldPoints = GetPoints(CardNum)

        ' Calculate the new points based on the total amount spent
        If Total < 50 Then
            NewPoints = 0
        ElseIf Total >= 50 And Total < 100 Then
            NewPoints = Int(Total / 5)
        Else
            NewPoints = Int(Total / 3)
        End If

        ' Return the total points (old points + new points)
        Return OldPoints + NewPoints
    End Function

    ' Example function to simulate GetPoints function
    Function GetPoints(CardNum As String) As Integer
        ' This is a placeholder function; you should implement the actual logic
        ' to retrieve the number of points based on the card number from your data source
        ' For now, return a static value for testing purposes
        Return 100
    End Function
    Function GetTotal() As Double
        ' Declare variable to store the user input
        Dim totalAmount As Double

        ' Prompt user to enter the total amount
        Do
            Console.Write("Enter the total amount: ")
            Dim userInput As String = Console.ReadLine()

            ' Attempt to convert the user input to a double
            If Double.TryParse(userInput, totalAmount) Then
                ' Check if the entered value is valid
                If totalAmount > 0 AndAlso totalAmount < 10000 Then
                    ' Valid input, break out of the loop
                    Exit Do
                Else
                    ' Invalid input, prompt the user to re-enter the value
                    Console.WriteLine("Invalid input. Please enter a value greater than 0 and less than 10000.")
                End If
            Else
                ' Invalid input (not a valid double), prompt the user to re-enter the value
                Console.WriteLine("Invalid input. Please enter a valid numeric value.")
            End If
        Loop While True

        ' Return the valid total amount
        Return totalAmount
    End Function
End Module
