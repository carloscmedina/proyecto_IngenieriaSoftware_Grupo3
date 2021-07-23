Imports System.Data
Imports capaDatos
Public Class cn_Persona
    'Se crea el objeto capaDatos
    Dim objCapaDatos As New cd_Persona

    'Implementamos la función que retorna el dataset
    Function listarPersonas() As DataSet
        Return objCapaDatos.listarPersonas
    End Function
End Class
