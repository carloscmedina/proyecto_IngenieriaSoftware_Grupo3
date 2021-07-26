Public Class frm_MenuPrincipal
    Private Sub UsuariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UsuariosToolStripMenuItem.Click
        Dim formulario As New frm_Usuario
        formulario.Show()
    End Sub

    Private Sub EmpleadosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmpleadosToolStripMenuItem.Click
        Dim formulario As New frm_Empleado
        formulario.Show()
    End Sub

    Private Sub MédicosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MédicosToolStripMenuItem.Click
        Dim formulario As New frm_Medico
        formulario.Show()
    End Sub

    Private Sub ReporteSíntomaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReporteSíntomaToolStripMenuItem.Click
        Dim formulario As New frm_Reporte_Sintoma
        formulario.Show()
    End Sub

    Private Sub ExamenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExamenToolStripMenuItem.Click
        Dim formulario As New frm_Examen
        formulario.Show()
    End Sub
End Class
