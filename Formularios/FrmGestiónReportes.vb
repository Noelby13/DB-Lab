Public Class FrmGestiónReportes
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







    End Sub

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