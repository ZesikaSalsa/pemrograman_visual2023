Public Class Form1
    Private Function HitungVol(jari As Integer) As Integer
        Dim volume As Integer
        volume = 4 / 3 * Math.PI * jari ^ 3
        Return volume
    End Function

    Private Function HitungLP(jari As Integer) As Integer
        Dim luasPermukaan As Integer
        luasPermukaan = 4 * Math.PI * jari ^ 2
        Return luasPermukaan
    End Function

    Private Sub btnHitung_Click(sender As Object, e As EventArgs) Handles btnHitung.Click
        Dim jari, volume, luasPermukaan As Integer

        jari = Val(txtJari.Text)

        volume = HitungVol(jari)
        luasPermukaan = HitungLP(jari)

        txtVolume.Text = Str(volume)
        txtLuas.Text = Str(luasPermukaan)

    End Sub
End Class