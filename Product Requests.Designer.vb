<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Product_Requests
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnAddToList = New System.Windows.Forms.Button()
        Me.txtProduct = New System.Windows.Forms.TextBox()
        Me.listProducts = New System.Windows.Forms.ListBox()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnAddToList
        '
        Me.btnAddToList.Location = New System.Drawing.Point(374, 13)
        Me.btnAddToList.Name = "btnAddToList"
        Me.btnAddToList.Size = New System.Drawing.Size(153, 39)
        Me.btnAddToList.TabIndex = 0
        Me.btnAddToList.Text = "ADD PRODUCT"
        Me.btnAddToList.UseVisualStyleBackColor = True
        '
        'txtProduct
        '
        Me.txtProduct.Location = New System.Drawing.Point(43, 23)
        Me.txtProduct.Name = "txtProduct"
        Me.txtProduct.Size = New System.Drawing.Size(199, 20)
        Me.txtProduct.TabIndex = 1
        '
        'listProducts
        '
        Me.listProducts.FormattingEnabled = True
        Me.listProducts.Location = New System.Drawing.Point(43, 121)
        Me.listProducts.Name = "listProducts"
        Me.listProducts.Size = New System.Drawing.Size(199, 160)
        Me.listProducts.TabIndex = 2
        '
        'btnRemove
        '
        Me.btnRemove.Location = New System.Drawing.Point(374, 121)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(153, 33)
        Me.btnRemove.TabIndex = 3
        Me.btnRemove.Text = "REMOVE"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'Product_Requests
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.listProducts)
        Me.Controls.Add(Me.txtProduct)
        Me.Controls.Add(Me.btnAddToList)
        Me.Name = "Product_Requests"
        Me.Text = "Product_Requests"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAddToList As Button
    Friend WithEvents txtProduct As TextBox
    Friend WithEvents listProducts As ListBox
    Friend WithEvents btnRemove As Button
End Class
