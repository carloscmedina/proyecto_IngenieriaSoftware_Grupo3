<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Medico
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn_Salir = New System.Windows.Forms.Button()
        Me.btn_Limpiar = New System.Windows.Forms.Button()
        Me.btn_Guardar = New System.Windows.Forms.Button()
        Me.rdb_inactivo_medico = New System.Windows.Forms.RadioButton()
        Me.rdb_activo_medico = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbx_id_medico = New System.Windows.Forms.ComboBox()
        Me.lbl_cedula_medico = New System.Windows.Forms.Label()
        Me.lbl_apellido_medico = New System.Windows.Forms.Label()
        Me.lbl_nombre_medico = New System.Windows.Forms.Label()
        Me.lbl_fechanac_medico = New System.Windows.Forms.Label()
        Me.txt_cedula_medico = New System.Windows.Forms.TextBox()
        Me.txt_nombre_medico = New System.Windows.Forms.TextBox()
        Me.txt_apellidos_medico = New System.Windows.Forms.TextBox()
        Me.dtp_fechanacimiento_medico = New System.Windows.Forms.DateTimePicker()
        Me.lbl_registro_medico = New System.Windows.Forms.Label()
        Me.txt_registro_medico = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txt_registro_medico)
        Me.GroupBox1.Controls.Add(Me.lbl_registro_medico)
        Me.GroupBox1.Controls.Add(Me.dtp_fechanacimiento_medico)
        Me.GroupBox1.Controls.Add(Me.txt_apellidos_medico)
        Me.GroupBox1.Controls.Add(Me.txt_nombre_medico)
        Me.GroupBox1.Controls.Add(Me.txt_cedula_medico)
        Me.GroupBox1.Controls.Add(Me.lbl_fechanac_medico)
        Me.GroupBox1.Controls.Add(Me.lbl_nombre_medico)
        Me.GroupBox1.Controls.Add(Me.lbl_apellido_medico)
        Me.GroupBox1.Controls.Add(Me.lbl_cedula_medico)
        Me.GroupBox1.Controls.Add(Me.cbx_id_medico)
        Me.GroupBox1.Controls.Add(Me.btn_Salir)
        Me.GroupBox1.Controls.Add(Me.btn_Limpiar)
        Me.GroupBox1.Controls.Add(Me.btn_Guardar)
        Me.GroupBox1.Controls.Add(Me.rdb_inactivo_medico)
        Me.GroupBox1.Controls.Add(Me.rdb_activo_medico)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(9, 7)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(779, 431)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "MÉDICO"
        '
        'btn_Salir
        '
        Me.btn_Salir.Location = New System.Drawing.Point(547, 337)
        Me.btn_Salir.Name = "btn_Salir"
        Me.btn_Salir.Size = New System.Drawing.Size(75, 23)
        Me.btn_Salir.TabIndex = 8
        Me.btn_Salir.Text = "Salir"
        Me.btn_Salir.UseVisualStyleBackColor = True
        '
        'btn_Limpiar
        '
        Me.btn_Limpiar.Location = New System.Drawing.Point(368, 337)
        Me.btn_Limpiar.Name = "btn_Limpiar"
        Me.btn_Limpiar.Size = New System.Drawing.Size(75, 23)
        Me.btn_Limpiar.TabIndex = 7
        Me.btn_Limpiar.Text = "Eliminar"
        Me.btn_Limpiar.UseVisualStyleBackColor = True
        '
        'btn_Guardar
        '
        Me.btn_Guardar.Location = New System.Drawing.Point(194, 337)
        Me.btn_Guardar.Name = "btn_Guardar"
        Me.btn_Guardar.Size = New System.Drawing.Size(75, 23)
        Me.btn_Guardar.TabIndex = 6
        Me.btn_Guardar.Text = "Guardar"
        Me.btn_Guardar.UseVisualStyleBackColor = True
        '
        'rdb_inactivo_medico
        '
        Me.rdb_inactivo_medico.AutoSize = True
        Me.rdb_inactivo_medico.Location = New System.Drawing.Point(280, 32)
        Me.rdb_inactivo_medico.Name = "rdb_inactivo_medico"
        Me.rdb_inactivo_medico.Size = New System.Drawing.Size(67, 19)
        Me.rdb_inactivo_medico.TabIndex = 5
        Me.rdb_inactivo_medico.TabStop = True
        Me.rdb_inactivo_medico.Text = "Inactivo"
        Me.rdb_inactivo_medico.UseVisualStyleBackColor = True
        '
        'rdb_activo_medico
        '
        Me.rdb_activo_medico.AutoSize = True
        Me.rdb_activo_medico.Location = New System.Drawing.Point(194, 32)
        Me.rdb_activo_medico.Name = "rdb_activo_medico"
        Me.rdb_activo_medico.Size = New System.Drawing.Size(59, 19)
        Me.rdb_activo_medico.TabIndex = 4
        Me.rdb_activo_medico.TabStop = True
        Me.rdb_activo_medico.Text = "Activo"
        Me.rdb_activo_medico.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(35, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Estado:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(35, 91)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID Médico:"
        '
        'cbx_id_medico
        '
        Me.cbx_id_medico.FormattingEnabled = True
        Me.cbx_id_medico.Location = New System.Drawing.Point(194, 91)
        Me.cbx_id_medico.Name = "cbx_id_medico"
        Me.cbx_id_medico.Size = New System.Drawing.Size(121, 23)
        Me.cbx_id_medico.TabIndex = 9
        '
        'lbl_cedula_medico
        '
        Me.lbl_cedula_medico.AutoSize = True
        Me.lbl_cedula_medico.Location = New System.Drawing.Point(35, 127)
        Me.lbl_cedula_medico.Name = "lbl_cedula_medico"
        Me.lbl_cedula_medico.Size = New System.Drawing.Size(47, 15)
        Me.lbl_cedula_medico.TabIndex = 10
        Me.lbl_cedula_medico.Text = "Cédula:"
        '
        'lbl_apellido_medico
        '
        Me.lbl_apellido_medico.AutoSize = True
        Me.lbl_apellido_medico.Location = New System.Drawing.Point(35, 205)
        Me.lbl_apellido_medico.Name = "lbl_apellido_medico"
        Me.lbl_apellido_medico.Size = New System.Drawing.Size(59, 15)
        Me.lbl_apellido_medico.TabIndex = 12
        Me.lbl_apellido_medico.Text = "Apellidos:"
        '
        'lbl_nombre_medico
        '
        Me.lbl_nombre_medico.AutoSize = True
        Me.lbl_nombre_medico.Location = New System.Drawing.Point(35, 169)
        Me.lbl_nombre_medico.Name = "lbl_nombre_medico"
        Me.lbl_nombre_medico.Size = New System.Drawing.Size(59, 15)
        Me.lbl_nombre_medico.TabIndex = 13
        Me.lbl_nombre_medico.Text = "Nombres:"
        '
        'lbl_fechanac_medico
        '
        Me.lbl_fechanac_medico.AutoSize = True
        Me.lbl_fechanac_medico.Location = New System.Drawing.Point(35, 246)
        Me.lbl_fechanac_medico.Name = "lbl_fechanac_medico"
        Me.lbl_fechanac_medico.Size = New System.Drawing.Size(122, 15)
        Me.lbl_fechanac_medico.TabIndex = 14
        Me.lbl_fechanac_medico.Text = "Fecha de Nacimiento:"
        '
        'txt_cedula_medico
        '
        Me.txt_cedula_medico.Location = New System.Drawing.Point(194, 127)
        Me.txt_cedula_medico.Name = "txt_cedula_medico"
        Me.txt_cedula_medico.Size = New System.Drawing.Size(121, 23)
        Me.txt_cedula_medico.TabIndex = 15
        '
        'txt_nombre_medico
        '
        Me.txt_nombre_medico.Location = New System.Drawing.Point(194, 161)
        Me.txt_nombre_medico.Name = "txt_nombre_medico"
        Me.txt_nombre_medico.Size = New System.Drawing.Size(378, 23)
        Me.txt_nombre_medico.TabIndex = 16
        '
        'txt_apellidos_medico
        '
        Me.txt_apellidos_medico.Location = New System.Drawing.Point(194, 197)
        Me.txt_apellidos_medico.Name = "txt_apellidos_medico"
        Me.txt_apellidos_medico.Size = New System.Drawing.Size(378, 23)
        Me.txt_apellidos_medico.TabIndex = 17
        '
        'dtp_fechanacimiento_medico
        '
        Me.dtp_fechanacimiento_medico.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_fechanacimiento_medico.Location = New System.Drawing.Point(194, 237)
        Me.dtp_fechanacimiento_medico.Name = "dtp_fechanacimiento_medico"
        Me.dtp_fechanacimiento_medico.Size = New System.Drawing.Size(200, 23)
        Me.dtp_fechanacimiento_medico.TabIndex = 18
        '
        'lbl_registro_medico
        '
        Me.lbl_registro_medico.AutoSize = True
        Me.lbl_registro_medico.Location = New System.Drawing.Point(35, 62)
        Me.lbl_registro_medico.Name = "lbl_registro_medico"
        Me.lbl_registro_medico.Size = New System.Drawing.Size(113, 15)
        Me.lbl_registro_medico.TabIndex = 20
        Me.lbl_registro_medico.Text = "N° Registro Médico:"
        '
        'txt_registro_medico
        '
        Me.txt_registro_medico.Location = New System.Drawing.Point(194, 62)
        Me.txt_registro_medico.Name = "txt_registro_medico"
        Me.txt_registro_medico.Size = New System.Drawing.Size(121, 23)
        Me.txt_registro_medico.TabIndex = 21
        '
        'frm_Medico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frm_Medico"
        Me.Text = "frm_Medico"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents rdb_inactivo_medico As RadioButton
    Friend WithEvents rdb_activo_medico As RadioButton
    Friend WithEvents btn_Salir As Button
    Friend WithEvents btn_Limpiar As Button
    Friend WithEvents btn_Guardar As Button
    Friend WithEvents cbx_id_medico As ComboBox
    Friend WithEvents lbl_cedula_medico As Label
    Friend WithEvents lbl_nombre_medico As Label
    Friend WithEvents lbl_apellido_medico As Label
    Friend WithEvents lbl_fechanac_medico As Label
    Friend WithEvents txt_nombre_medico As TextBox
    Friend WithEvents txt_cedula_medico As TextBox
    Friend WithEvents txt_registro_medico As TextBox
    Friend WithEvents lbl_registro_medico As Label
    Friend WithEvents dtp_fechanacimiento_medico As DateTimePicker
    Friend WithEvents txt_apellidos_medico As TextBox
End Class
