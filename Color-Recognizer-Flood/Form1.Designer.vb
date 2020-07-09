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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.r1 = New System.Windows.Forms.TextBox()
        Me.g1 = New System.Windows.Forms.TextBox()
        Me.b1 = New System.Windows.Forms.TextBox()
        Me.r2 = New System.Windows.Forms.TextBox()
        Me.g2 = New System.Windows.Forms.TextBox()
        Me.b2 = New System.Windows.Forms.TextBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(800, 450)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 477)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(161, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Select an image file:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(423, 477)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "RGB values:"
        '
        'r1
        '
        Me.r1.Location = New System.Drawing.Point(533, 479)
        Me.r1.MaxLength = 3
        Me.r1.Name = "r1"
        Me.r1.Size = New System.Drawing.Size(30, 20)
        Me.r1.TabIndex = 3
        Me.r1.Text = "255"
        Me.r1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'g1
        '
        Me.g1.Location = New System.Drawing.Point(569, 479)
        Me.g1.MaxLength = 3
        Me.g1.Name = "g1"
        Me.g1.Size = New System.Drawing.Size(30, 20)
        Me.g1.TabIndex = 4
        Me.g1.Text = "255"
        Me.g1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'b1
        '
        Me.b1.Location = New System.Drawing.Point(605, 479)
        Me.b1.MaxLength = 3
        Me.b1.Name = "b1"
        Me.b1.Size = New System.Drawing.Size(30, 20)
        Me.b1.TabIndex = 5
        Me.b1.Text = "255"
        Me.b1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'r2
        '
        Me.r2.Location = New System.Drawing.Point(533, 505)
        Me.r2.MaxLength = 3
        Me.r2.Name = "r2"
        Me.r2.Size = New System.Drawing.Size(30, 20)
        Me.r2.TabIndex = 6
        Me.r2.Text = "255"
        Me.r2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.r2.Visible = False
        '
        'g2
        '
        Me.g2.Location = New System.Drawing.Point(569, 505)
        Me.g2.MaxLength = 3
        Me.g2.Name = "g2"
        Me.g2.Size = New System.Drawing.Size(30, 20)
        Me.g2.TabIndex = 7
        Me.g2.Text = "255"
        Me.g2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.g2.Visible = False
        '
        'b2
        '
        Me.b2.Location = New System.Drawing.Point(605, 505)
        Me.b2.MaxLength = 3
        Me.b2.Name = "b2"
        Me.b2.Size = New System.Drawing.Size(30, 20)
        Me.b2.TabIndex = 8
        Me.b2.Text = "255"
        Me.b2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.b2.Visible = False
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(427, 500)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(80, 17)
        Me.CheckBox1.TabIndex = 9
        Me.CheckBox1.Text = "Dualsearch"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(539, 463)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(15, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "R"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(575, 463)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(15, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "G"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(611, 463)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(14, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "B"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(16, 505)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(230, 20)
        Me.TextBox1.TabIndex = 13
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(252, 505)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(53, 23)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "Open"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(16, 532)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 15
        Me.Button2.Text = "Go"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(97, 535)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(138, 20)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Calculation took: "
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(835, 584)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.b2)
        Me.Controls.Add(Me.g2)
        Me.Controls.Add(Me.r2)
        Me.Controls.Add(Me.b1)
        Me.Controls.Add(Me.g1)
        Me.Controls.Add(Me.r1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Form1"
        Me.Text = "Flood border recognizer"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents r1 As TextBox
    Friend WithEvents g1 As TextBox
    Friend WithEvents b1 As TextBox
    Friend WithEvents r2 As TextBox
    Friend WithEvents g2 As TextBox
    Friend WithEvents b2 As TextBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Label6 As Label
End Class
