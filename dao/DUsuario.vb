Imports System.Data.SqlClient

Public Class DUsuario

    'String de la conexion'
    Dim strConexion = My.Settings.miConexion.ToString()


    'Funcion para validar la existencia del usuario en el Login'
    Public Function validarUsuario(ByVal usuario As Usuario) As Boolean
        Dim resultado = False
        Try
            Dim ds As New DataTable
            Dim conn As New SqlConnection(strConexion)
            Dim tsql As String = "select * from Tbl_Usuario where username = @username and pwd = @pwd"
            Dim da As New SqlDataAdapter(tsql, conn)
            da.SelectCommand.Parameters.AddWithValue("@username", usuario.Username)
            da.SelectCommand.Parameters.AddWithValue("@pwd", usuario.Pwd)
            da.Fill(ds)
            If ds.Rows.Count > 0 Then
                resultado = True
            End If
        Catch ex As Exception
            MsgBox(ex.ToString())
            MsgBox("Ocurrio un error al validar el usuario", MsgBoxStyle.Information, "Inicio de Sesión")
        End Try
        Return resultado
    End Function


    'Funcion para obtener un Objeto de tipo Usuario con todos sus datos correspondientes'
    Public Function obtenerUsuario(ByVal username As String) As Usuario
        Try
            Dim user As New Usuario()
            Dim ds As New DataTable
            Dim conn As New SqlConnection(strConexion)
            Dim tsql As String = "select * from Tbl_Usuario where username = @username"
            Dim da As New SqlDataAdapter(tsql, conn)
            da.SelectCommand.Parameters.AddWithValue("@username", username)
            da.Fill(ds)
            user.PrimerNombre = ds.Rows(0).Item("primerNombre")
            'user.SegundoNombre = ds.Rows(0).Item("segundoNombre")
            user.PrimerApellido = ds.Rows(0).Item("primerApellido")
            'user.SegundoApellido = ds.Rows(0).Item("segundoApellido")
            user.Username = ds.Rows(0).Item("username")
            user.Pwd = ds.Rows(0).Item("pwd")
            user.IdUsuario = ds.Rows(0).Item("idUsuario")
            user.Telefono = ds.Rows(0).Item("telefono")
            user.Cedula = ds.Rows(0).Item("cedula")
            'user.Correo = ds.Rows(0).Item("correo")
            user.FechaIngreso = ds.Rows(0).Item("fechaIngreso")
            user.Estado = ds.Rows(0).Item("estado")
            user.IdRol = ds.Rows(0).Item("idRol")
            Return user

        Catch ex As Exception
            MsgBox("Ocurrio un error al obtener el usuario", MsgBoxStyle.Information, "Inicio de Sesión")
        End Try
    End Function


    'Funcion para obtener una lista de los permisos del usuario'
    Public Function obtenerListaPermisos(ByVal usuario As Usuario) As List(Of Integer)
        Dim listaPermisos As New List(Of Integer)
        Try
            Dim ds As New DataTable
            Dim conn As New SqlConnection(strConexion)
            Dim tsql As String = "select Tbl_Funcion.idFuncion
                                    from Tbl_Rol 
                                    inner join Tbl_RolFuncion ON Tbl_Rol.idRol = Tbl_RolFuncion.idRol 
                                    inner join Tbl_Usuario ON Tbl_Rol.idRol = Tbl_Usuario.idRol 
                                    inner join Tbl_Funcion ON Tbl_RolFuncion.idFuncion = Tbl_Funcion.idFuncion 
                                    where Tbl_Usuario.idUsuario = @idUsuario"
            Dim da As New SqlDataAdapter(tsql, conn)
            da.SelectCommand.Parameters.AddWithValue("@idUsuario", usuario.IdUsuario)
            da.Fill(ds)
            For Each row As DataRow In ds.Rows
                listaPermisos.Add(row.Item("idFuncion"))
            Next
        Catch ex As Exception
            MsgBox("Ocurrio un error al obtener los permisos", MsgBoxStyle.Information, "Inicio de Sesión")
        End Try
        Return listaPermisos
    End Function


    'Funcion para mostrar los registros almacenados en la tabla Tbl_Usuario'
    Public Function mostrarRegistros() As DataSet
        Dim ds As New DataSet
        Try
            Dim conn As New SqlConnection(strConexion)
            Dim tsql As String = "select * from Tbl_Usuario"
            Dim da As New SqlDataAdapter(tsql, conn)
            da.Fill(ds)
        Catch ex As Exception
            MsgBox("Ocurrio un error al obtener los registros", MsgBoxStyle.Critical, "ERROR")
        End Try
        Return ds
    End Function


    'Funcion para guardar un nuevo registro en la tabla Tbl_Usuario'
    Public Function guardarRegistro(ByVal usuario As Usuario) As Boolean
        Dim resultado = False
        Try
            Dim conn As New SqlConnection(strConexion)
            Dim tsql As String = "insert into Tbl_Usuario (primerNombre, segundoNombre, primerApellido, segundoApellido, username, pwd, telefono, cedula, correo, fechaIngreso, estado, idRol) 
                                  values (@primerNombre, @segundoNombre, @primerApellido, @segundoApellido, @username, @pwd, @telefono, @cedula, @correo, @fechaIngreso, @estado, @idRol)"
            Dim cmd As New SqlCommand(tsql, conn)
            cmd.Parameters.AddWithValue("@primerNombre", usuario.PrimerNombre)
            cmd.Parameters.AddWithValue("@segundoNombre", usuario.SegundoNombre)
            cmd.Parameters.AddWithValue("@primerApellido", usuario.PrimerApellido)
            cmd.Parameters.AddWithValue("@segundoApellido", usuario.SegundoApellido)
            cmd.Parameters.AddWithValue("@username", usuario.Username)
            cmd.Parameters.AddWithValue("@pwd", usuario.Pwd)
            cmd.Parameters.AddWithValue("@telefono", usuario.Telefono)
            cmd.Parameters.AddWithValue("@cedula", usuario.Cedula)
            cmd.Parameters.AddWithValue("@correo", usuario.Correo)
            cmd.Parameters.AddWithValue("@fechaIngreso", usuario.FechaIngreso)
            cmd.Parameters.AddWithValue("@estado", usuario.Estado)
            cmd.Parameters.AddWithValue("@idRol", usuario.IdRol)

            conn.Open()
            If (cmd.ExecuteNonQuery <> 0) Then
                resultado = True
            End If
            conn.Close()

        Catch ex As Exception
            MsgBox("Ocurrio un error al guardar el registro", MsgBoxStyle.Critical, "ERROR")
        End Try
        Return resultado
    End Function


    'Funcion para editar un registro de la tabla Tbl_Usuario'
    Public Function editarRegistro(ByVal usuario As Usuario) As Boolean
        Dim resultado = False
        Try
            Dim conn As New SqlConnection(strConexion)
            Dim tsql As String = "update Tbl_Usuario set primerNombre = @primerNombre, segundoNombre = @segundoNombre, primerApellido = @primerApellido, segundoApellido = @segundoApellido, username = @username, pwd = @pwd,
                                  telefono = @telefono, cedula = @cedula, correo = @correo, fechaIngreso = @fechaIngreso, estado = @estado, idRol = @idRol where idUsuario = @idUsuario"
            Dim cmd As New SqlCommand(tsql, conn)
            cmd.Parameters.AddWithValue("@primerNombre", usuario.PrimerNombre)
            cmd.Parameters.AddWithValue("@segundoNombre", usuario.SegundoNombre)
            cmd.Parameters.AddWithValue("@primerApellido", usuario.PrimerApellido)
            cmd.Parameters.AddWithValue("@segundoApellido", usuario.SegundoApellido)
            cmd.Parameters.AddWithValue("@username", usuario.Username)
            cmd.Parameters.AddWithValue("@pwd", usuario.Pwd)
            cmd.Parameters.AddWithValue("@telefono", usuario.Telefono)
            cmd.Parameters.AddWithValue("@cedula", usuario.Cedula)
            cmd.Parameters.AddWithValue("@correo", usuario.Correo)
            cmd.Parameters.AddWithValue("@fechaIngreso", usuario.FechaIngreso)
            cmd.Parameters.AddWithValue("@estado", usuario.Estado)
            cmd.Parameters.AddWithValue("@idRol", usuario.IdRol)
            cmd.Parameters.AddWithValue("@idUsuario", usuario.IdUsuario)

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


    'Funcion para buscar un registro de la tabla Tbl_Usuario'
    Public Function buscarRegistro(ByVal username As String) As Usuario
        Dim user As New Usuario
        Try
            Dim ds As New DataTable
            Dim conn As New SqlConnection(strConexion)
            Dim tsql As String = "select * from Tbl_Usuario where username = @username"
            Dim da As New SqlDataAdapter(tsql, conn)
            da.SelectCommand.Parameters.AddWithValue("@username", username)
            da.Fill(ds)
            user.IdUsuario = ds.Rows(0).Item("idUsuario")
            user.PrimerNombre = ds.Rows(0).Item("primerNombre")
            user.SegundoNombre = ds.Rows(0).Item("segundoNombre")
            user.PrimerApellido = ds.Rows(0).Item("primerApellido")
            user.SegundoApellido = ds.Rows(0).Item("segundoApellido")
            user.Username = ds.Rows(0).Item("username")
            user.Pwd = ds.Rows(0).Item("pwd")
            user.IdUsuario = ds.Rows(0).Item("idUsuario")
            user.Telefono = ds.Rows(0).Item("telefono")
            user.Cedula = ds.Rows(0).Item("cedula")
            user.Correo = ds.Rows(0).Item("correo")
            user.FechaIngreso = ds.Rows(0).Item("fechaIngreso")
            user.Estado = ds.Rows(0).Item("estado")
            user.IdRol = ds.Rows(0).Item("idRol")

        Catch ex As Exception
            MsgBox("Ocurrio un error al obtener el usuario", MsgBoxStyle.Information, "Inicio de Sesión")
        End Try

        Return user
    End Function


    'Funcion para eliminar un registro de la tabla Tbl_Usuario'
    Public Function eliminarRegistro(ByVal idUsuario As Integer) As Boolean
        Dim resultado = False
        Try
            Dim conn As New SqlConnection(strConexion)
            Dim tsql As String = "delete from Tbl_Usuario where idUsuario = @idUsuario"
            Dim cmd As New SqlCommand(tsql, conn)
            cmd.Parameters.AddWithValue("@idUsuario", idUsuario)

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


    Public Function comprobarUsuario(ByVal usuario As Usuario) As Boolean
        Dim resultado = False
        Try
            Dim ds As New DataTable
            Dim conn As New SqlConnection(strConexion)
            Dim tsql As String = "select * from Tbl_Usuario where username = @username"
            Dim da As New SqlDataAdapter(tsql, conn)
            da.SelectCommand.Parameters.AddWithValue("@username", usuario.Username)
            da.Fill(ds)
            If (ds.Rows.Count > 0) Then Return True
        Catch ex As Exception
            MsgBox("Ocurrio un error al comprobar al comprobar la existencia del usuario", MsgBoxStyle.Critical, "ERROR")
        End Try
        Return resultado
    End Function
End Class