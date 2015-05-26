<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmUsuario
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
        Me.TBUsuario = New System.Windows.Forms.TextBox()
        Me.TBContraseña = New System.Windows.Forms.TextBox()
        Me.TBNombre = New System.Windows.Forms.TextBox()
        Me.TBApellido = New System.Windows.Forms.TextBox()
        Me.TBDni = New System.Windows.Forms.TextBox()
        Me.TBDomicilio = New System.Windows.Forms.TextBox()
        Me.TBTelefono = New System.Windows.Forms.TextBox()
        Me.TBSueldo = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Lblinexistente = New System.Windows.Forms.LinkLabel()
        Me.TBBuscar = New System.Windows.Forms.TextBox()
        Me.Grilla = New System.Windows.Forms.DataGridView()
        Me.ColEliminar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.CBBuscar = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.CHKEliminar = New System.Windows.Forms.CheckBox()
        Me.LblID = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.CBAcceso = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.BtnAgregar = New System.Windows.Forms.Button()
        Me.BtnEditar = New System.Windows.Forms.Button()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.TBFlag = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Grilla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TBUsuario
        '
        Me.TBUsuario.Location = New System.Drawing.Point(72, 42)
        Me.TBUsuario.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.TBUsuario.MaxLength = 20
        Me.TBUsuario.Name = "TBUsuario"
        Me.TBUsuario.Size = New System.Drawing.Size(129, 20)
        Me.TBUsuario.TabIndex = 2
        '
        'TBContraseña
        '
        Me.TBContraseña.Location = New System.Drawing.Point(280, 42)
        Me.TBContraseña.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.TBContraseña.MaxLength = 20
        Me.TBContraseña.Name = "TBContraseña"
        Me.TBContraseña.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TBContraseña.Size = New System.Drawing.Size(129, 20)
        Me.TBContraseña.TabIndex = 3
        '
        'TBNombre
        '
        Me.TBNombre.Location = New System.Drawing.Point(72, 68)
        Me.TBNombre.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.TBNombre.MaxLength = 20
        Me.TBNombre.Name = "TBNombre"
        Me.TBNombre.Size = New System.Drawing.Size(129, 20)
        Me.TBNombre.TabIndex = 4
        '
        'TBApellido
        '
        Me.TBApellido.Location = New System.Drawing.Point(280, 68)
        Me.TBApellido.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.TBApellido.MaxLength = 20
        Me.TBApellido.Name = "TBApellido"
        Me.TBApellido.Size = New System.Drawing.Size(129, 20)
        Me.TBApellido.TabIndex = 5
        '
        'TBDni
        '
        Me.TBDni.Location = New System.Drawing.Point(72, 94)
        Me.TBDni.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.TBDni.MaxLength = 12
        Me.TBDni.Name = "TBDni"
        Me.TBDni.Size = New System.Drawing.Size(129, 20)
        Me.TBDni.TabIndex = 6
        '
        'TBDomicilio
        '
        Me.TBDomicilio.Location = New System.Drawing.Point(280, 94)
        Me.TBDomicilio.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.TBDomicilio.MaxLength = 20
        Me.TBDomicilio.Name = "TBDomicilio"
        Me.TBDomicilio.Size = New System.Drawing.Size(129, 20)
        Me.TBDomicilio.TabIndex = 7
        '
        'TBTelefono
        '
        Me.TBTelefono.Location = New System.Drawing.Point(72, 120)
        Me.TBTelefono.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.TBTelefono.MaxLength = 12
        Me.TBTelefono.Name = "TBTelefono"
        Me.TBTelefono.Size = New System.Drawing.Size(129, 20)
        Me.TBTelefono.TabIndex = 9
        '
        'TBSueldo
        '
        Me.TBSueldo.Location = New System.Drawing.Point(280, 120)
        Me.TBSueldo.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.TBSueldo.MaxLength = 20
        Me.TBSueldo.Name = "TBSueldo"
        Me.TBSueldo.Size = New System.Drawing.Size(129, 20)
        Me.TBSueldo.TabIndex = 10
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Lblinexistente)
        Me.GroupBox1.Controls.Add(Me.TBBuscar)
        Me.GroupBox1.Controls.Add(Me.Grilla)
        Me.GroupBox1.Controls.Add(Me.CBBuscar)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.BtnEliminar)
        Me.GroupBox1.Controls.Add(Me.CHKEliminar)
        Me.GroupBox1.Location = New System.Drawing.Point(455, 37)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(501, 412)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Listado de usuarios"
        '
        'Lblinexistente
        '
        Me.Lblinexistente.AutoSize = True
        Me.Lblinexistente.Location = New System.Drawing.Point(212, 252)
        Me.Lblinexistente.Name = "Lblinexistente"
        Me.Lblinexistente.Size = New System.Drawing.Size(93, 13)
        Me.Lblinexistente.TabIndex = 32
        Me.Lblinexistente.TabStop = True
        Me.Lblinexistente.Text = "Datos inexistentes"
        '
        'TBBuscar
        '
        Me.TBBuscar.Location = New System.Drawing.Point(357, 41)
        Me.TBBuscar.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.TBBuscar.Name = "TBBuscar"
        Me.TBBuscar.Size = New System.Drawing.Size(131, 20)
        Me.TBBuscar.TabIndex = 31
        '
        'Grilla
        '
        Me.Grilla.AllowUserToAddRows = False
        Me.Grilla.AllowUserToDeleteRows = False
        Me.Grilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Grilla.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColEliminar})
        Me.Grilla.Location = New System.Drawing.Point(12, 71)
        Me.Grilla.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Grilla.Name = "Grilla"
        Me.Grilla.ReadOnly = True
        Me.Grilla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Grilla.Size = New System.Drawing.Size(476, 327)
        Me.Grilla.TabIndex = 33
        '
        'ColEliminar
        '
        Me.ColEliminar.HeaderText = "Eliminar"
        Me.ColEliminar.Name = "ColEliminar"
        Me.ColEliminar.ReadOnly = True
        Me.ColEliminar.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ColEliminar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'CBBuscar
        '
        Me.CBBuscar.FormattingEnabled = True
        Me.CBBuscar.Location = New System.Drawing.Point(228, 40)
        Me.CBBuscar.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.CBBuscar.Name = "CBBuscar"
        Me.CBBuscar.Size = New System.Drawing.Size(123, 21)
        Me.CBBuscar.TabIndex = 30
        Me.CBBuscar.Text = "Dni"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(161, 44)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(61, 13)
        Me.Label11.TabIndex = 29
        Me.Label11.Text = "Buscar por:"
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Location = New System.Drawing.Point(78, 40)
        Me.BtnEliminar.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(74, 23)
        Me.BtnEliminar.TabIndex = 28
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.UseVisualStyleBackColor = True
        '
        'CHKEliminar
        '
        Me.CHKEliminar.AutoSize = True
        Me.CHKEliminar.Location = New System.Drawing.Point(11, 44)
        Me.CHKEliminar.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.CHKEliminar.Name = "CHKEliminar"
        Me.CHKEliminar.Size = New System.Drawing.Size(62, 17)
        Me.CHKEliminar.TabIndex = 27
        Me.CHKEliminar.Text = "Eliminar"
        Me.CHKEliminar.UseVisualStyleBackColor = True
        '
        'LblID
        '
        Me.LblID.AutoSize = True
        Me.LblID.Location = New System.Drawing.Point(75, 16)
        Me.LblID.Name = "LblID"
        Me.LblID.Size = New System.Drawing.Size(0, 13)
        Me.LblID.TabIndex = 13
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(18, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Usuario"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(206, 45)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Contraseña"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(18, 71)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 13)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Nombre"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(206, 71)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 13)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Apellido"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(19, 97)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(23, 13)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Dni"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(206, 97)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 13)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "Domicilio"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(19, 123)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(49, 13)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "Telefono"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(206, 123)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(40, 13)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "Sueldo"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(19, 151)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(42, 13)
        Me.Label10.TabIndex = 23
        Me.Label10.Text = "Acesso"
        '
        'CBAcceso
        '
        Me.CBAcceso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBAcceso.FormattingEnabled = True
        Me.CBAcceso.Location = New System.Drawing.Point(72, 147)
        Me.CBAcceso.Name = "CBAcceso"
        Me.CBAcceso.Size = New System.Drawing.Size(129, 21)
        Me.CBAcceso.TabIndex = 24
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.CBAcceso)
        Me.GroupBox2.Controls.Add(Me.TBUsuario)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.TBContraseña)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.TBNombre)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.TBApellido)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.TBDni)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.TBDomicilio)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.TBTelefono)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.TBSueldo)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.LblID)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Location = New System.Drawing.Point(22, 37)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(427, 182)
        Me.GroupBox2.TabIndex = 26
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos de los usuarios"
        '
        'BtnNuevo
        '
        Me.BtnNuevo.Location = New System.Drawing.Point(56, 247)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(75, 23)
        Me.BtnNuevo.TabIndex = 27
        Me.BtnNuevo.Text = "Nuevo"
        Me.BtnNuevo.UseVisualStyleBackColor = True
        '
        'BtnAgregar
        '
        Me.BtnAgregar.Location = New System.Drawing.Point(148, 247)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.Size = New System.Drawing.Size(75, 23)
        Me.BtnAgregar.TabIndex = 28
        Me.BtnAgregar.Text = "Agregar"
        Me.BtnAgregar.UseVisualStyleBackColor = True
        '
        'BtnEditar
        '
        Me.BtnEditar.Location = New System.Drawing.Point(243, 247)
        Me.BtnEditar.Name = "BtnEditar"
        Me.BtnEditar.Size = New System.Drawing.Size(75, 23)
        Me.BtnEditar.TabIndex = 29
        Me.BtnEditar.Text = "Editar"
        Me.BtnEditar.UseVisualStyleBackColor = True
        '
        'BtnSalir
        '
        Me.BtnSalir.Location = New System.Drawing.Point(335, 247)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(75, 23)
        Me.BtnSalir.TabIndex = 30
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'TBFlag
        '
        Me.TBFlag.Location = New System.Drawing.Point(22, 11)
        Me.TBFlag.Name = "TBFlag"
        Me.TBFlag.Size = New System.Drawing.Size(67, 20)
        Me.TBFlag.TabIndex = 35
        '
        'FrmUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(962, 491)
        Me.Controls.Add(Me.TBFlag)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.BtnEditar)
        Me.Controls.Add(Me.BtnAgregar)
        Me.Controls.Add(Me.BtnNuevo)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FrmUsuario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Control de usuarios"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Grilla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TBUsuario As System.Windows.Forms.TextBox
    Friend WithEvents TBContraseña As System.Windows.Forms.TextBox
    Friend WithEvents TBNombre As System.Windows.Forms.TextBox
    Friend WithEvents TBApellido As System.Windows.Forms.TextBox
    Friend WithEvents TBDni As System.Windows.Forms.TextBox
    Friend WithEvents TBDomicilio As System.Windows.Forms.TextBox
    Friend WithEvents TBTelefono As System.Windows.Forms.TextBox
    Friend WithEvents TBSueldo As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents LblID As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents CBAcceso As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnNuevo As System.Windows.Forms.Button
    Friend WithEvents BtnAgregar As System.Windows.Forms.Button
    Friend WithEvents BtnEditar As System.Windows.Forms.Button
    Friend WithEvents BtnSalir As System.Windows.Forms.Button
    Friend WithEvents TBBuscar As System.Windows.Forms.TextBox
    Friend WithEvents CBBuscar As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents BtnEliminar As System.Windows.Forms.Button
    Friend WithEvents CHKEliminar As System.Windows.Forms.CheckBox
    Friend WithEvents Lblinexistente As System.Windows.Forms.LinkLabel
    Friend WithEvents Grilla As System.Windows.Forms.DataGridView
    Friend WithEvents ColEliminar As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents TBFlag As System.Windows.Forms.TextBox
End Class
