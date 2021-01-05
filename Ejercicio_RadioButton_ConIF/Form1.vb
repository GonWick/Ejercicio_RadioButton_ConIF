Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "EJERCICIO RADIOBUTTON CON IF"
        ' Display a help button on the form.
        Me.HelpButton = True
        ' Define the border style of the form to a dialog box.
        Me.FormBorderStyle = FormBorderStyle.FixedDialog
        ' Set the MaximizeBox to false to remove the maximize box.
        Me.MaximizeBox = False
        ' Set the MinimizeBox to false to remove the minimize box.
        Me.MinimizeBox = False
        ' Set the accept button of the form to button1.
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Close()
    End Sub

    Private Sub BotonLimpiar_Click(sender As Object, e As EventArgs) Handles BotonLimpiar.Click
        Num1.Text = ""
        Num2.Text = ""
        Resultado.Text = ""
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a, b, r As Double
        a = Num1.Text
        b = Num2.Text
        If Suma.Checked Then
            r = a + b
        End If
        If Resta.Checked Then
            r = a - b
        End If
        If Producto.Checked Then
            r = a * b
        End If
        If Division.Checked Then
            r = a / b
        End If
        If Potencia.Checked Then
            r = a ^ b
        End If
        Resultado.Text = r

    End Sub
End Class
