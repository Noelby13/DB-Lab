Imports System.Configuration
Imports System.Data.SqlClient
Imports System.Runtime.InteropServices


Public Class FrmCancelarFactura
    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub

    'Sub llenarRegistros()
    '    Dim dDetalleFactura As New D_DetalleFactura
    '    DgvExamenesFacturados.DataSource = dDetalleFactura.mostrarDetalles().Tables(0)
    '    DgvExamenesFacturados.Refresh()
    'End Sub

    'Private Sub FrmCancelarFactura_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    '    llenarRegistros()
    'End Sub

    Public Function validarCampos() As Boolean
        Dim B = False

        If (TxtFactura.Text <> "") Then
            B = True
        End If
        Return B
    End Function

    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click
        TxtFactura.Clear()
        TxtNombre.Clear()
        TxtApellido.Clear()
        TxtTotal.Clear()
        DgvExamenesFacturados.DataSource = Nothing
    End Sub

    Private Sub BtnBorrar_Click(sender As Object, e As EventArgs) Handles BtnBorrar.Click

    End Sub

    'Falta validar que lo que se ingrese en el campo sea un numero
    Private Sub BtnBuscarFactura_Click(sender As Object, e As EventArgs) Handles BtnBuscarFactura.Click
        If Not validarCampos() Then
            MsgBox("Debe ingresar el numero de factura")
            Exit Sub
        End If

        Dim factura As New Factura()
        Dim dDetalles As New D_DetalleFactura
        Dim dFactura As New DFactura
        factura.IdFactura = TxtFactura.Text
        If Not dFactura.validarNumeroFactura(factura) Then
            MsgBox("El numero de factura no existe")
            Exit Sub
        End If

        Dim dDetalleFactura As New D_DetalleFactura
        DgvExamenesFacturados.DataSource = dDetalleFactura.buscarPorFactura(TxtFactura.Text).Tables(0)
        DgvExamenesFacturados.Refresh()

        Dim t = dFactura.obtenerDatosCliente(factura)
        TxtNombre.Text = t.Rows(0).Item(0)
        TxtApellido.Text = t.Rows(0).Item(1)
        DtpFacturacion.Text = t.Rows(0).Item(2)

        calcularTotal()
    End Sub

    Private Sub calcularTotal()
        Dim suma = 0.00

        For Each row As DataGridViewRow In DgvExamenesFacturados.Rows
            suma = suma + row.Cells(2).Value
        Next

        TxtTotal.Text = suma.ToString()
    End Sub

End Class
