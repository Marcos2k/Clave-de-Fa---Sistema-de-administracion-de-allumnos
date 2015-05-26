Public Class FrmClases
    Dim Tabla As New DataTable

    Private Sub FrmClases_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Bloqueamos los controles
        BtnEditar.Enabled = False
        BtnEliminar.Enabled = False
        TBID_Alumno.Enabled = False
        TBID_Profesor.Enabled = False
        TBNombre_Alumno.Enabled = False
        TBNombre_Profesor.Enabled = False
        TBFlag.Visible = False
        Mostrar()
        Llenar_Combo()
    End Sub
    Private Sub Mostrar()
        Dim Funcion As New FClases
        Try
            Tabla = Funcion.Mostrar_Clases
            Grilla.Columns.Item("ColEliminar").Visible = False

            If Grilla.ColumnCount <> 0 Then
                LblInexistente.Visible = False
                Grilla.ColumnHeadersVisible = True
                Grilla.DataSource = Tabla
            Else
                LblInexistente.Visible = True
                Grilla.ColumnHeadersVisible = False
                Grilla.DataSource = Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Buscar()
    End Sub

    Private Sub Buscar()
        Try
            Dim DS As New DataSet
            DS.Tables.Add(Tabla.Copy)

            Dim DV As New DataView(DS.Tables(0))
            DV.RowFilter = CBBuscar.Text & " like'" & TBBuscar.Text & "%'"

            If DV.Count <> 0 Then
                LblInexistente.Visible = False
                Grilla.DataSource = DV
                Ocultar_columnas()
            Else
                LblInexistente.Visible = True
                Grilla.DataSource = Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Ocultar_columnas()
        Grilla.Columns.Item(1).Visible = False
        Grilla.Columns.Item(2).Visible = False
        Grilla.Columns.Item(3).Visible = False
    End Sub
    Private Sub TBBuscar_TextChanged(sender As Object, e As EventArgs) Handles TBBuscar.TextChanged
        Buscar()
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Dim Resultado As DialogResult
        Resultado = MessageBox.Show("Deseas salir?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If Resultado = Windows.Forms.DialogResult.OK Then
            Me.Close()
        End If
    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        BtnEditar.Enabled = False
        BtnGuardar.Enabled = True
        TBID_Alumno.Text = ""
        TBID_Profesor.Text = ""
        TBNombre_Alumno.Text = ""
        TBNombre_Profesor.Text = ""
        LblID_Clase.Text = ""
    End Sub

    Private Sub TBBuscar_profesor_Click(sender As Object, e As EventArgs) Handles TBBuscar_profesor.Click
        FrmUsuario.TBFlag.Text = "1"
        FrmUsuario.ShowDialog()
    End Sub

    Private Sub TBBuscar_Alumno_Click(sender As Object, e As EventArgs) Handles TBBuscar_Alumno.Click
        FrmAlumnos.TBFlag.Text = "1"
        FrmAlumnos.ShowDialog()
    End Sub

    Private Sub Grilla_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Grilla.CellClick
        LblID_Clase.Text = Grilla.SelectedCells.Item(1).Value
        TBID_Profesor.Text = Grilla.SelectedCells.Item(2).Value
        TBID_Alumno.Text = Grilla.SelectedCells.Item(3).Value
        TBNombre_Profesor.Text = Grilla.SelectedCells.Item(4).Value
        TBNombre_Alumno.Text = Grilla.SelectedCells.Item(5).Value
        DTFecha.Text = Grilla.SelectedCells.Item(7).Value

        BtnGuardar.Enabled = False
        BtnEditar.Enabled = True
    End Sub

    Private Sub Llenar_Combo()
        CBBuscar.Items.Clear()
        CBBuscar.Items.Add("Nombre_Alumno")
        CBBuscar.Items.Add("Apellido_Alumno")
        CBBuscar.Items.Add("Profesor")
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Try
            If Me.ValidateChildren = True And TBID_Alumno.Text <> "" And TBID_Profesor.Text <> "" And DTFecha.Text <> "" Then
                Dim Funcion As New FClases
                Dim Dato As New VClases

                Dato.GID_Profesor = TBID_Profesor.Text
                Dato.GID_Alumno = TBID_Alumno.Text
                Dato.GFecha = DTFecha.Text

                If Funcion.Guardar_Clase(Dato) Then
                    MessageBox.Show("Clase registrada con exito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Mostrar()
                    Limpiar()
                Else
                    MessageBox.Show("Error,la clase no pudo ser registrada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Limpiar()
        BtnEditar.Enabled = False
        BtnGuardar.Enabled = True
        TBID_Alumno.Text = ""
        TBID_Profesor.Text = ""
        TBNombre_Alumno.Text = ""
        TBNombre_Profesor.Text = ""
        LblID_Clase.Text = ""
    End Sub

    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click
        Try
            If Me.ValidateChildren = True And TBID_Alumno.Text <> "" And TBID_Profesor.Text <> "" And DTFecha.Text <> "" Then
                Dim Funcion As New FClases
                Dim Dato As New VClases

                Dato.GID_Clase = LblID_Clase.Text
                Dato.GID_Profesor = TBID_Profesor.Text
                Dato.GID_Alumno = TBID_Alumno.Text
                Dato.GFecha = DTFecha.Text

                If Funcion.Editar_Clase(Dato) Then
                    MessageBox.Show("Clase editada con exito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Mostrar()
                    Limpiar()
                Else
                    MessageBox.Show("Error,la clase no pudo ser editada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
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
        If e.ColumnIndex = Me.Grilla.Columns.Item("ColEliminar").Index Then 'Si e-IndiceColumnas = Me.Grilla.Columnas.items("Nombredelacolumna").Indice
            Dim CHK As DataGridViewCheckBoxCell = Me.Grilla.Rows(e.RowIndex).Cells("ColEliminar") 'Dim Var Tipo DataGridviewCheckboxcell = Me.Grilla.Filas(e.FilaIndice).Celdas("Nombredelacolumna")
            CHK.Value = Not CHK.Value 'de alguna forma le indica que son distintos a su vez
        End If

    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        Dim Resultado As DialogResult
        Resultado = MessageBox.Show("Deseas eliminar los items seleccionados?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If Resultado = DialogResult.OK Then
            Try
                For Each Fila As DataGridViewRow In Grilla.Rows
                    'Convertimos a Boolean las celdas marcadas
                    Dim Marcado As Boolean = Convert.ToBoolean(Fila.Cells("ColEliminar").Value)

                    If Marcado Then
                        Dim Onekey As Integer = Convert.ToInt32(Fila.Cells("ID_Clase").Value)

                        Dim VDB As New VClases
                        Dim Funcion As New FClases

                        VDB.GID_Clase = Onekey ' Le indico que ID_Clase es un Entero
                        If Funcion.Eliminar_clase(VDB) Then
                            MessageBox.Show("Clase eliminada con exito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Limpiar()
                            Mostrar()
                        Else
                            MessageBox.Show("La Clase no puedo ser elminada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    End If
                Next
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MessageBox.Show("La eliminacion fue cancelada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub Grilla_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles Grilla.CellDoubleClick

        If TBFlag.Text = "1" Then
            FrmDetalle_clases.TBID_Clase.Text = Me.Grilla.SelectedCells.Item(1).Value
            FrmDetalle_clases.TBFecha.Text = Me.Grilla.SelectedCells.Item(7).Value

            Me.Close()
        End If
    End Sub
End Class