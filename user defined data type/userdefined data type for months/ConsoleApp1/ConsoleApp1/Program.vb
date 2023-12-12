Imports System

Module Module1

    ' Define the custom type
    Enum Months
        January
        February
        March
        April
        May
        June
        July
        August
        September
        October
        November
        December
    End Enum

    Sub Main()
        ' Example usage
        Dim currentMonth As Months = Months.January
        Console.WriteLine("Current month: " & currentMonth.ToString())

        ' You can use the 'currentMonth' variable in your code as needed

        ' Wait for user input before closing the console window
        Console.ReadLine()
    End Sub

End Module

