Imports System.Data.SqlClient

Public Class D_DetalleFactura

    Dim strConexion = My.Settings.miConexion.ToString()

    Public Function mostrarDetalles() As DataSet
        Dim ds As New DataSet

        Try
            Dim conn As New SqlConnection(strConexion)
            Dim tsql As String = "SELECT Tbl_DetalleFactura.idDetalleFactura AS Código, Tbl_DetalleFactura.cantidad AS Cantidad, 
                                    Tbl_DetalleFactura.precioUnitario AS Precio, 
                                    Tbl_DetalleFactura.idExamen AS [Número de exámen] FROM
                                    Tbl_DetalleFactura INNER JOIN
                                    Tbl_Factura ON Tbl_DetalleFactura.idFactura = Tbl_Factura.idFactura INNER JOIN
                                    Tbl_Cliente ON Tbl_Factura.idPaciente = Tbl_Cliente.idPaciente INNER JOIN
                                    Tbl_Doctor ON Tbl_Factura.idDoctor = Tbl_Doctor.idDoctor INNER JOIN
                                    Tbl_MetodoPago ON Tbl_Factura.idMetodoPago = Tbl_MetodoPago.idMetodoPago INNER JOIN
                                    Tbl_Usuario ON Tbl_Factura.idUsuario = Tbl_Usuario.idUsuario INNER JOIN
                                    Tbl_Examen ON Tbl_DetalleFactura.idExamen = Tbl_Examen.idExamen INNER JOIN
                                    Tbl_Categoria ON Tbl_Examen.idCategoria = Tbl_Categoria.idCategoria"
            Dim da As New SqlDataAdapter(tsql, conn)
            da.Fill(ds)
        Catch ex As Exception
            MsgBox("Ocurrio un error al listar los detalles", MsgBoxStyle.Critical, "ERROR")
        End Try
        Return ds
    End Function

    Public Function buscarPorFactura(ByVal idFactura As Integer) As DataSet
        Dim ds As New DataSet

        Try
            Dim conn As New SqlConnection(strConexion)
            Dim tsql As String = "SELECT Tbl_Examen.Nombre, Tbl_DetalleFactura.cantidad AS Cantidad, Tbl_DetalleFactura.precioUnitario AS [Precio por unidad]
                                    FROM Tbl_DetalleFactura INNER JOIN
                                    Tbl_Examen ON Tbl_DetalleFactura.idExamen = Tbl_Examen.idExamen WHERE Tbl_DetalleFactura.idFactura = @idFactura"
            Dim da As New SqlDataAdapter(tsql, conn)
            da.SelectCommand.Parameters.AddWithValue("@idFactura", idFactura)
            da.Fill(ds)
        Catch ex As Exception
            MsgBox("Ocurrio un error al buscar los detalles", MsgBoxStyle.Critical, "ERROR")
        End Try
        Return ds
    End Function


    Public Function obtenerExamenes(ByVal idFactura As Integer) As DataSet
        Dim ds As New DataSet
        Try
            Dim conn As New SqlConnection(strConexion)
            Dim tsql As String = "SELECT Est.idEstudio, Est.nombreEstudio, Est.valorInferiorH, Est.ValorSuperiorH, Est.valorTextoH, Est.valorInferiorM, Est.ValorSuperiorM, est.valorTextoM, U.nombre FROM Tbl_DetalleFactura as DE
                                  INNER JOIN Tbl_ExamenEstudio as EE
                                  on DE.idExamen = EE.idExamen
                                  INNER JOIN Tbl_Estudio as Est
                                  on EE.idEstudio = Est.idEstudio
                                  INNER JOIN Tbl_Unidad as U
                                  on Est.idUnidad = U.idUnidad
                                  where DE.idFactura = @idFactura"
            Dim da As New SqlDataAdapter(tsql, conn)
            da.SelectCommand.Parameters.AddWithValue("@idFactura", idFactura)
            da.Fill(ds)
        Catch ex As Exception
            MsgBox("Ocurrio un error al buscar los detalles", MsgBoxStyle.Critical, "ERROR")
        End Try
        Return ds
    End Function

    'Public Function eliminarDetalle(ByVal idDetalle As Integer) As Boolean
    '    Dim B As Boolean = False
    '    Try
    '        Dim conn As New SqlConnection(strConexion)
    '        Dim tsql As String = "DELETE FROM Tbl_DetalleFactura WHERE idDetalleFactura = @idDetalle"
    '        Dim cmd As New SqlCommand(tsql, conn)
    '        cmd.Parameters.AddWithValue("@idDetalle", idDetalle)
    '        conn.Open()
    '        cmd.ExecuteNonQuery()
    '        B = True
    '    Catch ex As Exception
    '        MsgBox("Ocurrio un error al eliminar el detalle", MsgBoxStyle.Critical, "ERROR")
    '    End Try
    '    Return B
    'End Function

End Class
