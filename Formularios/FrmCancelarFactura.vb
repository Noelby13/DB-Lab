Imports System.Configuration
Imports System.Data.SqlClient
Imports System.Runtime.InteropServices


Public Class FrmCancelarFactura
    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub

    Sub llenarRegistros()
        Dim dDetalleFactura As New D_DetalleFactura
        DgvExamenesFacturados.DataSource = dDetalleFactura.mostrarDetalles().Tables(0)
        DgvExamenesFacturados.Refresh()
    End Sub

    Private Sub FrmCancelarFactura_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenarRegistros()
    End Sub

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
        'DgvExamenesFacturados.Rows.Clear()
        TxtTotal.Clear()
    End Sub

    Private Sub BtnBorrar_Click(sender As Object, e As EventArgs) Handles BtnBorrar.Click

    End Sub

    'Falta validar que lo que se ingrese en el campo sea un numero
    Private Sub BtnBuscarFactura_Click(sender As Object, e As EventArgs) Handles BtnBuscarFactura.Click
        If Not validarCampos() Then
            MsgBox("Debe ingresar el numero de factura")
            Exit Sub
        End If



        'Dim dDetalleFactura As New D_DetalleFactura
        'DgvExamenesFacturados.DataSource = dDetalleFactura.buscarPorFactura(TxtFactura.Text.ToString()).Tables(0)
        'DgvExamenesFacturados.Refresh()
    End Sub

End Class