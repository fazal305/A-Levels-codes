Imports System

Public Class Node
    Public Data As Integer
    Public NextNode As Node

    Public Sub New(ByVal data As Integer)
        Me.Data = data
        Me.NextNode = Nothing
    End Sub
End Class

Public Class LinkedList
    Public Head As Node

    Public Sub New()
        Me.Head = Nothing
    End Sub

    Public Sub AddNode(ByVal data As Integer)
        Dim newNode As New Node(data)

        If Me.Head Is Nothing Then
            Me.Head = newNode
        Else
            Dim current As Node = Me.Head
            While current.NextNode IsNot Nothing
                current = current.NextNode
            End While
            current.NextNode = newNode
        End If
    End Sub

    Public Sub DisplayList()
        Dim current As Node = Me.Head

        While current IsNot Nothing
            Console.Write(current.Data & " ")
            current = current.NextNode
        End While

        Console.WriteLine()
    End Sub
End Class

Module MainModule
    Sub Main()
        Dim linkedList As New LinkedList()

        linkedList.AddNode(1)
        linkedList.AddNode(2)
        linkedList.AddNode(3)

        Console.WriteLine("Linked List: ")
        linkedList.DisplayList()

        Console.ReadLine()
    End Sub
End Module

