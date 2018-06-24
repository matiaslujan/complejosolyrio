Imports System.Data
Imports System.Data.SqlClient

Public Class ServicioClass

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

    Private IdReserva_ As Integer

    Public Property IdReserva() As Integer
        Get
            Return IdReserva_
        End Get
        Set(ByVal value As Integer)
            IdReserva_ = value
        End Set
    End Property

    Private Fecha_ As Date

    Public Property Fecha() As Date
        Get

            Return Fecha_
        End Get
        Set(ByVal value As Date)
            Fecha_ = value
        End Set
    End Property

    Private Importe_ As Decimal

    Public Property Importe() As Decimal
        Get
            Return Importe_
        End Get
        Set(ByVal value As Decimal)
            Importe_ = value
        End Set
    End Property

    Private Descripcion_ As String

    Public Property Descripcion() As String
        Get
            Return Descripcion_
        End Get
        Set(ByVal value As String)
            Descripcion_ = value
        End Set
    End Property

    Public Sub Traer(ByVal dgv As DataGridView, ByVal id As Integer)

        Conectar()

        Dim comando As New SqlCommand("ServicioTraer", conexion)

        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.AddWithValue("@idreserva", id)

        Dim tabla As New Data.DataTable

        Dim adaptador As New SqlDataAdapter(comando)

        adaptador.Fill(tabla)

        dgv.DataSource = tabla

        If dgv.RowCount > 0 Then

            dgv.Rows(0).Selected = False

        End If
        Desconectar()

    End Sub


    Public Sub Agregar(ByVal serv As ServicioClass)

        Conectar()

        Dim comando As New SqlCommand("ServicioAgregar", conexion)

        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.AddWithValue("@IdReserva", serv.IdReserva)
        comando.Parameters.AddWithValue("@Fecha", serv.Fecha)
        comando.Parameters.AddWithValue("@Importe", serv.Importe)
        comando.Parameters.AddWithValue("@Descripcion", serv.Descripcion)

        comando.ExecuteNonQuery()

        Desconectar()

    End Sub

    Public Sub Modificar(ByVal serv As ServicioClass)
        Conectar()

        Dim comando As New SqlCommand("ServicioModificar", conexion)

        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.AddWithValue("@IdReserva", serv.IdReserva)
        comando.Parameters.AddWithValue("@Fecha", serv.Fecha)
        comando.Parameters.AddWithValue("@Importe", serv.Importe)
        comando.Parameters.AddWithValue("@Descripcion", serv.Descripcion)
        comando.Parameters.AddWithValue("@Id", serv.Id)

        comando.ExecuteNonQuery()

        Desconectar()

    End Sub

    Public Sub Eliminar(ByVal id As Integer)

        Conectar()

        Dim comando As New SqlCommand("ServicioEliminar", conexion)

        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.AddWithValue("@Id", id)
        comando.ExecuteNonQuery()

        Desconectar()

    End Sub

End Class
