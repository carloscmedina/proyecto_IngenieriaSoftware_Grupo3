Public Class Medico
    Private idMedico As Integer
    Private estado As Boolean

    'Constructor, donde debemos pasar todos los datos  
    Public Sub New(idMedico As Integer, estado As String)
        Me.idMedico = idMedico
        Me.estado = estado
    End Sub
End Class