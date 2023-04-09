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
        Me.btnHitung = New System.Windows.Forms.Button()
        Me.txtLuasPermukaan = New System.Windows.Forms.TextBox()
        Me.Luas = New System.Windows.Forms.Label()
        Me.txtVolume = New System.Windows.Forms.TextBox()
        Me.Volume = New System.Windows.Forms.Label()
        Me.txtSisi = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnHitung
        '
        Me.btnHitung.Font = New System.Drawing.Font("Perpetua", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnHitung.Location = New System.Drawing.Point(115, 134)
        Me.btnHitung.Name = "btnHitung"
        Me.btnHitung.Size = New System.Drawing.Size(118, 52)
        Me.btnHitung.TabIndex = 13
        Me.btnHitung.Text = "Hitung"
        Me.btnHitung.UseVisualStyleBackColor = True
        '
        'txtLuasPermukaan
        '
        Me.txtLuasPermukaan.Enabled = False
        Me.txtLuasPermukaan.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.txtLuasPermukaan.Location = New System.Drawing.Point(206, 308)
        Me.txtLuasPermukaan.Name = "txtLuasPermukaan"
        Me.txtLuasPermukaan.Size = New System.Drawing.Size(133, 39)
        Me.txtLuasPermukaan.TabIndex = 12
        Me.txtLuasPermukaan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Luas
        '
        Me.Luas.AutoSize = True
        Me.Luas.Font = New System.Drawing.Font("MV Boli", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Luas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Luas.Location = New System.Drawing.Point(24, 289)
        Me.Luas.Name = "Luas"
        Me.Luas.Size = New System.Drawing.Size(158, 74)
        Me.Luas.TabIndex = 11
        Me.Luas.Text = "Luas " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Permukaan"
        Me.Luas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtVolume
        '
        Me.txtVolume.Enabled = False
        Me.txtVolume.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.txtVolume.Location = New System.Drawing.Point(206, 229)
        Me.txtVolume.Name = "txtVolume"
        Me.txtVolume.Size = New System.Drawing.Size(133, 39)
        Me.txtVolume.TabIndex = 10
        Me.txtVolume.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Volume
        '
        Me.Volume.AutoSize = True
        Me.Volume.Font = New System.Drawing.Font("MV Boli", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Volume.Location = New System.Drawing.Point(24, 229)
        Me.Volume.Name = "Volume"
        Me.Volume.Size = New System.Drawing.Size(111, 37)
        Me.Volume.TabIndex = 9
        Me.Volume.Text = "Volume"
        '
        'txtSisi
        '
        Me.txtSisi.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.txtSisi.Location = New System.Drawing.Point(206, 57)
        Me.txtSisi.Name = "txtSisi"
        Me.txtSisi.Size = New System.Drawing.Size(133, 39)
        Me.txtSisi.TabIndex = 8
        Me.txtSisi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MV Boli", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(24, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 37)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Sisi"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Pink
        Me.ClientSize = New System.Drawing.Size(367, 440)
        Me.Controls.Add(Me.btnHitung)
        Me.Controls.Add(Me.txtLuasPermukaan)
        Me.Controls.Add(Me.Luas)
        Me.Controls.Add(Me.txtVolume)
        Me.Controls.Add(Me.Volume)
        Me.Controls.Add(Me.txtSisi)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Kubus"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnHitung As Button
    Friend WithEvents txtLuasPermukaan As TextBox
    Friend WithEvents Luas As Label
    Friend WithEvents txtVolume As TextBox
    Friend WithEvents Volume As Label
    Friend WithEvents txtSisi As TextBox
    Friend WithEvents Label1 As Label
End Class
