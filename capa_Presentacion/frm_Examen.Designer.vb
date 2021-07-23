<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Examen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Examen))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmb_Diagnostico = New System.Windows.Forms.ComboBox()
        Me.dtp_Fecha = New System.Windows.Forms.DateTimePicker()
        Me.lbl_Fecha = New System.Windows.Forms.Label()
        Me.cmb_Medico = New System.Windows.Forms.ComboBox()
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.txt_Empleado = New System.Windows.Forms.TextBox()
        Me.txt_Id = New System.Windows.Forms.TextBox()
        Me.txt_Descripcion = New System.Windows.Forms.TextBox()
        Me.lbl_Diagnostico = New System.Windows.Forms.Label()
        Me.lbl_Medico = New System.Windows.Forms.Label()
        Me.lbl_Empleado = New System.Windows.Forms.Label()
        Me.lbl_Id = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.NuevoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GrabarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModificarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CancelarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lbl_Usuario = New System.Windows.Forms.Label()
        Me.lbl_Rol = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmb_Diagnostico)
        Me.GroupBox1.Controls.Add(Me.dtp_Fecha)
        Me.GroupBox1.Controls.Add(Me.lbl_Fecha)
        Me.GroupBox1.Controls.Add(Me.cmb_Medico)
        Me.GroupBox1.Controls.Add(Me.txt_nombre)
        Me.GroupBox1.Controls.Add(Me.txt_Empleado)
        Me.GroupBox1.Controls.Add(Me.txt_Id)
        Me.GroupBox1.Controls.Add(Me.txt_Descripcion)
        Me.GroupBox1.Controls.Add(Me.lbl_Diagnostico)
        Me.GroupBox1.Controls.Add(Me.lbl_Medico)
        Me.GroupBox1.Controls.Add(Me.lbl_Empleado)
        Me.GroupBox1.Controls.Add(Me.lbl_Id)
        Me.GroupBox1.Location = New System.Drawing.Point(10, 23)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(481, 215)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'cmb_Diagnostico
        '
        Me.cmb_Diagnostico.FormattingEnabled = True
        Me.cmb_Diagnostico.Location = New System.Drawing.Point(96, 92)
        Me.cmb_Diagnostico.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmb_Diagnostico.Name = "cmb_Diagnostico"
        Me.cmb_Diagnostico.Size = New System.Drawing.Size(73, 23)
        Me.cmb_Diagnostico.TabIndex = 14
        '
        'dtp_Fecha
        '
        Me.dtp_Fecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_Fecha.Location = New System.Drawing.Point(349, 12)
        Me.dtp_Fecha.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dtp_Fecha.Name = "dtp_Fecha"
        Me.dtp_Fecha.Size = New System.Drawing.Size(106, 23)
        Me.dtp_Fecha.TabIndex = 13
        '
        'lbl_Fecha
        '
        Me.lbl_Fecha.AutoSize = True
        Me.lbl_Fecha.Location = New System.Drawing.Point(303, 14)
        Me.lbl_Fecha.Name = "lbl_Fecha"
        Me.lbl_Fecha.Size = New System.Drawing.Size(38, 15)
        Me.lbl_Fecha.TabIndex = 12
        Me.lbl_Fecha.Text = "Fecha"
        '
        'cmb_Medico
        '
        Me.cmb_Medico.FormattingEnabled = True
        Me.cmb_Medico.Location = New System.Drawing.Point(96, 66)
        Me.cmb_Medico.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmb_Medico.Name = "cmb_Medico"
        Me.cmb_Medico.Size = New System.Drawing.Size(358, 23)
        Me.cmb_Medico.TabIndex = 11
        '
        'txt_nombre
        '
        Me.txt_nombre.Location = New System.Drawing.Point(174, 38)
        Me.txt_nombre.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(280, 23)
        Me.txt_nombre.TabIndex = 10
        '
        'txt_Empleado
        '
        Me.txt_Empleado.Location = New System.Drawing.Point(96, 38)
        Me.txt_Empleado.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_Empleado.Name = "txt_Empleado"
        Me.txt_Empleado.Size = New System.Drawing.Size(73, 23)
        Me.txt_Empleado.TabIndex = 7
        '
        'txt_Id
        '
        Me.txt_Id.Location = New System.Drawing.Point(96, 12)
        Me.txt_Id.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_Id.Name = "txt_Id"
        Me.txt_Id.Size = New System.Drawing.Size(73, 23)
        Me.txt_Id.TabIndex = 5
        '
        'txt_Descripcion
        '
        Me.txt_Descripcion.Location = New System.Drawing.Point(96, 119)
        Me.txt_Descripcion.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_Descripcion.Multiline = True
        Me.txt_Descripcion.Name = "txt_Descripcion"
        Me.txt_Descripcion.Size = New System.Drawing.Size(358, 87)
        Me.txt_Descripcion.TabIndex = 4
        '
        'lbl_Diagnostico
        '
        Me.lbl_Diagnostico.AutoSize = True
        Me.lbl_Diagnostico.Location = New System.Drawing.Point(13, 94)
        Me.lbl_Diagnostico.Name = "lbl_Diagnostico"
        Me.lbl_Diagnostico.Size = New System.Drawing.Size(70, 15)
        Me.lbl_Diagnostico.TabIndex = 3
        Me.lbl_Diagnostico.Text = "Diagnóstico"
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
        'lbl_Id
        '
        Me.lbl_Id.AutoSize = True
        Me.lbl_Id.Location = New System.Drawing.Point(13, 14)
        Me.lbl_Id.Name = "lbl_Id"
        Me.lbl_Id.Size = New System.Drawing.Size(17, 15)
        Me.lbl_Id.TabIndex = 0
        Me.lbl_Id.Text = "Id"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoToolStripMenuItem, Me.ConsultarToolStripMenuItem, Me.GrabarToolStripMenuItem, Me.ModificarToolStripMenuItem, Me.CancelarToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(5, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(741, 28)
        Me.MenuStrip1.TabIndex = 10
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'NuevoToolStripMenuItem
        '
        Me.NuevoToolStripMenuItem.Image = CType(resources.GetObject("NuevoToolStripMenuItem.Image"), System.Drawing.Image)
        Me.NuevoToolStripMenuItem.Name = "NuevoToolStripMenuItem"
        Me.NuevoToolStripMenuItem.Size = New System.Drawing.Size(74, 24)
        Me.NuevoToolStripMenuItem.Text = "Nuevo"
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
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Image = CType(resources.GetObject("SalirToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(61, 24)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'lbl_Usuario
        '
        Me.lbl_Usuario.AutoSize = True
        Me.lbl_Usuario.Location = New System.Drawing.Point(10, 241)
        Me.lbl_Usuario.Name = "lbl_Usuario"
        Me.lbl_Usuario.Size = New System.Drawing.Size(46, 15)
        Me.lbl_Usuario.TabIndex = 11
        Me.lbl_Usuario.Text = "usuario"
        '
        'lbl_Rol
        '
        Me.lbl_Rol.AutoSize = True
        Me.lbl_Rol.Location = New System.Drawing.Point(78, 241)
        Me.lbl_Rol.Name = "lbl_Rol"
        Me.lbl_Rol.Size = New System.Drawing.Size(21, 15)
        Me.lbl_Rol.TabIndex = 12
        Me.lbl_Rol.Text = "rol"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(61, 241)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(10, 15)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "|"
        '
        'frm_Examen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(741, 260)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lbl_Rol)
        Me.Controls.Add(Me.lbl_Usuario)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "frm_Examen"
        Me.Text = "Examen"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lbl_Medico As Label
    Friend WithEvents lbl_Empleado As Label
    Friend WithEvents lbl_Id As Label
    Friend WithEvents txt_nombre As TextBox
    Friend WithEvents txt_Empleado As TextBox
    Friend WithEvents txt_Id As TextBox
    Friend WithEvents txt_Descripcion As TextBox
    Friend WithEvents lbl_Diagnostico As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ConsultarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GrabarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ModificarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CancelarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents dtp_Fecha As DateTimePicker
    Friend WithEvents lbl_Fecha As Label
    Friend WithEvents cmb_Medico As ComboBox
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lbl_Usuario As Label
    Friend WithEvents lbl_Rol As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents cmb_Diagnostico As ComboBox
    Friend WithEvents NuevoToolStripMenuItem As ToolStripMenuItem
End Class
