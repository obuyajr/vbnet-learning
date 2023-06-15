Public Class employee_data
    Dim WithEvents person As Employee
    Dim displayMesg As Boolean






    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_addEmployee.Click
        person = New Employee()


        person.fName = txt_fname.Text
        person.lName = txt_lname.Text
        person.EmployeeNumber = txt_id.Text
        person.HourlyRate = txt_hourlyRate.Text
        btn_Submit.Enabled = True
        displayMesg = True

        MessageBox.Show(person.fName & " " & person.lName & "  " & person.EmployeeNumber & "  ")

    End Sub

    Private Sub btn_Submit_Click(sender As Object, e As EventArgs) Handles btn_Submit.Click
        person.pay(txt_hours.Text)
        txt_wages.Text = FormatCurrency(person.GrossWages)

        If displayMesg = True Then
            MessageBox.Show(person.fName & " " & person.lName & "  " & person.HoursWorked & " hours  ")

        End If

    End Sub

    Private Sub employee_data_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btn_Submit.Enabled = False
    End Sub

    'handle worked too much event
    Private Sub WorkedTooMuch(ByVal amount As Short) Handles person.OverWorked
        MessageBox.Show(person.fName & " has worked " & amount & " hours more !!! ")
        displayMesg = False
    End Sub

End Class