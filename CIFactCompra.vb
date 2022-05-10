Public Class CIFactCompra
    Inherits Solmicro.Expertis.Engine.UI.CIMnto

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicialización después de la llamada a InitializeComponent()
        txtImporteDesde.Value = System.DBNull.Value
        txtImporteHasta.Value = System.DBNull.Value
    End Sub

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms requiere el siguiente procedimiento
    'Puede modificarse utilizando el Diseñador de Windows Forms. 
    'No lo modifique con el editor de código.
    Public WithEvents lblfwiEstado As Solmicro.Expertis.Engine.UI.Label
    'Public WithEvents Grid As Solmicro.Expertis.Engine.UI.Grid
    Public WithEvents Panel1 As Solmicro.Expertis.Engine.UI.Panel
    Public WithEvents lblTotal As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents txtTotalA As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents lblFacturaDesde As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblFacturaHasta As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblProveedor As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblImpDesde As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblImpHasta As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblContador As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblEjercicio As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblFechaDesde As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblFechaHasta As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblContabilizado As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents AdvFacturaDesde As Solmicro.Expertis.Engine.UI.AdvSearch
    Public WithEvents AdvFacturaHasta As Solmicro.Expertis.Engine.UI.AdvSearch
    Public WithEvents AdvProveedor As Solmicro.Expertis.Engine.UI.AdvSearch
    Public WithEvents AdvContador As Solmicro.Expertis.Engine.UI.AdvSearch
    Public WithEvents cbxEjercicio As Solmicro.Expertis.Engine.UI.ComboBox
    Public WithEvents cbxFechaDesde As Solmicro.Expertis.Engine.UI.CalendarBox
    Public WithEvents cbxFechaHasta As Solmicro.Expertis.Engine.UI.CalendarBox
    Public WithEvents cbxContabilizado As Solmicro.Expertis.Engine.UI.ComboBox
    Public WithEvents txtImporteHasta As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents ImageList1 As System.Windows.Forms.ImageList
    Public WithEvents txtImporteDesde As Solmicro.Expertis.Engine.UI.NumericTextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim Grid_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim Grid_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.ImageList.ImageStream")
        Dim cbxContabilizado_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim cbxEjercicio_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CIFactCompra))
        Me.AdvFacturaDesde = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblFacturaDesde = New Solmicro.Expertis.Engine.UI.Label
        Me.AdvFacturaHasta = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblFacturaHasta = New Solmicro.Expertis.Engine.UI.Label
        Me.AdvProveedor = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblProveedor = New Solmicro.Expertis.Engine.UI.Label
        Me.lblImpDesde = New Solmicro.Expertis.Engine.UI.Label
        Me.lblImpHasta = New Solmicro.Expertis.Engine.UI.Label
        Me.AdvContador = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblContador = New Solmicro.Expertis.Engine.UI.Label
        Me.lblEjercicio = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxFechaDesde = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.lblFechaDesde = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxFechaHasta = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.lblFechaHasta = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxContabilizado = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.lblContabilizado = New Solmicro.Expertis.Engine.UI.Label
        Me.lblfwiEstado = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxEjercicio = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.txtImporteHasta = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.txtImporteDesde = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.Panel1 = New Solmicro.Expertis.Engine.UI.Panel
        Me.lblTotal = New Solmicro.Expertis.Engine.UI.Label
        Me.txtTotalA = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.FilterPanel.SuspendLayout()
        Me.CIMntoGridPanel.suspendlayout()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Toolbar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Menubar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainPanel.SuspendLayout()
        Me.MainPanelCIMntoContainer.SuspendLayout()
        CType(Me.cbxContabilizado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbxEjercicio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.suspendlayout()
        Me.SuspendLayout()
        '
        'FilterPanel
        '
        Me.FilterPanel.Controls.Add(Me.txtImporteHasta)
        Me.FilterPanel.Controls.Add(Me.txtImporteDesde)
        Me.FilterPanel.Controls.Add(Me.cbxEjercicio)
        Me.FilterPanel.Controls.Add(Me.lblFacturaDesde)
        Me.FilterPanel.Controls.Add(Me.lblFacturaHasta)
        Me.FilterPanel.Controls.Add(Me.lblProveedor)
        Me.FilterPanel.Controls.Add(Me.lblImpDesde)
        Me.FilterPanel.Controls.Add(Me.lblImpHasta)
        Me.FilterPanel.Controls.Add(Me.lblContador)
        Me.FilterPanel.Controls.Add(Me.lblEjercicio)
        Me.FilterPanel.Controls.Add(Me.lblFechaDesde)
        Me.FilterPanel.Controls.Add(Me.lblFechaHasta)
        Me.FilterPanel.Controls.Add(Me.lblContabilizado)
        Me.FilterPanel.Controls.Add(Me.lblfwiEstado)
        Me.FilterPanel.Controls.Add(Me.AdvFacturaDesde)
        Me.FilterPanel.Controls.Add(Me.AdvFacturaHasta)
        Me.FilterPanel.Controls.Add(Me.AdvProveedor)
        Me.FilterPanel.Controls.Add(Me.AdvContador)
        Me.FilterPanel.Controls.Add(Me.cbxFechaDesde)
        Me.FilterPanel.Controls.Add(Me.cbxFechaHasta)
        Me.FilterPanel.Controls.Add(Me.cbxContabilizado)
        Me.FilterPanel.Size = New System.Drawing.Size(624, 128)
        '
        'CIMntoGridPanel
        '
        Me.CIMntoGridPanel.Controls.Add(Me.Panel1)
        Me.CIMntoGridPanel.Size = New System.Drawing.Size(624, 189)
        Me.CIMntoGridPanel.Controls.SetChildIndex(Me.Panel1, 0)
        Me.CIMntoGridPanel.Controls.SetChildIndex(Me.Grid, 0)
        '
        'Grid
        '
        Grid_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("Grid_DesignTimeLayout_Reference_0.Instance"), Object)
        Grid_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {Grid_DesignTimeLayout_Reference_0})
        Grid_DesignTimeLayout.LayoutString = resources.GetString("Grid_DesignTimeLayout.LayoutString")
        Me.Grid.DesignTimeLayout = Grid_DesignTimeLayout
        Me.Grid.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.Grid.EntityName = "FacturaCompraCabecera"
        Me.Grid.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.Grid.FrozenColumns = 5
        Me.Grid.ImageList = Me.ImageList1
        Me.Grid.KeyField = "IDFactura"
        Me.Grid.Size = New System.Drawing.Size(624, 157)
        Me.Grid.TabIndex = 10
        Me.Grid.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.Grid.UseCheck = True
        Me.Grid.ViewName = "vCtlCIFactCompra"
        '
        'CheckAll
        '
        Me.CheckAll.Enabled = Janus.Windows.UI.InheritableBoolean.[False]
        Me.CheckAll.Visible = Janus.Windows.UI.InheritableBoolean.[True]
        '
        'UncheckAll
        '
        Me.UncheckAll.Enabled = Janus.Windows.UI.InheritableBoolean.[False]
        Me.UncheckAll.Visible = Janus.Windows.UI.InheritableBoolean.[True]
        '
        'ShowAllCheckedItems
        '
        Me.ShowAllCheckedItems.Enabled = Janus.Windows.UI.InheritableBoolean.[False]
        Me.ShowAllCheckedItems.Visible = Janus.Windows.UI.InheritableBoolean.[True]
        '
        'ClearFilter
        '
        Me.ClearFilter.Enabled = Janus.Windows.UI.InheritableBoolean.[False]
        '
        'Export
        '
        Me.Export.Enabled = Janus.Windows.UI.InheritableBoolean.[False]
        '
        'Toolbar
        '
        Me.Toolbar.Size = New System.Drawing.Size(320, 28)
        '
        'Menubar
        '
        Me.Menubar.Location = New System.Drawing.Point(0, 28)
        '
        'MainPanel
        '
        Me.MainPanel.Size = New System.Drawing.Size(624, 317)
        '
        'ExecuteActions
        '
        Me.ExecuteActions.Enabled = Janus.Windows.UI.InheritableBoolean.[False]
        '
        'MainPanelCIMntoContainer
        '
        Me.MainPanelCIMntoContainer.Size = New System.Drawing.Size(624, 317)
        '
        'AdvFacturaDesde
        '
        Me.AdvFacturaDesde.DisabledBackColor = System.Drawing.Color.White
        Me.AdvFacturaDesde.DisplayField = "NFactura"
        Me.AdvFacturaDesde.EntityName = "FacturaCompraCabecera"
        Me.AdvFacturaDesde.Location = New System.Drawing.Point(95, 23)
        Me.AdvFacturaDesde.Name = "AdvFacturaDesde"
        Me.AdvFacturaDesde.SecondaryDataFields = "IDFactura"
        Me.AdvFacturaDesde.Size = New System.Drawing.Size(115, 23)
        Me.AdvFacturaDesde.TabIndex = 1
        '
        'lblFacturaDesde
        '
        Me.lblFacturaDesde.Location = New System.Drawing.Point(8, 23)
        Me.lblFacturaDesde.Name = "lblFacturaDesde"
        Me.lblFacturaDesde.Size = New System.Drawing.Size(87, 13)
        Me.lblFacturaDesde.TabIndex = 0
        Me.lblFacturaDesde.Tag = "IdRec=4776;"
        Me.lblFacturaDesde.Text = "Nº Ftra Desde"
        '
        'AdvFacturaHasta
        '
        Me.AdvFacturaHasta.DisabledBackColor = System.Drawing.Color.White
        Me.AdvFacturaHasta.DisplayField = "NFactura"
        Me.AdvFacturaHasta.EntityName = "FacturaCompraCabecera"
        Me.AdvFacturaHasta.Location = New System.Drawing.Point(95, 47)
        Me.AdvFacturaHasta.Name = "AdvFacturaHasta"
        Me.AdvFacturaHasta.SecondaryDataFields = "IDFactura"
        Me.AdvFacturaHasta.Size = New System.Drawing.Size(115, 23)
        Me.AdvFacturaHasta.TabIndex = 2
        '
        'lblFacturaHasta
        '
        Me.lblFacturaHasta.Location = New System.Drawing.Point(8, 47)
        Me.lblFacturaHasta.Name = "lblFacturaHasta"
        Me.lblFacturaHasta.Size = New System.Drawing.Size(83, 13)
        Me.lblFacturaHasta.TabIndex = 2
        Me.lblFacturaHasta.Tag = "IdRec=4775;"
        Me.lblFacturaHasta.Text = "Nº Ftra Hasta"
        '
        'AdvProveedor
        '
        Me.AdvProveedor.DisabledBackColor = System.Drawing.Color.White
        Me.AdvProveedor.EntityName = "Proveedor"
        Me.AdvProveedor.Location = New System.Drawing.Point(95, 71)
        Me.AdvProveedor.Name = "AdvProveedor"
        Me.AdvProveedor.SecondaryDataFields = "IDProveedor"
        Me.AdvProveedor.Size = New System.Drawing.Size(115, 23)
        Me.AdvProveedor.TabIndex = 3
        '
        'lblProveedor
        '
        Me.lblProveedor.Location = New System.Drawing.Point(8, 71)
        Me.lblProveedor.Name = "lblProveedor"
        Me.lblProveedor.Size = New System.Drawing.Size(66, 13)
        Me.lblProveedor.TabIndex = 4
        Me.lblProveedor.Tag = "IdRec=4352;"
        Me.lblProveedor.Text = "Proveedor"
        '
        'lblImpDesde
        '
        Me.lblImpDesde.Location = New System.Drawing.Point(216, 75)
        Me.lblImpDesde.Name = "lblImpDesde"
        Me.lblImpDesde.Size = New System.Drawing.Size(75, 13)
        Me.lblImpDesde.TabIndex = 7
        Me.lblImpDesde.Tag = "IdRec=4778;"
        Me.lblImpDesde.Text = "Importe >="
        '
        'lblImpHasta
        '
        Me.lblImpHasta.Location = New System.Drawing.Point(216, 99)
        Me.lblImpHasta.Name = "lblImpHasta"
        Me.lblImpHasta.Size = New System.Drawing.Size(75, 13)
        Me.lblImpHasta.TabIndex = 8
        Me.lblImpHasta.Tag = "IdRec=4780;"
        Me.lblImpHasta.Text = "Importe <="
        '
        'AdvContador
        '
        Me.AdvContador.DisabledBackColor = System.Drawing.Color.White
        Me.AdvContador.EntityName = "EntidadContador"
        Me.AdvContador.Location = New System.Drawing.Point(512, 23)
        Me.AdvContador.Name = "AdvContador"
        Me.AdvContador.SecondaryDataFields = "IDContador"
        Me.AdvContador.Size = New System.Drawing.Size(104, 23)
        Me.AdvContador.TabIndex = 8
        '
        'lblContador
        '
        Me.lblContador.Location = New System.Drawing.Point(424, 27)
        Me.lblContador.Name = "lblContador"
        Me.lblContador.Size = New System.Drawing.Size(60, 13)
        Me.lblContador.TabIndex = 9
        Me.lblContador.Tag = "IdRec=4809;"
        Me.lblContador.Text = "Contador"
        '
        'lblEjercicio
        '
        Me.lblEjercicio.Location = New System.Drawing.Point(424, 76)
        Me.lblEjercicio.Name = "lblEjercicio"
        Me.lblEjercicio.Size = New System.Drawing.Size(55, 13)
        Me.lblEjercicio.TabIndex = 10
        Me.lblEjercicio.Tag = "IdRec=4467;"
        Me.lblEjercicio.Text = "Ejercicio"
        '
        'cbxFechaDesde
        '
        Me.cbxFechaDesde.DisabledBackColor = System.Drawing.Color.White
        Me.cbxFechaDesde.Location = New System.Drawing.Point(296, 23)
        Me.cbxFechaDesde.Name = "cbxFechaDesde"
        Me.cbxFechaDesde.Size = New System.Drawing.Size(115, 21)
        Me.cbxFechaDesde.TabIndex = 4
        '
        'lblFechaDesde
        '
        Me.lblFechaDesde.Location = New System.Drawing.Point(216, 27)
        Me.lblFechaDesde.Name = "lblFechaDesde"
        Me.lblFechaDesde.Size = New System.Drawing.Size(80, 13)
        Me.lblFechaDesde.TabIndex = 11
        Me.lblFechaDesde.Tag = "IdRec=4727;"
        Me.lblFechaDesde.Text = "Fecha Desde"
        '
        'cbxFechaHasta
        '
        Me.cbxFechaHasta.DisabledBackColor = System.Drawing.Color.White
        Me.cbxFechaHasta.Location = New System.Drawing.Point(296, 47)
        Me.cbxFechaHasta.Name = "cbxFechaHasta"
        Me.cbxFechaHasta.Size = New System.Drawing.Size(115, 21)
        Me.cbxFechaHasta.TabIndex = 5
        '
        'lblFechaHasta
        '
        Me.lblFechaHasta.Location = New System.Drawing.Point(216, 51)
        Me.lblFechaHasta.Name = "lblFechaHasta"
        Me.lblFechaHasta.Size = New System.Drawing.Size(76, 13)
        Me.lblFechaHasta.TabIndex = 12
        Me.lblFechaHasta.Tag = "IdRec=4726;"
        Me.lblFechaHasta.Text = "Fecha Hasta"
        '
        'cbxContabilizado
        '
        Me.cbxContabilizado.ComboStyle = Janus.Windows.GridEX.ComboStyle.DropDownList
        cbxContabilizado_DesignTimeLayout.LayoutString = resources.GetString("cbxContabilizado_DesignTimeLayout.LayoutString")
        Me.cbxContabilizado.DesignTimeLayout = cbxContabilizado_DesignTimeLayout
        Me.cbxContabilizado.DisabledBackColor = System.Drawing.Color.White
        Me.cbxContabilizado.Location = New System.Drawing.Point(512, 47)
        Me.cbxContabilizado.Name = "cbxContabilizado"
        Me.cbxContabilizado.SelectedIndex = -1
        Me.cbxContabilizado.SelectedItem = Nothing
        Me.cbxContabilizado.Size = New System.Drawing.Size(104, 21)
        Me.cbxContabilizado.TabIndex = 9
        '
        'lblContabilizado
        '
        Me.lblContabilizado.Location = New System.Drawing.Point(424, 51)
        Me.lblContabilizado.Name = "lblContabilizado"
        Me.lblContabilizado.Size = New System.Drawing.Size(84, 13)
        Me.lblContabilizado.TabIndex = 13
        Me.lblContabilizado.Tag = "IdRec=4725;"
        Me.lblContabilizado.Text = "Contabilizado"
        '
        'lblfwiEstado
        '
        Me.lblfwiEstado.Location = New System.Drawing.Point(360, 360)
        Me.lblfwiEstado.Name = "lblfwiEstado"
        Me.lblfwiEstado.Size = New System.Drawing.Size(59, 13)
        Me.lblfwiEstado.TabIndex = 15
        Me.lblfwiEstado.Tag = "IdRec=4781;"
        Me.lblfwiEstado.Text = "Situación"
        '
        'cbxEjercicio
        '
        cbxEjercicio_DesignTimeLayout.LayoutString = resources.GetString("cbxEjercicio_DesignTimeLayout.LayoutString")
        Me.cbxEjercicio.DesignTimeLayout = cbxEjercicio_DesignTimeLayout
        Me.cbxEjercicio.DisabledBackColor = System.Drawing.Color.White
        Me.cbxEjercicio.EntityName = "EjercicioContable"
        Me.cbxEjercicio.Location = New System.Drawing.Point(512, 71)
        Me.cbxEjercicio.Name = "cbxEjercicio"
        Me.cbxEjercicio.SecondaryDataFields = "IDEjercicio"
        Me.cbxEjercicio.SelectedIndex = -1
        Me.cbxEjercicio.SelectedItem = Nothing
        Me.cbxEjercicio.Size = New System.Drawing.Size(104, 21)
        Me.cbxEjercicio.TabIndex = 0
        '
        'txtImporteHasta
        '
        Me.txtImporteHasta.DisabledBackColor = System.Drawing.Color.White
        Me.txtImporteHasta.Location = New System.Drawing.Point(296, 95)
        Me.txtImporteHasta.Name = "txtImporteHasta"
        Me.txtImporteHasta.NullBehavior = Janus.Windows.GridEX.NumericEditNullBehavior.AllowNull
        Me.txtImporteHasta.Size = New System.Drawing.Size(115, 21)
        Me.txtImporteHasta.TabIndex = 7
        '
        'txtImporteDesde
        '
        Me.txtImporteDesde.DisabledBackColor = System.Drawing.Color.White
        Me.txtImporteDesde.Location = New System.Drawing.Point(296, 71)
        Me.txtImporteDesde.Name = "txtImporteDesde"
        Me.txtImporteDesde.NullBehavior = Janus.Windows.GridEX.NumericEditNullBehavior.AllowNull
        Me.txtImporteDesde.Size = New System.Drawing.Size(115, 21)
        Me.txtImporteDesde.TabIndex = 6
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lblTotal)
        Me.Panel1.Controls.Add(Me.txtTotalA)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 157)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(624, 32)
        Me.Panel1.TabIndex = 1
        '
        'lblTotal
        '
        Me.lblTotal.Location = New System.Drawing.Point(448, 8)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(35, 13)
        Me.lblTotal.TabIndex = 16
        Me.lblTotal.Text = "Total"
        '
        'txtTotalA
        '
        Me.txtTotalA.DisabledBackColor = System.Drawing.Color.White
        Me.txtTotalA.Enabled = False
        Me.txtTotalA.Location = New System.Drawing.Point(499, 6)
        Me.txtTotalA.Name = "txtTotalA"
        Me.txtTotalA.Size = New System.Drawing.Size(120, 21)
        Me.txtTotalA.TabIndex = 15
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "add2.ico")
        Me.ImageList1.Images.SetKeyName(1, "delete2.ico")
        Me.ImageList1.Images.SetKeyName(2, "scroll_warning.ico")
        '
        'CIFactCompra
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(632, 405)
        Me.EntityName = "FacturaCompraCabecera"
        Me.KeyField = "IDFactura"
        Me.Name = "CIFactCompra"
        Me.UseCheck = True
        Me.ViewName = "vCtlCIFactCompra"
        Me.FilterPanel.ResumeLayout(False)
        Me.FilterPanel.PerformLayout()
        Me.CIMntoGridPanel.ResumeLayout(False)
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Toolbar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Menubar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainPanel.ResumeLayout(False)
        Me.MainPanelCIMntoContainer.ResumeLayout(False)
        CType(Me.cbxContabilizado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbxEjercicio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region


    Protected Enum IconIndex
        NoContabilizado = 0
        Contabilizado = 1
        ExistenEntregas = 2
    End Enum

    Protected mMonedaA As MonedaInfo
    Protected Const mstrEntidad As String = "FacturaCompraCabecera"
    Protected MBlnContabilidad As Boolean
    Protected mblnGestionAnalitica As Boolean

#Region " Load "

    Protected Overridable Sub CIFactCompra_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Not Me.DesignMode Then
            LoadERPData()
            LoadEnums()
            LoadToolBarActions()
            LoadGridActions()
        End If
    End Sub

    Protected Overridable Sub LoadERPData()
        Dim m As New Moneda
        mMonedaA = ExpertisApp.ExecuteTask(Of Date, MonedaInfo)(AddressOf Moneda.MonedaA, cnMinDate)
        Dim ClsParam As New Parametro
        MBlnContabilidad = ClsParam.Contabilidad
        mblnGestionAnalitica = ClsParam.CAnaliticPredet
        If ClsParam.ExpertisSAAS Then Me.Grid.Columns("EntregasAcuenta").Visible = False
        If Not MBlnContabilidad Then
            lblContabilizado.Text = "Validada"
            cbxEjercicio.Visible = False
            lblEjercicio.Visible = False
        End If
    End Sub

    Protected Overridable Sub LoadEnums()

        Dim ClsParam As New Parametro
        If ClsParam.DobleContabilidad Then
            cbxContabilizado.DataSource = New EnumData("enumContabilizadoTodos")
            cbxContabilizado.Value = enumContabilizadoTodos.NoContabilizado
        Else
            cbxContabilizado.DataSource = New EnumData("enumSiNo")
            cbxContabilizado.Value = enumBoolean.No
        End If

    End Sub

    Protected Overridable Sub LoadToolBarActions()
        If MBlnContabilidad Then
            Me.FormActions.Add("Contabilización", AddressOf AccionContabilizar, ExpertisApp.GetIcon("import2.ico"))
            Me.FormActions.Add("Descontabilización", AddressOf AccionDescontabilizar, ExpertisApp.GetIcon("export2.ico"))
        Else
            Me.FormActions.Add("Validar Factura y crear Pagos en cartera", AddressOf AccionContabilizar, ExpertisApp.GetIcon("import2.ico"))
            Me.FormActions.Add("Modificar Factura y eliminar Pagos en cartera", AddressOf AccionDescontabilizar, ExpertisApp.GetIcon("export2.ico"))
        End If
    End Sub

    Protected Overridable Sub LoadGridActions()
        Me.Grid.Actions.Add("Abrir Factura", AddressOf AccionAbrirFactura, ExpertisApp.GetIcon("xFacturaCompra.ico"))
        Me.Grid.Actions.Add("Abrir Proveedor", AddressOf AccionAbrirProveedor, ExpertisApp.GetIcon("xProveedores.ico"))
    End Sub

#End Region

#Region " Toolbar Actions "

    Protected Overridable Sub AccionDescontabilizar()
        Dim dtGrid As DataTable = Me.CheckedRecords
        If Not dtGrid Is Nothing AndAlso dtGrid.Rows.Count > 0 Then
            Dim mIDProcess As Guid = Grid.SaveServerChecks()
            Dim mstrIDProcess As String = mIDProcess.ToString
            Dim BEDataEngine As New BE.DataEngine
            Dim dt As DataTable = BEDataEngine.Filter("CtlCIFactCompraDescontValidacion", New StringFilterItem("IDProcess", FilterOperator.Equal, mstrIDProcess))
            BEDataEngine = Nothing
            If Not IsNothing(dt) AndAlso dt.Rows.Count > 0 Then
                If MBlnContabilidad Then
                    ExpertisApp.GenerateMessage("Existen facturas seleccionadas descontabilizadas o pertenecientes a un ejercicio cerrado que no intervendrán en el proceso.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    ExpertisApp.GenerateMessage("Existen facturas seleccionadas que ya son modificables.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
                Exit Sub
            End If
            If MBlnContabilidad Then
                Dim frm As New frmDescontabilizar
                frm.IDProcess = mIDProcess
                frm.ShowDialog()
            Else
                Dim StrIDs(dtGrid.Rows.Count - 1) As String
                Dim j As Integer = 0
                For Each Dr As DataRow In dtGrid.Select
                    StrIDs(j) = Dr("IDFactura")
                    j += 1
                Next
                Dim FilDatos As New Filter
                FilDatos.Add(New InListFilterItem("IDFactura", StrIDs, FilterType.Numeric))
                Dim StDataC As New FacturaCompraCabecera.DataCambiarEstadoFactura(FilDatos, CInt(enumfccEstado.fccNoContabilizado))
                If ExpertisApp.ExecuteTask(Of FacturaCompraCabecera.DataCambiarEstadoFactura, Boolean)(AddressOf FacturaCompraCabecera.CambiarEstadoContabFacturas, StDataC) Then
                    ExpertisApp.GenerateMessage("Puede modificar su factura, recuerde validar de nuevo para crear los pagos.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If

            UnCheckAllRecords()
            Me.Execute()

        Else

            ExpertisApp.GenerateMessage("Debe seleccionar alguna fila.", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
  
    Protected Overridable Sub AccionContabilizar()
        Dim dtMarcados As DataTable = Me.CheckedRecords
        If Not dtMarcados Is Nothing AndAlso dtMarcados.Rows.Count > 0 Then
            Dim G As Guid = Grid.SaveServerChecks()
            Dim mstrIDProcess As String = G.ToString
            Dim de As New BE.DataEngine
            Dim dt As DataTable = de.Filter("CtlCIFactCompraContValidacion", New StringFilterItem("IDProcess", FilterOperator.Equal, mstrIDProcess))
            If Not IsNothing(dt) AndAlso dt.Rows.Count > 0 Then
                If MBlnContabilidad Then
                    ExpertisApp.GenerateMessage("Existen facturas seleccionadas contabilizadas o pertenecientes a un ejercicio cerrado que no intervendrán en el proceso.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    ExpertisApp.GenerateMessage("Existen facturas seleccionadas ya validadas.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
                Exit Sub
            End If
            If MBlnContabilidad Then
                If mblnGestionAnalitica Then
                    Dim dtFCAnaliticaNoDeduc As DataTable = de.Filter("vFCConIVANoDeducible", New GuidFilterItem("IDProcess", FilterOperator.Equal, G))
                    If Not dtFCAnaliticaNoDeduc Is Nothing AndAlso dtFCAnaliticaNoDeduc.Rows.Count > 0 Then
                        ExpertisApp.GenerateMessage("Existen facturas seleccionadas con IVA No Deducible. Recuerde que debe revisar los desgloses analíticos.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                End If
                Dim SimInfo As New DataSimulacionContableInfo
                SimInfo.TipoContabilizacion = enumTipoContabilizacion.tcFacturaCompra
                SimInfo.IDEjercicio = String.Empty
                SimInfo.GuidSimulacion = G
                SimInfo.Caption = "Simulación Contable - FACTURAS COMPRA -"
                Dim oFrm As Form = ExpertisApp.OpenForm("CISIMUCONT", , SimInfo, Me)
                AddHandler oFrm.Closed, AddressOf FrmActionClosed
            Else
                Dim StrIDS(dtMarcados.Rows.Count - 1) As String
                Dim j As Integer = 0
                For Each Dr As DataRow In dtMarcados.Select
                    StrIDS(j) = Dr("IDFactura")
                    j += 1
                Next
                Dim FilDatos As New Filter
                FilDatos.Add(New InListFilterItem("IDFactura", StrIDS, FilterType.Numeric))
                Dim ClsFactCompra As New FacturaCompraCabecera
                Dim StData As New FacturaCompraCabecera.DataCambiarEstadoFactura(FilDatos, CInt(enumfccEstado.fccContabilizado))
                If ExpertisApp.ExecuteTask(Of FacturaCompraCabecera.DataCambiarEstadoFactura, Boolean)(AddressOf FacturaCompraCabecera.CambiarEstadoContabFacturas, StData) Then
                    ExpertisApp.GenerateMessage("Facturas seleccionadas Validadas y Pagos Generados.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
                Me.UnCheckAllRecords()
                Me.Execute()
            End If
        Else
            ExpertisApp.GenerateMessage("Debe seleccionar alguna fila.", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub
    Protected Overridable Sub FrmActionClosed(ByVal sender As Object, ByVal e As System.EventArgs)
        RemoveHandler CType(sender, Form).Closed, AddressOf FrmActionClosed
        If CType(sender, Form).DialogResult = DialogResult.OK Then
            Me.UnCheckAllRecords()
            Me.DeleteServerChecks()
            Me.Execute()
        End If
    End Sub

#End Region

#Region " Grid Actions "

    Protected Overridable Sub AccionAbrirFactura()
        If Length(Grid.GetValue("IDFactura")) > 0 Then
            ExpertisApp.OpenForm("MFACC", New NumberFilterItem("IDFactura", Grid.GetValue("IDFactura")))
        End If
    End Sub

    Protected Overridable Sub AccionAbrirProveedor()
        If Length(Grid.GetValue("IDProveedor")) > 0 Then
            ExpertisApp.OpenForm("MPROV", New StringFilterItem("IDProveedor", Grid.GetValue("IDProveedor")))
        End If
    End Sub

#End Region

#Region " Grid "

    Protected Overridable Sub Grid_FormattingRow(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowLoadEventArgs) Handles Grid.FormattingRow
        If e.Row.RowType = RowType.Record Then
            If e.Row.Cells("Estado").Value = enumfccEstado.fccContabilizado Then
                e.Row.RowStyle = Grid.FormatStyles("ContabilizadoFormatStyle")
                e.Row.Cells("Estado").ImageIndex = IconIndex.Contabilizado
            Else
                e.Row.Cells("Estado").ImageIndex = IconIndex.NoContabilizado
            End If
        End If
        If CBool(e.Row.Cells("EntregasACuenta").Value) Then 'Entregas a Cuenta 
            e.Row.Cells("EntregasACuenta").ImageIndex = IconIndex.ExistenEntregas
        Else
            e.Row.Cells("EntregasACuenta").ImageIndex = 3
        End If
        ' Se fijan las 4 primeras columnas del grid que ha desencadenado el evento.
        Grid.FrozenColumns = 7
    End Sub

    Protected Overridable Sub Grid_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Grid.Click
        Dim objArea As Janus.Windows.GridEX.GridArea = Grid.HitTest()
        If objArea = Janus.Windows.GridEX.GridArea.Cell Then
            Dim objCol As Janus.Windows.GridEX.GridEXColumn = Grid.ColumnFromPoint()
            If Not IsNothing(objCol) Then
                Select Case objCol.Key
                    Case "EntregasACuenta"
                        If Grid.Value("EntregasACuenta") Then
                            Dim frmVerEntregas As New frmVerEntregasACuenta
                            frmVerEntregas.AñadirEntregas = False
                            frmVerEntregas.CircuitoOrigen = Circuito.Compras
                            frmVerEntregas.IDClienteProveedor = Grid.Value("IDProveedor")
                            frmVerEntregas.DescClienteProveedor = Grid.Value("DescProveedor")
                            frmVerEntregas.ShowDialog(Me)
                        End If
                End Select
            End If
        End If
    End Sub

#End Region

    Protected Overridable Sub AdvContador_SetPredefinedFilter(ByVal sender As System.Object, ByVal e As Solmicro.Expertis.Engine.UI.AdvSearchFilterEventArgs) Handles AdvContador.SetPredefinedFilter
        e.Filter.Add("Entidad", FilterOperator.Equal, mstrEntidad)
    End Sub

    Protected Overridable Sub AdvFacturaDesde_Hasta_SetPredefinedFilter(ByVal sender As Object, ByVal e As Engine.UI.AdvSearchFilterEventArgs) Handles AdvFacturaDesde.SetPredefinedFilter, AdvFacturaHasta.SetPredefinedFilter
        If Length(cbxEjercicio.Value) > 0 Then
            e.Filter.Add("IDEjercicio", FilterOperator.Equal, cbxEjercicio.Value, FilterType.String)
        End If
    End Sub

    Protected Overridable Sub AdvFacturaDesde_SelectionChanged(ByVal sender As System.Object, ByVal e As Solmicro.Expertis.Engine.UI.AdvSearchSelectionChangedEventArgs) Handles AdvFacturaDesde.SelectionChanged
        AdvFacturaHasta.Text = AdvFacturaDesde.Text
    End Sub

#Region " Query Execute "

    Protected Overridable Sub CIFactCompra_QueryExecuting(ByVal sender As Object, ByRef e As Engine.UI.QueryExecutingEventArgs) Handles MyBase.QueryExecuting
        If cbxContabilizado.Value <> enumContabilizadoTodos.Todos Then
            e.Filter.Add(New NumberFilterItem("Estado", FilterOperator.Equal, cbxContabilizado.Value))
        End If
        e.Filter.Add("IDEjercicio", FilterOperator.Equal, cbxEjercicio.Value, FilterType.String)
        e.Filter.Add("IDFactura", FilterOperator.GreaterThanOrEqual, AdvFacturaDesde.Value, FilterType.Numeric)
        e.Filter.Add("IDFactura", FilterOperator.LessThanOrEqual, AdvFacturaHasta.Value, FilterType.Numeric)
        e.Filter.Add("ImpTotalA", FilterOperator.GreaterThanOrEqual, txtImporteDesde.Value, FilterType.Numeric)
        e.Filter.Add("ImpTotalA", FilterOperator.LessThanOrEqual, txtImporteHasta.Value, FilterType.Numeric)
        e.Filter.Add("FechaFactura", FilterOperator.GreaterThanOrEqual, cbxFechaDesde.Value, FilterType.DateTime)
        e.Filter.Add("FechaFactura", FilterOperator.LessThanOrEqual, cbxFechaHasta.Value, FilterType.DateTime)
        e.Filter.Add("IDProveedor", FilterOperator.Equal, AdvProveedor.Text, FilterType.String)
        If Not AdvContador.Text Is Nothing AndAlso AdvContador.Text <> String.Empty Then
            e.Filter.Add(New LikeFilterItem("IDContador", AdvContador.Text))
        End If
    End Sub

    Protected Overridable Sub CIFactCompra_QueryExecuted(ByVal sender As Object, ByRef e As Engine.UI.QueryExecutedEventArgs) Handles MyBase.QueryExecuted
        CalcularTotales()
    End Sub

    Protected Overridable Sub CalcularTotales()
        txtTotalA.Value = xRound(Grid.GetTotal(Grid.Columns("ImpTotalA"), AggregateFunction.Sum), mMonedaA.NDecimalesImporte)
    End Sub

    Protected Overridable Sub CIFactCompra_FilterCleared(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.FilterCleared
        cbxContabilizado.Value = enumBoolean.No
        cbxFechaDesde.TextBox.Clear()
        cbxFechaHasta.TextBox.Clear()
    End Sub

#End Region

End Class