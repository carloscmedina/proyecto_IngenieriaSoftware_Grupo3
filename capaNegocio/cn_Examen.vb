Imports System.Data
Imports capaDatos
Imports capaEntidad
Public Class cn_Examen
    'Se crea el objeto capaDatos
    Dim objCapaDatos As New cd_Examen

    'Implementamos la función que retorna el dataset
    Function listarPersonas() As DataSet
        Return objCapaDatos.listarPersonas
    End Function

    'Implementamos la función que genera el Id
    Function generarId() As Integer
        Return objCapaDatos.generarId
    End Function

    'Llamamos al procedimiento de registro de personas
    Sub registroExamen(ByVal obj As capaEntidad.Examen)
        objCapaDatos.registroExamenes(obj)
    End Sub

    'Implementamos la función que retorna la lista
    Public Function buscaExamenes(ByVal id As Integer) As List(Of capaEntidad.Examen)
        Dim lista As New List(Of capaEntidad.Examen)
        Dim obj As New cd_Examen
        lista = obj.buscarExamenes(id)
        Return lista
    End Function

    Public Sub modificaExamenes(ByVal registros As capaEntidad.Examen)
        Dim Datos As New cd_Examen
        Datos.modificarExamen(registros)
    End Sub

End Class