Imports System

Public Class Stack
    Private Const MAX_SIZE As Integer = 100
    Private top As Integer
    Private stackArray(MAX_SIZE) As Integer

    Public Sub New()
        top = -1
    End Sub

    Public Function IsEmpty() As Boolean
        Return top = -1
    End Function

    Public Function IsFull() As Boolean
        Return top = MAX_SIZE - 1
    End Function

    Public Sub Push(ByVal data As Integer)
        If IsFull() Then
            Console.WriteLine("Stack overflow. Cannot push element.")
            Return
        End If

        top += 1
        stackArray(top) = data
    End Sub

    Public Function Pop() As Integer
        If IsEmpty() Then
            Console.WriteLine("Stack underflow. Cannot pop element.")
            Return -1 ' Or throw an exception
        End If

        Dim data As Integer = stackArray(top)
        top -= 1
        Return data
    End Function

    Public Sub DisplayStack()
        If IsEmpty() Then
            Console.WriteLine("Stack is empty.")
            Return
        End If

        Console.Write("Stack: ")
        For i As Integer = 0 To top
            Console.Write(stackArray(i) & " ")
        Next
        Console.WriteLine()
    End Sub
End Class

Module MainModule
    Sub Main()
        Dim stack As New Stack()

        stack.Push(1)
        stack.Push(2)
        stack.Push(3)

        stack.DisplayStack()

        Dim poppedValue As Integer = stack.Pop()
        Console.WriteLine("Popped value: " & poppedValue)

        stack.DisplayStack()

        Console.ReadLine()
    End Sub
End Module

