Public Class soal3
    ' Deklarasi variabel global
    Dim tarifKamar As Decimal
    Dim biayaSewa As Decimal
    Private Sub Formsoal3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Mengisi combo box dengan tipe kamar
        ComboBox1.Items.AddRange({"Standard Room", "Superior Room", "Deluxe Room", "Suite Room"})
        ' Mengisi combo box dengan tipe layanan
        ComboBox2.Items.AddRange({"Tanpa Breakfast", "Dengan Breakfast"})
    End Sub
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Memastikan bahwa semua input telah diisi
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or ComboBox1.SelectedIndex = -1 Or ComboBox2.SelectedIndex = -1 Or TextBox4.Text = "" Then
            MessageBox.Show("Semua kolom harus diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Mengatur tarif kamar berdasarkan tipe kamar yang dipilih
        Select Case ComboBox1.SelectedItem.ToString()
            Case "Standard Room"
                tarifKamar = 200000
            Case "Superior Room"
                tarifKamar = 300000
            Case "Deluxe Room"
                tarifKamar = 350000
            Case "Suite Room"
                tarifKamar = 550000
        End Select

        ' Menambah biaya tambahan jika dengan Breakfast
        If ComboBox2.SelectedItem.ToString() = "Dengan Breakfast" Then
            tarifKamar += 20000
        End If

        ' Menghitung biaya sewa
        biayaSewa = tarifKamar * CDec(TextBox4.Text)

        ' Menampilkan data reservasi dan biaya sewa
        Dim hasilReservasi As String = "No Identitas: " & TextBox1.Text & vbCrLf &
                                  "Nama: " & TextBox2.Text & vbCrLf &
                                  "No Hp: " & TextBox3.Text & vbCrLf &
                                  "Jenis Kamar: " & ComboBox1.SelectedItem.ToString() & vbCrLf &
                                  "Tipe Layanan: " & ComboBox2.SelectedItem.ToString() & vbCrLf &
                                  "Lama Menginap: " & TextBox4.Text & " hari" & vbCrLf &
                                  "Biaya Sewa: Rp " & biayaSewa.ToString("N2")

        MessageBox.Show(hasilReservasi, "Hasil Reservasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class