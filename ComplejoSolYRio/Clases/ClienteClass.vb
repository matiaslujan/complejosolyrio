Imports System.Data.SqlClient

Public Class ClienteClass
    Inherits ConexionClass

    Private Id_ As Integer

    Public Property id() As Integer
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
    Private domicilio_ As String

    Public Property domicilio() As String
        Get
            Return domicilio_

        End Get
        Set(ByVal value As String)
            domicilio_ = value

        End Set
    End Property
    Private telefono_ As String
    Public Property telefono() As String
        Get
            Return telefono_

        End Get
        Set(ByVal value As String)
            telefono_ = value

        End Set
    End Property
    Private correo_ As String

    Public Property correo() As String
        Get
            Return correo_

        End Get
        Set(ByVal value As String)

            correo_ = value

        End Set
    End Property
    Public Sub cargarCombo(ByVal combo As ComboBox)

        Conectar()

        Dim comando As New SqlCommand("ClienteTraer", conexion)

        comando.CommandType = CommandType.StoredProcedure


        Dim lista As SqlDataReader = comando.ExecuteReader

        Dim lista2 As New List(Of ClienteClass)

        If lista.HasRows Then

            While lista.Read()

                Dim cliente As New ClienteClass

                cliente.id = (lista("id"))

                cliente.nombre = (lista("nombre"))

                lista2.Add(cliente)

            End While

            combo.DataSource = lista2

            combo.DisplayMember = "Nombre"

            combo.ValueMember = "id"

        End If


        Desconectar()
    End Sub
End Class
