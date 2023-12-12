Imports System

Module Module1
    ' Define the structure for a tree node
    Class TreeNode
        Public Value As Integer
        Public Left As TreeNode
        Public Right As TreeNode

        Public Sub New(ByVal value As Integer)
            Me.Value = value
            Me.Left = Nothing
            Me.Right = Nothing
        End Sub
    End Class

    ' Binary tree class
    Class BinaryTree
        Public Root As TreeNode

        Public Sub New()
            Me.Root = Nothing
        End Sub

        ' Function to insert a value into the binary tree
        Public Sub Insert(ByVal value As Integer)
            Root = InsertRecursive(Root, value)
        End Sub

        ' Recursive function to insert a value into the binary tree
        Private Function InsertRecursive(ByVal root As TreeNode, ByVal value As Integer) As TreeNode
            ' If the tree is empty, create a new node
            If root Is Nothing Then
                Return New TreeNode(value)
            End If

            ' Otherwise, recur down the tree
            If value < root.Value Then
                root.Left = InsertRecursive(root.Left, value)
            ElseIf value > root.Value Then
                root.Right = InsertRecursive(root.Right, value)
            End If

            ' Return the unchanged node pointer
            Return root
        End Function

        ' Function to perform an inorder traversal of the binary tree
        Public Sub InOrderTraversal(ByVal root As TreeNode)
            If root IsNot Nothing Then
                InOrderTraversal(root.Left)
                Console.Write(root.Value & " ")
                InOrderTraversal(root.Right)
            End If
        End Sub
    End Class

    Sub Main()
        ' Create a binary tree
        Dim tree As New BinaryTree()

        ' Insert elements into the tree
        tree.Insert(5)
        tree.Insert(3)
        tree.Insert(7)
        tree.Insert(2)
        tree.Insert(4)
        tree.Insert(6)
        tree.Insert(8)

        ' Perform an inorder traversal and display the elements
        Console.WriteLine("Inorder Traversal:")
        tree.InOrderTraversal(tree.Root)

        Console.ReadLine()
    End Sub
End Module

