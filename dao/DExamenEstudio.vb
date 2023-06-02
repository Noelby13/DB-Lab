Imports System.Data.SqlClient

Public Class DExamenEstudio

    Dim strConexion = My.Settings.miConexion.ToString()

    Public Function listarExamenesEstudio() As DataSet
        Dim ds As New DataSet
        Try
            Dim conn As New SqlConnection(strConexion)
            Dim tsql As String = "select idExamenEstudio, idExamen, idEstudio from Tbl_ExamenEstudio where estado = 1"
            Dim da As New SqlDataAdapter(tsql, conn)
            da.Fill(ds)
        Catch ex As Exception
            MsgBox("Ocurrio un error al listar los examenes", MsgBoxStyle.Information, "Listar examenes")
        End Try
        Return ds
    End Function

    Public Function guardarExamenEstudio(ByVal examenEstudio As ExamenEstudio) As Boolean
        Dim resultado = False
        Try
            Dim conn As New SqlConnection(strConexion)
            Dim tsql As String = "insert into Tbl_ExamenEstudio (idExamen, idEstudio ) values (@idExamen, @idEstudio)"
            Dim cmd As New SqlCommand(tsql, conn)
            cmd.Parameters.AddWithValue("@idExamen", examenEstudio.IdExamen)
            cmd.Parameters.AddWithValue("@idEstudio", examenEstudio.IdEstudio)
            conn.Open()
            If cmd.ExecuteNonQuery() <> 0 Then
                resultado = True
            End If
            conn.Close()
            Return resultado
        Catch ex As Exception
            MsgBox(ex.ToString())
            MsgBox("Ocurrio un error al guardar el examen", MsgBoxStyle.Information, "Guardar examen")
        End Try

    End Function

    Public Function mostrarDetalles(ByVal idExamen As Integer) As DataSet
        Dim ds As New DataSet
        Try
            Dim conn As New SqlConnection(strConexion)
            Dim tsql As String = "select E.idEstudio as 'ID', E.nombreEstudio as 'Nombre'  
                                  from Tbl_Estudio E INNER JOIN Tbl_ExamenEstudio D 
                                    ON E.idEstudio = D.idEstudio where D.idExamen = @idExamen"
            Dim da As New SqlDataAdapter(tsql, conn)
            da.SelectCommand.Parameters.AddWithValue("@idExamen", idExamen)
            da.Fill(ds)
        Catch ex As Exception
            MsgBox("Ocurrio un error al listar los examenes", MsgBoxStyle.Information, "Listar examenes")
        End Try
        Return ds
    End Function

    Public Function borrarEstudio(ByVal ExamenEstudio As ExamenEstudio) As Boolean
        Dim resultado = False
        Try
            Dim conn As New SqlConnection(strConexion)
            Dim tsql As String = "delete from Tbl_ExamenEstudio where idExamen = @idExamen and idEstudio = @idEstudio"
            Dim cmd As New SqlCommand(tsql, conn)
            cmd.Parameters.AddWithValue("@idExamen", ExamenEstudio.IdExamen)
            cmd.Parameters.AddWithValue("@idEstudio", ExamenEstudio.IdEstudio)
            conn.Open()
            If cmd.ExecuteNonQuery() <> 0 Then
                resultado = True
            End If
            conn.Close()

        Catch ex As Exception
            MsgBox(ex.ToString())
            MsgBox("Ocurrio un error al borrar los detalles", MsgBoxStyle.Information, "Borrar detalles")

        End Try
        Return resultado
    End Function

End Class
