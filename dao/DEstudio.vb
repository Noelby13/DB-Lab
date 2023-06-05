Imports System.Data.SqlClient

Public Class DEstudio

    Dim strConexion = My.Settings.miConexion.ToString()

    Public Function insertarEstudio(ByVal estudio As Estudio) As Boolean
        Dim b = False
        Try
            Dim conn As New SqlConnection(strConexion)
            Dim tsql As String = "insert into Tbl_Estudio (nombreEstudio, valorInferiorH, valorSuperiorH, valorTextoH, valorInferiorM, valorSuperiorM, valorTextoM, estado, idUnidad) values (@nombre, @valorInferiorH, @valorSuperiorH, @valorTextoH, @valorInferiorM, @valorSuperiorM, @valorTextoM, @estado, @idUnidad)"
            Dim cmd As New SqlCommand(tsql, conn)
            cmd.Parameters.AddWithValue("@nombre", estudio.NombreEstudio)
            cmd.Parameters.AddWithValue("@valorInferiorH", estudio.ValorInferiorH)
            cmd.Parameters.AddWithValue("@valorSuperiorH", estudio.ValorSuperiorH)
            cmd.Parameters.AddWithValue("@valorTextoH", estudio.ValorTextoH)
            cmd.Parameters.AddWithValue("@valorInferiorM", estudio.ValorInferiorM)
            cmd.Parameters.AddWithValue("@valorSuperiorM", estudio.ValorSuperiorM)
            cmd.Parameters.AddWithValue("@valorTextoM", estudio.ValorTextoM)
            cmd.Parameters.AddWithValue("@estado", 1)
            cmd.Parameters.AddWithValue("@idUnidad", estudio.IdUnidad)
            conn.Open()
            If cmd.ExecuteNonQuery() <> 0 Then
                b = True
            End If
            conn.Close()

        Catch ex As Exception
            MsgBox("Ocurrio un error al guardar el estudio", MsgBoxStyle.Critical, "Error")
            MsgBox(ex.ToString())
        End Try
        Return b
    End Function

    Public Function listarEstudios() As DataSet
        Dim ds As New DataSet
        Try
            Dim conn As New SqlConnection(strConexion)
            Dim tsql As String = "select idEstudio, nombreEstudio as 'Nombre', valorInferiorH, valorSuperiorH, valorTextoH , valorInferiorM, valorSuperiorM , valorTextoM, U.nombre, U.idUnidad from Tbl_Estudio inner join Tbl_Unidad as U on Tbl_Estudio.idUnidad =U.idUnidad where  U.estado = 1 and Tbl_Estudio.estado = 1"
            Dim da As New SqlDataAdapter(tsql, conn)
            da.Fill(ds)
        Catch ex As Exception
            MsgBox("Ocurrio un error al listar los estudios", MsgBoxStyle.Critical, "Error")
            MsgBox(ex.ToString())
        End Try
        Return ds

    End Function

    Public Function actualizarEstudio(ByVal estudio As Estudio) As Boolean
        Dim b = False
        Try
            Dim conn As New SqlConnection(strConexion)
            Dim tsql As String = "update Tbl_Estudio set nombreEstudio = @nombre, valorInferiorH = @valorInferiorH, valorSuperiorH = @valorSuperiorH, valorTextoH = @valorTextoH, valorInferiorM = @valorInferiorM, valorSuperiorM = @valorSuperiorM, valorTextoM = @valorTextoM, idUnidad = @idUnidad where idEstudio = @idEstudio"
            Dim cmd As New SqlCommand(tsql, conn)
            cmd.Parameters.AddWithValue("@nombre", estudio.NombreEstudio)
            cmd.Parameters.AddWithValue("@valorInferiorH", estudio.ValorInferiorH)
            cmd.Parameters.AddWithValue("@valorSuperiorH", estudio.ValorSuperiorH)
            cmd.Parameters.AddWithValue("@valorTextoH", estudio.ValorTextoH)
            cmd.Parameters.AddWithValue("@valorInferiorM", estudio.ValorInferiorM)
            cmd.Parameters.AddWithValue("@valorSuperiorM", estudio.ValorSuperiorM)
            cmd.Parameters.AddWithValue("@valorTextoM", estudio.ValorTextoM)
            cmd.Parameters.AddWithValue("@idUnidad", estudio.IdUnidad)
            cmd.Parameters.AddWithValue("@idEstudio", estudio.IdEstudio)
            conn.Open()
            If cmd.ExecuteNonQuery() <> 0 Then
                b = True
            End If
            conn.Close()
        Catch ex As Exception
            MsgBox("Ocurrio un error al actualizar el estudio", MsgBoxStyle.Critical, "Error")
        End Try
        Return b
    End Function

    Public Function eliminarEstudio(ByVal estudio As Estudio) As Boolean
        Dim b = False
        Try
            Dim conn As New SqlConnection(strConexion)
            Dim tsql As String = "update Tbl_Estudio set estado = 0 where idEstudio = @idEstudio"
            Dim cmd As New SqlCommand(tsql, conn)
            cmd.Parameters.AddWithValue("@idEstudio", estudio.IdEstudio)
            conn.Open()
            If cmd.ExecuteNonQuery() <> 0 Then
                b = True
            End If
            conn.Close()
        Catch ex As Exception
            MsgBox("Ocurrio un error al eliminar el estudio", MsgBoxStyle.Critical, "Error")
        End Try
        Return b

    End Function

    Public Function buscarEstudio(ByVal cadena As String) As DataSet
        Dim ds As New DataSet
        Try
            Dim conn As New SqlConnection(strConexion)
            Dim tsql As String = "select idEstudio, nombreEstudio as 'Nombre', valorInferiorH, valorSuperiorH, valorTextoH , valorInferiorM, valorSuperiorM , valorTextoM, U.nombre, U.idUnidad from Tbl_Estudio inner join Tbl_Unidad as U on Tbl_Estudio.idUnidad =U.idUnidad where  U.estado = 1 and nombreEstudio like @nombre"
            Dim cmd As New SqlCommand(tsql, conn)
            cmd.Parameters.AddWithValue("@nombre", "%" + cadena + "%")
            Dim da As New SqlDataAdapter(cmd)
            da.Fill(ds)
        Catch ex As Exception
            MsgBox("Ocurrio un error al buscar el estudio", MsgBoxStyle.Critical, "Error")
        End Try
        Return ds
    End Function

End Class
