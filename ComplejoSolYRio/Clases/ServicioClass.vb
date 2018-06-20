Imports System.IO
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

    Private nombre_ As String

    Public Property nombre() As String

        Get

            Return nombre_

        End Get

        Set(ByVal value As String)

            nombre_ = value

        End Set

    End Property
    Public Sub Traer(ByVal dgv As DataGridView)

        Conectar()

        Dim comando As New SqlCommand("ServicioTraer", conexion)

        comando.CommandType = CommandType.StoredProcedure

        Dim table As New Data.DataTable

        Dim adapter As New SqlDataAdapter(comando)

        adapter.Fill(table)

        dgv.DataSource = table

        dgv.Columns("Id").Visible = False


        If dgv.RowCount > 0 Then

            dgv.Rows(0).Selected = False

        End If

        Desconectar()

    End Sub

    Public Sub Agregar(ByVal servicio As ServicioClass)

        Conectar()

        Dim comando As New SqlCommand("ServicioAgregar", conexion)

        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.AddWithValue("@nombre", servicio.nombre)

        comando.ExecuteNonQuery()


        Desconectar()


    End Sub

    Public Sub Modificar(ByVal servicio As ServicioClass)

        Conectar()

        Dim comando As New SqlCommand("ServicioModificar", conexion)

        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.AddWithValue("@nombre", servicio.nombre)

        comando.Parameters.AddWithValue("@id", servicio.Id)

        comando.ExecuteNonQuery()

        Desconectar()
    End Sub

    Public Sub Eliminar(ByVal Id As Integer)

        Conectar()

        Dim comando As New SqlCommand("ServicioEliminar", conexion)

        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.AddWithValue("@id", Id)

        comando.ExecuteNonQuery()

        Desconectar()

        MsgBox("El registro a sido eliminado con exito")

    End Sub

    Public Sub cargarCombo(ByVal combo As ComboBox)
        Conectar()

        Dim comando As New SqlCommand("ServicioTraer", conexion)

        comando.CommandType = CommandType.StoredProcedure

        Dim lista As SqlDataReader = comando.ExecuteReader

        Dim lista2 As New List(Of ServicioClass)

        If lista.HasRows Then

            While lista.Read()

                Dim servicio As New ServicioClass

                servicio.Id = (lista("id"))

                servicio.nombre = (lista("nombre"))

                lista2.Add(servicio)

            End While

            combo.DataSource = lista2

            combo.DisplayMember = "Nombre"

            combo.ValueMember = "id"

        End If

        Desconectar()

    End Sub

End Class
