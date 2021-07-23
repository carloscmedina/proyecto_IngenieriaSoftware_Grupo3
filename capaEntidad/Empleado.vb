Public Class Empleado
    Private idEmpleado As Integer
    Private estado As Boolean

    'Constructor, donde debemos pasar todos los datos  
    Public Sub New(idEmpleado As Integer, estado As String)
        Me.idEmpleado = idEmpleado
        Me.estado = estado
    End Sub

    Public Sub New()

    End Sub

    Public Sub consultaDatos()

    End Sub
End Class