Imports System.Data.SqlClient

Public Class DFuncion

    'String de la conexion'
    Dim strConexion As String = My.Settings.miConexion.ToString()


    'Lista las funciones que tiene el sistema'
    Public Function listarFunciones() As DataSet
        Dim ds As New DataSet
        Try
            Dim conn As New SqlConnection(strConexion)
            Dim tsql As String = "SELECT idFuncion, nombreFuncion FROM Tbl_Funcion"
            Dim da As New SqlDataAdapter(tsql, conn)
            da.Fill(ds)
        Catch ex As Exception
            MsgBox("Ocurrio un error al listar las funciones", MsgBoxStyle.Critical, "ERROR")
        End Try
        Return ds
    End Function

End Class
