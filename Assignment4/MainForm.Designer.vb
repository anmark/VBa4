<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.lstSeats = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.rbtnReserve = New System.Windows.Forms.RadioButton()
        Me.rbtnCancel = New System.Windows.Forms.RadioButton()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.grpOutput = New System.Windows.Forms.GroupBox()
        Me.lblNumOfVacantSeats = New System.Windows.Forms.Label()
        Me.lblNumOfReservedSeats = New System.Windows.Forms.Label()
        Me.lblTotalNumberOfSeats = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.grpInput = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.grpOutput.SuspendLayout()
        Me.grpInput.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'lstSeats
        '
        Me.lstSeats.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstSeats.FormattingEnabled = True
        Me.lstSeats.ItemHeight = 14
        Me.lstSeats.Location = New System.Drawing.Point(6, 38)
        Me.lstSeats.Name = "lstSeats"
        Me.lstSeats.Size = New System.Drawing.Size(365, 214)
        Me.lstSeats.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(15, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Seat"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(71, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Status"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(162, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Name"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(293, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Price"
        '
        'rbtnReserve
        '
        Me.rbtnReserve.AutoSize = True
        Me.rbtnReserve.ForeColor = System.Drawing.Color.Black
        Me.rbtnReserve.Location = New System.Drawing.Point(6, 15)
        Me.rbtnReserve.Name = "rbtnReserve"
        Me.rbtnReserve.Size = New System.Drawing.Size(65, 17)
        Me.rbtnReserve.TabIndex = 7
        Me.rbtnReserve.TabStop = True
        Me.rbtnReserve.Text = "Reserve"
        Me.rbtnReserve.UseVisualStyleBackColor = True
        '
        'rbtnCancel
        '
        Me.rbtnCancel.AutoSize = True
        Me.rbtnCancel.ForeColor = System.Drawing.Color.Black
        Me.rbtnCancel.Location = New System.Drawing.Point(77, 15)
        Me.rbtnCancel.Name = "rbtnCancel"
        Me.rbtnCancel.Size = New System.Drawing.Size(118, 17)
        Me.rbtnCancel.TabIndex = 8
        Me.rbtnCancel.TabStop = True
        Me.rbtnCancel.Text = "Cancel Reservation"
        Me.rbtnCancel.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(6, 39)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(35, 13)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Name"
        '
        'txtName
        '
        Me.txtName.ForeColor = System.Drawing.Color.Black
        Me.txtName.Location = New System.Drawing.Point(9, 56)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(146, 20)
        Me.txtName.TabIndex = 10
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(158, 39)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(31, 13)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Price"
        '
        'btnOK
        '
        Me.btnOK.ForeColor = System.Drawing.Color.Black
        Me.btnOK.Location = New System.Drawing.Point(43, 93)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(146, 23)
        Me.btnOK.TabIndex = 13
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'txtPrice
        '
        Me.txtPrice.ForeColor = System.Drawing.Color.Black
        Me.txtPrice.Location = New System.Drawing.Point(161, 56)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(57, 20)
        Me.txtPrice.TabIndex = 14
        '
        'grpOutput
        '
        Me.grpOutput.Controls.Add(Me.lblNumOfVacantSeats)
        Me.grpOutput.Controls.Add(Me.lblNumOfReservedSeats)
        Me.grpOutput.Controls.Add(Me.lblTotalNumberOfSeats)
        Me.grpOutput.Controls.Add(Me.Label9)
        Me.grpOutput.Controls.Add(Me.Label6)
        Me.grpOutput.Controls.Add(Me.Label1)
        Me.grpOutput.ForeColor = System.Drawing.Color.SeaGreen
        Me.grpOutput.Location = New System.Drawing.Point(10, 153)
        Me.grpOutput.Name = "grpOutput"
        Me.grpOutput.Size = New System.Drawing.Size(240, 129)
        Me.grpOutput.TabIndex = 15
        Me.grpOutput.TabStop = False
        Me.grpOutput.Text = "Output Data"
        '
        'lblNumOfVacantSeats
        '
        Me.lblNumOfVacantSeats.AutoSize = True
        Me.lblNumOfVacantSeats.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblNumOfVacantSeats.ForeColor = System.Drawing.Color.Black
        Me.lblNumOfVacantSeats.Location = New System.Drawing.Point(172, 73)
        Me.lblNumOfVacantSeats.Name = "lblNumOfVacantSeats"
        Me.lblNumOfVacantSeats.Size = New System.Drawing.Size(2, 15)
        Me.lblNumOfVacantSeats.TabIndex = 5
        '
        'lblNumOfReservedSeats
        '
        Me.lblNumOfReservedSeats.AccessibleDescription = ""
        Me.lblNumOfReservedSeats.AutoSize = True
        Me.lblNumOfReservedSeats.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblNumOfReservedSeats.ForeColor = System.Drawing.Color.Black
        Me.lblNumOfReservedSeats.Location = New System.Drawing.Point(172, 46)
        Me.lblNumOfReservedSeats.Name = "lblNumOfReservedSeats"
        Me.lblNumOfReservedSeats.Size = New System.Drawing.Size(2, 15)
        Me.lblNumOfReservedSeats.TabIndex = 4
        '
        'lblTotalNumberOfSeats
        '
        Me.lblTotalNumberOfSeats.AutoSize = True
        Me.lblTotalNumberOfSeats.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotalNumberOfSeats.ForeColor = System.Drawing.Color.Black
        Me.lblTotalNumberOfSeats.Location = New System.Drawing.Point(172, 19)
        Me.lblTotalNumberOfSeats.Name = "lblTotalNumberOfSeats"
        Me.lblTotalNumberOfSeats.Size = New System.Drawing.Size(2, 15)
        Me.lblTotalNumberOfSeats.TabIndex = 3
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(9, 46)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(128, 13)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Number of reserved seats"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(9, 73)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(120, 13)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Number of vacant seats"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(9, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Total number of seats"
        '
        'grpInput
        '
        Me.grpInput.Controls.Add(Me.rbtnCancel)
        Me.grpInput.Controls.Add(Me.rbtnReserve)
        Me.grpInput.Controls.Add(Me.txtPrice)
        Me.grpInput.Controls.Add(Me.Label7)
        Me.grpInput.Controls.Add(Me.btnOK)
        Me.grpInput.Controls.Add(Me.txtName)
        Me.grpInput.Controls.Add(Me.Label8)
        Me.grpInput.ForeColor = System.Drawing.Color.SeaGreen
        Me.grpInput.Location = New System.Drawing.Point(10, 13)
        Me.grpInput.Name = "grpInput"
        Me.grpInput.Size = New System.Drawing.Size(240, 134)
        Me.grpInput.TabIndex = 16
        Me.grpInput.TabStop = False
        Me.grpInput.Text = "Booking Input"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.lstSeats)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.ForeColor = System.Drawing.Color.SeaGreen
        Me.GroupBox3.Location = New System.Drawing.Point(263, 13)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(377, 269)
        Me.GroupBox3.TabIndex = 17
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Reservations"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(645, 286)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.grpInput)
        Me.Controls.Add(Me.grpOutput)
        Me.Name = "MainForm"
        Me.Text = "Form1"
        Me.grpOutput.ResumeLayout(False)
        Me.grpOutput.PerformLayout()
        Me.grpInput.ResumeLayout(False)
        Me.grpInput.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lstSeats As System.Windows.Forms.ListBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents rbtnReserve As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnCancel As System.Windows.Forms.RadioButton
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents txtPrice As System.Windows.Forms.TextBox
    Friend WithEvents grpOutput As System.Windows.Forms.GroupBox
    Friend WithEvents grpInput As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents lblTotalNumberOfSeats As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblNumOfVacantSeats As System.Windows.Forms.Label
    Friend WithEvents lblNumOfReservedSeats As System.Windows.Forms.Label

End Class
