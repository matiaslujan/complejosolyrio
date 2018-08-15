Public Class listServicios
    Private idres_ As Integer
    Public Property idres() As Integer
        Get

            Return idres_
        End Get
        Set(ByVal value As Integer)
            idres_ = value
        End Set
    End Property
    Public Sub New(ByVal id As Integer)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        idres = id
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub listServicios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim servres As New ServicioClass

        servres.Traer(dgvServiciosReserva, idres)


    End Sub
    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click

        Dim servicios As New detServicio(dgvServiciosReserva, idres)

        servicios.ShowDialog()


    End Sub

    Private Sub modificar()

        Dim servres As New ServicioClass

        servres.Id = dgvServiciosReserva.CurrentRow.Cells("Id").Value
        servres.IdReserva = dgvServiciosReserva.CurrentRow.Cells("IdReserva").Value
        servres.Importe = dgvServiciosReserva.CurrentRow.Cells("Importe").Value
        servres.Fecha = CDate(dgvServiciosReserva.CurrentRow.Cells("Fecha").Value)
        servres.Descripcion = dgvServiciosReserva.CurrentRow.Cells("Descripcion").Value

        Dim det As New detServicio(dgvServiciosReserva, servres)

        det.ShowDialog()


    End Sub

    Private Sub dgvServiciosReserva_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvServiciosReserva.CellDoubleClick

        modificar()

    End Sub

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click

        modificar()

    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click

        Dim servres As New ServicioClass

        servres.Id = dgvServiciosReserva.CurrentRow.Cells("Id").Value

        servres.Eliminar(servres.Id)

        servres.Traer(dgvServiciosReserva, idres)

    End Sub


End Class