Option Strict On
Option Explicit On

Imports capaNegocio
Imports capaEntidad

Public Class frm_Usuario
    Dim objNegocio As New cn_Persona
    Dim objNegocio2 As New cn_Usuario
    Dim objPersona As New Persona
    Dim objUsuario As New Usuario

    Public variableNuevo As String

    'Funciones para obtener valores de los campos
    Function getId() As Integer
        Return CInt(txt_IdEmpleado.Text.Trim)
    End Function

    Function getTipo() As Char
        Return CChar(Mid(cmb_Tipo.Text, 1, 1))
    End Function

    Function getUsuario() As String
        Return txt_Usuario.Text.Trim
    End Function

    Function getContrasenia() As String
        Return txt_Contrasenia.Text.Trim
    End Function

    Sub registroUsuarios()
        objUsuario.idPersona = getId()
        objUsuario.tipoUsuario = getTipo()
        objUsuario.usuario = getUsuario()
        objUsuario.contrasenia = getContrasenia()
        objNegocio2.registroUsuarios(objUsuario)
    End Sub

    Sub modificaUsuarios()
        Dim Entidad As New Usuario
        Dim Negocio2 As New cn_Usuario

        With Entidad
            .idPersona = getId()
            .tipoUsuario = getTipo()
            .usuario = getUsuario()
            .contrasenia = getContrasenia()
        End With '
        Negocio2.modificaUsuarios(Entidad)
    End Sub


    Sub consultarPersonas()
        Dim lista As New List(Of capaEntidad.Persona)
        Dim obj As New cn_Persona
        lista = obj.buscaPersonas(CInt(Me.txt_IdEmpleado.Text))
        Me.txt_NombreEmpleado.Text = lista.Item(0).apellidos + " " + lista.Item(0).nombres
    End Sub

    Sub consultarUsuarios()
        Dim lista As New List(Of capaEntidad.Usuario)
        Dim obj As New cn_Usuario
        lista = obj.buscaUsuarios(CInt(Me.txt_IdEmpleado.Text))
        If lista.Item(0).tipoUsuario = "A" Then
            cmb_Tipo.SelectedIndex = 0
        ElseIf lista.Item(0).tipoUsuario = "U" Then
            cmb_Tipo.SelectedIndex = 1
        End If
        Me.txt_Usuario.Text = lista.Item(0).usuario
        Me.txt_Contrasenia.Text = lista.Item(0).contrasenia
    End Sub


    Private Sub tsm_Salir_Click(sender As Object, e As EventArgs) Handles tsm_Salir.Click
        Me.Close()
    End Sub

    Private Sub tsm_Nuevo_Click(sender As Object, e As EventArgs) Handles tsm_Nuevo.Click
        Me.tsm_Nuevo.Enabled = False
        Me.tsm_Consultar.Enabled = False
        Me.tsm_Grabar.Enabled = True
        Me.tsm_Modificar.Enabled = False
        Me.tsm_Cancelar.Enabled = True
        HabilitarControles()
        Me.txt_IdEmpleado.Select()
        LimpiarControles()
        variableNuevo = "N"
    End Sub

    Private Sub tsm_Cancelar_Click(sender As Object, e As EventArgs) Handles tsm_Cancelar.Click
        Me.tsm_Nuevo.Enabled = True
        Me.tsm_Consultar.Enabled = True
        Me.tsm_Grabar.Enabled = False
        Me.tsm_Modificar.Enabled = False
        Me.tsm_Cancelar.Enabled = False
        InhabilitarControles()
        Me.txt_IdEmpleado.ReadOnly = False
        Me.txt_IdEmpleado.Select()
        LimpiarControles()
        variableNuevo = "N"
    End Sub

    Private Sub frm_Usuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.tsm_Nuevo.Enabled = True
        Me.tsm_Consultar.Enabled = True
        Me.tsm_Grabar.Enabled = False
        Me.tsm_Modificar.Enabled = False
        Me.tsm_Cancelar.Enabled = False
    End Sub


    Private Sub txt_Empleado_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_IdEmpleado.KeyDown
        If e.KeyCode = Keys.F4 Then
            Dim frm As New frm_Personas
            AddOwnedForm(frm)
            frm.ShowDialog()
        End If
    End Sub

    Private Sub tsm_Consultar_Click(sender As Object, e As EventArgs) Handles tsm_Consultar.Click
        consultarPersonas()
        consultarUsuarios()
        Me.tsm_Modificar.Enabled = True
    End Sub

    Private Sub tsm_Grabar_Click(sender As Object, e As EventArgs) Handles tsm_Grabar.Click
        If variableNuevo = "N" Then
            registroUsuarios()
        Else
            modificaUsuarios()
        End If
    End Sub

    Private Sub tsm_Modificar_Click(sender As Object, e As EventArgs) Handles tsm_Modificar.Click
        variableNuevo = "M"
        HabilitarControles()
        Me.txt_IdEmpleado.ReadOnly = True
        Me.tsm_Modificar.Enabled = False
        Me.tsm_Grabar.Enabled = True
        Me.tsm_Cancelar.Enabled = True
        Me.tsm_Consultar.Enabled = False
    End Sub

    Sub LimpiarControles()
        Me.txt_IdEmpleado.Text = String.Empty
        Me.cmb_Tipo.SelectedIndex = -1
        Me.txt_Usuario.Text = String.Empty
        Me.txt_Contrasenia.Text = String.Empty
    End Sub

    Sub HabilitarControles()
        Me.txt_IdEmpleado.ReadOnly = False
        Me.cmb_Tipo.Enabled = True
        Me.txt_Usuario.ReadOnly = False
        Me.txt_Contrasenia.ReadOnly = False
    End Sub

    Sub InhabilitarControles()
        Me.txt_IdEmpleado.ReadOnly = True
        Me.cmb_Tipo.Enabled = False
        Me.txt_Usuario.ReadOnly = True
        Me.txt_Contrasenia.ReadOnly = True
    End Sub

    Private Sub txt_IdEmpleado_TextChanged(sender As Object, e As EventArgs) Handles txt_IdEmpleado.TextChanged

    End Sub
End Class