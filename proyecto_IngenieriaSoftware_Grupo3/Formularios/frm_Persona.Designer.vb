<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Persona
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lbl_area_persona = New System.Windows.Forms.Label()
        Me.lbl_fechanac_persona = New System.Windows.Forms.Label()
        Me.lbl_nombre_persona = New System.Windows.Forms.Label()
        Me.lbl_apellido_persona = New System.Windows.Forms.Label()
        Me.lbl_cedula_persona = New System.Windows.Forms.Label()
        Me.lbl_estado_persona = New System.Windows.Forms.Label()
        Me.lbl_id_persona = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lbl_area_persona)
        Me.GroupBox1.Controls.Add(Me.lbl_id_persona)
        Me.GroupBox1.Controls.Add(Me.lbl_fechanac_persona)
        Me.GroupBox1.Controls.Add(Me.lbl_estado_persona)
        Me.GroupBox1.Controls.Add(Me.lbl_nombre_persona)
        Me.GroupBox1.Controls.Add(Me.lbl_cedula_persona)
        Me.GroupBox1.Controls.Add(Me.lbl_apellido_persona)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(775, 425)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "PERSONA"
        '
        'lbl_area_persona
        '
        Me.lbl_area_persona.AutoSize = True
        Me.lbl_area_persona.Location = New System.Drawing.Point(60, 81)
        Me.lbl_area_persona.Name = "lbl_area_persona"
        Me.lbl_area_persona.Size = New System.Drawing.Size(34, 15)
        Me.lbl_area_persona.TabIndex = 27
        Me.lbl_area_persona.Text = "Area:"
        '
        'lbl_fechanac_persona
        '
        Me.lbl_fechanac_persona.AutoSize = True
        Me.lbl_fechanac_persona.Location = New System.Drawing.Point(60, 265)
        Me.lbl_fechanac_persona.Name = "lbl_fechanac_persona"
        Me.lbl_fechanac_persona.Size = New System.Drawing.Size(122, 15)
        Me.lbl_fechanac_persona.TabIndex = 26
        Me.lbl_fechanac_persona.Text = "Fecha de Nacimiento:"
        '
        'lbl_nombre_persona
        '
        Me.lbl_nombre_persona.AutoSize = True
        Me.lbl_nombre_persona.Location = New System.Drawing.Point(60, 188)
        Me.lbl_nombre_persona.Name = "lbl_nombre_persona"
        Me.lbl_nombre_persona.Size = New System.Drawing.Size(59, 15)
        Me.lbl_nombre_persona.TabIndex = 25
        Me.lbl_nombre_persona.Text = "Nombres:"
        '
        'lbl_apellido_persona
        '
        Me.lbl_apellido_persona.AutoSize = True
        Me.lbl_apellido_persona.Location = New System.Drawing.Point(60, 224)
        Me.lbl_apellido_persona.Name = "lbl_apellido_persona"
        Me.lbl_apellido_persona.Size = New System.Drawing.Size(59, 15)
        Me.lbl_apellido_persona.TabIndex = 24
        Me.lbl_apellido_persona.Text = "Apellidos:"
        '
        'lbl_cedula_persona
        '
        Me.lbl_cedula_persona.AutoSize = True
        Me.lbl_cedula_persona.Location = New System.Drawing.Point(60, 146)
        Me.lbl_cedula_persona.Name = "lbl_cedula_persona"
        Me.lbl_cedula_persona.Size = New System.Drawing.Size(47, 15)
        Me.lbl_cedula_persona.TabIndex = 23
        Me.lbl_cedula_persona.Text = "Cédula:"
        '
        'lbl_estado_persona
        '
        Me.lbl_estado_persona.AutoSize = True
        Me.lbl_estado_persona.Location = New System.Drawing.Point(60, 53)
        Me.lbl_estado_persona.Name = "lbl_estado_persona"
        Me.lbl_estado_persona.Size = New System.Drawing.Size(45, 15)
        Me.lbl_estado_persona.TabIndex = 22
        Me.lbl_estado_persona.Text = "Estado:"
        '
        'lbl_id_persona
        '
        Me.lbl_id_persona.AutoSize = True
        Me.lbl_id_persona.Location = New System.Drawing.Point(60, 110)
        Me.lbl_id_persona.Name = "lbl_id_persona"
        Me.lbl_id_persona.Size = New System.Drawing.Size(66, 15)
        Me.lbl_id_persona.TabIndex = 21
        Me.lbl_id_persona.Text = "ID Persona:"
        '
        'frm_Persona
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frm_Persona"
        Me.Text = "frm_Persona"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lbl_area_persona As Label
    Friend WithEvents lbl_id_persona As Label
    Friend WithEvents lbl_fechanac_persona As Label
    Friend WithEvents lbl_estado_persona As Label
    Friend WithEvents lbl_nombre_persona As Label
    Friend WithEvents lbl_cedula_persona As Label
    Friend WithEvents lbl_apellido_persona As Label
End Class
