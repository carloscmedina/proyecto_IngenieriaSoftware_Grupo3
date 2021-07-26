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
        Me.txt_Diagnostico = New System.Windows.Forms.TextBox()
        Me.lbl_Diagnostico = New System.Windows.Forms.Label()
        Me.txt_Medico = New System.Windows.Forms.TextBox()
        Me.txt_IdMedico = New System.Windows.Forms.TextBox()
        Me.rdb_AltaMedicaNo = New System.Windows.Forms.RadioButton()
        Me.rdb_AltaMedicaSi = New System.Windows.Forms.RadioButton()
        Me.lbl_Estado = New System.Windows.Forms.Label()
        Me.btn_VerExamen = New System.Windows.Forms.Button()
        Me.txt_IdExamen = New System.Windows.Forms.TextBox()
        Me.lbl_Examen = New System.Windows.Forms.Label()
        Me.dtp_Fecha = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_NombreEmpleado = New System.Windows.Forms.TextBox()
        Me.txt_IdEmpleado = New System.Windows.Forms.TextBox()
        Me.txt_Id = New System.Windows.Forms.TextBox()
        Me.lbl_Medico = New System.Windows.Forms.Label()
        Me.lbl_Empleado = New System.Windows.Forms.Label()
        Me.lbl_IdCita = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lbl_Rol = New System.Windows.Forms.Label()
        Me.lbl_Usuario = New System.Windows.Forms.Label()
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
        Me.GroupBox1.Controls.Add(Me.txt_Diagnostico)
        Me.GroupBox1.Controls.Add(Me.lbl_Diagnostico)
        Me.GroupBox1.Controls.Add(Me.txt_Medico)
        Me.GroupBox1.Controls.Add(Me.txt_IdMedico)
        Me.GroupBox1.Controls.Add(Me.rdb_AltaMedicaNo)
        Me.GroupBox1.Controls.Add(Me.rdb_AltaMedicaSi)
        Me.GroupBox1.Controls.Add(Me.lbl_Estado)
        Me.GroupBox1.Controls.Add(Me.btn_VerExamen)
        Me.GroupBox1.Controls.Add(Me.txt_IdExamen)
        Me.GroupBox1.Controls.Add(Me.lbl_Examen)
        Me.GroupBox1.Controls.Add(Me.dtp_Fecha)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txt_NombreEmpleado)
        Me.GroupBox1.Controls.Add(Me.txt_IdEmpleado)
        Me.GroupBox1.Controls.Add(Me.txt_Id)
        Me.GroupBox1.Controls.Add(Me.lbl_Medico)
        Me.GroupBox1.Controls.Add(Me.lbl_Empleado)
        Me.GroupBox1.Controls.Add(Me.lbl_IdCita)
        Me.GroupBox1.Location = New System.Drawing.Point(11, 31)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(559, 254)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'txt_Diagnostico
        '
        Me.txt_Diagnostico.Location = New System.Drawing.Point(110, 160)
        Me.txt_Diagnostico.Multiline = True
        Me.txt_Diagnostico.Name = "txt_Diagnostico"
        Me.txt_Diagnostico.Size = New System.Drawing.Size(305, 81)
        Me.txt_Diagnostico.TabIndex = 23
        '
        'lbl_Diagnostico
        '
        Me.lbl_Diagnostico.AutoSize = True
        Me.lbl_Diagnostico.Location = New System.Drawing.Point(15, 162)
        Me.lbl_Diagnostico.Name = "lbl_Diagnostico"
        Me.lbl_Diagnostico.Size = New System.Drawing.Size(89, 20)
        Me.lbl_Diagnostico.TabIndex = 22
        Me.lbl_Diagnostico.Text = "Diagnóstico"
        '
        'txt_Medico
        '
        Me.txt_Medico.Location = New System.Drawing.Point(199, 88)
        Me.txt_Medico.Name = "txt_Medico"
        Me.txt_Medico.ReadOnly = True
        Me.txt_Medico.Size = New System.Drawing.Size(348, 27)
        Me.txt_Medico.TabIndex = 21
        '
        'txt_IdMedico
        '
        Me.txt_IdMedico.Location = New System.Drawing.Point(110, 88)
        Me.txt_IdMedico.Name = "txt_IdMedico"
        Me.txt_IdMedico.Size = New System.Drawing.Size(83, 27)
        Me.txt_IdMedico.TabIndex = 20
        '
        'rdb_AltaMedicaNo
        '
        Me.rdb_AltaMedicaNo.AutoSize = True
        Me.rdb_AltaMedicaNo.Location = New System.Drawing.Point(490, 160)
        Me.rdb_AltaMedicaNo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.rdb_AltaMedicaNo.Name = "rdb_AltaMedicaNo"
        Me.rdb_AltaMedicaNo.Size = New System.Drawing.Size(50, 24)
        Me.rdb_AltaMedicaNo.TabIndex = 19
        Me.rdb_AltaMedicaNo.TabStop = True
        Me.rdb_AltaMedicaNo.Text = "No"
        Me.rdb_AltaMedicaNo.UseVisualStyleBackColor = True
        '
        'rdb_AltaMedicaSi
        '
        Me.rdb_AltaMedicaSi.AutoSize = True
        Me.rdb_AltaMedicaSi.Location = New System.Drawing.Point(490, 128)
        Me.rdb_AltaMedicaSi.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.rdb_AltaMedicaSi.Name = "rdb_AltaMedicaSi"
        Me.rdb_AltaMedicaSi.Size = New System.Drawing.Size(42, 24)
        Me.rdb_AltaMedicaSi.TabIndex = 18
        Me.rdb_AltaMedicaSi.TabStop = True
        Me.rdb_AltaMedicaSi.Text = "Si"
        Me.rdb_AltaMedicaSi.UseVisualStyleBackColor = True
        '
        'lbl_Estado
        '
        Me.lbl_Estado.AutoSize = True
        Me.lbl_Estado.Location = New System.Drawing.Point(377, 128)
        Me.lbl_Estado.Name = "lbl_Estado"
        Me.lbl_Estado.Size = New System.Drawing.Size(89, 20)
        Me.lbl_Estado.TabIndex = 17
        Me.lbl_Estado.Text = "Alta médica"
        '
        'btn_VerExamen
        '
        Me.btn_VerExamen.Location = New System.Drawing.Point(199, 123)
        Me.btn_VerExamen.Name = "btn_VerExamen"
        Me.btn_VerExamen.Size = New System.Drawing.Size(94, 29)
        Me.btn_VerExamen.TabIndex = 16
        Me.btn_VerExamen.Text = "Ver exámen"
        Me.btn_VerExamen.UseVisualStyleBackColor = True
        '
        'txt_IdExamen
        '
        Me.txt_IdExamen.Location = New System.Drawing.Point(110, 125)
        Me.txt_IdExamen.Name = "txt_IdExamen"
        Me.txt_IdExamen.Size = New System.Drawing.Size(83, 27)
        Me.txt_IdExamen.TabIndex = 15
        '
        'lbl_Examen
        '
        Me.lbl_Examen.AutoSize = True
        Me.lbl_Examen.Location = New System.Drawing.Point(15, 125)
        Me.lbl_Examen.Name = "lbl_Examen"
        Me.lbl_Examen.Size = New System.Drawing.Size(61, 20)
        Me.lbl_Examen.TabIndex = 14
        Me.lbl_Examen.Text = "Examen"
        '
        'dtp_Fecha
        '
        Me.dtp_Fecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_Fecha.Location = New System.Drawing.Point(440, 12)
        Me.dtp_Fecha.Name = "dtp_Fecha"
        Me.dtp_Fecha.Size = New System.Drawing.Size(107, 27)
        Me.dtp_Fecha.TabIndex = 13
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(387, 17)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(47, 20)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Fecha"
        '
        'txt_NombreEmpleado
        '
        Me.txt_NombreEmpleado.Location = New System.Drawing.Point(199, 51)
        Me.txt_NombreEmpleado.Name = "txt_NombreEmpleado"
        Me.txt_NombreEmpleado.ReadOnly = True
        Me.txt_NombreEmpleado.Size = New System.Drawing.Size(348, 27)
        Me.txt_NombreEmpleado.TabIndex = 10
        '
        'txt_IdEmpleado
        '
        Me.txt_IdEmpleado.Location = New System.Drawing.Point(110, 51)
        Me.txt_IdEmpleado.Name = "txt_IdEmpleado"
        Me.txt_IdEmpleado.Size = New System.Drawing.Size(83, 27)
        Me.txt_IdEmpleado.TabIndex = 7
        '
        'txt_Id
        '
        Me.txt_Id.Location = New System.Drawing.Point(110, 16)
        Me.txt_Id.Name = "txt_Id"
        Me.txt_Id.Size = New System.Drawing.Size(83, 27)
        Me.txt_Id.TabIndex = 5
        '
        'lbl_Medico
        '
        Me.lbl_Medico.AutoSize = True
        Me.lbl_Medico.Location = New System.Drawing.Point(15, 88)
        Me.lbl_Medico.Name = "lbl_Medico"
        Me.lbl_Medico.Size = New System.Drawing.Size(59, 20)
        Me.lbl_Medico.TabIndex = 2
        Me.lbl_Medico.Text = "Médico"
        '
        'lbl_Empleado
        '
        Me.lbl_Empleado.AutoSize = True
        Me.lbl_Empleado.Location = New System.Drawing.Point(15, 51)
        Me.lbl_Empleado.Name = "lbl_Empleado"
        Me.lbl_Empleado.Size = New System.Drawing.Size(77, 20)
        Me.lbl_Empleado.TabIndex = 1
        Me.lbl_Empleado.Text = "Empleado"
        '
        'lbl_IdCita
        '
        Me.lbl_IdCita.AutoSize = True
        Me.lbl_IdCita.Location = New System.Drawing.Point(15, 19)
        Me.lbl_IdCita.Name = "lbl_IdCita"
        Me.lbl_IdCita.Size = New System.Drawing.Size(52, 20)
        Me.lbl_IdCita.TabIndex = 0
        Me.lbl_IdCita.Text = "Id Cita"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(69, 288)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(13, 20)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "|"
        '
        'lbl_Rol
        '
        Me.lbl_Rol.AutoSize = True
        Me.lbl_Rol.Location = New System.Drawing.Point(88, 288)
        Me.lbl_Rol.Name = "lbl_Rol"
        Me.lbl_Rol.Size = New System.Drawing.Size(27, 20)
        Me.lbl_Rol.TabIndex = 18
        Me.lbl_Rol.Text = "rol"
        '
        'lbl_Usuario
        '
        Me.lbl_Usuario.AutoSize = True
        Me.lbl_Usuario.Location = New System.Drawing.Point(10, 288)
        Me.lbl_Usuario.Name = "lbl_Usuario"
        Me.lbl_Usuario.Size = New System.Drawing.Size(57, 20)
        Me.lbl_Usuario.TabIndex = 17
        Me.lbl_Usuario.Text = "usuario"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsm_Nuevo, Me.tsm_Consultar, Me.tsm_Grabar, Me.tsm_Modificar, Me.tsm_Cancelar, Me.tsm_Salir})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(6, 3, 0, 3)
        Me.MenuStrip1.Size = New System.Drawing.Size(586, 30)
        Me.MenuStrip1.TabIndex = 22
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
        'frm_Cita
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(586, 318)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lbl_Rol)
        Me.Controls.Add(Me.lbl_Usuario)
        Me.Controls.Add(Me.GroupBox1)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.Name = "frm_Cita"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
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
    Friend WithEvents txt_NombreEmpleado As TextBox
    Friend WithEvents txt_IdEmpleado As TextBox
    Friend WithEvents txt_Id As TextBox
    Friend WithEvents lbl_Medico As Label
    Friend WithEvents lbl_Empleado As Label
    Friend WithEvents lbl_IdCita As Label
    Friend WithEvents btn_VerExamen As Button
    Friend WithEvents txt_IdExamen As TextBox
    Friend WithEvents lbl_Examen As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lbl_Rol As Label
    Friend WithEvents lbl_Usuario As Label
    Friend WithEvents rdb_AltaMedicaNo As RadioButton
    Friend WithEvents rdb_AltaMedicaSi As RadioButton
    Friend WithEvents lbl_Estado As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents tsm_Nuevo As ToolStripMenuItem
    Friend WithEvents tsm_Consultar As ToolStripMenuItem
    Friend WithEvents tsm_Grabar As ToolStripMenuItem
    Friend WithEvents tsm_Modificar As ToolStripMenuItem
    Friend WithEvents tsm_Cancelar As ToolStripMenuItem
    Friend WithEvents tsm_Salir As ToolStripMenuItem
    Friend WithEvents txt_Medico As TextBox
    Friend WithEvents txt_IdMedico As TextBox
    Friend WithEvents txt_Diagnostico As TextBox
    Friend WithEvents lbl_Diagnostico As Label
End Class
