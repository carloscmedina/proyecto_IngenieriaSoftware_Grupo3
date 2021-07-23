Imports capaNegocio
Public Class frm_Personas
    Private Sub frm_Personas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListarPersonas()
    End Sub

    Sub ListarPersonas()
        Dim objCapaNegocio As New cn_Persona
        DataGridView1.DataSource = objCapaNegocio.listarPersonas.Tables("Personas")
    End Sub
End Class