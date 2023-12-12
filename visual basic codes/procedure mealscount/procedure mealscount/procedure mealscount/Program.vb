Imports System

Module Module1

    Sub Main()
        ' Example usage:
        Dim mealOption1Count As Integer = 0
        Dim mealOption2Count As Integer = 0
        MealsCount(mealOption1Count, mealOption2Count)
    End Sub

    Sub MealsCount(ByRef MealOption1 As Integer, ByRef MealOption2 As Integer)
        Dim MealOption As Integer

        Console.WriteLine("Enter meal option (1 or 2, 0 to exit): ")
        Integer.TryParse(Console.ReadLine(), MealOption)

        If MealOption = 1 Then
            MealOption1 += 1
            MealsCount(MealOption1, MealOption2)
        ElseIf MealOption = 2 Then
            MealOption2 += 1
            MealsCount(MealOption1, MealOption2)
        ElseIf MealOption = 0 Then
            Console.WriteLine("Meal Option 1 count: " & MealOption1)
            Console.WriteLine("Meal Option 2 count: " & MealOption2)
        Else
            Console.WriteLine("Invalid meal option. Please enter 1 or 2.")
            MealsCount(MealOption1, MealOption2)
        End If
    End Sub

End Module
