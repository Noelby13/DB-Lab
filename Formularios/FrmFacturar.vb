Imports DB_Lab.DsDBLabTableAdapters

Public Class FrmFacturar
    Dim dExamen As New DExamen
    Dim ds As New DataSet
    Dim dataExamen As New DataSet
    Dim exa As New Examen
    Public Property user As Usuario
    Private Sub FrmFacturar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenarRegistros()
        rellenarComboDoctores()
        inicializarDataExamen()
        rellenarAutoComplete()
        'oculta tabpage Examenes
        TabPaciente.TabPages.Remove(Examenes)

    End Sub

    Private Sub inicializarDataExamen()
        ''crea el primer datatable de dataExamen
        If dataExamen.Tables.Count = 0 Then
            'Creamos la tabla
            Dim dt As New DataTable
            dt.Columns.Add("ID", GetType(Integer))
            dt.Columns.Add("Nombre", GetType(String))
            dt.Columns.Add("Precio", GetType(Decimal))
            dataExamen.Tables.Add(dt)
        End If
    End Sub


    Private Sub rellenarAutoComplete()
        ds = dExamen.listarExamenes()
        Using ds
            TxtExamen.AutoCompleteCustomSource.Clear()
            For Each fila As DataRow In ds.Tables(0).Rows
                TxtExamen.AutoCompleteCustomSource.Add(fila("Nombre").ToString())
            Next
        End Using

    End Sub

    Private Function obtenerIdExamen()
        'obten el id comparando el nombre del examen(txtexamen) con el dataset ds
        Dim idExamen As Integer = -1
        For Each fila As DataRow In ds.Tables(0).Rows
            If fila("Nombre").ToString().ToUpper = TxtExamen.Text.ToUpper Then
                idExamen = CInt(fila("idExamen"))
                exa.IdExamen = idExamen
                exa.Nombre = fila("Nombre").ToString()
                exa.Precio = CDec(fila("Precio"))
                Exit For
            End If
        Next
        Return idExamen
    End Function


    Private Sub rellenarComboDoctores()
        Dim ds As New DataSet
        Dim dDoctor As New DDoctor
        ds = dDoctor.obtenerDoctor
        CmbDoctor.DataSource = ds.Tables(0)
        CmbDoctor.DisplayMember = "Doctor"
        CmbDoctor.ValueMember = "idDoctor"

    End Sub

    Public Sub llenarRegistros()
        Dim dPaciente As New DPaciente

        DgvPacientes.DataSource = dPaciente.mostrarRegistros().Tables(0)
        DgvPacientes.Refresh()
        DgvPacientes.Columns(6).Visible = False
    End Sub

    Private Sub BtnBuscarPaciente_Click(sender As Object, e As EventArgs) Handles BtnBuscarPaciente.Click
        'validar que no sea vacio
        If TxtPaciente.Text = "" Then
            MessageBox.Show("Debe ingresar un valor para realizar la busqueda", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If CbxFiltro.SelectedIndex = -1 Then
            MessageBox.Show("Debe seleccionar un filtro para realizar la busqueda", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If CbxFiltro.SelectedIndex = 0 Then
            Dim dPaciente As New DPaciente
            DgvPacientes.DataSource = dPaciente.listaPacienteCedula(TxtPaciente.Text).Tables(0)

            DgvPacientes.Refresh()
            DgvPacientes.Columns(6).Visible = False
        End If

        If CbxFiltro.SelectedIndex = 1 Then
            Dim dPaciente As New DPaciente
            DgvPacientes.DataSource = dPaciente.listaPacienteNombre(TxtPaciente.Text).Tables(0)
            DgvPacientes.Refresh()

            DgvPacientes.Columns(6).Visible = False
        End If

    End Sub

    Private Sub TxtPaciente_TextChanged(sender As Object, e As EventArgs) Handles TxtPaciente.TextChanged
        If TxtPaciente.Text = "" Then
            llenarRegistros()
        End If
    End Sub




    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub

    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click
        If TxtExamen.Text = "" Then
            MessageBox.Show("Debe ingresar un valor para realizar la busqueda", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        'verifica si el examen esta en el dataset dataExamen
        Dim idExamen As Integer = obtenerIdExamen()
        If idExamen = -1 Then
            MessageBox.Show("El examen no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        'verifica si el examen ya esta en el dataset dataExamen
        For Each fila As DataRow In dataExamen.Tables(0).Rows
            If fila("ID") = idExamen Then
                MessageBox.Show("El examen ya esta agregado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        Next
        'agrega el examen al dataset dataExamen

        Dim row As DataRow = dataExamen.Tables(0).NewRow()
        row("ID") = exa.IdExamen
        row("Nombre") = exa.Nombre
        row("Precio") = exa.Precio
        dataExamen.Tables(0).Rows.Add(row)


        'actualiza el datagridview
        DgvExamen.DataSource = dataExamen.Tables(0)
        DgvExamen.Refresh()
        DgvExamen.Columns(0).Visible = False

        'calcula el monto
        calcularMonto()


    End Sub

    Private Sub calcularMonto()
        'recorre el dataset dataExamen y suma los precios
        Dim monto As Decimal = 0
        For Each fila As DataRow In dataExamen.Tables(0).Rows
            monto += CDec(fila("Precio"))
        Next
        TxtMonto.Text = monto
    End Sub

    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click
        'pregunta si quieres generar una venta al nombre del cliente por un total de monto

        If CbxMetodoPago.SelectedIndex = -1 Then
            MessageBox.Show("Debe seleccionar un metodo de pago", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Dim result As Integer = MessageBox.Show("¿Desea generar una venta al nombre de " + DgvPacientes.CurrentRow.Cells(1).Value.ToString() + " por un total de " + TxtMonto.Text + "?", "Generar venta", MessageBoxButtons.YesNo)
        If result = DialogResult.No Then
            Exit Sub
        End If
        'inserta la venta
        Dim factura As New Factura
        Dim dFactura As New DFactura
        factura.Total = TxtMonto.Text
        factura.FechaEmision = DateTime.Now
        factura.IdPaciente = CInt(DgvPacientes.CurrentRow.Cells(0).Value.ToString())
        factura.IdDoctor = CInt(CmbDoctor.SelectedValue)
        factura.IdUsuario = user.IdUsuario
        factura.IdEstadoFactura = 1

        If CbxMetodoPago.SelectedIndex = 0 Then
            factura.IdMetodoPago = 1
        End If

        If CbxMetodoPago.SelectedIndex = 1 Then
            factura.IdMetodoPago = 2
        End If

        Dim idFactura = dFactura.guardarFactura(factura)
        If idFactura = -1 Then
            MsgBox("Error al guardar la factura")
            Exit Sub
        End If

        'inserta los examenes
        Dim dDetalles As New D_DetalleFactura
        For Each fila As DataRow In dataExamen.Tables(0).Rows
            Dim d As New DetalleFactura
            d.IdFactura = idFactura
            d.IdExamen = fila("ID")
            d.PrecioUnitario = fila("Precio")
            d.Cantidad = 1
            If Not dDetalles.guardarDetalles(d) Then
                MsgBox("Error al guardar los detalles")
                Exit Sub
            End If
        Next

        MsgBox("Los examenes han sido agregado a la lista de Trabajo")
        limpiarCampos()
    End Sub

    Private Sub limpiarCampos()
        LblTitulo.Text = "Facturar Examenes"
        TxtPaciente.Text = ""
        CmbDoctor.SelectedIndex = -1
        CbxMetodoPago.SelectedIndex = -1
        dataExamen.Tables(0).Rows.Clear()
        DgvExamen.Refresh()
        TxtMonto.Text = ""
        TxtExamen.Text = ""
        TxtPaciente.Focus()
        CbxFiltro.SelectedIndex = -1
    End Sub

    Private Sub DgvPacientes_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvPacientes.CellDoubleClick
        If e.RowIndex < 0 Then
            Exit Sub
        End If

        'cambia de pestaña
        LblTitulo.Text = "Facturar Examenes de " & DgvPacientes.Rows(e.RowIndex).Cells(1).Value.ToString()
        'agrega tabpage llamada Examenes
        TabPaciente.TabPages.Add(Examenes)

        TabPaciente.SelectedTab = Examenes

    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        limpiarCampos()
        'regresa a la pestaña de pacientes
        TabPaciente.SelectedTab = Paciente
        'oculta esta tabPage
        TabPaciente.TabPages.Remove(Examenes)

    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        'eliminalo del dataset dataExamen
        If TxtExamen.Text = "" Then
            Exit Sub
        End If

        Dim idExamen As Integer = obtenerIdExamen()

        For Each item As DataRow In dataExamen.Tables(0).Rows
            If item("ID") = idExamen Then
                item.Delete()
                Exit For
            End If
        Next
        DgvExamen.DataSource = dataExamen.Tables(0)
        DgvExamen.Refresh()
        calcularMonto()
    End Sub

    Private Sub DgvExamen_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvExamen.CellDoubleClick
        'seleciona el nombre del dvgexamen y poneselo a txtExamen
        TxtExamen.Text = DgvExamen.CurrentRow.Cells(1).Value.ToString()

    End Sub
End Class