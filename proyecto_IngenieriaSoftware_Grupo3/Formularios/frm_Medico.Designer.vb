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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Medico))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txt_registro_medico = New System.Windows.Forms.TextBox()
        Me.lbl_registro_medico = New System.Windows.Forms.Label()
        Me.dtp_fechanacimiento_medico = New System.Windows.Forms.DateTimePicker()
        Me.txt_apellidos_medico = New System.Windows.Forms.TextBox()
        Me.txt_nombre_medico = New System.Windows.Forms.TextBox()
        Me.txt_cedula_medico = New System.Windows.Forms.TextBox()
        Me.lbl_fechanac_medico = New System.Windows.Forms.Label()
        Me.lbl_nombre_medico = New System.Windows.Forms.Label()
        Me.lbl_apellido_medico = New System.Windows.Forms.Label()
        Me.lbl_cedula_medico = New System.Windows.Forms.Label()
        Me.rdb_inactivo_medico = New System.Windows.Forms.RadioButton()
        Me.rdb_activo_medico = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ConsultarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GrabarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModificarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CancelarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.GroupBox1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TextBox1)
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
        Me.GroupBox1.Controls.Add(Me.rdb_inactivo_medico)
        Me.GroupBox1.Controls.Add(Me.rdb_activo_medico)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(10, 26)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(606, 281)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'txt_registro_medico
        '
        Me.txt_registro_medico.Location = New System.Drawing.Point(180, 21)
        Me.txt_registro_medico.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_registro_medico.Name = "txt_registro_medico"
        Me.txt_registro_medico.Size = New System.Drawing.Size(138, 27)
        Me.txt_registro_medico.TabIndex = 21
        '
        'lbl_registro_medico
        '
        Me.lbl_registro_medico.AutoSize = True
        Me.lbl_registro_medico.Location = New System.Drawing.Point(17, 24)
        Me.lbl_registro_medico.Name = "lbl_registro_medico"
        Me.lbl_registro_medico.Size = New System.Drawing.Size(139, 20)
        Me.lbl_registro_medico.TabIndex = 20
        Me.lbl_registro_medico.Text = "N° Registro Médico"
        '
        'dtp_fechanacimiento_medico
        '
        Me.dtp_fechanacimiento_medico.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_fechanacimiento_medico.Location = New System.Drawing.Point(180, 223)
        Me.dtp_fechanacimiento_medico.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dtp_fechanacimiento_medico.Name = "dtp_fechanacimiento_medico"
        Me.dtp_fechanacimiento_medico.Size = New System.Drawing.Size(138, 27)
        Me.dtp_fechanacimiento_medico.TabIndex = 18
        '
        'txt_apellidos_medico
        '
        Me.txt_apellidos_medico.Location = New System.Drawing.Point(180, 178)
        Me.txt_apellidos_medico.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_apellidos_medico.Name = "txt_apellidos_medico"
        Me.txt_apellidos_medico.Size = New System.Drawing.Size(409, 27)
        Me.txt_apellidos_medico.TabIndex = 17
        '
        'txt_nombre_medico
        '
        Me.txt_nombre_medico.Location = New System.Drawing.Point(180, 140)
        Me.txt_nombre_medico.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_nombre_medico.Name = "txt_nombre_medico"
        Me.txt_nombre_medico.Size = New System.Drawing.Size(409, 27)
        Me.txt_nombre_medico.TabIndex = 16
        '
        'txt_cedula_medico
        '
        Me.txt_cedula_medico.Location = New System.Drawing.Point(180, 99)
        Me.txt_cedula_medico.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_cedula_medico.Name = "txt_cedula_medico"
        Me.txt_cedula_medico.Size = New System.Drawing.Size(138, 27)
        Me.txt_cedula_medico.TabIndex = 15
        '
        'lbl_fechanac_medico
        '
        Me.lbl_fechanac_medico.AutoSize = True
        Me.lbl_fechanac_medico.Location = New System.Drawing.Point(19, 228)
        Me.lbl_fechanac_medico.Name = "lbl_fechanac_medico"
        Me.lbl_fechanac_medico.Size = New System.Drawing.Size(149, 20)
        Me.lbl_fechanac_medico.TabIndex = 14
        Me.lbl_fechanac_medico.Text = "Fecha de Nacimiento"
        '
        'lbl_nombre_medico
        '
        Me.lbl_nombre_medico.AutoSize = True
        Me.lbl_nombre_medico.Location = New System.Drawing.Point(19, 181)
        Me.lbl_nombre_medico.Name = "lbl_nombre_medico"
        Me.lbl_nombre_medico.Size = New System.Drawing.Size(70, 20)
        Me.lbl_nombre_medico.TabIndex = 13
        Me.lbl_nombre_medico.Text = "Nombres"
        '
        'lbl_apellido_medico
        '
        Me.lbl_apellido_medico.AutoSize = True
        Me.lbl_apellido_medico.Location = New System.Drawing.Point(17, 143)
        Me.lbl_apellido_medico.Name = "lbl_apellido_medico"
        Me.lbl_apellido_medico.Size = New System.Drawing.Size(72, 20)
        Me.lbl_apellido_medico.TabIndex = 12
        Me.lbl_apellido_medico.Text = "Apellidos"
        '
        'lbl_cedula_medico
        '
        Me.lbl_cedula_medico.AutoSize = True
        Me.lbl_cedula_medico.Location = New System.Drawing.Point(17, 102)
        Me.lbl_cedula_medico.Name = "lbl_cedula_medico"
        Me.lbl_cedula_medico.Size = New System.Drawing.Size(55, 20)
        Me.lbl_cedula_medico.TabIndex = 10
        Me.lbl_cedula_medico.Text = "Cédula"
        '
        'rdb_inactivo_medico
        '
        Me.rdb_inactivo_medico.AutoSize = True
        Me.rdb_inactivo_medico.Location = New System.Drawing.Point(517, 48)
        Me.rdb_inactivo_medico.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.rdb_inactivo_medico.Name = "rdb_inactivo_medico"
        Me.rdb_inactivo_medico.Size = New System.Drawing.Size(82, 24)
        Me.rdb_inactivo_medico.TabIndex = 5
        Me.rdb_inactivo_medico.TabStop = True
        Me.rdb_inactivo_medico.Text = "Inactivo"
        Me.rdb_inactivo_medico.UseVisualStyleBackColor = True
        '
        'rdb_activo_medico
        '
        Me.rdb_activo_medico.AutoSize = True
        Me.rdb_activo_medico.Location = New System.Drawing.Point(517, 16)
        Me.rdb_activo_medico.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.rdb_activo_medico.Name = "rdb_activo_medico"
        Me.rdb_activo_medico.Size = New System.Drawing.Size(72, 24)
        Me.rdb_activo_medico.TabIndex = 4
        Me.rdb_activo_medico.TabStop = True
        Me.rdb_activo_medico.Text = "Activo"
        Me.rdb_activo_medico.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(437, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Estado"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID Médico"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConsultarToolStripMenuItem, Me.GrabarToolStripMenuItem, Me.ModificarToolStripMenuItem, Me.CancelarToolStripMenuItem, Me.EliminarToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(624, 28)
        Me.MenuStrip1.TabIndex = 11
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ConsultarToolStripMenuItem
        '
        Me.ConsultarToolStripMenuItem.Image = CType(resources.GetObject("ConsultarToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ConsultarToolStripMenuItem.Name = "ConsultarToolStripMenuItem"
        Me.ConsultarToolStripMenuItem.Size = New System.Drawing.Size(105, 24)
        Me.ConsultarToolStripMenuItem.Text = "Consultar"
        '
        'GrabarToolStripMenuItem
        '
        Me.GrabarToolStripMenuItem.Image = CType(resources.GetObject("GrabarToolStripMenuItem.Image"), System.Drawing.Image)
        Me.GrabarToolStripMenuItem.Name = "GrabarToolStripMenuItem"
        Me.GrabarToolStripMenuItem.Size = New System.Drawing.Size(88, 24)
        Me.GrabarToolStripMenuItem.Text = "Grabar"
        '
        'ModificarToolStripMenuItem
        '
        Me.ModificarToolStripMenuItem.Image = CType(resources.GetObject("ModificarToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ModificarToolStripMenuItem.Name = "ModificarToolStripMenuItem"
        Me.ModificarToolStripMenuItem.Size = New System.Drawing.Size(107, 24)
        Me.ModificarToolStripMenuItem.Text = "Modificar"
        '
        'CancelarToolStripMenuItem
        '
        Me.CancelarToolStripMenuItem.Image = CType(resources.GetObject("CancelarToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CancelarToolStripMenuItem.Name = "CancelarToolStripMenuItem"
        Me.CancelarToolStripMenuItem.Size = New System.Drawing.Size(100, 24)
        Me.CancelarToolStripMenuItem.Text = "Cancelar"
        '
        'EliminarToolStripMenuItem
        '
        Me.EliminarToolStripMenuItem.Image = CType(resources.GetObject("EliminarToolStripMenuItem.Image"), System.Drawing.Image)
        Me.EliminarToolStripMenuItem.Name = "EliminarToolStripMenuItem"
        Me.EliminarToolStripMenuItem.Size = New System.Drawing.Size(97, 24)
        Me.EliminarToolStripMenuItem.Text = "Eliminar"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Image = CType(resources.GetObject("SalirToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(72, 24)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(180, 61)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(138, 27)
        Me.TextBox1.TabIndex = 22
        '
        'frm_Medico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(624, 321)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frm_Medico"
        Me.Text = "Mantenimiento de Médicos"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents rdb_inactivo_medico As RadioButton
    Friend WithEvents rdb_activo_medico As RadioButton
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
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ConsultarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GrabarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ModificarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CancelarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EliminarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
End Class
