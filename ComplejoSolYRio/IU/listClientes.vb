Public Class listClientes

    Private Sub listClientes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim c As New ClienteClass
        c.Traer(dgvClientes)

    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        If dgvClientes.CurrentRow.Selected = True Then
            Dim c As New ClienteClass

            c.Id = dgvClientes.CurrentRow.Cells("Id").Value

            c.Eliminar(c.Id)

            c.Traer(dgvClientes)

        End If
     

    End Sub

    Private Sub txtBuscar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBuscar.TextChanged

        Dim c As New ClienteClass

        c.Buscar(txtBuscar.Text, dgvClientes)


    End Sub

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        Dim det As New detCliente(dgvClientes)

        det.ShowDialog()

    End Sub
    Private Sub Modificar()

        If dgvClientes.CurrentRow.Selected = True Then

            Dim cliente As New ClienteClass
            cliente.Id = dgvClientes.CurrentRow.Cells("Id").Value
            cliente.Nombre = dgvClientes.CurrentRow.Cells("Nombre").Value
            cliente.Domicilio = dgvClientes.CurrentRow.Cells("Domicilio").Value
            cliente.Correo = dgvClientes.CurrentRow.Cells("Correo").Value
            cliente.Telefono = dgvClientes.CurrentRow.Cells("Telefono").Value


            Dim det As New detCliente(dgvClientes, cliente)

            det.ShowDialog()

        End If
  
    End Sub
    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click

        Modificar()

    End Sub

    Private Sub dgvClientes_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvClientes.CellDoubleClick
        Modificar()

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub btnHistorial_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHistorial.Click
        Dim id As Integer = dgvClientes.CurrentRow.Cells("Id").Value

        Dim h As New Historial(id)

        h.ShowDialog()

    End Sub
End Class