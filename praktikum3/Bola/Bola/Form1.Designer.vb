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
        Me.txtJari = New System.Windows.Forms.TextBox()
        Me.txtVolume = New System.Windows.Forms.TextBox()
        Me.Volume = New System.Windows.Forms.Label()
        Me.txtLuas = New System.Windows.Forms.TextBox()
        Me.Luas = New System.Windows.Forms.Label()
        Me.btnHitung = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MV Boli", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(29, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(122, 37)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Jari-jari"
        '
        'txtJari
        '
        Me.txtJari.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.txtJari.Location = New System.Drawing.Point(211, 67)
        Me.txtJari.Name = "txtJari"
        Me.txtJari.Size = New System.Drawing.Size(133, 39)
        Me.txtJari.TabIndex = 1
        Me.txtJari.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtVolume
        '
        Me.txtVolume.Enabled = False
        Me.txtVolume.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.txtVolume.Location = New System.Drawing.Point(211, 239)
        Me.txtVolume.Name = "txtVolume"
        Me.txtVolume.Size = New System.Drawing.Size(133, 39)
        Me.txtVolume.TabIndex = 3
        Me.txtVolume.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Volume
        '
        Me.Volume.AutoSize = True
        Me.Volume.Font = New System.Drawing.Font("MV Boli", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Volume.Location = New System.Drawing.Point(29, 239)
        Me.Volume.Name = "Volume"
        Me.Volume.Size = New System.Drawing.Size(111, 37)
        Me.Volume.TabIndex = 2
        Me.Volume.Text = "Volume"
        '
        'txtLuas
        '
        Me.txtLuas.Enabled = False
        Me.txtLuas.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.txtLuas.Location = New System.Drawing.Point(211, 318)
        Me.txtLuas.Name = "txtLuas"
        Me.txtLuas.Size = New System.Drawing.Size(133, 39)
        Me.txtLuas.TabIndex = 5
        Me.txtLuas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Luas
        '
        Me.Luas.AutoSize = True
        Me.Luas.Font = New System.Drawing.Font("MV Boli", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Luas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Luas.Location = New System.Drawing.Point(29, 302)
        Me.Luas.Name = "Luas"
        Me.Luas.Size = New System.Drawing.Size(158, 74)
        Me.Luas.TabIndex = 4
        Me.Luas.Text = "Luas " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Permukaan"
        Me.Luas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnHitung
        '
        Me.btnHitung.Font = New System.Drawing.Font("Perpetua", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnHitung.Location = New System.Drawing.Point(120, 144)
        Me.btnHitung.Name = "btnHitung"
        Me.btnHitung.Size = New System.Drawing.Size(118, 52)
        Me.btnHitung.TabIndex = 6
        Me.btnHitung.Text = "Hitung"
        Me.btnHitung.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Pink
        Me.ClientSize = New System.Drawing.Size(389, 434)
        Me.Controls.Add(Me.btnHitung)
        Me.Controls.Add(Me.txtLuas)
        Me.Controls.Add(Me.Luas)
        Me.Controls.Add(Me.txtVolume)
        Me.Controls.Add(Me.Volume)
        Me.Controls.Add(Me.txtJari)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Bola"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtJari As TextBox
    Friend WithEvents txtVolume As TextBox
    Friend WithEvents Volume As Label
    Friend WithEvents txtLuas As TextBox
    Friend WithEvents Luas As Label
    Friend WithEvents btnHitung As Button
End Class
