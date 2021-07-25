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
            Return _idPersona
        End Get
        Set(value As Integer)
            _idPersona = value
        End Set
    End Property

    Public Property area As String
        Get
            Return _area
        End Get
        Set(value As String)
            _area = value
        End Set
    End Property

End Class