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
            Throw
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
            Throw
        Finally
            cn.Dispose()
            da.Dispose()
            cn.Close()
        End Try
    End Sub

    Public Function buscarEmpleados(ByVal idPersona As Integer) As List(Of capaEntidad.Empleado)
        Dim lista As New List(Of capaEntidad.Empleado)
        cn = objConexion.Conectar
        cn.Open()
        Try
            Dim cmd As New SqlCommand("sp_consultarEmpleado", cn)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@idPersona", idPersona)
            Dim dr As SqlDataReader
            dr = cmd.ExecuteReader
            While dr.Read
                Dim reg As New capaEntidad.Empleado
                reg.area = dr.GetValue(1).ToString()
                lista.Add(reg)
            End While
            dr.Close()
        Catch ex As Exception
        End Try

        Return lista
    End Function

    'para modificar Empleados'
    Public Sub modificarEmpleados(ByVal registros As capaEntidad.Empleado)
        cn = objConexion.Conectar
        cn.Open()

        Dim cmd As New SqlCommand("sp_ModificarEmpleado", cn)
        cmd.CommandType = CommandType.StoredProcedure

        With cmd.Parameters
            .Add("@idPersona", SqlDbType.Int).Value = registros.idPersona
            .Add("@area", SqlDbType.VarChar).Value = registros.area
        End With
        cmd.ExecuteNonQuery()
        MsgBox("Registro modificado con éxito", MsgBoxStyle.Information)
        cn.Close()
    End Sub

End Class
