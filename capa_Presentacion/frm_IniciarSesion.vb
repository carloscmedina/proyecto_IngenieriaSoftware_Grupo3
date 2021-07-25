Option Strict On
Option Explicit On

Imports capaNegocio
Imports capaEntidad

Public Class frm_IniciarSesion

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        logearse()
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Function Validar(ByVal registros As Usuario) As Boolean
        Dim valor As Boolean
        Dim obj As New cn_Usuario
        valor = obj.Validar(registros)
        Return valor
    End Function

    Private Sub logearse()
        Dim autorizado As Boolean
        Dim registros As New Usuario
        With registros
            .usuario = txt_Usuario.Text
            .contrasenia = txt_Contrasenia.Text
        End With
        autorizado = Validar(registros)

        If autorizado Then
            frm_MenuPrincipal.Show()
            frm_MenuPrincipal.Text = "Usuario : " + registros.usuario

        Else
            MessageBox.Show("usuario o contraseña incorrecta")
        End If
    End Sub

End Class
