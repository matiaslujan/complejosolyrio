Public Class detServicio

    Private servres_ As ServicioClass
    Public Property servres() As ServicioClass
        Get
            Return servres_
        End Get
        Set(ByVal value As ServicioClass)
            servres_ = value
        End Set
    End Property

    Private operacion_ As String

    Public Property operacion() As String
        Get
            Return operacion_
        End Get
        Set(ByVal value As String)
            operacion_ = value
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
    'se recibe la tabla de servicios  y el id de la reserva para agregar un nuevo servicio

    Public Sub New(ByVal dgv As DataGridView, ByVal id As Integer)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        operacion = "A"

        tabla = dgv

        txtIdReserva.Text = id

    End Sub

    'tabla de servicios  y el servicio a modificar

    Public Sub New(ByVal dgv As DataGridView, ByVal sr As ServicioClass)
        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        operacion = "M"

        tabla = dgv

        servres = sr

    End Sub

    Private Sub detServicio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If operacion = "M" Then

            txtId.Text = servres.Id

            txtIdReserva.Text = servres.IdReserva

            txtDescripcion.Text = servres.Descripcion

            txtImporte.Text = servres.Importe

            dtpFecha.Text = servres.Fecha

        End If
    End Sub


    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Dim servr As New ServicioClass

        servr.IdReserva = txtIdReserva.Text
        servr.Importe = txtImporte.Text
        servr.Descripcion = txtDescripcion.Text
        servr.Fecha = dtpFecha.Text

        If operacion = "M" Then
            servr.Id = txtId.Text
            servr.Modificar(servr)
        Else

            servr.Agregar(servr)

        End If

        servr.Traer(tabla, servr.IdReserva)

        Close()
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Close()

    End Sub
End Class