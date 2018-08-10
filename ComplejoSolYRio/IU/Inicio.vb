Public Class Inicio

    Private Sub MatiasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MatiasToolStripMenuItem.Click
        listReservas.ShowDialog()
    End Sub

    Private Sub btnClientes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClientes.Click
        listClientes.ShowDialog()

    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        Dim b As New listReservas

        b.ShowDialog()


    End Sub

End Class
