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
            Dim tsql As String = "SELECT Tbl_Usuario.idUsuario AS Código, Tbl_Usuario.primerNombre AS [Primer Nombre], Tbl_Usuario.segundoNombre AS [Segundo Nombre], Tbl_Usuario.primerApellido AS [Primer Apellido], Tbl_Usuario.segundoApellido AS [Segundo Apellido], 
                                    Tbl_Usuario.username AS Usuario, Tbl_Usuario.telefono AS Teléfono, Tbl_Usuario.correo AS Correo, Tbl_Usuario.fechaIngreso AS Ingreso, Tbl_Usuario.cedula AS Cédula, Tbl_Usuario.pwd AS Clave, Tbl_Rol.nombre AS Rol
                                        FROM     Tbl_Usuario INNER JOIN
                                                    Tbl_Rol ON Tbl_Usuario.idRol = Tbl_Rol.idRol where Tbl_Usuario.estado = 'True'"
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
            cmd.Parameters.AddWithValue("@segundoNombre", comprobarValorNull(usuario.SegundoNombre))
            cmd.Parameters.AddWithValue("@primerApellido", usuario.PrimerApellido)
            cmd.Parameters.AddWithValue("@segundoApellido", comprobarValorNull(usuario.SegundoApellido))
            cmd.Parameters.AddWithValue("@username", usuario.Username)
            cmd.Parameters.AddWithValue("@pwd", usuario.Pwd)
            cmd.Parameters.AddWithValue("@telefono", usuario.Telefono)
            cmd.Parameters.AddWithValue("@cedula", usuario.Cedula)
            cmd.Parameters.AddWithValue("@correo", comprobarValorNull(usuario.Correo))
            cmd.Parameters.AddWithValue("@fechaIngreso", usuario.FechaIngreso)
            cmd.Parameters.AddWithValue("@estado", usuario.Estado)
            cmd.Parameters.AddWithValue("@idRol", usuario.IdRol)

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
    Public Function editarRegistro(ByVal usuario As Usuario) As Boolean
        Dim resultado = False
        Try
            Dim conn As New SqlConnection(strConexion)
            Dim tsql As String = "update Tbl_Usuario set primerNombre = @primerNombre, segundoNombre = @segundoNombre, primerApellido = @primerApellido, segundoApellido = @segundoApellido, username = @username, pwd = @pwd,
                                  telefono = @telefono, cedula = @cedula, correo = @correo, fechaIngreso = @fechaIngreso, idRol = @idRol where idUsuario = @idUsuario"
            Dim cmd As New SqlCommand(tsql, conn)
            cmd.Parameters.AddWithValue("@primerNombre", usuario.PrimerNombre)
            cmd.Parameters.AddWithValue("@segundoNombre", comprobarValorNull(usuario.SegundoNombre))
            cmd.Parameters.AddWithValue("@primerApellido", usuario.PrimerApellido)
            cmd.Parameters.AddWithValue("@segundoApellido", comprobarValorNull(usuario.SegundoApellido))
            cmd.Parameters.AddWithValue("@username", usuario.Username)
            cmd.Parameters.AddWithValue("@pwd", usuario.Pwd)
            cmd.Parameters.AddWithValue("@telefono", usuario.Telefono)
            cmd.Parameters.AddWithValue("@cedula", usuario.Cedula)
            cmd.Parameters.AddWithValue("@correo", comprobarValorNull(usuario.Correo))
            cmd.Parameters.AddWithValue("@fechaIngreso", usuario.FechaIngreso)
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


    'Funcion para eliminar un registro de la tabla Tbl_Usuario'
    Public Function eliminarRegistro(ByVal nombreUsuario As String) As Boolean
        Dim resultado = False
        Try
            Dim conn As New SqlConnection(strConexion)
            Dim tsql As String = "update Tbl_Usuario set estado = 'False' where username = @username"
            Dim cmd As New SqlCommand(tsql, conn)
            cmd.Parameters.AddWithValue("@username", nombreUsuario)

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


    'Funcion para comprobar la existencia de un usuario ya registrado en el sistema'
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


    'Funcion para comprobar si el atributo del objeto tiene un valor de Nothing o no'
    'Si es Nothing devuelve un valor NULL a la base de datos'
    'De lo contrario, devuelve el valor que ya tenia el atributo'
    Public Function comprobarValorNull(ByVal valor As Object) As Object
        If valor Is Nothing Then
            Return DBNull.Value
        Else
            Return valor
        End If
    End Function


    'Funcion para buscar un registro de la tabla Tbl_Usuario mediante el nombre'
    'Con el que se estan buscando coincidencias en la base de datos'
    Public Function buscarXNombre(ByVal nombre As String) As DataSet
        Dim ds As New DataSet
        nombre = nombre + "%"
        Try
            Dim conn As New SqlConnection(strConexion)
            Dim tsql As String = "SELECT Tbl_Usuario.idUsuario AS Código, Tbl_Usuario.primerNombre AS [Primer Nombre], Tbl_Usuario.segundoNombre AS [Segundo Nombre], Tbl_Usuario.primerApellido AS [Primer Apellido], Tbl_Usuario.segundoApellido AS [Segundo Apellido], 
                                    Tbl_Usuario.username AS Usuario, Tbl_Usuario.telefono AS Teléfono, Tbl_Usuario.correo AS Correo, Tbl_Usuario.fechaIngreso AS Ingreso, Tbl_Usuario.cedula AS Cédula, Tbl_Usuario.pwd AS Clave, Tbl_Rol.nombre AS Rol
                                        FROM     Tbl_Usuario INNER JOIN
                                                    Tbl_Rol ON Tbl_Usuario.idRol = Tbl_Rol.idRol where Tbl_Usuario.username like @nombre and Tbl_Usuario.estado = 'True'"
            Dim da As New SqlDataAdapter(tsql, conn)
            da.SelectCommand.Parameters.AddWithValue("@nombre", nombre)
            da.Fill(ds)
        Catch ex As Exception
            MsgBox("Ocurrio un error al buscar el registro", MsgBoxStyle.Critical, "ERROR")
        End Try
        Return ds
    End Function
End Class