Imports System.Data.SqlClient

Public Class DUnidad
    Dim strConexion = My.Settings.miConexion.ToString()

    Public Function listarUnidades() As DataSet
        Dim ds As New DataSet
        Try
            Dim conn As New SqlConnection(strConexion)
            Dim tsql As String = "select * from Tbl_Unidad where estado = 1"
            Dim cmd As New SqlCommand(tsql, conn)
            conn.Open()
            Dim da As New SqlDataAdapter(tsql, conn)
            da.Fill(ds)
            conn.Close()
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



End Class
