<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.txtboxPart = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtboxAuto = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtboxVerticalShelf = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtboxShelfSpace = New System.Windows.Forms.TextBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label1.Location = New System.Drawing.Point(16, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 28)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Part Type"
        '
        'txtboxPart
        '
        Me.txtboxPart.Location = New System.Drawing.Point(20, 46)
        Me.txtboxPart.Name = "txtboxPart"
        Me.txtboxPart.Size = New System.Drawing.Size(300, 27)
        Me.txtboxPart.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label2.Location = New System.Drawing.Point(16, 89)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(609, 28)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Automobile Type (if adding multiples then seperate by comma)"
        '
        'txtboxAuto
        '
        Me.txtboxAuto.Location = New System.Drawing.Point(20, 120)
        Me.txtboxAuto.Name = "txtboxAuto"
        Me.txtboxAuto.Size = New System.Drawing.Size(300, 27)
        Me.txtboxAuto.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label3.Location = New System.Drawing.Point(20, 166)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(338, 28)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Vertical Shelf Level (numbers only)"
        '
        'txtboxVerticalShelf
        '
        Me.txtboxVerticalShelf.Location = New System.Drawing.Point(20, 197)
        Me.txtboxVerticalShelf.Name = "txtboxVerticalShelf"
        Me.txtboxVerticalShelf.Size = New System.Drawing.Size(100, 27)
        Me.txtboxVerticalShelf.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Label4.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label4.Location = New System.Drawing.Point(20, 240)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(267, 28)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Shelf Space (numbers only)"
        '
        'txtboxShelfSpace
        '
        Me.txtboxShelfSpace.Location = New System.Drawing.Point(20, 271)
        Me.txtboxShelfSpace.Name = "txtboxShelfSpace"
        Me.txtboxShelfSpace.Size = New System.Drawing.Size(100, 27)
        Me.txtboxShelfSpace.TabIndex = 7
        '
        'btnAdd
        '
        Me.btnAdd.Font = New System.Drawing.Font("Segoe UI", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.btnAdd.Location = New System.Drawing.Point(423, 240)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(150, 50)
        Me.btnAdd.TabIndex = 8
        Me.btnAdd.Text = "Add Part"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Segoe UI", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.btnExit.Location = New System.Drawing.Point(614, 240)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(150, 50)
        Me.btnExit.TabIndex = 9
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(800, 318)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.txtboxShelfSpace)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtboxVerticalShelf)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtboxAuto)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtboxPart)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form2"
        Me.Text = "Dad's Car Parts - Add Part Screen"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtboxPart As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtboxAuto As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtboxVerticalShelf As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtboxShelfSpace As TextBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnExit As Button
End Class
