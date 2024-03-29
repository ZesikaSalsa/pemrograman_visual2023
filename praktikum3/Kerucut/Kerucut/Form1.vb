﻿Public Class Form1
    Private Function HitungVol(jari As Integer, tinggi As Integer) As Integer
        Dim volume As Integer
        volume = 1 / 3 * Math.PI * jari ^ 2 * tinggi
        Return volume
    End Function

    Private Function HitungLP(jari As Integer, garisPelukis As Integer) As Integer
        Dim luasPermukaan As Integer
        luasPermukaan = Math.PI * jari * (jari + garisPelukis)
        Return luasPermukaan
    End Function

    Private Sub btnHitung_Click(sender As Object, e As EventArgs) Handles btnHitung.Click
        Dim jari, tinggi, garisPelukis, volume, luasPermukaan As Integer

        jari = Val(txtJari.Text)
        tinggi = Val(txtTinggi.Text)
        garisPelukis = Val(txtGP.Text)

        volume = HitungVol(jari, tinggi)
        luasPermukaan = HitungLP(jari, garisPelukis)

        txtVolume.Text = Str(volume)
        txtLuasPermukaan.Text = Str(luasPermukaan)
    End Sub

End Class