Imports System.Data.SqlClient

Public Class DFactura

    Dim strConexion = My.Settings.miConexion.ToString()

    Public Function obtenerFactura()
        Try
            Dim factura As New Factura()
            Dim ds As New DataTable
            Dim conn As New SqlConnection(strConexion)
            Dim tsql As String = "select * from Tbl_Factura where idFactura = @idFactura"
            Dim da As New SqlDataAdapter(tsql, conn)
            da.SelectCommand.Parameters.AddWithValue("@idFactura", factura.IdFactura)
            da.Fill(ds)
            factura.IdFactura = ds.Rows(0).Item("idFactura")
            factura.Total = ds.Rows(0).Item("total")
            factura.FechaEmision = ds.Rows(0).Item("fechaEmision")
            factura.IdPaciente = ds.Rows(0).Item("idPaciente")
            factura.IdUsuario = ds.Rows(0).Item("idUsuario")
            factura.IdMetodoPago = ds.Rows(0).Item("idMetodoPago")
            factura.IdDoctor = ds.Rows(0).Item("idDoctor")
            Return factura
        Catch
            MsgBox("Ocurrio un error al intentar obtener la factura", MsgBoxStyle.Information, "Factura")
        End Try
    End Function

    Public Function validarNumeroFactura(ByVal idFactura As Factura) As Boolean
        Dim B = False
        Try
            Dim ds As New DataTable
            Dim conn As New SqlConnection(strConexion)
            Dim tsql As String = "SELECT * FROM Tbl_DetalleFactura WHERE idFactura = @idFactura"
            Dim da As New SqlDataAdapter(tsql, conn)
            da.SelectCommand.Parameters.AddWithValue("@idFactura", idFactura.IdFactura)
            da.Fill(ds)
            If ds.Rows.Count > 0 Then
                B = True
            End If
        Catch ex As Exception
            MsgBox(ex.ToString())
            MsgBox("Ocurrio un error al validar el detalle de factura", MsgBoxStyle.Critical, "ERROR")
        End Try
        Return B
    End Function

    Public Function obtenerDatosCliente(ByVal idFactura As Factura) As DataTable
        Dim dt As New DataTable
        Try
            Dim conn As New SqlConnection(strConexion)
            Dim tsql As String = "SELECT Tbl_Cliente.primerNombre, Tbl_Cliente.primerApellido, Tbl_Factura.fechaEmision
                                    FROM Tbl_Factura INNER JOIN
                                    Tbl_Cliente ON Tbl_Factura.idPaciente = Tbl_Cliente.idPaciente WHERE idFactura = @idFactura"
            Dim da As New SqlDataAdapter(tsql, conn)
            da.SelectCommand.Parameters.AddWithValue("@idFactura", idFactura.IdFactura)
            da.Fill(dt)
        Catch ex As Exception
            MsgBox(ex.ToString())
            MsgBox("Ocurrio un error al validar el detalle de factura", MsgBoxStyle.Critical, "ERROR")
        End Try
        Return dt
    End Function
End Class
