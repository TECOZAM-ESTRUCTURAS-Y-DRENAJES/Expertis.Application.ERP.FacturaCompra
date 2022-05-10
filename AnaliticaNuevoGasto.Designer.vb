<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AnaliticaNuevoGasto
    Inherits Solmicro.Expertis.Engine.UI.FormBase

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
        Me.components = New System.ComponentModel.Container
        Dim SubGrid_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AnaliticaNuevoGasto))
        Dim jngCentroCoste_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.SubGrid = New Solmicro.Expertis.Engine.UI.Grid
        Me.jngCentroCoste = New Solmicro.Expertis.Engine.UI.Grid
        Me.lblIDCContable = New Solmicro.Expertis.Engine.UI.Label
        Me.lblFecha = New Solmicro.Expertis.Engine.UI.Label
        Me.lblImporte = New Solmicro.Expertis.Engine.UI.Label
        Me.lblDescripcion = New Solmicro.Expertis.Engine.UI.Label
        Me.cmbAceptar = New Solmicro.Expertis.Engine.UI.Button
        Me.cmbCancelar = New Solmicro.Expertis.Engine.UI.Button
        Me.txtIDCContable = New Solmicro.Expertis.Engine.UI.TextBox
        Me.txtDescripcion = New Solmicro.Expertis.Engine.UI.TextBox
        Me.FraCContable = New Solmicro.Expertis.Engine.UI.Frame
        Me.clbFecha = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.nbxImporte = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.FraAcumulados = New Solmicro.Expertis.Engine.UI.Frame
        Me.lblPorcentajeAcu = New Solmicro.Expertis.Engine.UI.Label
        Me.nbxImporteAcumulado = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblImporteAcumulado = New Solmicro.Expertis.Engine.UI.Label
        Me.txtPorcentajeAcu = New Solmicro.Expertis.Engine.UI.TextBox
        CType(Me.SubGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.jngCentroCoste, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FraCContable.SuspendLayout()
        Me.FraAcumulados.SuspendLayout()
        Me.SuspendLayout()
        '
        'SubGrid
        '
        Me.SubGrid.CellSelectionMode = Janus.Windows.GridEX.CellSelectionMode.SingleCell
        SubGrid_DesignTimeLayout.LayoutString = resources.GetString("SubGrid_DesignTimeLayout.LayoutString")
        Me.SubGrid.DesignTimeLayout = SubGrid_DesignTimeLayout
        Me.SubGrid.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.SubGrid.EntityName = Nothing
        Me.SubGrid.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.SubGrid.Location = New System.Drawing.Point(371, 300)
        Me.SubGrid.Name = "SubGrid"
        Me.SubGrid.PrimaryDataFields = Nothing
        Me.SubGrid.ScrollBars = Janus.Windows.GridEX.ScrollBars.None
        Me.SubGrid.SecondaryDataFields = Nothing
        Me.SubGrid.Size = New System.Drawing.Size(165, 21)
        Me.SubGrid.TabIndex = 39
        Me.SubGrid.ViewName = Nothing
        Me.SubGrid.Visible = False
        '
        'jngCentroCoste
        '
        Me.jngCentroCoste.AdvSearchColumns = New Solmicro.Expertis.Engine.UI.AdvSearchColumns(New Solmicro.Expertis.Engine.UI.AdvSearchColumn() {New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDCentroGestion", "CentroGestion", "IDCentroGestion")})
        jngCentroCoste_DesignTimeLayout.LayoutString = resources.GetString("jngCentroCoste_DesignTimeLayout.LayoutString")
        Me.jngCentroCoste.DesignTimeLayout = jngCentroCoste_DesignTimeLayout
        Me.jngCentroCoste.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.jngCentroCoste.EntityName = "FacturaCompraAnalitica"
        Me.jngCentroCoste.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.jngCentroCoste.Location = New System.Drawing.Point(10, 92)
        Me.jngCentroCoste.Name = "jngCentroCoste"
        Me.jngCentroCoste.PrimaryDataFields = "IDLineaFactura"
        Me.jngCentroCoste.SecondaryDataFields = "IDLineaFactura"
        Me.jngCentroCoste.Size = New System.Drawing.Size(526, 202)
        Me.jngCentroCoste.TabIndex = 28
        Me.jngCentroCoste.Tag = "IdRec=4569:4571:4401:4402:;"
        Me.jngCentroCoste.ViewName = "VfrmMntoFacturaCompraAnalitica"
        '
        'lblIDCContable
        '
        Me.lblIDCContable.Location = New System.Drawing.Point(24, 25)
        Me.lblIDCContable.Name = "lblIDCContable"
        Me.lblIDCContable.Size = New System.Drawing.Size(103, 13)
        Me.lblIDCContable.TabIndex = 34
        Me.lblIDCContable.Tag = ""
        Me.lblIDCContable.Text = "Cuenta Contable"
        '
        'lblFecha
        '
        Me.lblFecha.Location = New System.Drawing.Point(225, 26)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(40, 13)
        Me.lblFecha.TabIndex = 35
        Me.lblFecha.Tag = ""
        Me.lblFecha.Text = "Fecha"
        '
        'lblImporte
        '
        Me.lblImporte.Location = New System.Drawing.Point(368, 25)
        Me.lblImporte.Name = "lblImporte"
        Me.lblImporte.Size = New System.Drawing.Size(53, 13)
        Me.lblImporte.TabIndex = 36
        Me.lblImporte.Tag = ""
        Me.lblImporte.Text = "Importe"
        '
        'lblDescripcion
        '
        Me.lblDescripcion.Location = New System.Drawing.Point(24, 55)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(73, 13)
        Me.lblDescripcion.TabIndex = 37
        Me.lblDescripcion.Tag = ""
        Me.lblDescripcion.Text = "Descripción"
        '
        'cmbAceptar
        '
        Me.cmbAceptar.Location = New System.Drawing.Point(369, 327)
        Me.cmbAceptar.Name = "cmbAceptar"
        Me.cmbAceptar.Size = New System.Drawing.Size(81, 25)
        Me.cmbAceptar.TabIndex = 25
        Me.cmbAceptar.Text = "Aceptar"
        '
        'cmbCancelar
        '
        Me.cmbCancelar.Location = New System.Drawing.Point(457, 327)
        Me.cmbCancelar.Name = "cmbCancelar"
        Me.cmbCancelar.Size = New System.Drawing.Size(81, 25)
        Me.cmbCancelar.TabIndex = 26
        Me.cmbCancelar.Text = "Cancelar"
        '
        'txtIDCContable
        '
        Me.txtIDCContable.DisabledBackColor = System.Drawing.Color.White
        Me.txtIDCContable.Enabled = False
        Me.txtIDCContable.Location = New System.Drawing.Point(134, 23)
        Me.txtIDCContable.Name = "txtIDCContable"
        Me.txtIDCContable.ReadOnly = True
        Me.txtIDCContable.Size = New System.Drawing.Size(86, 21)
        Me.txtIDCContable.TabIndex = 27
        '
        'txtDescripcion
        '
        Me.txtDescripcion.DisabledBackColor = System.Drawing.Color.White
        Me.txtDescripcion.Enabled = False
        Me.txtDescripcion.Location = New System.Drawing.Point(134, 53)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.ReadOnly = True
        Me.txtDescripcion.Size = New System.Drawing.Size(389, 21)
        Me.txtDescripcion.TabIndex = 30
        '
        'FraCContable
        '
        Me.FraCContable.Controls.Add(Me.clbFecha)
        Me.FraCContable.Controls.Add(Me.nbxImporte)
        Me.FraCContable.Location = New System.Drawing.Point(11, 4)
        Me.FraCContable.Name = "FraCContable"
        Me.FraCContable.Size = New System.Drawing.Size(525, 82)
        Me.FraCContable.TabIndex = 32
        Me.FraCContable.TabStop = False
        Me.FraCContable.Tag = "IdRec=0;"
        '
        'clbFecha
        '
        Me.clbFecha.DisabledBackColor = System.Drawing.Color.White
        Me.clbFecha.Enabled = False
        Me.clbFecha.Location = New System.Drawing.Point(255, 20)
        Me.clbFecha.Name = "clbFecha"
        Me.clbFecha.Size = New System.Drawing.Size(96, 21)
        Me.clbFecha.TabIndex = 1
        '
        'nbxImporte
        '
        Me.nbxImporte.DisabledBackColor = System.Drawing.Color.White
        Me.nbxImporte.Enabled = False
        Me.nbxImporte.Location = New System.Drawing.Point(414, 19)
        Me.nbxImporte.Name = "nbxImporte"
        Me.nbxImporte.ReadOnly = True
        Me.nbxImporte.Size = New System.Drawing.Size(98, 21)
        Me.nbxImporte.TabIndex = 0
        '
        'FraAcumulados
        '
        Me.FraAcumulados.Controls.Add(Me.lblPorcentajeAcu)
        Me.FraAcumulados.Controls.Add(Me.nbxImporteAcumulado)
        Me.FraAcumulados.Controls.Add(Me.lblImporteAcumulado)
        Me.FraAcumulados.Controls.Add(Me.txtPorcentajeAcu)
        Me.FraAcumulados.Location = New System.Drawing.Point(10, 290)
        Me.FraAcumulados.Name = "FraAcumulados"
        Me.FraAcumulados.Size = New System.Drawing.Size(251, 64)
        Me.FraAcumulados.TabIndex = 31
        Me.FraAcumulados.TabStop = False
        Me.FraAcumulados.Tag = "IdRec=0;"
        '
        'lblPorcentajeAcu
        '
        Me.lblPorcentajeAcu.Location = New System.Drawing.Point(8, 17)
        Me.lblPorcentajeAcu.Name = "lblPorcentajeAcu"
        Me.lblPorcentajeAcu.Size = New System.Drawing.Size(134, 13)
        Me.lblPorcentajeAcu.TabIndex = 39
        Me.lblPorcentajeAcu.Tag = ""
        Me.lblPorcentajeAcu.Text = "Porcentaje acumulado"
        '
        'nbxImporteAcumulado
        '
        Me.nbxImporteAcumulado.DisabledBackColor = System.Drawing.Color.White
        Me.nbxImporteAcumulado.Enabled = False
        Me.nbxImporteAcumulado.Location = New System.Drawing.Point(146, 39)
        Me.nbxImporteAcumulado.Name = "nbxImporteAcumulado"
        Me.nbxImporteAcumulado.ReadOnly = True
        Me.nbxImporteAcumulado.Size = New System.Drawing.Size(96, 21)
        Me.nbxImporteAcumulado.TabIndex = 25
        '
        'lblImporteAcumulado
        '
        Me.lblImporteAcumulado.Location = New System.Drawing.Point(8, 39)
        Me.lblImporteAcumulado.Name = "lblImporteAcumulado"
        Me.lblImporteAcumulado.Size = New System.Drawing.Size(120, 13)
        Me.lblImporteAcumulado.TabIndex = 24
        Me.lblImporteAcumulado.Tag = "IdRec=4936;"
        Me.lblImporteAcumulado.Text = "Importe Acumulado"
        '
        'txtPorcentajeAcu
        '
        Me.txtPorcentajeAcu.DisabledBackColor = System.Drawing.Color.White
        Me.txtPorcentajeAcu.Enabled = False
        Me.txtPorcentajeAcu.Location = New System.Drawing.Point(171, 15)
        Me.txtPorcentajeAcu.Name = "txtPorcentajeAcu"
        Me.txtPorcentajeAcu.ReadOnly = True
        Me.txtPorcentajeAcu.Size = New System.Drawing.Size(71, 21)
        Me.txtPorcentajeAcu.TabIndex = 8
        Me.txtPorcentajeAcu.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
        '
        'AnaliticaNuevoGasto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(544, 357)
        Me.Controls.Add(Me.SubGrid)
        Me.Controls.Add(Me.jngCentroCoste)
        Me.Controls.Add(Me.lblIDCContable)
        Me.Controls.Add(Me.lblFecha)
        Me.Controls.Add(Me.lblImporte)
        Me.Controls.Add(Me.lblDescripcion)
        Me.Controls.Add(Me.cmbAceptar)
        Me.Controls.Add(Me.cmbCancelar)
        Me.Controls.Add(Me.txtIDCContable)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.FraCContable)
        Me.Controls.Add(Me.FraAcumulados)
        Me.EntityName = "FacturaCompraLinea"
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "AnaliticaNuevoGasto"
        Me.Text = "Analítica Nuevo Gasto"
        Me.ViewName = "tbFacturaCompraLinea"
        CType(Me.SubGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.jngCentroCoste, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FraCContable.ResumeLayout(False)
        Me.FraCContable.PerformLayout()
        Me.FraAcumulados.ResumeLayout(False)
        Me.FraAcumulados.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SubGrid As Solmicro.Expertis.Engine.UI.Grid
    Friend WithEvents jngCentroCoste As Solmicro.Expertis.Engine.UI.Grid
    Friend WithEvents lblIDCContable As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblFecha As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblImporte As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblDescripcion As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents cmbAceptar As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents cmbCancelar As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents txtIDCContable As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents txtDescripcion As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents FraCContable As Solmicro.Expertis.Engine.UI.Frame
    Friend WithEvents nbxImporte As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents FraAcumulados As Solmicro.Expertis.Engine.UI.Frame
    Friend WithEvents nbxImporteAcumulado As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents lblImporteAcumulado As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents txtPorcentajeAcu As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents lblPorcentajeAcu As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents clbFecha As Solmicro.Expertis.Engine.UI.CalendarBox
End Class
