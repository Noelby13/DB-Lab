Imports Microsoft.Reporting.WinForms

Module Modulo

    Sub verReporte(ByVal t As DataTable, ByVal nombreDS As String, ByVal nombreRpt As String)
        Try
            Dim rpt As New ReportDataSource(nombreDS, t)
            With FrmVistaPrevia
                .ReportViewer1.LocalReport.DataSources.Clear()
                .ReportViewer1.LocalReport.DataSources.Add(rpt)
                .ReportViewer1.LocalReport.ReportPath = nombreRpt
                .ReportViewer1.RefreshReport()
                .Show()
            End With

        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try

    End Sub

    Sub verReporteMedico(ByVal t As DataTable, ByVal fac As DataTable, ByVal nombreDsResultados As String, nombreDsDatosFactura As String, ByVal nombreRpt As String)
        Try
            Dim rpt As New ReportDataSource(nombreDsResultados, t)
            Dim rpt1 As New ReportDataSource(nombreDsDatosFactura, fac)

            With FrmVistaPrevia
                .ReportViewer1.LocalReport.DataSources.Clear()
                .ReportViewer1.LocalReport.DataSources.Add(rpt)
                .ReportViewer1.LocalReport.DataSources.Add(rpt1)
                .ReportViewer1.LocalReport.ReportPath = nombreRpt
                .ReportViewer1.RefreshReport()
                .Show()
            End With

        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try

    End Sub

End Module
