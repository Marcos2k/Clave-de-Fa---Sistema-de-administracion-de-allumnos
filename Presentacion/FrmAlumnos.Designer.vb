<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAlumnos
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
        Me.components = New System.ComponentModel.Container()
        Me.TBDni = New System.Windows.Forms.TextBox()
        Me.TBNombre = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TBDomicilio = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TBTelefono = New System.Windows.Forms.TextBox()
        Me.TBApellido = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TBClase = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TBObservacion = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TBSaldo = New System.Windows.Forms.TextBox()
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.BtnEditar = New System.Windows.Forms.Button()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.Grilla = New System.Windows.Forms.DataGridView()
        Me.ColEliminar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.CHKEliminar = New System.Windows.Forms.CheckBox()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.CBBuscar = New System.Windows.Forms.ComboBox()
        Me.TBBuscar = New System.Windows.Forms.TextBox()
        Me.LblInexistente = New System.Windows.Forms.LinkLabel()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TBID_Alumno = New System.Windows.Forms.Label()
        Me.TBFlag = New System.Windows.Forms.TextBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Label13 = New System.Windows.Forms.Label()
        Me.CBEstado = New System.Windows.Forms.ComboBox()
        CType(Me.Grilla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TBDni
        '
        Me.TBDni.Location = New System.Drawing.Point(294, 67)
        Me.TBDni.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.TBDni.MaxLength = 12
        Me.TBDni.Name = "TBDni"
        Me.TBDni.Size = New System.Drawing.Size(129, 20)
        Me.TBDni.TabIndex = 0
        '
        'TBNombre
        '
        Me.TBNombre.Location = New System.Drawing.Point(294, 33)
        Me.TBNombre.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.TBNombre.MaxLength = 20
        Me.TBNombre.Name = "TBNombre"
        Me.TBNombre.Size = New System.Drawing.Size(129, 20)
        Me.TBNombre.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(237, 36)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Nombre"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(428, 36)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Apellido/s"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(237, 70)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(23, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Dni"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(237, 107)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Domicilio"
        '
        'TBDomicilio
        '
        Me.TBDomicilio.Location = New System.Drawing.Point(294, 103)
        Me.TBDomicilio.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.TBDomicilio.MaxLength = 50
        Me.TBDomicilio.Name = "TBDomicilio"
        Me.TBDomicilio.Size = New System.Drawing.Size(335, 20)
        Me.TBDomicilio.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(430, 70)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Telefono"
        '
        'TBTelefono
        '
        Me.TBTelefono.Location = New System.Drawing.Point(488, 67)
        Me.TBTelefono.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.TBTelefono.MaxLength = 12
        Me.TBTelefono.Name = "TBTelefono"
        Me.TBTelefono.Size = New System.Drawing.Size(141, 20)
        Me.TBTelefono.TabIndex = 8
        '
        'TBApellido
        '
        Me.TBApellido.Location = New System.Drawing.Point(488, 33)
        Me.TBApellido.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.TBApellido.MaxLength = 20
        Me.TBApellido.Name = "TBApellido"
        Me.TBApellido.Size = New System.Drawing.Size(141, 20)
        Me.TBApellido.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(424, 143)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(93, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Instrumento/Clase"
        '
        'TBClase
        '
        Me.TBClase.Location = New System.Drawing.Point(523, 140)
        Me.TBClase.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.TBClase.MaxLength = 20
        Me.TBClase.Name = "TBClase"
        Me.TBClase.Size = New System.Drawing.Size(100, 20)
        Me.TBClase.TabIndex = 12
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(235, 143)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(188, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "* Observaciones (Max 140 caracteres)"
        '
        'TBObservacion
        '
        Me.TBObservacion.Location = New System.Drawing.Point(240, 159)
        Me.TBObservacion.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.TBObservacion.MaxLength = 140
        Me.TBObservacion.Multiline = True
        Me.TBObservacion.Name = "TBObservacion"
        Me.TBObservacion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TBObservacion.Size = New System.Drawing.Size(176, 45)
        Me.TBObservacion.TabIndex = 14
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(426, 187)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(34, 13)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Saldo"
        '
        'TBSaldo
        '
        Me.TBSaldo.Location = New System.Drawing.Point(466, 184)
        Me.TBSaldo.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.TBSaldo.MaxLength = 6
        Me.TBSaldo.Name = "TBSaldo"
        Me.TBSaldo.Size = New System.Drawing.Size(100, 20)
        Me.TBSaldo.TabIndex = 15
        '
        'BtnNuevo
        '
        Me.BtnNuevo.Location = New System.Drawing.Point(649, 31)
        Me.BtnNuevo.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(74, 23)
        Me.BtnNuevo.TabIndex = 17
        Me.BtnNuevo.Text = "Nuevo"
        Me.BtnNuevo.UseVisualStyleBackColor = True
        '
        'BtnEditar
        '
        Me.BtnEditar.Location = New System.Drawing.Point(649, 67)
        Me.BtnEditar.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.BtnEditar.Name = "BtnEditar"
        Me.BtnEditar.Size = New System.Drawing.Size(74, 23)
        Me.BtnEditar.TabIndex = 18
        Me.BtnEditar.Text = "Editar"
        Me.BtnEditar.UseVisualStyleBackColor = True
        '
        'BtnSalir
        '
        Me.BtnSalir.Location = New System.Drawing.Point(649, 138)
        Me.BtnSalir.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(74, 23)
        Me.BtnSalir.TabIndex = 19
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'Grilla
        '
        Me.Grilla.AllowUserToAddRows = False
        Me.Grilla.AllowUserToDeleteRows = False
        Me.Grilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Grilla.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColEliminar})
        Me.Grilla.Location = New System.Drawing.Point(240, 246)
        Me.Grilla.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Grilla.Name = "Grilla"
        Me.Grilla.ReadOnly = True
        Me.Grilla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Grilla.Size = New System.Drawing.Size(476, 211)
        Me.Grilla.TabIndex = 20
        '
        'ColEliminar
        '
        Me.ColEliminar.HeaderText = "Eliminar"
        Me.ColEliminar.Name = "ColEliminar"
        Me.ColEliminar.ReadOnly = True
        Me.ColEliminar.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ColEliminar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'CHKEliminar
        '
        Me.CHKEliminar.AutoSize = True
        Me.CHKEliminar.Location = New System.Drawing.Point(240, 223)
        Me.CHKEliminar.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.CHKEliminar.Name = "CHKEliminar"
        Me.CHKEliminar.Size = New System.Drawing.Size(62, 17)
        Me.CHKEliminar.TabIndex = 21
        Me.CHKEliminar.Text = "Eliminar"
        Me.CHKEliminar.UseVisualStyleBackColor = True
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Location = New System.Drawing.Point(307, 219)
        Me.BtnEliminar.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(74, 23)
        Me.BtnEliminar.TabIndex = 22
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(390, 223)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(61, 13)
        Me.Label9.TabIndex = 24
        Me.Label9.Text = "Buscar por:"
        '
        'CBBuscar
        '
        Me.CBBuscar.FormattingEnabled = True
        Me.CBBuscar.Location = New System.Drawing.Point(457, 219)
        Me.CBBuscar.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.CBBuscar.Name = "CBBuscar"
        Me.CBBuscar.Size = New System.Drawing.Size(123, 21)
        Me.CBBuscar.TabIndex = 25
        Me.CBBuscar.Text = "Dni"
        '
        'TBBuscar
        '
        Me.TBBuscar.Location = New System.Drawing.Point(586, 220)
        Me.TBBuscar.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.TBBuscar.Name = "TBBuscar"
        Me.TBBuscar.Size = New System.Drawing.Size(131, 20)
        Me.TBBuscar.TabIndex = 26
        '
        'LblInexistente
        '
        Me.LblInexistente.AutoSize = True
        Me.LblInexistente.Location = New System.Drawing.Point(433, 362)
        Me.LblInexistente.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblInexistente.Name = "LblInexistente"
        Me.LblInexistente.Size = New System.Drawing.Size(93, 13)
        Me.LblInexistente.TabIndex = 27
        Me.LblInexistente.TabStop = True
        Me.LblInexistente.Text = "Datos inexistentes"
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Location = New System.Drawing.Point(650, 103)
        Me.BtnGuardar.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(74, 23)
        Me.BtnGuardar.TabIndex = 28
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(244, 469)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(106, 13)
        Me.Label11.TabIndex = 30
        Me.Label11.Text = "* Campos opcionales"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(236, 8)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(18, 13)
        Me.Label12.TabIndex = 32
        Me.Label12.Text = "ID"
        '
        'TBID_Alumno
        '
        Me.TBID_Alumno.AutoSize = True
        Me.TBID_Alumno.Location = New System.Drawing.Point(291, 8)
        Me.TBID_Alumno.Name = "TBID_Alumno"
        Me.TBID_Alumno.Size = New System.Drawing.Size(0, 13)
        Me.TBID_Alumno.TabIndex = 33
        '
        'TBFlag
        '
        Me.TBFlag.Location = New System.Drawing.Point(766, 8)
        Me.TBFlag.Name = "TBFlag"
        Me.TBFlag.Size = New System.Drawing.Size(67, 20)
        Me.TBFlag.TabIndex = 34
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(571, 187)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(40, 13)
        Me.Label13.TabIndex = 35
        Me.Label13.Text = "Estado"
        '
        'CBEstado
        '
        Me.CBEstado.FormattingEnabled = True
        Me.CBEstado.Location = New System.Drawing.Point(618, 182)
        Me.CBEstado.Name = "CBEstado"
        Me.CBEstado.Size = New System.Drawing.Size(105, 21)
        Me.CBEstado.TabIndex = 36
        '
        'FrmAlumnos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(962, 491)
        Me.Controls.Add(Me.CBEstado)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.TBFlag)
        Me.Controls.Add(Me.TBID_Alumno)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Controls.Add(Me.LblInexistente)
        Me.Controls.Add(Me.TBBuscar)
        Me.Controls.Add(Me.CBBuscar)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.BtnEliminar)
        Me.Controls.Add(Me.CHKEliminar)
        Me.Controls.Add(Me.Grilla)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.BtnEditar)
        Me.Controls.Add(Me.BtnNuevo)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TBSaldo)
        Me.Controls.Add(Me.TBObservacion)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TBClase)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TBApellido)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TBTelefono)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TBDomicilio)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TBNombre)
        Me.Controls.Add(Me.TBDni)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Name = "FrmAlumnos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Clave de Fa-Alumnos"
        CType(Me.Grilla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TBDni As System.Windows.Forms.TextBox
    Friend WithEvents TBNombre As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TBDomicilio As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TBTelefono As System.Windows.Forms.TextBox
    Friend WithEvents TBApellido As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TBClase As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TBObservacion As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TBSaldo As System.Windows.Forms.TextBox
    Friend WithEvents BtnNuevo As System.Windows.Forms.Button
    Friend WithEvents BtnEditar As System.Windows.Forms.Button
    Friend WithEvents BtnSalir As System.Windows.Forms.Button
    Friend WithEvents Grilla As System.Windows.Forms.DataGridView
    Friend WithEvents CHKEliminar As System.Windows.Forms.CheckBox
    Friend WithEvents BtnEliminar As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents CBBuscar As System.Windows.Forms.ComboBox
    Friend WithEvents TBBuscar As System.Windows.Forms.TextBox
    Friend WithEvents LblInexistente As System.Windows.Forms.LinkLabel
    Friend WithEvents ColEliminar As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents BtnGuardar As System.Windows.Forms.Button
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents TBID_Alumno As System.Windows.Forms.Label
    Friend WithEvents TBFlag As System.Windows.Forms.TextBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents CBEstado As System.Windows.Forms.ComboBox

End Class
