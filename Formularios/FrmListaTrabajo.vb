Imports System.Runtime.InteropServices

Public Class FrmListaTrabajo
    Dim dataReport As New DataSet

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub

    Private Sub FrmListaTrabajo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'datos falsos XD
        'Dim fila As Object() = {"18878", "10:00", "Juan", "Sin Iniciar"}

        ''Agregar la fila al DataGridView
        'DataGridView1.Rows.Add(fila)

        ''Crear otra fila con datos falsos
        'fila = {"24545", "11:00", "Maria", "Procesando"}

        ''Agregar la segunda fila al DataGridView
        'DataGridView1.Rows.Add(fila)
        cargarTabla()

    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvLista.CellClick
        'Dim orden As String = Nothing
        'Dim nombre As String = Nothing
        'If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
        '    orden = DgvLista.Rows(e.RowIndex).Cells(0).Value.ToString()
        '    nombre = DgvLista.Rows(e.RowIndex).Cells(2).Value.ToString()
        'End If



        'Dim tabPage As TabPage = Nothing
        'For Each tab As TabPage In TabControl1.TabPages
        '    If tab.Name = orden Then
        '        tabPage = tab
        '    End If

        'Next

        'Dim gestor As New GestorPestaña(TabControl1)
        'If tabPage Is Nothing Then
        '    tabPage = gestor.crearPestaña(nombre, orden)
        '    TabControl1.Controls.Add(tabPage)
        'End If

        'TabControl1.SelectedTab = tabPage
    End Sub

    Private Sub cargarTabla()
        Try
            Dim dFactura As New DFactura
            Dim ds = dFactura.obtenerListaTrabajo()
            DgvLista.DataSource = ds.Tables(0)
            DgvLista.Columns(0).HeaderText = "Orden"
            DgvLista.Columns(1).HeaderText = "idPaciente"
            DgvLista.Columns(2).HeaderText = "Hora"
            DgvLista.Columns(3).HeaderText = "Nombre"
            DgvLista.Columns(4).HeaderText = "Estado"

            DgvLista.Columns(1).Visible = False

            LblHora.Text = DateTime.Now.ToString("hh:mm:ss")

            DgvLista.Refresh()
        Catch ex As Exception
            MsgBox("Ocurrio un error mientras se cargaban los datos")
        End Try

    End Sub
    Private Sub DgvLista_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles DgvLista.DataBindingComplete
        For Each fila As DataGridViewRow In DgvLista.Rows
            Dim estado As String = fila.Cells("Estado").Value.ToString()

            ' Comparar el valor de Estado y aplicar el color a la fila correspondiente
            Select Case estado.Trim()
                Case "Sin iniciar"
                    fila.Cells("Estado").Style.BackColor = Color.Red
                    fila.Cells("Estado").Style.ForeColor = Color.White
                Case "En desarrollo"
                    fila.Cells("Estado").Style.BackColor = Color.Yellow
                    fila.Cells("Estado").Style.ForeColor = Color.Black
                Case "Terminado"
                    fila.Cells("Estado").Style.BackColor = Color.Green
                    fila.Cells("Estado").Style.ForeColor = Color.White
            End Select
        Next
        DgvLista.ClearSelection()

    End Sub

    Private Sub BtnRecargar_Click(sender As Object, e As EventArgs) Handles BtnRecargar.Click
        cargarTabla()
    End Sub

    Private Sub DgvLista_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvLista.CellContentDoubleClick

    End Sub

    Private Sub DgvLista_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvLista.CellDoubleClick
        Dim fila As Integer = e.RowIndex

        'validar que no sea la fila de los titulos
        If fila >= 0 Then
            Dim idCliente = Convert.ToInt32(DgvLista.Rows(fila).Cells(1).Value.ToString())

            Dim dCliente As New DCliente

            Dim cliente As Cliente = dCliente.obtenerCliente(idCliente)

            TxtNombre.Text = cliente.PrimerNombre + " " + cliente.SegundoNombre + " " + cliente.PrimerApellido + " " + cliente.SegundoApellido
            'calcula fecha de nacimiento
            TxtEdad.Text = DateDiff(DateInterval.Year, cliente.FechaNacimiento, Now.Date)

            If cliente.Sexo Then
                TxtSexo.Text = "Masculino"
            Else
                TxtSexo.Text = "Femenino"
            End If

            TxtOrden.Text = DgvLista.Rows(fila).Cells(0).Value.ToString()
            rellenarGridTrabajo()
            'cambia de tabpage
            TabControl1.SelectedTab = TpResultado



        End If
    End Sub

    Private Sub rellenarGridTrabajo()
        Dim dDetalle As New D_DetalleFactura
        Dim dResultado As New DResultado
        Dim datos = dDetalle.obtenerExamenes(Convert.ToInt32(TxtOrden.Text))
        Dim resul = dResultado.obtenerResultados(Convert.ToInt32(TxtOrden.Text))
        Dim ds As New DataSet

        'crea la primera datatable del dataset

        If ds.Tables.Count = 0 Then
            'Creamos la tabla
            Dim dt As New DataTable
            dt.Columns.Add("idEstudio", GetType(Integer)) 'Nos va servir para identificar el estudio y asociarlo al resultado
            dt.Columns.Add("Nombre", GetType(String))
            dt.Columns.Add("Resultado", GetType(String))
            dt.Columns.Add("ValorReferencia", GetType(String))
            dt.Columns.Add("Unidad", GetType(String))
            ds.Tables.Add(dt)
        End If



        For Each fila As DataRow In datos.Tables(0).Rows
            Dim row As DataRow
            row = ds.Tables(0).NewRow()
            Dim idEstudio = fila("idEstudio").ToString()
            Dim nombreEstudio = fila("nombreEstudio").ToString()
            Dim resultado = ""
            Dim valorReferencia = ""


            Dim filaResultado = resul.Tables(0).Select("idEstudio = " + idEstudio)

            'If filaResultado.Length > 0 Then
            '    If Not IsDBNull(filaResultado(0)("ResultadoNumerico")) Then
            '        resultado = filaResultado(0)("ResultadoNumerico").ToString()
            '    ElseIf Not IsDBNull(filaResultado(0)("ResultadoTexto")) Then
            '        resultado = filaResultado(0)("ResultadoTexto").ToString()
            '    End If
            'End If

            If filaResultado.Length > 0 Then
                If filaResultado(0)("ResultadoNumerico").ToString() = "" Or filaResultado(0)("ResultadoNumerico").ToString() = "0" Then
                    resultado = filaResultado(0)("ResultadoTexto").ToString()
                Else
                    resultado = filaResultado(0)("ResultadoNumerico").ToString()
                End If
            End If



            If TxtSexo.Text = "Masculino" Then
                If fila("valorTextoH").ToString() = "" Then
                    valorReferencia = fila("valorInferiorH").ToString() + " - " + fila("valorSuperiorH").ToString()

                Else
                    valorReferencia = fila("valorTextoH").ToString()

                End If


            Else
                If fila("valorTextoM").ToString() = "" Then
                    valorReferencia = fila("valorInferiorM").ToString() + " - " + fila("valorSuperiorM").ToString()
                Else
                    valorReferencia = fila("valorTextoM").ToString()
                End If

            End If
            row("idEstudio") = Convert.ToInt32(idEstudio)
            row("Nombre") = nombreEstudio
            row("Resultado") = resultado
            row("ValorReferencia") = valorReferencia
            row("Unidad") = fila("nombre")

            ds.Tables(0).Rows.Add(row)

        Next
        dataReport = ds

        DgvResultados.DataSource = ds.Tables(0)
        DgvResultados.Columns(0).Visible = False
        DgvResultados.Columns(1).ReadOnly = True
        DgvResultados.Columns(2).ReadOnly = False
        DgvResultados.Columns(3).ReadOnly = True
        DgvResultados.Columns(4).ReadOnly = True

        DgvResultados.Refresh()


    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Dim resul As String
        Try
            'recorre la tabla y guarda los resultados de la columna resultados
            For Each fila As DataGridViewRow In DgvResultados.Rows
                'validar si no esta vacio
                If fila.Cells("Resultado").Value.ToString() = "" Then
                    Continue For
                End If


                Dim resultado As New Resultado

                resultado.IdEstudio = CInt(fila.Cells("idEstudio").Value.ToString())
                resul = fila.Cells("ValorReferencia").Value.ToString()
                'quiero verificar resul contiene "-"



                If resul.Contains("-") Then
                    resultado.ResultadoNumerico = CDec(fila.Cells("Resultado").Value.ToString())
                    resultado.ResultadoTexto = ""
                Else
                    resultado.ResultadoTexto = fila.Cells("Resultado").Value.ToString()
                    resultado.ResultadoNumerico = Nothing
                End If
                resultado.IdFactura = Convert.ToInt32(TxtOrden.Text)
                Dim dResultado As New DResultado
                If Not dResultado.upSertResultado(resultado) Then
                    MsgBox("Error al guardar los resultados")
                    Exit Sub
                End If


            Next

            MsgBox("Resultados guardados correctamente")

        Catch ex As Exception
            MsgBox("Error al guardar los resultados")
            MsgBox(ex.ToString())
        End Try
    End Sub


    'quiero verificar si cada vez que ingreso un datos en la columna resultado, se cumpla la condicion de que si es numerico, no se pueda ingresar texto y viceversa
    Private Sub DgvResultados_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles DgvResultados.CellValueChanged
        'verifica que solo sea para la columna resultados
        If e.ColumnIndex = 2 Then
            Dim fila As Integer = e.RowIndex
            Dim valorReferencia = DgvResultados.Rows(fila).Cells("ValorReferencia").Value.ToString()
            Dim resultado = DgvResultados.Rows(fila).Cells("Resultado").Value.ToString()

            If resultado = "" Then
                Exit Sub
            End If

            If valorReferencia.Contains("-") And Not IsNumeric(resultado) Then
                DgvResultados.Rows(fila).Cells(2).Value = ""
                MsgBox("El resultado debe ser numerico")
            End If

            If Not valorReferencia.Contains("-") And IsNumeric(resultado) Then
                DgvResultados.Rows(fila).Cells(2).Value = ""
                MsgBox("El resultado debe ser texto")
            End If

        End If


    End Sub

    Private Sub BtnReporte_Click(sender As Object, e As EventArgs) Handles BtnReporte.Click
        'Dim dDetalle As New D_DetalleFactura
        'Dim DResultado As New DResultado

        'Dim t = dDetalle.obtenerExamenes(Convert.ToInt32(TxtOrden.Text))

        '' genera una consulta linq para filtrar si un resultadoNumericoH tenga 0 o "" debe mostrar el resultadoTextoH, debe generar otra tabla que solo tenga los datos del reporte(NombreEstudio, resultado, valoresReferencia, unidad)
        'Dim resul = DResultado.obtenerResultados(Convert.ToInt32(TxtOrden.Text))
        'Dim ds As New DataSet
        Dim tblFactura As New DsDBLabTableAdapters.RptDatosFacturaTableAdapter
        Dim datosFactura = tblFactura.GetData(Convert.ToInt32(TxtOrden.Text))




        verReporteMedico(dataReport.Tables(0), datosFactura, "DsResultado", "DsDatosFactura", "Reportes/RptResultadoMedico.rdlc")
    End Sub


End Class