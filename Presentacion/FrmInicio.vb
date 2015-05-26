Public Class FrmInicio

    Private Sub PBSalir_Click(sender As Object, e As EventArgs) Handles PBSalir.Click
        Dim Resultado As DialogResult
        Resultado = MessageBox.Show("Deseas salir?", "Saliendo del sistema", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If Resultado = DialogResult.OK Then
            Me.Close()
        End If
    End Sub

    Private Sub PBAlumnos_Click(sender As Object, e As EventArgs) Handles PBAlumnos.Click
        FrmAlumnos.ShowDialog()
    End Sub

    Private Sub PBClases_Click(sender As Object, e As EventArgs) Handles PBClases.Click
        FrmClases.ShowDialog()
    End Sub

    Private Sub PBPagos_Click(sender As Object, e As EventArgs) Handles PBPagos.Click
        FrmPagos.ShowDialog()
    End Sub

    Private Sub PBReportes_Click(sender As Object, e As EventArgs) Handles PBReportes.Click
        FrmSeleccion_Reportes.ShowDialog()
    End Sub

    Private Sub PBUsuarios_Click(sender As Object, e As EventArgs) Handles PBUsuarios.Click
        FrmUsuario.ShowDialog()
    End Sub

    Private Sub PBBackup_Click(sender As Object, e As EventArgs) Handles PBBackup.Click
        FrmBackup.ShowDialog()
    End Sub
End Class