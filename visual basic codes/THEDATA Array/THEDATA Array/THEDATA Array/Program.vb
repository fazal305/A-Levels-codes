Imports System

Module Module1

    Sub Main()
        Dim TheData() As Integer = {5, 3, 8, 2, 7}

        Console.WriteLine("Before sorting:")
        PrintArray(TheData)

        InsertionSort(TheData)

        Console.WriteLine("After sorting:")
        PrintArray(TheData)

        Console.ReadLine()
    End Sub

    Function Search(ByVal TheData() As Integer) As Boolean
        Console.WriteLine("Enter a whole number:")
        Dim NumberInput As Integer
        NumberInput = Convert.ToInt32(Console.ReadLine())

        Dim Count As Integer
        For Count = 0 To UBound(TheData)
            If TheData(Count) = NumberInput Then
                Console.WriteLine("Found")
                Return True
            End If
        Next

        Console.WriteLine("Not found")
        Return False
    End Function


    Sub InsertionSort(ByRef TheData() As Integer)
        Dim Count As Integer
        Dim DataToInsert As Integer
        Dim Inserted As Boolean
        Dim NextValue As Integer

        For Count = 1 To UBound(TheData)
            DataToInsert = TheData(Count)
            Inserted = False
            NextValue = Count - 1

            While NextValue >= 0 And Not Inserted
                If DataToInsert < TheData(NextValue) Then
                    TheData(NextValue + 1) = TheData(NextValue)
                    NextValue = NextValue - 1
                    TheData(NextValue + 1) = DataToInsert
                Else
                    Inserted = True
                End If
            End While
        Next
    End Sub



    Sub PrintArray(ByVal TheData() As Integer)
        Dim i As Integer

        For i = LBound(TheData) To UBound(TheData)
            Console.Write(TheData(i) & " ")
        Next

        Console.WriteLine()
    End Sub

End Module

