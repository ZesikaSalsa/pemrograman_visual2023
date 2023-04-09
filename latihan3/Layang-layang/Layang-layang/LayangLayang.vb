Public Class LayangLayang
    Private Sub btnHitung_Click(sender As Object, e As EventArgs) Handles btnHitung.Click
        Dim d1, d2, sisi_a, sisi_b, sisi_c, sisi_d, luas, keliling As Double

        d1 = Val(txtD1.Text)
        d2 = Val(txtD2.Text)
        sisi_a = Val(txtSisiA.Text)
        sisi_b = Val(txtSisiB.Text)
        sisi_c = Val(txtSisiC.Text)
        sisi_d = Val(txtSisiD.Text)

        luas = 0.5 * d1 * d2
        keliling = sisi_a + sisi_b + sisi_c + sisi_d

        txtLuas.Text = Str(luas)
        txtKeliling.Text = Str(keliling)

    End Sub
End Class
