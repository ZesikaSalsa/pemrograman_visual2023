<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Segitiga
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
        Me.txtAlas = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtTinggi = New System.Windows.Forms.TextBox()
        Me.btnHitung = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtLuas = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtSisi = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtKeliling = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txtAlas
        '
        Me.txtAlas.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtAlas.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.txtAlas.Location = New System.Drawing.Point(250, 61)
        Me.txtAlas.Name = "txtAlas"
        Me.txtAlas.Size = New System.Drawing.Size(139, 39)
        Me.txtAlas.TabIndex = 0
        Me.txtAlas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(53, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(153, 29)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Panjang Alas"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(53, 121)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 29)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Tinggi"
        '
        'txtTinggi
        '
        Me.txtTinggi.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtTinggi.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.txtTinggi.Location = New System.Drawing.Point(250, 117)
        Me.txtTinggi.Name = "txtTinggi"
        Me.txtTinggi.Size = New System.Drawing.Size(139, 39)
        Me.txtTinggi.TabIndex = 2
        Me.txtTinggi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnHitung
        '
        Me.btnHitung.BackColor = System.Drawing.Color.PaleVioletRed
        Me.btnHitung.Font = New System.Drawing.Font("Segoe Print", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHitung.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnHitung.Location = New System.Drawing.Point(253, 182)
        Me.btnHitung.Name = "btnHitung"
        Me.btnHitung.Size = New System.Drawing.Size(127, 61)
        Me.btnHitung.TabIndex = 4
        Me.btnHitung.Text = "Hitung"
        Me.btnHitung.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label3.Location = New System.Drawing.Point(53, 328)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 29)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Luas"
        '
        'txtLuas
        '
        Me.txtLuas.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtLuas.Enabled = False
        Me.txtLuas.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.txtLuas.Location = New System.Drawing.Point(250, 324)
        Me.txtLuas.Name = "txtLuas"
        Me.txtLuas.Size = New System.Drawing.Size(139, 39)
        Me.txtLuas.TabIndex = 7
        Me.txtLuas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label4.Location = New System.Drawing.Point(53, 272)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(126, 29)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Sisi Miring"
        '
        'txtSisi
        '
        Me.txtSisi.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtSisi.Enabled = False
        Me.txtSisi.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.txtSisi.Location = New System.Drawing.Point(250, 268)
        Me.txtSisi.Name = "txtSisi"
        Me.txtSisi.Size = New System.Drawing.Size(139, 39)
        Me.txtSisi.TabIndex = 5
        Me.txtSisi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label5.Location = New System.Drawing.Point(53, 381)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(94, 29)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Keliling"
        '
        'txtKeliling
        '
        Me.txtKeliling.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtKeliling.Enabled = False
        Me.txtKeliling.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.txtKeliling.Location = New System.Drawing.Point(250, 377)
        Me.txtKeliling.Name = "txtKeliling"
        Me.txtKeliling.Size = New System.Drawing.Size(139, 39)
        Me.txtKeliling.TabIndex = 9
        Me.txtKeliling.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Pink
        Me.ClientSize = New System.Drawing.Size(472, 471)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtKeliling)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtLuas)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtSisi)
        Me.Controls.Add(Me.btnHitung)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtTinggi)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtAlas)
        Me.Name = "Form1"
        Me.Text = "Segitiga"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtAlas As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtTinggi As TextBox
    Friend WithEvents btnHitung As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents txtLuas As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtSisi As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtKeliling As TextBox
End Class
