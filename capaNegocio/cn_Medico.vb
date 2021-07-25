Imports System.Data
Imports capaDatos
Imports capaEntidad
Public Class cn_Medico
    'Se crea el objeto capaDatos
    Dim objCapaDatos As New cd_Medico

    'Llamamos al procedimiento de registro de personas
    Sub registroMedicos(ByVal obj As capaEntidad.Medico)
        objCapaDatos.registroMedicos(obj)
    End Sub

    'Implementamos la función que retorna la lista
    Public Function buscaMedicos(ByVal idPersona As Integer) As List(Of capaEntidad.Medico)
        Dim lista As New List(Of capaEntidad.Medico)
        Dim obj As New cd_Medico
        lista = obj.buscarMedicos(idPersona)
        Return lista
    End Function

    Public Sub modificaMedicos(ByVal registros As capaEntidad.Medico)
        Dim Datos As New cd_Medico
        Datos.modificarMedicos(registros)
    End Sub

End Class