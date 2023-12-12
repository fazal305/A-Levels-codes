Imports System

Module Program
    Sub TraverseTree(ByVal Root As Integer)
        If Tree(Root).LeftPointer <> 0 Then
            TraverseTree(Tree(Root).LeftPointer)
        End If

        Console.WriteLine(Tree(Root).Name)

        If Tree(Root).RightPointer <> 0 Then
            TraverseTree(Tree(Root).RightPointer)
        End If
    End Sub

    Private Function Tree(root As Integer) As Object
        Throw New NotImplementedException()
    End Function
End Module
