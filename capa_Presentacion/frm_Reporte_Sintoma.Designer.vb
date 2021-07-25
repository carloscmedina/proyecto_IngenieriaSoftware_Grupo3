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
        Me.txt_Empleado = New System.Windows.Forms.TextBox()
        Me.txt_IdEmpleado = New System.Windows.Forms.TextBox()
        Me.lbl_Empleado = New System.Windows.Forms.Label()
        Me.txt_Id = New System.Windows.Forms.TextBox()
        Me.lbl_IdReporte = New System.Windows.Forms.Label()
        Me.txt_Descripcion = New System.Windows.Forms.TextBox()
        Me.lbl_Descripcion = New System.Windows.Forms.Label()
        Me.lbl_Separador = New System.Windows.Forms.Label()
        Me.lbl_Rol = New System.Windows.Forms.Label()
        Me.lbl_Uuario = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.tsm_Nuevo = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsm_Consultar = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsm_Grabar = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsm_Modificar = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsm_Cancelar = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsm_Salir = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dtp_Fecha)
        Me.GroupBox1.Controls.Add(Me.lbl_Fecha)
        Me.GroupBox1.Controls.Add(Me.txt_Empleado)
        Me.GroupBox1.Controls.Add(Me.txt_IdEmpleado)
        Me.GroupBox1.Controls.Add(Me.lbl_Empleado)
        Me.GroupBox1.Controls.Add(Me.txt_Id)
        Me.GroupBox1.Controls.Add(Me.lbl_IdReporte)
        Me.GroupBox1.Controls.Add(Me.txt_Descripcion)
        Me.GroupBox1.Controls.Add(Me.lbl_Descripcion)
        Me.GroupBox1.Location = New System.Drawing.Point(11, 32)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(607, 181)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'dtp_Fecha
        '
        Me.dtp_Fecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_Fecha.Location = New System.Drawing.Point(465, 19)
        Me.dtp_Fecha.Name = "dtp_Fecha"
        Me.dtp_Fecha.Size = New System.Drawing.Size(121, 27)
        Me.dtp_Fecha.TabIndex = 26
        '
        'lbl_Fecha
        '
        Me.lbl_Fecha.AutoSize = True
        Me.lbl_Fecha.Location = New System.Drawing.Point(411, 23)
        Me.lbl_Fecha.Name = "lbl_Fecha"
        Me.lbl_Fecha.Size = New System.Drawing.Size(47, 20)
        Me.lbl_Fecha.TabIndex = 25
        Me.lbl_Fecha.Text = "Fecha"
        '
        'txt_Empleado
        '
        Me.txt_Empleado.Location = New System.Drawing.Point(201, 57)
        Me.txt_Empleado.Name = "txt_Empleado"
        Me.txt_Empleado.Size = New System.Drawing.Size(383, 27)
        Me.txt_Empleado.TabIndex = 24
        '
        'txt_IdEmpleado
        '
        Me.txt_IdEmpleado.Location = New System.Drawing.Point(113, 57)
        Me.txt_IdEmpleado.Name = "txt_IdEmpleado"
        Me.txt_IdEmpleado.Size = New System.Drawing.Size(83, 27)
        Me.txt_IdEmpleado.TabIndex = 23
        '
        'lbl_Empleado
        '
        Me.lbl_Empleado.AutoSize = True
        Me.lbl_Empleado.Location = New System.Drawing.Point(17, 57)
        Me.lbl_Empleado.Name = "lbl_Empleado"
        Me.lbl_Empleado.Size = New System.Drawing.Size(77, 20)
        Me.lbl_Empleado.TabIndex = 22
        Me.lbl_Empleado.Text = "Empleado"
        '
        'txt_Id
        '
        Me.txt_Id.Location = New System.Drawing.Point(113, 24)
        Me.txt_Id.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_Id.Name = "txt_Id"
        Me.txt_Id.Size = New System.Drawing.Size(83, 27)
        Me.txt_Id.TabIndex = 21
        '
        'lbl_IdReporte
        '
        Me.lbl_IdReporte.AutoSize = True
        Me.lbl_IdReporte.Location = New System.Drawing.Point(17, 25)
        Me.lbl_IdReporte.Name = "lbl_IdReporte"
        Me.lbl_IdReporte.Size = New System.Drawing.Size(22, 20)
        Me.lbl_IdReporte.TabIndex = 20
        Me.lbl_IdReporte.Text = "Id"
        '
        'txt_Descripcion
        '
        Me.txt_Descripcion.Location = New System.Drawing.Point(113, 92)
        Me.txt_Descripcion.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_Descripcion.Multiline = True
        Me.txt_Descripcion.Name = "txt_Descripcion"
        Me.txt_Descripcion.Size = New System.Drawing.Size(473, 75)
        Me.txt_Descripcion.TabIndex = 15
        '
        'lbl_Descripcion
        '
        Me.lbl_Descripcion.AutoSize = True
        Me.lbl_Descripcion.Location = New System.Drawing.Point(17, 95)
        Me.lbl_Descripcion.Name = "lbl_Descripcion"
        Me.lbl_Descripcion.Size = New System.Drawing.Size(87, 20)
        Me.lbl_Descripcion.TabIndex = 10
        Me.lbl_Descripcion.Text = "Descripción"
        '
        'lbl_Separador
        '
        Me.lbl_Separador.AutoSize = True
        Me.lbl_Separador.Location = New System.Drawing.Point(71, 217)
        Me.lbl_Separador.Name = "lbl_Separador"
        Me.lbl_Separador.Size = New System.Drawing.Size(13, 20)
        Me.lbl_Separador.TabIndex = 19
        Me.lbl_Separador.Text = "|"
        '
        'lbl_Rol
        '
        Me.lbl_Rol.AutoSize = True
        Me.lbl_Rol.Location = New System.Drawing.Point(89, 217)
        Me.lbl_Rol.Name = "lbl_Rol"
        Me.lbl_Rol.Size = New System.Drawing.Size(27, 20)
        Me.lbl_Rol.TabIndex = 18
        Me.lbl_Rol.Text = "rol"
        '
        'lbl_Uuario
        '
        Me.lbl_Uuario.AutoSize = True
        Me.lbl_Uuario.Location = New System.Drawing.Point(11, 217)
        Me.lbl_Uuario.Name = "lbl_Uuario"
        Me.lbl_Uuario.Size = New System.Drawing.Size(57, 20)
        Me.lbl_Uuario.TabIndex = 17
        Me.lbl_Uuario.Text = "usuario"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsm_Nuevo, Me.tsm_Consultar, Me.tsm_Grabar, Me.tsm_Modificar, Me.tsm_Cancelar, Me.tsm_Salir})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(6, 3, 0, 3)
        Me.MenuStrip1.Size = New System.Drawing.Size(629, 30)
        Me.MenuStrip1.TabIndex = 20
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'tsm_Nuevo
        '
        Me.tsm_Nuevo.Image = CType(resources.GetObject("tsm_Nuevo.Image"), System.Drawing.Image)
        Me.tsm_Nuevo.Name = "tsm_Nuevo"
        Me.tsm_Nuevo.Size = New System.Drawing.Size(86, 24)
        Me.tsm_Nuevo.Text = "Nuevo"
        '
        'tsm_Consultar
        '
        Me.tsm_Consultar.Image = CType(resources.GetObject("tsm_Consultar.Image"), System.Drawing.Image)
        Me.tsm_Consultar.Name = "tsm_Consultar"
        Me.tsm_Consultar.Size = New System.Drawing.Size(105, 24)
        Me.tsm_Consultar.Text = "Consultar"
        '
        'tsm_Grabar
        '
        Me.tsm_Grabar.Image = CType(resources.GetObject("tsm_Grabar.Image"), System.Drawing.Image)
        Me.tsm_Grabar.Name = "tsm_Grabar"
        Me.tsm_Grabar.Size = New System.Drawing.Size(88, 24)
        Me.tsm_Grabar.Text = "Grabar"
        '
        'tsm_Modificar
        '
        Me.tsm_Modificar.Image = CType(resources.GetObject("tsm_Modificar.Image"), System.Drawing.Image)
        Me.tsm_Modificar.Name = "tsm_Modificar"
        Me.tsm_Modificar.Size = New System.Drawing.Size(107, 24)
        Me.tsm_Modificar.Text = "Modificar"
        '
        'tsm_Cancelar
        '
        Me.tsm_Cancelar.Image = CType(resources.GetObject("tsm_Cancelar.Image"), System.Drawing.Image)
        Me.tsm_Cancelar.Name = "tsm_Cancelar"
        Me.tsm_Cancelar.Size = New System.Drawing.Size(100, 24)
        Me.tsm_Cancelar.Text = "Cancelar"
        '
        'tsm_Salir
        '
        Me.tsm_Salir.Image = CType(resources.GetObject("tsm_Salir.Image"), System.Drawing.Image)
        Me.tsm_Salir.Name = "tsm_Salir"
        Me.tsm_Salir.Size = New System.Drawing.Size(72, 24)
        Me.tsm_Salir.Text = "Salir"
        '
        'frm_Reporte_Sintoma
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(629, 251)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.lbl_Separador)
        Me.Controls.Add(Me.lbl_Rol)
        Me.Controls.Add(Me.lbl_Uuario)
        Me.Controls.Add(Me.GroupBox1)
        Me.Margin = New System.Windows.Forms.Padding(1)
        Me.MaximizeBox = False
        Me.Name = "frm_Reporte_Sintoma"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reporte de síntoma"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txt_Id As TextBox
    Friend WithEvents lbl_IdReporte As Label
    Friend WithEvents txt_Descripcion As TextBox
    Friend WithEvents lbl_Descripcion As Label
    Friend WithEvents txt_Empleado As TextBox
    Friend WithEvents txt_IdEmpleado As TextBox
    Friend WithEvents lbl_Empleado As Label
    Friend WithEvents dtp_Fecha As DateTimePicker
    Friend WithEvents lbl_Fecha As Label
    Friend WithEvents lbl_Separador As Label
    Friend WithEvents lbl_Rol As Label
    Friend WithEvents lbl_Uuario As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents tsm_Nuevo As ToolStripMenuItem
    Friend WithEvents tsm_Consultar As ToolStripMenuItem
    Friend WithEvents tsm_Grabar As ToolStripMenuItem
    Friend WithEvents tsm_Modificar As ToolStripMenuItem
    Friend WithEvents tsm_Cancelar As ToolStripMenuItem
    Friend WithEvents tsm_Salir As ToolStripMenuItem
End Class
