Public Class frmPurchaseOrder

    'structure for products
    Public Structure lineItem
        Public ProductName As String
        Public Quantity As Integer
        Public Price As Decimal

    End Structure

    Public Enum ShippingOptions As Byte
        OverNightAir = 1
        Air = 2
        Ground = 3

    End Enum
    '
    Dim sVendorName As String
    Dim aRecepients() As String
    Const dfootballprice As Decimal = 20
    Const dbaseballprice As Decimal = 10
    Const dtennisprice As Decimal = 10

    'declare instance of Purchase Order summary
    Dim reports As New Purchase_Order_Summary()





    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Label11.Text = dfootballprice
        Label12.Text = dbaseballprice
        Label13.Text = dtennisprice

        Dim options As ShippingOptions

        cboShopVia.DataSource = options.GetNames(options.GetType)

        CreateRandomNumber()
        Label16.Text = iOrderNumber



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_calculate.Click
        'array of linr item type
        Dim product(3) As lineItem

        'lineItem type variable
        product(0).ProductName = "football"
        product(0).Quantity = TextBox1.Text
        product(0).Price = Label11.Text



        'lineItem type variable
        product(1).ProductName = "baseball"
        product(1).Quantity = TextBox2.Text
        product(1).Price = Label12.Text



        'lineItem type variable
        product(2).ProductName = "tennis"
        product(2).Quantity = TextBox3.Text
        product(2).Price = Label13.Text

        'total cost for each item
        Label2.Text = FormatCurrency(product(0).Quantity * product(0).Price)
        Label3.Text = FormatCurrency(product(1).Quantity * product(1).Price)
        Label15.Text = FormatCurrency(product(2).Quantity * product(2).Price)

        'assign to their global variables
        sFootballCost = Label2.Text
        sBaseBall = Label3.Text
        sTennis = Label15.Text

        'no of items
        txt_itemsNo.Text = CInt(product(0).Quantity) + CInt(product(1).Quantity) +
                            CInt(product(2).Quantity)

        'assign total items ordered to global var
        sTotalQuantityOrdered = txt_itemsNo.Text


        txt_grandTotal.Text = FormatCurrency(CDec(Label2.Text) + CDec(Label3.Text) + CDec(Label15.Text))
        sTotalCost = txt_grandTotal.Text

        '
        dCostTax = Tax(sTotalCost)
        dTotalShip = Shipping(dCostTax)

        MessageBox.Show("Your calculations: calculus", "Title", MessageBoxButtons.OKCancel,
                        MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1)

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            TextBox1.Enabled = True
            'displays footyball gif
            footballpic.Visible = True
        Else
            footballpic.Visible = False
            TextBox1.Enabled = False
        End If


    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked = True Then
            TextBox2.Enabled = True
            'displays footyball gif
            baseballpic.Visible = True
        Else
            baseballpic.Visible = False
            TextBox2.Enabled = False
        End If
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        If CheckBox3.Checked = True Then
            TextBox3.Enabled = True
            'displays footyball gif
            tennispic.Visible = True
        Else
            tennispic.Visible = False
            TextBox3.Enabled = False
        End If
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
        Me.Close()
        reports.Close()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        MessageBox.Show("FORM WILL BE RESET", "RESET FORM", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ResetForm()
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

    Private Sub cboVendor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboVendor.SelectedIndexChanged
        sVendor = cboVendor.Text

    End Sub

    Private Sub btnSummary_Click(sender As Object, e As EventArgs) Handles btnSummary.Click
        reports.Show()

    End Sub

    Private Sub CreateRandomNumber()
        Dim randomNumber As Single
        Randomize()
        randomNumber = Rnd()
        iOrderNumber = randomNumber * 1000

    End Sub

    Private Sub ResetForm()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        Label2.Text = ""
        Label3.Text = ""
        Label15.Text = ""
        txt_itemsNo.Text = ""
        txt_grandTotal.Text = ""
        cboVendor.Text = ""
        cboShopVia.Text = ""
        CheckBox1.Checked = False
        CheckBox2.Checked = False
        CheckBox3.Checked = False
        footballpic.Visible = False
        baseballpic.Visible = False
        tennispic.Visible = False

    End Sub

End Class
