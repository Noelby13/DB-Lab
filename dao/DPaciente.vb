Imports System.Data.SqlClient

Public Class DPaciente

    'String de la conexion'
    Dim strConexion = My.Settings.miConexion.ToString()

    'Aqui voy a crear las funciones'
    'Funcion para mostrar los registros almacenados en la tabla Tbl_Cliente'
    Public Function mostrarRegistros() As DataSet
        Dim ds As New DataSet
        Try
            Dim conn As New SqlConnection(strConexion)
            Dim tsql As String = "SELECT idPaciente AS 'Código', primerNombre AS 'PrimerNombre', segundoNombre AS 'SegundoNombre', primerApellido AS 'PrimerApellido', segundoApellido AS 'SegundoApellido', CASE WHEN sexo = 0 THEN 'Femenino' WHEN sexo = 1 THEN 'Masculino' END AS 'Sexo', sexo AS 'SexoBooleano', fechaNacimiento AS 'FechaNacimiento', telefono AS 'Teléfono', correo AS 'Correo', direccion AS 'Dirección', cedula AS 'Cédula'
                                                     FROM Tbl_Cliente Where estado = 'True'"
            Dim da As New SqlDataAdapter(tsql, conn)
            da.Fill(ds)
        Catch ex As Exception
            MsgBox("Ocurrio un error al obtener los registros" & ex.Message, MsgBoxStyle.Critical, "ERROR")
        End Try
        Return ds
    End Function

    'Funcion para guardar un nuevo registro en la tabla Tbl_Paciente'
    Public Function guardarRegistro(ByVal paciente As Paciente) As Boolean
        Dim resultado = False
        Try
            Dim conn As New SqlConnection(strConexion)
            Dim tsql As String = "insert into Tbl_Cliente (primerNombre, segundoNombre, primerApellido, segundoApellido, sexo, fechaNacimiento, telefono, cedula, correo, direccion) 
                                  values (@primerNombre, @segundoNombre, @primerApellido, @segundoApellido, @sexo, @fechaNacimiento, @telefono, @cedula, @correo, @direccion)"
            Dim cmd As New SqlCommand(tsql, conn)
            cmd.Parameters.AddWithValue("@primerNombre", paciente.PrimerNombre)
            cmd.Parameters.AddWithValue("@segundoNombre", comprobarValorNull(paciente.SegundoNombre))
            cmd.Parameters.AddWithValue("@primerApellido", paciente.PrimerApellido)
            cmd.Parameters.AddWithValue("@segundoApellido", comprobarValorNull(paciente.SegundoApellido))
            cmd.Parameters.AddWithValue("@sexo", paciente.Sexo)
            cmd.Parameters.AddWithValue("@fechaNacimiento", paciente.FechaNac)
            cmd.Parameters.AddWithValue("@telefono", comprobarValorNull(paciente.Telefono))
            cmd.Parameters.AddWithValue("@cedula", paciente.Cedula)
            cmd.Parameters.AddWithValue("@correo", comprobarValorNull(paciente.Correo))
            cmd.Parameters.AddWithValue("@direccion", comprobarValorNull(paciente.Direccion))
            conn.Open()
            If (cmd.ExecuteNonQuery <> 0) Then
                resultado = True
            End If
            conn.Close()

        Catch ex As Exception
            MsgBox("Ocurrio un error al guardar el registro del paciente" & ex.Message, MsgBoxStyle.Critical, "ERROR")
        End Try
        Return resultado
    End Function

    'Funcion para editar un registro de la tabla Tbl_Paciente'
    Public Function editarRegistro(ByVal paciente As Paciente) As Boolean
        Dim resultado = False
        Try
            Dim conn As New SqlConnection(strConexion)
            Dim tsql As String = "update Tbl_Cliente set primerNombre = @primerNombre, segundoNombre = @segundoNombre, primerApellido = @primerApellido, segundoApellido = @segundoApellido, sexo = @sexo, fechaNacimiento = @fechaNac,
                                  telefono = @telefono, cedula = @cedula, correo = @correo, direccion = @direccion Where idPaciente = @idPaciente"
            Dim cmd As New SqlCommand(tsql, conn)
            cmd.Parameters.AddWithValue("@primerNombre", paciente.PrimerNombre)
            cmd.Parameters.AddWithValue("@segundoNombre", comprobarValorNull(paciente.SegundoNombre))
            cmd.Parameters.AddWithValue("@primerApellido", paciente.PrimerApellido)
            cmd.Parameters.AddWithValue("@segundoApellido", comprobarValorNull(paciente.SegundoApellido))
            cmd.Parameters.AddWithValue("@sexo", paciente.Sexo)
            cmd.Parameters.AddWithValue("@fechaNac", paciente.FechaNac)
            cmd.Parameters.AddWithValue("@telefono", paciente.Telefono)
            cmd.Parameters.AddWithValue("@cedula", paciente.Cedula)
            cmd.Parameters.AddWithValue("@correo", comprobarValorNull(paciente.Correo))
            cmd.Parameters.AddWithValue("@direccion", paciente.Direccion)
            cmd.Parameters.AddWithValue("@idPaciente", paciente.IdPaciente)

            conn.Open()
            If (cmd.ExecuteNonQuery <> 0) Then
                resultado = True
            End If
            conn.Close()

        Catch ex As Exception
            MsgBox("Ocurrio un error al editar el registro" & ex.Message, MsgBoxStyle.Critical, "ERROR")
        End Try
        Return resultado
    End Function


    'Funcion para eliminar un registro de la tabla Tbl_Categoria'
    Public Function eliminarRegistro(ByVal cedula As String) As Boolean
        Dim resultado = False
        Try
            Dim conn As New SqlConnection(strConexion)
            Dim tsql As String = "update Tbl_Cliente set estado = 'False' where cedula = @cedula"
            Dim cmd As New SqlCommand(tsql, conn)
            cmd.Parameters.AddWithValue("@cedula", cedula)

            conn.Open()
            If (cmd.ExecuteNonQuery <> 0) Then
                resultado = True
            End If
            conn.Close()

        Catch ex As Exception
            MsgBox("Ocurrio un error al eliminar el registro" & ex.Message, MsgBoxStyle.Critical, "ERROR")
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

    'Funcion para comprobar la existencia de un usuario ya registrado en el sistema'
    Public Function comprobarPaciente(ByVal paciente As Paciente) As Boolean
        Dim resultado = False
        Try
            Dim ds As New DataTable
            Dim conn As New SqlConnection(strConexion)
            Dim tsql As String = "select * from Tbl_Cliente where cedula = @cedula"
            Dim da As New SqlDataAdapter(tsql, conn)
            da.SelectCommand.Parameters.AddWithValue("@cedula", paciente.Cedula)
            da.Fill(ds)
            If (ds.Rows.Count > 0) Then Return True
        Catch ex As Exception
            MsgBox("Ocurrio un error al comprobar al comprobar la existencia del paciente", MsgBoxStyle.Critical, "ERROR")
        End Try
        Return resultado
    End Function
    Public Function buscarXNombre(ByVal nombre As String) As DataSet
        Dim ds As New DataSet
        nombre = nombre + "%"
        Try
            Dim conn As New SqlConnection(strConexion)
            Dim tsql As String = "SELECT idPaciente AS 'Código', primerNombre AS 'PrimerNombre', segundoNombre AS 'SegundoNombre', primerApellido AS 'PrimerApellido', segundoApellido AS 'SegundoApellido', CASE WHEN sexo = 0 THEN 'Femenino' WHEN sexo = 1 THEN 'Masculino' END AS 'Sexo', sexo AS 'SexoBooleano', fechaNacimiento AS 'FechaNacimiento', telefono AS 'Teléfono', correo AS 'Correo', direccion AS 'Dirección', cedula AS 'Cédula'
                                                     FROM Tbl_Cliente Where primerNombre like @primerNombre and estado = 'True'"
            Dim da As New SqlDataAdapter(tsql, conn)
            da.SelectCommand.Parameters.AddWithValue("@primerNombre", "%" + nombre + "%")
            da.Fill(ds)
        Catch ex As Exception
            MsgBox("Ocurrio un error al buscar el registro" & ex.Message, MsgBoxStyle.Critical, "ERROR")
        End Try
        Return ds
    End Function

    Public Function listaPacienteNombre(ByVal nombre As String) As DataSet
        Dim resultado As New DataSet
        Try
            Dim conn As New SqlConnection(strConexion)
            Dim tsql As String = "SELECT idPaciente , primerNombre , segundoNombre , primerApellido, segundoApellido , CASE WHEN sexo = 0 THEN 'Femenino' WHEN sexo = 1 THEN 'Masculino' END AS 'Sexo', sexo AS 'SexoBooleano', fechaNacimiento, telefono , correo , direccion , cedula 
                                                     FROM Tbl_Cliente Where estado = 'True' and primerNombre like @nombre"
            Dim da As New SqlDataAdapter(tsql, conn)
            da.SelectCommand.Parameters.AddWithValue("@nombre", "%" + nombre + "%")

            da.Fill(resultado)

        Catch ex As Exception
            MsgBox("Ocurrio un error al buscar el registro" & ex.Message, MsgBoxStyle.Critical, "ERROR")
        End Try
        Return resultado

    End Function

    Public Function listaPacienteCedula(ByVal cedulas As String) As DataSet

        Dim ds As New DataSet
        Try
            Dim conn As New SqlConnection(strConexion)
            Dim tsql As String = "SELECT idPaciente AS 'Código', primerNombre AS 'PrimerNombre', segundoNombre AS 'SegundoNombre', primerApellido AS 'PrimerApellido', segundoApellido AS 'SegundoApellido', CASE WHEN sexo = 0 THEN 'Femenino' WHEN sexo = 1 THEN 'Masculino' END AS 'Sexo', sexo AS 'SexoBooleano', fechaNacimiento AS 'FechaNacimiento', telefono AS 'Teléfono', correo AS 'Correo', direccion AS 'Dirección', cedula AS 'Cédula'
                                                     FROM Tbl_Cliente Where estado = 'True' and cedula like @cedula"
            Dim da As New SqlDataAdapter(tsql, conn)
            da.SelectCommand.Parameters.AddWithValue("@cedula", "%" + cedulas + "%")
            da.Fill(ds)

        Catch ex As Exception
            MsgBox("Ocurrio un error al buscar el registro" & ex.Message, MsgBoxStyle.Critical, "ERROR")
        End Try
        Return ds

    End Function

End Class

