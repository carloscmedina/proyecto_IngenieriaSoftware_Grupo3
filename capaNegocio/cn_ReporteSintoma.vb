Imports System.Data
Imports capaDatos
Imports capaEntidad
Public Class cn_Reporte_Sintoma
    'Se crea el objeto capaDatos
    Dim objCapaDatos As New cd_Reporte_Sintoma

    'Implementamos la función que retorna el dataset
    Function listarPersonas() As DataSet
        Return objCapaDatos.listarPersonas
    End Function

    'Implementamos la función que genera el Id
    Function generarId() As Integer
        Return objCapaDatos.generarId
    End Function

    'Llamamos al procedimiento de registro de personas
    Sub registroReporte_Sintomas(ByVal obj As capaEntidad.Reporte_Sintoma)
        objCapaDatos.registroReportes_Sintomas(obj)
    End Sub

    'Implementamos la función que retorna la lista
    Public Function buscaReportes_Sintomas(ByVal id As Integer) As List(Of capaEntidad.Reporte_Sintoma)
        Dim lista As New List(Of capaEntidad.Reporte_Sintoma)
        Dim obj As New cd_Reporte_Sintoma
        lista = obj.buscarReportes_Sintomas(id)
        Return lista
    End Function

    Public Sub modificaReportes_Sintomas(ByVal registros As capaEntidad.Reporte_Sintoma)
        Dim Datos As New cd_Reporte_Sintoma
        Datos.modificarReporte_Sintoma(registros)
    End Sub

End Class