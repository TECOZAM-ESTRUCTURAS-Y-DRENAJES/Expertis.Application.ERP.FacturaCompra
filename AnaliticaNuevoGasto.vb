Public Class AnaliticaNuevoGasto


#Region " Variables globales "

    Private mblnCancelarUpdating As Boolean '//PROVISIONAL, para cancelar un UpdatingCell, de una B.Avan.
    Private mstrCampoEnlace As String = "IDLineaFactura"
    Private MonInfo As MonedaInfo
    Private MonInfoA As MonedaInfo
    Private MonInfoB As MonedaInfo

#End Region

#Region " Variables globales - Niveles Analítica "

    Private mIntNiveles As Integer

    Private WithEvents sctIDAnalitica1 As AdvancedSearch
    Private WithEvents sctIDAnalitica2 As AdvancedSearch
    Private WithEvents sctIDAnalitica3 As AdvancedSearch
    Private WithEvents sctIDAnalitica4 As AdvancedSearch
    Private WithEvents sctIDAnalitica5 As AdvancedSearch

#End Region

#Region " Propiedades "

    Private mDataSource As DataTable
    Public Property DataSource() As DataTable
        Get
            Return mDataSource
        End Get
        Set(ByVal value As DataTable)
            mDataSource = value
        End Set
    End Property

    Private mIDCContable As String
    Public WriteOnly Property IDCContable() As String
        Set(ByVal value As String)
            mIDCContable = value
        End Set
    End Property

    Private mDescCContable As String
    Public WriteOnly Property DescCContable() As String
        Set(ByVal value As String)
            mDescCContable = value
        End Set
    End Property

    Private mAnalitica As Boolean
    Public Property Analitica() As Boolean
        Get
            Return mAnalitica
        End Get
        Set(ByVal value As Boolean)
            mAnalitica = value
        End Set
    End Property

    Private mImporte As Double
    Public WriteOnly Property Importe() As Double
        Set(ByVal value As Double)
            mImporte = value
        End Set
    End Property

    Private mEjercicio As String
    Private mFecha As Date
    Public WriteOnly Property Fecha() As Date
        Set(ByVal value As Date)
            mFecha = value
            mEjercicio = ExpertisApp.ExecuteTask(Of Date, String)(AddressOf EjercicioContable.Predeterminado, value)
        End Set
    End Property

    Private mIDMoneda As String
    Public WriteOnly Property IDMoneda() As String
        Set(ByVal value As String)
            mIDMoneda = value
        End Set
    End Property

#End Region

#Region " Carga del formulario "

    Private Sub AnaliticaNuevoGasto_BusinessCalling(ByVal sender As Object, ByVal e As Engine.UI.BusinessCallingEventArgs) Handles Me.BusinessCalling
        e.Data.Context.Clear()
        Select Case e.EntityName
            Case jngCentroCoste.EntityName
                e.Data.Context("ImporteLinea") = Me.nbxImporte.Value
                e.Data.Context("IDMoneda") = MonInfo.ID
                e.Data.Context("Fecha") = mFecha
        End Select
    End Sub

    Private Sub AnaliticaNuevoGasto_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Me.DesignMode Then
            LoadProperties()
            LoadERPData()
            LoadColumns()
            LoadAdvSearchSettings()

        End If
    End Sub

    Private Sub LoadProperties()
        Me.txtIDCContable.Text = mIDCContable
        Me.txtDescripcion.Text = mDescCContable
        Me.nbxImporte.Value = mImporte
        Me.clbFecha.Value = Me.mFecha

        Me.jngCentroCoste.DataSource = mDataSource
        CalcularAcumulados()

        If Length(mEjercicio) > 0 AndAlso Length(mIDCContable) > 0 Then
            Dim dtPlanC As DataTable = New PlanContable().SelOnPrimaryKey(mEjercicio, mIDCContable)
            If Not dtPlanC Is Nothing AndAlso dtPlanC.Rows.Count > 0 Then
                Me.Analitica = Nz(dtPlanC.Rows(0)("Analitica"), False)
            End If
        End If
    End Sub

    Private Sub LoadERPData()
        Dim datGetMoneda As New Moneda.DatosObtenerMoneda
        datGetMoneda.IDMoneda = mIDMoneda
        datGetMoneda.Fecha = Me.clbFecha.Value
        MonInfo = ExpertisApp.ExecuteTask(Of Moneda.DatosObtenerMoneda, MonedaInfo)(AddressOf Moneda.ObtenerMoneda, datGetMoneda)
        MonInfoA = ExpertisApp.ExecuteTask(Of Date, MonedaInfo)(AddressOf Moneda.MonedaA, clbFecha.Value)
        MonInfoB = ExpertisApp.ExecuteTask(Of Date, MonedaInfo)(AddressOf Moneda.MonedaB, clbFecha.Value)
    End Sub

#End Region

