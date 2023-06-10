Public Class frmPurchaseOrder

    'structure for products
    Public Structure lineItem
        Public ProductName As String
        Public Quantity As Integer
        Public Price As Decimal

    End Structure
    '
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_calculate.Click
        Dim footballInfo As lineItem

        'lineItem type variable
        footballInfo.ProductName = "football"
        footballInfo.Quantity = TextBox1.Text
        footballInfo.Price = Label11.Text

        Dim baseball As lineItem

        'lineItem type variable
        baseball.ProductName = "baseball"
        baseball.Quantity = TextBox2.Text
        baseball.Price = Label12.Text

        Dim tennis As lineItem

        'lineItem type variable
        tennis.ProductName = "tennis"
        tennis.Quantity = TextBox3.Text
        tennis.Price = Label13.Text

        'total cost for each item
        Label2.Text = footballInfo.Quantity * footballInfo.Price
        Label3.Text = baseball.Quantity * baseball.Price
        Label15.Text = tennis.Quantity * tennis.Price




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
        'store formatted elements in dynamic array
        Dim sRecepientsMessage As String = "Copies are being sent to: " & vbCrLf

        Dim scounter As Short

        For scounter = 0 To UBound(aRecepients)
            sRecepientsMessage = sRecepientsMessage & aRecepients(scounter) & vbCrLf

        Next

        sVendorName = cboVendor.Text
        MessageBox.Show("your order is being processed. the vendor is " & sVendorName & vbCrLf & sRecepientsMessage, "ORDER VERIFICATION")

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
