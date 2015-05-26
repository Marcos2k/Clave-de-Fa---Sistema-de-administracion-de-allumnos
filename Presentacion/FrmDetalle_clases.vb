Public Class FrmDetalle_clases
    Dim Tabla As DataTable

    Private Sub FrmDetalle_clases_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GroupBox1.Enabled = False
        TBID_Clase.Enabled = False
        TBFecha.Enabled = False
        Mostrar()
    End Sub

    
    Private Sub TBBuscar_Click(sender As Object, e As EventArgs) Handles TBBuscar.Click
        FrmClases.TBFlag.Text = "1"
        FrmClases.ShowDialog()
    End Sub
    Private Sub Mostrar()
        Try
            Dim Funcion As New FDetalle 'crea un objeto en la clase FCliente
            Tabla = Funcion.Mostrar 'carga el procedimiento a la tabla 

            Grilla.Columns.Item("ColEliminar").Visible = False 'Oculta la columna Eliminar

            If Tabla.Rows.Count <> 0 Then 'Pregunta: Si la tabla tiene filas que sean distinta de cero entonces
                Grilla.DataSource = Tabla 'Datasource : Fuente de datos = Tabla
                Grilla.ColumnHeadersVisible = True 'Cabezales de la columna habilitados
                LblInexistente.Visible = False 'Oculta etiqueta
            Else
                Grilla.DataSource = Nothing
                Grilla.ColumnHeadersVisible = False
                LblInexistente.Visible = True 'Oculta etiqueta
            End If
        Catch ex As Exception
            MsgBox(ex.Message) 'muestra el posible fallo
        End Try

        Buscar()
    End Sub
    Private Sub Buscar()
        Try
            Dim DS As New DataSet 'conjunto de tablas
            DS.Tables.Add(Tabla.Copy) 'agrego la Tabla al data set usando la propiedad "Copy"

            Dim DV As New DataView(DS.Tables(0)) 'averiguar para que sirve un Dataview, DataView = Vista de datos
            DV.RowFilter = "ID_Pago='" & LblID_Pago.Text & "'"

            If DV.Count <> 0 Then
                LblInexistente.Visible = False
                Grilla.DataSource = DV

                Ocultar_Columnas()
            Else
                LblInexistente.Visible = True
                Grilla.DataSource = Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message) 'muestra el posible fallo
        End Try
    End Sub

    Private Sub Ocultar_Columnas()
        Grilla.Columns.Item(1).Visible = False
        Grilla.Columns.Item(2).Visible = False

    End Sub
    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click
        If Me.ValidateChildren = True And TBID_Clase.Text <> "" And LblID_Pago.Text <> "" Then
            Dim Funcion As New FDetalle
            Dim Dato As New VDetalle
            Try
                Dato.GID_Pago = LblID_Pago.Text
                Dato.GID_Clase = TBID_Clase.Text

                If Funcion.Insertar_Detalle(Dato) Then
                    Mostrar()
                    Limpiar()
                Else
                    MessageBox.Show("Error al guarda la clase,intente nuevamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MessageBox.Show("Campos incompletos, favor llenar para poder continuar con la operacion", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub CHKEliminar_CheckedChanged(sender As Object, e As EventArgs) Handles CHKEliminar.CheckedChanged
        'Pregunta si el Checkbox esta selececionado
        'Sintaxis: Checkbox.Checkstate = CheckState.Checked
        If CHKEliminar.CheckState = CheckState.Checked Then
            Grilla.Columns.Item("ColEliminar").Visible = True
        Else
            Grilla.Columns.Item("ColEliminar").Visible = False
        End If
    End Sub

    Private Sub Grilla_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Grilla.CellContentClick
        'Metodo para ocultar o mostrar la grilla eliminar, cuando el checkbox se elige muestra la Columna "Eliminar"
        If e.ColumnIndex = Me.Grilla.Columns.Item("ColEliminar").Index Then
            Dim CHK As DataGridViewCheckBoxCell = Me.Grilla.Rows(e.RowIndex).Cells("ColEliminar")
            CHK.Value = Not CHK.Value
        End If
    End Sub
    Private Sub Limpiar()
        TBID_Clase.Text = ""
        TBFecha.Text = ""
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click

        Dim Resultado As DialogResult
        Resultado = MessageBox.Show("Deseas eliminar los items seleccinados?", "Aviso!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If Resultado = DialogResult.OK Then
            Try
                'bucle FOR para eliminar los items seleccionados
                For Each Fila As DataGridViewRow In Grilla.Rows
                    Dim Marcado As Boolean = Convert.ToBoolean(Fila.Cells("ColEliminar").Value)

                    If Marcado Then 'estudiar este algoritmo
                        Dim Onekey As Integer = Convert.ToInt32(Fila.Cells("ID_Detalle").Value)
                        'Onekey= una llave haciendo referencia a PK de la tabla
                        Dim VDB As New VDetalle
                        Dim Funcion As New FDetalle

                        VDB.GID_Detalle = Onekey

                        If Funcion.Eliminar_Detalle(VDB) Then
                            'realiza las operaciones de la funcion Eliminar_Cliente desde la clase "FCliente"
                        Else
                            MessageBox.Show("Clase no pudo ser eliminada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If
                    End If
                Next
                Call Mostrar()

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If

    End Sub

    Private Sub TBSalir_Click(sender As Object, e As EventArgs) Handles TBSalir.Click
        Me.Close()
    End Sub

    Private Sub BtnImprimir_Click(sender As Object, e As EventArgs) Handles BtnImprimir.Click
        'En este proceso se accede a imprirmir el reporte del cobro
        FrmComprobante.TBID_Pago.Text = Me.LblID_Pago.Text

        FrmComprobante.ShowDialog()
    End Sub
End Class