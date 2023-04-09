Public Class Segitiga
    Private Sub btnHitung_Click(sender As Object, e As EventArgs) Handles btnHitung.Click
        Dim alas, tinggi, sisimiring, luas, keliling As Double

        alas = Val(txtAlas.Text)
        tinggi = Val(txtTinggi.Text)

        sisimiring = Math.Sqrt(alas ^ 2 + tinggi ^ 2)
        luas = 0.5 * alas * tinggi
        keliling = 2 * (alas + tinggi + sisimiring)

        txtSisi.Text = Str(sisimiring)
        txtLuas.Text = Str(luas)
        txtKeliling.Text = Str(keliling)

    End Sub
End Class
