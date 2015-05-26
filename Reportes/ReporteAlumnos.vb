Public Class FrmReporteAlumno

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'TODO: esta línea de código carga datos en la tabla 'ClavedefaDataSet1.Alumnos' Puede moverla o quitarla según sea necesario.
        Try
            Me.AlumnosTableAdapter.Fill(Me.ClavedefaDataSet1.Alumnos)

            Me.ReportViewer1.RefreshReport()
        Catch ex As Exception
            Me.ReportViewer1.RefreshReport()
        End Try
    End Sub
End Class