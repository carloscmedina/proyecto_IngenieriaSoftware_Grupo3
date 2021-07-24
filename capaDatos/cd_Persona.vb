﻿Imports System.Data
Imports System.Data.SqlClient

Public Class cd_Persona

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
            cn.Open()
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

    Sub registroPersonas(ByVal obj As capaEntidad.Persona)
        Try
            cn = objConexion.Conectar
            cn.Open()
            da = New SqlDataAdapter("sp_IngresarNuevaPersona", cn)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            With da.SelectCommand.Parameters
                .Add("@id", SqlDbType.Int).Value = obj.idPersona
                .Add("@tipoIdentificacion", SqlDbType.Char).Value = obj.tipoIdentificacion
                .Add("@identificacion", SqlDbType.VarChar).Value = obj.identificacion
                .Add("@apellidos", SqlDbType.VarChar).Value = obj.apellidos
                .Add("@nombres", SqlDbType.VarChar).Value = obj.nombres
                .Add("@fechaNacimiento", SqlDbType.Date).Value = obj.fechaNacimiento
                .Add("@estado", SqlDbType.Bit).Value = obj.estado
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

End Class
