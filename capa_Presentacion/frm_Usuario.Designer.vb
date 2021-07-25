<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Usuario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Usuario))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_ConfirmarContrasenia = New System.Windows.Forms.TextBox()
        Me.txt_NombreEmpleado = New System.Windows.Forms.TextBox()
        Me.txt_IdEmpleado = New System.Windows.Forms.TextBox()
        Me.lbl_Empleado = New System.Windows.Forms.Label()
        Me.cmb_Tipo = New System.Windows.Forms.ComboBox()
        Me.lbl_Area = New System.Windows.Forms.Label()
        Me.txt_Contrasenia = New System.Windows.Forms.TextBox()
        Me.txt_Usuario = New System.Windows.Forms.TextBox()
        Me.lbl_Nombres = New System.Windows.Forms.Label()
        Me.lbl_Apellidos = New System.Windows.Forms.Label()
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
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txt_ConfirmarContrasenia)
        Me.GroupBox1.Controls.Add(Me.txt_NombreEmpleado)
        Me.GroupBox1.Controls.Add(Me.txt_IdEmpleado)
        Me.GroupBox1.Controls.Add(Me.lbl_Empleado)
        Me.GroupBox1.Controls.Add(Me.cmb_Tipo)
        Me.GroupBox1.Controls.Add(Me.lbl_Area)
        Me.GroupBox1.Controls.Add(Me.txt_Contrasenia)
        Me.GroupBox1.Controls.Add(Me.txt_Usuario)
        Me.GroupBox1.Controls.Add(Me.lbl_Nombres)
        Me.GroupBox1.Controls.Add(Me.lbl_Apellidos)
        Me.GroupBox1.Location = New System.Drawing.Point(11, 34)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(606, 195)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(320, 141)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 40)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "Confirmar " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "contraseña"
        '
        'txt_ConfirmarContrasenia
        '
        Me.txt_ConfirmarContrasenia.Location = New System.Drawing.Point(407, 154)
        Me.txt_ConfirmarContrasenia.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_ConfirmarContrasenia.Name = "txt_ConfirmarContrasenia"
        Me.txt_ConfirmarContrasenia.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_ConfirmarContrasenia.Size = New System.Drawing.Size(172, 27)
        Me.txt_ConfirmarContrasenia.TabIndex = 8
        Me.txt_ConfirmarContrasenia.UseSystemPasswordChar = True
        '
        'txt_NombreEmpleado
        '
        Me.txt_NombreEmpleado.Location = New System.Drawing.Point(203, 26)
        Me.txt_NombreEmpleado.Name = "txt_NombreEmpleado"
        Me.txt_NombreEmpleado.ReadOnly = True
        Me.txt_NombreEmpleado.Size = New System.Drawing.Size(278, 27)
        Me.txt_NombreEmpleado.TabIndex = 2
        '
        'txt_IdEmpleado
        '
        Me.txt_IdEmpleado.Location = New System.Drawing.Point(114, 26)
        Me.txt_IdEmpleado.Name = "txt_IdEmpleado"
        Me.txt_IdEmpleado.Size = New System.Drawing.Size(83, 27)
        Me.txt_IdEmpleado.TabIndex = 1
        '
        'lbl_Empleado
        '
        Me.lbl_Empleado.AutoSize = True
        Me.lbl_Empleado.Location = New System.Drawing.Point(19, 26)
        Me.lbl_Empleado.Name = "lbl_Empleado"
        Me.lbl_Empleado.Size = New System.Drawing.Size(77, 20)
        Me.lbl_Empleado.TabIndex = 24
        Me.lbl_Empleado.Text = "Empleado"
        '
        'cmb_Tipo
        '
        Me.cmb_Tipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Tipo.FormattingEnabled = True
        Me.cmb_Tipo.Items.AddRange(New Object() {"A Administrador", "U Usuario"})
        Me.cmb_Tipo.Location = New System.Drawing.Point(114, 82)
        Me.cmb_Tipo.Name = "cmb_Tipo"
        Me.cmb_Tipo.Size = New System.Drawing.Size(367, 28)
        Me.cmb_Tipo.TabIndex = 5
        '
        'lbl_Area
        '
        Me.lbl_Area.AutoSize = True
        Me.lbl_Area.Location = New System.Drawing.Point(19, 85)
        Me.lbl_Area.Name = "lbl_Area"
        Me.lbl_Area.Size = New System.Drawing.Size(39, 20)
        Me.lbl_Area.TabIndex = 20
        Me.lbl_Area.Text = "Tipo"
        '
        'txt_Contrasenia
        '
        Me.txt_Contrasenia.Location = New System.Drawing.Point(114, 154)
        Me.txt_Contrasenia.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_Contrasenia.Name = "txt_Contrasenia"
        Me.txt_Contrasenia.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_Contrasenia.Size = New System.Drawing.Size(172, 27)
        Me.txt_Contrasenia.TabIndex = 7
        Me.txt_Contrasenia.UseSystemPasswordChar = True
        '
        'txt_Usuario
        '
        Me.txt_Usuario.Location = New System.Drawing.Point(114, 119)
        Me.txt_Usuario.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_Usuario.Name = "txt_Usuario"
        Me.txt_Usuario.Size = New System.Drawing.Size(172, 27)
        Me.txt_Usuario.TabIndex = 6
        '
        'lbl_Nombres
        '
        Me.lbl_Nombres.AutoSize = True
        Me.lbl_Nombres.Location = New System.Drawing.Point(19, 154)
        Me.lbl_Nombres.Name = "lbl_Nombres"
        Me.lbl_Nombres.Size = New System.Drawing.Size(83, 20)
        Me.lbl_Nombres.TabIndex = 13
        Me.lbl_Nombres.Text = "Contraseña"
        '
        'lbl_Apellidos
        '
        Me.lbl_Apellidos.AutoSize = True
        Me.lbl_Apellidos.Location = New System.Drawing.Point(19, 122)
        Me.lbl_Apellidos.Name = "lbl_Apellidos"
        Me.lbl_Apellidos.Size = New System.Drawing.Size(59, 20)
        Me.lbl_Apellidos.TabIndex = 12
        Me.lbl_Apellidos.Text = "Usuario"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(67, 233)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(13, 20)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "|"
        '
        'lbl_Rol
        '
        Me.lbl_Rol.AutoSize = True
        Me.lbl_Rol.Location = New System.Drawing.Point(86, 233)
        Me.lbl_Rol.Name = "lbl_Rol"
        Me.lbl_Rol.Size = New System.Drawing.Size(27, 20)
        Me.lbl_Rol.TabIndex = 15
        Me.lbl_Rol.Text = "rol"
        '
        'lbl_Usuario
        '
        Me.lbl_Usuario.AutoSize = True
        Me.lbl_Usuario.Location = New System.Drawing.Point(8, 233)
        Me.lbl_Usuario.Name = "lbl_Usuario"
        Me.lbl_Usuario.Size = New System.Drawing.Size(57, 20)
        Me.lbl_Usuario.TabIndex = 14
        Me.lbl_Usuario.Text = "usuario"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsm_Nuevo, Me.tsm_Consultar, Me.tsm_Grabar, Me.tsm_Modificar, Me.tsm_Cancelar, Me.tsm_Salir})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(6, 3, 0, 3)
        Me.MenuStrip1.Size = New System.Drawing.Size(627, 30)
        Me.MenuStrip1.TabIndex = 18
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
        'frm_Usuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(627, 261)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lbl_Rol)
        Me.Controls.Add(Me.lbl_Usuario)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.Name = "frm_Usuario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mantenimiento de Usuario"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cmb_Tipo As ComboBox
    Friend WithEvents lbl_Area As Label
    Friend WithEvents txt_Contrasenia As TextBox
    Friend WithEvents txt_Usuario As TextBox
    Friend WithEvents lbl_Nombres As Label
    Friend WithEvents lbl_Apellidos As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_ConfirmarContrasenia As TextBox
    Friend WithEvents txt_NombreEmpleado As TextBox
    Friend WithEvents txt_IdEmpleado As TextBox
    Friend WithEvents lbl_Empleado As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lbl_Rol As Label
    Friend WithEvents lbl_Usuario As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents tsm_Nuevo As ToolStripMenuItem
    Friend WithEvents tsm_Consultar As ToolStripMenuItem
    Friend WithEvents tsm_Grabar As ToolStripMenuItem
    Friend WithEvents tsm_Modificar As ToolStripMenuItem
    Friend WithEvents tsm_Cancelar As ToolStripMenuItem
    Friend WithEvents tsm_Salir As ToolStripMenuItem
End Class
