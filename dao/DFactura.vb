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
            MsgBox("Ocurrió  un error al validar el detalle de factura", MsgBoxStyle.Critical, "ERROR")
        End Try
        Return dt
    End Function

    Public Function eliminarFactura(ByVal idFactura As String) As Boolean
        Dim resultado = False
        Try
            Dim conn As New SqlConnection(strConexion)
            Dim tsql As String = "DELETE FROM Tbl_Factura WHERE idFactura = @idFactura"
            Dim cmd As New SqlCommand(tsql, conn)
            cmd.Parameters.AddWithValue("@idFactura", idFactura)

            conn.Open()
            If (cmd.ExecuteNonQuery <> 0) Then
                resultado = True
            End If
            conn.Close()
        Catch ex As Exception
            MsgBox("Ocurrió un error al eliminar el registro" & ex.Message, MsgBoxStyle.Critical, "ERROR")
        End Try
        Return resultado
    End Function

    Public Function obtenerListaTrabajo() As DataSet
        Dim ds As New DataSet
        Try
            Dim conn As New SqlConnection(strConexion)
            Dim tsql As String = "SELECT F.idFactura, F.idPaciente, CONVERT(varchar(5), F.fechaEmision, 108) as 'Hora', CONCAT(C.primerNombre,' ',C.primerApellido) as 'Nombre',  E.estado From Tbl_Factura as F 
                                  INNER JOIN Tbl_Cliente as C on F.idPaciente = C.idPaciente
                                  INNER JOIN Tbl_EstadoFactura as E on F.idEstadoFactura = E.idEstadoFactura"
            'where DAY(F.fechaEmision) = DAY(GETDATE())
            'AND MONTH(F.fechaEmision) = MONTH(GETDATE())
            'AND YEAR(F.fechaEmision) = YEAR(GETDATE())
            'ORDER BY Hora ASC , E.idEstadoFactura ASC"
            Dim da As New SqlDataAdapter(tsql, conn)
            da.Fill(ds)
        Catch ex As Exception
            MsgBox("Ocurrió un error al obtener la lista de trabajo" & ex.Message, MsgBoxStyle.Critical, "ERROR")
        End Try
        Return ds

    End Function

    Public Function guardarFactura(ByVal fac As Factura) As Integer
        Dim resultado As Integer = -1
        Try
            Dim conn As New SqlConnection(strConexion)
            Dim tsql As String = "INSERT INTO Tbl_Factura (total, fechaEmision, idPaciente, idUsuario, idMetodoPago, idDoctor, idEstadoFactura) 
                                  VALUES (@total, @fechaEmision, @idPaciente, @idUsuario, @idMetodoPago, @idDoctor, @idEstadoFactura)
                                  SELECT SCOPE_IDENTITY()"
            Dim cmd As New SqlCommand(tsql, conn)
            cmd.Parameters.AddWithValue("@total", fac.Total)
            cmd.Parameters.AddWithValue("@fechaEmision", fac.FechaEmision)
            cmd.Parameters.AddWithValue("@idPaciente", fac.IdPaciente)
            cmd.Parameters.AddWithValue("@idUsuario", fac.IdUsuario)
            cmd.Parameters.AddWithValue("@idMetodoPago", fac.IdMetodoPago)
            cmd.Parameters.AddWithValue("@idDoctor", fac.IdDoctor)
            cmd.Parameters.AddWithValue("@idEstadoFactura", fac.IdEstadoFactura)
            conn.Open()
            resultado = cmd.ExecuteScalar()
            conn.Close()

        Catch ex As Exception
            MsgBox("Ocurrió un error al guardar la factura" & ex.Message, MsgBoxStyle.Critical, "ERROR")
        End Try
        Return resultado

    End Function

    Public Function actualizarEstadoFactura(ByVal factura As Factura) As Boolean
        Dim resultado As Boolean = False
        Try
            Dim conn As New SqlConnection(strConexion)
            Dim tsql As String = "UPDATE Tbl_Factura SET idEstadoFactura = @estado WHERE idFactura = @idFactura"
            Dim cmd As New SqlCommand(tsql, conn)
            cmd.Parameters.AddWithValue("@estado", factura.IdEstadoFactura)
            cmd.Parameters.AddWithValue("@idFactura", factura.IdFactura)
            conn.Open()
            If (cmd.ExecuteNonQuery <> 0) Then
                resultado = True
            End If
            conn.Close()
        Catch ex As Exception
            MsgBox("Ocurrió un error al actualizar el estado de la factura" & ex.Message, MsgBoxStyle.Critical, "ERROR")
        End Try
        Return resultado

    End Function
End Class
