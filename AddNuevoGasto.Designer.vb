<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddNuevoGasto
    Inherits Solmicro.Expertis.Engine.UI.FormBase

    'Form invalida a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddNuevoGasto))
        Dim CmbTipoAsiento_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.FraImportes = New Solmicro.Expertis.Engine.UI.Frame
        Me.lblIVA = New Solmicro.Expertis.Engine.UI.Label
        Me.ntbIVA = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblBaseImponible = New Solmicro.Expertis.Engine.UI.Label
        Me.ntbBaseImponible = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblTotal = New Solmicro.Expertis.Engine.UI.Label
        Me.ntbTotal = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.FraProyectos = New Solmicro.Expertis.Engine.UI.Frame
        Me.ulDescTrabajo = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.AdvTrabajo = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblTrabajo = New Solmicro.Expertis.Engine.UI.Label
        Me.ulDescObra = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.AdvObra = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblObra = New Solmicro.Expertis.Engine.UI.Label
        Me.FraDatosGasto = New Solmicro.Expertis.Engine.UI.Frame
        Me.AdvRefProveedor = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblAnalitica = New Solmicro.Expertis.Engine.UI.Label
        Me.BtnAnalitica = New Solmicro.Expertis.Engine.UI.Button
        Me.lblTipoIVA = New Solmicro.Expertis.Engine.UI.Label
        Me.ulDescTipoIVA = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.AdvTipoIVA = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblCCCompra = New Solmicro.Expertis.Engine.UI.Label
        Me.ulDescCCCompra = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.AdvCCCompra = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblRefProveedor = New Solmicro.Expertis.Engine.UI.Label
        Me.lblArticuloProveedor = New Solmicro.Expertis.Engine.UI.Label
        Me.AdvArticuloProveedor = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.txtDescArticuloProveedor = New Solmicro.Expertis.Engine.UI.TextBox
        Me.txtDescRefProveedor = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblArticulo = New Solmicro.Expertis.Engine.UI.Label
        Me.AdvArticulo = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.txtDescArticulo = New Solmicro.Expertis.Engine.UI.TextBox
        Me.UiCommandManager1 = New Janus.Windows.UI.CommandBars.UICommandManager(Me.components)
        Me.BottomRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
        Me.UiCommandBar1 = New Janus.Windows.UI.CommandBars.UICommandBar
        Me.cmdUpdate1 = New Janus.Windows.UI.CommandBars.UICommand("cmdUpdate")
        Me.cmdUpdate = New Janus.Windows.UI.CommandBars.UICommand("cmdUpdate")
        Me.LeftRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
        Me.RightRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
        Me.TopRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
        Me.FraProveedor = New Solmicro.Expertis.Engine.UI.Frame
        Me.AdvMoneda = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.ulDescMoneda = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.AdvProveedor = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.ulDescProveedor = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.AdvFormaPago = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.ulDescFormaPago = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.lblFormaPago = New Solmicro.Expertis.Engine.UI.Label
        Me.lblCondicionPago = New Solmicro.Expertis.Engine.UI.Label
        Me.ulDescCondicionPago = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.AdvCondicionPago = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblDiaPago = New Solmicro.Expertis.Engine.UI.Label
        Me.ulDescDiaPago = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.AdvDiaPago = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblMoneda = New Solmicro.Expertis.Engine.UI.Label
        Me.lblTipoAsiento = New Solmicro.Expertis.Engine.UI.Label
        Me.CmbTipoAsiento = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.lblRazonSocial = New Solmicro.Expertis.Engine.UI.Label
        Me.txtRazonSocial = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblCIF = New Solmicro.Expertis.Engine.UI.Label
        Me.txtCIF = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblFechaFactura = New Solmicro.Expertis.Engine.UI.Label
        Me.ClbFechaFactura = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.lblProveedor = New Solmicro.Expertis.Engine.UI.Label
        Me.lblSuFactura = New Solmicro.Expertis.Engine.UI.Label
        Me.txtSuFactura = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblSuFechaFactura = New Solmicro.Expertis.Engine.UI.Label
        Me.ClbSuFechaFactura = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.lblBancoPropio = New Solmicro.Expertis.Engine.UI.Label
        Me.ulDescBancoPropio = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.AdvBancoPropio = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.FraImportes.SuspendLayout()
        Me.FraProyectos.SuspendLayout()
        Me.FraDatosGasto.SuspendLayout()
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BottomRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UiCommandBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LeftRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RightRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TopRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TopRebar1.SuspendLayout()
        Me.FraProveedor.SuspendLayout()
        CType(Me.CmbTipoAsiento, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FraImportes
        '
        Me.FraImportes.Controls.Add(Me.lblIVA)
        Me.FraImportes.Controls.Add(Me.ntbIVA)
        Me.FraImportes.Controls.Add(Me.lblBaseImponible)
        Me.FraImportes.Controls.Add(Me.ntbBaseImponible)
        Me.FraImportes.Controls.Add(Me.lblTotal)
        Me.FraImportes.Controls.Add(Me.ntbTotal)
        Me.FraImportes.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.FraImportes.Location = New System.Drawing.Point(0, 539)
        Me.FraImportes.Name = "FraImportes"
        Me.FraImportes.Size = New System.Drawing.Size(707, 57)
        Me.FraImportes.TabIndex = 3
        Me.FraImportes.TabStop = False
        Me.FraImportes.Text = "Importes"
        '
        'lblIVA
        '
        Me.lblIVA.Location = New System.Drawing.Point(294, 28)
        Me.lblIVA.Name = "lblIVA"
        Me.lblIVA.Size = New System.Drawing.Size(38, 13)
        Me.lblIVA.TabIndex = 23
        Me.lblIVA.Tag = "IdRec=5045;"
        Me.lblIVA.Text = "I.V.A."
        '
        'ntbIVA
        '
        Me.ntbIVA.DisabledBackColor = System.Drawing.Color.White
        Me.ntbIVA.Enabled = False
        Me.ntbIVA.Location = New System.Drawing.Point(340, 24)
        Me.ntbIVA.MaxLength = 15
        Me.ntbIVA.Name = "ntbIVA"
        Me.ntbIVA.ReadOnly = True
        Me.ntbIVA.Size = New System.Drawing.Size(129, 21)
        Me.ntbIVA.TabIndex = 27
        Me.ntbIVA.TabStop = False
        '
        'lblBaseImponible
        '
        Me.lblBaseImponible.Location = New System.Drawing.Point(16, 28)
        Me.lblBaseImponible.Name = "lblBaseImponible"
        Me.lblBaseImponible.Size = New System.Drawing.Size(96, 13)
        Me.lblBaseImponible.TabIndex = 24
        Me.lblBaseImponible.Tag = "IdRec=5044;"
        Me.lblBaseImponible.Text = "Base Imponible"
        '
        'ntbBaseImponible
        '
        Me.ntbBaseImponible.DisabledBackColor = System.Drawing.Color.White
        Me.ntbBaseImponible.Location = New System.Drawing.Point(121, 24)
        Me.ntbBaseImponible.MaxLength = 15
        Me.ntbBaseImponible.Name = "ntbBaseImponible"
        Me.ntbBaseImponible.Size = New System.Drawing.Size(129, 21)
        Me.ntbBaseImponible.TabIndex = 26
        '
        'lblTotal
        '
        Me.lblTotal.Location = New System.Drawing.Point(521, 28)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(34, 13)
        Me.lblTotal.TabIndex = 25
        Me.lblTotal.Tag = "IdRec=4664;"
        Me.lblTotal.Text = "Total"
        '
        'ntbTotal
        '
        Me.ntbTotal.DisabledBackColor = System.Drawing.Color.White
        Me.ntbTotal.Enabled = False
        Me.ntbTotal.Location = New System.Drawing.Point(563, 24)
        Me.ntbTotal.MaxLength = 15
        Me.ntbTotal.Name = "ntbTotal"
        Me.ntbTotal.Size = New System.Drawing.Size(129, 21)
        Me.ntbTotal.TabIndex = 28
        '
        'FraProyectos
        '
        Me.FraProyectos.Controls.Add(Me.ulDescTrabajo)
        Me.FraProyectos.Controls.Add(Me.AdvTrabajo)
        Me.FraProyectos.Controls.Add(Me.lblTrabajo)
        Me.FraProyectos.Controls.Add(Me.ulDescObra)
        Me.FraProyectos.Controls.Add(Me.AdvObra)
        Me.FraProyectos.Controls.Add(Me.lblObra)
        Me.FraProyectos.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.FraProyectos.Location = New System.Drawing.Point(0, 454)
        Me.FraProyectos.Name = "FraProyectos"
        Me.FraProyectos.Size = New System.Drawing.Size(707, 85)
        Me.FraProyectos.TabIndex = 2
        Me.FraProyectos.TabStop = False
        Me.FraProyectos.Text = "Datos para Proyectos"
        '
        'ulDescTrabajo
        '
        Me.ulDescTrabajo.Location = New System.Drawing.Point(230, 51)
        Me.ulDescTrabajo.Name = "ulDescTrabajo"
        Me.ulDescTrabajo.Size = New System.Drawing.Size(463, 23)
        Me.ulDescTrabajo.TabIndex = 8
        '
        'AdvTrabajo
        '
        Me.AdvTrabajo.ASSelectedFields = New Solmicro.Expertis.Engine.UI.ASSelectedFields(New Solmicro.Expertis.Engine.UI.ASSelectedField() {New Solmicro.Expertis.Engine.UI.ASSelectedField("DescTrabajo", ulDescTrabajo)})
        Me.AdvTrabajo.DisabledBackColor = System.Drawing.Color.White
        Me.AdvTrabajo.DisplayField = "CodTrabajo"
        Me.AdvTrabajo.EntityName = "ObraTrabajo"
        Me.AdvTrabajo.Location = New System.Drawing.Point(87, 51)
        Me.AdvTrabajo.Name = "AdvTrabajo"
        Me.AdvTrabajo.SecondaryDataFields = "IDTrabajo"
        Me.AdvTrabajo.Size = New System.Drawing.Size(136, 23)
        Me.AdvTrabajo.TabIndex = 7
        '
        'lblTrabajo
        '
        Me.lblTrabajo.Location = New System.Drawing.Point(24, 56)
        Me.lblTrabajo.Name = "lblTrabajo"
        Me.lblTrabajo.Size = New System.Drawing.Size(50, 13)
        Me.lblTrabajo.TabIndex = 6
        Me.lblTrabajo.Text = "Trabajo"
        Me.lblTrabajo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ulDescObra
        '
        Me.ulDescObra.Location = New System.Drawing.Point(230, 24)
        Me.ulDescObra.Name = "ulDescObra"
        Me.ulDescObra.Size = New System.Drawing.Size(463, 23)
        Me.ulDescObra.TabIndex = 5
        '
        'AdvObra
        '
        Me.AdvObra.ASSelectedFields = New Solmicro.Expertis.Engine.UI.ASSelectedFields(New Solmicro.Expertis.Engine.UI.ASSelectedField() {New Solmicro.Expertis.Engine.UI.ASSelectedField("DescObra", ulDescObra)})
        Me.AdvObra.DisabledBackColor = System.Drawing.Color.White
        Me.AdvObra.DisplayField = "NObra"
        Me.AdvObra.EntityName = "ObraCabecera"
        Me.AdvObra.Location = New System.Drawing.Point(87, 24)
        Me.AdvObra.Name = "AdvObra"
        Me.AdvObra.SecondaryDataFields = "IDObra"
        Me.AdvObra.Size = New System.Drawing.Size(136, 23)
        Me.AdvObra.TabIndex = 4
        '
        'lblObra
        '
        Me.lblObra.Location = New System.Drawing.Point(23, 29)
        Me.lblObra.Name = "lblObra"
        Me.lblObra.Size = New System.Drawing.Size(35, 13)
        Me.lblObra.TabIndex = 3
        Me.lblObra.Text = "Obra"
        Me.lblObra.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FraDatosGasto
        '
        Me.FraDatosGasto.Controls.Add(Me.AdvRefProveedor)
        Me.FraDatosGasto.Controls.Add(Me.lblAnalitica)
        Me.FraDatosGasto.Controls.Add(Me.BtnAnalitica)
        Me.FraDatosGasto.Controls.Add(Me.lblTipoIVA)
        Me.FraDatosGasto.Controls.Add(Me.ulDescTipoIVA)
        Me.FraDatosGasto.Controls.Add(Me.AdvTipoIVA)
        Me.FraDatosGasto.Controls.Add(Me.lblCCCompra)
        Me.FraDatosGasto.Controls.Add(Me.ulDescCCCompra)
        Me.FraDatosGasto.Controls.Add(Me.AdvCCCompra)
        Me.FraDatosGasto.Controls.Add(Me.lblRefProveedor)
        Me.FraDatosGasto.Controls.Add(Me.lblArticuloProveedor)
        Me.FraDatosGasto.Controls.Add(Me.AdvArticuloProveedor)
        Me.FraDatosGasto.Controls.Add(Me.txtDescArticuloProveedor)
        Me.FraDatosGasto.Controls.Add(Me.txtDescRefProveedor)
        Me.FraDatosGasto.Controls.Add(Me.lblArticulo)
        Me.FraDatosGasto.Controls.Add(Me.AdvArticulo)
        Me.FraDatosGasto.Controls.Add(Me.txtDescArticulo)
        Me.FraDatosGasto.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.FraDatosGasto.Location = New System.Drawing.Point(0, 261)
        Me.FraDatosGasto.Name = "FraDatosGasto"
        Me.FraDatosGasto.Size = New System.Drawing.Size(707, 193)
        Me.FraDatosGasto.TabIndex = 1
        Me.FraDatosGasto.TabStop = False
        Me.FraDatosGasto.Text = "Datos del Gasto"
        '
        'AdvRefProveedor
        '
        Me.AdvRefProveedor.DisabledBackColor = System.Drawing.Color.White
        Me.AdvRefProveedor.EntityName = "ArticuloProveedor"
        Me.AdvRefProveedor.Location = New System.Drawing.Point(159, 78)
        Me.AdvRefProveedor.Name = "AdvRefProveedor"
        Me.AdvRefProveedor.SecondaryDataFields = "RefProveedor"
        Me.AdvRefProveedor.Size = New System.Drawing.Size(136, 23)
        Me.AdvRefProveedor.TabIndex = 4
        Me.AdvRefProveedor.ViewName = "advArticuloProveedor"
        '
        'lblAnalitica
        '
        Me.lblAnalitica.Location = New System.Drawing.Point(23, 166)
        Me.lblAnalitica.Name = "lblAnalitica"
        Me.lblAnalitica.Size = New System.Drawing.Size(55, 13)
        Me.lblAnalitica.TabIndex = 52
        Me.lblAnalitica.Text = "Analítica"
        Me.lblAnalitica.Visible = False
        '
        'BtnAnalitica
        '
        Me.BtnAnalitica.Icon = CType(resources.GetObject("BtnAnalitica.Icon"), System.Drawing.Icon)
        Me.BtnAnalitica.Location = New System.Drawing.Point(159, 160)
        Me.BtnAnalitica.Name = "BtnAnalitica"
        Me.BtnAnalitica.Size = New System.Drawing.Size(27, 23)
        Me.BtnAnalitica.TabIndex = 8
        Me.BtnAnalitica.Visible = False
        '
        'lblTipoIVA
        '
        Me.lblTipoIVA.Location = New System.Drawing.Point(23, 138)
        Me.lblTipoIVA.Name = "lblTipoIVA"
        Me.lblTipoIVA.Size = New System.Drawing.Size(66, 13)
        Me.lblTipoIVA.TabIndex = 48
        Me.lblTipoIVA.Tag = "IdRec=4586;"
        Me.lblTipoIVA.Text = "Tipo I.V.A."
        '
        'ulDescTipoIVA
        '
        Me.ulDescTipoIVA.Location = New System.Drawing.Point(299, 133)
        Me.ulDescTipoIVA.Name = "ulDescTipoIVA"
        Me.ulDescTipoIVA.Size = New System.Drawing.Size(394, 23)
        Me.ulDescTipoIVA.TabIndex = 49
        '
        'AdvTipoIVA
        '
        Me.AdvTipoIVA.ASSelectedFields = New Solmicro.Expertis.Engine.UI.ASSelectedFields(New Solmicro.Expertis.Engine.UI.ASSelectedField() {New Solmicro.Expertis.Engine.UI.ASSelectedField("DescTipoIVA", ulDescTipoIVA)})
        Me.AdvTipoIVA.DisabledBackColor = System.Drawing.Color.White
        Me.AdvTipoIVA.DisplayField = "IDTipoIVA"
        Me.AdvTipoIVA.EntityName = "TipoIVA"
        Me.AdvTipoIVA.Location = New System.Drawing.Point(159, 133)
        Me.AdvTipoIVA.MaxLength = 10
        Me.AdvTipoIVA.Name = "AdvTipoIVA"
        Me.AdvTipoIVA.SecondaryDataFields = "IDTipoIVA"
        Me.AdvTipoIVA.Size = New System.Drawing.Size(136, 23)
        Me.AdvTipoIVA.TabIndex = 7
        '
        'lblCCCompra
        '
        Me.lblCCCompra.Location = New System.Drawing.Point(23, 110)
        Me.lblCCCompra.Name = "lblCCCompra"
        Me.lblCCCompra.Size = New System.Drawing.Size(83, 13)
        Me.lblCCCompra.TabIndex = 50
        Me.lblCCCompra.Tag = "IdRec=4588;"
        Me.lblCCCompra.Text = "C.C. Compra"
        '
        'ulDescCCCompra
        '
        Me.TryDataBinding(ulDescCCCompra, New System.Windows.Forms.Binding("Text", Me.AdvCCCompra, "DescCContable", True))
        Me.ulDescCCCompra.Location = New System.Drawing.Point(299, 105)
        Me.ulDescCCCompra.Name = "ulDescCCCompra"
        Me.ulDescCCCompra.Size = New System.Drawing.Size(394, 23)
        Me.ulDescCCCompra.TabIndex = 51
        '
        'AdvCCCompra
        '
        Me.AdvCCCompra.DisabledBackColor = System.Drawing.Color.White
        Me.AdvCCCompra.DisplayField = "IDCContable"
        Me.AdvCCCompra.EntityName = "PlanContable"
        Me.AdvCCCompra.Location = New System.Drawing.Point(159, 105)
        Me.AdvCCCompra.MaxLength = 10
        Me.AdvCCCompra.Name = "AdvCCCompra"
        Me.AdvCCCompra.SecondaryDataFields = "IDCContable"
        Me.AdvCCCompra.Size = New System.Drawing.Size(136, 23)
        Me.AdvCCCompra.TabIndex = 6
        '
        'lblRefProveedor
        '
        Me.lblRefProveedor.Location = New System.Drawing.Point(23, 83)
        Me.lblRefProveedor.Name = "lblRefProveedor"
        Me.lblRefProveedor.Size = New System.Drawing.Size(131, 13)
        Me.lblRefProveedor.TabIndex = 44
        Me.lblRefProveedor.Text = "Referencia Proveedor"
        Me.lblRefProveedor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblArticuloProveedor
        '
        Me.lblArticuloProveedor.Location = New System.Drawing.Point(23, 56)
        Me.lblArticuloProveedor.Name = "lblArticuloProveedor"
        Me.lblArticuloProveedor.Size = New System.Drawing.Size(113, 13)
        Me.lblArticuloProveedor.TabIndex = 43
        Me.lblArticuloProveedor.Text = "Artículo Proveedor"
        '
        'AdvArticuloProveedor
        '
        Me.AdvArticuloProveedor.DisabledBackColor = System.Drawing.Color.White
        Me.AdvArticuloProveedor.DisplayField = "IDArticulo"
        Me.AdvArticuloProveedor.EntityName = "ArticuloProveedor"
        Me.AdvArticuloProveedor.Location = New System.Drawing.Point(159, 51)
        Me.AdvArticuloProveedor.MaxLength = 25
        Me.AdvArticuloProveedor.Name = "AdvArticuloProveedor"
        Me.AdvArticuloProveedor.SecondaryDataFields = "IDArticulo"
        Me.AdvArticuloProveedor.Size = New System.Drawing.Size(136, 23)
        Me.AdvArticuloProveedor.TabIndex = 2
        Me.AdvArticuloProveedor.ViewName = "advArticuloProveedor"
        '
        'txtDescArticuloProveedor
        '
        Me.txtDescArticuloProveedor.DisabledBackColor = System.Drawing.Color.White
        Me.txtDescArticuloProveedor.Location = New System.Drawing.Point(299, 52)
        Me.txtDescArticuloProveedor.MaxLength = 300
        Me.txtDescArticuloProveedor.Name = "txtDescArticuloProveedor"
        Me.txtDescArticuloProveedor.Size = New System.Drawing.Size(394, 21)
        Me.txtDescArticuloProveedor.TabIndex = 3
        '
        'txtDescRefProveedor
        '
        Me.txtDescRefProveedor.DisabledBackColor = System.Drawing.Color.White
        Me.txtDescRefProveedor.Location = New System.Drawing.Point(299, 79)
        Me.txtDescRefProveedor.MaxLength = 300
        Me.txtDescRefProveedor.Name = "txtDescRefProveedor"
        Me.txtDescRefProveedor.Size = New System.Drawing.Size(394, 21)
        Me.txtDescRefProveedor.TabIndex = 5
        '
        'lblArticulo
        '
        Me.lblArticulo.Location = New System.Drawing.Point(23, 29)
        Me.lblArticulo.Name = "lblArticulo"
        Me.lblArticulo.Size = New System.Drawing.Size(50, 13)
        Me.lblArticulo.TabIndex = 37
        Me.lblArticulo.Text = "Artículo"
        Me.lblArticulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'AdvArticulo
        '
        Me.AdvArticulo.DisabledBackColor = System.Drawing.Color.White
        Me.AdvArticulo.DisplayField = "IDArticulo"
        Me.AdvArticulo.EntityName = "Articulo"
        Me.AdvArticulo.Location = New System.Drawing.Point(159, 24)
        Me.AdvArticulo.MaxLength = 25
        Me.AdvArticulo.Name = "AdvArticulo"
        Me.AdvArticulo.SecondaryDataFields = "IDArticulo"
        Me.AdvArticulo.Size = New System.Drawing.Size(136, 23)
        Me.AdvArticulo.TabIndex = 0
        '
        'txtDescArticulo
        '
        Me.txtDescArticulo.DisabledBackColor = System.Drawing.Color.White
        Me.txtDescArticulo.Location = New System.Drawing.Point(299, 25)
        Me.txtDescArticulo.MaxLength = 300
        Me.txtDescArticulo.Name = "txtDescArticulo"
        Me.txtDescArticulo.Size = New System.Drawing.Size(394, 21)
        Me.txtDescArticulo.TabIndex = 1
        '
        'UiCommandManager1
        '
        Me.UiCommandManager1.BottomRebar = Me.BottomRebar1
        Me.UiCommandManager1.CommandBars.AddRange(New Janus.Windows.UI.CommandBars.UICommandBar() {Me.UiCommandBar1})
        Me.UiCommandManager1.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.cmdUpdate})
        Me.UiCommandManager1.ContainerControl = Me
        Me.UiCommandManager1.Id = New System.Guid("7cf6def5-4b61-4f0b-844f-d7a59d0522b0")
        Me.UiCommandManager1.LeftRebar = Me.LeftRebar1
        Me.UiCommandManager1.RightRebar = Me.RightRebar1
        Me.UiCommandManager1.TopRebar = Me.TopRebar1
        '
        'BottomRebar1
        '
        Me.BottomRebar1.CommandManager = Me.UiCommandManager1
        Me.BottomRebar1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BottomRebar1.Location = New System.Drawing.Point(0, 596)
        Me.BottomRebar1.Name = "BottomRebar1"
        Me.BottomRebar1.Size = New System.Drawing.Size(707, 0)
        '
        'UiCommandBar1
        '
        Me.UiCommandBar1.CommandManager = Me.UiCommandManager1
        Me.UiCommandBar1.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.cmdUpdate1})
        Me.UiCommandBar1.Key = "CommandBar1"
        Me.UiCommandBar1.Location = New System.Drawing.Point(0, 0)
        Me.UiCommandBar1.MergeRowOrder = 1
        Me.UiCommandBar1.Name = "UiCommandBar1"
        Me.UiCommandBar1.RowIndex = 0
        Me.UiCommandBar1.Size = New System.Drawing.Size(46, 28)
        Me.UiCommandBar1.Text = "CommandBar1"
        '
        'cmdUpdate1
        '
        Me.cmdUpdate1.Key = "cmdUpdate"
        Me.cmdUpdate1.Name = "cmdUpdate1"
        '
        'cmdUpdate
        '
        Me.cmdUpdate.Image = CType(resources.GetObject("cmdUpdate.Image"), System.Drawing.Image)
        Me.cmdUpdate.Key = "cmdUpdate"
        Me.cmdUpdate.Name = "cmdUpdate"
        Me.cmdUpdate.ToolTipText = "Aceptar los cambios (F9)"
        '
        'LeftRebar1
        '
        Me.LeftRebar1.CommandManager = Me.UiCommandManager1
        Me.LeftRebar1.Dock = System.Windows.Forms.DockStyle.Left
        Me.LeftRebar1.Location = New System.Drawing.Point(0, 28)
        Me.LeftRebar1.Name = "LeftRebar1"
        Me.LeftRebar1.Size = New System.Drawing.Size(0, 568)
        '
        'RightRebar1
        '
        Me.RightRebar1.CommandManager = Me.UiCommandManager1
        Me.RightRebar1.Dock = System.Windows.Forms.DockStyle.Right
        Me.RightRebar1.Location = New System.Drawing.Point(707, 28)
        Me.RightRebar1.Name = "RightRebar1"
        Me.RightRebar1.Size = New System.Drawing.Size(0, 568)
        '
        'TopRebar1
        '
        Me.TopRebar1.CommandBars.AddRange(New Janus.Windows.UI.CommandBars.UICommandBar() {Me.UiCommandBar1})
        Me.TopRebar1.CommandManager = Me.UiCommandManager1
        Me.TopRebar1.Controls.Add(Me.UiCommandBar1)
        Me.TopRebar1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TopRebar1.Location = New System.Drawing.Point(0, 0)
        Me.TopRebar1.Name = "TopRebar1"
        Me.TopRebar1.Size = New System.Drawing.Size(707, 28)
        '
        'FraProveedor
        '
        Me.FraProveedor.Controls.Add(Me.AdvMoneda)
        Me.FraProveedor.Controls.Add(Me.AdvProveedor)
        Me.FraProveedor.Controls.Add(Me.AdvFormaPago)
        Me.FraProveedor.Controls.Add(Me.lblFormaPago)
        Me.FraProveedor.Controls.Add(Me.ulDescFormaPago)
        Me.FraProveedor.Controls.Add(Me.lblCondicionPago)
        Me.FraProveedor.Controls.Add(Me.ulDescCondicionPago)
        Me.FraProveedor.Controls.Add(Me.AdvCondicionPago)
        Me.FraProveedor.Controls.Add(Me.lblDiaPago)
        Me.FraProveedor.Controls.Add(Me.ulDescDiaPago)
        Me.FraProveedor.Controls.Add(Me.AdvDiaPago)
        Me.FraProveedor.Controls.Add(Me.lblMoneda)
        Me.FraProveedor.Controls.Add(Me.ulDescMoneda)
        Me.FraProveedor.Controls.Add(Me.lblTipoAsiento)
        Me.FraProveedor.Controls.Add(Me.CmbTipoAsiento)
        Me.FraProveedor.Controls.Add(Me.lblRazonSocial)
        Me.FraProveedor.Controls.Add(Me.txtRazonSocial)
        Me.FraProveedor.Controls.Add(Me.lblCIF)
        Me.FraProveedor.Controls.Add(Me.txtCIF)
        Me.FraProveedor.Controls.Add(Me.lblFechaFactura)
        Me.FraProveedor.Controls.Add(Me.ClbFechaFactura)
        Me.FraProveedor.Controls.Add(Me.lblProveedor)
        Me.FraProveedor.Controls.Add(Me.ulDescProveedor)
        Me.FraProveedor.Controls.Add(Me.lblSuFactura)
        Me.FraProveedor.Controls.Add(Me.txtSuFactura)
        Me.FraProveedor.Controls.Add(Me.lblSuFechaFactura)
        Me.FraProveedor.Controls.Add(Me.ClbSuFechaFactura)
        Me.FraProveedor.Controls.Add(Me.lblBancoPropio)
        Me.FraProveedor.Controls.Add(Me.ulDescBancoPropio)
        Me.FraProveedor.Controls.Add(Me.AdvBancoPropio)
        Me.FraProveedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FraProveedor.Location = New System.Drawing.Point(0, 28)
        Me.FraProveedor.Name = "FraProveedor"
        Me.FraProveedor.Size = New System.Drawing.Size(707, 233)
        Me.FraProveedor.TabIndex = 9
        Me.FraProveedor.TabStop = False
        Me.FraProveedor.Text = "Datos del Proveedor"
        '
        'AdvMoneda
        '
        Me.AdvMoneda.ASSelectedFields = New Solmicro.Expertis.Engine.UI.ASSelectedFields(New Solmicro.Expertis.Engine.UI.ASSelectedField() {New Solmicro.Expertis.Engine.UI.ASSelectedField("DescMoneda", ulDescMoneda)})
        Me.AdvMoneda.DisabledBackColor = System.Drawing.Color.White
        Me.AdvMoneda.DisplayField = "IDMoneda"
        Me.AdvMoneda.EntityName = "Moneda"
        Me.AdvMoneda.Location = New System.Drawing.Point(431, 70)
        Me.AdvMoneda.MaxLength = 10
        Me.AdvMoneda.Name = "AdvMoneda"
        Me.AdvMoneda.SecondaryDataFields = "IDMoneda"
        Me.AdvMoneda.Size = New System.Drawing.Size(89, 23)
        Me.AdvMoneda.TabIndex = 6
        '
        'ulDescMoneda
        '
        Me.ulDescMoneda.Location = New System.Drawing.Point(524, 70)
        Me.ulDescMoneda.Name = "ulDescMoneda"
        Me.ulDescMoneda.Size = New System.Drawing.Size(169, 23)
        Me.ulDescMoneda.TabIndex = 43
        '
        'AdvProveedor
        '
        Me.AdvProveedor.ASSelectedFields = New Solmicro.Expertis.Engine.UI.ASSelectedFields(New Solmicro.Expertis.Engine.UI.ASSelectedField() {New Solmicro.Expertis.Engine.UI.ASSelectedField("DescProveedor", ulDescProveedor)})
        Me.AdvProveedor.DisabledBackColor = System.Drawing.Color.White
        Me.AdvProveedor.DisplayField = "IDProveedor"
        Me.AdvProveedor.EntityName = "Proveedor"
        Me.AdvProveedor.Location = New System.Drawing.Point(246, 18)
        Me.AdvProveedor.MaxLength = 25
        Me.AdvProveedor.Name = "AdvProveedor"
        Me.AdvProveedor.SecondaryDataFields = "IDProveedor"
        Me.AdvProveedor.Size = New System.Drawing.Size(120, 23)
        Me.AdvProveedor.TabIndex = 3
        '
        'ulDescProveedor
        '
        Me.ulDescProveedor.Location = New System.Drawing.Point(372, 18)
        Me.ulDescProveedor.Name = "ulDescProveedor"
        Me.ulDescProveedor.Size = New System.Drawing.Size(322, 23)
        Me.ulDescProveedor.TabIndex = 49
        '
        'AdvFormaPago
        '
        Me.AdvFormaPago.ASSelectedFields = New Solmicro.Expertis.Engine.UI.ASSelectedFields(New Solmicro.Expertis.Engine.UI.ASSelectedField() {New Solmicro.Expertis.Engine.UI.ASSelectedField("DescFormaPago", ulDescFormaPago)})
        Me.AdvFormaPago.DisabledBackColor = System.Drawing.Color.White
        Me.AdvFormaPago.DisplayField = "IDFormaPago"
        Me.AdvFormaPago.EntityName = "FormaPago"
        Me.AdvFormaPago.Location = New System.Drawing.Point(246, 122)
        Me.AdvFormaPago.Name = "AdvFormaPago"
        Me.AdvFormaPago.SecondaryDataFields = "IDFormaPago"
        Me.AdvFormaPago.Size = New System.Drawing.Size(120, 23)
        Me.AdvFormaPago.TabIndex = 8
        '
        'ulDescFormaPago
        '
        Me.ulDescFormaPago.Location = New System.Drawing.Point(372, 122)
        Me.ulDescFormaPago.Name = "ulDescFormaPago"
        Me.ulDescFormaPago.Size = New System.Drawing.Size(322, 23)
        Me.ulDescFormaPago.TabIndex = 55
        '
        'lblFormaPago
        '
        Me.lblFormaPago.Location = New System.Drawing.Point(142, 127)
        Me.lblFormaPago.Name = "lblFormaPago"
        Me.lblFormaPago.Size = New System.Drawing.Size(75, 13)
        Me.lblFormaPago.TabIndex = 54
        Me.lblFormaPago.Text = "Forma Pago"
        '
        'lblCondicionPago
        '
        Me.lblCondicionPago.Location = New System.Drawing.Point(142, 154)
        Me.lblCondicionPago.Name = "lblCondicionPago"
        Me.lblCondicionPago.Size = New System.Drawing.Size(95, 13)
        Me.lblCondicionPago.TabIndex = 28
        Me.lblCondicionPago.Text = "Condición Pago"
        '
        'ulDescCondicionPago
        '
        Me.ulDescCondicionPago.Location = New System.Drawing.Point(372, 149)
        Me.ulDescCondicionPago.Name = "ulDescCondicionPago"
        Me.ulDescCondicionPago.Size = New System.Drawing.Size(322, 23)
        Me.ulDescCondicionPago.TabIndex = 29
        '
        'AdvCondicionPago
        '
        Me.AdvCondicionPago.ASSelectedFields = New Solmicro.Expertis.Engine.UI.ASSelectedFields(New Solmicro.Expertis.Engine.UI.ASSelectedField() {New Solmicro.Expertis.Engine.UI.ASSelectedField("DescCondicionPago", ulDescCondicionPago)})
        Me.AdvCondicionPago.DisabledBackColor = System.Drawing.Color.White
        Me.AdvCondicionPago.DisplayField = "IDCondicionPago"
        Me.AdvCondicionPago.EntityName = "CondicionPago"
        Me.AdvCondicionPago.Location = New System.Drawing.Point(246, 149)
        Me.AdvCondicionPago.MaxLength = 10
        Me.AdvCondicionPago.Name = "AdvCondicionPago"
        Me.AdvCondicionPago.SecondaryDataFields = "IDCondicionPago"
        Me.AdvCondicionPago.Size = New System.Drawing.Size(120, 23)
        Me.AdvCondicionPago.TabIndex = 9
        '
        'lblDiaPago
        '
        Me.lblDiaPago.Location = New System.Drawing.Point(142, 181)
        Me.lblDiaPago.Name = "lblDiaPago"
        Me.lblDiaPago.Size = New System.Drawing.Size(58, 13)
        Me.lblDiaPago.TabIndex = 38
        Me.lblDiaPago.Text = "Día Pago"
        '
        'ulDescDiaPago
        '
        Me.ulDescDiaPago.Location = New System.Drawing.Point(372, 176)
        Me.ulDescDiaPago.Name = "ulDescDiaPago"
        Me.ulDescDiaPago.Size = New System.Drawing.Size(322, 23)
        Me.ulDescDiaPago.TabIndex = 40
        '
        'AdvDiaPago
        '
        Me.AdvDiaPago.ASSelectedFields = New Solmicro.Expertis.Engine.UI.ASSelectedFields(New Solmicro.Expertis.Engine.UI.ASSelectedField() {New Solmicro.Expertis.Engine.UI.ASSelectedField("DescDiaPago", ulDescDiaPago)})
        Me.AdvDiaPago.DisabledBackColor = System.Drawing.Color.White
        Me.AdvDiaPago.DisplayField = "IDDiaPago"
        Me.AdvDiaPago.EntityName = "DiaPago"
        Me.AdvDiaPago.Location = New System.Drawing.Point(246, 176)
        Me.AdvDiaPago.MaxLength = 10
        Me.AdvDiaPago.Name = "AdvDiaPago"
        Me.AdvDiaPago.SecondaryDataFields = "IDDiaPago"
        Me.AdvDiaPago.Size = New System.Drawing.Size(120, 23)
        Me.AdvDiaPago.TabIndex = 10
        '
        'lblMoneda
        '
        Me.lblMoneda.Location = New System.Drawing.Point(374, 75)
        Me.lblMoneda.Name = "lblMoneda"
        Me.lblMoneda.Size = New System.Drawing.Size(51, 13)
        Me.lblMoneda.TabIndex = 42
        Me.lblMoneda.Tag = "IdRec=4398;"
        Me.lblMoneda.Text = "Moneda"
        '
        'lblTipoAsiento
        '
        Me.lblTipoAsiento.Location = New System.Drawing.Point(142, 207)
        Me.lblTipoAsiento.Name = "lblTipoAsiento"
        Me.lblTipoAsiento.Size = New System.Drawing.Size(77, 13)
        Me.lblTipoAsiento.TabIndex = 44
        Me.lblTipoAsiento.Tag = "IdRec=5376;"
        Me.lblTipoAsiento.Text = "Tipo Asiento"
        '
        'CmbTipoAsiento
        '
        Me.CmbTipoAsiento.ComboStyle = Janus.Windows.GridEX.ComboStyle.DropDownList
        CmbTipoAsiento_DesignTimeLayout.LayoutString = resources.GetString("CmbTipoAsiento_DesignTimeLayout.LayoutString")
        Me.CmbTipoAsiento.DesignTimeLayout = CmbTipoAsiento_DesignTimeLayout
        Me.CmbTipoAsiento.DisabledBackColor = System.Drawing.Color.White
        Me.CmbTipoAsiento.DisplayMember = "Text"
        Me.CmbTipoAsiento.Location = New System.Drawing.Point(246, 203)
        Me.CmbTipoAsiento.Name = "CmbTipoAsiento"
        Me.CmbTipoAsiento.SelectedIndex = -1
        Me.CmbTipoAsiento.SelectedItem = Nothing
        Me.CmbTipoAsiento.Size = New System.Drawing.Size(446, 21)
        Me.CmbTipoAsiento.TabIndex = 11
        Me.CmbTipoAsiento.ValueMember = "Value"
        '
        'lblRazonSocial
        '
        Me.lblRazonSocial.Location = New System.Drawing.Point(142, 49)
        Me.lblRazonSocial.Name = "lblRazonSocial"
        Me.lblRazonSocial.Size = New System.Drawing.Size(80, 13)
        Me.lblRazonSocial.TabIndex = 45
        Me.lblRazonSocial.Tag = "IdRec=4426;"
        Me.lblRazonSocial.Text = "Razón Social"
        '
        'txtRazonSocial
        '
        Me.txtRazonSocial.DisabledBackColor = System.Drawing.Color.White
        Me.txtRazonSocial.Location = New System.Drawing.Point(246, 45)
        Me.txtRazonSocial.MaxLength = 300
        Me.txtRazonSocial.Name = "txtRazonSocial"
        Me.txtRazonSocial.Size = New System.Drawing.Size(448, 21)
        Me.txtRazonSocial.TabIndex = 4
        '
        'lblCIF
        '
        Me.lblCIF.Location = New System.Drawing.Point(142, 74)
        Me.lblCIF.Name = "lblCIF"
        Me.lblCIF.Size = New System.Drawing.Size(41, 13)
        Me.lblCIF.TabIndex = 46
        Me.lblCIF.Tag = "IdRec=4425;"
        Me.lblCIF.Text = "C.I.F. "
        '
        'txtCIF
        '
        Me.txtCIF.DisabledBackColor = System.Drawing.Color.White
        Me.txtCIF.Location = New System.Drawing.Point(246, 70)
        Me.txtCIF.MaxLength = 50
        Me.txtCIF.Name = "txtCIF"
        Me.txtCIF.Size = New System.Drawing.Size(120, 21)
        Me.txtCIF.TabIndex = 5
        '
        'lblFechaFactura
        '
        Me.lblFechaFactura.Location = New System.Drawing.Point(16, 41)
        Me.lblFechaFactura.Name = "lblFechaFactura"
        Me.lblFechaFactura.Size = New System.Drawing.Size(85, 13)
        Me.lblFechaFactura.TabIndex = 47
        Me.lblFechaFactura.Tag = "IdRec=5043;"
        Me.lblFechaFactura.Text = "Fecha Factura"
        '
        'ClbFechaFactura
        '
        Me.ClbFechaFactura.DisabledBackColor = System.Drawing.Color.White
        Me.ClbFechaFactura.Location = New System.Drawing.Point(16, 61)
        Me.ClbFechaFactura.Name = "ClbFechaFactura"
        Me.ClbFechaFactura.Size = New System.Drawing.Size(102, 21)
        Me.ClbFechaFactura.TabIndex = 0
        '
        'lblProveedor
        '
        Me.lblProveedor.Location = New System.Drawing.Point(142, 23)
        Me.lblProveedor.Name = "lblProveedor"
        Me.lblProveedor.Size = New System.Drawing.Size(66, 13)
        Me.lblProveedor.TabIndex = 48
        Me.lblProveedor.Tag = "IdRec=4352;"
        Me.lblProveedor.Text = "Proveedor"
        '
        'lblSuFactura
        '
        Me.lblSuFactura.Location = New System.Drawing.Point(16, 91)
        Me.lblSuFactura.Name = "lblSuFactura"
        Me.lblSuFactura.Size = New System.Drawing.Size(67, 13)
        Me.lblSuFactura.TabIndex = 50
        Me.lblSuFactura.Tag = "IdRec=5072;"
        Me.lblSuFactura.Text = "Su Factura"
        '
        'txtSuFactura
        '
        Me.txtSuFactura.DisabledBackColor = System.Drawing.Color.White
        Me.txtSuFactura.Location = New System.Drawing.Point(16, 111)
        Me.txtSuFactura.MaxLength = 50
        Me.txtSuFactura.Name = "txtSuFactura"
        Me.txtSuFactura.Size = New System.Drawing.Size(102, 21)
        Me.txtSuFactura.TabIndex = 1
        '
        'lblSuFechaFactura
        '
        Me.lblSuFechaFactura.Location = New System.Drawing.Point(16, 141)
        Me.lblSuFechaFactura.Name = "lblSuFechaFactura"
        Me.lblSuFechaFactura.Size = New System.Drawing.Size(104, 13)
        Me.lblSuFechaFactura.TabIndex = 51
        Me.lblSuFechaFactura.Tag = "IdRec=5073;"
        Me.lblSuFechaFactura.Text = "Su Fecha Factura"
        '
        'ClbSuFechaFactura
        '
        Me.ClbSuFechaFactura.DisabledBackColor = System.Drawing.Color.White
        Me.ClbSuFechaFactura.Location = New System.Drawing.Point(16, 161)
        Me.ClbSuFechaFactura.Name = "ClbSuFechaFactura"
        Me.ClbSuFechaFactura.Size = New System.Drawing.Size(102, 21)
        Me.ClbSuFechaFactura.TabIndex = 2
        '
        'lblBancoPropio
        '
        Me.lblBancoPropio.Location = New System.Drawing.Point(142, 100)
        Me.lblBancoPropio.Name = "lblBancoPropio"
        Me.lblBancoPropio.Size = New System.Drawing.Size(82, 13)
        Me.lblBancoPropio.TabIndex = 52
        Me.lblBancoPropio.Tag = "IdRec=4613;"
        Me.lblBancoPropio.Text = "Banco Propio"
        '
        'ulDescBancoPropio
        '
        Me.ulDescBancoPropio.Location = New System.Drawing.Point(372, 95)
        Me.ulDescBancoPropio.Name = "ulDescBancoPropio"
        Me.ulDescBancoPropio.Size = New System.Drawing.Size(322, 23)
        Me.ulDescBancoPropio.TabIndex = 53
        '
        'AdvBancoPropio
        '
        Me.AdvBancoPropio.ASSelectedFields = New Solmicro.Expertis.Engine.UI.ASSelectedFields(New Solmicro.Expertis.Engine.UI.ASSelectedField() {New Solmicro.Expertis.Engine.UI.ASSelectedField("DescBancoPropio", ulDescBancoPropio)})
        Me.AdvBancoPropio.DisabledBackColor = System.Drawing.Color.White
        Me.AdvBancoPropio.DisplayField = "IDBancoPropio"
        Me.AdvBancoPropio.EntityName = "BancoPropio"
        Me.AdvBancoPropio.Location = New System.Drawing.Point(246, 95)
        Me.AdvBancoPropio.MaxLength = 10
        Me.AdvBancoPropio.Name = "AdvBancoPropio"
        Me.AdvBancoPropio.SecondaryDataFields = "IDBancoPropio"
        Me.AdvBancoPropio.Size = New System.Drawing.Size(120, 23)
        Me.AdvBancoPropio.TabIndex = 7
        '
        'AddNuevoGasto
        '
        Me.ClientSize = New System.Drawing.Size(707, 596)
        Me.Controls.Add(Me.FraProveedor)
        Me.Controls.Add(Me.FraDatosGasto)
        Me.Controls.Add(Me.FraProyectos)
        Me.Controls.Add(Me.FraImportes)
        Me.Controls.Add(Me.TopRebar1)
        Me.EntityName = "FacturaCompraCabecera"
        Me.FindTextField = "IDFactura"
        Me.Name = "AddNuevoGasto"
        Me.NavigationFields = "IDFactura"
        Me.Text = "Nuevo Gasto"
        Me.ViewName = "frmMntoFacturaCompra"
        Me.FraImportes.ResumeLayout(False)
        Me.FraImportes.PerformLayout()
        Me.FraProyectos.ResumeLayout(False)
        Me.FraProyectos.PerformLayout()
        Me.FraDatosGasto.ResumeLayout(False)
        Me.FraDatosGasto.PerformLayout()
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BottomRebar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UiCommandBar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LeftRebar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RightRebar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TopRebar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TopRebar1.ResumeLayout(False)
        Me.FraProveedor.ResumeLayout(False)
        Me.FraProveedor.PerformLayout()
        CType(Me.CmbTipoAsiento, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents FraImportes As Solmicro.Expertis.Engine.UI.Frame
    Friend WithEvents lblIVA As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents ntbIVA As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents lblBaseImponible As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents ntbBaseImponible As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents lblTotal As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents ntbTotal As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents FraProyectos As Solmicro.Expertis.Engine.UI.Frame
    Friend WithEvents ulDescTrabajo As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Friend WithEvents AdvTrabajo As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lblTrabajo As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents ulDescObra As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Friend WithEvents AdvObra As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lblObra As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents FraDatosGasto As Solmicro.Expertis.Engine.UI.Frame
    Friend WithEvents lblArticulo As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents AdvArticulo As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents txtDescArticulo As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents lblRefProveedor As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblArticuloProveedor As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents AdvArticuloProveedor As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents txtDescArticuloProveedor As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents txtDescRefProveedor As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents lblAnalitica As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents BtnAnalitica As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents lblTipoIVA As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents ulDescTipoIVA As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Friend WithEvents AdvTipoIVA As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lblCCCompra As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents ulDescCCCompra As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Friend WithEvents AdvCCCompra As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents UiCommandManager1 As Janus.Windows.UI.CommandBars.UICommandManager
    Friend WithEvents BottomRebar1 As Janus.Windows.UI.CommandBars.UIRebar
    Friend WithEvents UiCommandBar1 As Janus.Windows.UI.CommandBars.UICommandBar
    Friend WithEvents FraProveedor As Solmicro.Expertis.Engine.UI.Frame
    Friend WithEvents AdvFormaPago As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lblFormaPago As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents ulDescFormaPago As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Friend WithEvents lblCondicionPago As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents ulDescCondicionPago As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Friend WithEvents AdvCondicionPago As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lblDiaPago As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents ulDescDiaPago As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Friend WithEvents AdvDiaPago As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lblMoneda As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents ulDescMoneda As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Friend WithEvents lblTipoAsiento As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents CmbTipoAsiento As Solmicro.Expertis.Engine.UI.ComboBox
    Friend WithEvents lblRazonSocial As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents txtRazonSocial As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents lblCIF As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents txtCIF As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents lblFechaFactura As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents ClbFechaFactura As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents lblProveedor As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents ulDescProveedor As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Friend WithEvents lblSuFactura As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents txtSuFactura As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents lblSuFechaFactura As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents ClbSuFechaFactura As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents lblBancoPropio As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents ulDescBancoPropio As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Friend WithEvents AdvBancoPropio As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents LeftRebar1 As Janus.Windows.UI.CommandBars.UIRebar
    Friend WithEvents RightRebar1 As Janus.Windows.UI.CommandBars.UIRebar
    Friend WithEvents TopRebar1 As Janus.Windows.UI.CommandBars.UIRebar
    Friend WithEvents cmdUpdate As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents cmdUpdate1 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents AdvRefProveedor As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents AdvProveedor As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents AdvMoneda As Solmicro.Expertis.Engine.UI.AdvSearch

End Class
