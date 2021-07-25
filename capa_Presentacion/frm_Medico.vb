Option Strict On
Option Explicit On

Imports capaNegocio
Imports capaEntidad

Public Class frm_Medico

    Dim objNegocio As New cn_Persona
    Dim objNegocio2 As New cn_Medico
    Dim objPersona As New Persona
    Dim objMedico As New Medico

    Public variableNuevo As String

    'Funciones para obtener valores de los campos
    Function getId() As Integer
        Return CInt(txt_IdMedico.Text.Trim)
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

    Function getRegistroMedico() As String
        Return txt_RegistroMedico.Text.Trim
    End Function

    Function getEstado() As Boolean
        If Me.rdb_Activo.Checked Then
            Return True
        Else
            Return False
        End If

    End Function

    Sub GenerarId()
        txt_IdMedico.Text = objNegocio.generarId.ToString
    End Sub

    Sub registroPersonas()
        objPersona.idPersona = getId()
        objPersona.tipoIdentificacion = getTipoIdentificacion()
        objPersona.identificacion = getIdentificacion()
        objPersona.apellidos = getApellidos()
        objPersona.nombres = getNombres()
        objPersona.fechaNacimiento = getFechaNacimiento()
        objPersona.estado = getEstado()
        objNegocio.registroPersonas(objPersona)
    End Sub

    Sub registroMedicos()
        objMedico.idPersona = getId()
        objMedico.registroMedico = getRegistroMedico()
        objNegocio2.registroMedicos(objMedico)
    End Sub

    Sub modificaPersonas()
        objPersona.idPersona = getId()
        objPersona.tipoIdentificacion = getTipoIdentificacion()
        objPersona.identificacion = getIdentificacion()
        objPersona.apellidos = getApellidos()
        objPersona.nombres = getNombres()
        objPersona.estado = getEstado()
        objNegocio.modificaPersonas(objPersona)
    End Sub


    Sub modificaMedicos()
        Dim Entidad As New Medico
        Dim Negocio2 As New cn_Medico

        With Entidad
            .idPersona = getId()
            .registroMedico = getRegistroMedico()
        End With '
        Negocio2.modificaMedicos(Entidad)
    End Sub


    Sub consultarPersonas()
        Dim lista As New List(Of capaEntidad.Persona)
        Dim obj As New cn_Persona
        lista = obj.buscaPersonas(CInt(Me.txt_IdMedico.Text))
        If lista.Item(0).tipoIdentificacion = "C" Then
            cmbTipoIdentificacion.SelectedIndex = 0
        ElseIf lista.Item(0).tipoIdentificacion = "P" Then
            cmbTipoIdentificacion.SelectedIndex = 1
        End If
        Me.txt_Cedula.Text = lista.Item(0).identificacion
        Me.txt_Apellidos.Text = lista.Item(0).apellidos
        Me.txt_Nombres.Text = lista.Item(0).nombres
        If lista.Item(0).estado = True Then
            Me.rdb_Activo.Checked = True
        Else
            Me.rdb_Inactivo.Checked = True
        End If
    End Sub

    Sub consultarMedicos()
        Dim lista As New List(Of capaEntidad.Medico)
        Dim obj As New cn_Medico
        lista = obj.buscaMedicos(CInt(Me.txt_IdMedico.Text))
        Me.txt_RegistroMedico.Text = lista.Item(0).registroMedico
    End Sub

    Private Sub GrabarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles tsm_Grabar.Click
        If variableNuevo = "N" Then
            registroPersonas()
            registroMedicos()
        Else
            modificaPersonas()
            modificaMedicos()
        End If

    End Sub




    Sub LimpiarControles()
        Me.txt_IdMedico.Text = String.Empty
        Me.cmbTipoIdentificacion.SelectedIndex = -1
        Me.txt_Cedula.Text = String.Empty
        Me.txt_Apellidos.Text = String.Empty
        Me.txt_Nombres.Text = String.Empty
        Me.dtp_FechaNacimiento.Value = Today
        Me.txt_RegistroMedico.Text = String.Empty
        Me.rdb_Activo.Checked = False
        Me.rdb_Inactivo.Checked = False
    End Sub

    Sub HabilitarControles()
        Me.txt_IdMedico.ReadOnly = False
        Me.cmbTipoIdentificacion.Enabled = True
        Me.txt_Cedula.ReadOnly = False
        Me.txt_Apellidos.ReadOnly = False
        Me.txt_Nombres.ReadOnly = False
        Me.dtp_FechaNacimiento.Enabled = True
        Me.txt_RegistroMedico.ReadOnly = False
        Me.rdb_Activo.Enabled = True
        Me.rdb_Inactivo.Enabled = True
    End Sub

    Sub InhabilitarControles()
        Me.txt_IdMedico.ReadOnly = True
        Me.cmbTipoIdentificacion.Enabled = False
        Me.txt_Cedula.ReadOnly = True
        Me.txt_Apellidos.ReadOnly = True
        Me.txt_Nombres.ReadOnly = True
        Me.dtp_FechaNacimiento.Enabled = False
        Me.txt_RegistroMedico.ReadOnly = True
        Me.rdb_Activo.Enabled = False
        Me.rdb_Inactivo.Enabled = False
    End Sub

    Private Sub tsm_Nuevo_Click(sender As Object, e As EventArgs) Handles tsm_Nuevo.Click
        Me.tsm_Nuevo.Enabled = False
        Me.tsm_Consultar.Enabled = False
        Me.tsm_Grabar.Enabled = True
        Me.tsm_Modificar.Enabled = False
        Me.tsm_Cancelar.Enabled = True
        HabilitarControles()
        Me.txt_IdMedico.ReadOnly = True
        LimpiarControles()
        GenerarId()
        Me.cmbTipoIdentificacion.Select()
        variableNuevo = "N"
    End Sub

    Private Sub tsm_Salir_Click(sender As Object, e As EventArgs) Handles tsm_Salir.Click
        Me.Close()
    End Sub

    Private Sub tsm_Grabar_Click(sender As Object, e As EventArgs) Handles tsm_Grabar.Click

    End Sub

    Private Sub tsm_Consultar_Click(sender As Object, e As EventArgs) Handles tsm_Consultar.Click
        consultarPersonas()
        consultarMedicos()
        Me.tsm_Modificar.Enabled = True
    End Sub

    Private Sub tsm_Modificar_Click(sender As Object, e As EventArgs) Handles tsm_Modificar.Click
        variableNuevo = "M"
        HabilitarControles()
        Me.txt_IdMedico.ReadOnly = True
        Me.tsm_Modificar.Enabled = False
        Me.tsm_Grabar.Enabled = True
        Me.tsm_Cancelar.Enabled = True
        Me.tsm_Consultar.Enabled = False
    End Sub

    Private Sub tsm_Cancelar_Click(sender As Object, e As EventArgs) Handles tsm_Cancelar.Click
        Me.tsm_Nuevo.Enabled = True
        Me.tsm_Consultar.Enabled = True
        Me.tsm_Grabar.Enabled = False
        Me.tsm_Modificar.Enabled = False
        Me.tsm_Cancelar.Enabled = False
        InhabilitarControles()
        Me.txt_IdMedico.ReadOnly = False
        Me.txt_IdMedico.Select()
        LimpiarControles()
        variableNuevo = "N"
    End Sub

    Private Sub frm_Medico_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.tsm_Nuevo.Enabled = True
        Me.tsm_Consultar.Enabled = True
        Me.tsm_Grabar.Enabled = False
        Me.tsm_Modificar.Enabled = False
        Me.tsm_Cancelar.Enabled = False
        InhabilitarControles()
        Me.txt_IdMedico.Select()
        Me.txt_IdMedico.ReadOnly = False
    End Sub
End Class