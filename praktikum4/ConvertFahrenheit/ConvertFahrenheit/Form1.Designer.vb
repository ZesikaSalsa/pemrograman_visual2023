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
        Me.txtKelvin = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtReamur = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtFahrenheit = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnConvert = New System.Windows.Forms.Button()
        Me.txtCelcius = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtKelvin
        '
        Me.txtKelvin.Enabled = False
        Me.txtKelvin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKelvin.Location = New System.Drawing.Point(222, 295)
        Me.txtKelvin.Name = "txtKelvin"
        Me.txtKelvin.Size = New System.Drawing.Size(124, 35)
        Me.txtKelvin.TabIndex = 17
        Me.txtKelvin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Perpetua", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(53, 301)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 28)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Kelvin"
        '
        'txtReamur
        '
        Me.txtReamur.Enabled = False
        Me.txtReamur.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReamur.Location = New System.Drawing.Point(222, 230)
        Me.txtReamur.Name = "txtReamur"
        Me.txtReamur.Size = New System.Drawing.Size(124, 35)
        Me.txtReamur.TabIndex = 15
        Me.txtReamur.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Perpetua", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(53, 236)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 28)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Reamur"
        '
        'txtFahrenheit
        '
        Me.txtFahrenheit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFahrenheit.Location = New System.Drawing.Point(222, 69)
        Me.txtFahrenheit.Name = "txtFahrenheit"
        Me.txtFahrenheit.Size = New System.Drawing.Size(124, 35)
        Me.txtFahrenheit.TabIndex = 13
        Me.txtFahrenheit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Perpetua", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(53, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(124, 28)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Fahrenheit"
        '
        'btnConvert
        '
        Me.btnConvert.Font = New System.Drawing.Font("Hobo Std", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConvert.ForeColor = System.Drawing.Color.Black
        Me.btnConvert.Location = New System.Drawing.Point(222, 143)
        Me.btnConvert.Name = "btnConvert"
        Me.btnConvert.Size = New System.Drawing.Size(124, 46)
        Me.btnConvert.TabIndex = 11
        Me.btnConvert.Text = "Convert"
        Me.btnConvert.UseVisualStyleBackColor = True
        '
        'txtCelcius
        '
        Me.txtCelcius.Enabled = False
        Me.txtCelcius.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCelcius.Location = New System.Drawing.Point(222, 361)
        Me.txtCelcius.Name = "txtCelcius"
        Me.txtCelcius.Size = New System.Drawing.Size(124, 35)
        Me.txtCelcius.TabIndex = 10
        Me.txtCelcius.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Perpetua", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(53, 367)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 28)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Celcius"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(413, 467)
        Me.Controls.Add(Me.txtKelvin)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtReamur)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtFahrenheit)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnConvert)
        Me.Controls.Add(Me.txtCelcius)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.Color.White
        Me.Name = "Form1"
        Me.Text = "Konversi Fahrenheit"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtKelvin As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtReamur As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtFahrenheit As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnConvert As Button
    Friend WithEvents txtCelcius As TextBox
    Friend WithEvents Label1 As Label
End Class
