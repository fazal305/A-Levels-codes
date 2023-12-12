Imports System

Friend Module game
    Public Property Health As Integer

    Class balloon
        Private Healths As Integer
        Private Colours As String
        Private DefenceItems As String
        Public Sub New(PDefenceItem, PColour)
            Healths = 100
            Colours = PColour
            DefenceItems = PDefenceItem
        End Sub
        Public Sub ChangeHealth(Change)
            Health = Health + Change
        End Sub
        Public Function GetDefenceItem()
            Return DefenceItem
        End Function
    End Class
    Function Health()
        If Healths() <= 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Function Healths() As Integer
        Throw New NotImplementedException()
    End Function

    Function Defend(MyBalloon)
        Console.WriteLine("Enter the strength of opponent")
        Dim Strength As Integer = Console.ReadLine
        MyBalloon.ChangeHealth(-Strength)
        Console.WriteLine("You defended with " & MyBalloon.GetDefenceItem)
        If (MyBalloon.CheckHealth() = True) Then
            Console.WriteLine("Defence failed")
        Else
            Console.WriteLine("Defence succeeded")
        End If
        Return MyBalloon
    End Function




    Sub Main()
        Console.WriteLine("Enter balloon defence method")
        Dim Method As String = Console.ReadLine
        Console.WriteLine("Enter the balloons colour")
        Dim Colour As String = Console.ReadLine
    End Sub


End Module
