Public Class soal1
    Private Sub soal1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Mengambil input dari TextBox
        Dim bilangan As Integer = Integer.Parse(TextBox1.Text)

        ' Memeriksa apakah bilangan ganjil atau genap
        If bilangan Mod 2 = 0 Then
            Label3.Text = "Bilangan Genap"
        Else
            Label3.Text = "Bilangan Ganjil"
        End If
    End Sub
End Class