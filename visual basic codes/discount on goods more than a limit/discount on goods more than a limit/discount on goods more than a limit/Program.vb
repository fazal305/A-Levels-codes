Imports System

Module Program
    Function CalculateDiscount(GoodsTotal As Integer, HasDiscountCard As Boolean) As Integer
        Dim discountAmount As Integer

        ' Check if goods total is more than $100
        If GoodsTotal > 100 Then
            ' Apply 10% discount if the customer has a discount card
            If HasDiscountCard Then
                discountAmount = GoodsTotal * 0.1
            Else
                ' Apply 5% discount for goods totaling more than $100
                discountAmount = GoodsTotal * 0.05
            End If
        ElseIf HasDiscountCard Then
            ' Apply 5% discount if the customer has a discount card
            discountAmount = GoodsTotal * 0.05
        Else
            ' No discount if the conditions are not met
            discountAmount = 0
        End If

        ' Return the calculated discount amount as an integer
        Return CInt(discountAmount)
    End Function

    Sub Main()

    End Sub
End Module
