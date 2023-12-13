Imports System

Module Program
    Public Property Contact As Array

    Sub BubbleSort()
        ' Declaration of variables
        Dim temp As String
        Dim i As Integer
        Dim j As Integer
        Dim swapped As Boolean

        ' Assuming Contact is the 1D array to be sorted with structure:
        ' Contact(i) = "Name, OtherData1, OtherData2, ..."

        ' Get the total number of elements in the array
        Dim totalContacts As Integer
        totalContacts = UBound(Contact) + 1

        ' Bubble sort algorithm
        For i = 0 To totalContacts - 2
            swapped = False

            For j = 0 To totalContacts - i - 2
                ' Compare names and swap if necessary
                If Contact(j) > Contact(j + 1) Then
                    ' Swap the names
                    temp = Contact(j)
                    Contact(j) = Contact(j + 1)
                    Contact(j + 1) = temp

                    ' Set the flag to indicate a swap occurred
                    swapped = True
                End If
            Next j

            ' If no swap occurred in the inner loop, the array is already sorted
            If Not swapped Then
                Exit For
            End If
        Next i
    End Sub

End Module
