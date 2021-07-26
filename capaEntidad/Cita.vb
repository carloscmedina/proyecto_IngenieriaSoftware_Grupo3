Public Class Cita
    Private _id As Integer
    Private _fecha As Date
    Private _idEmpleado As Integer
    Private _idMedico As Integer
    Private _idExamen As Integer
    Private _diagnostico As String
    Private _altaMedica As Boolean

    Public Property id As Integer
        Get
            'retorna el id
            Return _id
        End Get
        Set(value As Integer)
            'viene asignado valor
            _id = value
        End Set
    End Property

    Public Property fecha As Date
        Get
            'retorna la fecha
            Return _fecha
        End Get
        Set(value As Date)
            'viene asignado valor
            _fecha = value
        End Set
    End Property

    Public Property idEmpleado As Integer
        Get
            'retorna el id
            Return _idEmpleado
        End Get
        Set(value As Integer)
            'viene asignado valor
            _idEmpleado = value
        End Set
    End Property

    Public Property idMedico As Integer
        Get
            'retorna el idMedico
            Return _idMedico
        End Get
        Set(value As Integer)
            'viene asignado valor
            _idMedico = value
        End Set
    End Property

    Public Property idExamen As Integer
        Get
            'retorna el idExamen
            Return _idExamen
        End Get
        Set(value As Integer)
            'viene asignado valor
            _idExamen = value
        End Set
    End Property

    Public Property diagnostico As String
        Get
            'retorna diagnostico
            Return _diagnostico
        End Get
        Set(value As String)
            'se asigna valor
            _diagnostico = value
        End Set
    End Property

    Public Property altaMedica As Boolean
        Get
            'retorna altaMedica
            Return _altaMedica
        End Get
        Set(value As Boolean)
            'se asigna valor
            _altaMedica = value
        End Set
    End Property

End Class
