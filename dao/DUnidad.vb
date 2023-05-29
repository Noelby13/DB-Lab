Imports System.Data.SqlClient

Public Class DUnidad
    Dim strConexion = My.Settings.miConexion.ToString()

    Public Function listarUnidades() As DataSet
        Dim ds As New DataSet
        Try
            Dim conn As New SqlConnection(strConexion)
            Dim tsql As String = "select idUnidad, nombre as 'Nombre', descripcion from Tbl_Unidad where estado = 1"
            Dim da As New SqlDataAdapter(tsql, conn)

            da.Fill(ds)
        Catch ex As Exception
            MsgBox(ex.ToString())
            MsgBox("Ocurrio un error al listar las unidades", MsgBoxStyle.Information, "Listar unidades")
        End Try
        Return ds
    End Function

    Public Function insertarUnidad(ByVal unidad As Unidad) As Boolean
        Dim b = False
        Try
            Dim conn As New SqlConnection(strConexion)
            Dim tsql As String = "insert into Tbl_Unidad (nombre, descripcion, estado) values (@nombre, @descripcion, @estado)"
            Dim cmd As New SqlCommand(tsql, conn)
            cmd.Parameters.AddWithValue("@nombre", unidad.Nombre)
            cmd.Parameters.AddWithValue("@descripcion", unidad.Descripcion)
            cmd.Parameters.AddWithValue("@estado", 1)
            conn.Open()
            If cmd.ExecuteNonQuery() <> 0 Then
                b = True
            End If
            conn.Close()
        Catch ex As Exception
            MsgBox("Ocurrio un error al guardar la unidad de medida", MsgBoxStyle.Critical, "Error")
        End Try


        Return b

    End Function

    Public Function buscarUnidad(ByVal nombre As String) As DataSet
        Dim ds As New DataSet
        Try
            Dim conn As New SqlConnection(strConexion)
            Dim tsql As String = "select idUnidad, nombre as 'Nombre', descripcion from Tbl_Unidad where estado = 1 and nombre like  '%' + @nombre + '%'"
            Dim da As New SqlDataAdapter(tsql, conn)
            da.SelectCommand.Parameters.AddWithValue("@nombre", nombre)
            da.Fill(ds)
        Catch ex As Exception
            MsgBox("Ocurrio un error al buscar la unidad de medida", MsgBoxStyle.Critical, "Error")
        End Try
        Return ds


    End Function

    Public Function modificarUnidad(ByVal unidad As Unidad) As Boolean
        Dim b = False
        Try
            Dim conn As New SqlConnection(strConexion)
            Dim tsql As String = "update Tbl_Unidad set nombre = @nombre, descripcion = @descripcion where idUnidad = @idUnidad"
            Dim cmd As New SqlCommand(tsql, conn)
            cmd.Parameters.AddWithValue("@nombre", unidad.Nombre)
            cmd.Parameters.AddWithValue("@descripcion", unidad.Descripcion)
            cmd.Parameters.AddWithValue("@idUnidad", unidad.IdUnidad)
            conn.Open()
            If cmd.ExecuteNonQuery() <> 0 Then
                b = True
            End If
            conn.Close()
        Catch ex As Exception
            MsgBox("Ocurrio un error al modificar la unidad de medida", MsgBoxStyle.Critical, "Error")
        End Try
        Return b
    End Function

    Public Function eliminarUnidad(ByVal idUnidad As Integer) As Boolean
        Dim b = False
        Try
            Dim conn As New SqlConnection(strConexion)
            Dim tsql As String = "update Tbl_Unidad set estado = @estado where idUnidad = @idUnidad"
            Dim cmd As New SqlCommand(tsql, conn)
            cmd.Parameters.AddWithValue("@estado", 0)
            cmd.Parameters.AddWithValue("@idUnidad", idUnidad)
            conn.Open()
            If cmd.ExecuteNonQuery() <> 0 Then
                b = True
            End If
            conn.Close()
        Catch ex As Exception
            MsgBox("Ocurrio un error al eliminar la unidad de medida", MsgBoxStyle.Critical, "Error")
        End Try
        Return b
    End Function





End Class
