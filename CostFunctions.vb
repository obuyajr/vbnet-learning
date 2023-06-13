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
        Select Case iShipId
            Case "1"
                ship = charge + 7.0

            Case "2"
                ship = charge + 4.5
            Case "3"
                ship = charge + 2.4

        End Select

        Return ship

    End Function

End Module
