<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.lblFullName = New System.Windows.Forms.Label()
        Me.lblIdNumber = New System.Windows.Forms.Label()
        Me.lblRegNumber = New System.Windows.Forms.Label()
        Me.lblPhoneNumber = New System.Windows.Forms.Label()
        Me.lblCompMan = New System.Windows.Forms.Label()
        Me.lblSerialNumber = New System.Windows.Forms.Label()
        Me.txtFullName = New System.Windows.Forms.TextBox()
        Me.txtIdNo = New System.Windows.Forms.TextBox()
        Me.txtRegNumber = New System.Windows.Forms.TextBox()
        Me.txtPhoneNumber = New System.Windows.Forms.TextBox()
        Me.txtManufacturer = New System.Windows.Forms.TextBox()
        Me.txtSerialNumber = New System.Windows.Forms.TextBox()
        Me.btnInsert = New System.Windows.Forms.Button()
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.dtgStusentsData = New System.Windows.Forms.DataGridView()
        Me.btnDelete = New System.Windows.Forms.Button()
        CType(Me.dtgStusentsData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblFullName
        '
        Me.lblFullName.AutoSize = True
        Me.lblFullName.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFullName.Location = New System.Drawing.Point(61, 46)
        Me.lblFullName.Name = "lblFullName"
        Me.lblFullName.Size = New System.Drawing.Size(97, 24)
        Me.lblFullName.TabIndex = 0
        Me.lblFullName.Text = "Full Name"
        '
        'lblIdNumber
        '
        Me.lblIdNumber.AutoSize = True
        Me.lblIdNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIdNumber.Location = New System.Drawing.Point(61, 88)
        Me.lblIdNumber.Name = "lblIdNumber"
        Me.lblIdNumber.Size = New System.Drawing.Size(101, 24)
        Me.lblIdNumber.TabIndex = 1
        Me.lblIdNumber.Text = "ID Number"
        '
        'lblRegNumber
        '
        Me.lblRegNumber.AutoSize = True
        Me.lblRegNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRegNumber.Location = New System.Drawing.Point(61, 132)
        Me.lblRegNumber.Name = "lblRegNumber"
        Me.lblRegNumber.Size = New System.Drawing.Size(119, 24)
        Me.lblRegNumber.TabIndex = 2
        Me.lblRegNumber.Text = "Reg Number"
        '
        'lblPhoneNumber
        '
        Me.lblPhoneNumber.AutoSize = True
        Me.lblPhoneNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPhoneNumber.Location = New System.Drawing.Point(477, 40)
        Me.lblPhoneNumber.Name = "lblPhoneNumber"
        Me.lblPhoneNumber.Size = New System.Drawing.Size(140, 24)
        Me.lblPhoneNumber.TabIndex = 3
        Me.lblPhoneNumber.Text = "Phone Number"
        '
        'lblCompMan
        '
        Me.lblCompMan.AutoSize = True
        Me.lblCompMan.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCompMan.Location = New System.Drawing.Point(477, 88)
        Me.lblCompMan.Name = "lblCompMan"
        Me.lblCompMan.Size = New System.Drawing.Size(120, 24)
        Me.lblCompMan.TabIndex = 4
        Me.lblCompMan.Text = "Manufacturer"
        '
        'lblSerialNumber
        '
        Me.lblSerialNumber.AutoSize = True
        Me.lblSerialNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSerialNumber.Location = New System.Drawing.Point(477, 129)
        Me.lblSerialNumber.Name = "lblSerialNumber"
        Me.lblSerialNumber.Size = New System.Drawing.Size(131, 24)
        Me.lblSerialNumber.TabIndex = 5
        Me.lblSerialNumber.Text = "Serial Number"
        '
        'txtFullName
        '
        Me.txtFullName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFullName.Location = New System.Drawing.Point(220, 39)
        Me.txtFullName.Name = "txtFullName"
        Me.txtFullName.Size = New System.Drawing.Size(187, 26)
        Me.txtFullName.TabIndex = 6
        '
        'txtIdNo
        '
        Me.txtIdNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdNo.Location = New System.Drawing.Point(220, 81)
        Me.txtIdNo.Name = "txtIdNo"
        Me.txtIdNo.Size = New System.Drawing.Size(187, 26)
        Me.txtIdNo.TabIndex = 7
        '
        'txtRegNumber
        '
        Me.txtRegNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRegNumber.Location = New System.Drawing.Point(220, 128)
        Me.txtRegNumber.Name = "txtRegNumber"
        Me.txtRegNumber.Size = New System.Drawing.Size(187, 26)
        Me.txtRegNumber.TabIndex = 8
        '
        'txtPhoneNumber
        '
        Me.txtPhoneNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPhoneNumber.Location = New System.Drawing.Point(688, 34)
        Me.txtPhoneNumber.Name = "txtPhoneNumber"
        Me.txtPhoneNumber.Size = New System.Drawing.Size(187, 26)
        Me.txtPhoneNumber.TabIndex = 9
        '
        'txtManufacturer
        '
        Me.txtManufacturer.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtManufacturer.Location = New System.Drawing.Point(688, 81)
        Me.txtManufacturer.Name = "txtManufacturer"
        Me.txtManufacturer.Size = New System.Drawing.Size(187, 26)
        Me.txtManufacturer.TabIndex = 10
        '
        'txtSerialNumber
        '
        Me.txtSerialNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSerialNumber.Location = New System.Drawing.Point(688, 118)
        Me.txtSerialNumber.Name = "txtSerialNumber"
        Me.txtSerialNumber.Size = New System.Drawing.Size(187, 26)
        Me.txtSerialNumber.TabIndex = 11
        '
        'btnInsert
        '
        Me.btnInsert.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInsert.Location = New System.Drawing.Point(292, 178)
        Me.btnInsert.Name = "btnInsert"
        Me.btnInsert.Size = New System.Drawing.Size(101, 36)
        Me.btnInsert.TabIndex = 12
        Me.btnInsert.Text = "Insert"
        Me.btnInsert.UseVisualStyleBackColor = True
        '
        'lblMessage
        '
        Me.lblMessage.AutoSize = True
        Me.lblMessage.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMessage.Location = New System.Drawing.Point(505, 141)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(0, 24)
        Me.lblMessage.TabIndex = 13
        '
        'btnUpdate
        '
        Me.btnUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.Location = New System.Drawing.Point(454, 178)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(101, 36)
        Me.btnUpdate.TabIndex = 14
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'dtgStusentsData
        '
        Me.dtgStusentsData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgStusentsData.Location = New System.Drawing.Point(99, 250)
        Me.dtgStusentsData.Name = "dtgStusentsData"
        Me.dtgStusentsData.Size = New System.Drawing.Size(748, 150)
        Me.dtgStusentsData.TabIndex = 15
        '
        'btnDelete
        '
        Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(598, 178)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(101, 36)
        Me.btnDelete.TabIndex = 16
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.ClientSize = New System.Drawing.Size(927, 450)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.dtgStusentsData)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.lblMessage)
        Me.Controls.Add(Me.btnInsert)
        Me.Controls.Add(Me.txtSerialNumber)
        Me.Controls.Add(Me.txtManufacturer)
        Me.Controls.Add(Me.txtPhoneNumber)
        Me.Controls.Add(Me.txtRegNumber)
        Me.Controls.Add(Me.txtIdNo)
        Me.Controls.Add(Me.txtFullName)
        Me.Controls.Add(Me.lblSerialNumber)
        Me.Controls.Add(Me.lblCompMan)
        Me.Controls.Add(Me.lblPhoneNumber)
        Me.Controls.Add(Me.lblRegNumber)
        Me.Controls.Add(Me.lblIdNumber)
        Me.Controls.Add(Me.lblFullName)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Student Computer Information"
        CType(Me.dtgStusentsData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblFullName As Label
    Friend WithEvents lblIdNumber As Label
    Friend WithEvents lblRegNumber As Label
    Friend WithEvents lblPhoneNumber As Label
    Friend WithEvents lblCompMan As Label
    Friend WithEvents lblSerialNumber As Label
    Friend WithEvents txtFullName As TextBox
    Friend WithEvents txtIdNo As TextBox
    Friend WithEvents txtRegNumber As TextBox
    Friend WithEvents txtPhoneNumber As TextBox
    Friend WithEvents txtManufacturer As TextBox
    Friend WithEvents txtSerialNumber As TextBox
    Friend WithEvents btnInsert As Button
    Friend WithEvents lblMessage As Label
    Friend WithEvents btnUpdate As Button
    Friend WithEvents dtgStusentsData As DataGridView
    Friend WithEvents btnDelete As Button
End Class
