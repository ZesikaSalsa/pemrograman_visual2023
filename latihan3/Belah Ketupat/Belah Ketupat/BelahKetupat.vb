Public Class BelahKetupat
    Private Sub btnHitung_Click(sender As Object, e As EventArgs) Handles btnHitung.Click
        Dim d1, d2, sisi, luas, keliling As Double

        d1 = Val(txtD1.Text)
        d2 = Val(txtD2.Text)
        sisi = Val(txtSisi.Text)

        luas = 0.5 * d1 * d2
        keliling = 4 * sisi

        txtLuas.Text = Str(luas)
        txtKeliling.Text = Str(keliling)

    End Sub
End Class
