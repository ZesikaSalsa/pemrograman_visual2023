﻿Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbKodeProdi.Items.Clear()
        cmbKodeProdi.Items.Add("TIF")
        cmbKodeProdi.Items.Add("IND")
        cmbKodeProdi.Items.Add("PET")
    End Sub
    Private Sub cmbProdi_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbKodeProdi.SelectedIndexChanged
        If cmbKodeProdi.Text = "TIF" Then
            txtProdi.Text = "Teknik Informatika"
            txtUKT.Text = "1500000"
            txtBayar.Clear()
            txtSisa.Clear()
        ElseIf cmbKodeProdi.Text = "IND" Then
            txtProdi.Text = "Teknik Industri"
            txtUKT.Text = "1300000"
            txtBayar.Clear()
            txtSisa.Clear()
        ElseIf cmbKodeProdi.Text = "PET" Then
            txtProdi.Text = "Peternakan"
            txtUKT.Text = "1400000"
            txtBayar.Clear()
            txtSisa.Clear()
        End If
    End Sub
    Private Sub txtHitung_Click(sender As Object, e As EventArgs) Handles btnHitung.Click
        txtSisa.Text = Val(txtBayar.Text) - Val(txtUKT.Text)
    End Sub
End Class

