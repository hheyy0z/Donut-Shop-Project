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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadbtnFilled = New System.Windows.Forms.RadioButton()
        Me.RadBtnChoco = New System.Windows.Forms.RadioButton()
        Me.RadBtnSugar = New System.Windows.Forms.RadioButton()
        Me.radbtnGlazed = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.RadBTNCap = New System.Windows.Forms.RadioButton()
        Me.RadBtnReg = New System.Windows.Forms.RadioButton()
        Me.radbtnNone = New System.Windows.Forms.RadioButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Total = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.Tax = New System.Windows.Forms.Label()
        Me.lblTax = New System.Windows.Forms.Label()
        Me.lblSubtotal = New System.Windows.Forms.Label()
        Me.SubTotal = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadbtnFilled)
        Me.GroupBox1.Controls.Add(Me.RadBtnChoco)
        Me.GroupBox1.Controls.Add(Me.RadBtnSugar)
        Me.GroupBox1.Controls.Add(Me.radbtnGlazed)
        Me.GroupBox1.Location = New System.Drawing.Point(67, 53)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(345, 343)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'RadbtnFilled
        '
        Me.RadbtnFilled.AutoSize = True
        Me.RadbtnFilled.Location = New System.Drawing.Point(47, 314)
        Me.RadbtnFilled.Name = "RadbtnFilled"
        Me.RadbtnFilled.Size = New System.Drawing.Size(103, 20)
        Me.RadbtnFilled.TabIndex = 3
        Me.RadbtnFilled.TabStop = True
        Me.RadbtnFilled.Text = "&Filled ($1.50)"
        Me.RadbtnFilled.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.RadbtnFilled.UseVisualStyleBackColor = True
        '
        'RadBtnChoco
        '
        Me.RadBtnChoco.AutoSize = True
        Me.RadBtnChoco.Location = New System.Drawing.Point(47, 232)
        Me.RadBtnChoco.Name = "RadBtnChoco"
        Me.RadBtnChoco.Size = New System.Drawing.Size(134, 20)
        Me.RadBtnChoco.TabIndex = 2
        Me.RadBtnChoco.TabStop = True
        Me.RadBtnChoco.Text = "C&hocolate ($1.25) "
        Me.RadBtnChoco.UseVisualStyleBackColor = True
        '
        'RadBtnSugar
        '
        Me.RadBtnSugar.AutoSize = True
        Me.RadBtnSugar.Location = New System.Drawing.Point(47, 150)
        Me.RadBtnSugar.Name = "RadBtnSugar"
        Me.RadBtnSugar.Size = New System.Drawing.Size(106, 20)
        Me.RadBtnSugar.TabIndex = 1
        Me.RadBtnSugar.TabStop = True
        Me.RadBtnSugar.Text = "&Sugar ($1.05)"
        Me.RadBtnSugar.UseVisualStyleBackColor = True
        '
        'radbtnGlazed
        '
        Me.radbtnGlazed.AutoSize = True
        Me.radbtnGlazed.Location = New System.Drawing.Point(47, 68)
        Me.radbtnGlazed.Name = "radbtnGlazed"
        Me.radbtnGlazed.Size = New System.Drawing.Size(113, 20)
        Me.radbtnGlazed.TabIndex = 0
        Me.radbtnGlazed.TabStop = True
        Me.radbtnGlazed.Text = "&Glazed ($1.05)"
        Me.radbtnGlazed.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.RadBTNCap)
        Me.GroupBox2.Controls.Add(Me.RadBtnReg)
        Me.GroupBox2.Controls.Add(Me.radbtnNone)
        Me.GroupBox2.Location = New System.Drawing.Point(67, 430)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(345, 334)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "GroupBox2"
        '
        'RadBTNCap
        '
        Me.RadBTNCap.AutoSize = True
        Me.RadBTNCap.Location = New System.Drawing.Point(59, 225)
        Me.RadBTNCap.Name = "RadBTNCap"
        Me.RadBTNCap.Size = New System.Drawing.Size(142, 20)
        Me.RadBTNCap.TabIndex = 2
        Me.RadBTNCap.TabStop = True
        Me.RadBTNCap.Text = "Ca&ppuccino ($2.75)"
        Me.RadBTNCap.UseVisualStyleBackColor = True
        '
        'RadBtnReg
        '
        Me.RadBtnReg.AutoSize = True
        Me.RadBtnReg.Location = New System.Drawing.Point(59, 148)
        Me.RadBtnReg.Name = "RadBtnReg"
        Me.RadBtnReg.Size = New System.Drawing.Size(118, 20)
        Me.RadBtnReg.TabIndex = 1
        Me.RadBtnReg.TabStop = True
        Me.RadBtnReg.Text = "&Regular ($1.50)"
        Me.RadBtnReg.UseVisualStyleBackColor = True
        '
        'radbtnNone
        '
        Me.radbtnNone.AutoSize = True
        Me.radbtnNone.Location = New System.Drawing.Point(59, 71)
        Me.radbtnNone.Name = "radbtnNone"
        Me.radbtnNone.Size = New System.Drawing.Size(61, 20)
        Me.radbtnNone.TabIndex = 0
        Me.radbtnNone.TabStop = True
        Me.radbtnNone.Text = "&None"
        Me.radbtnNone.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Total)
        Me.GroupBox3.Controls.Add(Me.lblTotal)
        Me.GroupBox3.Controls.Add(Me.Tax)
        Me.GroupBox3.Controls.Add(Me.lblTax)
        Me.GroupBox3.Controls.Add(Me.lblSubtotal)
        Me.GroupBox3.Controls.Add(Me.SubTotal)
        Me.GroupBox3.Location = New System.Drawing.Point(584, 53)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(388, 342)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "GroupBox3"
        '
        'Total
        '
        Me.Total.AutoSize = True
        Me.Total.Location = New System.Drawing.Point(162, 256)
        Me.Total.Name = "Total"
        Me.Total.Size = New System.Drawing.Size(0, 16)
        Me.Total.TabIndex = 5
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(32, 256)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(69, 16)
        Me.lblTotal.TabIndex = 4
        Me.lblTotal.Text = "Total Due:"
        '
        'Tax
        '
        Me.Tax.AutoSize = True
        Me.Tax.Location = New System.Drawing.Point(162, 180)
        Me.Tax.Name = "Tax"
        Me.Tax.Size = New System.Drawing.Size(0, 16)
        Me.Tax.TabIndex = 3
        '
        'lblTax
        '
        Me.lblTax.AutoSize = True
        Me.lblTax.Location = New System.Drawing.Point(32, 180)
        Me.lblTax.Name = "lblTax"
        Me.lblTax.Size = New System.Drawing.Size(33, 16)
        Me.lblTax.TabIndex = 2
        Me.lblTax.Text = "Tax:"
        '
        'lblSubtotal
        '
        Me.lblSubtotal.AutoSize = True
        Me.lblSubtotal.Location = New System.Drawing.Point(32, 104)
        Me.lblSubtotal.Name = "lblSubtotal"
        Me.lblSubtotal.Size = New System.Drawing.Size(59, 16)
        Me.lblSubtotal.TabIndex = 1
        Me.lblSubtotal.Text = "Subtotal:"
        '
        'SubTotal
        '
        Me.SubTotal.AutoSize = True
        Me.SubTotal.Location = New System.Drawing.Point(162, 104)
        Me.SubTotal.Name = "SubTotal"
        Me.SubTotal.Size = New System.Drawing.Size(0, 16)
        Me.SubTotal.TabIndex = 0
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(631, 512)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(302, 77)
        Me.btnCalculate.TabIndex = 3
        Me.btnCalculate.Text = "&Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(633, 640)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(302, 77)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AccessibleName = "FrmMain"
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1028, 802)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RadbtnFilled As RadioButton
    Friend WithEvents RadBtnChoco As RadioButton
    Friend WithEvents RadBtnSugar As RadioButton
    Friend WithEvents radbtnGlazed As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents RadBTNCap As RadioButton
    Friend WithEvents RadBtnReg As RadioButton
    Friend WithEvents radbtnNone As RadioButton
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Total As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents Tax As Label
    Friend WithEvents lblTax As Label
    Friend WithEvents lblSubtotal As Label
    Friend WithEvents SubTotal As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnExit As Button
End Class
