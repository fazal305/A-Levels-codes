Imports System

Module Module1
    Sub Main()
        ' Variable declarations
        Dim board(7, 7) As Char
        Dim row As Integer
        Dim col As Integer

        ' Initialize the board
        For row = 0 To 7
            For col = 0 To 7
                If (row + col) Mod 2 = 0 Then
                    ' Even row + even column or odd row + odd column represents a black square
                    board(row, col) = "E"
                Else
                    ' Odd row + even column or even row + odd column represents a white square
                    If row < 3 Then
                        board(row, col) = "B" ' Black piece
                    ElseIf row > 4 Then
                        board(row, col) = "W" ' White piece
                    Else
                        board(row, col) = "E" ' Empty square
                    End If
                End If
            Next
        Next

        ' Display the initialized board
        For row = 0 To 7
            For col = 0 To 7
                Console.Write(board(row, col) & " ")
            Next
            Console.WriteLine()
        Next

        Console.ReadLine()
    End Sub
End Module

