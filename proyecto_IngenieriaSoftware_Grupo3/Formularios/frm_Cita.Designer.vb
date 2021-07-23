<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_Cita
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Cita))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmb_Horarios = New System.Windows.Forms.ComboBox()
        Me.btn_VerExamen = New System.Windows.Forms.Button()
        Me.txt_IDExamen = New System.Windows.Forms.TextBox()
        Me.lbl_Examen = New System.Windows.Forms.Label()
        Me.dtp_Fecha = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cmb_Doctor = New System.Windows.Forms.ComboBox()
        Me.txt_NombreEmpleado = New System.Windows.Forms.TextBox()
        Me.txt_IdEmpleado = New System.Windows.Forms.TextBox()
        Me.txt_IdCita = New System.Windows.Forms.TextBox()
        Me.lbl_Horario = New System.Windows.Forms.Label()
        Me.lbl_Medico = New System.Windows.Forms.Label()
        Me.lbl_Empleado = New System.Windows.Forms.Label()
        Me.lbl_IdCita = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ConsultarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GrabarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModificarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CancelarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lbl_Rol = New System.Windows.Forms.Label()
        Me.lbl_Usuario = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmb_Horarios)
        Me.GroupBox1.Controls.Add(Me.btn_VerExamen)
        Me.GroupBox1.Controls.Add(Me.txt_IDExamen)
        Me.GroupBox1.Controls.Add(Me.lbl_Examen)
        Me.GroupBox1.Controls.Add(Me.dtp_Fecha)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.cmb_Doctor)
        Me.GroupBox1.Controls.Add(Me.txt_NombreEmpleado)
        Me.GroupBox1.Controls.Add(Me.txt_IdEmpleado)
        Me.GroupBox1.Controls.Add(Me.txt_IdCita)
        Me.GroupBox1.Controls.Add(Me.lbl_Horario)
        Me.GroupBox1.Controls.Add(Me.lbl_Medico)
        Me.GroupBox1.Controls.Add(Me.lbl_Empleado)
        Me.GroupBox1.Controls.Add(Me.lbl_IdCita)
        Me.GroupBox1.Location = New System.Drawing.Point(10, 23)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(489, 157)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'cmb_Horarios
        '
        Me.cmb_Horarios.FormattingEnabled = True
        Me.cmb_Horarios.Location = New System.Drawing.Point(96, 123)
        Me.cmb_Horarios.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmb_Horarios.Name = "cmb_Horarios"
        Me.cmb_Horarios.Size = New System.Drawing.Size(161, 23)
        Me.cmb_Horarios.TabIndex = 14
        '
        'btn_VerExamen
        '
        Me.btn_VerExamen.Location = New System.Drawing.Point(174, 94)
        Me.btn_VerExamen.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_VerExamen.Name = "btn_VerExamen"
        Me.btn_VerExamen.Size = New System.Drawing.Size(82, 22)
        Me.btn_VerExamen.TabIndex = 16
        Me.btn_VerExamen.Text = "Ver exámen"
        Me.btn_VerExamen.UseVisualStyleBackColor = True
        '
        'txt_IDExamen
        '
        Me.txt_IDExamen.Location = New System.Drawing.Point(96, 94)
        Me.txt_IDExamen.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_IDExamen.Name = "txt_IDExamen"
        Me.txt_IDExamen.Size = New System.Drawing.Size(73, 23)
        Me.txt_IDExamen.TabIndex = 15
        '
        'lbl_Examen
        '
        Me.lbl_Examen.AutoSize = True
        Me.lbl_Examen.Location = New System.Drawing.Point(13, 94)
        Me.lbl_Examen.Name = "lbl_Examen"
        Me.lbl_Examen.Size = New System.Drawing.Size(49, 15)
        Me.lbl_Examen.TabIndex = 14
        Me.lbl_Examen.Text = "Examen"
        '
        'dtp_Fecha
        '
        Me.dtp_Fecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_Fecha.Location = New System.Drawing.Point(385, 9)
        Me.dtp_Fecha.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dtp_Fecha.Name = "dtp_Fecha"
        Me.dtp_Fecha.Size = New System.Drawing.Size(94, 23)
        Me.dtp_Fecha.TabIndex = 13
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(339, 13)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(38, 15)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Fecha"
        '
        'cmb_Doctor
        '
        Me.cmb_Doctor.FormattingEnabled = True
        Me.cmb_Doctor.Location = New System.Drawing.Point(96, 66)
        Me.cmb_Doctor.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmb_Doctor.Name = "cmb_Doctor"
        Me.cmb_Doctor.Size = New System.Drawing.Size(383, 23)
        Me.cmb_Doctor.TabIndex = 11
        '
        'txt_NombreEmpleado
        '
        Me.txt_NombreEmpleado.Location = New System.Drawing.Point(174, 38)
        Me.txt_NombreEmpleado.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_NombreEmpleado.Name = "txt_NombreEmpleado"
        Me.txt_NombreEmpleado.Size = New System.Drawing.Size(305, 23)
        Me.txt_NombreEmpleado.TabIndex = 10
        '
        'txt_IdEmpleado
        '
        Me.txt_IdEmpleado.Location = New System.Drawing.Point(96, 38)
        Me.txt_IdEmpleado.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_IdEmpleado.Name = "txt_IdEmpleado"
        Me.txt_IdEmpleado.Size = New System.Drawing.Size(73, 23)
        Me.txt_IdEmpleado.TabIndex = 7
        '
        'txt_IdCita
        '
        Me.txt_IdCita.Location = New System.Drawing.Point(96, 12)
        Me.txt_IdCita.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_IdCita.Name = "txt_IdCita"
        Me.txt_IdCita.Size = New System.Drawing.Size(73, 23)
        Me.txt_IdCita.TabIndex = 5
        '
        'lbl_Horario
        '
        Me.lbl_Horario.AutoSize = True
        Me.lbl_Horario.Location = New System.Drawing.Point(14, 129)
        Me.lbl_Horario.Name = "lbl_Horario"
        Me.lbl_Horario.Size = New System.Drawing.Size(47, 15)
        Me.lbl_Horario.TabIndex = 3
        Me.lbl_Horario.Text = "Horario"
        '
        'lbl_Medico
        '
        Me.lbl_Medico.AutoSize = True
        Me.lbl_Medico.Location = New System.Drawing.Point(13, 66)
        Me.lbl_Medico.Name = "lbl_Medico"
        Me.lbl_Medico.Size = New System.Drawing.Size(47, 15)
        Me.lbl_Medico.TabIndex = 2
        Me.lbl_Medico.Text = "Médico"
        '
        'lbl_Empleado
        '
        Me.lbl_Empleado.AutoSize = True
        Me.lbl_Empleado.Location = New System.Drawing.Point(13, 38)
        Me.lbl_Empleado.Name = "lbl_Empleado"
        Me.lbl_Empleado.Size = New System.Drawing.Size(60, 15)
        Me.lbl_Empleado.TabIndex = 1
        Me.lbl_Empleado.Text = "Empleado"
        '
        'lbl_IdCita
        '
        Me.lbl_IdCita.AutoSize = True
        Me.lbl_IdCita.Location = New System.Drawing.Point(13, 14)
        Me.lbl_IdCita.Name = "lbl_IdCita"
        Me.lbl_IdCita.Size = New System.Drawing.Size(41, 15)
        Me.lbl_IdCita.TabIndex = 0
        Me.lbl_IdCita.Text = "Id Cita"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConsultarToolStripMenuItem, Me.GrabarToolStripMenuItem, Me.ModificarToolStripMenuItem, Me.CancelarToolStripMenuItem, Me.EliminarToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(5, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(513, 28)
        Me.MenuStrip1.TabIndex = 13
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ConsultarToolStripMenuItem
        '
        Me.ConsultarToolStripMenuItem.Image = CType(resources.GetObject("ConsultarToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ConsultarToolStripMenuItem.Name = "ConsultarToolStripMenuItem"
        Me.ConsultarToolStripMenuItem.Size = New System.Drawing.Size(90, 24)
        Me.ConsultarToolStripMenuItem.Text = "Consultar"
        '
        'GrabarToolStripMenuItem
        '
        Me.GrabarToolStripMenuItem.Image = CType(resources.GetObject("GrabarToolStripMenuItem.Image"), System.Drawing.Image)
        Me.GrabarToolStripMenuItem.Name = "GrabarToolStripMenuItem"
        Me.GrabarToolStripMenuItem.Size = New System.Drawing.Size(74, 24)
        Me.GrabarToolStripMenuItem.Text = "Grabar"
        '
        'ModificarToolStripMenuItem
        '
        Me.ModificarToolStripMenuItem.Image = CType(resources.GetObject("ModificarToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ModificarToolStripMenuItem.Name = "ModificarToolStripMenuItem"
        Me.ModificarToolStripMenuItem.Size = New System.Drawing.Size(90, 24)
        Me.ModificarToolStripMenuItem.Text = "Modificar"
        '
        'CancelarToolStripMenuItem
        '
        Me.CancelarToolStripMenuItem.Image = CType(resources.GetObject("CancelarToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CancelarToolStripMenuItem.Name = "CancelarToolStripMenuItem"
        Me.CancelarToolStripMenuItem.Size = New System.Drawing.Size(85, 24)
        Me.CancelarToolStripMenuItem.Text = "Cancelar"
        '
        'EliminarToolStripMenuItem
        '
        Me.EliminarToolStripMenuItem.Image = CType(resources.GetObject("EliminarToolStripMenuItem.Image"), System.Drawing.Image)
        Me.EliminarToolStripMenuItem.Name = "EliminarToolStripMenuItem"
        Me.EliminarToolStripMenuItem.Size = New System.Drawing.Size(82, 24)
        Me.EliminarToolStripMenuItem.Text = "Eliminar"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Image = CType(resources.GetObject("SalirToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(61, 24)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(61, 190)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(10, 15)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "|"
        '
        'lbl_Rol
        '
        Me.lbl_Rol.AutoSize = True
        Me.lbl_Rol.Location = New System.Drawing.Point(78, 190)
        Me.lbl_Rol.Name = "lbl_Rol"
        Me.lbl_Rol.Size = New System.Drawing.Size(21, 15)
        Me.lbl_Rol.TabIndex = 18
        Me.lbl_Rol.Text = "rol"
        '
        'lbl_Usuario
        '
        Me.lbl_Usuario.AutoSize = True
        Me.lbl_Usuario.Location = New System.Drawing.Point(10, 190)
        Me.lbl_Usuario.Name = "lbl_Usuario"
        Me.lbl_Usuario.Size = New System.Drawing.Size(46, 15)
        Me.lbl_Usuario.TabIndex = 17
        Me.lbl_Usuario.Text = "usuario"
        '
        'frm_Cita
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(513, 218)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lbl_Rol)
        Me.Controls.Add(Me.lbl_Usuario)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frm_Cita"
        Me.Text = "Cita"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dtp_Fecha As DateTimePicker
    Friend WithEvents Label8 As Label
    Friend WithEvents cmb_Doctor As ComboBox
    Friend WithEvents txt_NombreEmpleado As TextBox
    Friend WithEvents txt_IdEmpleado As TextBox
    Friend WithEvents txt_IdCita As TextBox
    Friend WithEvents lbl_Horario As Label
    Friend WithEvents lbl_Medico As Label
    Friend WithEvents lbl_Empleado As Label
    Friend WithEvents lbl_IdCita As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ConsultarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GrabarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ModificarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CancelarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EliminarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents cmb_Horarios As ComboBox
    Friend WithEvents btn_VerExamen As Button
    Friend WithEvents txt_IDExamen As TextBox
    Friend WithEvents lbl_Examen As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lbl_Rol As Label
    Friend WithEvents lbl_Usuario As Label
End Class
