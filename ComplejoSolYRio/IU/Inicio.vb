Public Class Inicio

    Private Sub MatiasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MatiasToolStripMenuItem.Click
        listReservas.ShowDialog()
    End Sub

    Private Sub btnClientes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClientes.Click
        listClientes.ShowDialog()

    End Sub
End Class
