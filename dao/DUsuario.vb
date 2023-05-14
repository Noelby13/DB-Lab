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
End Class
