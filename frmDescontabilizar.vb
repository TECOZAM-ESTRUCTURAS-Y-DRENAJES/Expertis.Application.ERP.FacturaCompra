Public Class frmDescontabilizar
    Inherits Solmicro.Expertis.Engine.UI.FormBase

#Region " Propiedades "

    Private mIDProcess As Guid
    Public WriteOnly Property IDProcess() As Guid
        Set(ByVal Value As Guid)
            mIDProcess = Value
        End Set
    End Property

#End Region

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicialización después de la llamada a InitializeComponent()

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
    Friend WithEvents jngApuntesPagos As Solmicro.Expertis.Engine.UI.Grid
    Friend WithEvents jngApuntesFact As Solmicro.Expertis.Engine.UI.Grid
    Friend WithEvents cmdAceptar As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents cmdCancelar As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents jngFacturas As Solmicro.Expertis.Engine.UI.Grid
    Friend WithEvents jngPagos As Solmicro.Expertis.Engine.UI.Grid
    Friend WithEvents lblfwiPagos As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblfwiFacturas As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblfwiApuntesFact As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblfwiApuntesPagos As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblfwiSituacion As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblcfwiSituacion As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Friend WithEvents fwiSituacion As Solmicro.Expertis.Engine.UI.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim jngApuntesPagos_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDescontabilizar))
        Dim jngApuntesFact_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim jngFacturas_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim jngPagos_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim fwiSituacion_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.jngApuntesPagos = New Solmicro.Expertis.Engine.UI.Grid
        Me.jngApuntesFact = New Solmicro.Expertis.Engine.UI.Grid
        Me.cmdAceptar = New Solmicro.Expertis.Engine.UI.Button
        Me.cmdCancelar = New Solmicro.Expertis.Engine.UI.Button
        Me.jngFacturas = New Solmicro.Expertis.Engine.UI.Grid
        Me.jngPagos = New Solmicro.Expertis.Engine.UI.Grid
        Me.lblfwiPagos = New Solmicro.Expertis.Engine.UI.Label
        Me.lblfwiFacturas = New Solmicro.Expertis.Engine.UI.Label
        Me.lblfwiApuntesFact = New Solmicro.Expertis.Engine.UI.Label
        Me.lblfwiApuntesPagos = New Solmicro.Expertis.Engine.UI.Label
        Me.lblfwiSituacion = New Solmicro.Expertis.Engine.UI.Label
        Me.lblcfwiSituacion = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.fwiSituacion = New Solmicro.Expertis.Engine.UI.ComboBox
        CType(Me.jngApuntesPagos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.jngApuntesFact, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.jngFacturas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.jngPagos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fwiSituacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'jngApuntesPagos
        '
        Me.jngApuntesPagos.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.jngApuntesPagos.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.jngApuntesPagos.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        jngApuntesPagos_DesignTimeLayout.LayoutString = resources.GetString("jngApuntesPagos_DesignTimeLayout.LayoutString")
        Me.jngApuntesPagos.DesignTimeLayout = jngApuntesPagos_DesignTimeLayout
        Me.jngApuntesPagos.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.jngApuntesPagos.EntityName = "DiarioContable"
        Me.jngApuntesPagos.Location = New System.Drawing.Point(4, 419)
        Me.jngApuntesPagos.Name = "jngApuntesPagos"
        Me.jngApuntesPagos.PrimaryDataFields = Nothing
        Me.jngApuntesPagos.RequeryManually = True
        Me.jngApuntesPagos.SecondaryDataFields = Nothing
        Me.jngApuntesPagos.Size = New System.Drawing.Size(600, 124)
        Me.jngApuntesPagos.TabIndex = 9
        Me.jngApuntesPagos.Tag = "IdRec=5455:5456:5666:5457:5458:4737:4738:5459:6583:4865:;"
        Me.jngApuntesPagos.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.jngApuntesPagos.ViewName = "vfrmFactCompraDescontApuntePago"
        '
        'jngApuntesFact
        '
        Me.jngApuntesFact.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.jngApuntesFact.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.jngApuntesFact.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        jngApuntesFact_DesignTimeLayout.LayoutString = resources.GetString("jngApuntesFact_DesignTimeLayout.LayoutString")
        Me.jngApuntesFact.DesignTimeLayout = jngApuntesFact_DesignTimeLayout
        Me.jngApuntesFact.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.jngApuntesFact.EntityName = "DiarioContable"
        Me.jngApuntesFact.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.jngApuntesFact.Location = New System.Drawing.Point(4, 144)
        Me.jngApuntesFact.Name = "jngApuntesFact"
        Me.jngApuntesFact.PrimaryDataFields = Nothing
        Me.jngApuntesFact.RequeryManually = True
        Me.jngApuntesFact.SecondaryDataFields = Nothing
        Me.jngApuntesFact.Size = New System.Drawing.Size(600, 153)
        Me.jngApuntesFact.TabIndex = 8
        Me.jngApuntesFact.Tag = "IdRec=5455:5456:4951:5457:5458:4737:4738:5459:4467:4865:;"
        Me.jngApuntesFact.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.jngApuntesFact.ViewName = "vfrmFactCompraDescontApunte"
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Location = New System.Drawing.Point(448, 551)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(76, 28)
        Me.cmdAceptar.TabIndex = 2
        Me.cmdAceptar.Text = "Aceptar"
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Location = New System.Drawing.Point(528, 551)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(76, 28)
        Me.cmdCancelar.TabIndex = 1
        Me.cmdCancelar.Text = "Cancelar"
        '
        'jngFacturas
        '
        Me.jngFacturas.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.jngFacturas.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.jngFacturas.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        jngFacturas_DesignTimeLayout.LayoutString = resources.GetString("jngFacturas_DesignTimeLayout.LayoutString")
        Me.jngFacturas.DesignTimeLayout = jngFacturas_DesignTimeLayout
        Me.jngFacturas.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.jngFacturas.EntityName = "FacturaCompraCabecera"
        Me.jngFacturas.Location = New System.Drawing.Point(4, 18)
        Me.jngFacturas.Name = "jngFacturas"
        Me.jngFacturas.PrimaryDataFields = Nothing
        Me.jngFacturas.RequeryManually = True
        Me.jngFacturas.SecondaryDataFields = Nothing
        Me.jngFacturas.Size = New System.Drawing.Size(600, 106)
        Me.jngFacturas.TabIndex = 0
        Me.jngFacturas.Tag = "IdRec=5453:5433:6267:4763:4467:5454:4352:5043:4664:4398:5058:9465:9466:;"
        Me.jngFacturas.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.jngFacturas.ViewName = "frmFactCompraDescont"
        '
        'jngPagos
        '
        Me.jngPagos.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.jngPagos.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.jngPagos.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        jngPagos_DesignTimeLayout.LayoutString = resources.GetString("jngPagos_DesignTimeLayout.LayoutString")
        Me.jngPagos.DesignTimeLayout = jngPagos_DesignTimeLayout
        Me.jngPagos.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.jngPagos.EntityName = "Pago"
        Me.jngPagos.Location = New System.Drawing.Point(4, 313)
        Me.jngPagos.Name = "jngPagos"
        Me.jngPagos.PrimaryDataFields = Nothing
        Me.jngPagos.RequeryManually = True
        Me.jngPagos.SecondaryDataFields = Nothing
        Me.jngPagos.Size = New System.Drawing.Size(600, 89)
        Me.jngPagos.TabIndex = 3
        Me.jngPagos.Tag = "IdRec=5029:6267:8125:6583:5454:5461:4398:4715:;"
        Me.jngPagos.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.jngPagos.ViewName = "vfrmFactCompraDescontPago"
        '
        'lblfwiPagos
        '
        Me.lblfwiPagos.Location = New System.Drawing.Point(8, 300)
        Me.lblfwiPagos.Name = "lblfwiPagos"
        Me.lblfwiPagos.Size = New System.Drawing.Size(46, 13)
        Me.lblfwiPagos.TabIndex = 10
        Me.lblfwiPagos.Tag = "IdRec=5030;"
        Me.lblfwiPagos.Text = "Pagos:"
        '
        'lblfwiFacturas
        '
        Me.lblfwiFacturas.Location = New System.Drawing.Point(8, 4)
        Me.lblfwiFacturas.Name = "lblfwiFacturas"
        Me.lblfwiFacturas.Size = New System.Drawing.Size(143, 13)
        Me.lblfwiFacturas.TabIndex = 11
        Me.lblfwiFacturas.Tag = "IdRec=5031;"
        Me.lblfwiFacturas.Text = "Facturas seleccionadas:"
        '
        'lblfwiApuntesFact
        '
        Me.lblfwiApuntesFact.Location = New System.Drawing.Point(8, 129)
        Me.lblfwiApuntesFact.Name = "lblfwiApuntesFact"
        Me.lblfwiApuntesFact.Size = New System.Drawing.Size(148, 13)
        Me.lblfwiApuntesFact.TabIndex = 12
        Me.lblfwiApuntesFact.Tag = "IdRec=5032;"
        Me.lblfwiApuntesFact.Text = "Apuntes de las Facturas:"
        '
        'lblfwiApuntesPagos
        '
        Me.lblfwiApuntesPagos.Location = New System.Drawing.Point(8, 405)
        Me.lblfwiApuntesPagos.Name = "lblfwiApuntesPagos"
        Me.lblfwiApuntesPagos.Size = New System.Drawing.Size(134, 13)
        Me.lblfwiApuntesPagos.TabIndex = 13
        Me.lblfwiApuntesPagos.Tag = "IdRec=5033;"
        Me.lblfwiApuntesPagos.Text = "Apuntes de los Pagos:"
        '
        'lblfwiSituacion
        '
        Me.lblfwiSituacion.AutoSize = False
        Me.lblfwiSituacion.Location = New System.Drawing.Point(6, 550)
        Me.lblfwiSituacion.Name = "lblfwiSituacion"
        Me.lblfwiSituacion.Size = New System.Drawing.Size(154, 29)
        Me.lblfwiSituacion.TabIndex = 14
        Me.lblfwiSituacion.Tag = "IdRec=5097;"
        Me.lblfwiSituacion.Text = "Cambiar la situación de los pagos a..."
        '
        'lblcfwiSituacion
        '
        Me.TryDataBinding(lblcfwiSituacion, New System.Windows.Forms.Binding("Text", Me.fwiSituacion, "DescEstado", True))
        Me.lblcfwiSituacion.Location = New System.Drawing.Point(223, 550)
        Me.lblcfwiSituacion.Name = "lblcfwiSituacion"
        Me.lblcfwiSituacion.Size = New System.Drawing.Size(209, 22)
        Me.lblcfwiSituacion.TabIndex = 15
        '
        'fwiSituacion
        '
        fwiSituacion_DesignTimeLayout.LayoutString = resources.GetString("fwiSituacion_DesignTimeLayout.LayoutString")
        Me.fwiSituacion.DesignTimeLayout = fwiSituacion_DesignTimeLayout
        Me.fwiSituacion.DisabledBackColor = System.Drawing.Color.White
        Me.fwiSituacion.EntityName = "EstadoPago"
        Me.fwiSituacion.Location = New System.Drawing.Point(167, 550)
        Me.fwiSituacion.Name = "fwiSituacion"
        Me.fwiSituacion.PrimaryDataFields = "IDEstado"
        Me.fwiSituacion.SecondaryDataFields = "IDEstado"
        Me.fwiSituacion.SelectedIndex = -1
        Me.fwiSituacion.SelectedItem = Nothing
        Me.fwiSituacion.Size = New System.Drawing.Size(53, 21)
        Me.fwiSituacion.TabIndex = 16
        Me.fwiSituacion.ViewName = "cmbEstadoPago"
        '
        'frmDescontabilizar
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(625, 601)
        Me.Controls.Add(Me.fwiSituacion)
        Me.Controls.Add(Me.jngApuntesPagos)
        Me.Controls.Add(Me.jngApuntesFact)
        Me.Controls.Add(Me.jngFacturas)
        Me.Controls.Add(Me.jngPagos)
        Me.Controls.Add(Me.lblfwiPagos)
        Me.Controls.Add(Me.lblfwiFacturas)
        Me.Controls.Add(Me.lblfwiApuntesFact)
        Me.Controls.Add(Me.lblfwiApuntesPagos)
        Me.Controls.Add(Me.cmdAceptar)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.lblfwiSituacion)
        Me.Controls.Add(Me.lblcfwiSituacion)
        Me.HelpButton = False
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmDescontabilizar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Descontabilización de Facturas de Compra"
        CType(Me.jngApuntesPagos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.jngApuntesFact, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.jngFacturas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.jngPagos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fwiSituacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private mstrIdFactura As String
    Private mstrIdPago As String
    Private mContabilidadMultiple As Boolean

#Region " Carga del formualario "

    Private Sub Me_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'intAccion = enumAccion.Cancelar

        Dim objNegParametro As New Parametro
        fwiSituacion.Text = objNegParametro.PagoDescontSituacion
        mContabilidadMultiple = objNegParametro.ContabilidadMultiple
        objNegParametro = Nothing

        '// Se visualizan las facturas marcadas.
        Dim oFilter As New Filter
        With jngFacturas
            oFilter.Add(New GuidFilterItem("IdProcess", FilterOperator.Equal, Me.mIDProcess))
            .Filter = oFilter
            .ReQuery()
        End With

        '// Se cargan el resto de los grids.
        CargarGrids()
    End Sub

    Private Sub CargarGrids()
        Dim oFilter As New Filter
        Dim objSortKey As Janus.Windows.GridEX.GridEXSortKey

        '//CARGAR APUNTES DE LA FACTURAS
        With jngApuntesFact
            'Filtro
            oFilter.Clear()
            oFilter.Add(New NumberFilterItem("IDTipoApunte", FilterOperator.Equal, enumDiarioTipoApunte.factc))
            oFilter.Add(FiltrarGrid("IdDocumento", "IdFactura", "NDocumento", jngFacturas.DataSource, True))
            .Filter = oFilter
            'Ordenación
            objSortKey = New Janus.Windows.GridEX.GridEXSortKey
            objSortKey.Column = .Columns("NDocumento")
            .RootTable.SortKeys.Clear()
            .RootTable.SortKeys.Add(objSortKey)
            objSortKey = Nothing
            .ReQuery()
        End With

        '//CARGAR PAGOS DE LAS FACTURAS
        With jngPagos
            'Filtro
            oFilter.Clear()
            oFilter.Add(FiltrarGrid("IdFactura", "IdFactura", "NFactura", jngFacturas.DataSource))
            .Filter = oFilter
            'Ordenación
            objSortKey = New Janus.Windows.GridEX.GridEXSortKey
            objSortKey.Column = .Columns("NFactura")
            .RootTable.SortKeys.Clear()
            .RootTable.SortKeys.Add(objSortKey)
            objSortKey = Nothing
            .ReQuery()
        End With

        '//CARGAR APUNTES DE LOS PAGOS
        If jngPagos.RowCount > 0 Then
            With jngApuntesPagos
                'Filtro
              
                Dim oFilter1 As New Filter(FilterUnionOperator.Or)
                oFilter1.Add(New NumberFilterItem("IDTipoApunte", FilterOperator.Equal, enumDiarioTipoApunte.Pago))
                oFilter1.Add(New NumberFilterItem("IDTipoApunte", FilterOperator.Equal, enumDiarioTipoApunte.RemesaPago))
                oFilter1.Add(New NumberFilterItem("IDTipoApunte", FilterOperator.Equal, enumDiarioTipoApunte.Talon))

                Dim oFilter2 As New Filter
                oFilter2.Add(FiltrarGrid("IdDocumento", "IdPago", "NDocumento", jngPagos.DataSource, True, True))

                Dim f As New Filter(FilterUnionOperator.And)
                f.Add(oFilter1)
                f.Add(oFilter2)

                .Filter = f
                'Ordenación
                objSortKey = New Janus.Windows.GridEX.GridEXSortKey
                objSortKey.Column = .Columns("NDocumento")
                .RootTable.SortKeys.Clear()
                .RootTable.SortKeys.Add(objSortKey)
                objSortKey = Nothing
                .ReQuery()
            End With
        End If

        oFilter = Nothing
    End Sub

    Private Function FiltrarGrid(ByVal strCampo As String, ByVal strEnlace As String, _
                                ByVal strCampoOrder As String, ByVal dtGrid As DataTable, _
                                Optional ByVal blnDiarioCont As Boolean = False, _
                                Optional ByVal blnPagosAgrupados As Boolean = False) As Filter

        Dim oFilter As New Filter(FilterUnionOperator.Or)
        Dim row As DataRow
        Dim objFilterPago As New Filter(FilterUnionOperator.Or)
        If Not dtGrid Is Nothing AndAlso dtGrid.Rows.Count > 0 Then
            For Each row In dtGrid.Rows
                If blnDiarioCont Then
                    Dim oFilterAND As New Filter(FilterUnionOperator.And)
                    If Length(row("IDEjercicio")) > 0 Then
                        Dim fEjercicio As New Filter(FilterUnionOperator.Or)
                        fEjercicio.Add(New StringFilterItem("IDEjercicio", FilterOperator.Equal, row("IDEjercicio")))
                        If mContabilidadMultiple Then
                            If row.Table.Columns.Contains("IDEjercicioTributario") AndAlso Length(row("IDEjercicioTributario")) > 0 Then fEjercicio.Add(New StringFilterItem("IDEjercicio", FilterOperator.Equal, row("IDEjercicioTributario")))
                        End If

                        oFilterAND.Add(fEjercicio)
                    End If

                    If blnPagosAgrupados AndAlso Length(row("IDPagoAgrupado")) > 0 AndAlso Length(row("IDEjercicioAgrupado")) > 0 Then
                        Dim fEjercicio As New Filter(FilterUnionOperator.Or)
                        fEjercicio.Add(New StringFilterItem("IDEjercicio", FilterOperator.Equal, row("IDEjercicioAgrupado")))
                        If mContabilidadMultiple Then
                            If row.Table.Columns.Contains("IDEjercicioTributarioAgrupado") AndAlso Length(row("IDEjercicioTributarioAgrupado")) > 0 Then fEjercicio.Add(New StringFilterItem("IDEjercicio", FilterOperator.Equal, row("IDEjercicioTributarioAgrupado")))
                        End If

                        oFilterAND.Add(fEjercicio)
                    End If

                    objFilterPago.Add(strCampo, FilterOperator.Equal, row(strEnlace))
                    If blnPagosAgrupados AndAlso Length(row("IDPagoAgrupado")) > 0 Then objFilterPago.Add(New NumberFilterItem(strCampo, row("IDPagoAgrupado")))
                    oFilterAND.Add(objFilterPago)
                    oFilter.Add(oFilterAND)
                Else
                    Dim oFilterOR As New Filter(FilterUnionOperator.Or)
                    oFilterOR.Add(strCampo, FilterOperator.Equal, row(strEnlace))
                    oFilter.Add(oFilterOR)
                End If
            Next row

        End If

        FiltrarGrid = oFilter
    End Function

#End Region

#Region " Formatero de los Grid "

    Private Sub jngFacturas_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles jngFacturas.SelectionChanged
        If CType(sender, Grid).SelectedItems.Count > 0 Then
            mstrIdFactura = CType(sender, Grid).SelectedItems(0).GetRow.DataRow("IDFactura")
            jngApuntesFact.Refresh()
            jngPagos.Refresh()
        End If
    End Sub

    Private Sub jngPagos_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles jngPagos.SelectionChanged
        If CType(sender, Grid).SelectedItems.Count > 0 Then
            mstrIdPago = CType(sender, Grid).SelectedItems(0).GetRow.DataRow("IDPago")
            jngApuntesPagos.Refresh()
        End If
    End Sub

    Private Sub jngApuntesFact_FormattingRow(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowLoadEventArgs) Handles jngApuntesFact.FormattingRow
        FormatoGrid(sender, e, mstrIdFactura)
    End Sub

    Private Sub jngPagos_FormattingRow(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowLoadEventArgs) Handles jngPagos.FormattingRow
        FormatoGrid(sender, e, mstrIdFactura)
    End Sub

    Private Sub jngApuntesPagos_FormattingRow(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowLoadEventArgs) Handles jngApuntesPagos.FormattingRow
        FormatoGrid(sender, e, , mstrIdPago)
    End Sub

    Private Sub FormatoGrid(ByVal objGrid As Grid, _
                         ByRef e As Janus.Windows.GridEX.RowLoadEventArgs, _
                         Optional ByVal strIdFactura As String = "", _
                         Optional ByVal strIdPago As String = "")

        Select Case objGrid.Name
            Case "jngApuntesFact"
                If strIdFactura <> String.Empty Then
                    If e.Row.DataRow("IdDocumento") = strIdFactura Then
                        e.Row.RowStyle = objGrid.FormatStyles("ResaltadoFormatStyle")
                    Else
                        e.Row.RowStyle = Nothing
                    End If
                End If
            Case "jngPagos"
                If strIdFactura <> String.Empty Then
                    If e.Row.DataRow("IDFactura") = strIdFactura Then
                        e.Row.RowStyle = objGrid.FormatStyles("ResaltadoFormatStyle")
                    Else
                        e.Row.RowStyle = Nothing
                    End If
                End If
            Case "jngApuntesPagos"
                If strIdPago <> String.Empty Then
                    If e.Row.DataRow("IdDocumento") = strIdPago Then
                        e.Row.RowStyle = objGrid.FormatStyles("ResaltadoFormatStyle")
                    Else
                        e.Row.RowStyle = Nothing
                    End If
                End If
        End Select

    End Sub

#End Region

#Region " Aceptar/Cancelar "

    Private Sub cmdCancelar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Me.Close()
    End Sub

    Private Sub cmdAceptar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        Dim lngNuevaSituacion As Integer
        Dim dtFact As New DataTable
        Dim dtApuntesFact As New DataTable
        Dim dtApuntesPago As New DataTable
        Dim objFilter As Filter
        Dim strFiltro As String
        Dim adr() As DataRow
        Try
            '//COMPROBAR LAS FACTURAS
            objFilter = New Filter
            With objFilter
                .Clear()
                .UnionOperator = FilterUnionOperator.Or
                .Add(New IsNullFilterItem("NDeclaracionIva", False))
                .Add(New IsNullFilterItem("AñoDeclaracionIva", False))
                strFiltro = .Compose(New AdoFilterComposer)
            End With

            If Not IsNothing(jngFacturas.DataSource) Then
                dtFact = jngFacturas.DataSource.Copy
                'strFiltro = "NDeclaracionIva<>NULL OR AñoDeclaracionIva<>NULL "
                adr = dtFact.Select(strFiltro)
                If Not IsNothing(adr) AndAlso adr.Length > 0 Then
                    ExpertisApp.GenerateMessage("Alguna factura seleccionada está declarada. Debe desdeclararla/s antes de descontabilizar. Se cancelará el proceso.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End If
                adr = Nothing
            End If

            '//COMPROBAR LOS APUNTES DE LAS FACTURAS
            With objFilter
                .Clear()
                .Add(New IsNullFilterItem("MesCierre", False))
                strFiltro = .Compose(New AdoFilterComposer)
            End With
            If Not IsNothing(jngApuntesFact.DataSource) Then
                dtApuntesFact = jngApuntesFact.DataSource.Copy
                'strFiltro = "MesCierre<>NULL"   
                adr = dtApuntesFact.Select(strFiltro)
                If Not IsNothing(adr) AndAlso adr.Length > 0 Then
                    '9461: Alguna factura está contabilizada en un periodo cerrado. Debe deshacer el cierre de ese periodo para descontabilizar la factura.
                    ExpertisApp.GenerateMessage("Alguna factura está contabilizada en un período cerrado.Debe deshacer el cierre de ese periodo para descontabilizar la factura.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End If
                adr = Nothing
            End If

            '//Comprobar si alguno de los Pagos es agrupado.
            Dim objFilterPagoAgrupado As New Filter
            objFilterPagoAgrupado.Add(New IsNullFilterItem("IDPagoAgrupado", False))
            If Not IsNothing(jngPagos.DataSource) AndAlso CType(jngPagos.DataSource, DataTable).Rows.Count > 0 Then
                Dim adrPagosAgrupados() As DataRow = CType(jngPagos.DataSource, DataTable).Select(objFilterPagoAgrupado.Compose(New AdoFilterComposer))
                If Not IsNothing(adrPagosAgrupados) AndAlso adrPagosAgrupados.Length > 0 Then
                    ExpertisApp.GenerateMessage("Algún Pago está Agrupado. No se puede descontabilizar una Factura con Pagos Agrupados. Debe descontabilizar y desagrupar dichos Pagos.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End If
            End If

            '//Comprobar si alguno de los Pagos ha generado un Cobro.
            Dim objFilterPagoGC As New Filter
            objFilterPagoGC.Add(New NumberFilterItem("Situacion", enumPagoSituacion.GeneradoCobro))
            If Not IsNothing(jngPagos.DataSource) AndAlso CType(jngPagos.DataSource, DataTable).Rows.Count > 0 Then
                Dim adrPagosGC() As DataRow = CType(jngPagos.DataSource, DataTable).Select(objFilterPagoGC.Compose(New AdoFilterComposer))
                If Not IsNothing(adrPagosGC) AndAlso adrPagosGC.Length > 0 Then
                    ExpertisApp.GenerateMessage("Algún Pago ha Generado un Cobro. Debe eliminar el Cobro Generado.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End If
            End If

            '//COMPROBAR LOSAPUNTES DE LOS PAGOS
            If Not IsNothing(jngApuntesPagos.DataSource) Then
                dtApuntesPago = jngApuntesPagos.DataSource.Copy
                If Not IsNothing(dtApuntesPago) AndAlso dtApuntesPago.Rows.Count <> 0 Then
                    'strFiltro = "MesCierre<>NULL"
                    'adr = dtApuntesPago.Select(strFiltro)
                    'If Not IsNothing(adr) AndAlso adr.Length > 0 Then
                    '9462: Algun pago está contabilizada en un periodo cerrado. Debe deshacer el cierre de ese periodo para descontabilizar la factura.
                    ExpertisApp.GenerateMessage("Deberá primero descontabilizar el pago correspondiente", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End If
                'End If
            End If


            '9464:Se eliminarán todos los apuntes contables de las facturas contabilizadas y de los pagos contabilizados seleccionados.
            '¿Desea continuar?
            If ExpertisApp.GenerateMessage("Se eliminarán todos los apuntes contables de las facturas contabilizadas y de los pagos contabilizados seleccionados.¿Desea continuar?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                If (fwiSituacion.Text) = String.Empty Then
                    lngNuevaSituacion = -1
                Else
                    lngNuevaSituacion = fwiSituacion.Text
                End If

                Dim dataDescont As New DataDescontabilizacion(mIDProcess, lngNuevaSituacion)
                ExpertisApp.ExecuteTask(Of DataDescontabilizacion)(AddressOf ContabilizacionFacturaComp.Descontabilizar, dataDescont)
            End If
            Me.Close()
        Catch ex As Exception
            ExpertisApp.GenerateMessage(ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            objFilter = Nothing
            adr = Nothing
            If Not IsNothing(dtFact) Then dtFact.Dispose()
            If Not IsNothing(dtApuntesFact) Then dtApuntesFact.Dispose()
            If Not IsNothing(dtApuntesPago) Then dtApuntesPago.Dispose()
        End Try
    End Sub

#End Region

End Class
