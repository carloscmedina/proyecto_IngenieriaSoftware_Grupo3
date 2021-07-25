Imports System.Data
Imports capaDatos
Imports capaEntidad
Public Class cn_Usuario
    'Se crea el objeto capaDatos
    Dim objCapaDatos As New cd_Usuario

    'Implementamos la función que retorna el dataset
    Function listarPersonas() As DataSet
        Return objCapaDatos.listarPersonas
    End Function

    'Llamamos al procedimiento de registro de usuarios
    Sub registroUsuarios(ByVal obj As capaEntidad.Usuario)
        objCapaDatos.registroUsuarios(obj)
    End Sub

    'Implementamos la función que retorna la lista
    Public Function buscaUsuarios(ByVal idPersona As Integer) As List(Of capaEntidad.Usuario)
        Dim lista As New List(Of capaEntidad.Usuario)
        Dim obj As New cd_Usuario
        lista = obj.buscarUsuarios(idPersona)
        Return lista
    End Function

    Public Sub modificaUsuarios(ByVal registros As capaEntidad.Usuario)
        Dim Datos As New cd_Usuario
        Datos.modificarUsuarios(registros)
    End Sub

    'Para El login
    Public Function Validar(ByVal registros As Usuario) As Boolean
        Dim valor As Boolean
        Dim obj As New cd_Usuario
        valor = obj.Validar(registros)

        Return valor
    End Function

End Class