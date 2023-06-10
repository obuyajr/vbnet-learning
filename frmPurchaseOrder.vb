Public Class frmPurchaseOrder

    Dim sVendorName As String
    Dim aRecepients() As String
    Const dfootballprice As Decimal = 20
    Const dbaseballprice As Decimal = 10
    Const dtennisprice As Decimal = 10


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Label11.Text = dfootballprice
        Label12.Text = dbaseballprice
        Label13.Text = dtennisprice

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click



        ''calculations
        'Label2.Text = qtyFootball * dfootballprice
        'Label3.Text = qtyBaseball * dbaseballprice
        'Label15.Text = qtyTennis * dtennisprice

        'Array to store values quantity coln
        Dim quantity(3) As Integer
        quantity(0) = TextBox1.Text
        quantity(1) = TextBox2.Text
        quantity(2) = TextBox3.Text

        'Array to store values price coln
        Dim price(3) As Integer
        price(0) = Label11.Text
        price(1) = Label12.Text
        price(2) = Label13.Text

        'array to store total cost results per (quantity * price)
        Dim totalCost(3) As Decimal
        totalCost(0) = price(0) * quantity(0)
        totalCost(1) = price(1) * quantity(1)
        totalCost(2) = price(2) * quantity(2)

        'array to display in each cost column
        Label2.Text = totalCost(0)
        Label3.Text = totalCost(1)
        Label15.Text = totalCost(2)

        'calculate total items
        txt_itemsNo.Text = quantity(0) + quantity(1) + quantity(2)

        'calculate grand total
        txt_grandTotal.Text = totalCost(0) + totalCost(1) + totalCost(2)



        MessageBox.Show("Your calculations: calculus", "Title", MessageBoxButtons.OKCancel,
                        MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1)

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        'displays footyball gif
        footballpic.Visible = True

    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        baseballpic.Visible = True
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        tennispic.Visible = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btn_submit.Click

        sVendorName = cboVendor.Text
        MessageBox.Show("your order is being processed. the vendor is " & sVendorName, "ORDER VERIFICATION")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        MessageBox.Show("FORM WILL BE RESET", "RESET FORM", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    End Sub

    Private Sub Label14_Click(sender As Object, e As EventArgs) Handles Label14.Click

    End Sub

    Private Sub btnCopyTo_Click(sender As Object, e As EventArgs) Handles btnCopyTo.Click
        Dim snumRecepients As Short = InputBox("How many people to receive 
                                        the purchase order?", "FORM RECEPIENTS")
        Dim scounter As Short

        ReDim aRecepients(snumRecepients - 1)

        'aasign values to the array using input box
        For scounter = 0 To UBound(aRecepients)
            aRecepients(scounter) = InputBox("ENTER NAME: ")
        Next


    End Sub
End Class
