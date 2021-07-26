Imports System.Data
Imports System.Data.SqlClient

Public Class cd_Examen

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
            da = New SqlDataAdapter("sp_ObtenerUltimoIdExamen", cn)
            Dim r As Integer
            r = da.SelectCommand.ExecuteScalar
            Return r
        Catch ex As Exception

            Throw
        Finally
            cn.Dispose()
        End Try

    End Function

    Sub registroExamenes(ByVal obj As capaEntidad.Examen)
        Try
            cn = objConexion.Conectar
            cn.Open()
            da = New SqlDataAdapter("sp_IngresarNuevoExamen", cn)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            With da.SelectCommand.Parameters
                .Add("@id", SqlDbType.Int).Value = obj.id
                .Add("@fecha", SqlDbType.Date).Value = obj.fecha
                .Add("@idEmpleado", SqlDbType.Int).Value = obj.idEmpleado
                .Add("@idMedico", SqlDbType.Int).Value = obj.idMedico
                .Add("@diagnostico", SqlDbType.VarChar).Value = obj.diagnostico
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

    Public Function buscarExamenes(ByVal id As Integer) As List(Of capaEntidad.Examen)
        Dim lista As New List(Of capaEntidad.Examen)
        cn = objConexion.Conectar
        cn.Open()
        Try
            Dim cmd As New SqlCommand("sp_consultarExamen", cn)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@id", id)
            Dim dr As SqlDataReader
            dr = cmd.ExecuteReader
            While dr.Read
                Dim reg As New capaEntidad.Examen
                reg.fecha = dr.GetValue(1).ToString()
                reg.idEmpleado = dr.GetValue(2).ToString()
                reg.idMedico = dr.GetValue(3).ToString()
                reg.diagnostico = dr.GetValue(4).ToString()
                lista.Add(reg)
            End While
            dr.Close()
        Catch ex As Exception
        End Try

        Return lista
    End Function

    'para modificar Registros síntomas'
    Public Sub modificarExamen(ByVal registros As capaEntidad.Examen)
        cn = objConexion.Conectar
        cn.Open()

        Dim cmd As New SqlCommand("sp_modificarExamen", cn)
        cmd.CommandType = CommandType.StoredProcedure

        With cmd.Parameters
            .Add("@id", SqlDbType.Int).Value = registros.id
            .Add("@fecha", SqlDbType.Date).Value = registros.fecha
            .Add("@idEmpleado", SqlDbType.Int).Value = registros.idEmpleado
            .Add("@idMedico", SqlDbType.Int).Value = registros.idMedico
            .Add("@diagnostico", SqlDbType.VarChar).Value = registros.diagnostico
        End With
        cmd.ExecuteNonQuery()
        MsgBox("Registro modificado con éxito", MsgBoxStyle.Information)
        cn.Close()
    End Sub

End Class

