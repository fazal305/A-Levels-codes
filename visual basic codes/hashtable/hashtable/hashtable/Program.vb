Imports System

Module HashTable
    ' Define the CustomerRecord structure
    Structure CustomerRecord
        Dim CustomerID As Integer
        Dim Data As String
    End Structure

    ' Declare the hash table as an array of CustomerRecord
    Dim Customer(199) As CustomerRecord

    ' Procedure to create and initialize the hash table
    Sub CreateHashTable()
        For x = 0 To 199
            Customer(x).CustomerID = 0
        Next
    End Sub

    ' Procedure to insert a new record into the hash table
    Sub InsertRecord(ByVal NewCustomer As CustomerRecord)
        Dim TableFull As Boolean = False
        Dim Index As Integer = Hash(NewCustomer.CustomerID)
        Dim Pointer As Integer = Index

        While Customer(Pointer).CustomerID > 0
            Pointer += 1

            If Pointer > 199 Then
                Pointer = 0
            End If

            If Pointer = Index Then
                TableFull = True
                Exit While
            End If
        End While

        If Not TableFull Then
            Customer(Pointer) = NewCustomer
        Else
            Console.WriteLine("Error: Table Full")
        End If
    End Sub

    ' Function to search for a customer ID in the hash table
    Function SearchHashTable(ByVal SearchID As Integer) As Integer
        Dim Index As Integer = Hash(SearchID)

        While Customer(Index).CustomerID <> SearchID AndAlso Customer(Index).CustomerID > 0
            Index += 1

            If Index > 199 Then
                Index = 0
            End If
        End While

        If Customer(Index).CustomerID = SearchID Then
            Return Index
        Else
            Return -1
        End If
    End Function

    ' Function to calculate the hash value
    Function Hash(ByVal value As Integer) As Integer
        ' This is a simple hash function; you may need to implement a more sophisticated one
        Return value Mod 200
    End Function

    Sub Main()
        ' Example usage
        CreateHashTable()

        Dim newCustomer As CustomerRecord = New CustomerRecord With {
            .CustomerID = 123,
            .Data = "Customer Data"
        }

        InsertRecord(newCustomer)

        Dim searchResult As Integer = SearchHashTable(123)
        If searchResult <> -1 Then
            Console.WriteLine("Customer found at index: " & searchResult)
        Else
            Console.WriteLine("Customer not found.")
        End If

        Console.ReadLine()
    End Sub
End Module
