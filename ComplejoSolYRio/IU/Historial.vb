Public Class Historial
    Private id_ As Integer
    Public Property id() As Integer
        Get
            Return id_
        End Get
        Set(ByVal value As Integer)
            id_ = value
        End Set
    End Property

    Public Sub New(ByVal idcliente As Integer)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        id = idcliente
    End Sub
    Private Sub Historial_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim c As New ClienteClass

        c.Historial(id, dgvReservas)

    End Sub

    Private Sub dgvReservas_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvReservas.CellDoubleClick

        Dim res As New ReservaClass

        res.Id = dgvReservas.CurrentRow.Cells("Id").Value

        'con el id se recuperan todos los datos de la reserva
        res.Datos(res)

        Dim det As New detReserva(res, dgvReservas)

        det.ShowDialog()

    End Sub

End Class