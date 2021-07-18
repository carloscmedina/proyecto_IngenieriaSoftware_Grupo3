Public Class Persona
    Private idPersona As Integer
    Private cedula As String
    Private apellidos As String
    Private nombres As String
    Private edad As Integer
    Private fecha_nac As Date

    'Constructor, donde debemos pasar todos los datos  
    Public Sub New(idPersona As Integer, cedula As String, apellidos As String, nombres As String, edad As Integer, fecha_nac As Date)
        Me.idPersona = idPersona
        Me.cedula = cedula
        Me.apellidos = apellidos
        Me.nombres = nombres
        Me.edad = edad
        Me.fecha_nac = fecha_nac
    End Sub

    Public Sub New()

    End Sub


    Public Sub consultaDatos()

    End Sub
End Class
