Public Class frm_Usuario


    Private Sub tsm_Salir_Click(sender As Object, e As EventArgs) Handles tsm_Salir.Click
        Me.Close()
    End Sub

    Private Sub tsm_Nuevo_Click(sender As Object, e As EventArgs) Handles tsm_Nuevo.Click
        Me.tsm_Nuevo.Enabled = False
        Me.tsm_Consultar.Enabled = False
        Me.tsm_Grabar.Enabled = True
        Me.tsm_Modificar.Enabled = False
        Me.tsm_Cancelar.Enabled = True
    End Sub

    Private Sub tsm_Cancelar_Click(sender As Object, e As EventArgs) Handles tsm_Cancelar.Click
        Me.tsm_Nuevo.Enabled = True
        Me.tsm_Consultar.Enabled = True
        Me.tsm_Grabar.Enabled = False
        Me.tsm_Modificar.Enabled = False
        Me.tsm_Cancelar.Enabled = False
    End Sub

    Private Sub frm_Usuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.tsm_Nuevo.Enabled = True
        Me.tsm_Consultar.Enabled = True
        Me.tsm_Grabar.Enabled = False
        Me.tsm_Modificar.Enabled = False
        Me.tsm_Cancelar.Enabled = False
    End Sub


    Private Sub txt_Empleado_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_Empleado.KeyDown
        If e.KeyCode = Keys.F4 Then
            Dim frm As New frm_Personas
            AddOwnedForm(frm)
            frm.ShowDialog()
        End If
    End Sub

End Class