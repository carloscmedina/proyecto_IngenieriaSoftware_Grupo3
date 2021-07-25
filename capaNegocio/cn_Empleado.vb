Imports System.Data
Imports capaDatos
Imports capaEntidad
Public Class cn_Empleado
    'Se crea el objeto capaDatos
    Dim objCapaDatos As New cd_Empleado

    'Implementamos la función que retorna el dataset
    Function listarPersonas() As DataSet
        Return objCapaDatos.listarPersonas
    End Function

    'Implementamos la función que genera el Id
    Function generarId() As Integer
        Return objCapaDatos.generarId
    End Function

    'Llamamos al procedimiento de registro de personas
    Sub registroEmpleados(ByVal obj As capaEntidad.Empleado)
        objCapaDatos.registroEmpleados(obj)
    End Sub

    'Implementamos la función que retorna la lista
    Public Function buscaEmpleados(ByVal idPersona As Integer) As List(Of capaEntidad.Empleado)
        Dim lista As New List(Of capaEntidad.Empleado)
        Dim obj As New cd_Empleado
        lista = obj.buscarEmpleados(idPersona)
        Return lista
    End Function

    Public Sub modificaEmpleados(ByVal registros As capaEntidad.Empleado)
        Dim Datos As New cd_Empleado
        Datos.modificarEmpleados(registros)
    End Sub

End Class