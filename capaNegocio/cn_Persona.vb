Imports System.Data
Imports capaDatos
Imports capaEntidad
Public Class cn_Persona
    'Se crea el objeto capaDatos
    Dim objCapaDatos As New cd_Persona

    'Implementamos la funci�n que retorna el dataset
    Function listarPersonas() As DataSet
        Return objCapaDatos.listarPersonas
    End Function

    'Implementamos la funci�n que genera el Id
    Function generarId() As Integer
        Return objCapaDatos.generarId
    End Function

    'Llamamos al procedimiento de registro de personas
    Sub registroPersonas(ByVal obj As capaEntidad.Persona)
        objCapaDatos.registroPersonas(obj)
    End Sub

End Class
