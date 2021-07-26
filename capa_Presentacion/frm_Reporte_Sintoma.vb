Option Strict On
Option Explicit On

Imports capaNegocio
Imports capaEntidad

Public Class frm_Reporte_Sintoma
    Dim objNegocio As New cn_Persona
    Dim objNegocio2 As New cn_Reporte_Sintoma
    Dim objPersona As New Persona
    Dim objReporte_Sintoma As New Reporte_Sintoma

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

    Function getDescripcion() As String
        'retorna contenido Apellidos
        Return txt_Descripcion.Text.Trim
    End Function

    Sub GenerarId()
        txt_Id.Text = objNegocio2.generarId.ToString
    End Sub

    Sub LimpiarControles()
        'encerar campos
        Me.txt_Id.Text = String.Empty
        Me.dtp_Fecha.Value = Today
        Me.txt_IdEmpleado.Text = String.Empty
        Me.txt_Descripcion.Text = String.Empty
    End Sub

    Sub HabilitarControles()
        Me.txt_Id.ReadOnly = False
        Me.dtp_Fecha.Enabled = True
        Me.txt_IdEmpleado.ReadOnly = False
        Me.txt_Descripcion.ReadOnly = False
    End Sub

    Sub InhabilitarControles()
        Me.txt_Id.ReadOnly = True
        Me.dtp_Fecha.Enabled = False
        Me.txt_IdEmpleado.ReadOnly = True
        Me.txt_Descripcion.ReadOnly = True
    End Sub

    Sub consultarReportes_Sintomas()
        Dim lista As New List(Of capaEntidad.Reporte_Sintoma)
        Dim obj As New cn_Reporte_Sintoma
        lista = obj.buscaReportes_Sintomas(CInt(Me.txt_Id.Text))
        Me.dtp_Fecha.Text = lista.Item(0).fecha.ToString
        Me.txt_IdEmpleado.Text = lista.Item(0).idEmpleado.ToString
        Me.txt_Descripcion.Text = lista.Item(0).descripcion
    End Sub

    Sub registroReportes_Sintomas()
        objReporte_Sintoma.id = getId()
        objReporte_Sintoma.fecha = getFecha()
        objReporte_Sintoma.idEmpleado = getIdEmpleado()
        objReporte_Sintoma.descripcion = getDescripcion()
        objNegocio2.registroReporte_Sintomas(objReporte_Sintoma)
    End Sub

    Sub modificaReportes_Sintomas()
        Dim Entidad As New Reporte_Sintoma
        Dim Negocio2 As New cn_Reporte_Sintoma

        With Entidad
            .id = getId()
            .fecha = getFecha()
            .idEmpleado = getIdEmpleado()
            .descripcion = getDescripcion()
        End With '
        Negocio2.modificaReportes_Sintomas(Entidad)
    End Sub

    Private Sub tsm_Salir_Click(sender As Object, e As EventArgs) Handles tsm_Salir.Click
        Me.Close()
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
        consultarReportes_Sintomas()
        Me.tsm_Modificar.Enabled = True
    End Sub

    Private Sub tsm_Grabar_Click(sender As Object, e As EventArgs) Handles tsm_Grabar.Click
        If variableNuevo = "N" Then
            'registroPersonas()
            registroReportes_Sintomas()
        Else
            'modificaPersonas()
            modificaReportes_Sintomas()
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

    Private Sub frm_Reporte_Sintoma_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.tsm_Nuevo.Enabled = True
        Me.tsm_Consultar.Enabled = True
        Me.tsm_Grabar.Enabled = False
        Me.tsm_Modificar.Enabled = False
        Me.tsm_Cancelar.Enabled = False
        InhabilitarControles()
        Me.txt_Id.Select()
        Me.txt_Id.ReadOnly = False
    End Sub


    Private Sub txt_IdEmpleado_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_IdEmpleado.KeyDown
        If e.KeyCode = Keys.F4 Then
            Dim frm As New frm_Personas
            AddOwnedForm(frm)
            frm.ShowDialog()
        End If
    End Sub

    Private Sub txt_Id_TextChanged(sender As Object, e As EventArgs) Handles txt_Id.TextChanged

    End Sub

    Private Sub txt_IdEmpleado_TextChanged(sender As Object, e As EventArgs) Handles txt_IdEmpleado.TextChanged

    End Sub
End Class