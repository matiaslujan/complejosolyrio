Public Class detReserva

    Private Reserva_ As ReservaClass

    Public Property Reserva() As ReservaClass
        Get
            Return Reserva_
        End Get
        Set(ByVal value As ReservaClass)
            Reserva_ = value
        End Set
    End Property

    Private Operacion_ As String

    Public Property Operacion() As String
        Get
            Return Operacion_
        End Get
        Set(ByVal value As String)
            Operacion_ = value
        End Set
    End Property
    Private tabla_ As DataGridView
    Public Property tabla() As DataGridView
        Get
            Return tabla_
        End Get
        Set(ByVal value As DataGridView)
            tabla_ = value
        End Set
    End Property
    Public Sub New(ByVal dgv As DataGridView)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        Reserva = Nothing
        ' Add any initialization after the InitializeComponent() call.
        Operacion = "A"

        tabla = dgv

    End Sub

    Public Sub New(ByVal res As ReservaClass, ByVal dgv As DataGridView)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        Reserva = res

        Operacion = "M"

        tabla = dgv

        ' Add any initialization after the InitializeComponent() call.


    End Sub


    Private Sub detReserva_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim cliente As New ClienteClass

        cliente.cargarCombo(cbClientes)

        If Operacion = "M" Then

            txtId.Text = Reserva.Id
            txtCantDia.Text = Reserva.CantDias
            txtCantPer.Text = Reserva.CantPersonas
            txtTotal.Text = "$" + CStr(Reserva.ImpTotal)
            txtImpDia.Text = "$" + CStr(Reserva.ImpDia)
            dtpFecha.Text = Reserva.Fecha
            dtpFechaEgreso.Text = Reserva.FEgreso
            dtpFechaIngreso.Text = Reserva.FIngreso
            cbClientes.SelectedValue = Reserva.IdCliente

            Dim servres As New ServicioClass

            servres.Traer(dgvServiciosReserva, Reserva.Id)

        Else

            btnAgregar.Enabled = False
            btnModificar.Enabled = False
            btnEliminar.Enabled = False

        End If
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click


        Dim reserva As New ReservaClass

        reserva.IdCliente = cbClientes.SelectedValue
        reserva.FIngreso = CDate(dtpFechaIngreso.Text)
        reserva.FEgreso = CDate(dtpFechaEgreso.Text)
        reserva.Fecha = CDate(dtpFecha.Text)
        reserva.CantDias = txtCantDia.Text
        reserva.CantPersonas = txtCantPer.Text
        reserva.ImpDia = txtImpDia.Text
        reserva.ImpTotal = txtTotal.Text
        reserva.Descripcion = txtDescripcion.Text


        If Operacion = "M" Then

            reserva.Id = txtId.Text

            reserva.Modificar(reserva)

            MsgBox("Cambios guardados")


        Else

            reserva.Agregar(reserva)

            reserva.ultimoid(txtId)

            MsgBox("Datos Cargados")

            Operacion = "M"
            btnAgregar.Enabled = True
            btnModificar.Enabled = True
            btnEliminar.Enabled = True
        End If

        reserva.Traer(tabla)



    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click

        Close()

    End Sub

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click

        Dim servicios As New detServicio(dgvServiciosReserva, txtId.Text)

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

        servres.Traer(dgvServiciosReserva, txtId.Text)

    End Sub


    Private Sub btnCalcular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalcular.Click

        txtTotal.Text = txtCantDia.Text * txtImpDia.Text

    End Sub

    Private Sub dtpFechaEgreso_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpFechaEgreso.ValueChanged

        txtCantDia.Text = DateDiff(DateInterval.Day, CDate(dtpFechaIngreso.Text), CDate(dtpFechaEgreso.Text))

    End Sub

End Class