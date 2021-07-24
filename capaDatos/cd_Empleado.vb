Imports System.Data
Imports System.Data.SqlClient

Public Class cd_Empleado

    Dim objConexion As New cd_Conexion
    Dim da As New SqlDataAdapter
    Dim cn As SqlConnection

    'Función que devuelve la lista de personas desde la base de datos
    Function listarPersonas() As DataSet
        Try
            cn = objConexion.Conectar
            da = New SqlDataAdapter("sp_ListarPersonas", cn)
            Dim ds As New DataSet
            da.Fill(ds, "Personas")
            Return ds
        Catch ex As Exception
            Throw
        Finally
            cn.Dispose()
            da.Dispose()
        End Try
    End Function

    'Función para generar el Id del registro nuevo
    Function generarId() As Integer
        Try
            cn = objConexion.Conectar
            da = New SqlDataAdapter("sp_ObtenerUltimoIdPersonas", cn)
            Dim r As Integer
            r = da.SelectCommand.ExecuteScalar
            Return r
        Catch ex As Exception
            Throw ex
        Finally
            cn.Dispose()
        End Try

    End Function

    Sub registroEmpleados(ByVal obj As capaEntidad.Empleado)
        Try
            cn = objConexion.Conectar
            cn.Open()
            da = New SqlDataAdapter("sp_IngresarNuevoEmpleado", cn)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            With da.SelectCommand.Parameters
                .Add("@idPersona", SqlDbType.Int).Value = obj.idPersona
                .Add("@area", SqlDbType.VarChar).Value = obj.area
            End With
            da.SelectCommand.ExecuteNonQuery()

            MsgBox("Registro realizado con éxito", MsgBoxStyle.Information)
        Catch ex As Exception
            Throw ex
        Finally
            cn.Dispose()
            da.Dispose()
            cn.Close()
        End Try
    End Sub

End Class
