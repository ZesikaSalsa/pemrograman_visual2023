<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Lingkaran
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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtKeliling = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtLuas = New System.Windows.Forms.TextBox()
        Me.btnHitung = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtJari = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label5.Location = New System.Drawing.Point(42, 259)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(94, 29)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Keliling"
        '
        'txtKeliling
        '
        Me.txtKeliling.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtKeliling.Enabled = False
        Me.txtKeliling.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.txtKeliling.Location = New System.Drawing.Point(239, 255)
        Me.txtKeliling.Name = "txtKeliling"
        Me.txtKeliling.Size = New System.Drawing.Size(139, 39)
        Me.txtKeliling.TabIndex = 20
        Me.txtKeliling.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label3.Location = New System.Drawing.Point(42, 206)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 29)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Luas"
        '
        'txtLuas
        '
        Me.txtLuas.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtLuas.Enabled = False
        Me.txtLuas.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.txtLuas.Location = New System.Drawing.Point(239, 202)
        Me.txtLuas.Name = "txtLuas"
        Me.txtLuas.Size = New System.Drawing.Size(139, 39)
        Me.txtLuas.TabIndex = 18
        Me.txtLuas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnHitung
        '
        Me.btnHitung.BackColor = System.Drawing.Color.PaleVioletRed
        Me.btnHitung.Font = New System.Drawing.Font("Segoe Print", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHitung.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnHitung.Location = New System.Drawing.Point(242, 120)
        Me.btnHitung.Name = "btnHitung"
        Me.btnHitung.Size = New System.Drawing.Size(127, 61)
        Me.btnHitung.TabIndex = 15
        Me.btnHitung.Text = "Hitung"
        Me.btnHitung.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(42, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 29)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Jari-jari"
        '
        'txtJari
        '
        Me.txtJari.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtJari.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.txtJari.Location = New System.Drawing.Point(239, 63)
        Me.txtJari.Name = "txtJari"
        Me.txtJari.Size = New System.Drawing.Size(139, 39)
        Me.txtJari.TabIndex = 11
        Me.txtJari.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Pink
        Me.ClientSize = New System.Drawing.Size(424, 376)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtKeliling)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtLuas)
        Me.Controls.Add(Me.btnHitung)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtJari)
        Me.Name = "Form1"
        Me.Text = "Lingkaran"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label5 As Label
    Friend WithEvents txtKeliling As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtLuas As TextBox
    Friend WithEvents btnHitung As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtJari As TextBox
End Class
