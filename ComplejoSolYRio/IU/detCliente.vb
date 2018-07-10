Public Class detCliente

    Private Cliente_ As New ClienteClass
    Public Property Cliente() As ClienteClass
        Get
            Return Cliente_

        End Get
        Set(ByVal value As ClienteClass)
            Cliente_ = value
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
    Private lista_ As DataGridView
    Public Property lista() As DataGridView
        Get
            Return lista_
        End Get
        Set(ByVal value As DataGridView)
            lista_ = value
        End Set
    End Property

    Public Sub New(ByVal dgv As DataGridView)

        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()

        lista = dgv

        Operacion = "A"


        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub
    Public Sub New(ByVal dgv As DataGridView, ByVal c As ClienteClass)

        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Cliente = c
        Operacion = "M"

        lista = dgv

    End Sub
    Private Sub detCliente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If Operacion = "M" Then

            txtId.Text = Cliente.Id
            txtNombre.Text = Cliente.Nombre
            txtDomicilio.Text = Cliente.Domicilio
            txtTelefono.Text = Cliente.Telefono
            txtCorreo.Text = Cliente.Correo

        End If

    End Sub


    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click

        Cliente.Nombre = txtNombre.Text
        Cliente.Telefono = txtNombre.Text
        Cliente.Correo = txtCorreo.Text
        Cliente.Domicilio = txtDomicilio.Text


        If Operacion = "M" Then
            Cliente.Id = txtId.Text

            Cliente.Modificar(Cliente)
        Else

            Cliente.Agregar(Cliente)

        End If

        Cliente.Traer(lista)

        Close()

    End Sub
End Class