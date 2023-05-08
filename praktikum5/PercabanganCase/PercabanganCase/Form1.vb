Public Class Form1
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click

        Select Case txtMakanan.Text
            Case "NGR" : txtKeterangan.Text = "Nasi Goreng"

            Case "MGR" : txtKeterangan.Text = "Mie Goreng"

            Case "ST" : txtKeterangan.Text = "Sate"

            Case "BKS" : txtKeterangan.Text = "Bakso"

            Case Else : txtKeterangan.Text = "Tidak Ditemukan"
        End Select

    End Sub
End Class