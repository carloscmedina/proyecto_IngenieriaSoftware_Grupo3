Imports capaNegocio
Public Class frm_Personas
    Public _id_seleccionado As String

    Private Sub frm_Personas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListarPersonas()
    End Sub

    Sub ListarPersonas()
        Dim objCapaNegocio As New cn_Persona
        dgv_Personas.DataSource = objCapaNegocio.listarPersonas.Tables("Personas")
    End Sub


    Private Sub dgv_Personas_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_Personas.CellContentDoubleClick
        'Dim frm As frm_Usuario = CType(Owner, frm_Usuario)
        'Dim frm2 As frm_Reporte_Sintoma = CType(Owner, frm_Reporte_Sintoma)

        If Application.OpenForms().OfType(Of frm_Reporte_Sintoma).Any Then
            Dim frm As frm_Reporte_Sintoma = CType(Owner, frm_Reporte_Sintoma)
            frm.txt_IdEmpleado.Text = dgv_Personas.CurrentRow.Cells(0).Value.ToString()
            frm.txt_Empleado.Text = dgv_Personas.CurrentRow.Cells(2).Value.ToString()
        ElseIf Application.OpenForms().OfType(Of frm_Usuario).Any Then
            Dim frm As frm_Usuario = CType(Owner, frm_Usuario)
            frm.txt_IdEmpleado.Text = dgv_Personas.CurrentRow.Cells(0).Value.ToString()
            frm.txt_NombreEmpleado.Text = dgv_Personas.CurrentRow.Cells(2).Value.ToString()
        ElseIf Application.OpenForms().OfType(Of frm_Examen).Any Then
            Dim frm As frm_Examen = CType(Owner, frm_Examen)
            frm.txt_IdEmpleado.Text = dgv_Personas.CurrentRow.Cells(0).Value.ToString()
            frm.txt_Empleado.Text = dgv_Personas.CurrentRow.Cells(2).Value.ToString()
        ElseIf Application.OpenForms().OfType(Of frm_Cita).Any Then
            Dim frm As frm_Cita = CType(Owner, frm_Cita)
            frm.txt_IdEmpleado.Text = dgv_Personas.CurrentRow.Cells(0).Value.ToString()
            frm.txt_NombreEmpleado.Text = dgv_Personas.CurrentRow.Cells(2).Value.ToString()
        End If

        'frm.txt_IdEmpleado.Text = dgv_Personas.CurrentRow.Cells(0).Value.ToString()
        'frm.txt_NombreEmpleado.Text = dgv_Personas.CurrentRow.Cells(2).Value.ToString()
        Me.Close()
    End Sub
End Class