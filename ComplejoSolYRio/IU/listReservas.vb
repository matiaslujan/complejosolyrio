Public Class listReservas


    Private Sub listReservas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim res As New ReservaClass
        res.Traer(dgvReservas)

    End Sub

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click

        Dim det As New detReserva(dgvReservas)

        det.ShowDialog()


    End Sub

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click

        modificar()

    End Sub
    Private Sub dgvReservas_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvReservas.CellDoubleClick

        modificar()

    End Sub
    Private Sub modificar()

        Dim res As New ReservaClass

        res.Id = dgvReservas.CurrentRow.Cells("Id").Value

        'con el id se recuperan todos los datos de la reserva
        res.Datos(res)

        Dim det As New detReserva(res, dgvReservas)

        det.ShowDialog()

    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click

        Dim res As New ReservaClass

        res.Id = dgvReservas.CurrentRow.Cells("Id").Value

        res.Eliminar(res.Id)

        res.Traer(dgvReservas)
    End Sub

    Private Sub txtBuscar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBuscar.TextChanged
        Dim r As New ReservaClass

        r.Buscar(txtBuscar.Text, dgvReservas)


    End Sub
End Class