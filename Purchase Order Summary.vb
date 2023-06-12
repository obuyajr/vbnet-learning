Public Class Purchase_Order_Summary
    Private Sub Purchase_Order_Summary_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = iOrderNumber
        Label2.Text = sVendor
        Label3.Text = sFootballCost
        Label4.Text = sBaseBall
        Label5.Text = sTennis
        Label6.Text = sTotalQuantityOrdered
        Label7.Text = sTotalCost
        Label8.Text = FormatCurrency(dCostTax)
        Label9.Text = FormatCurrency(dTotalShip)


    End Sub
End Class