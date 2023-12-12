Imports System
Module Module1

    Sub Main()
        Dim Forever As Boolean = False
        Dim NumberOfFloors As Integer = 5 ' Replace with the actual number of floors
        Dim NumberOfSensors As Integer = 10 ' Replace with the actual number of sensors

        Do
            For FloorCounter As Integer = 1 To NumberOfFloors
                For SensorCounter As Integer = 1 To NumberOfSensors
                    ' Assuming you have a function or method to read the sensor value
                    Dim sensorValue As Integer = ReadSensor(SensorCounter, FloorCounter)

                    ' Check if the sensor value is outside the range
                    If IsSensorValueOutsideRange(sensorValue) Then
                        Console.WriteLine("Problem on Floor " & FloorCounter & ", Sensor " & SensorCounter)
                    End If
                Next SensorCounter
            Next FloorCounter

            ' Delay loop - adjust the delay time as needed (in milliseconds)
            System.Threading.Thread.Sleep(1000) ' 1000 milliseconds = 1 second

        Loop Until Forever = True
    End Sub

    ' Replace with your actual sensor reading function
    Function ReadSensor(sensorNumber As Integer, floorNumber As Integer) As Integer
        ' Replace with your logic to read the sensor value
        ' For now, return a dummy value (replace with your actual implementation)
        Return 0
    End Function

    ' Replace with your actual range check logic
    Function IsSensorValueOutsideRange(sensorValue As Integer) As Boolean
        ' Replace with your logic to check if the sensor value is outside the range
        ' For now, return a dummy value (replace with your actual implementation)
        Return False
    End Function

End Module

