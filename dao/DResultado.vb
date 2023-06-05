Imports System.Data.SqlClient
Imports System.Runtime.CompilerServices

Public Class DResultado
    Dim strConexion = My.Settings.miConexion.ToString()

    Public Function obtenerResultados(ByVal idFactura As Integer) As DataSet
        Dim ds As New DataSet
        Try
            Dim conn As SqlConnection = New SqlConnection(strConexion)
            Dim tsql As String = "select R. idEstudio, R.resultadoNumerico, R.resultadoTexto  from Tbl_Resultado as R where idFactura = @idFactura"
            Dim da As New SqlDataAdapter(tsql, conn)
            da.SelectCommand.Parameters.AddWithValue("@idFactura", idFactura)
            da.Fill(ds)

        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
        Return ds

    End Function

    Public Function upSertResultado(ByVal Resultado As Resultado) As Boolean
        Dim res = False
        Dim resultadoNumerico As Decimal
        Dim resultadoTexto As String

        Try
            Dim conn As New SqlConnection(strConexion)
            Dim tsql As String = "IF EXISTS (SELECT 1 FROM Tbl_Resultado AS R where R.idEstudio =@idEstudio  and R.idFactura = @idFactura )
	                              UPDATE Tbl_Resultado Set resultadoNumerico = @resultadoNumerico, resultadoTexto = resultadoTexto where Tbl_Resultado.idEstudio = @idEstudio  and Tbl_Resultado.idFactura = @idFactura
                                  Else
	                              INSERT INTO Tbl_Resultado(resultadoNumerico, resultadoTexto, idEstudio, idFactura) values (@resultadoNumerico,@resultadoTexto, @idEstudio, @idFactura)"
            Dim cmd As New SqlCommand(tsql, conn)
            cmd.Parameters.AddWithValue("@idEstudio", Resultado.IdEstudio)
            cmd.Parameters.AddWithValue("@idFactura", Resultado.IdFactura)
            cmd.Parameters.AddWithValue("@resultadoNumerico", Resultado.ResultadoNumerico)
            cmd.Parameters.AddWithValue("@resultadoTexto", Resultado.ResultadoTexto)
            conn.Open()
            If cmd.ExecuteNonQuery() <> 0 Then
                res = True
            End If
            conn.Close()


        Catch ex As Exception
            MsgBox(ex.ToString())
            MsgBox("Ocurrio un error al guardar los resultados", MsgBoxStyle.Information, "Resultados")
        End Try
        Return res
    End Function




End Class
