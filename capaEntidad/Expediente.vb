Public Class Expediente
    Private numero As Integer
    Private altaMedica As Boolean

    'Constructor, donde debemos pasar todos los datos  
    Public Sub New(numero As Integer, altaMedica As String)
        Me.numero = numero
        Me.altaMedica = altaMedica
    End Sub

    Public Sub New()

    End Sub

    Public Sub obtenerReporte()

    End Sub
End Class