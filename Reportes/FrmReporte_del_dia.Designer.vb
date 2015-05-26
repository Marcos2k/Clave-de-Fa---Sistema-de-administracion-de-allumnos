<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmReporte_del_dia
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.ClavedefaDataSet2 = New Clave_de_Fa.ClavedefaDataSet2()
        Me.Reporte_del_diaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Reporte_del_diaTableAdapter = New Clave_de_Fa.ClavedefaDataSet2TableAdapters.Reporte_del_diaTableAdapter()
        Me.TBFecha = New System.Windows.Forms.TextBox()
        CType(Me.ClavedefaDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Reporte_del_diaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource2.Name = "DataSet1"
        ReportDataSource2.Value = Me.Reporte_del_diaBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Clave_de_Fa.Reporte_del_dia.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(962, 491)
        Me.ReportViewer1.TabIndex = 0
        '
        'ClavedefaDataSet2
        '
        Me.ClavedefaDataSet2.DataSetName = "ClavedefaDataSet2"
        Me.ClavedefaDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Reporte_del_diaBindingSource
        '
        Me.Reporte_del_diaBindingSource.DataMember = "Reporte_del_dia"
        Me.Reporte_del_diaBindingSource.DataSource = Me.ClavedefaDataSet2
        '
        'Reporte_del_diaTableAdapter
        '
        Me.Reporte_del_diaTableAdapter.ClearBeforeFill = True
        '
        'TBFecha
        '
        Me.TBFecha.Location = New System.Drawing.Point(22, 67)
        Me.TBFecha.Name = "TBFecha"
        Me.TBFecha.Size = New System.Drawing.Size(100, 20)
        Me.TBFecha.TabIndex = 6
        '
        'FrmReporte_del_dia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(962, 491)
        Me.Controls.Add(Me.TBFecha)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "FrmReporte_del_dia"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmReporte_del_dia"
        CType(Me.ClavedefaDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Reporte_del_diaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Reporte_del_diaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ClavedefaDataSet2 As Clave_de_Fa.ClavedefaDataSet2
    Friend WithEvents Reporte_del_diaTableAdapter As Clave_de_Fa.ClavedefaDataSet2TableAdapters.Reporte_del_diaTableAdapter
    Friend WithEvents TBFecha As System.Windows.Forms.TextBox
End Class
