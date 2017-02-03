Public Class Form1
    Dim puntajeParcial As Integer = 0
    Dim puntajeJugador As Integer = 0

    Private Sub btnTirar_Click(sender As Object, e As EventArgs) Handles btnTirar.Click
        Dim dado As Integer = Random()
        puntajeParcial = puntajeJugador + dado
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
        puntajeJugador += puntajeParcial
        txtAcum.Text = 0
        txtDado.Text = ""
        turnoCompu()
    End Sub

    Sub turnoCompu()

    End Sub
End Class
