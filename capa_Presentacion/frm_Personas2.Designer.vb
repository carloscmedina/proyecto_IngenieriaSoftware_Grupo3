<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Personas2
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
        Me.dgv_Personas2 = New System.Windows.Forms.DataGridView()
        CType(Me.dgv_Personas2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv_Personas2
        '
        Me.dgv_Personas2.AllowUserToAddRows = False
        Me.dgv_Personas2.AllowUserToDeleteRows = False
        Me.dgv_Personas2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_Personas2.Location = New System.Drawing.Point(12, 12)
        Me.dgv_Personas2.Name = "dgv_Personas2"
        Me.dgv_Personas2.RowHeadersWidth = 51
        Me.dgv_Personas2.RowTemplate.Height = 29
        Me.dgv_Personas2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_Personas2.Size = New System.Drawing.Size(458, 232)
        Me.dgv_Personas2.TabIndex = 1
        '
        'frm_Personas2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(481, 260)
        Me.Controls.Add(Me.dgv_Personas2)
        Me.MaximizeBox = False
        Me.Name = "frm_Personas2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_Personas2"
        CType(Me.dgv_Personas2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgv_Personas2 As DataGridView
End Class
