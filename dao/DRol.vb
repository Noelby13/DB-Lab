Imports System.Data.SqlClient

Public Class DRol

    Dim strConexion = My.Settings.miConexion.ToString()

    Public Function listarRoles() As DataSet
        Dim ds As New DataSet
        Try

            Dim conn As New SqlConnection(strConexion)
            Dim tsql As String = "SELECT idRol, nombre FROM Tbl_Rol"
            Dim da As New SqlDataAdapter(tsql, conn)
            da.Fill(ds)
        Catch ex As Exception
            MsgBox("Ocurrio un error al listar los roles", MsgBoxStyle.Critical, "ERROR")
        End Try
        Return ds
    End Function

End Class
