Public Class soal4

    Dim hargaSewaPerHari As Decimal
    Dim biayaSewa As Decimal

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        ' Memastikan bahwa semua input telah diisi
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or ComboBox1.SelectedIndex = -1 Or ComboBox2.SelectedIndex = -1 Or TextBox4.Text = "" Then
            MessageBox.Show("Semua kolom harus diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Mengatur harga sewa per hari berdasarkan jenis mobil yang dipilih
        Select Case ComboBox1.SelectedItem.ToString()
            Case "Toyota Avanza"
                hargaSewaPerHari = 240000
            Case "Toyota Calya"
                hargaSewaPerHari = 210000
            Case "Toyota Inova"
                hargaSewaPerHari = 340000
            Case "Daihatsu Xenia"
                hargaSewaPerHari = 230000
            Case "Daihatsu Sigra"
                hargaSewaPerHari = 200000
            Case "Honda Brio"
                hargaSewaPerHari = 230000
            Case "Honda Mobilio"
                hargaSewaPerHari = 240000
            Case "Mitsubishi Xpander"
                hargaSewaPerHari = 300000
        End Select

        ' Menambah biaya tambahan jika menggunakan sopir
        If ComboBox2.SelectedItem.ToString() = "Dengan Sopir" Then
            hargaSewaPerHari += 150000
        End If

        ' Menghitung biaya sewa
        biayaSewa = hargaSewaPerHari * CDec(TextBox4.Text)

        ' Menampilkan data penyewaan dan biaya sewa
        Dim hasilPenyewaan As String = "No Identitas: " & TextBox1.Text & vbCrLf &
                                      "Nama: " & TextBox2.Text & vbCrLf &
                                      "No Hp: " & TextBox3.Text & vbCrLf &
                                      "Jenis Mobil: " & ComboBox1.SelectedItem.ToString() & vbCrLf &
                                      "Tipe Layanan: " & ComboBox2.SelectedItem.ToString() & vbCrLf &
                                      "Lama Sewa: " & TextBox4.Text & " hari" & vbCrLf &
                                      "Biaya Sewa: Rp " & biayaSewa.ToString("N2")

        Label8.Text = hasilPenyewaan
    End Sub

    Private Sub soal4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Mengisi combo box dengan jenis mobil
        ComboBox1.Items.AddRange({"Toyota Avanza", "Toyota Calya", "Toyota Inova", "Daihatsu Xenia", "Daihatsu Sigra", "Honda Brio", "Honda Mobilio", "Mitsubishi Xpander"})
        ' Mengisi combo box dengan tipe layanan
        ComboBox2.Items.AddRange({"Lepas Kunci", "Dengan Sopir"})
    End Sub
End Class