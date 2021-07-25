Public Class Usuario
    Private _idPersona As Integer
    Private _usuario As String
    Private _contrasenia As String
    Private _tipoUsuario As String

    Public Property idPersona As Integer
        Get
            Return _idPersona
        End Get
        Set(value As Integer)
            _idPersona = value
        End Set
    End Property

    Public Property usuario As String
        Get
            Return _usuario
        End Get
        Set(value As String)
            _usuario = value
        End Set
    End Property

    Public Property contrasenia As String
        Get
            Return _contrasenia
        End Get
        Set(value As String)
            _contrasenia = value
        End Set
    End Property

    Public Property tipoUsuario As Char
        Get
            Return _tipoUsuario
        End Get
        Set(value As Char)
            _tipoUsuario = value
        End Set
    End Property

End Class