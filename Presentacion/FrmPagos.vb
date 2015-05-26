Public Class FrmPagos
    Dim Tabla As New DataTable

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Dim Resultado As DialogResult
        Resultado = MessageBox.Show("Deseas salir?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If Resultado = Windows.Forms.DialogResult.OK Then
            Me.Close()
        End If
    End Sub

    Private Sub FrmPagos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Bloqueamos controles
        TBID_Alumno.Enabled = False
        TBNombre_Alumno.Enabled = False
        BtnEditar.Enabled = False
        Mostrar()
        LlenarCombo()
    End Sub
    Private Sub Mostrar()
        Dim Funcion As New FPago
        Try
            Tabla = Funcion.Mostrar_pago
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
    End Sub

    Private Sub Grilla_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Grilla.CellClick
        LblID_Pago.Text = Grilla.SelectedCells.Item(1).Value
        TBID_Alumno.Text = Grilla.SelectedCells.Item(2).Value
        TBNombre_Alumno.Text = Grilla.SelectedCells.Item(3).Value & " " & Grilla.SelectedCells.Item(4).Value
        DTFecha.Text = Grilla.SelectedCells.Item(5).Value
        TBMonto.Text = Grilla.SelectedCells.Item(6).Value
        BtnEditar.Enabled = True
        BtnGuardar.Enabled = False
    End Sub

    
    Private Sub TBBuscar_TextChanged(sender As Object, e As EventArgs) Handles TBBuscar.TextChanged
        Buscar()
    End Sub

    Private Sub LlenarCombo()
        CBBuscar.Items.Clear()
        CBBuscar.Items.Add("Apellido")
        CBBuscar.Items.Add("Nombre")
    End Sub
    Private Sub Limpiar()
        LblID_Pago.Text = ""
        TBID_Alumno.Text = ""
        TBNombre_Alumno.Text = ""
        DTFecha.Text = Today
        TBMonto.Text = ""
        BtnGuardar.Enabled = True
        BtnEditar.Enabled = False
    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        Limpiar()
    End Sub

    Private Sub TBBuscar_Alumno_Click(sender As Object, e As EventArgs) Handles TBBuscar_Alumno.Click
        FrmAlumnos.TBFlag.Text = "2"
        FrmAlumnos.ShowDialog()
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        If Me.ValidateChildren = True And TBID_Alumno.Text <> "" And TBMonto.Text <> "" And DTFecha.Text <> "" Then
            Try
                Dim Funcion As New FPago
                Dim Dato As New VPago

                Dato.GID_Alumno = TBID_Alumno.Text
                Dato.GFecha = DTFecha.Text
                Dato.GMonto = TBMonto.Text

                If Funcion.Guardar_pago(Dato) Then
                    MessageBox.Show("Pago confirmado con exito,ahora añadir las clases", "Registrar pago", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Mostrar()
                    Ir_aDetalle()
                Else
                    MessageBox.Show("Error al confirmar pago, intente nuevamente", "Registrar pago", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MessageBox.Show("Campos incompletos, por favor completa los campos para poder continuar con la operacion", "Registrar pago", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub
    Private Sub Ir_aDetalle()

        FrmDetalle_clases.LblID_Pago.Text = Grilla.SelectedCells.Item(1).Value
        FrmDetalle_clases.TBID_Alumno.Text = TBID_Alumno.Text
        FrmDetalle_clases.TBNombre_Alumno.Text = TBNombre_Alumno.Text
        FrmDetalle_clases.DTFecha.Text = DTFecha.Text
        FrmDetalle_clases.TBMonto.Text = TBMonto.Text

        FrmDetalle_clases.ShowDialog()
    End Sub
    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click
        If Me.ValidateChildren = True And TBID_Alumno.Text <> "" And TBMonto.Text <> "" And DTFecha.Text <> "" Then
            Try
                Dim Funcion As New FPago
                Dim Dato As New VPago

                Dato.GID_Pago = LblID_Pago.Text
                Dato.GID_Alumno = TBID_Alumno.Text
                Dato.GFecha = DTFecha.Text
                Dato.GMonto = TBMonto.Text

                If Funcion.Editar_pago(Dato) Then
                    MessageBox.Show("Pago editado con exito", "Registrar pago", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Limpiar()
                    Mostrar()
                Else
                    MessageBox.Show("Error al editar el pago, intente nuevamente", "Registrar pago", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MessageBox.Show("Campos incompletos, por favor completa los campos para poder continuar con la operacion", "Registrar pago", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub Grilla_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles Grilla.CellDoubleClick
        Ir_aDetalle()
    End Sub
End Class