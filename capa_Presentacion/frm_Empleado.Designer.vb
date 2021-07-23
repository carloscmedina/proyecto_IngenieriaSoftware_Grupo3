<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Empleado
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Empleado))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmb_Area = New System.Windows.Forms.ComboBox()
        Me.txt_IdEmpleado = New System.Windows.Forms.TextBox()
        Me.lbl_Area = New System.Windows.Forms.Label()
        Me.dtp_FechaNacimiento = New System.Windows.Forms.DateTimePicker()
        Me.txt_Nombres = New System.Windows.Forms.TextBox()
        Me.txt_Apellidos = New System.Windows.Forms.TextBox()
        Me.txt_Cedula = New System.Windows.Forms.TextBox()
        Me.lbl_FechaNacimiento = New System.Windows.Forms.Label()
        Me.lbl_Nombres = New System.Windows.Forms.Label()
        Me.lbl_Apellidos = New System.Windows.Forms.Label()
        Me.lbl_Cedula = New System.Windows.Forms.Label()
        Me.rdb_Inactivo = New System.Windows.Forms.RadioButton()
        Me.rdb_Activo = New System.Windows.Forms.RadioButton()
        Me.lbl_Estado = New System.Windows.Forms.Label()
        Me.lbl_IdEmpleado = New System.Windows.Forms.Label()
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
        Me.GroupBox1.Controls.Add(Me.cmb_Area)
        Me.GroupBox1.Controls.Add(Me.txt_IdEmpleado)
        Me.GroupBox1.Controls.Add(Me.lbl_Area)
        Me.GroupBox1.Controls.Add(Me.dtp_FechaNacimiento)
        Me.GroupBox1.Controls.Add(Me.txt_Nombres)
        Me.GroupBox1.Controls.Add(Me.txt_Apellidos)
        Me.GroupBox1.Controls.Add(Me.txt_Cedula)
        Me.GroupBox1.Controls.Add(Me.lbl_FechaNacimiento)
        Me.GroupBox1.Controls.Add(Me.lbl_Nombres)
        Me.GroupBox1.Controls.Add(Me.lbl_Apellidos)
        Me.GroupBox1.Controls.Add(Me.lbl_Cedula)
        Me.GroupBox1.Controls.Add(Me.rdb_Inactivo)
        Me.GroupBox1.Controls.Add(Me.rdb_Activo)
        Me.GroupBox1.Controls.Add(Me.lbl_Estado)
        Me.GroupBox1.Controls.Add(Me.lbl_IdEmpleado)
        Me.GroupBox1.Location = New System.Drawing.Point(10, 22)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(530, 198)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'cmb_Area
        '
        Me.cmb_Area.FormattingEnabled = True
        Me.cmb_Area.Location = New System.Drawing.Point(158, 165)
        Me.cmb_Area.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmb_Area.Name = "cmb_Area"
        Me.cmb_Area.Size = New System.Drawing.Size(358, 23)
        Me.cmb_Area.TabIndex = 23
        '
        'txt_IdEmpleado
        '
        Me.txt_IdEmpleado.Location = New System.Drawing.Point(158, 19)
        Me.txt_IdEmpleado.Name = "txt_IdEmpleado"
        Me.txt_IdEmpleado.Size = New System.Drawing.Size(121, 23)
        Me.txt_IdEmpleado.TabIndex = 22
        '
        'lbl_Area
        '
        Me.lbl_Area.AutoSize = True
        Me.lbl_Area.Location = New System.Drawing.Point(17, 165)
        Me.lbl_Area.Name = "lbl_Area"
        Me.lbl_Area.Size = New System.Drawing.Size(31, 15)
        Me.lbl_Area.TabIndex = 20
        Me.lbl_Area.Text = "Area"
        '
        'dtp_FechaNacimiento
        '
        Me.dtp_FechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_FechaNacimiento.Location = New System.Drawing.Point(158, 135)
        Me.dtp_FechaNacimiento.Name = "dtp_FechaNacimiento"
        Me.dtp_FechaNacimiento.Size = New System.Drawing.Size(121, 23)
        Me.dtp_FechaNacimiento.TabIndex = 18
        '
        'txt_Nombres
        '
        Me.txt_Nombres.Location = New System.Drawing.Point(158, 104)
        Me.txt_Nombres.Name = "txt_Nombres"
        Me.txt_Nombres.Size = New System.Drawing.Size(358, 23)
        Me.txt_Nombres.TabIndex = 17
        '
        'txt_Apellidos
        '
        Me.txt_Apellidos.Location = New System.Drawing.Point(158, 76)
        Me.txt_Apellidos.Name = "txt_Apellidos"
        Me.txt_Apellidos.Size = New System.Drawing.Size(358, 23)
        Me.txt_Apellidos.TabIndex = 16
        '
        'txt_Cedula
        '
        Me.txt_Cedula.Location = New System.Drawing.Point(158, 45)
        Me.txt_Cedula.Name = "txt_Cedula"
        Me.txt_Cedula.Size = New System.Drawing.Size(121, 23)
        Me.txt_Cedula.TabIndex = 15
        '
        'lbl_FechaNacimiento
        '
        Me.lbl_FechaNacimiento.AutoSize = True
        Me.lbl_FechaNacimiento.Location = New System.Drawing.Point(17, 139)
        Me.lbl_FechaNacimiento.Name = "lbl_FechaNacimiento"
        Me.lbl_FechaNacimiento.Size = New System.Drawing.Size(119, 15)
        Me.lbl_FechaNacimiento.TabIndex = 14
        Me.lbl_FechaNacimiento.Text = "Fecha de Nacimiento"
        '
        'lbl_Nombres
        '
        Me.lbl_Nombres.AutoSize = True
        Me.lbl_Nombres.Location = New System.Drawing.Point(17, 107)
        Me.lbl_Nombres.Name = "lbl_Nombres"
        Me.lbl_Nombres.Size = New System.Drawing.Size(56, 15)
        Me.lbl_Nombres.TabIndex = 13
        Me.lbl_Nombres.Text = "Nombres"
        '
        'lbl_Apellidos
        '
        Me.lbl_Apellidos.AutoSize = True
        Me.lbl_Apellidos.Location = New System.Drawing.Point(15, 79)
        Me.lbl_Apellidos.Name = "lbl_Apellidos"
        Me.lbl_Apellidos.Size = New System.Drawing.Size(56, 15)
        Me.lbl_Apellidos.TabIndex = 12
        Me.lbl_Apellidos.Text = "Apellidos"
        '
        'lbl_Cedula
        '
        Me.lbl_Cedula.AutoSize = True
        Me.lbl_Cedula.Location = New System.Drawing.Point(15, 48)
        Me.lbl_Cedula.Name = "lbl_Cedula"
        Me.lbl_Cedula.Size = New System.Drawing.Size(44, 15)
        Me.lbl_Cedula.TabIndex = 10
        Me.lbl_Cedula.Text = "Cédula"
        '
        'rdb_Inactivo
        '
        Me.rdb_Inactivo.AutoSize = True
        Me.rdb_Inactivo.Location = New System.Drawing.Point(397, 40)
        Me.rdb_Inactivo.Name = "rdb_Inactivo"
        Me.rdb_Inactivo.Size = New System.Drawing.Size(67, 19)
        Me.rdb_Inactivo.TabIndex = 5
        Me.rdb_Inactivo.TabStop = True
        Me.rdb_Inactivo.Text = "Inactivo"
        Me.rdb_Inactivo.UseVisualStyleBackColor = True
        '
        'rdb_Activo
        '
        Me.rdb_Activo.AutoSize = True
        Me.rdb_Activo.Location = New System.Drawing.Point(397, 16)
        Me.rdb_Activo.Name = "rdb_Activo"
        Me.rdb_Activo.Size = New System.Drawing.Size(59, 19)
        Me.rdb_Activo.TabIndex = 4
        Me.rdb_Activo.TabStop = True
        Me.rdb_Activo.Text = "Activo"
        Me.rdb_Activo.UseVisualStyleBackColor = True
        '
        'lbl_Estado
        '
        Me.lbl_Estado.AutoSize = True
        Me.lbl_Estado.Location = New System.Drawing.Point(334, 19)
        Me.lbl_Estado.Name = "lbl_Estado"
        Me.lbl_Estado.Size = New System.Drawing.Size(42, 15)
        Me.lbl_Estado.TabIndex = 1
        Me.lbl_Estado.Text = "Estado"
        '
        'lbl_IdEmpleado
        '
        Me.lbl_IdEmpleado.AutoSize = True
        Me.lbl_IdEmpleado.Location = New System.Drawing.Point(17, 21)
        Me.lbl_IdEmpleado.Name = "lbl_IdEmpleado"
        Me.lbl_IdEmpleado.Size = New System.Drawing.Size(73, 15)
        Me.lbl_IdEmpleado.TabIndex = 0
        Me.lbl_IdEmpleado.Text = "Id Empleado"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConsultarToolStripMenuItem, Me.GrabarToolStripMenuItem, Me.ModificarToolStripMenuItem, Me.CancelarToolStripMenuItem, Me.EliminarToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(5, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(556, 28)
        Me.MenuStrip1.TabIndex = 12
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
        Me.Label7.Location = New System.Drawing.Point(63, 225)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(10, 15)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "|"
        '
        'lbl_Rol
        '
        Me.lbl_Rol.AutoSize = True
        Me.lbl_Rol.Location = New System.Drawing.Point(80, 225)
        Me.lbl_Rol.Name = "lbl_Rol"
        Me.lbl_Rol.Size = New System.Drawing.Size(21, 15)
        Me.lbl_Rol.TabIndex = 15
        Me.lbl_Rol.Text = "rol"
        '
        'lbl_Usuario
        '
        Me.lbl_Usuario.AutoSize = True
        Me.lbl_Usuario.Location = New System.Drawing.Point(12, 225)
        Me.lbl_Usuario.Name = "lbl_Usuario"
        Me.lbl_Usuario.Size = New System.Drawing.Size(46, 15)
        Me.lbl_Usuario.TabIndex = 14
        Me.lbl_Usuario.Text = "usuario"
        '
        'frm_Empleado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(556, 244)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lbl_Rol)
        Me.Controls.Add(Me.lbl_Usuario)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frm_Empleado"
        Me.Text = "Mantenimiento de Empleados"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txt_IdEmpleado As TextBox
    Friend WithEvents lbl_Area As Label
    Friend WithEvents dtp_FechaNacimiento As DateTimePicker
    Friend WithEvents txt_Nombres As TextBox
    Friend WithEvents txt_Apellidos As TextBox
    Friend WithEvents txt_Cedula As TextBox
    Friend WithEvents lbl_FechaNacimiento As Label
    Friend WithEvents lbl_Nombres As Label
    Friend WithEvents lbl_Apellidos As Label
    Friend WithEvents lbl_Cedula As Label
    Friend WithEvents rdb_Inactivo As RadioButton
    Friend WithEvents rdb_Activo As RadioButton
    Friend WithEvents lbl_Estado As Label
    Friend WithEvents lbl_IdEmpleado As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ConsultarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GrabarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ModificarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CancelarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EliminarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents cmb_Area As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents lbl_Rol As Label
    Friend WithEvents lbl_Usuario As Label
End Class
