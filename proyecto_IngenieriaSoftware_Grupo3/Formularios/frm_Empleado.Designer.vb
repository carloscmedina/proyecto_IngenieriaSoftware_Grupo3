<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Empleado
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
        Me.rdb_inactivo_empleado = New System.Windows.Forms.RadioButton()
        Me.rdb_activo_empleado = New System.Windows.Forms.RadioButton()
        Me.lbl_estado_empleado = New System.Windows.Forms.Label()
        Me.txt_nombre_empleado = New System.Windows.Forms.TextBox()
        Me.txt_id_empleado = New System.Windows.Forms.TextBox()
        Me.lbl_id_empleado = New System.Windows.Forms.Label()
        Me.btn_Guardar = New System.Windows.Forms.Button()
        Me.btn_Eliminar = New System.Windows.Forms.Button()
        Me.btn_Salir = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btn_Salir)
        Me.GroupBox1.Controls.Add(Me.btn_Eliminar)
        Me.GroupBox1.Controls.Add(Me.btn_Guardar)
        Me.GroupBox1.Controls.Add(Me.rdb_inactivo_empleado)
        Me.GroupBox1.Controls.Add(Me.rdb_activo_empleado)
        Me.GroupBox1.Controls.Add(Me.lbl_estado_empleado)
        Me.GroupBox1.Controls.Add(Me.txt_nombre_empleado)
        Me.GroupBox1.Controls.Add(Me.txt_id_empleado)
        Me.GroupBox1.Controls.Add(Me.lbl_id_empleado)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(776, 426)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "EMPLEADO"
        '
        'rdb_inactivo_empleado
        '
        Me.rdb_inactivo_empleado.AutoSize = True
        Me.rdb_inactivo_empleado.Location = New System.Drawing.Point(307, 91)
        Me.rdb_inactivo_empleado.Name = "rdb_inactivo_empleado"
        Me.rdb_inactivo_empleado.Size = New System.Drawing.Size(67, 19)
        Me.rdb_inactivo_empleado.TabIndex = 7
        Me.rdb_inactivo_empleado.TabStop = True
        Me.rdb_inactivo_empleado.Text = "Inactivo"
        Me.rdb_inactivo_empleado.UseVisualStyleBackColor = True
        '
        'rdb_activo_empleado
        '
        Me.rdb_activo_empleado.AutoSize = True
        Me.rdb_activo_empleado.Location = New System.Drawing.Point(182, 91)
        Me.rdb_activo_empleado.Name = "rdb_activo_empleado"
        Me.rdb_activo_empleado.Size = New System.Drawing.Size(59, 19)
        Me.rdb_activo_empleado.TabIndex = 6
        Me.rdb_activo_empleado.TabStop = True
        Me.rdb_activo_empleado.Text = "Activo"
        Me.rdb_activo_empleado.UseVisualStyleBackColor = True
        '
        'lbl_estado_empleado
        '
        Me.lbl_estado_empleado.AutoSize = True
        Me.lbl_estado_empleado.Location = New System.Drawing.Point(49, 95)
        Me.lbl_estado_empleado.Name = "lbl_estado_empleado"
        Me.lbl_estado_empleado.Size = New System.Drawing.Size(45, 15)
        Me.lbl_estado_empleado.TabIndex = 3
        Me.lbl_estado_empleado.Text = "Estado:"
        '
        'txt_nombre_empleado
        '
        Me.txt_nombre_empleado.Location = New System.Drawing.Point(269, 33)
        Me.txt_nombre_empleado.Name = "txt_nombre_empleado"
        Me.txt_nombre_empleado.Size = New System.Drawing.Size(164, 23)
        Me.txt_nombre_empleado.TabIndex = 2
        '
        'txt_id_empleado
        '
        Me.txt_id_empleado.Location = New System.Drawing.Point(182, 33)
        Me.txt_id_empleado.Name = "txt_id_empleado"
        Me.txt_id_empleado.Size = New System.Drawing.Size(71, 23)
        Me.txt_id_empleado.TabIndex = 1
        '
        'lbl_id_empleado
        '
        Me.lbl_id_empleado.AutoSize = True
        Me.lbl_id_empleado.Location = New System.Drawing.Point(49, 36)
        Me.lbl_id_empleado.Name = "lbl_id_empleado"
        Me.lbl_id_empleado.Size = New System.Drawing.Size(77, 15)
        Me.lbl_id_empleado.TabIndex = 0
        Me.lbl_id_empleado.Text = "ID Empleado:"
        '
        'btn_Guardar
        '
        Me.btn_Guardar.Location = New System.Drawing.Point(182, 278)
        Me.btn_Guardar.Name = "btn_Guardar"
        Me.btn_Guardar.Size = New System.Drawing.Size(75, 23)
        Me.btn_Guardar.TabIndex = 8
        Me.btn_Guardar.Text = "Guardar"
        Me.btn_Guardar.UseVisualStyleBackColor = True
        '
        'btn_Eliminar
        '
        Me.btn_Eliminar.Location = New System.Drawing.Point(370, 278)
        Me.btn_Eliminar.Name = "btn_Eliminar"
        Me.btn_Eliminar.Size = New System.Drawing.Size(75, 23)
        Me.btn_Eliminar.TabIndex = 9
        Me.btn_Eliminar.Text = "Eliminar"
        Me.btn_Eliminar.UseVisualStyleBackColor = True
        '
        'btn_Salir
        '
        Me.btn_Salir.Location = New System.Drawing.Point(586, 278)
        Me.btn_Salir.Name = "btn_Salir"
        Me.btn_Salir.Size = New System.Drawing.Size(75, 23)
        Me.btn_Salir.TabIndex = 10
        Me.btn_Salir.Text = "Salir"
        Me.btn_Salir.UseVisualStyleBackColor = True
        '
        'frm_Empleado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frm_Empleado"
        Me.Text = "frm_Empleado"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lbl_id_empleado As Label
    Friend WithEvents txt_nombre_empleado As TextBox
    Friend WithEvents txt_id_empleado As TextBox
    Friend WithEvents lbl_estado_empleado As Label
    Friend WithEvents rdb_inactivo_empleado As RadioButton
    Friend WithEvents rdb_activo_empleado As RadioButton
    Friend WithEvents btn_Salir As Button
    Friend WithEvents btn_Eliminar As Button
    Friend WithEvents btn_Guardar As Button
End Class
