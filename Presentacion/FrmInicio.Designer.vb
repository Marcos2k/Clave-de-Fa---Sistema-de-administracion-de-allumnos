<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmInicio
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmInicio))
        Me.PBClases = New System.Windows.Forms.PictureBox()
        Me.PBPagos = New System.Windows.Forms.PictureBox()
        Me.PBAlumnos = New System.Windows.Forms.PictureBox()
        Me.PBReportes = New System.Windows.Forms.PictureBox()
        Me.PBSalir = New System.Windows.Forms.PictureBox()
        Me.PBUsuarios = New System.Windows.Forms.PictureBox()
        Me.LblAlumnos = New System.Windows.Forms.Label()
        Me.LlbClases = New System.Windows.Forms.Label()
        Me.LblPagos = New System.Windows.Forms.Label()
        Me.LblReportes = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LblUsuarios = New System.Windows.Forms.Label()
        Me.LblNombre = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PBBackup = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.PBClases, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBPagos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBAlumnos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBReportes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBSalir, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBBackup, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PBClases
        '
        Me.PBClases.BackgroundImage = Global.Clave_de_Fa.My.Resources.Resources.Clases
        Me.PBClases.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PBClases.Location = New System.Drawing.Point(275, 44)
        Me.PBClases.Name = "PBClases"
        Me.PBClases.Size = New System.Drawing.Size(175, 175)
        Me.PBClases.TabIndex = 1
        Me.PBClases.TabStop = False
        '
        'PBPagos
        '
        Me.PBPagos.BackgroundImage = Global.Clave_de_Fa.My.Resources.Resources.Pagos
        Me.PBPagos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PBPagos.Location = New System.Drawing.Point(478, 291)
        Me.PBPagos.Name = "PBPagos"
        Me.PBPagos.Size = New System.Drawing.Size(175, 175)
        Me.PBPagos.TabIndex = 6
        Me.PBPagos.TabStop = False
        '
        'PBAlumnos
        '
        Me.PBAlumnos.BackgroundImage = Global.Clave_de_Fa.My.Resources.Resources.Alumnos
        Me.PBAlumnos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PBAlumnos.Location = New System.Drawing.Point(71, 44)
        Me.PBAlumnos.Name = "PBAlumnos"
        Me.PBAlumnos.Size = New System.Drawing.Size(175, 175)
        Me.PBAlumnos.TabIndex = 7
        Me.PBAlumnos.TabStop = False
        '
        'PBReportes
        '
        Me.PBReportes.BackgroundImage = Global.Clave_de_Fa.My.Resources.Resources.Report
        Me.PBReportes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PBReportes.Location = New System.Drawing.Point(71, 291)
        Me.PBReportes.Name = "PBReportes"
        Me.PBReportes.Size = New System.Drawing.Size(175, 175)
        Me.PBReportes.TabIndex = 10
        Me.PBReportes.TabStop = False
        '
        'PBSalir
        '
        Me.PBSalir.BackgroundImage = Global.Clave_de_Fa.My.Resources.Resources.Salir
        Me.PBSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PBSalir.Location = New System.Drawing.Point(685, 44)
        Me.PBSalir.Name = "PBSalir"
        Me.PBSalir.Size = New System.Drawing.Size(175, 175)
        Me.PBSalir.TabIndex = 9
        Me.PBSalir.TabStop = False
        '
        'PBUsuarios
        '
        Me.PBUsuarios.BackgroundImage = Global.Clave_de_Fa.My.Resources.Resources.Usuarios
        Me.PBUsuarios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PBUsuarios.Location = New System.Drawing.Point(275, 291)
        Me.PBUsuarios.Name = "PBUsuarios"
        Me.PBUsuarios.Size = New System.Drawing.Size(175, 175)
        Me.PBUsuarios.TabIndex = 8
        Me.PBUsuarios.TabStop = False
        '
        'LblAlumnos
        '
        Me.LblAlumnos.AutoSize = True
        Me.LblAlumnos.BackColor = System.Drawing.Color.Transparent
        Me.LblAlumnos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAlumnos.Location = New System.Drawing.Point(126, 222)
        Me.LblAlumnos.Name = "LblAlumnos"
        Me.LblAlumnos.Size = New System.Drawing.Size(71, 20)
        Me.LblAlumnos.TabIndex = 11
        Me.LblAlumnos.Text = "Alumnos"
        '
        'LlbClases
        '
        Me.LlbClases.AutoSize = True
        Me.LlbClases.BackColor = System.Drawing.Color.Transparent
        Me.LlbClases.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LlbClases.Location = New System.Drawing.Point(324, 222)
        Me.LlbClases.Name = "LlbClases"
        Me.LlbClases.Size = New System.Drawing.Size(57, 20)
        Me.LlbClases.TabIndex = 12
        Me.LlbClases.Text = "Clases"
        '
        'LblPagos
        '
        Me.LblPagos.AutoSize = True
        Me.LblPagos.BackColor = System.Drawing.Color.Transparent
        Me.LblPagos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPagos.Location = New System.Drawing.Point(524, 469)
        Me.LblPagos.Name = "LblPagos"
        Me.LblPagos.Size = New System.Drawing.Size(54, 20)
        Me.LblPagos.TabIndex = 13
        Me.LblPagos.Text = "Pagos"
        '
        'LblReportes
        '
        Me.LblReportes.AutoSize = True
        Me.LblReportes.BackColor = System.Drawing.Color.Transparent
        Me.LblReportes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblReportes.Location = New System.Drawing.Point(126, 469)
        Me.LblReportes.Name = "LblReportes"
        Me.LblReportes.Size = New System.Drawing.Size(75, 20)
        Me.LblReportes.TabIndex = 14
        Me.LblReportes.Text = "Reportes"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(752, 222)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 20)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Salir"
        '
        'LblUsuarios
        '
        Me.LblUsuarios.AutoSize = True
        Me.LblUsuarios.BackColor = System.Drawing.Color.Transparent
        Me.LblUsuarios.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblUsuarios.Location = New System.Drawing.Point(324, 469)
        Me.LblUsuarios.Name = "LblUsuarios"
        Me.LblUsuarios.Size = New System.Drawing.Size(72, 20)
        Me.LblUsuarios.TabIndex = 16
        Me.LblUsuarios.Text = "Usuarios"
        '
        'LblNombre
        '
        Me.LblNombre.AutoSize = True
        Me.LblNombre.BackColor = System.Drawing.Color.Transparent
        Me.LblNombre.Location = New System.Drawing.Point(879, 9)
        Me.LblNombre.Name = "LblNombre"
        Me.LblNombre.Size = New System.Drawing.Size(0, 13)
        Me.LblNombre.TabIndex = 20
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(813, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Bienvenido"
        '
        'PBBackup
        '
        Me.PBBackup.BackgroundImage = Global.Clave_de_Fa.My.Resources.Resources.Backup
        Me.PBBackup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PBBackup.Location = New System.Drawing.Point(478, 44)
        Me.PBBackup.Name = "PBBackup"
        Me.PBBackup.Size = New System.Drawing.Size(175, 175)
        Me.PBBackup.TabIndex = 21
        Me.PBBackup.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(499, 222)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(126, 20)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Generar Backup"
        '
        'FrmInicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Clave_de_Fa.My.Resources.Resources.Fondo2
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(968, 502)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PBBackup)
        Me.Controls.Add(Me.LblNombre)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LblUsuarios)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.LblReportes)
        Me.Controls.Add(Me.LblPagos)
        Me.Controls.Add(Me.LlbClases)
        Me.Controls.Add(Me.LblAlumnos)
        Me.Controls.Add(Me.PBReportes)
        Me.Controls.Add(Me.PBSalir)
        Me.Controls.Add(Me.PBUsuarios)
        Me.Controls.Add(Me.PBAlumnos)
        Me.Controls.Add(Me.PBPagos)
        Me.Controls.Add(Me.PBClases)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmInicio"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "                                                                                 " & _
    "                                Sistema de Gestion de Alumnos"
        CType(Me.PBClases, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBPagos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBAlumnos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBReportes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBSalir, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBUsuarios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBBackup, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PBClases As System.Windows.Forms.PictureBox
    Friend WithEvents PBPagos As System.Windows.Forms.PictureBox
    Friend WithEvents PBAlumnos As System.Windows.Forms.PictureBox
    Friend WithEvents PBReportes As System.Windows.Forms.PictureBox
    Friend WithEvents PBSalir As System.Windows.Forms.PictureBox
    Friend WithEvents PBUsuarios As System.Windows.Forms.PictureBox
    Friend WithEvents LblAlumnos As System.Windows.Forms.Label
    Friend WithEvents LlbClases As System.Windows.Forms.Label
    Friend WithEvents LblPagos As System.Windows.Forms.Label
    Friend WithEvents LblReportes As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents LblUsuarios As System.Windows.Forms.Label
    Friend WithEvents LblNombre As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PBBackup As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
