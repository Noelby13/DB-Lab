﻿Imports System.Data.SqlClient
Imports System.Security.Cryptography.X509Certificates

Public Class DDoctor

    Dim strConexion = My.Settings.miConexion.ToString()

    Public Function obtenerDoctor() As DataSet
        Dim ds As New DataSet
        Try


            Dim conn As New SqlConnection(strConexion)
            Dim tsql As String = "SELECT D.idDoctor, CONCAT(D.primerNombre,' ',D.segundoNombre, ' ', D.primerApellido, ' ',D.segundoApellido, '---Especialidad: ', D.especialidad) as 'Doctor' FROM Tbl_Doctor as D"
            Dim da As New SqlDataAdapter(tsql, conn)
            da.Fill(ds)

            'doctor.Especialidad = ds.Rows(0).Item("especialidad")

        Catch ex As Exception
            MsgBox("Ocurrio un error al intentar obtener el doctor", MsgBoxStyle.Information, "Doctor")
        End Try
        Return ds
    End Function

    Public Function mostrarRegistro() As DataSet
        Dim ds As New DataSet
        Try
            Dim conn As New SqlConnection(strConexion)
            Dim tsql As String = "SELECT idDoctor , primerNombre AS [Primer Nombre], segundoNombre AS [Segundo Nombre], primerApellido AS [Primer Apellido], segundoApellido AS [Segundo Apellido], especialidad AS [Especialidad] FROM Tbl_Doctor where estado = 1"
            Dim da As New SqlDataAdapter(tsql, conn)
            da.Fill(ds)
        Catch ex As Exception
            MsgBox("Ocurrio un error al obtener los registros de la tabla Doctor", MsgBoxStyle.Critical, "ERROR")
        End Try
        Return ds
    End Function

    Public Function guardarDoctor(ByVal doctor As Doctor) As Boolean
        Dim resultado = False

        Try
            Dim conn As New SqlConnection(strConexion)
            Dim tsql As String = "INSERT INTO Tbl_Doctor (primerNombre, segundoNombre, primerApellido, segundoApellido, especialidad) VALUES (@primerNombre, @segundoNombre, @primerApellido, @segundoApellido, @especialidad)"
            Dim cmd As New SqlCommand(tsql, conn)
            cmd.Parameters.AddWithValue("@primerNombre", doctor.PrimerNombre)
            cmd.Parameters.AddWithValue("@segundoNombre", comprobarValorNull(doctor.SegundoNombre))
            cmd.Parameters.AddWithValue("@primerApellido", doctor.PrimerApellido)
            cmd.Parameters.AddWithValue("@segundoApellido", comprobarValorNull(doctor.SegundoApellido))
            cmd.Parameters.AddWithValue("@especialidad", doctor.Especialidad)
            conn.Open()
            If cmd.ExecuteNonQuery() <> 0 Then
                resultado = True
            End If
            conn.Close()
            Return True
        Catch ex As Exception
            MsgBox("Ocurrio un error al intentar guardar el registro", MsgBoxStyle.Information, "Doctor")
            Return resultado
        End Try

    End Function

    Public Function eliminarDoctor(ByVal iddoctor As Integer) As Boolean
        Dim resultado = False
        Try
            Dim conn As New SqlConnection(strConexion)
            Dim tsql As String = "UPDATE Tbl_Doctor set estado = 'False' where idDoctor = @idDoctor"
            Dim cmd As New SqlCommand(tsql, conn)
            cmd.Parameters.AddWithValue("@idDoctor", iddoctor)

            conn.Open()
            If (cmd.ExecuteNonQuery <> 0) Then
                resultado = True
            End If
            conn.Close()
        Catch ex As Exception
            MsgBox("Ocurrio un error al intentar eliminar el doctor", MsgBoxStyle.Information, "Doctor")
        End Try
        Return resultado

    End Function


    Public Function editarDoctor(ByVal doctor As Doctor) As Boolean
        Dim resultado = False
        Try
            Dim conn As New SqlConnection(strConexion)
            Dim tsql As String = "Update Tbl_Doctor set primerNombre = @primerNombre, segundoNombre = @segundoNombre, 
                                  primerApellido = @primerApellido, segundoApellido = @segundoApellido, especialidad =@especialidad  where idDoctor = @idDoctor"
            Dim cmd As New SqlCommand(tsql, conn)
            cmd.Parameters.AddWithValue("@primerNombre", doctor.PrimerNombre)
            cmd.Parameters.AddWithValue("@segundoNombre", comprobarValorNull(doctor.SegundoNombre))
            cmd.Parameters.AddWithValue("@primerApellido", doctor.PrimerApellido)
            cmd.Parameters.AddWithValue("@segundoApellido", comprobarValorNull(doctor.SegundoApellido))
            cmd.Parameters.AddWithValue("@especialidad", comprobarValorNull(doctor.Especialidad))
            cmd.Parameters.AddWithValue("@idDoctor", doctor.IdDoctor)

            conn.Open()
            cmd.ExecuteNonQuery()
            conn.Close()
            Return True
        Catch ex As Exception
            MsgBox("Ocurrio un error al editar el registro", MsgBoxStyle.Critical, "ERROR")
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

    Public Function buscarPorDoctor(ByVal nombre As String) As DataSet
        Dim ds As New DataSet
        nombre = nombre + "%"
        Try
            Dim conn As New SqlConnection(strConexion)
            Dim tsql As String = "SELECT idDoctor , primerNombre AS [Primer Nombre], segundoNombre AS [Segundo Nombre], primerApellido AS [Primer Apellido], segundoApellido AS [Segundo Apellido]
                                    FROM Tbl_Doctor where primerNombre like @nombre and estado = 'True '"
            Dim da As New SqlDataAdapter(tsql, conn)
            da.SelectCommand.Parameters.AddWithValue("@nombre", nombre)
            da.Fill(ds)
        Catch ex As Exception
            MsgBox("Ocurrio un error al buscar al doctor", MsgBoxStyle.Critical, "ERROR")
        End Try
        Return ds
    End Function

End Class
