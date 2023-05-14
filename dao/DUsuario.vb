Imports System.Data.SqlClient

Public Class DUsuario
    Dim strConexion = My.Settings.miConexion.ToString()

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
            user.PrimerApellido = ds.Rows(0).Item("apellidoApellido")
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
End Class
