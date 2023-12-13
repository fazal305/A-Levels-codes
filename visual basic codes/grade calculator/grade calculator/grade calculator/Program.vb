Imports System

Module GradeCalculator
    Sub Main()
        ' Example usage of the GradeCalculator module
        Dim score As Integer = 85

        ' Call the GetGrade function and print the result
        Dim grade As String = GetGrade(score)
        Console.WriteLine("Score: " & score & " - Grade: " & grade)

        ' Wait for user input before closing the console window
        Console.ReadLine()
    End Sub

    Function GetGrade(score As Integer) As String
        ' Use an If statement to determine the grade based on the score
        If score >= 90 Then
            Return "A"
        ElseIf score >= 80 Then
            Return "B"
        ElseIf score >= 70 Then
            Return "C"
        ElseIf score >= 60 Then
            Return "D"
        Else
            Return "U"
        End If
    End Function
End Module

