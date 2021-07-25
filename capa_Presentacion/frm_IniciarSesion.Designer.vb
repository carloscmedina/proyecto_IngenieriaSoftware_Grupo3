<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
<Global.System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1726")> _
Partial Class frm_IniciarSesion
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
    Friend WithEvents LogoPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents lbl_Username As System.Windows.Forms.Label
    Friend WithEvents lbl_Password As System.Windows.Forms.Label
    Friend WithEvents txt_Usuario As System.Windows.Forms.TextBox
    Friend WithEvents txt_Contrasenia As System.Windows.Forms.TextBox
    Friend WithEvents OK As System.Windows.Forms.Button
    Friend WithEvents Cancel As System.Windows.Forms.Button

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_IniciarSesion))
        Me.LogoPictureBox = New System.Windows.Forms.PictureBox()
        Me.lbl_Username = New System.Windows.Forms.Label()
        Me.lbl_Password = New System.Windows.Forms.Label()
        Me.txt_Usuario = New System.Windows.Forms.TextBox()
        Me.txt_Contrasenia = New System.Windows.Forms.TextBox()
        Me.OK = New System.Windows.Forms.Button()
        Me.Cancel = New System.Windows.Forms.Button()
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LogoPictureBox
        '
        Me.LogoPictureBox.Image = CType(resources.GetObject("LogoPictureBox.Image"), System.Drawing.Image)
        Me.LogoPictureBox.Location = New System.Drawing.Point(0, 0)
        Me.LogoPictureBox.Name = "LogoPictureBox"
        Me.LogoPictureBox.Size = New System.Drawing.Size(165, 193)
        Me.LogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.LogoPictureBox.TabIndex = 0
        Me.LogoPictureBox.TabStop = False
        '
        'lbl_Username
        '
        Me.lbl_Username.Location = New System.Drawing.Point(172, 24)
        Me.lbl_Username.Name = "lbl_Username"
        Me.lbl_Username.Size = New System.Drawing.Size(220, 23)
        Me.lbl_Username.TabIndex = 0
        Me.lbl_Username.Text = "&Nombre de usuario"
        Me.lbl_Username.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl_Password
        '
        Me.lbl_Password.Location = New System.Drawing.Point(172, 81)
        Me.lbl_Password.Name = "lbl_Password"
        Me.lbl_Password.Size = New System.Drawing.Size(220, 23)
        Me.lbl_Password.TabIndex = 2
        Me.lbl_Password.Text = "&Contraseña"
        Me.lbl_Password.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt_Usuario
        '
        Me.txt_Usuario.Location = New System.Drawing.Point(174, 44)
        Me.txt_Usuario.Name = "txt_Usuario"
        Me.txt_Usuario.Size = New System.Drawing.Size(220, 27)
        Me.txt_Usuario.TabIndex = 1
        '
        'txt_Contrasenia
        '
        Me.txt_Contrasenia.Location = New System.Drawing.Point(174, 101)
        Me.txt_Contrasenia.Name = "txt_Contrasenia"
        Me.txt_Contrasenia.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_Contrasenia.Size = New System.Drawing.Size(220, 27)
        Me.txt_Contrasenia.TabIndex = 3
        '
        'OK
        '
        Me.OK.Image = CType(resources.GetObject("OK.Image"), System.Drawing.Image)
        Me.OK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.OK.Location = New System.Drawing.Point(197, 161)
        Me.OK.Name = "OK"
        Me.OK.Size = New System.Drawing.Size(94, 29)
        Me.OK.TabIndex = 4
        Me.OK.Text = "&Aceptar"
        Me.OK.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Cancel
        '
        Me.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel.Image = CType(resources.GetObject("Cancel.Image"), System.Drawing.Image)
        Me.Cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Cancel.Location = New System.Drawing.Point(300, 161)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(94, 29)
        Me.Cancel.TabIndex = 5
        Me.Cancel.Text = "&Cancelar"
        Me.Cancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'frm_IniciarSesion
        '
        Me.AcceptButton = Me.OK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel
        Me.ClientSize = New System.Drawing.Size(401, 202)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.OK)
        Me.Controls.Add(Me.txt_Contrasenia)
        Me.Controls.Add(Me.txt_Usuario)
        Me.Controls.Add(Me.lbl_Password)
        Me.Controls.Add(Me.lbl_Username)
        Me.Controls.Add(Me.LogoPictureBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_IniciarSesion"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Iniciar sesión"
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

End Class
