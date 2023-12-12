Imports System.Collections.Generic

Module MainModule
    Sub Main()
        ' Creating a Dictionary with Integer keys and String values
        Dim myDictionary As New Dictionary(Of Integer, String)

        ' Adding key-value pairs to the dictionary
        myDictionary.Add(1, "One")
        myDictionary.Add(2, "Two")
        myDictionary.Add(3, "Three")

        ' Accessing values using keys
        Console.WriteLine("Value for key 2: " & myDictionary(2))

        ' Modifying an existing value
        myDictionary(2) = "New Two"

        ' Removing a key-value pair
        myDictionary.Remove(1)

        ' Iterating through the dictionary
        For Each kvp As KeyValuePair(Of Integer, String) In myDictionary
            Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}")
        Next

        ' Check if a key exists in the dictionary
        If myDictionary.ContainsKey(3) Then
            Console.WriteLine("Key 3 exists in the dictionary.")
        End If

        ' Check if a value exists in the dictionary
        If myDictionary.ContainsValue("New Two") Then
            Console.WriteLine("Value 'New Two' exists in the dictionary.")
        End If

        Console.ReadLine()
    End Sub
End Module

