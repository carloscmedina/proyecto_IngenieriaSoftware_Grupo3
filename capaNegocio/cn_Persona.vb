Imports System.Data
Imports capaDatos
Imports capaEntidad
Public Class cn_Persona
    'Se crea el objeto capaDatos
    Dim objCapaDatos As New cd_Persona

    'Implementamos la función que retorna el dataset
    Function listarPersonas() As DataSet
        Return objCapaDatos.listarPersonas
    End Function

    'Implementamos la función que genera el Id
    Function generarId() As Integer
        Return objCapaDatos.generarId
    End Function

    'Llamamos al procedimiento de registro de personas
    Sub registroPersonas(ByVal obj As capaEntidad.Persona)
        objCapaDatos.registroPersonas(obj)
    End Sub

    'Implementamos la función que retorna la lista
    Public Function buscaPersonas(ByVal id As Integer) As List(Of capaEntidad.Persona)
        Dim lista As New List(Of capaEntidad.Persona)
        Dim obj As New cd_Persona
        lista = obj.buscarPersonas(id)
        Return lista
    End Function

    Public Sub modificaPersonas(ByVal registros As capaEntidad.Persona)
        Dim Datos As New cd_Persona
        Datos.modificarPersonas(registros)
    End Sub

End Class
