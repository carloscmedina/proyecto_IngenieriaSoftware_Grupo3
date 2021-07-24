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
        Me.txt_IdMedico = New System.Windows.Forms.TextBox()
        Me.txt_RegistroMedico = New System.Windows.Forms.TextBox()
        Me.lbl_RegistroMedico = New System.Windows.Forms.Label()
        Me.dtp_FechaDeNacimiento = New System.Windows.Forms.DateTimePicker()
        Me.txt_Apellidos = New System.Windows.Forms.TextBox()
        Me.txt_Nombres = New System.Windows.Forms.TextBox()
        Me.txt_Cedula = New System.Windows.Forms.TextBox()
        Me.lbl_FechaDeNacimiento = New System.Windows.Forms.Label()
        Me.lbl_Nombres = New System.Windows.Forms.Label()
        Me.lbl_Apellidos = New System.Windows.Forms.Label()
        Me.lbl_Cedula = New System.Windows.Forms.Label()
        Me.rdb_Inactivo = New System.Windows.Forms.RadioButton()
        Me.rdb_Activo = New System.Windows.Forms.RadioButton()
        Me.lbl_Estado = New System.Windows.Forms.Label()
        Me.lbl_Medico = New System.Windows.Forms.Label()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.lbl_Separador = New System.Windows.Forms.Label()
        Me.lbl_Rol = New System.Windows.Forms.Label()
        Me.lbl_Usuario = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.NuevoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GrabarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModificarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CancelarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txt_IdMedico)
        Me.GroupBox1.Controls.Add(Me.txt_RegistroMedico)
        Me.GroupBox1.Controls.Add(Me.lbl_RegistroMedico)
        Me.GroupBox1.Controls.Add(Me.dtp_FechaDeNacimiento)
        Me.GroupBox1.Controls.Add(Me.txt_Apellidos)
        Me.GroupBox1.Controls.Add(Me.txt_Nombres)
        Me.GroupBox1.Controls.Add(Me.txt_Cedula)
        Me.GroupBox1.Controls.Add(Me.lbl_FechaDeNacimiento)
        Me.GroupBox1.Controls.Add(Me.lbl_Nombres)
        Me.GroupBox1.Controls.Add(Me.lbl_Apellidos)
        Me.GroupBox1.Controls.Add(Me.lbl_Cedula)
        Me.GroupBox1.Controls.Add(Me.rdb_Inactivo)
        Me.GroupBox1.Controls.Add(Me.rdb_Activo)
        Me.GroupBox1.Controls.Add(Me.lbl_Estado)
        Me.GroupBox1.Controls.Add(Me.lbl_Medico)
        Me.GroupBox1.Location = New System.Drawing.Point(10, 26)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(606, 264)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'txt_IdMedico
        '
        Me.txt_IdMedico.Location = New System.Drawing.Point(180, 61)
        Me.txt_IdMedico.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_IdMedico.Name = "txt_IdMedico"
        Me.txt_IdMedico.Size = New System.Drawing.Size(138, 27)
        Me.txt_IdMedico.TabIndex = 22
        '
        'txt_RegistroMedico
        '
        Me.txt_RegistroMedico.Location = New System.Drawing.Point(180, 21)
        Me.txt_RegistroMedico.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_RegistroMedico.Name = "txt_RegistroMedico"
        Me.txt_RegistroMedico.Size = New System.Drawing.Size(138, 27)
        Me.txt_RegistroMedico.TabIndex = 21
        '
        'lbl_RegistroMedico
        '
        Me.lbl_RegistroMedico.AutoSize = True
        Me.lbl_RegistroMedico.Location = New System.Drawing.Point(17, 24)
        Me.lbl_RegistroMedico.Name = "lbl_RegistroMedico"
        Me.lbl_RegistroMedico.Size = New System.Drawing.Size(139, 20)
        Me.lbl_RegistroMedico.TabIndex = 20
        Me.lbl_RegistroMedico.Text = "N° Registro Médico"
        '
        'dtp_FechaDeNacimiento
        '
        Me.dtp_FechaDeNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_FechaDeNacimiento.Location = New System.Drawing.Point(180, 223)
        Me.dtp_FechaDeNacimiento.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dtp_FechaDeNacimiento.Name = "dtp_FechaDeNacimiento"
        Me.dtp_FechaDeNacimiento.Size = New System.Drawing.Size(138, 27)
        Me.dtp_FechaDeNacimiento.TabIndex = 18
        '
        'txt_Apellidos
        '
        Me.txt_Apellidos.Location = New System.Drawing.Point(180, 178)
        Me.txt_Apellidos.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_Apellidos.Name = "txt_Apellidos"
        Me.txt_Apellidos.Size = New System.Drawing.Size(409, 27)
        Me.txt_Apellidos.TabIndex = 17
        '
        'txt_Nombres
        '
        Me.txt_Nombres.Location = New System.Drawing.Point(180, 140)
        Me.txt_Nombres.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_Nombres.Name = "txt_Nombres"
        Me.txt_Nombres.Size = New System.Drawing.Size(409, 27)
        Me.txt_Nombres.TabIndex = 16
        '
        'txt_Cedula
        '
        Me.txt_Cedula.Location = New System.Drawing.Point(180, 99)
        Me.txt_Cedula.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_Cedula.Name = "txt_Cedula"
        Me.txt_Cedula.Size = New System.Drawing.Size(138, 27)
        Me.txt_Cedula.TabIndex = 15
        '
        'lbl_FechaDeNacimiento
        '
        Me.lbl_FechaDeNacimiento.AutoSize = True
        Me.lbl_FechaDeNacimiento.Location = New System.Drawing.Point(19, 228)
        Me.lbl_FechaDeNacimiento.Name = "lbl_FechaDeNacimiento"
        Me.lbl_FechaDeNacimiento.Size = New System.Drawing.Size(149, 20)
        Me.lbl_FechaDeNacimiento.TabIndex = 14
        Me.lbl_FechaDeNacimiento.Text = "Fecha de Nacimiento"
        '
        'lbl_Nombres
        '
        Me.lbl_Nombres.AutoSize = True
        Me.lbl_Nombres.Location = New System.Drawing.Point(19, 181)
        Me.lbl_Nombres.Name = "lbl_Nombres"
        Me.lbl_Nombres.Size = New System.Drawing.Size(70, 20)
        Me.lbl_Nombres.TabIndex = 13
        Me.lbl_Nombres.Text = "Nombres"
        '
        'lbl_Apellidos
        '
        Me.lbl_Apellidos.AutoSize = True
        Me.lbl_Apellidos.Location = New System.Drawing.Point(17, 143)
        Me.lbl_Apellidos.Name = "lbl_Apellidos"
        Me.lbl_Apellidos.Size = New System.Drawing.Size(72, 20)
        Me.lbl_Apellidos.TabIndex = 12
        Me.lbl_Apellidos.Text = "Apellidos"
        '
        'lbl_Cedula
        '
        Me.lbl_Cedula.AutoSize = True
        Me.lbl_Cedula.Location = New System.Drawing.Point(17, 102)
        Me.lbl_Cedula.Name = "lbl_Cedula"
        Me.lbl_Cedula.Size = New System.Drawing.Size(55, 20)
        Me.lbl_Cedula.TabIndex = 10
        Me.lbl_Cedula.Text = "Cédula"
        '
        'rdb_Inactivo
        '
        Me.rdb_Inactivo.AutoSize = True
        Me.rdb_Inactivo.Location = New System.Drawing.Point(454, 52)
        Me.rdb_Inactivo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.rdb_Inactivo.Name = "rdb_Inactivo"
        Me.rdb_Inactivo.Size = New System.Drawing.Size(82, 24)
        Me.rdb_Inactivo.TabIndex = 5
        Me.rdb_Inactivo.TabStop = True
        Me.rdb_Inactivo.Text = "Inactivo"
        Me.rdb_Inactivo.UseVisualStyleBackColor = True
        '
        'rdb_Activo
        '
        Me.rdb_Activo.AutoSize = True
        Me.rdb_Activo.Location = New System.Drawing.Point(454, 20)
        Me.rdb_Activo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.rdb_Activo.Name = "rdb_Activo"
        Me.rdb_Activo.Size = New System.Drawing.Size(72, 24)
        Me.rdb_Activo.TabIndex = 4
        Me.rdb_Activo.TabStop = True
        Me.rdb_Activo.Text = "Activo"
        Me.rdb_Activo.UseVisualStyleBackColor = True
        '
        'lbl_Estado
        '
        Me.lbl_Estado.AutoSize = True
        Me.lbl_Estado.Location = New System.Drawing.Point(382, 24)
        Me.lbl_Estado.Name = "lbl_Estado"
        Me.lbl_Estado.Size = New System.Drawing.Size(54, 20)
        Me.lbl_Estado.TabIndex = 1
        Me.lbl_Estado.Text = "Estado"
        '
        'lbl_Medico
        '
        Me.lbl_Medico.AutoSize = True
        Me.lbl_Medico.Location = New System.Drawing.Point(17, 64)
        Me.lbl_Medico.Name = "lbl_Medico"
        Me.lbl_Medico.Size = New System.Drawing.Size(78, 20)
        Me.lbl_Medico.TabIndex = 0
        Me.lbl_Medico.Text = "ID Médico"
        '
        'lbl_Separador
        '
        Me.lbl_Separador.AutoSize = True
        Me.lbl_Separador.Location = New System.Drawing.Point(70, 294)
        Me.lbl_Separador.Name = "lbl_Separador"
        Me.lbl_Separador.Size = New System.Drawing.Size(13, 20)
        Me.lbl_Separador.TabIndex = 16
        Me.lbl_Separador.Text = "|"
        '
        'lbl_Rol
        '
        Me.lbl_Rol.AutoSize = True
        Me.lbl_Rol.Location = New System.Drawing.Point(89, 294)
        Me.lbl_Rol.Name = "lbl_Rol"
        Me.lbl_Rol.Size = New System.Drawing.Size(27, 20)
        Me.lbl_Rol.TabIndex = 15
        Me.lbl_Rol.Text = "rol"
        '
        'lbl_Usuario
        '
        Me.lbl_Usuario.AutoSize = True
        Me.lbl_Usuario.Location = New System.Drawing.Point(12, 294)
        Me.lbl_Usuario.Name = "lbl_Usuario"
        Me.lbl_Usuario.Size = New System.Drawing.Size(57, 20)
        Me.lbl_Usuario.TabIndex = 14
        Me.lbl_Usuario.Text = "usuario"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoToolStripMenuItem, Me.ConsultarToolStripMenuItem, Me.GrabarToolStripMenuItem, Me.ModificarToolStripMenuItem, Me.CancelarToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(6, 3, 0, 3)
        Me.MenuStrip1.Size = New System.Drawing.Size(624, 30)
        Me.MenuStrip1.TabIndex = 17
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'NuevoToolStripMenuItem
        '
        Me.NuevoToolStripMenuItem.Image = CType(resources.GetObject("NuevoToolStripMenuItem.Image"), System.Drawing.Image)
        Me.NuevoToolStripMenuItem.Name = "NuevoToolStripMenuItem"
        Me.NuevoToolStripMenuItem.Size = New System.Drawing.Size(86, 24)
        Me.NuevoToolStripMenuItem.Text = "Nuevo"
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
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Image = CType(resources.GetObject("SalirToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(72, 24)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'frm_Medico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(624, 320)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.lbl_Separador)
        Me.Controls.Add(Me.lbl_Rol)
        Me.Controls.Add(Me.lbl_Usuario)
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
    Friend WithEvents lbl_Estado As Label
    Friend WithEvents lbl_Medico As Label
    Friend WithEvents rdb_Inactivo As RadioButton
    Friend WithEvents rdb_Activo As RadioButton
    Friend WithEvents lbl_Cedula As Label
    Friend WithEvents lbl_Nombres As Label
    Friend WithEvents lbl_Apellidos As Label
    Friend WithEvents lbl_FechaDeNacimiento As Label
    Friend WithEvents txt_Nombres As TextBox
    Friend WithEvents txt_Cedula As TextBox
    Friend WithEvents txt_RegistroMedico As TextBox
    Friend WithEvents lbl_RegistroMedico As Label
    Friend WithEvents dtp_FechaDeNacimiento As DateTimePicker
    Friend WithEvents txt_Apellidos As TextBox
    Friend WithEvents txt_IdMedico As TextBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents lbl_Separador As Label
    Friend WithEvents lbl_Rol As Label
    Friend WithEvents lbl_Usuario As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents NuevoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GrabarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ModificarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CancelarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
End Class
