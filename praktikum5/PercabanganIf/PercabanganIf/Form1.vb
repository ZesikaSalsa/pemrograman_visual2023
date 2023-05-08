Public Class Form1
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click

        If (Val(txtNilai.Text) >= 130) Then
            txtKeterangan.Text = "Very Superior (Cerdas)"

        ElseIf (txtNilai.Text >= 120) Then
            txtKeterangan.Text = "Superior (Di Atas Rata-rata)"

        ElseIf (txtNilai.Text >= 110) Then
            txtKeterangan.Text = "High Average (Rata-rata Tinggi)"

        ElseIf (txtNilai.Text >= 90) Then
            txtKeterangan.Text = "Average (Rata-rata)"

        ElseIf (txtNilai.Text >= 80) Then
            txtKeterangan.Text = "Low Average (Rata-rata Rendah)"

        ElseIf (txtNilai.Text >= 70) Then
            txtKeterangan.Text = "Borderline (Batas Fungsi Intelektual)"

        Else
            txtKeterangan.Text = "Intellectual Disability (Sangat Rendah)"
        End If

    End Sub
End Class
