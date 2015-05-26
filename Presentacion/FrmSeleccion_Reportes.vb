Public Class FrmSeleccion_Reportes

    Dim Tabla As New DataTable
    Private Sub FrmReportes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Grilla.DataSource = Nothing
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Dim Resultado As DialogResult
        Resultado = MessageBox.Show("Deseas salir?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If Resultado = DialogResult.OK Then
            Me.Close()
        End If
    End Sub

    Private Sub BtnMostrar_Click(sender As Object, e As EventArgs) Handles BtnMostrar.Click
        If OptAlumnos.Checked = True Then
            'Aca llenamos la grilla con la consulta 
            Dim Funcion As New FReporte
            Try
                Tabla = Funcion.Mostrar_Alumnos 'La tabla va a cargar los datos del procedimiento almacenado

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
        End If

        If OptBalance.Checked = True Then
            'Llenamos la grilla con la consulta por fecha
            Dim Funcion As New FPago
            Dim Dato As New VPago

            Dato.GFecha = DTFecha.Text

            Try
                Tabla = Funcion.Reporte_del_dia(Dato) 'La tabla va a cargar los datos del procedimiento almacenado

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
        End If
    End Sub

    Private Sub OptAlumnos_CheckedChanged(sender As Object, e As EventArgs) Handles OptAlumnos.CheckedChanged
        DTFecha.Enabled = False
    End Sub

    Private Sub BtnVer_Click(sender As Object, e As EventArgs) Handles BtnVer.Click
        If OptAlumnos.Checked = True Then
            FrmReporteAlumno.ShowDialog()
        End If

        If OptBalance.Checked = True Then
            'Tiramos el reporte del pago del dia
            FrmReporte_del_dia.TBFecha.Text = Me.DTFecha.Text
            FrmReporte_del_dia.ShowDialog()
        End If
    End Sub

    Private Sub OptBalance_CheckedChanged(sender As Object, e As EventArgs) Handles OptBalance.CheckedChanged
        If OptBalance.Checked = True Then
            DTFecha.Enabled = True
        End If
    End Sub

    Private Sub Limpiar_Click(sender As Object, e As EventArgs) Handles Limpiar.Click
        Grilla.DataSource = Nothing
    End Sub
End Class