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
        Me.txtJari = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtTinggi = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnHitung = New System.Windows.Forms.Button()
        Me.txtLuasPermukaan = New System.Windows.Forms.TextBox()
        Me.Luas = New System.Windows.Forms.Label()
        Me.txtVolume = New System.Windows.Forms.TextBox()
        Me.Volume = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtJari
        '
        Me.txtJari.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.txtJari.Location = New System.Drawing.Point(234, 55)
        Me.txtJari.Name = "txtJari"
        Me.txtJari.Size = New System.Drawing.Size(133, 39)
        Me.txtJari.TabIndex = 39
        Me.txtJari.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("MV Boli", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(28, 55)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(122, 37)
        Me.Label3.TabIndex = 38
        Me.Label3.Text = "Jari-jari"
        '
        'txtTinggi
        '
        Me.txtTinggi.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.txtTinggi.Location = New System.Drawing.Point(234, 111)
        Me.txtTinggi.Name = "txtTinggi"
        Me.txtTinggi.Size = New System.Drawing.Size(133, 39)
        Me.txtTinggi.TabIndex = 37
        Me.txtTinggi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("MV Boli", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(28, 111)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 37)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = "Tinggi"
        '
        'btnHitung
        '
        Me.btnHitung.Font = New System.Drawing.Font("Perpetua", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnHitung.Location = New System.Drawing.Point(139, 188)
        Me.btnHitung.Name = "btnHitung"
        Me.btnHitung.Size = New System.Drawing.Size(118, 52)
        Me.btnHitung.TabIndex = 35
        Me.btnHitung.Text = "Hitung"
        Me.btnHitung.UseVisualStyleBackColor = True
        '
        'txtLuasPermukaan
        '
        Me.txtLuasPermukaan.Enabled = False
        Me.txtLuasPermukaan.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.txtLuasPermukaan.Location = New System.Drawing.Point(234, 364)
        Me.txtLuasPermukaan.Name = "txtLuasPermukaan"
        Me.txtLuasPermukaan.Size = New System.Drawing.Size(133, 39)
        Me.txtLuasPermukaan.TabIndex = 34
        Me.txtLuasPermukaan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Luas
        '
        Me.Luas.AutoSize = True
        Me.Luas.Font = New System.Drawing.Font("MV Boli", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Luas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Luas.Location = New System.Drawing.Point(28, 345)
        Me.Luas.Name = "Luas"
        Me.Luas.Size = New System.Drawing.Size(158, 74)
        Me.Luas.TabIndex = 33
        Me.Luas.Text = "Luas " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Permukaan"
        Me.Luas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtVolume
        '
        Me.txtVolume.Enabled = False
        Me.txtVolume.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.txtVolume.Location = New System.Drawing.Point(234, 280)
        Me.txtVolume.Name = "txtVolume"
        Me.txtVolume.Size = New System.Drawing.Size(133, 39)
        Me.txtVolume.TabIndex = 32
        Me.txtVolume.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Volume
        '
        Me.Volume.AutoSize = True
        Me.Volume.Font = New System.Drawing.Font("MV Boli", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Volume.Location = New System.Drawing.Point(28, 280)
        Me.Volume.Name = "Volume"
        Me.Volume.Size = New System.Drawing.Size(111, 37)
        Me.Volume.TabIndex = 31
        Me.Volume.Text = "Volume"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Pink
        Me.ClientSize = New System.Drawing.Size(410, 487)
        Me.Controls.Add(Me.txtJari)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtTinggi)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnHitung)
        Me.Controls.Add(Me.txtLuasPermukaan)
        Me.Controls.Add(Me.Luas)
        Me.Controls.Add(Me.txtVolume)
        Me.Controls.Add(Me.Volume)
        Me.Name = "Form1"
        Me.Text = "Tabung"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtJari As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtTinggi As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnHitung As Button
    Friend WithEvents txtLuasPermukaan As TextBox
    Friend WithEvents Luas As Label
    Friend WithEvents txtVolume As TextBox
    Friend WithEvents Volume As Label
End Class
