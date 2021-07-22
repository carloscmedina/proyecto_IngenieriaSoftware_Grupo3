Public Class Examen
    Private idExamen As Integer
    Private fecha As Date
    Private idEmpleado As Integer
    Private idMedico As Integer
    Private diagnostico As String


    Public Sub New(idExamen As Integer, fecha As Date, idEmpleado As Integer, idMedico As Integer, diagnostico As String)
        Me.idExamen = idExamen
        Me.fecha = fecha
        Me.idEmpleado = idEmpleado
        Me.idMedico = idMedico
        Me.diagnostico = diagnostico

    End Sub

    Public Sub New()

    End Sub

    Public Sub consultaDatos()

    End Sub
End Class