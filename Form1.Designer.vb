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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.start_btn = New System.Windows.Forms.Button()
        Me.again_btn = New System.Windows.Forms.Button()
        Me.done_btn = New System.Windows.Forms.Button()
        Me.apply_math = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.sqroot_2 = New System.Windows.Forms.RadioButton()
        Me.sq_2 = New System.Windows.Forms.RadioButton()
        Me.div_2 = New System.Windows.Forms.RadioButton()
        Me.mul_2 = New System.Windows.Forms.RadioButton()
        Me.sub_2 = New System.Windows.Forms.RadioButton()
        Me.add_2 = New System.Windows.Forms.RadioButton()
        Me.random_label = New System.Windows.Forms.Label()
        Me.counter_label = New System.Windows.Forms.Label()
        Me.new_calc_label = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(128, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = " Original Random Number"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(164, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Counter"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 120)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(122, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "New Calculated Number"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 263)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(219, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "The object of the game is to apply operations"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(11, 276)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(127, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "using the number 2 to an "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 289)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(181, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "initial randomly-selected number until "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(13, 305)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(196, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "the new calculated number equals 100. "
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(14, 323)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(254, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "The challenge is to do so in as few steps as possible"
        '
        'start_btn
        '
        Me.start_btn.Location = New System.Drawing.Point(250, 116)
        Me.start_btn.Name = "start_btn"
        Me.start_btn.Size = New System.Drawing.Size(103, 38)
        Me.start_btn.TabIndex = 8
        Me.start_btn.Text = "Start"
        Me.start_btn.UseVisualStyleBackColor = True
        '
        'again_btn
        '
        Me.again_btn.Location = New System.Drawing.Point(250, 169)
        Me.again_btn.Name = "again_btn"
        Me.again_btn.Size = New System.Drawing.Size(103, 38)
        Me.again_btn.TabIndex = 9
        Me.again_btn.Text = "Again"
        Me.again_btn.UseVisualStyleBackColor = True
        '
        'done_btn
        '
        Me.done_btn.Location = New System.Drawing.Point(250, 228)
        Me.done_btn.Name = "done_btn"
        Me.done_btn.Size = New System.Drawing.Size(103, 38)
        Me.done_btn.TabIndex = 10
        Me.done_btn.Text = "Done"
        Me.done_btn.UseVisualStyleBackColor = True
        '
        'apply_math
        '
        Me.apply_math.Location = New System.Drawing.Point(359, 276)
        Me.apply_math.Name = "apply_math"
        Me.apply_math.Size = New System.Drawing.Size(115, 46)
        Me.apply_math.TabIndex = 11
        Me.apply_math.Text = "Apply the Math"
        Me.apply_math.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.sqroot_2)
        Me.GroupBox1.Controls.Add(Me.sq_2)
        Me.GroupBox1.Controls.Add(Me.div_2)
        Me.GroupBox1.Controls.Add(Me.mul_2)
        Me.GroupBox1.Controls.Add(Me.sub_2)
        Me.GroupBox1.Controls.Add(Me.add_2)
        Me.GroupBox1.Location = New System.Drawing.Point(359, 22)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(125, 244)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Operations"
        '
        'sqroot_2
        '
        Me.sqroot_2.AutoSize = True
        Me.sqroot_2.Location = New System.Drawing.Point(10, 206)
        Me.sqroot_2.Name = "sqroot_2"
        Me.sqroot_2.Size = New System.Drawing.Size(120, 17)
        Me.sqroot_2.TabIndex = 5
        Me.sqroot_2.TabStop = True
        Me.sqroot_2.Text = "Square Root(^(1/2))"
        Me.sqroot_2.UseVisualStyleBackColor = True
        '
        'sq_2
        '
        Me.sq_2.AutoSize = True
        Me.sq_2.Location = New System.Drawing.Point(11, 168)
        Me.sq_2.Name = "sq_2"
        Me.sq_2.Size = New System.Drawing.Size(77, 17)
        Me.sq_2.TabIndex = 4
        Me.sq_2.TabStop = True
        Me.sq_2.Text = "Square(^2)"
        Me.sq_2.UseVisualStyleBackColor = True
        '
        'div_2
        '
        Me.div_2.AutoSize = True
        Me.div_2.Location = New System.Drawing.Point(10, 133)
        Me.div_2.Name = "div_2"
        Me.div_2.Size = New System.Drawing.Size(78, 17)
        Me.div_2.TabIndex = 3
        Me.div_2.TabStop = True
        Me.div_2.Text = "Divide by 2"
        Me.div_2.UseVisualStyleBackColor = True
        '
        'mul_2
        '
        Me.mul_2.AutoSize = True
        Me.mul_2.Location = New System.Drawing.Point(11, 98)
        Me.mul_2.Name = "mul_2"
        Me.mul_2.Size = New System.Drawing.Size(83, 17)
        Me.mul_2.TabIndex = 2
        Me.mul_2.TabStop = True
        Me.mul_2.Text = "Multiply by 2"
        Me.mul_2.UseVisualStyleBackColor = True
        '
        'sub_2
        '
        Me.sub_2.AutoSize = True
        Me.sub_2.Location = New System.Drawing.Point(11, 62)
        Me.sub_2.Name = "sub_2"
        Me.sub_2.Size = New System.Drawing.Size(74, 17)
        Me.sub_2.TabIndex = 1
        Me.sub_2.TabStop = True
        Me.sub_2.Text = "Subtract 2"
        Me.sub_2.UseVisualStyleBackColor = True
        '
        'add_2
        '
        Me.add_2.AutoSize = True
        Me.add_2.Location = New System.Drawing.Point(11, 30)
        Me.add_2.Name = "add_2"
        Me.add_2.Size = New System.Drawing.Size(53, 17)
        Me.add_2.TabIndex = 0
        Me.add_2.TabStop = True
        Me.add_2.Text = "Add 2"
        Me.add_2.UseVisualStyleBackColor = True
        '
        'random_label
        '
        Me.random_label.AutoSize = True
        Me.random_label.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.random_label.Location = New System.Drawing.Point(35, 46)
        Me.random_label.Name = "random_label"
        Me.random_label.Size = New System.Drawing.Size(52, 55)
        Me.random_label.TabIndex = 13
        Me.random_label.Text = "0"
        '
        'counter_label
        '
        Me.counter_label.AutoSize = True
        Me.counter_label.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.counter_label.Location = New System.Drawing.Point(157, 46)
        Me.counter_label.Name = "counter_label"
        Me.counter_label.Size = New System.Drawing.Size(52, 55)
        Me.counter_label.TabIndex = 14
        Me.counter_label.Text = "0"
        '
        'new_calc_label
        '
        Me.new_calc_label.AutoSize = True
        Me.new_calc_label.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.new_calc_label.Location = New System.Drawing.Point(35, 149)
        Me.new_calc_label.Name = "new_calc_label"
        Me.new_calc_label.Size = New System.Drawing.Size(52, 55)
        Me.new_calc_label.TabIndex = 15
        Me.new_calc_label.Text = "0"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(496, 347)
        Me.Controls.Add(Me.new_calc_label)
        Me.Controls.Add(Me.counter_label)
        Me.Controls.Add(Me.random_label)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.apply_math)
        Me.Controls.Add(Me.done_btn)
        Me.Controls.Add(Me.again_btn)
        Me.Controls.Add(Me.start_btn)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Operation 2"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents start_btn As Button
    Friend WithEvents again_btn As Button
    Friend WithEvents done_btn As Button
    Friend WithEvents apply_math As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents sq_2 As RadioButton
    Friend WithEvents div_2 As RadioButton
    Friend WithEvents mul_2 As RadioButton
    Friend WithEvents sub_2 As RadioButton
    Friend WithEvents add_2 As RadioButton
    Friend WithEvents sqroot_2 As RadioButton
    Friend WithEvents random_label As Label
    Friend WithEvents counter_label As Label
    Friend WithEvents new_calc_label As Label
End Class
