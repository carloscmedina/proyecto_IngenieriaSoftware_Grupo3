Option Strict On
Option Explicit On

Imports capaNegocio
Imports capaEntidad

Public Class frm_Empleado
    Dim objNegocio As New cn_Persona
    Dim objNegocio2 As New cn_Empleado
    Dim objPersona As New Persona
    Dim objEmpleado As New Empleado

    'Funciones para obtener valores de los campos
    Function getId() As Integer
        Return CInt(txt_IdEmpleado.Text.Trim)
    End Function

    Function getTipoIdentificacion() As Char
        Return CChar(Mid(cmbTipoIdentificacion.Text, 1, 1))
    End Function

    Function getIdentificacion() As String
        Return txt_Cedula.Text.Trim
    End Function

    Function getApellidos() As String
        Return txt_Apellidos.Text.Trim
    End Function

    Function getNombres() As String
        Return txt_Nombres.Text.Trim
    End Function

    Function getFechaNacimiento() As Date
        Return dtp_FechaNacimiento.Value
    End Function

    Function getArea() As String
        Return Mid(cmb_Area.Text, 1, 4).Trim
    End Function

    Function getEstado() As Boolean
        If Me.rdb_Activo.Checked Then
            Return True
        Else
            Return False
        End If

    End Function

    Sub GenerarId()
        txt_IdEmpleado.Text = objNegocio.generarId.ToString
    End Sub

    Sub registroPersonas()
        objPersona.idPersona = getId()
        objPersona.tipoIdentificacion = getTipoIdentificacion()
        objPersona.identificacion = getIdentificacion()
        objPersona.apellidos = getApellidos()
        objPersona.nombres = getNombres()
        objPersona.estado = getEstado()
        objNegocio.registroPersonas(objPersona)
    End Sub

    Sub registroEmpleados()
        objEmpleado.idPersona = getId()
        objEmpleado.area = getArea()
        objNegocio2.registroEmpleados(objEmpleado)
    End Sub

    Private Sub GrabarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GrabarToolStripMenuItem.Click
        registroPersonas()
        registroEmpleados()
    End Sub

    Private Sub NuevoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoToolStripMenuItem.Click
        GenerarId()
    End Sub
End Class