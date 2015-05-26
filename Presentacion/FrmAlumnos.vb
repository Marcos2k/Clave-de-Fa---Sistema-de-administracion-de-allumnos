Public Class FrmAlumnos

    Dim Tabla As New DataTable
    Private Sub FrmNuevo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LlenarGrilla()
        BtnEditar.Enabled = False
        BtnEliminar.Enabled = False
        TBNombre.Focus()
        TBFlag.Visible = False
        Usar_tooltip()
        CargarEstado()
        CargarComboBusqueda()
    End Sub
    Private Sub Usar_tooltip()
        ToolTip1.SetToolTip(BtnNuevo, "Habilita para agregar un nuevo alumno")
        ToolTip1.SetToolTip(BtnGuardar, "Registra el nuevo alumno")
        ToolTip1.SetToolTip(BtnEditar, "Permite guardar los datos editados del alumno")
        ToolTip1.SetToolTip(BtnEliminar, "Elimina los alumnos seleccionados")
        ToolTip1.SetToolTip(BtnSalir, "Sale del ventana")
    End Sub
    Private Sub CargarComboBusqueda()
        CBBuscar.Items.Clear()
        CBBuscar.Items.Add("Nombre")
        CBBuscar.Items.Add("Apellido")
        CBBuscar.Items.Add("Dni")
    End Sub
    Private Sub CargarEstado()
        CBEstado.Items.Clear()
        CBEstado.Items.Add("Habilitado")
        CBEstado.Items.Add("Suspendido")
        CBEstado.SelectedIndex = 0
    End Sub
    Private Sub LlenarGrilla()
        Dim Funcion As New FAlumno

        Try
            Tabla = Funcion.MostrarAlumnos 'La tabla va a cargar los datos del procedimiento almacenado
            Grilla.Columns.Item("ColEliminar").Visible = False

            If Tabla.Rows.Count <> 0 Then
                Grilla.DataSource = Tabla
                LblInexistente.Visible = False 'oculta la etiqueta
                Grilla.ColumnHeadersVisible = True

            Else
                Grilla.DataSource = Nothing
                Grilla.ColumnHeadersVisible = False
                LblInexistente.Visible = True
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
                LblInexistente.Visible = False
                Grilla.DataSource = DV
                Ocultar_Columnas()
            Else
                LblInexistente.Visible = True
                Grilla.DataSource = Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Ocultar_Columnas()
        Grilla.Columns.Item(1).Visible = False
    End Sub

    Private Sub TBBuscar_TextChanged(sender As Object, e As EventArgs) Handles TBBuscar.TextChanged
        Buscar()
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Salir()
    End Sub

    Private Sub Salir()
        'Pregunta antes de salir 
        Dim Resultado As DialogResult
        Resultado = MessageBox.Show("Estas seguro de que deseas salir?", "Salir", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If Resultado = DialogResult.OK Then
            Me.Close()
        End If
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click

        Dim Funcion As New FAlumno
        Dim Dato As New VAlumnos

        Try
            If Me.ValidateChildren = True And TBNombre.Text <> "" And TBApellido.Text <> "" And TBDni.Text <> "" And TBTelefono.Text <> "" And TBDomicilio.Text <> "" And TBSaldo.Text <> "" And TBClase.Text <> "" Then

                Dato.GNombre = TBNombre.Text
                Dato.GApellido = TBApellido.Text
                Dato.GDni = TBDni.Text
                Dato.GDomicilio = TBDomicilio.Text
                Dato.GTelefono = TBTelefono.Text
                Dato.GInstrumento_clase = TBClase.Text
                Dato.GObservaciones = TBObservacion.Text
                Dato.GSaldo = TBSaldo.Text
                Dato.GEstado = CBEstado.Text

                If Funcion.Guardar_Alumnos(Dato) Then
                    MessageBox.Show("Alumno guardado con exito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    LlenarGrilla()
                    LimpiarCampos()
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

    Private Sub LimpiarCampos()
        TBNombre.Text = ""
        TBApellido.Text = ""
        TBDni.Text = ""
        TBTelefono.Text = ""
        TBDomicilio.Text = ""
        TBClase.Text = ""
        TBObservacion.Text = ""
        TBSaldo.Text = ""
        TBID_Alumno.Text = ""
    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        LimpiarCampos()
        BtnGuardar.Enabled = True
        BtnEditar.Enabled = False
    End Sub

    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click
        Dim Funcion As New FAlumno
        Dim Dato As New VAlumnos

        Dim Resultado As DialogResult
        Resultado = MessageBox.Show("Realmente deseas modificar los datos del alumno?", "Modificando registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If Resultado = DialogResult.OK Then
            Try
                If Me.ValidateChildren = True And TBNombre.Text <> "" And TBApellido.Text <> "" And TBDni.Text <> "" And TBTelefono.Text <> "" And TBDomicilio.Text <> "" And TBSaldo.Text <> "" And TBClase.Text <> "" Then

                    Dato.GID_Alumno = TBID_Alumno.Text
                    Dato.GNombre = TBNombre.Text
                    Dato.GApellido = TBApellido.Text
                    Dato.GDni = TBDni.Text
                    Dato.GDomicilio = TBDomicilio.Text
                    Dato.GTelefono = TBTelefono.Text
                    Dato.GInstrumento_clase = TBClase.Text
                    Dato.GObservaciones = TBObservacion.Text
                    Dato.GSaldo = TBSaldo.Text
                    Dato.GEstado = CBEstado.Text

                    If Funcion.Editar_Alumno(Dato) Then
                        MessageBox.Show("Alumno modificado con exito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        LlenarGrilla()
                        LimpiarCampos()
                    Else
                        MessageBox.Show("Error al guardar, intente de nuevo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
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

    Private Sub Grilla_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Grilla.CellClick
        'Cuando damos un click pasa los datos las cajas de texto
        'Recuerda que la grilla esta en el modo en su propiedad SELECTION MODE como "RowfullSelect"
        TBID_Alumno.Text = Grilla.SelectedCells.Item(1).Value
        TBNombre.Text = Grilla.SelectedCells.Item(2).Value
        TBApellido.Text = Grilla.SelectedCells.Item(3).Value
        TBDni.Text = Grilla.SelectedCells.Item(4).Value
        TBDomicilio.Text = Grilla.SelectedCells.Item(5).Value
        TBTelefono.Text = Grilla.SelectedCells.Item(6).Value
        TBClase.Text = Grilla.SelectedCells.Item(7).Value
        TBObservacion.Text = Grilla.SelectedCells.Item(8).Value
        TBSaldo.Text = Grilla.SelectedCells.Item(9).Value
        CBEstado.Text = Grilla.SelectedCells.Item(10).Value
        BtnEditar.Enabled = True
        BtnGuardar.Enabled = False
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

    Private Sub Grilla_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Grilla.CellContentClick
        'Permite seleccionar varios items
        If e.ColumnIndex = Me.Grilla.Columns.Item("ColEliminar").Index Then
            Dim CHK As DataGridViewCheckBoxCell = Me.Grilla.Rows(e.RowIndex).Cells("ColEliminar")
            CHK.Value = Not CHK.Value
        End If
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        Dim Resultado As DialogResult
        Resultado = MessageBox.Show("Realmente deseas eliminar los alumnos seleccionados", "Eliminando registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If Resultado = DialogResult.OK Then
            Try
                For Each Fila As DataGridViewRow In Grilla.Rows
                    'Marcado hace referencia a los items seleccionados 
                    Dim Marcado As Boolean = Convert.ToBoolean(Fila.Cells("ColEliminar").Value)

                    If Marcado Then
                        Dim OneKey As Integer = Convert.ToInt32(Fila.Cells("ID_Alumno").Value)

                        Dim VDB As New VAlumnos
                        Dim Funcion As New FAlumno

                        VDB.GID_Alumno = OneKey

                        If Funcion.Eliminar_Alumno(VDB) Then
                            MessageBox.Show("Alumno eliminado con exito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            MessageBox.Show("El alumno no pudo ser eliminado, debido a que tiene clases/pagos registrados", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
        Call LimpiarCampos()
    End Sub

   
    Private Sub Grilla_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles Grilla.CellDoubleClick
        If TBFlag.Text = "1" Then
            FrmClases.TBID_Alumno.Text = Grilla.SelectedCells.Item(1).Value
            FrmClases.TBNombre_Alumno.Text = Grilla.SelectedCells.Item(2).Value
            Me.Close()
        End If

        If TBFlag.Text = "2" Then
            FrmPagos.TBID_Alumno.Text = Grilla.SelectedCells.Item(1).Value
            FrmPagos.TBNombre_Alumno.Text = Grilla.SelectedCells.Item(2).Value
            Me.Close()
        End If
    End Sub
End Class
