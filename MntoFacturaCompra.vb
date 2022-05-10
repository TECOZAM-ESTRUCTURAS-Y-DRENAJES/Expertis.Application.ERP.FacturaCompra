Public Class MntoFacturaCompra
    Inherits Solmicro.Expertis.Engine.UI.SimpleMnto

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicialización después de la llamada a InitializeComponent()
        SettingNeededData()
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
    Public WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Public WithEvents FwiIDDireccion As Solmicro.Expertis.Engine.UI.TextBox
    Public WithEvents FwiIDProveedor As Solmicro.Expertis.Engine.UI.AdvSearch
    Public WithEvents lblcFwiIDProveedor As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Public WithEvents fwiProvincia As Solmicro.Expertis.Engine.UI.TextBox
    Public WithEvents lblfwiProvincia As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents FwiIdPais As Solmicro.Expertis.Engine.UI.AdvSearch
    Public WithEvents lblFwiIdPais As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents fwiPoblacion As Solmicro.Expertis.Engine.UI.TextBox
    Public WithEvents lblfwiPoblacion As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents fwiCodPostal As Solmicro.Expertis.Engine.UI.TextBox
    Public WithEvents lblfwiCodPostal As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents fwiDir As Solmicro.Expertis.Engine.UI.TextBox
    Public WithEvents lblfwiDir As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents FwiIDContador As Solmicro.Expertis.Engine.UI.TextBox
    Public WithEvents lblFwiIDContador As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents Line5 As Janus.Windows.EditControls.UIGroupBox
    Public WithEvents Line8 As Janus.Windows.EditControls.UIGroupBox
    Public WithEvents fwiSuFecFactura As Solmicro.Expertis.Engine.UI.CalendarBox
    Public WithEvents lblfwiSuFecFactura As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents fwiSuFactura As Solmicro.Expertis.Engine.UI.TextBox
    Public WithEvents lblfwiSuFactura As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents fwiNFactura As Solmicro.Expertis.Engine.UI.CounterTextBox
    Public WithEvents lblfwiNFactura As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents fwiFecFactura As Solmicro.Expertis.Engine.UI.CalendarBox
    Public WithEvents lblfwiFecFactura As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents fwiTotalIva As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents lblfwiTotalIva As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents fwiTotalBaseImp As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents lblfwiTotalBaseImp As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents fwiTotal As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents lblfwiTotal As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents fwiCIF As Solmicro.Expertis.Engine.UI.TextBox
    Public WithEvents lblfwiCIF As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents fwiRazonSocial As Solmicro.Expertis.Engine.UI.TextBox
    Public WithEvents lblfwiRazonSocial As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents fwiTel As Solmicro.Expertis.Engine.UI.TextBox
    Public WithEvents lblfwiTel As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents fwiFax As Solmicro.Expertis.Engine.UI.TextBox
    Public WithEvents lblfwiFax As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblFwiIDProveedor As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents LblSelloContabilizado As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblNObra As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents AdvObra As Solmicro.Expertis.Engine.UI.AdvSearch
    Public WithEvents PicCabecera As Solmicro.Expertis.Engine.UI.Panel
    Public WithEvents TabFacturas As Solmicro.Expertis.Engine.UI.Tab
    Public WithEvents TabPageLineas As Janus.Windows.UI.Tab.UITabPage
    Public WithEvents TabPageBasesIVA As Janus.Windows.UI.Tab.UITabPage
    Public WithEvents jngBaseImponible As Solmicro.Expertis.Engine.UI.Grid
    Public WithEvents fwiIVAManual As Solmicro.Expertis.Engine.UI.CheckBox
    Public WithEvents TabPageVencimientos As Janus.Windows.UI.Tab.UITabPage
    Public WithEvents jngVencimientos As Solmicro.Expertis.Engine.UI.Grid
    Public WithEvents fwiVencimientoManual As Solmicro.Expertis.Engine.UI.CheckBox
    Public WithEvents TabPageDatosEconomicos As Janus.Windows.UI.Tab.UITabPage
    Public WithEvents FraRetencion As Solmicro.Expertis.Engine.UI.Frame
    Public WithEvents lblImpRetencion As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents txtImpRetencionGar As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents lblFechaRetencion As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents cbxFechaRetencion As Solmicro.Expertis.Engine.UI.CalendarBox
    Public WithEvents lblRetencion As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents txtRetencion As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents lblTipoRetencion As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents cbxTipoRetencion As Solmicro.Expertis.Engine.UI.ComboBox
    Public WithEvents WLFrame8 As Solmicro.Expertis.Engine.UI.Frame
    Public WithEvents fwiCambioB As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents fwiCambioA As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents lblfwiCambioB As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblfwiCambioA As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents fwiDescMonedaB As Solmicro.Expertis.Engine.UI.TextBox
    Public WithEvents fwiDescMonedaA As Solmicro.Expertis.Engine.UI.TextBox
    Public WithEvents WLFrame6 As Solmicro.Expertis.Engine.UI.Frame
    Public WithEvents lblfwiIdMoneda As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblcfwiIdMoneda As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Public WithEvents fwiIdMoneda As Solmicro.Expertis.Engine.UI.AdvSearch
    Public WithEvents WLFrame5 As Solmicro.Expertis.Engine.UI.Frame
    Public WithEvents lblfwiTipoAsiento As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents fwiTipoAsiento As Solmicro.Expertis.Engine.UI.ComboBox
    Public WithEvents lblfwiFormaPago As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblcfwiFormaPago As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Public WithEvents fwiFormaPago As Solmicro.Expertis.Engine.UI.AdvSearch
    Public WithEvents lblfwiBancoPropio As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblcfwiBancoPropio As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Public WithEvents fwiBancoPropio As Solmicro.Expertis.Engine.UI.AdvSearch
    Public WithEvents lblfwiIdProvBanco As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblcfwiIdProvBanco As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Public WithEvents fwiIdProvBanco As Solmicro.Expertis.Engine.UI.AdvSearch
    Public WithEvents lblfwiIdDiaPago As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblcfwiIdDiaPago As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Public WithEvents fwiIdDiaPago As Solmicro.Expertis.Engine.UI.AdvSearch
    Public WithEvents lblfwiCondPago As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblcfwiCondPago As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Public WithEvents fwiCondPago As Solmicro.Expertis.Engine.UI.AdvSearch
    Public WithEvents TabPageImporteMonedas As Janus.Windows.UI.Tab.UITabPage
    Public WithEvents Line3 As Janus.Windows.EditControls.UIGroupBox
    Public WithEvents fwiMonedaB As Solmicro.Expertis.Engine.UI.TextBox
    Public WithEvents fwiMonedaA As Solmicro.Expertis.Engine.UI.TextBox
    Public WithEvents Line1 As Janus.Windows.EditControls.UIGroupBox
    Public WithEvents Line18 As Janus.Windows.EditControls.UIGroupBox
    Public WithEvents Line15 As Janus.Windows.EditControls.UIGroupBox
    Public WithEvents Line19 As Janus.Windows.EditControls.UIGroupBox
    Public WithEvents WLFrame9 As Solmicro.Expertis.Engine.UI.Frame
    Public WithEvents lblfwiImpLineasNormalesB As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents fwiImpLineasNormalesB As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents lblfwiImpLineasEspecialesB As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents fwiImpLineasEspecialesB As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents lblfwiImpLineasNormalesA As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents fwiImpLineasNormalesA As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents lblfwiImpLineasEspecialesA As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents fwiImpLineasEspecialesA As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents lblfwiImpRecFinanB As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents fwiImpRecFinanB As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents lblfwiImpRecFinanA As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents fwiImpRecFinanA As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents lblfwiImpReA As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents fwiImpReA As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents lblfwiRetencionA As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents fwiRetencionA As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents lblfwiIntrastat As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblfwiIntrastatA As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents fwiIntrastatA As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents lblfwiBaseImpB As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents fwiBaseImpB As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents lblfwiBaseImpA As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents fwiBaseImpA As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents lblfwiImpReB As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents fwiImpReB As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents lblfwiImpRetencionB As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents fwiImpRetencionB As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents lblfwiImpTotalB As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents fwiImpTotalB As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents lblfwiImpTotalA As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents fwiImpTotalA As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents lblfwiImpIVAB As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents fwiImpIVAB As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents lblfwiImpIVAA As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents fwiImpIVAA As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents lblfwiImpLineasA As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents fwiImpLineasA As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents lblfwiImpLineasB As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents fwiImpLineasB As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents Line6 As Janus.Windows.EditControls.UIGroupBox
    Public WithEvents TabPageTotales As Janus.Windows.UI.Tab.UITabPage
    Public WithEvents FraMoneda As Solmicro.Expertis.Engine.UI.Frame
    Public WithEvents ullDescMoneda As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Public WithEvents FraIvaIntrastat As Solmicro.Expertis.Engine.UI.Frame
    Public WithEvents lblImpIntrastat As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents ImpIntrastat As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents Line10 As Janus.Windows.EditControls.UIGroupBox
    Public WithEvents FraRetenciones As Solmicro.Expertis.Engine.UI.Frame
    Public WithEvents Label4 As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents NumericTextBox1 As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents Label5 As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents fwiRegimenEspecial As Solmicro.Expertis.Engine.UI.CheckBox
    Public WithEvents fwiRetencionManual As Solmicro.Expertis.Engine.UI.CheckBox
    Public WithEvents lblfwiBaseRetencion As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents fwiBaseRetencion As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents lblfwiPorcIRPF As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents fwiPorcIRPF As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents lblfwiImpRetencion As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents fwiImpRetencion As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents fraCalculoFactura As Solmicro.Expertis.Engine.UI.Frame
    Public WithEvents Label3 As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents Label2 As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents Label1 As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblfwiImpLineasNormales As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents fwiImpLineasNormales As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents lblfwiImpLineasEspeciales As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents fwiImpLineasEspeciales As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents lblfwiImpTotal As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents fwiImpTotal As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents lblfwiDtoProntoPago As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents fwiDtoProntoPago As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents lblfwiBaseImpMon As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents fwiBaseImpMon As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents lblfwiImpLinMon As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents fwiImpLinMon As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents lblfwiImpREMon As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents fwiImpREMon As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents lblfwiIVA As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents fwiIVA As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents lblfwiRecFinan As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents fwiRecFinan As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents lblfwiImpRecFinan As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents fwiImpRecFinan As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents lblfwiDtoFactura As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents fwiDtoFactura As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents TabPageAnotaciones As Janus.Windows.UI.Tab.UITabPage
    Public WithEvents fraComentarios As Solmicro.Expertis.Engine.UI.Frame
    Public WithEvents fwiTextoFactura As Solmicro.Expertis.Engine.UI.TextBox
    Public WithEvents TabPageSeguimiento As Janus.Windows.UI.Tab.UITabPage
    Public WithEvents CmbCentroCoste As Solmicro.Expertis.Engine.UI.ComboBox
    Public WithEvents LblCentroCoste As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents FwiTipoFactura As Solmicro.Expertis.Engine.UI.ComboBox
    Public WithEvents lblfwiCGestion As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents FraDirFacturacion As Solmicro.Expertis.Engine.UI.Frame
    Public WithEvents FwDirFacturacion As Solmicro.Expertis.Engine.UI.TextBox
    Public WithEvents fwiCGestion As Solmicro.Expertis.Engine.UI.ComboBox
    Public WithEvents lblfwiTipoFactura As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblfwiNDocumento As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblFwicIDEjercicioC As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Public WithEvents fwiNDocumento As Solmicro.Expertis.Engine.UI.TextBox
    Public WithEvents lblfwiIDEjercicio As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents fwiIDEjercicio As Solmicro.Expertis.Engine.UI.TextBox
    Public WithEvents lblfwiEstado As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents fwiEstado As Solmicro.Expertis.Engine.UI.TextBox
    Public WithEvents WLFrame7 As Solmicro.Expertis.Engine.UI.Frame
    Public WithEvents lblfwiNAutofactura As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents fwiNAutofactura As Solmicro.Expertis.Engine.UI.TextBox
    Public WithEvents lblfwiIDAutofactura As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents pnlLineas As Solmicro.Expertis.Engine.UI.Panel
    Public WithEvents UiGroupBox1 As Janus.Windows.EditControls.UIGroupBox
    Public WithEvents Line11 As Janus.Windows.EditControls.UIGroupBox
    Public WithEvents Line13 As Janus.Windows.EditControls.UIGroupBox
    Public WithEvents ImageList1 As System.Windows.Forms.ImageList
    Public WithEvents LblImpTotalVtos As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents TabPageDeclaraciones As Janus.Windows.UI.Tab.UITabPage
    Public WithEvents CmbTipoOperIntra As Solmicro.Expertis.Engine.UI.ComboBox
    Public WithEvents LblTipoOperIntra As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents cbxClaveOperacion As Solmicro.Expertis.Engine.UI.ComboBox
    Public WithEvents lblClaveOperacion As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents AdvFtaRectificada As Solmicro.Expertis.Engine.UI.AdvSearch
    Public WithEvents lblFacturaRectificada As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents fraDeclaracionesIva As Solmicro.Expertis.Engine.UI.Frame
    Public WithEvents chkEnviar347 As Solmicro.Expertis.Engine.UI.CheckBox
    Public WithEvents lblFwiFechaParaDeclaracion As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblFwiNumDeclaracion As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents chkFechaDeclManual As Solmicro.Expertis.Engine.UI.CheckBox
    Public WithEvents FwiFechaParaDeclaracion As Solmicro.Expertis.Engine.UI.CalendarBox
    Public WithEvents FwiNumDeclaracion As Solmicro.Expertis.Engine.UI.TextBox
    Public WithEvents lblFwiAñoDeclaracion As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents FwiAñoDeclaracion As Solmicro.Expertis.Engine.UI.TextBox
    Public WithEvents LblTotalVtos As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents ChkSectorServicios As Solmicro.Expertis.Engine.UI.CheckBox
    Public WithEvents ChkEnviar349 As Solmicro.Expertis.Engine.UI.CheckBox
    Public WithEvents CmbTipoRetencionIRPF As Solmicro.Expertis.Engine.UI.ComboBox
    Public WithEvents LblTipoRetencionIRPF As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents ChkOpeTriangular As Solmicro.Expertis.Engine.UI.CheckBox
    Public WithEvents Frame1 As Solmicro.Expertis.Engine.UI.Frame
    Public WithEvents chkImportacion As Solmicro.Expertis.Engine.UI.CheckBox
    Public WithEvents lblNReferencia As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents txtNReferencia As Solmicro.Expertis.Engine.UI.TextBox
    Public WithEvents jngLineaFactura As Solmicro.Expertis.Engine.UI.Grid
    Public WithEvents Label7 As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents NumericTextBox3 As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents Label6 As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents NumericTextBox2 As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents Label8 As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents NumericTextBox4 As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents fwiIntrastatB As Solmicro.Expertis.Engine.UI.NumericTextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim jngLineaFactura_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim jngLineaFactura_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column6.ButtonImage")
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MntoFacturaCompra))
        Dim jngLineaFactura_DesignTimeLayout_Reference_1 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column7.ButtonImage")
        Dim jngLineaFactura_DesignTimeLayout_Reference_2 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column10.ButtonImage")
        Dim jngLineaFactura_DesignTimeLayout_Reference_3 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column22.ButtonImage")
        Dim jngLineaFactura_DesignTimeLayout_Reference_4 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column23.ButtonImage")
        Dim jngLineaFactura_DesignTimeLayout_Reference_5 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column29.ButtonImage")
        Dim jngLineaFactura_DesignTimeLayout_Reference_6 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column30.ButtonImage")
        Dim jngLineaFactura_DesignTimeLayout_Reference_7 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column33.ButtonImage")
        Dim jngLineaFactura_DesignTimeLayout_Reference_8 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.ImageList.ImageStream")
        Dim jngBaseImponible_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim jngBaseImponible_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column2.ButtonImage")
        Dim jngVencimientos_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim jngVencimientos_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column5.ButtonImage")
        Dim cbxTipoRetencion_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim fwiTipoAsiento_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim CmbTipoRetencionIRPF_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim CmbCentroCoste_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim FwiTipoFactura_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim fwiCGestion_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim CmbTipoOperIntra_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim cbxClaveOperacion_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.PicCabecera = New Solmicro.Expertis.Engine.UI.Panel
        Me.LblImpTotalVtos = New Solmicro.Expertis.Engine.UI.Label
        Me.LblTotalVtos = New Solmicro.Expertis.Engine.UI.Label
        Me.lblNObra = New Solmicro.Expertis.Engine.UI.Label
        Me.AdvObra = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.LblSelloContabilizado = New Solmicro.Expertis.Engine.UI.Label
        Me.lblcFwiIDProveedor = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.lblFwiIDProveedor = New Solmicro.Expertis.Engine.UI.Label
        Me.FwiIDDireccion = New Solmicro.Expertis.Engine.UI.TextBox
        Me.FwiIDProveedor = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblfwiProvincia = New Solmicro.Expertis.Engine.UI.Label
        Me.fwiProvincia = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblFwiIdPais = New Solmicro.Expertis.Engine.UI.Label
        Me.FwiIdPais = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblfwiPoblacion = New Solmicro.Expertis.Engine.UI.Label
        Me.fwiPoblacion = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblfwiCodPostal = New Solmicro.Expertis.Engine.UI.Label
        Me.fwiCodPostal = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblfwiDir = New Solmicro.Expertis.Engine.UI.Label
        Me.fwiDir = New Solmicro.Expertis.Engine.UI.TextBox
        Me.FwiIDContador = New Solmicro.Expertis.Engine.UI.TextBox
        Me.Line5 = New Janus.Windows.EditControls.UIGroupBox
        Me.Line8 = New Janus.Windows.EditControls.UIGroupBox
        Me.fwiSuFecFactura = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.fwiSuFactura = New Solmicro.Expertis.Engine.UI.TextBox
        Me.fwiNFactura = New Solmicro.Expertis.Engine.UI.CounterTextBox
        Me.fwiFecFactura = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.lblfwiTotalIva = New Solmicro.Expertis.Engine.UI.Label
        Me.fwiTotalIva = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblfwiTotalBaseImp = New Solmicro.Expertis.Engine.UI.Label
        Me.fwiTotalBaseImp = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblfwiTotal = New Solmicro.Expertis.Engine.UI.Label
        Me.fwiTotal = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblfwiCIF = New Solmicro.Expertis.Engine.UI.Label
        Me.fwiCIF = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblfwiRazonSocial = New Solmicro.Expertis.Engine.UI.Label
        Me.fwiRazonSocial = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblfwiTel = New Solmicro.Expertis.Engine.UI.Label
        Me.fwiTel = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblfwiFax = New Solmicro.Expertis.Engine.UI.Label
        Me.fwiFax = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblFwiIDContador = New Solmicro.Expertis.Engine.UI.Label
        Me.lblfwiNFactura = New Solmicro.Expertis.Engine.UI.Label
        Me.lblfwiSuFactura = New Solmicro.Expertis.Engine.UI.Label
        Me.lblfwiSuFecFactura = New Solmicro.Expertis.Engine.UI.Label
        Me.lblfwiFecFactura = New Solmicro.Expertis.Engine.UI.Label
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.pnlLineas = New Solmicro.Expertis.Engine.UI.Panel
        Me.TabFacturas = New Solmicro.Expertis.Engine.UI.Tab
        Me.TabPageLineas = New Janus.Windows.UI.Tab.UITabPage
        Me.jngLineaFactura = New Solmicro.Expertis.Engine.UI.Grid
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.TabPageBasesIVA = New Janus.Windows.UI.Tab.UITabPage
        Me.jngBaseImponible = New Solmicro.Expertis.Engine.UI.Grid
        Me.fwiIVAManual = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.TabPageVencimientos = New Janus.Windows.UI.Tab.UITabPage
        Me.jngVencimientos = New Solmicro.Expertis.Engine.UI.Grid
        Me.fwiVencimientoManual = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.TabPageDatosEconomicos = New Janus.Windows.UI.Tab.UITabPage
        Me.FraRetencion = New Solmicro.Expertis.Engine.UI.Frame
        Me.lblImpRetencion = New Solmicro.Expertis.Engine.UI.Label
        Me.txtImpRetencionGar = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblFechaRetencion = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxFechaRetencion = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.lblRetencion = New Solmicro.Expertis.Engine.UI.Label
        Me.txtRetencion = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblTipoRetencion = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxTipoRetencion = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.WLFrame8 = New Solmicro.Expertis.Engine.UI.Frame
        Me.fwiCambioB = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.fwiCambioA = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblfwiCambioB = New Solmicro.Expertis.Engine.UI.Label
        Me.lblfwiCambioA = New Solmicro.Expertis.Engine.UI.Label
        Me.fwiDescMonedaB = New Solmicro.Expertis.Engine.UI.TextBox
        Me.fwiDescMonedaA = New Solmicro.Expertis.Engine.UI.TextBox
        Me.WLFrame6 = New Solmicro.Expertis.Engine.UI.Frame
        Me.lblfwiIdMoneda = New Solmicro.Expertis.Engine.UI.Label
        Me.lblcfwiIdMoneda = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.fwiIdMoneda = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.WLFrame5 = New Solmicro.Expertis.Engine.UI.Frame
        Me.lblfwiTipoAsiento = New Solmicro.Expertis.Engine.UI.Label
        Me.fwiTipoAsiento = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.lblfwiFormaPago = New Solmicro.Expertis.Engine.UI.Label
        Me.lblcfwiFormaPago = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.fwiFormaPago = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblfwiBancoPropio = New Solmicro.Expertis.Engine.UI.Label
        Me.lblcfwiBancoPropio = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.fwiBancoPropio = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblfwiIdProvBanco = New Solmicro.Expertis.Engine.UI.Label
        Me.lblcfwiIdProvBanco = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.fwiIdProvBanco = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblfwiIdDiaPago = New Solmicro.Expertis.Engine.UI.Label
        Me.lblcfwiIdDiaPago = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.fwiIdDiaPago = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblfwiCondPago = New Solmicro.Expertis.Engine.UI.Label
        Me.lblcfwiCondPago = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.fwiCondPago = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.TabPageImporteMonedas = New Janus.Windows.UI.Tab.UITabPage
        Me.Line3 = New Janus.Windows.EditControls.UIGroupBox
        Me.fwiMonedaB = New Solmicro.Expertis.Engine.UI.TextBox
        Me.fwiMonedaA = New Solmicro.Expertis.Engine.UI.TextBox
        Me.Line1 = New Janus.Windows.EditControls.UIGroupBox
        Me.Line18 = New Janus.Windows.EditControls.UIGroupBox
        Me.Line15 = New Janus.Windows.EditControls.UIGroupBox
        Me.Line19 = New Janus.Windows.EditControls.UIGroupBox
        Me.WLFrame9 = New Solmicro.Expertis.Engine.UI.Frame
        Me.lblfwiImpLineasNormalesB = New Solmicro.Expertis.Engine.UI.Label
        Me.fwiImpLineasNormalesB = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblfwiImpLineasEspecialesB = New Solmicro.Expertis.Engine.UI.Label
        Me.fwiImpLineasEspecialesB = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblfwiImpLineasNormalesA = New Solmicro.Expertis.Engine.UI.Label
        Me.fwiImpLineasNormalesA = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblfwiImpLineasEspecialesA = New Solmicro.Expertis.Engine.UI.Label
        Me.fwiImpLineasEspecialesA = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblfwiImpRecFinanB = New Solmicro.Expertis.Engine.UI.Label
        Me.fwiImpRecFinanB = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblfwiImpRecFinanA = New Solmicro.Expertis.Engine.UI.Label
        Me.fwiImpRecFinanA = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblfwiImpReA = New Solmicro.Expertis.Engine.UI.Label
        Me.fwiImpReA = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblfwiRetencionA = New Solmicro.Expertis.Engine.UI.Label
        Me.fwiRetencionA = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblfwiIntrastat = New Solmicro.Expertis.Engine.UI.Label
        Me.fwiIntrastatB = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblfwiIntrastatA = New Solmicro.Expertis.Engine.UI.Label
        Me.fwiIntrastatA = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblfwiBaseImpB = New Solmicro.Expertis.Engine.UI.Label
        Me.fwiBaseImpB = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblfwiBaseImpA = New Solmicro.Expertis.Engine.UI.Label
        Me.fwiBaseImpA = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblfwiImpReB = New Solmicro.Expertis.Engine.UI.Label
        Me.fwiImpReB = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblfwiImpRetencionB = New Solmicro.Expertis.Engine.UI.Label
        Me.fwiImpRetencionB = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblfwiImpTotalB = New Solmicro.Expertis.Engine.UI.Label
        Me.fwiImpTotalB = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblfwiImpTotalA = New Solmicro.Expertis.Engine.UI.Label
        Me.fwiImpTotalA = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblfwiImpIVAB = New Solmicro.Expertis.Engine.UI.Label
        Me.fwiImpIVAB = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblfwiImpIVAA = New Solmicro.Expertis.Engine.UI.Label
        Me.fwiImpIVAA = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblfwiImpLineasA = New Solmicro.Expertis.Engine.UI.Label
        Me.fwiImpLineasA = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblfwiImpLineasB = New Solmicro.Expertis.Engine.UI.Label
        Me.fwiImpLineasB = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.Line6 = New Janus.Windows.EditControls.UIGroupBox
        Me.Label7 = New Solmicro.Expertis.Engine.UI.Label
        Me.NumericTextBox3 = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.Label6 = New Solmicro.Expertis.Engine.UI.Label
        Me.NumericTextBox2 = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.TabPageTotales = New Janus.Windows.UI.Tab.UITabPage
        Me.FraMoneda = New Solmicro.Expertis.Engine.UI.Frame
        Me.ullDescMoneda = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.FraIvaIntrastat = New Solmicro.Expertis.Engine.UI.Frame
        Me.lblImpIntrastat = New Solmicro.Expertis.Engine.UI.Label
        Me.ImpIntrastat = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.Line10 = New Janus.Windows.EditControls.UIGroupBox
        Me.FraRetenciones = New Solmicro.Expertis.Engine.UI.Frame
        Me.CmbTipoRetencionIRPF = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.LblTipoRetencionIRPF = New Solmicro.Expertis.Engine.UI.Label
        Me.Label4 = New Solmicro.Expertis.Engine.UI.Label
        Me.NumericTextBox1 = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.Label5 = New Solmicro.Expertis.Engine.UI.Label
        Me.fwiRegimenEspecial = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.fwiRetencionManual = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.lblfwiBaseRetencion = New Solmicro.Expertis.Engine.UI.Label
        Me.fwiBaseRetencion = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblfwiPorcIRPF = New Solmicro.Expertis.Engine.UI.Label
        Me.fwiPorcIRPF = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblfwiImpRetencion = New Solmicro.Expertis.Engine.UI.Label
        Me.fwiImpRetencion = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.fraCalculoFactura = New Solmicro.Expertis.Engine.UI.Frame
        Me.Label8 = New Solmicro.Expertis.Engine.UI.Label
        Me.NumericTextBox4 = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.Line13 = New Janus.Windows.EditControls.UIGroupBox
        Me.Line11 = New Janus.Windows.EditControls.UIGroupBox
        Me.UiGroupBox1 = New Janus.Windows.EditControls.UIGroupBox
        Me.Label3 = New Solmicro.Expertis.Engine.UI.Label
        Me.Label2 = New Solmicro.Expertis.Engine.UI.Label
        Me.Label1 = New Solmicro.Expertis.Engine.UI.Label
        Me.lblfwiImpLineasNormales = New Solmicro.Expertis.Engine.UI.Label
        Me.fwiImpLineasNormales = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblfwiImpLineasEspeciales = New Solmicro.Expertis.Engine.UI.Label
        Me.fwiImpLineasEspeciales = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblfwiImpTotal = New Solmicro.Expertis.Engine.UI.Label
        Me.fwiImpTotal = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblfwiDtoProntoPago = New Solmicro.Expertis.Engine.UI.Label
        Me.fwiDtoProntoPago = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblfwiBaseImpMon = New Solmicro.Expertis.Engine.UI.Label
        Me.fwiBaseImpMon = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblfwiImpLinMon = New Solmicro.Expertis.Engine.UI.Label
        Me.fwiImpLinMon = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblfwiImpREMon = New Solmicro.Expertis.Engine.UI.Label
        Me.fwiImpREMon = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblfwiIVA = New Solmicro.Expertis.Engine.UI.Label
        Me.fwiIVA = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblfwiRecFinan = New Solmicro.Expertis.Engine.UI.Label
        Me.fwiRecFinan = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblfwiImpRecFinan = New Solmicro.Expertis.Engine.UI.Label
        Me.fwiImpRecFinan = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblfwiDtoFactura = New Solmicro.Expertis.Engine.UI.Label
        Me.fwiDtoFactura = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.TabPageAnotaciones = New Janus.Windows.UI.Tab.UITabPage
        Me.fraComentarios = New Solmicro.Expertis.Engine.UI.Frame
        Me.fwiTextoFactura = New Solmicro.Expertis.Engine.UI.TextBox
        Me.TabPageSeguimiento = New Janus.Windows.UI.Tab.UITabPage
        Me.lblfwiNDocumento = New Solmicro.Expertis.Engine.UI.Label
        Me.CmbCentroCoste = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.fwiNDocumento = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblFwicIDEjercicioC = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.LblCentroCoste = New Solmicro.Expertis.Engine.UI.Label
        Me.FwiTipoFactura = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.lblfwiIDEjercicio = New Solmicro.Expertis.Engine.UI.Label
        Me.lblfwiCGestion = New Solmicro.Expertis.Engine.UI.Label
        Me.fwiIDEjercicio = New Solmicro.Expertis.Engine.UI.TextBox
        Me.FraDirFacturacion = New Solmicro.Expertis.Engine.UI.Frame
        Me.FwDirFacturacion = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblfwiEstado = New Solmicro.Expertis.Engine.UI.Label
        Me.fwiCGestion = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.fwiEstado = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblfwiTipoFactura = New Solmicro.Expertis.Engine.UI.Label
        Me.WLFrame7 = New Solmicro.Expertis.Engine.UI.Frame
        Me.lblfwiNAutofactura = New Solmicro.Expertis.Engine.UI.Label
        Me.fwiNAutofactura = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblfwiIDAutofactura = New Solmicro.Expertis.Engine.UI.Label
        Me.TabPageDeclaraciones = New Janus.Windows.UI.Tab.UITabPage
        Me.Frame1 = New Solmicro.Expertis.Engine.UI.Frame
        Me.lblNReferencia = New Solmicro.Expertis.Engine.UI.Label
        Me.txtNReferencia = New Solmicro.Expertis.Engine.UI.TextBox
        Me.chkImportacion = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.CmbTipoOperIntra = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.LblTipoOperIntra = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxClaveOperacion = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.lblClaveOperacion = New Solmicro.Expertis.Engine.UI.Label
        Me.AdvFtaRectificada = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblFacturaRectificada = New Solmicro.Expertis.Engine.UI.Label
        Me.fraDeclaracionesIva = New Solmicro.Expertis.Engine.UI.Frame
        Me.ChkOpeTriangular = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.ChkSectorServicios = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.ChkEnviar349 = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.chkEnviar347 = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.lblFwiFechaParaDeclaracion = New Solmicro.Expertis.Engine.UI.Label
        Me.lblFwiNumDeclaracion = New Solmicro.Expertis.Engine.UI.Label
        Me.chkFechaDeclManual = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.FwiFechaParaDeclaracion = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.FwiNumDeclaracion = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblFwiAñoDeclaracion = New Solmicro.Expertis.Engine.UI.Label
        Me.FwiAñoDeclaracion = New Solmicro.Expertis.Engine.UI.TextBox
        CType(Me.ToolBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MenuBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainPanel.suspendlayout()
        Me.PicCabecera.suspendlayout()
        CType(Me.Line5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Line8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlLineas.suspendlayout()
        CType(Me.TabFacturas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabFacturas.SuspendLayout()
        Me.TabPageLineas.SuspendLayout()
        CType(Me.jngLineaFactura, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPageBasesIVA.SuspendLayout()
        CType(Me.jngBaseImponible, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPageVencimientos.SuspendLayout()
        CType(Me.jngVencimientos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPageDatosEconomicos.SuspendLayout()
        Me.FraRetencion.SuspendLayout()
        CType(Me.cbxTipoRetencion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.WLFrame8.SuspendLayout()
        Me.WLFrame6.SuspendLayout()
        Me.WLFrame5.SuspendLayout()
        CType(Me.fwiTipoAsiento, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPageImporteMonedas.SuspendLayout()
        CType(Me.Line3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Line1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Line18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Line15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Line19, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.WLFrame9.SuspendLayout()
        CType(Me.Line6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Line6.SuspendLayout()
        Me.TabPageTotales.SuspendLayout()
        Me.FraMoneda.SuspendLayout()
        Me.FraIvaIntrastat.SuspendLayout()
        CType(Me.Line10, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FraRetenciones.SuspendLayout()
        CType(Me.CmbTipoRetencionIRPF, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.fraCalculoFactura.SuspendLayout()
        CType(Me.Line13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Line11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPageAnotaciones.SuspendLayout()
        Me.fraComentarios.SuspendLayout()
        Me.TabPageSeguimiento.SuspendLayout()
        CType(Me.CmbCentroCoste, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FwiTipoFactura, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FraDirFacturacion.SuspendLayout()
        CType(Me.fwiCGestion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.WLFrame7.SuspendLayout()
        Me.TabPageDeclaraciones.SuspendLayout()
        Me.Frame1.SuspendLayout()
        CType(Me.CmbTipoOperIntra, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbxClaveOperacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.fraDeclaracionesIva.SuspendLayout()
        Me.SuspendLayout()
        '
        'Duplicate
        '
        Me.Duplicate.Enabled = Janus.Windows.UI.InheritableBoolean.[True]
        '
        'ToolBar
        '
        Me.ToolBar.Size = New System.Drawing.Size(721, 39)
        '
        'MenuBar
        '
        Me.MenuBar.Location = New System.Drawing.Point(0, 42)
        Me.MenuBar.Size = New System.Drawing.Size(504, 26)
        '
        'GoFirst
        '
        Me.GoFirst.Enabled = Janus.Windows.UI.InheritableBoolean.[True]
        '
        'GoPrevious
        '
        Me.GoPrevious.Enabled = Janus.Windows.UI.InheritableBoolean.[True]
        '
        'GoNext
        '
        Me.GoNext.Enabled = Janus.Windows.UI.InheritableBoolean.[True]
        '
        'Delete
        '
        Me.Delete.Enabled = Janus.Windows.UI.InheritableBoolean.[True]
        '
        'Ok
        '
        Me.Ok.Enabled = Janus.Windows.UI.InheritableBoolean.[False]
        '
        'Cancel
        '
        Me.Cancel.Enabled = Janus.Windows.UI.InheritableBoolean.[False]
        '
        'Print
        '
        Me.Print.Enabled = Janus.Windows.UI.InheritableBoolean.[True]
        '
        'Search
        '
        Me.Search.Enabled = Janus.Windows.UI.InheritableBoolean.[True]
        '
        'GoLast
        '
        Me.GoLast.Enabled = Janus.Windows.UI.InheritableBoolean.[True]
        '
        'FindText
        '
        Me.FindText.Enabled = Janus.Windows.UI.InheritableBoolean.[True]
        '
        'Find
        '
        Me.Find.Enabled = Janus.Windows.UI.InheritableBoolean.[True]
        '
        'NewRow
        '
        Me.NewRow.Enabled = Janus.Windows.UI.InheritableBoolean.[True]
        '
        'Requery
        '
        Me.Requery.Enabled = Janus.Windows.UI.InheritableBoolean.[True]
        '
        'ExecuteActions
        '
        Me.ExecuteActions.Enabled = Janus.Windows.UI.InheritableBoolean.[True]
        '
        'MainPanel
        '
        Me.MainPanel.Controls.Add(Me.pnlLineas)
        Me.MainPanel.Controls.Add(Me.PicCabecera)
        Me.MainPanel.Size = New System.Drawing.Size(720, 550)
        '
        'PicCabecera
        '
        Me.PicCabecera.Controls.Add(Me.LblImpTotalVtos)
        Me.PicCabecera.Controls.Add(Me.LblTotalVtos)
        Me.PicCabecera.Controls.Add(Me.lblNObra)
        Me.PicCabecera.Controls.Add(Me.AdvObra)
        Me.PicCabecera.Controls.Add(Me.LblSelloContabilizado)
        Me.PicCabecera.Controls.Add(Me.lblcFwiIDProveedor)
        Me.PicCabecera.Controls.Add(Me.lblFwiIDProveedor)
        Me.PicCabecera.Controls.Add(Me.FwiIDDireccion)
        Me.PicCabecera.Controls.Add(Me.FwiIDProveedor)
        Me.PicCabecera.Controls.Add(Me.lblfwiProvincia)
        Me.PicCabecera.Controls.Add(Me.fwiProvincia)
        Me.PicCabecera.Controls.Add(Me.lblFwiIdPais)
        Me.PicCabecera.Controls.Add(Me.FwiIdPais)
        Me.PicCabecera.Controls.Add(Me.lblfwiPoblacion)
        Me.PicCabecera.Controls.Add(Me.fwiPoblacion)
        Me.PicCabecera.Controls.Add(Me.lblfwiCodPostal)
        Me.PicCabecera.Controls.Add(Me.fwiCodPostal)
        Me.PicCabecera.Controls.Add(Me.lblfwiDir)
        Me.PicCabecera.Controls.Add(Me.fwiDir)
        Me.PicCabecera.Controls.Add(Me.FwiIDContador)
        Me.PicCabecera.Controls.Add(Me.Line5)
        Me.PicCabecera.Controls.Add(Me.Line8)
        Me.PicCabecera.Controls.Add(Me.fwiSuFecFactura)
        Me.PicCabecera.Controls.Add(Me.fwiSuFactura)
        Me.PicCabecera.Controls.Add(Me.fwiNFactura)
        Me.PicCabecera.Controls.Add(Me.fwiFecFactura)
        Me.PicCabecera.Controls.Add(Me.lblfwiTotalIva)
        Me.PicCabecera.Controls.Add(Me.fwiTotalIva)
        Me.PicCabecera.Controls.Add(Me.lblfwiTotalBaseImp)
        Me.PicCabecera.Controls.Add(Me.fwiTotalBaseImp)
        Me.PicCabecera.Controls.Add(Me.lblfwiTotal)
        Me.PicCabecera.Controls.Add(Me.fwiTotal)
        Me.PicCabecera.Controls.Add(Me.lblfwiCIF)
        Me.PicCabecera.Controls.Add(Me.fwiCIF)
        Me.PicCabecera.Controls.Add(Me.lblfwiRazonSocial)
        Me.PicCabecera.Controls.Add(Me.fwiRazonSocial)
        Me.PicCabecera.Controls.Add(Me.lblfwiTel)
        Me.PicCabecera.Controls.Add(Me.fwiTel)
        Me.PicCabecera.Controls.Add(Me.lblfwiFax)
        Me.PicCabecera.Controls.Add(Me.fwiFax)
        Me.PicCabecera.Controls.Add(Me.lblFwiIDContador)
        Me.PicCabecera.Controls.Add(Me.lblfwiNFactura)
        Me.PicCabecera.Controls.Add(Me.lblfwiSuFactura)
        Me.PicCabecera.Controls.Add(Me.lblfwiSuFecFactura)
        Me.PicCabecera.Controls.Add(Me.lblfwiFecFactura)
        Me.PicCabecera.Dock = System.Windows.Forms.DockStyle.Top
        Me.PicCabecera.Location = New System.Drawing.Point(0, 0)
        Me.PicCabecera.Name = "PicCabecera"
        Me.PicCabecera.Size = New System.Drawing.Size(720, 176)
        Me.PicCabecera.TabIndex = 0
        '
        'LblImpTotalVtos
        '
        Me.LblImpTotalVtos.Location = New System.Drawing.Point(656, 148)
        Me.LblImpTotalVtos.Name = "LblImpTotalVtos"
        Me.LblImpTotalVtos.Size = New System.Drawing.Size(0, 13)
        Me.LblImpTotalVtos.TabIndex = 159
        '
        'LblTotalVtos
        '
        Me.LblTotalVtos.Location = New System.Drawing.Point(582, 149)
        Me.LblTotalVtos.Name = "LblTotalVtos"
        Me.LblTotalVtos.Size = New System.Drawing.Size(67, 13)
        Me.LblTotalVtos.TabIndex = 158
        Me.LblTotalVtos.Text = "Total Vtos."
        '
        'lblNObra
        '
        Me.lblNObra.Location = New System.Drawing.Point(530, 111)
        Me.lblNObra.Name = "lblNObra"
        Me.lblNObra.Size = New System.Drawing.Size(57, 13)
        Me.lblNObra.TabIndex = 157
        Me.lblNObra.Tag = ""
        Me.lblNObra.Text = "Proyecto"
        '
        'AdvObra
        '
        Me.TryDataBinding(AdvObra, New System.Windows.Forms.Binding("Value", Me, "IDObra", True))
        Me.AdvObra.DisabledBackColor = System.Drawing.Color.White
        Me.AdvObra.DisplayField = "NObra"
        Me.AdvObra.EntityName = "obracabecera"
        Me.AdvObra.Location = New System.Drawing.Point(592, 107)
        Me.AdvObra.Name = "AdvObra"
        Me.AdvObra.PrimaryDataFields = "IDObra"
        Me.AdvObra.SecondaryDataFields = "IDObra"
        Me.AdvObra.Size = New System.Drawing.Size(123, 23)
        Me.AdvObra.TabIndex = 13
        '
        'LblSelloContabilizado
        '
        Me.LblSelloContabilizado.Location = New System.Drawing.Point(632, 11)
        Me.LblSelloContabilizado.Name = "LblSelloContabilizado"
        Me.LblSelloContabilizado.Size = New System.Drawing.Size(84, 13)
        Me.LblSelloContabilizado.TabIndex = 147
        Me.LblSelloContabilizado.Tag = ""
        Me.LblSelloContabilizado.Text = "Contabilizada"
        Me.LblSelloContabilizado.Visible = False
        '
        'lblcFwiIDProveedor
        '
        Me.TryDataBinding(lblcFwiIDProveedor, New System.Windows.Forms.Binding("Text", Me.FwiIDProveedor, "DescProveedor", True))
        Me.lblcFwiIDProveedor.Location = New System.Drawing.Point(322, 6)
        Me.lblcFwiIDProveedor.Name = "lblcFwiIDProveedor"
        Me.lblcFwiIDProveedor.Size = New System.Drawing.Size(304, 21)
        Me.lblcFwiIDProveedor.TabIndex = 127
        '
        'lblFwiIDProveedor
        '
        Me.lblFwiIDProveedor.Location = New System.Drawing.Point(151, 9)
        Me.lblFwiIDProveedor.Name = "lblFwiIDProveedor"
        Me.lblFwiIDProveedor.Size = New System.Drawing.Size(66, 13)
        Me.lblFwiIDProveedor.TabIndex = 154
        Me.lblFwiIDProveedor.Text = "Proveedor"
        '
        'FwiIDDireccion
        '
        Me.TryDataBinding(FwiIDDireccion, New System.Windows.Forms.Binding("Text", Me, "IDDireccion", True))
        Me.FwiIDDireccion.DisabledBackColor = System.Drawing.Color.White
        Me.FwiIDDireccion.Location = New System.Drawing.Point(567, 3)
        Me.FwiIDDireccion.Name = "FwiIDDireccion"
        Me.FwiIDDireccion.Size = New System.Drawing.Size(80, 21)
        Me.FwiIDDireccion.TabIndex = 123
        Me.FwiIDDireccion.Visible = False
        '
        'FwiIDProveedor
        '
        Me.TryDataBinding(FwiIDProveedor, New System.Windows.Forms.Binding("Text", Me, "IDProveedor", True))
        Me.FwiIDProveedor.DisabledBackColor = System.Drawing.Color.White
        Me.FwiIDProveedor.EntityName = "Proveedor"
        Me.FwiIDProveedor.Location = New System.Drawing.Point(219, 6)
        Me.FwiIDProveedor.Name = "FwiIDProveedor"
        Me.FwiIDProveedor.PrimaryDataFields = "IDProveedor"
        Me.FwiIDProveedor.SecondaryDataFields = "IDProveedor"
        Me.FwiIDProveedor.Size = New System.Drawing.Size(100, 23)
        Me.FwiIDProveedor.TabIndex = 5
        Me.FwiIDProveedor.ViewName = "tbMaestroProveedor"
        '
        'lblfwiProvincia
        '
        Me.lblfwiProvincia.Location = New System.Drawing.Point(151, 112)
        Me.lblfwiProvincia.Name = "lblfwiProvincia"
        Me.lblfwiProvincia.Size = New System.Drawing.Size(59, 13)
        Me.lblfwiProvincia.TabIndex = 129
        Me.lblfwiProvincia.Tag = "IdRec=4412;"
        Me.lblfwiProvincia.Text = "Provincia"
        '
        'fwiProvincia
        '
        Me.TryDataBinding(fwiProvincia, New System.Windows.Forms.Binding("Text", Me, "Provincia", True))
        Me.fwiProvincia.DisabledBackColor = System.Drawing.Color.White
        Me.fwiProvincia.Location = New System.Drawing.Point(219, 107)
        Me.fwiProvincia.Name = "fwiProvincia"
        Me.fwiProvincia.Size = New System.Drawing.Size(208, 21)
        Me.fwiProvincia.TabIndex = 11
        '
        'lblFwiIdPais
        '
        Me.lblFwiIdPais.Location = New System.Drawing.Point(431, 112)
        Me.lblFwiIdPais.Name = "lblFwiIdPais"
        Me.lblFwiIdPais.Size = New System.Drawing.Size(30, 13)
        Me.lblFwiIdPais.TabIndex = 130
        Me.lblFwiIdPais.Tag = "IdRec=6987;"
        Me.lblFwiIdPais.Text = "Pais"
        '
        'FwiIdPais
        '
        Me.TryDataBinding(FwiIdPais, New System.Windows.Forms.Binding("Text", Me, "IDPais", True))
        Me.FwiIdPais.DisabledBackColor = System.Drawing.Color.White
        Me.FwiIdPais.EntityName = "Pais"
        Me.FwiIdPais.Location = New System.Drawing.Point(463, 107)
        Me.FwiIdPais.Name = "FwiIdPais"
        Me.FwiIdPais.PrimaryDataFields = "IDPais"
        Me.FwiIdPais.SecondaryDataFields = "IDPais"
        Me.FwiIdPais.Size = New System.Drawing.Size(60, 23)
        Me.FwiIdPais.TabIndex = 12
        Me.FwiIdPais.ViewName = "tbMaestroPais"
        '
        'lblfwiPoblacion
        '
        Me.lblfwiPoblacion.Location = New System.Drawing.Point(281, 86)
        Me.lblfwiPoblacion.Name = "lblfwiPoblacion"
        Me.lblfwiPoblacion.Size = New System.Drawing.Size(61, 13)
        Me.lblfwiPoblacion.TabIndex = 132
        Me.lblfwiPoblacion.Tag = "IdRec=4413;"
        Me.lblfwiPoblacion.Text = "Población"
        '
        'fwiPoblacion
        '
        Me.TryDataBinding(fwiPoblacion, New System.Windows.Forms.Binding("Text", Me, "Poblacion", True))
        Me.fwiPoblacion.DisabledBackColor = System.Drawing.Color.White
        Me.fwiPoblacion.Location = New System.Drawing.Point(344, 82)
        Me.fwiPoblacion.Name = "fwiPoblacion"
        Me.fwiPoblacion.Size = New System.Drawing.Size(235, 21)
        Me.fwiPoblacion.TabIndex = 10
        '
        'lblfwiCodPostal
        '
        Me.lblfwiCodPostal.Location = New System.Drawing.Point(151, 86)
        Me.lblfwiCodPostal.Name = "lblfwiCodPostal"
        Me.lblfwiCodPostal.Size = New System.Drawing.Size(29, 13)
        Me.lblfwiCodPostal.TabIndex = 133
        Me.lblfwiCodPostal.Tag = "IdRec=4414;"
        Me.lblfwiCodPostal.Text = "C.P."
        '
        'fwiCodPostal
        '
        Me.TryDataBinding(fwiCodPostal, New System.Windows.Forms.Binding("Text", Me, "CodPostal", True))
        Me.fwiCodPostal.DisabledBackColor = System.Drawing.Color.White
        Me.fwiCodPostal.Location = New System.Drawing.Point(219, 82)
        Me.fwiCodPostal.Name = "fwiCodPostal"
        Me.fwiCodPostal.Size = New System.Drawing.Size(59, 21)
        Me.fwiCodPostal.TabIndex = 9
        '
        'lblfwiDir
        '
        Me.lblfwiDir.Location = New System.Drawing.Point(151, 61)
        Me.lblfwiDir.Name = "lblfwiDir"
        Me.lblfwiDir.Size = New System.Drawing.Size(60, 13)
        Me.lblfwiDir.TabIndex = 134
        Me.lblfwiDir.Tag = "IdRec=4410;"
        Me.lblfwiDir.Text = "Dirección"
        '
        'fwiDir
        '
        Me.TryDataBinding(fwiDir, New System.Windows.Forms.Binding("Text", Me, "Direccion", True))
        Me.fwiDir.DisabledBackColor = System.Drawing.Color.White
        Me.fwiDir.Location = New System.Drawing.Point(219, 57)
        Me.fwiDir.Name = "fwiDir"
        Me.fwiDir.Size = New System.Drawing.Size(360, 21)
        Me.fwiDir.TabIndex = 8
        '
        'FwiIDContador
        '
        Me.TryDataBinding(FwiIDContador, New System.Windows.Forms.Binding("Text", Me, "IDContador", True))
        Me.FwiIDContador.DisabledBackColor = System.Drawing.Color.White
        Me.FwiIDContador.Enabled = False
        Me.FwiIDContador.Location = New System.Drawing.Point(88, 65)
        Me.FwiIDContador.Name = "FwiIDContador"
        Me.FwiIDContador.Size = New System.Drawing.Size(53, 21)
        Me.FwiIDContador.TabIndex = 2
        '
        'Line5
        '
        Me.Line5.Location = New System.Drawing.Point(146, 134)
        Me.Line5.Name = "Line5"
        Me.Line5.Size = New System.Drawing.Size(597, 3)
        Me.Line5.TabIndex = 137
        '
        'Line8
        '
        Me.Line8.Location = New System.Drawing.Point(145, -3)
        Me.Line8.Name = "Line8"
        Me.Line8.Size = New System.Drawing.Size(2, 178)
        Me.Line8.TabIndex = 139
        '
        'fwiSuFecFactura
        '
        Me.TryDataBinding(fwiSuFecFactura, New System.Windows.Forms.Binding("BindableValue", Me, "SuFechaFactura", True))
        Me.fwiSuFecFactura.DisabledBackColor = System.Drawing.Color.White
        Me.fwiSuFecFactura.Location = New System.Drawing.Point(4, 149)
        Me.fwiSuFecFactura.Name = "fwiSuFecFactura"
        Me.fwiSuFecFactura.Size = New System.Drawing.Size(137, 21)
        Me.fwiSuFecFactura.TabIndex = 4
        '
        'fwiSuFactura
        '
        Me.TryDataBinding(fwiSuFactura, New System.Windows.Forms.Binding("Text", Me, "SuFactura", True))
        Me.fwiSuFactura.DisabledBackColor = System.Drawing.Color.White
        Me.fwiSuFactura.Location = New System.Drawing.Point(5, 107)
        Me.fwiSuFactura.Name = "fwiSuFactura"
        Me.fwiSuFactura.Size = New System.Drawing.Size(136, 21)
        Me.fwiSuFactura.TabIndex = 3
        '
        'fwiNFactura
        '
        Me.TryDataBinding(fwiNFactura, New System.Windows.Forms.Binding("Text", Me, "NFactura", True))
        Me.fwiNFactura.DisabledBackColor = System.Drawing.Color.White
        Me.fwiNFactura.Location = New System.Drawing.Point(4, 21)
        Me.fwiNFactura.Name = "fwiNFactura"
        Me.fwiNFactura.ReadOnly = True
        Me.fwiNFactura.Size = New System.Drawing.Size(137, 23)
        Me.fwiNFactura.TabIndex = 0
        '
        'fwiFecFactura
        '
        Me.TryDataBinding(fwiFecFactura, New System.Windows.Forms.Binding("BindableValue", Me, "FechaFactura", True))
        Me.fwiFecFactura.DisabledBackColor = System.Drawing.Color.White
        Me.fwiFecFactura.Location = New System.Drawing.Point(4, 65)
        Me.fwiFecFactura.Name = "fwiFecFactura"
        Me.fwiFecFactura.Size = New System.Drawing.Size(78, 21)
        Me.fwiFecFactura.TabIndex = 1
        '
        'lblfwiTotalIva
        '
        Me.lblfwiTotalIva.Location = New System.Drawing.Point(341, 150)
        Me.lblfwiTotalIva.Name = "lblfwiTotalIva"
        Me.lblfwiTotalIva.Size = New System.Drawing.Size(28, 13)
        Me.lblfwiTotalIva.TabIndex = 145
        Me.lblfwiTotalIva.Tag = "IdRec=5045;"
        Me.lblfwiTotalIva.Text = "IVA"
        '
        'fwiTotalIva
        '
        Me.TryDataBinding(fwiTotalIva, New System.Windows.Forms.Binding("Value", Me, "ImpIva", True))
        Me.fwiTotalIva.DisabledBackColor = System.Drawing.Color.White
        Me.fwiTotalIva.Enabled = False
        Me.fwiTotalIva.Location = New System.Drawing.Point(387, 146)
        Me.fwiTotalIva.Name = "fwiTotalIva"
        Me.fwiTotalIva.Size = New System.Drawing.Size(69, 21)
        Me.fwiTotalIva.TabIndex = 116
        '
        'lblfwiTotalBaseImp
        '
        Me.lblfwiTotalBaseImp.Location = New System.Drawing.Point(155, 149)
        Me.lblfwiTotalBaseImp.Name = "lblfwiTotalBaseImp"
        Me.lblfwiTotalBaseImp.Size = New System.Drawing.Size(96, 13)
        Me.lblfwiTotalBaseImp.TabIndex = 146
        Me.lblfwiTotalBaseImp.Tag = "IdRec=5044;"
        Me.lblfwiTotalBaseImp.Text = "Base Imponible"
        '
        'fwiTotalBaseImp
        '
        Me.TryDataBinding(fwiTotalBaseImp, New System.Windows.Forms.Binding("Value", Me, "BaseImponible", True))
        Me.fwiTotalBaseImp.DisabledBackColor = System.Drawing.Color.White
        Me.fwiTotalBaseImp.Enabled = False
        Me.fwiTotalBaseImp.Location = New System.Drawing.Point(255, 146)
        Me.fwiTotalBaseImp.Name = "fwiTotalBaseImp"
        Me.fwiTotalBaseImp.Size = New System.Drawing.Size(64, 21)
        Me.fwiTotalBaseImp.TabIndex = 115
        '
        'lblfwiTotal
        '
        Me.lblfwiTotal.Location = New System.Drawing.Point(465, 150)
        Me.lblfwiTotal.Name = "lblfwiTotal"
        Me.lblfwiTotal.Size = New System.Drawing.Size(34, 13)
        Me.lblfwiTotal.TabIndex = 147
        Me.lblfwiTotal.Tag = "IdRec=4664;"
        Me.lblfwiTotal.Text = "Total"
        '
        'fwiTotal
        '
        Me.TryDataBinding(fwiTotal, New System.Windows.Forms.Binding("Value", Me, "ImpTotal", True))
        Me.fwiTotal.DisabledBackColor = System.Drawing.Color.White
        Me.fwiTotal.Enabled = False
        Me.fwiTotal.Location = New System.Drawing.Point(506, 146)
        Me.fwiTotal.Name = "fwiTotal"
        Me.fwiTotal.Size = New System.Drawing.Size(70, 21)
        Me.fwiTotal.TabIndex = 114
        '
        'lblfwiCIF
        '
        Me.lblfwiCIF.Location = New System.Drawing.Point(151, 36)
        Me.lblfwiCIF.Name = "lblfwiCIF"
        Me.lblfwiCIF.Size = New System.Drawing.Size(37, 13)
        Me.lblfwiCIF.TabIndex = 148
        Me.lblfwiCIF.Tag = ""
        Me.lblfwiCIF.Text = "C.I.F."
        '
        'fwiCIF
        '
        Me.TryDataBinding(fwiCIF, New System.Windows.Forms.Binding("Text", Me, "CifProveedor", True))
        Me.fwiCIF.DisabledBackColor = System.Drawing.Color.White
        Me.fwiCIF.Location = New System.Drawing.Point(219, 32)
        Me.fwiCIF.Name = "fwiCIF"
        Me.fwiCIF.Size = New System.Drawing.Size(100, 21)
        Me.fwiCIF.TabIndex = 6
        '
        'lblfwiRazonSocial
        '
        Me.lblfwiRazonSocial.Location = New System.Drawing.Point(319, 36)
        Me.lblfwiRazonSocial.Name = "lblfwiRazonSocial"
        Me.lblfwiRazonSocial.Size = New System.Drawing.Size(80, 13)
        Me.lblfwiRazonSocial.TabIndex = 149
        Me.lblfwiRazonSocial.Tag = "IdRec=4426;"
        Me.lblfwiRazonSocial.Text = "Razón Social"
        '
        'fwiRazonSocial
        '
        Me.TryDataBinding(fwiRazonSocial, New System.Windows.Forms.Binding("Text", Me, "RazonSocial", True))
        Me.fwiRazonSocial.DisabledBackColor = System.Drawing.Color.White
        Me.fwiRazonSocial.Location = New System.Drawing.Point(401, 32)
        Me.fwiRazonSocial.Name = "fwiRazonSocial"
        Me.fwiRazonSocial.Size = New System.Drawing.Size(314, 21)
        Me.fwiRazonSocial.TabIndex = 7
        '
        'lblfwiTel
        '
        Me.lblfwiTel.Location = New System.Drawing.Point(585, 61)
        Me.lblfwiTel.Name = "lblfwiTel"
        Me.lblfwiTel.Size = New System.Drawing.Size(55, 13)
        Me.lblfwiTel.TabIndex = 150
        Me.lblfwiTel.Tag = "IdRec=4411;"
        Me.lblfwiTel.Text = "Teléfono"
        '
        'fwiTel
        '
        Me.TryDataBinding(fwiTel, New System.Windows.Forms.Binding("Text", Me, "Telefono", True))
        Me.fwiTel.DisabledBackColor = System.Drawing.Color.White
        Me.fwiTel.Enabled = False
        Me.fwiTel.Location = New System.Drawing.Point(648, 57)
        Me.fwiTel.Name = "fwiTel"
        Me.fwiTel.Size = New System.Drawing.Size(66, 21)
        Me.fwiTel.TabIndex = 113
        '
        'lblfwiFax
        '
        Me.lblfwiFax.Location = New System.Drawing.Point(585, 86)
        Me.lblfwiFax.Name = "lblfwiFax"
        Me.lblfwiFax.Size = New System.Drawing.Size(26, 13)
        Me.lblfwiFax.TabIndex = 151
        Me.lblfwiFax.Tag = "IdRec=4415;"
        Me.lblfwiFax.Text = "Fax"
        '
        'fwiFax
        '
        Me.TryDataBinding(fwiFax, New System.Windows.Forms.Binding("Text", Me, "Fax", True))
        Me.fwiFax.DisabledBackColor = System.Drawing.Color.White
        Me.fwiFax.Enabled = False
        Me.fwiFax.Location = New System.Drawing.Point(648, 82)
        Me.fwiFax.Name = "fwiFax"
        Me.fwiFax.Size = New System.Drawing.Size(66, 21)
        Me.fwiFax.TabIndex = 112
        '
        'lblFwiIDContador
        '
        Me.lblFwiIDContador.Location = New System.Drawing.Point(81, 48)
        Me.lblFwiIDContador.Name = "lblFwiIDContador"
        Me.lblFwiIDContador.Size = New System.Drawing.Size(60, 13)
        Me.lblFwiIDContador.TabIndex = 135
        Me.lblFwiIDContador.Text = "Contador"
        '
        'lblfwiNFactura
        '
        Me.lblfwiNFactura.Location = New System.Drawing.Point(4, 6)
        Me.lblfwiNFactura.Name = "lblfwiNFactura"
        Me.lblfwiNFactura.Size = New System.Drawing.Size(82, 13)
        Me.lblfwiNFactura.TabIndex = 143
        Me.lblfwiNFactura.Tag = "IdRec=4719;"
        Me.lblfwiNFactura.Text = "Núm. Factura"
        '
        'lblfwiSuFactura
        '
        Me.lblfwiSuFactura.Location = New System.Drawing.Point(5, 90)
        Me.lblfwiSuFactura.Name = "lblfwiSuFactura"
        Me.lblfwiSuFactura.Size = New System.Drawing.Size(67, 13)
        Me.lblfwiSuFactura.TabIndex = 142
        Me.lblfwiSuFactura.Tag = "IdRec=5072;"
        Me.lblfwiSuFactura.Text = "Su Factura"
        '
        'lblfwiSuFecFactura
        '
        Me.lblfwiSuFecFactura.Location = New System.Drawing.Point(4, 132)
        Me.lblfwiSuFecFactura.Name = "lblfwiSuFecFactura"
        Me.lblfwiSuFecFactura.Size = New System.Drawing.Size(104, 13)
        Me.lblfwiSuFecFactura.TabIndex = 141
        Me.lblfwiSuFecFactura.Tag = "IdRec=5073;"
        Me.lblfwiSuFecFactura.Text = "Su Fecha Factura"
        '
        'lblfwiFecFactura
        '
        Me.lblfwiFecFactura.Location = New System.Drawing.Point(4, 48)
        Me.lblfwiFecFactura.Name = "lblfwiFecFactura"
        Me.lblfwiFecFactura.Size = New System.Drawing.Size(60, 13)
        Me.lblfwiFecFactura.TabIndex = 144
        Me.lblfwiFecFactura.Text = "F. Factura"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.BlinkRate = 300
        Me.ErrorProvider1.ContainerControl = Me
        Me.ErrorProvider1.Icon = CType(resources.GetObject("ErrorProvider1.Icon"), System.Drawing.Icon)
        '
        'pnlLineas
        '
        Me.pnlLineas.Controls.Add(Me.TabFacturas)
        Me.pnlLineas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlLineas.Location = New System.Drawing.Point(0, 176)
        Me.pnlLineas.Name = "pnlLineas"
        Me.pnlLineas.Size = New System.Drawing.Size(720, 374)
        Me.pnlLineas.TabIndex = 2
        '
        'TabFacturas
        '
        Me.TabFacturas.BackColor = System.Drawing.Color.White
        Me.TabFacturas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabFacturas.Location = New System.Drawing.Point(0, 0)
        Me.TabFacturas.Name = "TabFacturas"
        Me.TabFacturas.Size = New System.Drawing.Size(720, 374)
        Me.TabFacturas.TabIndex = 1
        Me.TabFacturas.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.TabPageLineas, Me.TabPageBasesIVA, Me.TabPageVencimientos, Me.TabPageDatosEconomicos, Me.TabPageImporteMonedas, Me.TabPageTotales, Me.TabPageAnotaciones, Me.TabPageSeguimiento, Me.TabPageDeclaraciones})
        Me.TabFacturas.Text = "Seguimiento"
        Me.TabFacturas.UseThemes = True
        '
        'TabPageLineas
        '
        Me.TabPageLineas.Controls.Add(Me.jngLineaFactura)
        Me.TabPageLineas.Key = "Lineas"
        Me.TabPageLineas.Location = New System.Drawing.Point(1, 21)
        Me.TabPageLineas.Name = "TabPageLineas"
        Me.TabPageLineas.Size = New System.Drawing.Size(718, 352)
        Me.TabPageLineas.TabStop = True
        Me.TabPageLineas.Text = "Líneas de Factura"
        '
        'jngLineaFactura
        '
        Me.jngLineaFactura.AdvSearchColumns = New Solmicro.Expertis.Engine.UI.AdvSearchColumns(New Solmicro.Expertis.Engine.UI.AdvSearchColumn() {New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDTipoIva", "TipoIva", "IDTipoIva"), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("CContable", "PlanContable", "IDCContable"), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDCentroGestion", "CentroGestion", "IDCentroGestion"), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDUdMedida", "UdMedida", "IDUdMedida"), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDArticulo", "Articulo", "IDArticulo", New Solmicro.Expertis.Engine.UI.ASSelectedColumns(New Solmicro.Expertis.Engine.UI.ASSelectedColumn() {New Solmicro.Expertis.Engine.UI.ASSelectedColumn("DescArticulo", "DescArticulo")})), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("RefProveedor", "ArticuloProveedor", "RefProveedor", New Solmicro.Expertis.Engine.UI.ASSelectedColumns(New Solmicro.Expertis.Engine.UI.ASSelectedColumn() {New Solmicro.Expertis.Engine.UI.ASSelectedColumn("IDArticulo", "IDArticulo")})), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("NObra", "ObraCabecera", "NObra", New Solmicro.Expertis.Engine.UI.ASSelectedColumns(New Solmicro.Expertis.Engine.UI.ASSelectedColumn() {New Solmicro.Expertis.Engine.UI.ASSelectedColumn("IDObra", "IDObra")})), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("CodTrabajo", "ObraTrabajo", "CodTrabajo", New Solmicro.Expertis.Engine.UI.ASSelectedColumns(New Solmicro.Expertis.Engine.UI.ASSelectedColumn() {New Solmicro.Expertis.Engine.UI.ASSelectedColumn("IDTrabajo", "IDTrabajo")})), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("NROT", "MntoOT", "NROT", "vAdvOTsConPrevisto"), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDMntoOTPrev", "MntoOTPrevLinea", "IDMntoOTPrev"), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDInmueble", "InmueblesCabecera", "IDInmueble", New Solmicro.Expertis.Engine.UI.ASSelectedColumns(New Solmicro.Expertis.Engine.UI.ASSelectedColumn() {New Solmicro.Expertis.Engine.UI.ASSelectedColumn("DescInmueble", "DescInmueble")}))})
        jngLineaFactura_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("jngLineaFactura_DesignTimeLayout_Reference_0.Instance"), Object)
        jngLineaFactura_DesignTimeLayout_Reference_1.Instance = CType(resources.GetObject("jngLineaFactura_DesignTimeLayout_Reference_1.Instance"), Object)
        jngLineaFactura_DesignTimeLayout_Reference_2.Instance = CType(resources.GetObject("jngLineaFactura_DesignTimeLayout_Reference_2.Instance"), Object)
        jngLineaFactura_DesignTimeLayout_Reference_3.Instance = CType(resources.GetObject("jngLineaFactura_DesignTimeLayout_Reference_3.Instance"), Object)
        jngLineaFactura_DesignTimeLayout_Reference_4.Instance = CType(resources.GetObject("jngLineaFactura_DesignTimeLayout_Reference_4.Instance"), Object)
        jngLineaFactura_DesignTimeLayout_Reference_5.Instance = CType(resources.GetObject("jngLineaFactura_DesignTimeLayout_Reference_5.Instance"), Object)
        jngLineaFactura_DesignTimeLayout_Reference_6.Instance = CType(resources.GetObject("jngLineaFactura_DesignTimeLayout_Reference_6.Instance"), Object)
        jngLineaFactura_DesignTimeLayout_Reference_7.Instance = CType(resources.GetObject("jngLineaFactura_DesignTimeLayout_Reference_7.Instance"), Object)
        jngLineaFactura_DesignTimeLayout_Reference_8.Instance = CType(resources.GetObject("jngLineaFactura_DesignTimeLayout_Reference_8.Instance"), Object)
        jngLineaFactura_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {jngLineaFactura_DesignTimeLayout_Reference_0, jngLineaFactura_DesignTimeLayout_Reference_1, jngLineaFactura_DesignTimeLayout_Reference_2, jngLineaFactura_DesignTimeLayout_Reference_3, jngLineaFactura_DesignTimeLayout_Reference_4, jngLineaFactura_DesignTimeLayout_Reference_5, jngLineaFactura_DesignTimeLayout_Reference_6, jngLineaFactura_DesignTimeLayout_Reference_7, jngLineaFactura_DesignTimeLayout_Reference_8})
        jngLineaFactura_DesignTimeLayout.LayoutString = resources.GetString("jngLineaFactura_DesignTimeLayout.LayoutString")
        Me.jngLineaFactura.DesignTimeLayout = jngLineaFactura_DesignTimeLayout
        Me.jngLineaFactura.Dock = System.Windows.Forms.DockStyle.Fill
        Me.jngLineaFactura.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.jngLineaFactura.EntityName = "FacturaCompraLinea"
        Me.jngLineaFactura.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.jngLineaFactura.FrozenColumns = 5
        Me.jngLineaFactura.ImageList = Me.ImageList1
        Me.jngLineaFactura.KeyField = "IDLineaFactura"
        Me.jngLineaFactura.Location = New System.Drawing.Point(0, 0)
        Me.jngLineaFactura.Name = "jngLineaFactura"
        Me.jngLineaFactura.PrimaryDataFields = "IDFactura"
        Me.jngLineaFactura.SecondaryDataFields = "IDFactura"
        Me.jngLineaFactura.Size = New System.Drawing.Size(718, 352)
        Me.jngLineaFactura.TabIndex = 90
        Me.jngLineaFactura.ViewName = "VFrmMntoFacturaCompraLineas"
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "folder_edit.ico")
        Me.ImageList1.Images.SetKeyName(1, "folders.ico")
        Me.ImageList1.Images.SetKeyName(2, "find_again.ico")
        Me.ImageList1.Images.SetKeyName(3, "money2.ico")
        '
        'TabPageBasesIVA
        '
        Me.TabPageBasesIVA.Controls.Add(Me.jngBaseImponible)
        Me.TabPageBasesIVA.Controls.Add(Me.fwiIVAManual)
        Me.TabPageBasesIVA.Key = "IVA"
        Me.TabPageBasesIVA.Location = New System.Drawing.Point(1, 21)
        Me.TabPageBasesIVA.Name = "TabPageBasesIVA"
        Me.TabPageBasesIVA.Size = New System.Drawing.Size(718, 352)
        Me.TabPageBasesIVA.TabStop = True
        Me.TabPageBasesIVA.Text = "Base Imponible"
        Me.TabPageBasesIVA.Visible = False
        '
        'jngBaseImponible
        '
        Me.jngBaseImponible.AdvSearchColumns = New Solmicro.Expertis.Engine.UI.AdvSearchColumns(New Solmicro.Expertis.Engine.UI.AdvSearchColumn() {New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDPais", "Pais", "IDPais", New Solmicro.Expertis.Engine.UI.ASSelectedColumns(New Solmicro.Expertis.Engine.UI.ASSelectedColumn() {New Solmicro.Expertis.Engine.UI.ASSelectedColumn("DescPais", "DescPais")}))})
        Me.jngBaseImponible.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.jngBaseImponible.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.jngBaseImponible.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        jngBaseImponible_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("jngBaseImponible_DesignTimeLayout_Reference_0.Instance"), Object)
        jngBaseImponible_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {jngBaseImponible_DesignTimeLayout_Reference_0})
        jngBaseImponible_DesignTimeLayout.LayoutString = resources.GetString("jngBaseImponible_DesignTimeLayout.LayoutString")
        Me.jngBaseImponible.DesignTimeLayout = jngBaseImponible_DesignTimeLayout
        Me.jngBaseImponible.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.jngBaseImponible.EntityName = "FacturaCompraBaseImponible"
        Me.jngBaseImponible.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.jngBaseImponible.Location = New System.Drawing.Point(0, 0)
        Me.jngBaseImponible.Name = "jngBaseImponible"
        Me.jngBaseImponible.PrimaryDataFields = "IDFactura"
        Me.jngBaseImponible.SecondaryDataFields = "IDFactura"
        Me.jngBaseImponible.Size = New System.Drawing.Size(720, 322)
        Me.jngBaseImponible.TabIndex = 87
        Me.jngBaseImponible.Tag = ""
        Me.jngBaseImponible.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.jngBaseImponible.ViewName = "VFrmMntoFacturaCompraBasesImponibles"
        '
        'fwiIVAManual
        '
        Me.fwiIVAManual.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TryDataBinding(fwiIVAManual, New System.Windows.Forms.Binding("BindableValue", Me, "IVAManual", True))
        Me.fwiIVAManual.Location = New System.Drawing.Point(7, 327)
        Me.fwiIVAManual.Name = "fwiIVAManual"
        Me.fwiIVAManual.Size = New System.Drawing.Size(166, 19)
        Me.fwiIVAManual.TabIndex = 88
        Me.fwiIVAManual.Text = "I.V.A. Manual"
        '
        'TabPageVencimientos
        '
        Me.TabPageVencimientos.Controls.Add(Me.jngVencimientos)
        Me.TabPageVencimientos.Controls.Add(Me.fwiVencimientoManual)
        Me.TabPageVencimientos.Key = "Vencimientos"
        Me.TabPageVencimientos.Location = New System.Drawing.Point(1, 21)
        Me.TabPageVencimientos.Name = "TabPageVencimientos"
        Me.TabPageVencimientos.Size = New System.Drawing.Size(718, 352)
        Me.TabPageVencimientos.TabStop = True
        Me.TabPageVencimientos.Text = "Vencimientos"
        Me.TabPageVencimientos.Visible = False
        '
        'jngVencimientos
        '
        Me.jngVencimientos.AdvSearchColumns = New Solmicro.Expertis.Engine.UI.AdvSearchColumns(New Solmicro.Expertis.Engine.UI.AdvSearchColumn() {New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDFormaPago", "FormaPago", "IDFormaPago")})
        Me.jngVencimientos.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.jngVencimientos.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.jngVencimientos.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.jngVencimientos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        jngVencimientos_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("jngVencimientos_DesignTimeLayout_Reference_0.Instance"), Object)
        jngVencimientos_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {jngVencimientos_DesignTimeLayout_Reference_0})
        jngVencimientos_DesignTimeLayout.LayoutString = resources.GetString("jngVencimientos_DesignTimeLayout.LayoutString")
        Me.jngVencimientos.DesignTimeLayout = jngVencimientos_DesignTimeLayout
        Me.jngVencimientos.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.jngVencimientos.EntityName = "Pago"
        Me.jngVencimientos.Location = New System.Drawing.Point(0, 0)
        Me.jngVencimientos.Name = "jngVencimientos"
        Me.jngVencimientos.PrimaryDataFields = "IDFactura"
        Me.jngVencimientos.SecondaryDataFields = "IDFactura"
        Me.jngVencimientos.Size = New System.Drawing.Size(720, 326)
        Me.jngVencimientos.TabIndex = 84
        Me.jngVencimientos.Tag = "IdRec=5029:6267:4712:4805:4713:4758:4711:;"
        Me.jngVencimientos.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.jngVencimientos.ViewName = "VFrmMntoFacturaCompraPagos"
        '
        'fwiVencimientoManual
        '
        Me.fwiVencimientoManual.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TryDataBinding(fwiVencimientoManual, New System.Windows.Forms.Binding("BindableValue", Me, "VencimientosManuales", True))
        Me.fwiVencimientoManual.Location = New System.Drawing.Point(4, 328)
        Me.fwiVencimientoManual.Name = "fwiVencimientoManual"
        Me.fwiVencimientoManual.Size = New System.Drawing.Size(182, 19)
        Me.fwiVencimientoManual.TabIndex = 85
        Me.fwiVencimientoManual.Text = "Vencimiento Manual"
        '
        'TabPageDatosEconomicos
        '
        Me.TabPageDatosEconomicos.Controls.Add(Me.FraRetencion)
        Me.TabPageDatosEconomicos.Controls.Add(Me.WLFrame8)
        Me.TabPageDatosEconomicos.Controls.Add(Me.WLFrame6)
        Me.TabPageDatosEconomicos.Controls.Add(Me.WLFrame5)
        Me.TabPageDatosEconomicos.Key = "DatosEconomicos"
        Me.TabPageDatosEconomicos.Location = New System.Drawing.Point(1, 21)
        Me.TabPageDatosEconomicos.Name = "TabPageDatosEconomicos"
        Me.TabPageDatosEconomicos.Size = New System.Drawing.Size(718, 352)
        Me.TabPageDatosEconomicos.TabStop = True
        Me.TabPageDatosEconomicos.Text = "Datos Económicos"
        Me.TabPageDatosEconomicos.Visible = False
        '
        'FraRetencion
        '
        Me.FraRetencion.Controls.Add(Me.lblImpRetencion)
        Me.FraRetencion.Controls.Add(Me.txtImpRetencionGar)
        Me.FraRetencion.Controls.Add(Me.lblFechaRetencion)
        Me.FraRetencion.Controls.Add(Me.cbxFechaRetencion)
        Me.FraRetencion.Controls.Add(Me.lblRetencion)
        Me.FraRetencion.Controls.Add(Me.txtRetencion)
        Me.FraRetencion.Controls.Add(Me.lblTipoRetencion)
        Me.FraRetencion.Controls.Add(Me.cbxTipoRetencion)
        Me.FraRetencion.Location = New System.Drawing.Point(7, 204)
        Me.FraRetencion.Name = "FraRetencion"
        Me.FraRetencion.Size = New System.Drawing.Size(401, 74)
        Me.FraRetencion.TabIndex = 188
        Me.FraRetencion.TabStop = False
        Me.FraRetencion.Text = "Retención por garantía"
        '
        'lblImpRetencion
        '
        Me.lblImpRetencion.Location = New System.Drawing.Point(208, 46)
        Me.lblImpRetencion.Name = "lblImpRetencion"
        Me.lblImpRetencion.Size = New System.Drawing.Size(53, 13)
        Me.lblImpRetencion.TabIndex = 195
        Me.lblImpRetencion.Tag = ""
        Me.lblImpRetencion.Text = "Importe"
        '
        'txtImpRetencionGar
        '
        Me.TryDataBinding(txtImpRetencionGar, New System.Windows.Forms.Binding("Value", Me, "ImpRetencionGar", True))
        Me.txtImpRetencionGar.DecimalDigits = 5
        Me.txtImpRetencionGar.DisabledBackColor = System.Drawing.Color.White
        Me.txtImpRetencionGar.Enabled = False
        Me.txtImpRetencionGar.FormatString = "#,0.0####"
        Me.txtImpRetencionGar.Location = New System.Drawing.Point(265, 46)
        Me.txtImpRetencionGar.Name = "txtImpRetencionGar"
        Me.txtImpRetencionGar.Size = New System.Drawing.Size(119, 21)
        Me.txtImpRetencionGar.TabIndex = 23
        '
        'lblFechaRetencion
        '
        Me.lblFechaRetencion.Location = New System.Drawing.Point(9, 46)
        Me.lblFechaRetencion.Name = "lblFechaRetencion"
        Me.lblFechaRetencion.Size = New System.Drawing.Size(40, 13)
        Me.lblFechaRetencion.TabIndex = 193
        Me.lblFechaRetencion.Tag = ""
        Me.lblFechaRetencion.Text = "Fecha"
        '
        'cbxFechaRetencion
        '
        Me.TryDataBinding(cbxFechaRetencion, New System.Windows.Forms.Binding("BindableValue", Me, "FechaRetencion", True))
        Me.cbxFechaRetencion.DisabledBackColor = System.Drawing.Color.White
        Me.cbxFechaRetencion.Location = New System.Drawing.Point(56, 46)
        Me.cbxFechaRetencion.Name = "cbxFechaRetencion"
        Me.cbxFechaRetencion.Size = New System.Drawing.Size(105, 21)
        Me.cbxFechaRetencion.TabIndex = 21
        '
        'lblRetencion
        '
        Me.lblRetencion.AutoSize = False
        Me.lblRetencion.Location = New System.Drawing.Point(296, 21)
        Me.lblRetencion.Name = "lblRetencion"
        Me.lblRetencion.Size = New System.Drawing.Size(15, 17)
        Me.lblRetencion.TabIndex = 90
        Me.lblRetencion.Tag = ""
        Me.lblRetencion.Text = "%"
        '
        'txtRetencion
        '
        Me.TryDataBinding(txtRetencion, New System.Windows.Forms.Binding("Value", Me, "Retencion", True))
        Me.txtRetencion.DisabledBackColor = System.Drawing.Color.White
        Me.txtRetencion.Location = New System.Drawing.Point(320, 21)
        Me.txtRetencion.Name = "txtRetencion"
        Me.txtRetencion.Size = New System.Drawing.Size(64, 21)
        Me.txtRetencion.TabIndex = 22
        Me.txtRetencion.TabStop = False
        '
        'lblTipoRetencion
        '
        Me.lblTipoRetencion.Location = New System.Drawing.Point(9, 21)
        Me.lblTipoRetencion.Name = "lblTipoRetencion"
        Me.lblTipoRetencion.Size = New System.Drawing.Size(35, 13)
        Me.lblTipoRetencion.TabIndex = 89
        Me.lblTipoRetencion.Tag = ""
        Me.lblTipoRetencion.Text = "Tipo "
        '
        'cbxTipoRetencion
        '
        Me.TryDataBinding(cbxTipoRetencion, New System.Windows.Forms.Binding("Value", Me, "TipoRetencion", True))
        cbxTipoRetencion_DesignTimeLayout.LayoutString = resources.GetString("cbxTipoRetencion_DesignTimeLayout.LayoutString")
        Me.cbxTipoRetencion.DesignTimeLayout = cbxTipoRetencion_DesignTimeLayout
        Me.cbxTipoRetencion.DisabledBackColor = System.Drawing.Color.White
        Me.cbxTipoRetencion.DisplayMember = "Value"
        Me.cbxTipoRetencion.Location = New System.Drawing.Point(56, 21)
        Me.cbxTipoRetencion.Name = "cbxTipoRetencion"
        Me.cbxTipoRetencion.PrimaryDataFields = "Estado"
        Me.cbxTipoRetencion.SecondaryDataFields = "Value"
        Me.cbxTipoRetencion.SelectedIndex = -1
        Me.cbxTipoRetencion.SelectedItem = Nothing
        Me.cbxTipoRetencion.Size = New System.Drawing.Size(203, 21)
        Me.cbxTipoRetencion.TabIndex = 20
        '
        'WLFrame8
        '
        Me.WLFrame8.Controls.Add(Me.fwiCambioB)
        Me.WLFrame8.Controls.Add(Me.fwiCambioA)
        Me.WLFrame8.Controls.Add(Me.lblfwiCambioB)
        Me.WLFrame8.Controls.Add(Me.lblfwiCambioA)
        Me.WLFrame8.Controls.Add(Me.fwiDescMonedaB)
        Me.WLFrame8.Controls.Add(Me.fwiDescMonedaA)
        Me.WLFrame8.Location = New System.Drawing.Point(413, 92)
        Me.WLFrame8.Name = "WLFrame8"
        Me.WLFrame8.Size = New System.Drawing.Size(302, 106)
        Me.WLFrame8.TabIndex = 82
        Me.WLFrame8.TabStop = False
        Me.WLFrame8.Tag = "IdRec=5082;"
        Me.WLFrame8.Text = "Monedas Internas"
        '
        'fwiCambioB
        '
        Me.TryDataBinding(fwiCambioB, New System.Windows.Forms.Binding("Value", Me, "CambioB", True))
        Me.fwiCambioB.DecimalDigits = 5
        Me.fwiCambioB.DisabledBackColor = System.Drawing.Color.White
        Me.fwiCambioB.Enabled = False
        Me.fwiCambioB.FormatString = "#,0.0####"
        Me.fwiCambioB.Location = New System.Drawing.Point(192, 67)
        Me.fwiCambioB.Name = "fwiCambioB"
        Me.fwiCambioB.Size = New System.Drawing.Size(88, 21)
        Me.fwiCambioB.TabIndex = 87
        '
        'fwiCambioA
        '
        Me.TryDataBinding(fwiCambioA, New System.Windows.Forms.Binding("Value", Me, "CambioA", True))
        Me.fwiCambioA.DecimalDigits = 5
        Me.fwiCambioA.DisabledBackColor = System.Drawing.Color.White
        Me.fwiCambioA.Enabled = False
        Me.fwiCambioA.FormatString = "#,0.0####"
        Me.fwiCambioA.Location = New System.Drawing.Point(192, 32)
        Me.fwiCambioA.Name = "fwiCambioA"
        Me.fwiCambioA.Size = New System.Drawing.Size(88, 21)
        Me.fwiCambioA.TabIndex = 86
        '
        'lblfwiCambioB
        '
        Me.lblfwiCambioB.Location = New System.Drawing.Point(114, 67)
        Me.lblfwiCambioB.Name = "lblfwiCambioB"
        Me.lblfwiCambioB.Size = New System.Drawing.Size(63, 13)
        Me.lblfwiCambioB.TabIndex = 0
        Me.lblfwiCambioB.Tag = "IdRec=4399;"
        Me.lblfwiCambioB.Text = "Cambio B"
        '
        'lblfwiCambioA
        '
        Me.lblfwiCambioA.Location = New System.Drawing.Point(114, 32)
        Me.lblfwiCambioA.Name = "lblfwiCambioA"
        Me.lblfwiCambioA.Size = New System.Drawing.Size(63, 13)
        Me.lblfwiCambioA.TabIndex = 76
        Me.lblfwiCambioA.Tag = "IdRec=4395;"
        Me.lblfwiCambioA.Text = "Cambio A"
        '
        'fwiDescMonedaB
        '
        Me.fwiDescMonedaB.DisabledBackColor = System.Drawing.Color.White
        Me.fwiDescMonedaB.Enabled = False
        Me.fwiDescMonedaB.Location = New System.Drawing.Point(12, 67)
        Me.fwiDescMonedaB.Name = "fwiDescMonedaB"
        Me.fwiDescMonedaB.Size = New System.Drawing.Size(88, 21)
        Me.fwiDescMonedaB.TabIndex = 77
        '
        'fwiDescMonedaA
        '
        Me.fwiDescMonedaA.DisabledBackColor = System.Drawing.Color.White
        Me.fwiDescMonedaA.Enabled = False
        Me.fwiDescMonedaA.Location = New System.Drawing.Point(12, 32)
        Me.fwiDescMonedaA.Name = "fwiDescMonedaA"
        Me.fwiDescMonedaA.Size = New System.Drawing.Size(88, 21)
        Me.fwiDescMonedaA.TabIndex = 78
        '
        'WLFrame6
        '
        Me.WLFrame6.Controls.Add(Me.lblfwiIdMoneda)
        Me.WLFrame6.Controls.Add(Me.lblcfwiIdMoneda)
        Me.WLFrame6.Controls.Add(Me.fwiIdMoneda)
        Me.WLFrame6.Location = New System.Drawing.Point(413, 16)
        Me.WLFrame6.Name = "WLFrame6"
        Me.WLFrame6.Size = New System.Drawing.Size(302, 56)
        Me.WLFrame6.TabIndex = 81
        Me.WLFrame6.TabStop = False
        Me.WLFrame6.Tag = "IdRec=5084;"
        Me.WLFrame6.Text = "Moneda Factura"
        '
        'lblfwiIdMoneda
        '
        Me.lblfwiIdMoneda.Location = New System.Drawing.Point(9, 21)
        Me.lblfwiIdMoneda.Name = "lblfwiIdMoneda"
        Me.lblfwiIdMoneda.Size = New System.Drawing.Size(51, 13)
        Me.lblfwiIdMoneda.TabIndex = 0
        Me.lblfwiIdMoneda.Tag = "IdRec=4398;"
        Me.lblfwiIdMoneda.Text = "Moneda"
        '
        'lblcfwiIdMoneda
        '
        Me.TryDataBinding(lblcfwiIdMoneda, New System.Windows.Forms.Binding("Text", Me.fwiIdMoneda, "DescMoneda", True))
        Me.lblcfwiIdMoneda.Location = New System.Drawing.Point(118, 21)
        Me.lblcfwiIdMoneda.Name = "lblcfwiIdMoneda"
        Me.lblcfwiIdMoneda.Size = New System.Drawing.Size(167, 21)
        Me.lblcfwiIdMoneda.TabIndex = 1
        '
        'fwiIdMoneda
        '
        Me.TryDataBinding(fwiIdMoneda, New System.Windows.Forms.Binding("Text", Me, "IDMoneda", True))
        Me.fwiIdMoneda.DisabledBackColor = System.Drawing.Color.White
        Me.fwiIdMoneda.EntityName = "Moneda"
        Me.fwiIdMoneda.Location = New System.Drawing.Point(63, 21)
        Me.fwiIdMoneda.Name = "fwiIdMoneda"
        Me.fwiIdMoneda.PrimaryDataFields = "IDMoneda"
        Me.fwiIdMoneda.SecondaryDataFields = "IDMoneda"
        Me.fwiIdMoneda.Size = New System.Drawing.Size(53, 23)
        Me.fwiIdMoneda.TabIndex = 20
        Me.fwiIdMoneda.ViewName = "tbMaestroMoneda"
        '
        'WLFrame5
        '
        Me.WLFrame5.Controls.Add(Me.lblfwiTipoAsiento)
        Me.WLFrame5.Controls.Add(Me.fwiTipoAsiento)
        Me.WLFrame5.Controls.Add(Me.lblfwiFormaPago)
        Me.WLFrame5.Controls.Add(Me.lblcfwiFormaPago)
        Me.WLFrame5.Controls.Add(Me.fwiFormaPago)
        Me.WLFrame5.Controls.Add(Me.lblfwiBancoPropio)
        Me.WLFrame5.Controls.Add(Me.lblcfwiBancoPropio)
        Me.WLFrame5.Controls.Add(Me.fwiBancoPropio)
        Me.WLFrame5.Controls.Add(Me.lblfwiIdProvBanco)
        Me.WLFrame5.Controls.Add(Me.lblcfwiIdProvBanco)
        Me.WLFrame5.Controls.Add(Me.fwiIdProvBanco)
        Me.WLFrame5.Controls.Add(Me.lblfwiIdDiaPago)
        Me.WLFrame5.Controls.Add(Me.lblcfwiIdDiaPago)
        Me.WLFrame5.Controls.Add(Me.fwiIdDiaPago)
        Me.WLFrame5.Controls.Add(Me.lblfwiCondPago)
        Me.WLFrame5.Controls.Add(Me.lblcfwiCondPago)
        Me.WLFrame5.Controls.Add(Me.fwiCondPago)
        Me.WLFrame5.Location = New System.Drawing.Point(7, 16)
        Me.WLFrame5.Name = "WLFrame5"
        Me.WLFrame5.Size = New System.Drawing.Size(401, 182)
        Me.WLFrame5.TabIndex = 80
        Me.WLFrame5.TabStop = False
        Me.WLFrame5.Tag = "IdRec=4420;"
        Me.WLFrame5.Text = "Condiciones económicas"
        '
        'lblfwiTipoAsiento
        '
        Me.lblfwiTipoAsiento.Location = New System.Drawing.Point(9, 146)
        Me.lblfwiTipoAsiento.Name = "lblfwiTipoAsiento"
        Me.lblfwiTipoAsiento.Size = New System.Drawing.Size(77, 13)
        Me.lblfwiTipoAsiento.TabIndex = 0
        Me.lblfwiTipoAsiento.Tag = "IdRec=4594;"
        Me.lblfwiTipoAsiento.Text = "Tipo Asiento"
        '
        'fwiTipoAsiento
        '
        Me.TryDataBinding(fwiTipoAsiento, New System.Windows.Forms.Binding("Value", Me, "IDTipoAsiento", True))
        fwiTipoAsiento_DesignTimeLayout.LayoutString = resources.GetString("fwiTipoAsiento_DesignTimeLayout.LayoutString")
        Me.fwiTipoAsiento.DesignTimeLayout = fwiTipoAsiento_DesignTimeLayout
        Me.fwiTipoAsiento.DisabledBackColor = System.Drawing.Color.White
        Me.fwiTipoAsiento.Location = New System.Drawing.Point(114, 146)
        Me.fwiTipoAsiento.Name = "fwiTipoAsiento"
        Me.fwiTipoAsiento.PrimaryDataFields = "IDTipoAsiento"
        Me.fwiTipoAsiento.SecondaryDataFields = "Value"
        Me.fwiTipoAsiento.SelectedIndex = -1
        Me.fwiTipoAsiento.SelectedItem = Nothing
        Me.fwiTipoAsiento.Size = New System.Drawing.Size(270, 21)
        Me.fwiTipoAsiento.TabIndex = 19
        '
        'lblfwiFormaPago
        '
        Me.lblfwiFormaPago.Location = New System.Drawing.Point(9, 21)
        Me.lblfwiFormaPago.Name = "lblfwiFormaPago"
        Me.lblfwiFormaPago.Size = New System.Drawing.Size(47, 13)
        Me.lblfwiFormaPago.TabIndex = 20
        Me.lblfwiFormaPago.Tag = "IdRec=4397;"
        Me.lblfwiFormaPago.Text = "F. Pago"
        '
        'lblcfwiFormaPago
        '
        Me.TryDataBinding(lblcfwiFormaPago, New System.Windows.Forms.Binding("Text", Me.fwiFormaPago, "DescFormaPago", True))
        Me.lblcfwiFormaPago.Location = New System.Drawing.Point(171, 21)
        Me.lblcfwiFormaPago.Name = "lblcfwiFormaPago"
        Me.lblcfwiFormaPago.Size = New System.Drawing.Size(213, 21)
        Me.lblcfwiFormaPago.TabIndex = 21
        '
        'fwiFormaPago
        '
        Me.TryDataBinding(fwiFormaPago, New System.Windows.Forms.Binding("Text", Me, "IDFormaPago", True))
        Me.fwiFormaPago.DisabledBackColor = System.Drawing.Color.White
        Me.fwiFormaPago.EntityName = "FormaPago"
        Me.fwiFormaPago.Location = New System.Drawing.Point(114, 21)
        Me.fwiFormaPago.Name = "fwiFormaPago"
        Me.fwiFormaPago.PrimaryDataFields = "IDFormaPago"
        Me.fwiFormaPago.SecondaryDataFields = "IDFormaPago"
        Me.fwiFormaPago.Size = New System.Drawing.Size(56, 23)
        Me.fwiFormaPago.TabIndex = 14
        Me.fwiFormaPago.ViewName = "tbMaestroFormaPago"
        '
        'lblfwiBancoPropio
        '
        Me.lblfwiBancoPropio.Location = New System.Drawing.Point(9, 121)
        Me.lblfwiBancoPropio.Name = "lblfwiBancoPropio"
        Me.lblfwiBancoPropio.Size = New System.Drawing.Size(82, 13)
        Me.lblfwiBancoPropio.TabIndex = 22
        Me.lblfwiBancoPropio.Tag = "IdRec=4613;"
        Me.lblfwiBancoPropio.Text = "Banco Propio"
        '
        'lblcfwiBancoPropio
        '
        Me.TryDataBinding(lblcfwiBancoPropio, New System.Windows.Forms.Binding("Text", Me.fwiBancoPropio, "DescBancoPropio", True))
        Me.lblcfwiBancoPropio.Location = New System.Drawing.Point(171, 121)
        Me.lblcfwiBancoPropio.Name = "lblcfwiBancoPropio"
        Me.lblcfwiBancoPropio.Size = New System.Drawing.Size(213, 21)
        Me.lblcfwiBancoPropio.TabIndex = 23
        '
        'fwiBancoPropio
        '
        Me.TryDataBinding(fwiBancoPropio, New System.Windows.Forms.Binding("Text", Me, "IDBancoPropio", True))
        Me.fwiBancoPropio.DisabledBackColor = System.Drawing.Color.White
        Me.fwiBancoPropio.EntityName = "BancoPropio"
        Me.fwiBancoPropio.Location = New System.Drawing.Point(114, 121)
        Me.fwiBancoPropio.Name = "fwiBancoPropio"
        Me.fwiBancoPropio.PrimaryDataFields = "IDBancoPropio"
        Me.fwiBancoPropio.SecondaryDataFields = "IDBancoPropio"
        Me.fwiBancoPropio.Size = New System.Drawing.Size(56, 23)
        Me.fwiBancoPropio.TabIndex = 18
        Me.fwiBancoPropio.ViewName = "tbMaestroBancoPropio"
        '
        'lblfwiIdProvBanco
        '
        Me.lblfwiIdProvBanco.Location = New System.Drawing.Point(9, 96)
        Me.lblfwiIdProvBanco.Name = "lblfwiIdProvBanco"
        Me.lblfwiIdProvBanco.Size = New System.Drawing.Size(105, 13)
        Me.lblfwiIdProvBanco.TabIndex = 24
        Me.lblfwiIdProvBanco.Tag = "IdRec=6226;"
        Me.lblfwiIdProvBanco.Text = "Proveedor Banco"
        '
        'lblcfwiIdProvBanco
        '
        Me.TryDataBinding(lblcfwiIdProvBanco, New System.Windows.Forms.Binding("Text", Me, "DescBanco", True))
        Me.lblcfwiIdProvBanco.Location = New System.Drawing.Point(171, 96)
        Me.lblcfwiIdProvBanco.Name = "lblcfwiIdProvBanco"
        Me.lblcfwiIdProvBanco.Size = New System.Drawing.Size(213, 21)
        Me.lblcfwiIdProvBanco.TabIndex = 25
        '
        'fwiIdProvBanco
        '
        Me.TryDataBinding(fwiIdProvBanco, New System.Windows.Forms.Binding("Value", Me, "IDProveedorBanco", True))
        Me.fwiIdProvBanco.DisabledBackColor = System.Drawing.Color.White
        Me.fwiIdProvBanco.DisplayField = "IDProveedorBanco"
        Me.fwiIdProvBanco.EntityName = "ProveedorBanco"
        Me.fwiIdProvBanco.Location = New System.Drawing.Point(114, 96)
        Me.fwiIdProvBanco.Name = "fwiIdProvBanco"
        Me.fwiIdProvBanco.PrimaryDataFields = "IDProveedorBanco"
        Me.fwiIdProvBanco.SecondaryDataFields = "IDProveedorBanco"
        Me.fwiIdProvBanco.Size = New System.Drawing.Size(56, 23)
        Me.fwiIdProvBanco.TabIndex = 17
        Me.fwiIdProvBanco.ViewName = "tbProveedorBanco"
        '
        'lblfwiIdDiaPago
        '
        Me.lblfwiIdDiaPago.Location = New System.Drawing.Point(9, 71)
        Me.lblfwiIdDiaPago.Name = "lblfwiIdDiaPago"
        Me.lblfwiIdDiaPago.Size = New System.Drawing.Size(58, 13)
        Me.lblfwiIdDiaPago.TabIndex = 26
        Me.lblfwiIdDiaPago.Tag = "IdRec=4681;"
        Me.lblfwiIdDiaPago.Text = "Día Pago"
        '
        'lblcfwiIdDiaPago
        '
        Me.TryDataBinding(lblcfwiIdDiaPago, New System.Windows.Forms.Binding("Text", Me.fwiIdDiaPago, "DescDiaPago", True))
        Me.lblcfwiIdDiaPago.Location = New System.Drawing.Point(171, 71)
        Me.lblcfwiIdDiaPago.Name = "lblcfwiIdDiaPago"
        Me.lblcfwiIdDiaPago.Size = New System.Drawing.Size(213, 21)
        Me.lblcfwiIdDiaPago.TabIndex = 27
        '
        'fwiIdDiaPago
        '
        Me.TryDataBinding(fwiIdDiaPago, New System.Windows.Forms.Binding("Text", Me, "IDDiaPago", True))
        Me.fwiIdDiaPago.DisabledBackColor = System.Drawing.Color.White
        Me.fwiIdDiaPago.EntityName = "DiaPago"
        Me.fwiIdDiaPago.Location = New System.Drawing.Point(114, 71)
        Me.fwiIdDiaPago.Name = "fwiIdDiaPago"
        Me.fwiIdDiaPago.PrimaryDataFields = "IDDiaPago"
        Me.fwiIdDiaPago.SecondaryDataFields = "IDDiaPago"
        Me.fwiIdDiaPago.Size = New System.Drawing.Size(56, 23)
        Me.fwiIdDiaPago.TabIndex = 16
        Me.fwiIdDiaPago.ViewName = "tbMaestroDiaPago"
        '
        'lblfwiCondPago
        '
        Me.lblfwiCondPago.Location = New System.Drawing.Point(9, 46)
        Me.lblfwiCondPago.Name = "lblfwiCondPago"
        Me.lblfwiCondPago.Size = New System.Drawing.Size(52, 13)
        Me.lblfwiCondPago.TabIndex = 28
        Me.lblfwiCondPago.Tag = "IdRec=4396;"
        Me.lblfwiCondPago.Text = "C. Pago"
        '
        'lblcfwiCondPago
        '
        Me.TryDataBinding(lblcfwiCondPago, New System.Windows.Forms.Binding("Text", Me.fwiCondPago, "DescCondicionPago", True))
        Me.lblcfwiCondPago.Location = New System.Drawing.Point(171, 46)
        Me.lblcfwiCondPago.Name = "lblcfwiCondPago"
        Me.lblcfwiCondPago.Size = New System.Drawing.Size(213, 21)
        Me.lblcfwiCondPago.TabIndex = 29
        '
        'fwiCondPago
        '
        Me.TryDataBinding(fwiCondPago, New System.Windows.Forms.Binding("Text", Me, "IDCondicionPago", True))
        Me.fwiCondPago.DisabledBackColor = System.Drawing.Color.White
        Me.fwiCondPago.EntityName = "CondicionPago"
        Me.fwiCondPago.Location = New System.Drawing.Point(114, 46)
        Me.fwiCondPago.Name = "fwiCondPago"
        Me.fwiCondPago.PrimaryDataFields = "IDCondicionPago"
        Me.fwiCondPago.SecondaryDataFields = "IDCondicionPago"
        Me.fwiCondPago.Size = New System.Drawing.Size(56, 23)
        Me.fwiCondPago.TabIndex = 15
        Me.fwiCondPago.ViewName = "tbMaestroCondicionPago"
        '
        'TabPageImporteMonedas
        '
        Me.TabPageImporteMonedas.Controls.Add(Me.Line3)
        Me.TabPageImporteMonedas.Controls.Add(Me.fwiMonedaB)
        Me.TabPageImporteMonedas.Controls.Add(Me.fwiMonedaA)
        Me.TabPageImporteMonedas.Controls.Add(Me.Line1)
        Me.TabPageImporteMonedas.Controls.Add(Me.Line18)
        Me.TabPageImporteMonedas.Controls.Add(Me.Line15)
        Me.TabPageImporteMonedas.Controls.Add(Me.Line19)
        Me.TabPageImporteMonedas.Controls.Add(Me.WLFrame9)
        Me.TabPageImporteMonedas.Key = "ImporteMonedas"
        Me.TabPageImporteMonedas.Location = New System.Drawing.Point(1, 21)
        Me.TabPageImporteMonedas.Name = "TabPageImporteMonedas"
        Me.TabPageImporteMonedas.Size = New System.Drawing.Size(718, 352)
        Me.TabPageImporteMonedas.TabStop = True
        Me.TabPageImporteMonedas.Text = "Importe Monedas"
        Me.TabPageImporteMonedas.Visible = False
        '
        'Line3
        '
        Me.Line3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.Line3.Location = New System.Drawing.Point(352, -1)
        Me.Line3.Name = "Line3"
        Me.Line3.Size = New System.Drawing.Size(3, 353)
        Me.Line3.TabIndex = 0
        '
        'fwiMonedaB
        '
        Me.fwiMonedaB.DisabledBackColor = System.Drawing.Color.White
        Me.fwiMonedaB.Enabled = False
        Me.fwiMonedaB.Location = New System.Drawing.Point(448, 0)
        Me.fwiMonedaB.Name = "fwiMonedaB"
        Me.fwiMonedaB.Size = New System.Drawing.Size(109, 21)
        Me.fwiMonedaB.TabIndex = 72
        Me.fwiMonedaB.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        '
        'fwiMonedaA
        '
        Me.fwiMonedaA.DisabledBackColor = System.Drawing.Color.White
        Me.fwiMonedaA.Enabled = False
        Me.fwiMonedaA.Location = New System.Drawing.Point(100, 0)
        Me.fwiMonedaA.Name = "fwiMonedaA"
        Me.fwiMonedaA.Size = New System.Drawing.Size(109, 21)
        Me.fwiMonedaA.TabIndex = 73
        Me.fwiMonedaA.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        '
        'Line1
        '
        Me.Line1.Location = New System.Drawing.Point(408, 97)
        Me.Line1.Name = "Line1"
        Me.Line1.Size = New System.Drawing.Size(245, 2)
        Me.Line1.TabIndex = 74
        '
        'Line18
        '
        Me.Line18.Location = New System.Drawing.Point(36, 200)
        Me.Line18.Name = "Line18"
        Me.Line18.Size = New System.Drawing.Size(245, 2)
        Me.Line18.TabIndex = 76
        '
        'Line15
        '
        Me.Line15.Location = New System.Drawing.Point(36, 96)
        Me.Line15.Name = "Line15"
        Me.Line15.Size = New System.Drawing.Size(245, 2)
        Me.Line15.TabIndex = 77
        '
        'Line19
        '
        Me.Line19.Location = New System.Drawing.Point(408, 203)
        Me.Line19.Name = "Line19"
        Me.Line19.Size = New System.Drawing.Size(245, 2)
        Me.Line19.TabIndex = 78
        '
        'WLFrame9
        '
        Me.WLFrame9.Controls.Add(Me.lblfwiImpLineasNormalesB)
        Me.WLFrame9.Controls.Add(Me.fwiImpLineasNormalesB)
        Me.WLFrame9.Controls.Add(Me.lblfwiImpLineasEspecialesB)
        Me.WLFrame9.Controls.Add(Me.fwiImpLineasEspecialesB)
        Me.WLFrame9.Controls.Add(Me.lblfwiImpLineasNormalesA)
        Me.WLFrame9.Controls.Add(Me.fwiImpLineasNormalesA)
        Me.WLFrame9.Controls.Add(Me.lblfwiImpLineasEspecialesA)
        Me.WLFrame9.Controls.Add(Me.fwiImpLineasEspecialesA)
        Me.WLFrame9.Controls.Add(Me.lblfwiImpRecFinanB)
        Me.WLFrame9.Controls.Add(Me.fwiImpRecFinanB)
        Me.WLFrame9.Controls.Add(Me.lblfwiImpRecFinanA)
        Me.WLFrame9.Controls.Add(Me.fwiImpRecFinanA)
        Me.WLFrame9.Controls.Add(Me.lblfwiImpReA)
        Me.WLFrame9.Controls.Add(Me.fwiImpReA)
        Me.WLFrame9.Controls.Add(Me.lblfwiRetencionA)
        Me.WLFrame9.Controls.Add(Me.fwiRetencionA)
        Me.WLFrame9.Controls.Add(Me.lblfwiIntrastat)
        Me.WLFrame9.Controls.Add(Me.fwiIntrastatB)
        Me.WLFrame9.Controls.Add(Me.lblfwiIntrastatA)
        Me.WLFrame9.Controls.Add(Me.fwiIntrastatA)
        Me.WLFrame9.Controls.Add(Me.lblfwiBaseImpB)
        Me.WLFrame9.Controls.Add(Me.fwiBaseImpB)
        Me.WLFrame9.Controls.Add(Me.lblfwiBaseImpA)
        Me.WLFrame9.Controls.Add(Me.fwiBaseImpA)
        Me.WLFrame9.Controls.Add(Me.lblfwiImpReB)
        Me.WLFrame9.Controls.Add(Me.fwiImpReB)
        Me.WLFrame9.Controls.Add(Me.lblfwiImpRetencionB)
        Me.WLFrame9.Controls.Add(Me.fwiImpRetencionB)
        Me.WLFrame9.Controls.Add(Me.lblfwiImpTotalB)
        Me.WLFrame9.Controls.Add(Me.fwiImpTotalB)
        Me.WLFrame9.Controls.Add(Me.lblfwiImpTotalA)
        Me.WLFrame9.Controls.Add(Me.fwiImpTotalA)
        Me.WLFrame9.Controls.Add(Me.lblfwiImpIVAB)
        Me.WLFrame9.Controls.Add(Me.fwiImpIVAB)
        Me.WLFrame9.Controls.Add(Me.lblfwiImpIVAA)
        Me.WLFrame9.Controls.Add(Me.fwiImpIVAA)
        Me.WLFrame9.Controls.Add(Me.lblfwiImpLineasA)
        Me.WLFrame9.Controls.Add(Me.fwiImpLineasA)
        Me.WLFrame9.Controls.Add(Me.lblfwiImpLineasB)
        Me.WLFrame9.Controls.Add(Me.fwiImpLineasB)
        Me.WLFrame9.Controls.Add(Me.Line6)
        Me.WLFrame9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WLFrame9.Location = New System.Drawing.Point(0, 0)
        Me.WLFrame9.Name = "WLFrame9"
        Me.WLFrame9.Size = New System.Drawing.Size(718, 352)
        Me.WLFrame9.TabIndex = 92
        Me.WLFrame9.TabStop = False
        Me.WLFrame9.Tag = "IdRec=0;"
        '
        'lblfwiImpLineasNormalesB
        '
        Me.lblfwiImpLineasNormalesB.Location = New System.Drawing.Point(408, 24)
        Me.lblfwiImpLineasNormalesB.Name = "lblfwiImpLineasNormalesB"
        Me.lblfwiImpLineasNormalesB.Size = New System.Drawing.Size(101, 13)
        Me.lblfwiImpLineasNormalesB.TabIndex = 0
        Me.lblfwiImpLineasNormalesB.Text = "Líneas Normales"
        '
        'fwiImpLineasNormalesB
        '
        Me.fwiImpLineasNormalesB.DisabledBackColor = System.Drawing.Color.White
        Me.fwiImpLineasNormalesB.Enabled = False
        Me.fwiImpLineasNormalesB.Location = New System.Drawing.Point(520, 24)
        Me.fwiImpLineasNormalesB.Name = "fwiImpLineasNormalesB"
        Me.fwiImpLineasNormalesB.Size = New System.Drawing.Size(119, 21)
        Me.fwiImpLineasNormalesB.TabIndex = 109
        '
        'lblfwiImpLineasEspecialesB
        '
        Me.lblfwiImpLineasEspecialesB.Location = New System.Drawing.Point(408, 48)
        Me.lblfwiImpLineasEspecialesB.Name = "lblfwiImpLineasEspecialesB"
        Me.lblfwiImpLineasEspecialesB.Size = New System.Drawing.Size(106, 13)
        Me.lblfwiImpLineasEspecialesB.TabIndex = 110
        Me.lblfwiImpLineasEspecialesB.Text = "Líneas Especiales"
        '
        'fwiImpLineasEspecialesB
        '
        Me.fwiImpLineasEspecialesB.DisabledBackColor = System.Drawing.Color.White
        Me.fwiImpLineasEspecialesB.Enabled = False
        Me.fwiImpLineasEspecialesB.Location = New System.Drawing.Point(520, 48)
        Me.fwiImpLineasEspecialesB.Name = "fwiImpLineasEspecialesB"
        Me.fwiImpLineasEspecialesB.Size = New System.Drawing.Size(119, 21)
        Me.fwiImpLineasEspecialesB.TabIndex = 108
        '
        'lblfwiImpLineasNormalesA
        '
        Me.lblfwiImpLineasNormalesA.Location = New System.Drawing.Point(42, 24)
        Me.lblfwiImpLineasNormalesA.Name = "lblfwiImpLineasNormalesA"
        Me.lblfwiImpLineasNormalesA.Size = New System.Drawing.Size(101, 13)
        Me.lblfwiImpLineasNormalesA.TabIndex = 111
        Me.lblfwiImpLineasNormalesA.Text = "Líneas Normales"
        '
        'fwiImpLineasNormalesA
        '
        Me.fwiImpLineasNormalesA.DisabledBackColor = System.Drawing.Color.White
        Me.fwiImpLineasNormalesA.Enabled = False
        Me.fwiImpLineasNormalesA.Location = New System.Drawing.Point(149, 24)
        Me.fwiImpLineasNormalesA.Name = "fwiImpLineasNormalesA"
        Me.fwiImpLineasNormalesA.Size = New System.Drawing.Size(119, 21)
        Me.fwiImpLineasNormalesA.TabIndex = 107
        '
        'lblfwiImpLineasEspecialesA
        '
        Me.lblfwiImpLineasEspecialesA.Location = New System.Drawing.Point(42, 48)
        Me.lblfwiImpLineasEspecialesA.Name = "lblfwiImpLineasEspecialesA"
        Me.lblfwiImpLineasEspecialesA.Size = New System.Drawing.Size(106, 13)
        Me.lblfwiImpLineasEspecialesA.TabIndex = 112
        Me.lblfwiImpLineasEspecialesA.Text = "Líneas Especiales"
        '
        'fwiImpLineasEspecialesA
        '
        Me.fwiImpLineasEspecialesA.DisabledBackColor = System.Drawing.Color.White
        Me.fwiImpLineasEspecialesA.Enabled = False
        Me.fwiImpLineasEspecialesA.Location = New System.Drawing.Point(149, 48)
        Me.fwiImpLineasEspecialesA.Name = "fwiImpLineasEspecialesA"
        Me.fwiImpLineasEspecialesA.Size = New System.Drawing.Size(119, 21)
        Me.fwiImpLineasEspecialesA.TabIndex = 106
        '
        'lblfwiImpRecFinanB
        '
        Me.lblfwiImpRecFinanB.Location = New System.Drawing.Point(408, 177)
        Me.lblfwiImpRecFinanB.Name = "lblfwiImpRecFinanB"
        Me.lblfwiImpRecFinanB.Size = New System.Drawing.Size(81, 13)
        Me.lblfwiImpRecFinanB.TabIndex = 113
        Me.lblfwiImpRecFinanB.Tag = "IdRec=5065;"
        Me.lblfwiImpRecFinanB.Text = "ImpRecFinan"
        '
        'fwiImpRecFinanB
        '
        Me.TryDataBinding(fwiImpRecFinanB, New System.Windows.Forms.Binding("Value", Me, "ImpRecFinanB", True))
        Me.fwiImpRecFinanB.DisabledBackColor = System.Drawing.Color.White
        Me.fwiImpRecFinanB.Enabled = False
        Me.fwiImpRecFinanB.Location = New System.Drawing.Point(520, 177)
        Me.fwiImpRecFinanB.Name = "fwiImpRecFinanB"
        Me.fwiImpRecFinanB.Size = New System.Drawing.Size(97, 21)
        Me.fwiImpRecFinanB.TabIndex = 52
        '
        'lblfwiImpRecFinanA
        '
        Me.lblfwiImpRecFinanA.Location = New System.Drawing.Point(42, 174)
        Me.lblfwiImpRecFinanA.Name = "lblfwiImpRecFinanA"
        Me.lblfwiImpRecFinanA.Size = New System.Drawing.Size(101, 13)
        Me.lblfwiImpRecFinanA.TabIndex = 114
        Me.lblfwiImpRecFinanA.Tag = ""
        Me.lblfwiImpRecFinanA.Text = "Imp. Rec. Finan."
        '
        'fwiImpRecFinanA
        '
        Me.TryDataBinding(fwiImpRecFinanA, New System.Windows.Forms.Binding("Value", Me, "ImpRecFinanA", True))
        Me.fwiImpRecFinanA.DisabledBackColor = System.Drawing.Color.White
        Me.fwiImpRecFinanA.Enabled = False
        Me.fwiImpRecFinanA.Location = New System.Drawing.Point(149, 174)
        Me.fwiImpRecFinanA.Name = "fwiImpRecFinanA"
        Me.fwiImpRecFinanA.Size = New System.Drawing.Size(97, 21)
        Me.fwiImpRecFinanA.TabIndex = 53
        '
        'lblfwiImpReA
        '
        Me.lblfwiImpReA.Location = New System.Drawing.Point(42, 150)
        Me.lblfwiImpReA.Name = "lblfwiImpReA"
        Me.lblfwiImpReA.Size = New System.Drawing.Size(30, 13)
        Me.lblfwiImpReA.TabIndex = 115
        Me.lblfwiImpReA.Tag = "IdRec=5062;"
        Me.lblfwiImpReA.Text = "R.E."
        '
        'fwiImpReA
        '
        Me.TryDataBinding(fwiImpReA, New System.Windows.Forms.Binding("Value", Me, "ImpREA", True))
        Me.fwiImpReA.DisabledBackColor = System.Drawing.Color.White
        Me.fwiImpReA.Enabled = False
        Me.fwiImpReA.Location = New System.Drawing.Point(149, 150)
        Me.fwiImpReA.Name = "fwiImpReA"
        Me.fwiImpReA.Size = New System.Drawing.Size(97, 21)
        Me.fwiImpReA.TabIndex = 54
        '
        'lblfwiRetencionA
        '
        Me.lblfwiRetencionA.Location = New System.Drawing.Point(184, 284)
        Me.lblfwiRetencionA.Name = "lblfwiRetencionA"
        Me.lblfwiRetencionA.Size = New System.Drawing.Size(63, 13)
        Me.lblfwiRetencionA.TabIndex = 116
        Me.lblfwiRetencionA.Tag = "IdRec=5060;"
        Me.lblfwiRetencionA.Text = "Retención"
        '
        'fwiRetencionA
        '
        Me.TryDataBinding(fwiRetencionA, New System.Windows.Forms.Binding("Value", Me, "ImpRetencionA", True))
        Me.fwiRetencionA.DisabledBackColor = System.Drawing.Color.White
        Me.fwiRetencionA.Enabled = False
        Me.fwiRetencionA.Location = New System.Drawing.Point(256, 284)
        Me.fwiRetencionA.Name = "fwiRetencionA"
        Me.fwiRetencionA.Size = New System.Drawing.Size(73, 21)
        Me.fwiRetencionA.TabIndex = 55
        '
        'lblfwiIntrastat
        '
        Me.lblfwiIntrastat.Location = New System.Drawing.Point(384, 284)
        Me.lblfwiIntrastat.Name = "lblfwiIntrastat"
        Me.lblfwiIntrastat.Size = New System.Drawing.Size(60, 13)
        Me.lblfwiIntrastat.TabIndex = 117
        Me.lblfwiIntrastat.Tag = "IdRec=5064;"
        Me.lblfwiIntrastat.Text = "Intrastat."
        '
        'fwiIntrastatB
        '
        Me.TryDataBinding(fwiIntrastatB, New System.Windows.Forms.Binding("Value", Me, "ImpIntrastatB", True))
        Me.fwiIntrastatB.DisabledBackColor = System.Drawing.Color.White
        Me.fwiIntrastatB.Enabled = False
        Me.fwiIntrastatB.Location = New System.Drawing.Point(456, 284)
        Me.fwiIntrastatB.Name = "fwiIntrastatB"
        Me.fwiIntrastatB.Size = New System.Drawing.Size(77, 21)
        Me.fwiIntrastatB.TabIndex = 56
        '
        'lblfwiIntrastatA
        '
        Me.lblfwiIntrastatA.Location = New System.Drawing.Point(16, 284)
        Me.lblfwiIntrastatA.Name = "lblfwiIntrastatA"
        Me.lblfwiIntrastatA.Size = New System.Drawing.Size(60, 13)
        Me.lblfwiIntrastatA.TabIndex = 118
        Me.lblfwiIntrastatA.Tag = "IdRec=5064;"
        Me.lblfwiIntrastatA.Text = "Intrastat."
        '
        'fwiIntrastatA
        '
        Me.TryDataBinding(fwiIntrastatA, New System.Windows.Forms.Binding("Value", Me, "ImpIntrastatA", True))
        Me.fwiIntrastatA.DisabledBackColor = System.Drawing.Color.White
        Me.fwiIntrastatA.Enabled = False
        Me.fwiIntrastatA.Location = New System.Drawing.Point(88, 284)
        Me.fwiIntrastatA.Name = "fwiIntrastatA"
        Me.fwiIntrastatA.Size = New System.Drawing.Size(77, 21)
        Me.fwiIntrastatA.TabIndex = 57
        '
        'lblfwiBaseImpB
        '
        Me.lblfwiBaseImpB.Location = New System.Drawing.Point(408, 105)
        Me.lblfwiBaseImpB.Name = "lblfwiBaseImpB"
        Me.lblfwiBaseImpB.Size = New System.Drawing.Size(96, 13)
        Me.lblfwiBaseImpB.TabIndex = 119
        Me.lblfwiBaseImpB.Tag = "IdRec=5044;"
        Me.lblfwiBaseImpB.Text = "Base Imponible"
        '
        'fwiBaseImpB
        '
        Me.TryDataBinding(fwiBaseImpB, New System.Windows.Forms.Binding("Value", Me, "BaseImponibleB", True))
        Me.fwiBaseImpB.DisabledBackColor = System.Drawing.Color.White
        Me.fwiBaseImpB.Enabled = False
        Me.fwiBaseImpB.Location = New System.Drawing.Point(520, 105)
        Me.fwiBaseImpB.Name = "fwiBaseImpB"
        Me.fwiBaseImpB.Size = New System.Drawing.Size(119, 21)
        Me.fwiBaseImpB.TabIndex = 58
        '
        'lblfwiBaseImpA
        '
        Me.lblfwiBaseImpA.Location = New System.Drawing.Point(42, 102)
        Me.lblfwiBaseImpA.Name = "lblfwiBaseImpA"
        Me.lblfwiBaseImpA.Size = New System.Drawing.Size(96, 13)
        Me.lblfwiBaseImpA.TabIndex = 120
        Me.lblfwiBaseImpA.Tag = "IdRec=5044;"
        Me.lblfwiBaseImpA.Text = "Base Imponible"
        '
        'fwiBaseImpA
        '
        Me.TryDataBinding(fwiBaseImpA, New System.Windows.Forms.Binding("Value", Me, "BaseImponibleA", True))
        Me.fwiBaseImpA.DisabledBackColor = System.Drawing.Color.White
        Me.fwiBaseImpA.Enabled = False
        Me.fwiBaseImpA.Location = New System.Drawing.Point(149, 102)
        Me.fwiBaseImpA.Name = "fwiBaseImpA"
        Me.fwiBaseImpA.Size = New System.Drawing.Size(119, 21)
        Me.fwiBaseImpA.TabIndex = 59
        '
        'lblfwiImpReB
        '
        Me.lblfwiImpReB.Location = New System.Drawing.Point(408, 153)
        Me.lblfwiImpReB.Name = "lblfwiImpReB"
        Me.lblfwiImpReB.Size = New System.Drawing.Size(30, 13)
        Me.lblfwiImpReB.TabIndex = 123
        Me.lblfwiImpReB.Tag = "IdRec=5062;"
        Me.lblfwiImpReB.Text = "R.E."
        '
        'fwiImpReB
        '
        Me.TryDataBinding(fwiImpReB, New System.Windows.Forms.Binding("Value", Me, "ImpREB", True))
        Me.fwiImpReB.DisabledBackColor = System.Drawing.Color.White
        Me.fwiImpReB.Enabled = False
        Me.fwiImpReB.Location = New System.Drawing.Point(520, 153)
        Me.fwiImpReB.Name = "fwiImpReB"
        Me.fwiImpReB.Size = New System.Drawing.Size(97, 21)
        Me.fwiImpReB.TabIndex = 62
        '
        'lblfwiImpRetencionB
        '
        Me.lblfwiImpRetencionB.Location = New System.Drawing.Point(544, 284)
        Me.lblfwiImpRetencionB.Name = "lblfwiImpRetencionB"
        Me.lblfwiImpRetencionB.Size = New System.Drawing.Size(63, 13)
        Me.lblfwiImpRetencionB.TabIndex = 126
        Me.lblfwiImpRetencionB.Tag = "IdRec=5060;"
        Me.lblfwiImpRetencionB.Text = "Retención"
        '
        'fwiImpRetencionB
        '
        Me.TryDataBinding(fwiImpRetencionB, New System.Windows.Forms.Binding("Value", Me, "ImpRetencionB", True))
        Me.fwiImpRetencionB.DisabledBackColor = System.Drawing.Color.White
        Me.fwiImpRetencionB.Enabled = False
        Me.fwiImpRetencionB.Location = New System.Drawing.Point(624, 284)
        Me.fwiImpRetencionB.Name = "fwiImpRetencionB"
        Me.fwiImpRetencionB.Size = New System.Drawing.Size(77, 21)
        Me.fwiImpRetencionB.TabIndex = 65
        '
        'lblfwiImpTotalB
        '
        Me.lblfwiImpTotalB.Location = New System.Drawing.Point(408, 210)
        Me.lblfwiImpTotalB.Name = "lblfwiImpTotalB"
        Me.lblfwiImpTotalB.Size = New System.Drawing.Size(46, 13)
        Me.lblfwiImpTotalB.TabIndex = 127
        Me.lblfwiImpTotalB.Tag = "IdRec=5059;"
        Me.lblfwiImpTotalB.Text = "Total B"
        '
        'fwiImpTotalB
        '
        Me.TryDataBinding(fwiImpTotalB, New System.Windows.Forms.Binding("Value", Me, "ImpTotalB", True))
        Me.fwiImpTotalB.DisabledBackColor = System.Drawing.Color.White
        Me.fwiImpTotalB.Enabled = False
        Me.fwiImpTotalB.Location = New System.Drawing.Point(520, 210)
        Me.fwiImpTotalB.Name = "fwiImpTotalB"
        Me.fwiImpTotalB.Size = New System.Drawing.Size(119, 21)
        Me.fwiImpTotalB.TabIndex = 66
        '
        'lblfwiImpTotalA
        '
        Me.lblfwiImpTotalA.Location = New System.Drawing.Point(42, 207)
        Me.lblfwiImpTotalA.Name = "lblfwiImpTotalA"
        Me.lblfwiImpTotalA.Size = New System.Drawing.Size(46, 13)
        Me.lblfwiImpTotalA.TabIndex = 128
        Me.lblfwiImpTotalA.Tag = "IdRec=5058;"
        Me.lblfwiImpTotalA.Text = "Total A"
        '
        'fwiImpTotalA
        '
        Me.TryDataBinding(fwiImpTotalA, New System.Windows.Forms.Binding("Value", Me, "ImpTotalA", True))
        Me.fwiImpTotalA.DisabledBackColor = System.Drawing.Color.White
        Me.fwiImpTotalA.Enabled = False
        Me.fwiImpTotalA.Location = New System.Drawing.Point(149, 207)
        Me.fwiImpTotalA.Name = "fwiImpTotalA"
        Me.fwiImpTotalA.Size = New System.Drawing.Size(119, 21)
        Me.fwiImpTotalA.TabIndex = 67
        '
        'lblfwiImpIVAB
        '
        Me.lblfwiImpIVAB.Location = New System.Drawing.Point(408, 129)
        Me.lblfwiImpIVAB.Name = "lblfwiImpIVAB"
        Me.lblfwiImpIVAB.Size = New System.Drawing.Size(67, 13)
        Me.lblfwiImpIVAB.TabIndex = 129
        Me.lblfwiImpIVAB.Tag = "IdRec=5045;"
        Me.lblfwiImpIVAB.Text = "Impuestos"
        '
        'fwiImpIVAB
        '
        Me.TryDataBinding(fwiImpIVAB, New System.Windows.Forms.Binding("Value", Me, "ImpIvaB", True))
        Me.fwiImpIVAB.DisabledBackColor = System.Drawing.Color.White
        Me.fwiImpIVAB.Enabled = False
        Me.fwiImpIVAB.Location = New System.Drawing.Point(520, 129)
        Me.fwiImpIVAB.Name = "fwiImpIVAB"
        Me.fwiImpIVAB.Size = New System.Drawing.Size(97, 21)
        Me.fwiImpIVAB.TabIndex = 68
        '
        'lblfwiImpIVAA
        '
        Me.lblfwiImpIVAA.Location = New System.Drawing.Point(42, 126)
        Me.lblfwiImpIVAA.Name = "lblfwiImpIVAA"
        Me.lblfwiImpIVAA.Size = New System.Drawing.Size(26, 13)
        Me.lblfwiImpIVAA.TabIndex = 130
        Me.lblfwiImpIVAA.Tag = "IdRec=5045;"
        Me.lblfwiImpIVAA.Text = "Iva"
        '
        'fwiImpIVAA
        '
        Me.TryDataBinding(fwiImpIVAA, New System.Windows.Forms.Binding("Value", Me, "ImpIvaA", True))
        Me.fwiImpIVAA.DisabledBackColor = System.Drawing.Color.White
        Me.fwiImpIVAA.Enabled = False
        Me.fwiImpIVAA.Location = New System.Drawing.Point(149, 126)
        Me.fwiImpIVAA.Name = "fwiImpIVAA"
        Me.fwiImpIVAA.Size = New System.Drawing.Size(97, 21)
        Me.fwiImpIVAA.TabIndex = 69
        '
        'lblfwiImpLineasA
        '
        Me.lblfwiImpLineasA.Location = New System.Drawing.Point(42, 72)
        Me.lblfwiImpLineasA.Name = "lblfwiImpLineasA"
        Me.lblfwiImpLineasA.Size = New System.Drawing.Size(43, 13)
        Me.lblfwiImpLineasA.TabIndex = 131
        Me.lblfwiImpLineasA.Tag = "IdRec=5057;"
        Me.lblfwiImpLineasA.Text = "Líneas"
        '
        'fwiImpLineasA
        '
        Me.TryDataBinding(fwiImpLineasA, New System.Windows.Forms.Binding("Value", Me, "ImpLineasA", True))
        Me.fwiImpLineasA.DisabledBackColor = System.Drawing.Color.White
        Me.fwiImpLineasA.Enabled = False
        Me.fwiImpLineasA.Location = New System.Drawing.Point(149, 72)
        Me.fwiImpLineasA.Name = "fwiImpLineasA"
        Me.fwiImpLineasA.Size = New System.Drawing.Size(119, 21)
        Me.fwiImpLineasA.TabIndex = 70
        '
        'lblfwiImpLineasB
        '
        Me.lblfwiImpLineasB.Location = New System.Drawing.Point(408, 72)
        Me.lblfwiImpLineasB.Name = "lblfwiImpLineasB"
        Me.lblfwiImpLineasB.Size = New System.Drawing.Size(43, 13)
        Me.lblfwiImpLineasB.TabIndex = 132
        Me.lblfwiImpLineasB.Tag = "IdRec=5057;"
        Me.lblfwiImpLineasB.Text = "Líneas"
        '
        'fwiImpLineasB
        '
        Me.TryDataBinding(fwiImpLineasB, New System.Windows.Forms.Binding("Value", Me, "ImpLineasB", True))
        Me.fwiImpLineasB.DisabledBackColor = System.Drawing.Color.White
        Me.fwiImpLineasB.Enabled = False
        Me.fwiImpLineasB.Location = New System.Drawing.Point(520, 72)
        Me.fwiImpLineasB.Name = "fwiImpLineasB"
        Me.fwiImpLineasB.Size = New System.Drawing.Size(119, 21)
        Me.fwiImpLineasB.TabIndex = 71
        '
        'Line6
        '
        Me.Line6.Controls.Add(Me.Label7)
        Me.Line6.Controls.Add(Me.NumericTextBox3)
        Me.Line6.Controls.Add(Me.Label6)
        Me.Line6.Controls.Add(Me.NumericTextBox2)
        Me.Line6.Location = New System.Drawing.Point(0, 234)
        Me.Line6.Name = "Line6"
        Me.Line6.Size = New System.Drawing.Size(716, 44)
        Me.Line6.TabIndex = 75
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(408, 12)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(67, 13)
        Me.Label7.TabIndex = 134
        Me.Label7.Tag = "IdRec=5045;"
        Me.Label7.Text = "Impuestos"
        '
        'NumericTextBox3
        '
        Me.TryDataBinding(NumericTextBox3, New System.Windows.Forms.Binding("Value", Me, "ImpImpuestosB", True))
        Me.NumericTextBox3.DisabledBackColor = System.Drawing.Color.White
        Me.NumericTextBox3.Enabled = False
        Me.NumericTextBox3.Location = New System.Drawing.Point(520, 12)
        Me.NumericTextBox3.Name = "NumericTextBox3"
        Me.NumericTextBox3.Size = New System.Drawing.Size(97, 21)
        Me.NumericTextBox3.TabIndex = 133
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(41, 12)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(67, 13)
        Me.Label6.TabIndex = 132
        Me.Label6.Tag = "IdRec=5045;"
        Me.Label6.Text = "Impuestos"
        '
        'NumericTextBox2
        '
        Me.TryDataBinding(NumericTextBox2, New System.Windows.Forms.Binding("Value", Me, "ImpImpuestosA", True))
        Me.NumericTextBox2.DisabledBackColor = System.Drawing.Color.White
        Me.NumericTextBox2.Enabled = False
        Me.NumericTextBox2.Location = New System.Drawing.Point(148, 12)
        Me.NumericTextBox2.Name = "NumericTextBox2"
        Me.NumericTextBox2.Size = New System.Drawing.Size(97, 21)
        Me.NumericTextBox2.TabIndex = 131
        '
        'TabPageTotales
        '
        Me.TabPageTotales.Controls.Add(Me.FraMoneda)
        Me.TabPageTotales.Controls.Add(Me.FraIvaIntrastat)
        Me.TabPageTotales.Controls.Add(Me.Line10)
        Me.TabPageTotales.Controls.Add(Me.FraRetenciones)
        Me.TabPageTotales.Controls.Add(Me.fraCalculoFactura)
        Me.TabPageTotales.Key = "Totales"
        Me.TabPageTotales.Location = New System.Drawing.Point(1, 21)
        Me.TabPageTotales.Name = "TabPageTotales"
        Me.TabPageTotales.Size = New System.Drawing.Size(718, 352)
        Me.TabPageTotales.TabStop = True
        Me.TabPageTotales.Text = "Totales"
        Me.TabPageTotales.Visible = False
        '
        'FraMoneda
        '
        Me.FraMoneda.Controls.Add(Me.ullDescMoneda)
        Me.FraMoneda.Location = New System.Drawing.Point(1, 62)
        Me.FraMoneda.Name = "FraMoneda"
        Me.FraMoneda.Size = New System.Drawing.Size(255, 56)
        Me.FraMoneda.TabIndex = 49
        Me.FraMoneda.TabStop = False
        Me.FraMoneda.Tag = ""
        Me.FraMoneda.Text = "Moneda Factura"
        '
        'ullDescMoneda
        '
        Me.TryDataBinding(ullDescMoneda, New System.Windows.Forms.Binding("Text", Me.fwiIdMoneda, "DescMoneda", True))
        Me.ullDescMoneda.Location = New System.Drawing.Point(8, 21)
        Me.ullDescMoneda.Name = "ullDescMoneda"
        Me.ullDescMoneda.Size = New System.Drawing.Size(232, 24)
        Me.ullDescMoneda.TabIndex = 0
        Me.ullDescMoneda.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FraIvaIntrastat
        '
        Me.FraIvaIntrastat.Controls.Add(Me.lblImpIntrastat)
        Me.FraIvaIntrastat.Controls.Add(Me.ImpIntrastat)
        Me.FraIvaIntrastat.Location = New System.Drawing.Point(1, 7)
        Me.FraIvaIntrastat.Name = "FraIvaIntrastat"
        Me.FraIvaIntrastat.Size = New System.Drawing.Size(255, 51)
        Me.FraIvaIntrastat.TabIndex = 48
        Me.FraIvaIntrastat.TabStop = False
        Me.FraIvaIntrastat.Tag = ""
        Me.FraIvaIntrastat.Text = "IVA Intrastat"
        '
        'lblImpIntrastat
        '
        Me.lblImpIntrastat.Location = New System.Drawing.Point(14, 20)
        Me.lblImpIntrastat.Name = "lblImpIntrastat"
        Me.lblImpIntrastat.Size = New System.Drawing.Size(60, 13)
        Me.lblImpIntrastat.TabIndex = 0
        Me.lblImpIntrastat.Tag = "IdRec=5064;"
        Me.lblImpIntrastat.Text = "Intrastat."
        '
        'ImpIntrastat
        '
        Me.TryDataBinding(ImpIntrastat, New System.Windows.Forms.Binding("Value", Me, "ImpIntrastat", True))
        Me.ImpIntrastat.DisabledBackColor = System.Drawing.Color.White
        Me.ImpIntrastat.Enabled = False
        Me.ImpIntrastat.Location = New System.Drawing.Point(88, 20)
        Me.ImpIntrastat.Name = "ImpIntrastat"
        Me.ImpIntrastat.Size = New System.Drawing.Size(83, 21)
        Me.ImpIntrastat.TabIndex = 91
        '
        'Line10
        '
        Me.Line10.Location = New System.Drawing.Point(392, 376)
        Me.Line10.Name = "Line10"
        Me.Line10.Size = New System.Drawing.Size(286, 2)
        Me.Line10.TabIndex = 51
        '
        'FraRetenciones
        '
        Me.FraRetenciones.Controls.Add(Me.CmbTipoRetencionIRPF)
        Me.FraRetenciones.Controls.Add(Me.LblTipoRetencionIRPF)
        Me.FraRetenciones.Controls.Add(Me.Label4)
        Me.FraRetenciones.Controls.Add(Me.NumericTextBox1)
        Me.FraRetenciones.Controls.Add(Me.Label5)
        Me.FraRetenciones.Controls.Add(Me.fwiRegimenEspecial)
        Me.FraRetenciones.Controls.Add(Me.fwiRetencionManual)
        Me.FraRetenciones.Controls.Add(Me.lblfwiBaseRetencion)
        Me.FraRetenciones.Controls.Add(Me.fwiBaseRetencion)
        Me.FraRetenciones.Controls.Add(Me.lblfwiPorcIRPF)
        Me.FraRetenciones.Controls.Add(Me.fwiPorcIRPF)
        Me.FraRetenciones.Controls.Add(Me.lblfwiImpRetencion)
        Me.FraRetenciones.Controls.Add(Me.fwiImpRetencion)
        Me.FraRetenciones.Location = New System.Drawing.Point(1, 123)
        Me.FraRetenciones.Name = "FraRetenciones"
        Me.FraRetenciones.Size = New System.Drawing.Size(255, 195)
        Me.FraRetenciones.TabIndex = 43
        Me.FraRetenciones.TabStop = False
        Me.FraRetenciones.Tag = ""
        Me.FraRetenciones.Text = "Retenciones"
        '
        'CmbTipoRetencionIRPF
        '
        Me.TryDataBinding(CmbTipoRetencionIRPF, New System.Windows.Forms.Binding("Value", Me, "TipoRetencionIRPF", True))
        CmbTipoRetencionIRPF_DesignTimeLayout.LayoutString = resources.GetString("CmbTipoRetencionIRPF_DesignTimeLayout.LayoutString")
        Me.CmbTipoRetencionIRPF.DesignTimeLayout = CmbTipoRetencionIRPF_DesignTimeLayout
        Me.CmbTipoRetencionIRPF.DisabledBackColor = System.Drawing.Color.White
        Me.CmbTipoRetencionIRPF.DisplayMember = "Text"
        Me.CmbTipoRetencionIRPF.Location = New System.Drawing.Point(136, 74)
        Me.CmbTipoRetencionIRPF.Name = "CmbTipoRetencionIRPF"
        Me.CmbTipoRetencionIRPF.SelectedIndex = -1
        Me.CmbTipoRetencionIRPF.SelectedItem = Nothing
        Me.CmbTipoRetencionIRPF.Size = New System.Drawing.Size(100, 21)
        Me.CmbTipoRetencionIRPF.TabIndex = 102
        Me.CmbTipoRetencionIRPF.ValueMember = "Value"
        '
        'LblTipoRetencionIRPF
        '
        Me.LblTipoRetencionIRPF.Location = New System.Drawing.Point(24, 78)
        Me.LblTipoRetencionIRPF.Name = "LblTipoRetencionIRPF"
        Me.LblTipoRetencionIRPF.Size = New System.Drawing.Size(91, 13)
        Me.LblTipoRetencionIRPF.TabIndex = 110
        Me.LblTipoRetencionIRPF.Text = "Tipo Retención"
        '
        'Label4
        '
        Me.Label4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.Location = New System.Drawing.Point(24, 171)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(105, 13)
        Me.Label4.TabIndex = 109
        Me.Label4.Tag = "IdRec=4664;"
        Me.Label4.Text = "Tot. Fact. con Ret"
        '
        'NumericTextBox1
        '
        Me.TryDataBinding(NumericTextBox1, New System.Windows.Forms.Binding("Value", Me, "TotconRet", True))
        Me.NumericTextBox1.DisabledBackColor = System.Drawing.Color.White
        Me.NumericTextBox1.Enabled = False
        Me.NumericTextBox1.Location = New System.Drawing.Point(136, 171)
        Me.NumericTextBox1.Name = "NumericTextBox1"
        Me.NumericTextBox1.Size = New System.Drawing.Size(100, 21)
        Me.NumericTextBox1.TabIndex = 106
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(176, 125)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(19, 13)
        Me.Label5.TabIndex = 107
        Me.Label5.Text = "%"
        '
        'fwiRegimenEspecial
        '
        Me.TryDataBinding(fwiRegimenEspecial, New System.Windows.Forms.Binding("BindableValue", Me, "RegimenEspecial", True))
        Me.fwiRegimenEspecial.Location = New System.Drawing.Point(8, 24)
        Me.fwiRegimenEspecial.Name = "fwiRegimenEspecial"
        Me.fwiRegimenEspecial.Size = New System.Drawing.Size(122, 19)
        Me.fwiRegimenEspecial.TabIndex = 100
        Me.fwiRegimenEspecial.Text = "Régimen especial"
        Me.fwiRegimenEspecial.Visible = False
        '
        'fwiRetencionManual
        '
        Me.TryDataBinding(fwiRetencionManual, New System.Windows.Forms.Binding("BindableValue", Me, "RetencionManual", True))
        Me.fwiRetencionManual.Location = New System.Drawing.Point(8, 46)
        Me.fwiRetencionManual.Name = "fwiRetencionManual"
        Me.fwiRetencionManual.Size = New System.Drawing.Size(122, 19)
        Me.fwiRetencionManual.TabIndex = 101
        Me.fwiRetencionManual.Text = "Retención Manual"
        '
        'lblfwiBaseRetencion
        '
        Me.lblfwiBaseRetencion.Location = New System.Drawing.Point(24, 99)
        Me.lblfwiBaseRetencion.Name = "lblfwiBaseRetencion"
        Me.lblfwiBaseRetencion.Size = New System.Drawing.Size(95, 13)
        Me.lblfwiBaseRetencion.TabIndex = 104
        Me.lblfwiBaseRetencion.Text = "Base Retención"
        '
        'fwiBaseRetencion
        '
        Me.TryDataBinding(fwiBaseRetencion, New System.Windows.Forms.Binding("Value", Me, "BaseRetencion", True))
        Me.fwiBaseRetencion.DisabledBackColor = System.Drawing.Color.White
        Me.fwiBaseRetencion.Enabled = False
        Me.fwiBaseRetencion.Location = New System.Drawing.Point(136, 99)
        Me.fwiBaseRetencion.Name = "fwiBaseRetencion"
        Me.fwiBaseRetencion.Size = New System.Drawing.Size(100, 21)
        Me.fwiBaseRetencion.TabIndex = 103
        '
        'lblfwiPorcIRPF
        '
        Me.lblfwiPorcIRPF.Location = New System.Drawing.Point(24, 123)
        Me.lblfwiPorcIRPF.Name = "lblfwiPorcIRPF"
        Me.lblfwiPorcIRPF.Size = New System.Drawing.Size(45, 13)
        Me.lblfwiPorcIRPF.TabIndex = 105
        Me.lblfwiPorcIRPF.Tag = "IdRec=5069;"
        Me.lblfwiPorcIRPF.Text = "I.R.P.F."
        '
        'fwiPorcIRPF
        '
        Me.TryDataBinding(fwiPorcIRPF, New System.Windows.Forms.Binding("Value", Me, "RetencionIRPF", True))
        Me.fwiPorcIRPF.DisabledBackColor = System.Drawing.Color.White
        Me.fwiPorcIRPF.Location = New System.Drawing.Point(136, 123)
        Me.fwiPorcIRPF.Name = "fwiPorcIRPF"
        Me.fwiPorcIRPF.Size = New System.Drawing.Size(35, 21)
        Me.fwiPorcIRPF.TabIndex = 104
        '
        'lblfwiImpRetencion
        '
        Me.lblfwiImpRetencion.Location = New System.Drawing.Point(24, 147)
        Me.lblfwiImpRetencion.Name = "lblfwiImpRetencion"
        Me.lblfwiImpRetencion.Size = New System.Drawing.Size(94, 13)
        Me.lblfwiImpRetencion.TabIndex = 106
        Me.lblfwiImpRetencion.Tag = "IdRec=5066;"
        Me.lblfwiImpRetencion.Text = "Imp. Retención"
        '
        'fwiImpRetencion
        '
        Me.TryDataBinding(fwiImpRetencion, New System.Windows.Forms.Binding("Value", Me, "ImpRetencion", True))
        Me.fwiImpRetencion.DisabledBackColor = System.Drawing.Color.White
        Me.fwiImpRetencion.Enabled = False
        Me.fwiImpRetencion.Location = New System.Drawing.Point(136, 147)
        Me.fwiImpRetencion.Name = "fwiImpRetencion"
        Me.fwiImpRetencion.Size = New System.Drawing.Size(100, 21)
        Me.fwiImpRetencion.TabIndex = 105
        '
        'fraCalculoFactura
        '
        Me.fraCalculoFactura.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.fraCalculoFactura.Controls.Add(Me.Label8)
        Me.fraCalculoFactura.Controls.Add(Me.NumericTextBox4)
        Me.fraCalculoFactura.Controls.Add(Me.Line13)
        Me.fraCalculoFactura.Controls.Add(Me.Line11)
        Me.fraCalculoFactura.Controls.Add(Me.UiGroupBox1)
        Me.fraCalculoFactura.Controls.Add(Me.Label3)
        Me.fraCalculoFactura.Controls.Add(Me.Label2)
        Me.fraCalculoFactura.Controls.Add(Me.Label1)
        Me.fraCalculoFactura.Controls.Add(Me.lblfwiImpLineasNormales)
        Me.fraCalculoFactura.Controls.Add(Me.fwiImpLineasNormales)
        Me.fraCalculoFactura.Controls.Add(Me.lblfwiImpLineasEspeciales)
        Me.fraCalculoFactura.Controls.Add(Me.fwiImpLineasEspeciales)
        Me.fraCalculoFactura.Controls.Add(Me.lblfwiImpTotal)
        Me.fraCalculoFactura.Controls.Add(Me.fwiImpTotal)
        Me.fraCalculoFactura.Controls.Add(Me.lblfwiDtoProntoPago)
        Me.fraCalculoFactura.Controls.Add(Me.fwiDtoProntoPago)
        Me.fraCalculoFactura.Controls.Add(Me.lblfwiBaseImpMon)
        Me.fraCalculoFactura.Controls.Add(Me.fwiBaseImpMon)
        Me.fraCalculoFactura.Controls.Add(Me.lblfwiImpLinMon)
        Me.fraCalculoFactura.Controls.Add(Me.fwiImpLinMon)
        Me.fraCalculoFactura.Controls.Add(Me.lblfwiImpREMon)
        Me.fraCalculoFactura.Controls.Add(Me.fwiImpREMon)
        Me.fraCalculoFactura.Controls.Add(Me.lblfwiIVA)
        Me.fraCalculoFactura.Controls.Add(Me.fwiIVA)
        Me.fraCalculoFactura.Controls.Add(Me.lblfwiRecFinan)
        Me.fraCalculoFactura.Controls.Add(Me.fwiRecFinan)
        Me.fraCalculoFactura.Controls.Add(Me.lblfwiImpRecFinan)
        Me.fraCalculoFactura.Controls.Add(Me.fwiImpRecFinan)
        Me.fraCalculoFactura.Controls.Add(Me.lblfwiDtoFactura)
        Me.fraCalculoFactura.Controls.Add(Me.fwiDtoFactura)
        Me.fraCalculoFactura.Location = New System.Drawing.Point(258, 1)
        Me.fraCalculoFactura.Name = "fraCalculoFactura"
        Me.fraCalculoFactura.Size = New System.Drawing.Size(462, 349)
        Me.fraCalculoFactura.TabIndex = 42
        Me.fraCalculoFactura.TabStop = False
        Me.fraCalculoFactura.Tag = ""
        Me.fraCalculoFactura.Text = "Cálculo Factura"
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(10, 245)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(67, 13)
        Me.Label8.TabIndex = 126
        Me.Label8.Tag = "IdRec=5045;"
        Me.Label8.Text = "Impuestos"
        '
        'NumericTextBox4
        '
        Me.TryDataBinding(NumericTextBox4, New System.Windows.Forms.Binding("Value", Me, "ImpImpuestos", True))
        Me.NumericTextBox4.DisabledBackColor = System.Drawing.Color.White
        Me.NumericTextBox4.Enabled = False
        Me.NumericTextBox4.Location = New System.Drawing.Point(85, 245)
        Me.NumericTextBox4.Name = "NumericTextBox4"
        Me.NumericTextBox4.Size = New System.Drawing.Size(76, 21)
        Me.NumericTextBox4.TabIndex = 125
        '
        'Line13
        '
        Me.Line13.Location = New System.Drawing.Point(166, 221)
        Me.Line13.Name = "Line13"
        Me.Line13.Size = New System.Drawing.Size(286, 3)
        Me.Line13.TabIndex = 124
        '
        'Line11
        '
        Me.Line11.Location = New System.Drawing.Point(166, 80)
        Me.Line11.Name = "Line11"
        Me.Line11.Size = New System.Drawing.Size(286, 3)
        Me.Line11.TabIndex = 123
        '
        'UiGroupBox1
        '
        Me.UiGroupBox1.Location = New System.Drawing.Point(166, 113)
        Me.UiGroupBox1.Name = "UiGroupBox1"
        Me.UiGroupBox1.Size = New System.Drawing.Size(286, 3)
        Me.UiGroupBox1.TabIndex = 122
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(168, 196)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(19, 13)
        Me.Label3.TabIndex = 120
        Me.Label3.Text = "%"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(168, 146)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(19, 13)
        Me.Label2.TabIndex = 119
        Me.Label2.Text = "%"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(168, 122)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(19, 13)
        Me.Label1.TabIndex = 118
        Me.Label1.Text = "%"
        '
        'lblfwiImpLineasNormales
        '
        Me.lblfwiImpLineasNormales.Location = New System.Drawing.Point(165, 32)
        Me.lblfwiImpLineasNormales.Name = "lblfwiImpLineasNormales"
        Me.lblfwiImpLineasNormales.Size = New System.Drawing.Size(151, 13)
        Me.lblfwiImpLineasNormales.TabIndex = 0
        Me.lblfwiImpLineasNormales.Text = "Importe Líneas Normales"
        '
        'fwiImpLineasNormales
        '
        Me.fwiImpLineasNormales.DisabledBackColor = System.Drawing.Color.White
        Me.fwiImpLineasNormales.Enabled = False
        Me.fwiImpLineasNormales.Location = New System.Drawing.Point(322, 32)
        Me.fwiImpLineasNormales.Name = "fwiImpLineasNormales"
        Me.fwiImpLineasNormales.Size = New System.Drawing.Size(128, 21)
        Me.fwiImpLineasNormales.TabIndex = 105
        '
        'lblfwiImpLineasEspeciales
        '
        Me.lblfwiImpLineasEspeciales.Location = New System.Drawing.Point(165, 56)
        Me.lblfwiImpLineasEspeciales.Name = "lblfwiImpLineasEspeciales"
        Me.lblfwiImpLineasEspeciales.Size = New System.Drawing.Size(156, 13)
        Me.lblfwiImpLineasEspeciales.TabIndex = 106
        Me.lblfwiImpLineasEspeciales.Text = "Importe Líneas Especiales"
        '
        'fwiImpLineasEspeciales
        '
        Me.fwiImpLineasEspeciales.DisabledBackColor = System.Drawing.Color.White
        Me.fwiImpLineasEspeciales.Enabled = False
        Me.fwiImpLineasEspeciales.Location = New System.Drawing.Point(322, 56)
        Me.fwiImpLineasEspeciales.Name = "fwiImpLineasEspeciales"
        Me.fwiImpLineasEspeciales.Size = New System.Drawing.Size(128, 21)
        Me.fwiImpLineasEspeciales.TabIndex = 104
        '
        'lblfwiImpTotal
        '
        Me.lblfwiImpTotal.Location = New System.Drawing.Point(220, 230)
        Me.lblfwiImpTotal.Name = "lblfwiImpTotal"
        Me.lblfwiImpTotal.Size = New System.Drawing.Size(34, 13)
        Me.lblfwiImpTotal.TabIndex = 107
        Me.lblfwiImpTotal.Tag = "IdRec=4664;"
        Me.lblfwiImpTotal.Text = "Total"
        '
        'fwiImpTotal
        '
        Me.TryDataBinding(fwiImpTotal, New System.Windows.Forms.Binding("Value", Me, "ImpTotal", True))
        Me.fwiImpTotal.DisabledBackColor = System.Drawing.Color.White
        Me.fwiImpTotal.Enabled = False
        Me.fwiImpTotal.Location = New System.Drawing.Point(321, 230)
        Me.fwiImpTotal.Name = "fwiImpTotal"
        Me.fwiImpTotal.Size = New System.Drawing.Size(127, 21)
        Me.fwiImpTotal.TabIndex = 100
        '
        'lblfwiDtoProntoPago
        '
        Me.lblfwiDtoProntoPago.Location = New System.Drawing.Point(6, 146)
        Me.lblfwiDtoProntoPago.Name = "lblfwiDtoProntoPago"
        Me.lblfwiDtoProntoPago.Size = New System.Drawing.Size(76, 13)
        Me.lblfwiDtoProntoPago.TabIndex = 108
        Me.lblfwiDtoProntoPago.Tag = "IdRec=5068;"
        Me.lblfwiDtoProntoPago.Text = "Pronto Pago"
        '
        'fwiDtoProntoPago
        '
        Me.TryDataBinding(fwiDtoProntoPago, New System.Windows.Forms.Binding("Value", Me, "DtoProntoPago", True))
        Me.fwiDtoProntoPago.DisabledBackColor = System.Drawing.Color.White
        Me.fwiDtoProntoPago.Location = New System.Drawing.Point(126, 146)
        Me.fwiDtoProntoPago.Name = "fwiDtoProntoPago"
        Me.fwiDtoProntoPago.Size = New System.Drawing.Size(35, 21)
        Me.fwiDtoProntoPago.TabIndex = 34
        '
        'lblfwiBaseImpMon
        '
        Me.lblfwiBaseImpMon.Location = New System.Drawing.Point(220, 124)
        Me.lblfwiBaseImpMon.Name = "lblfwiBaseImpMon"
        Me.lblfwiBaseImpMon.Size = New System.Drawing.Size(96, 13)
        Me.lblfwiBaseImpMon.TabIndex = 109
        Me.lblfwiBaseImpMon.Tag = "IdRec=5044;"
        Me.lblfwiBaseImpMon.Text = "Base Imponible"
        '
        'fwiBaseImpMon
        '
        Me.TryDataBinding(fwiBaseImpMon, New System.Windows.Forms.Binding("Value", Me, "BaseImponible", True))
        Me.fwiBaseImpMon.DisabledBackColor = System.Drawing.Color.White
        Me.fwiBaseImpMon.Enabled = False
        Me.fwiBaseImpMon.Location = New System.Drawing.Point(321, 124)
        Me.fwiBaseImpMon.Name = "fwiBaseImpMon"
        Me.fwiBaseImpMon.Size = New System.Drawing.Size(127, 21)
        Me.fwiBaseImpMon.TabIndex = 38
        '
        'lblfwiImpLinMon
        '
        Me.lblfwiImpLinMon.Location = New System.Drawing.Point(165, 88)
        Me.lblfwiImpLinMon.Name = "lblfwiImpLinMon"
        Me.lblfwiImpLinMon.Size = New System.Drawing.Size(93, 13)
        Me.lblfwiImpLinMon.TabIndex = 110
        Me.lblfwiImpLinMon.Tag = "IdRec=5067;"
        Me.lblfwiImpLinMon.Text = "Importe Líneas"
        '
        'fwiImpLinMon
        '
        Me.TryDataBinding(fwiImpLinMon, New System.Windows.Forms.Binding("Value", Me, "ImpLineas", True))
        Me.fwiImpLinMon.DisabledBackColor = System.Drawing.Color.White
        Me.fwiImpLinMon.Enabled = False
        Me.fwiImpLinMon.Location = New System.Drawing.Point(322, 88)
        Me.fwiImpLinMon.Name = "fwiImpLinMon"
        Me.fwiImpLinMon.Size = New System.Drawing.Size(128, 21)
        Me.fwiImpLinMon.TabIndex = 39
        '
        'lblfwiImpREMon
        '
        Me.lblfwiImpREMon.Location = New System.Drawing.Point(220, 172)
        Me.lblfwiImpREMon.Name = "lblfwiImpREMon"
        Me.lblfwiImpREMon.Size = New System.Drawing.Size(30, 13)
        Me.lblfwiImpREMon.TabIndex = 111
        Me.lblfwiImpREMon.Tag = "IdRec=5062;"
        Me.lblfwiImpREMon.Text = "R.E."
        '
        'fwiImpREMon
        '
        Me.TryDataBinding(fwiImpREMon, New System.Windows.Forms.Binding("Value", Me, "ImpRE", True))
        Me.fwiImpREMon.DisabledBackColor = System.Drawing.Color.White
        Me.fwiImpREMon.Enabled = False
        Me.fwiImpREMon.Location = New System.Drawing.Point(321, 172)
        Me.fwiImpREMon.Name = "fwiImpREMon"
        Me.fwiImpREMon.Size = New System.Drawing.Size(105, 21)
        Me.fwiImpREMon.TabIndex = 40
        '
        'lblfwiIVA
        '
        Me.lblfwiIVA.Location = New System.Drawing.Point(220, 148)
        Me.lblfwiIVA.Name = "lblfwiIVA"
        Me.lblfwiIVA.Size = New System.Drawing.Size(28, 13)
        Me.lblfwiIVA.TabIndex = 112
        Me.lblfwiIVA.Tag = "IdRec=5045;"
        Me.lblfwiIVA.Text = "IVA"
        '
        'fwiIVA
        '
        Me.TryDataBinding(fwiIVA, New System.Windows.Forms.Binding("Value", Me, "ImpIva", True))
        Me.fwiIVA.DisabledBackColor = System.Drawing.Color.White
        Me.fwiIVA.Enabled = False
        Me.fwiIVA.Location = New System.Drawing.Point(321, 148)
        Me.fwiIVA.Name = "fwiIVA"
        Me.fwiIVA.Size = New System.Drawing.Size(105, 21)
        Me.fwiIVA.TabIndex = 41
        '
        'lblfwiRecFinan
        '
        Me.lblfwiRecFinan.Location = New System.Drawing.Point(7, 196)
        Me.lblfwiRecFinan.Name = "lblfwiRecFinan"
        Me.lblfwiRecFinan.Size = New System.Drawing.Size(116, 13)
        Me.lblfwiRecFinan.TabIndex = 113
        Me.lblfwiRecFinan.Text = "Recargo Financiero"
        '
        'fwiRecFinan
        '
        Me.TryDataBinding(fwiRecFinan, New System.Windows.Forms.Binding("Value", Me, "RecFinan", True))
        Me.fwiRecFinan.DisabledBackColor = System.Drawing.Color.White
        Me.fwiRecFinan.Location = New System.Drawing.Point(126, 196)
        Me.fwiRecFinan.Name = "fwiRecFinan"
        Me.fwiRecFinan.Size = New System.Drawing.Size(35, 21)
        Me.fwiRecFinan.TabIndex = 36
        '
        'lblfwiImpRecFinan
        '
        Me.lblfwiImpRecFinan.Location = New System.Drawing.Point(220, 196)
        Me.lblfwiImpRecFinan.Name = "lblfwiImpRecFinan"
        Me.lblfwiImpRecFinan.Size = New System.Drawing.Size(101, 13)
        Me.lblfwiImpRecFinan.TabIndex = 114
        Me.lblfwiImpRecFinan.Text = "Imp. Rec. Finan."
        '
        'fwiImpRecFinan
        '
        Me.TryDataBinding(fwiImpRecFinan, New System.Windows.Forms.Binding("Value", Me, "ImpRecFinan", True))
        Me.fwiImpRecFinan.DisabledBackColor = System.Drawing.Color.White
        Me.fwiImpRecFinan.Enabled = False
        Me.fwiImpRecFinan.Location = New System.Drawing.Point(321, 196)
        Me.fwiImpRecFinan.Name = "fwiImpRecFinan"
        Me.fwiImpRecFinan.Size = New System.Drawing.Size(105, 21)
        Me.fwiImpRecFinan.TabIndex = 37
        '
        'lblfwiDtoFactura
        '
        Me.lblfwiDtoFactura.Location = New System.Drawing.Point(7, 122)
        Me.lblfwiDtoFactura.Name = "lblfwiDtoFactura"
        Me.lblfwiDtoFactura.Size = New System.Drawing.Size(76, 13)
        Me.lblfwiDtoFactura.TabIndex = 117
        Me.lblfwiDtoFactura.Tag = "IdRec=5063;"
        Me.lblfwiDtoFactura.Text = "Dto. Factura"
        '
        'fwiDtoFactura
        '
        Me.TryDataBinding(fwiDtoFactura, New System.Windows.Forms.Binding("Value", Me, "DtoFactura", True))
        Me.fwiDtoFactura.DisabledBackColor = System.Drawing.Color.White
        Me.fwiDtoFactura.Location = New System.Drawing.Point(126, 122)
        Me.fwiDtoFactura.Name = "fwiDtoFactura"
        Me.fwiDtoFactura.Size = New System.Drawing.Size(35, 21)
        Me.fwiDtoFactura.TabIndex = 32
        '
        'TabPageAnotaciones
        '
        Me.TabPageAnotaciones.Controls.Add(Me.fraComentarios)
        Me.TabPageAnotaciones.Key = "Anotaciones"
        Me.TabPageAnotaciones.Location = New System.Drawing.Point(1, 21)
        Me.TabPageAnotaciones.Name = "TabPageAnotaciones"
        Me.TabPageAnotaciones.Size = New System.Drawing.Size(718, 352)
        Me.TabPageAnotaciones.TabStop = True
        Me.TabPageAnotaciones.Text = "Anotaciones"
        Me.TabPageAnotaciones.Visible = False
        '
        'fraComentarios
        '
        Me.fraComentarios.Controls.Add(Me.fwiTextoFactura)
        Me.fraComentarios.Dock = System.Windows.Forms.DockStyle.Fill
        Me.fraComentarios.Location = New System.Drawing.Point(0, 0)
        Me.fraComentarios.Margin = New System.Windows.Forms.Padding(5)
        Me.fraComentarios.Name = "fraComentarios"
        Me.fraComentarios.Size = New System.Drawing.Size(718, 352)
        Me.fraComentarios.TabIndex = 28
        Me.fraComentarios.TabStop = False
        Me.fraComentarios.Tag = ""
        Me.fraComentarios.Text = "Comentarios"
        '
        'fwiTextoFactura
        '
        Me.TryDataBinding(fwiTextoFactura, New System.Windows.Forms.Binding("Text", Me, "Texto", True))
        Me.fwiTextoFactura.DisabledBackColor = System.Drawing.Color.White
        Me.fwiTextoFactura.Dock = System.Windows.Forms.DockStyle.Fill
        Me.fwiTextoFactura.Location = New System.Drawing.Point(3, 17)
        Me.fwiTextoFactura.Multiline = True
        Me.fwiTextoFactura.Name = "fwiTextoFactura"
        Me.fwiTextoFactura.Size = New System.Drawing.Size(712, 332)
        Me.fwiTextoFactura.TabIndex = 27
        '
        'TabPageSeguimiento
        '
        Me.TabPageSeguimiento.Controls.Add(Me.lblfwiNDocumento)
        Me.TabPageSeguimiento.Controls.Add(Me.CmbCentroCoste)
        Me.TabPageSeguimiento.Controls.Add(Me.fwiNDocumento)
        Me.TabPageSeguimiento.Controls.Add(Me.lblFwicIDEjercicioC)
        Me.TabPageSeguimiento.Controls.Add(Me.LblCentroCoste)
        Me.TabPageSeguimiento.Controls.Add(Me.FwiTipoFactura)
        Me.TabPageSeguimiento.Controls.Add(Me.lblfwiIDEjercicio)
        Me.TabPageSeguimiento.Controls.Add(Me.lblfwiCGestion)
        Me.TabPageSeguimiento.Controls.Add(Me.fwiIDEjercicio)
        Me.TabPageSeguimiento.Controls.Add(Me.FraDirFacturacion)
        Me.TabPageSeguimiento.Controls.Add(Me.lblfwiEstado)
        Me.TabPageSeguimiento.Controls.Add(Me.fwiCGestion)
        Me.TabPageSeguimiento.Controls.Add(Me.fwiEstado)
        Me.TabPageSeguimiento.Controls.Add(Me.lblfwiTipoFactura)
        Me.TabPageSeguimiento.Controls.Add(Me.WLFrame7)
        Me.TabPageSeguimiento.Key = "Seguimiento"
        Me.TabPageSeguimiento.Location = New System.Drawing.Point(1, 21)
        Me.TabPageSeguimiento.Name = "TabPageSeguimiento"
        Me.TabPageSeguimiento.Size = New System.Drawing.Size(718, 352)
        Me.TabPageSeguimiento.TabStop = True
        Me.TabPageSeguimiento.Text = "Seguimiento"
        Me.TabPageSeguimiento.Visible = False
        '
        'lblfwiNDocumento
        '
        Me.lblfwiNDocumento.Location = New System.Drawing.Point(10, 169)
        Me.lblfwiNDocumento.Name = "lblfwiNDocumento"
        Me.lblfwiNDocumento.Size = New System.Drawing.Size(72, 13)
        Me.lblfwiNDocumento.TabIndex = 102
        Me.lblfwiNDocumento.Tag = "IdRec=4739;"
        Me.lblfwiNDocumento.Text = "Documento"
        '
        'CmbCentroCoste
        '
        Me.TryDataBinding(CmbCentroCoste, New System.Windows.Forms.Binding("Value", Me, "IDCentroCoste", True))
        CmbCentroCoste_DesignTimeLayout.LayoutString = resources.GetString("CmbCentroCoste_DesignTimeLayout.LayoutString")
        Me.CmbCentroCoste.DesignTimeLayout = CmbCentroCoste_DesignTimeLayout
        Me.CmbCentroCoste.DisabledBackColor = System.Drawing.Color.White
        Me.CmbCentroCoste.EntityName = "CentroCosteAnalitica"
        Me.CmbCentroCoste.Location = New System.Drawing.Point(104, 32)
        Me.CmbCentroCoste.Name = "CmbCentroCoste"
        Me.CmbCentroCoste.PrimaryDataFields = "IDCentroCoste"
        Me.CmbCentroCoste.SecondaryDataFields = "IDCentroCoste"
        Me.CmbCentroCoste.SelectedIndex = -1
        Me.CmbCentroCoste.SelectedItem = Nothing
        Me.CmbCentroCoste.Size = New System.Drawing.Size(134, 21)
        Me.CmbCentroCoste.TabIndex = 2
        Me.CmbCentroCoste.ViewName = "tbMaestroCentroCosteAnalitica"
        '
        'fwiNDocumento
        '
        Me.TryDataBinding(fwiNDocumento, New System.Windows.Forms.Binding("Text", Me, "NDocumento", True))
        Me.fwiNDocumento.DisabledBackColor = System.Drawing.Color.White
        Me.fwiNDocumento.Location = New System.Drawing.Point(104, 166)
        Me.fwiNDocumento.Name = "fwiNDocumento"
        Me.fwiNDocumento.Size = New System.Drawing.Size(187, 21)
        Me.fwiNDocumento.TabIndex = 5
        '
        'lblFwicIDEjercicioC
        '
        Me.lblFwicIDEjercicioC.Location = New System.Drawing.Point(199, 82)
        Me.lblFwicIDEjercicioC.Name = "lblFwicIDEjercicioC"
        Me.lblFwicIDEjercicioC.Size = New System.Drawing.Size(246, 21)
        Me.lblFwicIDEjercicioC.TabIndex = 101
        '
        'LblCentroCoste
        '
        Me.LblCentroCoste.Location = New System.Drawing.Point(8, 36)
        Me.LblCentroCoste.Name = "LblCentroCoste"
        Me.LblCentroCoste.Size = New System.Drawing.Size(83, 13)
        Me.LblCentroCoste.TabIndex = 126
        Me.LblCentroCoste.Text = "Centro Coste"
        Me.LblCentroCoste.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FwiTipoFactura
        '
        Me.TryDataBinding(FwiTipoFactura, New System.Windows.Forms.Binding("Value", Me, "TipoFactura", True))
        FwiTipoFactura_DesignTimeLayout.LayoutString = resources.GetString("FwiTipoFactura_DesignTimeLayout.LayoutString")
        Me.FwiTipoFactura.DesignTimeLayout = FwiTipoFactura_DesignTimeLayout
        Me.FwiTipoFactura.DisabledBackColor = System.Drawing.Color.White
        Me.FwiTipoFactura.DisplayMember = "DescTipoFactura"
        Me.FwiTipoFactura.EntityName = "TipoFactura"
        Me.FwiTipoFactura.Location = New System.Drawing.Point(325, 8)
        Me.FwiTipoFactura.Name = "FwiTipoFactura"
        Me.FwiTipoFactura.PrimaryDataFields = "TipoFactura"
        Me.FwiTipoFactura.SecondaryDataFields = "IDTipoFactura"
        Me.FwiTipoFactura.SelectedIndex = -1
        Me.FwiTipoFactura.SelectedItem = Nothing
        Me.FwiTipoFactura.Size = New System.Drawing.Size(120, 21)
        Me.FwiTipoFactura.TabIndex = 1
        Me.FwiTipoFactura.ValueMember = "IDTipoFactura"
        Me.FwiTipoFactura.ViewName = "tbMaestroTipoFactura"
        '
        'lblfwiIDEjercicio
        '
        Me.lblfwiIDEjercicio.Location = New System.Drawing.Point(8, 86)
        Me.lblfwiIDEjercicio.Name = "lblfwiIDEjercicio"
        Me.lblfwiIDEjercicio.Size = New System.Drawing.Size(55, 13)
        Me.lblfwiIDEjercicio.TabIndex = 98
        Me.lblfwiIDEjercicio.Tag = "IdRec=5081;"
        Me.lblfwiIDEjercicio.Text = "Ejercicio"
        '
        'lblfwiCGestion
        '
        Me.lblfwiCGestion.Location = New System.Drawing.Point(8, 12)
        Me.lblfwiCGestion.Name = "lblfwiCGestion"
        Me.lblfwiCGestion.Size = New System.Drawing.Size(93, 13)
        Me.lblfwiCGestion.TabIndex = 123
        Me.lblfwiCGestion.Tag = "IdRec=5774;"
        Me.lblfwiCGestion.Text = "Centro Gestión"
        '
        'fwiIDEjercicio
        '
        Me.TryDataBinding(fwiIDEjercicio, New System.Windows.Forms.Binding("Text", Me, "IDEjercicio", True))
        Me.fwiIDEjercicio.DisabledBackColor = System.Drawing.Color.White
        Me.fwiIDEjercicio.Enabled = False
        Me.fwiIDEjercicio.Location = New System.Drawing.Point(104, 82)
        Me.fwiIDEjercicio.Name = "fwiIDEjercicio"
        Me.fwiIDEjercicio.Size = New System.Drawing.Size(88, 21)
        Me.fwiIDEjercicio.TabIndex = 1
        '
        'FraDirFacturacion
        '
        Me.FraDirFacturacion.Controls.Add(Me.FwDirFacturacion)
        Me.FraDirFacturacion.Location = New System.Drawing.Point(451, 2)
        Me.FraDirFacturacion.Name = "FraDirFacturacion"
        Me.FraDirFacturacion.Size = New System.Drawing.Size(264, 230)
        Me.FraDirFacturacion.TabIndex = 6
        Me.FraDirFacturacion.TabStop = False
        Me.FraDirFacturacion.Text = "Dirección de envío de la Factura"
        '
        'FwDirFacturacion
        '
        Me.FwDirFacturacion.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FwDirFacturacion.DisabledBackColor = System.Drawing.Color.White
        Me.FwDirFacturacion.Enabled = False
        Me.FwDirFacturacion.Location = New System.Drawing.Point(5, 16)
        Me.FwDirFacturacion.Multiline = True
        Me.FwDirFacturacion.Name = "FwDirFacturacion"
        Me.FwDirFacturacion.Size = New System.Drawing.Size(253, 208)
        Me.FwDirFacturacion.TabIndex = 0
        '
        'lblfwiEstado
        '
        Me.lblfwiEstado.Location = New System.Drawing.Point(8, 61)
        Me.lblfwiEstado.Name = "lblfwiEstado"
        Me.lblfwiEstado.Size = New System.Drawing.Size(45, 13)
        Me.lblfwiEstado.TabIndex = 100
        Me.lblfwiEstado.Tag = "IdRec=4405;"
        Me.lblfwiEstado.Text = "Estado"
        '
        'fwiCGestion
        '
        Me.TryDataBinding(fwiCGestion, New System.Windows.Forms.Binding("Value", Me, "IDCentroGestion", True))
        fwiCGestion_DesignTimeLayout.LayoutString = resources.GetString("fwiCGestion_DesignTimeLayout.LayoutString")
        Me.fwiCGestion.DesignTimeLayout = fwiCGestion_DesignTimeLayout
        Me.fwiCGestion.DisabledBackColor = System.Drawing.Color.White
        Me.fwiCGestion.DisplayMember = "DescCentroGestion"
        Me.fwiCGestion.EntityName = "CentroGestion"
        Me.fwiCGestion.Location = New System.Drawing.Point(104, 8)
        Me.fwiCGestion.Name = "fwiCGestion"
        Me.fwiCGestion.PrimaryDataFields = "IDCentroGestion"
        Me.fwiCGestion.SecondaryDataFields = "IDCentroGestion"
        Me.fwiCGestion.SelectedIndex = -1
        Me.fwiCGestion.SelectedItem = Nothing
        Me.fwiCGestion.Size = New System.Drawing.Size(134, 21)
        Me.fwiCGestion.TabIndex = 0
        Me.fwiCGestion.ValueMember = "IDCentroGestion"
        Me.fwiCGestion.ViewName = "tbMaestroCentroGestion"
        '
        'fwiEstado
        '
        Me.fwiEstado.DisabledBackColor = System.Drawing.Color.White
        Me.fwiEstado.Location = New System.Drawing.Point(104, 57)
        Me.fwiEstado.Name = "fwiEstado"
        Me.fwiEstado.ReadOnly = True
        Me.fwiEstado.Size = New System.Drawing.Size(134, 21)
        Me.fwiEstado.TabIndex = 3
        Me.fwiEstado.TabStop = False
        '
        'lblfwiTipoFactura
        '
        Me.lblfwiTipoFactura.Location = New System.Drawing.Point(243, 12)
        Me.lblfwiTipoFactura.Name = "lblfwiTipoFactura"
        Me.lblfwiTipoFactura.Size = New System.Drawing.Size(76, 13)
        Me.lblfwiTipoFactura.TabIndex = 121
        Me.lblfwiTipoFactura.Tag = "IdRec=5774;"
        Me.lblfwiTipoFactura.Text = "Tipo Factura"
        '
        'WLFrame7
        '
        Me.WLFrame7.Controls.Add(Me.lblfwiNAutofactura)
        Me.WLFrame7.Controls.Add(Me.fwiNAutofactura)
        Me.WLFrame7.Controls.Add(Me.lblfwiIDAutofactura)
        Me.WLFrame7.Location = New System.Drawing.Point(3, 112)
        Me.WLFrame7.Name = "WLFrame7"
        Me.WLFrame7.Size = New System.Drawing.Size(442, 48)
        Me.WLFrame7.TabIndex = 4
        Me.WLFrame7.TabStop = False
        Me.WLFrame7.Text = "Autofactura"
        '
        'lblfwiNAutofactura
        '
        Me.lblfwiNAutofactura.Location = New System.Drawing.Point(14, 21)
        Me.lblfwiNAutofactura.Name = "lblfwiNAutofactura"
        Me.lblfwiNAutofactura.Size = New System.Drawing.Size(120, 13)
        Me.lblfwiNAutofactura.TabIndex = 0
        Me.lblfwiNAutofactura.Text = "Nº Factura de Venta"
        '
        'fwiNAutofactura
        '
        Me.TryDataBinding(fwiNAutofactura, New System.Windows.Forms.Binding("Text", Me, "NFacturaAutofactura", True))
        Me.fwiNAutofactura.DisabledBackColor = System.Drawing.Color.White
        Me.fwiNAutofactura.Location = New System.Drawing.Point(142, 18)
        Me.fwiNAutofactura.Name = "fwiNAutofactura"
        Me.fwiNAutofactura.Size = New System.Drawing.Size(118, 21)
        Me.fwiNAutofactura.TabIndex = 0
        '
        'lblfwiIDAutofactura
        '
        Me.lblfwiIDAutofactura.Location = New System.Drawing.Point(141, 19)
        Me.lblfwiIDAutofactura.Name = "lblfwiIDAutofactura"
        Me.lblfwiIDAutofactura.Size = New System.Drawing.Size(0, 13)
        Me.lblfwiIDAutofactura.TabIndex = 1
        '
        'TabPageDeclaraciones
        '
        Me.TabPageDeclaraciones.Controls.Add(Me.Frame1)
        Me.TabPageDeclaraciones.Controls.Add(Me.CmbTipoOperIntra)
        Me.TabPageDeclaraciones.Controls.Add(Me.LblTipoOperIntra)
        Me.TabPageDeclaraciones.Controls.Add(Me.cbxClaveOperacion)
        Me.TabPageDeclaraciones.Controls.Add(Me.lblClaveOperacion)
        Me.TabPageDeclaraciones.Controls.Add(Me.AdvFtaRectificada)
        Me.TabPageDeclaraciones.Controls.Add(Me.lblFacturaRectificada)
        Me.TabPageDeclaraciones.Controls.Add(Me.fraDeclaracionesIva)
        Me.TabPageDeclaraciones.Key = "Declaraciones"
        Me.TabPageDeclaraciones.Location = New System.Drawing.Point(1, 21)
        Me.TabPageDeclaraciones.Name = "TabPageDeclaraciones"
        Me.TabPageDeclaraciones.Size = New System.Drawing.Size(718, 352)
        Me.TabPageDeclaraciones.TabStop = True
        Me.TabPageDeclaraciones.Text = "Declaraciones"
        '
        'Frame1
        '
        Me.Frame1.Controls.Add(Me.lblNReferencia)
        Me.Frame1.Controls.Add(Me.txtNReferencia)
        Me.Frame1.Controls.Add(Me.chkImportacion)
        Me.Frame1.Location = New System.Drawing.Point(31, 206)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.Size = New System.Drawing.Size(632, 70)
        Me.Frame1.TabIndex = 139
        Me.Frame1.TabStop = False
        Me.Frame1.Text = "Importación/DUA"
        '
        'lblNReferencia
        '
        Me.lblNReferencia.Location = New System.Drawing.Point(232, 33)
        Me.lblNReferencia.Name = "lblNReferencia"
        Me.lblNReferencia.Size = New System.Drawing.Size(86, 13)
        Me.lblNReferencia.TabIndex = 139
        Me.lblNReferencia.Text = "Nº Referencia"
        '
        'txtNReferencia
        '
        Me.TryDataBinding(txtNReferencia, New System.Windows.Forms.Binding("Text", Me, "NReferencia", True))
        Me.txtNReferencia.DisabledBackColor = System.Drawing.Color.White
        Me.txtNReferencia.Location = New System.Drawing.Point(324, 30)
        Me.txtNReferencia.Name = "txtNReferencia"
        Me.txtNReferencia.Size = New System.Drawing.Size(104, 21)
        Me.txtNReferencia.TabIndex = 138
        '
        'chkImportacion
        '
        Me.TryDataBinding(chkImportacion, New System.Windows.Forms.Binding("BindableValue", Me, "Importacion", True))
        Me.chkImportacion.Location = New System.Drawing.Point(56, 27)
        Me.chkImportacion.Name = "chkImportacion"
        Me.chkImportacion.Size = New System.Drawing.Size(120, 24)
        Me.chkImportacion.TabIndex = 137
        Me.chkImportacion.Text = "Importacion"
        '
        'CmbTipoOperIntra
        '
        Me.TryDataBinding(CmbTipoOperIntra, New System.Windows.Forms.Binding("Value", Me, "TipoOperIntra", True))
        CmbTipoOperIntra_DesignTimeLayout.LayoutString = resources.GetString("CmbTipoOperIntra_DesignTimeLayout.LayoutString")
        Me.CmbTipoOperIntra.DesignTimeLayout = CmbTipoOperIntra_DesignTimeLayout
        Me.CmbTipoOperIntra.DisabledBackColor = System.Drawing.Color.White
        Me.CmbTipoOperIntra.DisplayMember = "Text"
        Me.CmbTipoOperIntra.Location = New System.Drawing.Point(147, 39)
        Me.CmbTipoOperIntra.Name = "CmbTipoOperIntra"
        Me.CmbTipoOperIntra.SelectedIndex = -1
        Me.CmbTipoOperIntra.SelectedItem = Nothing
        Me.CmbTipoOperIntra.Size = New System.Drawing.Size(100, 21)
        Me.CmbTipoOperIntra.TabIndex = 1
        Me.CmbTipoOperIntra.ValueMember = "Value"
        '
        'LblTipoOperIntra
        '
        Me.LblTipoOperIntra.Location = New System.Drawing.Point(28, 39)
        Me.LblTipoOperIntra.Name = "LblTipoOperIntra"
        Me.LblTipoOperIntra.Size = New System.Drawing.Size(101, 13)
        Me.LblTipoOperIntra.TabIndex = 138
        Me.LblTipoOperIntra.Text = "Tipo Oper. Intra."
        '
        'cbxClaveOperacion
        '
        Me.TryDataBinding(cbxClaveOperacion, New System.Windows.Forms.Binding("Value", Me, "ClaveOperacion", True))
        cbxClaveOperacion_DesignTimeLayout.LayoutString = resources.GetString("cbxClaveOperacion_DesignTimeLayout.LayoutString")
        Me.cbxClaveOperacion.DesignTimeLayout = cbxClaveOperacion_DesignTimeLayout
        Me.cbxClaveOperacion.DisabledBackColor = System.Drawing.Color.White
        Me.cbxClaveOperacion.DisplayMember = "Text"
        Me.cbxClaveOperacion.Location = New System.Drawing.Point(407, 11)
        Me.cbxClaveOperacion.Name = "cbxClaveOperacion"
        Me.cbxClaveOperacion.SelectedIndex = -1
        Me.cbxClaveOperacion.SelectedItem = Nothing
        Me.cbxClaveOperacion.Size = New System.Drawing.Size(256, 21)
        Me.cbxClaveOperacion.TabIndex = 2
        Me.cbxClaveOperacion.ValueMember = "Value"
        '
        'lblClaveOperacion
        '
        Me.lblClaveOperacion.Location = New System.Drawing.Point(301, 15)
        Me.lblClaveOperacion.Name = "lblClaveOperacion"
        Me.lblClaveOperacion.Size = New System.Drawing.Size(102, 13)
        Me.lblClaveOperacion.TabIndex = 137
        Me.lblClaveOperacion.Text = "Clave Operación"
        '
        'AdvFtaRectificada
        '
        Me.TryDataBinding(AdvFtaRectificada, New System.Windows.Forms.Binding("Value", Me, "IDFacturaRectificada", True))
        Me.AdvFtaRectificada.DisabledBackColor = System.Drawing.Color.White
        Me.AdvFtaRectificada.DisplayField = "NFactura"
        Me.AdvFtaRectificada.EntityName = "FacturaCompraCabecera"
        Me.AdvFtaRectificada.Location = New System.Drawing.Point(147, 11)
        Me.AdvFtaRectificada.Name = "AdvFtaRectificada"
        Me.AdvFtaRectificada.PrimaryDataFields = "IDFacturaRectificada"
        Me.AdvFtaRectificada.SecondaryDataFields = "IDFactura"
        Me.AdvFtaRectificada.Size = New System.Drawing.Size(100, 23)
        Me.AdvFtaRectificada.TabIndex = 0
        '
        'lblFacturaRectificada
        '
        Me.lblFacturaRectificada.Location = New System.Drawing.Point(28, 15)
        Me.lblFacturaRectificada.Name = "lblFacturaRectificada"
        Me.lblFacturaRectificada.Size = New System.Drawing.Size(99, 13)
        Me.lblFacturaRectificada.TabIndex = 136
        Me.lblFacturaRectificada.Text = "Fact. Rectificada"
        '
        'fraDeclaracionesIva
        '
        Me.fraDeclaracionesIva.Controls.Add(Me.ChkOpeTriangular)
        Me.fraDeclaracionesIva.Controls.Add(Me.ChkSectorServicios)
        Me.fraDeclaracionesIva.Controls.Add(Me.ChkEnviar349)
        Me.fraDeclaracionesIva.Controls.Add(Me.chkEnviar347)
        Me.fraDeclaracionesIva.Controls.Add(Me.lblFwiFechaParaDeclaracion)
        Me.fraDeclaracionesIva.Controls.Add(Me.lblFwiNumDeclaracion)
        Me.fraDeclaracionesIva.Controls.Add(Me.chkFechaDeclManual)
        Me.fraDeclaracionesIva.Controls.Add(Me.FwiFechaParaDeclaracion)
        Me.fraDeclaracionesIva.Controls.Add(Me.FwiNumDeclaracion)
        Me.fraDeclaracionesIva.Controls.Add(Me.lblFwiAñoDeclaracion)
        Me.fraDeclaracionesIva.Controls.Add(Me.FwiAñoDeclaracion)
        Me.fraDeclaracionesIva.Location = New System.Drawing.Point(31, 63)
        Me.fraDeclaracionesIva.Name = "fraDeclaracionesIva"
        Me.fraDeclaracionesIva.Size = New System.Drawing.Size(632, 144)
        Me.fraDeclaracionesIva.TabIndex = 3
        Me.fraDeclaracionesIva.TabStop = False
        Me.fraDeclaracionesIva.Tag = ""
        Me.fraDeclaracionesIva.Text = "Declaraciones de Iva"
        '
        'ChkOpeTriangular
        '
        Me.TryDataBinding(ChkOpeTriangular, New System.Windows.Forms.Binding("BindableValue", Me, "OpeTriangular", True))
        Me.ChkOpeTriangular.Location = New System.Drawing.Point(293, 113)
        Me.ChkOpeTriangular.Name = "ChkOpeTriangular"
        Me.ChkOpeTriangular.Size = New System.Drawing.Size(177, 24)
        Me.ChkOpeTriangular.TabIndex = 137
        Me.ChkOpeTriangular.Text = "Operación Triangular"
        '
        'ChkSectorServicios
        '
        Me.TryDataBinding(ChkSectorServicios, New System.Windows.Forms.Binding("BindableValue", Me, "Servicios349", True))
        Me.ChkSectorServicios.Location = New System.Drawing.Point(161, 113)
        Me.ChkSectorServicios.Name = "ChkSectorServicios"
        Me.ChkSectorServicios.Size = New System.Drawing.Size(120, 24)
        Me.ChkSectorServicios.TabIndex = 136
        Me.ChkSectorServicios.Text = "Servicios"
        '
        'ChkEnviar349
        '
        Me.TryDataBinding(ChkEnviar349, New System.Windows.Forms.Binding("BindableValue", Me, "Enviar349", True))
        Me.ChkEnviar349.Location = New System.Drawing.Point(56, 113)
        Me.ChkEnviar349.Name = "ChkEnviar349"
        Me.ChkEnviar349.Size = New System.Drawing.Size(120, 24)
        Me.ChkEnviar349.TabIndex = 135
        Me.ChkEnviar349.Text = "Enviar a 349"
        '
        'chkEnviar347
        '
        Me.TryDataBinding(chkEnviar347, New System.Windows.Forms.Binding("Checked", Me, "Enviar347", True))
        Me.chkEnviar347.Location = New System.Drawing.Point(56, 93)
        Me.chkEnviar347.Name = "chkEnviar347"
        Me.chkEnviar347.Size = New System.Drawing.Size(104, 24)
        Me.chkEnviar347.TabIndex = 4
        Me.chkEnviar347.Text = "Enviar a 347"
        '
        'lblFwiFechaParaDeclaracion
        '
        Me.lblFwiFechaParaDeclaracion.Location = New System.Drawing.Point(326, 80)
        Me.lblFwiFechaParaDeclaracion.Name = "lblFwiFechaParaDeclaracion"
        Me.lblFwiFechaParaDeclaracion.Size = New System.Drawing.Size(141, 13)
        Me.lblFwiFechaParaDeclaracion.TabIndex = 134
        Me.lblFwiFechaParaDeclaracion.Text = "Fecha para Declaración"
        '
        'lblFwiNumDeclaracion
        '
        Me.lblFwiNumDeclaracion.Location = New System.Drawing.Point(56, 52)
        Me.lblFwiNumDeclaracion.Name = "lblFwiNumDeclaracion"
        Me.lblFwiNumDeclaracion.Size = New System.Drawing.Size(108, 13)
        Me.lblFwiNumDeclaracion.TabIndex = 133
        Me.lblFwiNumDeclaracion.Text = "Num. Declaración"
        '
        'chkFechaDeclManual
        '
        Me.TryDataBinding(chkFechaDeclManual, New System.Windows.Forms.Binding("BindableValue", Me, "FechaDeclaracionManual", True))
        Me.chkFechaDeclManual.Location = New System.Drawing.Point(56, 76)
        Me.chkFechaDeclManual.Name = "chkFechaDeclManual"
        Me.chkFechaDeclManual.Size = New System.Drawing.Size(208, 16)
        Me.chkFechaDeclManual.TabIndex = 2
        Me.chkFechaDeclManual.Text = "Fecha Para Declaración Manual"
        '
        'FwiFechaParaDeclaracion
        '
        Me.TryDataBinding(FwiFechaParaDeclaracion, New System.Windows.Forms.Binding("BindableValue", Me, "FechaParaDeclaracion", True))
        Me.FwiFechaParaDeclaracion.DisabledBackColor = System.Drawing.Color.White
        Me.FwiFechaParaDeclaracion.Enabled = False
        Me.FwiFechaParaDeclaracion.Location = New System.Drawing.Point(472, 77)
        Me.FwiFechaParaDeclaracion.Name = "FwiFechaParaDeclaracion"
        Me.FwiFechaParaDeclaracion.Size = New System.Drawing.Size(94, 21)
        Me.FwiFechaParaDeclaracion.TabIndex = 3
        '
        'FwiNumDeclaracion
        '
        Me.TryDataBinding(FwiNumDeclaracion, New System.Windows.Forms.Binding("Text", Me, "NDeclaracionIVA", True))
        Me.FwiNumDeclaracion.DisabledBackColor = System.Drawing.Color.White
        Me.FwiNumDeclaracion.Enabled = False
        Me.FwiNumDeclaracion.Location = New System.Drawing.Point(176, 52)
        Me.FwiNumDeclaracion.Name = "FwiNumDeclaracion"
        Me.FwiNumDeclaracion.Size = New System.Drawing.Size(104, 21)
        Me.FwiNumDeclaracion.TabIndex = 1
        '
        'lblFwiAñoDeclaracion
        '
        Me.lblFwiAñoDeclaracion.Location = New System.Drawing.Point(56, 28)
        Me.lblFwiAñoDeclaracion.Name = "lblFwiAñoDeclaracion"
        Me.lblFwiAñoDeclaracion.Size = New System.Drawing.Size(100, 13)
        Me.lblFwiAñoDeclaracion.TabIndex = 127
        Me.lblFwiAñoDeclaracion.Text = "Año Declaración"
        '
        'FwiAñoDeclaracion
        '
        Me.TryDataBinding(FwiAñoDeclaracion, New System.Windows.Forms.Binding("Text", Me, "AñoDeclaracionIVA", True))
        Me.FwiAñoDeclaracion.DisabledBackColor = System.Drawing.Color.White
        Me.FwiAñoDeclaracion.Enabled = False
        Me.FwiAñoDeclaracion.Location = New System.Drawing.Point(176, 28)
        Me.FwiAñoDeclaracion.Name = "FwiAñoDeclaracion"
        Me.FwiAñoDeclaracion.Size = New System.Drawing.Size(104, 21)
        Me.FwiAñoDeclaracion.TabIndex = 0
        '
        'MntoFacturaCompra
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(728, 623)
        Me.CreateTransaction = True
        Me.EntityName = "FacturaCompraCabecera"
        Me.FindTextField = "NFactura"
        Me.LastUsedDescFields = "NFactura"
        Me.Name = "MntoFacturaCompra"
        Me.NavigationFields = "FechaFactura;NFactura"
        Me.NoEditableControls = New Solmicro.Expertis.Engine.UI.NoEditableControls(New System.Windows.Forms.Control() {Me.fwiNFactura})
        Me.ViewName = "frmMntoFacturaCompra"
        CType(Me.ToolBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MenuBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainPanel.ResumeLayout(False)
        Me.PicCabecera.ResumeLayout(False)
        Me.PicCabecera.PerformLayout()
        CType(Me.Line5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Line8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlLineas.ResumeLayout(False)
        CType(Me.TabFacturas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabFacturas.ResumeLayout(False)
        Me.TabPageLineas.ResumeLayout(False)
        CType(Me.jngLineaFactura, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPageBasesIVA.ResumeLayout(False)
        CType(Me.jngBaseImponible, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPageVencimientos.ResumeLayout(False)
        CType(Me.jngVencimientos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPageDatosEconomicos.ResumeLayout(False)
        Me.FraRetencion.ResumeLayout(False)
        Me.FraRetencion.PerformLayout()
        CType(Me.cbxTipoRetencion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.WLFrame8.ResumeLayout(False)
        Me.WLFrame8.PerformLayout()
        Me.WLFrame6.ResumeLayout(False)
        Me.WLFrame6.PerformLayout()
        Me.WLFrame5.ResumeLayout(False)
        Me.WLFrame5.PerformLayout()
        CType(Me.fwiTipoAsiento, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPageImporteMonedas.ResumeLayout(False)
        Me.TabPageImporteMonedas.PerformLayout()
        CType(Me.Line3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Line1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Line18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Line15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Line19, System.ComponentModel.ISupportInitialize).EndInit()
        Me.WLFrame9.ResumeLayout(False)
        Me.WLFrame9.PerformLayout()
        CType(Me.Line6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Line6.ResumeLayout(False)
        Me.Line6.PerformLayout()
        Me.TabPageTotales.ResumeLayout(False)
        Me.FraMoneda.ResumeLayout(False)
        Me.FraIvaIntrastat.ResumeLayout(False)
        Me.FraIvaIntrastat.PerformLayout()
        CType(Me.Line10, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FraRetenciones.ResumeLayout(False)
        Me.FraRetenciones.PerformLayout()
        CType(Me.CmbTipoRetencionIRPF, System.ComponentModel.ISupportInitialize).EndInit()
        Me.fraCalculoFactura.ResumeLayout(False)
        Me.fraCalculoFactura.PerformLayout()
        CType(Me.Line13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Line11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPageAnotaciones.ResumeLayout(False)
        Me.fraComentarios.ResumeLayout(False)
        Me.fraComentarios.PerformLayout()
        Me.TabPageSeguimiento.ResumeLayout(False)
        Me.TabPageSeguimiento.PerformLayout()
        CType(Me.CmbCentroCoste, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FwiTipoFactura, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FraDirFacturacion.ResumeLayout(False)
        Me.FraDirFacturacion.PerformLayout()
        CType(Me.fwiCGestion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.WLFrame7.ResumeLayout(False)
        Me.WLFrame7.PerformLayout()
        Me.TabPageDeclaraciones.ResumeLayout(False)
        Me.TabPageDeclaraciones.PerformLayout()
        Me.Frame1.ResumeLayout(False)
        Me.Frame1.PerformLayout()
        CType(Me.CmbTipoOperIntra, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbxClaveOperacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.fraDeclaracionesIva.ResumeLayout(False)
        Me.fraDeclaracionesIva.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Const cnABRIRPEDIDOCOMPRA As String = "Abrir Pedido Compra"
    Private Const cnABRIRALBARANCOMPRA As String = "Abrir Albarán Compra"
    Private Const cnABRIROBRA As String = "Abrir Proyecto"
    Private Const cnABRIRORDENTRABAJO As String = "Abrir Orden Trabajo"
    Private Const cnABRIRINMUEBLE As String = "Abrir Inmueble"

    Private mndEntregasACtaProveedor As NeededData
    Private mlngDigitosAuxiliar As Integer
    Private mblnSuFacturaIdProvChanged As Boolean
    Private MStrCContableProv As String
    Private MBlnExpertisSAAS As Boolean
    Private MBlnExpContabilidad As Boolean
    Private mblnCambioPrecioManual As Boolean
    Private mPrecioAnterior As Double

    Protected mblnGestionAnalitica As Boolean
    Protected MonInfoA As MonedaInfo
    Protected MonInfoB As MonedaInfo

    Private mblnValidatingProv As Boolean

    Private WithEvents sctBusquedaDireccion As AdvancedSearch
    Private WithEvents advFacturaCompra As AdvancedSearch
    Private WithEvents advFacturaVenta As AdvancedSearch

    Private mblnStkDobleUnidad As Boolean
    Private MIDArticuloRef As String
    Private mIDCobros(-1) As Integer
    Private mIDRemesa As Integer?
    Private ndImpuestos As ProviderNeededData

#Region " Entregas a Cuenta "

    Private Sub SettingNeededData()
        mndEntregasACtaProveedor = New NeededData("vEntregasACuentaGeneradas", RelationMode.ChildMode, New String() {"IDProveedor"}, New String() {"IDProveedor"})
        Me.AddDataItem(mndEntregasACtaProveedor)
    End Sub

    Private Sub ComprobarEntregasACuenta()
        Me.ErrorProvider1.SetError(Me.lblFwiIDProveedor, String.Empty)
        If Not IsNothing(mndEntregasACtaProveedor.Data) AndAlso mndEntregasACtaProveedor.Data.Rows.Count > 0 Then
            ErrorProvider1.SetIconPadding(Me.lblFwiIDProveedor, 2)
            ErrorProvider1.SetError(Me.lblFwiIDProveedor, "El Proveedor tiene Entregas a Cuenta pendientes.")
        End If
    End Sub

#End Region

#Region " Load "

    Private Sub MntoFacturaCompra_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Not Me.DesignMode Then
            LoadAdvancedSearchSettings()
            LoadFormParams()
            LoadParams()
            LoadToolbarActions()
            LoadGridActions()
            LoadEnums()
            DescripcionMonedasAB()
            SettingDobleUnidad()
            LoadDecimalesControlesCambio()
            LoadNedeedDataImpuestos()
        End If
    End Sub
    Private Sub LoadDecimalesControlesCambio()
        Dim FormatoCambios As String = "#,##0.########"
        fwiCambioA.FormatString = FormatoCambios
        fwiCambioB.FormatString = FormatoCambios
    End Sub
    Private Sub SettingDobleUnidad()
        If Me.jngLineaFactura.Columns.Contains("IDUDInterna2") Then
            Me.jngLineaFactura.Columns("IDUDInterna2").Visible = mblnStkDobleUnidad
            Me.jngLineaFactura.Columns("IDUDInterna2").Position = Me.jngLineaFactura.Columns("IDUDInterna").Position + 1
        End If
        If Me.jngLineaFactura.Columns.Contains("QInterna2") Then
            Me.jngLineaFactura.Columns("QInterna2").Visible = mblnStkDobleUnidad
            Me.jngLineaFactura.Columns("QInterna2").Position = Me.jngLineaFactura.Columns("QInterna").Position + 1
        End If
    End Sub

    Private Sub LoadAdvancedSearchSettings()
        sctBusquedaDireccion = New AdvancedSearch
        sctBusquedaDireccion.EntityName = "ProveedorDireccion"
    End Sub

    Private Sub LoadFormParams()
        Dim ht As Hashtable = Me.Params

        If Not IsNothing(ht) Then
            If Nz(ht("IdFactura"), 0) > 0 Then
                Dim objFilterCriteria As New Filter
                objFilterCriteria.Clear()
                objFilterCriteria.Add(New NumberFilterItem("IDFactura", FilterOperator.Equal, ht("IdFactura")))
                GotoRecord(DataProviderActions.GoRecord, objFilterCriteria, Me.CurrentData)
            End If
            If Length(ht("IDCobros")) > 0 Then mIDCobros = ht("IDCobros")
            If Length(ht("IDRemesa")) > 0 Then mIDRemesa = ht("IDRemesa")
        End If
    End Sub

    Private Sub LoadParams()
        Dim ParamsFC As DataParamFacturaCompra = ExpertisApp.ExecuteTask(Of Object, DataParamFacturaCompra)(AddressOf FacturaCompraCabecera.GetParamsFacturaCompra, Nothing)
        mblnGestionAnalitica = ParamsFC.GestionAnalitica
        MBlnExpertisSAAS = ParamsFC.ExpertisSAAS
        MBlnExpContabilidad = ParamsFC.Contabilidad
        MonInfoA = ParamsFC.MonInfoA
        MonInfoB = ParamsFC.MonInfoB
        mblnStkDobleUnidad = ParamsFC.GestionDobleUnidad

        If Not MBlnExpContabilidad Then
            fwiTipoAsiento.Visible = False
            lblfwiTipoAsiento.Visible = False
            fwiIDEjercicio.Visible = False
            lblfwiIDEjercicio.Visible = False
            lblFwicIDEjercicioC.Visible = False

        End If
        If MBlnExpertisSAAS Then
            lblNObra.Visible = False
            AdvObra.Visible = False
            Me.FraRetencion.Visible = False
        End If

    End Sub

    Private Sub LoadGridDefaultValues()
        With jngLineaFactura
            If Not Me.CurrentRow Is Nothing AndAlso Me.CurrentRow.RowState <> DataRowState.Deleted Then
                .Columns("NFactura").DefaultValue = Me.CurrentRow("NFactura")
                .Columns("IDCentroGestion").DefaultValue = Me.CurrentRow("IDCentroGestion")
                .Columns("Dto").DefaultValue = Nz(Me.CurrentRow("DtoFactura"), 0)
            Else
                .Columns("Dto").DefaultValue = 0
            End If
            .Columns("Cantidad").DefaultValue = 0
            .Columns("Factor").DefaultValue = 1
            .Columns("QInterna").DefaultValue = 0
            .Columns("UdValoracion").DefaultValue = 1
            .Columns("Precio").DefaultValue = 0
            .Columns("Importe").DefaultValue = 0
            .Columns("Dto1").DefaultValue = 0
            .Columns("Dto2").DefaultValue = 0
            .Columns("Dto3").DefaultValue = 0
            If Me.fwiDtoProntoPago.Value <> 0 Then
                .Columns("DtoProntoPago").DefaultValue = Me.fwiDtoProntoPago.Value
            Else
                .Columns("DtoProntoPago").DefaultValue = 0
            End If
            .Columns("TipoGastoObra").DefaultValue = CInt(enumfclTipoGastoObra.enumfclMaterial)
            If Length(AdvObra.Value) > 0 Then
                .Columns("IDObra").DefaultValue = AdvObra.Value
                .Columns("NObra").DefaultValue = AdvObra.Text
            Else
                .Columns("IDObra").DefaultValue = DBNull.Value
                .Columns("NObra").DefaultValue = DBNull.Value
            End If
        End With
    End Sub

    Protected Overridable Sub LoadToolbarActions()
        Me.FormActions.Add("Dirección de Facturación", AddressOf AccionDireccionEnvio, ExpertisApp.GetIcon("find_again.ico"))
        Me.AddSeparator()
        'If MBlnExpContabilidad Then
        '    Me.FormActions.Add("Contabilizar", AddressOf AccionContabilizar, ExpertisApp.GetIcon("import2.ico"))
        '    Me.FormActions.Add("Descontabilizar", AddressOf AccionDescontabilizar, ExpertisApp.GetIcon("export2.ico"))
        '    Me.LblSelloContabilizado.Text = "Contabilizada"
        'Else
        '    Me.FormActions.Add("Validar Factura y crear Pagos en cartera", AddressOf AccionContabilizar, ExpertisApp.GetIcon("import2.ico"))
        '    Me.FormActions.Add("Modificar Factura y eliminar Pagos en cartera", AddressOf AccionDescontabilizar, ExpertisApp.GetIcon("export2.ico"))
        '    Me.LblSelloContabilizado.Text = "Validada"
        'End If
        Me.AddSeparator()
        Me.FormActions.Add("Trazabilidad", AddressOf AccionTrazabilidad)
        Me.AddSeparator()
        Me.FormActions.Add("Generar Autofacturación", AddressOf AccionAutofacturacion)
        If Not MBlnExpertisSAAS Then
            Me.FormActions.Add("Ver / Añadir Entregas a Cuenta", AddressOf AccionVerAñadirEntregasACuenta)
            Me.FormActions.Add("Quitar Entregas a Cuenta", AddressOf AccionQuitarEntregasACuenta)
            If Not MBlnExpertisSAAS Then Me.FormActions.Add("Calcular Precio Optimo", AddressOf AccionPrecioOptimo)
        End If
        Me.FormActions.Add("Imputación de gastos", AddressOf AccionImputacion)

    End Sub

    Private Sub LoadGridActions()
        With jngLineaFactura
            .Actions.Add(cnABRIRPEDIDOCOMPRA, AddressOf AccionAbrirPedidoCompra, ExpertisApp.GetIcon("xPedidoCompra.ico"))
            .Actions.Add(cnABRIRALBARANCOMPRA, AddressOf AccionAbrirAlbaranCompra, ExpertisApp.GetIcon("xAlbaranCompra.ico"))
            .Actions.Add(cnABRIROBRA, AddressOf AccionAbrirProyecto, ExpertisApp.GetIcon("xProyectos.ico"))
            .Actions.Add(cnABRIRORDENTRABAJO, AddressOf AccionAbrirOT, ExpertisApp.GetIcon("xOrdenesFabricacion.ico"))
            .Actions.Add("Abrir Artículo", AddressOf AccionAbrirArticulo, ExpertisApp.GetIcon("xArticulos.ico"))
            .Actions.Add("Imputación de gastos", AddressOf AccionImputacionLinea)
            .Actions.Add("Ver detalle imputación de gastos", AddressOf AccionDetalleImputacion)
            .Actions.Add(cnABRIRINMUEBLE, AddressOf CargarInmueble, ExpertisApp.GetIcon("server_client_exchange.ico"))
        End With
    End Sub

    Private Sub LoadEnums()
        fwiTipoAsiento.DataSource = New EnumData("enumTipoAsiento")
        cbxTipoRetencion.DataSource = New EnumData("enumTipoRetencion")
        cbxClaveOperacion.DataSource = EnumData.EnumView("ClaveOperacion")
        EnumData.PopulateValueList("enumfclTipoGastoObra", jngLineaFactura.Columns("TipoGastoObra"))
        CmbTipoOperIntra.DataSource = New EnumData("enumTipoOperacionIntra")
        CmbTipoRetencionIRPF.DataSource = EnumData.EnumView("TipoRetencionIRPF")
        EnumData.PopulateValueList("enumfcbiOrigen", jngBaseImponible.Columns("Origen"))
    End Sub

    Private Sub DescripcionMonedasAB()
        fwiDescMonedaA.Text = MonInfoA.Texto
        fwiMonedaA.Text = fwiDescMonedaA.Text
        fwiDescMonedaB.Text = MonInfoB.Texto
        fwiMonedaB.Text = fwiDescMonedaB.Text
    End Sub

    Private Sub CalcularTotalVencimientos()
        LblImpTotalVtos.Text = Format(jngVencimientos.GetTotal(jngVencimientos.Columns("ImpVencimiento"), AggregateFunction.Sum), "#,##0.00")
        If CDbl(LblImpTotalVtos.Text) < 0 Then
            LblImpTotalVtos.ForeColor = Color.Red
        Else
            LblImpTotalVtos.ForeColor = Color.Blue
        End If
    End Sub
    Private Sub LoadNedeedDataImpuestos()
        ndImpuestos = New ProviderNeededData
        ndImpuestos.Name = "Impuestos"
        ndImpuestos.EntityName = "FacturaCompraImpuesto"
        Dim s(0) As String
        s(0) = "IDFactura"
        ndImpuestos.PrimaryDataFields = s
        ndImpuestos.SecondaryDataFields = s
        ndImpuestos.RelationMode = RelationMode.ChildMode
        ndImpuestos.ViewName = "vFrmMntoFacturaCompraImpuestos"
        ndImpuestos.UpdateOrder = -1

        Me.AddDataItem(ndImpuestos)
    End Sub
#End Region

#Region " Mnto. Factura "

    Private Sub MntoFacturaCompra_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        If Me.RecordsState = RecordsState.Saved Then
            Dim objFilter As Filter
            If Not IsNothing(Me.CurrentRow) Then
                objFilter = New Filter
                objFilter.Clear()
                objFilter.Add(New NumberFilterItem("IDFactura", Me.CurrentRow("IDFactura")))
            Else
                objFilter = Nothing
            End If
            Me.GotoRecord(DataProviderActions.GoRecord, objFilter, Me.CurrentRow.Table)
        End If
    End Sub

    Protected Overridable Sub BloqueoDatos()
        If Not CurrentRow Is Nothing Then
            Dim blnEnabled As Boolean = False
            If (Me.CurrentRow("Estado") <> enumContabilizado.NoContabilizado) Then
                blnEnabled = True
                Me.fwiVencimientoManual.Enabled = False : Me.fwiIVAManual.Enabled = False
            ElseIf Me.fwiVencimientoManual.Checked OrElse Me.fwiIVAManual.Checked Then
                blnEnabled = True
                Me.fwiVencimientoManual.Enabled = True : Me.fwiIVAManual.Enabled = True
            Else
                blnEnabled = False
                Me.fwiVencimientoManual.Enabled = True : Me.fwiIVAManual.Enabled = True
            End If
            If Length(Me.CurrentRow("AñoDeclaracionIva")) > 0 AndAlso Length(Me.CurrentRow("NDeclaracionIva")) > 0 Then
                blnEnabled = True
            End If

            BloquearInformacion(Me.MainPanel, blnEnabled, fwiEstado, fwiCIF, fwiRazonSocial, fwiDir, fwiTel, _
                                fwiCodPostal, fwiPoblacion, fwiFax, fwiProvincia, FwiIdPais, fwiTextoFactura, _
                                chkEnviar347, ChkEnviar349, ChkSectorServicios, ChkOpeTriangular, jngBaseImponible, fwiMonedaA, fwiMonedaB, _
                                fwiImpLineasNormalesA, fwiImpLineasEspecialesA, fwiImpLineasA, _
                                fwiBaseImpA, fwiImpIVAA, fwiImpReA, fwiImpRecFinanA, fwiImpTotalA, fwiIntrastatA, fwiRetencionA, _
                                fwiImpLineasNormalesB, fwiImpLineasEspecialesB, fwiImpLineasB, _
                                fwiBaseImpB, fwiImpIVAB, fwiImpReB, fwiImpRecFinanB, fwiImpTotalB, fwiIntrastatB, _
                                fwiImpRetencionB, fwiImpLineasNormales, fwiImpLineasEspeciales, fwiImpLinMon, _
                                fwiBaseImpMon, fwiIVA, fwiImpREMon, fwiImpRecFinan, fwiImpTotal, _
                                fwiNFactura, FwiIDContador, fwiTotalBaseImp, fwiTotalIva, fwiTotal, fwiDescMonedaA, _
                                fwiDescMonedaB, fwiIntrastatB, fwiImpRetencion, fwiImpLinMon, fwiImpLineasNormales, _
                                fwiImpLineasEspeciales, fwiBaseImpMon, fwiIVA, fwiImpREMon, _
                                fwiImpRecFinan, fwiImpTotal, fwiIDEjercicio, FwiAñoDeclaracion, FwiNumDeclaracion, fwiVencimientoManual, _
                                fwiIVAManual, chkImportacion, txtNReferencia, fwiSuFactura, chkFechaDeclManual)
            If blnEnabled Then
                HabilitarControlesMoneda()
            End If
        End If
    End Sub

    Private Sub MntoFacturaCompra_Navigated(ByVal sender As Object, ByVal e As Solmicro.Expertis.Engine.UI.NavigatedEventArgs) Handles MyBase.Navigated
        If Not CurrentRow Is Nothing AndAlso Me.RecordsState <> UI.RecordsState.New Then
            If Me.RecordsState = RecordsState.Saved Then
                mblnValidatingProv = False
                ValidarVencimientos()
                fwiTextoFactura.Enabled = True
                GetDireccionFacturacion()
                'BloqueoDatos()
                EstadoRetencion()
                GetEjercicioContable()
                ComprobarEntregasACuenta()
            End If
            MostrarEstadoContabilizacion()
            If Not MBlnExpertisSAAS Then
                If CurrentRow("Estado") <> enumContabilizado.NoContabilizado Then
                    Me.ExecuteActions.Commands("Calcular Precio Optimo").Enabled = Janus.Windows.UI.InheritableBoolean.False
                Else
                    Me.ExecuteActions.Commands("Calcular Precio Optimo").Enabled = Janus.Windows.UI.InheritableBoolean.True
                End If
            End If
            ConfiguracionVencimientoManual(Me.CurrentRow("VencimientosManuales"))
            ConfiguracionIVAManual(Me.CurrentRow("IVAManual"))
            'If MBlnExpContabilidad Then
            '    MStrCContableProv = String.Empty
            '    Dim Dtprov As DataTable = New Proveedor().SelOnPrimaryKey(Me.CurrentRow("IDProveedor"))
            '    If Not Dtprov Is Nothing AndAlso Dtprov.Rows.Count > 0 Then
            '        MStrCContableProv = Dtprov.Rows(0)("CCProveedor")
            '    End If
            'End If
            CalcularTotalVencimientos()
            LoadGridDefaultValues()
            BloqueoDatos()
            ComprobarDeclaracionManual()
        End If
    End Sub

    Private Sub MostrarEstadoContabilizacion()
        fwiEstado.Text = RecuperarDescripcionEnumerado("enumContabilizado", Me.CurrentRow("Estado"))
        LblSelloContabilizado.Text = fwiEstado.Text
        If Not MBlnExpContabilidad Then
            If Me.CurrentRow("Estado") <> enumContabilizado.NoContabilizado Then
                Me.fwiEstado.Text = "Validada"
            Else
                Me.fwiEstado.Text = "Pendiente de Validar"
            End If
        End If
        If (Me.CurrentRow("Estado") <> enumContabilizado.NoContabilizado) Then
            LblSelloContabilizado.Visible = True
        ElseIf Me.fwiVencimientoManual.Checked OrElse Me.fwiIVAManual.Checked Then
            LblSelloContabilizado.Visible = False
        Else
            LblSelloContabilizado.Visible = False
        End If
    End Sub

    Private Sub ComprobarDeclaracionManual()
        If Length(Me.CurrentRow("NDeclaracionIVA")) > 0 AndAlso Length(Me.CurrentRow("AñoDeclaracionIVA")) > 0 Then
            Me.chkFechaDeclManual.Enabled = False
            Me.FwiFechaParaDeclaracion.Enabled = False
            Me.AdvFtaRectificada.Enabled = False
            Me.CmbTipoOperIntra.Enabled = False
            Me.cbxClaveOperacion.Enabled = False

        Else
            Me.chkFechaDeclManual.Enabled = True
            Me.AdvFtaRectificada.Enabled = True
            Me.CmbTipoOperIntra.Enabled = True
            Me.cbxClaveOperacion.Enabled = True
            If chkFechaDeclManual.Checked Then
                FwiFechaParaDeclaracion.Enabled = True
                FwiFechaParaDeclaracion.ReadOnly = False
            Else
                FwiFechaParaDeclaracion.Enabled = False
                FwiFechaParaDeclaracion.ReadOnly = True
            End If
        End If
    End Sub


    'Private Sub MntoFacturaCompra_RecordAdding(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.RecordAdding
    '    LblSelloContabilizado.Visible = False
    '    BloqueoDatos()
    '    '    BloquearInformacion(Me.MainPanel, False, fwiCIF, fwiRazonSocial, fwiDir, fwiTel, fwiCodPostal, fwiPoblacion, fwiFax, fwiProvincia, FwiIdPais, fwiTextoFactura, chkEnviar347, jngBaseImponible)
    '    'fwiIVAManual.Enabled = True
    '    'fwiVencimientoManual.Enabled = True
    '    fwiEstado.Text = String.Empty
    '    FwDirFacturacion.Text = String.Empty
    'End Sub

    Private Sub GetEjercicioContable()
        If Length(fwiIDEjercicio.Text) > 0 Then
            mlngDigitosAuxiliar = Nz(Me.CurrentRow("DigitosAuxiliar"), 0)
            lblFwicIDEjercicioC.Text = Me.CurrentRow("DescEjercicio") & String.Empty
        Else
            lblFwicIDEjercicioC.Text = String.Empty
        End If
    End Sub

    Private Sub GetDireccionFacturacion()
        If Length(Me.CurrentRow("DirFacturacion")) > 0 Then
            FwDirFacturacion.Text = ParseFormatString(CurrentRow("DirFacturacion"), vbNewLine, vbNewLine)
        Else
            FwDirFacturacion.Text = String.Empty
        End If
    End Sub

    Private Sub MntoFacturaCompra_RecordStateChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.RecordStateChanged
        If Me.RecordsState = RecordsState.Saved Then
            ComprobarEntregasACuenta()
        ElseIf Me.RecordsState = RecordsState.[New] Then
            Me.ErrorProvider1.SetError(Me.lblFwiIDProveedor, String.Empty)
        End If
        LoadGridDefaultValues()
    End Sub

    Private Sub MntoFacturaCompra_RecordAdded(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.RecordAdded
        LblSelloContabilizado.Visible = False
        BloqueoDatos()
        AdvObra.Value = Nothing
        fwiEstado.Text = String.Empty
        FwDirFacturacion.Text = String.Empty
        CalcularTotalVencimientos()
        ComprobarDeclaracionManual()
    End Sub

    Private Sub MntoFacturaCompra_RecordUpdated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.RecordUpdated
        mblnValidatingProv = False
        EstadoRetencion()
        CalcularTotalVencimientos()
        LoadGridDefaultValues()
        GenerarRelacionConRemesaCobro()
        GenerarRelacionConCobros()
    End Sub

    Private Sub GenerarRelacionConCobros()
        If Not mIDCobros Is Nothing AndAlso mIDCobros.Length > 0 AndAlso Length(Me.CurrentRow("IDFactura")) > 0 Then
            Dim datGastos(-1) As CobroFacturaCompra.DataCobroFC

            For i As Integer = 0 To mIDCobros.Length - 1
                Dim datGasto As New CobroFacturaCompra.DataCobroFC
                datGasto.IDCobro = mIDCobros(i)
                datGasto.IDFactura = Me.CurrentRow("IDFactura")

                ReDim Preserve datGastos(datGastos.Length)
                datGastos(datGastos.Length - 1) = datGasto
            Next

            If datGastos.Length > 0 Then ExpertisApp.ExecuteTask(Of CobroFacturaCompra.DataCobroFC())(AddressOf CobroFacturaCompra.AddCobroFacturaCompra, datGastos)
            ReDim mIDCobros(-1)
        End If
    End Sub


    Private Sub GenerarRelacionConRemesaCobro()
        If Not mIDRemesa Is Nothing AndAlso Length(Me.CurrentRow("IDFactura")) > 0 Then
            Dim datGastos(-1) As RemesaCobroFacturaCompra.DataRemesaFC

            'Dim RFC As New RemesaCobroFacturaCompra
            'Dim dtGasto As DataTable = RFC.AddNew
            'Dim drNewGasto As DataRow = dtGasto.NewRow
            'drNewGasto("IDRemesa") = mIDRemesa
            'drNewGasto("IDFacturaCompra") = Me.CurrentRow("IDFactura")
            'dtGasto.Rows.Add(drNewGasto)
            'RFC.Update(dtGasto)

            Dim datGasto As New RemesaCobroFacturaCompra.DataRemesaFC
            datGasto.IDRemesa = mIDRemesa
            datGasto.IDFactura = Me.CurrentRow("IDFactura")

            ReDim Preserve datGastos(datGastos.Length)
            datGastos(datGastos.Length - 1) = datGasto
            If datGastos.Length > 0 Then ExpertisApp.ExecuteTask(Of RemesaCobroFacturaCompra.DataRemesaFC())(AddressOf RemesaCobroFacturaCompra.AddRemesaFacturaCompra, datGastos)


            mIDRemesa = Nothing
        End If
    End Sub


    Private Sub MntoFacturaCompra_RecordUpdating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.RecordUpdating
        If Length(fwiSuFactura.Text) = 0 Then
            If ExpertisApp.GenerateMessage("¿Desea que en el campo -Su Factura- se grabe el Número Factura generado?.", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                fwiSuFactura.Text = fwiNFactura.Text
            Else
                e.Cancel = True
                fwiSuFactura.Focus()
            End If
        End If

        ' Si ha cambiado el Proveedor o Su Factura ValidarProveedor
        If mblnSuFacturaIdProvChanged Then e.Cancel = ValidarProveedorSuFactura()
    End Sub
#End Region

#Region " Acciones - Toolbar "

    Protected Overridable Sub AccionDireccionEnvio()
        sctBusquedaDireccion.Open()
    End Sub

    Protected Overridable Sub AccionPrecioOptimo()
        Dim _filter As New Filter
        If Not Me.CurrentRow Is Nothing Then
            If IsNumeric(Me.CurrentRow("IDFactura")) Then
                Me.Cursor = Cursors.WaitCursor
                ExpertisApp.ExecuteTask(Of Integer)(AddressOf FacturaCompraCabecera.PrecioOptimo, Me.CurrentRow("IDFactura"))
                _filter.Add("IDFactura", CurrentRow.Item("idfactura"))
                GotoRecord(DataProviderActions.Refresh, _filter)
                Select Case TabFacturas.SelectedTab.Key
                    Case "Lineas"
                        jngLineaFactura.ReQuery()
                    Case "BaseImponible"
                        jngBaseImponible.ReQuery()
                    Case "Vencimientos"
                        jngVencimientos.ReQuery()
                End Select

                Me.Cursor = Cursors.Default
            End If
        End If
    End Sub

    Protected Overridable Sub AccionTrazabilidad()
        Dim strParameters As String
        If Length(fwiNFactura.Text) > 0 Then
            strParameters = fwiNFactura.Text
            If ExpertisApp.IsFormOpen("TFC") Then ExpertisApp.CloseForm("TFC")
            ExpertisApp.OpenForm("TFC", , strParameters)
        End If
    End Sub

    Private Sub AccionAutofacturacion()
        Dim ClsBE As New BE.DataEngine
        Dim FilFact As New Filter
        Dim DtDatos As New DataTable
        Dim StrValorContador As String
        Dim LngIDFactura As Long
        LngIDFactura = Me.CurrentRow("IdFactura")
        FilFact.Add("IDFactura", FilterOperator.Equal, LngIDFactura)
        DtDatos = ClsBE.Filter("vrptAutofacturaIntra", FilFact)

        If Not DtDatos Is Nothing AndAlso DtDatos.Rows.Count > 0 Then
            'Si tiene datos para la autofacturacion, el NAutofactura sera el valor del contador 'AFCONT' y se lanzara el informe
            If Length(fwiNAutofactura.Text & String.Empty) = 0 Then
                Dim fc As New FacturaCompraCabecera
                StrValorContador = fc.ContadorAutofactura
                If Length(StrValorContador & String.Empty) > 0 Then
                    fwiNAutofactura.Text = StrValorContador
                    Me.UpdateData()
                    Me.RecordsState = RecordsState.Saved
                    If Length(DtDatos.Rows(0)("NFacturaAutoFactura") & String.Empty) = 0 Then
                        DtDatos.Rows(0)("NFacturaAutoFactura") = fwiNAutofactura.Text
                    End If
                End If
            End If
            Dim RptAuto As New Report("AFINTRA")
            RptAuto.DataSource = DtDatos
            ExpertisApp.OpenReport(RptAuto)
        Else
            If Length(fwiNAutofactura.Text & String.Empty) > 0 Then
                ' 13062: "No hay datos para mostrar la Autofacturación."
                ExpertisApp.GenerateMessage("No hay datos para mostrar la Autofacturación.", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                ' 13063: "No hay datos para generar la Autofacturación."
                ExpertisApp.GenerateMessage("No hay datos para generar la Autofacturación.", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Private Sub AccionVerAñadirEntregasACuenta()
        Dim frmVerEntregas As New frmVerEntregasACuenta
        '//Si la factura está contabilizada No permitimos Añadir Entregas a la factura. 
        '//En este caso, sólo permitiremos visualizarlas.
        If Me.CurrentRow("Estado") <> enumContabilizado.NoContabilizado Then
            frmVerEntregas.AñadirEntregas = False
        Else
            frmVerEntregas.AñadirEntregas = True
        End If
        frmVerEntregas.CircuitoOrigen = Circuito.Compras
        frmVerEntregas.IDFactura = Me.CurrentRow("IDFactura")
        frmVerEntregas.IDClienteProveedor = Me.CurrentRow("IDProveedor")
        frmVerEntregas.DescClienteProveedor = lblcFwiIDProveedor.Text
        If frmVerEntregas.ShowDialog(Me) = DialogResult.OK AndAlso frmVerEntregas.AñadirEntregas Then
            Me.Requery.InvokeOnClick()
            CalcularTotalVencimientos()
        End If
    End Sub

    Public Sub AccionQuitarEntregasACuenta()
        Dim frmVerEntregas As New frmVerEntregasACuenta
        '//Si la factura está contabilizada No permitimos Quitar Entregas a la factura. 
        '//En este caso, sólo permitiremos visualizarlas.
        frmVerEntregas.CircuitoOrigen = Circuito.Compras
        frmVerEntregas.IDFactura = Me.CurrentRow("IDFactura")
        frmVerEntregas.IDClienteProveedor = Me.CurrentRow("IDProveedor")
        frmVerEntregas.DescClienteProveedor = lblcFwiIDProveedor.Text
        If Me.CurrentRow("Estado") <> enumContabilizado.NoContabilizado Then
            frmVerEntregas.EliminarEntregas = False
        Else
            frmVerEntregas.EliminarEntregas = True
        End If
        If frmVerEntregas.ShowDialog(Me) = DialogResult.OK AndAlso frmVerEntregas.EliminarEntregas Then
            Me.Requery.InvokeOnClick()
            CalcularTotalVencimientos()
        End If
    End Sub
    Private Sub AccionImputacion()
        If jngLineaFactura.RecordCount > 0 Then
            Dim lst As New List(Of Object)
            Dim dtLineas As DataTable = jngLineaFactura.DataSource
            For Each dr As DataRow In dtLineas.Rows
                lst.Add(dr("IDLineaFactura"))
            Next

            Dim TipoOrigen As PartidaOrigen

            TipoOrigen = PartidaOrigen.FC


            Dim frm As New Solmicro.Expertis.Application.ERP.Rentabilidad.frmRepartoRentabilidad
            frm.AbrirReparto(lst, TipoOrigen)

        Else
            ExpertisApp.GenerateMessage("Debe seleccionar los registros a imputar.", Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Information)
        End If
    End Sub
  
#End Region

#Region " Acciones - Grid "
    Private Sub AccionAbrirPedidoCompra()
        If Length(jngLineaFactura.Value("IdPedido")) > 0 Then
            ExpertisApp.OpenForm("MPEDC", New NumberFilterItem("IdPedido", FilterOperator.Equal, jngLineaFactura.Value("IdPedido")))
        End If
    End Sub

    Private Sub AccionAbrirAlbaranCompra()
        If Length(jngLineaFactura.Value("IdAlbaran")) > 0 Then
            ExpertisApp.OpenForm("MALBC", New StringFilterItem("IdAlbaran", FilterOperator.Equal, jngLineaFactura.Value("IdAlbaran")))
        End If
    End Sub

    Private Sub AccionAbrirProyecto()
        If Length(jngLineaFactura.Value("IdObra")) > 0 Then
            ExpertisApp.OpenForm("MGEO", New NumberFilterItem("IdObra", FilterOperator.Equal, jngLineaFactura.Value("IdObra")))
        End If
    End Sub

    Private Sub AccionAbrirOT()
        If Length(jngLineaFactura.Value("IDOT")) > 0 Then
            ExpertisApp.OpenForm("MNTOOT", New NumberFilterItem("IDOT", FilterOperator.Equal, jngLineaFactura.Value("IDOT")))
        End If
    End Sub

    Private Sub AccionAbrirArticulo()
        ExpertisApp.OpenForm("MARTICULO", New FilterItem("IDArticulo", FilterOperator.Equal, jngLineaFactura.GetValue("IDArticulo")))
    End Sub
    Private Sub AccionImputacionLinea()
        If Length(jngLineaFactura.Value("IDLineaFactura")) > 0 Then
            Dim lst As New List(Of Object)

            lst.Add(jngLineaFactura.Value("IDLineaFactura"))

            Dim TipoOrigen As PartidaOrigen

            TipoOrigen = PartidaOrigen.FC
            Dim vPartida As New BE.DataEngine
            Dim dt As DataTable = vPartida.Filter("vPartidaFacturaCompra", New FilterItem("IDOrigen", FilterOperator.Equal, jngLineaFactura.Value("IDLineaFactura")))
            If dt.Rows.Count > 0 Then
                AccionDetalleImputacion()
            Else
                Dim frm As New Solmicro.Expertis.Application.ERP.Rentabilidad.frmRepartoRentabilidad
                frm.AbrirReparto(lst, TipoOrigen)
            End If

        End If
    End Sub

    Private Sub AccionDetalleImputacion()
        Dim TipoOrigen As PartidaOrigen
        
        TipoOrigen = PartidaOrigen.FC
        Dim frm As New Solmicro.Expertis.Application.ERP.Rentabilidad.frmDetalleReparto

        frm.AbrirDetalle(jngLineaFactura.GetRow.DataRow.row, TipoOrigen)
    End Sub

    Private Sub CargarInmueble()
        Dim strAlias As String = "INMCAB"
        If ExpertisApp.IsFormOpen(strAlias) Then ExpertisApp.CloseForm(strAlias)
        ExpertisApp.OpenForm(strAlias)
    End Sub

#End Region

#Region " TAB "

    Private Sub TabFacturas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabFacturas.Click
        'Dim blnCancel As Boolean
        'If TabFacturas.SelectedTab.Name <> "TabPagePicVencimientos" Then
        '    If Not mblnVntosChecked Then ValidarVencimientos(blnCancel)
        'End If

        'If Not blnCancel Then
        Select Case TabFacturas.SelectedTab.Key
            Case "Vencimientos"
                'If Not mblnVntosChecked Then ValidarVencimientos()
            Case "DatosEconomicos"
                If Length(fwiIdProvBanco.Text) > 0 Then
                    DescripcionBanco()
                Else
                    lblcfwiIdProvBanco.Text = String.Empty
                End If
            Case "Totales"
                AccionCalcularFactura()
        End Select
        'End If
    End Sub

    Private Sub AccionCalcularFactura()
        Dim vImporte As New BE.DataEngine

        Dim dt As DataTable = vImporte.Filter("vFacturaCompraImporte", New FilterItem("IDFactura", FilterOperator.Equal, Me.CurrentRow("IDFactura")))
        If Not dt Is Nothing AndAlso dt.Rows.Count > 0 Then
            fwiImpLineasNormales.Text = dt.Rows(0)("ImporteNormal")
            fwiImpLineasEspeciales.Text = dt.Rows(0)("ImporteEspecial")
        End If

    End Sub
#End Region

#Region " Cabecera "

    Private Function ValidarProveedorSuFactura() As Boolean
        Dim blnCancel As Boolean

        If Length(FwiIDProveedor.Text) > 0 And Length(fwiSuFactura.Text) > 0 And Length(fwiIDEjercicio.Text) > 0 Then
            Dim FilFact As New Filter
            FilFact.Add("IDProveedor", FilterOperator.Equal, FwiIDProveedor.Text)
            FilFact.Add("SuFactura", FilterOperator.Equal, fwiSuFactura.Text)
            FilFact.Add("IDEjercicio", FilterOperator.Equal, fwiIDEjercicio.Text)
            Dim FCC As New FacturaCompraCabecera
            Dim dt As DataTable = FCC.Filter(FilFact)
            If Not IsNothing(dt) Then
                blnCancel = (dt.Rows.Count > 1)
                If blnCancel Then
                    ExpertisApp.GenerateMessage("No pueden haber dos facturas con el mismo -Proveedor- y -Su Factura- para el mismo Ejercicio.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
                dt.Dispose()
            End If
        End If

        Return blnCancel
    End Function

    Private Sub fwiSuFactura_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fwiSuFactura.Validated
        mblnSuFacturaIdProvChanged = True
    End Sub

#End Region

#Region " Pestaña Lineas de Factura "

#Region " jngLineaFactura "

    Private Sub jngLineaFactura_ColumnButtonClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles jngLineaFactura.ColumnButtonClick
        With jngLineaFactura
            Select Case e.Column.Key
                Case "SeguimientoTarifa"
                    CargarSeguimientoTarifa(.Value(e.Column.Key) & String.Empty, .Columns(e.Column.Key).Caption)
            End Select
        End With
    End Sub

    Private Sub jngLineaFactura_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles jngLineaFactura.KeyDown
        If e.KeyCode = Keys.F4 Then
            With jngLineaFactura
                Select Case .Col
                    Case .Columns("NROT").Position
                        'PENDIENTE - B.Avanzada especial (con vista en Entity Name)
                        'CargarConjuntoDeOTs()
                    Case .Columns("SeguimientoTarifa").Position
                        CargarSeguimientoTarifa(.Value("SeguimientoTarifa") & String.Empty, .Columns("SeguimientoTarifa").Caption)
                End Select
            End With
        End If
    End Sub

    Private Sub jngLineaFactura_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles jngLineaFactura.Click
        Try

            Dim hit As GridArea
            With jngLineaFactura
                hit = .HitTest()
                If hit = GridArea.Cell Or hit = GridArea.NewRowCell Then
                    Dim c As GridEXColumn = .ColumnFromPoint()
                    If Not IsNothing(c) Then
                        If Me.RecordsState = RecordsState.Saved Then
                            Select Case c.Key
                                Case "NROT"
                                    'PENDIENTE - B.vazada especial (con vista en Entity Name)
                                    'CargarConjuntoDeOTs()
                                Case "Texto"
                                    FormularioObservaciones()
                                Case "BotonAnalitica"
                                    AbrirAnalitica()
                                Case "Impuestos"
                                    Dim blnSoloLectura As Boolean = (Me.CurrentRow("Estado") <> enumContabilizado.NoContabilizado)
                                    blnSoloLectura = blnSoloLectura OrElse (Length(Me.CurrentRow("AñoDeclaracionIva")) > 0 AndAlso Length(Me.CurrentRow("NDeclaracionIva")) > 0)
                                    CommonClasses.Impuestos(jngLineaFactura, Me.CurrentRow, ndImpuestos.Data, Circuito.Compras, "FacturaCompraImpuesto", "vFrmMntoFacturaCompraImpuestos", "tbFacturaCompraLinea", "FechaFactura", "IDFactura", blnSoloLectura)
                            End Select
                        Else
                            Select Case c.Key
                                Case "Impuestos"
                                    Dim blnSoloLectura As Boolean = (Me.CurrentRow("Estado") <> enumContabilizado.NoContabilizado)
                                    blnSoloLectura = blnSoloLectura OrElse (Length(Me.CurrentRow("AñoDeclaracionIva")) > 0 AndAlso Length(Me.CurrentRow("NDeclaracionIva")) > 0)
                                    If Length(Me.CurrentRow("IDFactura")) > 0 AndAlso Length(jngLineaFactura.Value("IDLineaFactura")) > 0 Then
                                        CommonClasses.Impuestos(jngLineaFactura, Me.CurrentRow, ndImpuestos.Data, Circuito.Compras, "FacturaCompraImpuesto", "vFrmMntoFacturaCompraImpuestos", "tbFacturaCompraLinea", "FechaFactura", "IDFactura", blnSoloLectura)
                                    End If
                            End Select
                        End If
                    End If
                End If
            End With

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub jngLineaFactura_EditingCell(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.EditingCellEventArgs) Handles jngLineaFactura.EditingCell
        Dim blnContabilizado, blnDeclarado As Boolean
        If Not IsNothing(Me.CurrentData) AndAlso Me.CurrentData.Rows.Count Then
            blnContabilizado = (Me.CurrentRow("estado") <> enumContabilizado.NoContabilizado)
            blnDeclarado = (Length(Me.CurrentRow("AñoDeclaracionIVA")) > 0 AndAlso Length(Me.CurrentRow("NDeclaracionIVA")) > 0)
        End If

        With jngLineaFactura
            If Not blnContabilizado AndAlso Not blnDeclarado AndAlso Not Me.fwiIVAManual.Checked AndAlso Not Me.fwiVencimientoManual.Checked Then
                If Not IsDBNull(.Value("EstadoInmovilizado")) AndAlso Not CBool(.Value("EstadoInmovilizado")) Then
                    Select Case e.Column.Key
                        Case "IdArticulo", "RefProveedor"
                            If .Row <> Grid.newTopRowPosition Then
                                e.Column.ButtonStyle = ButtonStyle.NoButton
                                e.Cancel = True
                            Else
                                e.Column.ButtonStyle = ButtonStyle.Image
                                e.Column.EditType = EditType.TextBox
                            End If
                        Case "Cantidad", "QInterna", "QInterna2"
                            If Length(.Value("IDAlbaran")) > 0 Then
                                e.Cancel = True
                            End If
                        Case "IDUDMedida"
                            If Length(.Value("IDAlbaran")) > 0 Then
                                e.Cancel = True
                                e.Column.ButtonStyle = Janus.Windows.GridEX.ButtonStyle.NoButton
                            Else
                                e.Column.EditType = Janus.Windows.GridEX.EditType.TextBox
                                e.Column.ButtonStyle = Janus.Windows.GridEX.ButtonStyle.Image
                            End If
                        Case "CContable", "IDCentroGestion"
                            e.Column.EditType = Janus.Windows.GridEX.EditType.TextBox
                            e.Column.ButtonStyle = Janus.Windows.GridEX.ButtonStyle.Image
                        Case "IDConcepto"
                            .Columns(e.Column.Index).EditType = Janus.Windows.GridEX.EditType.TextBox
                            .Columns(e.Column.Index).ButtonStyle = Janus.Windows.GridEX.ButtonStyle.Image
                            AsignarEntidadSearchConcepto()
                        Case "NObra"
                            e.Column.EditType = Janus.Windows.GridEX.EditType.TextBox
                            e.Column.ButtonStyle = Janus.Windows.GridEX.ButtonStyle.Image
                            If Length(.Value("IDAlbaran")) > 0 AndAlso Length(.Value("IDObraAlbaran")) > 0 Then
                                e.Column.ButtonStyle = ButtonStyle.NoButton
                                e.Cancel = True
                            End If
                        Case "CodTrabajo"
                            e.Column.EditType = Janus.Windows.GridEX.EditType.TextBox
                            e.Column.ButtonStyle = Janus.Windows.GridEX.ButtonStyle.Image
                            If Length(.Value("IDAlbaran")) > 0 AndAlso Length(.Value("IDTrabajoAlbaran")) > 0 Then
                                e.Column.ButtonStyle = ButtonStyle.NoButton
                                e.Cancel = True
                            End If
                        Case "TipoGastoObra"
                            If Length(.Value("IDObra")) > 0 AndAlso Length(.Value("IDAlbaran")) = 0 Then
                                .Columns(e.Column.Index).EditType = Janus.Windows.GridEX.EditType.DropDownList
                            Else
                                e.Cancel = True
                            End If
                        Case "IDLineaPadre"
                            AsignarEntidadSearchLineaConcepto()
                            If Length(.Value("IDAlbaran")) > 0 Then
                                e.Cancel = True
                            End If
                        Case "Importe", "IDPedido", "IDAlbaran", "NROT"
                            e.Cancel = True
                        Case "IdTipoIVA"
                            e.Column.EditType = Janus.Windows.GridEX.EditType.TextBox
                            e.Column.ButtonStyle = Janus.Windows.GridEX.ButtonStyle.Image
                        Case "Dto", "DtoProntoPago"
                            e.Cancel = Nz(.Value("Especial"), 0)
                        Case "SeguimientoTarifa"
                            e.Column.ButtonStyle = Janus.Windows.GridEX.ButtonStyle.Ellipsis
                            e.Cancel = True
                        Case "IDUDInterna", "IDUDInterna2"
                            e.Column.ButtonStyle = ButtonStyle.NoButton
                            e.Cancel = True
                        Case "Factor"
                            e.Cancel = True
                    End Select
                Else
                    e.Cancel = True
                End If
            Else
                If Me.fwiVencimientoManual.Checked Then
                    Select Case e.Column.Key
                        Case "NObra"
                            e.Column.EditType = Janus.Windows.GridEX.EditType.TextBox
                            e.Column.ButtonStyle = Janus.Windows.GridEX.ButtonStyle.Image
                            If Length(.Value("IDAlbaran")) > 0 AndAlso Length(.Value("IDObra")) > 0 Then
                                e.Column.ButtonStyle = ButtonStyle.NoButton
                                e.Cancel = True
                            End If
                        Case "CodTrabajo"
                            e.Column.EditType = Janus.Windows.GridEX.EditType.TextBox
                            e.Column.ButtonStyle = Janus.Windows.GridEX.ButtonStyle.Image
                            If Length(.Value("IDAlbaran")) > 0 AndAlso Length(.Value("IDTrabajo")) > 0 Then
                                e.Column.ButtonStyle = ButtonStyle.NoButton
                                e.Cancel = True
                            End If
                        Case "DescArticulo"
                            e.Column.EditType = Janus.Windows.GridEX.EditType.TextBox
                        Case Else
                            e.Cancel = True
                            e.Column.ButtonStyle = Janus.Windows.GridEX.ButtonStyle.NoButton
                    End Select
                Else
                    e.Cancel = True
                    e.Column.ButtonStyle = Janus.Windows.GridEX.ButtonStyle.NoButton
                End If
            End If
            'If e.Column.Key = "IDArticulo" AndAlso Me.jngLineaFactura.Row <> Grid.newTopRowPosition Then
            '    e.Column.ButtonStyle = ButtonStyle.NoButton
            '    e.Cancel = True
            'End If
        End With
    End Sub

    Private Sub jngLineaFactura_AddingRecord(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles jngLineaFactura.AddingRecord
        If Not ValidarUpdate() Then e.Cancel = True
    End Sub

    Private Sub jngLineaFactura_UpdatingRecord(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles jngLineaFactura.UpdatingRecord
        Try
            With jngLineaFactura
                If Not ValidarUpdate() Then
                    e.Cancel = True
                End If
            End With

        Catch ex As Exception
            e.Cancel = True
            ExpertisApp.GenerateMessage(ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub jngLineaFactura_ColumnsFormatted() Handles jngLineaFactura.ColumnsFormatted
        jngLineaFactura.Columns("BotonAnalitica").Visible = mblnGestionAnalitica
    End Sub

    Private Sub jngLineaFactura_RecordsLoaded() Handles jngLineaFactura.RecordsLoaded
        DesglosarImporteLineas()
    End Sub

    Private Sub jngLineaFactura_RecordsDeleted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles jngLineaFactura.RecordsDeleted
        DesglosarImporteLineas()
        jngLineaFactura.DataSource = TratarOrdenesLinea(jngLineaFactura.DataSource, "IDOrdenLinea", False)
    End Sub

    Private Sub jngLineaFactura_AdvSearchSetPredefinedFilter(ByVal sender As System.Object, ByVal e As Solmicro.Expertis.Engine.UI.GridAdvSearchFilterEventArgs) Handles jngLineaFactura.AdvSearchSetPredefinedFilter
        With jngLineaFactura
            Select Case e.Key
                Case "IDArticulo"
                    e.Filter.Add(New BooleanFilterItem("Activo", FilterOperator.Equal, True))
                    e.Filter.Add(New BooleanFilterItem("Compra", FilterOperator.Equal, True))
                Case "RefProveedor"
                    If Length(FwiIDProveedor.Text) Then
                        e.Filter.Add(New StringFilterItem("IDProveedor", FilterOperator.Equal, FwiIDProveedor.Text))
                    End If
                Case "NObra"
                    'e.Filter.Add(New NumberFilterItem("Estado", FilterOperator.NotEqual, enumocEstado.ocTerminado))
                Case "CodTrabajo"
                    If Length(.Value("IDObra")) > 0 Then
                        e.Filter.Add(New NumberFilterItem("IDObra", FilterOperator.Equal, .Value("IDObra")))
                        e.ForcePredefinedFilter = True
                    End If
                Case "IDLineaPadre"
                    If Length(.Value("IDObra")) > 0 Then
                        e.Filter.Add("IdObra", FilterOperator.Equal, .Value("IDObra"))
                    End If

                    If Length(.Value("IDTrabajo")) > 0 Then
                        e.Filter.Add("IDTrabajo", FilterOperator.Equal, .Value("IDTrabajo"))
                    End If

                    If Length(.Value("IDArticulo")) > 0 AndAlso .Value("TipoGastoObra") = enumfclTipoGastoObra.enumfclMaterial Then
                        e.Filter.Add("IDMaterial", FilterOperator.Equal, .Value("IDArticulo"))
                    End If
                Case "CContable"
                    e.Filter.Add(New StringFilterItem("IDEjercicio", FilterOperator.Equal, fwiIDEjercicio.Text))
                Case "NROT"
                    If Length(.Value("IDArticulo")) > 0 Then
                        e.Filter.Add("IDArticulo", FilterOperator.Equal, .Value("IDArticulo"))
                    End If
            End Select
        End With
    End Sub

    Private Sub jngLineaFactura_AdvSearchSelectionChanged(ByVal sender As Object, ByVal e As Engine.UI.GridAdvSearchSelectionChangedEventArgs) Handles jngLineaFactura.AdvSearchSelectionChanged
        With jngLineaFactura
            Select Case e.Key
                Case "NROT"
                    .Value("IDOT") = e.Selected.Rows(0)("IDOT")
                    Dim dt As DataTable = New BE.DataEngine().Filter("vAdvOTsConPrevisto", New NumberFilterItem("IDOT", e.Selected.Rows(0)("IDOT")))
                    If Not dt Is Nothing AndAlso dt.Rows.Count > 0 Then
                        .Value("IDMntoOTPrev") = dt.Rows(0)("IDMntoOTPrev")
                    End If
                Case "IDLineaPadre"
                    If Not e.Selected Is Nothing AndAlso e.Selected.Rows.Count > 0 Then
                        If Length(e.Selected.Rows(0)("IDTrabajo")) > 0 Then
                            Dim CodTrabajo As String = New ObraTrabajo().SelOnPrimaryKey(e.Selected.Rows(0)("IDTrabajo")).Rows(0)("CodTrabajo")
                            jngLineaFactura.SetValue("CodTrabajo", CodTrabajo)
                        End If
                        If Length(e.Selected.Rows(0)("IDObra")) > 0 Then
                            Dim NObra As String = New ObraCabecera().SelOnPrimaryKey(e.Selected.Rows(0)("IDObra")).Rows(0)("NObra")
                            jngLineaFactura.SetValue("NObra", NObra)
                        End If
                    End If
                Case "RefProveedor"
                    If Not e.Selected Is Nothing AndAlso e.Selected.Rows.Count > 0 Then
                        MIDArticuloRef = e.Selected.Rows(0)("IDArticulo")
                    End If
            End Select
        End With
    End Sub

    Private Sub AsignarEntidadSearchConcepto()
        With jngLineaFactura
            If Length(.Value("TipoGastoObra")) > 0 Then
                For Each Adv As AdvSearchColumn In .AdvSearchColumns
                    If Adv.Key = "IdConcepto" Then
                        .AdvSearchColumns.Remove(Adv)
                        Exit For
                    End If
                Next
                Select Case CType(.Value("TipoGastoObra"), enumfclTipoGastoObra)
                    Case enumfclTipoGastoObra.enumfclGastos
                        .AdvSearchColumns.Add("Gasto", "IdConcepto", "IdGasto")
                    Case enumfclTipoGastoObra.enumfclVarios
                        .AdvSearchColumns.Add("Varios", "IdConcepto", "IdVarios")
                End Select
                .Columns("IDConcepto").ButtonImage = ImageList1.Images(2)
            Else
                .Columns("IDConcepto").ButtonStyle = Janus.Windows.GridEX.ButtonStyle.NoButton
            End If
        End With
    End Sub

    Private Sub AsignarEntidadSearchLineaConcepto()
        With jngLineaFactura
            If Length(.Value("TipoGastoObra")) > 0 Then
                For Each Adv As AdvSearchColumn In .AdvSearchColumns
                    If Adv.Key = "IDLineaPadre" Then
                        .AdvSearchColumns.Remove(Adv)
                        Exit For
                    End If
                Next
                If Length(.Value("IDAlbaran")) = 0 Then
                    Dim Cols As New Engine.UI.ASSelectedColumns
                    If Length(.Value("IDObra")) = 0 Then
                        Dim ColIDObra As New Engine.UI.ASSelectedColumn
                        ColIDObra.GridColumn = "IDObra"
                        ColIDObra.SelectedColumn = "IDObra"
                        Cols.Add(ColIDObra)
                    End If
                    If Length(.Value("IDTrabajo")) = 0 Then
                        Dim ColIDTrab As New Engine.UI.ASSelectedColumn
                        ColIDTrab.GridColumn = "IDTrabajo"
                        ColIDTrab.SelectedColumn = "IDTrabajo"
                        Cols.Add(ColIDTrab)
                    End If
                    Select Case CType(.Value("TipoGastoObra"), enumfclTipoGastoObra)
                        Case enumfclTipoGastoObra.enumfclMaterial
                            .AdvSearchColumns.Add("ObraMaterial", "IDLineaPadre", "IdLineaMaterial", Cols)
                        Case enumfclTipoGastoObra.enumfclGastos
                            .AdvSearchColumns.Add("ObraGasto", "IDLineaPadre", "IdLineaGasto", Cols)
                        Case enumfclTipoGastoObra.enumfclVarios
                            .AdvSearchColumns.Add("ObraVarios", "IDLineaPadre", "IdLineaVarios", Cols)
                    End Select
                    .Columns("IdLineaPadre").ButtonImage = ImageList1.Images(2)
                    .Columns("IdLineaPadre").ButtonStyle = ButtonStyle.Image
                Else
                    .Columns("IdLineaPadre").ButtonStyle = Janus.Windows.GridEX.ButtonStyle.NoButton
                End If
            Else
                .Columns("IdLineaPadre").ButtonStyle = Janus.Windows.GridEX.ButtonStyle.NoButton
            End If
        End With
    End Sub

    Protected Overridable Sub jngLineaFactura_UpdatingCell(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.UpdatingCellEventArgs) Handles jngLineaFactura.UpdatingCell
        With jngLineaFactura
            Select Case e.Column.Key
                Case "CContable"
                    Dim objNegEjercicio As New EjercicioContable
                    Dim strEjercicio As String = Me.CurrentRow("IDEjercicio")
                    Dim intDigitosAuxiliar As Integer = objNegEjercicio.GetNDigitosAuxiliar(strEjercicio)
                    objNegEjercicio = Nothing

                    e.Value = PuntoPorCero(Nz(e.Value, String.Empty), intDigitosAuxiliar, strEjercicio)
                Case "Dto1", "Dto2", "Dto3", "Dto", "DtoProntoPago"
                    If e.Value > 100 Then
                        ExpertisApp.GenerateMessage("El Descuento introducido no puede ser superior a 100%.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        e.Cancel = True
                    End If
            End Select
        End With
    End Sub

    Private Sub jngLineaFactura_RecordAdded(ByVal sender As Object, ByVal e As System.EventArgs) Handles jngLineaFactura.RecordAdded
        jngLineaFactura.DataSource = TratarOrdenesLinea(jngLineaFactura.DataSource, "IDOrdenLinea", True)
    End Sub

    Private Sub jngLineaFactura_RecordUpdated(ByVal sender As Object, ByVal e As System.EventArgs) Handles jngLineaFactura.RecordUpdated
        jngLineaFactura.DataSource = TratarOrdenesLinea(jngLineaFactura.DataSource, "IDOrdenLinea", False)
    End Sub

    Private Sub jngLineaFactura_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles jngLineaFactura.MouseUp
        With jngLineaFactura
            If e.Button = MouseButtons.Right Then
                If Not IsNothing(jngLineaFactura) AndAlso .RowCount > 0 Then
                    .UiCommandManager1.Commands(cnABRIRPEDIDOCOMPRA).IsVisible = IIf(Length(.Value("IDPedido")) > 0, True, False)
                    .UiCommandManager1.Commands(cnABRIRALBARANCOMPRA).IsVisible = IIf(Length(.Value("IDAlbaran")) > 0, True, False)
                    .UiCommandManager1.Commands(cnABRIROBRA).IsVisible = IIf(Length(.Value("IDObra")) > 0, True, False)
                    .UiCommandManager1.Commands(cnABRIRORDENTRABAJO).IsVisible = IIf(Length(.Value("IDOT")) > 0, True, False)
                End If
            End If
        End With
    End Sub

    Private Sub jngLineaFactura_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles jngLineaFactura.GotFocus
        LoadGridDefaultValues()
    End Sub

#End Region

    Private Sub FormularioObservaciones()
        Dim texto As String
        With jngLineaFactura
            Dim frm As New CommonClasses.FormularioTexto
            frm.Texto = .Value("Texto") & String.Empty
            frm.SoloLectura = (Me.CurrentRow("Estado") <> enumContabilizado.NoContabilizado)
            frm.ShowDialog()
            texto = frm.Texto
            frm.Dispose()
            If .Value("Texto") & String.Empty <> texto & String.Empty Then
                .SetValue("Texto", texto)
            End If
        End With
    End Sub

    Private Sub AbrirAnalitica()
        With jngLineaFactura
            If .Row <> Grid.newTopRowPosition And Len(.Value("IDArticulo") & String.Empty) Then
                If ComprobarAnaliticaCuentas(.GetValue("CContable"), Me.CurrentRow("IDEjercicio")) Then
                    Dim frm As New CommonClasses.Analitica
                    frm.EntityName = "FacturaCompraLinea"
                    frm.ViewName = "tbFacturaCompraLinea"
                    frm.jngAnalitica.EntityName = "FacturaCompraAnalitica"
                    frm.jngAnalitica.PrimaryDataFields = "IDLineaFactura"
                    frm.jngAnalitica.SecondaryDataFields = "IDLineaFactura"
                    frm.jngAnalitica.ViewName = "VfrmMntoFacturaCompraAnalitica"
                    frm.SoloLectura = (Me.CurrentRow("Estado") <> enumContabilizado.NoContabilizado)
                    frm.IDMoneda = Me.CurrentRow("IDMoneda")
                    frm.CambioA = Me.CurrentRow("CambioA")
                    frm.CambioB = Me.CurrentRow("CambioB")
                    frm.Fecha = Me.CurrentRow("FechaFactura")
                    frm.FilterCriteria = New NumberFilterItem("IDLineaFactura", FilterOperator.Equal, .Value("IDLineaFactura"))
                    frm.ShowDialog()
                    frm.Dispose()
                End If
            End If
        End With
    End Sub

    Private Function ValidarUpdate() As Boolean
        With jngLineaFactura
            If Len(.Value("IdArticulo") & String.Empty) = 0 Then
                Throw New Exception("El Artículo es un dato obligatorio.")
            ElseIf Len(.Value("DescArticulo") & String.Empty) = 0 Then
                Throw New Exception("La descripción del Artículo es obligatoria.")
            ElseIf Len(.Value("IdTipoIva") & String.Empty) = 0 Then
                Throw New Exception("El Tipo IVA es un dato obligatorio.")
            ElseIf Not IsNumeric(.Value("Cantidad")) Then
                Throw New Exception("Cantidad no válida.")
            ElseIf Not IsNumeric(.Value("Precio")) Or _
            Not IsNumeric(.Value("Dto1")) Or _
            Not IsNumeric(.Value("Dto2")) Or _
            Not IsNumeric(.Value("Dto3")) Or _
            Not IsNumeric(.Value("Factor")) Or _
            Not IsNumeric(.Value("QInterna")) Then
                Throw New Exception("Valor no válido.")
            ElseIf Not IsNumeric(.Value("UdValoracion")) Then
                Throw New Exception("La Unidad de Valoración ha de ser mayor que 0.")
            Else
                If .Value("Cantidad") = 0 Then
                    Throw New Exception("Cantidad no válida.")
                ElseIf .Value("UdValoracion") <= 0 Then
                    Throw New Exception("Valor no válido.")
                ElseIf .Value("Factor") <= 0 Then
                    Throw New Exception("El Factor de conversión no es válido.")
                Else
                    ValidarUpdate = True
                End If
            End If
        End With

    End Function
    Private Sub DesglosarImporteLineas()
        If Not jngLineaFactura.DataSource Is Nothing Then
            Dim dtLineas As DataTable = jngLineaFactura.DataSource.copy

            fwiImpLineasNormales.Value = 0
            fwiImpLineasNormalesA.Value = 0
            fwiImpLineasNormalesB.Value = 0

            fwiImpLineasEspeciales.Value = 0
            fwiImpLineasEspecialesA.Value = 0
            fwiImpLineasEspecialesB.Value = 0


            Dim ImportesNormales As New DataView(dtLineas, "Especial=0", Nothing, DataViewRowState.CurrentRows)
            If ImportesNormales.Count > 0 Then
                For Each drImportes As DataRowView In ImportesNormales
                    If drImportes.Row.RowState <> DataRowState.Deleted Then
                        fwiImpLineasNormales.Value += Nz(drImportes.Row("Importe"), 0)
                        fwiImpLineasNormalesA.Value += Nz(drImportes.Row("ImporteA"), 0)
                        fwiImpLineasNormalesB.Value += Nz(drImportes.Row("ImporteB"), 0)
                    End If
                Next
            End If


            Dim ImportesEspeciales As New DataView(dtLineas, "Especial=1", Nothing, DataViewRowState.CurrentRows)
            If ImportesEspeciales.Count > 0 Then
                For Each drImportes As DataRowView In ImportesEspeciales
                    If drImportes.Row.RowState <> DataRowState.Deleted Then
                        fwiImpLineasEspeciales.Value += Nz(drImportes.Row("Importe"), 0)
                        fwiImpLineasEspecialesA.Value += Nz(drImportes.Row("ImporteA"), 0)
                        fwiImpLineasEspecialesB.Value += Nz(drImportes.Row("ImporteB"), 0)
                    End If
                Next
            End If

            fwiImpLinMon.Value = fwiImpLineasNormales.Value + fwiImpLineasEspeciales.Value
            fwiImpLineasA.Value = fwiImpLineasNormalesA.Value + fwiImpLineasEspecialesA.Value
            fwiImpLineasB.Value = fwiImpLineasNormalesB.Value + fwiImpLineasEspecialesB.Value

        End If
    End Sub

    Private Sub CargarSeguimientoTarifa(ByVal strTexto As String, ByVal strLabel As String)
        Dim frm As New FormularioTexto
        frm.Text = strLabel
        frm.SoloLectura = False
        frm.Texto = strTexto
        frm.ShowDialog()
    End Sub

#End Region

#Region " Pestaña Base Imponible "

#Region " jngBaseImponible "

    Private Sub jngBaseImponible_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles jngBaseImponible.GotFocus
        jngBaseImponible.Columns("Origen").DefaultValue = enumfcbiOrigen.Compra
    End Sub

    Private Sub jngBaseImponible_CellUpdated(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles jngBaseImponible.CellUpdated
        Select Case e.Column.Key
            Case "NFacturaImportacion"
                If Length(Me.jngBaseImponible.GetValue("NFacturaImportacion")) = 0 Then
                    Me.jngBaseImponible.SetValue("IDFacturaImportacion", DBNull.Value)
                End If
        End Select
    End Sub

    Private Sub jngBaseImponible_ColumnButtonClick(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles jngBaseImponible.ColumnButtonClick
        Select Case e.Column.Key
            Case "NFacturaImportacion"
                If Nz(jngBaseImponible.Value("Origen"), enumfcbiOrigen.Compra) = enumfcbiOrigen.Compra Then
                    advFacturaCompra = New AdvancedSearch
                    advFacturaCompra.EntityName = GetType(FacturaCompraCabecera).Name
                    advFacturaCompra.ViewName = "AdvFacturaCompraImportacion"
                    advFacturaCompra.Open()
                Else
                    advFacturaVenta = New AdvancedSearch
                    advFacturaVenta.EntityName = GetType(FacturaVentaCabecera).Name
                    advFacturaVenta.ViewName = "AdvFacturaVentaImportacion"
                    advFacturaVenta.Open()
                End If
        End Select
    End Sub

    Private Sub advFacturaCompraVenta_SelectionChanged(ByVal sender As Object, ByVal e As Solmicro.Expertis.Engine.UI.AdvSearchSelectionChangedEventArgs) Handles advFacturaCompra.SelectionChanged, advFacturaVenta.SelectionChanged
        jngBaseImponible.Value("IDFacturaImportacion") = e.Selected.Rows(0)("IDFactura")
        jngBaseImponible.Value("NFacturaImportacion") = e.Selected.Rows(0)("NFactura")
        jngBaseImponible.Value("RazonSocial") = e.Selected.Rows(0)("RazonSocial")
        jngBaseImponible.Value("IDPais") = e.Selected.Rows(0)("IDPais")
        jngBaseImponible.Value("DescPais") = e.Selected.Rows(0)("DescPais")
        jngBaseImponible.Value("CIF") = e.Selected.Rows(0)("CIF")
    End Sub

    Private Sub jngBaseImponible_EditingCell(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.EditingCellEventArgs) Handles jngBaseImponible.EditingCell
        Select Case e.Column.Key
            Case "TipoIVADUA"
                e.Cancel = (Length(Me.CurrentRow("NReferencia")) = 0)
            Case "BaseImponibleDUA"
                e.Cancel = (Length(Me.CurrentRow("NReferencia")) = 0)
            Case "NFacturaImportacion"
                If Length(Me.CurrentRow("NReferencia")) = 0 Then
                    e.Column.ButtonStyle = ButtonStyle.NoButton
                    e.Cancel = True
                Else
                    jngBaseImponible.Columns(e.Column.Key).ButtonStyle = Janus.Windows.GridEX.ButtonStyle.Image
                    jngBaseImponible.Columns(e.Column.Key).ButtonImage = ImageList1.Images(2)
                End If
            Case "RazonSocial", "IDPais", "CIF"
                If Length(Me.CurrentRow("NReferencia")) > 0 AndAlso Length(jngBaseImponible.Value("NFacturaImportacion")) = 0 Then
                    If e.Column.Key = "IDPais" Then
                        e.Column.ButtonStyle = ButtonStyle.Image
                    End If
                Else
                    e.Column.ButtonStyle = ButtonStyle.NoButton
                    e.Cancel = True
                End If
        End Select
    End Sub

    Private Sub jngBaseImponible_UpdatingRecord(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles jngBaseImponible.UpdatingRecord
        e.Cancel = ValidarBaseImponible()
    End Sub

#End Region

    Private Function ValidarBaseImponible() As Boolean
        Dim blnCancelar As Boolean = False
        With jngBaseImponible
            If Length(.Value("ImpIVA")) = 0 Then
                ExpertisApp.GenerateMessage("Todos los datos son obligatorios.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                blnCancelar = True
                .Focus()
            Else
                If Not IsNumeric(.Value("ImpIVA")) Then
                    ExpertisApp.GenerateMessage("El Importe del IVA ha de ser numérico.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    blnCancelar = True
                    .Focus()
                End If
            End If
            If Length(.GetValue("ImpIVANoDeducible")) > 0 AndAlso .GetValue("ImpIVANoDeducible") <> 0 Then
                Dim DtBases As DataTable = Me.jngBaseImponible.DataSource
                Dim DrSel() As DataRow = DtBases.Select("IDBaseImponible = " & Me.jngBaseImponible.GetValue("IDBaseImponible"))
                If DrSel.Length > 0 Then
                    If Nz(DrSel(0)("ImpIVANoDeducible"), 0) <> Nz(DrSel(0)("ImpIVANoDeducible", DataRowVersion.Original), 0) Then
                        ExpertisApp.GenerateMessage("Debe revisar la contabilización de la factura puesto que tiene importe de iva no deducible.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                End If
            End If
        End With
        Return blnCancelar
    End Function

    'Private Sub fwiIVAManual_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles fwiIVAManual.CheckedChanged
    '    If fwiIVAManual.Checked Then
    '        jngBaseImponible.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.True
    '    Else
    '        jngBaseImponible.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False
    '    End If
    '    jngBaseImponible.Refresh()
    'End Sub
    'Private Sub fwiIVAManual_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fwiIVAManual.CheckedChanged
    '    BloqueoDatos()
    '    ConfiguracionIVAManual(fwiIVAManual.Checked)
    'End Sub
#End Region

#Region " Pestaña Vencimientos "

#Region " jngVencimientos "

    Private Sub jngVencimientos_CellUpdated(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles jngVencimientos.CellUpdated
        Select Case e.Column.Key
            Case "IDFormaPago"
                If Not IsDBNull(jngVencimientos.GetValue("IDFormaPago")) AndAlso Length(jngVencimientos.Value("IDFormaPago")) > 0 Then
                    Dim DtFP As DataTable = New FormaPago().SelOnPrimaryKey(jngVencimientos.GetValue(e.Column.Index))
                    If DtFP Is Nothing OrElse DtFP.Rows.Count = 0 Then
                        ExpertisApp.GenerateMessage("La Forma de Pago no existe.", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        jngVencimientos.SetValue("IDFormaPago", fwiFormaPago.Text)
                    End If
                End If
        End Select
    End Sub

    Private Sub jngVencimientos_AddingRecord(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles jngVencimientos.AddingRecord
        With jngVencimientos
            'Antes de hacer cambios, validar que los campos sean correctos
            If (.GetValue("FechaVencimiento") & String.Empty = String.Empty) OrElse _
            (.GetValue("RecargoFinanciero") & String.Empty = String.Empty) OrElse _
            (.GetValue("ImpVencimiento") & String.Empty = String.Empty) OrElse _
            (.GetValue("IdFormaPago") & String.Empty = String.Empty) Then
                e.Cancel = True
                ExpertisApp.GenerateMessage("Todos los campos son obligatorios.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                .Focus()
            End If

            If Length(.GetValue("RecargoFinanciero")) = 0 OrElse .GetValue("RecargoFinanciero") < 0 Then
                e.Cancel = True
                ExpertisApp.GenerateMessage("El Recargo Financiero ha de ser mayor que 0.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                .Focus()
            End If

            If Length(.GetValue("ImpVencimiento")) = 0 Then
                e.Cancel = True
                ExpertisApp.GenerateMessage("Importe de vencimiento incorrecto.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                .Focus()
            End If

            If Length(.GetValue("FechaVencimiento")) = 0 Then
                e.Cancel = True
                ExpertisApp.GenerateMessage("El campo Fecha Vencimiento ha de ser de tipo Fecha.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                .Focus()
            Else
                .SetValue("FechaVencimientoFactura", .GetValue("FechaVencimiento"))
            End If

            If Not e.Cancel Then
                If CDbl(.GetValue("ImpVencimiento")) > 0 Then
                    'Comprobamos que el recargo Financiero no sea mayor que el Importe del Vencimiento
                    If CDbl(.GetValue("ImpVencimiento")) < CDbl(.GetValue("RecargoFinanciero")) Then
                        e.Cancel = True
                        ExpertisApp.GenerateMessage("El Recargo Financiero no puede ser superior al Importe del Vencimiento.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        .Focus()
                    End If
                End If
            End If
        End With


        If Not e.Cancel Then
            jngVencimientos.SetValue("Titulo", fwiRazonSocial.Text)
            jngVencimientos.SetValue("CContable", Me.CurrentRow("CCProveedor") & String.Empty)
            If Length(Me.CurrentRow("CCProveedor")) > 0 Then
                Dim cd As New ProveedorDireccion
                Dim StDatosDirec As New ProveedorDireccion.DataDirecDe
                StDatosDirec.IDDireccion = Me.CurrentRow("IdDireccion")
                StDatosDirec.TipoDireccion = enumpdTipoDireccion.pdDireccionPago
                If ExpertisApp.ExecuteTask(Of ProveedorDireccion.DataDirecDe, Boolean)(AddressOf ProveedorDireccion.EsDireccionDe, StDatosDirec) = True Then
                    jngVencimientos.SetValue("IDDireccion", Me.CurrentRow("IDDireccion") & String.Empty)
                Else
                    Dim StDatosDirecEnv As New ProveedorDireccion.DataDirecEnvio
                    StDatosDirecEnv.IDProveedor = Me.CurrentRow("IDProveedor")
                    StDatosDirecEnv.TipoDireccion = enumpdTipoDireccion.pdDireccionPago
                    Dim direc As DataTable = ExpertisApp.ExecuteTask(Of ProveedorDireccion.DataDirecEnvio, DataTable)(AddressOf ProveedorDireccion.ObtenerDireccionEnvio, StDatosDirecEnv)
                    If Not IsNothing(direc) AndAlso direc.Rows.Count Then
                        jngVencimientos.SetValue("IDDireccion", direc.Rows(0)("IDDireccion") & String.Empty)
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub jngVencimientos_UpdatingRecord(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles jngVencimientos.UpdatingRecord
        With jngVencimientos
            'Antes de hacer cambios, validar que los campos sean correctos
            If (.Value(.Columns("FechaVencimiento").Index) & String.Empty = String.Empty) Or _
            (.Value(.Columns("RecargoFinanciero").Index) & String.Empty = String.Empty) Or _
            (.Value(.Columns("ImpVencimiento").Index) & String.Empty = String.Empty) Or _
            (.Value(.Columns("IdFormaPago").Index) & String.Empty = String.Empty) Then
                '1487-Todos los campos son obligatorios
                e.Cancel = True
                ExpertisApp.GenerateMessage("Todos los campos son obligatorios.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                .Focus()
            End If

            If Not IsNumeric(.Value(.Columns("RecargoFinanciero").Index)) Or _
            .Value(.Columns("RecargoFinanciero").Index) < 0 Then
                '1602-El Recargo Financiero ha de ser mayor que 0
                e.Cancel = True
                ExpertisApp.GenerateMessage("El Recargo Financiero ha de ser mayor que 0.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                .Focus()
            End If

            If Not IsNumeric(.Value(.Columns("ImpVencimiento").Index)) Then
                e.Cancel = True
                '6448: "Importe de vencimiento incorrecto."
                ExpertisApp.GenerateMessage("Importe de vencimiento incorrecto.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                .Focus()
            End If

            If Not IsDate(.Value(.Columns("FechaVencimiento").Index)) Then
                '1604-El campo Fecha Vencimiento ha de ser de tipo Fecha
                e.Cancel = True
                ExpertisApp.GenerateMessage("El campo Fecha Vencimiento ha de ser de tipo Fecha.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                .Focus()
            End If

            If Not e.Cancel Then
                If CDbl(.Value(.Columns("ImpVencimiento").Index)) > 0 Then
                    'Comprobamos que el recargo Financiero no sea mayor que el Importe del Vencimiento
                    If CDbl(.Value(.Columns("ImpVencimiento").Index)) < CDbl(.Value(.Columns("RecargoFinanciero").Index)) Then
                        '5617- El Recargo Financiero no puede ser superior al Importe del Vencimiento
                        e.Cancel = True
                        ExpertisApp.GenerateMessage("El Recargo Financiero no puede ser superior al Importe del Vencimiento.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        .Focus()
                    End If
                End If
            End If
        End With
    End Sub

    Private Sub jngVencimientos_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles jngVencimientos.GotFocus
        With jngVencimientos
            .Columns("IdFormaPago").DefaultValue = fwiFormaPago.Text
            .Columns("RecargoFinanciero").DefaultValue = 0
            .Columns("IDMoneda").DefaultValue = Me.CurrentRow(("IDMoneda"))
            .Columns("IdProveedorBanco").DefaultValue = Me.CurrentRow(("IdProveedorBanco"))
            .Columns("IDBancoPropio").DefaultValue = Me.CurrentRow(("IDBancoPropio"))
            .Columns("NFactura").DefaultValue = Me.CurrentRow(("NFactura"))
            .Columns("IDFactura").DefaultValue = Me.CurrentRow(("IDFactura"))
            .Columns("CambioA").DefaultValue = Me.CurrentRow(("CambioA"))
            .Columns("CambioB").DefaultValue = Me.CurrentRow(("CambioB"))
            .Columns("IDProveedor").DefaultValue = Me.CurrentRow(("IDProveedor"))
            .Columns("Titulo").DefaultValue = Me.CurrentRow(("RazonSocial"))
            .Columns("CContable").DefaultValue = Me.CurrentRow("CCProveedor")
            If Length(Me.CurrentRow("IDTipoAsiento")) > 0 Then
                Select Case CInt(Me.CurrentRow("IdTipoAsiento"))
                    Case enumTipoAsiento.taBancoSinPago
                        .Columns("Contabilizado").DefaultValue = enumPagoContabilizado.PagoContabilizado
                        .Columns("Situacion").DefaultValue = enumPagoSituacion.Pagado
                    Case enumTipoAsiento.taProveedorConPagoNPyNC
                        .Columns("Contabilizado").DefaultValue = enumPagoContabilizado.PagoNoContabilizado
                        .Columns("Situacion").DefaultValue = enumPagoSituacion.NoPagado
                    Case enumTipoAsiento.taProveedorConPagoPyNC
                        .Columns("Contabilizado").DefaultValue = enumPagoContabilizado.PagoNoContabilizado
                        .Columns("Situacion").DefaultValue = enumPagoSituacion.Pagado
                    Case enumTipoAsiento.taProveedorSinPago
                        .Columns("Contabilizado").DefaultValue = enumPagoContabilizado.PagoContabilizado
                        .Columns("Situacion").DefaultValue = enumPagoSituacion.Pagado
                End Select
            End If
        End With
    End Sub

    Private Sub jngVencimientos_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles jngVencimientos.LostFocus
        'Comprobamos que la suma de Vencimientos no supera el importe total de la factura
        If TabFacturas.SelectedTab.Index <> TabFacturas.TabPages("Vencimientos").Index Then
            If jngVencimientos.EditMode = Janus.Windows.GridEX.EditMode.EditOn Or jngVencimientos.DataChanged Then
                jngVencimientos.Update()
            End If
            'ValidarVencimientos()
            'Else
            '    mblnVntosChecked = False
        End If
    End Sub

    Private Function ComprobarVencimientos() As Double
        If Not Me.CurrentRow Is Nothing Then
            If Me.CurrentData.Rows.Count > 0 Then
                If Me.CurrentRow("estado") = enumContabilizado.NoContabilizado Then
                    If fwiVencimientoManual.Checked Then
                        If jngVencimientos.RowCount > 0 Then
                            Dim jFilter As New GridEXFilterCondition(jngVencimientos.Columns("CobroCompensacion"), ConditionOperator.Equal, 0)
                            Dim dblTotal As Double = xRound(jngVencimientos.GetTotal(jngVencimientos.Columns("ImpVencimiento"), Janus.Windows.GridEX.AggregateFunction.Sum, jFilter), MonInfoA.NDecimalesImporte)
                            Return dblTotal - fwiTotal.Value
                        End If
                    End If
                End If
            End If
        End If
    End Function

    Private Sub ValidarVencimientos(Optional ByRef blnCancel As Boolean = False, Optional ByVal blnSelectTab As Boolean = True)
        Dim mdblDiff As Double = ComprobarVencimientos()
        If mdblDiff <> 0 Then
            ExpertisApp.GenerateMessage("La suma de los Vencimientos no coincide con el Importe de la Factura. Diferencia: |", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, mdblDiff)
            blnCancel = True
            If blnSelectTab Then If Not TabFacturas.TabPages("Vencimientos").Selected Then TabFacturas.TabPages("Vencimientos").Selected = True
            jngVencimientos.Focus()
            jngVencimientos.Col = jngVencimientos.Columns("ImpVencimiento").Index
            jngVencimientos.EditMode = Janus.Windows.GridEX.EditMode.EditOn
        End If
    End Sub

    Private Sub jngVencimientos_RecordUpdated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles jngVencimientos.RecordUpdated, jngVencimientos.RecordAdded
        ValidarVencimientos()
    End Sub

#End Region

    'Private Sub fwiVencimientoManual_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles fwiVencimientoManual.CheckedChanged
    '    'If Me.RecordsState = RecordsState.Modified Then
    '    If fwiVencimientoManual.Checked Then
    '        jngVencimientos.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.True
    '        jngVencimientos.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.True
    '        jngVencimientos.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.True
    '    Else
    '        jngVencimientos.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False
    '        jngVencimientos.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.False
    '        jngVencimientos.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.False
    '    End If
    '    jngVencimientos.Refresh()
    'End Sub

    'Private Sub fwiVencimientoManual_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fwiVencimientoManual.CheckedChanged
    '    'BloqueoDatos()
    '    'ConfiguracionVencimientoManual(fwiVencimientoManual.Checked)
    '    If Me.RecordsState <> UI.RecordsState.Saved AndAlso Me.fwiVencimientoManual.Checked Then
    '        ExpertisApp.GenerateMessage("Debe salvar los datos antes de poder establecer a vencimiento manual la factura actual.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    '        Me.fwiVencimientoManual.Checked = False
    '    End If
    'End Sub
#End Region

#Region " Pestaña de Datos Eccos. "

    Private Sub fwiIdProvBanco_SetPredefinedFilter(ByVal sender As System.Object, ByVal e As Solmicro.Expertis.Engine.UI.AdvSearchFilterEventArgs) Handles fwiIdProvBanco.SetPredefinedFilter
        e.Filter.Add("IDProveedor", FilterOperator.Equal, FwiIDProveedor.Text)
    End Sub

    Private Sub fwiIdProvBanco_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles fwiIdProvBanco.Validating
        If Trim(fwiIdProvBanco.Text) <> String.Empty Then
            DescripcionBanco()
        Else
            lblcfwiIdProvBanco.Text = String.Empty
        End If
    End Sub

    Private Sub DescripcionBanco()
        Dim DtProvBanco As DataTable = New ProveedorBanco().SelOnPrimaryKey(fwiIdProvBanco.Text)
        If Not DtProvBanco Is Nothing AndAlso DtProvBanco.Rows.Count > 0 Then
            Dim DtBanco As DataTable = New Banco().SelOnPrimaryKey(DtProvBanco.Rows(0)("IDBanco"))
            If Not DtBanco Is Nothing AndAlso DtBanco.Rows.Count > 0 Then
                lblcfwiIdProvBanco.Text = DtBanco.Rows(0)("DescBanco")
            End If
        End If
    End Sub

#End Region

#Region " Pestaña de Seguimiento "

    Private Sub fwiRetencionManual_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fwiRetencionManual.CheckedChanged
        If Not IsNothing(Me.CurrentRow) Then
            EstadoRetencion()
        End If
    End Sub

    Private Sub fwiEstado_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fwiEstado.DoubleClick
        'INC10210. Eliminar la posibilidad de contabilizar/descontabilizar mediante dbl click sobre el estado
        'If Not MBlnExpertisSAAS Then
        '    If Me.CurrentRow("estado") = enumContabilizado.NoContabilizado Then
        '        If ExpertisApp.GenerateMessage("Va a dar por contabilizada la factura.", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
        '            'Me.CurrentRow("estado") = enumfvcEstado.fvcContabilizado
        '        End If
        '    ElseIf Me.CurrentRow("estado") = enumContabilizado.Contabilizado Then
        '        If ExpertisApp.GenerateMessage("Va a dar por no contabilizada la factura.", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
        '            'Me.CurrentRow("estado") = enumfvcEstado.fvcNoContabilizado
        '        End If
        '    End If
        'fin INC10210

        '    ExpertisApp.ExecuteTask(Of DataTable)(AddressOf FacturaCompraCabecera.CambiarEstadoFactura, Me.CurrentData)
        '    Me.Requery.InvokeOnClick()
        'End If

        'fwiEstado.Text = RecuperarDescripcionEnumerado("enumfccEstado", Me.CurrentRow("Estado"))

        'Dim blnEnabled As Boolean = (Me.CurrentRow("Estado") = enumfvcEstado.fvcContabilizado)
        'LblSelloContabilizado.Visible = (Me.CurrentRow("Estado") = enumfvcEstado.fvcContabilizado)
        'BloquearInformacion(Me.MainPanel, blnEnabled, fwiEstado, fwiCIF, fwiRazonSocial, fwiDir, fwiTel, fwiCodPostal, fwiPoblacion, fwiFax, fwiProvincia, FwiIdPais, fwiTextoFactura, chkEnviar347, jngBaseImponible)
    End Sub

    'Private Sub fwiEstado_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles fwiEstado.TextChanged
    '    If Me.CurrentRow("Estado") = enumfccEstado.fccContabilizado Then
    '        Me.LblSelloContabilizado.Visible = True
    '    Else
    '        Me.LblSelloContabilizado.Visible = False
    '    End If
    'End Sub

    Private Sub FwiIDDireccion_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FwiIDDireccion.TextChanged
        GetDireccionFacturacion()
    End Sub

#Region " Control FwSearch -  Se ha convertido en una B.Avanzada por código"

    Private Sub sctBusquedaDireccion_SetPredefinedFilter(ByVal sender As Object, ByVal e As Engine.UI.AdvSearchFilterEventArgs) Handles sctBusquedaDireccion.SetPredefinedFilter
        'En el botón de búsqueda de direcciones de factura hacemos que únicamente salgan aquellas
        'correspondiente al proveedor seleccionado.
        e.Filter.Add("IdProveedor", FilterOperator.Equal, FwiIDProveedor.Text)
        'e.Filter.Add("Tipo", FilterOperator.Equal, enumpdTipoDireccion.pdDireccionFactura)
        e.Filter.Add(New BooleanFilterItem("Factura", FilterOperator.Equal, True))
    End Sub

    Private Sub sctBusquedaDireccion_SelectionChanged(ByVal sender As Object, ByVal e As Engine.UI.AdvSearchSelectionChangedEventArgs) Handles sctBusquedaDireccion.SelectionChanged
        ' Cambia el id de la dirección seleccionada en la búsqueda
        Me.CurrentRow("IDDireccion") = e.Selected.Rows(0)("IDDireccion")
        GetDireccionFacturacion()
    End Sub

#End Region

#End Region

    Private Sub EstadoRetencion()
        If (Not IsNothing(Me.CurrentData)) AndAlso (Me.CurrentData.Rows.Count > 0) Then
            If Me.CurrentRow("Estado") <> enumContabilizado.NoContabilizado Then
                fwiBaseRetencion.Enabled = False
            Else
                fwiBaseRetencion.Enabled = fwiRetencionManual.Checked
            End If

        End If
    End Sub

#Region " BUSINESSCALLING "

    Private Sub MntoFacturaCompra_BusinessCalling(ByVal sender As Object, ByVal e As Engine.UI.BusinessCallingEventArgs) Handles MyBase.BusinessCalling
        Dim dr As DataRow
        Select Case e.EntityName
            Case "FacturaCompraCabecera"
                If e.Data.NewData.Contains("FechaFactura") Then
                    Me.CurrentRow("IDEjercicio") = System.DBNull.Value
                End If
            Case jngLineaFactura.EntityName
                mblnCambioPrecioManual = False
                dr = Me.CurrentRow
                e.Data.Context.Clear()
                e.Data.SetContext(dr)
                e.Data.Context.Add("Fecha", New Date(CDate(fwiFecFactura.Text).Year, CDate(fwiFecFactura.Text).Month, CDate(fwiFecFactura.Text).Day))
                mPrecioAnterior = Nz(e.Data.CurrentData("Precio"), 0)
                If e.Data.NewData.Contains("Precio") Then
                    mblnCambioPrecioManual = True
                End If
                If MIDArticuloRef <> String.Empty Then e.Data.Context.Add("IDArticuloRef", MIDArticuloRef)
            Case jngVencimientos.EntityName  'Vencimientos
                e.Data.Context.Clear()
                e.Data.Context.Add("Estado", Me.CurrentRow("Estado"))
                e.Data.Context.Add("VencimientosManuales", fwiVencimientoManual.Checked)
                e.Data.Context.Add("RetencionIRPF", Me.CurrentRow("RetencionIRPF"))
                e.Data.Context.Add("BaseImponible", Me.CurrentRow("BaseImponible"))
                e.Data.Context.Add("IdMoneda", fwiIdMoneda.Text)
                e.Data.Context.Add("ImpTotal", Me.CurrentRow("ImpTotal"))
                e.Data.Context.Add("ImpRecFinan", Me.CurrentRow("ImpRecFinan"))
                e.Data.Context.Add("IDFactura", Me.CurrentRow("IDFactura"))
            Case ndImpuestos.EntityName
                e.Cancel = True
            Case jngBaseImponible.EntityName
                'Gestión cambio base imponible para ajustar facturas 
                e.Data.Context = New BusinessData(Me.CurrentRow)

        End Select
    End Sub

    Private Sub MntoFacturaCompra_BusinessCalled(ByVal sender As Object, ByVal e As Engine.UI.BusinessCalledEventArgs) Handles Me.BusinessCalled
        Select Case e.EntityName
            Case jngLineaFactura.EntityName
                If jngLineaFactura.Row <> Grid.newTopRowPosition AndAlso Not mblnCambioPrecioManual AndAlso mPrecioAnterior <> e.Data("Precio") Then
                    If ExpertisApp.GenerateMessage("Ha cambiado el precio de manera automática. ¿Desea mantener el precio anterior?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                        e.Data = New FacturaVentaLinea().ApplyBusinessRule("Precio", mPrecioAnterior, e.Data, New BusinessData(Me.CurrentRow))
                    End If
                End If
                MIDArticuloRef = String.Empty
        End Select
    End Sub

#End Region

#Region " Debería estar en Negocio, pero necesita interacción con el usuario "

    Private Sub ComprobarUnidadesMedida(ByVal objGrid As Solmicro.Expertis.Engine.UI.Grid, _
                                      ByVal strNombreQMedida As String, _
                                      ByVal strNombreQInterna As String, _
                                      ByVal strNombreUdMedida As String, _
                                      ByVal strNombreUdInterna As String)
        With objGrid
            If (.Value(.Columns(strNombreUdMedida).Index) = .Value(.Columns(strNombreUdInterna).Index)) Then
                If (.Value(.Columns(strNombreQMedida).Index) <> CDbl(.Value(.Columns(strNombreQInterna).Index))) And _
                (.Value(.Columns("Factor").Index) <> 1) Then
                    'mblnRecalcular = False
                    ' 12576: Las unidades de medida son iguales, pero las cantidades son diferentes. El Factor de conversión debería ser 1. ¿Desea que Factor=1?
                    If ExpertisApp.GenerateMessage("Las unidades de medida son iguales, pero las cantidades son diferentes. El Factor de conversión debería ser 1. ¿Desea que Factor=1?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                        .Value(.Columns("Factor").Index) = 1
                    End If
                End If
            End If
        End With
    End Sub

#End Region

    Private Sub chkFechaDeclManual_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkFechaDeclManual.CheckedChanged
        ComprobarDeclaracionManual()
    End Sub

    Private Sub ConfiguracionIVAManual(ByVal EsManual As Boolean)
        If EsManual AndAlso Me.CurrentRow("Estado") = enumContabilizado.NoContabilizado Then
            jngBaseImponible.AllowEdit = InheritableBoolean.True
        Else
            jngBaseImponible.AllowEdit = InheritableBoolean.False
        End If
    End Sub

    Private Sub ConfiguracionVencimientoManual(ByVal EsManual As Boolean)
        If EsManual AndAlso Me.CurrentRow("Estado") = enumContabilizado.NoContabilizado Then
            jngVencimientos.AllowEdit = InheritableBoolean.True
            jngVencimientos.AllowAddNew = InheritableBoolean.True
            jngVencimientos.AllowDelete = InheritableBoolean.True

            jngVencimientos.Columns("IDFormaPago").ButtonStyle = Janus.Windows.GridEX.ButtonStyle.Image
            fwiFormaPago.Enabled = False
        Else
            jngVencimientos.AllowEdit = InheritableBoolean.False
            jngVencimientos.AllowAddNew = InheritableBoolean.False
            jngVencimientos.AllowDelete = InheritableBoolean.False

            jngVencimientos.Columns("IDFormaPago").ButtonStyle = Janus.Windows.GridEX.ButtonStyle.NoButton
            fwiFormaPago.Enabled = True
        End If
    End Sub

   
    Private Sub fwiVencimientoManual_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fwiVencimientoManual.Click
        If fwiVencimientoManual.Checked Then
            Dim dtGridVtos As DataTable = jngVencimientos.DataSource
            Dim objFilter As New Filter
            objFilter.Add(New IsNullFilterItem("IDEntrega", False))
            Dim adr() As DataRow = dtGridVtos.Select(objFilter.Compose(New AdoFilterComposer))
            If Not IsNothing(adr) AndAlso adr.Length > 0 Then
                ExpertisApp.GenerateMessage("Existen Vencimientos provenientes de Entregas a Cuenta.|" & _
                "No es posible establecer los Vencimientos de forma automática.", MessageBoxButtons.OK, MessageBoxIcon.Information, vbNewLine)
                fwiVencimientoManual.Checked = False
            End If
        End If
    End Sub

    Private Sub fwiTextoFactura_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fwiTextoFactura.DoubleClick
        Dim frm As New FormularioTexto
        frm.Texto = fwiTextoFactura.Text & String.Empty
        frm.CrearObservaciones = True
        Dim res As DialogResult = frm.ShowDialog()
        If res = DialogResult.OK Then
            If fwiTextoFactura.Text & String.Empty <> frm.Texto Then
                fwiTextoFactura.Text = frm.Texto
            End If
        End If
    End Sub

#Region " Informes "

    Private Sub MntoFacturaCompra_SetReportOptions(ByVal sender As Object, ByVal e As Engine.UI.ReportExportOptionsEventArgs) Handles MyBase.SetReportExportOptions
        e.Options.PromptUser = True
    End Sub

#End Region

    Private Sub FwiIDProveedor_SelectionChanged(ByVal sender As Object, ByVal e As Engine.UI.AdvSearchSelectionChangedEventArgs) Handles FwiIDProveedor.SelectionChanged
        MStrCContableProv = String.Empty
        If Not e.Selected Is Nothing AndAlso e.Selected.Rows.Count > 0 Then
            MStrCContableProv = e.Selected.Rows(0)("CCProveedor")
        End If

        ValidarCambioProveedor()
        mblnValidatingProv = True
    End Sub

    Private Sub FwiIDProveedor_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles FwiIDProveedor.Validated
        Dim DtVencManual As DataTable = Me.jngVencimientos.DataSource
        If Not DtVencManual Is Nothing AndAlso DtVencManual.Rows.Count > 0 Then
            For Each Dr As DataRow In DtVencManual.Select
                Dr("IDProveedor") = FwiIDProveedor.Value
            Next
            Me.jngVencimientos.DataSource = DtVencManual
        End If
        LoadGridDefaultValues()
    End Sub

    Protected Overridable Sub fwiDtoFactura_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles fwiDtoFactura.Validating
        If fwiDtoFactura.Value > 100 Then
            ExpertisApp.GenerateMessage("El Descuento introducido no puede ser superior a 100%.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            e.Cancel = True
        End If
    End Sub

    Private Sub fwiDtoFactura_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles fwiDtoFactura.ValueChanged
        If Me.RecordsState = RecordsState.Initialize Then Exit Sub
        If Not Me.jngLineaFactura.DataSource Is Nothing AndAlso CType(jngLineaFactura.DataSource, DataTable).Rows.Count > 0 Then
            Dim FCL As New FacturaCompraLinea
            Dim context As New BusinessData(Me.CurrentRow)
            Dim f As New Filter
            f.Add(New BooleanFilterItem("Especial", False))
            For Each drLinea As DataRow In CType(jngLineaFactura.DataSource, DataTable).Select(f.Compose(New AdoFilterComposer))
                Dim Current As New BusinessData(drLinea)
                Current = FCL.ApplyBusinessRule("Dto", Nz(fwiDtoFactura.Value, 0), Current, context)
                For Each col As DataColumn In drLinea.Table.Columns
                    drLinea(col.ColumnName) = Current(col.ColumnName)
                Next
            Next
        End If
    End Sub

    Private Sub fwiDtoProntoPago_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles fwiDtoProntoPago.Validating
        If fwiDtoProntoPago.Value > 100 Then
            ExpertisApp.GenerateMessage("El Descuento introducido no puede ser superior a 100%.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            e.Cancel = True
        End If
    End Sub

    Private Sub fwiDtoProntoPago_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles fwiDtoProntoPago.ValueChanged
        If Me.RecordsState = RecordsState.Initialize Then Exit Sub
        If Not Me.jngLineaFactura.DataSource Is Nothing AndAlso CType(jngLineaFactura.DataSource, DataTable).Rows.Count > 0 Then
            Dim FCL As New FacturaCompraLinea
            Dim context As New BusinessData(Me.CurrentRow)
            Dim f As New Filter
            f.Add(New BooleanFilterItem("Especial", False))
            For Each drLinea As DataRow In CType(jngLineaFactura.DataSource, DataTable).Select(f.Compose(New AdoFilterComposer))
                Dim Current As New BusinessData(drLinea)
                Current = FCL.ApplyBusinessRule("DtoProntoPago", Nz(fwiDtoProntoPago.Value, 0), Current, context)
                For Each col As DataColumn In drLinea.Table.Columns
                    drLinea(col.ColumnName) = Current(col.ColumnName)
                Next
            Next
        End If
    End Sub

    Private Sub fwiCondPago_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles fwiCondPago.Validated
        LoadGridDefaultValues()
    End Sub

    Private Sub fwiFormaPago_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles fwiFormaPago.Validated
        LoadGridDefaultValues()
    End Sub

    Private Sub fwiIdProveedor_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles FwiIDProveedor.Validating
        ValidarCambioProveedor()
    End Sub

    Private Sub ValidarCambioProveedor()
        If Length(Me.CurrentRow("IDProveedor")) > 0 AndAlso Not mblnValidatingProv Then
            If FwiIDProveedor.Value & String.Empty <> Me.CurrentRow("IDProveedor") & String.Empty AndAlso Me.jngLineaFactura.RowCount > 0 Then
                ExpertisApp.GenerateMessage("La modificación del proveedor no afectará a la información de las líneas")
            End If
        End If
    End Sub

    'Private Sub fwiVencimientoManual_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles fwiVencimientoManual.Validated
    '    BloqueoDatos()
    '    ConfiguracionVencimientoManual(fwiVencimientoManual.Checked)
    'End Sub

    Private Sub MntoFacturaCompra_RecordDeleting(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.RecordDeleting
        If Me.LblSelloContabilizado.Visible Then
            ExpertisApp.GenerateMessage("No se puede eliminar la factura, está contabilizada.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            e.Cancel = True
        End If
    End Sub

    Private Sub ChkOpeTriangular_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ChkOpeTriangular.Validating
        If Me.ChkOpeTriangular.Checked AndAlso Me.ChkSectorServicios.Checked Then
            ExpertisApp.GenerateMessage("La Factura es una operación de servicios. No puede ser a su vez una operación triangular.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            e.Cancel = True
        End If
    End Sub

    Private Sub ChkSectorServicios_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ChkSectorServicios.Validating
        If Me.ChkOpeTriangular.Checked AndAlso Me.ChkSectorServicios.Checked Then
            ExpertisApp.GenerateMessage("La Factura es una operación triangular, no puede ser de servicios.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            e.Cancel = True
        End If
    End Sub

    Private Sub AdvFtaRectificada_SetPredefinedFilter(ByVal sender As Object, ByVal e As Engine.UI.AdvSearchFilterEventArgs) Handles AdvFtaRectificada.SetPredefinedFilter
        Dim fProv As New Filter(FilterUnionOperator.Or)
        fProv.Add(New StringFilterItem("IDProveedor", Me.CurrentRow("IDProveedor")))
        fProv.Add(New StringFilterItem("IDProveedorInicial", Me.CurrentRow("IDProveedor")))
        e.Filter.Add(fProv)
    End Sub

    Protected Overridable Function HabilitarControlesMoneda() As Boolean
        Dim blnLocked As Boolean = (Nz(Me.CurrentRow("VencimientosManuales"), False) OrElse Nz(Me.CurrentRow("IVAManual"), False))

        Me.fwiIdMoneda.Enabled = Not blnLocked
        Me.fwiCambioA.Enabled = Not blnLocked
        Me.fwiCambioB.Enabled = Not blnLocked
    End Function

    Protected Overridable Sub fwiVencimientoManual_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles fwiVencimientoManual.CheckedChanged
        Me.CurrentRow("VencimientosManuales") = fwiVencimientoManual.Checked
        BloqueoDatos()
        ConfiguracionVencimientoManual(Nz(Me.CurrentRow("VencimientosManuales"), False))
    End Sub


    Protected Overridable Sub fwiIVAManual_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles fwiIVAManual.CheckedChanged
        Me.CurrentRow("IVAManual") = fwiIVAManual.Checked
        BloqueoDatos()
        ConfiguracionIVAManual(Nz(Me.CurrentRow("IVAManual"), False))
    End Sub



     
End Class