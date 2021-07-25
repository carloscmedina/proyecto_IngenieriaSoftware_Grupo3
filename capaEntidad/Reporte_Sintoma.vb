Public Class Reporte_Sintoma
    Private _id As Integer
    Private _fecha As Date
    Private _idEmpleado As Integer
    Private _descripcion As String

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

    Public Property descripcion As String
        Get
            'retorna descripcion
            Return _descripcion
        End Get
        Set(value As String)
            'se asigna valor
            _descripcion = value
        End Set
    End Property

End Class
