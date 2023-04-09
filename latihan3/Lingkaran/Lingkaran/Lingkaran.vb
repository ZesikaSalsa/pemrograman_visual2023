Public Class Lingkaran
    Private Sub btnHitung_Click(sender As Object, e As EventArgs) Handles btnHitung.Click
        Dim jarijari, luas, keliling As Double

        jarijari = Val(txtJari.Text)

        luas = Math.PI * jarijari ^ 2
        keliling = 2 * Math.PI * jarijari

        txtLuas.Text = Str(luas)
        txtKeliling.Text = Str(keliling)

    End Sub
End Class
