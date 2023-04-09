Public Class Trapesium
    Private Sub btnHitung_Click(sender As Object, e As EventArgs) Handles btnHitung.Click
        Dim sisi_a, sisi_b, sisi_c, sisi_d, tinggi, luas, keliling As Double

        sisi_a = Val(txtSisiA.Text)
        sisi_b = Val(txtSisiB.Text)
        sisi_c = Val(txtSisiC.Text)
        sisi_d = Val(txtSisiD.Text)
        tinggi = Val(txtTinggi.Text)

        luas = 0.5 * (sisi_a + sisi_b) * tinggi
        keliling = sisi_a + sisi_b + sisi_c + sisi_d

        txtLuas.Text = Str(luas)
        txtKeliling.Text = Str(keliling)

    End Sub
End Class
