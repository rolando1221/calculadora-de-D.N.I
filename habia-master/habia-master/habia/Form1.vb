Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim bb, aa, gg, ee, tt, ll, qq, oo, suma, division, resultado As Double

        bb = dni.Text.Substring(0, 1) * 3
        aa = dni.Text.Substring(1, 1) * 2
        gg = dni.Text.Substring(2, 1) * 7
        ee = dni.Text.Substring(3, 1) * 6
        tt = dni.Text.Substring(4, 1) * 5
        ll = dni.Text.Substring(5, 1) * 4
        qq = dni.Text.Substring(6, 1) * 3
        oo = dni.Text.Substring(7, 1) * 2
        If varon.Checked = True Then
            suma = 10 + bb + aa + gg + ee + tt + ll + qq + oo
        Else
            suma = 38 + bb + aa + gg + ee + tt + ll + qq + oo
        End If
        TextBox1.Text = suma
        division = suma Mod 11
        resultado = 11 - division
        TextBox3.Text = resultado
        cuil.Text = bb

        If varon.Checked = True Then
            TextBox2.Text = "20-" + dni.Text & -resultado

        Else
            TextBox2.Text = "27-" + dni.Text & -resultado
        End If


    End Sub
End Class
