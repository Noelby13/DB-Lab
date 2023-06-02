Imports System.Data.SqlClient

Public Class DExamen

    Dim strConexion = My.Settings.miConexion.ToString()

    Public Function listarExamenes() As DataSet
        Dim ds As New DataSet
        Try
            Dim conn As New SqlConnection(strConexion)
            Dim tsql As String = "select E.idExamen , E.nombre as 'Nombre', E.descripcion as 'Descripción', E.precio as 'Precio', 
                                  C.nombre as 'Categoria' from Tbl_Examen E  INNER JOIN	 Tbl_Categoria C  
                                 on  E.idCategoria = C.idCategoria where E.estado = 1"

            Dim da As New SqlDataAdapter(tsql, conn)
            da.Fill(ds)
        Catch ex As Exception
            MsgBox("Ocurrio un error al listar los examenes", MsgBoxStyle.Information, "Listar examenes")
        End Try
        Return ds
    End Function

    'Public Function guardarExamen(ByVal examen As Examen) As Boolean
    '    Dim resultado = False
    '    Try
    '        Dim conn As New SqlConnection(strConexion)
    '        Dim tsql As String = "insert into Tbl_Examen (nombre, descripcion, estado, idCategoria) values (@nombre, @descripcion, @estado, @idCategoria)"
    '        Dim cmd As New SqlCommand(tsql, conn)
    '        cmd.Parameters.AddWithValue("@nombre", examen.Nombre)
    '        cmd.Parameters.AddWithValue("@descripcion", examen.Descripcion)
    '        cmd.Parameters.AddWithValue("@estado", 1)
    '        cmd.Parameters.AddWithValue("@idCategoria", examen.IdCategoria)
    '        conn.Open()
    '        If cmd.ExecuteNonQuery() <> 0 Then
    '            resultado = True
    '        End If
    '        conn.Close()
    '    Catch ex As Exception
    '        MsgBox("Ocurrio un error al guardar el examen", MsgBoxStyle.Information, "Guardar examen")
    '    End Try


    '    Return resultado

    'End Function.

    Public Function guardarExamen(ByVal examen As Examen) As Integer
        Dim examenId As Integer = -1 ' Valor predeterminado en caso de error
        Try
            Dim conn As New SqlConnection(strConexion)
            Dim tsql As String = "INSERT INTO Tbl_Examen (nombre, descripcion,precio, estado, idCategoria) VALUES (@nombre, @descripcion,@precio, @estado, @idCategoria); SELECT SCOPE_IDENTITY() AS ExamID;"
            Dim cmd As New SqlCommand(tsql, conn)
            cmd.Parameters.AddWithValue("@nombre", examen.Nombre)
            cmd.Parameters.AddWithValue("@descripcion", examen.Descripcion)
            cmd.Parameters.AddWithValue("@precio", examen.Precio)
            cmd.Parameters.AddWithValue("@estado", 1)
            cmd.Parameters.AddWithValue("@idCategoria", examen.IdCategoria)
            conn.Open()
            examenId = cmd.ExecuteScalar()
            'Si ocurrio un error al guardar el examen, el valor de examenId sera 0, pero siento que es mejor que sea -1
            If examenId = 0 Then
                examenId = -1
            End If

            conn.Close()
        Catch ex As Exception
            MsgBox("Ocurrió un error al guardar el examen: " & ex.Message, MsgBoxStyle.Information, "Guardar examen")
            examenId = -1 ' Valor predeterminado en caso de error
        End Try

        Return examenId
    End Function


    Public Function actualizarExamen(ByVal examen As Examen)
        Dim resultado = False
        Try
            Dim conn As New SqlConnection(strConexion)
            Dim tsql As String = "update Tbl_Examen set nombre = @nombre, descripcion = @descripcion, precio = @precio, idCategoria = @idCategoria where idExamen = @idExamen"
            Dim cmd As New SqlCommand(tsql, conn)
            cmd.Parameters.AddWithValue("@nombre", examen.Nombre)
            cmd.Parameters.AddWithValue("@descripcion", examen.Descripcion)
            cmd.Parameters.AddWithValue("@precio", examen.Precio)
            cmd.Parameters.AddWithValue("@idCategoria", examen.IdCategoria)
            cmd.Parameters.AddWithValue("@idExamen", examen.IdExamen)
            conn.Open()
            If cmd.ExecuteNonQuery() <> 0 Then
                resultado = True
            End If
            conn.Close()
        Catch ex As Exception
            MsgBox("Ocurrio un error al actualizar el examen", MsgBoxStyle.Information, "Actualizar examen")
        End Try

        Return resultado
    End Function

    Public Function eliminarExamen(ByVal idExamen As Integer) As Boolean
        Dim resultado = False
        Try
            Dim conn As New SqlConnection(strConexion)
            Dim tsql As String = "update Tbl_Examen set estado = 0 where idExamen = @idExamen"
            Dim cmd As New SqlCommand(tsql, conn)
            cmd.Parameters.AddWithValue("@idExamen", idExamen)
            conn.Open()
            If cmd.ExecuteNonQuery() <> 0 Then
                resultado = True
            End If
            conn.Close()
        Catch ex As Exception
            MsgBox("Ocurrio un error al eliminar el examen", MsgBoxStyle.Information, "Eliminar examen")
        End Try
        Return resultado
    End Function

    Public Function existeExamen(ByVal nombre As String) As Boolean
        Dim resultado = False
        Try
            Dim conn As New SqlConnection(strConexion)
            Dim tsql As String = "select count(*) from Tbl_Examen where nombre = @nombre"
            Dim cmd As New SqlCommand(tsql, conn)
            cmd.Parameters.AddWithValue("@nombre", nombre)
            conn.Open()
            Dim count = cmd.ExecuteScalar()
            If count > 0 Then
                resultado = True
            End If
            conn.Close()
        Catch ex As Exception
            MsgBox("Ocurrio un error al verificar si existe el examen", MsgBoxStyle.Information, "Verificar examen")
        End Try
        Return resultado

    End Function



End Class
