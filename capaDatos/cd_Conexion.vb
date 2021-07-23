Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration

Public Class cd_Conexion

    Dim conexion As SqlConnection

    Public Function Conectar() As SqlConnection
        conexion = New SqlConnection(ConfigurationManager.ConnectionStrings("cn").ConnectionString)
        Return conexion
    End Function

End Class
