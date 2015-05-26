Public Class FrmReporte_del_dia

    Private Sub FrmReporte_del_dia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TBFecha.Visible = False
        'TODO: esta línea de código carga datos en la tabla 'ClavedefaDataSet2.Reporte_del_dia' Puede moverla o quitarla según sea necesario.
        Try
            Me.Reporte_del_diaTableAdapter.Fill(Me.ClavedefaDataSet2.Reporte_del_dia, Fecha:=TBFecha.Text)
            Me.ReportViewer1.RefreshReport()
        Catch ex As Exception
            Me.ReportViewer1.RefreshReport()
        End Try
    End Sub
End Class