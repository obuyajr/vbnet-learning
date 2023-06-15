<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class employee_data
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
        Me.txt_id = New System.Windows.Forms.TextBox()
        Me.txt_lname = New System.Windows.Forms.TextBox()
        Me.txt_fname = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_hours = New System.Windows.Forms.TextBox()
        Me.txt_wages = New System.Windows.Forms.TextBox()
        Me.btn_addEmployee = New System.Windows.Forms.Button()
        Me.txt_hourlyRate = New System.Windows.Forms.TextBox()
        Me.btn_Submit = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'txt_id
        '
        Me.txt_id.Location = New System.Drawing.Point(95, 36)
        Me.txt_id.Name = "txt_id"
        Me.txt_id.Size = New System.Drawing.Size(153, 20)
        Me.txt_id.TabIndex = 0
        '
        'txt_lname
        '
        Me.txt_lname.Location = New System.Drawing.Point(95, 133)
        Me.txt_lname.Name = "txt_lname"
        Me.txt_lname.Size = New System.Drawing.Size(153, 20)
        Me.txt_lname.TabIndex = 2
        '
        'txt_fname
        '
        Me.txt_fname.Location = New System.Drawing.Point(95, 83)
        Me.txt_fname.Name = "txt_fname"
        Me.txt_fname.Size = New System.Drawing.Size(153, 20)
        Me.txt_fname.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(46, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(18, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Firstname"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 220)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Hourly Rate"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(11, 133)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Lastname"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(21, 20)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Hours"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(25, 178)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Wages"
        '
        'txt_hours
        '
        Me.txt_hours.Location = New System.Drawing.Point(80, 17)
        Me.txt_hours.Name = "txt_hours"
        Me.txt_hours.Size = New System.Drawing.Size(75, 20)
        Me.txt_hours.TabIndex = 4
        '
        'txt_wages
        '
        Me.txt_wages.Location = New System.Drawing.Point(95, 175)
        Me.txt_wages.Name = "txt_wages"
        Me.txt_wages.Size = New System.Drawing.Size(153, 20)
        Me.txt_wages.TabIndex = 8
        '
        'btn_addEmployee
        '
        Me.btn_addEmployee.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_addEmployee.Location = New System.Drawing.Point(341, 147)
        Me.btn_addEmployee.Name = "btn_addEmployee"
        Me.btn_addEmployee.Size = New System.Drawing.Size(185, 41)
        Me.btn_addEmployee.TabIndex = 12
        Me.btn_addEmployee.Text = "ADD EMPLOYEE"
        Me.btn_addEmployee.UseVisualStyleBackColor = True
        '
        'txt_hourlyRate
        '
        Me.txt_hourlyRate.Location = New System.Drawing.Point(95, 217)
        Me.txt_hourlyRate.Name = "txt_hourlyRate"
        Me.txt_hourlyRate.Size = New System.Drawing.Size(153, 20)
        Me.txt_hourlyRate.TabIndex = 3
        '
        'btn_Submit
        '
        Me.btn_Submit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Submit.Location = New System.Drawing.Point(77, 60)
        Me.btn_Submit.Name = "btn_Submit"
        Me.btn_Submit.Size = New System.Drawing.Size(92, 23)
        Me.btn_Submit.TabIndex = 14
        Me.btn_Submit.Text = "SUBMIT"
        Me.btn_Submit.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.txt_hourlyRate)
        Me.Panel1.Controls.Add(Me.txt_id)
        Me.Panel1.Controls.Add(Me.txt_lname)
        Me.Panel1.Controls.Add(Me.txt_fname)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txt_wages)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Location = New System.Drawing.Point(12, 24)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(282, 253)
        Me.Panel1.TabIndex = 15
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, -1)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(77, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Employee Info."
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.txt_hours)
        Me.Panel2.Controls.Add(Me.btn_Submit)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Location = New System.Drawing.Point(317, 24)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(200, 100)
        Me.Panel2.TabIndex = 16
        '
        'employee_data
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(571, 301)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.btn_addEmployee)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "employee_data"
        Me.Text = "employee_data"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txt_id As TextBox
    Friend WithEvents txt_lname As TextBox
    Friend WithEvents txt_fname As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_hours As TextBox
    Friend WithEvents txt_wages As TextBox
    Friend WithEvents btn_addEmployee As Button
    Friend WithEvents txt_hourlyRate As TextBox
    Friend WithEvents btn_Submit As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel2 As Panel
End Class
