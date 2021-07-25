Imports System.Data
Imports System.Data.SqlClient

Public Class cd_Medico

    Dim objConexion As New cd_Conexion
    Dim da As New SqlDataAdapter
    Dim cn As SqlConnection


    Sub registroMedicos(ByVal obj As capaEntidad.Medico)
        Try
            cn = objConexion.Conectar
            cn.Open()
            da = New SqlDataAdapter("sp_IngresarNuevoMedico", cn)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            With da.SelectCommand.Parameters
                .Add("@idPersona", SqlDbType.Int).Value = obj.idPersona
                .Add("@registroMedico", SqlDbType.VarChar).Value = obj.registroMedico
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

    Public Function buscarMedicos(ByVal idPersona As Integer) As List(Of capaEntidad.Medico)
        Dim lista As New List(Of capaEntidad.Medico)
        cn = objConexion.Conectar
        cn.Open()
        Try
            Dim cmd As New SqlCommand("sp_consultarMedico", cn)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@idPersona", idPersona)
            Dim dr As SqlDataReader
            dr = cmd.ExecuteReader
            While dr.Read
                Dim reg As New capaEntidad.Medico
                reg.registroMedico = dr.GetValue(1).ToString()
                lista.Add(reg)
            End While
            dr.Close()
        Catch ex As Exception
        End Try

        Return lista
    End Function

    'para modificar Médicos'
    Public Sub modificarMedicos(ByVal registros As capaEntidad.Medico)
        cn = objConexion.Conectar
        cn.Open()

        Dim cmd As New SqlCommand("sp_ModificarMedico", cn)
        cmd.CommandType = CommandType.StoredProcedure

        With cmd.Parameters
            .Add("@idPersona", SqlDbType.Int).Value = registros.idPersona
            .Add("@area", SqlDbType.VarChar).Value = registros.registroMedico
        End With
        cmd.ExecuteNonQuery()
        MsgBox("Registro modificado con éxito", MsgBoxStyle.Information)
        cn.Close()
    End Sub

End Class
