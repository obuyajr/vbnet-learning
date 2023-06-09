Public Class frmPurchaseOrder
    Dim sVendorName As String
    Const dfootballprice As Decimal = 20
    Const dbaseballprice As Decimal = 10
    Const dtennisprice As Decimal = 10
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Label11.Text = dfootballprice
        Label12.Text = dbaseballprice
        Label13.Text = dtennisprice

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim qtyFootball As Integer = TextBox1.Text
        Dim qtyBaseball As Integer = TextBox2.Text
        Dim qtyTennis As Integer = TextBox3.Text



        'calculations
        Label2.Text = qtyFootball * dfootballprice
        Label3.Text = qtyBaseball * dbaseballprice
        Label15.Text = qtyTennis * dtennisprice

        'TOTAL ITEMS
        txt_itemsNo.Text = qtyTennis + qtyFootball + qtyBaseball

        'total cost 
        Dim costFootball As Decimal = Label2.Text
        Dim costBaseball As Decimal = Label3.Text
        Dim costTennis As Decimal = Label15.Text

        txt_cost.Text = costBaseball + costFootball + costTennis


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
End Class
