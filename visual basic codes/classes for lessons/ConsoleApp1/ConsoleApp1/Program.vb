Imports System

Module Program


    Public Sub ty(LType As String, ByVal LInstructor As String)
        LessonType = LType
        Instructor = LInstructor
    End Sub

    Dim myLesson As New Lesson("Math", "Mr. Smith")
    Private _LessonType As String

    Public Property LessonType As String
        Get
            Return _LessonType
        End Get
        Set
            _LessonType = Value
        End Set
    End Property

    Public Property Instructor As String

    Public Class Lesson
        ' Property
        Public Property LessonType As String

        ' Constructor
        Public Sub New(ByVal LType As String, v As String)
            LessonType = LType
        End Sub

        ' Function to get LessonType
        Public Function GetLessonType() As String
            Return LessonType
        End Function
    End Class

    Public Function GetFee(ByVal PLevel As String) As Integer
        If PLevel = "B" Then
            Return 45
        ElseIf PLevel = "I" Then
            Return 50
        ElseIf PLevel = "A" Then
            Return 55
        Else
            Return -1
        End If
    End Function

End Module
