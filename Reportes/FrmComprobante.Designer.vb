<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmComprobante
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
        Dim ReportDataSource3 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.ClavedefaDataSet = New Clave_de_Fa.ClavedefaDataSet()
        Me.Generar_comprobanteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Generar_comprobanteTableAdapter = New Clave_de_Fa.ClavedefaDataSetTableAdapters.Generar_comprobanteTableAdapter()
        Me.ClavedefaDataSet1 = New Clave_de_Fa.ClavedefaDataSet1()
        Me.AlumnosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AlumnosTableAdapter = New Clave_de_Fa.ClavedefaDataSet1TableAdapters.AlumnosTableAdapter()
        Me.TBID_Pago = New System.Windows.Forms.TextBox()
        CType(Me.ClavedefaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Generar_comprobanteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClavedefaDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AlumnosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource3.Name = "DataSet1"
        ReportDataSource3.Value = Me.Generar_comprobanteBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource3)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Clave_de_Fa.RptComprobante.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(962, 491)
        Me.ReportViewer1.TabIndex = 0
        '
        'ClavedefaDataSet
        '
        Me.ClavedefaDataSet.DataSetName = "ClavedefaDataSet"
        Me.ClavedefaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Generar_comprobanteBindingSource
        '
        Me.Generar_comprobanteBindingSource.DataMember = "Generar_comprobante"
        Me.Generar_comprobanteBindingSource.DataSource = Me.ClavedefaDataSet
        '
        'Generar_comprobanteTableAdapter
        '
        Me.Generar_comprobanteTableAdapter.ClearBeforeFill = True
        '
        'ClavedefaDataSet1
        '
        Me.ClavedefaDataSet1.DataSetName = "ClavedefaDataSet1"
        Me.ClavedefaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AlumnosBindingSource
        '
        Me.AlumnosBindingSource.DataMember = "Alumnos"
        Me.AlumnosBindingSource.DataSource = Me.ClavedefaDataSet1
        '
        'AlumnosTableAdapter
        '
        Me.AlumnosTableAdapter.ClearBeforeFill = True
        '
        'TBID_Pago
        '
        Me.TBID_Pago.Location = New System.Drawing.Point(28, 55)
        Me.TBID_Pago.Name = "TBID_Pago"
        Me.TBID_Pago.Size = New System.Drawing.Size(100, 20)
        Me.TBID_Pago.TabIndex = 2
        '
        'FrmComprobante
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(962, 491)
        Me.Controls.Add(Me.TBID_Pago)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "FrmComprobante"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Comprobante de pago"
        CType(Me.ClavedefaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Generar_comprobanteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClavedefaDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AlumnosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Generar_comprobanteBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ClavedefaDataSet As Clave_de_Fa.ClavedefaDataSet
    Friend WithEvents Generar_comprobanteTableAdapter As Clave_de_Fa.ClavedefaDataSetTableAdapters.Generar_comprobanteTableAdapter
    Friend WithEvents AlumnosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ClavedefaDataSet1 As Clave_de_Fa.ClavedefaDataSet1
    Friend WithEvents AlumnosTableAdapter As Clave_de_Fa.ClavedefaDataSet1TableAdapters.AlumnosTableAdapter
    Friend WithEvents TBID_Pago As System.Windows.Forms.TextBox
End Class
