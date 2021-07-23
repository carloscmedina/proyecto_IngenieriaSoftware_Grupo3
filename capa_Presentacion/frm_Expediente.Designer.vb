<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Expediente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Expediente))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ConsultarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GrabarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModificarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CancelarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dtp_Fecha = New System.Windows.Forms.DateTimePicker()
        Me.lbl_Fecha = New System.Windows.Forms.Label()
        Me.txt_Nombre = New System.Windows.Forms.TextBox()
        Me.txt_Empleado = New System.Windows.Forms.TextBox()
        Me.txt_Numero = New System.Windows.Forms.TextBox()
        Me.lbl_Empleado = New System.Windows.Forms.Label()
        Me.lbl_Numero = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dgv_Datos = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lbl_Rol = New System.Windows.Forms.Label()
        Me.lbl_Usuario = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgv_Datos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConsultarToolStripMenuItem, Me.GrabarToolStripMenuItem, Me.ModificarToolStripMenuItem, Me.CancelarToolStripMenuItem, Me.EliminarToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(5, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(660, 28)
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
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dtp_Fecha)
        Me.GroupBox1.Controls.Add(Me.lbl_Fecha)
        Me.GroupBox1.Controls.Add(Me.txt_Nombre)
        Me.GroupBox1.Controls.Add(Me.txt_Empleado)
        Me.GroupBox1.Controls.Add(Me.txt_Numero)
        Me.GroupBox1.Controls.Add(Me.lbl_Empleado)
        Me.GroupBox1.Controls.Add(Me.lbl_Numero)
        Me.GroupBox1.Location = New System.Drawing.Point(10, 23)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(553, 71)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
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
        'txt_Nombre
        '
        Me.txt_Nombre.Location = New System.Drawing.Point(174, 38)
        Me.txt_Nombre.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_Nombre.Name = "txt_Nombre"
        Me.txt_Nombre.Size = New System.Drawing.Size(280, 23)
        Me.txt_Nombre.TabIndex = 10
        '
        'txt_Empleado
        '
        Me.txt_Empleado.Location = New System.Drawing.Point(96, 38)
        Me.txt_Empleado.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_Empleado.Name = "txt_Empleado"
        Me.txt_Empleado.Size = New System.Drawing.Size(73, 23)
        Me.txt_Empleado.TabIndex = 7
        '
        'txt_Numero
        '
        Me.txt_Numero.Location = New System.Drawing.Point(96, 12)
        Me.txt_Numero.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_Numero.Name = "txt_Numero"
        Me.txt_Numero.Size = New System.Drawing.Size(73, 23)
        Me.txt_Numero.TabIndex = 5
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
        'lbl_Numero
        '
        Me.lbl_Numero.AutoSize = True
        Me.lbl_Numero.Location = New System.Drawing.Point(13, 14)
        Me.lbl_Numero.Name = "lbl_Numero"
        Me.lbl_Numero.Size = New System.Drawing.Size(51, 15)
        Me.lbl_Numero.TabIndex = 0
        Me.lbl_Numero.Text = "Número"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dgv_Datos)
        Me.GroupBox2.Location = New System.Drawing.Point(10, 97)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox2.Size = New System.Drawing.Size(622, 185)
        Me.GroupBox2.TabIndex = 13
        Me.GroupBox2.TabStop = False
        '
        'dgv_Datos
        '
        Me.dgv_Datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_Datos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column4, Me.Column2, Me.Column3, Me.Column5})
        Me.dgv_Datos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv_Datos.Location = New System.Drawing.Point(3, 18)
        Me.dgv_Datos.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgv_Datos.Name = "dgv_Datos"
        Me.dgv_Datos.RowHeadersWidth = 51
        Me.dgv_Datos.RowTemplate.Height = 29
        Me.dgv_Datos.Size = New System.Drawing.Size(616, 165)
        Me.dgv_Datos.TabIndex = 0
        '
        'Column1
        '
        Me.Column1.HeaderText = "Cita"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 80
        '
        'Column4
        '
        Me.Column4.HeaderText = "Fecha"
        Me.Column4.MinimumWidth = 6
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 80
        '
        'Column2
        '
        Me.Column2.HeaderText = "Médico"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 200
        '
        'Column3
        '
        Me.Column3.HeaderText = "Diagnóstico"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 200
        '
        'Column5
        '
        Me.Column5.HeaderText = "Alta médica"
        Me.Column5.MinimumWidth = 6
        Me.Column5.Name = "Column5"
        Me.Column5.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Column5.Width = 60
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(64, 284)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(10, 15)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "|"
        '
        'lbl_Rol
        '
        Me.lbl_Rol.AutoSize = True
        Me.lbl_Rol.Location = New System.Drawing.Point(80, 284)
        Me.lbl_Rol.Name = "lbl_Rol"
        Me.lbl_Rol.Size = New System.Drawing.Size(21, 15)
        Me.lbl_Rol.TabIndex = 18
        Me.lbl_Rol.Text = "rol"
        '
        'lbl_Usuario
        '
        Me.lbl_Usuario.AutoSize = True
        Me.lbl_Usuario.Location = New System.Drawing.Point(13, 284)
        Me.lbl_Usuario.Name = "lbl_Usuario"
        Me.lbl_Usuario.Size = New System.Drawing.Size(46, 15)
        Me.lbl_Usuario.TabIndex = 17
        Me.lbl_Usuario.Text = "usuario"
        '
        'frm_Expediente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(660, 308)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lbl_Rol)
        Me.Controls.Add(Me.lbl_Usuario)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "frm_Expediente"
        Me.Text = "Expediente"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgv_Datos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ConsultarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GrabarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ModificarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CancelarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EliminarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dtp_Fecha As DateTimePicker
    Friend WithEvents lbl_Fecha As Label
    Friend WithEvents txt_Nombre As TextBox
    Friend WithEvents txt_Empleado As TextBox
    Friend WithEvents txt_Numero As TextBox
    Friend WithEvents lbl_Empleado As Label
    Friend WithEvents lbl_Numero As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents dgv_Datos As DataGridView
    Friend WithEvents Label7 As Label
    Friend WithEvents lbl_Rol As Label
    Friend WithEvents lbl_Usuario As Label
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewCheckBoxColumn
End Class
