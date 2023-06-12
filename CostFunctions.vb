Module CostFunctions
    'calculates tax amount based on thr cost argument and returns sum
    Function Tax(ByVal Cost As Decimal) As Decimal
        Dim taxAmount As Decimal
        Dim costTotal As Decimal

        taxAmount = Cost * 0.07

        costTotal = taxAmount + Cost
        Return costTotal
    End Function

    Function Shipping(ByVal charge As Decimal) As Decimal

        Dim ship As Decimal
        ship = charge + 2.4
        Return ship
    End Function

End Module
