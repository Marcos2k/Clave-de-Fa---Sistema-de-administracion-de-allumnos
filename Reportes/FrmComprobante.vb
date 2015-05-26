Public Class FrmComprobante

    Private Sub FrmComprobante_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TBID_Pago.Visible = False
        'TODO: esta línea de código carga datos en la tabla 'ClavedefaDataSet.Generar_comprobante' Puede moverla o quitarla según sea necesario.
        Try
            Me.Generar_comprobanteTableAdapter.Fill(Me.ClavedefaDataSet.Generar_comprobante, ID_Pago:=TBID_Pago.Text)

            Me.ReportViewer1.RefreshReport()
        Catch ex As Exception
            Me.ReportViewer1.RefreshReport()
        End Try
    End Sub
End Class