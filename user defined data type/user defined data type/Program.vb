Imports System

Module Program
    Sub Main()
        Public Class Student
        Public Property StudentID As String
        Public Property Email As String
        Public Property Club1 As Integer
        Public Property Club2 As Integer
        Public Property Club3 As Integer

        Public Overrides Function Equals(obj As Object) As Boolean
            Dim student = TryCast(obj, Student)
            Return student IsNot Nothing AndAlso
                   StudentID = student.StudentID AndAlso
                   Email = student.Email AndAlso
                   Club1 = student.Club1 AndAlso
                   Club2 = student.Club2 AndAlso
                   Club3 = student.Club3
        End Function
    End Class
    End Sub
End Module
