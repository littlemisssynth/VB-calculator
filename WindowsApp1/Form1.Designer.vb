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
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnSubtract = New System.Windows.Forms.Button()
        Me.btnDivide = New System.Windows.Forms.Button()
        Me.btnMultiply = New System.Windows.Forms.Button()
        Me.txtResult = New System.Windows.Forms.TextBox()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.btnEnd = New System.Windows.Forms.Button()
        Me.numAlpha = New System.Windows.Forms.TextBox()
        Me.numBeta = New System.Windows.Forms.TextBox()
        Me.btnInt = New System.Windows.Forms.Button()
        Me.btnRemainer = New System.Windows.Forms.Button()
        Me.btnExponentiation = New System.Windows.Forms.Button()
        Me.btnConcatenation = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(138, 40)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 1
        Me.btnAdd.Text = "Add (+)"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnSubtract
        '
        Me.btnSubtract.Location = New System.Drawing.Point(219, 40)
        Me.btnSubtract.Name = "btnSubtract"
        Me.btnSubtract.Size = New System.Drawing.Size(75, 23)
        Me.btnSubtract.TabIndex = 2
        Me.btnSubtract.Text = "Minus (-)"
        Me.btnSubtract.UseVisualStyleBackColor = True
        '
        'btnDivide
        '
        Me.btnDivide.Location = New System.Drawing.Point(219, 69)
        Me.btnDivide.Name = "btnDivide"
        Me.btnDivide.Size = New System.Drawing.Size(75, 23)
        Me.btnDivide.TabIndex = 3
        Me.btnDivide.Text = "Divide (/)"
        Me.btnDivide.UseVisualStyleBackColor = True
        '
        'btnMultiply
        '
        Me.btnMultiply.Location = New System.Drawing.Point(138, 69)
        Me.btnMultiply.Name = "btnMultiply"
        Me.btnMultiply.Size = New System.Drawing.Size(75, 23)
        Me.btnMultiply.TabIndex = 4
        Me.btnMultiply.Text = "Times (*)"
        Me.btnMultiply.UseVisualStyleBackColor = True
        '
        'txtResult
        '
        Me.txtResult.Location = New System.Drawing.Point(138, 209)
        Me.txtResult.Name = "txtResult"
        Me.txtResult.Size = New System.Drawing.Size(100, 20)
        Me.txtResult.TabIndex = 6
        '
        'lblResult
        '
        Me.lblResult.AutoSize = True
        Me.lblResult.Location = New System.Drawing.Point(135, 182)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(37, 13)
        Me.lblResult.TabIndex = 7
        Me.lblResult.Text = "Result"
        '
        'btnEnd
        '
        Me.btnEnd.Location = New System.Drawing.Point(320, 206)
        Me.btnEnd.Name = "btnEnd"
        Me.btnEnd.Size = New System.Drawing.Size(75, 23)
        Me.btnEnd.TabIndex = 8
        Me.btnEnd.Text = "End"
        Me.btnEnd.UseVisualStyleBackColor = True
        '
        'numAlpha
        '
        Me.numAlpha.Location = New System.Drawing.Point(13, 59)
        Me.numAlpha.Name = "numAlpha"
        Me.numAlpha.Size = New System.Drawing.Size(100, 20)
        Me.numAlpha.TabIndex = 9
        '
        'numBeta
        '
        Me.numBeta.Location = New System.Drawing.Point(320, 59)
        Me.numBeta.Name = "numBeta"
        Me.numBeta.Size = New System.Drawing.Size(100, 20)
        Me.numBeta.TabIndex = 10
        '
        'btnInt
        '
        Me.btnInt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInt.Location = New System.Drawing.Point(138, 127)
        Me.btnInt.Name = "btnInt"
        Me.btnInt.Size = New System.Drawing.Size(156, 23)
        Me.btnInt.TabIndex = 11
        Me.btnInt.Text = "interger division (\)"
        Me.btnInt.UseVisualStyleBackColor = True
        '
        'btnRemainer
        '
        Me.btnRemainer.Location = New System.Drawing.Point(138, 98)
        Me.btnRemainer.Name = "btnRemainer"
        Me.btnRemainer.Size = New System.Drawing.Size(75, 23)
        Me.btnRemainer.TabIndex = 12
        Me.btnRemainer.Text = "remainder"
        Me.btnRemainer.UseVisualStyleBackColor = True
        '
        'btnExponentiation
        '
        Me.btnExponentiation.Location = New System.Drawing.Point(219, 98)
        Me.btnExponentiation.Name = "btnExponentiation"
        Me.btnExponentiation.Size = New System.Drawing.Size(75, 23)
        Me.btnExponentiation.TabIndex = 13
        Me.btnExponentiation.Text = "raise to"
        Me.btnExponentiation.UseVisualStyleBackColor = True
        '
        'btnConcatenation
        '
        Me.btnConcatenation.Location = New System.Drawing.Point(138, 156)
        Me.btnConcatenation.Name = "btnConcatenation"
        Me.btnConcatenation.Size = New System.Drawing.Size(156, 23)
        Me.btnConcatenation.TabIndex = 14
        Me.btnConcatenation.Text = "concatenation"
        Me.btnConcatenation.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(432, 290)
        Me.Controls.Add(Me.btnConcatenation)
        Me.Controls.Add(Me.btnExponentiation)
        Me.Controls.Add(Me.btnRemainer)
        Me.Controls.Add(Me.btnInt)
        Me.Controls.Add(Me.numBeta)
        Me.Controls.Add(Me.numAlpha)
        Me.Controls.Add(Me.btnEnd)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.txtResult)
        Me.Controls.Add(Me.btnMultiply)
        Me.Controls.Add(Me.btnDivide)
        Me.Controls.Add(Me.btnSubtract)
        Me.Controls.Add(Me.btnAdd)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnSubtract As Button
    Friend WithEvents btnDivide As Button
    Friend WithEvents btnMultiply As Button
    Friend WithEvents txtResult As TextBox
    Friend WithEvents lblResult As Label
    Friend WithEvents btnEnd As Button
    Friend WithEvents numAlpha As TextBox
    Friend WithEvents numBeta As TextBox
    Friend WithEvents btnInt As Button
    Friend WithEvents btnRemainer As Button
    Friend WithEvents btnExponentiation As Button
    Friend WithEvents btnConcatenation As Button
End Class
