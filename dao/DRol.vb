Imports System.Data.SqlClient

Public Class DRol

    Dim strConexion = My.Settings.miConexion.ToString()

    Public Function listarRoles() As DataSet
        Dim ds As New DataSet
        Try

            Dim conn As New SqlConnection(strConexion)
            Dim tsql As String = "SELECT idRol, nombre FROM Tbl_Rol where estado = 'True'"
            Dim da As New SqlDataAdapter(tsql, conn)
            da.Fill(ds)
        Catch ex As Exception
            MsgBox("Ocurrio un error al listar los roles", MsgBoxStyle.Critical, "ERROR")
        End Try
        Return ds
    End Function


    Public Function mostrarRegistros() As DataSet
        Dim ds As New DataSet
        Try
            Dim conn As New SqlConnection(strConexion)
            Dim tsql As String = "SELECT idRol AS Código, nombre AS [Nombre del Rol], descripcion AS Descripción FROM Tbl_Rol where estado = 'True'"
            Dim da As New SqlDataAdapter(tsql, conn)
            da.Fill(ds)
        Catch ex As Exception
            MsgBox("Ocurrio un error al obtener los registros", MsgBoxStyle.Critical, "ERROR")
        End Try
        Return ds
    End Function


    Public Function guardarRegistro(ByVal rol As Rol) As Boolean
        Dim resultado = False
        Try
            Dim conn As New SqlConnection(strConexion)
            Dim tsql As String = "INSERT INTO Tbl_Rol (nombre, descripcion) VALUES (@nombre, @descripcion)"
            Dim cmd As New SqlCommand(tsql, conn)
            cmd.Parameters.AddWithValue("@nombre", rol.Nombre)
            cmd.Parameters.AddWithValue("@descripcion", comprobarValorNull(rol.Descripcion))

            conn.Open()
            If (cmd.ExecuteNonQuery() <> 0) Then
                resultado = True
            End If
            conn.Close()

        Catch ex As Exception
            MsgBox("Ocurrio un error al guardar el registro", MsgBoxStyle.Critical, "ERROR")
        End Try
        Return resultado
    End Function

    Public Function editarRegistro(ByVal rol As Rol) As Boolean
        Dim resultado = False
        Try
            Dim conn As New SqlConnection(strConexion)
            Dim tsql As String = "UPDATE Tbl_Rol SET nombre = @nombre, descripcion = @descripcion WHERE idRol = @idRol"
            Dim cmd As New SqlCommand(tsql, conn)
            cmd.Parameters.AddWithValue("@nombre", rol.Nombre)
            cmd.Parameters.AddWithValue("@descripcion", comprobarValorNull(rol.Descripcion))
            cmd.Parameters.AddWithValue("@idRol", rol.IdRol)
            conn.Open()
            If (cmd.ExecuteNonQuery() <> 0) Then
                resultado = True
            End If
            conn.Close()
        Catch ex As Exception
            MsgBox("Ocurrio un error al editar el registro", MsgBoxStyle.Critical, "ERROR")
        End Try
        Return resultado
    End Function


    Public Function eliminarRegistro(ByVal nombreRol As String) As Boolean
        Dim resultado = False
        Try
            Dim conn As New SqlConnection(strConexion)
            Dim tsql As String = "update Tbl_Rol set estado = 'False' WHERE nombre = @nombreRol"
            Dim cmd As New SqlCommand(tsql, conn)
            cmd.Parameters.AddWithValue("@nombreRol", nombreRol)

            conn.Open()
            If (cmd.ExecuteNonQuery() <> 0) Then
                resultado = True
            End If
            conn.Close()

        Catch ex As Exception
            MsgBox("Ocurrio un error al eliminar el registro", MsgBoxStyle.Critical, "ERROR")
        End Try
        Return resultado
    End Function


    Public Function comprobarRol(ByVal rol As Rol) As Boolean
        Dim resultado = False
        Try
            Dim ds As New DataTable
            Dim conn As New SqlConnection(strConexion)
            Dim tsql As String = "SELECT * FROM Tbl_Rol WHERE nombre = @nombreRol"
            Dim da As New SqlDataAdapter(tsql, conn)
            da.SelectCommand.Parameters.AddWithValue("@nombreRol", rol.Nombre)
            da.Fill(ds)
            If (ds.Rows.Count > 0) Then Return True
        Catch ex As Exception
            MsgBox("Ocurrio un error al comprobar el rol", MsgBoxStyle.Critical, "ERROR")
        End Try
        Return resultado
    End Function


    Public Function comprobarValorNull(ByVal valor As Object) As Object
        If valor Is Nothing Then
            Return DBNull.Value
        Else
            Return valor
        End If
    End Function


    Public Function buscarXNombre(ByVal nombre As String) As DataSet
        Dim ds As New DataSet
        nombre = nombre + "%"
        Try
            Dim conn As New SqlConnection(strConexion)
            Dim tsql As String = "SELECT idRol AS Código, nombre AS [Nombre del Rol], descripcion AS Descripción FROM Tbl_Rol where nombre like @nombre and estado = 'True'"
            Dim da As New SqlDataAdapter(tsql, conn)
            da.SelectCommand.Parameters.AddWithValue("@nombre", nombre)
            da.Fill(ds)
        Catch ex As Exception
            MsgBox("Ocurrio un error al buscar el registro", MsgBoxStyle.Critical, "ERROR")
        End Try
        Return ds
    End Function
End Class
