Imports System
Module Program
    Dim Jobs(99, 1) As Integer
    Dim NumberOfJobs As Integer
    Sub Initialise()
        For X = 0 To 99
            For Y = 0 To 1
                Jobs(X, Y) = -1
            Next
        Next
        NumberOfJobs = 0
    End Sub
    Sub AddJob(JobNumber, Priority)
        If NumberOfJobs = 100 Then
            Console.WriteLine("Not added")
        Else
            Jobs(NumberOfJobs, 0) = JobNumber
            Jobs(NumberOfJobs, 1) = Priority
            NumberOfJobs = NumberOfJobs + 1
            Console.WriteLine("Added")
        End If
    End Sub
    Sub Main()
        Initialise()
        AddJob(12, 10)
        AddJob(526, 9)
        AddJob(33, 8)
        AddJob(12, 9)
        AddJob(78, 1)
        InsertionSort()
        PrintArray()
    End Sub
    Sub InsertionSort()
        Dim Tempa As Integer
        Dim Tempb As Integer
        Dim Counter As Integer
        Dim Placed As Boolean
        For i = 1 To NumberOfJobs - 1
            Tempa = Jobs(i, 0)
            Tempb = Jobs(i, 1)
            Counter = i
            Placed = False
            While (Counter > 0 And Not Placed)
                If (Jobs(Counter - 1, 1) > Tempb) Then
                    Jobs(Counter, 0) = Jobs(Counter - 1, 0)
                    Jobs(Counter, 1) = Jobs(Counter - 1, 1)
                    Counter = Counter - 1
                Else
                    Placed = True
                End If
            End While
            Jobs(Counter, 0) = Tempa
            Jobs(Counter, 1) = Tempb
        Next i
    End Sub
    Sub PrintArray()
        For X = 0 To NumberOfJobs - 1
            Console.WriteLine(Jobs(X, 0) & " priority " & Jobs(X,
           1))
        Next
    End Sub
End Module
