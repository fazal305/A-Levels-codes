Imports System

Module Program
    Sub Count(ByRef Number As Integer)
        If Number Mod 2 <> 0 Then
            Number = Number - 1
        End If

        Console.WriteLine(Number) ' or use MsgBox(Number) for a message box output

        If Number > 0 Then
            Count(Number - 1)
        End If
    End Sub

End Module
