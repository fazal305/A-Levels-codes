Imports System

Public Class Queue
    Private Const MAX_SIZE As Integer = 100
    Private front As Integer
    Private rear As Integer
    Private queueArray(MAX_SIZE) As Integer

    Public Sub New()
        front = -1
        rear = -1
    End Sub

    Public Function IsEmpty() As Boolean
        Return front = -1
    End Function

    Public Function IsFull() As Boolean
        Return (rear = MAX_SIZE - 1 AndAlso front = 0) OrElse (rear + 1 = front)
    End Function

    Public Sub Enqueue(ByVal data As Integer)
        If IsFull() Then
            Console.WriteLine("Queue overflow. Cannot enqueue element.")
            Return
        End If

        If front = -1 Then
            front = 0
        End If

        rear = (rear + 1) Mod MAX_SIZE
        queueArray(rear) = data
    End Sub

    Public Function Dequeue() As Integer
        If IsEmpty() Then
            Console.WriteLine("Queue underflow. Cannot dequeue element.")
            Return -1 ' Or throw an exception
        End If

        Dim data As Integer = queueArray(front)

        If front = rear Then
            front = -1
            rear = -1
        Else
            front = (front + 1) Mod MAX_SIZE
        End If

        Return data
    End Function

    Public Sub DisplayQueue()
        If IsEmpty() Then
            Console.WriteLine("Queue is empty.")
            Return
        End If

        Console.Write("Queue: ")
        Dim index As Integer = front
        Do
            Console.Write(queueArray(index) & " ")
            index = (index + 1) Mod MAX_SIZE
        Loop While index <> (rear + 1) Mod MAX_SIZE

        Console.WriteLine()
    End Sub
End Class

Module MainModule
    Sub Main()
        Dim queue As New Queue()

        queue.Enqueue(1)
        queue.Enqueue(2)
        queue.Enqueue(3)

        queue.DisplayQueue()

        Dim dequeuedValue As Integer = queue.Dequeue()
        Console.WriteLine("Dequeued value: " & dequeuedValue)

        queue.DisplayQueue()

        Console.ReadLine()
    End Sub
End Module

