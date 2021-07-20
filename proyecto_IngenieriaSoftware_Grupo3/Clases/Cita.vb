Public Class Cita
    Private num_expediente As Integer
    Private idCita As Integer
    Private idEmpleado As Integer
    Private idExamen As Integer
    Private idMedico As Integer
    Private fecha_visita As Date
    Private horario As horario As String

    Public Sub New(num_expediente As Integer, idCita As Integer, idEmpleado As Integer, idExamen As Integer, idMedico As Integer, fecha_visita As Date, horario As horario As String)
        Me.num_expediente = num_expediente
        Me.idCita = idCita
        Me.idEmpleado = idEmpleado
        Me.idExamen = idExamen
        Me.idMedico = idMedico
        Me.fecha_visita = fecha_visita
        Me.horario = horario

    End Sub

    Public Sub New()

    End Sub

    Public Sub consultaDatos()

    End Sub
End Class