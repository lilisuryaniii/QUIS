Public Class soal2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        ' Mendapatkan nilai dari TextBox
        Dim nim As String = TextBox1.Text
        Dim nama As String = TextBox2.Text
        Dim kelas As String = TextBox3.Text

        ' Mendeklarasikan variabel untuk nilai UTS, UAS, dan Tugas
        Dim nilaiUTS, nilaiUAS, nilaiTugas As Integer

        ' Melakukan konversi dengan TryParse dan memeriksa apakah berhasil
        If Integer.TryParse(TextBox4.Text, nilaiUTS) AndAlso
       Integer.TryParse(TextBox5.Text, nilaiUAS) AndAlso
       Integer.TryParse(TextBox6.Text, nilaiTugas) Then

            ' Melakukan perhitungan nilai akhir
            Dim nilaiAkhir As Double = (nilaiUTS * 0.3) + (nilaiUAS * 0.5) + (nilaiTugas * 0.2)

            ' Menentukan status lulus atau tidak
            Dim status As String = If(nilaiAkhir >= 60, "Lulus", "Tidak Lulus")

            ' Menambahkan data ke Listbox
            Dim result As String = $"NIM: {nim}, Nama: {nama}, Kelas: {kelas}, UTS: {nilaiUTS}, UAS: {nilaiUAS}, Tugas: {nilaiTugas}, Nilai Akhir: {nilaiAkhir}, Status: {status}"
            HASIL.Items.Add(result)

            ' Membersihkan TextBox setelah proses input
            ClearTextBoxes()
        Else
            MessageBox.Show("Harap masukkan nilai numerik bulat untuk UTS, UAS, dan Tugas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
    Private Sub ClearTextBoxes()
        ' Membersihkan TextBox
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
    End Sub
End Class
