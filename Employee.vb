Public Class Employee
    Public fName As String
    Public lName As String
    Private hours As Short
    Private employeeID As Short
    Private wages As Decimal
    Private rate As Decimal
    Public Event OverWorked(ByVal amount As Short)




    Public Property EmployeeNumber() As Short
        Get
            Return employeeID

        End Get
        Set(value As Short)
            employeeID = value

        End Set
    End Property

    Public ReadOnly Property GrossWages() As Decimal
        Get
            Return wages
        End Get
    End Property


    Public ReadOnly Property HoursWorked() As Long
        Get
            Return hours
        End Get
    End Property

    Public Property HourlyRate() As Decimal
        Get
            Return rate
        End Get
        Set(value As Decimal)
            rate = value
        End Set
    End Property

    Public Function pay(ByVal time As Short) As Decimal
        hours += time
        If hours > 60 Then
            RaiseEvent OverWorked(hours)

        End If

        wages = rate * time
        Return wages


    End Function

    'if employee has worked over 60 hours


End Class
