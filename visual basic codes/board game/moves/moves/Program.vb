Imports System

Module Module1
    Sub Main()
        ' Example usage of ValidMoves
        ValidMoves("B", 4, 4)
    End Sub

    ' Procedure to calculate and output valid moves in the x direction
    Sub ValidMoves(PieceColour As Char, xCurrent As Integer, yCurrent As Integer)
        ' Assume a chessboard of size 8x8
        Dim board(7, 7) As Char
        ' Populate the board (initialize it as per your requirement)

        ' Output header
        Console.WriteLine("Possible moves are:")

        ' Check moves to the LEFT
        For xDest = xCurrent - 1 To 0 Step -1
            If IsValidMove(PieceColour, xCurrent, yCurrent, xDest, yCurrent, board) Then
                Console.WriteLine($"Moving LEFT")
                Console.WriteLine($"{xDest} {yCurrent}")
                If board(xDest, yCurrent) <> "E" Then
                    Console.WriteLine($"REMOVE piece")
                End If
            Else
                Exit For ' Stop checking in this direction if an invalid move is encountered
            End If
        Next

        ' Check moves to the RIGHT
        For xDest = xCurrent + 1 To 7
            If IsValidMove(PieceColour, xCurrent, yCurrent, xDest, yCurrent, board) Then
                Console.WriteLine($"Moving RIGHT")
                Console.WriteLine($"{xDest} {yCurrent}")
                If board(xDest, yCurrent) <> "E" Then
                    Console.WriteLine($"REMOVE piece")
                End If
            Else
                Exit For ' Stop checking in this direction if an invalid move is encountered
            End If
        Next
    End Sub

    ' Function to check if a move is valid
    Function IsValidMove(PieceColour As Char, xCurrent As Integer, yCurrent As Integer, xDest As Integer, yDest As Integer, board(,) As Char) As Boolean
        ' Add your logic to check if the move is valid based on the rules
        ' For example, check if the destination is within the board boundaries and other conditions
        ' Return True if valid, False otherwise
        Return xDest >= 0 AndAlso xDest <= 7
    End Function
End Module
