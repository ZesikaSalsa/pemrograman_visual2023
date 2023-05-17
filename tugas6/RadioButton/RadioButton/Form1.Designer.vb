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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.radioAnak = New System.Windows.Forms.RadioButton()
        Me.radioDewasa = New System.Windows.Forms.RadioButton()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtHargaTiket = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(49, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(329, 50)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Pemesanan Masuk Tiket Wisata " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Curug Muarajaya" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label2.Location = New System.Drawing.Point(71, 156)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(126, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Pilih Kategori"
        '
        'radioAnak
        '
        Me.radioAnak.AutoSize = True
        Me.radioAnak.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radioAnak.Location = New System.Drawing.Point(227, 156)
        Me.radioAnak.Name = "radioAnak"
        Me.radioAnak.Size = New System.Drawing.Size(138, 29)
        Me.radioAnak.TabIndex = 2
        Me.radioAnak.TabStop = True
        Me.radioAnak.Text = "Anak-anak "
        Me.radioAnak.UseVisualStyleBackColor = True
        '
        'radioDewasa
        '
        Me.radioDewasa.AutoSize = True
        Me.radioDewasa.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radioDewasa.Location = New System.Drawing.Point(227, 198)
        Me.radioDewasa.Name = "radioDewasa"
        Me.radioDewasa.Size = New System.Drawing.Size(108, 29)
        Me.radioDewasa.TabIndex = 3
        Me.radioDewasa.TabStop = True
        Me.radioDewasa.Text = "Dewasa"
        Me.radioDewasa.UseVisualStyleBackColor = True
        '
        'btnSubmit
        '
        Me.btnSubmit.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.btnSubmit.Location = New System.Drawing.Point(227, 258)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(138, 39)
        Me.btnSubmit.TabIndex = 4
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label3.Location = New System.Drawing.Point(71, 334)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(113, 25)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Harga Tiket"
        '
        'txtHargaTiket
        '
        Me.txtHargaTiket.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtHargaTiket.Location = New System.Drawing.Point(227, 334)
        Me.txtHargaTiket.Name = "txtHargaTiket"
        Me.txtHargaTiket.Size = New System.Drawing.Size(138, 30)
        Me.txtHargaTiket.TabIndex = 6
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(442, 431)
        Me.Controls.Add(Me.txtHargaTiket)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.radioDewasa)
        Me.Controls.Add(Me.radioAnak)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents radioAnak As System.Windows.Forms.RadioButton
    Friend WithEvents radioDewasa As System.Windows.Forms.RadioButton
    Friend WithEvents btnSubmit As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents txtHargaTiket As TextBox
End Class
