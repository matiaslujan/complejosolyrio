Public Class listClientes

    Private Sub listClientes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim c As New ClienteClass
        c.Traer(dgvClientes)

    End Sub
End Class