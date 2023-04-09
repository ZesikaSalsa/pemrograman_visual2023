<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Trapesium
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
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtSisiD = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtSisiC = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtSisiB = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtKeliling = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtLuas = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtSisiA = New System.Windows.Forms.TextBox()
        Me.btnHitung = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtTinggi = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label6.Location = New System.Drawing.Point(66, 227)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(76, 29)
        Me.Label6.TabIndex = 55
        Me.Label6.Text = "Sisi D"
        '
        'txtSisiD
        '
        Me.txtSisiD.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtSisiD.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.txtSisiD.Location = New System.Drawing.Point(263, 223)
        Me.txtSisiD.Name = "txtSisiD"
        Me.txtSisiD.Size = New System.Drawing.Size(139, 39)
        Me.txtSisiD.TabIndex = 54
        Me.txtSisiD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label7.Location = New System.Drawing.Point(66, 169)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(76, 29)
        Me.Label7.TabIndex = 53
        Me.Label7.Text = "Sisi C"
        '
        'txtSisiC
        '
        Me.txtSisiC.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtSisiC.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.txtSisiC.Location = New System.Drawing.Point(263, 165)
        Me.txtSisiC.Name = "txtSisiC"
        Me.txtSisiC.Size = New System.Drawing.Size(139, 39)
        Me.txtSisiC.TabIndex = 52
        Me.txtSisiC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label8.Location = New System.Drawing.Point(66, 113)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(75, 29)
        Me.Label8.TabIndex = 51
        Me.Label8.Text = "Sisi B"
        '
        'txtSisiB
        '
        Me.txtSisiB.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtSisiB.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.txtSisiB.Location = New System.Drawing.Point(263, 109)
        Me.txtSisiB.Name = "txtSisiB"
        Me.txtSisiB.Size = New System.Drawing.Size(139, 39)
        Me.txtSisiB.TabIndex = 50
        Me.txtSisiB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label5.Location = New System.Drawing.Point(66, 527)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(94, 29)
        Me.Label5.TabIndex = 49
        Me.Label5.Text = "Keliling"
        '
        'txtKeliling
        '
        Me.txtKeliling.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtKeliling.Enabled = False
        Me.txtKeliling.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.txtKeliling.Location = New System.Drawing.Point(263, 523)
        Me.txtKeliling.Name = "txtKeliling"
        Me.txtKeliling.Size = New System.Drawing.Size(139, 39)
        Me.txtKeliling.TabIndex = 48
        Me.txtKeliling.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label3.Location = New System.Drawing.Point(66, 474)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 29)
        Me.Label3.TabIndex = 47
        Me.Label3.Text = "Luas"
        '
        'txtLuas
        '
        Me.txtLuas.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtLuas.Enabled = False
        Me.txtLuas.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.txtLuas.Location = New System.Drawing.Point(263, 470)
        Me.txtLuas.Name = "txtLuas"
        Me.txtLuas.Size = New System.Drawing.Size(139, 39)
        Me.txtLuas.TabIndex = 46
        Me.txtLuas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label4.Location = New System.Drawing.Point(66, 56)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 29)
        Me.Label4.TabIndex = 45
        Me.Label4.Text = "Sisi A"
        '
        'txtSisiA
        '
        Me.txtSisiA.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtSisiA.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.txtSisiA.Location = New System.Drawing.Point(263, 52)
        Me.txtSisiA.Name = "txtSisiA"
        Me.txtSisiA.Size = New System.Drawing.Size(139, 39)
        Me.txtSisiA.TabIndex = 44
        Me.txtSisiA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnHitung
        '
        Me.btnHitung.BackColor = System.Drawing.Color.PaleVioletRed
        Me.btnHitung.Font = New System.Drawing.Font("Segoe Print", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHitung.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnHitung.Location = New System.Drawing.Point(266, 366)
        Me.btnHitung.Name = "btnHitung"
        Me.btnHitung.Size = New System.Drawing.Size(127, 61)
        Me.btnHitung.TabIndex = 43
        Me.btnHitung.Text = "Hitung"
        Me.btnHitung.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(66, 291)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 29)
        Me.Label2.TabIndex = 42
        Me.Label2.Text = "Tinggi"
        '
        'txtTinggi
        '
        Me.txtTinggi.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtTinggi.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.txtTinggi.Location = New System.Drawing.Point(263, 287)
        Me.txtTinggi.Name = "txtTinggi"
        Me.txtTinggi.Size = New System.Drawing.Size(139, 39)
        Me.txtTinggi.TabIndex = 41
        Me.txtTinggi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Pink
        Me.ClientSize = New System.Drawing.Size(477, 632)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtSisiD)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtSisiC)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtSisiB)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtKeliling)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtLuas)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtSisiA)
        Me.Controls.Add(Me.btnHitung)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtTinggi)
        Me.Name = "Form1"
        Me.Text = "Trapesium"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label6 As Label
    Friend WithEvents txtSisiD As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtSisiC As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtSisiB As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtKeliling As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtLuas As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtSisiA As TextBox
    Friend WithEvents btnHitung As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txtTinggi As TextBox
End Class
