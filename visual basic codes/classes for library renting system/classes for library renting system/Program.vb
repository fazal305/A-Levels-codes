Imports System

Module Program
    Class stockitem

        Public Sub showTitle()

        End Sub

        Public Sub showdateaquired()

        End Sub
        Private title As String

        Private Dateaquired As Date
    End Class


    Class Book : Inherits stockitem

        Public Sub ShowAuthor()

        End Sub

        Public Sub ShowISBN()

        End Sub


        Private Author As String

        Private ISBN As String

    End Class

End Module
