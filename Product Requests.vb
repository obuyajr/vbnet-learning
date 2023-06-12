Public Class Product_Requests
    'new collection declared
    Dim Merchandise As New Collection()

    Private Sub btnAddToList_Click(sender As Object, e As EventArgs) Handles btnAddToList.Click
        'clear the listbox
        Merchandise.Clear()
        Dim product As String = txtProduct.Text

        Merchandise.Add(product, product)

        'display each member of item
        Dim i As Integer
        For i = 1 To Merchandise.Count
            listProducts.Items.Add(Merchandise(i))

        Next i

        'clear textbox
        txtProduct.Text = ""
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        Dim selection As String = listProducts.SelectedItem
        Merchandise.Remove(selection)
        listProducts.Items.Remove(selection)


    End Sub
End Class