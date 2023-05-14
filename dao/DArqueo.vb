Imports System.Data.SqlClient

Public Class DArqueo
    Dim strConexion = My.Settings.miConexion.ToString()

    Public Function chequearTurno() As Boolean
        Dim resultado = False
        Try
            Dim turno As New ArqueoCaja()
            Dim ds As New DataTable
            Dim conn As New SqlConnection(strConexion)
            Dim tsql As String = "select * from Tbl_ArqueoCaja where estatus = 1 "
            Dim da As New SqlDataAdapter(tsql, conn)
            da.Fill(ds)
            If ds.Rows.Count > 0 Then
                resultado = True
            End If
        Catch ex As Exception
            MsgBox(ex.ToString())
            MsgBox("Ocurrio un error al validar el turno", MsgBoxStyle.Information, "Apertura de turno")
        End Try
        Return resultado

    End Function

    Public Function abrirTurno(ByVal turno As ArqueoCaja) As Boolean
        Dim resultado = False
        Try
            Dim conn As New SqlConnection(strConexion)
            Dim tsql As String = "insert into Tbl_ArqueoCaja (fechaApertura, montoInicial, estatus, idUsuario) values (@fechaApertura, @montoInicial, @estatus, @idUsuario)"
            Dim cmd As New SqlCommand(tsql, conn)
            cmd.Parameters.AddWithValue("@fechaApertura", DateTime.Now)
            cmd.Parameters.AddWithValue("@estatus", 1)
            cmd.Parameters.AddWithValue("@montoInicial", turno.MontoInicial)
            cmd.Parameters.AddWithValue("@idUsuario", turno.IdUsuario)
            conn.Open()
            If cmd.ExecuteNonQuery() <> 0 Then
                resultado = True
            End If
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.ToString())
            MsgBox("Ocurrio un error al abrir el turno", MsgBoxStyle.Information, "Apertura de turno")

        End Try
        Return resultado
    End Function
End Class
