Public Class FrmUsuario
    Dim Tabla As New DataTable

    Private Sub FrmUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BloquearControles()
        LlenarCombo()
        LlenarAcceso()
        LlenarGrilla()
        Usar_tooltip()
        TBFlag.Visible = False
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        'Pregunta antes de salir 
        Dim Resultado As DialogResult

        Resultado = MessageBox.Show("Estas seguro de que deseas salir?", "Salir", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If Resultado = DialogResult.OK Then
            Me.Close()
        End If
    End Sub

    Private Sub BloquearControles()
        'Manipulamos los controles
        TBUsuario.Focus()
        BtnEditar.Enabled = False
        BtnEliminar.Enabled = False
    End Sub

    Private Sub LlenarGrilla()
        Dim Funcion As New FUsuario

        Try
            Tabla = Funcion.MostrarAlumnos 'La tabla va a cargar los datos del procedimiento almacenado
            Grilla.Columns.Item("ColEliminar").Visible = False

            If Tabla.Rows.Count <> 0 Then
                Grilla.DataSource = Tabla
                Lblinexistente.Visible = False 'oculta la etiqueta
                Grilla.ColumnHeadersVisible = True
            Else
                Grilla.DataSource = Nothing
                Grilla.ColumnHeadersVisible = False
                Lblinexistente.Visible = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Buscar()
    End Sub
    Private Sub Buscar()
        'Se encarga de buscar y mostrar los datos coincidentes
        Try
            Dim DS As New DataSet
            DS.Tables.Add(Tabla.Copy)

            Dim DV As New DataView(DS.Tables(0))
            DV.RowFilter = CBBuscar.Text & " like'" & TBBuscar.Text & "%'"

            If DV.Count <> 0 Then
                Lblinexistente.Visible = False
                Grilla.DataSource = DV
                Ocultar_columnas()
            Else
                Lblinexistente.Visible = True
                Grilla.DataSource = Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Ocultar_columnas()
        Grilla.Columns.Item(1).Visible = False
        Grilla.Columns.Item(3).Visible = False
        Grilla.Columns.Item(10).Visible = False

    End Sub

    Private Sub TBBuscar_TextChanged(sender As Object, e As EventArgs) Handles TBBuscar.TextChanged
        Buscar()
    End Sub

    Private Sub LlenarCombo()
        CBBuscar.Items.Clear()
        CBBuscar.Items.Add("Nombre")
        CBBuscar.Items.Add("Apellido")
        CBBuscar.Items.Add("Dni")
    End Sub

    Private Sub Grilla_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Grilla.CellClick
        'Cuando damos un click pasa los datos las cajas de texto
        'Recuerda que la grilla esta en el modo en su propiedad SELECTION MODE como "RowfullSelect"
        LblID.Text = Grilla.SelectedCells.Item(1).Value
        TBUsuario.Text = Grilla.SelectedCells.Item(2).Value
        TBContraseña.Text = Grilla.SelectedCells.Item(3).Value
        TBNombre.Text = Grilla.SelectedCells.Item(4).Value
        TBApellido.Text = Grilla.SelectedCells.Item(5).Value
        TBDni.Text = Grilla.SelectedCells.Item(6).Value
        TBDomicilio.Text = Grilla.SelectedCells.Item(7).Value
        TBTelefono.Text = Grilla.SelectedCells.Item(8).Value
        TBSueldo.Text = Grilla.SelectedCells.Item(9).Value
        If Grilla.SelectedCells.Item(10).Value = 1 Then
            CBAcceso.Text = "Total"
        Else
            CBAcceso.Text = "Limitado"
        End If

        BtnEditar.Enabled = True
        BtnAgregar.Enabled = False
    End Sub
    Private Sub LlenarAcceso()
        CBAcceso.Items.Clear()
        CBAcceso.Items.Add("Total")
        CBAcceso.Items.Add("Limitado")
        CBAcceso.SelectedIndex = -1
    End Sub

    Private Sub Limpiar()
        LblID.Text = ""
        TBUsuario.Text = ""
        TBContraseña.Text = ""
        TBNombre.Text = ""
        TBApellido.Text = ""
        TBDni.Text = ""
        TBDomicilio.Text = ""
        TBTelefono.Text = ""
        TBSueldo.Text = ""

        TBUsuario.Focus()
    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        Limpiar()
        BtnAgregar.Enabled = True
        BtnEditar.Enabled = False
    End Sub

    Private Sub Usar_tooltip()
        ToolTip1.SetToolTip(BtnNuevo, "Habilita para agregar un nuevo usuario")
        ToolTip1.SetToolTip(BtnAgregar, "Registra el nuevo usuario")
        ToolTip1.SetToolTip(BtnEditar, "Permite guardar los datos editados del usuario")
        ToolTip1.SetToolTip(BtnEliminar, "Elimina los usuarios seleccionados")
        ToolTip1.SetToolTip(BtnSalir, "Sale del ventana")
    End Sub

    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click
        Dim Funcion As New FUsuario
        Dim Dato As New VUsuario

        Try
            If Me.ValidateChildren = True And TBUsuario.Text <> "" And TBContraseña.Text <> "" And TBNombre.Text <> "" And TBApellido.Text <> "" And TBDni.Text <> "" And TBDomicilio.Text <> "" And TBTelefono.Text <> "" And TBSueldo.Text <> "" Then
                Dim Acceso As String

                Dato.GUsuario = TBUsuario.Text
                Dato.GContraseña = TBContraseña.Text
                Dato.GNombre = TBNombre.Text
                Dato.GApellido = TBApellido.Text
                Dato.GDni = TBDni.Text
                Dato.GDomicilio = TBDomicilio.Text
                Dato.GTelefono = TBTelefono.Text
                Dato.GSueldo = TBSueldo.Text
                'Define que tipo de acceso va a tener
                If CBAcceso.Text = "Total" Then
                    Acceso = "1"
                    Dato.GAcceso = Acceso
                ElseIf CBAcceso.Text = "Limitado" Then
                    Acceso = "2"
                    Dato.GAcceso = Acceso
                End If

                If Funcion.Agregar_usuario(Dato) Then
                    MessageBox.Show("Usuario guardado con exito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    LlenarGrilla()
                    Limpiar()
                Else
                    MessageBox.Show("Error al guardar, intente de nuevo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                MessageBox.Show("Campos incompletos, por favor completar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click
        Dim Funcion As New FUsuario
        Dim Dato As New VUsuario

        Dim Resultado As DialogResult
        Resultado = MessageBox.Show("Realmente deseas modificar los datos usuario", "Modificando registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If Resultado = DialogResult.OK Then
            Try
                If Me.ValidateChildren = True And TBUsuario.Text <> "" And TBContraseña.Text <> "" And TBNombre.Text <> "" And TBApellido.Text <> "" And TBDni.Text <> "" And TBDomicilio.Text <> "" And TBTelefono.Text <> "" And TBSueldo.Text <> "" Then
                    Dim Acceso As String

                    Dato.GID_Usuario = LblID.Text
                    Dato.GUsuario = TBUsuario.Text
                    Dato.GContraseña = TBContraseña.Text
                    Dato.GNombre = TBNombre.Text
                    Dato.GApellido = TBApellido.Text
                    Dato.GDni = TBDni.Text
                    Dato.GDomicilio = TBDomicilio.Text
                    Dato.GTelefono = TBTelefono.Text
                    Dato.GSueldo = TBSueldo.Text
                    'Define que tipo de acceso va a tener
                    If CBAcceso.Text = "Total" Then
                        Acceso = "1"
                        Dato.GAcceso = Acceso
                    ElseIf CBAcceso.Text = "Limitado" Then
                        Acceso = "2"
                        Dato.GAcceso = Acceso
                    End If

                    If Funcion.Editar_usuario(Dato) Then
                        MessageBox.Show("Usuario modificado con exito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        LlenarGrilla()
                        Limpiar()
                    Else
                        MessageBox.Show("Error al editar, intente de nuevo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Else
                    MessageBox.Show("Campos incompletos, por favor completar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MessageBox.Show("La modificacion de registros ha sido cancelada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub Grilla_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Grilla.CellContentClick
        'permite seleccionar varios items
        If e.ColumnIndex = Me.Grilla.Columns.Item("ColEliminar").Index Then
            Dim CHK As DataGridViewCheckBoxCell = Me.Grilla.Rows(e.RowIndex).Cells("ColEliminar")
            CHK.Value = Not CHK.Value
        End If
    End Sub
    Private Sub CHKEliminar_CheckedChanged(sender As Object, e As EventArgs) Handles CHKEliminar.CheckedChanged
        If CHKEliminar.CheckState = CheckState.Checked Then
            BtnEliminar.Enabled = True
            ColEliminar.Visible = True
        Else
            BtnEliminar.Enabled = False
            ColEliminar.Visible = False
        End If
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        Dim Resultado As DialogResult
        Resultado = MessageBox.Show("Realmente deseas eliminar los usuarios seleccionados", "Eliminando registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If Resultado = DialogResult.OK Then
            Try
                For Each Fila As DataGridViewRow In Grilla.Rows
                    Dim Marcado As Boolean = Convert.ToBoolean(Fila.Cells("ColEliminar").Value)

                    If Marcado Then
                        Dim Onekey As Integer = Convert.ToInt32(Fila.Cells("ID_Usuario").Value) 'Le indico la lleve principal de la fila que voy a borrar

                        Dim Funcion As New FUsuario
                        Dim VDB As New VUsuario

                        VDB.GID_Usuario = Onekey

                        If Funcion.Eliminar_usuario(VDB) Then
                            MessageBox.Show("Usuario eliminado con exito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            MessageBox.Show("El usuario no pudo ser eliminado, debido a que tiene clases/pagos registrados", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If
                    End If
                Next
                Call LlenarGrilla()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MessageBox.Show("La eliminacion de registros ha sido cancelada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LlenarGrilla()
        End If
        Call Limpiar()
    End Sub

    Private Sub Grilla_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles Grilla.CellDoubleClick
        If TBFlag.Text = "1" Then
            FrmClases.TBID_Profesor.Text = Grilla.SelectedCells.Item(1).Value
            FrmClases.TBNombre_Profesor.Text = Grilla.SelectedCells.Item(4).Value
            Me.Close()
        End If
    End Sub
End Class