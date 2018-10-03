Imports _01_HelloWorld_Windows_Forms_C


Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim oPersona As New clsPersona

        oPersona.nombre = "Jorge"
        oPersona.apellidos = "Obando Lopez"


        MessageBox.Show(oPersona.nombre + " " + oPersona.apellidos)



    End Sub
End Class
