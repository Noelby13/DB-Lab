﻿Imports System.Data.SqlClient

Public Class DRolFuncion

    'String de la conexion'
    Dim strConexion As String = My.Settings.miConexion.ToString()

    Public Function guardarPermiso(ByVal rolfuncion As RolFuncion) As Boolean
        Dim resultado = False
        Try
            Dim conn As New SqlConnection(strConexion)
            Dim tsql As String = "INSERT INTO Tbl_RolFuncion (idFuncion, idRol) VALUES (@idFuncion, @idRol)"
            Dim cmd As New SqlCommand(tsql, conn)
            cmd.Parameters.AddWithValue("@idFuncion", rolfuncion.IdFuncion)
            cmd.Parameters.AddWithValue("@idRol", rolfuncion.IdRol)
            conn.Open()
            If (cmd.ExecuteNonQuery() <> 0) Then
                resultado = True
            End If
            conn.Close()
        Catch ex As Exception
            MsgBox("Ocurrio un error al guardar el permiso", MsgBoxStyle.Critical, "ERROR")
        End Try
        Return resultado
    End Function

    Public Function borrarPermisos(ByVal idRol As Integer) As Boolean
        Dim resultado = False
        Try
            Dim conn As New SqlConnection(strConexion)
            Dim tsql As String = "DELETE FROM Tbl_RolFuncion WHERE idRol = @idRol"
            Dim cmd As New SqlCommand(tsql, conn)
            cmd.Parameters.AddWithValue("@idRol", idRol)
            conn.Open()
            If (cmd.ExecuteNonQuery() <> 0) Then
                resultado = True
            End If
            conn.Close()
        Catch ex As Exception
            MsgBox("Ocurrio un error al borrar los permisos", MsgBoxStyle.Critical, "ERROR")
        End Try
        Return resultado
    End Function
End Class
