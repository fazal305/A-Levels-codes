Imports System

Module BoatHireManager
    Sub Main()
        ' Example usage of the AddTime module
        Dim startTime As String = "09:00"
        Dim duration As Integer = 45

        ' Call the AddTime module and print the result
        Dim newTime As String = AddTime(startTime, duration)
        Console.WriteLine("New Time: " & newTime)

        ' Wait for user input before closing the console window
        Console.ReadLine()
    End Sub

    Function AddTime(StartTime As String, Duration As Integer) As String
        ' Convert the start time to a DateTime object for easy manipulation
        Dim startTimeAsDateTime As DateTime = DateTime.ParseExact(StartTime, "HH:mm", Nothing)

        ' Add the duration to the start time
        Dim endTimeAsDateTime As DateTime = startTimeAsDateTime.AddMinutes(Duration)

        ' Format the result as a string in the "HH:mm" format
        Dim newTime As String = endTimeAsDateTime.ToString("HH:mm")

        ' Return the new time as a string
        Return newTime
    End Function
End Module
