Public Class Form2
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click

        Select Case txtKendaraan.Text
            Case "MBL" : txtKeterangan.Text = "Mobil"

            Case "MTR" : txtKeterangan.Text = "Motor"

            Case "PSW" : txtKeterangan.Text = "Pesawat"

            Case "KPL" : txtKeterangan.Text = "Kapal"

            Case Else : txtKeterangan.Text = "Tidak Ditemukan"
        End Select

    End Sub
End Class