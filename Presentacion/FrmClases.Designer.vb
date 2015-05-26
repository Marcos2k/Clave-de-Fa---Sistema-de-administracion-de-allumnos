<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmClases
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DTFecha = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TBID_Alumno = New System.Windows.Forms.TextBox()
        Me.TBID_Profesor = New System.Windows.Forms.TextBox()
        Me.LblID_Clase = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TBNombre_Profesor = New System.Windows.Forms.TextBox()
        Me.TBNombre_Alumno = New System.Windows.Forms.TextBox()
        Me.TBBuscar_profesor = New System.Windows.Forms.Button()
        Me.TBBuscar_Alumno = New System.Windows.Forms.Button()
        Me.LblInexistente = New System.Windows.Forms.LinkLabel()
        Me.TBBuscar = New System.Windows.Forms.TextBox()
        Me.CBBuscar = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.CHKEliminar = New System.Windows.Forms.CheckBox()
        Me.Grilla = New System.Windows.Forms.DataGridView()
        Me.ColEliminar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.BtnEditar = New System.Windows.Forms.Button()
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.TBFlag = New System.Windows.Forms.TextBox()
        CType(Me.Grilla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(249, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID Clase"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(249, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Profesor"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(249, 96)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Alumno"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(249, 128)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Fecha"
        '
        'DTFecha
        '
        Me.DTFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTFecha.Location = New System.Drawing.Point(292, 122)
        Me.DTFecha.Name = "DTFecha"
        Me.DTFecha.Size = New System.Drawing.Size(93, 20)
        Me.DTFecha.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(302, 96)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(18, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "ID"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(301, 69)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(18, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "ID"
        '
        'TBID_Alumno
        '
        Me.TBID_Alumno.Location = New System.Drawing.Point(339, 91)
        Me.TBID_Alumno.Name = "TBID_Alumno"
        Me.TBID_Alumno.Size = New System.Drawing.Size(46, 20)
        Me.TBID_Alumno.TabIndex = 7
        '
        'TBID_Profesor
        '
        Me.TBID_Profesor.Location = New System.Drawing.Point(338, 66)
        Me.TBID_Profesor.Name = "TBID_Profesor"
        Me.TBID_Profesor.Size = New System.Drawing.Size(47, 20)
        Me.TBID_Profesor.TabIndex = 8
        '
        'LblID_Clase
        '
        Me.LblID_Clase.AutoSize = True
        Me.LblID_Clase.Location = New System.Drawing.Point(335, 41)
        Me.LblID_Clase.Name = "LblID_Clase"
        Me.LblID_Clase.Size = New System.Drawing.Size(0, 13)
        Me.LblID_Clase.TabIndex = 9
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(391, 69)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(44, 13)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Nombre"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(391, 96)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(44, 13)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "Nombre"
        '
        'TBNombre_Profesor
        '
        Me.TBNombre_Profesor.Location = New System.Drawing.Point(442, 65)
        Me.TBNombre_Profesor.Name = "TBNombre_Profesor"
        Me.TBNombre_Profesor.Size = New System.Drawing.Size(100, 20)
        Me.TBNombre_Profesor.TabIndex = 12
        '
        'TBNombre_Alumno
        '
        Me.TBNombre_Alumno.Location = New System.Drawing.Point(441, 93)
        Me.TBNombre_Alumno.Name = "TBNombre_Alumno"
        Me.TBNombre_Alumno.Size = New System.Drawing.Size(100, 20)
        Me.TBNombre_Alumno.TabIndex = 13
        '
        'TBBuscar_profesor
        '
        Me.TBBuscar_profesor.Location = New System.Drawing.Point(549, 59)
        Me.TBBuscar_profesor.Name = "TBBuscar_profesor"
        Me.TBBuscar_profesor.Size = New System.Drawing.Size(49, 23)
        Me.TBBuscar_profesor.TabIndex = 14
        Me.TBBuscar_profesor.Text = "..."
        Me.TBBuscar_profesor.UseVisualStyleBackColor = True
        '
        'TBBuscar_Alumno
        '
        Me.TBBuscar_Alumno.Location = New System.Drawing.Point(549, 88)
        Me.TBBuscar_Alumno.Name = "TBBuscar_Alumno"
        Me.TBBuscar_Alumno.Size = New System.Drawing.Size(49, 23)
        Me.TBBuscar_Alumno.TabIndex = 15
        Me.TBBuscar_Alumno.Text = "..."
        Me.TBBuscar_Alumno.UseVisualStyleBackColor = True
        '
        'LblInexistente
        '
        Me.LblInexistente.AutoSize = True
        Me.LblInexistente.Location = New System.Drawing.Point(434, 321)
        Me.LblInexistente.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblInexistente.Name = "LblInexistente"
        Me.LblInexistente.Size = New System.Drawing.Size(93, 13)
        Me.LblInexistente.TabIndex = 34
        Me.LblInexistente.TabStop = True
        Me.LblInexistente.Text = "Datos inexistentes"
        '
        'TBBuscar
        '
        Me.TBBuscar.Location = New System.Drawing.Point(587, 179)
        Me.TBBuscar.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.TBBuscar.Name = "TBBuscar"
        Me.TBBuscar.Size = New System.Drawing.Size(115, 20)
        Me.TBBuscar.TabIndex = 33
        '
        'CBBuscar
        '
        Me.CBBuscar.FormattingEnabled = True
        Me.CBBuscar.Location = New System.Drawing.Point(458, 178)
        Me.CBBuscar.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.CBBuscar.Name = "CBBuscar"
        Me.CBBuscar.Size = New System.Drawing.Size(123, 21)
        Me.CBBuscar.TabIndex = 32
        Me.CBBuscar.Text = "Profesor"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(391, 182)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 13)
        Me.Label7.TabIndex = 31
        Me.Label7.Text = "Buscar por:"
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Location = New System.Drawing.Point(318, 178)
        Me.BtnEliminar.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(74, 23)
        Me.BtnEliminar.TabIndex = 30
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.UseVisualStyleBackColor = True
        '
        'CHKEliminar
        '
        Me.CHKEliminar.AutoSize = True
        Me.CHKEliminar.Location = New System.Drawing.Point(251, 182)
        Me.CHKEliminar.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.CHKEliminar.Name = "CHKEliminar"
        Me.CHKEliminar.Size = New System.Drawing.Size(62, 17)
        Me.CHKEliminar.TabIndex = 29
        Me.CHKEliminar.Text = "Eliminar"
        Me.CHKEliminar.UseVisualStyleBackColor = True
        '
        'Grilla
        '
        Me.Grilla.AllowUserToAddRows = False
        Me.Grilla.AllowUserToDeleteRows = False
        Me.Grilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Grilla.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColEliminar})
        Me.Grilla.Location = New System.Drawing.Point(251, 205)
        Me.Grilla.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Grilla.Name = "Grilla"
        Me.Grilla.ReadOnly = True
        Me.Grilla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Grilla.Size = New System.Drawing.Size(451, 211)
        Me.Grilla.TabIndex = 28
        '
        'ColEliminar
        '
        Me.ColEliminar.HeaderText = "Eliminar"
        Me.ColEliminar.Name = "ColEliminar"
        Me.ColEliminar.ReadOnly = True
        Me.ColEliminar.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ColEliminar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Location = New System.Drawing.Point(620, 99)
        Me.BtnGuardar.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(74, 23)
        Me.BtnGuardar.TabIndex = 38
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'BtnSalir
        '
        Me.BtnSalir.Location = New System.Drawing.Point(621, 128)
        Me.BtnSalir.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(74, 23)
        Me.BtnSalir.TabIndex = 37
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'BtnEditar
        '
        Me.BtnEditar.Location = New System.Drawing.Point(621, 69)
        Me.BtnEditar.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.BtnEditar.Name = "BtnEditar"
        Me.BtnEditar.Size = New System.Drawing.Size(74, 23)
        Me.BtnEditar.TabIndex = 36
        Me.BtnEditar.Text = "Editar"
        Me.BtnEditar.UseVisualStyleBackColor = True
        '
        'BtnNuevo
        '
        Me.BtnNuevo.Location = New System.Drawing.Point(620, 41)
        Me.BtnNuevo.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(74, 23)
        Me.BtnNuevo.TabIndex = 35
        Me.BtnNuevo.Text = "Nuevo"
        Me.BtnNuevo.UseVisualStyleBackColor = True
        '
        'TBFlag
        '
        Me.TBFlag.Location = New System.Drawing.Point(251, 13)
        Me.TBFlag.Name = "TBFlag"
        Me.TBFlag.Size = New System.Drawing.Size(45, 20)
        Me.TBFlag.TabIndex = 39
        '
        'FrmClases
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(962, 491)
        Me.Controls.Add(Me.TBFlag)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.BtnEditar)
        Me.Controls.Add(Me.BtnNuevo)
        Me.Controls.Add(Me.LblInexistente)
        Me.Controls.Add(Me.TBBuscar)
        Me.Controls.Add(Me.CBBuscar)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.BtnEliminar)
        Me.Controls.Add(Me.CHKEliminar)
        Me.Controls.Add(Me.Grilla)
        Me.Controls.Add(Me.TBBuscar_Alumno)
        Me.Controls.Add(Me.TBBuscar_profesor)
        Me.Controls.Add(Me.TBNombre_Alumno)
        Me.Controls.Add(Me.TBNombre_Profesor)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.LblID_Clase)
        Me.Controls.Add(Me.TBID_Profesor)
        Me.Controls.Add(Me.TBID_Alumno)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.DTFecha)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmClases"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registro y control de clases"
        CType(Me.Grilla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents DTFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TBID_Alumno As System.Windows.Forms.TextBox
    Friend WithEvents TBID_Profesor As System.Windows.Forms.TextBox
    Friend WithEvents LblID_Clase As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TBNombre_Profesor As System.Windows.Forms.TextBox
    Friend WithEvents TBNombre_Alumno As System.Windows.Forms.TextBox
    Friend WithEvents TBBuscar_profesor As System.Windows.Forms.Button
    Friend WithEvents TBBuscar_Alumno As System.Windows.Forms.Button
    Friend WithEvents LblInexistente As System.Windows.Forms.LinkLabel
    Friend WithEvents TBBuscar As System.Windows.Forms.TextBox
    Friend WithEvents CBBuscar As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents BtnEliminar As System.Windows.Forms.Button
    Friend WithEvents CHKEliminar As System.Windows.Forms.CheckBox
    Friend WithEvents Grilla As System.Windows.Forms.DataGridView
    Friend WithEvents ColEliminar As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents BtnGuardar As System.Windows.Forms.Button
    Friend WithEvents BtnSalir As System.Windows.Forms.Button
    Friend WithEvents BtnEditar As System.Windows.Forms.Button
    Friend WithEvents BtnNuevo As System.Windows.Forms.Button
    Friend WithEvents TBFlag As System.Windows.Forms.TextBox
End Class
