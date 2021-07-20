<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Cita
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
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtp_fecha_visita = New System.Windows.Forms.DateTimePicker()
        Me.txt_nombre_empleado = New System.Windows.Forms.TextBox()
        Me.txt_id_empleado = New System.Windows.Forms.TextBox()
        Me.lbl_empleado = New System.Windows.Forms.Label()
        Me.txt_numero_expediente = New System.Windows.Forms.TextBox()
        Me.lbl_num_expediente = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CheckBox1)
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.dtp_fecha_visita)
        Me.GroupBox1.Controls.Add(Me.txt_nombre_empleado)
        Me.GroupBox1.Controls.Add(Me.txt_id_empleado)
        Me.GroupBox1.Controls.Add(Me.lbl_empleado)
        Me.GroupBox1.Controls.Add(Me.txt_numero_expediente)
        Me.GroupBox1.Controls.Add(Me.lbl_num_expediente)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(776, 426)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(358, 336)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(85, 19)
        Me.CheckBox1.TabIndex = 9
        Me.CheckBox1.Text = "CheckBox1"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(226, 337)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(97, 19)
        Me.RadioButton1.TabIndex = 8
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "RadioButton1"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2})
        Me.DataGridView1.Location = New System.Drawing.Point(226, 164)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 25
        Me.DataGridView1.Size = New System.Drawing.Size(261, 150)
        Me.DataGridView1.TabIndex = 7
        '
        'Column1
        '
        Me.Column1.HeaderText = "Lo que sea"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "Column2"
        Me.Column2.Name = "Column2"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(71, 125)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 15)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Label1"
        '
        'dtp_fecha_visita
        '
        Me.dtp_fecha_visita.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_fecha_visita.Location = New System.Drawing.Point(226, 118)
        Me.dtp_fecha_visita.Name = "dtp_fecha_visita"
        Me.dtp_fecha_visita.Size = New System.Drawing.Size(100, 23)
        Me.dtp_fecha_visita.TabIndex = 5
        '
        'txt_nombre_empleado
        '
        Me.txt_nombre_empleado.Location = New System.Drawing.Point(293, 77)
        Me.txt_nombre_empleado.Name = "txt_nombre_empleado"
        Me.txt_nombre_empleado.Size = New System.Drawing.Size(194, 23)
        Me.txt_nombre_empleado.TabIndex = 4
        '
        'txt_id_empleado
        '
        Me.txt_id_empleado.Location = New System.Drawing.Point(226, 77)
        Me.txt_id_empleado.Name = "txt_id_empleado"
        Me.txt_id_empleado.Size = New System.Drawing.Size(61, 23)
        Me.txt_id_empleado.TabIndex = 3
        '
        'lbl_empleado
        '
        Me.lbl_empleado.AutoSize = True
        Me.lbl_empleado.Location = New System.Drawing.Point(71, 77)
        Me.lbl_empleado.Name = "lbl_empleado"
        Me.lbl_empleado.Size = New System.Drawing.Size(60, 15)
        Me.lbl_empleado.TabIndex = 2
        Me.lbl_empleado.Text = "Empleado"
        Me.lbl_empleado.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lbl_empleado.UseMnemonic = False
        '
        'txt_numero_expediente
        '
        Me.txt_numero_expediente.Location = New System.Drawing.Point(226, 41)
        Me.txt_numero_expediente.Name = "txt_numero_expediente"
        Me.txt_numero_expediente.Size = New System.Drawing.Size(100, 23)
        Me.txt_numero_expediente.TabIndex = 1
        '
        'lbl_num_expediente
        '
        Me.lbl_num_expediente.AutoSize = True
        Me.lbl_num_expediente.Location = New System.Drawing.Point(71, 44)
        Me.lbl_num_expediente.Name = "lbl_num_expediente"
        Me.lbl_num_expediente.Size = New System.Drawing.Size(128, 15)
        Me.lbl_num_expediente.TabIndex = 0
        Me.lbl_num_expediente.Text = "Numero de Expediente"
        Me.lbl_num_expediente.UseMnemonic = False
        '
        'frm_Cita
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frm_Cita"
        Me.Text = "frm_Cita"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lbl_num_expediente As Label
    Friend WithEvents txt_numero_expediente As TextBox
    Friend WithEvents lbl_empleado As Label
    Friend WithEvents txt_nombre_empleado As TextBox
    Friend WithEvents txt_id_empleado As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents dtp_fecha_visita As DateTimePicker
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
End Class
