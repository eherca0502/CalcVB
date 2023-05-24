Public Class Form1
    Shared opcion As String
    Private Sub btn0_Click(sender As Object, e As EventArgs) Handles btn0.Click
        txtPantalla.Text += "0"
    End Sub

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        txtPantalla.Text += "1"
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        txtPantalla.Text += "2"
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        txtPantalla.Text += "3"
    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        txtPantalla.Text += "4"
    End Sub

    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        txtPantalla.Text += "5"
    End Sub

    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        txtPantalla.Text += "6"
    End Sub

    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        txtPantalla.Text += "7"
    End Sub

    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        txtPantalla.Text += "8"
    End Sub

    Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
        txtPantalla.Text += "9"
    End Sub

    Private Sub btnDivision_Click(sender As Object, e As EventArgs) Handles btnDivision.Click
        If Operacion.numero1 = -1 Then
            Operacion.numero1 = Double.Parse(txtPantalla.Text)
            opcion = "Division"
            txtPantalla.Clear()
        End If
    End Sub

    Private Sub btnResta_Click(sender As Object, e As EventArgs) Handles btnResta.Click
        If Operacion.numero1 = -1 Then
            Operacion.numero1 = Double.Parse(txtPantalla.Text)
            opcion = "Resta"
            txtPantalla.Clear()
        End If
    End Sub

    Private Sub btnSuma_Click(sender As Object, e As EventArgs) Handles btnSuma.Click
        If Operacion.numero1 = -1 Then
            Operacion.numero1 = Double.Parse(txtPantalla.Text)
            opcion = "Suma"
            txtPantalla.Clear()
        End If
    End Sub

    Private Sub btnMultiplicacion_Click(sender As Object, e As EventArgs) Handles btnMultiplicacion.Click
        If Operacion.numero1 = -1 Then
            Operacion.numero1 = Double.Parse(txtPantalla.Text)
            opcion = "Multiplicacion"
            txtPantalla.Clear()
        End If
    End Sub

    Private Sub btnIgual_Click(sender As Object, e As EventArgs) Handles btnIgual.Click
        If Operacion.numero1 <> -1 Then

            If Operacion.numero2 = -1 Then
                Operacion.numero2 = Double.Parse(txtPantalla.Text)
            Else
                Return
            End If
        Else
            Return
        End If

        Select Case opcion
            Case "Suma"
                Dim operacion As Suma = New Suma()
                Dim resultado As Double = operacion.Calcular()
                txtPantalla.Text = resultado.ToString()
            Case "Resta"
                Dim operacion1 As Resta = New Resta()
                Dim resultado1 As Double = operacion1.Calcular()
                txtPantalla.Text = resultado1.ToString()
            Case "Multiplicacion"
                Dim operacion2 As Multiplicacion = New Multiplicacion()
                Dim resultado2 As Double = operacion2.Calcular()
                txtPantalla.Text = resultado2.ToString()
            Case "Division"
                Dim operacion3 As Division = New Division()
                Dim resultado3 As Double = operacion3.Calcular()
                txtPantalla.Text = resultado3.ToString()
            Case Else
        End Select


        Operacion.numero1 = -1
        Operacion.numero2 = -1
    End Sub

    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click
        txtPantalla.Clear()
    End Sub
End Class
