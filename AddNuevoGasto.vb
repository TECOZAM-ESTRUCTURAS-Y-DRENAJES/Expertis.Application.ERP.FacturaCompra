Public Class AddNuevoGasto

    Private mIDEjercicio As String
    Private G As Guid
    Private mdtAnalitica As DataTable
    Private mDigitosAuxiliar As Integer

#Region " Load "

    Private Sub AddNuevoGasto_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Not Me.DesignMode Then
            LoadEnumns()
            LoadDefaultValues()
            LoadConfigAnalitica()
        End If
    End Sub

    Private Sub LoadEnumns()
        CmbTipoAsiento.DataSource = EnumData.EnumView("enumTipoAsiento")
    End Sub

    Private Sub LoadDefaultValues()
        ClbFechaFactura.Value = Date.Today
        ClbSuFechaFactura.Value = Date.Today
    End Sub

    Private Sub LoadConfigAnalitica()
        Dim p As New Parametro
        Dim Contabilidad As Boolean = p.Contabilidad
        Dim GestionAnalitica As Boolean = p.CAnaliticPredet

        BtnAnalitica.Visible = Contabilidad AndAlso GestionAnalitica
        lblAnalitica.Visible = BtnAnalitica.Visible
    End Sub

#End Region

#Region " Toolbar Actions "

    Private Sub cmdUpdate1_Click(ByVal sender As Object, ByVal e As Janus.Windows.UI.CommandBars.CommandEventArgs) Handles cmdUpdate1.Click
        GenerarNuevoGasto()
    End Sub

    Private Sub AddNuevoGasto_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp
        If e.KeyCode = Keys.F9 Then GenerarNuevoGasto()
    End Sub

    Private Sub GenerarNuevoGasto()
        If ValidarFactura() Then
            Me.Cursor = Cursors.WaitCursor

            Dim data As New DataPrcFacturacionNuevoGasto
            data.FechaFactura = ClbFechaFactura.Value
            data.SuFactura = txtSuFactura.Text
            data.SuFechaFactura = ClbSuFechaFactura.Value
            data.IDProveedor = AdvProveedor.Text
            data.RazonSocial = txtRazonSocial.Text
            data.CIF = txtCIF.Text
            data.IDMoneda = AdvMoneda.Text
            data.IDDiaPago = AdvDiaPago.Text
            data.IDFormaPago = AdvFormaPago.Text
            data.IDCondicionPago = AdvCondicionPago.Text
            data.IDBancoPropio = AdvBancoPropio.Text
            data.IDTipoAsiento = CmbTipoAsiento.Value

            Dim lin As New DataPrcFacturacionLineaNuevoGasto
            If Length(AdvArticulo.Text) > 0 Then
                lin.IDArticulo = AdvArticulo.Text
                lin.DescArticulo = txtDescArticulo.Text
            ElseIf Length(AdvArticuloProveedor.Text) > 0 Then
                lin.IDArticulo = AdvArticuloProveedor.Text
                lin.DescArticulo = txtDescArticuloProveedor.Text
            End If
            If Length(AdvRefProveedor.Value) > 0 Then lin.RefProveedor = AdvRefProveedor.Value
            If Length(Me.txtDescRefProveedor.Text) > 0 Then lin.DescRefProveedor = Me.txtDescRefProveedor.Text

            lin.IDCContable = AdvCCCompra.Text
            lin.IDTipoIVA = AdvTipoIVA.Text
            lin.Importe = ntbBaseImponible.Value
            lin.ImpIVA = ntbIVA.Value
            lin.ImporteTotal = ntbTotal.Value
            If Length(AdvObra.Value) > 0 Then lin.IDObra = AdvObra.Value
            If Length(AdvTrabajo.Value) > 0 Then lin.IDTrabajo = AdvTrabajo.Value
            lin.Analitica = mdtAnalitica

            data.Lineas.Add(lin)

            Dim e As CreateElement = New BE.DataEngine().RunProcess(GetType(PrcFacturacionNuevoGasto), data)
            If Not e Is Nothing Then
                If e.IDElement > 0 Then LanzarSimulacion(e.IDElement)
            End If
            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Function ValidarFactura() As Boolean
        If Length(ClbFechaFactura.Value) <= 0 Then
            ExpertisApp.GenerateMessage("La Fecha Factura es un dato obligatorio.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
        Else
            'Dim Ejercicio As String = ExpertisApp.ExecuteTask(Of Date, String)(AddressOf EjercicioContable.Predeterminado, ClbFechaFactura.Value)
            If Length(mIDEjercicio) > 0 Then
                Dim dtEjercicioContable As DataTable = New EjercicioContable().SelOnPrimaryKey(mIDEjercicio)
                If dtEjercicioContable.Rows.Count > 0 AndAlso dtEjercicioContable.Rows(0)("EjercicioCerrado") Then
                    ExpertisApp.GenerateMessage("El Ejercicio {0} está cerrado. No se pueden introducir Facturas en dicho Ejercicio.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, Quoted(mIDEjercicio))
                    Return False
                End If
            Else
                Return False
            End If
        End If
        If Length(ClbSuFechaFactura.Value) <= 0 Then
            ExpertisApp.GenerateMessage("Los datos Su Factura y Su Fecha Factura son obligatorios.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
        End If
        If Length(AdvProveedor.Text) = 0 Then
            ExpertisApp.GenerateMessage("El Proveedor es un dato obligatorio.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
        End If
        If Length(txtRazonSocial.Text) = 0 Then
            ExpertisApp.GenerateMessage("La Razón Social es un dato obligatorio.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
        End If
        If Length(txtCIF.Text) = 0 Then
            ExpertisApp.GenerateMessage("El C.I.F. es un dato obligatorio.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
        End If
        If Length(AdvMoneda.Value) = 0 Then
            ExpertisApp.GenerateMessage("La Moneda es un dato obligatorio.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
        End If
        If Length(AdvArticulo.Text) <= 0 AndAlso Length(AdvArticuloProveedor.Text) <= 0 Then
            ExpertisApp.GenerateMessage("Debe seleccionar un Artículo o un Artículo Proveedor.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
        End If
        If Length(txtDescArticulo.Text) <= 0 AndAlso Length(txtDescArticuloProveedor.Text) <= 0 Then
            If Length(AdvArticulo.Text) > 0 Then
                ExpertisApp.GenerateMessage("La descripción del Artículo es un dato obligatorio.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                ExpertisApp.GenerateMessage("La descripción del Artículo Proveedor es un dato obligatorio.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
            Return False
        End If
        If Length(AdvCCCompra.Text) <> mDigitosAuxiliar Then
            ExpertisApp.GenerateMessage("La C.C. Compra ha de ser de | dígitos.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, mDigitosAuxiliar)
            Return False
        End If
        If Length(AdvTipoIVA.Value) = 0 Then
            ExpertisApp.GenerateMessage("El Tipo I.V.A. es un dato obligatorio.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
        End If
        If ntbBaseImponible.Value <= 0 Then
            ExpertisApp.GenerateMessage("La Base Imponible ha de ser mayor que 0.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
        End If
        If ntbTotal.Value <= 0 Then
            ExpertisApp.GenerateMessage("El cálculo del importe Total no se ha llevado a cabo correctamente.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
        End If

        Return True
    End Function

#Region " Simulacion Contable "

    Private Sub LanzarSimulacion(ByVal IDFactura As Integer)
        G = MarcarRegistro(IDFactura, FilterType.Numeric)
        Dim info As New DataSimulacionContableInfo
        info.GuidSimulacion = G
        info.TipoContabilizacion = enumTipoContabilizacion.tcFacturaCompra
        info.IDEjercicio = mIDEjercicio
        info.Caption = "Simulación Contable - NUEVO GASTO -"

        Dim frm As Form = ExpertisApp.OpenForm("CISIMUCONT", , info, Me)
        AddHandler frm.Closed, AddressOf FrmActionClosed
    End Sub

    Private Sub FrmActionClosed(ByVal sender As Object, ByVal e As System.EventArgs)
        RemoveHandler CType(sender, Form).Closed, AddressOf FrmActionClosed
        Expertis.Application.ERP.CommonClasses.DesmarcarRegistro(G, FilterType.String)
        If CType(sender, Form).DialogResult = Windows.Forms.DialogResult.OK Then InicializarControles()
    End Sub

    Private Sub InicializarControles()
        txtSuFactura.Text = String.Empty
        AdvProveedor.Text = String.Empty : ulDescProveedor.Text = String.Empty
        txtRazonSocial.Text = String.Empty
        txtCIF.Text = String.Empty
        AdvMoneda.Text = String.Empty : ulDescMoneda.Text = String.Empty
        AdvBancoPropio.Text = String.Empty : ulDescBancoPropio.Text = String.Empty
        AdvCondicionPago.Text = String.Empty : ulDescCondicionPago.Text = String.Empty
        AdvFormaPago.Text = String.Empty : ulDescFormaPago.Text = String.Empty
        AdvDiaPago.Text = String.Empty : ulDescDiaPago.Text = String.Empty
        CmbTipoAsiento.Value = Nothing
        AdvArticulo.Text = String.Empty : txtDescArticulo.Text = String.Empty
        AdvArticuloProveedor.Text = String.Empty : txtDescArticuloProveedor.Text = String.Empty
        AdvRefProveedor.Text = String.Empty
        txtDescRefProveedor.Text = String.Empty
        AdvCCCompra.Text = String.Empty : ulDescCCCompra.Text = String.Empty
        AdvTipoIVA.Text = String.Empty : ulDescTipoIVA.Text = String.Empty
        AdvObra.Value = Nothing : ulDescObra.Text = String.Empty
        AdvTrabajo.Value = Nothing : ulDescTrabajo.Text = String.Empty
        ntbBaseImponible.Value = 0 : ntbIVA.Value = 0 : ntbTotal.Value = 0
        mdtAnalitica = Nothing
        CmbTipoAsiento.Text = String.Empty
        LoadDefaultValues()
    End Sub

#End Region

#End Region

#Region " Datos Proveedor "

    Private Sub ClbFechaFactura_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ClbFechaFactura.ValueChanged
        If Length(ClbFechaFactura.Value) > 0 Then
            mIDEjercicio = ExpertisApp.ExecuteTask(Of Date, String)(AddressOf EjercicioContable.Predeterminado, ClbFechaFactura.Value)
            If Length(mIDEjercicio) > 0 Then
                GetDigitosAuxiliar()
            Else
                ExpertisApp.GenerateMessage("No existe un Ejercicio Contable predeterminado para la Fecha de la Factura.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        Else
            mIDEjercicio = String.Empty
        End If
    End Sub

    Private Sub GetDigitosAuxiliar()
        Dim dtEjercicio As DataTable = New EjercicioContable().SelOnPrimaryKey(mIDEjercicio)
        If Not dtEjercicio Is Nothing AndAlso dtEjercicio.Rows.Count > 0 Then
            mDigitosAuxiliar = dtEjercicio.Rows(0)("DigitosAuxiliar")
        End If
    End Sub

    Private Sub AdvProveedor_SelectionChanged(ByVal sender As Object, ByVal e As Engine.UI.AdvSearchSelectionChangedEventArgs) Handles AdvProveedor.SelectionChanged
        Dim current As New BusinessData
        current = New FacturaCompraCabecera().ApplyBusinessRule("IDProveedor", AdvProveedor.Text, current)
        txtRazonSocial.Text = current("RazonSocial") & String.Empty
        txtCIF.Text = current("CifProveedor") & String.Empty
        AdvMoneda.Value = current("IdMoneda") & String.Empty
        AdvBancoPropio.Value = current("IDBancoPropio") & String.Empty
        AdvFormaPago.Value = current("IDFormaPago") & String.Empty
        AdvCondicionPago.Value = current("IDCondicionPago") & String.Empty
        AdvDiaPago.Value = current("IDDiaPago") & String.Empty
        CmbTipoAsiento.Value = current("IDTipoAsiento") & String.Empty
    End Sub

    Private Sub AdvProveedor_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AdvProveedor.Validated
        If Length(AdvProveedor.Text) = 0 Then
            txtRazonSocial.Text = String.Empty
            txtCIF.Text = String.Empty
            AdvMoneda.Text = String.Empty : ulDescMoneda.Text = String.Empty
            AdvFormaPago.Text = String.Empty : ulDescFormaPago.Text = String.Empty
            AdvCondicionPago.Text = String.Empty : ulDescCondicionPago.Text = String.Empty
            AdvDiaPago.Text = String.Empty : ulDescDiaPago.Text = String.Empty
            AdvBancoPropio.Text = String.Empty : ulDescBancoPropio.Text = String.Empty
            CmbTipoAsiento.Text = String.Empty
        End If
    End Sub

    Private Sub AdvMoneda_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles AdvMoneda.Validated
        CalcularImporte()
    End Sub

#End Region

#Region " Datos Gasto "

    Private Sub AdvArticulo_SelectionChanged(ByVal sender As Object, ByVal e As Engine.UI.AdvSearchSelectionChangedEventArgs) Handles AdvArticulo.SelectionChanged
        GetDatosArticulo(enumtipo.Articulo)
    End Sub

#Region " GetDatosArticulo "

    Private Enum enumtipo
        Articulo
        ArticuloProveedor
    End Enum

    Private Sub GetDatosArticulo(ByVal tipo As enumtipo)
        Dim current As New BusinessData
        Dim context As New BusinessData
        context.Add("IdMoneda", AdvMoneda.Text)
        context.Add("IDProveedor", AdvProveedor.Text)
        If Length(AdvMoneda.Text) > 0 Then context.Add("CambioA", AdvMoneda.SelectedRow("CambioA"))
        context.Add("IDEjercicio", mIDEjercicio)
        context.Add("Fecha", New Date(CDate(ClbFechaFactura.Value).Year, CDate(ClbFechaFactura.Value).Month, CDate(ClbFechaFactura.Value).Day))
        If tipo = enumtipo.Articulo Then
            current = New FacturaCompraLinea().ApplyBusinessRule("IDArticulo", AdvArticulo.Text, current, context)
            txtDescArticulo.Text = current("DescArticulo") & String.Empty
        Else
            current = New FacturaCompraLinea().ApplyBusinessRule("IDArticulo", AdvArticuloProveedor.Text, current, context)
            txtDescArticuloProveedor.Text = current("DescArticulo") & String.Empty
        End If
        AdvRefProveedor.Text = current("RefProveedor") & String.Empty
        txtDescRefProveedor.Text = current("DescRefProveedor") & String.Empty
        AdvCCCompra.Text = current("CContable") & String.Empty
        ulDescCCCompra.Text = DescripcionCContable(mIDEjercicio, AdvCCCompra.Text)
        AdvTipoIVA.Text = current("IDTipoIVA") & String.Empty
    End Sub

#End Region

    Private Sub AdvArticulo_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles AdvArticulo.Validated
        If Length(AdvArticulo.Text) = 0 Then
            txtDescArticulo.Text = String.Empty
            AdvRefProveedor.Text = String.Empty
            txtDescRefProveedor.Text = String.Empty
            AdvCCCompra.Text = String.Empty
            AdvTipoIVA.Text = String.Empty
        End If
    End Sub

    Private Sub AdvArticuloProveedor_SelectionChanged(ByVal sender As Object, ByVal e As Engine.UI.AdvSearchSelectionChangedEventArgs) Handles AdvArticuloProveedor.SelectionChanged
        GetDatosArticulo(enumtipo.ArticuloProveedor)
    End Sub

    Private Sub AdvArticuloProveedor_SetPredefinedFilter(ByVal sender As System.Object, ByVal e As Solmicro.Expertis.Engine.UI.AdvSearchFilterEventArgs) Handles AdvArticuloProveedor.SetPredefinedFilter
        If Length(AdvProveedor.Text) > 0 Then
            e.Filter.Add(New StringFilterItem("IDProveedor", AdvProveedor.Text))
        End If
    End Sub

    Private Sub AdvTipoIVA_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles AdvTipoIVA.Validated
        CalcularImporte()
    End Sub

    Private Sub AdvCCCompra_SetPredefinedFilter(ByVal sender As System.Object, ByVal e As Solmicro.Expertis.Engine.UI.AdvSearchFilterEventArgs) Handles AdvCCCompra.SetPredefinedFilter
        If Length(mIDEjercicio) > 0 Then
            e.Filter.Add(New StringFilterItem("IDEjercicio", mIDEjercicio))
            e.Filter.Add(New BooleanFilterItem("Auxiliar", FilterOperator.Equal, True))
        Else
            e.Filter.Add(New NoRowsFilterItem)
        End If
    End Sub

    Private Sub AdvCCCompra_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles AdvCCCompra.Validating
        If Length(AdvCCCompra.Text) > 0 AndAlso Length(mIDEjercicio) Then
            ulDescCCCompra.Text = DescripcionCContable(mIDEjercicio, AdvCCCompra.Text)
        Else
            ulDescCCCompra.Text = String.Empty
        End If
    End Sub

#Region " Analitica "

    Private Sub BtnAnalitica_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAnalitica.Click
        If ValidarAnalitica() Then
            If mdtAnalitica Is Nothing Then mdtAnalitica = New FacturaCompraAnalitica().AddNew

            Dim frm As New AnaliticaNuevoGasto
            frm.IDMoneda = AdvMoneda.Text
            frm.DataSource = mdtAnalitica.Copy
            frm.IDCContable = Me.AdvCCCompra.Text
            frm.DescCContable = Me.ulDescCCCompra.Text
            frm.Importe = ntbBaseImponible.Value
            frm.Fecha = Me.ClbFechaFactura.Value
            If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
                mdtAnalitica = frm.DataSource.Copy
            End If
        End If
    End Sub

    Private Function ValidarAnalitica() As Boolean
        If Len(ClbFechaFactura.Value) = 0 Then
            ExpertisApp.GenerateMessage("La Fecha Factura es un dato obligatorio.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf Length(AdvMoneda.Text) = 0 Then
            ExpertisApp.GenerateMessage("La Moneda es un dato obligatorio.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf Length(AdvTipoIVA.Text) = 0 Then
            ExpertisApp.GenerateMessage("El Tipo IVA es un dato obligatorio.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf Length(AdvArticulo.Text) = 0 Then
            ExpertisApp.GenerateMessage("Debe seleccionar un artículo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf Length(AdvCCCompra.Text) = 0 Then
            ExpertisApp.GenerateMessage("Debe seleccionar una Cuenta Contable.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf ntbBaseImponible.Value <= 0 Then
            ExpertisApp.GenerateMessage("La Base Imponible ha de ser mayor que 0.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf ntbTotal.Value <= 0 Then
            ExpertisApp.GenerateMessage("El Total ha de ser mayor que 0.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Dim IDEjercicio As String = ExpertisApp.ExecuteTask(Of Date, String)(AddressOf EjercicioContable.Predeterminado, ClbFechaFactura.Value)
            Dim CC As New AltaPlanContable
            Return CC.ValidaCuentaContable(AdvCCCompra.Text, IDEjercicio)
        End If
        Return False
    End Function

#End Region

#End Region

#Region " Datos Obra "

    Private Sub AdvObra_SelectionChanged(ByVal sender As Object, ByVal e As Engine.UI.AdvSearchSelectionChangedEventArgs) Handles AdvObra.SelectionChanged
        AdvTrabajo.Value = DBNull.Value
    End Sub

    Private Sub AdvTrabajo_SetPredefinedFilter(ByVal sender As Object, ByVal e As Engine.UI.AdvSearchFilterEventArgs) Handles AdvTrabajo.SetPredefinedFilter
        If Length(AdvObra.Value) > 0 Then
            e.Filter.Add(New NumberFilterItem("IDObra", AdvObra.Value))
        End If
    End Sub

    Private Sub AdvObra_SetPredefinedFilter(ByVal sender As Object, ByVal e As Engine.UI.AdvSearchFilterEventArgs) Handles AdvObra.SetPredefinedFilter
        If Length(AdvTrabajo.Value) > 0 Then
            e.Filter.Add(New NumberFilterItem("IDTrabajo", AdvTrabajo.Value))
        End If
    End Sub

#End Region

    Private Sub ntbBaseImponible_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ntbBaseImponible.ValueChanged
        CalcularImporte()
    End Sub

    Private Sub CalcularImporte()
        Dim DblFactor As Double = 0
        Dim IntNDecimalesImp As Integer = 0

        If Length(AdvTipoIVA.Value) > 0 Then
            DblFactor = Nz(AdvTipoIVA.SelectedRow("Factor"), 0)
        End If
        If Length(AdvMoneda.Value) > 0 Then
            IntNDecimalesImp = Nz(AdvMoneda.SelectedRow("NDecimalesImp"), 0)
        End If

        Dim DblBaseImponible As Double = Nz(ntbBaseImponible.Value, 0)
        ntbIVA.Value = xRound(DblBaseImponible * DblFactor / 100, IntNDecimalesImp)
        ntbTotal.Value = ntbIVA.Value + DblBaseImponible
    End Sub

    Private Sub AdvRefProveedor_SetPredefinedFilter(ByVal sender As Object, ByVal e As Engine.UI.AdvSearchFilterEventArgs) Handles AdvRefProveedor.SetPredefinedFilter
        If Length(AdvProveedor.Value) > 0 Then
            e.Filter.Add(New StringFilterItem("IDProveedor", AdvProveedor.Value))
        End If
    End Sub

End Class
