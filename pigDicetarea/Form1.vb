Public Class Form1
    Dim puntajeParcial As Integer = 0
    Dim puntajeJugador As Integer = 0
    Dim puntajeParcialComp As Integer = 0
    Dim puntajeComputadora As Integer = 0

    Private Sub btnTirar_Click(sender As Object, e As EventArgs) Handles btnTirar.Click
        Dim dado As Integer = random()
        puntajeJugador += dado
        puntajeParcial = puntajeJugador
        txtDado.Text = dado
        txtAcum.Text = puntajeParcial

        If dado = 1 Then
            puntajeParcial = 0
            txtAcum.Text = 0
            txtDado.Text = ""
            turnoCompu()
        End If
    End Sub

    Function random() As Integer
        Randomize()
        Dim numero As Integer = CInt(Math.Floor((7 - 2 + 1) * Rnd())) + 1
        Return numero
    End Function

    Private Sub btnParar_Click(sender As Object, e As EventArgs) Handles btnParar.Click
        txtJugador.Text = puntajeParcial
        txtAcum.Text = 0
        txtDado.Text = ""
        turnoCompu()
    End Sub

    Sub turnoCompu()
        For turnoComp = 1 To 3
            Dim dado As Integer = random()
            puntajeComputadora += dado
            puntajeParcialComp = puntajeComputadora
            txtDado.Text = dado
            txtAcum.Text = puntajeParcialComp

            If dado = 1 Then
                puntajeParcialComp = 0
                txtAcum.Text = 0
                txtDado.Text = ""
            End If

        Next
        txtAcum.Text = 0
        txtDado.Text = ""
        txtComputadora.Text = puntajeParcialComp
        Ganador()
    End Sub

    Sub Ganador()
        If puntajeParcial >= 100 Then
            MessageBox.Show("¡Has ganado!")
        End If
        If puntajeParcialComp >= 100 Then
            MessageBox.Show("¡Has perdido!")
        End If
    End Sub
End Class
