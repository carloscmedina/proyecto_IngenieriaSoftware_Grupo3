Public Class Empleado
    Private _idPersona As Integer
    Private _area As String

    ''Constructor, donde debemos pasar todos los datos  
    'Public Sub New(idEmpleado As Integer, area As String)
    '    Me.idEmpleado = idEmpleado
    '    Me.area = area
    'End Sub

    Public Property idPersona As Integer
        Get
            'retorna el id
            Return _idPersona
        End Get
        Set(value As Integer)
            'viene asignado valor
            _idPersona = value
        End Set
    End Property

    Public Property area As String
        Get
            'retorna area
            Return _area
        End Get
        Set(value As String)
            'se asigna valor
            _area = value
        End Set
    End Property

End Class