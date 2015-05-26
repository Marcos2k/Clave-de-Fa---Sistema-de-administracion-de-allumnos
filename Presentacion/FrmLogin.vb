Public Class FrmLogin
    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub

   
    Private Sub BtnIngresar_Click(sender As Object, e As EventArgs) Handles BtnIngresar.Click
        If Me.ValidateChildren = True And TBContraseña.Text <> "" And TBUsuario.Text <> "" Then

            Dim Funcion As New FLogin
            Dim Dato As New VUsuario
            Dim Acceso_total As String = "1"
            Dim Acceso_limitado As String = "2"
            Try
                Dato.GUsuario = TBUsuario.Text
                Dato.GContraseña = TBContraseña.Text
                Dato.GAcceso = Acceso_total
                If Acceso_total = "1" Then
                    If Funcion.Validar_usuarios(Dato) Then
                        FrmInicio.LblNombre.Text = TBUsuario.Text
                        FrmInicio.ShowDialog()
                        Me.Hide()
                    Else
                        Dato.GAcceso = Acceso_limitado
                        If Acceso_limitado = "2" Then
                            If Funcion.Validar_usuarios(Dato) Then
                                FrmInicio.LblNombre.Text = TBUsuario.Text
                                'Se restringen algunos permisos a determinados usuarios
                                FrmInicio.PBReportes.Visible = False
                                FrmInicio.LblReportes.Visible = False
                                FrmInicio.PBUsuarios.Visible = False
                                FrmInicio.LblUsuarios.Visible = False
                                FrmInicio.PBPagos.Visible = False
                                FrmInicio.LblPagos.Visible = False
                                'Bloqueo de funciones en otros formularios
                                'Formulario de clases
                                FrmClases.CHKEliminar.Visible = False
                                FrmClases.BtnEliminar.Visible = False
                                FrmClases.BtnEditar.Visible = False
                                'Formulario de alumno
                                FrmAlumnos.CHKEliminar.Visible = False
                                FrmAlumnos.BtnEliminar.Visible = False
                                'Formulario de usuarios
                                FrmUsuario.CHKEliminar.Visible = False
                                FrmUsuario.BtnEliminar.Visible = False
                                FrmUsuario.TBSueldo.PasswordChar = "*"
                                FrmUsuario.BtnEditar.Visible = False
                                FrmUsuario.BtnAgregar.Visible = False
                                FrmUsuario.BtnNuevo.Visible = False
                                FrmUsuario.CBAcceso.Enabled = False
                                FrmInicio.ShowDialog()
                                Me.Hide()
                            Else
                                MessageBox.Show("Campos incorrectos, intenta nuevamente", "Error al ingresar", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                TBContraseña.Text = ""
                                TBUsuario.Text = ""
                            End If
                        End If
                    End If
                Else
                    MessageBox.Show("Campos incorrectos, intenta nuevamente", "Error al ingresar", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    TBContraseña.Text = ""
                    TBUsuario.Text = ""
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub FrmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LblFecha.Text = Today
        LblHora.Text = TimeOfDay
    End Sub

    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
        LblHora.Text = TimeOfDay
    End Sub
End Class