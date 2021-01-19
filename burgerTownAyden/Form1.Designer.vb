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
        Me.btnRequst = New System.Windows.Forms.Button()
        Me.btnRegister = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.radManagement = New System.Windows.Forms.RadioButton()
        Me.radTraining = New System.Windows.Forms.RadioButton()
        Me.radCashier = New System.Windows.Forms.RadioButton()
        Me.radAssembly = New System.Windows.Forms.RadioButton()
        Me.lblTraining = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnRequst
        '
        Me.btnRequst.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRequst.Location = New System.Drawing.Point(303, 225)
        Me.btnRequst.Name = "btnRequst"
        Me.btnRequst.Size = New System.Drawing.Size(133, 28)
        Me.btnRequst.TabIndex = 5
        Me.btnRequst.Text = "Request Promotion"
        Me.btnRequst.UseVisualStyleBackColor = True
        '
        'btnRegister
        '
        Me.btnRegister.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegister.Location = New System.Drawing.Point(123, 225)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Size = New System.Drawing.Size(133, 28)
        Me.btnRegister.TabIndex = 4
        Me.btnRegister.Text = "Register Training"
        Me.btnRegister.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radManagement)
        Me.GroupBox1.Controls.Add(Me.radTraining)
        Me.GroupBox1.Controls.Add(Me.radCashier)
        Me.GroupBox1.Controls.Add(Me.radAssembly)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(15, 24)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(528, 169)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Burger Town Jobs"
        '
        'radManagement
        '
        Me.radManagement.AutoSize = True
        Me.radManagement.Location = New System.Drawing.Point(6, 145)
        Me.radManagement.Name = "radManagement"
        Me.radManagement.Size = New System.Drawing.Size(173, 20)
        Me.radManagement.TabIndex = 3
        Me.radManagement.TabStop = True
        Me.radManagement.Text = "Restaurant Management"
        Me.radManagement.UseVisualStyleBackColor = True
        '
        'radTraining
        '
        Me.radTraining.AutoSize = True
        Me.radTraining.Location = New System.Drawing.Point(6, 103)
        Me.radTraining.Name = "radTraining"
        Me.radTraining.Size = New System.Drawing.Size(147, 20)
        Me.radTraining.TabIndex = 2
        Me.radTraining.TabStop = True
        Me.radTraining.Text = "Training Employees"
        Me.radTraining.UseVisualStyleBackColor = True
        '
        'radCashier
        '
        Me.radCashier.AutoSize = True
        Me.radCashier.Location = New System.Drawing.Point(6, 61)
        Me.radCashier.Name = "radCashier"
        Me.radCashier.Size = New System.Drawing.Size(179, 20)
        Me.radCashier.TabIndex = 1
        Me.radCashier.TabStop = True
        Me.radCashier.Text = "Introductory Cashier Skills"
        Me.radCashier.UseVisualStyleBackColor = True
        '
        'radAssembly
        '
        Me.radAssembly.AutoSize = True
        Me.radAssembly.Location = New System.Drawing.Point(6, 19)
        Me.radAssembly.Name = "radAssembly"
        Me.radAssembly.Size = New System.Drawing.Size(201, 20)
        Me.radAssembly.TabIndex = 0
        Me.radAssembly.TabStop = True
        Me.radAssembly.Text = "Introductory Burger Assembly"
        Me.radAssembly.UseVisualStyleBackColor = True
        '
        'lblTraining
        '
        Me.lblTraining.AutoSize = True
        Me.lblTraining.Location = New System.Drawing.Point(120, 335)
        Me.lblTraining.Name = "lblTraining"
        Me.lblTraining.Size = New System.Drawing.Size(234, 13)
        Me.lblTraining.TabIndex = 6
        Me.lblTraining.Text = "Your Completed Training Will Be Displayed Here"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(558, 444)
        Me.Controls.Add(Me.lblTraining)
        Me.Controls.Add(Me.btnRequst)
        Me.Controls.Add(Me.btnRegister)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnRequst As System.Windows.Forms.Button
    Friend WithEvents btnRegister As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents radManagement As System.Windows.Forms.RadioButton
    Friend WithEvents radTraining As System.Windows.Forms.RadioButton
    Friend WithEvents radCashier As System.Windows.Forms.RadioButton
    Friend WithEvents radAssembly As System.Windows.Forms.RadioButton
    Friend WithEvents lblTraining As System.Windows.Forms.Label

End Class
