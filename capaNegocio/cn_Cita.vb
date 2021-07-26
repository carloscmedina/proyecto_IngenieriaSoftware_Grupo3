Imports System.Data
Imports capaDatos
Imports capaEntidad
Public Class cn_Cita
    'Se crea el objeto capaDatos
    Dim objCapaDatos As New cd_Cita

    'Implementamos la función que retorna el dataset
    Function listarPersonas() As DataSet
        Return objCapaDatos.listarPersonas
    End Function

    'Implementamos la función que genera el Id
    Function generarId() As Integer
        Return objCapaDatos.generarId
    End Function

    'Llamamos al procedimiento de registro de personas
    Sub registroCita(ByVal obj As capaEntidad.Cita)
        objCapaDatos.registroCitas(obj)
    End Sub

    'Implementamos la función que retorna la lista
    Public Function buscaCitas(ByVal id As Integer) As List(Of capaEntidad.Cita)
        Dim lista As New List(Of capaEntidad.Cita)
        Dim obj As New cd_Cita
        lista = obj.buscarCitas(id)
        Return lista
    End Function

    Public Sub modificaCitas(ByVal registros As capaEntidad.Cita)
        Dim Datos As New cd_Cita
        Datos.modificarCita(registros)
    End Sub

End Class