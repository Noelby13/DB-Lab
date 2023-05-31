Imports System.Data.SqlClient

Public Class DCategoria
    'String de la conexion'
    Dim strConexion = My.Settings.miConexion.ToString()

    'Aqui voy a crear las funciones'

    'Funcion para mostrar los registros almacenados en la tabla Tbl_Usuario'

    Public Function mostrarRegistros() As DataSet
        Dim ds As New DataSet
        Try
            Dim conn As New SqlConnection(strConexion)
            Dim tsql As String = "SELECT idCategoria AS Código, nombre AS Nombre, descripcion AS Descripción
                                        FROM     Tbl_Categoria where estado = 'True'"
            Dim da As New SqlDataAdapter(tsql, conn)
            da.Fill(ds)
        Catch ex As Exception
            MsgBox("Ocurrio un error al obtener los registros", MsgBoxStyle.Critical, "ERROR")
        End Try
        Return ds
    End Function

    'Funcion para guardar un nuevo registro en la tabla Tbl_Usuario'
    Public Function guardarRegistro(ByVal categoria As Categoria) As Boolean
        Dim resultado = False
        Try
            Dim conn As New SqlConnection(strConexion)
            Dim tsql As String = "insert into Tbl_Categoria (nombre, descripcion) 
                                  values (@Nombre, @Descripcion)"
            Dim cmd As New SqlCommand(tsql, conn)
            cmd.Parameters.AddWithValue("@nombre", (categoria.Nombre))
            cmd.Parameters.AddWithValue("@descripcion", (categoria.Descripcion))

            conn.Open()
            If (cmd.ExecuteNonQuery <> 0) Then
                resultado = True
            End If
            conn.Close()

        Catch ex As Exception
            MsgBox("Ocurrio un error al guardar el registro" & ex.Message, MsgBoxStyle.Critical, "ERROR")
        End Try
        Return resultado
    End Function

    'Funcion para editar un registro de la tabla Tbl_Usuario'
    Public Function editarRegistro(ByVal categoria As Categoria) As Boolean
        Dim resultado = False
        Try
            Dim conn As New SqlConnection(strConexion)
            Dim tsql As String = "update Tbl_Categoria set nombre = @nombre, descripcion = @descripcion where idCategoria = @idCategoria"
            Dim cmd As New SqlCommand(tsql, conn)
            cmd.Parameters.AddWithValue("@nombre", categoria.Nombre)
            cmd.Parameters.AddWithValue("@descripcion", (categoria.Descripcion))
            conn.Open()
            If (cmd.ExecuteNonQuery <> 0) Then
                resultado = True
            End If
            conn.Close()

        Catch ex As Exception
            MsgBox("Ocurrio un error al editar el registro", MsgBoxStyle.Critical, "ERROR")
        End Try
        Return resultado
    End Function


    'Funcion para eliminar un registro de la tabla Tbl_Usuario'
    Public Function eliminarRegistro(ByVal nombreCategoria As String) As Boolean
        Dim resultado = False
        Try
            Dim conn As New SqlConnection(strConexion)
            Dim tsql As String = "update Tbl_Categoria set estado = 'False' where nombre = @nombreCategoria"
            Dim cmd As New SqlCommand(tsql, conn)
            cmd.Parameters.AddWithValue("@nombreCategoria", nombreCategoria)

            conn.Open()
            If (cmd.ExecuteNonQuery <> 0) Then
                resultado = True
            End If
            conn.Close()

        Catch ex As Exception
            MsgBox("Ocurrio un error al eliminar el registro", MsgBoxStyle.Critical, "ERROR")
        End Try
        Return resultado
    End Function

    Public Function comprobarCategoria(ByVal categoria As Categoria) As Boolean
        Dim resultado = False
        Try
            Dim ds As New DataTable
            Dim conn As New SqlConnection(strConexion)
            Dim tsql As String = "SELECT * FROM Tbl_Categoria WHERE nombre = @nombreCategoria"
            Dim da As New SqlDataAdapter(tsql, conn)
            da.SelectCommand.Parameters.AddWithValue("@nombreRol", categoria.Nombre)
            da.Fill(ds)
            If (ds.Rows.Count > 0) Then Return True
        Catch ex As Exception
            MsgBox("Ocurrio un error al comprobar el rol", MsgBoxStyle.Critical, "ERROR")
        End Try
        Return resultado
    End Function


    Public Function buscarXNombre(ByVal nombreCategoria As String) As DataSet
        Dim ds As New DataSet
        nombreCategoria = nombreCategoria + "%"
        Try
            Dim conn As New SqlConnection(strConexion)
            Dim tsql As String = "SELECT idCategoria AS Código, nombre AS Nombre, descripcion AS Descripción FROM Tbl_Categoria where nombre like @nombreCategoria and estado = 'True'"
            Dim da As New SqlDataAdapter(tsql, conn)
            da.SelectCommand.Parameters.AddWithValue("@nombreCategoria", nombreCategoria)
            da.Fill(ds)
        Catch ex As Exception
            MsgBox("Ocurrio un error al buscar el registro", MsgBoxStyle.Critical, "ERROR")
        End Try
        Return ds
    End Function
End Class
