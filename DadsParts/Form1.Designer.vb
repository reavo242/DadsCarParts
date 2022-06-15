<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.grpbxChoices = New System.Windows.Forms.GroupBox()
        Me.rdbtnFind = New System.Windows.Forms.RadioButton()
        Me.rdbtnAdd = New System.Windows.Forms.RadioButton()
        Me.btnSelect = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpbxChoices.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(511, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(266, 211)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'grpbxChoices
        '
        Me.grpbxChoices.BackColor = System.Drawing.Color.Black
        Me.grpbxChoices.Controls.Add(Me.rdbtnFind)
        Me.grpbxChoices.Controls.Add(Me.rdbtnAdd)
        Me.grpbxChoices.Font = New System.Drawing.Font("Segoe UI", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.grpbxChoices.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.grpbxChoices.Location = New System.Drawing.Point(29, 31)
        Me.grpbxChoices.Name = "grpbxChoices"
        Me.grpbxChoices.Size = New System.Drawing.Size(413, 145)
        Me.grpbxChoices.TabIndex = 1
        Me.grpbxChoices.TabStop = False
        Me.grpbxChoices.Text = "What Do You Want To Do..."
        '
        'rdbtnFind
        '
        Me.rdbtnFind.AutoSize = True
        Me.rdbtnFind.Location = New System.Drawing.Point(35, 75)
        Me.rdbtnFind.Name = "rdbtnFind"
        Me.rdbtnFind.Size = New System.Drawing.Size(255, 32)
        Me.rdbtnFind.TabIndex = 2
        Me.rdbtnFind.TabStop = True
        Me.rdbtnFind.Text = "Find A Catalogued Part"
        Me.rdbtnFind.UseVisualStyleBackColor = True
        '
        'rdbtnAdd
        '
        Me.rdbtnAdd.AutoSize = True
        Me.rdbtnAdd.Checked = True
        Me.rdbtnAdd.Font = New System.Drawing.Font("Segoe UI", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.rdbtnAdd.Location = New System.Drawing.Point(35, 37)
        Me.rdbtnAdd.Name = "rdbtnAdd"
        Me.rdbtnAdd.Size = New System.Drawing.Size(186, 32)
        Me.rdbtnAdd.TabIndex = 1
        Me.rdbtnAdd.TabStop = True
        Me.rdbtnAdd.Text = "Add A New Part"
        Me.rdbtnAdd.UseVisualStyleBackColor = True
        '
        'btnSelect
        '
        Me.btnSelect.Font = New System.Drawing.Font("Segoe UI", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.btnSelect.Location = New System.Drawing.Point(52, 215)
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.Size = New System.Drawing.Size(150, 50)
        Me.btnSelect.TabIndex = 3
        Me.btnSelect.Text = "Select"
        Me.btnSelect.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Segoe UI", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.btnExit.Location = New System.Drawing.Point(272, 215)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(150, 50)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(800, 318)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnSelect)
        Me.Controls.Add(Me.grpbxChoices)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Form1"
        Me.Text = "Dad's Car Parts - Main Screen"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpbxChoices.ResumeLayout(False)
        Me.grpbxChoices.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents grpbxChoices As GroupBox
    Friend WithEvents rdbtnAdd As RadioButton
    Friend WithEvents rdbtnFind As RadioButton
    Friend WithEvents btnSelect As Button
    Friend WithEvents btnExit As Button
End Class
