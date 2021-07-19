Public Class Reporte_Sintoma
    Private idReporte As Integer
    Private descripcion As String
    Private idEmpleado As Integer


    'Constructor, donde debemos pasar todos los datos  
    Public Sub New(idReporte As Integer, descripcion As String, idEmpleado As Integer)
        Me.idReporte = idReporte
        Me.descripcion = descripcion
        Me.idEmpleado = idEmpleado
    End Sub

    Public Sub New()

    End Sub
End Class