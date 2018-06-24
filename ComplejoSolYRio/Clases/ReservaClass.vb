Imports System.Data
Imports System.Data.SqlClient
Public Class ReservaClass
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

    Private IdCliente_ As Integer

    Public Property IdCliente() As Integer
        Get
            Return IdCliente_
        End Get
        Set(ByVal value As Integer)
            IdCliente_ = value
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

    Private FIngreso_ As Date

    Public Property FIngreso() As Date
        Get
            Return FIngreso_
        End Get
        Set(ByVal value As Date)
            FIngreso_ = value
        End Set
    End Property

    Private FEgreso_ As Date

    Public Property FEgreso() As Date
        Get
            Return FEgreso_
        End Get
        Set(ByVal value As Date)
            FEgreso_ = value
        End Set
    End Property

    Private CantPersonas_ As Integer

    Public Property CantPersonas() As Integer
        Get
            Return CantPersonas_
        End Get
        Set(ByVal value As Integer)
            CantPersonas_ = value
        End Set
    End Property

    Private CantDias_ As Integer

    Public Property CantDias() As Integer
        Get
            Return CantDias_
        End Get
        Set(ByVal value As Integer)
            CantDias_ = value
        End Set
    End Property

    Private ImpDia_ As Decimal

    Public Property ImpDia() As Decimal
        Get
            Return ImpDia_

        End Get
        Set(ByVal value As Decimal)
            ImpDia_ = value
        End Set
    End Property

    Private ImpTotal_ As Decimal

    Public Property ImpTotal() As Decimal
        Get
            Return ImpTotal_
        End Get
        Set(ByVal value As Decimal)
            ImpTotal_ = value
        End Set
    End Property

    Public Sub Traer(ByVal dgv As DataGridView)

        Conectar()

        Dim consulta As String = "SELECT r.Id, r.FIngreso Ingreso, r.FEgreso Egreso, r.FReserva Reservado  FROM Reservas r  " _
        & "group by r.Id,r.FIngreso, r.FEgreso,r.FReserva " _
        & "order by r.freserva desc"

        Dim comando As New SqlCommand(consulta, conexion)

        Dim table As New Data.DataTable

        Dim adapter As New SqlDataAdapter(comando)

        adapter.Fill(table)

        dgv.DataSource = table


        Desconectar()

    End Sub

    Public Sub Datos(ByVal reserva As ReservaClass)

        Conectar()

        Dim consulta As String = "SELECT * FROM Reservas WHERE Id = @Id"

        Dim comando As New SqlCommand(consulta, conexion)

        comando.Parameters.AddWithValue("@Id", reserva.id)

        Dim lista As SqlDataReader = comando.ExecuteReader

        If lista.HasRows Then

            While lista.Read()

                reserva.id = (lista("Id"))
                reserva.IdCliente = (lista("IdCliente"))
                reserva.Fecha = (lista("FReserva"))
                reserva.FIngreso = (lista("FIngreso"))
                reserva.FEgreso = (lista("FEgreso"))
                reserva.CantPersonas = (lista("cantPersonas"))
                reserva.CantDias = (lista("CantDias"))
                reserva.ImpDia = (lista("impDia"))
                reserva.ImpTotal = (lista("ImpTotal"))

            End While

        End If

        Desconectar()

    End Sub
    Public Sub Agregar(ByVal reserva As ReservaClass)

        Conectar()

        Dim consulta As String = "INSERT INTO reservas (IdCliente,FIngreso,FEgreso,FReserva, CantDias,cantPersonas,impDia,ImpTotal)" _
        & "values (@IdCliente,@FIngreso,@FEgreso,@FReserva, @CantDias,@cantPersonas,@impDia,@ImpTotal)"

        Dim comando As New SqlCommand(consulta, conexion)

        comando.Parameters.AddWithValue("@IdCliente", reserva.IdCliente)
        comando.Parameters.AddWithValue("@FIngreso", reserva.FIngreso)
        comando.Parameters.AddWithValue("@FEgreso", reserva.FEgreso)
        comando.Parameters.AddWithValue("@FReserva", reserva.Fecha)
        comando.Parameters.AddWithValue("@CantDias", reserva.CantDias)
        comando.Parameters.AddWithValue("@cantPersonas", reserva.CantPersonas)
        comando.Parameters.AddWithValue("@impDia", reserva.ImpDia)
        comando.Parameters.AddWithValue("@ImpTotal", reserva.ImpTotal)

        comando.ExecuteNonQuery()


        Desconectar()

    End Sub

    Public Sub Modificar(ByVal reserva As ReservaClass)

        Conectar()

        Dim consulta As String = "UPDATE Reservas SET IdCliente=@IdCliente, FIngreso=@FIngreso, " _
        & " FEgreso=@FEgreso,FReserva=@FReserva, CantDias = @CantDias,CantPersonas=@CantPersonas, " _
        & "impDia=@impDia, ImpTotal=@ImpTotal WHERE id=@id"

        Dim comando As New SqlCommand(consulta, conexion)

        comando.Parameters.AddWithValue("@IdCliente", reserva.IdCliente)
        comando.Parameters.AddWithValue("@FIngreso", reserva.FIngreso)
        comando.Parameters.AddWithValue("@FEgreso", reserva.FEgreso)
        comando.Parameters.AddWithValue("@FReserva", reserva.Fecha)
        comando.Parameters.AddWithValue("@CantDias", reserva.CantDias)
        comando.Parameters.AddWithValue("@CantPersonas", reserva.CantPersonas)
        comando.Parameters.AddWithValue("@ImpDia", reserva.ImpDia)
        comando.Parameters.AddWithValue("@ImpTotal", reserva.ImpTotal)
        comando.Parameters.AddWithValue("@Id", reserva.Id)

        comando.ExecuteNonQuery()

        Desconectar()

    End Sub

    Public Sub Eliminar(ByVal Id As Integer)

        Conectar()

        Dim consulta As String = "DELETE FROM reservas WHERE id=@id"

        Dim comando As New SqlCommand(consulta, conexion)

        comando.Parameters.AddWithValue("@id", Id)

        comando.ExecuteNonQuery()

        Desconectar()

    End Sub

    Public Sub ultimoid(ByVal txt As TextBox)

        Conectar()

        Dim consultas As String = "SELECT TOP(1)Id FROM Reservas ORDER BY Id DESC"

        Dim comando As New SqlCommand(consultas, conexion)

        txt.Text = comando.ExecuteScalar

        Desconectar()


    End Sub
End Class
