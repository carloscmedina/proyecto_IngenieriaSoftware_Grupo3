Public Class Medico
    Private _idPersona As Integer
    Private _registroMedico As String

    Public Property idPersona As Integer
        Get
            Return _idPersona
        End Get
        Set(value As Integer)
            _idPersona = value
        End Set
    End Property

    Public Property registroMedico As String
        Get
            Return _registroMedico
        End Get
        Set(value As String)
            _registroMedico = value
        End Set
    End Property
End Class