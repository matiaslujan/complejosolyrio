Imports System.Data.SqlClient

Public Class ClienteClass
    Inherits ConexionClass

    Private Id_ As Integer

    Public Property Id() As Integer
        Get
            Return Id_
        End Get
        Set(ByVal value As Integer)
            Id_ = value
        End Set
    End Property
    Private Nombre_ As String


    Public Property Nombre() As String
        Get
            Return Nombre_

        End Get
        Set(ByVal value As String)
            Nombre_ = value

        End Set
    End Property
    Private Domicilio_ As String

    Public Property Domicilio() As String
        Get
            Return Domicilio_

        End Get
        Set(ByVal value As String)
            Domicilio_ = value

        End Set
    End Property
    Private Telefono_ As String
    Public Property Telefono() As String
        Get
            Return Telefono_

        End Get
        Set(ByVal value As String)
            Telefono_ = value

        End Set
    End Property
    Private Correo_ As String

    Public Property Correo() As String
        Get
            Return Correo_

        End Get
        Set(ByVal value As String)

            Correo_ = value

        End Set
    End Property

    Public Sub Traer(ByVal dgv As DataGridView)

        Conectar()

        Dim comando As New SqlCommand("ClienteTraer", conexion)

        comando.CommandType = CommandType.StoredProcedure

        Dim lista As New SqlDataAdapter(comando)

        Dim tabla As New Data.DataTable

        lista.Fill(tabla)

        dgv.DataSource = tabla

        dgv.Columns("Id").Visible = False

        Desconectar()

    End Sub
    Public Sub Agregar(ByVal Cliente As ClienteClass)
        Conectar()

        Dim comando As New SqlCommand("ClienteAgregar", conexion)

        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.AddWithValue("@Nombre", Cliente.Nombre)
        comando.Parameters.AddWithValue("@Domicilio", Cliente.Domicilio)
        comando.Parameters.AddWithValue("@Telefono", Cliente.Telefono)
        comando.Parameters.AddWithValue("@Correo", Cliente.Correo)

        comando.ExecuteNonQuery()


        Desconectar()


    End Sub
    Public Sub Modificar(ByVal Cliente As ClienteClass)

        Conectar()

        Dim comando As New SqlCommand("ClienteModificar", conexion)

        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.AddWithValue("@Nombre", Cliente.Nombre)
        comando.Parameters.AddWithValue("@Domicilio", Cliente.Domicilio)
        comando.Parameters.AddWithValue("@Telefono", Cliente.Telefono)
        comando.Parameters.AddWithValue("@Correo", Cliente.Correo)
        comando.Parameters.AddWithValue("@Id", Cliente.Id)

        comando.ExecuteNonQuery()


        Desconectar()

    End Sub
    Public Sub Eliminar(ByVal Id As Integer)

        Conectar()

        Dim comando As New SqlCommand("ClienteEliminar", conexion)

        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.AddWithValue("@Id", Id)

        comando.ExecuteNonQuery()

        Desconectar()

    End Sub
    Public Sub cargarCombo(ByVal combo As ComboBox)

        Conectar()

        Dim comando As New SqlCommand("ClienteTraer", conexion)

        comando.CommandType = CommandType.StoredProcedure


        Dim lista As SqlDataReader = comando.ExecuteReader

        Dim lista2 As New List(Of ClienteClass)

        If lista.HasRows Then

            While lista.Read()

                Dim cliente As New ClienteClass

                cliente.Id = (lista("id"))

                cliente.Nombre = (lista("nombre"))

                lista2.Add(cliente)

            End While

            combo.DataSource = lista2

            combo.DisplayMember = "Nombre"

            combo.ValueMember = "id"

        End If

        Desconectar()
    End Sub

    Public Sub Buscar(ByVal Nombre As String, ByVal dgv As DataGridView)

        Conectar()

        Dim comando As New SqlCommand("ClienteBuscar", conexion)

        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.AddWithValue("@Nombre", Nombre)

        Dim tabla As New Data.DataTable

        Dim lista As New SqlDataAdapter(comando)

        lista.Fill(tabla)

        dgv.DataSource = tabla

        Desconectar()

    End Sub

    Public Sub Historial(ByVal id As Integer, ByVal dgv As DataGridView)

        Conectar()



        Dim comando As New SqlCommand("ClienteHistorial", conexion)

        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.AddWithValue("@Id", id)

        Dim table As New Data.DataTable
        Dim lista As New SqlDataAdapter(comando)
        lista.Fill(table)

        dgv.DataSource = table

        Desconectar()

    End Sub
End Class
