<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsultaGuias_OD
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnCargarenGuia = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtFecha = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtTracking = New System.Windows.Forms.TextBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.txtOrdenEntrega = New System.Windows.Forms.TextBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.txtOrden = New System.Windows.Forms.TextBox
        Me.cmbTipo = New System.Windows.Forms.ComboBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.cmbAlmacen = New System.Windows.Forms.ComboBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.cmbPlanta = New System.Windows.Forms.ComboBox
        Me.cmbDivision = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.cmbCompania = New System.Windows.Forms.ComboBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnConsultar = New System.Windows.Forms.Button
        Me.txtNumero = New System.Windows.Forms.TextBox
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnCargarenGuia)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtFecha)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtTracking)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.txtOrdenEntrega)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.txtOrden)
        Me.GroupBox1.Controls.Add(Me.cmbTipo)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.cmbAlmacen)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.cmbPlanta)
        Me.GroupBox1.Controls.Add(Me.cmbDivision)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.cmbCompania)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.btnConsultar)
        Me.GroupBox1.Controls.Add(Me.txtNumero)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(316, 293)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        '
        'btnCargarenGuia
        '
        Me.btnCargarenGuia.Location = New System.Drawing.Point(192, 257)
        Me.btnCargarenGuia.Name = "btnCargarenGuia"
        Me.btnCargarenGuia.Size = New System.Drawing.Size(95, 29)
        Me.btnCargarenGuia.TabIndex = 95
        Me.btnCargarenGuia.Text = "Cargar en Guía"
        Me.btnCargarenGuia.UseVisualStyleBackColor = True
        Me.btnCargarenGuia.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 240)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 94
        Me.Label3.Text = "Fecha"
        '
        'txtFecha
        '
        Me.txtFecha.Location = New System.Drawing.Point(71, 236)
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.ReadOnly = True
        Me.txtFecha.Size = New System.Drawing.Size(103, 20)
        Me.txtFecha.TabIndex = 93
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 266)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 92
        Me.Label2.Text = "Tracking"
        '
        'txtTracking
        '
        Me.txtTracking.Location = New System.Drawing.Point(71, 262)
        Me.txtTracking.Name = "txtTracking"
        Me.txtTracking.ReadOnly = True
        Me.txtTracking.Size = New System.Drawing.Size(103, 20)
        Me.txtTracking.TabIndex = 91
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(13, 212)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(47, 13)
        Me.Label17.TabIndex = 90
        Me.Label17.Text = "# O. Ent"
        '
        'txtOrdenEntrega
        '
        Me.txtOrdenEntrega.Location = New System.Drawing.Point(71, 209)
        Me.txtOrdenEntrega.Name = "txtOrdenEntrega"
        Me.txtOrdenEntrega.ReadOnly = True
        Me.txtOrdenEntrega.Size = New System.Drawing.Size(103, 20)
        Me.txtOrdenEntrega.TabIndex = 89
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(13, 186)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(46, 13)
        Me.Label16.TabIndex = 88
        Me.Label16.Text = "# Orden"
        '
        'txtOrden
        '
        Me.txtOrden.Location = New System.Drawing.Point(70, 183)
        Me.txtOrden.Name = "txtOrden"
        Me.txtOrden.ReadOnly = True
        Me.txtOrden.Size = New System.Drawing.Size(103, 20)
        Me.txtOrden.TabIndex = 87
        '
        'cmbTipo
        '
        Me.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTipo.FormattingEnabled = True
        Me.cmbTipo.Items.AddRange(New Object() {"GV Guías por Venta", "GO Guías por Orden de Distribución"})
        Me.cmbTipo.Location = New System.Drawing.Point(69, 123)
        Me.cmbTipo.Name = "cmbTipo"
        Me.cmbTipo.Size = New System.Drawing.Size(203, 21)
        Me.cmbTipo.TabIndex = 86
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(12, 126)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(28, 13)
        Me.Label15.TabIndex = 85
        Me.Label15.Text = "Tipo"
        '
        'cmbAlmacen
        '
        Me.cmbAlmacen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbAlmacen.FormattingEnabled = True
        Me.cmbAlmacen.Location = New System.Drawing.Point(68, 94)
        Me.cmbAlmacen.Name = "cmbAlmacen"
        Me.cmbAlmacen.Size = New System.Drawing.Size(203, 21)
        Me.cmbAlmacen.TabIndex = 84
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(11, 97)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(48, 13)
        Me.Label11.TabIndex = 83
        Me.Label11.Text = "Almacén"
        '
        'cmbPlanta
        '
        Me.cmbPlanta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPlanta.FormattingEnabled = True
        Me.cmbPlanta.Location = New System.Drawing.Point(68, 67)
        Me.cmbPlanta.Name = "cmbPlanta"
        Me.cmbPlanta.Size = New System.Drawing.Size(203, 21)
        Me.cmbPlanta.TabIndex = 82
        '
        'cmbDivision
        '
        Me.cmbDivision.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDivision.FormattingEnabled = True
        Me.cmbDivision.Location = New System.Drawing.Point(68, 40)
        Me.cmbDivision.Name = "cmbDivision"
        Me.cmbDivision.Size = New System.Drawing.Size(203, 21)
        Me.cmbDivision.TabIndex = 81
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(11, 73)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 13)
        Me.Label5.TabIndex = 80
        Me.Label5.Text = "Planta"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(11, 16)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(56, 13)
        Me.Label9.TabIndex = 79
        Me.Label9.Text = "Compañía"
        '
        'cmbCompania
        '
        Me.cmbCompania.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCompania.FormattingEnabled = True
        Me.cmbCompania.Location = New System.Drawing.Point(69, 13)
        Me.cmbCompania.Name = "cmbCompania"
        Me.cmbCompania.Size = New System.Drawing.Size(202, 21)
        Me.cmbCompania.TabIndex = 78
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(11, 43)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(44, 13)
        Me.Label7.TabIndex = 77
        Me.Label7.Text = "División"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 155)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Número"
        '
        'btnConsultar
        '
        Me.btnConsultar.Location = New System.Drawing.Point(192, 147)
        Me.btnConsultar.Name = "btnConsultar"
        Me.btnConsultar.Size = New System.Drawing.Size(60, 29)
        Me.btnConsultar.TabIndex = 2
        Me.btnConsultar.Text = "Consultar"
        Me.btnConsultar.UseVisualStyleBackColor = True
        '
        'txtNumero
        '
        Me.txtNumero.Location = New System.Drawing.Point(70, 152)
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.Size = New System.Drawing.Size(103, 20)
        Me.txtNumero.TabIndex = 0
        '
        'frmConsultaGuias_OD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(335, 305)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmConsultaGuias_OD"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmConsultaGuias_OD"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtOrdenEntrega As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtOrden As System.Windows.Forms.TextBox
    Friend WithEvents cmbTipo As System.Windows.Forms.ComboBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents cmbAlmacen As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents cmbPlanta As System.Windows.Forms.ComboBox
    Friend WithEvents cmbDivision As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cmbCompania As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnConsultar As System.Windows.Forms.Button
    Friend WithEvents txtNumero As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtTracking As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtFecha As System.Windows.Forms.TextBox
    Friend WithEvents btnCargarenGuia As System.Windows.Forms.Button
End Class
