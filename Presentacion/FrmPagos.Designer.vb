<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPagos
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
        Me.TBBuscar_Alumno = New System.Windows.Forms.Button()
        Me.TBNombre_Alumno = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TBID_Alumno = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DTFecha = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TBBuscar = New System.Windows.Forms.TextBox()
        Me.CBBuscar = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LblInexistente = New System.Windows.Forms.LinkLabel()
        Me.Grilla = New System.Windows.Forms.DataGridView()
        Me.ColEliminar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TBMonto = New System.Windows.Forms.TextBox()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.BtnEditar = New System.Windows.Forms.Button()
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.LblID_Pago = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Grilla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(65, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Pago Nro"
        '
        'TBBuscar_Alumno
        '
        Me.TBBuscar_Alumno.Location = New System.Drawing.Point(337, 73)
        Me.TBBuscar_Alumno.Name = "TBBuscar_Alumno"
        Me.TBBuscar_Alumno.Size = New System.Drawing.Size(49, 23)
        Me.TBBuscar_Alumno.TabIndex = 21
        Me.TBBuscar_Alumno.Text = "..."
        Me.TBBuscar_Alumno.UseVisualStyleBackColor = True
        '
        'TBNombre_Alumno
        '
        Me.TBNombre_Alumno.Location = New System.Drawing.Point(231, 74)
        Me.TBNombre_Alumno.Name = "TBNombre_Alumno"
        Me.TBNombre_Alumno.Size = New System.Drawing.Size(100, 20)
        Me.TBNombre_Alumno.TabIndex = 20
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(181, 77)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(44, 13)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Nombre"
        '
        'TBID_Alumno
        '
        Me.TBID_Alumno.Location = New System.Drawing.Point(129, 74)
        Me.TBID_Alumno.Name = "TBID_Alumno"
        Me.TBID_Alumno.Size = New System.Drawing.Size(46, 20)
        Me.TBID_Alumno.TabIndex = 18
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(105, 77)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(18, 13)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "ID"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(65, 77)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 13)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Alumno"
        '
        'DTFecha
        '
        Me.DTFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTFecha.Location = New System.Drawing.Point(108, 100)
        Me.DTFecha.Name = "DTFecha"
        Me.DTFecha.Size = New System.Drawing.Size(93, 20)
        Me.DTFecha.TabIndex = 23
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(65, 106)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Fecha"
        '
        'TBBuscar
        '
        Me.TBBuscar.Location = New System.Drawing.Point(210, 28)
        Me.TBBuscar.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.TBBuscar.Name = "TBBuscar"
        Me.TBBuscar.Size = New System.Drawing.Size(115, 20)
        Me.TBBuscar.TabIndex = 40
        '
        'CBBuscar
        '
        Me.CBBuscar.FormattingEnabled = True
        Me.CBBuscar.Location = New System.Drawing.Point(81, 27)
        Me.CBBuscar.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.CBBuscar.Name = "CBBuscar"
        Me.CBBuscar.Size = New System.Drawing.Size(123, 21)
        Me.CBBuscar.TabIndex = 39
        Me.CBBuscar.Text = "Nombre"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(14, 31)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 13)
        Me.Label7.TabIndex = 38
        Me.Label7.Text = "Buscar por:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LblInexistente)
        Me.GroupBox1.Controls.Add(Me.Grilla)
        Me.GroupBox1.Controls.Add(Me.CBBuscar)
        Me.GroupBox1.Controls.Add(Me.TBBuscar)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Location = New System.Drawing.Point(423, 38)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(474, 385)
        Me.GroupBox1.TabIndex = 42
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Listado de pago"
        '
        'LblInexistente
        '
        Me.LblInexistente.AutoSize = True
        Me.LblInexistente.Location = New System.Drawing.Point(231, 186)
        Me.LblInexistente.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblInexistente.Name = "LblInexistente"
        Me.LblInexistente.Size = New System.Drawing.Size(93, 13)
        Me.LblInexistente.TabIndex = 42
        Me.LblInexistente.TabStop = True
        Me.LblInexistente.Text = "Datos inexistentes"
        '
        'Grilla
        '
        Me.Grilla.AllowUserToAddRows = False
        Me.Grilla.AllowUserToDeleteRows = False
        Me.Grilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Grilla.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColEliminar})
        Me.Grilla.Location = New System.Drawing.Point(17, 54)
        Me.Grilla.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Grilla.Name = "Grilla"
        Me.Grilla.ReadOnly = True
        Me.Grilla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Grilla.Size = New System.Drawing.Size(443, 325)
        Me.Grilla.TabIndex = 41
        '
        'ColEliminar
        '
        Me.ColEliminar.HeaderText = "Eliminar"
        Me.ColEliminar.Name = "ColEliminar"
        Me.ColEliminar.ReadOnly = True
        Me.ColEliminar.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ColEliminar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(65, 131)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 43
        Me.Label3.Text = "Monto"
        '
        'TBMonto
        '
        Me.TBMonto.Location = New System.Drawing.Point(108, 128)
        Me.TBMonto.Name = "TBMonto"
        Me.TBMonto.Size = New System.Drawing.Size(93, 20)
        Me.TBMonto.TabIndex = 44
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Location = New System.Drawing.Point(231, 163)
        Me.BtnGuardar.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(74, 23)
        Me.BtnGuardar.TabIndex = 48
        Me.BtnGuardar.Text = "Siguiente ->"
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'BtnSalir
        '
        Me.BtnSalir.Location = New System.Drawing.Point(312, 163)
        Me.BtnSalir.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(74, 23)
        Me.BtnSalir.TabIndex = 47
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'BtnEditar
        '
        Me.BtnEditar.Location = New System.Drawing.Point(151, 163)
        Me.BtnEditar.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.BtnEditar.Name = "BtnEditar"
        Me.BtnEditar.Size = New System.Drawing.Size(74, 23)
        Me.BtnEditar.TabIndex = 46
        Me.BtnEditar.Text = "Editar"
        Me.BtnEditar.UseVisualStyleBackColor = True
        '
        'BtnNuevo
        '
        Me.BtnNuevo.Location = New System.Drawing.Point(68, 163)
        Me.BtnNuevo.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(74, 23)
        Me.BtnNuevo.TabIndex = 45
        Me.BtnNuevo.Text = "Nuevo"
        Me.BtnNuevo.UseVisualStyleBackColor = True
        '
        'LblID_Pago
        '
        Me.LblID_Pago.AutoSize = True
        Me.LblID_Pago.Location = New System.Drawing.Point(138, 50)
        Me.LblID_Pago.Name = "LblID_Pago"
        Me.LblID_Pago.Size = New System.Drawing.Size(0, 13)
        Me.LblID_Pago.TabIndex = 49
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(126, 50)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(14, 13)
        Me.Label6.TabIndex = 50
        Me.Label6.Text = "#"
        '
        'FrmPagos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(962, 491)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.LblID_Pago)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.BtnEditar)
        Me.Controls.Add(Me.BtnNuevo)
        Me.Controls.Add(Me.TBMonto)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DTFecha)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TBBuscar_Alumno)
        Me.Controls.Add(Me.TBNombre_Alumno)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TBID_Alumno)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmPagos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ingreso y control de pagos"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Grilla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TBBuscar_Alumno As System.Windows.Forms.Button
    Friend WithEvents TBNombre_Alumno As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TBID_Alumno As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents DTFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TBBuscar As System.Windows.Forms.TextBox
    Friend WithEvents CBBuscar As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TBMonto As System.Windows.Forms.TextBox
    Friend WithEvents BtnGuardar As System.Windows.Forms.Button
    Friend WithEvents BtnSalir As System.Windows.Forms.Button
    Friend WithEvents BtnEditar As System.Windows.Forms.Button
    Friend WithEvents BtnNuevo As System.Windows.Forms.Button
    Friend WithEvents Grilla As System.Windows.Forms.DataGridView
    Friend WithEvents ColEliminar As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents LblInexistente As System.Windows.Forms.LinkLabel
    Friend WithEvents LblID_Pago As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
End Class
