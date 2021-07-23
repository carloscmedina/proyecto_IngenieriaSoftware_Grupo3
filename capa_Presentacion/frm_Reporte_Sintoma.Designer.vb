<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Reporte_Sintoma
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Reporte_Sintoma))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dtp_Fecha = New System.Windows.Forms.DateTimePicker()
        Me.lbl_Fecha = New System.Windows.Forms.Label()
        Me.txtEmpleado = New System.Windows.Forms.TextBox()
        Me.txt_Empleado = New System.Windows.Forms.TextBox()
        Me.lbl_Empleado = New System.Windows.Forms.Label()
        Me.txt_IdReporte = New System.Windows.Forms.TextBox()
        Me.lbl_IdReporte = New System.Windows.Forms.Label()
        Me.txt_Descripcion = New System.Windows.Forms.TextBox()
        Me.lbl_Descripcion = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ConsultarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GrabarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModificarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CancelarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lbl_Separador = New System.Windows.Forms.Label()
        Me.lbl_Rol = New System.Windows.Forms.Label()
        Me.lbl_Uuario = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dtp_Fecha)
        Me.GroupBox1.Controls.Add(Me.lbl_Fecha)
        Me.GroupBox1.Controls.Add(Me.txtEmpleado)
        Me.GroupBox1.Controls.Add(Me.txt_Empleado)
        Me.GroupBox1.Controls.Add(Me.lbl_Empleado)
        Me.GroupBox1.Controls.Add(Me.txt_IdReporte)
        Me.GroupBox1.Controls.Add(Me.lbl_IdReporte)
        Me.GroupBox1.Controls.Add(Me.txt_Descripcion)
        Me.GroupBox1.Controls.Add(Me.lbl_Descripcion)
        Me.GroupBox1.Location = New System.Drawing.Point(10, 24)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(531, 136)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'dtp_Fecha
        '
        Me.dtp_Fecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_Fecha.Location = New System.Drawing.Point(407, 14)
        Me.dtp_Fecha.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dtp_Fecha.Name = "dtp_Fecha"
        Me.dtp_Fecha.Size = New System.Drawing.Size(106, 23)
        Me.dtp_Fecha.TabIndex = 26
        '
        'lbl_Fecha
        '
        Me.lbl_Fecha.AutoSize = True
        Me.lbl_Fecha.Location = New System.Drawing.Point(360, 17)
        Me.lbl_Fecha.Name = "lbl_Fecha"
        Me.lbl_Fecha.Size = New System.Drawing.Size(38, 15)
        Me.lbl_Fecha.TabIndex = 25
        Me.lbl_Fecha.Text = "Fecha"
        '
        'txtEmpleado
        '
        Me.txtEmpleado.Location = New System.Drawing.Point(176, 43)
        Me.txtEmpleado.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtEmpleado.Name = "txtEmpleado"
        Me.txtEmpleado.Size = New System.Drawing.Size(336, 23)
        Me.txtEmpleado.TabIndex = 24
        '
        'txt_Empleado
        '
        Me.txt_Empleado.Location = New System.Drawing.Point(99, 43)
        Me.txt_Empleado.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_Empleado.Name = "txt_Empleado"
        Me.txt_Empleado.Size = New System.Drawing.Size(73, 23)
        Me.txt_Empleado.TabIndex = 23
        '
        'lbl_Empleado
        '
        Me.lbl_Empleado.AutoSize = True
        Me.lbl_Empleado.Location = New System.Drawing.Point(15, 43)
        Me.lbl_Empleado.Name = "lbl_Empleado"
        Me.lbl_Empleado.Size = New System.Drawing.Size(60, 15)
        Me.lbl_Empleado.TabIndex = 22
        Me.lbl_Empleado.Text = "Empleado"
        '
        'txt_IdReporte
        '
        Me.txt_IdReporte.Location = New System.Drawing.Point(99, 18)
        Me.txt_IdReporte.Name = "txt_IdReporte"
        Me.txt_IdReporte.Size = New System.Drawing.Size(73, 23)
        Me.txt_IdReporte.TabIndex = 21
        '
        'lbl_IdReporte
        '
        Me.lbl_IdReporte.AutoSize = True
        Me.lbl_IdReporte.Location = New System.Drawing.Point(15, 19)
        Me.lbl_IdReporte.Name = "lbl_IdReporte"
        Me.lbl_IdReporte.Size = New System.Drawing.Size(62, 15)
        Me.lbl_IdReporte.TabIndex = 20
        Me.lbl_IdReporte.Text = "ID Reporte"
        '
        'txt_Descripcion
        '
        Me.txt_Descripcion.Location = New System.Drawing.Point(99, 69)
        Me.txt_Descripcion.Multiline = True
        Me.txt_Descripcion.Name = "txt_Descripcion"
        Me.txt_Descripcion.Size = New System.Drawing.Size(414, 57)
        Me.txt_Descripcion.TabIndex = 15
        '
        'lbl_Descripcion
        '
        Me.lbl_Descripcion.AutoSize = True
        Me.lbl_Descripcion.Location = New System.Drawing.Point(15, 71)
        Me.lbl_Descripcion.Name = "lbl_Descripcion"
        Me.lbl_Descripcion.Size = New System.Drawing.Size(69, 15)
        Me.lbl_Descripcion.TabIndex = 10
        Me.lbl_Descripcion.Text = "Descripción"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConsultarToolStripMenuItem, Me.GrabarToolStripMenuItem, Me.ModificarToolStripMenuItem, Me.CancelarToolStripMenuItem, Me.EliminarToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(6, 1, 0, 1)
        Me.MenuStrip1.Size = New System.Drawing.Size(550, 26)
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
        'lbl_Separador
        '
        Me.lbl_Separador.AutoSize = True
        Me.lbl_Separador.Location = New System.Drawing.Point(62, 163)
        Me.lbl_Separador.Name = "lbl_Separador"
        Me.lbl_Separador.Size = New System.Drawing.Size(10, 15)
        Me.lbl_Separador.TabIndex = 19
        Me.lbl_Separador.Text = "|"
        '
        'lbl_Rol
        '
        Me.lbl_Rol.AutoSize = True
        Me.lbl_Rol.Location = New System.Drawing.Point(78, 163)
        Me.lbl_Rol.Name = "lbl_Rol"
        Me.lbl_Rol.Size = New System.Drawing.Size(21, 15)
        Me.lbl_Rol.TabIndex = 18
        Me.lbl_Rol.Text = "rol"
        '
        'lbl_Uuario
        '
        Me.lbl_Uuario.AutoSize = True
        Me.lbl_Uuario.Location = New System.Drawing.Point(10, 163)
        Me.lbl_Uuario.Name = "lbl_Uuario"
        Me.lbl_Uuario.Size = New System.Drawing.Size(46, 15)
        Me.lbl_Uuario.TabIndex = 17
        Me.lbl_Uuario.Text = "usuario"
        '
        'frm_Reporte_Sintoma
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(550, 188)
        Me.Controls.Add(Me.lbl_Separador)
        Me.Controls.Add(Me.lbl_Rol)
        Me.Controls.Add(Me.lbl_Uuario)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.Name = "frm_Reporte_Sintoma"
        Me.Text = "Reporte de síntoma"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txt_IdReporte As TextBox
    Friend WithEvents lbl_IdReporte As Label
    Friend WithEvents txt_Descripcion As TextBox
    Friend WithEvents lbl_Descripcion As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ConsultarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GrabarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ModificarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CancelarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EliminarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents txtEmpleado As TextBox
    Friend WithEvents txt_Empleado As TextBox
    Friend WithEvents lbl_Empleado As Label
    Friend WithEvents dtp_Fecha As DateTimePicker
    Friend WithEvents lbl_Fecha As Label
    Friend WithEvents lbl_Separador As Label
    Friend WithEvents lbl_Rol As Label
    Friend WithEvents lbl_Uuario As Label
End Class
