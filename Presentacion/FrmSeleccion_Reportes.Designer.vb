<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSeleccion_Reportes
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.OptAlumnos = New System.Windows.Forms.RadioButton()
        Me.OptBalance = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DTFecha = New System.Windows.Forms.DateTimePicker()
        Me.BtnVer = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BtnMostrar = New System.Windows.Forms.Button()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.Grilla = New System.Windows.Forms.DataGridView()
        Me.LblInexistente = New System.Windows.Forms.LinkLabel()
        Me.Limpiar = New System.Windows.Forms.Button()
        CType(Me.Grilla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, -16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(202, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Seleccione que tipo de reporte desea ver"
        '
        'OptAlumnos
        '
        Me.OptAlumnos.AutoSize = True
        Me.OptAlumnos.Location = New System.Drawing.Point(30, 59)
        Me.OptAlumnos.Name = "OptAlumnos"
        Me.OptAlumnos.Size = New System.Drawing.Size(65, 17)
        Me.OptAlumnos.TabIndex = 1
        Me.OptAlumnos.TabStop = True
        Me.OptAlumnos.Text = "Alumnos"
        Me.OptAlumnos.UseVisualStyleBackColor = True
        '
        'OptBalance
        '
        Me.OptBalance.AutoSize = True
        Me.OptBalance.Location = New System.Drawing.Point(30, 82)
        Me.OptBalance.Name = "OptBalance"
        Me.OptBalance.Size = New System.Drawing.Size(111, 17)
        Me.OptBalance.TabIndex = 2
        Me.OptBalance.TabStop = True
        Me.OptBalance.Text = "Balance de pagos"
        Me.OptBalance.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(146, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Fecha"
        '
        'DTFecha
        '
        Me.DTFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTFecha.Location = New System.Drawing.Point(190, 79)
        Me.DTFecha.Name = "DTFecha"
        Me.DTFecha.Size = New System.Drawing.Size(99, 20)
        Me.DTFecha.TabIndex = 4
        '
        'BtnVer
        '
        Me.BtnVer.Location = New System.Drawing.Point(376, 76)
        Me.BtnVer.Name = "BtnVer"
        Me.BtnVer.Size = New System.Drawing.Size(75, 23)
        Me.BtnVer.TabIndex = 7
        Me.BtnVer.Text = "Ver reporte"
        Me.BtnVer.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(27, 32)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(213, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Seleccione el tipo de reporte que desea ver"
        '
        'BtnMostrar
        '
        Me.BtnMostrar.Location = New System.Drawing.Point(295, 76)
        Me.BtnMostrar.Name = "BtnMostrar"
        Me.BtnMostrar.Size = New System.Drawing.Size(75, 23)
        Me.BtnMostrar.TabIndex = 10
        Me.BtnMostrar.Text = "Mostrar"
        Me.BtnMostrar.UseVisualStyleBackColor = True
        '
        'BtnSalir
        '
        Me.BtnSalir.Location = New System.Drawing.Point(538, 76)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(75, 23)
        Me.BtnSalir.TabIndex = 11
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'Grilla
        '
        Me.Grilla.AllowUserToAddRows = False
        Me.Grilla.AllowUserToDeleteRows = False
        Me.Grilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Grilla.Location = New System.Drawing.Point(30, 129)
        Me.Grilla.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Grilla.Name = "Grilla"
        Me.Grilla.ReadOnly = True
        Me.Grilla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Grilla.Size = New System.Drawing.Size(921, 314)
        Me.Grilla.TabIndex = 21
        '
        'LblInexistente
        '
        Me.LblInexistente.AutoSize = True
        Me.LblInexistente.Location = New System.Drawing.Point(411, 275)
        Me.LblInexistente.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblInexistente.Name = "LblInexistente"
        Me.LblInexistente.Size = New System.Drawing.Size(93, 13)
        Me.LblInexistente.TabIndex = 28
        Me.LblInexistente.TabStop = True
        Me.LblInexistente.Text = "Datos inexistentes"
        '
        'Limpiar
        '
        Me.Limpiar.Location = New System.Drawing.Point(457, 76)
        Me.Limpiar.Name = "Limpiar"
        Me.Limpiar.Size = New System.Drawing.Size(75, 23)
        Me.Limpiar.TabIndex = 29
        Me.Limpiar.Text = "Limpiar"
        Me.Limpiar.UseVisualStyleBackColor = True
        '
        'FrmSeleccion_Reportes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(962, 491)
        Me.Controls.Add(Me.Limpiar)
        Me.Controls.Add(Me.LblInexistente)
        Me.Controls.Add(Me.Grilla)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.BtnMostrar)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.BtnVer)
        Me.Controls.Add(Me.DTFecha)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.OptBalance)
        Me.Controls.Add(Me.OptAlumnos)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmSeleccion_Reportes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Seleccion de reportes"
        CType(Me.Grilla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents OptAlumnos As System.Windows.Forms.RadioButton
    Friend WithEvents OptBalance As System.Windows.Forms.RadioButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DTFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents BtnVer As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents BtnMostrar As System.Windows.Forms.Button
    Friend WithEvents BtnSalir As System.Windows.Forms.Button
    Friend WithEvents Grilla As System.Windows.Forms.DataGridView
    Friend WithEvents LblInexistente As System.Windows.Forms.LinkLabel
    Friend WithEvents Limpiar As System.Windows.Forms.Button
End Class
