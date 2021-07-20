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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_id_medico = New System.Windows.Forms.TextBox()
        Me.txt_nombre_medico = New System.Windows.Forms.TextBox()
        Me.rdb_activo_medico = New System.Windows.Forms.RadioButton()
        Me.rdb_inactivo_medico = New System.Windows.Forms.RadioButton()
        Me.btn_Guardar = New System.Windows.Forms.Button()
        Me.btn_Limpiar = New System.Windows.Forms.Button()
        Me.btn_Salir = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btn_Salir)
        Me.GroupBox1.Controls.Add(Me.btn_Limpiar)
        Me.GroupBox1.Controls.Add(Me.btn_Guardar)
        Me.GroupBox1.Controls.Add(Me.rdb_inactivo_medico)
        Me.GroupBox1.Controls.Add(Me.rdb_activo_medico)
        Me.GroupBox1.Controls.Add(Me.txt_nombre_medico)
        Me.GroupBox1.Controls.Add(Me.txt_id_medico)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(9, 7)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(779, 431)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "MÉDICO"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(39, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID Médico:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(39, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Estado:"
        '
        'txt_id_medico
        '
        Me.txt_id_medico.Location = New System.Drawing.Point(159, 46)
        Me.txt_id_medico.Name = "txt_id_medico"
        Me.txt_id_medico.Size = New System.Drawing.Size(67, 23)
        Me.txt_id_medico.TabIndex = 2
        '
        'txt_nombre_medico
        '
        Me.txt_nombre_medico.Location = New System.Drawing.Point(254, 46)
        Me.txt_nombre_medico.Name = "txt_nombre_medico"
        Me.txt_nombre_medico.Size = New System.Drawing.Size(248, 23)
        Me.txt_nombre_medico.TabIndex = 3
        '
        'rdb_activo_medico
        '
        Me.rdb_activo_medico.AutoSize = True
        Me.rdb_activo_medico.Location = New System.Drawing.Point(159, 87)
        Me.rdb_activo_medico.Name = "rdb_activo_medico"
        Me.rdb_activo_medico.Size = New System.Drawing.Size(59, 19)
        Me.rdb_activo_medico.TabIndex = 4
        Me.rdb_activo_medico.TabStop = True
        Me.rdb_activo_medico.Text = "Activo"
        Me.rdb_activo_medico.UseVisualStyleBackColor = True
        '
        'rdb_inactivo_medico
        '
        Me.rdb_inactivo_medico.AutoSize = True
        Me.rdb_inactivo_medico.Location = New System.Drawing.Point(303, 86)
        Me.rdb_inactivo_medico.Name = "rdb_inactivo_medico"
        Me.rdb_inactivo_medico.Size = New System.Drawing.Size(67, 19)
        Me.rdb_inactivo_medico.TabIndex = 5
        Me.rdb_inactivo_medico.TabStop = True
        Me.rdb_inactivo_medico.Text = "Inactivo"
        Me.rdb_inactivo_medico.UseVisualStyleBackColor = True
        '
        'btn_Guardar
        '
        Me.btn_Guardar.Location = New System.Drawing.Point(194, 337)
        Me.btn_Guardar.Name = "btn_Guardar"
        Me.btn_Guardar.Size = New System.Drawing.Size(75, 23)
        Me.btn_Guardar.TabIndex = 6
        Me.btn_Guardar.Text = "Guardar"
        Me.btn_Guardar.UseVisualStyleBackColor = True
        '
        'btn_Limpiar
        '
        Me.btn_Limpiar.Location = New System.Drawing.Point(368, 337)
        Me.btn_Limpiar.Name = "btn_Limpiar"
        Me.btn_Limpiar.Size = New System.Drawing.Size(75, 23)
        Me.btn_Limpiar.TabIndex = 7
        Me.btn_Limpiar.Text = "Eliminar"
        Me.btn_Limpiar.UseVisualStyleBackColor = True
        '
        'btn_Salir
        '
        Me.btn_Salir.Location = New System.Drawing.Point(547, 337)
        Me.btn_Salir.Name = "btn_Salir"
        Me.btn_Salir.Size = New System.Drawing.Size(75, 23)
        Me.btn_Salir.TabIndex = 8
        Me.btn_Salir.Text = "Salir"
        Me.btn_Salir.UseVisualStyleBackColor = True
        '
        'frm_Medico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frm_Medico"
        Me.Text = "frm_Medico"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents rdb_inactivo_medico As RadioButton
    Friend WithEvents rdb_activo_medico As RadioButton
    Friend WithEvents txt_nombre_medico As TextBox
    Friend WithEvents txt_id_medico As TextBox
    Friend WithEvents btn_Salir As Button
    Friend WithEvents btn_Limpiar As Button
    Friend WithEvents btn_Guardar As Button
End Class