#Region " jngCentroCoste "

    Private Sub jngCentroCoste_EditingCell(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.EditingCellEventArgs) Handles jngCentroCoste.EditingCell
        e.Cancel = (jngCentroCoste.AllowAddNew = InheritableBoolean.False)
        If e.Cancel Then
            Select Case e.Column.Key
                Case "IDCentroCoste", "IDCentroGestion"
                    e.Column.ButtonStyle = ButtonStyle.NoButton
            End Select
        End If
    End Sub

    Private Sub jngCentroCoste_AddingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles jngCentroCoste.AddingRecord
        Dim jRow As GridEXRow = jngCentroCoste.GetRow(Grid.newTopRowPosition)
        With jRow
            If .Cells("IDCentroCoste").Value & String.Empty <> String.Empty Then
                '//Comprobar si se intenta introducir el mismo centro de coste en 2 registros diferentes.
                Dim objFilter As New Filter
                If Length(.Cells(mstrCampoEnlace).Value) > 0 Then
                    objFilter.Add(New StringFilterItem(mstrCampoEnlace, .Cells(mstrCampoEnlace).Value))
                End If
                objFilter.Add(New StringFilterItem("IDCentroCoste", .Cells("IDCentroCoste").Value))
                'objFilter.Add(New StringFilterItem("IDCentroGestion", .Cells("IDCentroGestion").Value))
                Dim adrRows() As DataRow = jngCentroCoste.DataSource.Select(objFilter.Compose(New AdoFilterComposer))
                If Not IsNothing(adrRows) AndAlso adrRows.Length = 1 Then
                    e.Cancel = True
                    ExpertisApp.GenerateMessage("El Centro de Coste ya existe en el desglose.", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
            If Not e.Cancel AndAlso Nz(.Cells("Porcentaje").Value, 0) = 0 Then
                e.Cancel = True
                Throw New Exception("El porcentaje no puede ser 0.")
            End If

        End With
    End Sub

    Private Sub jngCentroCoste_UpdatingCell(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.UpdatingCellEventArgs) Handles jngCentroCoste.UpdatingCell
        mblnCancelarUpdating = False
        Select Case e.Column.Key
            Case "IDCentroCoste" ', "IDCentroGestion"
                '//En las de Tipo de Analitica de Asiento Nuevo, no tenemos el IDApunte, con lo que no se puede comprobar en las BusinessRules
                '//los duplicados del Centro Coste, Centro Gestion.
                With jngCentroCoste
                    If .Row <> Grid.newTopRowPosition Then
                        If .Value("IDCentroCoste") & String.Empty <> String.Empty Then
                            '//Comprobar si se intenta introducir el mismo centro de coste en 2 registros diferentes.
                            Dim objFilter As New Filter
                            If Length(.Value(mstrCampoEnlace)) > 0 Then
                                objFilter.Add(New StringFilterItem(mstrCampoEnlace, .Value(mstrCampoEnlace)))
                            End If
                            If e.Column.Key = "IDCentroCoste" Then
                                objFilter.Add(New StringFilterItem("IDCentroCoste", e.Value))
                            Else
                                objFilter.Add(New StringFilterItem("IDCentroCoste", .Value("IDCentroCoste")))
                            End If
                            Dim adrRows() As DataRow = jngCentroCoste.DataSource.Select(objFilter.Compose(New AdoFilterComposer))
                            If Not IsNothing(adrRows) AndAlso adrRows.Length = 1 Then
                                ExpertisApp.GenerateMessage("El Centro de Coste ya existe en el desglose", MessageBoxButtons.OK, MessageBoxIcon.Error)

                                e.Cancel = True
                                mblnCancelarUpdating = True
                                .SetValue(e.Column.Key, e.InitialValue)
                            End If
                        End If
                    End If
                End With
        End Select

    End Sub

    Private Sub jngCentroCoste_UpdatingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles jngCentroCoste.UpdatingRecord
        e.Cancel = mblnCancelarUpdating
    End Sub

    Private Sub jngCentroCoste_RecordAdded(ByVal sender As Object, ByVal e As System.EventArgs) Handles jngCentroCoste.RecordAdded
        MostrarRestante()
    End Sub
    Private Sub jngCentroCoste_RecordUpdated(ByVal sender As Object, ByVal e As System.EventArgs) Handles jngCentroCoste.RecordUpdated
        MostrarRestante()
    End Sub
    Private Sub jngCentroCoste_RecordsDeleted(ByVal sender As Object, ByVal e As System.EventArgs) Handles jngCentroCoste.RecordsDeleted
        MostrarRestante()
    End Sub
    Private Sub CalcularAcumulados()
        With jngCentroCoste
            txtPorcentajeAcu.Text = xRound(.GetTotal(Nz(.Columns("Porcentaje"), 0), Janus.Windows.GridEX.AggregateFunction.Sum), cnDECIMALES_PORCENTAJE)
            nbxImporteAcumulado.Value = .GetTotal(Nz(.Columns("Importe"), 0), Janus.Windows.GridEX.AggregateFunction.Sum)
        End With
    End Sub
    Private Sub MostrarRestante()
        CalcularAcumulados()

        '//Cálculo de los restantes
        With jngCentroCoste
            .Columns("Importe").DefaultValue = xRound(Nz(nbxImporte.Value, 0) - Nz(nbxImporteAcumulado.Value, 0), MonInfo.NDecimalesImporte)
            .Columns("ImporteA").DefaultValue = xRound(.Columns("Importe").DefaultValue * MonInfo.CambioA, MonInfoA.NDecimalesImporte)
            .Columns("ImporteB").DefaultValue = xRound(.Columns("Importe").DefaultValue * MonInfo.CambioB, MonInfoB.NDecimalesImporte)
            .Columns("Porcentaje").DefaultValue = xRound(100 - Nz(txtPorcentajeAcu.Text, 0), cnDECIMALES_PORCENTAJE)
        End With
    End Sub

    Private Sub jngCentroCoste_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles jngCentroCoste.KeyDown
        If e.KeyCode = Keys.F9 AndAlso jngCentroCoste.Row = Grid.newTopRowPosition Then
            '//Para que pase la línea de insercción al grid.
            e.Handled = True
            System.Windows.Forms.SendKeys.Send("{Down}")
        End If
    End Sub

    Private Sub jngCentroCoste_InitCustomEdit(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.InitCustomEditEventArgs) Handles jngCentroCoste.InitCustomEdit
        Dim DtNew As New DataTable
        DtNew.Columns.Add("IDAnalitica1", GetType(String))
        DtNew.Columns.Add("IDAnalitica2", GetType(String))
        DtNew.Columns.Add("IDAnalitica3", GetType(String))
        DtNew.Columns.Add("IDAnalitica4", GetType(String))
        DtNew.Columns.Add("IDAnalitica5", GetType(String))

        SubGrid.DataSource = DtNew
        e.EditControl = SubGrid
        SubGrid.Row = Grid.newTopRowPosition

        Dim StrCoste As String = Nz(e.Value, String.Empty)
        If Length(StrCoste) > 0 Then
            Dim IntLenTotal As Integer = 0
            If mIntNiveles >= 1 Then IntLenTotal += cnLENGTH_NIVELES_ANALITICA
            If mIntNiveles >= 2 Then IntLenTotal += cnLENGTH_NIVELES_ANALITICA
            If mIntNiveles >= 3 Then IntLenTotal += cnLENGTH_NIVELES_ANALITICA
            If mIntNiveles >= 4 Then IntLenTotal += cnLENGTH_NIVELES_ANALITICA
            If mIntNiveles = 5 Then IntLenTotal += cnLENGTH_NIVELES_ANALITICA

            If Len(StrCoste) = IntLenTotal Then
                If mIntNiveles >= 1 Then
                    SubGrid.SetValue("IDAnalitica1", StrCoste.Substring(0, cnLENGTH_NIVELES_ANALITICA))
                End If
                If mIntNiveles >= 2 Then
                    SubGrid.SetValue("IDAnalitica2", StrCoste.Substring(cnLENGTH_NIVELES_ANALITICA, cnLENGTH_NIVELES_ANALITICA))
                End If
                If mIntNiveles >= 3 Then
                    SubGrid.SetValue("IDAnalitica3", StrCoste.Substring((2 * cnLENGTH_NIVELES_ANALITICA), cnLENGTH_NIVELES_ANALITICA))
                End If
                If mIntNiveles >= 4 Then
                    SubGrid.SetValue("IDAnalitica4", StrCoste.Substring((3 * cnLENGTH_NIVELES_ANALITICA), cnLENGTH_NIVELES_ANALITICA))
                End If
                If mIntNiveles >= 5 Then
                    SubGrid.SetValue("IDAnalitica5", StrCoste.Substring((4 * cnLENGTH_NIVELES_ANALITICA), cnLENGTH_NIVELES_ANALITICA))
                End If
            End If
        End If
    End Sub

    Private Sub jngCentroCoste_EndCustomEdit(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.EndCustomEditEventArgs) Handles jngCentroCoste.EndCustomEdit
        Dim StrCoste As String = CalcularIDCoste()
        If Len(StrCoste) > 0 Then
            e.Value = StrCoste
            CrearIDCoste(e.Value)
        End If
    End Sub

    Private Sub SubGrid_CellValueChanged(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles SubGrid.CellValueChanged
        If (e.Column.Index + 1) >= 0 AndAlso (e.Column.Index + 1) <= 4 Then
            If Len(CStr(SubGrid.GetValue("IDAnalitica" & (e.Column.Index + 1)))) = cnLENGTH_NIVELES_ANALITICA Then
                If ComprobarIDAnalitica(e.Column.Index + 1) Then
                    LimpiarIDAnaliticas(e.Column.Index + 2)
                    If e.Column.Index + 1 = mIntNiveles Then
                        jngCentroCoste.Col = 1
                    Else : SubGrid.Col += 1
                    End If
                Else
                    LimpiarIDAnaliticas(e.Column.Index + 2)
                End If
            End If
        Else
            If Len(CStr(SubGrid.GetValue("IDAnalitica5"))) = cnLENGTH_NIVELES_ANALITICA Then
                ComprobarIDAnalitica(e.Column.Index + 1)
                jngCentroCoste.Col = 1
            End If
        End If
    End Sub

    Private Sub SubGrid_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles SubGrid.Click
        Dim hit As GridArea
        With SubGrid
            hit = .HitTest()
            If hit = GridArea.CellButton Then
                Dim c As GridEXColumn = .ColumnFromPoint()
                If Not IsNothing(c) Then
                    Select Case c.Key
                        Case "IDAnalitica1"
                            sctIDAnalitica1.Open()
                        Case "IDAnalitica2"
                            sctIDAnalitica2.Open()
                        Case "IDAnalitica3"
                            sctIDAnalitica3.Open()
                        Case "IDAnalitica4"
                            sctIDAnalitica4.Open()
                        Case "IDAnalitica5"
                            sctIDAnalitica5.Open()
                    End Select
                End If
            End If
        End With
    End Sub

    Private Sub SubGrid_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles SubGrid.KeyUp
        If e.KeyCode = Keys.F4 Then
            Select Case SubGrid.Col
                Case SubGrid.Columns("IDAnalitica1").Index
                    sctIDAnalitica1.Open()
                Case SubGrid.Columns("IDAnalitica2").Index
                    sctIDAnalitica2.Open()
                Case SubGrid.Columns("IDAnalitica3").Index
                    sctIDAnalitica3.Open()
                Case SubGrid.Columns("IDAnalitica4").Index
                    sctIDAnalitica4.Open()
                Case SubGrid.Columns("IDAnalitica5").Index
                    sctIDAnalitica5.Open()
            End Select
        End If
    End Sub

    Private Sub SubGrid_AddingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles SubGrid.AddingRecord
        e.Cancel = True
    End Sub


    Private Function CalcularIDCoste() As String
        Dim StrIDCoste As String = String.Empty
        Dim IntCuenta As Integer = 0
        For i As Integer = 1 To mIntNiveles
            If Length(SubGrid.GetValue("IDAnalitica" & i)) = 0 Then
                IntCuenta += 1
            End If
        Next
        If IntCuenta = mIntNiveles Then
            StrIDCoste = String.Empty
        Else
            For j As Integer = 1 To mIntNiveles
                If Length(SubGrid.GetValue("IDAnalitica" & j)) = 0 Then
                    SubGrid.SetValue("IDAnalitica" & j, New String("@", mIntNiveles))
                End If
                jngCentroCoste.SetValue("IDAnalitica" & j, SubGrid.GetValue("IDAnalitica" & j))
                StrIDCoste &= SubGrid.GetValue("IDAnalitica" & j)
            Next
        End If
        Return StrIDCoste
    End Function

#Region " Analítica  Multinivel "
    Private Sub LoadColumns()
        mIntNiveles = New Parametro().NivelesDeAnalitica
        If mIntNiveles <> CInt(EnumNivelesAnalitica.Nivel0) Then
            Dim ClsBE As New BE.DataEngine
            Dim DtAnalit1 As DataTable = ClsBE.GetPrimaryKey("AnaliticaNivel1")
            Dim DtAnalit2 As DataTable = ClsBE.GetPrimaryKey("AnaliticaNivel2")
            Dim DtAnalit3 As DataTable = ClsBE.GetPrimaryKey("AnaliticaNivel3")
            Dim DtAnalit4 As DataTable = ClsBE.GetPrimaryKey("AnaliticaNivel4")
            Dim DtAnalit5 As DataTable = ClsBE.GetPrimaryKey("AnaliticaNivel5")
            jngCentroCoste.Columns("IDCentroCoste").EditType = EditType.Custom

            SubGrid.Columns("IDAnalitica1").MaxLength = DtAnalit1.Columns(0).MaxLength
            SubGrid.Columns("IDAnalitica1").InputMask = New String("A", DtAnalit1.Columns(0).MaxLength)
            SubGrid.Columns("IDAnalitica2").MaxLength = DtAnalit2.Columns(0).MaxLength
            SubGrid.Columns("IDAnalitica2").InputMask = New String("A", DtAnalit2.Columns(0).MaxLength)
            SubGrid.Columns("IDAnalitica3").MaxLength = DtAnalit3.Columns(0).MaxLength
            SubGrid.Columns("IDAnalitica3").InputMask = New String("A", DtAnalit3.Columns(0).MaxLength)
            SubGrid.Columns("IDAnalitica4").MaxLength = DtAnalit4.Columns(0).MaxLength
            SubGrid.Columns("IDAnalitica4").InputMask = New String("A", DtAnalit4.Columns(0).MaxLength)
            SubGrid.Columns("IDAnalitica5").MaxLength = DtAnalit5.Columns(0).MaxLength
            SubGrid.Columns("IDAnalitica5").InputMask = New String("A", DtAnalit5.Columns(0).MaxLength)

            Select Case mIntNiveles
                Case 1
                    SubGrid.Columns("IDAnalitica2").Visible = False : SubGrid.Columns("IDAnalitica2").EditType = EditType.NoEdit : SubGrid.Columns("IDAnalitica2").ButtonStyle = ButtonStyle.NoButton
                    SubGrid.Columns("IDAnalitica3").Visible = False : SubGrid.Columns("IDAnalitica3").EditType = EditType.NoEdit : SubGrid.Columns("IDAnalitica3").ButtonStyle = ButtonStyle.NoButton
                    SubGrid.Columns("IDAnalitica4").Visible = False : SubGrid.Columns("IDAnalitica4").EditType = EditType.NoEdit : SubGrid.Columns("IDAnalitica4").ButtonStyle = ButtonStyle.NoButton
                    SubGrid.Columns("IDAnalitica5").Visible = False : SubGrid.Columns("IDAnalitica5").EditType = EditType.NoEdit : SubGrid.Columns("IDAnalitica5").ButtonStyle = ButtonStyle.NoButton
                Case 2
                    SubGrid.Columns("IDAnalitica3").Visible = False : SubGrid.Columns("IDAnalitica3").EditType = EditType.NoEdit : SubGrid.Columns("IDAnalitica3").ButtonStyle = ButtonStyle.NoButton
                    SubGrid.Columns("IDAnalitica4").Visible = False : SubGrid.Columns("IDAnalitica4").EditType = EditType.NoEdit : SubGrid.Columns("IDAnalitica4").ButtonStyle = ButtonStyle.NoButton
                    SubGrid.Columns("IDAnalitica5").Visible = False : SubGrid.Columns("IDAnalitica5").EditType = EditType.NoEdit : SubGrid.Columns("IDAnalitica5").ButtonStyle = ButtonStyle.NoButton
                Case 3
                    SubGrid.Columns("IDAnalitica4").Visible = False : SubGrid.Columns("IDAnalitica4").EditType = EditType.NoEdit : SubGrid.Columns("IDAnalitica4").ButtonStyle = ButtonStyle.NoButton
                    SubGrid.Columns("IDAnalitica5").Visible = False : SubGrid.Columns("IDAnalitica5").EditType = EditType.NoEdit : SubGrid.Columns("IDAnalitica5").ButtonStyle = ButtonStyle.NoButton
                Case 4
                    SubGrid.Columns("IDAnalitica5").Visible = False : SubGrid.Columns("IDAnalitica5").EditType = EditType.NoEdit : SubGrid.Columns("IDAnalitica5").ButtonStyle = ButtonStyle.NoButton
            End Select

            jngCentroCoste.Columns("IDCentroCoste").Width = mIntNiveles * 80
        Else
            jngCentroCoste.Columns("IDCentroCoste").EditType = EditType.TextBox
            jngCentroCoste.AdvSearchColumns.Add("CentroCosteAnalitica", "IDCentroCoste", "IDCentroCoste")
            Dim AssCol As New Engine.UI.ASSelectedColumn("DescCentroCoste", "DescCentroCoste")
            jngCentroCoste.AdvSearchColumns(0).SelectedColumns.Add(AssCol)
            Dim AdvIcon As New Icon(Engine.UI.Resources.AdvSearchIcon, 16, 16)
            jngCentroCoste.Columns("IDCentroCoste").ButtonStyle = ButtonStyle.Image
            jngCentroCoste.Columns("IDCentroCoste").ButtonImage = AdvIcon.ToBitmap
            jngCentroCoste.Columns("IDCentroCoste").Width = 100
        End If
    End Sub


    Private Sub LoadAdvSearchSettings()
        If mIntNiveles <> CInt(EnumNivelesAnalitica.Nivel0) Then
            Dim AdvIcon As New Icon(Engine.UI.Resources.AdvSearchIcon, 16, 16)
            sctIDAnalitica1 = New AdvancedSearch
            sctIDAnalitica1.EntityName = "AnaliticaNivel1"
            SubGrid.Columns("IDAnalitica1").ButtonImage = AdvIcon.ToBitmap

            Dim f As Filter
            sctIDAnalitica2 = New AdvancedSearch
            Dim dtR12 As DataTable = New AnaliticaR12().Filter(f, , "TOP 1 *")
            If Not dtR12 Is Nothing AndAlso dtR12.Rows.Count > 0 Then
                sctIDAnalitica2.EntityName = "AnaliticaR12"
                sctIDAnalitica2.ViewName = "vFrmAnaliticaR12"
            Else
                sctIDAnalitica2.EntityName = "AnaliticaNivel2"
            End If
            SubGrid.Columns("IDAnalitica2").ButtonImage = AdvIcon.ToBitmap

            sctIDAnalitica3 = New AdvancedSearch
            Dim dtR23 As DataTable = New AnaliticaR23().Filter(f, , "TOP 1 *")
            If Not dtR23 Is Nothing AndAlso dtR23.Rows.Count > 0 Then
                sctIDAnalitica3.EntityName = "AnaliticaR23"
                sctIDAnalitica3.ViewName = "vFrmAnaliticaR23"
            Else
                sctIDAnalitica3.EntityName = "AnaliticaNivel3"
            End If
            SubGrid.Columns("IDAnalitica3").ButtonImage = AdvIcon.ToBitmap

            sctIDAnalitica4 = New AdvancedSearch
            Dim dtR34 As DataTable = New AnaliticaR34().Filter(f, , "TOP 1 *")
            If Not dtR34 Is Nothing AndAlso dtR34.Rows.Count > 0 Then
                sctIDAnalitica4.EntityName = "AnaliticaR34"
                sctIDAnalitica4.ViewName = "vFrmAnaliticaR34"
            Else
                sctIDAnalitica4.EntityName = "AnaliticaNivel4"
            End If
            SubGrid.Columns("IDAnalitica4").ButtonImage = AdvIcon.ToBitmap

            sctIDAnalitica5 = New AdvancedSearch
            Dim dtR45 As DataTable = New AnaliticaR45().Filter(f, , "TOP 1 *")
            If Not dtR45 Is Nothing AndAlso dtR45.Rows.Count > 0 Then
                sctIDAnalitica5.EntityName = "AnaliticaR45"
                sctIDAnalitica5.ViewName = "vFrmAnaliticaR45"
            Else
                sctIDAnalitica5.EntityName = "AnaliticaNivel5"
            End If
            SubGrid.Columns("IDAnalitica5").ButtonImage = AdvIcon.ToBitmap
        End If
    End Sub

    Private Sub ComprobarIDCoste()
        Dim ClsCoste As New CentroCosteAnalitica
        Dim DtCoste As DataTable
        Dim DtCosteFinal As DataTable = ClsCoste.AddNew
        Dim DtGrid As DataTable = jngCentroCoste.DataSource

        Dim IntLenAnalit1 As Integer = DtCosteFinal.Columns("IDAnalitica1").MaxLength
        Dim IntLenAnalit2 As Integer = DtCosteFinal.Columns("IDAnalitica2").MaxLength
        Dim IntLenAnalit3 As Integer = DtCosteFinal.Columns("IDAnalitica3").MaxLength
        Dim IntLenAnalit4 As Integer = DtCosteFinal.Columns("IDAnalitica4").MaxLength
        Dim IntLenAnalit5 As Integer = DtCosteFinal.Columns("IDAnalitica5").MaxLength

        For Each Dr As DataRow In DtGrid.Select
            DtCoste = ClsCoste.SelOnPrimaryKey(Dr("IDCentroCoste"))
            If DtCoste Is Nothing OrElse DtCoste.Rows.Count = 0 Then
                Dim DrNew As DataRow = DtCosteFinal.NewRow
                DrNew("IDCentroCoste") = Dr("IDCentroCoste")
                DrNew("DescCentroCoste") = "Desc. Centro: " & Dr("IDCentroCoste")
                If mIntNiveles >= 1 Then
                    DrNew("IDAnalitica1") = DrNew("IDCentroCoste").Substring(0, IntLenAnalit1)
                End If
                If mIntNiveles >= 2 Then
                    DrNew("IDAnalitica2") = DrNew("IDCentroCoste").Substring(IntLenAnalit1, IntLenAnalit2)
                End If
                If mIntNiveles >= 3 Then
                    DrNew("IDAnalitica3") = DrNew("IDCentroCoste").Substring((IntLenAnalit1 + IntLenAnalit2), IntLenAnalit3)
                End If
                If mIntNiveles >= 4 Then
                    DrNew("IDAnalitica4") = DrNew("IDCentroCoste").Substring((IntLenAnalit1 + IntLenAnalit2 + IntLenAnalit3), IntLenAnalit4)
                End If
                If mIntNiveles >= 5 Then
                    DrNew("IDAnalitica5") = DrNew("IDCentroCoste").Substring((IntLenAnalit1 + IntLenAnalit2 + IntLenAnalit3 + IntLenAnalit4), IntLenAnalit5)
                End If
                DtCosteFinal.Rows.Add(DrNew)
            End If
        Next
        If DtCosteFinal.Rows.Count > 0 Then ClsCoste.Update(DtCosteFinal)
    End Sub

    Private Sub CrearIDCoste(ByVal StrIDCoste As String)
        Dim ClsCoste As New CentroCosteAnalitica
        Dim DtCoste As DataTable = ClsCoste.SelOnPrimaryKey(StrIDCoste)
        If DtCoste Is Nothing OrElse DtCoste.Rows.Count = 0 Then
            Dim DtNew As DataTable = DtCoste.Clone
            Dim DrNew As DataRow = DtNew.NewRow
            DrNew("IDCentroCoste") = StrIDCoste
            DrNew("DescCentroCoste") = "Centro Coste Analitico"
            DrNew("IDAnalitica1") = SubGrid.GetValue("IDAnalitica1")
            DrNew("IDAnalitica2") = SubGrid.GetValue("IDAnalitica2")
            DrNew("IDAnalitica3") = SubGrid.GetValue("IDAnalitica3")
            DrNew("IDAnalitica4") = SubGrid.GetValue("IDAnalitica4")
            DrNew("IDAnalitica5") = SubGrid.GetValue("IDAnalitica5")
            DtNew.Rows.Add(DrNew)
            ClsCoste.Update(DtNew)
        End If
    End Sub

    Private Function ComprobarIDAnalitica(ByVal IntLevel As Integer) As Boolean
        Dim ClsObj As BE.BusinessHelper
        Select Case IntLevel
            Case 1
                ClsObj = New AnaliticaNivel1
            Case 2
                ClsObj = New AnaliticaNivel2
            Case 3
                ClsObj = New AnaliticaNivel3
            Case 4
                ClsObj = New AnaliticaNivel4
            Case 5
                ClsObj = New AnaliticaNivel5
        End Select

        Dim DtAnalit As DataTable = ClsObj.SelOnPrimaryKey(SubGrid.GetValue("IDAnalitica" & IntLevel))
        If DtAnalit Is Nothing OrElse DtAnalit.Rows.Count = 0 Then
            ExpertisApp.GenerateMessage("El Código introducido no existe.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            SubGrid.SetValue("IDAnalitica" & IntLevel, String.Empty)
            Return False
        Else
            Dim FilBE As New Filter
            Dim DtBE As DataTable
            Dim ClsBE As New BE.DataEngine
            Select Case IntLevel
                Case 2
                    FilBE.Add("IDAnalitica1", FilterOperator.Equal, SubGrid.GetValue("IDAnalitica1"))
                    FilBE.Add("IDAnalitica2", FilterOperator.Equal, SubGrid.GetValue("IDAnalitica2"))
                    DtBE = ClsBE.Filter("vFrmAnaliticaR12", FilBE)
                    If DtBE Is Nothing OrElse DtBE.Rows.Count = 0 Then
                        DtBE = ClsBE.Filter("vFrmAnaliticaR12", Nothing)
                        If Not DtBE Is Nothing AndAlso DtBE.Rows.Count > 0 Then
                            ExpertisApp.GenerateMessage("El Código introducido no existe.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                            SubGrid.SetValue("IDAnalitica" & IntLevel, String.Empty)
                            Return False
                        End If
                    End If
                Case 3
                    FilBE.Add("IDAnalitica2", FilterOperator.Equal, SubGrid.GetValue("IDAnalitica2"))
                    FilBE.Add("IDAnalitica3", FilterOperator.Equal, SubGrid.GetValue("IDAnalitica3"))
                    DtBE = ClsBE.Filter("vFrmAnaliticaR23", FilBE)
                    If DtBE Is Nothing OrElse DtBE.Rows.Count = 0 Then
                        DtBE = ClsBE.Filter("vFrmAnaliticaR23", Nothing)
                        If Not DtBE Is Nothing AndAlso DtBE.Rows.Count > 0 Then
                            ExpertisApp.GenerateMessage("El Código introducido no existe.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                            SubGrid.SetValue("IDAnalitica" & IntLevel, String.Empty)
                            Return False
                        End If
                    End If
                Case 4
                    FilBE.Add("IDAnalitica3", FilterOperator.Equal, SubGrid.GetValue("IDAnalitica3"))
                    FilBE.Add("IDAnalitica4", FilterOperator.Equal, SubGrid.GetValue("IDAnalitica4"))
                    DtBE = ClsBE.Filter("vFrmAnaliticaR34", FilBE)
                    If DtBE Is Nothing OrElse DtBE.Rows.Count = 0 Then
                        DtBE = ClsBE.Filter("vFrmAnaliticaR34", Nothing)
                        If Not DtBE Is Nothing AndAlso DtBE.Rows.Count > 0 Then
                            ExpertisApp.GenerateMessage("El Código introducido no existe.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                            SubGrid.SetValue("IDAnalitica" & IntLevel, String.Empty)
                            Return False
                        End If
                    End If
                Case 5
                    FilBE.Add("IDAnalitica4", FilterOperator.Equal, SubGrid.GetValue("IDAnalitica4"))
                    FilBE.Add("IDAnalitica5", FilterOperator.Equal, SubGrid.GetValue("IDAnalitica5"))
                    DtBE = ClsBE.Filter("vFrmAnaliticaR45", FilBE)
                    If DtBE Is Nothing OrElse DtBE.Rows.Count = 0 Then
                        DtBE = ClsBE.Filter("vFrmAnaliticaR45", Nothing)
                        If Not DtBE Is Nothing AndAlso DtBE.Rows.Count > 0 Then
                            ExpertisApp.GenerateMessage("El Código introducido no existe.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                            SubGrid.SetValue("IDAnalitica" & IntLevel, String.Empty)
                            Return False
                        End If
                    End If
            End Select
        End If
        Return True
    End Function

    Private Sub LimpiarIDAnaliticas(ByVal IntLevelDesde As Integer)
        For i As Integer = IntLevelDesde To mIntNiveles
            SubGrid.SetValue("IDAnalitica" & i, String.Empty)
        Next
    End Sub

#End Region


#End Region

#Region " AdvSearch - Niveles Analítica "

    Private Sub sctIDAnalitica1_SelectionChanged(ByVal sender As Object, ByVal e As Engine.UI.AdvSearchSelectionChangedEventArgs) Handles sctIDAnalitica1.SelectionChanged
        SubGrid.SetValue("IDAnalitica1", e.Selected.Rows(0)("IDAnalitica1"))
    End Sub

    Private Sub sctIDAnalitica2_SelectionChanged(ByVal sender As Object, ByVal e As Engine.UI.AdvSearchSelectionChangedEventArgs) Handles sctIDAnalitica2.SelectionChanged
        SubGrid.SetValue("IDAnalitica2", e.Selected.Rows(0)("IDAnalitica2"))
    End Sub

    Private Sub sctIDAnalitica3_SelectionChanged(ByVal sender As Object, ByVal e As Engine.UI.AdvSearchSelectionChangedEventArgs) Handles sctIDAnalitica3.SelectionChanged
        SubGrid.SetValue("IDAnalitica3", e.Selected.Rows(0)("IDAnalitica3"))
    End Sub

    Private Sub sctIDAnalitica4_SelectionChanged(ByVal sender As Object, ByVal e As Engine.UI.AdvSearchSelectionChangedEventArgs) Handles sctIDAnalitica4.SelectionChanged
        SubGrid.SetValue("IDAnalitica4", e.Selected.Rows(0)("IDAnalitica4"))
    End Sub

    Private Sub sctIDAnalitica5_SelectionChanged(ByVal sender As Object, ByVal e As Engine.UI.AdvSearchSelectionChangedEventArgs) Handles sctIDAnalitica5.SelectionChanged
        SubGrid.SetValue("IDAnalitica5", e.Selected.Rows(0)("IDAnalitica5"))
    End Sub

    Private Sub sctIDAnalitica2_SetPredefinedFilter(ByVal sender As Object, ByVal e As Engine.UI.AdvSearchFilterEventArgs) Handles sctIDAnalitica2.SetPredefinedFilter
        If sctIDAnalitica2.EntityName = GetType(AnaliticaR12).Name Then
            If Length(SubGrid.GetValue("IDAnalitica1")) > 0 Then
                e.Filter.Add("IDAnalitica1", FilterOperator.Equal, SubGrid.GetValue("IDAnalitica1"))
            End If
        End If
    End Sub

    Private Sub sctIDAnalitica3_SetPredefinedFilter(ByVal sender As Object, ByVal e As Engine.UI.AdvSearchFilterEventArgs) Handles sctIDAnalitica3.SetPredefinedFilter
        If sctIDAnalitica3.EntityName = GetType(AnaliticaR23).Name Then
            If Length(SubGrid.GetValue("IDAnalitica2")) > 0 Then
                e.Filter.Add("IDAnalitica2", FilterOperator.Equal, SubGrid.GetValue("IDAnalitica2"))
            End If
        End If
    End Sub

    Private Sub sctIDAnalitica4_SetPredefinedFilter(ByVal sender As Object, ByVal e As Engine.UI.AdvSearchFilterEventArgs) Handles sctIDAnalitica4.SetPredefinedFilter
        If sctIDAnalitica4.EntityName = GetType(AnaliticaR34).Name Then
            If Length(SubGrid.GetValue("IDAnalitica3")) > 0 Then
                e.Filter.Add("IDAnalitica3", FilterOperator.Equal, SubGrid.GetValue("IDAnalitica3"))
            End If
        End If
    End Sub

    Private Sub sctIDAnalitica5_SetPredefinedFilter(ByVal sender As Object, ByVal e As Engine.UI.AdvSearchFilterEventArgs) Handles sctIDAnalitica5.SetPredefinedFilter
        If sctIDAnalitica5.EntityName = GetType(AnaliticaR45).Name Then
            If Length(SubGrid.GetValue("IDAnalitica4")) > 0 Then
                e.Filter.Add("IDAnalitica4", FilterOperator.Equal, SubGrid.GetValue("IDAnalitica4"))
            End If
        End If
    End Sub

#End Region

#Region " Aceptar/Cancelar "

    Private Sub cmbAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbAceptar.Click
        If ValidacionesPrevias() Then
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        End If
    End Sub

    Private Function ValidacionesPrevias() As Boolean
        ValidacionesPrevias = False
        If ValidarCuentaAnalitica() Then
            If ValidarPorcentajeAsignado() Then
                If ValidarImporteAsignado() Then
                    ValidacionesPrevias = True
                End If
            End If
        End If
    End Function

    Private Function ValidarCuentaAnalitica() As Boolean
        ValidarCuentaAnalitica = True
        If jngCentroCoste.RowCount = 0 AndAlso Me.Analitica Then
            ValidarCuentaAnalitica = False
            ExpertisApp.GenerateMessage("La Cuenta es Analítica y debe contener algún desglose.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Function

    Private Function ValidarPorcentajeAsignado() As Boolean
        Dim f As New Filter
        f.Add(New NumberFilterItem("Porcentaje", FilterOperator.NotEqual, 0))
        Dim PorcAsignado As Double = CType(jngCentroCoste.DataSource, DataTable).Compute("SUM(Porcentaje)", f.Compose(New AdoFilterComposer))
        If PorcAsignado <> 100 Then
            ValidarPorcentajeAsignado = False
            ExpertisApp.GenerateMessage("Revise el Porcentaje asignado, debe sumar 100.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            ValidarPorcentajeAsignado = True
        End If
    End Function

    Private Function ValidarImporteAsignado() As Boolean
        ValidarImporteAsignado = True
        If (nbxImporteAcumulado.Value <> 0 OrElse (nbxImporteAcumulado.Value = 0 AndAlso Me.Analitica)) _
                        AndAlso xRound(nbxImporteAcumulado.Value, MonInfoA.NDecimalesImporte) <> xRound(Me.nbxImporte.Value, MonInfoA.NDecimalesImporte) Then
            ValidarImporteAsignado = False
            ExpertisApp.GenerateMessage("La suma  de los Importes de las líneas, no coincide con el Importe del Apunte.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Function

    Private Sub cmbCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCancelar.Click
        Me.Close()
    End Sub

#End Region


End Class