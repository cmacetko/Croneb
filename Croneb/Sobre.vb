Public Class Sobre

    ' Process.Start("XXXXXXXX")

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

        Process.Start("Mailto:cmacetko@gmail.com")

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

        Process.Start("https://api.whatsapp.com/send?phone=47992784148")

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

        Process.Start(sender.text)

    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.Click

        Process.Start(sender.text)

    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click

        Process.Start(sender.text)

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

        Process.Start(sender.text)

    End Sub

    Private Sub Label19_Click(sender As Object, e As EventArgs) Handles Label19.Click

        Process.Start(sender.text)

    End Sub

    Private Sub Label17_Click(sender As Object, e As EventArgs) Handles Label17.Click

        Process.Start(sender.text)

    End Sub

End Class