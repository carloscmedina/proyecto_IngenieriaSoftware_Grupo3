Imports System.Data
Imports System.Data.SqlClient

Public Class cd_Usuario

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


    Sub registroUsuarios(ByVal obj As capaEntidad.Usuario)
        Try
            cn = objConexion.Conectar
            cn.Open()
            da = New SqlDataAdapter("sp_IngresarNuevoUsuario", cn)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            With da.SelectCommand.Parameters
                .Add("@tipo", SqlDbType.Char).Value = obj.tipoUsuario
                .Add("@idPersona", SqlDbType.Int).Value = obj.idPersona
                .Add("@usuario", SqlDbType.VarChar).Value = obj.usuario
                .Add("@contrasenia", SqlDbType.VarChar).Value = obj.contrasenia

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

    Public Function buscarUsuarios(ByVal idPersona As Integer) As List(Of capaEntidad.Usuario)
        Dim lista As New List(Of capaEntidad.Usuario)
        cn = objConexion.Conectar
        cn.Open()
        Try
            Dim cmd As New SqlCommand("sp_consultarUsuario", cn)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@idPersona", idPersona)
            Dim dr As SqlDataReader
            dr = cmd.ExecuteReader
            While dr.Read
                Dim reg As New capaEntidad.Usuario
                reg.tipoUsuario = dr.GetValue(3).ToString()
                reg.usuario = dr.GetValue(1).ToString()
                reg.contrasenia = dr.GetValue(2).ToString()

                lista.Add(reg)
            End While
            dr.Close()
        Catch ex As Exception
        End Try

        Return lista
    End Function

    'para modificar Empleados'
    Public Sub modificarUsuarios(ByVal registros As capaEntidad.Usuario)
        cn = objConexion.Conectar
        cn.Open()

        Dim cmd As New SqlCommand("sp_ModificarUsuario", cn)
        cmd.CommandType = CommandType.StoredProcedure

        With cmd.Parameters
            .Add("@idPersona", SqlDbType.Int).Value = registros.idPersona
            .Add("@usuario", SqlDbType.VarChar).Value = registros.usuario
            .Add("@contrasenia", SqlDbType.VarChar).Value = registros.contrasenia
            .Add("@tipoUsuario", SqlDbType.Char).Value = registros.tipoUsuario
        End With
        cmd.ExecuteNonQuery()
        MsgBox("Registro modificado con éxito", MsgBoxStyle.Information)
        cn.Close()
    End Sub

End Class
