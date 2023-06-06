Public Class FrmGestiónReportes
    Dim data As New DsDBLab.TblIntervaloFechasDataTable
    Dim fechaInicio As DateTime
    Dim fechaFin As DateTime

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub CbxTipoReporte_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbxTipoReporte.SelectedIndexChanged
        If CbxTipoReporte.SelectedIndex > 7 Then
            CbxFecha.Enabled = True
        Else
            CbxFecha.Enabled = False
            CbxFecha.SelectedIndex = -1
        End If
    End Sub

    Private Sub BtnReporte_Click(sender As Object, e As EventArgs) Handles BtnReporte.Click
        If CbxTipoReporte.SelectedIndex = -1 Or CbxTipoReporte.SelectedIndex = 7 Or CbxTipoReporte.SelectedIndex = 0 Then
            MsgBox("Seleccione un tipo de reporte", vbInformation, "Reporte")
            Exit Sub
        End If

        'pregunta si quiere el reporte en la misma pantalla o en otra
        If CbxTipoReporte.SelectedIndex = 0 And CbxTipoReporte.SelectedIndex = 7 Then
            MsgBox("Seleccione un tipo de reporte", vbInformation, "Reporte")
            Exit Sub
        End If

        If CbxTipoReporte.SelectedIndex = 1 Then
            mostrarExamenesDisponibles()
        End If

        If CbxTipoReporte.SelectedIndex = 2 Then
            mostrarEstudiosDisponibles()
        End If

        If CbxTipoReporte.SelectedIndex = 3 Then
            mostrarCategoriasDisponibles()
        End If

        If CbxTipoReporte.SelectedIndex = 4 Then
            mostrarClientesDisponibles()
        End If

        If CbxTipoReporte.SelectedIndex = 5 Then
            mostrarCantidadEdades()
        End If

        If CbxTipoReporte.SelectedIndex = 6 Then
            mostrarDoctoresDisponibles()
        End If

        If CbxTipoReporte.SelectedIndex = 8 Then
            mostrarIngresosDias()
        End If

        If CbxTipoReporte.SelectedIndex = 9 Then
            mostrarVentasExamenes()
        End If

        If CbxTipoReporte.SelectedIndex = 10 Then
            mostrarIngresosCategorias()
        End If

        If CbxTipoReporte.SelectedIndex = 11 Then
            mostrarIngresosDoctor()
        End If



    End Sub

    Private Sub mostrarIngresosDoctor()
        If obtenerRangoFecha() = False Then
            Exit Sub
        End If

        Dim tbl As New DsDBLabTableAdapters.RptIngresosDoctorTableAdapter
        Dim datos = tbl.GetData(fechaInicio, fechaFin)
        verReportePersonalizado(datos, data, "DsIngresosDoctor", "DsFechas", "Reportes/RptIngresosDoctor.rdlc")
    End Sub



    Private Sub mostrarIngresosCategorias()
        If obtenerRangoFecha() = False Then
            Exit Sub
        End If
        Dim tbl As New DsDBLabTableAdapters.RptCategoriasVendidasTableAdapter
        Dim datos = tbl.GetData(fechaInicio, fechaFin)
        verReportePersonalizado(datos, data, "DsCategoriasVendidas", "DsFechas", "Reportes/RptCategoriasVendidas.rdlc")
    End Sub

    Private Sub mostrarVentasExamenes()
        If obtenerRangoFecha() = False Then
            Exit Sub
        End If

        Dim tbl As New DsDBLabTableAdapters.RptVentaExamenesTableAdapter
        Dim datos = tbl.GetData(fechaInicio, fechaFin)
        verReportePersonalizado(datos, data, "DsVentaExamenes", "DsFechas", "Reportes/RptVentaExamenes.rdlc")
    End Sub


    Private Sub mostrarIngresosDias()
        If obtenerRangoFecha() = False Then
            Exit Sub
        End If
        Dim tbl As New DsDBLabTableAdapters.RptIngresosDiasTableAdapter
        Dim datos = tbl.GetData(fechaInicio, fechaFin)
        verReportePersonalizado(datos, data, "DsIngresosDias", "DsFechas", "Reportes/RptIngresosDias.rdlc")
    End Sub

    Private Function obtenerRangoFecha()

        If CbxFecha.SelectedIndex = -1 Then
            MsgBox("Seleccione un rango de fecha", vbInformation, "Reporte")
            Return False
        End If

        'genera 2 datetime que tengan una semana de diferencia


        If CbxFecha.SelectedIndex = 0 Then
            fechaFin = Date.Now
            fechaInicio = Date.Now.AddDays(-7)
        End If

        If CbxFecha.SelectedIndex = 1 Then
            fechaFin = Date.Now
            fechaInicio = Date.Now.AddDays(-30)
        End If


        If CbxFecha.SelectedIndex = 2 Then
            fechaFin = Date.Now
            fechaInicio = Date.Now.AddDays(-365)
        End If

        'borra todos los datos que tenga el datatable incluidas las columnas
        data.Clear()
        'guarda estas fechas en un datatable
        data.Rows.Add(fechaInicio, fechaFin)

        Return True

    End Function





    Private Sub mostrarCantidadEdades()
        Dim tbl As New DsDBLabTableAdapters.RptCantidadEdadesTableAdapter
        Dim datos = tbl.GetData()
        verReporte(datos, "DsEdades", "Reportes/RptCantidadEdad.rdlc")

    End Sub
    Private Sub mostrarDoctoresDisponibles()
        Dim tbl As New DsDBLabTableAdapters.RptDoctoresDisponiblesTableAdapter
        Dim datos = tbl.GetData()
        verReporte(datos, "DsDoctoresDisponibles", "Reportes/RptDoctoresDisponibles.rdlc")
    End Sub
    Private Sub mostrarClientesDisponibles()
        Dim tbl As New DsDBLabTableAdapters.RptClientesDisponiblesTableAdapter
        Dim datos = tbl.GetData()
        verReporte(datos, "DsClientesDisponibles", "Reportes/RptClientesDisponibles.rdlc")

    End Sub

    Private Sub mostrarExamenesDisponibles()
        Dim tbl As New DsDBLabTableAdapters.RptExamenesDisponiblesTableAdapter
        Dim datos = tbl.GetData()
        verReporte(datos, "DsExamenesDisponible", "Reportes/RptExamenesDisponibles.rdlc")

    End Sub

    Private Sub mostrarEstudiosDisponibles()
        Dim tbl As New DsDBLabTableAdapters.RptEstudiosDisponiblesTableAdapter
        Dim datos = tbl.GetData()
        verReporte(datos, "DsEstudiosDisponibles", "Reportes/RptEstudiosDisponibles.rdlc")

    End Sub

    Private Sub mostrarCategoriasDisponibles()
        Dim tbl As New DsDBLabTableAdapters.RptCategoriasDisponiblesTableAdapter
        Dim datos = tbl.GetData()
        verReporte(datos, "DsCategoriasDisponibles", "Reportes/RptCategoriasDisponibles.rdlc")

    End Sub

    Private FrmActual As Form = Nothing
    Private Sub abrirFrmHijo(FrmHijo As Form)
        If FrmActual IsNot Nothing Then FrmActual.Close()
        FrmActual = FrmHijo
        FrmHijo.TopLevel = False
        FrmHijo.FormBorderStyle = FormBorderStyle.None
        FrmHijo.Dock = DockStyle.Fill
        PanelReportes.Controls.Add(FrmHijo)
        PanelReportes.Tag = FrmHijo
        FrmHijo.Show()
    End Sub




    Private Sub FrmGestiónReportes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class