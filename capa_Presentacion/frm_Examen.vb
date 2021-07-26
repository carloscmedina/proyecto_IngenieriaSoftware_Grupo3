Option Strict On
Option Explicit On

Imports capaNegocio
Imports capaEntidad

Public Class frm_Examen
    Dim objNegocio As New cn_Persona
    Dim objNegocio2 As New cn_Examen
    Dim objPersona As New Persona
    Dim objExamen As New Examen

    Public variableNuevo As String

    'Funciones para obtener valores de los campos
    Function getId() As Integer
        Return CInt(txt_Id.Text.Trim)
    End Function

    Function getFecha() As Date
        'retorna contenido fecha
        Return dtp_Fecha.Value
    End Function

    'Funciones para obtener valores de los campos
    Function getIdEmpleado() As Integer
        Return CInt(txt_IdEmpleado.Text.Trim)
    End Function

    'Funciones para obtener valores de los campos
    Function getIdMedico() As Integer
        Return CInt(txt_IdMedico.Text.Trim)
    End Function

    Function getDiagnostico() As String
        'retorna contenido diagnostico
        Return txt_Diagnostico.Text.Trim
    End Function

    Sub GenerarId()
        txt_Id.Text = objNegocio2.generarId.ToString
    End Sub

    Sub LimpiarControles()
        'encerar campos
        Me.txt_Id.Text = String.Empty
        Me.dtp_Fecha.Value = Today
        Me.txt_IdEmpleado.Text = String.Empty
        Me.txt_IdMedico.Text = String.Empty
        Me.txt_Diagnostico.Text = String.Empty
    End Sub

    Sub HabilitarControles()
        Me.txt_Id.ReadOnly = False
        Me.dtp_Fecha.Enabled = True
        Me.txt_IdEmpleado.ReadOnly = False
        Me.txt_IdMedico.ReadOnly = False
        Me.txt_Diagnostico.ReadOnly = False
    End Sub

    Sub InhabilitarControles()
        Me.txt_Id.ReadOnly = True
        Me.dtp_Fecha.Enabled = False
        Me.txt_IdEmpleado.ReadOnly = True
        Me.txt_IdMedico.ReadOnly = True
        Me.txt_Diagnostico.ReadOnly = True
    End Sub

    Sub consultarExamenes()
        Dim lista As New List(Of capaEntidad.Examen)
        Dim obj As New cn_Examen
        lista = obj.buscaExamenes(CInt(Me.txt_Id.Text))
        Me.dtp_Fecha.Text = lista.Item(0).fecha.ToString
        Me.txt_IdEmpleado.Text = lista.Item(0).idEmpleado.ToString
        Me.txt_IdMedico.Text = lista.Item(0).idMedico.ToString
        Me.txt_Diagnostico.Text = lista.Item(0).diagnostico
    End Sub

    Sub registroExamenes()
        objExamen.id = getId()
        objExamen.fecha = getFecha()
        objExamen.idEmpleado = getIdEmpleado()
        objExamen.idMedico = getIdMedico()
        objExamen.diagnostico = getDiagnostico()
        objNegocio2.registroExamen(objExamen)
    End Sub

    Sub modificaExamenes()
        Dim Entidad As New Examen
        Dim Negocio2 As New cn_Examen

        With Entidad
            .id = getId()
            .fecha = getFecha()
            .idEmpleado = getIdEmpleado()
            .idMedico = getIdMedico()
            .diagnostico = getDiagnostico()
        End With '
        Negocio2.modificaExamenes(Entidad)
    End Sub


    Private Sub tsm_Nuevo_Click(sender As Object, e As EventArgs) Handles tsm_Nuevo.Click
        'sincronizacion de controles
        Me.tsm_Nuevo.Enabled = False
        Me.tsm_Consultar.Enabled = False
        Me.tsm_Grabar.Enabled = True
        Me.tsm_Modificar.Enabled = False
        Me.tsm_Cancelar.Enabled = True
        HabilitarControles()
        Me.txt_Id.ReadOnly = True
        LimpiarControles()
        GenerarId()
        Me.txt_IdEmpleado.Select()
        variableNuevo = "N"
    End Sub

    Private Sub tsm_Consultar_Click(sender As Object, e As EventArgs) Handles tsm_Consultar.Click
        'consultarPersonas()
        consultarExamenes()
        Me.tsm_Modificar.Enabled = True
    End Sub

    Private Sub tsm_Grabar_Click(sender As Object, e As EventArgs) Handles tsm_Grabar.Click
        If variableNuevo = "N" Then
            'registroPersonas()
            registroExamenes()
        Else
            'modificaPersonas()
            modificaExamenes()
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

    Private Sub tsm_Cancelar_Click(sender As Object, e As EventArgs) Handles tsm_Cancelar.Click
        Me.tsm_Nuevo.Enabled = True
        Me.tsm_Consultar.Enabled = True
        Me.tsm_Grabar.Enabled = False
        Me.tsm_Modificar.Enabled = False
        Me.tsm_Cancelar.Enabled = False
        InhabilitarControles()
        Me.txt_Id.ReadOnly = False
        Me.txt_Id.Select()
        LimpiarControles()
        variableNuevo = "N"
    End Sub

    Private Sub tsm_Salir_Click(sender As Object, e As EventArgs) Handles tsm_Salir.Click
        Me.Close()
    End Sub

    Private Sub txt_IdEmpleado_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_IdEmpleado.KeyDown
        If e.KeyCode = Keys.F4 Then
            Dim frm As New frm_Personas
            AddOwnedForm(frm)
            frm.ShowDialog()
        End If
    End Sub

    Private Sub txt_IdMedico_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_IdMedico.KeyDown
        If e.KeyCode = Keys.F4 Then
            Dim frm As New frm_Personas2
            AddOwnedForm(frm)
            frm.ShowDialog()
        End If
    End Sub

    Private Sub frm_Examen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.tsm_Nuevo.Enabled = True
        Me.tsm_Consultar.Enabled = True
        Me.tsm_Grabar.Enabled = False
        Me.tsm_Modificar.Enabled = False
        Me.tsm_Cancelar.Enabled = False
        InhabilitarControles()
        Me.txt_Id.Select()
        Me.txt_Id.ReadOnly = False
    End Sub
End Class