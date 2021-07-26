Imports capaNegocio
Public Class frm_Personas2
    Public _id_seleccionado As String
    Private Sub frm_Personas2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListarPersonas()
    End Sub

    Sub ListarPersonas()
        Dim objCapaNegocio As New cn_Persona
        dgv_Personas2.DataSource = objCapaNegocio.listarPersonas.Tables("Personas")
    End Sub

    Private Sub dgv_Personas2_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_Personas2.CellContentDoubleClick
        If Application.OpenForms().OfType(Of frm_Examen).Any Then
            Dim frm As frm_Examen = CType(Owner, frm_Examen)
            frm.txt_IdMedico.Text = dgv_Personas2.CurrentRow.Cells(0).Value.ToString()
            frm.txt_Medico.Text = dgv_Personas2.CurrentRow.Cells(2).Value.ToString()
        End If
        Me.Close()
    End Sub
End Class