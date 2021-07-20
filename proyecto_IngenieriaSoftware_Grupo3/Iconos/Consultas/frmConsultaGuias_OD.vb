Imports System.Data.SqlClient

Public Class frmConsultaGuias_OD
    Dim Dt As DataTable
    Dim Da As New SqlDataAdapter
    Dim Cmd As New SqlCommand


    Private Sub frmConsultaGuias_OD_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LlenarComboCompania()
        Me.cmbTipo.SelectedIndex = 0
    End Sub


    Private Sub LlenarComboCompania()
        With Cmd
            .CommandType = CommandType.Text
            .CommandText = "Select ccicompania, ccicompania + ' ' + cnocompania as cnocompania From tblGbCompania where bsnactivo = 1"
            .Connection = Cn
        End With
        Da.SelectCommand = Cmd
        Dt = New DataTable
        Da.Fill(Dt)
        With cmbCompania
            .DataSource = Dt
            .DisplayMember = "cnocompania"
            .ValueMember = "ccicompania"
        End With
    End Sub

    Private Sub LlenarComboDivision(ByVal valor As String)
        With Cmd
            .CommandType = CommandType.Text
            .CommandText = "Select ccidivision, ccidivision + ' ' + cnodivision as cnodivision From tblGbDivision where ccicompania ='" & valor & "' and bsnactivo = '1'"
            .Connection = Cn
        End With
        Da.SelectCommand = Cmd
        Dt = New DataTable
        Da.Fill(Dt)
        With cmbDivision
            .DataSource = Dt
            .DisplayMember = "cnodivision"
            .ValueMember = "ccidivision"
        End With
    End Sub

    Private Sub LlenarComboPlanta(ByVal valor As String)
        With Cmd
            .CommandType = CommandType.Text
            .CommandText = "Select cciplanta, cciplanta + ' ' + cnoplanta as cnoplanta From tblGbPlanta where ccidivision ='" & valor & "' and bsnactivo = '1'"
            .Connection = Cn
        End With
        Da.SelectCommand = Cmd
        Dt = New DataTable
        Da.Fill(Dt)
        With cmbPlanta
            .DataSource = Dt
            .DisplayMember = "cnoplanta"
            .ValueMember = "cciplanta"
        End With
        Me.cmbPlanta.SelectedValue = Variableplanta
    End Sub

    Private Sub LlenarComboAlmacen(ByVal valor As String)
        With Cmd
            .CommandType = CommandType.Text
            .CommandText = "Select MWWHLO as ccialmacen, MWWHLO + ' ' + MWWHNM as cnoalmacen From MITWHL WHERE MWFACI = '" & valor & "'"
            '.CommandText = "Select OAADK2 as ccialmacen, OAADK2 + ' ' + OACONM as cnoalmacen From CIADDR where OAADK2 ='" & valor & "'"
            .Connection = Cn
        End With
        Da.SelectCommand = Cmd
        Dt = New DataTable
        Da.Fill(Dt)
        With cmbAlmacen
            .DataSource = Dt
            .DisplayMember = "cnoalmacen"
            .ValueMember = "ccialmacen"
        End With
        Me.cmbAlmacen.SelectedValue = Variablealmacen
    End Sub

    Private Sub cmbCompania_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbCompania.SelectedValueChanged
        Me.cmbDivision.SelectedIndex = -1
        Me.cmbPlanta.SelectedIndex = -1
        LlenarComboDivision(Me.cmbCompania.SelectedValue.ToString)
        Encerar()
    End Sub

    Private Sub cmbDivision_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbDivision.SelectedValueChanged
        If Me.cmbDivision.SelectedIndex = -1 Then
        Else
            LlenarComboPlanta(Me.cmbDivision.SelectedValue.ToString)
        End If
        Encerar()
    End Sub

    Private Sub cmbPlanta_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbPlanta.SelectedValueChanged
        If Me.cmbPlanta.SelectedIndex = -1 Then
        Else
            LlenarComboAlmacen(Me.cmbPlanta.SelectedValue.ToString)
            'Me.LlenarCabecera()
        End If
        Encerar()
    End Sub

    Private Sub btnConsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsultar.Click
        If Me.txtNumero.Text <> String.Empty Then
            Encerar()
            obj_con.ConnectionString = cs
            obj_con.Open()
            With obj_cmd
                .CommandType = CommandType.StoredProcedure
                .CommandText = "sp_GuiaOrdenesDistribucionRecuperarDatosInformativos"
                .Connection = obj_con
                .Parameters.AddWithValue("@ccicompania", Mid(Me.cmbCompania.Text, 1, 1))
                .Parameters.AddWithValue("@ccidivision", Mid(Me.cmbDivision.Text, 1, 3))
                .Parameters.AddWithValue("@cciplanta", Mid(Me.cmbPlanta.Text, 1, 3))
                .Parameters.AddWithValue("@ccialmacen", Mid(Me.cmbAlmacen.Text, 1, 3))
                .Parameters.AddWithValue("@tipo", Mid(Me.cmbTipo.Text, 1, 2))
                .Parameters.AddWithValue("@numero", Me.txtNumero.Text)
            End With

            obj_dr = obj_cmd.ExecuteReader

            If obj_dr.Read Then
                Me.txtOrden.Text = obj_dr.Item("nnuorden")
                Me.txtOrdenEntrega.Text = obj_dr.Item("nnuordenentrega")
                Me.txtTracking.Text = obj_dr.Item("nnutracking")
                Me.txtFecha.Text = obj_dr.Item("FechaGuia")
                If Me.txtTracking.Text <> String.Empty Then
                    Me.btnCargarenGuia.Visible = True
                Else
                    Me.btnCargarenGuia.Visible = False
                End If
            Else
                Me.btnCargarenGuia.Visible = False
                Me.txtOrden.Text = String.Empty
                Me.txtOrdenEntrega.Text = String.Empty
                Me.txtTracking.Text = String.Empty
                Me.txtFecha.Text = String.Empty

                MessageBox.Show("Orden de distribución no existe en M3", "DM3SK", _
    MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            obj_dr.Close()
            obj_con.Close()
            obj_cmd.Dispose()
        End If
    End Sub

    Private Sub Encerar()
        Me.txtOrden.Text = String.Empty
        Me.txtOrdenEntrega.Text = String.Empty
        Me.txtTracking.Text = String.Empty
        Me.txtFecha.Text = String.Empty
    End Sub

    Private Sub btnCargarenGuia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCargarenGuia.Click
        obj_con0.ConnectionString = cs
        obj_con0.Open()
        With obj_cmd0
            .CommandType = CommandType.StoredProcedure
            .CommandText = "sp_VerificarPermisos"
            .Connection = obj_con0
            .Parameters.AddWithValue("@cciusuario", frmPrincipal.lbl_Usuario.Text)
            .Parameters.AddWithValue("@cciformulario", "101")
        End With
        obj_dr0 = obj_cmd0.ExecuteReader
        If obj_dr0.Read Then
            frmGuias.Show()
            frmGuias.cmbCompania.Text = Me.cmbCompania.Text
            frmGuias.cmbDivision.Text = Me.cmbDivision.Text
            frmGuias.cmbPlanta.Text = Me.cmbPlanta.Text
            frmGuias.cmbAlmacen.Text = Me.cmbAlmacen.Text
            frmGuias.cmbTipo.Text = Me.cmbTipo.Text
            frmGuias.txtNumero.Text = Me.txtNumero.Text
            frmGuias.ConsultaGuia()
        Else
            MessageBox.Show("Usuario no autorizado para enviar guías al portal", "DM3SK", _
MessageBoxButtons.OK, MessageBoxIcon.Hand)
        End If
        obj_dr0.Close()
        obj_con0.Close()
        obj_cmd0.Dispose()
    End Sub
End Class