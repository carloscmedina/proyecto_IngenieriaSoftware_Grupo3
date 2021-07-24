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
        Dim frm As frm_Usuario = CType(Owner, frm_Usuario)
        frm.txt_Empleado.Text = dgv_Personas.CurrentRow.Cells(0).Value.ToString()
        frm.txt_NombreEmpleado.Text = dgv_Personas.CurrentRow.Cells(2).Value.ToString()
        Me.Close()
    End Sub
End Class