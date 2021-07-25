Public Class Persona
    Private _idPersona As Integer
    Private _tipoIdentificacion As Char
    Private _identificacion As String
    Private _apellidos As String
    Private _nombres As String
    Public _fechaNacimiento As Date
    Private _estado As Boolean

    Public Property idPersona As Integer
        Get
            Return _idPersona
        End Get
        Set(value As Integer)
            _idPersona = value
        End Set
    End Property

    Public Property tipoIdentificacion As Char
        Get
            Return _tipoIdentificacion
        End Get
        Set(value As Char)
            _tipoIdentificacion = value
        End Set
    End Property

    Public Property identificacion As String
        Get
            Return _identificacion
        End Get
        Set(value As String)
            _identificacion = value
        End Set
    End Property

    Public Property apellidos As String
        Get
            Return _apellidos
        End Get
        Set(value As String)
            _apellidos = value
        End Set
    End Property

    Public Property nombres As String
        Get
            Return _nombres
        End Get
        Set(value As String)
            _nombres = value
        End Set
    End Property

    Public Property fechaNacimiento As Date
        Get
            Return _fechaNacimiento
        End Get
        Set(value As Date)
            _fechaNacimiento = value
        End Set
    End Property

    Public Property estado As Boolean
        Get
            Return _estado
        End Get
        Set(value As Boolean)
            _estado = value
        End Set
    End Property

End Class
