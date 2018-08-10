Imports System.Data
Imports System.Data.SqlClient

Public Class ConexionClass

    Private conexion_ As New SqlConnection

    Public Property conexion() As SqlConnection
        Get
            Return conexion_
        End Get
        Set(ByVal value As SqlConnection)
            conexion_ = value
        End Set
    End Property

    Public Sub Conectar()

        'matias
        conexion.ConnectionString = "Server=LAPTOP-K16JEHVE\DEVELOPER;Database=complejosolyrio;Trusted_connection=true;"


        conexion.Open()

    End Sub

    Public Sub Desconectar()

        conexion.Close()


    End Sub
End Class
