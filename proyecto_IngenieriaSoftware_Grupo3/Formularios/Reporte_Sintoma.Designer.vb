<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Reporte_Sintoma
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
        Me.txt_id_Empleado = New System.Windows.Forms.TextBox()
        Me.txt_id_Reporte = New System.Windows.Forms.TextBox()
        Me.lbl_idReporte = New System.Windows.Forms.Label()
        Me.txt_desc = New System.Windows.Forms.TextBox()
        Me.lbl_desc = New System.Windows.Forms.Label()
        Me.Lbl_id_Empleado = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txt_id_Empleado)
        Me.GroupBox1.Controls.Add(Me.txt_id_Reporte)
        Me.GroupBox1.Controls.Add(Me.lbl_idReporte)
        Me.GroupBox1.Controls.Add(Me.txt_desc)
        Me.GroupBox1.Controls.Add(Me.lbl_desc)
        Me.GroupBox1.Controls.Add(Me.Lbl_id_Empleado)
        Me.GroupBox1.Location = New System.Drawing.Point(21, 60)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Size = New System.Drawing.Size(758, 236)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'txt_id_Empleado
        '
        Me.txt_id_Empleado.Location = New System.Drawing.Point(544, 26)
        Me.txt_id_Empleado.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_id_Empleado.Name = "txt_id_Empleado"
        Me.txt_id_Empleado.Size = New System.Drawing.Size(172, 31)
        Me.txt_id_Empleado.TabIndex = 22
        '
        'txt_id_Reporte
        '
        Me.txt_id_Reporte.Location = New System.Drawing.Point(225, 26)
        Me.txt_id_Reporte.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_id_Reporte.Name = "txt_id_Reporte"
        Me.txt_id_Reporte.Size = New System.Drawing.Size(172, 31)
        Me.txt_id_Reporte.TabIndex = 21
        '
        'lbl_idReporte
        '
        Me.lbl_idReporte.AutoSize = True
        Me.lbl_idReporte.Location = New System.Drawing.Point(22, 32)
        Me.lbl_idReporte.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_idReporte.Name = "lbl_idReporte"
        Me.lbl_idReporte.Size = New System.Drawing.Size(97, 25)
        Me.lbl_idReporte.TabIndex = 20
        Me.lbl_idReporte.Text = "ID Reporte"
        '
        'txt_desc
        '
        Me.txt_desc.Location = New System.Drawing.Point(225, 105)
        Me.txt_desc.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_desc.Name = "txt_desc"
        Me.txt_desc.Size = New System.Drawing.Size(491, 31)
        Me.txt_desc.TabIndex = 15
        '
        'lbl_desc
        '
        Me.lbl_desc.AutoSize = True
        Me.lbl_desc.Location = New System.Drawing.Point(22, 108)
        Me.lbl_desc.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_desc.Name = "lbl_desc"
        Me.lbl_desc.Size = New System.Drawing.Size(104, 25)
        Me.lbl_desc.TabIndex = 10
        Me.lbl_desc.Text = "Descripción"
        '
        'Lbl_id_Empleado
        '
        Me.Lbl_id_Empleado.AutoSize = True
        Me.Lbl_id_Empleado.Location = New System.Drawing.Point(421, 26)
        Me.Lbl_id_Empleado.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lbl_id_Empleado.Name = "Lbl_id_Empleado"
        Me.Lbl_id_Empleado.Size = New System.Drawing.Size(115, 25)
        Me.Lbl_id_Empleado.TabIndex = 0
        Me.Lbl_id_Empleado.Text = "ID Empleado"
        '
        'Reporte_Sintoma
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 336)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Reporte_Sintoma"
        Me.Text = "Reporte_Sintoma"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txt_id_Empleado As TextBox
    Friend WithEvents txt_id_Reporte As TextBox
    Friend WithEvents lbl_idReporte As Label
    Friend WithEvents txt_desc As TextBox
    Friend WithEvents lbl_desc As Label
    Friend WithEvents Lbl_id_Empleado As Label
End Class
