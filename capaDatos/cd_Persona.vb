Imports System.Data
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

    Public Function buscarPersonas(ByVal id As Integer) As List(Of capaEntidad.Persona)
        Dim lista As New List(Of capaEntidad.Persona)
        cn = objConexion.Conectar
        cn.Open()
        Try
            Dim cmd As New SqlCommand("sp_consultarPersona", cn)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@id", id)
            Dim dr As SqlDataReader
            dr = cmd.ExecuteReader
            While dr.Read
                Dim reg As New capaEntidad.Persona
                reg.tipoIdentificacion = dr.GetValue(1).ToString()
                reg.identificacion = dr.GetValue(2).ToString()
                reg.apellidos = dr.GetValue(3).ToString()
                reg.nombres = dr.GetValue(4).ToString()
                reg.fechaNacimiento = dr.GetValue(5).ToString()
                If dr.GetValue(6).ToString() = "True" Then
                    reg.estado = True
                Else
                    reg.estado = False
                End If

                lista.Add(reg)
            End While
            dr.Close()
        Catch ex As Exception
        End Try

        Return lista
    End Function

    'para modificar Personas'
    Public Sub modificarPersonas(ByVal registros As capaEntidad.Persona)
        cn = objConexion.Conectar
        cn.Open()

        Dim cmd As New SqlCommand("sp_ModificarPersona", cn)
        cmd.CommandType = CommandType.StoredProcedure
        With cmd.Parameters
            .Add("@id", SqlDbType.Int).Value = registros.idPersona
            .Add("@tipoIdentificacion", SqlDbType.Char).Value = registros.tipoIdentificacion
            .Add("@identificacion", SqlDbType.VarChar).Value = registros.identificacion
            .Add("@apellidos", SqlDbType.VarChar).Value = registros.apellidos
            .Add("@nombres", SqlDbType.VarChar).Value = registros.nombres
            .Add("@fechaNacimiento", SqlDbType.Date).Value = registros.fechaNacimiento
            .Add("@estado", SqlDbType.Bit).Value = registros.estado
        End With
            cmd.ExecuteNonQuery()
        cn.Close()
    End Sub

End Class
